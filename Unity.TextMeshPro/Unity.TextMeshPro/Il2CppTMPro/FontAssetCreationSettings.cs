using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x0200001D RID: 29
	[Serializable]
	public sealed class FontAssetCreationSettings : ValueType
	{
		// Token: 0x060002DC RID: 732 RVA: 0x00013798 File Offset: 0x00011998
		// Note: this type is marked as 'beforefieldinit'.
		static FontAssetCreationSettings()
		{
			Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "FontAssetCreationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr);
			FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "sourceFontFileName");
			FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "sourceFontFileGUID");
			FontAssetCreationSettings.NativeFieldInfoPtr_pointSizeSamplingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "pointSizeSamplingMode");
			FontAssetCreationSettings.NativeFieldInfoPtr_pointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "pointSize");
			FontAssetCreationSettings.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "padding");
			FontAssetCreationSettings.NativeFieldInfoPtr_packingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "packingMode");
			FontAssetCreationSettings.NativeFieldInfoPtr_atlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "atlasWidth");
			FontAssetCreationSettings.NativeFieldInfoPtr_atlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "atlasHeight");
			FontAssetCreationSettings.NativeFieldInfoPtr_characterSetSelectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "characterSetSelectionMode");
			FontAssetCreationSettings.NativeFieldInfoPtr_characterSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "characterSequence");
			FontAssetCreationSettings.NativeFieldInfoPtr_referencedFontAssetGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "referencedFontAssetGUID");
			FontAssetCreationSettings.NativeFieldInfoPtr_referencedTextAssetGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "referencedTextAssetGUID");
			FontAssetCreationSettings.NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "fontStyle");
			FontAssetCreationSettings.NativeFieldInfoPtr_fontStyleModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "fontStyleModifier");
			FontAssetCreationSettings.NativeFieldInfoPtr_renderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "renderMode");
			FontAssetCreationSettings.NativeFieldInfoPtr_includeFontFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "includeFontFeatures");
			FontAssetCreationSettings.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, 100663624);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0001391C File Offset: 0x00011B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453580, XrefRangeEnd = 453584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceFontFileGUID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSizeSamplingMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasWidth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasHeight;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterSelectionMode;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(characterSet);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAssetCreationSettings.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00003705 File Offset: 0x00001905
		public FontAssetCreationSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000370E File Offset: 0x0000190E
		public FontAssetCreationSettings()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr))
		{
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x000139F4 File Offset: 0x00011BF4
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00003720 File Offset: 0x00001920
		public unsafe string sourceFontFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00013A1C File Offset: 0x00011C1C
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000373F File Offset: 0x0000193F
		public unsafe string sourceFontFileGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00013A44 File Offset: 0x00011C44
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x0000375E File Offset: 0x0000195E
		public unsafe int pointSizeSamplingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_pointSizeSamplingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_pointSizeSamplingMode)) = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00013A6C File Offset: 0x00011C6C
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00003779 File Offset: 0x00001979
		public unsafe int pointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_pointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_pointSize)) = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00013A94 File Offset: 0x00011C94
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00003794 File Offset: 0x00001994
		public unsafe int padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_padding)) = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00013ABC File Offset: 0x00011CBC
		// (set) Token: 0x060002EB RID: 747 RVA: 0x000037AF File Offset: 0x000019AF
		public unsafe int packingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_packingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_packingMode)) = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00013AE4 File Offset: 0x00011CE4
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000037CA File Offset: 0x000019CA
		public unsafe int atlasWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_atlasWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_atlasWidth)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00013B0C File Offset: 0x00011D0C
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000037E5 File Offset: 0x000019E5
		public unsafe int atlasHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_atlasHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_atlasHeight)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00013B34 File Offset: 0x00011D34
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00003800 File Offset: 0x00001A00
		public unsafe int characterSetSelectionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_characterSetSelectionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_characterSetSelectionMode)) = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00013B5C File Offset: 0x00011D5C
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x0000381B File Offset: 0x00001A1B
		public unsafe string characterSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_characterSequence);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_characterSequence), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00013B84 File Offset: 0x00011D84
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000383A File Offset: 0x00001A3A
		public unsafe string referencedFontAssetGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_referencedFontAssetGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_referencedFontAssetGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00013BAC File Offset: 0x00011DAC
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00003859 File Offset: 0x00001A59
		public unsafe string referencedTextAssetGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_referencedTextAssetGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_referencedTextAssetGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00013BD4 File Offset: 0x00011DD4
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00003878 File Offset: 0x00001A78
		public unsafe int fontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_fontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_fontStyle)) = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00013BFC File Offset: 0x00011DFC
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00003893 File Offset: 0x00001A93
		public unsafe float fontStyleModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_fontStyleModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_fontStyleModifier)) = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00013C24 File Offset: 0x00011E24
		// (set) Token: 0x060002FD RID: 765 RVA: 0x000038AE File Offset: 0x00001AAE
		public unsafe int renderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_renderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_renderMode)) = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00013C4C File Offset: 0x00011E4C
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000038C9 File Offset: 0x00001AC9
		public unsafe bool includeFontFeatures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_includeFontFeatures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_includeFontFeatures)) = value;
			}
		}

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_sourceFontFileName;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_sourceFontFileGUID;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_pointSizeSamplingMode;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_pointSize;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_padding;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_packingMode;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_atlasWidth;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_atlasHeight;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_characterSetSelectionMode;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_characterSequence;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_referencedFontAssetGUID;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_referencedTextAssetGUID;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_fontStyle;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_fontStyleModifier;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_renderMode;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_includeFontFeatures;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_Int32_0;
	}
}
