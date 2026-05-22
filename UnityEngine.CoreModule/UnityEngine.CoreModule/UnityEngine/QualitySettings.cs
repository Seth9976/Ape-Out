using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000069 RID: 105
	public sealed class QualitySettings : Object
	{
		// Token: 0x06000730 RID: 1840 RVA: 0x0002777C File Offset: 0x0002597C
		// Note: this type is marked as 'beforefieldinit'.
		static QualitySettings()
		{
			Il2CppClassPointerStore<QualitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "QualitySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr);
			QualitySettings.NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100663831);
			QualitySettings.NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100663832);
			QualitySettings.NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100663833);
			QualitySettings.get_pixelLightCountDelegateField = IL2CPP.ResolveICall<QualitySettings.get_pixelLightCountDelegate>("UnityEngine.QualitySettings::get_pixelLightCount");
			QualitySettings.set_pixelLightCountDelegateField = IL2CPP.ResolveICall<QualitySettings.set_pixelLightCountDelegate>("UnityEngine.QualitySettings::set_pixelLightCount");
			QualitySettings.get_shadowsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowsDelegate>("UnityEngine.QualitySettings::get_shadows");
			QualitySettings.set_shadowsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowsDelegate>("UnityEngine.QualitySettings::set_shadows");
			QualitySettings.get_shadowProjectionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowProjectionDelegate>("UnityEngine.QualitySettings::get_shadowProjection");
			QualitySettings.set_shadowProjectionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowProjectionDelegate>("UnityEngine.QualitySettings::set_shadowProjection");
			QualitySettings.get_shadowCascadesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascadesDelegate>("UnityEngine.QualitySettings::get_shadowCascades");
			QualitySettings.set_shadowCascadesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascadesDelegate>("UnityEngine.QualitySettings::set_shadowCascades");
			QualitySettings.get_shadowDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowDistanceDelegate>("UnityEngine.QualitySettings::get_shadowDistance");
			QualitySettings.set_shadowDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowDistanceDelegate>("UnityEngine.QualitySettings::set_shadowDistance");
			QualitySettings.get_shadowResolutionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowResolutionDelegate>("UnityEngine.QualitySettings::get_shadowResolution");
			QualitySettings.set_shadowResolutionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowResolutionDelegate>("UnityEngine.QualitySettings::set_shadowResolution");
			QualitySettings.get_shadowmaskModeDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowmaskModeDelegate>("UnityEngine.QualitySettings::get_shadowmaskMode");
			QualitySettings.set_shadowmaskModeDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowmaskModeDelegate>("UnityEngine.QualitySettings::set_shadowmaskMode");
			QualitySettings.get_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::get_shadowNearPlaneOffset");
			QualitySettings.set_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::set_shadowNearPlaneOffset");
			QualitySettings.get_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::get_shadowCascade2Split");
			QualitySettings.set_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::set_shadowCascade2Split");
			QualitySettings.get_lodBiasDelegateField = IL2CPP.ResolveICall<QualitySettings.get_lodBiasDelegate>("UnityEngine.QualitySettings::get_lodBias");
			QualitySettings.set_lodBiasDelegateField = IL2CPP.ResolveICall<QualitySettings.set_lodBiasDelegate>("UnityEngine.QualitySettings::set_lodBias");
			QualitySettings.get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<QualitySettings.get_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::get_anisotropicFiltering");
			QualitySettings.set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<QualitySettings.set_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::set_anisotropicFiltering");
			QualitySettings.get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_masterTextureLimitDelegate>("UnityEngine.QualitySettings::get_masterTextureLimit");
			QualitySettings.set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_masterTextureLimitDelegate>("UnityEngine.QualitySettings::set_masterTextureLimit");
			QualitySettings.get_maximumLODLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.get_maximumLODLevelDelegate>("UnityEngine.QualitySettings::get_maximumLODLevel");
			QualitySettings.set_maximumLODLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.set_maximumLODLevelDelegate>("UnityEngine.QualitySettings::set_maximumLODLevel");
			QualitySettings.get_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::get_particleRaycastBudget");
			QualitySettings.set_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::set_particleRaycastBudget");
			QualitySettings.get_softParticlesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_softParticlesDelegate>("UnityEngine.QualitySettings::get_softParticles");
			QualitySettings.set_softParticlesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_softParticlesDelegate>("UnityEngine.QualitySettings::set_softParticles");
			QualitySettings.get_softVegetationDelegateField = IL2CPP.ResolveICall<QualitySettings.get_softVegetationDelegate>("UnityEngine.QualitySettings::get_softVegetation");
			QualitySettings.set_softVegetationDelegateField = IL2CPP.ResolveICall<QualitySettings.set_softVegetationDelegate>("UnityEngine.QualitySettings::set_softVegetation");
			QualitySettings.get_vSyncCountDelegateField = IL2CPP.ResolveICall<QualitySettings.get_vSyncCountDelegate>("UnityEngine.QualitySettings::get_vSyncCount");
			QualitySettings.get_antiAliasingDelegateField = IL2CPP.ResolveICall<QualitySettings.get_antiAliasingDelegate>("UnityEngine.QualitySettings::get_antiAliasing");
			QualitySettings.get_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::get_asyncUploadTimeSlice");
			QualitySettings.set_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::set_asyncUploadTimeSlice");
			QualitySettings.get_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::get_asyncUploadBufferSize");
			QualitySettings.set_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::set_asyncUploadBufferSize");
			QualitySettings.get_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::get_asyncUploadPersistentBuffer");
			QualitySettings.set_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::set_asyncUploadPersistentBuffer");
			QualitySettings.get_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::get_realtimeReflectionProbes");
			QualitySettings.set_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::set_realtimeReflectionProbes");
			QualitySettings.get_billboardsFaceCameraPositionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_billboardsFaceCameraPositionDelegate>("UnityEngine.QualitySettings::get_billboardsFaceCameraPosition");
			QualitySettings.set_billboardsFaceCameraPositionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_billboardsFaceCameraPositionDelegate>("UnityEngine.QualitySettings::set_billboardsFaceCameraPosition");
			QualitySettings.get_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<QualitySettings.get_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::get_resolutionScalingFixedDPIFactor");
			QualitySettings.set_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<QualitySettings.set_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::set_resolutionScalingFixedDPIFactor");
			QualitySettings.get_INTERNAL_renderPipelineDelegateField = IL2CPP.ResolveICall<QualitySettings.get_INTERNAL_renderPipelineDelegate>("UnityEngine.QualitySettings::get_INTERNAL_renderPipeline");
			QualitySettings.set_INTERNAL_renderPipelineDelegateField = IL2CPP.ResolveICall<QualitySettings.set_INTERNAL_renderPipelineDelegate>("UnityEngine.QualitySettings::set_INTERNAL_renderPipeline");
			QualitySettings.InternalGetRenderPipelineAssetAtDelegateField = IL2CPP.ResolveICall<QualitySettings.InternalGetRenderPipelineAssetAtDelegate>("UnityEngine.QualitySettings::InternalGetRenderPipelineAssetAt");
			QualitySettings.get_blendWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_blendWeightsDelegate>("UnityEngine.QualitySettings::get_blendWeights");
			QualitySettings.set_blendWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_blendWeightsDelegate>("UnityEngine.QualitySettings::set_blendWeights");
			QualitySettings.get_skinWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_skinWeightsDelegate>("UnityEngine.QualitySettings::get_skinWeights");
			QualitySettings.set_skinWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_skinWeightsDelegate>("UnityEngine.QualitySettings::set_skinWeights");
			QualitySettings.get_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsActive");
			QualitySettings.set_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsActive");
			QualitySettings.get_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMemoryBudget");
			QualitySettings.set_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMemoryBudget");
			QualitySettings.get_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsRenderersPerFrame");
			QualitySettings.set_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsRenderersPerFrame");
			QualitySettings.get_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxLevelReduction");
			QualitySettings.set_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxLevelReduction");
			QualitySettings.get_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsAddAllCameras");
			QualitySettings.set_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsAddAllCameras");
			QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxFileIORequests");
			QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxFileIORequests");
			QualitySettings.get_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::get_maxQueuedFrames");
			QualitySettings.set_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::set_maxQueuedFrames");
			QualitySettings.GetQualityLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.GetQualityLevelDelegate>("UnityEngine.QualitySettings::GetQualityLevel");
			QualitySettings.SetQualityLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.SetQualityLevelDelegate>("UnityEngine.QualitySettings::SetQualityLevel");
			QualitySettings.get_namesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_namesDelegate>("UnityEngine.QualitySettings::get_names");
			QualitySettings.get_desiredColorSpaceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_desiredColorSpaceDelegate>("UnityEngine.QualitySettings::get_desiredColorSpace");
			QualitySettings.get_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::get_shadowCascade4Split_Injected");
			QualitySettings.set_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::set_shadowCascade4Split_Injected");
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00005C16 File Offset: 0x00003E16
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00027C30 File Offset: 0x00025E30
		public unsafe static int vSyncCount
		{
			get
			{
				return QualitySettings.get_vSyncCountDelegateField();
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488147, XrefRangeEnd = 488151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00005C22 File Offset: 0x00003E22
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00027C64 File Offset: 0x00025E64
		public unsafe static int antiAliasing
		{
			get
			{
				return QualitySettings.get_antiAliasingDelegateField();
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488151, XrefRangeEnd = 488155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00027C98 File Offset: 0x00025E98
		public unsafe static ColorSpace activeColorSpace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 488159, RefRangeEnd = 488160, XrefRangeStart = 488155, XrefRangeEnd = 488159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00005A28 File Offset: 0x00003C28
		public QualitySettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00005A31 File Offset: 0x00003C31
		public static void IncreaseLevel(bool applyExpensiveChanges)
		{
			QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() + 1, applyExpensiveChanges);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00005A42 File Offset: 0x00003C42
		public static void DecreaseLevel(bool applyExpensiveChanges)
		{
			QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() - 1, applyExpensiveChanges);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00005A53 File Offset: 0x00003C53
		public static void SetQualityLevel(int index)
		{
			QualitySettings.SetQualityLevel(index, true);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00005A5E File Offset: 0x00003C5E
		public static void IncreaseLevel()
		{
			QualitySettings.IncreaseLevel(false);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00005A68 File Offset: 0x00003C68
		public static void DecreaseLevel()
		{
			QualitySettings.DecreaseLevel(false);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00027CC8 File Offset: 0x00025EC8
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00005A72 File Offset: 0x00003C72
		public static QualityLevel currentLevel
		{
			get
			{
				return (QualityLevel)QualitySettings.GetQualityLevel();
			}
			set
			{
				QualitySettings.SetQualityLevel((int)value, true);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00005A7D File Offset: 0x00003C7D
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00005A89 File Offset: 0x00003C89
		public static int pixelLightCount
		{
			get
			{
				return QualitySettings.get_pixelLightCountDelegateField();
			}
			set
			{
				QualitySettings.set_pixelLightCountDelegateField(value);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00005A96 File Offset: 0x00003C96
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00005AA2 File Offset: 0x00003CA2
		public static ShadowQuality shadows
		{
			get
			{
				return QualitySettings.get_shadowsDelegateField();
			}
			set
			{
				QualitySettings.set_shadowsDelegateField(value);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00005AAF File Offset: 0x00003CAF
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00005ABB File Offset: 0x00003CBB
		public static ShadowProjection shadowProjection
		{
			get
			{
				return QualitySettings.get_shadowProjectionDelegateField();
			}
			set
			{
				QualitySettings.set_shadowProjectionDelegateField(value);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00005AC8 File Offset: 0x00003CC8
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00005AD4 File Offset: 0x00003CD4
		public static int shadowCascades
		{
			get
			{
				return QualitySettings.get_shadowCascadesDelegateField();
			}
			set
			{
				QualitySettings.set_shadowCascadesDelegateField(value);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00005AE1 File Offset: 0x00003CE1
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00005AED File Offset: 0x00003CED
		public static float shadowDistance
		{
			get
			{
				return QualitySettings.get_shadowDistanceDelegateField();
			}
			set
			{
				QualitySettings.set_shadowDistanceDelegateField(value);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00005AFA File Offset: 0x00003CFA
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00005B06 File Offset: 0x00003D06
		public static ShadowResolution shadowResolution
		{
			get
			{
				return QualitySettings.get_shadowResolutionDelegateField();
			}
			set
			{
				QualitySettings.set_shadowResolutionDelegateField(value);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00005B13 File Offset: 0x00003D13
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00005B1F File Offset: 0x00003D1F
		public static ShadowmaskMode shadowmaskMode
		{
			get
			{
				return QualitySettings.get_shadowmaskModeDelegateField();
			}
			set
			{
				QualitySettings.set_shadowmaskModeDelegateField(value);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00005B2C File Offset: 0x00003D2C
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00005B38 File Offset: 0x00003D38
		public static float shadowNearPlaneOffset
		{
			get
			{
				return QualitySettings.get_shadowNearPlaneOffsetDelegateField();
			}
			set
			{
				QualitySettings.set_shadowNearPlaneOffsetDelegateField(value);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00005B45 File Offset: 0x00003D45
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00005B51 File Offset: 0x00003D51
		public static float shadowCascade2Split
		{
			get
			{
				return QualitySettings.get_shadowCascade2SplitDelegateField();
			}
			set
			{
				QualitySettings.set_shadowCascade2SplitDelegateField(value);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00027CE0 File Offset: 0x00025EE0
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00005B5E File Offset: 0x00003D5E
		public static Vector3 shadowCascade4Split
		{
			get
			{
				Vector3 vector;
				QualitySettings.get_shadowCascade4Split_Injected(out vector);
				return vector;
			}
			set
			{
				QualitySettings.set_shadowCascade4Split_Injected(ref value);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00005B67 File Offset: 0x00003D67
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00005B73 File Offset: 0x00003D73
		public static float lodBias
		{
			get
			{
				return QualitySettings.get_lodBiasDelegateField();
			}
			set
			{
				QualitySettings.set_lodBiasDelegateField(value);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00005B80 File Offset: 0x00003D80
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00005B8C File Offset: 0x00003D8C
		public static AnisotropicFiltering anisotropicFiltering
		{
			get
			{
				return QualitySettings.get_anisotropicFilteringDelegateField();
			}
			set
			{
				QualitySettings.set_anisotropicFilteringDelegateField(value);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00005B99 File Offset: 0x00003D99
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x00005BA5 File Offset: 0x00003DA5
		public static int masterTextureLimit
		{
			get
			{
				return QualitySettings.get_masterTextureLimitDelegateField();
			}
			set
			{
				QualitySettings.set_masterTextureLimitDelegateField(value);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00005BB2 File Offset: 0x00003DB2
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00005BBE File Offset: 0x00003DBE
		public static int maximumLODLevel
		{
			get
			{
				return QualitySettings.get_maximumLODLevelDelegateField();
			}
			set
			{
				QualitySettings.set_maximumLODLevelDelegateField(value);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00005BCB File Offset: 0x00003DCB
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00005BD7 File Offset: 0x00003DD7
		public static int particleRaycastBudget
		{
			get
			{
				return QualitySettings.get_particleRaycastBudgetDelegateField();
			}
			set
			{
				QualitySettings.set_particleRaycastBudgetDelegateField(value);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00005BE4 File Offset: 0x00003DE4
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00005BF0 File Offset: 0x00003DF0
		public static bool softParticles
		{
			get
			{
				return QualitySettings.get_softParticlesDelegateField();
			}
			set
			{
				QualitySettings.set_softParticlesDelegateField(value);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00005BFD File Offset: 0x00003DFD
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00005C09 File Offset: 0x00003E09
		public static bool softVegetation
		{
			get
			{
				return QualitySettings.get_softVegetationDelegateField();
			}
			set
			{
				QualitySettings.set_softVegetationDelegateField(value);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00005C2E File Offset: 0x00003E2E
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00005C3A File Offset: 0x00003E3A
		public static int asyncUploadTimeSlice
		{
			get
			{
				return QualitySettings.get_asyncUploadTimeSliceDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadTimeSliceDelegateField(value);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00005C47 File Offset: 0x00003E47
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00005C53 File Offset: 0x00003E53
		public static int asyncUploadBufferSize
		{
			get
			{
				return QualitySettings.get_asyncUploadBufferSizeDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadBufferSizeDelegateField(value);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00005C60 File Offset: 0x00003E60
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00005C6C File Offset: 0x00003E6C
		public static bool asyncUploadPersistentBuffer
		{
			get
			{
				return QualitySettings.get_asyncUploadPersistentBufferDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadPersistentBufferDelegateField(value);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00005C79 File Offset: 0x00003E79
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00005C85 File Offset: 0x00003E85
		public static bool realtimeReflectionProbes
		{
			get
			{
				return QualitySettings.get_realtimeReflectionProbesDelegateField();
			}
			set
			{
				QualitySettings.set_realtimeReflectionProbesDelegateField(value);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00005C92 File Offset: 0x00003E92
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00005C9E File Offset: 0x00003E9E
		public static bool billboardsFaceCameraPosition
		{
			get
			{
				return QualitySettings.get_billboardsFaceCameraPositionDelegateField();
			}
			set
			{
				QualitySettings.set_billboardsFaceCameraPositionDelegateField(value);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00005CAB File Offset: 0x00003EAB
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00005CB7 File Offset: 0x00003EB7
		public static float resolutionScalingFixedDPIFactor
		{
			get
			{
				return QualitySettings.get_resolutionScalingFixedDPIFactorDelegateField();
			}
			set
			{
				QualitySettings.set_resolutionScalingFixedDPIFactorDelegateField(value);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00027CF8 File Offset: 0x00025EF8
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00005CC4 File Offset: 0x00003EC4
		public static ScriptableObject INTERNAL_renderPipeline
		{
			get
			{
				IntPtr intPtr = QualitySettings.get_INTERNAL_renderPipelineDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
			set
			{
				QualitySettings.set_INTERNAL_renderPipelineDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00027D20 File Offset: 0x00025F20
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00005CD6 File Offset: 0x00003ED6
		public static UnityEngine.Rendering.RenderPipelineAsset renderPipeline
		{
			get
			{
				return QualitySettings.INTERNAL_renderPipeline.TryCast<UnityEngine.Rendering.RenderPipelineAsset>();
			}
			set
			{
				QualitySettings.INTERNAL_renderPipeline = value;
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00027D3C File Offset: 0x00025F3C
		public static ScriptableObject InternalGetRenderPipelineAssetAt(int index)
		{
			IntPtr intPtr = QualitySettings.InternalGetRenderPipelineAssetAtDelegateField(index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00027D64 File Offset: 0x00025F64
		public static UnityEngine.Rendering.RenderPipelineAsset GetRenderPipelineAssetAt(int index)
		{
			bool flag = index < 0 || index >= QualitySettings.names.Length;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Format("{0} is out of range [0..{1}[", "index", QualitySettings.names.Length));
			}
			return QualitySettings.InternalGetRenderPipelineAssetAt(index).TryCast<UnityEngine.Rendering.RenderPipelineAsset>();
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00005CE0 File Offset: 0x00003EE0
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00005CEC File Offset: 0x00003EEC
		public static BlendWeights blendWeights
		{
			get
			{
				return QualitySettings.get_blendWeightsDelegateField();
			}
			set
			{
				QualitySettings.set_blendWeightsDelegateField(value);
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00005CF9 File Offset: 0x00003EF9
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00005D05 File Offset: 0x00003F05
		public static SkinWeights skinWeights
		{
			get
			{
				return QualitySettings.get_skinWeightsDelegateField();
			}
			set
			{
				QualitySettings.set_skinWeightsDelegateField(value);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00005D12 File Offset: 0x00003F12
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00005D1E File Offset: 0x00003F1E
		public static bool streamingMipmapsActive
		{
			get
			{
				return QualitySettings.get_streamingMipmapsActiveDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsActiveDelegateField(value);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00005D2B File Offset: 0x00003F2B
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00005D37 File Offset: 0x00003F37
		public static float streamingMipmapsMemoryBudget
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMemoryBudgetDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMemoryBudgetDelegateField(value);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00005D44 File Offset: 0x00003F44
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00005D50 File Offset: 0x00003F50
		public static int streamingMipmapsRenderersPerFrame
		{
			get
			{
				return QualitySettings.get_streamingMipmapsRenderersPerFrameDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsRenderersPerFrameDelegateField(value);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00005D5D File Offset: 0x00003F5D
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00005D69 File Offset: 0x00003F69
		public static int streamingMipmapsMaxLevelReduction
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMaxLevelReductionDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMaxLevelReductionDelegateField(value);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00005D76 File Offset: 0x00003F76
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00005D82 File Offset: 0x00003F82
		public static bool streamingMipmapsAddAllCameras
		{
			get
			{
				return QualitySettings.get_streamingMipmapsAddAllCamerasDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsAddAllCamerasDelegateField(value);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00005D8F File Offset: 0x00003F8F
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00005D9B File Offset: 0x00003F9B
		public static int streamingMipmapsMaxFileIORequests
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegateField(value);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00005DA8 File Offset: 0x00003FA8
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00005DB4 File Offset: 0x00003FB4
		public static int maxQueuedFrames
		{
			get
			{
				return QualitySettings.get_maxQueuedFramesDelegateField();
			}
			set
			{
				QualitySettings.set_maxQueuedFramesDelegateField(value);
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00005DC1 File Offset: 0x00003FC1
		public static int GetQualityLevel()
		{
			return QualitySettings.GetQualityLevelDelegateField();
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00005DCD File Offset: 0x00003FCD
		public static void SetQualityLevel(int index, bool applyExpensiveChanges)
		{
			QualitySettings.SetQualityLevelDelegateField(index, applyExpensiveChanges);
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00027DC4 File Offset: 0x00025FC4
		public static Il2CppStringArray names
		{
			get
			{
				IntPtr intPtr = QualitySettings.get_namesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00005DDB File Offset: 0x00003FDB
		public static ColorSpace desiredColorSpace
		{
			get
			{
				return QualitySettings.get_desiredColorSpaceDelegateField();
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00005DE7 File Offset: 0x00003FE7
		public static void get_shadowCascade4Split_Injected(out Vector3 ret)
		{
			QualitySettings.get_shadowCascade4Split_InjectedDelegateField(out ret);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00005DF4 File Offset: 0x00003FF4
		public static void set_shadowCascade4Split_Injected(ref Vector3 value)
		{
			QualitySettings.set_shadowCascade4Split_InjectedDelegateField(ref value);
		}

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly QualitySettings.get_pixelLightCountDelegate get_pixelLightCountDelegateField;

		// Token: 0x040004F8 RID: 1272
		private static readonly QualitySettings.set_pixelLightCountDelegate set_pixelLightCountDelegateField;

		// Token: 0x040004F9 RID: 1273
		private static readonly QualitySettings.get_shadowsDelegate get_shadowsDelegateField;

		// Token: 0x040004FA RID: 1274
		private static readonly QualitySettings.set_shadowsDelegate set_shadowsDelegateField;

		// Token: 0x040004FB RID: 1275
		private static readonly QualitySettings.get_shadowProjectionDelegate get_shadowProjectionDelegateField;

		// Token: 0x040004FC RID: 1276
		private static readonly QualitySettings.set_shadowProjectionDelegate set_shadowProjectionDelegateField;

		// Token: 0x040004FD RID: 1277
		private static readonly QualitySettings.get_shadowCascadesDelegate get_shadowCascadesDelegateField;

		// Token: 0x040004FE RID: 1278
		private static readonly QualitySettings.set_shadowCascadesDelegate set_shadowCascadesDelegateField;

		// Token: 0x040004FF RID: 1279
		private static readonly QualitySettings.get_shadowDistanceDelegate get_shadowDistanceDelegateField;

		// Token: 0x04000500 RID: 1280
		private static readonly QualitySettings.set_shadowDistanceDelegate set_shadowDistanceDelegateField;

		// Token: 0x04000501 RID: 1281
		private static readonly QualitySettings.get_shadowResolutionDelegate get_shadowResolutionDelegateField;

		// Token: 0x04000502 RID: 1282
		private static readonly QualitySettings.set_shadowResolutionDelegate set_shadowResolutionDelegateField;

		// Token: 0x04000503 RID: 1283
		private static readonly QualitySettings.get_shadowmaskModeDelegate get_shadowmaskModeDelegateField;

		// Token: 0x04000504 RID: 1284
		private static readonly QualitySettings.set_shadowmaskModeDelegate set_shadowmaskModeDelegateField;

		// Token: 0x04000505 RID: 1285
		private static readonly QualitySettings.get_shadowNearPlaneOffsetDelegate get_shadowNearPlaneOffsetDelegateField;

		// Token: 0x04000506 RID: 1286
		private static readonly QualitySettings.set_shadowNearPlaneOffsetDelegate set_shadowNearPlaneOffsetDelegateField;

		// Token: 0x04000507 RID: 1287
		private static readonly QualitySettings.get_shadowCascade2SplitDelegate get_shadowCascade2SplitDelegateField;

		// Token: 0x04000508 RID: 1288
		private static readonly QualitySettings.set_shadowCascade2SplitDelegate set_shadowCascade2SplitDelegateField;

		// Token: 0x04000509 RID: 1289
		private static readonly QualitySettings.get_lodBiasDelegate get_lodBiasDelegateField;

		// Token: 0x0400050A RID: 1290
		private static readonly QualitySettings.set_lodBiasDelegate set_lodBiasDelegateField;

		// Token: 0x0400050B RID: 1291
		private static readonly QualitySettings.get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;

		// Token: 0x0400050C RID: 1292
		private static readonly QualitySettings.set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;

		// Token: 0x0400050D RID: 1293
		private static readonly QualitySettings.get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;

		// Token: 0x0400050E RID: 1294
		private static readonly QualitySettings.set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;

		// Token: 0x0400050F RID: 1295
		private static readonly QualitySettings.get_maximumLODLevelDelegate get_maximumLODLevelDelegateField;

		// Token: 0x04000510 RID: 1296
		private static readonly QualitySettings.set_maximumLODLevelDelegate set_maximumLODLevelDelegateField;

		// Token: 0x04000511 RID: 1297
		private static readonly QualitySettings.get_particleRaycastBudgetDelegate get_particleRaycastBudgetDelegateField;

		// Token: 0x04000512 RID: 1298
		private static readonly QualitySettings.set_particleRaycastBudgetDelegate set_particleRaycastBudgetDelegateField;

		// Token: 0x04000513 RID: 1299
		private static readonly QualitySettings.get_softParticlesDelegate get_softParticlesDelegateField;

		// Token: 0x04000514 RID: 1300
		private static readonly QualitySettings.set_softParticlesDelegate set_softParticlesDelegateField;

		// Token: 0x04000515 RID: 1301
		private static readonly QualitySettings.get_softVegetationDelegate get_softVegetationDelegateField;

		// Token: 0x04000516 RID: 1302
		private static readonly QualitySettings.set_softVegetationDelegate set_softVegetationDelegateField;

		// Token: 0x04000517 RID: 1303
		private static readonly QualitySettings.get_vSyncCountDelegate get_vSyncCountDelegateField;

		// Token: 0x04000518 RID: 1304
		private static readonly QualitySettings.get_antiAliasingDelegate get_antiAliasingDelegateField;

		// Token: 0x04000519 RID: 1305
		private static readonly QualitySettings.get_asyncUploadTimeSliceDelegate get_asyncUploadTimeSliceDelegateField;

		// Token: 0x0400051A RID: 1306
		private static readonly QualitySettings.set_asyncUploadTimeSliceDelegate set_asyncUploadTimeSliceDelegateField;

		// Token: 0x0400051B RID: 1307
		private static readonly QualitySettings.get_asyncUploadBufferSizeDelegate get_asyncUploadBufferSizeDelegateField;

		// Token: 0x0400051C RID: 1308
		private static readonly QualitySettings.set_asyncUploadBufferSizeDelegate set_asyncUploadBufferSizeDelegateField;

		// Token: 0x0400051D RID: 1309
		private static readonly QualitySettings.get_asyncUploadPersistentBufferDelegate get_asyncUploadPersistentBufferDelegateField;

		// Token: 0x0400051E RID: 1310
		private static readonly QualitySettings.set_asyncUploadPersistentBufferDelegate set_asyncUploadPersistentBufferDelegateField;

		// Token: 0x0400051F RID: 1311
		private static readonly QualitySettings.get_realtimeReflectionProbesDelegate get_realtimeReflectionProbesDelegateField;

		// Token: 0x04000520 RID: 1312
		private static readonly QualitySettings.set_realtimeReflectionProbesDelegate set_realtimeReflectionProbesDelegateField;

		// Token: 0x04000521 RID: 1313
		private static readonly QualitySettings.get_billboardsFaceCameraPositionDelegate get_billboardsFaceCameraPositionDelegateField;

		// Token: 0x04000522 RID: 1314
		private static readonly QualitySettings.set_billboardsFaceCameraPositionDelegate set_billboardsFaceCameraPositionDelegateField;

		// Token: 0x04000523 RID: 1315
		private static readonly QualitySettings.get_resolutionScalingFixedDPIFactorDelegate get_resolutionScalingFixedDPIFactorDelegateField;

		// Token: 0x04000524 RID: 1316
		private static readonly QualitySettings.set_resolutionScalingFixedDPIFactorDelegate set_resolutionScalingFixedDPIFactorDelegateField;

		// Token: 0x04000525 RID: 1317
		private static readonly QualitySettings.get_INTERNAL_renderPipelineDelegate get_INTERNAL_renderPipelineDelegateField;

		// Token: 0x04000526 RID: 1318
		private static readonly QualitySettings.set_INTERNAL_renderPipelineDelegate set_INTERNAL_renderPipelineDelegateField;

		// Token: 0x04000527 RID: 1319
		private static readonly QualitySettings.InternalGetRenderPipelineAssetAtDelegate InternalGetRenderPipelineAssetAtDelegateField;

		// Token: 0x04000528 RID: 1320
		private static readonly QualitySettings.get_blendWeightsDelegate get_blendWeightsDelegateField;

		// Token: 0x04000529 RID: 1321
		private static readonly QualitySettings.set_blendWeightsDelegate set_blendWeightsDelegateField;

		// Token: 0x0400052A RID: 1322
		private static readonly QualitySettings.get_skinWeightsDelegate get_skinWeightsDelegateField;

		// Token: 0x0400052B RID: 1323
		private static readonly QualitySettings.set_skinWeightsDelegate set_skinWeightsDelegateField;

		// Token: 0x0400052C RID: 1324
		private static readonly QualitySettings.get_streamingMipmapsActiveDelegate get_streamingMipmapsActiveDelegateField;

		// Token: 0x0400052D RID: 1325
		private static readonly QualitySettings.set_streamingMipmapsActiveDelegate set_streamingMipmapsActiveDelegateField;

		// Token: 0x0400052E RID: 1326
		private static readonly QualitySettings.get_streamingMipmapsMemoryBudgetDelegate get_streamingMipmapsMemoryBudgetDelegateField;

		// Token: 0x0400052F RID: 1327
		private static readonly QualitySettings.set_streamingMipmapsMemoryBudgetDelegate set_streamingMipmapsMemoryBudgetDelegateField;

		// Token: 0x04000530 RID: 1328
		private static readonly QualitySettings.get_streamingMipmapsRenderersPerFrameDelegate get_streamingMipmapsRenderersPerFrameDelegateField;

		// Token: 0x04000531 RID: 1329
		private static readonly QualitySettings.set_streamingMipmapsRenderersPerFrameDelegate set_streamingMipmapsRenderersPerFrameDelegateField;

		// Token: 0x04000532 RID: 1330
		private static readonly QualitySettings.get_streamingMipmapsMaxLevelReductionDelegate get_streamingMipmapsMaxLevelReductionDelegateField;

		// Token: 0x04000533 RID: 1331
		private static readonly QualitySettings.set_streamingMipmapsMaxLevelReductionDelegate set_streamingMipmapsMaxLevelReductionDelegateField;

		// Token: 0x04000534 RID: 1332
		private static readonly QualitySettings.get_streamingMipmapsAddAllCamerasDelegate get_streamingMipmapsAddAllCamerasDelegateField;

		// Token: 0x04000535 RID: 1333
		private static readonly QualitySettings.set_streamingMipmapsAddAllCamerasDelegate set_streamingMipmapsAddAllCamerasDelegateField;

		// Token: 0x04000536 RID: 1334
		private static readonly QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegate get_streamingMipmapsMaxFileIORequestsDelegateField;

		// Token: 0x04000537 RID: 1335
		private static readonly QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegate set_streamingMipmapsMaxFileIORequestsDelegateField;

		// Token: 0x04000538 RID: 1336
		private static readonly QualitySettings.get_maxQueuedFramesDelegate get_maxQueuedFramesDelegateField;

		// Token: 0x04000539 RID: 1337
		private static readonly QualitySettings.set_maxQueuedFramesDelegate set_maxQueuedFramesDelegateField;

		// Token: 0x0400053A RID: 1338
		private static readonly QualitySettings.GetQualityLevelDelegate GetQualityLevelDelegateField;

		// Token: 0x0400053B RID: 1339
		private static readonly QualitySettings.SetQualityLevelDelegate SetQualityLevelDelegateField;

		// Token: 0x0400053C RID: 1340
		private static readonly QualitySettings.get_namesDelegate get_namesDelegateField;

		// Token: 0x0400053D RID: 1341
		private static readonly QualitySettings.get_desiredColorSpaceDelegate get_desiredColorSpaceDelegateField;

		// Token: 0x0400053E RID: 1342
		private static readonly QualitySettings.get_shadowCascade4Split_InjectedDelegate get_shadowCascade4Split_InjectedDelegateField;

		// Token: 0x0400053F RID: 1343
		private static readonly QualitySettings.set_shadowCascade4Split_InjectedDelegate set_shadowCascade4Split_InjectedDelegateField;

		// Token: 0x0200049E RID: 1182
		// (Invoke) Token: 0x06002772 RID: 10098
		private delegate int get_pixelLightCountDelegate();

		// Token: 0x0200049F RID: 1183
		// (Invoke) Token: 0x06002774 RID: 10100
		private delegate void set_pixelLightCountDelegate(int value);

		// Token: 0x020004A0 RID: 1184
		// (Invoke) Token: 0x06002776 RID: 10102
		private delegate ShadowQuality get_shadowsDelegate();

		// Token: 0x020004A1 RID: 1185
		// (Invoke) Token: 0x06002778 RID: 10104
		private delegate void set_shadowsDelegate(ShadowQuality value);

		// Token: 0x020004A2 RID: 1186
		// (Invoke) Token: 0x0600277A RID: 10106
		private delegate ShadowProjection get_shadowProjectionDelegate();

		// Token: 0x020004A3 RID: 1187
		// (Invoke) Token: 0x0600277C RID: 10108
		private delegate void set_shadowProjectionDelegate(ShadowProjection value);

		// Token: 0x020004A4 RID: 1188
		// (Invoke) Token: 0x0600277E RID: 10110
		private delegate int get_shadowCascadesDelegate();

		// Token: 0x020004A5 RID: 1189
		// (Invoke) Token: 0x06002780 RID: 10112
		private delegate void set_shadowCascadesDelegate(int value);

		// Token: 0x020004A6 RID: 1190
		// (Invoke) Token: 0x06002782 RID: 10114
		private delegate float get_shadowDistanceDelegate();

		// Token: 0x020004A7 RID: 1191
		// (Invoke) Token: 0x06002784 RID: 10116
		private delegate void set_shadowDistanceDelegate(float value);

		// Token: 0x020004A8 RID: 1192
		// (Invoke) Token: 0x06002786 RID: 10118
		private delegate ShadowResolution get_shadowResolutionDelegate();

		// Token: 0x020004A9 RID: 1193
		// (Invoke) Token: 0x06002788 RID: 10120
		private delegate void set_shadowResolutionDelegate(ShadowResolution value);

		// Token: 0x020004AA RID: 1194
		// (Invoke) Token: 0x0600278A RID: 10122
		private delegate ShadowmaskMode get_shadowmaskModeDelegate();

		// Token: 0x020004AB RID: 1195
		// (Invoke) Token: 0x0600278C RID: 10124
		private delegate void set_shadowmaskModeDelegate(ShadowmaskMode value);

		// Token: 0x020004AC RID: 1196
		// (Invoke) Token: 0x0600278E RID: 10126
		private delegate float get_shadowNearPlaneOffsetDelegate();

		// Token: 0x020004AD RID: 1197
		// (Invoke) Token: 0x06002790 RID: 10128
		private delegate void set_shadowNearPlaneOffsetDelegate(float value);

		// Token: 0x020004AE RID: 1198
		// (Invoke) Token: 0x06002792 RID: 10130
		private delegate float get_shadowCascade2SplitDelegate();

		// Token: 0x020004AF RID: 1199
		// (Invoke) Token: 0x06002794 RID: 10132
		private delegate void set_shadowCascade2SplitDelegate(float value);

		// Token: 0x020004B0 RID: 1200
		// (Invoke) Token: 0x06002796 RID: 10134
		private delegate float get_lodBiasDelegate();

		// Token: 0x020004B1 RID: 1201
		// (Invoke) Token: 0x06002798 RID: 10136
		private delegate void set_lodBiasDelegate(float value);

		// Token: 0x020004B2 RID: 1202
		// (Invoke) Token: 0x0600279A RID: 10138
		private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

		// Token: 0x020004B3 RID: 1203
		// (Invoke) Token: 0x0600279C RID: 10140
		private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

		// Token: 0x020004B4 RID: 1204
		// (Invoke) Token: 0x0600279E RID: 10142
		private delegate int get_masterTextureLimitDelegate();

		// Token: 0x020004B5 RID: 1205
		// (Invoke) Token: 0x060027A0 RID: 10144
		private delegate void set_masterTextureLimitDelegate(int value);

		// Token: 0x020004B6 RID: 1206
		// (Invoke) Token: 0x060027A2 RID: 10146
		private delegate int get_maximumLODLevelDelegate();

		// Token: 0x020004B7 RID: 1207
		// (Invoke) Token: 0x060027A4 RID: 10148
		private delegate void set_maximumLODLevelDelegate(int value);

		// Token: 0x020004B8 RID: 1208
		// (Invoke) Token: 0x060027A6 RID: 10150
		private delegate int get_particleRaycastBudgetDelegate();

		// Token: 0x020004B9 RID: 1209
		// (Invoke) Token: 0x060027A8 RID: 10152
		private delegate void set_particleRaycastBudgetDelegate(int value);

		// Token: 0x020004BA RID: 1210
		// (Invoke) Token: 0x060027AA RID: 10154
		private delegate bool get_softParticlesDelegate();

		// Token: 0x020004BB RID: 1211
		// (Invoke) Token: 0x060027AC RID: 10156
		private delegate void set_softParticlesDelegate(bool value);

		// Token: 0x020004BC RID: 1212
		// (Invoke) Token: 0x060027AE RID: 10158
		private delegate bool get_softVegetationDelegate();

		// Token: 0x020004BD RID: 1213
		// (Invoke) Token: 0x060027B0 RID: 10160
		private delegate void set_softVegetationDelegate(bool value);

		// Token: 0x020004BE RID: 1214
		// (Invoke) Token: 0x060027B2 RID: 10162
		private delegate int get_vSyncCountDelegate();

		// Token: 0x020004BF RID: 1215
		// (Invoke) Token: 0x060027B4 RID: 10164
		private delegate int get_antiAliasingDelegate();

		// Token: 0x020004C0 RID: 1216
		// (Invoke) Token: 0x060027B6 RID: 10166
		private delegate int get_asyncUploadTimeSliceDelegate();

		// Token: 0x020004C1 RID: 1217
		// (Invoke) Token: 0x060027B8 RID: 10168
		private delegate void set_asyncUploadTimeSliceDelegate(int value);

		// Token: 0x020004C2 RID: 1218
		// (Invoke) Token: 0x060027BA RID: 10170
		private delegate int get_asyncUploadBufferSizeDelegate();

		// Token: 0x020004C3 RID: 1219
		// (Invoke) Token: 0x060027BC RID: 10172
		private delegate void set_asyncUploadBufferSizeDelegate(int value);

		// Token: 0x020004C4 RID: 1220
		// (Invoke) Token: 0x060027BE RID: 10174
		private delegate bool get_asyncUploadPersistentBufferDelegate();

		// Token: 0x020004C5 RID: 1221
		// (Invoke) Token: 0x060027C0 RID: 10176
		private delegate void set_asyncUploadPersistentBufferDelegate(bool value);

		// Token: 0x020004C6 RID: 1222
		// (Invoke) Token: 0x060027C2 RID: 10178
		private delegate bool get_realtimeReflectionProbesDelegate();

		// Token: 0x020004C7 RID: 1223
		// (Invoke) Token: 0x060027C4 RID: 10180
		private delegate void set_realtimeReflectionProbesDelegate(bool value);

		// Token: 0x020004C8 RID: 1224
		// (Invoke) Token: 0x060027C6 RID: 10182
		private delegate bool get_billboardsFaceCameraPositionDelegate();

		// Token: 0x020004C9 RID: 1225
		// (Invoke) Token: 0x060027C8 RID: 10184
		private delegate void set_billboardsFaceCameraPositionDelegate(bool value);

		// Token: 0x020004CA RID: 1226
		// (Invoke) Token: 0x060027CA RID: 10186
		private delegate float get_resolutionScalingFixedDPIFactorDelegate();

		// Token: 0x020004CB RID: 1227
		// (Invoke) Token: 0x060027CC RID: 10188
		private delegate void set_resolutionScalingFixedDPIFactorDelegate(float value);

		// Token: 0x020004CC RID: 1228
		// (Invoke) Token: 0x060027CE RID: 10190
		private delegate IntPtr get_INTERNAL_renderPipelineDelegate();

		// Token: 0x020004CD RID: 1229
		// (Invoke) Token: 0x060027D0 RID: 10192
		private delegate void set_INTERNAL_renderPipelineDelegate(IntPtr value);

		// Token: 0x020004CE RID: 1230
		// (Invoke) Token: 0x060027D2 RID: 10194
		private delegate IntPtr InternalGetRenderPipelineAssetAtDelegate(int index);

		// Token: 0x020004CF RID: 1231
		// (Invoke) Token: 0x060027D4 RID: 10196
		private delegate BlendWeights get_blendWeightsDelegate();

		// Token: 0x020004D0 RID: 1232
		// (Invoke) Token: 0x060027D6 RID: 10198
		private delegate void set_blendWeightsDelegate(BlendWeights value);

		// Token: 0x020004D1 RID: 1233
		// (Invoke) Token: 0x060027D8 RID: 10200
		private delegate SkinWeights get_skinWeightsDelegate();

		// Token: 0x020004D2 RID: 1234
		// (Invoke) Token: 0x060027DA RID: 10202
		private delegate void set_skinWeightsDelegate(SkinWeights value);

		// Token: 0x020004D3 RID: 1235
		// (Invoke) Token: 0x060027DC RID: 10204
		private delegate bool get_streamingMipmapsActiveDelegate();

		// Token: 0x020004D4 RID: 1236
		// (Invoke) Token: 0x060027DE RID: 10206
		private delegate void set_streamingMipmapsActiveDelegate(bool value);

		// Token: 0x020004D5 RID: 1237
		// (Invoke) Token: 0x060027E0 RID: 10208
		private delegate float get_streamingMipmapsMemoryBudgetDelegate();

		// Token: 0x020004D6 RID: 1238
		// (Invoke) Token: 0x060027E2 RID: 10210
		private delegate void set_streamingMipmapsMemoryBudgetDelegate(float value);

		// Token: 0x020004D7 RID: 1239
		// (Invoke) Token: 0x060027E4 RID: 10212
		private delegate int get_streamingMipmapsRenderersPerFrameDelegate();

		// Token: 0x020004D8 RID: 1240
		// (Invoke) Token: 0x060027E6 RID: 10214
		private delegate void set_streamingMipmapsRenderersPerFrameDelegate(int value);

		// Token: 0x020004D9 RID: 1241
		// (Invoke) Token: 0x060027E8 RID: 10216
		private delegate int get_streamingMipmapsMaxLevelReductionDelegate();

		// Token: 0x020004DA RID: 1242
		// (Invoke) Token: 0x060027EA RID: 10218
		private delegate void set_streamingMipmapsMaxLevelReductionDelegate(int value);

		// Token: 0x020004DB RID: 1243
		// (Invoke) Token: 0x060027EC RID: 10220
		private delegate bool get_streamingMipmapsAddAllCamerasDelegate();

		// Token: 0x020004DC RID: 1244
		// (Invoke) Token: 0x060027EE RID: 10222
		private delegate void set_streamingMipmapsAddAllCamerasDelegate(bool value);

		// Token: 0x020004DD RID: 1245
		// (Invoke) Token: 0x060027F0 RID: 10224
		private delegate int get_streamingMipmapsMaxFileIORequestsDelegate();

		// Token: 0x020004DE RID: 1246
		// (Invoke) Token: 0x060027F2 RID: 10226
		private delegate void set_streamingMipmapsMaxFileIORequestsDelegate(int value);

		// Token: 0x020004DF RID: 1247
		// (Invoke) Token: 0x060027F4 RID: 10228
		private delegate int get_maxQueuedFramesDelegate();

		// Token: 0x020004E0 RID: 1248
		// (Invoke) Token: 0x060027F6 RID: 10230
		private delegate void set_maxQueuedFramesDelegate(int value);

		// Token: 0x020004E1 RID: 1249
		// (Invoke) Token: 0x060027F8 RID: 10232
		private delegate int GetQualityLevelDelegate();

		// Token: 0x020004E2 RID: 1250
		// (Invoke) Token: 0x060027FA RID: 10234
		private delegate void SetQualityLevelDelegate(int index, bool applyExpensiveChanges);

		// Token: 0x020004E3 RID: 1251
		// (Invoke) Token: 0x060027FC RID: 10236
		private delegate IntPtr get_namesDelegate();

		// Token: 0x020004E4 RID: 1252
		// (Invoke) Token: 0x060027FE RID: 10238
		private delegate ColorSpace get_desiredColorSpaceDelegate();

		// Token: 0x020004E5 RID: 1253
		// (Invoke) Token: 0x06002800 RID: 10240
		private delegate void get_shadowCascade4Split_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020004E6 RID: 1254
		// (Invoke) Token: 0x06002802 RID: 10242
		private delegate void set_shadowCascade4Split_InjectedDelegate(IntPtr value);
	}
}
