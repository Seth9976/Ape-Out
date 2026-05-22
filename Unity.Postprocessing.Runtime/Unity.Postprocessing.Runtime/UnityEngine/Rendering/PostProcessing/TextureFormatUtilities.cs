using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000065 RID: 101
	public static class TextureFormatUtilities : Object
	{
		// Token: 0x060006A4 RID: 1700 RVA: 0x0001A048 File Offset: 0x00018248
		// Note: this type is marked as 'beforefieldinit'.
		static TextureFormatUtilities()
		{
			Il2CppClassPointerStore<TextureFormatUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "TextureFormatUtilities");
			TextureFormatUtilities.NativeFieldInfoPtr_s_FormatAliasMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureFormatUtilities>.NativeClassPtr, "s_FormatAliasMap");
			TextureFormatUtilities.NativeFieldInfoPtr_s_SupportedRenderTextureFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureFormatUtilities>.NativeClassPtr, "s_SupportedRenderTextureFormats");
			TextureFormatUtilities.NativeFieldInfoPtr_s_SupportedTextureFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureFormatUtilities>.NativeClassPtr, "s_SupportedTextureFormats");
			TextureFormatUtilities.NativeMethodInfoPtr_IsObsolete_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureFormatUtilities>.NativeClassPtr, 100663884);
			TextureFormatUtilities.NativeMethodInfoPtr_GetUncompressedRenderTextureFormat_Public_Static_RenderTextureFormat_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureFormatUtilities>.NativeClassPtr, 100663885);
			TextureFormatUtilities.NativeMethodInfoPtr_IsSupported_Internal_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureFormatUtilities>.NativeClassPtr, 100663886);
			TextureFormatUtilities.NativeMethodInfoPtr_IsSupported_Internal_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureFormatUtilities>.NativeClassPtr, 100663887);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001A0FC File Offset: 0x000182FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449932, XrefRangeEnd = 449942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsObsolete(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureFormatUtilities.NativeMethodInfoPtr_IsObsolete_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001A140 File Offset: 0x00018340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 449955, RefRangeEnd = 449956, XrefRangeStart = 449942, XrefRangeEnd = 449955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureFormatUtilities.NativeMethodInfoPtr_GetUncompressedRenderTextureFormat_Public_Static_RenderTextureFormat_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001A184 File Offset: 0x00018384
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 449962, RefRangeEnd = 449974, XrefRangeStart = 449956, XrefRangeEnd = 449962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSupported(this RenderTextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureFormatUtilities.NativeMethodInfoPtr_IsSupported_Internal_Static_Boolean_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001A1C4 File Offset: 0x000183C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449974, XrefRangeEnd = 449980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSupported(this TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureFormatUtilities.NativeMethodInfoPtr_IsSupported_Internal_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000054F1 File Offset: 0x000036F1
		public TextureFormatUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0001A204 File Offset: 0x00018404
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x000054FA File Offset: 0x000036FA
		public unsafe static Dictionary<int, RenderTextureFormat> s_FormatAliasMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureFormatUtilities.NativeFieldInfoPtr_s_FormatAliasMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, RenderTextureFormat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureFormatUtilities.NativeFieldInfoPtr_s_FormatAliasMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x0001A22C File Offset: 0x0001842C
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x0000550C File Offset: 0x0000370C
		public unsafe static Dictionary<int, bool> s_SupportedRenderTextureFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureFormatUtilities.NativeFieldInfoPtr_s_SupportedRenderTextureFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureFormatUtilities.NativeFieldInfoPtr_s_SupportedRenderTextureFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x0001A254 File Offset: 0x00018454
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x0000551E File Offset: 0x0000371E
		public unsafe static Dictionary<int, bool> s_SupportedTextureFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureFormatUtilities.NativeFieldInfoPtr_s_SupportedTextureFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureFormatUtilities.NativeFieldInfoPtr_s_SupportedTextureFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr_s_FormatAliasMap;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_s_SupportedRenderTextureFormats;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr_s_SupportedTextureFormats;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_IsObsolete_Private_Static_Boolean_Object_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_GetUncompressedRenderTextureFormat_Public_Static_RenderTextureFormat_Texture_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_IsSupported_Internal_Static_Boolean_RenderTextureFormat_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_IsSupported_Internal_Static_Boolean_TextureFormat_0;
	}
}
