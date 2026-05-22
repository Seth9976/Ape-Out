using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	[StructLayout(2)]
	public struct ColorBlock
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00008200 File Offset: 0x00006400
		// Note: this type is marked as 'beforefieldinit'.
		static ColorBlock()
		{
			Il2CppClassPointerStore<ColorBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ColorBlock");
			ColorBlock.NativeFieldInfoPtr_m_NormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, "m_NormalColor");
			ColorBlock.NativeFieldInfoPtr_m_HighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, "m_HighlightedColor");
			ColorBlock.NativeFieldInfoPtr_m_PressedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, "m_PressedColor");
			ColorBlock.NativeFieldInfoPtr_m_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, "m_SelectedColor");
			ColorBlock.NativeFieldInfoPtr_m_DisabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, "m_DisabledColor");
			ColorBlock.NativeFieldInfoPtr_m_ColorMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, "m_ColorMultiplier");
			ColorBlock.NativeFieldInfoPtr_m_FadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, "m_FadeDuration");
			ColorBlock.NativeFieldInfoPtr_defaultColorBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, "defaultColorBlock");
			ColorBlock.NativeMethodInfoPtr_get_normalColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663349);
			ColorBlock.NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663350);
			ColorBlock.NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663351);
			ColorBlock.NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663352);
			ColorBlock.NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663353);
			ColorBlock.NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663354);
			ColorBlock.NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663355);
			ColorBlock.NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663356);
			ColorBlock.NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663357);
			ColorBlock.NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663358);
			ColorBlock.NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663359);
			ColorBlock.NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663360);
			ColorBlock.NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663361);
			ColorBlock.NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663362);
			ColorBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663364);
			ColorBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663365);
			ColorBlock.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ColorBlock_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663366);
			ColorBlock.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ColorBlock_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663367);
			ColorBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, 100663368);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00008444 File Offset: 0x00006644
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00008474 File Offset: 0x00006674
		public unsafe Color normalColor
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_get_normalColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000084A8 File Offset: 0x000066A8
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000084D8 File Offset: 0x000066D8
		public unsafe Color highlightedColor
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000850C File Offset: 0x0000670C
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000853C File Offset: 0x0000673C
		public unsafe Color pressedColor
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00008570 File Offset: 0x00006770
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000085A0 File Offset: 0x000067A0
		public unsafe Color selectedColor
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000085D4 File Offset: 0x000067D4
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00008604 File Offset: 0x00006804
		public unsafe Color disabledColor
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00008638 File Offset: 0x00006838
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00008668 File Offset: 0x00006868
		public unsafe float colorMultiplier
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000869C File Offset: 0x0000689C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000086CC File Offset: 0x000068CC
		public unsafe float fadeDuration
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008700 File Offset: 0x00006900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516201, XrefRangeEnd = 516204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00008744 File Offset: 0x00006944
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 516204, RefRangeEnd = 516207, XrefRangeStart = 516204, XrefRangeEnd = 516204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ColorBlock other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ColorBlock_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00008784 File Offset: 0x00006984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516207, XrefRangeEnd = 516208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ColorBlock point1, ColorBlock point2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ColorBlock_ColorBlock_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000087D0 File Offset: 0x000069D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516208, XrefRangeEnd = 516209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ColorBlock point1, ColorBlock point2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ColorBlock_ColorBlock_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000881C File Offset: 0x00006A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516209, XrefRangeEnd = 516214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002251 File Offset: 0x00000451
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorBlock>.NativeClassPtr, ref this));
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000884C File Offset: 0x00006A4C
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002263 File Offset: 0x00000463
		public unsafe static ColorBlock defaultColorBlock
		{
			get
			{
				ColorBlock colorBlock;
				IL2CPP.il2cpp_field_static_get_value(ColorBlock.NativeFieldInfoPtr_defaultColorBlock, (void*)(&colorBlock));
				return colorBlock;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorBlock.NativeFieldInfoPtr_defaultColorBlock, (void*)(&value));
			}
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalColor;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightedColor;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_m_PressedColor;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedColor;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_m_DisabledColor;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorMultiplier;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_m_FadeDuration;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_defaultColorBlock;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_normalColor_Public_get_Color_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ColorBlock_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ColorBlock_ColorBlock_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ColorBlock_ColorBlock_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000062 RID: 98
		[FieldOffset(0)]
		public Color m_NormalColor;

		// Token: 0x04000063 RID: 99
		[FieldOffset(16)]
		public Color m_HighlightedColor;

		// Token: 0x04000064 RID: 100
		[FieldOffset(32)]
		public Color m_PressedColor;

		// Token: 0x04000065 RID: 101
		[FieldOffset(48)]
		public Color m_SelectedColor;

		// Token: 0x04000066 RID: 102
		[FieldOffset(64)]
		public Color m_DisabledColor;

		// Token: 0x04000067 RID: 103
		[FieldOffset(80)]
		public float m_ColorMultiplier;

		// Token: 0x04000068 RID: 104
		[FieldOffset(84)]
		public float m_FadeDuration;
	}
}
