using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000FC RID: 252
	public sealed class SystemInfo : Object
	{
		// Token: 0x06001492 RID: 5266 RVA: 0x00052238 File Offset: 0x00050438
		// Note: this type is marked as 'beforefieldinit'.
		static SystemInfo()
		{
			Il2CppClassPointerStore<SystemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SystemInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr);
			SystemInfo.NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665088);
			SystemInfo.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665089);
			SystemInfo.NativeMethodInfoPtr_get_deviceName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665090);
			SystemInfo.NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665091);
			SystemInfo.NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665092);
			SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665093);
			SystemInfo.NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665094);
			SystemInfo.NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665095);
			SystemInfo.NativeMethodInfoPtr_get_supportsMotionVectors_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665096);
			SystemInfo.NativeMethodInfoPtr_get_supports3DRenderTextures_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665097);
			SystemInfo.NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665098);
			SystemInfo.NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665099);
			SystemInfo.NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665100);
			SystemInfo.NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665101);
			SystemInfo.NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665102);
			SystemInfo.NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665103);
			SystemInfo.NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665104);
			SystemInfo.NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665105);
			SystemInfo.NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665106);
			SystemInfo.NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665107);
			SystemInfo.NativeMethodInfoPtr_GetDeviceName_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665108);
			SystemInfo.NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665109);
			SystemInfo.NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665110);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665111);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665112);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665113);
			SystemInfo.NativeMethodInfoPtr_SupportsMotionVectors_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665114);
			SystemInfo.NativeMethodInfoPtr_Supports3DRenderTextures_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665115);
			SystemInfo.NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665116);
			SystemInfo.NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665117);
			SystemInfo.NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665118);
			SystemInfo.NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665119);
			SystemInfo.NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665120);
			SystemInfo.NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665121);
			SystemInfo.NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665122);
			SystemInfo.NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665123);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665124);
			SystemInfo.NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100665125);
			SystemInfo.GetBatteryLevelDelegateField = IL2CPP.ResolveICall<SystemInfo.GetBatteryLevelDelegate>("UnityEngine.SystemInfo::GetBatteryLevel");
			SystemInfo.GetBatteryStatusDelegateField = IL2CPP.ResolveICall<SystemInfo.GetBatteryStatusDelegate>("UnityEngine.SystemInfo::GetBatteryStatus");
			SystemInfo.GetOperatingSystemDelegateField = IL2CPP.ResolveICall<SystemInfo.GetOperatingSystemDelegate>("UnityEngine.SystemInfo::GetOperatingSystem");
			SystemInfo.GetProcessorTypeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetProcessorTypeDelegate>("UnityEngine.SystemInfo::GetProcessorType");
			SystemInfo.GetProcessorFrequencyMHzDelegateField = IL2CPP.ResolveICall<SystemInfo.GetProcessorFrequencyMHzDelegate>("UnityEngine.SystemInfo::GetProcessorFrequencyMHz");
			SystemInfo.GetProcessorCountDelegateField = IL2CPP.ResolveICall<SystemInfo.GetProcessorCountDelegate>("UnityEngine.SystemInfo::GetProcessorCount");
			SystemInfo.GetPhysicalMemoryMBDelegateField = IL2CPP.ResolveICall<SystemInfo.GetPhysicalMemoryMBDelegate>("UnityEngine.SystemInfo::GetPhysicalMemoryMB");
			SystemInfo.SupportsAccelerometerDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAccelerometerDelegate>("UnityEngine.SystemInfo::SupportsAccelerometer");
			SystemInfo.IsGyroAvailableDelegateField = IL2CPP.ResolveICall<SystemInfo.IsGyroAvailableDelegate>("UnityEngine.SystemInfo::IsGyroAvailable");
			SystemInfo.SupportsLocationServiceDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsLocationServiceDelegate>("UnityEngine.SystemInfo::SupportsLocationService");
			SystemInfo.SupportsVibrationDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsVibrationDelegate>("UnityEngine.SystemInfo::SupportsVibration");
			SystemInfo.SupportsAudioDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAudioDelegate>("UnityEngine.SystemInfo::SupportsAudio");
			SystemInfo.GetGraphicsMemorySizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsMemorySizeDelegate>("UnityEngine.SystemInfo::GetGraphicsMemorySize");
			SystemInfo.GetGraphicsDeviceNameDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceNameDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceName");
			SystemInfo.GetGraphicsDeviceVendorDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceVendorDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceVendor");
			SystemInfo.GetGraphicsDeviceIDDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceIDDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceID");
			SystemInfo.GetGraphicsDeviceVendorIDDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceVendorIDDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceVendorID");
			SystemInfo.GetGraphicsDeviceVersionDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceVersionDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceVersion");
			SystemInfo.GetGraphicsMultiThreadedDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsMultiThreadedDelegate>("UnityEngine.SystemInfo::GetGraphicsMultiThreaded");
			SystemInfo.GetRenderingThreadingModeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetRenderingThreadingModeDelegate>("UnityEngine.SystemInfo::GetRenderingThreadingMode");
			SystemInfo.HasHiddenSurfaceRemovalOnGPUDelegateField = IL2CPP.ResolveICall<SystemInfo.HasHiddenSurfaceRemovalOnGPUDelegate>("UnityEngine.SystemInfo::HasHiddenSurfaceRemovalOnGPU");
			SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegate>("UnityEngine.SystemInfo::HasDynamicUniformArrayIndexingInFragmentShaders");
			SystemInfo.SupportsShadowsDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsShadowsDelegate>("UnityEngine.SystemInfo::SupportsShadows");
			SystemInfo.SupportsRawShadowDepthSamplingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRawShadowDepthSamplingDelegate>("UnityEngine.SystemInfo::SupportsRawShadowDepthSampling");
			SystemInfo.Supports3DTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports3DTexturesDelegate>("UnityEngine.SystemInfo::Supports3DTextures");
			SystemInfo.SupportsCompressed3DTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsCompressed3DTexturesDelegate>("UnityEngine.SystemInfo::SupportsCompressed3DTextures");
			SystemInfo.Supports2DArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports2DArrayTexturesDelegate>("UnityEngine.SystemInfo::Supports2DArrayTextures");
			SystemInfo.SupportsCubemapArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsCubemapArrayTexturesDelegate>("UnityEngine.SystemInfo::SupportsCubemapArrayTextures");
			SystemInfo.SupportsGeometryShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsGeometryShadersDelegate>("UnityEngine.SystemInfo::SupportsGeometryShaders");
			SystemInfo.SupportsTessellationShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsTessellationShadersDelegate>("UnityEngine.SystemInfo::SupportsTessellationShaders");
			SystemInfo.SupportsRenderTargetArrayIndexFromVertexShaderDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRenderTargetArrayIndexFromVertexShaderDelegate>("UnityEngine.SystemInfo::SupportsRenderTargetArrayIndexFromVertexShader");
			SystemInfo.SupportsInstancingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsInstancingDelegate>("UnityEngine.SystemInfo::SupportsInstancing");
			SystemInfo.SupportsHardwareQuadTopologyDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsHardwareQuadTopologyDelegate>("UnityEngine.SystemInfo::SupportsHardwareQuadTopology");
			SystemInfo.Supports32bitsIndexBufferDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports32bitsIndexBufferDelegate>("UnityEngine.SystemInfo::Supports32bitsIndexBuffer");
			SystemInfo.SupportsSparseTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSparseTexturesDelegate>("UnityEngine.SystemInfo::SupportsSparseTextures");
			SystemInfo.SupportsSeparatedRenderTargetsBlendDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSeparatedRenderTargetsBlendDelegate>("UnityEngine.SystemInfo::SupportsSeparatedRenderTargetsBlend");
			SystemInfo.SupportedRandomWriteTargetCountDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportedRandomWriteTargetCountDelegate>("UnityEngine.SystemInfo::SupportedRandomWriteTargetCount");
			SystemInfo.MaxComputeBufferInputsVertexDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsVertexDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsVertex");
			SystemInfo.MaxComputeBufferInputsFragmentDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsFragmentDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsFragment");
			SystemInfo.MaxComputeBufferInputsGeometryDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsGeometryDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsGeometry");
			SystemInfo.MaxComputeBufferInputsDomainDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsDomainDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsDomain");
			SystemInfo.MaxComputeBufferInputsHullDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsHullDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsHull");
			SystemInfo.MaxComputeBufferInputsComputeDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsComputeDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsCompute");
			SystemInfo.SupportsMultisampledTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMultisampledTexturesDelegate>("UnityEngine.SystemInfo::SupportsMultisampledTextures");
			SystemInfo.SupportsMultisampled2DArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMultisampled2DArrayTexturesDelegate>("UnityEngine.SystemInfo::SupportsMultisampled2DArrayTextures");
			SystemInfo.SupportsMultisampleAutoResolveDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMultisampleAutoResolveDelegate>("UnityEngine.SystemInfo::SupportsMultisampleAutoResolve");
			SystemInfo.SupportsTextureWrapMirrorOnceDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsTextureWrapMirrorOnceDelegate>("UnityEngine.SystemInfo::SupportsTextureWrapMirrorOnce");
			SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsBlendingOnRenderTextureFormatNative");
			SystemInfo.SupportsVertexAttributeFormatNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsVertexAttributeFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsVertexAttributeFormatNative");
			SystemInfo.GetNPOTSupportDelegateField = IL2CPP.ResolveICall<SystemInfo.GetNPOTSupportDelegate>("UnityEngine.SystemInfo::GetNPOTSupport");
			SystemInfo.GetMaxTextureSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxTextureSizeDelegate>("UnityEngine.SystemInfo::GetMaxTextureSize");
			SystemInfo.GetMaxTexture3DSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxTexture3DSizeDelegate>("UnityEngine.SystemInfo::GetMaxTexture3DSize");
			SystemInfo.GetMaxTextureArraySlicesDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxTextureArraySlicesDelegate>("UnityEngine.SystemInfo::GetMaxTextureArraySlices");
			SystemInfo.GetMaxCubemapSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxCubemapSizeDelegate>("UnityEngine.SystemInfo::GetMaxCubemapSize");
			SystemInfo.GetMaxRenderTextureSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxRenderTextureSizeDelegate>("UnityEngine.SystemInfo::GetMaxRenderTextureSize");
			SystemInfo.GetMaxComputeWorkGroupSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSize");
			SystemInfo.GetMaxComputeWorkGroupSizeXDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeXDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeX");
			SystemInfo.GetMaxComputeWorkGroupSizeYDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeYDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeY");
			SystemInfo.GetMaxComputeWorkGroupSizeZDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeZDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeZ");
			SystemInfo.GetComputeSubGroupSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetComputeSubGroupSizeDelegate>("UnityEngine.SystemInfo::GetComputeSubGroupSize");
			SystemInfo.SupportsAsyncComputeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAsyncComputeDelegate>("UnityEngine.SystemInfo::SupportsAsyncCompute");
			SystemInfo.SupportsGpuRecorderDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsGpuRecorderDelegate>("UnityEngine.SystemInfo::SupportsGpuRecorder");
			SystemInfo.SupportsGPUFenceDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsGPUFenceDelegate>("UnityEngine.SystemInfo::SupportsGPUFence");
			SystemInfo.SupportsAsyncGPUReadbackDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAsyncGPUReadbackDelegate>("UnityEngine.SystemInfo::SupportsAsyncGPUReadback");
			SystemInfo.SupportsRayTracingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRayTracingDelegate>("UnityEngine.SystemInfo::SupportsRayTracing");
			SystemInfo.SupportsSetConstantBufferDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSetConstantBufferDelegate>("UnityEngine.SystemInfo::SupportsSetConstantBuffer");
			SystemInfo.MinConstantBufferOffsetAlignmentDelegateField = IL2CPP.ResolveICall<SystemInfo.MinConstantBufferOffsetAlignmentDelegate>("UnityEngine.SystemInfo::MinConstantBufferOffsetAlignment");
			SystemInfo.HasMipMaxLevelDelegateField = IL2CPP.ResolveICall<SystemInfo.HasMipMaxLevelDelegate>("UnityEngine.SystemInfo::HasMipMaxLevel");
			SystemInfo.SupportsMipStreamingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMipStreamingDelegate>("UnityEngine.SystemInfo::SupportsMipStreaming");
			SystemInfo.GetHDRDisplaySupportFlagsDelegateField = IL2CPP.ResolveICall<SystemInfo.GetHDRDisplaySupportFlagsDelegate>("UnityEngine.SystemInfo::GetHDRDisplaySupportFlags");
			SystemInfo.SupportsConservativeRasterDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsConservativeRasterDelegate>("UnityEngine.SystemInfo::SupportsConservativeRaster");
			SystemInfo.SupportsMultiviewDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMultiviewDelegate>("UnityEngine.SystemInfo::SupportsMultiview");
			SystemInfo.SupportsStoreAndResolveActionDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsStoreAndResolveActionDelegate>("UnityEngine.SystemInfo::SupportsStoreAndResolveAction");
			SystemInfo.GetRenderTextureSupportedMSAASampleCount_InjectedDelegateField = IL2CPP.ResolveICall<SystemInfo.GetRenderTextureSupportedMSAASampleCount_InjectedDelegate>("UnityEngine.SystemInfo::GetRenderTextureSupportedMSAASampleCount_Injected");
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x000529B8 File Offset: 0x00050BB8
		public unsafe static OperatingSystemFamily operatingSystemFamily
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498419, XrefRangeEnd = 498423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x000529E8 File Offset: 0x00050BE8
		public unsafe static string deviceUniqueIdentifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498423, XrefRangeEnd = 498427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x00052A14 File Offset: 0x00050C14
		public unsafe static string deviceName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498427, XrefRangeEnd = 498431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x00052A40 File Offset: 0x00050C40
		public unsafe static string deviceModel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498431, XrefRangeEnd = 498435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x00052A6C File Offset: 0x00050C6C
		public unsafe static DeviceType deviceType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498435, XrefRangeEnd = 498439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x00052A9C File Offset: 0x00050C9C
		public unsafe static UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 498443, RefRangeEnd = 498445, XrefRangeStart = 498439, XrefRangeEnd = 498443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00052ACC File Offset: 0x00050CCC
		public unsafe static bool graphicsUVStartsAtTop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498445, XrefRangeEnd = 498449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x00052AFC File Offset: 0x00050CFC
		public unsafe static int graphicsShaderLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498449, XrefRangeEnd = 498453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00052B2C File Offset: 0x00050D2C
		public unsafe static bool supportsMotionVectors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498453, XrefRangeEnd = 498457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsMotionVectors_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x00052B5C File Offset: 0x00050D5C
		public unsafe static bool supports3DRenderTextures
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498457, XrefRangeEnd = 498461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supports3DRenderTextures_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x00052B8C File Offset: 0x00050D8C
		public unsafe static UnityEngine.Rendering.CopyTextureSupport copyTextureSupport
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 498465, RefRangeEnd = 498466, XrefRangeStart = 498461, XrefRangeEnd = 498465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x00052BBC File Offset: 0x00050DBC
		public unsafe static bool supportsComputeShaders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 498470, RefRangeEnd = 498471, XrefRangeStart = 498466, XrefRangeEnd = 498470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x00052BEC File Offset: 0x00050DEC
		public unsafe static int supportedRenderTargetCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498471, XrefRangeEnd = 498475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x00052C1C File Offset: 0x00050E1C
		public unsafe static bool usesReversedZBuffer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498475, XrefRangeEnd = 498479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00052C4C File Offset: 0x00050E4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 498486, RefRangeEnd = 498488, XrefRangeStart = 498479, XrefRangeEnd = 498486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidEnumValue(Enum value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00052C90 File Offset: 0x00050E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498488, XrefRangeEnd = 498502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00052CD0 File Offset: 0x00050ED0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 498516, RefRangeEnd = 498519, XrefRangeStart = 498502, XrefRangeEnd = 498516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsTextureFormat(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x00052D10 File Offset: 0x00050F10
		public unsafe static bool usesLoadStoreActions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498519, XrefRangeEnd = 498523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00052D40 File Offset: 0x00050F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OperatingSystemFamily GetOperatingSystemFamily()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00052D70 File Offset: 0x00050F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceUniqueIdentifier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00052D9C File Offset: 0x00050F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceName_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00052DC8 File Offset: 0x00050FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceModel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00052DF4 File Offset: 0x00050FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeviceType GetDeviceType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00052E24 File Offset: 0x00051024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 498443, RefRangeEnd = 498445, XrefRangeStart = 498443, XrefRangeEnd = 498445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00052E54 File Offset: 0x00051054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetGraphicsUVStartsAtTop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00052E84 File Offset: 0x00051084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGraphicsShaderLevel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00052EB4 File Offset: 0x000510B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsMotionVectors()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsMotionVectors_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00052EE4 File Offset: 0x000510E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Supports3DRenderTextures()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_Supports3DRenderTextures_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00052F14 File Offset: 0x00051114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 498465, RefRangeEnd = 498466, XrefRangeStart = 498465, XrefRangeEnd = 498466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupport()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00052F44 File Offset: 0x00051144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 498470, RefRangeEnd = 498471, XrefRangeStart = 498470, XrefRangeEnd = 498471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsComputeShaders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00052F74 File Offset: 0x00051174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SupportedRenderTargetCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00052FA4 File Offset: 0x000511A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UsesReversedZBuffer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00052FD4 File Offset: 0x000511D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498523, XrefRangeEnd = 498527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasRenderTextureNative(RenderTextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00053014 File Offset: 0x00051214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498527, XrefRangeEnd = 498531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsTextureFormatNative(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00053054 File Offset: 0x00051254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498531, XrefRangeEnd = 498535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x000530A0 File Offset: 0x000512A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498535, XrefRangeEnd = 498539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x000530EC File Offset: 0x000512EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498539, XrefRangeEnd = 498543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0005312C File Offset: 0x0005132C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UsesLoadStoreActions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0000B8FA File Offset: 0x00009AFA
		public SystemInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0005315C File Offset: 0x0005135C
		public static float batteryLevel
		{
			get
			{
				return SystemInfo.GetBatteryLevel();
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x00053174 File Offset: 0x00051374
		public static BatteryStatus batteryStatus
		{
			get
			{
				return SystemInfo.GetBatteryStatus();
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0005318C File Offset: 0x0005138C
		public static string operatingSystem
		{
			get
			{
				return SystemInfo.GetOperatingSystem();
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x000531A4 File Offset: 0x000513A4
		public static string processorType
		{
			get
			{
				return SystemInfo.GetProcessorType();
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x000531BC File Offset: 0x000513BC
		public static int processorFrequency
		{
			get
			{
				return SystemInfo.GetProcessorFrequencyMHz();
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x000531D4 File Offset: 0x000513D4
		public static int processorCount
		{
			get
			{
				return SystemInfo.GetProcessorCount();
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x000531EC File Offset: 0x000513EC
		public static int systemMemorySize
		{
			get
			{
				return SystemInfo.GetPhysicalMemoryMB();
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x00053204 File Offset: 0x00051404
		public static bool supportsAccelerometer
		{
			get
			{
				return SystemInfo.SupportsAccelerometer();
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0005321C File Offset: 0x0005141C
		public static bool supportsGyroscope
		{
			get
			{
				return SystemInfo.IsGyroAvailable();
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x00053234 File Offset: 0x00051434
		public static bool supportsLocationService
		{
			get
			{
				return SystemInfo.SupportsLocationService();
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0005324C File Offset: 0x0005144C
		public static bool supportsVibration
		{
			get
			{
				return SystemInfo.SupportsVibration();
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x00053264 File Offset: 0x00051464
		public static bool supportsAudio
		{
			get
			{
				return SystemInfo.SupportsAudio();
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0005327C File Offset: 0x0005147C
		public static int graphicsMemorySize
		{
			get
			{
				return SystemInfo.GetGraphicsMemorySize();
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00053294 File Offset: 0x00051494
		public static string graphicsDeviceName
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceName();
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x000532AC File Offset: 0x000514AC
		public static string graphicsDeviceVendor
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceVendor();
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x000532C4 File Offset: 0x000514C4
		public static int graphicsDeviceID
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceID();
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x000532DC File Offset: 0x000514DC
		public static int graphicsDeviceVendorID
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceVendorID();
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x000532F4 File Offset: 0x000514F4
		public static string graphicsDeviceVersion
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceVersion();
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x0005330C File Offset: 0x0005150C
		public static bool graphicsMultiThreaded
		{
			get
			{
				return SystemInfo.GetGraphicsMultiThreaded();
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00053324 File Offset: 0x00051524
		public static UnityEngine.Rendering.RenderingThreadingMode renderingThreadingMode
		{
			get
			{
				return SystemInfo.GetRenderingThreadingMode();
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x0005333C File Offset: 0x0005153C
		public static bool hasHiddenSurfaceRemovalOnGPU
		{
			get
			{
				return SystemInfo.HasHiddenSurfaceRemovalOnGPU();
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x00053354 File Offset: 0x00051554
		public static bool hasDynamicUniformArrayIndexingInFragmentShaders
		{
			get
			{
				return SystemInfo.HasDynamicUniformArrayIndexingInFragmentShaders();
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x0005336C File Offset: 0x0005156C
		public static bool supportsShadows
		{
			get
			{
				return SystemInfo.SupportsShadows();
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x00053384 File Offset: 0x00051584
		public static bool supportsRawShadowDepthSampling
		{
			get
			{
				return SystemInfo.SupportsRawShadowDepthSampling();
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0005339C File Offset: 0x0005159C
		public static bool supportsRenderTextures
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x000533B0 File Offset: 0x000515B0
		public static bool supportsRenderToCubemap
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x000533C4 File Offset: 0x000515C4
		public static bool supportsImageEffects
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x000533D8 File Offset: 0x000515D8
		public static bool supports3DTextures
		{
			get
			{
				return SystemInfo.Supports3DTextures();
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x000533F0 File Offset: 0x000515F0
		public static bool supportsCompressed3DTextures
		{
			get
			{
				return SystemInfo.SupportsCompressed3DTextures();
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x00053408 File Offset: 0x00051608
		public static bool supports2DArrayTextures
		{
			get
			{
				return SystemInfo.Supports2DArrayTextures();
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x00053420 File Offset: 0x00051620
		public static bool supportsCubemapArrayTextures
		{
			get
			{
				return SystemInfo.SupportsCubemapArrayTextures();
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x00053438 File Offset: 0x00051638
		public static bool supportsGeometryShaders
		{
			get
			{
				return SystemInfo.SupportsGeometryShaders();
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x00053450 File Offset: 0x00051650
		public static bool supportsTessellationShaders
		{
			get
			{
				return SystemInfo.SupportsTessellationShaders();
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00053468 File Offset: 0x00051668
		public static bool supportsRenderTargetArrayIndexFromVertexShader
		{
			get
			{
				return SystemInfo.SupportsRenderTargetArrayIndexFromVertexShader();
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x00053480 File Offset: 0x00051680
		public static bool supportsInstancing
		{
			get
			{
				return SystemInfo.SupportsInstancing();
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00053498 File Offset: 0x00051698
		public static bool supportsHardwareQuadTopology
		{
			get
			{
				return SystemInfo.SupportsHardwareQuadTopology();
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x000534B0 File Offset: 0x000516B0
		public static bool supports32bitsIndexBuffer
		{
			get
			{
				return SystemInfo.Supports32bitsIndexBuffer();
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x000534C8 File Offset: 0x000516C8
		public static bool supportsSparseTextures
		{
			get
			{
				return SystemInfo.SupportsSparseTextures();
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x000534E0 File Offset: 0x000516E0
		public static bool supportsSeparatedRenderTargetsBlend
		{
			get
			{
				return SystemInfo.SupportsSeparatedRenderTargetsBlend();
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x000534F8 File Offset: 0x000516F8
		public static int supportedRandomWriteTargetCount
		{
			get
			{
				return SystemInfo.SupportedRandomWriteTargetCount();
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x00053510 File Offset: 0x00051710
		public static int supportsMultisampledTextures
		{
			get
			{
				return SystemInfo.SupportsMultisampledTextures();
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x00053528 File Offset: 0x00051728
		public static bool supportsMultisampled2DArrayTextures
		{
			get
			{
				return SystemInfo.SupportsMultisampled2DArrayTextures();
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x00053540 File Offset: 0x00051740
		public static bool supportsMultisampleAutoResolve
		{
			get
			{
				return SystemInfo.SupportsMultisampleAutoResolve();
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x00053558 File Offset: 0x00051758
		public static int supportsTextureWrapMirrorOnce
		{
			get
			{
				return SystemInfo.SupportsTextureWrapMirrorOnce();
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00053570 File Offset: 0x00051770
		public static int supportsStencil
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00053584 File Offset: 0x00051784
		public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsBlendingOnRenderTextureFormat; format is not a valid RenderTextureFormat");
			}
			return SystemInfo.SupportsBlendingOnRenderTextureFormatNative(format);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x000535BC File Offset: 0x000517BC
		public static bool SupportsVertexAttributeFormat(UnityEngine.Rendering.VertexAttributeFormat format, int dimension)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsVertexAttributeFormat; format is not a valid VertexAttributeFormat");
			}
			bool flag2 = dimension < 1 || dimension > 4;
			if (flag2)
			{
				throw new ArgumentException("Failed SupportsVertexAttributeFormat; dimension must be in 1..4 range");
			}
			return SystemInfo.SupportsVertexAttributeFormatNative(format, dimension);
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x0005360C File Offset: 0x0005180C
		public static NPOTSupport npotSupport
		{
			get
			{
				return SystemInfo.GetNPOTSupport();
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x00053624 File Offset: 0x00051824
		public static int maxTextureSize
		{
			get
			{
				return SystemInfo.GetMaxTextureSize();
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x0005363C File Offset: 0x0005183C
		public static int maxTexture3DSize
		{
			get
			{
				return SystemInfo.GetMaxTexture3DSize();
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x00053654 File Offset: 0x00051854
		public static int maxTextureArraySlices
		{
			get
			{
				return SystemInfo.GetMaxTextureArraySlices();
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0005366C File Offset: 0x0005186C
		public static int maxCubemapSize
		{
			get
			{
				return SystemInfo.GetMaxCubemapSize();
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x00053684 File Offset: 0x00051884
		public static int maxRenderTextureSize
		{
			get
			{
				return SystemInfo.GetMaxRenderTextureSize();
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0005369C File Offset: 0x0005189C
		public static int maxComputeBufferInputsVertex
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsVertex();
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x000536B4 File Offset: 0x000518B4
		public static int maxComputeBufferInputsFragment
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsFragment();
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x000536CC File Offset: 0x000518CC
		public static int maxComputeBufferInputsGeometry
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsGeometry();
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x000536E4 File Offset: 0x000518E4
		public static int maxComputeBufferInputsDomain
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsDomain();
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x000536FC File Offset: 0x000518FC
		public static int maxComputeBufferInputsHull
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsHull();
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00053714 File Offset: 0x00051914
		public static int maxComputeBufferInputsCompute
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsCompute();
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0005372C File Offset: 0x0005192C
		public static int maxComputeWorkGroupSize
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSize();
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x00053744 File Offset: 0x00051944
		public static int maxComputeWorkGroupSizeX
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeX();
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0005375C File Offset: 0x0005195C
		public static int maxComputeWorkGroupSizeY
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeY();
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x00053774 File Offset: 0x00051974
		public static int maxComputeWorkGroupSizeZ
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeZ();
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x0005378C File Offset: 0x0005198C
		public static int computeSubGroupSize
		{
			get
			{
				return SystemInfo.GetComputeSubGroupSize();
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x000537A4 File Offset: 0x000519A4
		public static bool supportsAsyncCompute
		{
			get
			{
				return SystemInfo.SupportsAsyncCompute();
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x000537BC File Offset: 0x000519BC
		public static bool supportsGpuRecorder
		{
			get
			{
				return SystemInfo.SupportsGpuRecorder();
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x000537D4 File Offset: 0x000519D4
		public static bool supportsGraphicsFence
		{
			get
			{
				return SystemInfo.SupportsGPUFence();
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x000537EC File Offset: 0x000519EC
		public static bool supportsAsyncGPUReadback
		{
			get
			{
				return SystemInfo.SupportsAsyncGPUReadback();
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00053804 File Offset: 0x00051A04
		public static bool supportsRayTracing
		{
			get
			{
				return SystemInfo.SupportsRayTracing();
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x0005381C File Offset: 0x00051A1C
		public static bool supportsSetConstantBuffer
		{
			get
			{
				return SystemInfo.SupportsSetConstantBuffer();
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x00053834 File Offset: 0x00051A34
		public static int constantBufferOffsetAlignment
		{
			get
			{
				return SystemInfo.MinConstantBufferOffsetAlignment();
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x0005384C File Offset: 0x00051A4C
		public static bool minConstantBufferOffsetAlignment
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x00053860 File Offset: 0x00051A60
		public static bool hasMipMaxLevel
		{
			get
			{
				return SystemInfo.HasMipMaxLevel();
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x00053878 File Offset: 0x00051A78
		public static bool supportsMipStreaming
		{
			get
			{
				return SystemInfo.SupportsMipStreaming();
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x00053890 File Offset: 0x00051A90
		public static int graphicsPixelFillrate
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x000538A4 File Offset: 0x00051AA4
		public static HDRDisplaySupportFlags hdrDisplaySupportFlags
		{
			get
			{
				return SystemInfo.GetHDRDisplaySupportFlags();
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000538BC File Offset: 0x00051ABC
		public static bool supportsConservativeRaster
		{
			get
			{
				return SystemInfo.SupportsConservativeRaster();
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x000538D4 File Offset: 0x00051AD4
		public static bool supportsMultiview
		{
			get
			{
				return SystemInfo.SupportsMultiview();
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x000538EC File Offset: 0x00051AEC
		public static bool supportsStoreAndResolveAction
		{
			get
			{
				return SystemInfo.SupportsStoreAndResolveAction();
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x00053904 File Offset: 0x00051B04
		public static bool supportsVertexPrograms
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0000B903 File Offset: 0x00009B03
		public static float GetBatteryLevel()
		{
			return SystemInfo.GetBatteryLevelDelegateField();
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0000B90F File Offset: 0x00009B0F
		public static BatteryStatus GetBatteryStatus()
		{
			return SystemInfo.GetBatteryStatusDelegateField();
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00053918 File Offset: 0x00051B18
		public static string GetOperatingSystem()
		{
			IntPtr intPtr = SystemInfo.GetOperatingSystemDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00053938 File Offset: 0x00051B38
		public static string GetProcessorType()
		{
			IntPtr intPtr = SystemInfo.GetProcessorTypeDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0000B91B File Offset: 0x00009B1B
		public static int GetProcessorFrequencyMHz()
		{
			return SystemInfo.GetProcessorFrequencyMHzDelegateField();
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0000B927 File Offset: 0x00009B27
		public static int GetProcessorCount()
		{
			return SystemInfo.GetProcessorCountDelegateField();
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0000B933 File Offset: 0x00009B33
		public static int GetPhysicalMemoryMB()
		{
			return SystemInfo.GetPhysicalMemoryMBDelegateField();
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0000B93F File Offset: 0x00009B3F
		public static bool SupportsAccelerometer()
		{
			return SystemInfo.SupportsAccelerometerDelegateField();
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0000B94B File Offset: 0x00009B4B
		public static bool IsGyroAvailable()
		{
			return SystemInfo.IsGyroAvailableDelegateField();
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0000B957 File Offset: 0x00009B57
		public static bool SupportsLocationService()
		{
			return SystemInfo.SupportsLocationServiceDelegateField();
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0000B963 File Offset: 0x00009B63
		public static bool SupportsVibration()
		{
			return SystemInfo.SupportsVibrationDelegateField();
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0000B96F File Offset: 0x00009B6F
		public static bool SupportsAudio()
		{
			return SystemInfo.SupportsAudioDelegateField();
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0000B97B File Offset: 0x00009B7B
		public static int GetGraphicsMemorySize()
		{
			return SystemInfo.GetGraphicsMemorySizeDelegateField();
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00053958 File Offset: 0x00051B58
		public static string GetGraphicsDeviceName()
		{
			IntPtr intPtr = SystemInfo.GetGraphicsDeviceNameDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00053978 File Offset: 0x00051B78
		public static string GetGraphicsDeviceVendor()
		{
			IntPtr intPtr = SystemInfo.GetGraphicsDeviceVendorDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0000B987 File Offset: 0x00009B87
		public static int GetGraphicsDeviceID()
		{
			return SystemInfo.GetGraphicsDeviceIDDelegateField();
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0000B993 File Offset: 0x00009B93
		public static int GetGraphicsDeviceVendorID()
		{
			return SystemInfo.GetGraphicsDeviceVendorIDDelegateField();
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00053998 File Offset: 0x00051B98
		public static string GetGraphicsDeviceVersion()
		{
			IntPtr intPtr = SystemInfo.GetGraphicsDeviceVersionDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0000B99F File Offset: 0x00009B9F
		public static bool GetGraphicsMultiThreaded()
		{
			return SystemInfo.GetGraphicsMultiThreadedDelegateField();
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0000B9AB File Offset: 0x00009BAB
		public static UnityEngine.Rendering.RenderingThreadingMode GetRenderingThreadingMode()
		{
			return SystemInfo.GetRenderingThreadingModeDelegateField();
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0000B9B7 File Offset: 0x00009BB7
		public static bool HasHiddenSurfaceRemovalOnGPU()
		{
			return SystemInfo.HasHiddenSurfaceRemovalOnGPUDelegateField();
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0000B9C3 File Offset: 0x00009BC3
		public static bool HasDynamicUniformArrayIndexingInFragmentShaders()
		{
			return SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegateField();
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0000B9CF File Offset: 0x00009BCF
		public static bool SupportsShadows()
		{
			return SystemInfo.SupportsShadowsDelegateField();
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0000B9DB File Offset: 0x00009BDB
		public static bool SupportsRawShadowDepthSampling()
		{
			return SystemInfo.SupportsRawShadowDepthSamplingDelegateField();
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0000B9E7 File Offset: 0x00009BE7
		public static bool Supports3DTextures()
		{
			return SystemInfo.Supports3DTexturesDelegateField();
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0000B9F3 File Offset: 0x00009BF3
		public static bool SupportsCompressed3DTextures()
		{
			return SystemInfo.SupportsCompressed3DTexturesDelegateField();
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0000B9FF File Offset: 0x00009BFF
		public static bool Supports2DArrayTextures()
		{
			return SystemInfo.Supports2DArrayTexturesDelegateField();
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0000BA0B File Offset: 0x00009C0B
		public static bool SupportsCubemapArrayTextures()
		{
			return SystemInfo.SupportsCubemapArrayTexturesDelegateField();
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0000BA17 File Offset: 0x00009C17
		public static bool SupportsGeometryShaders()
		{
			return SystemInfo.SupportsGeometryShadersDelegateField();
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0000BA23 File Offset: 0x00009C23
		public static bool SupportsTessellationShaders()
		{
			return SystemInfo.SupportsTessellationShadersDelegateField();
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0000BA2F File Offset: 0x00009C2F
		public static bool SupportsRenderTargetArrayIndexFromVertexShader()
		{
			return SystemInfo.SupportsRenderTargetArrayIndexFromVertexShaderDelegateField();
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0000BA3B File Offset: 0x00009C3B
		public static bool SupportsInstancing()
		{
			return SystemInfo.SupportsInstancingDelegateField();
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0000BA47 File Offset: 0x00009C47
		public static bool SupportsHardwareQuadTopology()
		{
			return SystemInfo.SupportsHardwareQuadTopologyDelegateField();
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0000BA53 File Offset: 0x00009C53
		public static bool Supports32bitsIndexBuffer()
		{
			return SystemInfo.Supports32bitsIndexBufferDelegateField();
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0000BA5F File Offset: 0x00009C5F
		public static bool SupportsSparseTextures()
		{
			return SystemInfo.SupportsSparseTexturesDelegateField();
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0000BA6B File Offset: 0x00009C6B
		public static bool SupportsSeparatedRenderTargetsBlend()
		{
			return SystemInfo.SupportsSeparatedRenderTargetsBlendDelegateField();
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0000BA77 File Offset: 0x00009C77
		public static int SupportedRandomWriteTargetCount()
		{
			return SystemInfo.SupportedRandomWriteTargetCountDelegateField();
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0000BA83 File Offset: 0x00009C83
		public static int MaxComputeBufferInputsVertex()
		{
			return SystemInfo.MaxComputeBufferInputsVertexDelegateField();
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0000BA8F File Offset: 0x00009C8F
		public static int MaxComputeBufferInputsFragment()
		{
			return SystemInfo.MaxComputeBufferInputsFragmentDelegateField();
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0000BA9B File Offset: 0x00009C9B
		public static int MaxComputeBufferInputsGeometry()
		{
			return SystemInfo.MaxComputeBufferInputsGeometryDelegateField();
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0000BAA7 File Offset: 0x00009CA7
		public static int MaxComputeBufferInputsDomain()
		{
			return SystemInfo.MaxComputeBufferInputsDomainDelegateField();
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0000BAB3 File Offset: 0x00009CB3
		public static int MaxComputeBufferInputsHull()
		{
			return SystemInfo.MaxComputeBufferInputsHullDelegateField();
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0000BABF File Offset: 0x00009CBF
		public static int MaxComputeBufferInputsCompute()
		{
			return SystemInfo.MaxComputeBufferInputsComputeDelegateField();
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0000BACB File Offset: 0x00009CCB
		public static int SupportsMultisampledTextures()
		{
			return SystemInfo.SupportsMultisampledTexturesDelegateField();
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0000BAD7 File Offset: 0x00009CD7
		public static bool SupportsMultisampled2DArrayTextures()
		{
			return SystemInfo.SupportsMultisampled2DArrayTexturesDelegateField();
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0000BAE3 File Offset: 0x00009CE3
		public static bool SupportsMultisampleAutoResolve()
		{
			return SystemInfo.SupportsMultisampleAutoResolveDelegateField();
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0000BAEF File Offset: 0x00009CEF
		public static int SupportsTextureWrapMirrorOnce()
		{
			return SystemInfo.SupportsTextureWrapMirrorOnceDelegateField();
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0000BAFB File Offset: 0x00009CFB
		public static bool SupportsBlendingOnRenderTextureFormatNative(RenderTextureFormat format)
		{
			return SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegateField(format);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0000BB08 File Offset: 0x00009D08
		public static bool SupportsVertexAttributeFormatNative(UnityEngine.Rendering.VertexAttributeFormat format, int dimension)
		{
			return SystemInfo.SupportsVertexAttributeFormatNativeDelegateField(format, dimension);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0000BB16 File Offset: 0x00009D16
		public static NPOTSupport GetNPOTSupport()
		{
			return SystemInfo.GetNPOTSupportDelegateField();
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0000BB22 File Offset: 0x00009D22
		public static int GetMaxTextureSize()
		{
			return SystemInfo.GetMaxTextureSizeDelegateField();
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0000BB2E File Offset: 0x00009D2E
		public static int GetMaxTexture3DSize()
		{
			return SystemInfo.GetMaxTexture3DSizeDelegateField();
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0000BB3A File Offset: 0x00009D3A
		public static int GetMaxTextureArraySlices()
		{
			return SystemInfo.GetMaxTextureArraySlicesDelegateField();
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0000BB46 File Offset: 0x00009D46
		public static int GetMaxCubemapSize()
		{
			return SystemInfo.GetMaxCubemapSizeDelegateField();
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0000BB52 File Offset: 0x00009D52
		public static int GetMaxRenderTextureSize()
		{
			return SystemInfo.GetMaxRenderTextureSizeDelegateField();
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0000BB5E File Offset: 0x00009D5E
		public static int GetMaxComputeWorkGroupSize()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeDelegateField();
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0000BB6A File Offset: 0x00009D6A
		public static int GetMaxComputeWorkGroupSizeX()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeXDelegateField();
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0000BB76 File Offset: 0x00009D76
		public static int GetMaxComputeWorkGroupSizeY()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeYDelegateField();
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0000BB82 File Offset: 0x00009D82
		public static int GetMaxComputeWorkGroupSizeZ()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeZDelegateField();
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0000BB8E File Offset: 0x00009D8E
		public static int GetComputeSubGroupSize()
		{
			return SystemInfo.GetComputeSubGroupSizeDelegateField();
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0000BB9A File Offset: 0x00009D9A
		public static bool SupportsAsyncCompute()
		{
			return SystemInfo.SupportsAsyncComputeDelegateField();
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0000BBA6 File Offset: 0x00009DA6
		public static bool SupportsGpuRecorder()
		{
			return SystemInfo.SupportsGpuRecorderDelegateField();
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0000BBB2 File Offset: 0x00009DB2
		public static bool SupportsGPUFence()
		{
			return SystemInfo.SupportsGPUFenceDelegateField();
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0000BBBE File Offset: 0x00009DBE
		public static bool SupportsAsyncGPUReadback()
		{
			return SystemInfo.SupportsAsyncGPUReadbackDelegateField();
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0000BBCA File Offset: 0x00009DCA
		public static bool SupportsRayTracing()
		{
			return SystemInfo.SupportsRayTracingDelegateField();
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0000BBD6 File Offset: 0x00009DD6
		public static bool SupportsSetConstantBuffer()
		{
			return SystemInfo.SupportsSetConstantBufferDelegateField();
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0000BBE2 File Offset: 0x00009DE2
		public static int MinConstantBufferOffsetAlignment()
		{
			return SystemInfo.MinConstantBufferOffsetAlignmentDelegateField();
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x0000BBEE File Offset: 0x00009DEE
		public static bool HasMipMaxLevel()
		{
			return SystemInfo.HasMipMaxLevelDelegateField();
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0000BBFA File Offset: 0x00009DFA
		public static bool SupportsMipStreaming()
		{
			return SystemInfo.SupportsMipStreamingDelegateField();
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0000BC06 File Offset: 0x00009E06
		public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
		{
			return SystemInfo.GetRenderTextureSupportedMSAASampleCount_Injected(ref desc);
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0000BC0F File Offset: 0x00009E0F
		public static HDRDisplaySupportFlags GetHDRDisplaySupportFlags()
		{
			return SystemInfo.GetHDRDisplaySupportFlagsDelegateField();
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0000BC1B File Offset: 0x00009E1B
		public static bool SupportsConservativeRaster()
		{
			return SystemInfo.SupportsConservativeRasterDelegateField();
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0000BC27 File Offset: 0x00009E27
		public static bool SupportsMultiview()
		{
			return SystemInfo.SupportsMultiviewDelegateField();
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0000BC33 File Offset: 0x00009E33
		public static bool SupportsStoreAndResolveAction()
		{
			return SystemInfo.SupportsStoreAndResolveActionDelegateField();
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x000539B8 File Offset: 0x00051BB8
		public static bool supportsGPUFence
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0000BC3F File Offset: 0x00009E3F
		public static int GetRenderTextureSupportedMSAASampleCount_Injected(ref RenderTextureDescriptor desc)
		{
			return SystemInfo.GetRenderTextureSupportedMSAASampleCount_InjectedDelegateField(ref desc);
		}

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceName_Public_Static_get_String_0;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsMotionVectors_Public_Static_get_Boolean_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_get_supports3DRenderTextures_Public_Static_get_Boolean_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceName_Private_Static_String_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_SupportsMotionVectors_Private_Static_Boolean_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_Supports3DRenderTextures_Private_Static_Boolean_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0;

		// Token: 0x04001052 RID: 4178
		public const string unsupportedIdentifier = "n/a";

		// Token: 0x04001053 RID: 4179
		private static readonly SystemInfo.GetBatteryLevelDelegate GetBatteryLevelDelegateField;

		// Token: 0x04001054 RID: 4180
		private static readonly SystemInfo.GetBatteryStatusDelegate GetBatteryStatusDelegateField;

		// Token: 0x04001055 RID: 4181
		private static readonly SystemInfo.GetOperatingSystemDelegate GetOperatingSystemDelegateField;

		// Token: 0x04001056 RID: 4182
		private static readonly SystemInfo.GetProcessorTypeDelegate GetProcessorTypeDelegateField;

		// Token: 0x04001057 RID: 4183
		private static readonly SystemInfo.GetProcessorFrequencyMHzDelegate GetProcessorFrequencyMHzDelegateField;

		// Token: 0x04001058 RID: 4184
		private static readonly SystemInfo.GetProcessorCountDelegate GetProcessorCountDelegateField;

		// Token: 0x04001059 RID: 4185
		private static readonly SystemInfo.GetPhysicalMemoryMBDelegate GetPhysicalMemoryMBDelegateField;

		// Token: 0x0400105A RID: 4186
		private static readonly SystemInfo.SupportsAccelerometerDelegate SupportsAccelerometerDelegateField;

		// Token: 0x0400105B RID: 4187
		private static readonly SystemInfo.IsGyroAvailableDelegate IsGyroAvailableDelegateField;

		// Token: 0x0400105C RID: 4188
		private static readonly SystemInfo.SupportsLocationServiceDelegate SupportsLocationServiceDelegateField;

		// Token: 0x0400105D RID: 4189
		private static readonly SystemInfo.SupportsVibrationDelegate SupportsVibrationDelegateField;

		// Token: 0x0400105E RID: 4190
		private static readonly SystemInfo.SupportsAudioDelegate SupportsAudioDelegateField;

		// Token: 0x0400105F RID: 4191
		private static readonly SystemInfo.GetGraphicsMemorySizeDelegate GetGraphicsMemorySizeDelegateField;

		// Token: 0x04001060 RID: 4192
		private static readonly SystemInfo.GetGraphicsDeviceNameDelegate GetGraphicsDeviceNameDelegateField;

		// Token: 0x04001061 RID: 4193
		private static readonly SystemInfo.GetGraphicsDeviceVendorDelegate GetGraphicsDeviceVendorDelegateField;

		// Token: 0x04001062 RID: 4194
		private static readonly SystemInfo.GetGraphicsDeviceIDDelegate GetGraphicsDeviceIDDelegateField;

		// Token: 0x04001063 RID: 4195
		private static readonly SystemInfo.GetGraphicsDeviceVendorIDDelegate GetGraphicsDeviceVendorIDDelegateField;

		// Token: 0x04001064 RID: 4196
		private static readonly SystemInfo.GetGraphicsDeviceVersionDelegate GetGraphicsDeviceVersionDelegateField;

		// Token: 0x04001065 RID: 4197
		private static readonly SystemInfo.GetGraphicsMultiThreadedDelegate GetGraphicsMultiThreadedDelegateField;

		// Token: 0x04001066 RID: 4198
		private static readonly SystemInfo.GetRenderingThreadingModeDelegate GetRenderingThreadingModeDelegateField;

		// Token: 0x04001067 RID: 4199
		private static readonly SystemInfo.HasHiddenSurfaceRemovalOnGPUDelegate HasHiddenSurfaceRemovalOnGPUDelegateField;

		// Token: 0x04001068 RID: 4200
		private static readonly SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegate HasDynamicUniformArrayIndexingInFragmentShadersDelegateField;

		// Token: 0x04001069 RID: 4201
		private static readonly SystemInfo.SupportsShadowsDelegate SupportsShadowsDelegateField;

		// Token: 0x0400106A RID: 4202
		private static readonly SystemInfo.SupportsRawShadowDepthSamplingDelegate SupportsRawShadowDepthSamplingDelegateField;

		// Token: 0x0400106B RID: 4203
		private static readonly SystemInfo.Supports3DTexturesDelegate Supports3DTexturesDelegateField;

		// Token: 0x0400106C RID: 4204
		private static readonly SystemInfo.SupportsCompressed3DTexturesDelegate SupportsCompressed3DTexturesDelegateField;

		// Token: 0x0400106D RID: 4205
		private static readonly SystemInfo.Supports2DArrayTexturesDelegate Supports2DArrayTexturesDelegateField;

		// Token: 0x0400106E RID: 4206
		private static readonly SystemInfo.SupportsCubemapArrayTexturesDelegate SupportsCubemapArrayTexturesDelegateField;

		// Token: 0x0400106F RID: 4207
		private static readonly SystemInfo.SupportsGeometryShadersDelegate SupportsGeometryShadersDelegateField;

		// Token: 0x04001070 RID: 4208
		private static readonly SystemInfo.SupportsTessellationShadersDelegate SupportsTessellationShadersDelegateField;

		// Token: 0x04001071 RID: 4209
		private static readonly SystemInfo.SupportsRenderTargetArrayIndexFromVertexShaderDelegate SupportsRenderTargetArrayIndexFromVertexShaderDelegateField;

		// Token: 0x04001072 RID: 4210
		private static readonly SystemInfo.SupportsInstancingDelegate SupportsInstancingDelegateField;

		// Token: 0x04001073 RID: 4211
		private static readonly SystemInfo.SupportsHardwareQuadTopologyDelegate SupportsHardwareQuadTopologyDelegateField;

		// Token: 0x04001074 RID: 4212
		private static readonly SystemInfo.Supports32bitsIndexBufferDelegate Supports32bitsIndexBufferDelegateField;

		// Token: 0x04001075 RID: 4213
		private static readonly SystemInfo.SupportsSparseTexturesDelegate SupportsSparseTexturesDelegateField;

		// Token: 0x04001076 RID: 4214
		private static readonly SystemInfo.SupportsSeparatedRenderTargetsBlendDelegate SupportsSeparatedRenderTargetsBlendDelegateField;

		// Token: 0x04001077 RID: 4215
		private static readonly SystemInfo.SupportedRandomWriteTargetCountDelegate SupportedRandomWriteTargetCountDelegateField;

		// Token: 0x04001078 RID: 4216
		private static readonly SystemInfo.MaxComputeBufferInputsVertexDelegate MaxComputeBufferInputsVertexDelegateField;

		// Token: 0x04001079 RID: 4217
		private static readonly SystemInfo.MaxComputeBufferInputsFragmentDelegate MaxComputeBufferInputsFragmentDelegateField;

		// Token: 0x0400107A RID: 4218
		private static readonly SystemInfo.MaxComputeBufferInputsGeometryDelegate MaxComputeBufferInputsGeometryDelegateField;

		// Token: 0x0400107B RID: 4219
		private static readonly SystemInfo.MaxComputeBufferInputsDomainDelegate MaxComputeBufferInputsDomainDelegateField;

		// Token: 0x0400107C RID: 4220
		private static readonly SystemInfo.MaxComputeBufferInputsHullDelegate MaxComputeBufferInputsHullDelegateField;

		// Token: 0x0400107D RID: 4221
		private static readonly SystemInfo.MaxComputeBufferInputsComputeDelegate MaxComputeBufferInputsComputeDelegateField;

		// Token: 0x0400107E RID: 4222
		private static readonly SystemInfo.SupportsMultisampledTexturesDelegate SupportsMultisampledTexturesDelegateField;

		// Token: 0x0400107F RID: 4223
		private static readonly SystemInfo.SupportsMultisampled2DArrayTexturesDelegate SupportsMultisampled2DArrayTexturesDelegateField;

		// Token: 0x04001080 RID: 4224
		private static readonly SystemInfo.SupportsMultisampleAutoResolveDelegate SupportsMultisampleAutoResolveDelegateField;

		// Token: 0x04001081 RID: 4225
		private static readonly SystemInfo.SupportsTextureWrapMirrorOnceDelegate SupportsTextureWrapMirrorOnceDelegateField;

		// Token: 0x04001082 RID: 4226
		private static readonly SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegate SupportsBlendingOnRenderTextureFormatNativeDelegateField;

		// Token: 0x04001083 RID: 4227
		private static readonly SystemInfo.SupportsVertexAttributeFormatNativeDelegate SupportsVertexAttributeFormatNativeDelegateField;

		// Token: 0x04001084 RID: 4228
		private static readonly SystemInfo.GetNPOTSupportDelegate GetNPOTSupportDelegateField;

		// Token: 0x04001085 RID: 4229
		private static readonly SystemInfo.GetMaxTextureSizeDelegate GetMaxTextureSizeDelegateField;

		// Token: 0x04001086 RID: 4230
		private static readonly SystemInfo.GetMaxTexture3DSizeDelegate GetMaxTexture3DSizeDelegateField;

		// Token: 0x04001087 RID: 4231
		private static readonly SystemInfo.GetMaxTextureArraySlicesDelegate GetMaxTextureArraySlicesDelegateField;

		// Token: 0x04001088 RID: 4232
		private static readonly SystemInfo.GetMaxCubemapSizeDelegate GetMaxCubemapSizeDelegateField;

		// Token: 0x04001089 RID: 4233
		private static readonly SystemInfo.GetMaxRenderTextureSizeDelegate GetMaxRenderTextureSizeDelegateField;

		// Token: 0x0400108A RID: 4234
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeDelegate GetMaxComputeWorkGroupSizeDelegateField;

		// Token: 0x0400108B RID: 4235
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeXDelegate GetMaxComputeWorkGroupSizeXDelegateField;

		// Token: 0x0400108C RID: 4236
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeYDelegate GetMaxComputeWorkGroupSizeYDelegateField;

		// Token: 0x0400108D RID: 4237
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeZDelegate GetMaxComputeWorkGroupSizeZDelegateField;

		// Token: 0x0400108E RID: 4238
		private static readonly SystemInfo.GetComputeSubGroupSizeDelegate GetComputeSubGroupSizeDelegateField;

		// Token: 0x0400108F RID: 4239
		private static readonly SystemInfo.SupportsAsyncComputeDelegate SupportsAsyncComputeDelegateField;

		// Token: 0x04001090 RID: 4240
		private static readonly SystemInfo.SupportsGpuRecorderDelegate SupportsGpuRecorderDelegateField;

		// Token: 0x04001091 RID: 4241
		private static readonly SystemInfo.SupportsGPUFenceDelegate SupportsGPUFenceDelegateField;

		// Token: 0x04001092 RID: 4242
		private static readonly SystemInfo.SupportsAsyncGPUReadbackDelegate SupportsAsyncGPUReadbackDelegateField;

		// Token: 0x04001093 RID: 4243
		private static readonly SystemInfo.SupportsRayTracingDelegate SupportsRayTracingDelegateField;

		// Token: 0x04001094 RID: 4244
		private static readonly SystemInfo.SupportsSetConstantBufferDelegate SupportsSetConstantBufferDelegateField;

		// Token: 0x04001095 RID: 4245
		private static readonly SystemInfo.MinConstantBufferOffsetAlignmentDelegate MinConstantBufferOffsetAlignmentDelegateField;

		// Token: 0x04001096 RID: 4246
		private static readonly SystemInfo.HasMipMaxLevelDelegate HasMipMaxLevelDelegateField;

		// Token: 0x04001097 RID: 4247
		private static readonly SystemInfo.SupportsMipStreamingDelegate SupportsMipStreamingDelegateField;

		// Token: 0x04001098 RID: 4248
		private static readonly SystemInfo.GetHDRDisplaySupportFlagsDelegate GetHDRDisplaySupportFlagsDelegateField;

		// Token: 0x04001099 RID: 4249
		private static readonly SystemInfo.SupportsConservativeRasterDelegate SupportsConservativeRasterDelegateField;

		// Token: 0x0400109A RID: 4250
		private static readonly SystemInfo.SupportsMultiviewDelegate SupportsMultiviewDelegateField;

		// Token: 0x0400109B RID: 4251
		private static readonly SystemInfo.SupportsStoreAndResolveActionDelegate SupportsStoreAndResolveActionDelegateField;

		// Token: 0x0400109C RID: 4252
		private static readonly SystemInfo.GetRenderTextureSupportedMSAASampleCount_InjectedDelegate GetRenderTextureSupportedMSAASampleCount_InjectedDelegateField;

		// Token: 0x020007F1 RID: 2033
		// (Invoke) Token: 0x06002DE4 RID: 11748
		private delegate float GetBatteryLevelDelegate();

		// Token: 0x020007F2 RID: 2034
		// (Invoke) Token: 0x06002DE6 RID: 11750
		private delegate BatteryStatus GetBatteryStatusDelegate();

		// Token: 0x020007F3 RID: 2035
		// (Invoke) Token: 0x06002DE8 RID: 11752
		private delegate IntPtr GetOperatingSystemDelegate();

		// Token: 0x020007F4 RID: 2036
		// (Invoke) Token: 0x06002DEA RID: 11754
		private delegate IntPtr GetProcessorTypeDelegate();

		// Token: 0x020007F5 RID: 2037
		// (Invoke) Token: 0x06002DEC RID: 11756
		private delegate int GetProcessorFrequencyMHzDelegate();

		// Token: 0x020007F6 RID: 2038
		// (Invoke) Token: 0x06002DEE RID: 11758
		private delegate int GetProcessorCountDelegate();

		// Token: 0x020007F7 RID: 2039
		// (Invoke) Token: 0x06002DF0 RID: 11760
		private delegate int GetPhysicalMemoryMBDelegate();

		// Token: 0x020007F8 RID: 2040
		// (Invoke) Token: 0x06002DF2 RID: 11762
		private delegate bool SupportsAccelerometerDelegate();

		// Token: 0x020007F9 RID: 2041
		// (Invoke) Token: 0x06002DF4 RID: 11764
		private delegate bool IsGyroAvailableDelegate();

		// Token: 0x020007FA RID: 2042
		// (Invoke) Token: 0x06002DF6 RID: 11766
		private delegate bool SupportsLocationServiceDelegate();

		// Token: 0x020007FB RID: 2043
		// (Invoke) Token: 0x06002DF8 RID: 11768
		private delegate bool SupportsVibrationDelegate();

		// Token: 0x020007FC RID: 2044
		// (Invoke) Token: 0x06002DFA RID: 11770
		private delegate bool SupportsAudioDelegate();

		// Token: 0x020007FD RID: 2045
		// (Invoke) Token: 0x06002DFC RID: 11772
		private delegate int GetGraphicsMemorySizeDelegate();

		// Token: 0x020007FE RID: 2046
		// (Invoke) Token: 0x06002DFE RID: 11774
		private delegate IntPtr GetGraphicsDeviceNameDelegate();

		// Token: 0x020007FF RID: 2047
		// (Invoke) Token: 0x06002E00 RID: 11776
		private delegate IntPtr GetGraphicsDeviceVendorDelegate();

		// Token: 0x02000800 RID: 2048
		// (Invoke) Token: 0x06002E02 RID: 11778
		private delegate int GetGraphicsDeviceIDDelegate();

		// Token: 0x02000801 RID: 2049
		// (Invoke) Token: 0x06002E04 RID: 11780
		private delegate int GetGraphicsDeviceVendorIDDelegate();

		// Token: 0x02000802 RID: 2050
		// (Invoke) Token: 0x06002E06 RID: 11782
		private delegate IntPtr GetGraphicsDeviceVersionDelegate();

		// Token: 0x02000803 RID: 2051
		// (Invoke) Token: 0x06002E08 RID: 11784
		private delegate bool GetGraphicsMultiThreadedDelegate();

		// Token: 0x02000804 RID: 2052
		// (Invoke) Token: 0x06002E0A RID: 11786
		private delegate UnityEngine.Rendering.RenderingThreadingMode GetRenderingThreadingModeDelegate();

		// Token: 0x02000805 RID: 2053
		// (Invoke) Token: 0x06002E0C RID: 11788
		private delegate bool HasHiddenSurfaceRemovalOnGPUDelegate();

		// Token: 0x02000806 RID: 2054
		// (Invoke) Token: 0x06002E0E RID: 11790
		private delegate bool HasDynamicUniformArrayIndexingInFragmentShadersDelegate();

		// Token: 0x02000807 RID: 2055
		// (Invoke) Token: 0x06002E10 RID: 11792
		private delegate bool SupportsShadowsDelegate();

		// Token: 0x02000808 RID: 2056
		// (Invoke) Token: 0x06002E12 RID: 11794
		private delegate bool SupportsRawShadowDepthSamplingDelegate();

		// Token: 0x02000809 RID: 2057
		// (Invoke) Token: 0x06002E14 RID: 11796
		private delegate bool Supports3DTexturesDelegate();

		// Token: 0x0200080A RID: 2058
		// (Invoke) Token: 0x06002E16 RID: 11798
		private delegate bool SupportsCompressed3DTexturesDelegate();

		// Token: 0x0200080B RID: 2059
		// (Invoke) Token: 0x06002E18 RID: 11800
		private delegate bool Supports2DArrayTexturesDelegate();

		// Token: 0x0200080C RID: 2060
		// (Invoke) Token: 0x06002E1A RID: 11802
		private delegate bool SupportsCubemapArrayTexturesDelegate();

		// Token: 0x0200080D RID: 2061
		// (Invoke) Token: 0x06002E1C RID: 11804
		private delegate bool SupportsGeometryShadersDelegate();

		// Token: 0x0200080E RID: 2062
		// (Invoke) Token: 0x06002E1E RID: 11806
		private delegate bool SupportsTessellationShadersDelegate();

		// Token: 0x0200080F RID: 2063
		// (Invoke) Token: 0x06002E20 RID: 11808
		private delegate bool SupportsRenderTargetArrayIndexFromVertexShaderDelegate();

		// Token: 0x02000810 RID: 2064
		// (Invoke) Token: 0x06002E22 RID: 11810
		private delegate bool SupportsInstancingDelegate();

		// Token: 0x02000811 RID: 2065
		// (Invoke) Token: 0x06002E24 RID: 11812
		private delegate bool SupportsHardwareQuadTopologyDelegate();

		// Token: 0x02000812 RID: 2066
		// (Invoke) Token: 0x06002E26 RID: 11814
		private delegate bool Supports32bitsIndexBufferDelegate();

		// Token: 0x02000813 RID: 2067
		// (Invoke) Token: 0x06002E28 RID: 11816
		private delegate bool SupportsSparseTexturesDelegate();

		// Token: 0x02000814 RID: 2068
		// (Invoke) Token: 0x06002E2A RID: 11818
		private delegate bool SupportsSeparatedRenderTargetsBlendDelegate();

		// Token: 0x02000815 RID: 2069
		// (Invoke) Token: 0x06002E2C RID: 11820
		private delegate int SupportedRandomWriteTargetCountDelegate();

		// Token: 0x02000816 RID: 2070
		// (Invoke) Token: 0x06002E2E RID: 11822
		private delegate int MaxComputeBufferInputsVertexDelegate();

		// Token: 0x02000817 RID: 2071
		// (Invoke) Token: 0x06002E30 RID: 11824
		private delegate int MaxComputeBufferInputsFragmentDelegate();

		// Token: 0x02000818 RID: 2072
		// (Invoke) Token: 0x06002E32 RID: 11826
		private delegate int MaxComputeBufferInputsGeometryDelegate();

		// Token: 0x02000819 RID: 2073
		// (Invoke) Token: 0x06002E34 RID: 11828
		private delegate int MaxComputeBufferInputsDomainDelegate();

		// Token: 0x0200081A RID: 2074
		// (Invoke) Token: 0x06002E36 RID: 11830
		private delegate int MaxComputeBufferInputsHullDelegate();

		// Token: 0x0200081B RID: 2075
		// (Invoke) Token: 0x06002E38 RID: 11832
		private delegate int MaxComputeBufferInputsComputeDelegate();

		// Token: 0x0200081C RID: 2076
		// (Invoke) Token: 0x06002E3A RID: 11834
		private delegate int SupportsMultisampledTexturesDelegate();

		// Token: 0x0200081D RID: 2077
		// (Invoke) Token: 0x06002E3C RID: 11836
		private delegate bool SupportsMultisampled2DArrayTexturesDelegate();

		// Token: 0x0200081E RID: 2078
		// (Invoke) Token: 0x06002E3E RID: 11838
		private delegate bool SupportsMultisampleAutoResolveDelegate();

		// Token: 0x0200081F RID: 2079
		// (Invoke) Token: 0x06002E40 RID: 11840
		private delegate int SupportsTextureWrapMirrorOnceDelegate();

		// Token: 0x02000820 RID: 2080
		// (Invoke) Token: 0x06002E42 RID: 11842
		private delegate bool SupportsBlendingOnRenderTextureFormatNativeDelegate(RenderTextureFormat format);

		// Token: 0x02000821 RID: 2081
		// (Invoke) Token: 0x06002E44 RID: 11844
		private delegate bool SupportsVertexAttributeFormatNativeDelegate(UnityEngine.Rendering.VertexAttributeFormat format, int dimension);

		// Token: 0x02000822 RID: 2082
		// (Invoke) Token: 0x06002E46 RID: 11846
		private delegate NPOTSupport GetNPOTSupportDelegate();

		// Token: 0x02000823 RID: 2083
		// (Invoke) Token: 0x06002E48 RID: 11848
		private delegate int GetMaxTextureSizeDelegate();

		// Token: 0x02000824 RID: 2084
		// (Invoke) Token: 0x06002E4A RID: 11850
		private delegate int GetMaxTexture3DSizeDelegate();

		// Token: 0x02000825 RID: 2085
		// (Invoke) Token: 0x06002E4C RID: 11852
		private delegate int GetMaxTextureArraySlicesDelegate();

		// Token: 0x02000826 RID: 2086
		// (Invoke) Token: 0x06002E4E RID: 11854
		private delegate int GetMaxCubemapSizeDelegate();

		// Token: 0x02000827 RID: 2087
		// (Invoke) Token: 0x06002E50 RID: 11856
		private delegate int GetMaxRenderTextureSizeDelegate();

		// Token: 0x02000828 RID: 2088
		// (Invoke) Token: 0x06002E52 RID: 11858
		private delegate int GetMaxComputeWorkGroupSizeDelegate();

		// Token: 0x02000829 RID: 2089
		// (Invoke) Token: 0x06002E54 RID: 11860
		private delegate int GetMaxComputeWorkGroupSizeXDelegate();

		// Token: 0x0200082A RID: 2090
		// (Invoke) Token: 0x06002E56 RID: 11862
		private delegate int GetMaxComputeWorkGroupSizeYDelegate();

		// Token: 0x0200082B RID: 2091
		// (Invoke) Token: 0x06002E58 RID: 11864
		private delegate int GetMaxComputeWorkGroupSizeZDelegate();

		// Token: 0x0200082C RID: 2092
		// (Invoke) Token: 0x06002E5A RID: 11866
		private delegate int GetComputeSubGroupSizeDelegate();

		// Token: 0x0200082D RID: 2093
		// (Invoke) Token: 0x06002E5C RID: 11868
		private delegate bool SupportsAsyncComputeDelegate();

		// Token: 0x0200082E RID: 2094
		// (Invoke) Token: 0x06002E5E RID: 11870
		private delegate bool SupportsGpuRecorderDelegate();

		// Token: 0x0200082F RID: 2095
		// (Invoke) Token: 0x06002E60 RID: 11872
		private delegate bool SupportsGPUFenceDelegate();

		// Token: 0x02000830 RID: 2096
		// (Invoke) Token: 0x06002E62 RID: 11874
		private delegate bool SupportsAsyncGPUReadbackDelegate();

		// Token: 0x02000831 RID: 2097
		// (Invoke) Token: 0x06002E64 RID: 11876
		private delegate bool SupportsRayTracingDelegate();

		// Token: 0x02000832 RID: 2098
		// (Invoke) Token: 0x06002E66 RID: 11878
		private delegate bool SupportsSetConstantBufferDelegate();

		// Token: 0x02000833 RID: 2099
		// (Invoke) Token: 0x06002E68 RID: 11880
		private delegate int MinConstantBufferOffsetAlignmentDelegate();

		// Token: 0x02000834 RID: 2100
		// (Invoke) Token: 0x06002E6A RID: 11882
		private delegate bool HasMipMaxLevelDelegate();

		// Token: 0x02000835 RID: 2101
		// (Invoke) Token: 0x06002E6C RID: 11884
		private delegate bool SupportsMipStreamingDelegate();

		// Token: 0x02000836 RID: 2102
		// (Invoke) Token: 0x06002E6E RID: 11886
		private delegate HDRDisplaySupportFlags GetHDRDisplaySupportFlagsDelegate();

		// Token: 0x02000837 RID: 2103
		// (Invoke) Token: 0x06002E70 RID: 11888
		private delegate bool SupportsConservativeRasterDelegate();

		// Token: 0x02000838 RID: 2104
		// (Invoke) Token: 0x06002E72 RID: 11890
		private delegate bool SupportsMultiviewDelegate();

		// Token: 0x02000839 RID: 2105
		// (Invoke) Token: 0x06002E74 RID: 11892
		private delegate bool SupportsStoreAndResolveActionDelegate();

		// Token: 0x0200083A RID: 2106
		// (Invoke) Token: 0x06002E76 RID: 11894
		private delegate int GetRenderTextureSupportedMSAASampleCount_InjectedDelegate(IntPtr desc);
	}
}
