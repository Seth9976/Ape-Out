using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000057 RID: 87
	public sealed class PostProcessRenderContext : Object
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x00013248 File Offset: 0x00011448
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessRenderContext()
		{
			Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessRenderContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr);
			PostProcessRenderContext.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "m_Camera");
			PostProcessRenderContext.NativeFieldInfoPtr__command_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<command>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<source>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__destination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<destination>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__sourceFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<sourceFormat>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__flip_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<flip>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__resources_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<resources>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__propertySheets_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<propertySheets>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__userData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<userData>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__debugLayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<debugLayer>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<width>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<height>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__stereoActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<stereoActive>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__xrActiveEye_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<xrActiveEye>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__numberOfEyes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<numberOfEyes>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__stereoRenderingMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<stereoRenderingMode>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__screenWidth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<screenWidth>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__screenHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<screenHeight>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__isSceneView_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<isSceneView>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__antialiasing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<antialiasing>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr__temporalAntialiasing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "<temporalAntialiasing>k__BackingField");
			PostProcessRenderContext.NativeFieldInfoPtr_uberSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "uberSheet");
			PostProcessRenderContext.NativeFieldInfoPtr_autoExposureTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "autoExposureTexture");
			PostProcessRenderContext.NativeFieldInfoPtr_logHistogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "logHistogram");
			PostProcessRenderContext.NativeFieldInfoPtr_logLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "logLut");
			PostProcessRenderContext.NativeFieldInfoPtr_autoExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "autoExposure");
			PostProcessRenderContext.NativeFieldInfoPtr_bloomBufferNameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "bloomBufferNameID");
			PostProcessRenderContext.NativeFieldInfoPtr_physicalCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "physicalCamera");
			PostProcessRenderContext.NativeFieldInfoPtr_m_sourceDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, "m_sourceDescriptor");
			PostProcessRenderContext.NativeMethodInfoPtr_get_camera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663678);
			PostProcessRenderContext.NativeMethodInfoPtr_set_camera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663679);
			PostProcessRenderContext.NativeMethodInfoPtr_get_command_Public_get_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663680);
			PostProcessRenderContext.NativeMethodInfoPtr_set_command_Public_set_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663681);
			PostProcessRenderContext.NativeMethodInfoPtr_get_source_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663682);
			PostProcessRenderContext.NativeMethodInfoPtr_set_source_Public_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663683);
			PostProcessRenderContext.NativeMethodInfoPtr_get_destination_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663684);
			PostProcessRenderContext.NativeMethodInfoPtr_set_destination_Public_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663685);
			PostProcessRenderContext.NativeMethodInfoPtr_get_sourceFormat_Public_get_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663686);
			PostProcessRenderContext.NativeMethodInfoPtr_set_sourceFormat_Public_set_Void_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663687);
			PostProcessRenderContext.NativeMethodInfoPtr_get_flip_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663688);
			PostProcessRenderContext.NativeMethodInfoPtr_set_flip_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663689);
			PostProcessRenderContext.NativeMethodInfoPtr_get_resources_Public_get_PostProcessResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663690);
			PostProcessRenderContext.NativeMethodInfoPtr_set_resources_Internal_set_Void_PostProcessResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663691);
			PostProcessRenderContext.NativeMethodInfoPtr_get_propertySheets_Public_get_PropertySheetFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663692);
			PostProcessRenderContext.NativeMethodInfoPtr_set_propertySheets_Internal_set_Void_PropertySheetFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663693);
			PostProcessRenderContext.NativeMethodInfoPtr_get_userData_Public_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663694);
			PostProcessRenderContext.NativeMethodInfoPtr_set_userData_Private_set_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663695);
			PostProcessRenderContext.NativeMethodInfoPtr_get_debugLayer_Public_get_PostProcessDebugLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663696);
			PostProcessRenderContext.NativeMethodInfoPtr_set_debugLayer_Internal_set_Void_PostProcessDebugLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663697);
			PostProcessRenderContext.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663698);
			PostProcessRenderContext.NativeMethodInfoPtr_set_width_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663699);
			PostProcessRenderContext.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663700);
			PostProcessRenderContext.NativeMethodInfoPtr_set_height_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663701);
			PostProcessRenderContext.NativeMethodInfoPtr_get_stereoActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663702);
			PostProcessRenderContext.NativeMethodInfoPtr_set_stereoActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663703);
			PostProcessRenderContext.NativeMethodInfoPtr_get_xrActiveEye_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663704);
			PostProcessRenderContext.NativeMethodInfoPtr_set_xrActiveEye_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663705);
			PostProcessRenderContext.NativeMethodInfoPtr_get_numberOfEyes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663706);
			PostProcessRenderContext.NativeMethodInfoPtr_set_numberOfEyes_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663707);
			PostProcessRenderContext.NativeMethodInfoPtr_get_stereoRenderingMode_Public_get_StereoRenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663708);
			PostProcessRenderContext.NativeMethodInfoPtr_set_stereoRenderingMode_Private_set_Void_StereoRenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663709);
			PostProcessRenderContext.NativeMethodInfoPtr_get_screenWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663710);
			PostProcessRenderContext.NativeMethodInfoPtr_set_screenWidth_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663711);
			PostProcessRenderContext.NativeMethodInfoPtr_get_screenHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663712);
			PostProcessRenderContext.NativeMethodInfoPtr_set_screenHeight_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663713);
			PostProcessRenderContext.NativeMethodInfoPtr_get_isSceneView_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663714);
			PostProcessRenderContext.NativeMethodInfoPtr_set_isSceneView_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663715);
			PostProcessRenderContext.NativeMethodInfoPtr_get_antialiasing_Public_get_Antialiasing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663716);
			PostProcessRenderContext.NativeMethodInfoPtr_set_antialiasing_Internal_set_Void_Antialiasing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663717);
			PostProcessRenderContext.NativeMethodInfoPtr_get_temporalAntialiasing_Public_get_TemporalAntialiasing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663718);
			PostProcessRenderContext.NativeMethodInfoPtr_set_temporalAntialiasing_Internal_set_Void_TemporalAntialiasing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663719);
			PostProcessRenderContext.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663720);
			PostProcessRenderContext.NativeMethodInfoPtr_IsTemporalAntialiasingActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663721);
			PostProcessRenderContext.NativeMethodInfoPtr_IsDebugOverlayEnabled_Public_Boolean_DebugOverlay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663722);
			PostProcessRenderContext.NativeMethodInfoPtr_PushDebugOverlay_Public_Void_CommandBuffer_RenderTargetIdentifier_PropertySheet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663723);
			PostProcessRenderContext.NativeMethodInfoPtr_GetDescriptor_Internal_RenderTextureDescriptor_Int32_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663724);
			PostProcessRenderContext.NativeMethodInfoPtr_GetScreenSpaceTemporaryRT_Public_Void_CommandBuffer_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_FilterMode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663725);
			PostProcessRenderContext.NativeMethodInfoPtr_GetScreenSpaceTemporaryRT_Public_RenderTexture_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663726);
			PostProcessRenderContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr, 100663727);
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x000138A4 File Offset: 0x00011AA4
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x000138E4 File Offset: 0x00011AE4
		public unsafe Camera camera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_camera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 448128, RefRangeEnd = 448129, XrefRangeStart = 448122, XrefRangeEnd = 448128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_camera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00013928 File Offset: 0x00011B28
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x00013968 File Offset: 0x00011B68
		public unsafe CommandBuffer command
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_command_Public_get_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_command_Public_set_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x000139AC File Offset: 0x00011BAC
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x000139E8 File Offset: 0x00011BE8
		public unsafe RenderTargetIdentifier source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_source_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_source_Public_set_Void_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00013A28 File Offset: 0x00011C28
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00013A64 File Offset: 0x00011C64
		public unsafe RenderTargetIdentifier destination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_destination_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_destination_Public_set_Void_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00013AA4 File Offset: 0x00011CA4
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00013AE0 File Offset: 0x00011CE0
		public unsafe RenderTextureFormat sourceFormat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_sourceFormat_Public_get_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_sourceFormat_Public_set_Void_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00013B20 File Offset: 0x00011D20
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00013B5C File Offset: 0x00011D5C
		public unsafe bool flip
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_flip_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_flip_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00013B9C File Offset: 0x00011D9C
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00013BDC File Offset: 0x00011DDC
		public unsafe PostProcessResources resources
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_resources_Public_get_PostProcessResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessResources>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_resources_Internal_set_Void_PostProcessResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00013C20 File Offset: 0x00011E20
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00013C60 File Offset: 0x00011E60
		public unsafe PropertySheetFactory propertySheets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_propertySheets_Public_get_PropertySheetFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertySheetFactory>(intPtr3) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 382561, RefRangeEnd = 382571, XrefRangeStart = 382561, XrefRangeEnd = 382571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_propertySheets_Internal_set_Void_PropertySheetFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00013CA4 File Offset: 0x00011EA4
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00013CE4 File Offset: 0x00011EE4
		public unsafe Dictionary<string, Object> userData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_userData_Public_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 161221, RefRangeEnd = 161228, XrefRangeStart = 161221, XrefRangeEnd = 161228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_userData_Private_set_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00013D28 File Offset: 0x00011F28
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00013D68 File Offset: 0x00011F68
		public unsafe PostProcessDebugLayer debugLayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_debugLayer_Public_get_PostProcessDebugLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessDebugLayer>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_debugLayer_Internal_set_Void_PostProcessDebugLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00013DAC File Offset: 0x00011FAC
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00013DE8 File Offset: 0x00011FE8
		public unsafe int width
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 381016, RefRangeEnd = 381017, XrefRangeStart = 381016, XrefRangeEnd = 381017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_width_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_width_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00013E28 File Offset: 0x00012028
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00013E64 File Offset: 0x00012064
		public unsafe int height
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89523, RefRangeEnd = 89524, XrefRangeStart = 89523, XrefRangeEnd = 89524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_height_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_height_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00013EA4 File Offset: 0x000120A4
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00013EE0 File Offset: 0x000120E0
		public unsafe bool stereoActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_stereoActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_stereoActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00013F20 File Offset: 0x00012120
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00013F5C File Offset: 0x0001215C
		public unsafe int xrActiveEye
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_xrActiveEye_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_xrActiveEye_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00013F9C File Offset: 0x0001219C
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00013FD8 File Offset: 0x000121D8
		public unsafe int numberOfEyes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_numberOfEyes_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_numberOfEyes_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00014018 File Offset: 0x00012218
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x00014054 File Offset: 0x00012254
		public unsafe PostProcessRenderContext.StereoRenderingMode stereoRenderingMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_stereoRenderingMode_Public_get_StereoRenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_stereoRenderingMode_Private_set_Void_StereoRenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00014094 File Offset: 0x00012294
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x000140D0 File Offset: 0x000122D0
		public unsafe int screenWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_screenWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_screenWidth_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00014110 File Offset: 0x00012310
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x0001414C File Offset: 0x0001234C
		public unsafe int screenHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_screenHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_screenHeight_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0001418C File Offset: 0x0001238C
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x000141C8 File Offset: 0x000123C8
		public unsafe bool isSceneView
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_isSceneView_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_isSceneView_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00014208 File Offset: 0x00012408
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00014244 File Offset: 0x00012444
		public unsafe PostProcessLayer.Antialiasing antialiasing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_antialiasing_Public_get_Antialiasing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_antialiasing_Internal_set_Void_Antialiasing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00014284 File Offset: 0x00012484
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x000142C4 File Offset: 0x000124C4
		public unsafe TemporalAntialiasing temporalAntialiasing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_get_temporalAntialiasing_Public_get_TemporalAntialiasing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TemporalAntialiasing>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 386301, RefRangeEnd = 386305, XrefRangeStart = 386301, XrefRangeEnd = 386305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_set_temporalAntialiasing_Internal_set_Void_TemporalAntialiasing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00014308 File Offset: 0x00012508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 448141, RefRangeEnd = 448142, XrefRangeStart = 448129, XrefRangeEnd = 448141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0001433C File Offset: 0x0001253C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 448143, RefRangeEnd = 448144, XrefRangeStart = 448142, XrefRangeEnd = 448143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTemporalAntialiasingActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_IsTemporalAntialiasingActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00014378 File Offset: 0x00012578
		[CallerCount(0)]
		public unsafe bool IsDebugOverlayEnabled(DebugOverlay overlay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overlay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_IsDebugOverlayEnabled_Public_Boolean_DebugOverlay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000143C4 File Offset: 0x000125C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448144, XrefRangeEnd = 448145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_PushDebugOverlay_Public_Void_CommandBuffer_RenderTargetIdentifier_PropertySheet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00014434 File Offset: 0x00012634
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 448156, RefRangeEnd = 448172, XrefRangeStart = 448145, XrefRangeEnd = 448156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depthBufferBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_GetDescriptor_Internal_RenderTextureDescriptor_Int32_RenderTextureFormat_RenderTextureReadWrite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0001449C File Offset: 0x0001269C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 448175, RefRangeEnd = 448180, XrefRangeStart = 448172, XrefRangeEnd = 448175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthOverride;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_GetScreenSpaceTemporaryRT_Public_Void_CommandBuffer_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_FilterMode_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00014540 File Offset: 0x00012740
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 448184, RefRangeEnd = 448188, XrefRangeStart = 448180, XrefRangeEnd = 448184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, int widthOverride = 0, int heightOverride = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depthBufferBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthOverride;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr_GetScreenSpaceTemporaryRT_Public_RenderTexture_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000145C4 File Offset: 0x000127C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessRenderContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessRenderContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessRenderContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00004430 File Offset: 0x00002630
		public PostProcessRenderContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00014600 File Offset: 0x00012800
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00004439 File Offset: 0x00002639
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00014630 File Offset: 0x00012830
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00004458 File Offset: 0x00002658
		public unsafe CommandBuffer _command_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__command_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__command_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00014660 File Offset: 0x00012860
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00004477 File Offset: 0x00002677
		public unsafe RenderTargetIdentifier _source_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__source_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__source_k__BackingField)) = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00014688 File Offset: 0x00012888
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00004492 File Offset: 0x00002692
		public unsafe RenderTargetIdentifier _destination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__destination_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__destination_k__BackingField)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x000146B0 File Offset: 0x000128B0
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x000044AD File Offset: 0x000026AD
		public unsafe RenderTextureFormat _sourceFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__sourceFormat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__sourceFormat_k__BackingField)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x000146D8 File Offset: 0x000128D8
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x000044C8 File Offset: 0x000026C8
		public unsafe bool _flip_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__flip_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__flip_k__BackingField)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00014700 File Offset: 0x00012900
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x000044E3 File Offset: 0x000026E3
		public unsafe PostProcessResources _resources_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__resources_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__resources_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00014730 File Offset: 0x00012930
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00004502 File Offset: 0x00002702
		public unsafe PropertySheetFactory _propertySheets_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__propertySheets_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySheetFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__propertySheets_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00014760 File Offset: 0x00012960
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00004521 File Offset: 0x00002721
		public unsafe Dictionary<string, Object> _userData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__userData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__userData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00014790 File Offset: 0x00012990
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00004540 File Offset: 0x00002740
		public unsafe PostProcessDebugLayer _debugLayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__debugLayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessDebugLayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__debugLayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x000147C0 File Offset: 0x000129C0
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0000455F File Offset: 0x0000275F
		public unsafe int _width_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__width_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__width_k__BackingField)) = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x000147E8 File Offset: 0x000129E8
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0000457A File Offset: 0x0000277A
		public unsafe int _height_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__height_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__height_k__BackingField)) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00014810 File Offset: 0x00012A10
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00004595 File Offset: 0x00002795
		public unsafe bool _stereoActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__stereoActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__stereoActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00014838 File Offset: 0x00012A38
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x000045B0 File Offset: 0x000027B0
		public unsafe int _xrActiveEye_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__xrActiveEye_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__xrActiveEye_k__BackingField)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00014860 File Offset: 0x00012A60
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x000045CB File Offset: 0x000027CB
		public unsafe int _numberOfEyes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__numberOfEyes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__numberOfEyes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00014888 File Offset: 0x00012A88
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x000045E6 File Offset: 0x000027E6
		public unsafe PostProcessRenderContext.StereoRenderingMode _stereoRenderingMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__stereoRenderingMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__stereoRenderingMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x000148B0 File Offset: 0x00012AB0
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00004601 File Offset: 0x00002801
		public unsafe int _screenWidth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__screenWidth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__screenWidth_k__BackingField)) = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x000148D8 File Offset: 0x00012AD8
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x0000461C File Offset: 0x0000281C
		public unsafe int _screenHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__screenHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__screenHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00014900 File Offset: 0x00012B00
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00004637 File Offset: 0x00002837
		public unsafe bool _isSceneView_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__isSceneView_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__isSceneView_k__BackingField)) = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00014928 File Offset: 0x00012B28
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00004652 File Offset: 0x00002852
		public unsafe PostProcessLayer.Antialiasing _antialiasing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__antialiasing_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__antialiasing_k__BackingField)) = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00014950 File Offset: 0x00012B50
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x0000466D File Offset: 0x0000286D
		public unsafe TemporalAntialiasing _temporalAntialiasing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__temporalAntialiasing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TemporalAntialiasing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr__temporalAntialiasing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00014980 File Offset: 0x00012B80
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x0000468C File Offset: 0x0000288C
		public unsafe PropertySheet uberSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_uberSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_uberSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x000149B0 File Offset: 0x00012BB0
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x000046AB File Offset: 0x000028AB
		public unsafe Texture autoExposureTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_autoExposureTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_autoExposureTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x000149E0 File Offset: 0x00012BE0
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x000046CA File Offset: 0x000028CA
		public unsafe LogHistogram logHistogram
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_logHistogram);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogHistogram>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_logHistogram), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00014A10 File Offset: 0x00012C10
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x000046E9 File Offset: 0x000028E9
		public unsafe Texture logLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_logLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_logLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00014A40 File Offset: 0x00012C40
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00004708 File Offset: 0x00002908
		public unsafe AutoExposure autoExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_autoExposure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoExposure>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_autoExposure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00014A70 File Offset: 0x00012C70
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00004727 File Offset: 0x00002927
		public unsafe int bloomBufferNameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_bloomBufferNameID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_bloomBufferNameID)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00014A98 File Offset: 0x00012C98
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00004742 File Offset: 0x00002942
		public unsafe bool physicalCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_physicalCamera);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_physicalCamera)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00014AC0 File Offset: 0x00012CC0
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x0000475D File Offset: 0x0000295D
		public unsafe RenderTextureDescriptor m_sourceDescriptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_m_sourceDescriptor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessRenderContext.NativeFieldInfoPtr_m_sourceDescriptor)) = value;
			}
		}

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr__command_k__BackingField;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeFieldInfoPtr__source_k__BackingField;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr__destination_k__BackingField;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeFieldInfoPtr__sourceFormat_k__BackingField;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr__flip_k__BackingField;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr__resources_k__BackingField;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr__propertySheets_k__BackingField;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr__userData_k__BackingField;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr__debugLayer_k__BackingField;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr__width_k__BackingField;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr__height_k__BackingField;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr__stereoActive_k__BackingField;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr__xrActiveEye_k__BackingField;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr__numberOfEyes_k__BackingField;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr__stereoRenderingMode_k__BackingField;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr__screenWidth_k__BackingField;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr__screenHeight_k__BackingField;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr__isSceneView_k__BackingField;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr__antialiasing_k__BackingField;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr__temporalAntialiasing_k__BackingField;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_uberSheet;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_autoExposureTexture;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_logHistogram;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_logLut;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_autoExposure;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_bloomBufferNameID;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_physicalCamera;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_m_sourceDescriptor;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_get_camera_Public_get_Camera_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_set_camera_Public_set_Void_Camera_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_get_command_Public_get_CommandBuffer_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_set_command_Public_set_Void_CommandBuffer_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_get_source_Public_get_RenderTargetIdentifier_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_set_source_Public_set_Void_RenderTargetIdentifier_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_get_destination_Public_get_RenderTargetIdentifier_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_set_destination_Public_set_Void_RenderTargetIdentifier_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceFormat_Public_get_RenderTextureFormat_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_set_sourceFormat_Public_set_Void_RenderTextureFormat_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_get_flip_Public_get_Boolean_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_set_flip_Public_set_Void_Boolean_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_get_resources_Public_get_PostProcessResources_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_set_resources_Internal_set_Void_PostProcessResources_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_get_propertySheets_Public_get_PropertySheetFactory_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_set_propertySheets_Internal_set_Void_PropertySheetFactory_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_get_userData_Public_get_Dictionary_2_String_Object_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_set_userData_Private_set_Void_Dictionary_2_String_Object_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_get_debugLayer_Public_get_PostProcessDebugLayer_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_set_debugLayer_Internal_set_Void_PostProcessDebugLayer_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Private_set_Void_Int32_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Private_set_Void_Int32_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoActive_Public_get_Boolean_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoActive_Private_set_Void_Boolean_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_get_xrActiveEye_Public_get_Int32_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_set_xrActiveEye_Private_set_Void_Int32_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_get_numberOfEyes_Public_get_Int32_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_set_numberOfEyes_Private_set_Void_Int32_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoRenderingMode_Public_get_StereoRenderingMode_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoRenderingMode_Private_set_Void_StereoRenderingMode_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_get_screenWidth_Public_get_Int32_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_set_screenWidth_Private_set_Void_Int32_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_get_screenHeight_Public_get_Int32_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_set_screenHeight_Private_set_Void_Int32_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_get_isSceneView_Public_get_Boolean_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_set_isSceneView_Internal_set_Void_Boolean_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_get_antialiasing_Public_get_Antialiasing_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_set_antialiasing_Internal_set_Void_Antialiasing_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_get_temporalAntialiasing_Public_get_TemporalAntialiasing_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_set_temporalAntialiasing_Internal_set_Void_TemporalAntialiasing_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_IsTemporalAntialiasingActive_Public_Boolean_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_IsDebugOverlayEnabled_Public_Boolean_DebugOverlay_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_PushDebugOverlay_Public_Void_CommandBuffer_RenderTargetIdentifier_PropertySheet_Int32_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptor_Internal_RenderTextureDescriptor_Int32_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenSpaceTemporaryRT_Public_Void_CommandBuffer_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_FilterMode_Int32_Int32_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenSpaceTemporaryRT_Public_RenderTexture_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_Int32_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200008D RID: 141
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "StereoRenderingMode")]
		public enum StereoRenderingMode
		{
			// Token: 0x040004F6 RID: 1270
			MultiPass,
			// Token: 0x040004F7 RID: 1271
			SinglePass,
			// Token: 0x040004F8 RID: 1272
			SinglePassInstanced,
			// Token: 0x040004F9 RID: 1273
			SinglePassMultiview
		}
	}
}
