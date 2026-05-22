using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200000F RID: 15
	public sealed class TMP_CharacterInfo : ValueType
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x0000C69C File Offset: 0x0000A89C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_CharacterInfo()
		{
			Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_CharacterInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr);
			TMP_CharacterInfo.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "character");
			TMP_CharacterInfo.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "index");
			TMP_CharacterInfo.NativeFieldInfoPtr_stringLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "stringLength");
			TMP_CharacterInfo.NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "elementType");
			TMP_CharacterInfo.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "textElement");
			TMP_CharacterInfo.NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "fontAsset");
			TMP_CharacterInfo.NativeFieldInfoPtr_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "spriteAsset");
			TMP_CharacterInfo.NativeFieldInfoPtr_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "spriteIndex");
			TMP_CharacterInfo.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "material");
			TMP_CharacterInfo.NativeFieldInfoPtr_materialReferenceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "materialReferenceIndex");
			TMP_CharacterInfo.NativeFieldInfoPtr_isUsingAlternateTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "isUsingAlternateTypeface");
			TMP_CharacterInfo.NativeFieldInfoPtr_pointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "pointSize");
			TMP_CharacterInfo.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "lineNumber");
			TMP_CharacterInfo.NativeFieldInfoPtr_pageNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "pageNumber");
			TMP_CharacterInfo.NativeFieldInfoPtr_vertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "vertexIndex");
			TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "vertex_BL");
			TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "vertex_TL");
			TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "vertex_TR");
			TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "vertex_BR");
			TMP_CharacterInfo.NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "topLeft");
			TMP_CharacterInfo.NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "bottomLeft");
			TMP_CharacterInfo.NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "topRight");
			TMP_CharacterInfo.NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "bottomRight");
			TMP_CharacterInfo.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "origin");
			TMP_CharacterInfo.NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "xAdvance");
			TMP_CharacterInfo.NativeFieldInfoPtr_ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "ascender");
			TMP_CharacterInfo.NativeFieldInfoPtr_baseLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "baseLine");
			TMP_CharacterInfo.NativeFieldInfoPtr_descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "descender");
			TMP_CharacterInfo.NativeFieldInfoPtr_adjustedAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "adjustedAscender");
			TMP_CharacterInfo.NativeFieldInfoPtr_adjustedDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "adjustedDescender");
			TMP_CharacterInfo.NativeFieldInfoPtr_aspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "aspectRatio");
			TMP_CharacterInfo.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "scale");
			TMP_CharacterInfo.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "color");
			TMP_CharacterInfo.NativeFieldInfoPtr_underlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "underlineColor");
			TMP_CharacterInfo.NativeFieldInfoPtr_underlineVertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "underlineVertexIndex");
			TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "strikethroughColor");
			TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughVertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "strikethroughVertexIndex");
			TMP_CharacterInfo.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "highlightColor");
			TMP_CharacterInfo.NativeFieldInfoPtr_highlightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "highlightState");
			TMP_CharacterInfo.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "style");
			TMP_CharacterInfo.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "isVisible");
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002482 File Offset: 0x00000682
		public TMP_CharacterInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000248B File Offset: 0x0000068B
		public TMP_CharacterInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000CA00 File Offset: 0x0000AC00
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000249D File Offset: 0x0000069D
		public unsafe char character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_character);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_character)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000CA28 File Offset: 0x0000AC28
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000024B8 File Offset: 0x000006B8
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000CA50 File Offset: 0x0000AC50
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000024D3 File Offset: 0x000006D3
		public unsafe int stringLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_stringLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_stringLength)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000CA78 File Offset: 0x0000AC78
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000024EE File Offset: 0x000006EE
		public unsafe TMP_TextElementType elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_elementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_elementType)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002509 File Offset: 0x00000709
		public unsafe TMP_TextElement textElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_textElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000CAD0 File Offset: 0x0000ACD0
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002528 File Offset: 0x00000728
		public unsafe TMP_FontAsset fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000CB00 File Offset: 0x0000AD00
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002547 File Offset: 0x00000747
		public unsafe TMP_SpriteAsset spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000CB30 File Offset: 0x0000AD30
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002566 File Offset: 0x00000766
		public unsafe int spriteIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_spriteIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_spriteIndex)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000CB58 File Offset: 0x0000AD58
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002581 File Offset: 0x00000781
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000CB88 File Offset: 0x0000AD88
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000025A0 File Offset: 0x000007A0
		public unsafe int materialReferenceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_materialReferenceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_materialReferenceIndex)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000CBB0 File Offset: 0x0000ADB0
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000025BB File Offset: 0x000007BB
		public unsafe bool isUsingAlternateTypeface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_isUsingAlternateTypeface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_isUsingAlternateTypeface)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x000025D6 File Offset: 0x000007D6
		public unsafe float pointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_pointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_pointSize)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000CC00 File Offset: 0x0000AE00
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x000025F1 File Offset: 0x000007F1
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000CC28 File Offset: 0x0000AE28
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000260C File Offset: 0x0000080C
		public unsafe int pageNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_pageNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_pageNumber)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000CC50 File Offset: 0x0000AE50
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002627 File Offset: 0x00000827
		public unsafe int vertexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertexIndex)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000CC78 File Offset: 0x0000AE78
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002642 File Offset: 0x00000842
		public unsafe TMP_Vertex vertex_BL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BL)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000265D File Offset: 0x0000085D
		public unsafe TMP_Vertex vertex_TL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TL)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000CCC8 File Offset: 0x0000AEC8
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002678 File Offset: 0x00000878
		public unsafe TMP_Vertex vertex_TR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TR)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002693 File Offset: 0x00000893
		public unsafe TMP_Vertex vertex_BR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BR)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000CD18 File Offset: 0x0000AF18
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000026AE File Offset: 0x000008AE
		public unsafe Vector3 topLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_topLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_topLeft)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000CD40 File Offset: 0x0000AF40
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000026C9 File Offset: 0x000008C9
		public unsafe Vector3 bottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_bottomLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_bottomLeft)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000CD68 File Offset: 0x0000AF68
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000026E4 File Offset: 0x000008E4
		public unsafe Vector3 topRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_topRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_topRight)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000CD90 File Offset: 0x0000AF90
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000026FF File Offset: 0x000008FF
		public unsafe Vector3 bottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_bottomRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_bottomRight)) = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000271A File Offset: 0x0000091A
		public unsafe float origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_origin)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002735 File Offset: 0x00000935
		public unsafe float xAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_xAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_xAdvance)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000CE08 File Offset: 0x0000B008
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002750 File Offset: 0x00000950
		public unsafe float ascender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_ascender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_ascender)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000CE30 File Offset: 0x0000B030
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000276B File Offset: 0x0000096B
		public unsafe float baseLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_baseLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_baseLine)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000CE58 File Offset: 0x0000B058
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002786 File Offset: 0x00000986
		public unsafe float descender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_descender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_descender)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000CE80 File Offset: 0x0000B080
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000027A1 File Offset: 0x000009A1
		public unsafe float adjustedAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_adjustedAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_adjustedAscender)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000027BC File Offset: 0x000009BC
		public unsafe float adjustedDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_adjustedDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_adjustedDescender)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000027D7 File Offset: 0x000009D7
		public unsafe float aspectRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_aspectRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_aspectRatio)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000027F2 File Offset: 0x000009F2
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000CF20 File Offset: 0x0000B120
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000280D File Offset: 0x00000A0D
		public unsafe Color32 color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000CF48 File Offset: 0x0000B148
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002828 File Offset: 0x00000A28
		public unsafe Color32 underlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_underlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_underlineColor)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000CF70 File Offset: 0x0000B170
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002843 File Offset: 0x00000A43
		public unsafe int underlineVertexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_underlineVertexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_underlineVertexIndex)) = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000CF98 File Offset: 0x0000B198
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000285E File Offset: 0x00000A5E
		public unsafe Color32 strikethroughColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughColor)) = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002879 File Offset: 0x00000A79
		public unsafe int strikethroughVertexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughVertexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughVertexIndex)) = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000CFE8 File Offset: 0x0000B1E8
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002894 File Offset: 0x00000A94
		public unsafe Color32 highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_highlightColor)) = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000D010 File Offset: 0x0000B210
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000028AF File Offset: 0x00000AAF
		public unsafe HighlightState highlightState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_highlightState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_highlightState)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000D038 File Offset: 0x0000B238
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000028CA File Offset: 0x00000ACA
		public unsafe FontStyles style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_style);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_style)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000D060 File Offset: 0x0000B260
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000028E5 File Offset: 0x00000AE5
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_character;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_stringLength;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_elementType;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_textElement;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_spriteAsset;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_spriteIndex;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_materialReferenceIndex;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_isUsingAlternateTypeface;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_pointSize;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_pageNumber;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_vertexIndex;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_vertex_BL;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_vertex_TL;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_vertex_TR;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_vertex_BR;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_topLeft;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_bottomLeft;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_topRight;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_bottomRight;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_origin;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_xAdvance;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_ascender;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_baseLine;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_descender;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_adjustedAscender;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_adjustedDescender;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_aspectRatio;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_underlineColor;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_underlineVertexIndex;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughColor;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughVertexIndex;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_highlightState;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_style;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;
	}
}
