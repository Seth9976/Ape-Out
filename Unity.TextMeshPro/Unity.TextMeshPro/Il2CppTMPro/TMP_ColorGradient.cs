using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class TMP_ColorGradient : ScriptableObject
	{
		// Token: 0x060000FB RID: 251 RVA: 0x0000D088 File Offset: 0x0000B288
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_ColorGradient()
		{
			Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_ColorGradient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr);
			TMP_ColorGradient.NativeFieldInfoPtr_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "colorMode");
			TMP_ColorGradient.NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "topLeft");
			TMP_ColorGradient.NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "topRight");
			TMP_ColorGradient.NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "bottomLeft");
			TMP_ColorGradient.NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "bottomRight");
			TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "k_DefaultColorMode");
			TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "k_DefaultColor");
			TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, 100663376);
			TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, 100663377);
			TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, 100663378);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000D180 File Offset: 0x0000B380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450494, XrefRangeEnd = 450502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ColorGradient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000D1BC File Offset: 0x0000B3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450502, XrefRangeEnd = 450503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ColorGradient(Color color)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000D204 File Offset: 0x0000B404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450503, XrefRangeEnd = 450504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002900 File Offset: 0x00000B00
		public TMP_ColorGradient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000D278 File Offset: 0x0000B478
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002909 File Offset: 0x00000B09
		public unsafe ColorMode colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_colorMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_colorMode)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000D2A0 File Offset: 0x0000B4A0
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002924 File Offset: 0x00000B24
		public unsafe Color topLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topLeft)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000D2C8 File Offset: 0x0000B4C8
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0000293F File Offset: 0x00000B3F
		public unsafe Color topRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topRight)) = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000295A File Offset: 0x00000B5A
		public unsafe Color bottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomLeft)) = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000D318 File Offset: 0x0000B518
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002975 File Offset: 0x00000B75
		public unsafe Color bottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomRight)) = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000D340 File Offset: 0x0000B540
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002990 File Offset: 0x00000B90
		public unsafe static ColorMode k_DefaultColorMode
		{
			get
			{
				ColorMode colorMode;
				IL2CPP.il2cpp_field_static_get_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColorMode, (void*)(&colorMode));
				return colorMode;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColorMode, (void*)(&value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000D35C File Offset: 0x0000B55C
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000299E File Offset: 0x00000B9E
		public unsafe static Color k_DefaultColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColor, (void*)(&value));
			}
		}

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_colorMode;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_topLeft;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_topRight;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_bottomLeft;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_bottomRight;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultColorMode;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultColor;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0;
	}
}
