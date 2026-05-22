using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000054 RID: 84
	public sealed class PostProcessLayer : MonoBehaviour
	{
		// Token: 0x06000372 RID: 882 RVA: 0x00010AE4 File Offset: 0x0000ECE4
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessLayer()
		{
			Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr);
			PostProcessLayer.NativeFieldInfoPtr_volumeTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "volumeTrigger");
			PostProcessLayer.NativeFieldInfoPtr_volumeLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "volumeLayer");
			PostProcessLayer.NativeFieldInfoPtr_stopNaNPropagation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "stopNaNPropagation");
			PostProcessLayer.NativeFieldInfoPtr_finalBlitToCameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "finalBlitToCameraTarget");
			PostProcessLayer.NativeFieldInfoPtr_antialiasingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "antialiasingMode");
			PostProcessLayer.NativeFieldInfoPtr_temporalAntialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "temporalAntialiasing");
			PostProcessLayer.NativeFieldInfoPtr_subpixelMorphologicalAntialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "subpixelMorphologicalAntialiasing");
			PostProcessLayer.NativeFieldInfoPtr_fastApproximateAntialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "fastApproximateAntialiasing");
			PostProcessLayer.NativeFieldInfoPtr_fog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "fog");
			PostProcessLayer.NativeFieldInfoPtr_dithering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "dithering");
			PostProcessLayer.NativeFieldInfoPtr_debugLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "debugLayer");
			PostProcessLayer.NativeFieldInfoPtr_m_Resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_Resources");
			PostProcessLayer.NativeFieldInfoPtr_m_OldResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_OldResources");
			PostProcessLayer.NativeFieldInfoPtr_m_ShowToolkit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_ShowToolkit");
			PostProcessLayer.NativeFieldInfoPtr_m_ShowCustomSorter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_ShowCustomSorter");
			PostProcessLayer.NativeFieldInfoPtr_breakBeforeColorGrading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "breakBeforeColorGrading");
			PostProcessLayer.NativeFieldInfoPtr_m_BeforeTransparentBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_BeforeTransparentBundles");
			PostProcessLayer.NativeFieldInfoPtr_m_BeforeStackBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_BeforeStackBundles");
			PostProcessLayer.NativeFieldInfoPtr_m_AfterStackBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_AfterStackBundles");
			PostProcessLayer.NativeFieldInfoPtr__sortedBundles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "<sortedBundles>k__BackingField");
			PostProcessLayer.NativeFieldInfoPtr__cameraDepthFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "<cameraDepthFlags>k__BackingField");
			PostProcessLayer.NativeFieldInfoPtr__haveBundlesBeenInited_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "<haveBundlesBeenInited>k__BackingField");
			PostProcessLayer.NativeFieldInfoPtr_m_Bundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_Bundles");
			PostProcessLayer.NativeFieldInfoPtr_m_PropertySheetFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_PropertySheetFactory");
			PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBufferBeforeReflections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_LegacyCmdBufferBeforeReflections");
			PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBufferBeforeLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_LegacyCmdBufferBeforeLighting");
			PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBufferOpaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_LegacyCmdBufferOpaque");
			PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_LegacyCmdBuffer");
			PostProcessLayer.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_Camera");
			PostProcessLayer.NativeFieldInfoPtr_m_CurrentContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_CurrentContext");
			PostProcessLayer.NativeFieldInfoPtr_m_LogHistogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_LogHistogram");
			PostProcessLayer.NativeFieldInfoPtr_m_SettingsUpdateNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_SettingsUpdateNeeded");
			PostProcessLayer.NativeFieldInfoPtr_m_IsRenderingInSceneView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_IsRenderingInSceneView");
			PostProcessLayer.NativeFieldInfoPtr_m_TargetPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_TargetPool");
			PostProcessLayer.NativeFieldInfoPtr_m_NaNKilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_NaNKilled");
			PostProcessLayer.NativeFieldInfoPtr_m_ActiveEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_ActiveEffects");
			PostProcessLayer.NativeFieldInfoPtr_m_Targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "m_Targets");
			PostProcessLayer.NativeMethodInfoPtr_get_sortedBundles_Public_get_Dictionary_2_PostProcessEvent_List_1_SerializedBundleRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663586);
			PostProcessLayer.NativeMethodInfoPtr_set_sortedBundles_Private_set_Void_Dictionary_2_PostProcessEvent_List_1_SerializedBundleRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663587);
			PostProcessLayer.NativeMethodInfoPtr_get_cameraDepthFlags_Public_get_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663588);
			PostProcessLayer.NativeMethodInfoPtr_set_cameraDepthFlags_Private_set_Void_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663589);
			PostProcessLayer.NativeMethodInfoPtr_get_haveBundlesBeenInited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663590);
			PostProcessLayer.NativeMethodInfoPtr_set_haveBundlesBeenInited_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663591);
			PostProcessLayer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663592);
			PostProcessLayer.NativeMethodInfoPtr_InitLegacy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663593);
			PostProcessLayer.NativeMethodInfoPtr_DynamicResolutionAllowsFinalBlitToCameraTarget_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663594);
			PostProcessLayer.NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663595);
			PostProcessLayer.NativeMethodInfoPtr_Init_Public_Void_PostProcessResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663596);
			PostProcessLayer.NativeMethodInfoPtr_InitBundles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663597);
			PostProcessLayer.NativeMethodInfoPtr_UpdateBundleSortList_Private_Void_List_1_SerializedBundleRef_PostProcessEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663598);
			PostProcessLayer.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663599);
			PostProcessLayer.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663600);
			PostProcessLayer.NativeMethodInfoPtr_OnPreCull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663601);
			PostProcessLayer.NativeMethodInfoPtr_OnPreRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663602);
			PostProcessLayer.NativeMethodInfoPtr_RequiresInitialBlit_Private_Static_Boolean_Camera_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663603);
			PostProcessLayer.NativeMethodInfoPtr_UpdateSrcDstForOpaqueOnly_Private_Void_byref_Int32_byref_Int32_PostProcessRenderContext_RenderTargetIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663604);
			PostProcessLayer.NativeMethodInfoPtr_BuildCommandBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663605);
			PostProcessLayer.NativeMethodInfoPtr_OnPostRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663606);
			PostProcessLayer.NativeMethodInfoPtr_GetBundle_Public_PostProcessBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663607);
			PostProcessLayer.NativeMethodInfoPtr_GetBundle_Public_PostProcessBundle_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663608);
			PostProcessLayer.NativeMethodInfoPtr_GetSettings_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663609);
			PostProcessLayer.NativeMethodInfoPtr_BakeMSVOMap_Public_Void_CommandBuffer_Camera_RenderTargetIdentifier_Nullable_1_RenderTargetIdentifier_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663610);
			PostProcessLayer.NativeMethodInfoPtr_OverrideSettings_Internal_Void_List_1_PostProcessEffectSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663611);
			PostProcessLayer.NativeMethodInfoPtr_SetLegacyCameraFlags_Private_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663612);
			PostProcessLayer.NativeMethodInfoPtr_ResetHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663613);
			PostProcessLayer.NativeMethodInfoPtr_HasOpaqueOnlyEffects_Public_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663614);
			PostProcessLayer.NativeMethodInfoPtr_HasActiveEffects_Public_Boolean_PostProcessEvent_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663615);
			PostProcessLayer.NativeMethodInfoPtr_SetupContext_Private_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663616);
			PostProcessLayer.NativeMethodInfoPtr_UpdateVolumeSystem_Public_Void_Camera_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663617);
			PostProcessLayer.NativeMethodInfoPtr_RenderOpaqueOnly_Public_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663618);
			PostProcessLayer.NativeMethodInfoPtr_Render_Public_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663619);
			PostProcessLayer.NativeMethodInfoPtr_RenderInjectionPoint_Private_Int32_PostProcessEvent_PostProcessRenderContext_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663620);
			PostProcessLayer.NativeMethodInfoPtr_RenderList_Private_Void_List_1_SerializedBundleRef_PostProcessRenderContext_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663621);
			PostProcessLayer.NativeMethodInfoPtr_ApplyFlip_Private_Void_PostProcessRenderContext_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663622);
			PostProcessLayer.NativeMethodInfoPtr_ApplyDefaultFlip_Private_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663623);
			PostProcessLayer.NativeMethodInfoPtr_RenderBuiltins_Private_Int32_PostProcessRenderContext_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663624);
			PostProcessLayer.NativeMethodInfoPtr_RenderFinalPass_Private_Void_PostProcessRenderContext_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663625);
			PostProcessLayer.NativeMethodInfoPtr_RenderEffect_Private_Int32_PostProcessRenderContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663626);
			PostProcessLayer.NativeMethodInfoPtr_ShouldGenerateLogHistogram_Private_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663627);
			PostProcessLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, 100663628);
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00011154 File Offset: 0x0000F354
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00011194 File Offset: 0x0000F394
		public unsafe Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> sortedBundles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_get_sortedBundles_Public_get_Dictionary_2_PostProcessEvent_List_1_SerializedBundleRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>>>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 388203, RefRangeEnd = 388211, XrefRangeStart = 388203, XrefRangeEnd = 388211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_set_sortedBundles_Private_set_Void_Dictionary_2_PostProcessEvent_List_1_SerializedBundleRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000375 RID: 885 RVA: 0x000111D8 File Offset: 0x0000F3D8
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00011214 File Offset: 0x0000F414
		public unsafe DepthTextureMode cameraDepthFlags
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 381016, RefRangeEnd = 381017, XrefRangeStart = 381016, XrefRangeEnd = 381017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_get_cameraDepthFlags_Public_get_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_set_cameraDepthFlags_Private_set_Void_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00011254 File Offset: 0x0000F454
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00011290 File Offset: 0x0000F490
		public unsafe bool haveBundlesBeenInited
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_get_haveBundlesBeenInited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_set_haveBundlesBeenInited_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000112D0 File Offset: 0x0000F4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446437, XrefRangeEnd = 446466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00011304 File Offset: 0x0000F504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 446508, RefRangeEnd = 446510, XrefRangeStart = 446466, XrefRangeEnd = 446508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitLegacy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_InitLegacy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00011338 File Offset: 0x0000F538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 446516, RefRangeEnd = 446518, XrefRangeStart = 446510, XrefRangeEnd = 446516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DynamicResolutionAllowsFinalBlitToCameraTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_DynamicResolutionAllowsFinalBlitToCameraTarget_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00011374 File Offset: 0x0000F574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446518, XrefRangeEnd = 446527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000113C8 File Offset: 0x0000F5C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 446560, RefRangeEnd = 446561, XrefRangeStart = 446527, XrefRangeEnd = 446560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(PostProcessResources resources)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resources);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_Init_Public_Void_PostProcessResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0001140C File Offset: 0x0000F60C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 446618, RefRangeEnd = 446619, XrefRangeStart = 446561, XrefRangeEnd = 446618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitBundles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_InitBundles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00011440 File Offset: 0x0000F640
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 446704, RefRangeEnd = 446707, XrefRangeStart = 446619, XrefRangeEnd = 446704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBundleSortList(List<PostProcessLayer.SerializedBundleRef> sortedList, PostProcessEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortedList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_UpdateBundleSortList_Private_Void_List_1_SerializedBundleRef_PostProcessEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00011490 File Offset: 0x0000F690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446707, XrefRangeEnd = 446747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000114C4 File Offset: 0x0000F6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446747, XrefRangeEnd = 446749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000114F8 File Offset: 0x0000F6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446749, XrefRangeEnd = 446800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreCull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_OnPreCull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0001152C File Offset: 0x0000F72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446800, XrefRangeEnd = 446807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_OnPreRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00011560 File Offset: 0x0000F760
		[CallerCount(0)]
		public unsafe static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_RequiresInitialBlit_Private_Static_Boolean_Camera_PostProcessRenderContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000115B4 File Offset: 0x0000F7B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 446814, RefRangeEnd = 446818, XrefRangeStart = 446807, XrefRangeEnd = 446814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dst;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTarget;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opaqueOnlyEffectsRemaining;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_UpdateSrcDstForOpaqueOnly_Private_Void_byref_Int32_byref_Int32_PostProcessRenderContext_RenderTargetIdentifier_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00011630 File Offset: 0x0000F830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 446938, RefRangeEnd = 446940, XrefRangeStart = 446818, XrefRangeEnd = 446938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildCommandBuffers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_BuildCommandBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00011664 File Offset: 0x0000F864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446940, XrefRangeEnd = 446954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPostRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_OnPostRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00011698 File Offset: 0x0000F898
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 446962, RefRangeEnd = 446967, XrefRangeStart = 446954, XrefRangeEnd = 446962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessBundle GetBundle<T>() where T : PostProcessEffectSettings
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.MethodInfoStoreGeneric_GetBundle_Public_PostProcessBundle_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessBundle>(intPtr3) : null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000116D8 File Offset: 0x0000F8D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 446971, RefRangeEnd = 446972, XrefRangeStart = 446967, XrefRangeEnd = 446971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessBundle GetBundle(Type settingsType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settingsType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_GetBundle_Public_PostProcessBundle_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessBundle>(intPtr3) : null;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00011728 File Offset: 0x0000F928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446972, XrefRangeEnd = 446973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetSettings<T>() where T : PostProcessEffectSettings
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.MethodInfoStoreGeneric_GetSettings_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00011764 File Offset: 0x0000F964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446973, XrefRangeEnd = 446984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(depthMap));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMSAA;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_BakeMSVOMap_Public_Void_CommandBuffer_Camera_RenderTargetIdentifier_Nullable_1_RenderTargetIdentifier_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000117FC File Offset: 0x0000F9FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 447001, RefRangeEnd = 447003, XrefRangeStart = 446984, XrefRangeEnd = 447001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interpFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_OverrideSettings_Internal_Void_List_1_PostProcessEffectSettings_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0001184C File Offset: 0x0000FA4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 447020, RefRangeEnd = 447021, XrefRangeStart = 447003, XrefRangeEnd = 447020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLegacyCameraFlags(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_SetLegacyCameraFlags_Private_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00011890 File Offset: 0x0000FA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447021, XrefRangeEnd = 447030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_ResetHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000118C4 File Offset: 0x0000FAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447030, XrefRangeEnd = 447031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasOpaqueOnlyEffects(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_HasOpaqueOnlyEffects_Public_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00011914 File Offset: 0x0000FB14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 447043, RefRangeEnd = 447047, XrefRangeStart = 447031, XrefRangeEnd = 447043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_HasActiveEffects_Public_Boolean_PostProcessEvent_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00011970 File Offset: 0x0000FB70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 447072, RefRangeEnd = 447076, XrefRangeStart = 447047, XrefRangeEnd = 447072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupContext(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_SetupContext_Private_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000119B4 File Offset: 0x0000FBB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 447094, RefRangeEnd = 447098, XrefRangeStart = 447076, XrefRangeEnd = 447094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVolumeSystem(Camera cam, CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_UpdateVolumeSystem_Public_Void_Camera_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00011A08 File Offset: 0x0000FC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447098, XrefRangeEnd = 447112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderOpaqueOnly(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_RenderOpaqueOnly_Public_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00011A4C File Offset: 0x0000FC4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 447206, RefRangeEnd = 447207, XrefRangeStart = 447112, XrefRangeEnd = 447206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_Render_Public_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00011A90 File Offset: 0x0000FC90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 447219, RefRangeEnd = 447221, XrefRangeStart = 447207, XrefRangeEnd = 447219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(marker);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseTargetAfterUse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_RenderInjectionPoint_Private_Int32_PostProcessEvent_PostProcessRenderContext_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00011B0C File Offset: 0x0000FD0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 447272, RefRangeEnd = 447275, XrefRangeStart = 447221, XrefRangeEnd = 447272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderList(List<PostProcessLayer.SerializedBundleRef> list, PostProcessRenderContext context, string marker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(marker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_RenderList_Private_Void_List_1_SerializedBundleRef_PostProcessRenderContext_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00011B74 File Offset: 0x0000FD74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 447281, RefRangeEnd = 447283, XrefRangeStart = 447275, XrefRangeEnd = 447281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_ApplyFlip_Private_Void_PostProcessRenderContext_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 447292, RefRangeEnd = 447293, XrefRangeStart = 447283, XrefRangeEnd = 447292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDefaultFlip(MaterialPropertyBlock properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_ApplyDefaultFlip_Private_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00011C0C File Offset: 0x0000FE0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 447393, RefRangeEnd = 447394, XrefRangeStart = 447293, XrefRangeEnd = 447393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFinalPass;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseTargetAfterUse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_RenderBuiltins_Private_Int32_PostProcessRenderContext_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00011C84 File Offset: 0x0000FE84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 447488, RefRangeEnd = 447489, XrefRangeStart = 447394, XrefRangeEnd = 447488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseTargetAfterUse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_RenderFinalPass_Private_Void_PostProcessRenderContext_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 447496, RefRangeEnd = 447505, XrefRangeStart = 447489, XrefRangeEnd = 447496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = false) where T : PostProcessEffectSettings
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTempTarget;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.MethodInfoStoreGeneric_RenderEffect_Private_Int32_PostProcessRenderContext_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00011D40 File Offset: 0x0000FF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447505, XrefRangeEnd = 447509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldGenerateLogHistogram(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr_ShouldGenerateLogHistogram_Private_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00011D90 File Offset: 0x0000FF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447509, XrefRangeEnd = 447528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessLayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00003EA6 File Offset: 0x000020A6
		public PostProcessLayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00011DCC File Offset: 0x0000FFCC
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00003EAF File Offset: 0x000020AF
		public unsafe Transform volumeTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_volumeTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_volumeTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00011DFC File Offset: 0x0000FFFC
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00003ECE File Offset: 0x000020CE
		public unsafe LayerMask volumeLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_volumeLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_volumeLayer)) = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00011E24 File Offset: 0x00010024
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00003EE9 File Offset: 0x000020E9
		public unsafe bool stopNaNPropagation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_stopNaNPropagation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_stopNaNPropagation)) = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00011E4C File Offset: 0x0001004C
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00003F04 File Offset: 0x00002104
		public unsafe bool finalBlitToCameraTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_finalBlitToCameraTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_finalBlitToCameraTarget)) = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00011E74 File Offset: 0x00010074
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x00003F1F File Offset: 0x0000211F
		public unsafe PostProcessLayer.Antialiasing antialiasingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_antialiasingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_antialiasingMode)) = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00011E9C File Offset: 0x0001009C
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00003F3A File Offset: 0x0000213A
		public unsafe TemporalAntialiasing temporalAntialiasing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_temporalAntialiasing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TemporalAntialiasing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_temporalAntialiasing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00011ECC File Offset: 0x000100CC
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00003F59 File Offset: 0x00002159
		public unsafe SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_subpixelMorphologicalAntialiasing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubpixelMorphologicalAntialiasing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_subpixelMorphologicalAntialiasing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00011EFC File Offset: 0x000100FC
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00003F78 File Offset: 0x00002178
		public unsafe FastApproximateAntialiasing fastApproximateAntialiasing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_fastApproximateAntialiasing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastApproximateAntialiasing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_fastApproximateAntialiasing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00011F2C File Offset: 0x0001012C
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003F97 File Offset: 0x00002197
		public unsafe Fog fog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_fog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_fog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00011F5C File Offset: 0x0001015C
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003FB6 File Offset: 0x000021B6
		public unsafe Dithering dithering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_dithering);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dithering>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_dithering), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00011F8C File Offset: 0x0001018C
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00003FD5 File Offset: 0x000021D5
		public unsafe PostProcessDebugLayer debugLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_debugLayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessDebugLayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_debugLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00011FBC File Offset: 0x000101BC
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00003FF4 File Offset: 0x000021F4
		public unsafe PostProcessResources m_Resources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_Resources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_Resources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00011FEC File Offset: 0x000101EC
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00004013 File Offset: 0x00002213
		public unsafe PostProcessResources m_OldResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_OldResources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_OldResources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0001201C File Offset: 0x0001021C
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00004032 File Offset: 0x00002232
		public unsafe bool m_ShowToolkit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_ShowToolkit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_ShowToolkit)) = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00012044 File Offset: 0x00010244
		// (set) Token: 0x060003BC RID: 956 RVA: 0x0000404D File Offset: 0x0000224D
		public unsafe bool m_ShowCustomSorter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_ShowCustomSorter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_ShowCustomSorter)) = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0001206C File Offset: 0x0001026C
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00004068 File Offset: 0x00002268
		public unsafe bool breakBeforeColorGrading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_breakBeforeColorGrading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_breakBeforeColorGrading)) = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00012094 File Offset: 0x00010294
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00004083 File Offset: 0x00002283
		public unsafe List<PostProcessLayer.SerializedBundleRef> m_BeforeTransparentBundles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_BeforeTransparentBundles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PostProcessLayer.SerializedBundleRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_BeforeTransparentBundles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x000120C4 File Offset: 0x000102C4
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x000040A2 File Offset: 0x000022A2
		public unsafe List<PostProcessLayer.SerializedBundleRef> m_BeforeStackBundles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_BeforeStackBundles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PostProcessLayer.SerializedBundleRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_BeforeStackBundles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x000120F4 File Offset: 0x000102F4
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x000040C1 File Offset: 0x000022C1
		public unsafe List<PostProcessLayer.SerializedBundleRef> m_AfterStackBundles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_AfterStackBundles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PostProcessLayer.SerializedBundleRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_AfterStackBundles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00012124 File Offset: 0x00010324
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x000040E0 File Offset: 0x000022E0
		public unsafe Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> _sortedBundles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr__sortedBundles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr__sortedBundles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00012154 File Offset: 0x00010354
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x000040FF File Offset: 0x000022FF
		public unsafe DepthTextureMode _cameraDepthFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr__cameraDepthFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr__cameraDepthFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0001217C File Offset: 0x0001037C
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0000411A File Offset: 0x0000231A
		public unsafe bool _haveBundlesBeenInited_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr__haveBundlesBeenInited_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr__haveBundlesBeenInited_k__BackingField)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003CB RID: 971 RVA: 0x000121A4 File Offset: 0x000103A4
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00004135 File Offset: 0x00002335
		public unsafe Dictionary<Type, PostProcessBundle> m_Bundles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_Bundles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, PostProcessBundle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_Bundles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003CD RID: 973 RVA: 0x000121D4 File Offset: 0x000103D4
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00004154 File Offset: 0x00002354
		public unsafe PropertySheetFactory m_PropertySheetFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_PropertySheetFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySheetFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_PropertySheetFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00012204 File Offset: 0x00010404
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00004173 File Offset: 0x00002373
		public unsafe CommandBuffer m_LegacyCmdBufferBeforeReflections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBufferBeforeReflections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBufferBeforeReflections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00012234 File Offset: 0x00010434
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00004192 File Offset: 0x00002392
		public unsafe CommandBuffer m_LegacyCmdBufferBeforeLighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBufferBeforeLighting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBufferBeforeLighting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00012264 File Offset: 0x00010464
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x000041B1 File Offset: 0x000023B1
		public unsafe CommandBuffer m_LegacyCmdBufferOpaque
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBufferOpaque);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBufferOpaque), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00012294 File Offset: 0x00010494
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x000041D0 File Offset: 0x000023D0
		public unsafe CommandBuffer m_LegacyCmdBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_LegacyCmdBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x000122C4 File Offset: 0x000104C4
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x000041EF File Offset: 0x000023EF
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x000122F4 File Offset: 0x000104F4
		// (set) Token: 0x060003DA RID: 986 RVA: 0x0000420E File Offset: 0x0000240E
		public unsafe PostProcessRenderContext m_CurrentContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_CurrentContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessRenderContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_CurrentContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00012324 File Offset: 0x00010524
		// (set) Token: 0x060003DC RID: 988 RVA: 0x0000422D File Offset: 0x0000242D
		public unsafe LogHistogram m_LogHistogram
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_LogHistogram);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogHistogram>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_LogHistogram), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00012354 File Offset: 0x00010554
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000424C File Offset: 0x0000244C
		public unsafe bool m_SettingsUpdateNeeded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_SettingsUpdateNeeded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_SettingsUpdateNeeded)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0001237C File Offset: 0x0001057C
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00004267 File Offset: 0x00002467
		public unsafe bool m_IsRenderingInSceneView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_IsRenderingInSceneView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_IsRenderingInSceneView)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x000123A4 File Offset: 0x000105A4
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00004282 File Offset: 0x00002482
		public unsafe TargetPool m_TargetPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_TargetPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_TargetPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000123D4 File Offset: 0x000105D4
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000042A1 File Offset: 0x000024A1
		public unsafe bool m_NaNKilled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_NaNKilled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_NaNKilled)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x000123FC File Offset: 0x000105FC
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000042BC File Offset: 0x000024BC
		public unsafe List<PostProcessEffectRenderer> m_ActiveEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_ActiveEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PostProcessEffectRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_ActiveEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0001242C File Offset: 0x0001062C
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x000042DB File Offset: 0x000024DB
		public unsafe List<RenderTargetIdentifier> m_Targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_Targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RenderTargetIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.NativeFieldInfoPtr_m_Targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_volumeTrigger;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_volumeLayer;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_stopNaNPropagation;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr_finalBlitToCameraTarget;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr_antialiasingMode;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr_temporalAntialiasing;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_subpixelMorphologicalAntialiasing;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_fastApproximateAntialiasing;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_fog;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_dithering;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_debugLayer;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_m_Resources;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr_m_OldResources;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeFieldInfoPtr_m_ShowToolkit;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeFieldInfoPtr_m_ShowCustomSorter;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr_breakBeforeColorGrading;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_m_BeforeTransparentBundles;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_m_BeforeStackBundles;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_m_AfterStackBundles;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr__sortedBundles_k__BackingField;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr__cameraDepthFlags_k__BackingField;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr__haveBundlesBeenInited_k__BackingField;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_m_Bundles;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertySheetFactory;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_m_LegacyCmdBufferBeforeReflections;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_m_LegacyCmdBufferBeforeLighting;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_m_LegacyCmdBufferOpaque;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_m_LegacyCmdBuffer;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentContext;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_m_LogHistogram;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr_m_SettingsUpdateNeeded;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_m_IsRenderingInSceneView;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetPool;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_m_NaNKilled;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveEffects;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_m_Targets;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_get_sortedBundles_Public_get_Dictionary_2_PostProcessEvent_List_1_SerializedBundleRef_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_set_sortedBundles_Private_set_Void_Dictionary_2_PostProcessEvent_List_1_SerializedBundleRef_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraDepthFlags_Public_get_DepthTextureMode_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_set_cameraDepthFlags_Private_set_Void_DepthTextureMode_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_get_haveBundlesBeenInited_Public_get_Boolean_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_set_haveBundlesBeenInited_Private_set_Void_Boolean_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_InitLegacy_Private_Void_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_DynamicResolutionAllowsFinalBlitToCameraTarget_Private_Boolean_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_PostProcessResources_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_InitBundles_Public_Void_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBundleSortList_Private_Void_List_1_SerializedBundleRef_PostProcessEvent_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_OnPreCull_Private_Void_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_OnPreRender_Private_Void_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_RequiresInitialBlit_Private_Static_Boolean_Camera_PostProcessRenderContext_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSrcDstForOpaqueOnly_Private_Void_byref_Int32_byref_Int32_PostProcessRenderContext_RenderTargetIdentifier_Int32_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_BuildCommandBuffers_Private_Void_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_OnPostRender_Private_Void_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_GetBundle_Public_PostProcessBundle_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_GetBundle_Public_PostProcessBundle_Type_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_T_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_BakeMSVOMap_Public_Void_CommandBuffer_Camera_RenderTargetIdentifier_Nullable_1_RenderTargetIdentifier_Boolean_Boolean_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_OverrideSettings_Internal_Void_List_1_PostProcessEffectSettings_Single_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_SetLegacyCameraFlags_Private_Void_PostProcessRenderContext_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_ResetHistory_Public_Void_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_HasOpaqueOnlyEffects_Public_Boolean_PostProcessRenderContext_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_HasActiveEffects_Public_Boolean_PostProcessEvent_PostProcessRenderContext_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_SetupContext_Private_Void_PostProcessRenderContext_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolumeSystem_Public_Void_Camera_CommandBuffer_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_RenderOpaqueOnly_Public_Void_PostProcessRenderContext_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_PostProcessRenderContext_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_RenderInjectionPoint_Private_Int32_PostProcessEvent_PostProcessRenderContext_String_Int32_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_RenderList_Private_Void_List_1_SerializedBundleRef_PostProcessRenderContext_String_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFlip_Private_Void_PostProcessRenderContext_MaterialPropertyBlock_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDefaultFlip_Private_Void_MaterialPropertyBlock_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_RenderBuiltins_Private_Int32_PostProcessRenderContext_Boolean_Int32_Int32_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_RenderFinalPass_Private_Void_PostProcessRenderContext_Int32_Int32_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_RenderEffect_Private_Int32_PostProcessRenderContext_Boolean_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_ShouldGenerateLogHistogram_Private_Boolean_PostProcessRenderContext_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200007C RID: 124
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Antialiasing")]
		public enum Antialiasing
		{
			// Token: 0x040004CC RID: 1228
			None,
			// Token: 0x040004CD RID: 1229
			FastApproximateAntialiasing,
			// Token: 0x040004CE RID: 1230
			SubpixelMorphologicalAntialiasing,
			// Token: 0x040004CF RID: 1231
			TemporalAntialiasing
		}

		// Token: 0x0200007D RID: 125
		[Serializable]
		public sealed class SerializedBundleRef : Object
		{
			// Token: 0x060006F0 RID: 1776 RVA: 0x0001ADA4 File Offset: 0x00018FA4
			// Note: this type is marked as 'beforefieldinit'.
			static SerializedBundleRef()
			{
				Il2CppClassPointerStore<PostProcessLayer.SerializedBundleRef>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "SerializedBundleRef");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessLayer.SerializedBundleRef>.NativeClassPtr);
				PostProcessLayer.SerializedBundleRef.NativeFieldInfoPtr_assemblyQualifiedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer.SerializedBundleRef>.NativeClassPtr, "assemblyQualifiedName");
				PostProcessLayer.SerializedBundleRef.NativeFieldInfoPtr_bundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer.SerializedBundleRef>.NativeClassPtr, "bundle");
				PostProcessLayer.SerializedBundleRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.SerializedBundleRef>.NativeClassPtr, 100663629);
			}

			// Token: 0x060006F1 RID: 1777 RVA: 0x0001AE0C File Offset: 0x0001900C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializedBundleRef()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessLayer.SerializedBundleRef>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.SerializedBundleRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006F2 RID: 1778 RVA: 0x00005767 File Offset: 0x00003967
			public SerializedBundleRef(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700024C RID: 588
			// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0001AE48 File Offset: 0x00019048
			// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00005770 File Offset: 0x00003970
			public unsafe string assemblyQualifiedName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.SerializedBundleRef.NativeFieldInfoPtr_assemblyQualifiedName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.SerializedBundleRef.NativeFieldInfoPtr_assemblyQualifiedName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700024D RID: 589
			// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0001AE70 File Offset: 0x00019070
			// (set) Token: 0x060006F6 RID: 1782 RVA: 0x0000578F File Offset: 0x0000398F
			public unsafe PostProcessBundle bundle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.SerializedBundleRef.NativeFieldInfoPtr_bundle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessBundle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.SerializedBundleRef.NativeFieldInfoPtr_bundle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004D0 RID: 1232
			private static readonly IntPtr NativeFieldInfoPtr_assemblyQualifiedName;

			// Token: 0x040004D1 RID: 1233
			private static readonly IntPtr NativeFieldInfoPtr_bundle;

			// Token: 0x040004D2 RID: 1234
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200007E RID: 126
		[ObfuscatedName("UnityEngine.Rendering.PostProcessing.PostProcessLayer+<>c__DisplayClass54_0")]
		public sealed class __c__DisplayClass54_0 : Object
		{
			// Token: 0x060006F7 RID: 1783 RVA: 0x0001AEA0 File Offset: 0x000190A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_0()
			{
				Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "<>c__DisplayClass54_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_0>.NativeClassPtr);
				PostProcessLayer.__c__DisplayClass54_0.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_0>.NativeClassPtr, "evt");
				PostProcessLayer.__c__DisplayClass54_0.NativeFieldInfoPtr_effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_0>.NativeClassPtr, "effects");
				PostProcessLayer.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_0>.NativeClassPtr, 100663630);
				PostProcessLayer.__c__DisplayClass54_0.NativeMethodInfoPtr__UpdateBundleSortList_b__0_Internal_Boolean_KeyValuePair_2_Type_PostProcessBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_0>.NativeClassPtr, 100663631);
				PostProcessLayer.__c__DisplayClass54_0.NativeMethodInfoPtr__UpdateBundleSortList_b__2_Internal_Boolean_SerializedBundleRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_0>.NativeClassPtr, 100663632);
			}

			// Token: 0x060006F8 RID: 1784 RVA: 0x0001AF30 File Offset: 0x00019130
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006F9 RID: 1785 RVA: 0x0001AF6C File Offset: 0x0001916C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446423, XrefRangeEnd = 446424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateBundleSortList_b__0(KeyValuePair<Type, PostProcessBundle> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.__c__DisplayClass54_0.NativeMethodInfoPtr__UpdateBundleSortList_b__0_Internal_Boolean_KeyValuePair_2_Type_PostProcessBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060006FA RID: 1786 RVA: 0x0001AFC0 File Offset: 0x000191C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446424, XrefRangeEnd = 446435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateBundleSortList_b__2(PostProcessLayer.SerializedBundleRef x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.__c__DisplayClass54_0.NativeMethodInfoPtr__UpdateBundleSortList_b__2_Internal_Boolean_SerializedBundleRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060006FB RID: 1787 RVA: 0x000057AE File Offset: 0x000039AE
			public __c__DisplayClass54_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700024E RID: 590
			// (get) Token: 0x060006FC RID: 1788 RVA: 0x0001B010 File Offset: 0x00019210
			// (set) Token: 0x060006FD RID: 1789 RVA: 0x000057B7 File Offset: 0x000039B7
			public unsafe PostProcessEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.__c__DisplayClass54_0.NativeFieldInfoPtr_evt);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.__c__DisplayClass54_0.NativeFieldInfoPtr_evt)) = value;
				}
			}

			// Token: 0x1700024F RID: 591
			// (get) Token: 0x060006FE RID: 1790 RVA: 0x0001B038 File Offset: 0x00019238
			// (set) Token: 0x060006FF RID: 1791 RVA: 0x000057D2 File Offset: 0x000039D2
			public unsafe List<PostProcessBundle> effects
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.__c__DisplayClass54_0.NativeFieldInfoPtr_effects);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PostProcessBundle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.__c__DisplayClass54_0.NativeFieldInfoPtr_effects), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004D3 RID: 1235
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x040004D4 RID: 1236
			private static readonly IntPtr NativeFieldInfoPtr_effects;

			// Token: 0x040004D5 RID: 1237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004D6 RID: 1238
			private static readonly IntPtr NativeMethodInfoPtr__UpdateBundleSortList_b__0_Internal_Boolean_KeyValuePair_2_Type_PostProcessBundle_0;

			// Token: 0x040004D7 RID: 1239
			private static readonly IntPtr NativeMethodInfoPtr__UpdateBundleSortList_b__2_Internal_Boolean_SerializedBundleRef_0;
		}

		// Token: 0x0200007F RID: 127
		[ObfuscatedName("UnityEngine.Rendering.PostProcessing.PostProcessLayer+<>c__DisplayClass54_1")]
		public sealed class __c__DisplayClass54_1 : Object
		{
			// Token: 0x06000700 RID: 1792 RVA: 0x0001B068 File Offset: 0x00019268
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_1()
			{
				Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "<>c__DisplayClass54_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_1>.NativeClassPtr);
				PostProcessLayer.__c__DisplayClass54_1.NativeFieldInfoPtr_searchStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_1>.NativeClassPtr, "searchStr");
				PostProcessLayer.__c__DisplayClass54_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_1>.NativeClassPtr, 100663633);
				PostProcessLayer.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateBundleSortList_b__3_Internal_Boolean_PostProcessBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_1>.NativeClassPtr, 100663634);
			}

			// Token: 0x06000701 RID: 1793 RVA: 0x0001B0D0 File Offset: 0x000192D0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.__c__DisplayClass54_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000702 RID: 1794 RVA: 0x0001B10C File Offset: 0x0001930C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446435, XrefRangeEnd = 446436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateBundleSortList_b__3(PostProcessBundle b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateBundleSortList_b__3_Internal_Boolean_PostProcessBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000703 RID: 1795 RVA: 0x000057F1 File Offset: 0x000039F1
			public __c__DisplayClass54_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000250 RID: 592
			// (get) Token: 0x06000704 RID: 1796 RVA: 0x0001B15C File Offset: 0x0001935C
			// (set) Token: 0x06000705 RID: 1797 RVA: 0x000057FA File Offset: 0x000039FA
			public unsafe string searchStr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.__c__DisplayClass54_1.NativeFieldInfoPtr_searchStr);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.__c__DisplayClass54_1.NativeFieldInfoPtr_searchStr), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004D8 RID: 1240
			private static readonly IntPtr NativeFieldInfoPtr_searchStr;

			// Token: 0x040004D9 RID: 1241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004DA RID: 1242
			private static readonly IntPtr NativeMethodInfoPtr__UpdateBundleSortList_b__3_Internal_Boolean_PostProcessBundle_0;
		}

		// Token: 0x02000080 RID: 128
		[ObfuscatedName("UnityEngine.Rendering.PostProcessing.PostProcessLayer+<>c__DisplayClass54_2")]
		public sealed class __c__DisplayClass54_2 : Object
		{
			// Token: 0x06000706 RID: 1798 RVA: 0x0001B184 File Offset: 0x00019384
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_2()
			{
				Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "<>c__DisplayClass54_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_2>.NativeClassPtr);
				PostProcessLayer.__c__DisplayClass54_2.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_2>.NativeClassPtr, "typeName");
				PostProcessLayer.__c__DisplayClass54_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_2>.NativeClassPtr, 100663635);
				PostProcessLayer.__c__DisplayClass54_2.NativeMethodInfoPtr__UpdateBundleSortList_b__4_Internal_Boolean_SerializedBundleRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_2>.NativeClassPtr, 100663636);
			}

			// Token: 0x06000707 RID: 1799 RVA: 0x0001B1EC File Offset: 0x000193EC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.__c__DisplayClass54_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000708 RID: 1800 RVA: 0x0001B228 File Offset: 0x00019428
			[CallerCount(0)]
			public unsafe bool _UpdateBundleSortList_b__4(PostProcessLayer.SerializedBundleRef b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.__c__DisplayClass54_2.NativeMethodInfoPtr__UpdateBundleSortList_b__4_Internal_Boolean_SerializedBundleRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000709 RID: 1801 RVA: 0x00005819 File Offset: 0x00003A19
			public __c__DisplayClass54_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000251 RID: 593
			// (get) Token: 0x0600070A RID: 1802 RVA: 0x0001B278 File Offset: 0x00019478
			// (set) Token: 0x0600070B RID: 1803 RVA: 0x00005822 File Offset: 0x00003A22
			public unsafe string typeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.__c__DisplayClass54_2.NativeFieldInfoPtr_typeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.__c__DisplayClass54_2.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004DB RID: 1243
			private static readonly IntPtr NativeFieldInfoPtr_typeName;

			// Token: 0x040004DC RID: 1244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004DD RID: 1245
			private static readonly IntPtr NativeMethodInfoPtr__UpdateBundleSortList_b__4_Internal_Boolean_SerializedBundleRef_0;
		}

		// Token: 0x02000081 RID: 129
		[ObfuscatedName("UnityEngine.Rendering.PostProcessing.PostProcessLayer+<>c__DisplayClass54_3")]
		public sealed class __c__DisplayClass54_3 : Object
		{
			// Token: 0x0600070C RID: 1804 RVA: 0x0001B2A0 File Offset: 0x000194A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_3()
			{
				Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "<>c__DisplayClass54_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_3>.NativeClassPtr);
				PostProcessLayer.__c__DisplayClass54_3.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_3>.NativeClassPtr, "typeName");
				PostProcessLayer.__c__DisplayClass54_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_3>.NativeClassPtr, 100663637);
				PostProcessLayer.__c__DisplayClass54_3.NativeMethodInfoPtr__UpdateBundleSortList_b__5_Internal_Boolean_PostProcessBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_3>.NativeClassPtr, 100663638);
			}

			// Token: 0x0600070D RID: 1805 RVA: 0x0001B308 File Offset: 0x00019508
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessLayer.__c__DisplayClass54_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.__c__DisplayClass54_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600070E RID: 1806 RVA: 0x0001B344 File Offset: 0x00019544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateBundleSortList_b__5(PostProcessBundle b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.__c__DisplayClass54_3.NativeMethodInfoPtr__UpdateBundleSortList_b__5_Internal_Boolean_PostProcessBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600070F RID: 1807 RVA: 0x00005841 File Offset: 0x00003A41
			public __c__DisplayClass54_3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000252 RID: 594
			// (get) Token: 0x06000710 RID: 1808 RVA: 0x0001B394 File Offset: 0x00019594
			// (set) Token: 0x06000711 RID: 1809 RVA: 0x0000584A File Offset: 0x00003A4A
			public unsafe string typeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.__c__DisplayClass54_3.NativeFieldInfoPtr_typeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessLayer.__c__DisplayClass54_3.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004DE RID: 1246
			private static readonly IntPtr NativeFieldInfoPtr_typeName;

			// Token: 0x040004DF RID: 1247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004E0 RID: 1248
			private static readonly IntPtr NativeMethodInfoPtr__UpdateBundleSortList_b__5_Internal_Boolean_PostProcessBundle_0;
		}

		// Token: 0x02000082 RID: 130
		[ObfuscatedName("UnityEngine.Rendering.PostProcessing.PostProcessLayer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000712 RID: 1810 RVA: 0x0001B3BC File Offset: 0x000195BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PostProcessLayer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessLayer.__c>.NativeClassPtr);
				PostProcessLayer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer.__c>.NativeClassPtr, "<>9");
				PostProcessLayer.__c.NativeFieldInfoPtr___9__54_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessLayer.__c>.NativeClassPtr, "<>9__54_1");
				PostProcessLayer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.__c>.NativeClassPtr, 100663640);
				PostProcessLayer.__c.NativeMethodInfoPtr__UpdateBundleSortList_b__54_1_Internal_PostProcessBundle_KeyValuePair_2_Type_PostProcessBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessLayer.__c>.NativeClassPtr, 100663641);
			}

			// Token: 0x06000713 RID: 1811 RVA: 0x0001B438 File Offset: 0x00019638
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessLayer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000714 RID: 1812 RVA: 0x0001B474 File Offset: 0x00019674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446436, XrefRangeEnd = 446437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PostProcessBundle _UpdateBundleSortList_b__54_1(KeyValuePair<Type, PostProcessBundle> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessLayer.__c.NativeMethodInfoPtr__UpdateBundleSortList_b__54_1_Internal_PostProcessBundle_KeyValuePair_2_Type_PostProcessBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessBundle>(intPtr3) : null;
				}
			}

			// Token: 0x06000715 RID: 1813 RVA: 0x00005869 File Offset: 0x00003A69
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000253 RID: 595
			// (get) Token: 0x06000716 RID: 1814 RVA: 0x0001B4CC File Offset: 0x000196CC
			// (set) Token: 0x06000717 RID: 1815 RVA: 0x00005872 File Offset: 0x00003A72
			public unsafe static PostProcessLayer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessLayer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessLayer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessLayer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000254 RID: 596
			// (get) Token: 0x06000718 RID: 1816 RVA: 0x0001B4F4 File Offset: 0x000196F4
			// (set) Token: 0x06000719 RID: 1817 RVA: 0x00005884 File Offset: 0x00003A84
			public unsafe static Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle> __9__54_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessLayer.__c.NativeFieldInfoPtr___9__54_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessLayer.__c.NativeFieldInfoPtr___9__54_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004E1 RID: 1249
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040004E2 RID: 1250
			private static readonly IntPtr NativeFieldInfoPtr___9__54_1;

			// Token: 0x040004E3 RID: 1251
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004E4 RID: 1252
			private static readonly IntPtr NativeMethodInfoPtr__UpdateBundleSortList_b__54_1_Internal_PostProcessBundle_KeyValuePair_2_Type_PostProcessBundle_0;
		}

		// Token: 0x02000083 RID: 131
		private sealed class MethodInfoStoreGeneric_GetBundle_Public_PostProcessBundle_0<T>
		{
			// Token: 0x040004E5 RID: 1253
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessLayer.NativeMethodInfoPtr_GetBundle_Public_PostProcessBundle_0, Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000084 RID: 132
		private sealed class MethodInfoStoreGeneric_GetSettings_Public_T_0<T>
		{
			// Token: 0x040004E6 RID: 1254
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessLayer.NativeMethodInfoPtr_GetSettings_Public_T_0, Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000085 RID: 133
		private sealed class MethodInfoStoreGeneric_RenderEffect_Private_Int32_PostProcessRenderContext_Boolean_0<T>
		{
			// Token: 0x040004E7 RID: 1255
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessLayer.NativeMethodInfoPtr_RenderEffect_Private_Int32_PostProcessRenderContext_Boolean_0, Il2CppClassPointerStore<PostProcessLayer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
