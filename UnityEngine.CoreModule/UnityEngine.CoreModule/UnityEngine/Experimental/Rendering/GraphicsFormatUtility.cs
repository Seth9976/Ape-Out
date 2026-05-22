using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020001AE RID: 430
	public class GraphicsFormatUtility : Object
	{
		// Token: 0x06001F5B RID: 8027 RVA: 0x00073348 File Offset: 0x00071548
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsFormatUtility()
		{
			Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "GraphicsFormatUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666174);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666175);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666176);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666177);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666178);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666179);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666180);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedTextureFormat_Internal_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666181);
			GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666182);
			GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666183);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666184);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100666185);
			GraphicsFormatUtility.GetFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetFormat");
			GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetTextureFormat_Native_GraphicsFormat");
			GraphicsFormatUtility.IsSwizzleFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSwizzleFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSwizzleFormat");
			GraphicsFormatUtility.GetSRGBFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetSRGBFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetSRGBFormat");
			GraphicsFormatUtility.GetLinearFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetLinearFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetLinearFormat");
			GraphicsFormatUtility.GetColorComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetColorComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetColorComponentCount");
			GraphicsFormatUtility.GetAlphaComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetAlphaComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetAlphaComponentCount");
			GraphicsFormatUtility.GetComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetComponentCount");
			GraphicsFormatUtility.GetFormatStringDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetFormatStringDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetFormatString");
			GraphicsFormatUtility.IsCompressedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsCompressedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsCompressedFormat");
			GraphicsFormatUtility.IsPackedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsPackedFormat");
			GraphicsFormatUtility.Is16BitPackedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.Is16BitPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::Is16BitPackedFormat");
			GraphicsFormatUtility.ConvertToAlphaFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ConvertToAlphaFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ConvertToAlphaFormat");
			GraphicsFormatUtility.IsAlphaOnlyFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsAlphaOnlyFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaOnlyFormat");
			GraphicsFormatUtility.IsAlphaTestFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsAlphaTestFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaTestFormat");
			GraphicsFormatUtility.HasAlphaChannelDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.HasAlphaChannelDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::HasAlphaChannel");
			GraphicsFormatUtility.IsDepthFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsDepthFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsDepthFormat");
			GraphicsFormatUtility.IsStencilFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsStencilFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsStencilFormat");
			GraphicsFormatUtility.IsIEEE754FormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsIEEE754FormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIEEE754Format");
			GraphicsFormatUtility.IsFloatFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsFloatFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsFloatFormat");
			GraphicsFormatUtility.IsHalfFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsHalfFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHalfFormat");
			GraphicsFormatUtility.IsUnsignedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUnsignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUnsignedFormat");
			GraphicsFormatUtility.IsSignedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSignedFormat");
			GraphicsFormatUtility.IsNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsNormFormat");
			GraphicsFormatUtility.IsUNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUNormFormat");
			GraphicsFormatUtility.IsSNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSNormFormat");
			GraphicsFormatUtility.IsIntegerFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsIntegerFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIntegerFormat");
			GraphicsFormatUtility.IsUIntFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUIntFormat");
			GraphicsFormatUtility.IsSIntFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSIntFormat");
			GraphicsFormatUtility.IsXRFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsXRFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsXRFormat");
			GraphicsFormatUtility.IsDXTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsDXTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsDXTCFormat");
			GraphicsFormatUtility.IsRGTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsRGTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsRGTCFormat");
			GraphicsFormatUtility.IsBPTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsBPTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBPTCFormat");
			GraphicsFormatUtility.IsBCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsBCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBCFormat");
			GraphicsFormatUtility.IsETCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsETCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsETCFormat");
			GraphicsFormatUtility.IsEACFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsEACFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsEACFormat");
			GraphicsFormatUtility.IsASTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsASTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsASTCFormat");
			GraphicsFormatUtility.GetSwizzleRDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetSwizzleRDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetSwizzleR");
			GraphicsFormatUtility.GetSwizzleGDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetSwizzleGDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetSwizzleG");
			GraphicsFormatUtility.GetSwizzleBDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetSwizzleBDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetSwizzleB");
			GraphicsFormatUtility.GetSwizzleADelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetSwizzleADelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetSwizzleA");
			GraphicsFormatUtility.GetBlockSizeDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockSizeDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockSize");
			GraphicsFormatUtility.GetBlockWidthDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockWidthDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockWidth");
			GraphicsFormatUtility.GetBlockHeightDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockHeightDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockHeight");
			GraphicsFormatUtility.ComputeMipmapSize_Native_2DDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ComputeMipmapSize_Native_2DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipmapSize_Native_2D");
			GraphicsFormatUtility.ComputeMipmapSize_Native_3DDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ComputeMipmapSize_Native_3DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipmapSize_Native_3D");
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0007371C File Offset: 0x0007191C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504756, RefRangeEnd = 504757, XrefRangeStart = 504752, XrefRangeEnd = 504756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00073768 File Offset: 0x00071968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504756, RefRangeEnd = 504757, XrefRangeStart = 504756, XrefRangeEnd = 504757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000737B4 File Offset: 0x000719B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504757, XrefRangeEnd = 504761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00073800 File Offset: 0x00071A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x0007384C File Offset: 0x00071A4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 504770, RefRangeEnd = 504773, XrefRangeStart = 504761, XrefRangeEnd = 504770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00073898 File Offset: 0x00071A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504773, XrefRangeEnd = 504777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSRGBFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000738D8 File Offset: 0x00071AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504777, XrefRangeEnd = 504781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00073918 File Offset: 0x00071B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504781, XrefRangeEnd = 504785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompressedTextureFormat(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedTextureFormat_Internal_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00073958 File Offset: 0x00071B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504785, XrefRangeEnd = 504789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeImage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x000739A4 File Offset: 0x00071BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504789, XrefRangeEnd = 504793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanDecompressFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x000739E4 File Offset: 0x00071BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504793, XrefRangeEnd = 504797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPVRTCFormat(GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00073A24 File Offset: 0x00071C24
		[CallerCount(0)]
		public unsafe static bool IsCrunchFormat(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x0001036D File Offset: 0x0000E56D
		public GraphicsFormatUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x00010376 File Offset: 0x0000E576
		public static GraphicsFormat GetFormat(Texture texture)
		{
			return GraphicsFormatUtility.GetFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00073A64 File Offset: 0x00071C64
		public static TextureFormat GetTextureFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormat(format);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00010388 File Offset: 0x0000E588
		public static TextureFormat GetTextureFormat_Native_GraphicsFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegateField(format);
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00010395 File Offset: 0x0000E595
		public static bool IsSwizzleFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSwizzleFormatDelegateField(format);
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x000103A2 File Offset: 0x0000E5A2
		public static GraphicsFormat GetSRGBFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetSRGBFormatDelegateField(format);
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x000103AF File Offset: 0x0000E5AF
		public static GraphicsFormat GetLinearFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetLinearFormatDelegateField(format);
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000103BC File Offset: 0x0000E5BC
		public static uint GetColorComponentCount(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetColorComponentCountDelegateField(format);
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x000103C9 File Offset: 0x0000E5C9
		public static uint GetAlphaComponentCount(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetAlphaComponentCountDelegateField(format);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x000103D6 File Offset: 0x0000E5D6
		public static uint GetComponentCount(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetComponentCountDelegateField(format);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00073A7C File Offset: 0x00071C7C
		public static string GetFormatString(GraphicsFormat format)
		{
			IntPtr intPtr = GraphicsFormatUtility.GetFormatStringDelegateField(format);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x000103E3 File Offset: 0x0000E5E3
		public static bool IsCompressedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsCompressedFormatDelegateField(format);
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x000103F0 File Offset: 0x0000E5F0
		public static bool IsPackedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsPackedFormatDelegateField(format);
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x000103FD File Offset: 0x0000E5FD
		public static bool Is16BitPackedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.Is16BitPackedFormatDelegateField(format);
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0001040A File Offset: 0x0000E60A
		public static GraphicsFormat ConvertToAlphaFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.ConvertToAlphaFormatDelegateField(format);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00010417 File Offset: 0x0000E617
		public static bool IsAlphaOnlyFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsAlphaOnlyFormatDelegateField(format);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00010424 File Offset: 0x0000E624
		public static bool IsAlphaTestFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsAlphaTestFormatDelegateField(format);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00010431 File Offset: 0x0000E631
		public static bool HasAlphaChannel(GraphicsFormat format)
		{
			return GraphicsFormatUtility.HasAlphaChannelDelegateField(format);
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x0001043E File Offset: 0x0000E63E
		public static bool IsDepthFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsDepthFormatDelegateField(format);
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x0001044B File Offset: 0x0000E64B
		public static bool IsStencilFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsStencilFormatDelegateField(format);
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00010458 File Offset: 0x0000E658
		public static bool IsIEEE754Format(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsIEEE754FormatDelegateField(format);
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00010465 File Offset: 0x0000E665
		public static bool IsFloatFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsFloatFormatDelegateField(format);
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00010472 File Offset: 0x0000E672
		public static bool IsHalfFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsHalfFormatDelegateField(format);
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x0001047F File Offset: 0x0000E67F
		public static bool IsUnsignedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUnsignedFormatDelegateField(format);
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x0001048C File Offset: 0x0000E68C
		public static bool IsSignedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSignedFormatDelegateField(format);
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00010499 File Offset: 0x0000E699
		public static bool IsNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsNormFormatDelegateField(format);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x000104A6 File Offset: 0x0000E6A6
		public static bool IsUNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUNormFormatDelegateField(format);
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x000104B3 File Offset: 0x0000E6B3
		public static bool IsSNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSNormFormatDelegateField(format);
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x000104C0 File Offset: 0x0000E6C0
		public static bool IsIntegerFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsIntegerFormatDelegateField(format);
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x000104CD File Offset: 0x0000E6CD
		public static bool IsUIntFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUIntFormatDelegateField(format);
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x000104DA File Offset: 0x0000E6DA
		public static bool IsSIntFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSIntFormatDelegateField(format);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x000104E7 File Offset: 0x0000E6E7
		public static bool IsXRFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsXRFormatDelegateField(format);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x000104F4 File Offset: 0x0000E6F4
		public static bool IsDXTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsDXTCFormatDelegateField(format);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00010501 File Offset: 0x0000E701
		public static bool IsRGTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsRGTCFormatDelegateField(format);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0001050E File Offset: 0x0000E70E
		public static bool IsBPTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsBPTCFormatDelegateField(format);
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x0001051B File Offset: 0x0000E71B
		public static bool IsBCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsBCFormatDelegateField(format);
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00010528 File Offset: 0x0000E728
		public static bool IsETCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsETCFormatDelegateField(format);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00010535 File Offset: 0x0000E735
		public static bool IsEACFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsEACFormatDelegateField(format);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00010542 File Offset: 0x0000E742
		public static bool IsASTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsASTCFormatDelegateField(format);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0001054F File Offset: 0x0000E74F
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleR(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleRDelegateField(format);
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x0001055C File Offset: 0x0000E75C
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleG(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleGDelegateField(format);
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x00010569 File Offset: 0x0000E769
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleB(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleBDelegateField(format);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00010576 File Offset: 0x0000E776
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleA(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleADelegateField(format);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00010583 File Offset: 0x0000E783
		public static uint GetBlockSize(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetBlockSizeDelegateField(format);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00010590 File Offset: 0x0000E790
		public static uint GetBlockWidth(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetBlockWidthDelegateField(format);
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x0001059D File Offset: 0x0000E79D
		public static uint GetBlockHeight(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetBlockHeightDelegateField(format);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00073A9C File Offset: 0x00071C9C
		public static uint ComputeMipmapSize(int width, int height, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize_Native_2D(width, height, format);
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000105AA File Offset: 0x0000E7AA
		public static uint ComputeMipmapSize_Native_2D(int width, int height, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize_Native_2DDelegateField(width, height, format);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00073AB8 File Offset: 0x00071CB8
		public static uint ComputeMipmapSize(int width, int height, int depth, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize_Native_3D(width, height, depth, format);
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x000105B9 File Offset: 0x0000E7B9
		public static uint ComputeMipmapSize_Native_3D(int width, int height, int depth, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize_Native_3DDelegateField(width, height, depth, format);
		}

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeMethodInfoPtr_IsCompressedTextureFormat_Internal_Static_Boolean_TextureFormat_0;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0;

		// Token: 0x04001959 RID: 6489
		private static readonly GraphicsFormatUtility.GetFormatDelegate GetFormatDelegateField;

		// Token: 0x0400195A RID: 6490
		private static readonly GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegate GetTextureFormat_Native_GraphicsFormatDelegateField;

		// Token: 0x0400195B RID: 6491
		private static readonly GraphicsFormatUtility.IsSwizzleFormatDelegate IsSwizzleFormatDelegateField;

		// Token: 0x0400195C RID: 6492
		private static readonly GraphicsFormatUtility.GetSRGBFormatDelegate GetSRGBFormatDelegateField;

		// Token: 0x0400195D RID: 6493
		private static readonly GraphicsFormatUtility.GetLinearFormatDelegate GetLinearFormatDelegateField;

		// Token: 0x0400195E RID: 6494
		private static readonly GraphicsFormatUtility.GetColorComponentCountDelegate GetColorComponentCountDelegateField;

		// Token: 0x0400195F RID: 6495
		private static readonly GraphicsFormatUtility.GetAlphaComponentCountDelegate GetAlphaComponentCountDelegateField;

		// Token: 0x04001960 RID: 6496
		private static readonly GraphicsFormatUtility.GetComponentCountDelegate GetComponentCountDelegateField;

		// Token: 0x04001961 RID: 6497
		private static readonly GraphicsFormatUtility.GetFormatStringDelegate GetFormatStringDelegateField;

		// Token: 0x04001962 RID: 6498
		private static readonly GraphicsFormatUtility.IsCompressedFormatDelegate IsCompressedFormatDelegateField;

		// Token: 0x04001963 RID: 6499
		private static readonly GraphicsFormatUtility.IsPackedFormatDelegate IsPackedFormatDelegateField;

		// Token: 0x04001964 RID: 6500
		private static readonly GraphicsFormatUtility.Is16BitPackedFormatDelegate Is16BitPackedFormatDelegateField;

		// Token: 0x04001965 RID: 6501
		private static readonly GraphicsFormatUtility.ConvertToAlphaFormatDelegate ConvertToAlphaFormatDelegateField;

		// Token: 0x04001966 RID: 6502
		private static readonly GraphicsFormatUtility.IsAlphaOnlyFormatDelegate IsAlphaOnlyFormatDelegateField;

		// Token: 0x04001967 RID: 6503
		private static readonly GraphicsFormatUtility.IsAlphaTestFormatDelegate IsAlphaTestFormatDelegateField;

		// Token: 0x04001968 RID: 6504
		private static readonly GraphicsFormatUtility.HasAlphaChannelDelegate HasAlphaChannelDelegateField;

		// Token: 0x04001969 RID: 6505
		private static readonly GraphicsFormatUtility.IsDepthFormatDelegate IsDepthFormatDelegateField;

		// Token: 0x0400196A RID: 6506
		private static readonly GraphicsFormatUtility.IsStencilFormatDelegate IsStencilFormatDelegateField;

		// Token: 0x0400196B RID: 6507
		private static readonly GraphicsFormatUtility.IsIEEE754FormatDelegate IsIEEE754FormatDelegateField;

		// Token: 0x0400196C RID: 6508
		private static readonly GraphicsFormatUtility.IsFloatFormatDelegate IsFloatFormatDelegateField;

		// Token: 0x0400196D RID: 6509
		private static readonly GraphicsFormatUtility.IsHalfFormatDelegate IsHalfFormatDelegateField;

		// Token: 0x0400196E RID: 6510
		private static readonly GraphicsFormatUtility.IsUnsignedFormatDelegate IsUnsignedFormatDelegateField;

		// Token: 0x0400196F RID: 6511
		private static readonly GraphicsFormatUtility.IsSignedFormatDelegate IsSignedFormatDelegateField;

		// Token: 0x04001970 RID: 6512
		private static readonly GraphicsFormatUtility.IsNormFormatDelegate IsNormFormatDelegateField;

		// Token: 0x04001971 RID: 6513
		private static readonly GraphicsFormatUtility.IsUNormFormatDelegate IsUNormFormatDelegateField;

		// Token: 0x04001972 RID: 6514
		private static readonly GraphicsFormatUtility.IsSNormFormatDelegate IsSNormFormatDelegateField;

		// Token: 0x04001973 RID: 6515
		private static readonly GraphicsFormatUtility.IsIntegerFormatDelegate IsIntegerFormatDelegateField;

		// Token: 0x04001974 RID: 6516
		private static readonly GraphicsFormatUtility.IsUIntFormatDelegate IsUIntFormatDelegateField;

		// Token: 0x04001975 RID: 6517
		private static readonly GraphicsFormatUtility.IsSIntFormatDelegate IsSIntFormatDelegateField;

		// Token: 0x04001976 RID: 6518
		private static readonly GraphicsFormatUtility.IsXRFormatDelegate IsXRFormatDelegateField;

		// Token: 0x04001977 RID: 6519
		private static readonly GraphicsFormatUtility.IsDXTCFormatDelegate IsDXTCFormatDelegateField;

		// Token: 0x04001978 RID: 6520
		private static readonly GraphicsFormatUtility.IsRGTCFormatDelegate IsRGTCFormatDelegateField;

		// Token: 0x04001979 RID: 6521
		private static readonly GraphicsFormatUtility.IsBPTCFormatDelegate IsBPTCFormatDelegateField;

		// Token: 0x0400197A RID: 6522
		private static readonly GraphicsFormatUtility.IsBCFormatDelegate IsBCFormatDelegateField;

		// Token: 0x0400197B RID: 6523
		private static readonly GraphicsFormatUtility.IsETCFormatDelegate IsETCFormatDelegateField;

		// Token: 0x0400197C RID: 6524
		private static readonly GraphicsFormatUtility.IsEACFormatDelegate IsEACFormatDelegateField;

		// Token: 0x0400197D RID: 6525
		private static readonly GraphicsFormatUtility.IsASTCFormatDelegate IsASTCFormatDelegateField;

		// Token: 0x0400197E RID: 6526
		private static readonly GraphicsFormatUtility.GetSwizzleRDelegate GetSwizzleRDelegateField;

		// Token: 0x0400197F RID: 6527
		private static readonly GraphicsFormatUtility.GetSwizzleGDelegate GetSwizzleGDelegateField;

		// Token: 0x04001980 RID: 6528
		private static readonly GraphicsFormatUtility.GetSwizzleBDelegate GetSwizzleBDelegateField;

		// Token: 0x04001981 RID: 6529
		private static readonly GraphicsFormatUtility.GetSwizzleADelegate GetSwizzleADelegateField;

		// Token: 0x04001982 RID: 6530
		private static readonly GraphicsFormatUtility.GetBlockSizeDelegate GetBlockSizeDelegateField;

		// Token: 0x04001983 RID: 6531
		private static readonly GraphicsFormatUtility.GetBlockWidthDelegate GetBlockWidthDelegateField;

		// Token: 0x04001984 RID: 6532
		private static readonly GraphicsFormatUtility.GetBlockHeightDelegate GetBlockHeightDelegateField;

		// Token: 0x04001985 RID: 6533
		private static readonly GraphicsFormatUtility.ComputeMipmapSize_Native_2DDelegate ComputeMipmapSize_Native_2DDelegateField;

		// Token: 0x04001986 RID: 6534
		private static readonly GraphicsFormatUtility.ComputeMipmapSize_Native_3DDelegate ComputeMipmapSize_Native_3DDelegateField;

		// Token: 0x02000A55 RID: 2645
		// (Invoke) Token: 0x0600332A RID: 13098
		private delegate GraphicsFormat GetFormatDelegate(IntPtr texture);

		// Token: 0x02000A56 RID: 2646
		// (Invoke) Token: 0x0600332C RID: 13100
		private delegate TextureFormat GetTextureFormat_Native_GraphicsFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A57 RID: 2647
		// (Invoke) Token: 0x0600332E RID: 13102
		private delegate bool IsSwizzleFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A58 RID: 2648
		// (Invoke) Token: 0x06003330 RID: 13104
		private delegate GraphicsFormat GetSRGBFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A59 RID: 2649
		// (Invoke) Token: 0x06003332 RID: 13106
		private delegate GraphicsFormat GetLinearFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A5A RID: 2650
		// (Invoke) Token: 0x06003334 RID: 13108
		private delegate uint GetColorComponentCountDelegate(GraphicsFormat format);

		// Token: 0x02000A5B RID: 2651
		// (Invoke) Token: 0x06003336 RID: 13110
		private delegate uint GetAlphaComponentCountDelegate(GraphicsFormat format);

		// Token: 0x02000A5C RID: 2652
		// (Invoke) Token: 0x06003338 RID: 13112
		private delegate uint GetComponentCountDelegate(GraphicsFormat format);

		// Token: 0x02000A5D RID: 2653
		// (Invoke) Token: 0x0600333A RID: 13114
		private delegate IntPtr GetFormatStringDelegate(GraphicsFormat format);

		// Token: 0x02000A5E RID: 2654
		// (Invoke) Token: 0x0600333C RID: 13116
		private delegate bool IsCompressedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A5F RID: 2655
		// (Invoke) Token: 0x0600333E RID: 13118
		private delegate bool IsPackedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A60 RID: 2656
		// (Invoke) Token: 0x06003340 RID: 13120
		private delegate bool Is16BitPackedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A61 RID: 2657
		// (Invoke) Token: 0x06003342 RID: 13122
		private delegate GraphicsFormat ConvertToAlphaFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A62 RID: 2658
		// (Invoke) Token: 0x06003344 RID: 13124
		private delegate bool IsAlphaOnlyFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A63 RID: 2659
		// (Invoke) Token: 0x06003346 RID: 13126
		private delegate bool IsAlphaTestFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A64 RID: 2660
		// (Invoke) Token: 0x06003348 RID: 13128
		private delegate bool HasAlphaChannelDelegate(GraphicsFormat format);

		// Token: 0x02000A65 RID: 2661
		// (Invoke) Token: 0x0600334A RID: 13130
		private delegate bool IsDepthFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A66 RID: 2662
		// (Invoke) Token: 0x0600334C RID: 13132
		private delegate bool IsStencilFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A67 RID: 2663
		// (Invoke) Token: 0x0600334E RID: 13134
		private delegate bool IsIEEE754FormatDelegate(GraphicsFormat format);

		// Token: 0x02000A68 RID: 2664
		// (Invoke) Token: 0x06003350 RID: 13136
		private delegate bool IsFloatFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A69 RID: 2665
		// (Invoke) Token: 0x06003352 RID: 13138
		private delegate bool IsHalfFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A6A RID: 2666
		// (Invoke) Token: 0x06003354 RID: 13140
		private delegate bool IsUnsignedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A6B RID: 2667
		// (Invoke) Token: 0x06003356 RID: 13142
		private delegate bool IsSignedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A6C RID: 2668
		// (Invoke) Token: 0x06003358 RID: 13144
		private delegate bool IsNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A6D RID: 2669
		// (Invoke) Token: 0x0600335A RID: 13146
		private delegate bool IsUNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A6E RID: 2670
		// (Invoke) Token: 0x0600335C RID: 13148
		private delegate bool IsSNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A6F RID: 2671
		// (Invoke) Token: 0x0600335E RID: 13150
		private delegate bool IsIntegerFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A70 RID: 2672
		// (Invoke) Token: 0x06003360 RID: 13152
		private delegate bool IsUIntFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A71 RID: 2673
		// (Invoke) Token: 0x06003362 RID: 13154
		private delegate bool IsSIntFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A72 RID: 2674
		// (Invoke) Token: 0x06003364 RID: 13156
		private delegate bool IsXRFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A73 RID: 2675
		// (Invoke) Token: 0x06003366 RID: 13158
		private delegate bool IsDXTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A74 RID: 2676
		// (Invoke) Token: 0x06003368 RID: 13160
		private delegate bool IsRGTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A75 RID: 2677
		// (Invoke) Token: 0x0600336A RID: 13162
		private delegate bool IsBPTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A76 RID: 2678
		// (Invoke) Token: 0x0600336C RID: 13164
		private delegate bool IsBCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A77 RID: 2679
		// (Invoke) Token: 0x0600336E RID: 13166
		private delegate bool IsETCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A78 RID: 2680
		// (Invoke) Token: 0x06003370 RID: 13168
		private delegate bool IsEACFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A79 RID: 2681
		// (Invoke) Token: 0x06003372 RID: 13170
		private delegate bool IsASTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000A7A RID: 2682
		// (Invoke) Token: 0x06003374 RID: 13172
		private delegate UnityEngine.Rendering.FormatSwizzle GetSwizzleRDelegate(GraphicsFormat format);

		// Token: 0x02000A7B RID: 2683
		// (Invoke) Token: 0x06003376 RID: 13174
		private delegate UnityEngine.Rendering.FormatSwizzle GetSwizzleGDelegate(GraphicsFormat format);

		// Token: 0x02000A7C RID: 2684
		// (Invoke) Token: 0x06003378 RID: 13176
		private delegate UnityEngine.Rendering.FormatSwizzle GetSwizzleBDelegate(GraphicsFormat format);

		// Token: 0x02000A7D RID: 2685
		// (Invoke) Token: 0x0600337A RID: 13178
		private delegate UnityEngine.Rendering.FormatSwizzle GetSwizzleADelegate(GraphicsFormat format);

		// Token: 0x02000A7E RID: 2686
		// (Invoke) Token: 0x0600337C RID: 13180
		private delegate uint GetBlockSizeDelegate(GraphicsFormat format);

		// Token: 0x02000A7F RID: 2687
		// (Invoke) Token: 0x0600337E RID: 13182
		private delegate uint GetBlockWidthDelegate(GraphicsFormat format);

		// Token: 0x02000A80 RID: 2688
		// (Invoke) Token: 0x06003380 RID: 13184
		private delegate uint GetBlockHeightDelegate(GraphicsFormat format);

		// Token: 0x02000A81 RID: 2689
		// (Invoke) Token: 0x06003382 RID: 13186
		private delegate uint ComputeMipmapSize_Native_2DDelegate(int width, int height, GraphicsFormat format);

		// Token: 0x02000A82 RID: 2690
		// (Invoke) Token: 0x06003384 RID: 13188
		private delegate uint ComputeMipmapSize_Native_3DDelegate(int width, int height, int depth, GraphicsFormat format);
	}
}
