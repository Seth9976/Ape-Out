using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000090 RID: 144
	public class Texture : Object
	{
		// Token: 0x06000C24 RID: 3108 RVA: 0x0003341C File Offset: 0x0003161C
		// Note: this type is marked as 'beforefieldinit'.
		static Texture()
		{
			Il2CppClassPointerStore<Texture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture>.NativeClassPtr);
			Texture.NativeFieldInfoPtr_GenerateAllMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture>.NativeClassPtr, "GenerateAllMips");
			Texture.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664124);
			Texture.NativeMethodInfoPtr_GetDataWidth_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664125);
			Texture.NativeMethodInfoPtr_GetDataHeight_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664126);
			Texture.NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664127);
			Texture.NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664128);
			Texture.NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664129);
			Texture.NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664130);
			Texture.NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664131);
			Texture.NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664132);
			Texture.NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664133);
			Texture.NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664134);
			Texture.NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664135);
			Texture.NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664136);
			Texture.NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664137);
			Texture.NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664138);
			Texture.NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664139);
			Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664140);
			Texture.NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664141);
			Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664142);
			Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664143);
			Texture.NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664144);
			Texture.NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664146);
			Texture.get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<Texture.get_masterTextureLimitDelegate>("UnityEngine.Texture::get_masterTextureLimit");
			Texture.set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<Texture.set_masterTextureLimitDelegate>("UnityEngine.Texture::set_masterTextureLimit");
			Texture.get_mipmapCountDelegateField = IL2CPP.ResolveICall<Texture.get_mipmapCountDelegate>("UnityEngine.Texture::get_mipmapCount");
			Texture.get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<Texture.get_anisotropicFilteringDelegate>("UnityEngine.Texture::get_anisotropicFiltering");
			Texture.set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<Texture.set_anisotropicFilteringDelegate>("UnityEngine.Texture::set_anisotropicFiltering");
			Texture.SetGlobalAnisotropicFilteringLimitsDelegateField = IL2CPP.ResolveICall<Texture.SetGlobalAnisotropicFilteringLimitsDelegate>("UnityEngine.Texture::SetGlobalAnisotropicFilteringLimits");
			Texture.get_wrapModeUDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeUDelegate>("UnityEngine.Texture::get_wrapModeU");
			Texture.set_wrapModeUDelegateField = IL2CPP.ResolveICall<Texture.set_wrapModeUDelegate>("UnityEngine.Texture::set_wrapModeU");
			Texture.get_wrapModeVDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeVDelegate>("UnityEngine.Texture::get_wrapModeV");
			Texture.set_wrapModeVDelegateField = IL2CPP.ResolveICall<Texture.set_wrapModeVDelegate>("UnityEngine.Texture::set_wrapModeV");
			Texture.get_wrapModeWDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeWDelegate>("UnityEngine.Texture::get_wrapModeW");
			Texture.set_wrapModeWDelegateField = IL2CPP.ResolveICall<Texture.set_wrapModeWDelegate>("UnityEngine.Texture::set_wrapModeW");
			Texture.get_filterModeDelegateField = IL2CPP.ResolveICall<Texture.get_filterModeDelegate>("UnityEngine.Texture::get_filterMode");
			Texture.get_anisoLevelDelegateField = IL2CPP.ResolveICall<Texture.get_anisoLevelDelegate>("UnityEngine.Texture::get_anisoLevel");
			Texture.get_mipMapBiasDelegateField = IL2CPP.ResolveICall<Texture.get_mipMapBiasDelegate>("UnityEngine.Texture::get_mipMapBias");
			Texture.set_mipMapBiasDelegateField = IL2CPP.ResolveICall<Texture.set_mipMapBiasDelegate>("UnityEngine.Texture::set_mipMapBias");
			Texture.GetNativeTexturePtrDelegateField = IL2CPP.ResolveICall<Texture.GetNativeTexturePtrDelegate>("UnityEngine.Texture::GetNativeTexturePtr");
			Texture.get_updateCountDelegateField = IL2CPP.ResolveICall<Texture.get_updateCountDelegate>("UnityEngine.Texture::get_updateCount");
			Texture.IncrementUpdateCountDelegateField = IL2CPP.ResolveICall<Texture.IncrementUpdateCountDelegate>("UnityEngine.Texture::IncrementUpdateCount");
			Texture.get_totalTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_totalTextureMemoryDelegate>("UnityEngine.Texture::get_totalTextureMemory");
			Texture.get_desiredTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_desiredTextureMemoryDelegate>("UnityEngine.Texture::get_desiredTextureMemory");
			Texture.get_targetTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_targetTextureMemoryDelegate>("UnityEngine.Texture::get_targetTextureMemory");
			Texture.get_currentTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_currentTextureMemoryDelegate>("UnityEngine.Texture::get_currentTextureMemory");
			Texture.get_nonStreamingTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_nonStreamingTextureMemoryDelegate>("UnityEngine.Texture::get_nonStreamingTextureMemory");
			Texture.get_streamingMipmapUploadCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingMipmapUploadCountDelegate>("UnityEngine.Texture::get_streamingMipmapUploadCount");
			Texture.get_streamingRendererCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingRendererCountDelegate>("UnityEngine.Texture::get_streamingRendererCount");
			Texture.get_streamingTextureCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureCountDelegate>("UnityEngine.Texture::get_streamingTextureCount");
			Texture.get_nonStreamingTextureCountDelegateField = IL2CPP.ResolveICall<Texture.get_nonStreamingTextureCountDelegate>("UnityEngine.Texture::get_nonStreamingTextureCount");
			Texture.get_streamingTexturePendingLoadCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTexturePendingLoadCountDelegate>("UnityEngine.Texture::get_streamingTexturePendingLoadCount");
			Texture.get_streamingTextureLoadingCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureLoadingCountDelegate>("UnityEngine.Texture::get_streamingTextureLoadingCount");
			Texture.SetStreamingTextureMaterialDebugPropertiesDelegateField = IL2CPP.ResolveICall<Texture.SetStreamingTextureMaterialDebugPropertiesDelegate>("UnityEngine.Texture::SetStreamingTextureMaterialDebugProperties");
			Texture.get_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::get_streamingTextureForceLoadAll");
			Texture.set_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<Texture.set_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::set_streamingTextureForceLoadAll");
			Texture.get_streamingTextureDiscardUnusedMipsDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureDiscardUnusedMipsDelegate>("UnityEngine.Texture::get_streamingTextureDiscardUnusedMips");
			Texture.set_streamingTextureDiscardUnusedMipsDelegateField = IL2CPP.ResolveICall<Texture.set_streamingTextureDiscardUnusedMipsDelegate>("UnityEngine.Texture::set_streamingTextureDiscardUnusedMips");
			Texture.get_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<Texture.get_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::get_allowThreadedTextureCreation");
			Texture.set_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<Texture.set_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::set_allowThreadedTextureCreation");
			Texture.GetPixelDataSizeDelegateField = IL2CPP.ResolveICall<Texture.GetPixelDataSizeDelegate>("UnityEngine.Texture::GetPixelDataSize");
			Texture.GetPixelDataOffsetDelegateField = IL2CPP.ResolveICall<Texture.GetPixelDataOffsetDelegate>("UnityEngine.Texture::GetPixelDataOffset");
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00033864 File Offset: 0x00031A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490242, XrefRangeEnd = 490245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000338A0 File Offset: 0x00031AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490245, XrefRangeEnd = 490249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataWidth_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x000338DC File Offset: 0x00031ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490249, XrefRangeEnd = 490253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataHeight_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00033918 File Offset: 0x00031B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490253, XrefRangeEnd = 490257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.TextureDimension GetDimension()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00033954 File Offset: 0x00031B54
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x0003399C File Offset: 0x00031B9C
		public unsafe virtual int width
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490257, XrefRangeEnd = 490262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x000339E8 File Offset: 0x00031BE8
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00033A30 File Offset: 0x00031C30
		public unsafe virtual int height
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490262, XrefRangeEnd = 490267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00033A7C File Offset: 0x00031C7C
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00033AC4 File Offset: 0x00031CC4
		public unsafe virtual UnityEngine.Rendering.TextureDimension dimension
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490267, XrefRangeEnd = 490272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00033B10 File Offset: 0x00031D10
		public unsafe virtual bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490272, XrefRangeEnd = 490276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x00033B58 File Offset: 0x00031D58
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x00033B94 File Offset: 0x00031D94
		public unsafe TextureWrapMode wrapMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490276, XrefRangeEnd = 490280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 490284, RefRangeEnd = 490287, XrefRangeStart = 490280, XrefRangeEnd = 490284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00008B2A File Offset: 0x00006D2A
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00033BD4 File Offset: 0x00031DD4
		public unsafe FilterMode filterMode
		{
			get
			{
				return Texture.get_filterModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 490291, RefRangeEnd = 490298, XrefRangeStart = 490287, XrefRangeEnd = 490291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00008B3C File Offset: 0x00006D3C
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x00033C14 File Offset: 0x00031E14
		public unsafe int anisoLevel
		{
			get
			{
				return Texture.get_anisoLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 490302, RefRangeEnd = 490305, XrefRangeStart = 490298, XrefRangeEnd = 490302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00033C54 File Offset: 0x00031E54
		public unsafe Vector2 texelSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 490307, RefRangeEnd = 490309, XrefRangeStart = 490305, XrefRangeEnd = 490307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00033C90 File Offset: 0x00031E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490309, XrefRangeEnd = 490313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_GetActiveTextureColorSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x00033CCC File Offset: 0x00031ECC
		public unsafe ColorSpace activeTextureColorSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490313, XrefRangeEnd = 490315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00033D08 File Offset: 0x00031F08
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 490332, RefRangeEnd = 490343, XrefRangeStart = 490315, XrefRangeEnd = 490332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(TextureFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00033D54 File Offset: 0x00031F54
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 490358, RefRangeEnd = 490369, XrefRangeStart = 490343, XrefRangeEnd = 490358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00033DAC File Offset: 0x00031FAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 490377, RefRangeEnd = 490382, XrefRangeStart = 490369, XrefRangeEnd = 490377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException CreateNonReadableException(Texture t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityException>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00033DFC File Offset: 0x00031FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490382, XrefRangeEnd = 490386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_texelSize_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00008A52 File Offset: 0x00006C52
		public Texture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00033E3C File Offset: 0x0003203C
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x00008A5B File Offset: 0x00006C5B
		public unsafe static int GenerateAllMips
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Texture.NativeFieldInfoPtr_GenerateAllMips, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture.NativeFieldInfoPtr_GenerateAllMips, (void*)(&value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00008A69 File Offset: 0x00006C69
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x00008A75 File Offset: 0x00006C75
		public static int masterTextureLimit
		{
			get
			{
				return Texture.get_masterTextureLimitDelegateField();
			}
			set
			{
				Texture.set_masterTextureLimitDelegateField(value);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00008A82 File Offset: 0x00006C82
		public int mipmapCount
		{
			get
			{
				return Texture.get_mipmapCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00008A94 File Offset: 0x00006C94
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00008AA0 File Offset: 0x00006CA0
		public static AnisotropicFiltering anisotropicFiltering
		{
			get
			{
				return Texture.get_anisotropicFilteringDelegateField();
			}
			set
			{
				Texture.set_anisotropicFilteringDelegateField(value);
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00008AAD File Offset: 0x00006CAD
		public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax)
		{
			Texture.SetGlobalAnisotropicFilteringLimitsDelegateField(forcedMin, globalMax);
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00033E58 File Offset: 0x00032058
		public virtual UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			get
			{
				return UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetFormat(this);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x00008ABB File Offset: 0x00006CBB
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x00008ACD File Offset: 0x00006CCD
		public TextureWrapMode wrapModeU
		{
			get
			{
				return Texture.get_wrapModeUDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture.set_wrapModeUDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00008AE0 File Offset: 0x00006CE0
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x00008AF2 File Offset: 0x00006CF2
		public TextureWrapMode wrapModeV
		{
			get
			{
				return Texture.get_wrapModeVDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture.set_wrapModeVDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00008B05 File Offset: 0x00006D05
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x00008B17 File Offset: 0x00006D17
		public TextureWrapMode wrapModeW
		{
			get
			{
				return Texture.get_wrapModeWDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture.set_wrapModeWDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00008B4E File Offset: 0x00006D4E
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x00008B60 File Offset: 0x00006D60
		public float mipMapBias
		{
			get
			{
				return Texture.get_mipMapBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture.set_mipMapBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00008B73 File Offset: 0x00006D73
		public IntPtr GetNativeTexturePtr()
		{
			return Texture.GetNativeTexturePtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00033E70 File Offset: 0x00032070
		public int GetNativeTextureID()
		{
			return (int)this.GetNativeTexturePtr();
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00008B85 File Offset: 0x00006D85
		public uint updateCount
		{
			get
			{
				return Texture.get_updateCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00008B97 File Offset: 0x00006D97
		public void IncrementUpdateCount()
		{
			Texture.IncrementUpdateCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00008BA9 File Offset: 0x00006DA9
		public static ulong totalTextureMemory
		{
			get
			{
				return Texture.get_totalTextureMemoryDelegateField();
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00008BB5 File Offset: 0x00006DB5
		public static ulong desiredTextureMemory
		{
			get
			{
				return Texture.get_desiredTextureMemoryDelegateField();
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00008BC1 File Offset: 0x00006DC1
		public static ulong targetTextureMemory
		{
			get
			{
				return Texture.get_targetTextureMemoryDelegateField();
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00008BCD File Offset: 0x00006DCD
		public static ulong currentTextureMemory
		{
			get
			{
				return Texture.get_currentTextureMemoryDelegateField();
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00008BD9 File Offset: 0x00006DD9
		public static ulong nonStreamingTextureMemory
		{
			get
			{
				return Texture.get_nonStreamingTextureMemoryDelegateField();
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00008BE5 File Offset: 0x00006DE5
		public static ulong streamingMipmapUploadCount
		{
			get
			{
				return Texture.get_streamingMipmapUploadCountDelegateField();
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00008BF1 File Offset: 0x00006DF1
		public static ulong streamingRendererCount
		{
			get
			{
				return Texture.get_streamingRendererCountDelegateField();
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00008BFD File Offset: 0x00006DFD
		public static ulong streamingTextureCount
		{
			get
			{
				return Texture.get_streamingTextureCountDelegateField();
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00008C09 File Offset: 0x00006E09
		public static ulong nonStreamingTextureCount
		{
			get
			{
				return Texture.get_nonStreamingTextureCountDelegateField();
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00008C15 File Offset: 0x00006E15
		public static ulong streamingTexturePendingLoadCount
		{
			get
			{
				return Texture.get_streamingTexturePendingLoadCountDelegateField();
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00008C21 File Offset: 0x00006E21
		public static ulong streamingTextureLoadingCount
		{
			get
			{
				return Texture.get_streamingTextureLoadingCountDelegateField();
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00008C2D File Offset: 0x00006E2D
		public static void SetStreamingTextureMaterialDebugProperties()
		{
			Texture.SetStreamingTextureMaterialDebugPropertiesDelegateField();
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00008C39 File Offset: 0x00006E39
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00008C45 File Offset: 0x00006E45
		public static bool streamingTextureForceLoadAll
		{
			get
			{
				return Texture.get_streamingTextureForceLoadAllDelegateField();
			}
			set
			{
				Texture.set_streamingTextureForceLoadAllDelegateField(value);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x00008C52 File Offset: 0x00006E52
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00008C5E File Offset: 0x00006E5E
		public static bool streamingTextureDiscardUnusedMips
		{
			get
			{
				return Texture.get_streamingTextureDiscardUnusedMipsDelegateField();
			}
			set
			{
				Texture.set_streamingTextureDiscardUnusedMipsDelegateField(value);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00008C6B File Offset: 0x00006E6B
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00008C77 File Offset: 0x00006E77
		public static bool allowThreadedTextureCreation
		{
			get
			{
				return Texture.get_allowThreadedTextureCreationDelegateField();
			}
			set
			{
				Texture.set_allowThreadedTextureCreationDelegateField(value);
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00008C84 File Offset: 0x00006E84
		public ulong GetPixelDataSize(int mipLevel, [Optional] int element)
		{
			return Texture.GetPixelDataSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mipLevel, element);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00008C98 File Offset: 0x00006E98
		public ulong GetPixelDataOffset(int mipLevel, [Optional] int element)
		{
			return Texture.GetPixelDataOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mipLevel, element);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00033E90 File Offset: 0x00032090
		public bool ValidateFormat(RenderTextureFormat format)
		{
			bool flag = SystemInfo.SupportsRenderTextureFormat(format);
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				Debug.LogError(String.Format("RenderTexture creation failed. '{0}' is not supported on this platform. Use 'SystemInfo.SupportsRenderTextureFormat' C# API to check format support.", format.ToString()), this);
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00033ED4 File Offset: 0x000320D4
		public UnityException CreateNativeArrayLengthOverflowException()
		{
			return new UnityException("Failed to create NativeArray, length exceeds the allowed maximum of Int32.MaxValue. Use a larger type as template argument to reduce the array length.");
		}

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_GenerateAllMips;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeMethodInfoPtr_GetDataWidth_Private_Int32_0;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeMethodInfoPtr_GetDataHeight_Private_Int32_0;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000908 RID: 2312
		private static readonly Texture.get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;

		// Token: 0x04000909 RID: 2313
		private static readonly Texture.set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;

		// Token: 0x0400090A RID: 2314
		private static readonly Texture.get_mipmapCountDelegate get_mipmapCountDelegateField;

		// Token: 0x0400090B RID: 2315
		private static readonly Texture.get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;

		// Token: 0x0400090C RID: 2316
		private static readonly Texture.set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;

		// Token: 0x0400090D RID: 2317
		private static readonly Texture.SetGlobalAnisotropicFilteringLimitsDelegate SetGlobalAnisotropicFilteringLimitsDelegateField;

		// Token: 0x0400090E RID: 2318
		private static readonly Texture.get_wrapModeUDelegate get_wrapModeUDelegateField;

		// Token: 0x0400090F RID: 2319
		private static readonly Texture.set_wrapModeUDelegate set_wrapModeUDelegateField;

		// Token: 0x04000910 RID: 2320
		private static readonly Texture.get_wrapModeVDelegate get_wrapModeVDelegateField;

		// Token: 0x04000911 RID: 2321
		private static readonly Texture.set_wrapModeVDelegate set_wrapModeVDelegateField;

		// Token: 0x04000912 RID: 2322
		private static readonly Texture.get_wrapModeWDelegate get_wrapModeWDelegateField;

		// Token: 0x04000913 RID: 2323
		private static readonly Texture.set_wrapModeWDelegate set_wrapModeWDelegateField;

		// Token: 0x04000914 RID: 2324
		private static readonly Texture.get_filterModeDelegate get_filterModeDelegateField;

		// Token: 0x04000915 RID: 2325
		private static readonly Texture.get_anisoLevelDelegate get_anisoLevelDelegateField;

		// Token: 0x04000916 RID: 2326
		private static readonly Texture.get_mipMapBiasDelegate get_mipMapBiasDelegateField;

		// Token: 0x04000917 RID: 2327
		private static readonly Texture.set_mipMapBiasDelegate set_mipMapBiasDelegateField;

		// Token: 0x04000918 RID: 2328
		private static readonly Texture.GetNativeTexturePtrDelegate GetNativeTexturePtrDelegateField;

		// Token: 0x04000919 RID: 2329
		private static readonly Texture.get_updateCountDelegate get_updateCountDelegateField;

		// Token: 0x0400091A RID: 2330
		private static readonly Texture.IncrementUpdateCountDelegate IncrementUpdateCountDelegateField;

		// Token: 0x0400091B RID: 2331
		private static readonly Texture.get_totalTextureMemoryDelegate get_totalTextureMemoryDelegateField;

		// Token: 0x0400091C RID: 2332
		private static readonly Texture.get_desiredTextureMemoryDelegate get_desiredTextureMemoryDelegateField;

		// Token: 0x0400091D RID: 2333
		private static readonly Texture.get_targetTextureMemoryDelegate get_targetTextureMemoryDelegateField;

		// Token: 0x0400091E RID: 2334
		private static readonly Texture.get_currentTextureMemoryDelegate get_currentTextureMemoryDelegateField;

		// Token: 0x0400091F RID: 2335
		private static readonly Texture.get_nonStreamingTextureMemoryDelegate get_nonStreamingTextureMemoryDelegateField;

		// Token: 0x04000920 RID: 2336
		private static readonly Texture.get_streamingMipmapUploadCountDelegate get_streamingMipmapUploadCountDelegateField;

		// Token: 0x04000921 RID: 2337
		private static readonly Texture.get_streamingRendererCountDelegate get_streamingRendererCountDelegateField;

		// Token: 0x04000922 RID: 2338
		private static readonly Texture.get_streamingTextureCountDelegate get_streamingTextureCountDelegateField;

		// Token: 0x04000923 RID: 2339
		private static readonly Texture.get_nonStreamingTextureCountDelegate get_nonStreamingTextureCountDelegateField;

		// Token: 0x04000924 RID: 2340
		private static readonly Texture.get_streamingTexturePendingLoadCountDelegate get_streamingTexturePendingLoadCountDelegateField;

		// Token: 0x04000925 RID: 2341
		private static readonly Texture.get_streamingTextureLoadingCountDelegate get_streamingTextureLoadingCountDelegateField;

		// Token: 0x04000926 RID: 2342
		private static readonly Texture.SetStreamingTextureMaterialDebugPropertiesDelegate SetStreamingTextureMaterialDebugPropertiesDelegateField;

		// Token: 0x04000927 RID: 2343
		private static readonly Texture.get_streamingTextureForceLoadAllDelegate get_streamingTextureForceLoadAllDelegateField;

		// Token: 0x04000928 RID: 2344
		private static readonly Texture.set_streamingTextureForceLoadAllDelegate set_streamingTextureForceLoadAllDelegateField;

		// Token: 0x04000929 RID: 2345
		private static readonly Texture.get_streamingTextureDiscardUnusedMipsDelegate get_streamingTextureDiscardUnusedMipsDelegateField;

		// Token: 0x0400092A RID: 2346
		private static readonly Texture.set_streamingTextureDiscardUnusedMipsDelegate set_streamingTextureDiscardUnusedMipsDelegateField;

		// Token: 0x0400092B RID: 2347
		private static readonly Texture.get_allowThreadedTextureCreationDelegate get_allowThreadedTextureCreationDelegateField;

		// Token: 0x0400092C RID: 2348
		private static readonly Texture.set_allowThreadedTextureCreationDelegate set_allowThreadedTextureCreationDelegateField;

		// Token: 0x0400092D RID: 2349
		private static readonly Texture.GetPixelDataSizeDelegate GetPixelDataSizeDelegateField;

		// Token: 0x0400092E RID: 2350
		private static readonly Texture.GetPixelDataOffsetDelegate GetPixelDataOffsetDelegateField;

		// Token: 0x020006A0 RID: 1696
		// (Invoke) Token: 0x06002B5F RID: 11103
		private delegate int get_masterTextureLimitDelegate();

		// Token: 0x020006A1 RID: 1697
		// (Invoke) Token: 0x06002B61 RID: 11105
		private delegate void set_masterTextureLimitDelegate(int value);

		// Token: 0x020006A2 RID: 1698
		// (Invoke) Token: 0x06002B63 RID: 11107
		private delegate int get_mipmapCountDelegate(IntPtr @this);

		// Token: 0x020006A3 RID: 1699
		// (Invoke) Token: 0x06002B65 RID: 11109
		private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

		// Token: 0x020006A4 RID: 1700
		// (Invoke) Token: 0x06002B67 RID: 11111
		private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

		// Token: 0x020006A5 RID: 1701
		// (Invoke) Token: 0x06002B69 RID: 11113
		private delegate void SetGlobalAnisotropicFilteringLimitsDelegate(int forcedMin, int globalMax);

		// Token: 0x020006A6 RID: 1702
		// (Invoke) Token: 0x06002B6B RID: 11115
		private delegate TextureWrapMode get_wrapModeUDelegate(IntPtr @this);

		// Token: 0x020006A7 RID: 1703
		// (Invoke) Token: 0x06002B6D RID: 11117
		private delegate void set_wrapModeUDelegate(IntPtr @this, TextureWrapMode value);

		// Token: 0x020006A8 RID: 1704
		// (Invoke) Token: 0x06002B6F RID: 11119
		private delegate TextureWrapMode get_wrapModeVDelegate(IntPtr @this);

		// Token: 0x020006A9 RID: 1705
		// (Invoke) Token: 0x06002B71 RID: 11121
		private delegate void set_wrapModeVDelegate(IntPtr @this, TextureWrapMode value);

		// Token: 0x020006AA RID: 1706
		// (Invoke) Token: 0x06002B73 RID: 11123
		private delegate TextureWrapMode get_wrapModeWDelegate(IntPtr @this);

		// Token: 0x020006AB RID: 1707
		// (Invoke) Token: 0x06002B75 RID: 11125
		private delegate void set_wrapModeWDelegate(IntPtr @this, TextureWrapMode value);

		// Token: 0x020006AC RID: 1708
		// (Invoke) Token: 0x06002B77 RID: 11127
		private delegate FilterMode get_filterModeDelegate(IntPtr @this);

		// Token: 0x020006AD RID: 1709
		// (Invoke) Token: 0x06002B79 RID: 11129
		private delegate int get_anisoLevelDelegate(IntPtr @this);

		// Token: 0x020006AE RID: 1710
		// (Invoke) Token: 0x06002B7B RID: 11131
		private delegate float get_mipMapBiasDelegate(IntPtr @this);

		// Token: 0x020006AF RID: 1711
		// (Invoke) Token: 0x06002B7D RID: 11133
		private delegate void set_mipMapBiasDelegate(IntPtr @this, float value);

		// Token: 0x020006B0 RID: 1712
		// (Invoke) Token: 0x06002B7F RID: 11135
		private delegate IntPtr GetNativeTexturePtrDelegate(IntPtr @this);

		// Token: 0x020006B1 RID: 1713
		// (Invoke) Token: 0x06002B81 RID: 11137
		private delegate uint get_updateCountDelegate(IntPtr @this);

		// Token: 0x020006B2 RID: 1714
		// (Invoke) Token: 0x06002B83 RID: 11139
		private delegate void IncrementUpdateCountDelegate(IntPtr @this);

		// Token: 0x020006B3 RID: 1715
		// (Invoke) Token: 0x06002B85 RID: 11141
		private delegate ulong get_totalTextureMemoryDelegate();

		// Token: 0x020006B4 RID: 1716
		// (Invoke) Token: 0x06002B87 RID: 11143
		private delegate ulong get_desiredTextureMemoryDelegate();

		// Token: 0x020006B5 RID: 1717
		// (Invoke) Token: 0x06002B89 RID: 11145
		private delegate ulong get_targetTextureMemoryDelegate();

		// Token: 0x020006B6 RID: 1718
		// (Invoke) Token: 0x06002B8B RID: 11147
		private delegate ulong get_currentTextureMemoryDelegate();

		// Token: 0x020006B7 RID: 1719
		// (Invoke) Token: 0x06002B8D RID: 11149
		private delegate ulong get_nonStreamingTextureMemoryDelegate();

		// Token: 0x020006B8 RID: 1720
		// (Invoke) Token: 0x06002B8F RID: 11151
		private delegate ulong get_streamingMipmapUploadCountDelegate();

		// Token: 0x020006B9 RID: 1721
		// (Invoke) Token: 0x06002B91 RID: 11153
		private delegate ulong get_streamingRendererCountDelegate();

		// Token: 0x020006BA RID: 1722
		// (Invoke) Token: 0x06002B93 RID: 11155
		private delegate ulong get_streamingTextureCountDelegate();

		// Token: 0x020006BB RID: 1723
		// (Invoke) Token: 0x06002B95 RID: 11157
		private delegate ulong get_nonStreamingTextureCountDelegate();

		// Token: 0x020006BC RID: 1724
		// (Invoke) Token: 0x06002B97 RID: 11159
		private delegate ulong get_streamingTexturePendingLoadCountDelegate();

		// Token: 0x020006BD RID: 1725
		// (Invoke) Token: 0x06002B99 RID: 11161
		private delegate ulong get_streamingTextureLoadingCountDelegate();

		// Token: 0x020006BE RID: 1726
		// (Invoke) Token: 0x06002B9B RID: 11163
		private delegate void SetStreamingTextureMaterialDebugPropertiesDelegate();

		// Token: 0x020006BF RID: 1727
		// (Invoke) Token: 0x06002B9D RID: 11165
		private delegate bool get_streamingTextureForceLoadAllDelegate();

		// Token: 0x020006C0 RID: 1728
		// (Invoke) Token: 0x06002B9F RID: 11167
		private delegate void set_streamingTextureForceLoadAllDelegate(bool value);

		// Token: 0x020006C1 RID: 1729
		// (Invoke) Token: 0x06002BA1 RID: 11169
		private delegate bool get_streamingTextureDiscardUnusedMipsDelegate();

		// Token: 0x020006C2 RID: 1730
		// (Invoke) Token: 0x06002BA3 RID: 11171
		private delegate void set_streamingTextureDiscardUnusedMipsDelegate(bool value);

		// Token: 0x020006C3 RID: 1731
		// (Invoke) Token: 0x06002BA5 RID: 11173
		private delegate bool get_allowThreadedTextureCreationDelegate();

		// Token: 0x020006C4 RID: 1732
		// (Invoke) Token: 0x06002BA7 RID: 11175
		private delegate void set_allowThreadedTextureCreationDelegate(bool value);

		// Token: 0x020006C5 RID: 1733
		// (Invoke) Token: 0x06002BA9 RID: 11177
		private delegate ulong GetPixelDataSizeDelegate(IntPtr @this, int mipLevel, int element);

		// Token: 0x020006C6 RID: 1734
		// (Invoke) Token: 0x06002BAB RID: 11179
		private delegate ulong GetPixelDataOffsetDelegate(IntPtr @this, int mipLevel, int element);
	}
}
