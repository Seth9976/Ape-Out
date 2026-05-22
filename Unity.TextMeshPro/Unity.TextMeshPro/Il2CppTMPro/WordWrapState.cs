using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200006C RID: 108
	public sealed class WordWrapState : ValueType
	{
		// Token: 0x06000C80 RID: 3200 RVA: 0x00034894 File Offset: 0x00032A94
		// Note: this type is marked as 'beforefieldinit'.
		static WordWrapState()
		{
			Il2CppClassPointerStore<WordWrapState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "WordWrapState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr);
			WordWrapState.NativeFieldInfoPtr_previous_WordBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "previous_WordBreak");
			WordWrapState.NativeFieldInfoPtr_total_CharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "total_CharacterCount");
			WordWrapState.NativeFieldInfoPtr_visible_CharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visible_CharacterCount");
			WordWrapState.NativeFieldInfoPtr_visible_SpriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visible_SpriteCount");
			WordWrapState.NativeFieldInfoPtr_visible_LinkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visible_LinkCount");
			WordWrapState.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "firstCharacterIndex");
			WordWrapState.NativeFieldInfoPtr_firstVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "firstVisibleCharacterIndex");
			WordWrapState.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lastCharacterIndex");
			WordWrapState.NativeFieldInfoPtr_lastVisibleCharIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lastVisibleCharIndex");
			WordWrapState.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineNumber");
			WordWrapState.NativeFieldInfoPtr_maxCapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxCapHeight");
			WordWrapState.NativeFieldInfoPtr_maxAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxAscender");
			WordWrapState.NativeFieldInfoPtr_maxDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxDescender");
			WordWrapState.NativeFieldInfoPtr_startOfLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "startOfLineAscender");
			WordWrapState.NativeFieldInfoPtr_maxLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxLineAscender");
			WordWrapState.NativeFieldInfoPtr_maxLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxLineDescender");
			WordWrapState.NativeFieldInfoPtr_pageAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "pageAscender");
			WordWrapState.NativeFieldInfoPtr_horizontalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "horizontalAlignment");
			WordWrapState.NativeFieldInfoPtr_marginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "marginLeft");
			WordWrapState.NativeFieldInfoPtr_marginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "marginRight");
			WordWrapState.NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "xAdvance");
			WordWrapState.NativeFieldInfoPtr_preferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "preferredWidth");
			WordWrapState.NativeFieldInfoPtr_preferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "preferredHeight");
			WordWrapState.NativeFieldInfoPtr_previousLineScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "previousLineScale");
			WordWrapState.NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "wordCount");
			WordWrapState.NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontStyle");
			WordWrapState.NativeFieldInfoPtr_italicAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "italicAngle");
			WordWrapState.NativeFieldInfoPtr_fontScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontScaleMultiplier");
			WordWrapState.NativeFieldInfoPtr_currentFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentFontSize");
			WordWrapState.NativeFieldInfoPtr_baselineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "baselineOffset");
			WordWrapState.NativeFieldInfoPtr_lineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineOffset");
			WordWrapState.NativeFieldInfoPtr_isDrivenLineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "isDrivenLineSpacing");
			WordWrapState.NativeFieldInfoPtr_glyphHorizontalAdvanceAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "glyphHorizontalAdvanceAdjustment");
			WordWrapState.NativeFieldInfoPtr_cSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "cSpace");
			WordWrapState.NativeFieldInfoPtr_mSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "mSpace");
			WordWrapState.NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "textInfo");
			WordWrapState.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineInfo");
			WordWrapState.NativeFieldInfoPtr_vertexColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "vertexColor");
			WordWrapState.NativeFieldInfoPtr_underlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "underlineColor");
			WordWrapState.NativeFieldInfoPtr_strikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "strikethroughColor");
			WordWrapState.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightColor");
			WordWrapState.NativeFieldInfoPtr_basicStyleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "basicStyleStack");
			WordWrapState.NativeFieldInfoPtr_italicAngleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "italicAngleStack");
			WordWrapState.NativeFieldInfoPtr_colorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "colorStack");
			WordWrapState.NativeFieldInfoPtr_underlineColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "underlineColorStack");
			WordWrapState.NativeFieldInfoPtr_strikethroughColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "strikethroughColorStack");
			WordWrapState.NativeFieldInfoPtr_highlightColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightColorStack");
			WordWrapState.NativeFieldInfoPtr_highlightStateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightStateStack");
			WordWrapState.NativeFieldInfoPtr_colorGradientStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "colorGradientStack");
			WordWrapState.NativeFieldInfoPtr_sizeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "sizeStack");
			WordWrapState.NativeFieldInfoPtr_indentStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "indentStack");
			WordWrapState.NativeFieldInfoPtr_fontWeightStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontWeightStack");
			WordWrapState.NativeFieldInfoPtr_styleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "styleStack");
			WordWrapState.NativeFieldInfoPtr_baselineStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "baselineStack");
			WordWrapState.NativeFieldInfoPtr_actionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "actionStack");
			WordWrapState.NativeFieldInfoPtr_materialReferenceStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "materialReferenceStack");
			WordWrapState.NativeFieldInfoPtr_lineJustificationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineJustificationStack");
			WordWrapState.NativeFieldInfoPtr_spriteAnimationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "spriteAnimationID");
			WordWrapState.NativeFieldInfoPtr_currentFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentFontAsset");
			WordWrapState.NativeFieldInfoPtr_currentSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentSpriteAsset");
			WordWrapState.NativeFieldInfoPtr_currentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentMaterial");
			WordWrapState.NativeFieldInfoPtr_currentMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentMaterialIndex");
			WordWrapState.NativeFieldInfoPtr_meshExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "meshExtents");
			WordWrapState.NativeFieldInfoPtr_tagNoParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "tagNoParsing");
			WordWrapState.NativeFieldInfoPtr_isNonBreakingSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "isNonBreakingSpace");
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00007CAE File Offset: 0x00005EAE
		public WordWrapState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00007CB7 File Offset: 0x00005EB7
		public WordWrapState()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr))
		{
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00034DD8 File Offset: 0x00032FD8
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00007CC9 File Offset: 0x00005EC9
		public unsafe int previous_WordBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_previous_WordBreak);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_previous_WordBreak)) = value;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00034E00 File Offset: 0x00033000
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x00007CE4 File Offset: 0x00005EE4
		public unsafe int total_CharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_total_CharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_total_CharacterCount)) = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00034E28 File Offset: 0x00033028
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x00007CFF File Offset: 0x00005EFF
		public unsafe int visible_CharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_CharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_CharacterCount)) = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00034E50 File Offset: 0x00033050
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x00007D1A File Offset: 0x00005F1A
		public unsafe int visible_SpriteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_SpriteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_SpriteCount)) = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x00034E78 File Offset: 0x00033078
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00007D35 File Offset: 0x00005F35
		public unsafe int visible_LinkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_LinkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_LinkCount)) = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00034EA0 File Offset: 0x000330A0
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00007D50 File Offset: 0x00005F50
		public unsafe int firstCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_firstCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_firstCharacterIndex)) = value;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00034EC8 File Offset: 0x000330C8
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x00007D6B File Offset: 0x00005F6B
		public unsafe int firstVisibleCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_firstVisibleCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_firstVisibleCharacterIndex)) = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00034EF0 File Offset: 0x000330F0
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00007D86 File Offset: 0x00005F86
		public unsafe int lastCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lastCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lastCharacterIndex)) = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00034F18 File Offset: 0x00033118
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00007DA1 File Offset: 0x00005FA1
		public unsafe int lastVisibleCharIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lastVisibleCharIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lastVisibleCharIndex)) = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00034F40 File Offset: 0x00033140
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x00007DBC File Offset: 0x00005FBC
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00034F68 File Offset: 0x00033168
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x00007DD7 File Offset: 0x00005FD7
		public unsafe float maxCapHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxCapHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxCapHeight)) = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x00034F90 File Offset: 0x00033190
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00007DF2 File Offset: 0x00005FF2
		public unsafe float maxAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxAscender)) = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00034FB8 File Offset: 0x000331B8
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00007E0D File Offset: 0x0000600D
		public unsafe float maxDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxDescender)) = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00034FE0 File Offset: 0x000331E0
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x00007E28 File Offset: 0x00006028
		public unsafe float startOfLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_startOfLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_startOfLineAscender)) = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00035008 File Offset: 0x00033208
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00007E43 File Offset: 0x00006043
		public unsafe float maxLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxLineAscender)) = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00035030 File Offset: 0x00033230
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x00007E5E File Offset: 0x0000605E
		public unsafe float maxLineDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxLineDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxLineDescender)) = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00035058 File Offset: 0x00033258
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00007E79 File Offset: 0x00006079
		public unsafe float pageAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_pageAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_pageAscender)) = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00035080 File Offset: 0x00033280
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00007E94 File Offset: 0x00006094
		public unsafe HorizontalAlignmentOptions horizontalAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_horizontalAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_horizontalAlignment)) = value;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x000350A8 File Offset: 0x000332A8
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00007EAF File Offset: 0x000060AF
		public unsafe float marginLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_marginLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_marginLeft)) = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x000350D0 File Offset: 0x000332D0
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00007ECA File Offset: 0x000060CA
		public unsafe float marginRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_marginRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_marginRight)) = value;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x000350F8 File Offset: 0x000332F8
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00007EE5 File Offset: 0x000060E5
		public unsafe float xAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_xAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_xAdvance)) = value;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00035120 File Offset: 0x00033320
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00007F00 File Offset: 0x00006100
		public unsafe float preferredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_preferredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_preferredWidth)) = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x00035148 File Offset: 0x00033348
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00007F1B File Offset: 0x0000611B
		public unsafe float preferredHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_preferredHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_preferredHeight)) = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x00035170 File Offset: 0x00033370
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00007F36 File Offset: 0x00006136
		public unsafe float previousLineScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_previousLineScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_previousLineScale)) = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00035198 File Offset: 0x00033398
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00007F51 File Offset: 0x00006151
		public unsafe int wordCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_wordCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_wordCount)) = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x000351C0 File Offset: 0x000333C0
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00007F6C File Offset: 0x0000616C
		public unsafe FontStyles fontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontStyle)) = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x000351E8 File Offset: 0x000333E8
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00007F87 File Offset: 0x00006187
		public unsafe int italicAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_italicAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_italicAngle)) = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00035210 File Offset: 0x00033410
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x00007FA2 File Offset: 0x000061A2
		public unsafe float fontScaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontScaleMultiplier)) = value;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00035238 File Offset: 0x00033438
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x00007FBD File Offset: 0x000061BD
		public unsafe float currentFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentFontSize)) = value;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00035260 File Offset: 0x00033460
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x00007FD8 File Offset: 0x000061D8
		public unsafe float baselineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_baselineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_baselineOffset)) = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00035288 File Offset: 0x00033488
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x00007FF3 File Offset: 0x000061F3
		public unsafe float lineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineOffset)) = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x000352B0 File Offset: 0x000334B0
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x0000800E File Offset: 0x0000620E
		public unsafe bool isDrivenLineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_isDrivenLineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_isDrivenLineSpacing)) = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000352D8 File Offset: 0x000334D8
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x00008029 File Offset: 0x00006229
		public unsafe float glyphHorizontalAdvanceAdjustment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_glyphHorizontalAdvanceAdjustment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_glyphHorizontalAdvanceAdjustment)) = value;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00035300 File Offset: 0x00033500
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x00008044 File Offset: 0x00006244
		public unsafe float cSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_cSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_cSpace)) = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00035328 File Offset: 0x00033528
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x0000805F File Offset: 0x0000625F
		public unsafe float mSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_mSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_mSpace)) = value;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00035350 File Offset: 0x00033550
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x0000807A File Offset: 0x0000627A
		public unsafe TMP_TextInfo textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00035380 File Offset: 0x00033580
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00008099 File Offset: 0x00006299
		public unsafe TMP_LineInfo lineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineInfo)) = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000353A8 File Offset: 0x000335A8
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x000080B4 File Offset: 0x000062B4
		public unsafe Color32 vertexColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_vertexColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_vertexColor)) = value;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000353D0 File Offset: 0x000335D0
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x000080CF File Offset: 0x000062CF
		public unsafe Color32 underlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_underlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_underlineColor)) = value;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000353F8 File Offset: 0x000335F8
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x000080EA File Offset: 0x000062EA
		public unsafe Color32 strikethroughColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_strikethroughColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_strikethroughColor)) = value;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00035420 File Offset: 0x00033620
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x00008105 File Offset: 0x00006305
		public unsafe Color32 highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightColor)) = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00035448 File Offset: 0x00033648
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00008120 File Offset: 0x00006320
		public unsafe TMP_FontStyleStack basicStyleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_basicStyleStack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_basicStyleStack)) = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x00035470 File Offset: 0x00033670
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x0000813B File Offset: 0x0000633B
		public TMP_TextProcessingStack<int> italicAngleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_italicAngleStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_italicAngleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x000354A0 File Offset: 0x000336A0
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x00008169 File Offset: 0x00006369
		public TMP_TextProcessingStack<Color32> colorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x000354D0 File Offset: 0x000336D0
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00008197 File Offset: 0x00006397
		public TMP_TextProcessingStack<Color32> underlineColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_underlineColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_underlineColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00035500 File Offset: 0x00033700
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x000081C5 File Offset: 0x000063C5
		public TMP_TextProcessingStack<Color32> strikethroughColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_strikethroughColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_strikethroughColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x00035530 File Offset: 0x00033730
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x000081F3 File Offset: 0x000063F3
		public TMP_TextProcessingStack<Color32> highlightColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00035560 File Offset: 0x00033760
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x00008221 File Offset: 0x00006421
		public TMP_TextProcessingStack<HighlightState> highlightStateStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightStateStack);
				return new TMP_TextProcessingStack<HighlightState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<HighlightState>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightStateStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<HighlightState>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00035590 File Offset: 0x00033790
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x0000824F File Offset: 0x0000644F
		public TMP_TextProcessingStack<TMP_ColorGradient> colorGradientStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorGradientStack);
				return new TMP_TextProcessingStack<TMP_ColorGradient>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<TMP_ColorGradient>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorGradientStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<TMP_ColorGradient>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000355C0 File Offset: 0x000337C0
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x0000827D File Offset: 0x0000647D
		public TMP_TextProcessingStack<float> sizeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_sizeStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_sizeStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x000355F0 File Offset: 0x000337F0
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x000082AB File Offset: 0x000064AB
		public TMP_TextProcessingStack<float> indentStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_indentStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_indentStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00035620 File Offset: 0x00033820
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x000082D9 File Offset: 0x000064D9
		public TMP_TextProcessingStack<FontWeight> fontWeightStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontWeightStack);
				return new TMP_TextProcessingStack<FontWeight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<FontWeight>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontWeightStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<FontWeight>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00035650 File Offset: 0x00033850
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x00008307 File Offset: 0x00006507
		public TMP_TextProcessingStack<int> styleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_styleStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_styleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x00035680 File Offset: 0x00033880
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00008335 File Offset: 0x00006535
		public TMP_TextProcessingStack<float> baselineStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_baselineStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_baselineStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x000356B0 File Offset: 0x000338B0
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00008363 File Offset: 0x00006563
		public TMP_TextProcessingStack<int> actionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_actionStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_actionStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x000356E0 File Offset: 0x000338E0
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00008391 File Offset: 0x00006591
		public TMP_TextProcessingStack<MaterialReference> materialReferenceStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_materialReferenceStack);
				return new TMP_TextProcessingStack<MaterialReference>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<MaterialReference>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_materialReferenceStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<MaterialReference>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00035710 File Offset: 0x00033910
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x000083BF File Offset: 0x000065BF
		public TMP_TextProcessingStack<HorizontalAlignmentOptions> lineJustificationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineJustificationStack);
				return new TMP_TextProcessingStack<HorizontalAlignmentOptions>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<HorizontalAlignmentOptions>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineJustificationStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<HorizontalAlignmentOptions>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00035740 File Offset: 0x00033940
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x000083ED File Offset: 0x000065ED
		public unsafe int spriteAnimationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_spriteAnimationID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_spriteAnimationID)) = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00035768 File Offset: 0x00033968
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00008408 File Offset: 0x00006608
		public unsafe TMP_FontAsset currentFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x00035798 File Offset: 0x00033998
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00008427 File Offset: 0x00006627
		public unsafe TMP_SpriteAsset currentSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x000357C8 File Offset: 0x000339C8
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x00008446 File Offset: 0x00006646
		public unsafe Material currentMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x000357F8 File Offset: 0x000339F8
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00008465 File Offset: 0x00006665
		public unsafe int currentMaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentMaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentMaterialIndex)) = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x00035820 File Offset: 0x00033A20
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00008480 File Offset: 0x00006680
		public unsafe Extents meshExtents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_meshExtents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_meshExtents)) = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x00035848 File Offset: 0x00033A48
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x0000849B File Offset: 0x0000669B
		public unsafe bool tagNoParsing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_tagNoParsing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_tagNoParsing)) = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00035870 File Offset: 0x00033A70
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x000084B6 File Offset: 0x000066B6
		public unsafe bool isNonBreakingSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_isNonBreakingSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_isNonBreakingSpace)) = value;
			}
		}

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeFieldInfoPtr_previous_WordBreak;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeFieldInfoPtr_total_CharacterCount;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeFieldInfoPtr_visible_CharacterCount;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeFieldInfoPtr_visible_SpriteCount;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeFieldInfoPtr_visible_LinkCount;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr_firstVisibleCharacterIndex;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeFieldInfoPtr_lastVisibleCharIndex;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeFieldInfoPtr_maxCapHeight;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeFieldInfoPtr_maxAscender;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr_maxDescender;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr_startOfLineAscender;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeFieldInfoPtr_maxLineAscender;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr_maxLineDescender;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr_pageAscender;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeFieldInfoPtr_horizontalAlignment;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeFieldInfoPtr_marginLeft;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeFieldInfoPtr_marginRight;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeFieldInfoPtr_xAdvance;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeFieldInfoPtr_preferredWidth;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeFieldInfoPtr_preferredHeight;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeFieldInfoPtr_previousLineScale;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeFieldInfoPtr_wordCount;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeFieldInfoPtr_fontStyle;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeFieldInfoPtr_italicAngle;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeFieldInfoPtr_fontScaleMultiplier;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeFieldInfoPtr_currentFontSize;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeFieldInfoPtr_baselineOffset;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeFieldInfoPtr_lineOffset;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeFieldInfoPtr_isDrivenLineSpacing;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeFieldInfoPtr_glyphHorizontalAdvanceAdjustment;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeFieldInfoPtr_cSpace;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeFieldInfoPtr_mSpace;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeFieldInfoPtr_textInfo;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeFieldInfoPtr_vertexColor;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeFieldInfoPtr_underlineColor;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughColor;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_basicStyleStack;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr_italicAngleStack;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr_colorStack;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeFieldInfoPtr_underlineColorStack;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughColorStack;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr_highlightColorStack;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeFieldInfoPtr_highlightStateStack;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeFieldInfoPtr_colorGradientStack;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeFieldInfoPtr_sizeStack;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeFieldInfoPtr_indentStack;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeFieldInfoPtr_fontWeightStack;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_styleStack;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr_baselineStack;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr_actionStack;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeFieldInfoPtr_materialReferenceStack;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeFieldInfoPtr_lineJustificationStack;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeFieldInfoPtr_spriteAnimationID;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeFieldInfoPtr_currentFontAsset;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr_currentSpriteAsset;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_currentMaterial;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr_currentMaterialIndex;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_meshExtents;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr_tagNoParsing;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr_isNonBreakingSpace;
	}
}
