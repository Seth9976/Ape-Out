using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public sealed class TextMesh : Component
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00003EFC File Offset: 0x000020FC
		// Note: this type is marked as 'beforefieldinit'.
		static TextMesh()
		{
			Il2CppClassPointerStore<TextMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "TextMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMesh>.NativeClassPtr);
			TextMesh.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663331);
			TextMesh.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663332);
			TextMesh.NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663333);
			TextMesh.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663334);
			TextMesh.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663335);
			TextMesh.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663336);
			TextMesh.NativeMethodInfoPtr_get_alignment_Public_get_TextAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663337);
			TextMesh.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663338);
			TextMesh.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663339);
			TextMesh.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663340);
			TextMesh.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663341);
			TextMesh.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663342);
			TextMesh.get_fontStyleDelegateField = IL2CPP.ResolveICall<TextMesh.get_fontStyleDelegate>("UnityEngine.TextMesh::get_fontStyle");
			TextMesh.set_fontStyleDelegateField = IL2CPP.ResolveICall<TextMesh.set_fontStyleDelegate>("UnityEngine.TextMesh::set_fontStyle");
			TextMesh.get_offsetZDelegateField = IL2CPP.ResolveICall<TextMesh.get_offsetZDelegate>("UnityEngine.TextMesh::get_offsetZ");
			TextMesh.set_offsetZDelegateField = IL2CPP.ResolveICall<TextMesh.set_offsetZDelegate>("UnityEngine.TextMesh::set_offsetZ");
			TextMesh.get_anchorDelegateField = IL2CPP.ResolveICall<TextMesh.get_anchorDelegate>("UnityEngine.TextMesh::get_anchor");
			TextMesh.set_anchorDelegateField = IL2CPP.ResolveICall<TextMesh.set_anchorDelegate>("UnityEngine.TextMesh::set_anchor");
			TextMesh.get_characterSizeDelegateField = IL2CPP.ResolveICall<TextMesh.get_characterSizeDelegate>("UnityEngine.TextMesh::get_characterSize");
			TextMesh.set_characterSizeDelegateField = IL2CPP.ResolveICall<TextMesh.set_characterSizeDelegate>("UnityEngine.TextMesh::set_characterSize");
			TextMesh.get_lineSpacingDelegateField = IL2CPP.ResolveICall<TextMesh.get_lineSpacingDelegate>("UnityEngine.TextMesh::get_lineSpacing");
			TextMesh.set_lineSpacingDelegateField = IL2CPP.ResolveICall<TextMesh.set_lineSpacingDelegate>("UnityEngine.TextMesh::set_lineSpacing");
			TextMesh.get_tabSizeDelegateField = IL2CPP.ResolveICall<TextMesh.get_tabSizeDelegate>("UnityEngine.TextMesh::get_tabSize");
			TextMesh.set_tabSizeDelegateField = IL2CPP.ResolveICall<TextMesh.set_tabSizeDelegate>("UnityEngine.TextMesh::set_tabSize");
			TextMesh.get_richTextDelegateField = IL2CPP.ResolveICall<TextMesh.get_richTextDelegate>("UnityEngine.TextMesh::get_richText");
			TextMesh.set_richTextDelegateField = IL2CPP.ResolveICall<TextMesh.set_richTextDelegate>("UnityEngine.TextMesh::set_richText");
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000040F0 File Offset: 0x000022F0
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00004128 File Offset: 0x00002328
		public unsafe string text
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515460, XrefRangeEnd = 515464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 515468, RefRangeEnd = 515480, XrefRangeStart = 515464, XrefRangeEnd = 515468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000416C File Offset: 0x0000236C
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000041AC File Offset: 0x000023AC
		public unsafe Font font
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 515484, RefRangeEnd = 515485, XrefRangeStart = 515480, XrefRangeEnd = 515484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515485, XrefRangeEnd = 515489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000041F0 File Offset: 0x000023F0
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000422C File Offset: 0x0000242C
		public unsafe int fontSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515489, XrefRangeEnd = 515493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 515497, RefRangeEnd = 515498, XrefRangeStart = 515493, XrefRangeEnd = 515497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000426C File Offset: 0x0000246C
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000042A8 File Offset: 0x000024A8
		public unsafe TextAlignment alignment
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 515502, RefRangeEnd = 515503, XrefRangeStart = 515498, XrefRangeEnd = 515502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_get_alignment_Public_get_TextAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515503, XrefRangeEnd = 515507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000042E8 File Offset: 0x000024E8
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00004324 File Offset: 0x00002524
		public unsafe Color color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515507, XrefRangeEnd = 515509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515509, XrefRangeEnd = 515511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004364 File Offset: 0x00002564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515511, XrefRangeEnd = 515515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_color_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000043A4 File Offset: 0x000025A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515515, XrefRangeEnd = 515536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_color_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMesh.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000023CE File Offset: 0x000005CE
		public TextMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000023D7 File Offset: 0x000005D7
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000023E9 File Offset: 0x000005E9
		public FontStyle fontStyle
		{
			get
			{
				return TextMesh.get_fontStyleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_fontStyleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000023FC File Offset: 0x000005FC
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000240E File Offset: 0x0000060E
		public float offsetZ
		{
			get
			{
				return TextMesh.get_offsetZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_offsetZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002421 File Offset: 0x00000621
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002433 File Offset: 0x00000633
		public TextAnchor anchor
		{
			get
			{
				return TextMesh.get_anchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_anchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002446 File Offset: 0x00000646
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002458 File Offset: 0x00000658
		public float characterSize
		{
			get
			{
				return TextMesh.get_characterSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_characterSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000246B File Offset: 0x0000066B
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000247D File Offset: 0x0000067D
		public float lineSpacing
		{
			get
			{
				return TextMesh.get_lineSpacingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_lineSpacingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002490 File Offset: 0x00000690
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000024A2 File Offset: 0x000006A2
		public float tabSize
		{
			get
			{
				return TextMesh.get_tabSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_tabSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000024B5 File Offset: 0x000006B5
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000024C7 File Offset: 0x000006C7
		public bool richText
		{
			get
			{
				return TextMesh.get_richTextDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_richTextDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_Font_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Public_get_TextAlignment_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignment_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x0400006F RID: 111
		private static readonly TextMesh.get_fontStyleDelegate get_fontStyleDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly TextMesh.set_fontStyleDelegate set_fontStyleDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly TextMesh.get_offsetZDelegate get_offsetZDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly TextMesh.set_offsetZDelegate set_offsetZDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly TextMesh.get_anchorDelegate get_anchorDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly TextMesh.set_anchorDelegate set_anchorDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly TextMesh.get_characterSizeDelegate get_characterSizeDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly TextMesh.set_characterSizeDelegate set_characterSizeDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly TextMesh.get_lineSpacingDelegate get_lineSpacingDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly TextMesh.set_lineSpacingDelegate set_lineSpacingDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly TextMesh.get_tabSizeDelegate get_tabSizeDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly TextMesh.set_tabSizeDelegate set_tabSizeDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly TextMesh.get_richTextDelegate get_richTextDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly TextMesh.set_richTextDelegate set_richTextDelegateField;

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000D7 RID: 215
		private delegate FontStyle get_fontStyleDelegate(IntPtr @this);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000D9 RID: 217
		private delegate void set_fontStyleDelegate(IntPtr @this, FontStyle value);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000DB RID: 219
		private delegate float get_offsetZDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000DD RID: 221
		private delegate void set_offsetZDelegate(IntPtr @this, float value);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000DF RID: 223
		private delegate TextAnchor get_anchorDelegate(IntPtr @this);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000E1 RID: 225
		private delegate void set_anchorDelegate(IntPtr @this, TextAnchor value);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000E3 RID: 227
		private delegate float get_characterSizeDelegate(IntPtr @this);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000E5 RID: 229
		private delegate void set_characterSizeDelegate(IntPtr @this, float value);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000E7 RID: 231
		private delegate float get_lineSpacingDelegate(IntPtr @this);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060000E9 RID: 233
		private delegate void set_lineSpacingDelegate(IntPtr @this, float value);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000EB RID: 235
		private delegate float get_tabSizeDelegate(IntPtr @this);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060000ED RID: 237
		private delegate void set_tabSizeDelegate(IntPtr @this, float value);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000EF RID: 239
		private delegate bool get_richTextDelegate(IntPtr @this);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060000F1 RID: 241
		private delegate void set_richTextDelegate(IntPtr @this, bool value);
	}
}
