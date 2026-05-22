using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppTMPro
{
	// Token: 0x02000052 RID: 82
	public class TMP_Text : MaskableGraphic
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x00024B10 File Offset: 0x00022D10
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Text()
		{
			Il2CppClassPointerStore<TMP_Text>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Text");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr);
			TMP_Text.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_text");
			TMP_Text.NativeFieldInfoPtr_m_IsTextBackingStringDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsTextBackingStringDirty");
			TMP_Text.NativeFieldInfoPtr_m_TextPreprocessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextPreprocessor");
			TMP_Text.NativeFieldInfoPtr_m_isRightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isRightToLeft");
			TMP_Text.NativeFieldInfoPtr_m_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontAsset");
			TMP_Text.NativeFieldInfoPtr_m_currentFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentFontAsset");
			TMP_Text.NativeFieldInfoPtr_m_isSDFShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isSDFShader");
			TMP_Text.NativeFieldInfoPtr_m_sharedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_sharedMaterial");
			TMP_Text.NativeFieldInfoPtr_m_currentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentMaterial");
			TMP_Text.NativeFieldInfoPtr_m_materialReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_materialReferences");
			TMP_Text.NativeFieldInfoPtr_m_materialReferenceIndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_materialReferenceIndexLookup");
			TMP_Text.NativeFieldInfoPtr_m_materialReferenceStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_materialReferenceStack");
			TMP_Text.NativeFieldInfoPtr_m_currentMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentMaterialIndex");
			TMP_Text.NativeFieldInfoPtr_m_fontSharedMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSharedMaterials");
			TMP_Text.NativeFieldInfoPtr_m_fontMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontMaterial");
			TMP_Text.NativeFieldInfoPtr_m_fontMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontMaterials");
			TMP_Text.NativeFieldInfoPtr_m_isMaterialDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isMaterialDirty");
			TMP_Text.NativeFieldInfoPtr_m_fontColor32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColor32");
			TMP_Text.NativeFieldInfoPtr_m_fontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColor");
			TMP_Text.NativeFieldInfoPtr_s_colorWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "s_colorWhite");
			TMP_Text.NativeFieldInfoPtr_m_underlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_underlineColor");
			TMP_Text.NativeFieldInfoPtr_m_strikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_strikethroughColor");
			TMP_Text.NativeFieldInfoPtr_m_enableVertexGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableVertexGradient");
			TMP_Text.NativeFieldInfoPtr_m_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorMode");
			TMP_Text.NativeFieldInfoPtr_m_fontColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColorGradient");
			TMP_Text.NativeFieldInfoPtr_m_fontColorGradientPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColorGradientPreset");
			TMP_Text.NativeFieldInfoPtr_m_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteAsset");
			TMP_Text.NativeFieldInfoPtr_m_tintAllSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_tintAllSprites");
			TMP_Text.NativeFieldInfoPtr_m_tintSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_tintSprite");
			TMP_Text.NativeFieldInfoPtr_m_spriteColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteColor");
			TMP_Text.NativeFieldInfoPtr_m_StyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_StyleSheet");
			TMP_Text.NativeFieldInfoPtr_m_TextStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyle");
			TMP_Text.NativeFieldInfoPtr_m_TextStyleHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyleHashCode");
			TMP_Text.NativeFieldInfoPtr_m_overrideHtmlColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_overrideHtmlColors");
			TMP_Text.NativeFieldInfoPtr_m_faceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_faceColor");
			TMP_Text.NativeFieldInfoPtr_m_outlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_outlineColor");
			TMP_Text.NativeFieldInfoPtr_m_outlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_outlineWidth");
			TMP_Text.NativeFieldInfoPtr_m_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSize");
			TMP_Text.NativeFieldInfoPtr_m_currentFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentFontSize");
			TMP_Text.NativeFieldInfoPtr_m_fontSizeBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSizeBase");
			TMP_Text.NativeFieldInfoPtr_m_sizeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_sizeStack");
			TMP_Text.NativeFieldInfoPtr_m_fontWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontWeight");
			TMP_Text.NativeFieldInfoPtr_m_FontWeightInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FontWeightInternal");
			TMP_Text.NativeFieldInfoPtr_m_FontWeightStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FontWeightStack");
			TMP_Text.NativeFieldInfoPtr_m_enableAutoSizing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableAutoSizing");
			TMP_Text.NativeFieldInfoPtr_m_maxFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxFontSize");
			TMP_Text.NativeFieldInfoPtr_m_minFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_minFontSize");
			TMP_Text.NativeFieldInfoPtr_m_AutoSizeIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_AutoSizeIterationCount");
			TMP_Text.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_AutoSizeMaxIterationCount");
			TMP_Text.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsAutoSizePointSizeSet");
			TMP_Text.NativeFieldInfoPtr_m_fontSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSizeMin");
			TMP_Text.NativeFieldInfoPtr_m_fontSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSizeMax");
			TMP_Text.NativeFieldInfoPtr_m_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontStyle");
			TMP_Text.NativeFieldInfoPtr_m_FontStyleInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FontStyleInternal");
			TMP_Text.NativeFieldInfoPtr_m_fontStyleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontStyleStack");
			TMP_Text.NativeFieldInfoPtr_m_isUsingBold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isUsingBold");
			TMP_Text.NativeFieldInfoPtr_m_HorizontalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_HorizontalAlignment");
			TMP_Text.NativeFieldInfoPtr_m_VerticalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_VerticalAlignment");
			TMP_Text.NativeFieldInfoPtr_m_textAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textAlignment");
			TMP_Text.NativeFieldInfoPtr_m_lineJustification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineJustification");
			TMP_Text.NativeFieldInfoPtr_m_lineJustificationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineJustificationStack");
			TMP_Text.NativeFieldInfoPtr_m_textContainerLocalCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textContainerLocalCorners");
			TMP_Text.NativeFieldInfoPtr_m_characterSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_characterSpacing");
			TMP_Text.NativeFieldInfoPtr_m_cSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_cSpacing");
			TMP_Text.NativeFieldInfoPtr_m_monoSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_monoSpacing");
			TMP_Text.NativeFieldInfoPtr_m_wordSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_wordSpacing");
			TMP_Text.NativeFieldInfoPtr_m_lineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineSpacing");
			TMP_Text.NativeFieldInfoPtr_m_lineSpacingDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineSpacingDelta");
			TMP_Text.NativeFieldInfoPtr_m_lineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineHeight");
			TMP_Text.NativeFieldInfoPtr_m_IsDrivenLineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsDrivenLineSpacing");
			TMP_Text.NativeFieldInfoPtr_m_lineSpacingMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineSpacingMax");
			TMP_Text.NativeFieldInfoPtr_m_paragraphSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_paragraphSpacing");
			TMP_Text.NativeFieldInfoPtr_m_charWidthMaxAdj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_charWidthMaxAdj");
			TMP_Text.NativeFieldInfoPtr_m_charWidthAdjDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_charWidthAdjDelta");
			TMP_Text.NativeFieldInfoPtr_m_enableWordWrapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableWordWrapping");
			TMP_Text.NativeFieldInfoPtr_m_isCharacterWrappingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isCharacterWrappingEnabled");
			TMP_Text.NativeFieldInfoPtr_m_isNonBreakingSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isNonBreakingSpace");
			TMP_Text.NativeFieldInfoPtr_m_isIgnoringAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isIgnoringAlignment");
			TMP_Text.NativeFieldInfoPtr_m_wordWrappingRatios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_wordWrappingRatios");
			TMP_Text.NativeFieldInfoPtr_m_overflowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_overflowMode");
			TMP_Text.NativeFieldInfoPtr_m_firstOverflowCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstOverflowCharacterIndex");
			TMP_Text.NativeFieldInfoPtr_m_linkedTextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_linkedTextComponent");
			TMP_Text.NativeFieldInfoPtr_parentLinkedComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "parentLinkedComponent");
			TMP_Text.NativeFieldInfoPtr_m_isTextTruncated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isTextTruncated");
			TMP_Text.NativeFieldInfoPtr_m_enableKerning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableKerning");
			TMP_Text.NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_GlyphHorizontalAdvanceAdjustment");
			TMP_Text.NativeFieldInfoPtr_m_enableExtraPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableExtraPadding");
			TMP_Text.NativeFieldInfoPtr_checkPaddingRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "checkPaddingRequired");
			TMP_Text.NativeFieldInfoPtr_m_isRichText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isRichText");
			TMP_Text.NativeFieldInfoPtr_m_parseCtrlCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_parseCtrlCharacters");
			TMP_Text.NativeFieldInfoPtr_m_isOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isOverlay");
			TMP_Text.NativeFieldInfoPtr_m_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isOrthographic");
			TMP_Text.NativeFieldInfoPtr_m_isCullingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isCullingEnabled");
			TMP_Text.NativeFieldInfoPtr_m_isMaskingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isMaskingEnabled");
			TMP_Text.NativeFieldInfoPtr_isMaskUpdateRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "isMaskUpdateRequired");
			TMP_Text.NativeFieldInfoPtr_m_ignoreCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ignoreCulling");
			TMP_Text.NativeFieldInfoPtr_m_horizontalMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_horizontalMapping");
			TMP_Text.NativeFieldInfoPtr_m_verticalMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_verticalMapping");
			TMP_Text.NativeFieldInfoPtr_m_uvLineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_uvLineOffset");
			TMP_Text.NativeFieldInfoPtr_m_renderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_renderMode");
			TMP_Text.NativeFieldInfoPtr_m_geometrySortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_geometrySortingOrder");
			TMP_Text.NativeFieldInfoPtr_m_IsTextObjectScaleStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsTextObjectScaleStatic");
			TMP_Text.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_VertexBufferAutoSizeReduction");
			TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstVisibleCharacter");
			TMP_Text.NativeFieldInfoPtr_m_maxVisibleCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxVisibleCharacters");
			TMP_Text.NativeFieldInfoPtr_m_maxVisibleWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxVisibleWords");
			TMP_Text.NativeFieldInfoPtr_m_maxVisibleLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxVisibleLines");
			TMP_Text.NativeFieldInfoPtr_m_useMaxVisibleDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_useMaxVisibleDescender");
			TMP_Text.NativeFieldInfoPtr_m_pageToDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_pageToDisplay");
			TMP_Text.NativeFieldInfoPtr_m_isNewPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isNewPage");
			TMP_Text.NativeFieldInfoPtr_m_margin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_margin");
			TMP_Text.NativeFieldInfoPtr_m_marginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginLeft");
			TMP_Text.NativeFieldInfoPtr_m_marginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginRight");
			TMP_Text.NativeFieldInfoPtr_m_marginWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginWidth");
			TMP_Text.NativeFieldInfoPtr_m_marginHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginHeight");
			TMP_Text.NativeFieldInfoPtr_m_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_width");
			TMP_Text.NativeFieldInfoPtr_m_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textInfo");
			TMP_Text.NativeFieldInfoPtr_m_havePropertiesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_havePropertiesChanged");
			TMP_Text.NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isUsingLegacyAnimationComponent");
			TMP_Text.NativeFieldInfoPtr_m_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_transform");
			TMP_Text.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_rectTransform");
			TMP_Text.NativeFieldInfoPtr_m_PreviousRectTransformSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_PreviousRectTransformSize");
			TMP_Text.NativeFieldInfoPtr_m_PreviousPivotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_PreviousPivotPosition");
			TMP_Text.NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "<autoSizeTextContainer>k__BackingField");
			TMP_Text.NativeFieldInfoPtr_m_autoSizeTextContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_autoSizeTextContainer");
			TMP_Text.NativeFieldInfoPtr_m_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_mesh");
			TMP_Text.NativeFieldInfoPtr_m_isVolumetricText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isVolumetricText");
			TMP_Text.NativeFieldInfoPtr_OnFontAssetRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "OnFontAssetRequest");
			TMP_Text.NativeFieldInfoPtr_OnSpriteAssetRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "OnSpriteAssetRequest");
			TMP_Text.NativeFieldInfoPtr_OnPreRenderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "OnPreRenderText");
			TMP_Text.NativeFieldInfoPtr_m_spriteAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteAnimator");
			TMP_Text.NativeFieldInfoPtr_m_flexibleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_flexibleHeight");
			TMP_Text.NativeFieldInfoPtr_m_flexibleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_flexibleWidth");
			TMP_Text.NativeFieldInfoPtr_m_minWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_minWidth");
			TMP_Text.NativeFieldInfoPtr_m_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_minHeight");
			TMP_Text.NativeFieldInfoPtr_m_maxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxWidth");
			TMP_Text.NativeFieldInfoPtr_m_maxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxHeight");
			TMP_Text.NativeFieldInfoPtr_m_LayoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_LayoutElement");
			TMP_Text.NativeFieldInfoPtr_m_preferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_preferredWidth");
			TMP_Text.NativeFieldInfoPtr_m_renderedWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_renderedWidth");
			TMP_Text.NativeFieldInfoPtr_m_isPreferredWidthDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isPreferredWidthDirty");
			TMP_Text.NativeFieldInfoPtr_m_preferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_preferredHeight");
			TMP_Text.NativeFieldInfoPtr_m_renderedHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_renderedHeight");
			TMP_Text.NativeFieldInfoPtr_m_isPreferredHeightDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isPreferredHeightDirty");
			TMP_Text.NativeFieldInfoPtr_m_isCalculatingPreferredValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isCalculatingPreferredValues");
			TMP_Text.NativeFieldInfoPtr_m_layoutPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_layoutPriority");
			TMP_Text.NativeFieldInfoPtr_m_isLayoutDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isLayoutDirty");
			TMP_Text.NativeFieldInfoPtr_m_isAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isAwake");
			TMP_Text.NativeFieldInfoPtr_m_isWaitingOnResourceLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isWaitingOnResourceLoad");
			TMP_Text.NativeFieldInfoPtr_m_inputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_inputSource");
			TMP_Text.NativeFieldInfoPtr_m_fontScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontScaleMultiplier");
			TMP_Text.NativeFieldInfoPtr_m_htmlTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_htmlTag");
			TMP_Text.NativeFieldInfoPtr_m_xmlAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_xmlAttribute");
			TMP_Text.NativeFieldInfoPtr_m_attributeParameterValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_attributeParameterValues");
			TMP_Text.NativeFieldInfoPtr_tag_LineIndent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "tag_LineIndent");
			TMP_Text.NativeFieldInfoPtr_tag_Indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "tag_Indent");
			TMP_Text.NativeFieldInfoPtr_m_indentStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_indentStack");
			TMP_Text.NativeFieldInfoPtr_tag_NoParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "tag_NoParsing");
			TMP_Text.NativeFieldInfoPtr_m_isParsingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isParsingText");
			TMP_Text.NativeFieldInfoPtr_m_FXMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FXMatrix");
			TMP_Text.NativeFieldInfoPtr_m_isFXMatrixSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isFXMatrixSet");
			TMP_Text.NativeFieldInfoPtr_m_TextProcessingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextProcessingArray");
			TMP_Text.NativeFieldInfoPtr_m_InternalTextProcessingArraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_InternalTextProcessingArraySize");
			TMP_Text.NativeFieldInfoPtr_m_internalCharacterInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_internalCharacterInfo");
			TMP_Text.NativeFieldInfoPtr_m_totalCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_totalCharacterCount");
			TMP_Text.NativeFieldInfoPtr_m_SavedWordWrapState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedWordWrapState");
			TMP_Text.NativeFieldInfoPtr_m_SavedLineState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedLineState");
			TMP_Text.NativeFieldInfoPtr_m_SavedEllipsisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedEllipsisState");
			TMP_Text.NativeFieldInfoPtr_m_SavedLastValidState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedLastValidState");
			TMP_Text.NativeFieldInfoPtr_m_SavedSoftLineBreakState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedSoftLineBreakState");
			TMP_Text.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_EllipsisInsertionCandidateStack");
			TMP_Text.NativeFieldInfoPtr_m_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_characterCount");
			TMP_Text.NativeFieldInfoPtr_m_firstCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstVisibleCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_lastCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lastCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_lastVisibleCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lastVisibleCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineNumber");
			TMP_Text.NativeFieldInfoPtr_m_lineVisibleCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineVisibleCharacterCount");
			TMP_Text.NativeFieldInfoPtr_m_pageNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_pageNumber");
			TMP_Text.NativeFieldInfoPtr_m_PageAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_PageAscender");
			TMP_Text.NativeFieldInfoPtr_m_maxTextAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxTextAscender");
			TMP_Text.NativeFieldInfoPtr_m_maxCapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxCapHeight");
			TMP_Text.NativeFieldInfoPtr_m_ElementAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ElementAscender");
			TMP_Text.NativeFieldInfoPtr_m_ElementDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ElementDescender");
			TMP_Text.NativeFieldInfoPtr_m_maxLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxLineAscender");
			TMP_Text.NativeFieldInfoPtr_m_maxLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxLineDescender");
			TMP_Text.NativeFieldInfoPtr_m_startOfLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_startOfLineAscender");
			TMP_Text.NativeFieldInfoPtr_m_startOfLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_startOfLineDescender");
			TMP_Text.NativeFieldInfoPtr_m_lineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineOffset");
			TMP_Text.NativeFieldInfoPtr_m_meshExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_meshExtents");
			TMP_Text.NativeFieldInfoPtr_m_htmlColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_htmlColor");
			TMP_Text.NativeFieldInfoPtr_m_colorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorStack");
			TMP_Text.NativeFieldInfoPtr_m_underlineColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_underlineColorStack");
			TMP_Text.NativeFieldInfoPtr_m_strikethroughColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_strikethroughColorStack");
			TMP_Text.NativeFieldInfoPtr_m_HighlightStateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_HighlightStateStack");
			TMP_Text.NativeFieldInfoPtr_m_colorGradientPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorGradientPreset");
			TMP_Text.NativeFieldInfoPtr_m_colorGradientStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorGradientStack");
			TMP_Text.NativeFieldInfoPtr_m_colorGradientPresetIsTinted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorGradientPresetIsTinted");
			TMP_Text.NativeFieldInfoPtr_m_tabSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_tabSpacing");
			TMP_Text.NativeFieldInfoPtr_m_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spacing");
			TMP_Text.NativeFieldInfoPtr_m_TextStyleStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyleStacks");
			TMP_Text.NativeFieldInfoPtr_m_TextStyleStackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyleStackDepth");
			TMP_Text.NativeFieldInfoPtr_m_ItalicAngleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ItalicAngleStack");
			TMP_Text.NativeFieldInfoPtr_m_ItalicAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ItalicAngle");
			TMP_Text.NativeFieldInfoPtr_m_actionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_actionStack");
			TMP_Text.NativeFieldInfoPtr_m_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_padding");
			TMP_Text.NativeFieldInfoPtr_m_baselineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_baselineOffset");
			TMP_Text.NativeFieldInfoPtr_m_baselineOffsetStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_baselineOffsetStack");
			TMP_Text.NativeFieldInfoPtr_m_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_xAdvance");
			TMP_Text.NativeFieldInfoPtr_m_textElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textElementType");
			TMP_Text.NativeFieldInfoPtr_m_cached_TextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_cached_TextElement");
			TMP_Text.NativeFieldInfoPtr_m_Ellipsis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_Ellipsis");
			TMP_Text.NativeFieldInfoPtr_m_Underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_Underline");
			TMP_Text.NativeFieldInfoPtr_m_defaultSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_defaultSpriteAsset");
			TMP_Text.NativeFieldInfoPtr_m_currentSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentSpriteAsset");
			TMP_Text.NativeFieldInfoPtr_m_spriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteCount");
			TMP_Text.NativeFieldInfoPtr_m_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteIndex");
			TMP_Text.NativeFieldInfoPtr_m_spriteAnimationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteAnimationID");
			TMP_Text.NativeFieldInfoPtr_k_ParseTextMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_ParseTextMarker");
			TMP_Text.NativeFieldInfoPtr_k_InsertNewLineMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_InsertNewLineMarker");
			TMP_Text.NativeFieldInfoPtr_m_ignoreActiveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ignoreActiveState");
			TMP_Text.NativeFieldInfoPtr_m_TextBackingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextBackingArray");
			TMP_Text.NativeFieldInfoPtr_k_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_Power");
			TMP_Text.NativeFieldInfoPtr_k_LargePositiveVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargePositiveVector2");
			TMP_Text.NativeFieldInfoPtr_k_LargeNegativeVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargeNegativeVector2");
			TMP_Text.NativeFieldInfoPtr_k_LargePositiveFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargePositiveFloat");
			TMP_Text.NativeFieldInfoPtr_k_LargeNegativeFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargeNegativeFloat");
			TMP_Text.NativeFieldInfoPtr_k_LargePositiveInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargePositiveInt");
			TMP_Text.NativeFieldInfoPtr_k_LargeNegativeInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargeNegativeInt");
			TMP_Text.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664242);
			TMP_Text.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664243);
			TMP_Text.NativeMethodInfoPtr_get_textPreprocessor_Public_get_ITextPreprocessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664244);
			TMP_Text.NativeMethodInfoPtr_set_textPreprocessor_Public_set_Void_ITextPreprocessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664245);
			TMP_Text.NativeMethodInfoPtr_get_isRightToLeftText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664246);
			TMP_Text.NativeMethodInfoPtr_set_isRightToLeftText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664247);
			TMP_Text.NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664248);
			TMP_Text.NativeMethodInfoPtr_set_font_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664249);
			TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664250);
			TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterial_Public_Virtual_New_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664251);
			TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664252);
			TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664253);
			TMP_Text.NativeMethodInfoPtr_get_fontMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664254);
			TMP_Text.NativeMethodInfoPtr_set_fontMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664255);
			TMP_Text.NativeMethodInfoPtr_get_fontMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664256);
			TMP_Text.NativeMethodInfoPtr_set_fontMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664257);
			TMP_Text.NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664258);
			TMP_Text.NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664259);
			TMP_Text.NativeMethodInfoPtr_get_alpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664260);
			TMP_Text.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664261);
			TMP_Text.NativeMethodInfoPtr_get_enableVertexGradient_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664262);
			TMP_Text.NativeMethodInfoPtr_set_enableVertexGradient_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664263);
			TMP_Text.NativeMethodInfoPtr_get_colorGradient_Public_get_VertexGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664264);
			TMP_Text.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_VertexGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664265);
			TMP_Text.NativeMethodInfoPtr_get_colorGradientPreset_Public_get_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664266);
			TMP_Text.NativeMethodInfoPtr_set_colorGradientPreset_Public_set_Void_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664267);
			TMP_Text.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664268);
			TMP_Text.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664269);
			TMP_Text.NativeMethodInfoPtr_get_tintAllSprites_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664270);
			TMP_Text.NativeMethodInfoPtr_set_tintAllSprites_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664271);
			TMP_Text.NativeMethodInfoPtr_get_styleSheet_Public_get_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664272);
			TMP_Text.NativeMethodInfoPtr_set_styleSheet_Public_set_Void_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664273);
			TMP_Text.NativeMethodInfoPtr_get_textStyle_Public_get_TMP_Style_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664274);
			TMP_Text.NativeMethodInfoPtr_set_textStyle_Public_set_Void_TMP_Style_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664275);
			TMP_Text.NativeMethodInfoPtr_get_overrideColorTags_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664276);
			TMP_Text.NativeMethodInfoPtr_set_overrideColorTags_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664277);
			TMP_Text.NativeMethodInfoPtr_get_faceColor_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664278);
			TMP_Text.NativeMethodInfoPtr_set_faceColor_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664279);
			TMP_Text.NativeMethodInfoPtr_get_outlineColor_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664280);
			TMP_Text.NativeMethodInfoPtr_set_outlineColor_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664281);
			TMP_Text.NativeMethodInfoPtr_get_outlineWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664282);
			TMP_Text.NativeMethodInfoPtr_set_outlineWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664283);
			TMP_Text.NativeMethodInfoPtr_get_fontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664284);
			TMP_Text.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664285);
			TMP_Text.NativeMethodInfoPtr_get_fontWeight_Public_get_FontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664286);
			TMP_Text.NativeMethodInfoPtr_set_fontWeight_Public_set_Void_FontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664287);
			TMP_Text.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664288);
			TMP_Text.NativeMethodInfoPtr_get_enableAutoSizing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664289);
			TMP_Text.NativeMethodInfoPtr_set_enableAutoSizing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664290);
			TMP_Text.NativeMethodInfoPtr_get_fontSizeMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664291);
			TMP_Text.NativeMethodInfoPtr_set_fontSizeMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664292);
			TMP_Text.NativeMethodInfoPtr_get_fontSizeMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664293);
			TMP_Text.NativeMethodInfoPtr_set_fontSizeMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664294);
			TMP_Text.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664295);
			TMP_Text.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664296);
			TMP_Text.NativeMethodInfoPtr_get_isUsingBold_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664297);
			TMP_Text.NativeMethodInfoPtr_get_horizontalAlignment_Public_get_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664298);
			TMP_Text.NativeMethodInfoPtr_set_horizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664299);
			TMP_Text.NativeMethodInfoPtr_get_verticalAlignment_Public_get_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664300);
			TMP_Text.NativeMethodInfoPtr_set_verticalAlignment_Public_set_Void_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664301);
			TMP_Text.NativeMethodInfoPtr_get_alignment_Public_get_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664302);
			TMP_Text.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664303);
			TMP_Text.NativeMethodInfoPtr_get_characterSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664304);
			TMP_Text.NativeMethodInfoPtr_set_characterSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664305);
			TMP_Text.NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664306);
			TMP_Text.NativeMethodInfoPtr_set_wordSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664307);
			TMP_Text.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664308);
			TMP_Text.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664309);
			TMP_Text.NativeMethodInfoPtr_get_lineSpacingAdjustment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664310);
			TMP_Text.NativeMethodInfoPtr_set_lineSpacingAdjustment_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664311);
			TMP_Text.NativeMethodInfoPtr_get_paragraphSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664312);
			TMP_Text.NativeMethodInfoPtr_set_paragraphSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664313);
			TMP_Text.NativeMethodInfoPtr_get_characterWidthAdjustment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664314);
			TMP_Text.NativeMethodInfoPtr_set_characterWidthAdjustment_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664315);
			TMP_Text.NativeMethodInfoPtr_get_enableWordWrapping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664316);
			TMP_Text.NativeMethodInfoPtr_set_enableWordWrapping_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664317);
			TMP_Text.NativeMethodInfoPtr_get_wordWrappingRatios_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664318);
			TMP_Text.NativeMethodInfoPtr_set_wordWrappingRatios_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664319);
			TMP_Text.NativeMethodInfoPtr_get_overflowMode_Public_get_TextOverflowModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664320);
			TMP_Text.NativeMethodInfoPtr_set_overflowMode_Public_set_Void_TextOverflowModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664321);
			TMP_Text.NativeMethodInfoPtr_get_isTextOverflowing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664322);
			TMP_Text.NativeMethodInfoPtr_get_firstOverflowCharacterIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664323);
			TMP_Text.NativeMethodInfoPtr_get_linkedTextComponent_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664324);
			TMP_Text.NativeMethodInfoPtr_set_linkedTextComponent_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664325);
			TMP_Text.NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664326);
			TMP_Text.NativeMethodInfoPtr_get_enableKerning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664327);
			TMP_Text.NativeMethodInfoPtr_set_enableKerning_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664328);
			TMP_Text.NativeMethodInfoPtr_get_extraPadding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664329);
			TMP_Text.NativeMethodInfoPtr_set_extraPadding_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664330);
			TMP_Text.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664331);
			TMP_Text.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664332);
			TMP_Text.NativeMethodInfoPtr_get_parseCtrlCharacters_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664333);
			TMP_Text.NativeMethodInfoPtr_set_parseCtrlCharacters_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664334);
			TMP_Text.NativeMethodInfoPtr_get_isOverlay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664335);
			TMP_Text.NativeMethodInfoPtr_set_isOverlay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664336);
			TMP_Text.NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664337);
			TMP_Text.NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664338);
			TMP_Text.NativeMethodInfoPtr_get_enableCulling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664339);
			TMP_Text.NativeMethodInfoPtr_set_enableCulling_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664340);
			TMP_Text.NativeMethodInfoPtr_get_ignoreVisibility_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664341);
			TMP_Text.NativeMethodInfoPtr_set_ignoreVisibility_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664342);
			TMP_Text.NativeMethodInfoPtr_get_horizontalMapping_Public_get_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664343);
			TMP_Text.NativeMethodInfoPtr_set_horizontalMapping_Public_set_Void_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664344);
			TMP_Text.NativeMethodInfoPtr_get_verticalMapping_Public_get_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664345);
			TMP_Text.NativeMethodInfoPtr_set_verticalMapping_Public_set_Void_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664346);
			TMP_Text.NativeMethodInfoPtr_get_mappingUvLineOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664347);
			TMP_Text.NativeMethodInfoPtr_set_mappingUvLineOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664348);
			TMP_Text.NativeMethodInfoPtr_get_renderMode_Public_get_TextRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664349);
			TMP_Text.NativeMethodInfoPtr_set_renderMode_Public_set_Void_TextRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664350);
			TMP_Text.NativeMethodInfoPtr_get_geometrySortingOrder_Public_get_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664351);
			TMP_Text.NativeMethodInfoPtr_set_geometrySortingOrder_Public_set_Void_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664352);
			TMP_Text.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664353);
			TMP_Text.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664354);
			TMP_Text.NativeMethodInfoPtr_get_vertexBufferAutoSizeReduction_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664355);
			TMP_Text.NativeMethodInfoPtr_set_vertexBufferAutoSizeReduction_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664356);
			TMP_Text.NativeMethodInfoPtr_get_firstVisibleCharacter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664357);
			TMP_Text.NativeMethodInfoPtr_set_firstVisibleCharacter_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664358);
			TMP_Text.NativeMethodInfoPtr_get_maxVisibleCharacters_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664359);
			TMP_Text.NativeMethodInfoPtr_set_maxVisibleCharacters_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664360);
			TMP_Text.NativeMethodInfoPtr_get_maxVisibleWords_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664361);
			TMP_Text.NativeMethodInfoPtr_set_maxVisibleWords_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664362);
			TMP_Text.NativeMethodInfoPtr_get_maxVisibleLines_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664363);
			TMP_Text.NativeMethodInfoPtr_set_maxVisibleLines_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664364);
			TMP_Text.NativeMethodInfoPtr_get_useMaxVisibleDescender_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664365);
			TMP_Text.NativeMethodInfoPtr_set_useMaxVisibleDescender_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664366);
			TMP_Text.NativeMethodInfoPtr_get_pageToDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664367);
			TMP_Text.NativeMethodInfoPtr_set_pageToDisplay_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664368);
			TMP_Text.NativeMethodInfoPtr_get_margin_Public_Virtual_New_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664369);
			TMP_Text.NativeMethodInfoPtr_set_margin_Public_Virtual_New_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664370);
			TMP_Text.NativeMethodInfoPtr_get_textInfo_Public_get_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664371);
			TMP_Text.NativeMethodInfoPtr_get_havePropertiesChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664372);
			TMP_Text.NativeMethodInfoPtr_set_havePropertiesChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664373);
			TMP_Text.NativeMethodInfoPtr_get_isUsingLegacyAnimationComponent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664374);
			TMP_Text.NativeMethodInfoPtr_set_isUsingLegacyAnimationComponent_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664375);
			TMP_Text.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664376);
			TMP_Text.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664377);
			TMP_Text.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664378);
			TMP_Text.NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664379);
			TMP_Text.NativeMethodInfoPtr_get_mesh_Public_Virtual_New_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664380);
			TMP_Text.NativeMethodInfoPtr_get_isVolumetricText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664381);
			TMP_Text.NativeMethodInfoPtr_set_isVolumetricText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664382);
			TMP_Text.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664383);
			TMP_Text.NativeMethodInfoPtr_get_textBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664384);
			TMP_Text.NativeMethodInfoPtr_add_OnFontAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664385);
			TMP_Text.NativeMethodInfoPtr_remove_OnFontAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664386);
			TMP_Text.NativeMethodInfoPtr_add_OnSpriteAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664387);
			TMP_Text.NativeMethodInfoPtr_remove_OnSpriteAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664388);
			TMP_Text.NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_New_add_Void_Action_1_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664389);
			TMP_Text.NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_New_rem_Void_Action_1_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664390);
			TMP_Text.NativeMethodInfoPtr_get_spriteAnimator_Protected_get_TMP_SpriteAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664391);
			TMP_Text.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664392);
			TMP_Text.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664393);
			TMP_Text.NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664394);
			TMP_Text.NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664395);
			TMP_Text.NativeMethodInfoPtr_get_maxWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664396);
			TMP_Text.NativeMethodInfoPtr_get_maxHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664397);
			TMP_Text.NativeMethodInfoPtr_get_layoutElement_Protected_get_LayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664398);
			TMP_Text.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664399);
			TMP_Text.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664400);
			TMP_Text.NativeMethodInfoPtr_get_renderedWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664401);
			TMP_Text.NativeMethodInfoPtr_get_renderedHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664402);
			TMP_Text.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664403);
			TMP_Text.NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664404);
			TMP_Text.NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664405);
			TMP_Text.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664406);
			TMP_Text.NativeMethodInfoPtr_SetFontBaseMaterial_Protected_Virtual_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664407);
			TMP_Text.NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664408);
			TMP_Text.NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_New_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664409);
			TMP_Text.NativeMethodInfoPtr_GetMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664410);
			TMP_Text.NativeMethodInfoPtr_CreateMaterialInstance_Protected_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664411);
			TMP_Text.NativeMethodInfoPtr_SetVertexColorGradient_Protected_Void_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664412);
			TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664413);
			TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664414);
			TMP_Text.NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_New_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664415);
			TMP_Text.NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_New_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664416);
			TMP_Text.NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664417);
			TMP_Text.NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664418);
			TMP_Text.NativeMethodInfoPtr_SetCulling_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664419);
			TMP_Text.NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664420);
			TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664421);
			TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664422);
			TMP_Text.NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664423);
			TMP_Text.NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_New_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664424);
			TMP_Text.NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_New_Void_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664425);
			TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_TMP_VertexDataUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664426);
			TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664427);
			TMP_Text.NativeMethodInfoPtr_SetVertices_Public_Virtual_New_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664428);
			TMP_Text.NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664429);
			TMP_Text.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_Void_Color_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664430);
			TMP_Text.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664431);
			TMP_Text.NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_New_Void_Color_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664432);
			TMP_Text.NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_New_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664433);
			TMP_Text.NativeMethodInfoPtr_ParseInputText_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664434);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664435);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664436);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664437);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664438);
			TMP_Text.NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664439);
			TMP_Text.NativeMethodInfoPtr_SetTextInternal_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664440);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664441);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664442);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664443);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664444);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664445);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664446);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664447);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664448);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664449);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664450);
			TMP_Text.NativeMethodInfoPtr_SetText_Private_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664451);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664452);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664453);
			TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664454);
			TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664455);
			TMP_Text.NativeMethodInfoPtr_GetStyle_Private_TMP_Style_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664456);
			TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664457);
			TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664458);
			TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_TextBackingContainer_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664459);
			TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_Int32_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664460);
			TMP_Text.NativeMethodInfoPtr_InsertOpeningStyleTag_Private_Boolean_TMP_Style_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664461);
			TMP_Text.NativeMethodInfoPtr_InsertClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664462);
			TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664463);
			TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664464);
			TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664465);
			TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_TextBackingContainer_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664466);
			TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664467);
			TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664468);
			TMP_Text.NativeMethodInfoPtr_AddFloatToInternalTextBackingArray_Private_Void_Single_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664469);
			TMP_Text.NativeMethodInfoPtr_AddIntegerToInternalTextBackingArray_Private_Void_Double_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664470);
			TMP_Text.NativeMethodInfoPtr_InternalTextBackingArrayToString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664471);
			TMP_Text.NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_New_Int32_Il2CppStructArray_1_UnicodeChar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664472);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664473);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664474);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664475);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664476);
			TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664477);
			TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Private_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664478);
			TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664479);
			TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Private_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664480);
			TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664481);
			TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664482);
			TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664483);
			TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Protected_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664484);
			TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664485);
			TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Protected_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664486);
			TMP_Text.NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664487);
			TMP_Text.NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_New_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664488);
			TMP_Text.NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_New_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664489);
			TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664490);
			TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664491);
			TMP_Text.NativeMethodInfoPtr_AdjustLineOffset_Protected_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664492);
			TMP_Text.NativeMethodInfoPtr_ResizeLineExtents_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664493);
			TMP_Text.NativeMethodInfoPtr_GetTextInfo_Public_Virtual_New_TMP_TextInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664494);
			TMP_Text.NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664495);
			TMP_Text.NativeMethodInfoPtr_InsertNewLine_Protected_Void_Int32_Single_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664496);
			TMP_Text.NativeMethodInfoPtr_SaveWordWrappingState_Protected_Void_byref_WordWrapState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664497);
			TMP_Text.NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664498);
			TMP_Text.NativeMethodInfoPtr_SaveGlyphVertexInfo_Protected_Virtual_New_Void_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664499);
			TMP_Text.NativeMethodInfoPtr_SaveSpriteVertexInfo_Protected_Virtual_New_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664500);
			TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664501);
			TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664502);
			TMP_Text.NativeMethodInfoPtr_FillSpriteVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664503);
			TMP_Text.NativeMethodInfoPtr_DrawUnderlineMesh_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664504);
			TMP_Text.NativeMethodInfoPtr_DrawTextHighlight_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664505);
			TMP_Text.NativeMethodInfoPtr_LoadDefaultSettings_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664506);
			TMP_Text.NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664507);
			TMP_Text.NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664508);
			TMP_Text.NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664509);
			TMP_Text.NativeMethodInfoPtr_ReplaceTagWithCharacter_Protected_Void_Il2CppStructArray_1_Int32_Int32_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664510);
			TMP_Text.NativeMethodInfoPtr_GetFontAssetForWeight_Protected_TMP_FontAsset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664511);
			TMP_Text.NativeMethodInfoPtr_GetTextElement_Internal_TMP_TextElement_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664512);
			TMP_Text.NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664513);
			TMP_Text.NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664514);
			TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664515);
			TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664516);
			TMP_Text.NativeMethodInfoPtr_GetParsedText_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664517);
			TMP_Text.NativeMethodInfoPtr_IsSelfOrLinkedAncestor_Internal_Boolean_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664518);
			TMP_Text.NativeMethodInfoPtr_ReleaseLinkedTextComponent_Internal_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664519);
			TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664520);
			TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664521);
			TMP_Text.NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664522);
			TMP_Text.NativeMethodInfoPtr_HexToInt_Protected_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664523);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664524);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664525);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664526);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664527);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Private_Int32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664528);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664529);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664530);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664531);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664532);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Private_Int32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664533);
			TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664534);
			TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664535);
			TMP_Text.NativeMethodInfoPtr_GetAttributeParameters_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664536);
			TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664537);
			TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664538);
			TMP_Text.NativeMethodInfoPtr_ValidateHtmlTag_Internal_Boolean_Il2CppStructArray_1_UnicodeChar_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664539);
			TMP_Text.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664540);
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00027480 File Offset: 0x00025680
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x000274C4 File Offset: 0x000256C4
		public unsafe virtual string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00027514 File Offset: 0x00025714
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00027554 File Offset: 0x00025754
		public unsafe ITextPreprocessor textPreprocessor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textPreprocessor_Public_get_ITextPreprocessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextPreprocessor>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_textPreprocessor_Public_set_Void_ITextPreprocessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00027598 File Offset: 0x00025798
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x000275D4 File Offset: 0x000257D4
		public unsafe bool isRightToLeftText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isRightToLeftText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isRightToLeftText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00027614 File Offset: 0x00025814
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00027654 File Offset: 0x00025854
		public unsafe TMP_FontAsset font
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 460786, RefRangeEnd = 460791, XrefRangeStart = 460770, XrefRangeEnd = 460786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_font_Public_set_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00027698 File Offset: 0x00025898
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x000276E4 File Offset: 0x000258E4
		public unsafe virtual Material fontSharedMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460791, XrefRangeEnd = 460807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterial_Public_Virtual_New_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00027734 File Offset: 0x00025934
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00027780 File Offset: 0x00025980
		public unsafe virtual Il2CppReferenceArray<Material> fontSharedMaterials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x000277D0 File Offset: 0x000259D0
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00027810 File Offset: 0x00025A10
		public unsafe Material fontMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460807, XrefRangeEnd = 460821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00027854 File Offset: 0x00025A54
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x000278A0 File Offset: 0x00025AA0
		public unsafe virtual Il2CppReferenceArray<Material> fontMaterials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_fontMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_fontMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x000278F0 File Offset: 0x00025AF0
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00027938 File Offset: 0x00025B38
		public unsafe override Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00027984 File Offset: 0x00025B84
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x000279C0 File Offset: 0x00025BC0
		public unsafe float alpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_alpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00027A00 File Offset: 0x00025C00
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x00027A3C File Offset: 0x00025C3C
		public unsafe bool enableVertexGradient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableVertexGradient_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableVertexGradient_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00027A7C File Offset: 0x00025C7C
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x00027AB8 File Offset: 0x00025CB8
		public unsafe VertexGradient colorGradient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_colorGradient_Public_get_VertexGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_VertexGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00027AF8 File Offset: 0x00025CF8
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x00027B38 File Offset: 0x00025D38
		public unsafe TMP_ColorGradient colorGradientPreset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_colorGradientPreset_Public_get_TMP_ColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_ColorGradient>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_colorGradientPreset_Public_set_Void_TMP_ColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00027B7C File Offset: 0x00025D7C
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00027BBC File Offset: 0x00025DBC
		public unsafe TMP_SpriteAsset spriteAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00027C00 File Offset: 0x00025E00
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00027C3C File Offset: 0x00025E3C
		public unsafe bool tintAllSprites
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_tintAllSprites_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_tintAllSprites_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00027C7C File Offset: 0x00025E7C
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00027CBC File Offset: 0x00025EBC
		public unsafe TMP_StyleSheet styleSheet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_styleSheet_Public_get_TMP_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_styleSheet_Public_set_Void_TMP_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00027D00 File Offset: 0x00025F00
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00027D40 File Offset: 0x00025F40
		public unsafe TMP_Style textStyle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 460832, RefRangeEnd = 460834, XrefRangeStart = 460821, XrefRangeEnd = 460832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textStyle_Public_get_TMP_Style_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460834, XrefRangeEnd = 460835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_textStyle_Public_set_Void_TMP_Style_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00027D84 File Offset: 0x00025F84
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x00027DC0 File Offset: 0x00025FC0
		public unsafe bool overrideColorTags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_overrideColorTags_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_overrideColorTags_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00027E00 File Offset: 0x00026000
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00027E3C File Offset: 0x0002603C
		public unsafe Color32 faceColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460835, XrefRangeEnd = 460854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_faceColor_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_faceColor_Public_set_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00027E7C File Offset: 0x0002607C
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00027EB8 File Offset: 0x000260B8
		public unsafe Color32 outlineColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460854, XrefRangeEnd = 460873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_outlineColor_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_outlineColor_Public_set_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00027EF8 File Offset: 0x000260F8
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x00027F34 File Offset: 0x00026134
		public unsafe float outlineWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460873, XrefRangeEnd = 460891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_outlineWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_outlineWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00027F74 File Offset: 0x00026174
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x00027FB0 File Offset: 0x000261B0
		public unsafe float fontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 460891, RefRangeEnd = 460895, XrefRangeStart = 460891, XrefRangeEnd = 460891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00027FF0 File Offset: 0x000261F0
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x0002802C File Offset: 0x0002622C
		public unsafe FontWeight fontWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontWeight_Public_get_FontWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontWeight_Public_set_Void_FontWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0002806C File Offset: 0x0002626C
		public unsafe float pixelsPerUnit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460895, XrefRangeEnd = 460914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x000280A8 File Offset: 0x000262A8
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x000280E4 File Offset: 0x000262E4
		public unsafe bool enableAutoSizing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableAutoSizing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableAutoSizing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00028124 File Offset: 0x00026324
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00028160 File Offset: 0x00026360
		public unsafe float fontSizeMin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontSizeMin_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontSizeMin_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x000281A0 File Offset: 0x000263A0
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x000281DC File Offset: 0x000263DC
		public unsafe float fontSizeMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontSizeMax_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontSizeMax_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x0002821C File Offset: 0x0002641C
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00028258 File Offset: 0x00026458
		public unsafe FontStyles fontStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00028298 File Offset: 0x00026498
		public unsafe bool isUsingBold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isUsingBold_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x000282D4 File Offset: 0x000264D4
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00028310 File Offset: 0x00026510
		public unsafe HorizontalAlignmentOptions horizontalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_horizontalAlignment_Public_get_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_horizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00028350 File Offset: 0x00026550
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x0002838C File Offset: 0x0002658C
		public unsafe VerticalAlignmentOptions verticalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_verticalAlignment_Public_get_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_verticalAlignment_Public_set_Void_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x000283CC File Offset: 0x000265CC
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x00028408 File Offset: 0x00026608
		public unsafe TextAlignmentOptions alignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_alignment_Public_get_TextAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00028448 File Offset: 0x00026648
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x00028484 File Offset: 0x00026684
		public unsafe float characterSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_characterSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_characterSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x000284C4 File Offset: 0x000266C4
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x00028500 File Offset: 0x00026700
		public unsafe float wordSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_wordSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00028540 File Offset: 0x00026740
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x0002857C File Offset: 0x0002677C
		public unsafe float lineSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x000285BC File Offset: 0x000267BC
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x000285F8 File Offset: 0x000267F8
		public unsafe float lineSpacingAdjustment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_lineSpacingAdjustment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_lineSpacingAdjustment_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00028638 File Offset: 0x00026838
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x00028674 File Offset: 0x00026874
		public unsafe float paragraphSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_paragraphSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_paragraphSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x000286B4 File Offset: 0x000268B4
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x000286F0 File Offset: 0x000268F0
		public unsafe float characterWidthAdjustment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_characterWidthAdjustment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_characterWidthAdjustment_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00028730 File Offset: 0x00026930
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x0002876C File Offset: 0x0002696C
		public unsafe bool enableWordWrapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableWordWrapping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableWordWrapping_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x000287AC File Offset: 0x000269AC
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x000287E8 File Offset: 0x000269E8
		public unsafe float wordWrappingRatios
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_wordWrappingRatios_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_wordWrappingRatios_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00028828 File Offset: 0x00026A28
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x00028864 File Offset: 0x00026A64
		public unsafe TextOverflowModes overflowMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_overflowMode_Public_get_TextOverflowModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_overflowMode_Public_set_Void_TextOverflowModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x000288A4 File Offset: 0x00026AA4
		public unsafe bool isTextOverflowing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isTextOverflowing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x000288E0 File Offset: 0x00026AE0
		public unsafe int firstOverflowCharacterIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_firstOverflowCharacterIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x0002891C File Offset: 0x00026B1C
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x0002895C File Offset: 0x00026B5C
		public unsafe TMP_Text linkedTextComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_linkedTextComponent_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 460932, RefRangeEnd = 460933, XrefRangeStart = 460914, XrefRangeEnd = 460932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_linkedTextComponent_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x000289A0 File Offset: 0x00026BA0
		public unsafe bool isTextTruncated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x000289DC File Offset: 0x00026BDC
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00028A18 File Offset: 0x00026C18
		public unsafe bool enableKerning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableKerning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableKerning_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00028A58 File Offset: 0x00026C58
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00028A94 File Offset: 0x00026C94
		public unsafe bool extraPadding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_extraPadding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_extraPadding_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00028AD4 File Offset: 0x00026CD4
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00028B10 File Offset: 0x00026D10
		public unsafe bool richText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00028B50 File Offset: 0x00026D50
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00028B8C File Offset: 0x00026D8C
		public unsafe bool parseCtrlCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_parseCtrlCharacters_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_parseCtrlCharacters_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00028BCC File Offset: 0x00026DCC
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00028C08 File Offset: 0x00026E08
		public unsafe bool isOverlay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isOverlay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isOverlay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00028C48 File Offset: 0x00026E48
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00028C84 File Offset: 0x00026E84
		public unsafe bool isOrthographic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00028CC4 File Offset: 0x00026EC4
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00028D00 File Offset: 0x00026F00
		public unsafe bool enableCulling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableCulling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableCulling_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00028D40 File Offset: 0x00026F40
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00028D7C File Offset: 0x00026F7C
		public unsafe bool ignoreVisibility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_ignoreVisibility_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_ignoreVisibility_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00028DBC File Offset: 0x00026FBC
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00028DF8 File Offset: 0x00026FF8
		public unsafe TextureMappingOptions horizontalMapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_horizontalMapping_Public_get_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_horizontalMapping_Public_set_Void_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00028E38 File Offset: 0x00027038
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00028E74 File Offset: 0x00027074
		public unsafe TextureMappingOptions verticalMapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_verticalMapping_Public_get_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_verticalMapping_Public_set_Void_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00028EB4 File Offset: 0x000270B4
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00028EF0 File Offset: 0x000270F0
		public unsafe float mappingUvLineOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_mappingUvLineOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_mappingUvLineOffset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00028F30 File Offset: 0x00027130
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00028F6C File Offset: 0x0002716C
		public unsafe TextRenderFlags renderMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_renderMode_Public_get_TextRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_renderMode_Public_set_Void_TextRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00028FAC File Offset: 0x000271AC
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00028FE8 File Offset: 0x000271E8
		public unsafe VertexSortingOrder geometrySortingOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_geometrySortingOrder_Public_get_VertexSortingOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_geometrySortingOrder_Public_set_Void_VertexSortingOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00029028 File Offset: 0x00027228
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x00029064 File Offset: 0x00027264
		public unsafe bool isTextObjectScaleStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460933, XrefRangeEnd = 460939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x000290A4 File Offset: 0x000272A4
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x000290E0 File Offset: 0x000272E0
		public unsafe bool vertexBufferAutoSizeReduction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_vertexBufferAutoSizeReduction_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_vertexBufferAutoSizeReduction_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00029120 File Offset: 0x00027320
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x0002915C File Offset: 0x0002735C
		public unsafe int firstVisibleCharacter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_firstVisibleCharacter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 460939, RefRangeEnd = 460941, XrefRangeStart = 460939, XrefRangeEnd = 460939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_firstVisibleCharacter_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0002919C File Offset: 0x0002739C
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x000291D8 File Offset: 0x000273D8
		public unsafe int maxVisibleCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxVisibleCharacters_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_maxVisibleCharacters_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00029218 File Offset: 0x00027418
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00029254 File Offset: 0x00027454
		public unsafe int maxVisibleWords
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxVisibleWords_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_maxVisibleWords_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00029294 File Offset: 0x00027494
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x000292D0 File Offset: 0x000274D0
		public unsafe int maxVisibleLines
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxVisibleLines_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_maxVisibleLines_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00029310 File Offset: 0x00027510
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x0002934C File Offset: 0x0002754C
		public unsafe bool useMaxVisibleDescender
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_useMaxVisibleDescender_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_useMaxVisibleDescender_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0002938C File Offset: 0x0002758C
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x000293C8 File Offset: 0x000275C8
		public unsafe int pageToDisplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_pageToDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_pageToDisplay_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00029408 File Offset: 0x00027608
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00029450 File Offset: 0x00027650
		public unsafe virtual Vector4 margin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_margin_Public_Virtual_New_get_Vector4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_margin_Public_Virtual_New_set_Void_Vector4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0002949C File Offset: 0x0002769C
		public unsafe TMP_TextInfo textInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textInfo_Public_get_TMP_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x000294DC File Offset: 0x000276DC
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x00029518 File Offset: 0x00027718
		public unsafe bool havePropertiesChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_havePropertiesChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_havePropertiesChanged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x00029558 File Offset: 0x00027758
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x00029594 File Offset: 0x00027794
		public unsafe bool isUsingLegacyAnimationComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isUsingLegacyAnimationComponent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isUsingLegacyAnimationComponent_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x000295D4 File Offset: 0x000277D4
		public new unsafe Transform transform
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 460956, RefRangeEnd = 460962, XrefRangeStart = 460941, XrefRangeEnd = 460956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00029614 File Offset: 0x00027814
		public new unsafe RectTransform rectTransform
		{
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 460977, RefRangeEnd = 461031, XrefRangeStart = 460962, XrefRangeEnd = 460977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00029654 File Offset: 0x00027854
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x0002969C File Offset: 0x0002789C
		public unsafe virtual bool autoSizeTextContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x000296E8 File Offset: 0x000278E8
		public unsafe virtual Mesh mesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_mesh_Public_Virtual_New_get_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00029734 File Offset: 0x00027934
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x00029770 File Offset: 0x00027970
		public unsafe bool isVolumetricText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isVolumetricText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461031, XrefRangeEnd = 461033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isVolumetricText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x000297B0 File Offset: 0x000279B0
		public unsafe Bounds bounds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461033, XrefRangeEnd = 461045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x000297EC File Offset: 0x000279EC
		public unsafe Bounds textBounds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461045, XrefRangeEnd = 461046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00029828 File Offset: 0x00027A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461046, XrefRangeEnd = 461056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_add_OnFontAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00029860 File Offset: 0x00027A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461056, XrefRangeEnd = 461066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_remove_OnFontAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00029898 File Offset: 0x00027A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461066, XrefRangeEnd = 461076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_add_OnSpriteAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000298D0 File Offset: 0x00027AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461076, XrefRangeEnd = 461086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_remove_OnSpriteAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00029908 File Offset: 0x00027B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461086, XrefRangeEnd = 461089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_OnPreRenderText(Action<TMP_TextInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_New_add_Void_Action_1_TMP_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00029958 File Offset: 0x00027B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461089, XrefRangeEnd = 461092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_New_rem_Void_Action_1_TMP_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x000299A8 File Offset: 0x00027BA8
		public unsafe TMP_SpriteAnimator spriteAnimator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461092, XrefRangeEnd = 461124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_spriteAnimator_Protected_get_TMP_SpriteAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAnimator>(intPtr3) : null;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x000299E8 File Offset: 0x00027BE8
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00029A24 File Offset: 0x00027C24
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00029A60 File Offset: 0x00027C60
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00029A9C File Offset: 0x00027C9C
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00029AD8 File Offset: 0x00027CD8
		public unsafe float maxWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00029B14 File Offset: 0x00027D14
		public unsafe float maxHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00029B50 File Offset: 0x00027D50
		public unsafe LayoutElement layoutElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461124, XrefRangeEnd = 461139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_layoutElement_Protected_get_LayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr3) : null;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00029B90 File Offset: 0x00027D90
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461139, XrefRangeEnd = 461140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00029BD8 File Offset: 0x00027DD8
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461140, XrefRangeEnd = 461141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x00029C20 File Offset: 0x00027E20
		public unsafe virtual float renderedWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461141, XrefRangeEnd = 461142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_renderedWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00029C68 File Offset: 0x00027E68
		public unsafe virtual float renderedHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461142, XrefRangeEnd = 461143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_renderedHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00029CB0 File Offset: 0x00027EB0
		public unsafe virtual int layoutPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00029CEC File Offset: 0x00027EEC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadFontAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00029D28 File Offset: 0x00027F28
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSharedMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_New_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00029D78 File Offset: 0x00027F78
		[CallerCount(0)]
		public unsafe virtual Material GetMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00029DD4 File Offset: 0x00027FD4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetFontBaseMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetFontBaseMaterial_Protected_Virtual_New_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00029E24 File Offset: 0x00028024
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Material> GetSharedMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00029E70 File Offset: 0x00028070
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSharedMaterials(Il2CppReferenceArray<Material> materials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_New_Void_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00029EC0 File Offset: 0x000280C0
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Material> GetMaterials(Il2CppReferenceArray<Material> mats)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mats);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00029F1C File Offset: 0x0002811C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461143, XrefRangeEnd = 461156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Material CreateMaterialInstance(Material source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CreateMaterialInstance_Protected_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00029F78 File Offset: 0x00028178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461156, XrefRangeEnd = 461168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexColorGradient(TMP_ColorGradient gradient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gradient);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetVertexColorGradient_Protected_Void_TMP_ColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00029FBC File Offset: 0x000281BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextSortingOrder(VertexSortingOrder order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_VertexSortingOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00029FFC File Offset: 0x000281FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextSortingOrder(Il2CppStructArray<int> order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(order);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0002A040 File Offset: 0x00028240
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetFaceColor(Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_New_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0002A08C File Offset: 0x0002828C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOutlineColor(Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_New_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0002A0D8 File Offset: 0x000282D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOutlineThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thickness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0002A124 File Offset: 0x00028324
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetShaderDepth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0002A160 File Offset: 0x00028360
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetCulling_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0002A19C File Offset: 0x0002839C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0002A1D8 File Offset: 0x000283D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461168, XrefRangeEnd = 461191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetPaddingForMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0002A220 File Offset: 0x00028420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461191, XrefRangeEnd = 461211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetPaddingForMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0002A278 File Offset: 0x00028478
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<Vector3> GetTextContainerLocalCorners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0002A2C4 File Offset: 0x000284C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreActiveState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceTextReparsing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_New_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0002A31C File Offset: 0x0002851C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateGeometry(Mesh mesh, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_New_Void_Mesh_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0002A378 File Offset: 0x00028578
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_TMP_VertexDataUpdateFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0002A3C4 File Offset: 0x000285C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVertexData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0002A400 File Offset: 0x00028600
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVertices(Il2CppStructArray<Vector3> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetVertices_Public_Virtual_New_Void_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0002A450 File Offset: 0x00028650
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMeshPadding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0002A48C File Offset: 0x0002868C
		[CallerCount(0)]
		public unsafe override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_Void_Color_Single_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0002A500 File Offset: 0x00028700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461211, XrefRangeEnd = 461214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_Void_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0002A568 File Offset: 0x00028768
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_New_Void_Color_Single_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0002A5DC File Offset: 0x000287DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_New_Void_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0002A644 File Offset: 0x00028844
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 461220, RefRangeEnd = 461225, XrefRangeStart = 461214, XrefRangeEnd = 461220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseInputText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ParseInputText_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0002A678 File Offset: 0x00028878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461225, XrefRangeEnd = 461227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(string sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0002A6BC File Offset: 0x000288BC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 461233, RefRangeEnd = 461239, XrefRangeStart = 461227, XrefRangeEnd = 461233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(string sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0002A71C File Offset: 0x0002891C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 461246, RefRangeEnd = 461248, XrefRangeStart = 461239, XrefRangeEnd = 461246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(StringBuilder sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0002A77C File Offset: 0x0002897C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 461254, RefRangeEnd = 461258, XrefRangeStart = 461248, XrefRangeEnd = 461254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(Il2CppStructArray<char> sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0002A7DC File Offset: 0x000289DC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 461309, RefRangeEnd = 461321, XrefRangeStart = 461258, XrefRangeEnd = 461309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextProcessingArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0002A810 File Offset: 0x00028A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461321, XrefRangeEnd = 461324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextInternal(string sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetTextInternal_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0002A854 File Offset: 0x00028A54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 461327, RefRangeEnd = 461329, XrefRangeStart = 461324, XrefRangeEnd = 461327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, bool syncTextInputBox = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref syncTextInputBox;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0002A8A4 File Offset: 0x00028AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461329, XrefRangeEnd = 461330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0002A8F4 File Offset: 0x00028AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461330, XrefRangeEnd = 461331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0002A954 File Offset: 0x00028B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461331, XrefRangeEnd = 461332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0002A9C0 File Offset: 0x00028BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461332, XrefRangeEnd = 461333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0002AA3C File Offset: 0x00028C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461333, XrefRangeEnd = 461334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0002AAC4 File Offset: 0x00028CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461334, XrefRangeEnd = 461335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0002AB5C File Offset: 0x00028D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461335, XrefRangeEnd = 461336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg5;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg6;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0002AC00 File Offset: 0x00028E00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 461363, RefRangeEnd = 461370, XrefRangeStart = 461336, XrefRangeEnd = 461363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg5;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg6;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0002ACB4 File Offset: 0x00028EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461370, XrefRangeEnd = 461373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(StringBuilder sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0002ACF8 File Offset: 0x00028EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461373, XrefRangeEnd = 461375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(StringBuilder sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Private_Void_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0002AD58 File Offset: 0x00028F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461375, XrefRangeEnd = 461378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(Il2CppStructArray<char> sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0002AD9C File Offset: 0x00028F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461378, XrefRangeEnd = 461380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(Il2CppStructArray<char> sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0002ADFC File Offset: 0x00028FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCharArray(Il2CppStructArray<char> sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0002AE40 File Offset: 0x00029040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCharArray(Il2CppStructArray<char> sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0002AEA0 File Offset: 0x000290A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 461407, RefRangeEnd = 461413, XrefRangeStart = 461380, XrefRangeEnd = 461407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Style GetStyle(int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetStyle_Private_TMP_Style_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0002AEEC File Offset: 0x000290EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461440, RefRangeEnd = 461441, XrefRangeStart = 461413, XrefRangeEnd = 461440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReplaceOpeningStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sourceText));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &srcOffset;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0002AF98 File Offset: 0x00029198
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 461468, RefRangeEnd = 461474, XrefRangeStart = 461441, XrefRangeEnd = 461468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReplaceOpeningStyleTag(ref Il2CppStructArray<int> sourceText, int srcIndex, out int srcOffset, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &srcOffset;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			sourceText = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0002B054 File Offset: 0x00029254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461495, RefRangeEnd = 461496, XrefRangeStart = 461474, XrefRangeEnd = 461495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceClosingStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sourceText));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_TextBackingContainer_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0002B0E0 File Offset: 0x000292E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 461517, RefRangeEnd = 461523, XrefRangeStart = 461496, XrefRangeEnd = 461517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceClosingStyleTag(ref Il2CppStructArray<int> sourceText, int srcIndex, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_Int32_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			sourceText = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr6));
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0002B180 File Offset: 0x00029380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461544, RefRangeEnd = 461545, XrefRangeStart = 461523, XrefRangeEnd = 461544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InsertOpeningStyleTag_Private_Boolean_TMP_Style_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0002B214 File Offset: 0x00029414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461566, RefRangeEnd = 461567, XrefRangeStart = 461545, XrefRangeEnd = 461566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertClosingStyleTag(ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InsertClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0002B27C File Offset: 0x0002947C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 461571, RefRangeEnd = 461577, XrefRangeStart = 461567, XrefRangeEnd = 461571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMarkupTagHashCode(Il2CppStructArray<int> tagDefinition, int readIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tagDefinition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0002B2D8 File Offset: 0x000294D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461581, RefRangeEnd = 461582, XrefRangeStart = 461577, XrefRangeEnd = 461581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMarkupTagHashCode(TMP_Text.TextBackingContainer tagDefinition, int readIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tagDefinition));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_TextBackingContainer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0002B338 File Offset: 0x00029538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461582, XrefRangeEnd = 461587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStyleHashCode(ref Il2CppStructArray<int> text, int index, out int closeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(text);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			text = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0002B3B8 File Offset: 0x000295B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461587, XrefRangeEnd = 461592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStyleHashCode(ref TMP_Text.TextBackingContainer text, int index, out int closeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_TextBackingContainer_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0002B428 File Offset: 0x00029628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461592, XrefRangeEnd = 461597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeInternalArray<T>(ref Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0002B480 File Offset: 0x00029680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461597, XrefRangeEnd = 461601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeInternalArray<T>(ref Il2CppArrayBase<T> array, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0002B4E8 File Offset: 0x000296E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461660, RefRangeEnd = 461661, XrefRangeStart = 461601, XrefRangeEnd = 461660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_AddFloatToInternalTextBackingArray_Private_Void_Single_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0002B554 File Offset: 0x00029754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461665, RefRangeEnd = 461666, XrefRangeStart = 461661, XrefRangeEnd = 461665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_AddIntegerToInternalTextBackingArray_Private_Void_Double_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0002B5B0 File Offset: 0x000297B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461666, XrefRangeEnd = 461676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalTextBackingArrayToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InternalTextBackingArrayToString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0002B5E8 File Offset: 0x000297E8
		[CallerCount(0)]
		public unsafe virtual int SetArraySizes(Il2CppStructArray<TMP_Text.UnicodeChar> unicodeChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodeChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_New_Int32_Il2CppStructArray_1_UnicodeChar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0002B640 File Offset: 0x00029840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461676, XrefRangeEnd = 461678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0002B67C File Offset: 0x0002987C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461678, XrefRangeEnd = 461681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues(float width, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0002B6D4 File Offset: 0x000298D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461681, XrefRangeEnd = 461690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0002B724 File Offset: 0x00029924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461690, XrefRangeEnd = 461695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues(string text, float width, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0002B790 File Offset: 0x00029990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 461714, RefRangeEnd = 461716, XrefRangeStart = 461695, XrefRangeEnd = 461714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0002B7CC File Offset: 0x000299CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 461717, RefRangeEnd = 461720, XrefRangeStart = 461716, XrefRangeEnd = 461717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredWidth(Vector2 margin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref margin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Private_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0002B818 File Offset: 0x00029A18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 461743, RefRangeEnd = 461745, XrefRangeStart = 461720, XrefRangeEnd = 461743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0002B854 File Offset: 0x00029A54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 461746, RefRangeEnd = 461749, XrefRangeStart = 461745, XrefRangeEnd = 461746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredHeight(Vector2 margin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref margin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Private_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0002B8A0 File Offset: 0x00029AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461749, XrefRangeEnd = 461750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRenderedValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0002B8DC File Offset: 0x00029ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461750, XrefRangeEnd = 461751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRenderedValues(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0002B928 File Offset: 0x00029B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0002B964 File Offset: 0x00029B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461751, XrefRangeEnd = 461752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedWidth(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Protected_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0002B9B0 File Offset: 0x00029BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0002B9EC File Offset: 0x00029BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461752, XrefRangeEnd = 461753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedHeight(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Protected_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0002BA38 File Offset: 0x00029C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461753, XrefRangeEnd = 462293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &fontSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref marginSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTextAutoSizingEnabled;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWordWrappingEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0002BAB8 File Offset: 0x00029CB8
		[CallerCount(0)]
		public unsafe virtual Bounds GetCompoundBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_New_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0002BB00 File Offset: 0x00029D00
		[CallerCount(0)]
		public unsafe virtual Rect GetCanvasSpaceClippingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_New_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0002BB48 File Offset: 0x00029D48
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 462299, RefRangeEnd = 462307, XrefRangeStart = 462293, XrefRangeEnd = 462299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetTextBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0002BB84 File Offset: 0x00029D84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 462313, RefRangeEnd = 462316, XrefRangeStart = 462307, XrefRangeEnd = 462313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetTextBounds(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0002BBD0 File Offset: 0x00029DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462316, RefRangeEnd = 462317, XrefRangeStart = 462316, XrefRangeEnd = 462316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustLineOffset(int startIndex, int endIndex, float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_AdjustLineOffset_Protected_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0002BC2C File Offset: 0x00029E2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462331, RefRangeEnd = 462332, XrefRangeStart = 462317, XrefRangeEnd = 462331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeLineExtents(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ResizeLineExtents_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0002BC6C File Offset: 0x00029E6C
		[CallerCount(0)]
		public unsafe virtual TMP_TextInfo GetTextInfo(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetTextInfo_Public_Virtual_New_TMP_TextInfo_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0002BCC8 File Offset: 0x00029EC8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ComputeMarginSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0002BD04 File Offset: 0x00029F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 462347, RefRangeEnd = 462349, XrefRangeStart = 462332, XrefRangeEnd = 462347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseScale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentElementScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentEmScale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphAdjustment;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boldSpacingAdjustment;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterSpacingAdjustment;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineGap;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isMaxVisibleDescenderSet;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxVisibleDescender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InsertNewLine_Protected_Void_Int32_Single_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0002BDD4 File Offset: 0x00029FD4
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 462353, RefRangeEnd = 462373, XrefRangeStart = 462349, XrefRangeEnd = 462353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveWordWrappingState(ref WordWrapState state, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SaveWordWrappingState_Protected_Void_byref_WordWrapState_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0002BE38 File Offset: 0x0002A038
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 462377, RefRangeEnd = 462390, XrefRangeStart = 462373, XrefRangeEnd = 462377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RestoreWordWrappingState(ref WordWrapState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0002BE8C File Offset: 0x0002A08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462390, XrefRangeEnd = 462432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref padding;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style_padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SaveGlyphVertexInfo_Protected_Virtual_New_Void_Single_Single_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0002BEF4 File Offset: 0x0002A0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462432, XrefRangeEnd = 462478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SaveSpriteVertexInfo(Color32 vertexColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexColor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SaveSpriteVertexInfo_Protected_Virtual_New_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0002BF40 File Offset: 0x0002A140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462478, XrefRangeEnd = 462481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FillCharacterVertexBuffers(int i, int index_X4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index_X4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0002BF98 File Offset: 0x0002A198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462481, XrefRangeEnd = 462484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index_X4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolumetric;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0002C000 File Offset: 0x0002A200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FillSpriteVertexBuffers(int i, int index_X4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index_X4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_FillSpriteVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0002C058 File Offset: 0x0002A258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462484, XrefRangeEnd = 462488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startScale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endScale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxScale;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sdfScale;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref underlineColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_DrawUnderlineMesh_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Single_Single_Single_Single_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0002C104 File Offset: 0x0002A304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462488, XrefRangeEnd = 462496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highlightColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_DrawTextHighlight_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0002C178 File Offset: 0x0002A378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 462546, RefRangeEnd = 462548, XrefRangeStart = 462496, XrefRangeEnd = 462546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDefaultSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_LoadDefaultSettings_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0002C1AC File Offset: 0x0002A3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462548, XrefRangeEnd = 462550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSpecialCharacters(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0002C1F0 File Offset: 0x0002A3F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 462589, RefRangeEnd = 462594, XrefRangeStart = 462550, XrefRangeEnd = 462589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0002C234 File Offset: 0x0002A434
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 462616, RefRangeEnd = 462621, XrefRangeStart = 462594, XrefRangeEnd = 462616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0002C278 File Offset: 0x0002A478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462621, XrefRangeEnd = 462622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceTagWithCharacter(Il2CppStructArray<int> chars, int insertionIndex, int tagLength, char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref insertionIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceTagWithCharacter_Protected_Void_Il2CppStructArray_1_Int32_Int32_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0002C2E4 File Offset: 0x0002A4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462622, XrefRangeEnd = 462623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_FontAsset GetFontAssetForWeight(int fontWeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fontWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetFontAssetForWeight_Protected_TMP_FontAsset_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0002C330 File Offset: 0x0002A530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 462648, RefRangeEnd = 462650, XrefRangeStart = 462623, XrefRangeEnd = 462648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontStyle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontWeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isUsingAlternativeTypeface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetTextElement_Internal_TMP_TextElement_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextElement>(intPtr3) : null;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0002C3BC File Offset: 0x0002A5BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetActiveSubMeshes(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0002C408 File Offset: 0x0002A608
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroySubMeshObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0002C444 File Offset: 0x0002A644
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0002C480 File Offset: 0x0002A680
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearMesh(bool uploadGeometry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uploadGeometry;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0002C4CC File Offset: 0x0002A6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462650, XrefRangeEnd = 462659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetParsedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetParsedText_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0002C510 File Offset: 0x0002A710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 462686, RefRangeEnd = 462688, XrefRangeStart = 462659, XrefRangeEnd = 462686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetTextComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_IsSelfOrLinkedAncestor_Internal_Boolean_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0002C560 File Offset: 0x0002A760
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 462716, RefRangeEnd = 462719, XrefRangeStart = 462688, XrefRangeEnd = 462716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseLinkedTextComponent(TMP_Text targetTextComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetTextComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReleaseLinkedTextComponent_Internal_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0002C5A4 File Offset: 0x0002A7A4
		[CallerCount(0)]
		public unsafe Vector2 PackUV(float x, float y, float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Vector2_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0002C60C File Offset: 0x0002A80C
		[CallerCount(0)]
		public unsafe float PackUV(float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0002C664 File Offset: 0x0002A864
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InternalUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0002C6A0 File Offset: 0x0002A8A0
		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 462719, RefRangeEnd = 462801, XrefRangeStart = 462719, XrefRangeEnd = 462719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int HexToInt(char hex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_HexToInt_Protected_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0002C6EC File Offset: 0x0002A8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462801, XrefRangeEnd = 462805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(string text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0002C748 File Offset: 0x0002A948
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 462809, RefRangeEnd = 462815, XrefRangeStart = 462805, XrefRangeEnd = 462809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(Il2CppStructArray<int> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0002C7A4 File Offset: 0x0002A9A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 462809, RefRangeEnd = 462815, XrefRangeStart = 462809, XrefRangeEnd = 462815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(Il2CppStructArray<uint> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0002C800 File Offset: 0x0002AA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462815, XrefRangeEnd = 462823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(StringBuilder text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0002C85C File Offset: 0x0002AA5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462827, RefRangeEnd = 462828, XrefRangeStart = 462823, XrefRangeEnd = 462827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(TMP_Text.TextBackingContainer text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Private_Int32_TextBackingContainer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0002C8BC File Offset: 0x0002AABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462828, XrefRangeEnd = 462836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(string text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0002C918 File Offset: 0x0002AB18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 462844, RefRangeEnd = 462850, XrefRangeStart = 462836, XrefRangeEnd = 462844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(Il2CppStructArray<int> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0002C974 File Offset: 0x0002AB74
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 462844, RefRangeEnd = 462850, XrefRangeStart = 462844, XrefRangeEnd = 462850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(Il2CppStructArray<uint> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462850, XrefRangeEnd = 462866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(StringBuilder text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0002CA2C File Offset: 0x0002AC2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462874, RefRangeEnd = 462875, XrefRangeStart = 462866, XrefRangeEnd = 462874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(TMP_Text.TextBackingContainer text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Private_Int32_TextBackingContainer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0002CA8C File Offset: 0x0002AC8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 462891, RefRangeEnd = 462892, XrefRangeStart = 462875, XrefRangeEnd = 462891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 HexCharsToColor(Il2CppStructArray<char> hexChars, int tagCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hexChars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0002CAE8 File Offset: 0x0002ACE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462892, XrefRangeEnd = 462905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 HexCharsToColor(Il2CppStructArray<char> hexChars, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hexChars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0002CB54 File Offset: 0x0002AD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462905, XrefRangeEnd = 462906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAttributeParameters(Il2CppStructArray<char> chars, int startIndex, int length, ref Il2CppStructArray<float> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetAttributeParameters_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parameters = ((intPtr4 == 0) ? null : new Il2CppStructArray<float>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0002CBE8 File Offset: 0x0002ADE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462906, XrefRangeEnd = 462907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0002CC54 File Offset: 0x0002AE54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 462910, RefRangeEnd = 462912, XrefRangeStart = 462907, XrefRangeEnd = 462910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length, out int lastIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0002CCCC File Offset: 0x0002AECC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 463220, RefRangeEnd = 463225, XrefRangeStart = 462912, XrefRangeEnd = 463220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateHtmlTag(Il2CppStructArray<TMP_Text.UnicodeChar> chars, int startIndex, out int endIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ValidateHtmlTag_Internal_Boolean_Il2CppStructArray_1_UnicodeChar_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0002CD38 File Offset: 0x0002AF38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463301, RefRangeEnd = 463303, XrefRangeStart = 463225, XrefRangeEnd = 463301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Text()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00005929 File Offset: 0x00003B29
		public TMP_Text(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0002CD74 File Offset: 0x0002AF74
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00005932 File Offset: 0x00003B32
		public unsafe string m_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0002CD9C File Offset: 0x0002AF9C
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x00005951 File Offset: 0x00003B51
		public unsafe bool m_IsTextBackingStringDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextBackingStringDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextBackingStringDirty)) = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0002CDC4 File Offset: 0x0002AFC4
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x0000596C File Offset: 0x00003B6C
		public unsafe ITextPreprocessor m_TextPreprocessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextPreprocessor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITextPreprocessor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextPreprocessor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0002CDF4 File Offset: 0x0002AFF4
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x0000598B File Offset: 0x00003B8B
		public unsafe bool m_isRightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRightToLeft)) = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0002CE1C File Offset: 0x0002B01C
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x000059A6 File Offset: 0x00003BA6
		public unsafe TMP_FontAsset m_fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0002CE4C File Offset: 0x0002B04C
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x000059C5 File Offset: 0x00003BC5
		public unsafe TMP_FontAsset m_currentFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0002CE7C File Offset: 0x0002B07C
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x000059E4 File Offset: 0x00003BE4
		public unsafe bool m_isSDFShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isSDFShader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isSDFShader)) = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0002CEA4 File Offset: 0x0002B0A4
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x000059FF File Offset: 0x00003BFF
		public unsafe Material m_sharedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sharedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sharedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x0002CED4 File Offset: 0x0002B0D4
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00005A1E File Offset: 0x00003C1E
		public unsafe Material m_currentMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0002CF04 File Offset: 0x0002B104
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00005A3D File Offset: 0x00003C3D
		public unsafe static Il2CppReferenceArray<MaterialReference> m_materialReferences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_materialReferences, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MaterialReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_materialReferences, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0002CF2C File Offset: 0x0002B12C
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00005A4F File Offset: 0x00003C4F
		public unsafe static Dictionary<int, int> m_materialReferenceIndexLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceIndexLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceIndexLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0002CF54 File Offset: 0x0002B154
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x00005A61 File Offset: 0x00003C61
		public unsafe static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<MaterialReference>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceStack, intPtr);
				return new TMP_TextProcessingStack<MaterialReference>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<MaterialReference>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceStack, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0002CF90 File Offset: 0x0002B190
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00005A78 File Offset: 0x00003C78
		public unsafe int m_currentMaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterialIndex)) = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x0002CFB8 File Offset: 0x0002B1B8
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x00005A93 File Offset: 0x00003C93
		public unsafe Il2CppReferenceArray<Material> m_fontSharedMaterials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSharedMaterials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSharedMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x0002CFE8 File Offset: 0x0002B1E8
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00005AB2 File Offset: 0x00003CB2
		public unsafe Material m_fontMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0002D018 File Offset: 0x0002B218
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00005AD1 File Offset: 0x00003CD1
		public unsafe Il2CppReferenceArray<Material> m_fontMaterials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0002D048 File Offset: 0x0002B248
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00005AF0 File Offset: 0x00003CF0
		public unsafe bool m_isMaterialDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaterialDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaterialDirty)) = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0002D070 File Offset: 0x0002B270
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x00005B0B File Offset: 0x00003D0B
		public unsafe Color32 m_fontColor32
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor32);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor32)) = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0002D098 File Offset: 0x0002B298
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x00005B26 File Offset: 0x00003D26
		public unsafe Color m_fontColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor)) = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x00005B41 File Offset: 0x00003D41
		public unsafe static Color32 s_colorWhite
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_s_colorWhite, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_s_colorWhite, (void*)(&value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0002D0DC File Offset: 0x0002B2DC
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x00005B4F File Offset: 0x00003D4F
		public unsafe Color32 m_underlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColor)) = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0002D104 File Offset: 0x0002B304
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x00005B6A File Offset: 0x00003D6A
		public unsafe Color32 m_strikethroughColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColor)) = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0002D12C File Offset: 0x0002B32C
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00005B85 File Offset: 0x00003D85
		public unsafe bool m_enableVertexGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableVertexGradient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableVertexGradient)) = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0002D154 File Offset: 0x0002B354
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00005BA0 File Offset: 0x00003DA0
		public unsafe ColorMode m_colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorMode)) = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0002D17C File Offset: 0x0002B37C
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00005BBB File Offset: 0x00003DBB
		public unsafe VertexGradient m_fontColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradient)) = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0002D1A4 File Offset: 0x0002B3A4
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public unsafe TMP_ColorGradient m_fontColorGradientPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradientPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ColorGradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradientPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0002D1D4 File Offset: 0x0002B3D4
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00005BF5 File Offset: 0x00003DF5
		public unsafe TMP_SpriteAsset m_spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0002D204 File Offset: 0x0002B404
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00005C14 File Offset: 0x00003E14
		public unsafe bool m_tintAllSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintAllSprites);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintAllSprites)) = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0002D22C File Offset: 0x0002B42C
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00005C2F File Offset: 0x00003E2F
		public unsafe bool m_tintSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintSprite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintSprite)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x0002D254 File Offset: 0x0002B454
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x00005C4A File Offset: 0x00003E4A
		public unsafe Color32 m_spriteColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteColor)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x0002D27C File Offset: 0x0002B47C
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00005C65 File Offset: 0x00003E65
		public unsafe TMP_StyleSheet m_StyleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_StyleSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_StyleSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0002D2AC File Offset: 0x0002B4AC
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x00005C84 File Offset: 0x00003E84
		public unsafe TMP_Style m_TextStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0002D2DC File Offset: 0x0002B4DC
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x00005CA3 File Offset: 0x00003EA3
		public unsafe int m_TextStyleHashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleHashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleHashCode)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0002D304 File Offset: 0x0002B504
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00005CBE File Offset: 0x00003EBE
		public unsafe bool m_overrideHtmlColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overrideHtmlColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overrideHtmlColors)) = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0002D32C File Offset: 0x0002B52C
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00005CD9 File Offset: 0x00003ED9
		public unsafe Color32 m_faceColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_faceColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_faceColor)) = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0002D354 File Offset: 0x0002B554
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x00005CF4 File Offset: 0x00003EF4
		public unsafe Color32 m_outlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineColor)) = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0002D37C File Offset: 0x0002B57C
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x00005D0F File Offset: 0x00003F0F
		public unsafe float m_outlineWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineWidth)) = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0002D3A4 File Offset: 0x0002B5A4
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00005D2A File Offset: 0x00003F2A
		public unsafe float m_fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSize)) = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0002D3CC File Offset: 0x0002B5CC
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00005D45 File Offset: 0x00003F45
		public unsafe float m_currentFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontSize)) = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0002D3F4 File Offset: 0x0002B5F4
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x00005D60 File Offset: 0x00003F60
		public unsafe float m_fontSizeBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeBase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeBase)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0002D41C File Offset: 0x0002B61C
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x00005D7B File Offset: 0x00003F7B
		public TMP_TextProcessingStack<float> m_sizeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sizeStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sizeStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0002D44C File Offset: 0x0002B64C
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00005DA9 File Offset: 0x00003FA9
		public unsafe FontWeight m_fontWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontWeight)) = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0002D474 File Offset: 0x0002B674
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x00005DC4 File Offset: 0x00003FC4
		public unsafe FontWeight m_FontWeightInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightInternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightInternal)) = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0002D49C File Offset: 0x0002B69C
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00005DDF File Offset: 0x00003FDF
		public TMP_TextProcessingStack<FontWeight> m_FontWeightStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightStack);
				return new TMP_TextProcessingStack<FontWeight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<FontWeight>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<FontWeight>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0002D4CC File Offset: 0x0002B6CC
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00005E0D File Offset: 0x0000400D
		public unsafe bool m_enableAutoSizing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableAutoSizing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableAutoSizing)) = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0002D4F4 File Offset: 0x0002B6F4
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00005E28 File Offset: 0x00004028
		public unsafe float m_maxFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxFontSize)) = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0002D51C File Offset: 0x0002B71C
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00005E43 File Offset: 0x00004043
		public unsafe float m_minFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minFontSize)) = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0002D544 File Offset: 0x0002B744
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x00005E5E File Offset: 0x0000405E
		public unsafe int m_AutoSizeIterationCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeIterationCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeIterationCount)) = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x0002D56C File Offset: 0x0002B76C
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x00005E79 File Offset: 0x00004079
		public unsafe int m_AutoSizeMaxIterationCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount)) = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0002D594 File Offset: 0x0002B794
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00005E94 File Offset: 0x00004094
		public unsafe bool m_IsAutoSizePointSizeSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet)) = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0002D5BC File Offset: 0x0002B7BC
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00005EAF File Offset: 0x000040AF
		public unsafe float m_fontSizeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMin)) = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0002D5E4 File Offset: 0x0002B7E4
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x00005ECA File Offset: 0x000040CA
		public unsafe float m_fontSizeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMax)) = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0002D60C File Offset: 0x0002B80C
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00005EE5 File Offset: 0x000040E5
		public unsafe FontStyles m_fontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyle)) = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0002D634 File Offset: 0x0002B834
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00005F00 File Offset: 0x00004100
		public unsafe FontStyles m_FontStyleInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontStyleInternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontStyleInternal)) = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0002D65C File Offset: 0x0002B85C
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00005F1B File Offset: 0x0000411B
		public unsafe TMP_FontStyleStack m_fontStyleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyleStack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyleStack)) = value;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0002D684 File Offset: 0x0002B884
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00005F36 File Offset: 0x00004136
		public unsafe bool m_isUsingBold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingBold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingBold)) = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x0002D6AC File Offset: 0x0002B8AC
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00005F51 File Offset: 0x00004151
		public unsafe HorizontalAlignmentOptions m_HorizontalAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HorizontalAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HorizontalAlignment)) = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0002D6D4 File Offset: 0x0002B8D4
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00005F6C File Offset: 0x0000416C
		public unsafe VerticalAlignmentOptions m_VerticalAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VerticalAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VerticalAlignment)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0002D6FC File Offset: 0x0002B8FC
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00005F87 File Offset: 0x00004187
		public unsafe TextAlignmentOptions m_textAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textAlignment)) = value;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0002D724 File Offset: 0x0002B924
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x00005FA2 File Offset: 0x000041A2
		public unsafe HorizontalAlignmentOptions m_lineJustification
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustification);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustification)) = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0002D74C File Offset: 0x0002B94C
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x00005FBD File Offset: 0x000041BD
		public TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustificationStack);
				return new TMP_TextProcessingStack<HorizontalAlignmentOptions>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<HorizontalAlignmentOptions>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustificationStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<HorizontalAlignmentOptions>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0002D77C File Offset: 0x0002B97C
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00005FEB File Offset: 0x000041EB
		public unsafe Il2CppStructArray<Vector3> m_textContainerLocalCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textContainerLocalCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textContainerLocalCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0002D7AC File Offset: 0x0002B9AC
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x0000600A File Offset: 0x0000420A
		public unsafe float m_characterSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterSpacing)) = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0002D7D4 File Offset: 0x0002B9D4
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x00006025 File Offset: 0x00004225
		public unsafe float m_cSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cSpacing)) = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0002D7FC File Offset: 0x0002B9FC
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00006040 File Offset: 0x00004240
		public unsafe float m_monoSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_monoSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_monoSpacing)) = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0002D824 File Offset: 0x0002BA24
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x0000605B File Offset: 0x0000425B
		public unsafe float m_wordSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordSpacing)) = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0002D84C File Offset: 0x0002BA4C
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00006076 File Offset: 0x00004276
		public unsafe float m_lineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacing)) = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0002D874 File Offset: 0x0002BA74
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00006091 File Offset: 0x00004291
		public unsafe float m_lineSpacingDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingDelta)) = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0002D89C File Offset: 0x0002BA9C
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x000060AC File Offset: 0x000042AC
		public unsafe float m_lineHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineHeight)) = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0002D8C4 File Offset: 0x0002BAC4
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x000060C7 File Offset: 0x000042C7
		public unsafe bool m_IsDrivenLineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsDrivenLineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsDrivenLineSpacing)) = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0002D8EC File Offset: 0x0002BAEC
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x000060E2 File Offset: 0x000042E2
		public unsafe float m_lineSpacingMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingMax)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0002D914 File Offset: 0x0002BB14
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x000060FD File Offset: 0x000042FD
		public unsafe float m_paragraphSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_paragraphSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_paragraphSpacing)) = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0002D93C File Offset: 0x0002BB3C
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x00006118 File Offset: 0x00004318
		public unsafe float m_charWidthMaxAdj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthMaxAdj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthMaxAdj)) = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x0002D964 File Offset: 0x0002BB64
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x00006133 File Offset: 0x00004333
		public unsafe float m_charWidthAdjDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthAdjDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthAdjDelta)) = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0002D98C File Offset: 0x0002BB8C
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x0000614E File Offset: 0x0000434E
		public unsafe bool m_enableWordWrapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableWordWrapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableWordWrapping)) = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0002D9B4 File Offset: 0x0002BBB4
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x00006169 File Offset: 0x00004369
		public unsafe bool m_isCharacterWrappingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCharacterWrappingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCharacterWrappingEnabled)) = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0002D9DC File Offset: 0x0002BBDC
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x00006184 File Offset: 0x00004384
		public unsafe bool m_isNonBreakingSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNonBreakingSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNonBreakingSpace)) = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0002DA04 File Offset: 0x0002BC04
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x0000619F File Offset: 0x0000439F
		public unsafe bool m_isIgnoringAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isIgnoringAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isIgnoringAlignment)) = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0002DA2C File Offset: 0x0002BC2C
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x000061BA File Offset: 0x000043BA
		public unsafe float m_wordWrappingRatios
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordWrappingRatios);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordWrappingRatios)) = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0002DA54 File Offset: 0x0002BC54
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x000061D5 File Offset: 0x000043D5
		public unsafe TextOverflowModes m_overflowMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overflowMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overflowMode)) = value;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0002DA7C File Offset: 0x0002BC7C
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x000061F0 File Offset: 0x000043F0
		public unsafe int m_firstOverflowCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstOverflowCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstOverflowCharacterIndex)) = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0002DAA4 File Offset: 0x0002BCA4
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x0000620B File Offset: 0x0000440B
		public unsafe TMP_Text m_linkedTextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_linkedTextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_linkedTextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0002DAD4 File Offset: 0x0002BCD4
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x0000622A File Offset: 0x0000442A
		public unsafe TMP_Text parentLinkedComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_parentLinkedComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_parentLinkedComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0002DB04 File Offset: 0x0002BD04
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x00006249 File Offset: 0x00004449
		public unsafe bool m_isTextTruncated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isTextTruncated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isTextTruncated)) = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0002DB2C File Offset: 0x0002BD2C
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x00006264 File Offset: 0x00004464
		public unsafe bool m_enableKerning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableKerning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableKerning)) = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0002DB54 File Offset: 0x0002BD54
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x0000627F File Offset: 0x0000447F
		public unsafe float m_GlyphHorizontalAdvanceAdjustment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment)) = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0002DB7C File Offset: 0x0002BD7C
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x0000629A File Offset: 0x0000449A
		public unsafe bool m_enableExtraPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableExtraPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableExtraPadding)) = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0002DBA4 File Offset: 0x0002BDA4
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x000062B5 File Offset: 0x000044B5
		public unsafe bool checkPaddingRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_checkPaddingRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_checkPaddingRequired)) = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0002DBCC File Offset: 0x0002BDCC
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x000062D0 File Offset: 0x000044D0
		public unsafe bool m_isRichText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRichText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRichText)) = value;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0002DBF4 File Offset: 0x0002BDF4
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x000062EB File Offset: 0x000044EB
		public unsafe bool m_parseCtrlCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_parseCtrlCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_parseCtrlCharacters)) = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0002DC1C File Offset: 0x0002BE1C
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x00006306 File Offset: 0x00004506
		public unsafe bool m_isOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOverlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOverlay)) = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0002DC44 File Offset: 0x0002BE44
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00006321 File Offset: 0x00004521
		public unsafe bool m_isOrthographic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOrthographic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOrthographic)) = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0002DC6C File Offset: 0x0002BE6C
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x0000633C File Offset: 0x0000453C
		public unsafe bool m_isCullingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCullingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCullingEnabled)) = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0002DC94 File Offset: 0x0002BE94
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00006357 File Offset: 0x00004557
		public unsafe bool m_isMaskingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaskingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaskingEnabled)) = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0002DCBC File Offset: 0x0002BEBC
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x00006372 File Offset: 0x00004572
		public unsafe bool isMaskUpdateRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_isMaskUpdateRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_isMaskUpdateRequired)) = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0002DCE4 File Offset: 0x0002BEE4
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x0000638D File Offset: 0x0000458D
		public unsafe bool m_ignoreCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreCulling)) = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0002DD0C File Offset: 0x0002BF0C
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x000063A8 File Offset: 0x000045A8
		public unsafe TextureMappingOptions m_horizontalMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_horizontalMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_horizontalMapping)) = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0002DD34 File Offset: 0x0002BF34
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x000063C3 File Offset: 0x000045C3
		public unsafe TextureMappingOptions m_verticalMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_verticalMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_verticalMapping)) = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0002DD5C File Offset: 0x0002BF5C
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x000063DE File Offset: 0x000045DE
		public unsafe float m_uvLineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_uvLineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_uvLineOffset)) = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0002DD84 File Offset: 0x0002BF84
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x000063F9 File Offset: 0x000045F9
		public unsafe TextRenderFlags m_renderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderMode)) = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002DDAC File Offset: 0x0002BFAC
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x00006414 File Offset: 0x00004614
		public unsafe VertexSortingOrder m_geometrySortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_geometrySortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_geometrySortingOrder)) = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0002DDD4 File Offset: 0x0002BFD4
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0000642F File Offset: 0x0000462F
		public unsafe bool m_IsTextObjectScaleStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextObjectScaleStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextObjectScaleStatic)) = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0002DDFC File Offset: 0x0002BFFC
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x0000644A File Offset: 0x0000464A
		public unsafe bool m_VertexBufferAutoSizeReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction)) = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0002DE24 File Offset: 0x0002C024
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00006465 File Offset: 0x00004665
		public unsafe int m_firstVisibleCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacter)) = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0002DE4C File Offset: 0x0002C04C
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00006480 File Offset: 0x00004680
		public unsafe int m_maxVisibleCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleCharacters)) = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0002DE74 File Offset: 0x0002C074
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x0000649B File Offset: 0x0000469B
		public unsafe int m_maxVisibleWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleWords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleWords)) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0002DE9C File Offset: 0x0002C09C
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x000064B6 File Offset: 0x000046B6
		public unsafe int m_maxVisibleLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleLines)) = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0002DEC4 File Offset: 0x0002C0C4
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x000064D1 File Offset: 0x000046D1
		public unsafe bool m_useMaxVisibleDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_useMaxVisibleDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_useMaxVisibleDescender)) = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0002DEEC File Offset: 0x0002C0EC
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x000064EC File Offset: 0x000046EC
		public unsafe int m_pageToDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageToDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageToDisplay)) = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0002DF14 File Offset: 0x0002C114
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00006507 File Offset: 0x00004707
		public unsafe bool m_isNewPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNewPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNewPage)) = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0002DF3C File Offset: 0x0002C13C
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00006522 File Offset: 0x00004722
		public unsafe Vector4 m_margin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_margin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_margin)) = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0002DF64 File Offset: 0x0002C164
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x0000653D File Offset: 0x0000473D
		public unsafe float m_marginLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginLeft)) = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0002DF8C File Offset: 0x0002C18C
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00006558 File Offset: 0x00004758
		public unsafe float m_marginRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginRight)) = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0002DFB4 File Offset: 0x0002C1B4
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00006573 File Offset: 0x00004773
		public unsafe float m_marginWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginWidth)) = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0002DFDC File Offset: 0x0002C1DC
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x0000658E File Offset: 0x0000478E
		public unsafe float m_marginHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginHeight)) = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0002E004 File Offset: 0x0002C204
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x000065A9 File Offset: 0x000047A9
		public unsafe float m_width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_width)) = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0002E02C File Offset: 0x0002C22C
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x000065C4 File Offset: 0x000047C4
		public unsafe TMP_TextInfo m_textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0002E05C File Offset: 0x0002C25C
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x000065E3 File Offset: 0x000047E3
		public unsafe bool m_havePropertiesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_havePropertiesChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_havePropertiesChanged)) = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0002E084 File Offset: 0x0002C284
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x000065FE File Offset: 0x000047FE
		public unsafe bool m_isUsingLegacyAnimationComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent)) = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0002E0AC File Offset: 0x0002C2AC
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00006619 File Offset: 0x00004819
		public unsafe Transform m_transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0002E0DC File Offset: 0x0002C2DC
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00006638 File Offset: 0x00004838
		public unsafe RectTransform m_rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0002E10C File Offset: 0x0002C30C
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00006657 File Offset: 0x00004857
		public unsafe Vector2 m_PreviousRectTransformSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousRectTransformSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousRectTransformSize)) = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0002E134 File Offset: 0x0002C334
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00006672 File Offset: 0x00004872
		public unsafe Vector2 m_PreviousPivotPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousPivotPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousPivotPosition)) = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0002E15C File Offset: 0x0002C35C
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x0000668D File Offset: 0x0000488D
		public unsafe bool _autoSizeTextContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField)) = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0002E184 File Offset: 0x0002C384
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x000066A8 File Offset: 0x000048A8
		public unsafe bool m_autoSizeTextContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_autoSizeTextContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_autoSizeTextContainer)) = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0002E1AC File Offset: 0x0002C3AC
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x000066C3 File Offset: 0x000048C3
		public unsafe Mesh m_mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0002E1DC File Offset: 0x0002C3DC
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x000066E2 File Offset: 0x000048E2
		public unsafe bool m_isVolumetricText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isVolumetricText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isVolumetricText)) = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0002E204 File Offset: 0x0002C404
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x000066FD File Offset: 0x000048FD
		public unsafe static Func<int, string, TMP_FontAsset> OnFontAssetRequest
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_OnFontAssetRequest, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_OnFontAssetRequest, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0002E22C File Offset: 0x0002C42C
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x0000670F File Offset: 0x0000490F
		public unsafe static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_OnSpriteAssetRequest, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, TMP_SpriteAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_OnSpriteAssetRequest, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0002E254 File Offset: 0x0002C454
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00006721 File Offset: 0x00004921
		public unsafe Action<TMP_TextInfo> OnPreRenderText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_OnPreRenderText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TMP_TextInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_OnPreRenderText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0002E284 File Offset: 0x0002C484
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00006740 File Offset: 0x00004940
		public unsafe TMP_SpriteAnimator m_spriteAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0002E2B4 File Offset: 0x0002C4B4
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x0000675F File Offset: 0x0000495F
		public unsafe float m_flexibleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleHeight)) = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0002E2DC File Offset: 0x0002C4DC
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0000677A File Offset: 0x0000497A
		public unsafe float m_flexibleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleWidth)) = value;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0002E304 File Offset: 0x0002C504
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00006795 File Offset: 0x00004995
		public unsafe float m_minWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minWidth)) = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0002E32C File Offset: 0x0002C52C
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x000067B0 File Offset: 0x000049B0
		public unsafe float m_minHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minHeight)) = value;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0002E354 File Offset: 0x0002C554
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x000067CB File Offset: 0x000049CB
		public unsafe float m_maxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxWidth)) = value;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0002E37C File Offset: 0x0002C57C
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x000067E6 File Offset: 0x000049E6
		public unsafe float m_maxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxHeight)) = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0002E3A4 File Offset: 0x0002C5A4
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x00006801 File Offset: 0x00004A01
		public unsafe LayoutElement m_LayoutElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_LayoutElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_LayoutElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x0002E3D4 File Offset: 0x0002C5D4
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00006820 File Offset: 0x00004A20
		public unsafe float m_preferredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredWidth)) = value;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0002E3FC File Offset: 0x0002C5FC
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x0000683B File Offset: 0x00004A3B
		public unsafe float m_renderedWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedWidth)) = value;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0002E424 File Offset: 0x0002C624
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00006856 File Offset: 0x00004A56
		public unsafe bool m_isPreferredWidthDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredWidthDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredWidthDirty)) = value;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0002E44C File Offset: 0x0002C64C
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00006871 File Offset: 0x00004A71
		public unsafe float m_preferredHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredHeight)) = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0002E474 File Offset: 0x0002C674
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x0000688C File Offset: 0x00004A8C
		public unsafe float m_renderedHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedHeight)) = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0002E49C File Offset: 0x0002C69C
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x000068A7 File Offset: 0x00004AA7
		public unsafe bool m_isPreferredHeightDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredHeightDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredHeightDirty)) = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0002E4C4 File Offset: 0x0002C6C4
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x000068C2 File Offset: 0x00004AC2
		public unsafe bool m_isCalculatingPreferredValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCalculatingPreferredValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCalculatingPreferredValues)) = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0002E4EC File Offset: 0x0002C6EC
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x000068DD File Offset: 0x00004ADD
		public unsafe int m_layoutPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_layoutPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_layoutPriority)) = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0002E514 File Offset: 0x0002C714
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x000068F8 File Offset: 0x00004AF8
		public unsafe bool m_isLayoutDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isLayoutDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isLayoutDirty)) = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x0002E53C File Offset: 0x0002C73C
		// (set) Token: 0x06000A4D RID: 2637 RVA: 0x00006913 File Offset: 0x00004B13
		public unsafe bool m_isAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isAwake)) = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0002E564 File Offset: 0x0002C764
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x0000692E File Offset: 0x00004B2E
		public unsafe bool m_isWaitingOnResourceLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isWaitingOnResourceLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isWaitingOnResourceLoad)) = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0002E58C File Offset: 0x0002C78C
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00006949 File Offset: 0x00004B49
		public unsafe TMP_Text.TextInputSources m_inputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_inputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_inputSource)) = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0002E5B4 File Offset: 0x0002C7B4
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00006964 File Offset: 0x00004B64
		public unsafe float m_fontScaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontScaleMultiplier)) = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0002E5DC File Offset: 0x0002C7DC
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x0000697F File Offset: 0x00004B7F
		public unsafe static Il2CppStructArray<char> m_htmlTag
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_htmlTag, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_htmlTag, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0002E604 File Offset: 0x0002C804
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00006991 File Offset: 0x00004B91
		public unsafe static Il2CppStructArray<RichTextTagAttribute> m_xmlAttribute
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_xmlAttribute, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RichTextTagAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_xmlAttribute, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0002E62C File Offset: 0x0002C82C
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x000069A3 File Offset: 0x00004BA3
		public unsafe static Il2CppStructArray<float> m_attributeParameterValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_attributeParameterValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_attributeParameterValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0002E654 File Offset: 0x0002C854
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x000069B5 File Offset: 0x00004BB5
		public unsafe float tag_LineIndent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_LineIndent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_LineIndent)) = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x0002E67C File Offset: 0x0002C87C
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x000069D0 File Offset: 0x00004BD0
		public unsafe float tag_Indent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_Indent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_Indent)) = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0002E6A4 File Offset: 0x0002C8A4
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x000069EB File Offset: 0x00004BEB
		public TMP_TextProcessingStack<float> m_indentStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_indentStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_indentStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0002E6D4 File Offset: 0x0002C8D4
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00006A19 File Offset: 0x00004C19
		public unsafe bool tag_NoParsing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_NoParsing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_NoParsing)) = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0002E6FC File Offset: 0x0002C8FC
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00006A34 File Offset: 0x00004C34
		public unsafe bool m_isParsingText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isParsingText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isParsingText)) = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0002E724 File Offset: 0x0002C924
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00006A4F File Offset: 0x00004C4F
		public unsafe Matrix4x4 m_FXMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FXMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FXMatrix)) = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0002E74C File Offset: 0x0002C94C
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00006A6A File Offset: 0x00004C6A
		public unsafe bool m_isFXMatrixSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isFXMatrixSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isFXMatrixSet)) = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0002E774 File Offset: 0x0002C974
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00006A85 File Offset: 0x00004C85
		public unsafe Il2CppStructArray<TMP_Text.UnicodeChar> m_TextProcessingArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextProcessingArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TMP_Text.UnicodeChar>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextProcessingArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0002E7A4 File Offset: 0x0002C9A4
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00006AA4 File Offset: 0x00004CA4
		public unsafe int m_InternalTextProcessingArraySize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_InternalTextProcessingArraySize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_InternalTextProcessingArraySize)) = value;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0002E7CC File Offset: 0x0002C9CC
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00006ABF File Offset: 0x00004CBF
		public unsafe Il2CppReferenceArray<TMP_CharacterInfo> m_internalCharacterInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_internalCharacterInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_CharacterInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_internalCharacterInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0002E7FC File Offset: 0x0002C9FC
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00006ADE File Offset: 0x00004CDE
		public unsafe int m_totalCharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_totalCharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_totalCharacterCount)) = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0002E824 File Offset: 0x0002CA24
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00006AF9 File Offset: 0x00004CF9
		public unsafe static WordWrapState m_SavedWordWrapState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedWordWrapState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedWordWrapState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0002E860 File Offset: 0x0002CA60
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00006B10 File Offset: 0x00004D10
		public unsafe static WordWrapState m_SavedLineState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedLineState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedLineState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002E89C File Offset: 0x0002CA9C
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00006B27 File Offset: 0x00004D27
		public unsafe static WordWrapState m_SavedEllipsisState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedEllipsisState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedEllipsisState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0002E8D8 File Offset: 0x0002CAD8
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00006B3E File Offset: 0x00004D3E
		public unsafe static WordWrapState m_SavedLastValidState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedLastValidState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedLastValidState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0002E914 File Offset: 0x0002CB14
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00006B55 File Offset: 0x00004D55
		public unsafe static WordWrapState m_SavedSoftLineBreakState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedSoftLineBreakState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedSoftLineBreakState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0002E950 File Offset: 0x0002CB50
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00006B6C File Offset: 0x00004D6C
		public unsafe static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<WordWrapState>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack, intPtr);
				return new TMP_TextProcessingStack<WordWrapState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<WordWrapState>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0002E98C File Offset: 0x0002CB8C
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00006B83 File Offset: 0x00004D83
		public unsafe int m_characterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterCount)) = value;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0002E9B4 File Offset: 0x0002CBB4
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x00006B9E File Offset: 0x00004D9E
		public unsafe int m_firstCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstCharacterOfLine)) = value;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0002E9DC File Offset: 0x0002CBDC
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x00006BB9 File Offset: 0x00004DB9
		public unsafe int m_firstVisibleCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacterOfLine)) = value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0002EA04 File Offset: 0x0002CC04
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x00006BD4 File Offset: 0x00004DD4
		public unsafe int m_lastCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastCharacterOfLine)) = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0002EA2C File Offset: 0x0002CC2C
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x00006BEF File Offset: 0x00004DEF
		public unsafe int m_lastVisibleCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastVisibleCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastVisibleCharacterOfLine)) = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0002EA54 File Offset: 0x0002CC54
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x00006C0A File Offset: 0x00004E0A
		public unsafe int m_lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineNumber)) = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0002EA7C File Offset: 0x0002CC7C
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x00006C25 File Offset: 0x00004E25
		public unsafe int m_lineVisibleCharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineVisibleCharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineVisibleCharacterCount)) = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0002EAA4 File Offset: 0x0002CCA4
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x00006C40 File Offset: 0x00004E40
		public unsafe int m_pageNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageNumber)) = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0002EACC File Offset: 0x0002CCCC
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x00006C5B File Offset: 0x00004E5B
		public unsafe float m_PageAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PageAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PageAscender)) = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0002EAF4 File Offset: 0x0002CCF4
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x00006C76 File Offset: 0x00004E76
		public unsafe float m_maxTextAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxTextAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxTextAscender)) = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0002EB1C File Offset: 0x0002CD1C
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00006C91 File Offset: 0x00004E91
		public unsafe float m_maxCapHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxCapHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxCapHeight)) = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0002EB44 File Offset: 0x0002CD44
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00006CAC File Offset: 0x00004EAC
		public unsafe float m_ElementAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementAscender)) = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0002EB6C File Offset: 0x0002CD6C
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00006CC7 File Offset: 0x00004EC7
		public unsafe float m_ElementDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementDescender)) = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0002EB94 File Offset: 0x0002CD94
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x00006CE2 File Offset: 0x00004EE2
		public unsafe float m_maxLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineAscender)) = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0002EBBC File Offset: 0x0002CDBC
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x00006CFD File Offset: 0x00004EFD
		public unsafe float m_maxLineDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineDescender)) = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0002EBE4 File Offset: 0x0002CDE4
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00006D18 File Offset: 0x00004F18
		public unsafe float m_startOfLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineAscender)) = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0002EC0C File Offset: 0x0002CE0C
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00006D33 File Offset: 0x00004F33
		public unsafe float m_startOfLineDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineDescender)) = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0002EC34 File Offset: 0x0002CE34
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00006D4E File Offset: 0x00004F4E
		public unsafe float m_lineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineOffset)) = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0002EC5C File Offset: 0x0002CE5C
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x00006D69 File Offset: 0x00004F69
		public unsafe Extents m_meshExtents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_meshExtents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_meshExtents)) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0002EC84 File Offset: 0x0002CE84
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x00006D84 File Offset: 0x00004F84
		public unsafe Color32 m_htmlColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_htmlColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_htmlColor)) = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0002ECAC File Offset: 0x0002CEAC
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x00006D9F File Offset: 0x00004F9F
		public TMP_TextProcessingStack<Color32> m_colorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0002ECDC File Offset: 0x0002CEDC
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x00006DCD File Offset: 0x00004FCD
		public TMP_TextProcessingStack<Color32> m_underlineColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0002ED0C File Offset: 0x0002CF0C
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x00006DFB File Offset: 0x00004FFB
		public TMP_TextProcessingStack<Color32> m_strikethroughColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0002ED3C File Offset: 0x0002CF3C
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00006E29 File Offset: 0x00005029
		public TMP_TextProcessingStack<HighlightState> m_HighlightStateStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HighlightStateStack);
				return new TMP_TextProcessingStack<HighlightState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<HighlightState>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HighlightStateStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<HighlightState>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0002ED6C File Offset: 0x0002CF6C
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00006E57 File Offset: 0x00005057
		public unsafe TMP_ColorGradient m_colorGradientPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ColorGradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0002ED9C File Offset: 0x0002CF9C
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00006E76 File Offset: 0x00005076
		public TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientStack);
				return new TMP_TextProcessingStack<TMP_ColorGradient>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<TMP_ColorGradient>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<TMP_ColorGradient>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0002EDCC File Offset: 0x0002CFCC
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00006EA4 File Offset: 0x000050A4
		public unsafe bool m_colorGradientPresetIsTinted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPresetIsTinted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPresetIsTinted)) = value;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0002EDF4 File Offset: 0x0002CFF4
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00006EBF File Offset: 0x000050BF
		public unsafe float m_tabSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tabSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tabSpacing)) = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0002EE1C File Offset: 0x0002D01C
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00006EDA File Offset: 0x000050DA
		public unsafe float m_spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spacing)) = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0002EE44 File Offset: 0x0002D044
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00006EF5 File Offset: 0x000050F5
		public unsafe Il2CppReferenceArray<TMP_TextProcessingStack<int>> m_TextStyleStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_TextProcessingStack<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x0002EE74 File Offset: 0x0002D074
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00006F14 File Offset: 0x00005114
		public unsafe int m_TextStyleStackDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStackDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStackDepth)) = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0002EE9C File Offset: 0x0002D09C
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00006F2F File Offset: 0x0000512F
		public TMP_TextProcessingStack<int> m_ItalicAngleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngleStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0002EECC File Offset: 0x0002D0CC
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00006F5D File Offset: 0x0000515D
		public unsafe int m_ItalicAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngle)) = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0002EEF4 File Offset: 0x0002D0F4
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00006F78 File Offset: 0x00005178
		public TMP_TextProcessingStack<int> m_actionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_actionStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_actionStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0002EF24 File Offset: 0x0002D124
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00006FA6 File Offset: 0x000051A6
		public unsafe float m_padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_padding)) = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0002EF4C File Offset: 0x0002D14C
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00006FC1 File Offset: 0x000051C1
		public unsafe float m_baselineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffset)) = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0002EF74 File Offset: 0x0002D174
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00006FDC File Offset: 0x000051DC
		public TMP_TextProcessingStack<float> m_baselineOffsetStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffsetStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffsetStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0002EFA4 File Offset: 0x0002D1A4
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x0000700A File Offset: 0x0000520A
		public unsafe float m_xAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_xAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_xAdvance)) = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0002EFCC File Offset: 0x0002D1CC
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00007025 File Offset: 0x00005225
		public unsafe TMP_TextElementType m_textElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textElementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textElementType)) = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x0002EFF4 File Offset: 0x0002D1F4
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x00007040 File Offset: 0x00005240
		public unsafe TMP_TextElement m_cached_TextElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cached_TextElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cached_TextElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x0002F024 File Offset: 0x0002D224
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x0000705F File Offset: 0x0000525F
		public TMP_Text.SpecialCharacter m_Ellipsis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Ellipsis);
				return new TMP_Text.SpecialCharacter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Ellipsis), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0002F054 File Offset: 0x0002D254
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x0000708D File Offset: 0x0000528D
		public TMP_Text.SpecialCharacter m_Underline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Underline);
				return new TMP_Text.SpecialCharacter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Underline), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0002F084 File Offset: 0x0002D284
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x000070BB File Offset: 0x000052BB
		public unsafe TMP_SpriteAsset m_defaultSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_defaultSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_defaultSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0002F0B4 File Offset: 0x0002D2B4
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x000070DA File Offset: 0x000052DA
		public unsafe TMP_SpriteAsset m_currentSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0002F0E4 File Offset: 0x0002D2E4
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x000070F9 File Offset: 0x000052F9
		public unsafe int m_spriteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteCount)) = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0002F10C File Offset: 0x0002D30C
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x00007114 File Offset: 0x00005314
		public unsafe int m_spriteIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteIndex)) = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0002F134 File Offset: 0x0002D334
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x0000712F File Offset: 0x0000532F
		public unsafe int m_spriteAnimationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimationID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimationID)) = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0002F15C File Offset: 0x0002D35C
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x0000714A File Offset: 0x0000534A
		public unsafe static ProfilerMarker k_ParseTextMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_ParseTextMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_ParseTextMarker, (void*)(&value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0002F178 File Offset: 0x0002D378
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x00007158 File Offset: 0x00005358
		public unsafe static ProfilerMarker k_InsertNewLineMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_InsertNewLineMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_InsertNewLineMarker, (void*)(&value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0002F194 File Offset: 0x0002D394
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00007166 File Offset: 0x00005366
		public unsafe bool m_ignoreActiveState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreActiveState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreActiveState)) = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0002F1BC File Offset: 0x0002D3BC
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00007181 File Offset: 0x00005381
		public TMP_Text.TextBackingContainer m_TextBackingArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextBackingArray);
				return new TMP_Text.TextBackingContainer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextBackingArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0002F1EC File Offset: 0x0002D3EC
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x000071AF File Offset: 0x000053AF
		public unsafe Il2CppStructArray<Decimal> k_Power
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_k_Power);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_k_Power), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x0002F21C File Offset: 0x0002D41C
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x000071CE File Offset: 0x000053CE
		public unsafe static Vector2 k_LargePositiveVector2
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveVector2, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveVector2, (void*)(&value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0002F238 File Offset: 0x0002D438
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x000071DC File Offset: 0x000053DC
		public unsafe static Vector2 k_LargeNegativeVector2
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeVector2, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeVector2, (void*)(&value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0002F254 File Offset: 0x0002D454
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x000071EA File Offset: 0x000053EA
		public unsafe static float k_LargePositiveFloat
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveFloat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveFloat, (void*)(&value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0002F270 File Offset: 0x0002D470
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x000071F8 File Offset: 0x000053F8
		public unsafe static float k_LargeNegativeFloat
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeFloat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeFloat, (void*)(&value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0002F28C File Offset: 0x0002D48C
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x00007206 File Offset: 0x00005406
		public unsafe static int k_LargePositiveInt
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveInt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveInt, (void*)(&value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0002F2A8 File Offset: 0x0002D4A8
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x00007214 File Offset: 0x00005414
		public unsafe static int k_LargeNegativeInt
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeInt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeInt, (void*)(&value));
			}
		}

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr_m_text;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextBackingStringDirty;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr_m_TextPreprocessor;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr_m_isRightToLeft;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeFieldInfoPtr_m_fontAsset;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr_m_currentFontAsset;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr_m_isSDFShader;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr_m_sharedMaterial;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr_m_currentMaterial;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr_m_materialReferences;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr_m_materialReferenceIndexLookup;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeFieldInfoPtr_m_materialReferenceStack;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeFieldInfoPtr_m_currentMaterialIndex;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSharedMaterials;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr_m_fontMaterial;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr_m_fontMaterials;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr_m_isMaterialDirty;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColor32;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColor;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr_s_colorWhite;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_m_underlineColor;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr_m_strikethroughColor;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr_m_enableVertexGradient;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr_m_colorMode;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColorGradient;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColorGradientPreset;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAsset;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_m_tintAllSprites;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr_m_tintSprite;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteColor;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleSheet;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyle;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyleHashCode;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr_m_overrideHtmlColors;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr_m_faceColor;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_m_outlineColor;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_m_outlineWidth;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSize;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_m_currentFontSize;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSizeBase;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr_m_sizeStack;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_m_fontWeight;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_m_FontWeightInternal;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_m_FontWeightStack;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_m_enableAutoSizing;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_m_maxFontSize;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_m_minFontSize;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoSizeIterationCount;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoSizeMaxIterationCount;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr_m_IsAutoSizePointSizeSet;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSizeMin;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSizeMax;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeFieldInfoPtr_m_fontStyle;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeFieldInfoPtr_m_FontStyleInternal;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr_m_fontStyleStack;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr_m_isUsingBold;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAlignment;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalAlignment;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeFieldInfoPtr_m_textAlignment;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr_m_lineJustification;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeFieldInfoPtr_m_lineJustificationStack;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeFieldInfoPtr_m_textContainerLocalCorners;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeFieldInfoPtr_m_characterSpacing;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr_m_cSpacing;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr_m_monoSpacing;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeFieldInfoPtr_m_wordSpacing;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeFieldInfoPtr_m_lineSpacing;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr_m_lineSpacingDelta;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr_m_lineHeight;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDrivenLineSpacing;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeFieldInfoPtr_m_lineSpacingMax;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeFieldInfoPtr_m_paragraphSpacing;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeFieldInfoPtr_m_charWidthMaxAdj;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr_m_charWidthAdjDelta;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeFieldInfoPtr_m_enableWordWrapping;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeFieldInfoPtr_m_isCharacterWrappingEnabled;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeFieldInfoPtr_m_isNonBreakingSpace;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeFieldInfoPtr_m_isIgnoringAlignment;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeFieldInfoPtr_m_wordWrappingRatios;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeFieldInfoPtr_m_overflowMode;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeFieldInfoPtr_m_firstOverflowCharacterIndex;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeFieldInfoPtr_m_linkedTextComponent;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr_parentLinkedComponent;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeFieldInfoPtr_m_isTextTruncated;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeFieldInfoPtr_m_enableKerning;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr_m_enableExtraPadding;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr_checkPaddingRequired;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr_m_isRichText;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeFieldInfoPtr_m_parseCtrlCharacters;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeFieldInfoPtr_m_isOverlay;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeFieldInfoPtr_m_isOrthographic;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeFieldInfoPtr_m_isCullingEnabled;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeFieldInfoPtr_m_isMaskingEnabled;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeFieldInfoPtr_isMaskUpdateRequired;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeFieldInfoPtr_m_ignoreCulling;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalMapping;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalMapping;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeFieldInfoPtr_m_uvLineOffset;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeFieldInfoPtr_m_renderMode;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeFieldInfoPtr_m_geometrySortingOrder;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextObjectScaleStatic;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_m_firstVisibleCharacter;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_m_maxVisibleCharacters;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_m_maxVisibleWords;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_m_maxVisibleLines;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_m_useMaxVisibleDescender;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_m_pageToDisplay;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_m_isNewPage;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_m_margin;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_m_marginLeft;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_m_marginRight;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_m_marginWidth;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_m_marginHeight;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_m_width;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_m_textInfo;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_m_havePropertiesChanged;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_m_transform;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousRectTransformSize;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousPivotPosition;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_m_autoSizeTextContainer;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_m_mesh;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_m_isVolumetricText;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_OnFontAssetRequest;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_OnSpriteAssetRequest;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_OnPreRenderText;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAnimator;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_m_flexibleHeight;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_m_flexibleWidth;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_m_minWidth;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_m_minHeight;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_m_maxWidth;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_m_maxHeight;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutElement;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_m_preferredWidth;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr_m_renderedWidth;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_m_isPreferredWidthDirty;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr_m_preferredHeight;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr_m_renderedHeight;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr_m_isPreferredHeightDirty;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_m_isCalculatingPreferredValues;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr_m_layoutPriority;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr_m_isLayoutDirty;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr_m_isAwake;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_m_isWaitingOnResourceLoad;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr_m_inputSource;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr_m_fontScaleMultiplier;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr_m_htmlTag;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr_m_xmlAttribute;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_m_attributeParameterValues;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_tag_LineIndent;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_tag_Indent;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr_m_indentStack;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr_tag_NoParsing;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr_m_isParsingText;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeFieldInfoPtr_m_FXMatrix;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeFieldInfoPtr_m_isFXMatrixSet;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr_m_TextProcessingArray;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalTextProcessingArraySize;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeFieldInfoPtr_m_internalCharacterInfo;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeFieldInfoPtr_m_totalCharacterCount;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedWordWrapState;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedLineState;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedEllipsisState;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedLastValidState;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedSoftLineBreakState;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeFieldInfoPtr_m_characterCount;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_m_firstCharacterOfLine;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeFieldInfoPtr_m_firstVisibleCharacterOfLine;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeFieldInfoPtr_m_lastCharacterOfLine;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeFieldInfoPtr_m_lastVisibleCharacterOfLine;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeFieldInfoPtr_m_lineNumber;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeFieldInfoPtr_m_lineVisibleCharacterCount;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeFieldInfoPtr_m_pageNumber;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeFieldInfoPtr_m_PageAscender;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeFieldInfoPtr_m_maxTextAscender;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCapHeight;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementAscender;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementDescender;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeFieldInfoPtr_m_maxLineAscender;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeFieldInfoPtr_m_maxLineDescender;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeFieldInfoPtr_m_startOfLineAscender;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeFieldInfoPtr_m_startOfLineDescender;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeFieldInfoPtr_m_lineOffset;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr_m_meshExtents;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr_m_htmlColor;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeFieldInfoPtr_m_colorStack;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeFieldInfoPtr_m_underlineColorStack;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeFieldInfoPtr_m_strikethroughColorStack;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightStateStack;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr_m_colorGradientPreset;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeFieldInfoPtr_m_colorGradientStack;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr_m_colorGradientPresetIsTinted;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_m_tabSpacing;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr_m_spacing;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyleStacks;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyleStackDepth;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr_m_ItalicAngleStack;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeFieldInfoPtr_m_ItalicAngle;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeFieldInfoPtr_m_actionStack;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeFieldInfoPtr_m_padding;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeFieldInfoPtr_m_baselineOffset;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeFieldInfoPtr_m_baselineOffsetStack;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr_m_xAdvance;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr_m_textElementType;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr_m_cached_TextElement;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr_m_Ellipsis;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr_m_Underline;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultSpriteAsset;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeFieldInfoPtr_m_currentSpriteAsset;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteCount;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteIndex;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAnimationID;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr_k_ParseTextMarker;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_k_InsertNewLineMarker;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_m_ignoreActiveState;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_m_TextBackingArray;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeFieldInfoPtr_k_Power;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeFieldInfoPtr_k_LargePositiveVector2;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeFieldInfoPtr_k_LargeNegativeVector2;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeFieldInfoPtr_k_LargePositiveFloat;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeFieldInfoPtr_k_LargeNegativeFloat;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeFieldInfoPtr_k_LargePositiveInt;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr_k_LargeNegativeInt;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_get_textPreprocessor_Public_get_ITextPreprocessor_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_set_textPreprocessor_Public_set_Void_ITextPreprocessor_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_get_isRightToLeftText_Public_get_Boolean_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_set_isRightToLeftText_Public_set_Void_Boolean_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_TMP_FontAsset_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSharedMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSharedMaterial_Public_Virtual_New_set_Void_Material_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSharedMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSharedMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_get_fontMaterial_Public_get_Material_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_set_fontMaterial_Public_set_Void_Material_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_get_fontMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_set_fontMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_get_alpha_Public_get_Single_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_get_enableVertexGradient_Public_get_Boolean_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_set_enableVertexGradient_Public_set_Void_Boolean_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradient_Public_get_VertexGradient_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_set_colorGradient_Public_set_Void_VertexGradient_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradientPreset_Public_get_TMP_ColorGradient_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_set_colorGradientPreset_Public_set_Void_TMP_ColorGradient_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_get_tintAllSprites_Public_get_Boolean_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_set_tintAllSprites_Public_set_Void_Boolean_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_get_styleSheet_Public_get_TMP_StyleSheet_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_set_styleSheet_Public_set_Void_TMP_StyleSheet_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_get_textStyle_Public_get_TMP_Style_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_set_textStyle_Public_set_Void_TMP_Style_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideColorTags_Public_get_Boolean_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideColorTags_Public_set_Void_Boolean_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_get_faceColor_Public_get_Color32_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_set_faceColor_Public_set_Void_Color32_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_get_outlineColor_Public_get_Color32_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_set_outlineColor_Public_set_Void_Color32_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_get_outlineWidth_Public_get_Single_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_set_outlineWidth_Public_set_Void_Single_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Single_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSize_Public_set_Void_Single_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_get_fontWeight_Public_get_FontWeight_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_set_fontWeight_Public_set_Void_FontWeight_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_get_enableAutoSizing_Public_get_Boolean_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_set_enableAutoSizing_Public_set_Void_Boolean_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSizeMin_Public_get_Single_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSizeMin_Public_set_Void_Single_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSizeMax_Public_get_Single_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSizeMax_Public_set_Void_Single_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyles_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyles_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_get_isUsingBold_Public_get_Boolean_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAlignment_Public_get_HorizontalAlignmentOptions_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalAlignment_Public_get_VerticalAlignmentOptions_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalAlignment_Public_set_Void_VerticalAlignmentOptions_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Public_get_TextAlignmentOptions_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignmentOptions_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_get_characterSpacing_Public_get_Single_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_set_characterSpacing_Public_set_Void_Single_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_set_wordSpacing_Public_set_Void_Single_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacingAdjustment_Public_get_Single_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_set_lineSpacingAdjustment_Public_set_Void_Single_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_get_paragraphSpacing_Public_get_Single_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_set_paragraphSpacing_Public_set_Void_Single_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_get_characterWidthAdjustment_Public_get_Single_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_set_characterWidthAdjustment_Public_set_Void_Single_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_get_enableWordWrapping_Public_get_Boolean_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_set_enableWordWrapping_Public_set_Void_Boolean_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_get_wordWrappingRatios_Public_get_Single_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_set_wordWrappingRatios_Public_set_Void_Single_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_get_overflowMode_Public_get_TextOverflowModes_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_set_overflowMode_Public_set_Void_TextOverflowModes_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextOverflowing_Public_get_Boolean_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_get_firstOverflowCharacterIndex_Public_get_Int32_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_get_linkedTextComponent_Public_get_TMP_Text_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_set_linkedTextComponent_Public_set_Void_TMP_Text_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_get_enableKerning_Public_get_Boolean_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_set_enableKerning_Public_set_Void_Boolean_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_get_extraPadding_Public_get_Boolean_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_set_extraPadding_Public_set_Void_Boolean_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_get_richText_Public_get_Boolean_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_get_parseCtrlCharacters_Public_get_Boolean_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_set_parseCtrlCharacters_Public_set_Void_Boolean_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_get_isOverlay_Public_get_Boolean_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_set_isOverlay_Public_set_Void_Boolean_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_get_enableCulling_Public_get_Boolean_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_set_enableCulling_Public_set_Void_Boolean_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreVisibility_Public_get_Boolean_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreVisibility_Public_set_Void_Boolean_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalMapping_Public_get_TextureMappingOptions_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalMapping_Public_set_Void_TextureMappingOptions_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalMapping_Public_get_TextureMappingOptions_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalMapping_Public_set_Void_TextureMappingOptions_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_get_mappingUvLineOffset_Public_get_Single_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_set_mappingUvLineOffset_Public_set_Void_Single_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_get_renderMode_Public_get_TextRenderFlags_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_set_renderMode_Public_set_Void_TextRenderFlags_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_get_geometrySortingOrder_Public_get_VertexSortingOrder_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_set_geometrySortingOrder_Public_set_Void_VertexSortingOrder_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_get_Boolean_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_set_Void_Boolean_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexBufferAutoSizeReduction_Public_get_Boolean_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_set_vertexBufferAutoSizeReduction_Public_set_Void_Boolean_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_get_firstVisibleCharacter_Public_get_Int32_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_set_firstVisibleCharacter_Public_set_Void_Int32_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVisibleCharacters_Public_get_Int32_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_set_maxVisibleCharacters_Public_set_Void_Int32_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVisibleWords_Public_get_Int32_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_set_maxVisibleWords_Public_set_Void_Int32_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVisibleLines_Public_get_Int32_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_set_maxVisibleLines_Public_set_Void_Int32_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_get_useMaxVisibleDescender_Public_get_Boolean_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_set_useMaxVisibleDescender_Public_set_Void_Boolean_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_get_pageToDisplay_Public_get_Int32_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_set_pageToDisplay_Public_set_Void_Int32_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_get_margin_Public_Virtual_New_get_Vector4_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_set_margin_Public_Virtual_New_set_Void_Vector4_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_get_textInfo_Public_get_TMP_TextInfo_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_get_havePropertiesChanged_Public_get_Boolean_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_set_havePropertiesChanged_Public_set_Void_Boolean_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_get_isUsingLegacyAnimationComponent_Public_get_Boolean_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_set_isUsingLegacyAnimationComponent_Public_set_Void_Boolean_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_Virtual_New_get_Mesh_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_get_isVolumetricText_Public_get_Boolean_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_set_isVolumetricText_Public_set_Void_Boolean_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_get_textBounds_Public_get_Bounds_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_add_OnFontAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_FontAsset_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnFontAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_FontAsset_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSpriteAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_SpriteAsset_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSpriteAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_SpriteAsset_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_New_add_Void_Action_1_TMP_TextInfo_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_New_rem_Void_Action_1_TMP_TextInfo_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteAnimator_Protected_get_TMP_SpriteAnimator_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_get_maxWidth_Public_get_Single_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_get_maxHeight_Public_get_Single_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutElement_Protected_get_LayoutElement_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_get_renderedWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_get_renderedHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_New_Void_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_New_Void_Material_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_Material_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_SetFontBaseMaterial_Protected_Virtual_New_Void_Material_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_New_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_CreateMaterialInstance_Protected_Virtual_New_Material_Material_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexColorGradient_Protected_Void_TMP_ColorGradient_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_VertexSortingOrder_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_New_Void_Color32_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_New_Void_Color32_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_New_Void_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_SetCulling_Protected_Virtual_New_Void_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_New_Void_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_Material_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_New_Void_Boolean_Boolean_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_New_Void_Mesh_Int32_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_TMP_VertexDataUpdateFlags_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Virtual_New_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_New_Void_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_Void_Color_Single_Boolean_Boolean_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_Void_Single_Single_Boolean_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_New_Void_Color_Single_Boolean_Boolean_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_New_Void_Single_Single_Boolean_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_ParseInputText_Protected_Void_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_SetTextInternal_Private_Void_String_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Boolean_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_StringBuilder_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Private_TMP_Style_Int32_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_TextBackingContainer_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_Int32_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_InsertOpeningStyleTag_Private_Boolean_TMP_Style_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_InsertClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_TextBackingContainer_Int32_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_TextBackingContainer_Int32_byref_Int32_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_AddFloatToInternalTextBackingArray_Private_Void_Single_Int32_Int32_byref_Int32_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_AddIntegerToInternalTextBackingArray_Private_Void_Double_Int32_byref_Int32_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_InternalTextBackingArrayToString_Private_String_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_New_Int32_Il2CppStructArray_1_UnicodeChar_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_Single_Single_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_Single_Single_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredWidth_Protected_Single_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredWidth_Private_Single_Vector2_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredHeight_Protected_Single_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredHeight_Private_Single_Vector2_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_Boolean_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedWidth_Private_Single_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedWidth_Protected_Single_Boolean_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedHeight_Private_Single_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedHeight_Protected_Single_Boolean_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_Boolean_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_New_Bounds_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_New_Rect_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_Boolean_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_AdjustLineOffset_Protected_Void_Int32_Int32_Single_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_ResizeLineExtents_Protected_Void_Int32_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_GetTextInfo_Public_Virtual_New_TMP_TextInfo_String_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_New_Void_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_InsertNewLine_Protected_Void_Int32_Single_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_SaveWordWrappingState_Protected_Void_byref_WordWrapState_Int32_Int32_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_SaveGlyphVertexInfo_Protected_Virtual_New_Void_Single_Single_Color32_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_SaveSpriteVertexInfo_Protected_Virtual_New_Void_Color32_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_Boolean_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_FillSpriteVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_DrawUnderlineMesh_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Single_Single_Single_Single_Color32_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_DrawTextHighlight_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Color32_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultSettings_Protected_Void_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TMP_FontAsset_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TMP_FontAsset_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TMP_FontAsset_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceTagWithCharacter_Protected_Void_Il2CppStructArray_1_Int32_Int32_Int32_Char_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_GetFontAssetForWeight_Protected_TMP_FontAsset_Int32_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_GetTextElement_Internal_TMP_TextElement_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_New_Void_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_GetParsedText_Public_Virtual_New_String_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_IsSelfOrLinkedAncestor_Internal_Boolean_TMP_Text_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseLinkedTextComponent_Internal_Void_TMP_Text_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_PackUV_Protected_Vector2_Single_Single_Single_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_PackUV_Protected_Single_Single_Single_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_New_Void_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_HexToInt_Protected_Int32_Char_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Protected_Int32_String_Int32_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Protected_Int32_StringBuilder_Int32_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Private_Int32_TextBackingContainer_Int32_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Protected_Int32_String_Int32_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Protected_Int32_StringBuilder_Int32_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Private_Int32_TextBackingContainer_Int32_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeParameters_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_ValidateHtmlTag_Internal_Boolean_Il2CppStructArray_1_UnicodeChar_Int32_byref_Int32_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000A4 RID: 164
		[StructLayout(2)]
		public struct CharacterSubstitution
		{
			// Token: 0x06000FCF RID: 4047 RVA: 0x0003E74C File Offset: 0x0003C94C
			// Note: this type is marked as 'beforefieldinit'.
			static CharacterSubstitution()
			{
				Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "CharacterSubstitution");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr);
				TMP_Text.CharacterSubstitution.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, "index");
				TMP_Text.CharacterSubstitution.NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, "unicode");
				TMP_Text.CharacterSubstitution.NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, 100664542);
			}

			// Token: 0x06000FD0 RID: 4048 RVA: 0x0003E7B4 File Offset: 0x0003C9B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76853, RefRangeEnd = 76855, XrefRangeStart = 76853, XrefRangeEnd = 76855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CharacterSubstitution(int index, uint unicode)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.CharacterSubstitution.NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FD1 RID: 4049 RVA: 0x00009905 File Offset: 0x00007B05
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, ref this));
			}

			// Token: 0x04000C63 RID: 3171
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04000C64 RID: 3172
			private static readonly IntPtr NativeFieldInfoPtr_unicode;

			// Token: 0x04000C65 RID: 3173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0;

			// Token: 0x04000C66 RID: 3174
			[FieldOffset(0)]
			public int index;

			// Token: 0x04000C67 RID: 3175
			[FieldOffset(4)]
			public uint unicode;
		}

		// Token: 0x020000A5 RID: 165
		[OriginalName("Unity.TextMeshPro.dll", "", "TextInputSources")]
		public enum TextInputSources
		{
			// Token: 0x04000C69 RID: 3177
			TextInputBox,
			// Token: 0x04000C6A RID: 3178
			SetText,
			// Token: 0x04000C6B RID: 3179
			SetTextArray,
			// Token: 0x04000C6C RID: 3180
			TextString
		}

		// Token: 0x020000A6 RID: 166
		[StructLayout(2)]
		public struct UnicodeChar
		{
			// Token: 0x06000FD2 RID: 4050 RVA: 0x0003E7F4 File Offset: 0x0003C9F4
			// Note: this type is marked as 'beforefieldinit'.
			static UnicodeChar()
			{
				Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "UnicodeChar");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr);
				TMP_Text.UnicodeChar.NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, "unicode");
				TMP_Text.UnicodeChar.NativeFieldInfoPtr_stringIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, "stringIndex");
				TMP_Text.UnicodeChar.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, "length");
			}

			// Token: 0x06000FD3 RID: 4051 RVA: 0x00009917 File Offset: 0x00007B17
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, ref this));
			}

			// Token: 0x04000C6D RID: 3181
			private static readonly IntPtr NativeFieldInfoPtr_unicode;

			// Token: 0x04000C6E RID: 3182
			private static readonly IntPtr NativeFieldInfoPtr_stringIndex;

			// Token: 0x04000C6F RID: 3183
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x04000C70 RID: 3184
			[FieldOffset(0)]
			public int unicode;

			// Token: 0x04000C71 RID: 3185
			[FieldOffset(4)]
			public int stringIndex;

			// Token: 0x04000C72 RID: 3186
			[FieldOffset(8)]
			public int length;
		}

		// Token: 0x020000A7 RID: 167
		public sealed class SpecialCharacter : ValueType
		{
			// Token: 0x06000FD4 RID: 4052 RVA: 0x0003E85C File Offset: 0x0003CA5C
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialCharacter()
			{
				Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "SpecialCharacter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr);
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "character");
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "fontAsset");
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "material");
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_materialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "materialIndex");
				TMP_Text.SpecialCharacter.NativeMethodInfoPtr__ctor_Public_Void_TMP_Character_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, 100664543);
			}

			// Token: 0x06000FD5 RID: 4053 RVA: 0x0003E8EC File Offset: 0x0003CAEC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 460739, RefRangeEnd = 460740, XrefRangeStart = 460723, XrefRangeEnd = 460739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialCharacter(TMP_Character character, int materialIndex)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref materialIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.SpecialCharacter.NativeMethodInfoPtr__ctor_Public_Void_TMP_Character_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FD6 RID: 4054 RVA: 0x00009929 File Offset: 0x00007B29
			public SpecialCharacter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000FD7 RID: 4055 RVA: 0x00009932 File Offset: 0x00007B32
			public SpecialCharacter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr))
			{
			}

			// Token: 0x170005BF RID: 1471
			// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0003E94C File Offset: 0x0003CB4C
			// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00009944 File Offset: 0x00007B44
			public unsafe TMP_Character character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C0 RID: 1472
			// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0003E97C File Offset: 0x0003CB7C
			// (set) Token: 0x06000FDB RID: 4059 RVA: 0x00009963 File Offset: 0x00007B63
			public unsafe TMP_FontAsset fontAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_fontAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C1 RID: 1473
			// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0003E9AC File Offset: 0x0003CBAC
			// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00009982 File Offset: 0x00007B82
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C2 RID: 1474
			// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0003E9DC File Offset: 0x0003CBDC
			// (set) Token: 0x06000FDF RID: 4063 RVA: 0x000099A1 File Offset: 0x00007BA1
			public unsafe int materialIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_materialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_materialIndex)) = value;
				}
			}

			// Token: 0x04000C73 RID: 3187
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x04000C74 RID: 3188
			private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

			// Token: 0x04000C75 RID: 3189
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04000C76 RID: 3190
			private static readonly IntPtr NativeFieldInfoPtr_materialIndex;

			// Token: 0x04000C77 RID: 3191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMP_Character_Int32_0;
		}

		// Token: 0x020000A8 RID: 168
		public sealed class TextBackingContainer : ValueType
		{
			// Token: 0x06000FE0 RID: 4064 RVA: 0x0003EA04 File Offset: 0x0003CC04
			// Note: this type is marked as 'beforefieldinit'.
			static TextBackingContainer()
			{
				Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "TextBackingContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr);
				TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, "m_Array");
				TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, "m_Count");
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664544);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664545);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664546);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664547);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664548);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664549);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_Resize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664550);
			}

			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x0003EAE4 File Offset: 0x0003CCE4
			public unsafe int Capacity
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170005C6 RID: 1478
			// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0003EB28 File Offset: 0x0003CD28
			// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x0003EB6C File Offset: 0x0003CD6C
			public unsafe int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170005C7 RID: 1479
			public unsafe uint this[int index]
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 460741, RefRangeEnd = 460744, XrefRangeStart = 460740, XrefRangeEnd = 460741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000FE6 RID: 4070 RVA: 0x0003EC54 File Offset: 0x0003CE54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460744, XrefRangeEnd = 460747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextBackingContainer(int size)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000FE7 RID: 4071 RVA: 0x0003ECA0 File Offset: 0x0003CEA0
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 460755, RefRangeEnd = 460770, XrefRangeStart = 460747, XrefRangeEnd = 460755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Resize(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_Resize_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000FE8 RID: 4072 RVA: 0x000099BC File Offset: 0x00007BBC
			public TextBackingContainer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000FE9 RID: 4073 RVA: 0x000099C5 File Offset: 0x00007BC5
			public TextBackingContainer()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr))
			{
			}

			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x06000FEA RID: 4074 RVA: 0x0003ECE4 File Offset: 0x0003CEE4
			// (set) Token: 0x06000FEB RID: 4075 RVA: 0x000099D7 File Offset: 0x00007BD7
			public unsafe Il2CppStructArray<uint> m_Array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C4 RID: 1476
			// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0003ED14 File Offset: 0x0003CF14
			// (set) Token: 0x06000FED RID: 4077 RVA: 0x000099F6 File Offset: 0x00007BF6
			public unsafe int m_Count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Count)) = value;
				}
			}

			// Token: 0x04000C78 RID: 3192
			private static readonly IntPtr NativeFieldInfoPtr_m_Array;

			// Token: 0x04000C79 RID: 3193
			private static readonly IntPtr NativeFieldInfoPtr_m_Count;

			// Token: 0x04000C7A RID: 3194
			private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

			// Token: 0x04000C7B RID: 3195
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x04000C7C RID: 3196
			private static readonly IntPtr NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0;

			// Token: 0x04000C7D RID: 3197
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0;

			// Token: 0x04000C7E RID: 3198
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0;

			// Token: 0x04000C7F RID: 3199
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C80 RID: 3200
			private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_0;
		}

		// Token: 0x020000A9 RID: 169
		[ObfuscatedName("TMPro.TMP_Text+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000FEE RID: 4078 RVA: 0x0003ED3C File Offset: 0x0003CF3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr);
				TMP_Text.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, "<>9");
				TMP_Text.__c.NativeFieldInfoPtr___9__622_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, "<>9__622_0");
				TMP_Text.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, 100664552);
				TMP_Text.__c.NativeMethodInfoPtr___ctor_b__622_0_Internal_Void_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, 100664553);
			}

			// Token: 0x06000FEF RID: 4079 RVA: 0x0003EDB8 File Offset: 0x0003CFB8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FF0 RID: 4080 RVA: 0x0003EDF4 File Offset: 0x0003CFF4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__622_0(TMP_TextInfo <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.__c.NativeMethodInfoPtr___ctor_b__622_0_Internal_Void_TMP_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000FF1 RID: 4081 RVA: 0x00009A11 File Offset: 0x00007C11
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005C8 RID: 1480
			// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0003EE38 File Offset: 0x0003D038
			// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00009A1A File Offset: 0x00007C1A
			public unsafe static TMP_Text.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_Text.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_Text.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C9 RID: 1481
			// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0003EE60 File Offset: 0x0003D060
			// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00009A2C File Offset: 0x00007C2C
			public unsafe static Action<TMP_TextInfo> __9__622_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_Text.__c.NativeFieldInfoPtr___9__622_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TMP_TextInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_Text.__c.NativeFieldInfoPtr___9__622_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C81 RID: 3201
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C82 RID: 3202
			private static readonly IntPtr NativeFieldInfoPtr___9__622_0;

			// Token: 0x04000C83 RID: 3203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C84 RID: 3204
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__622_0_Internal_Void_TMP_TextInfo_0;
		}

		// Token: 0x020000AA RID: 170
		private sealed class MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04000C85 RID: 3205
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<TMP_Text>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000AB RID: 171
		private sealed class MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04000C86 RID: 3206
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<TMP_Text>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
