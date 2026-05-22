using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000049 RID: 73
	public sealed class Camera : Behaviour
	{
		// Token: 0x06000298 RID: 664 RVA: 0x0001B6B4 File Offset: 0x000198B4
		// Note: this type is marked as 'beforefieldinit'.
		static Camera()
		{
			Il2CppClassPointerStore<Camera>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Camera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Camera>.NativeClassPtr);
			Camera.NativeFieldInfoPtr_onPreCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPreCull");
			Camera.NativeFieldInfoPtr_onPreRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPreRender");
			Camera.NativeFieldInfoPtr_onPostRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPostRender");
			Camera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663481);
			Camera.NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663482);
			Camera.NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663483);
			Camera.NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663484);
			Camera.NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663485);
			Camera.NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663486);
			Camera.NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663487);
			Camera.NativeMethodInfoPtr_set_renderingPath_Public_set_Void_RenderingPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663488);
			Camera.NativeMethodInfoPtr_get_actualRenderingPath_Public_get_RenderingPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663489);
			Camera.NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663490);
			Camera.NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663491);
			Camera.NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663492);
			Camera.NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663493);
			Camera.NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663494);
			Camera.NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663495);
			Camera.NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663496);
			Camera.NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663497);
			Camera.NativeMethodInfoPtr_get_depth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663498);
			Camera.NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663499);
			Camera.NativeMethodInfoPtr_get_aspect_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663500);
			Camera.NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663501);
			Camera.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663502);
			Camera.NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663503);
			Camera.NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663504);
			Camera.NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663505);
			Camera.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663506);
			Camera.NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663507);
			Camera.NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663508);
			Camera.NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663509);
			Camera.NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663510);
			Camera.NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663511);
			Camera.NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663512);
			Camera.NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663513);
			Camera.NativeMethodInfoPtr_set_usePhysicalProperties_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663514);
			Camera.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663515);
			Camera.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663516);
			Camera.NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663517);
			Camera.NativeMethodInfoPtr_set_pixelRect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663518);
			Camera.NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663519);
			Camera.NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663520);
			Camera.NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663521);
			Camera.NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663522);
			Camera.NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663523);
			Camera.NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663524);
			Camera.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663525);
			Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663526);
			Camera.NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663527);
			Camera.NativeMethodInfoPtr_set_projectionMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663528);
			Camera.NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663529);
			Camera.NativeMethodInfoPtr_set_useJitteredProjectionMatrixForTransparentRendering_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663530);
			Camera.NativeMethodInfoPtr_ResetProjectionMatrix_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663531);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663532);
			Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663533);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663534);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663535);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663536);
			Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663537);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663538);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663539);
			Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663540);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663541);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663542);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663543);
			Camera.NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663544);
			Camera.NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663545);
			Camera.NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663546);
			Camera.NativeMethodInfoPtr_get_stereoTargetEye_Public_get_StereoTargetEyeMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663547);
			Camera.NativeMethodInfoPtr_get_stereoActiveEye_Public_get_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663548);
			Camera.NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Public_Matrix4x4_StereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663549);
			Camera.NativeMethodInfoPtr_CopyStereoDeviceProjectionMatrixToNonJittered_Public_Void_StereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663550);
			Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663551);
			Camera.NativeMethodInfoPtr_ResetStereoProjectionMatrices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663552);
			Camera.NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663553);
			Camera.NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663554);
			Camera.NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663555);
			Camera.NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663556);
			Camera.NativeMethodInfoPtr_Render_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663557);
			Camera.NativeMethodInfoPtr_AddCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663558);
			Camera.NativeMethodInfoPtr_RemoveCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663559);
			Camera.NativeMethodInfoPtr_AddCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663560);
			Camera.NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663561);
			Camera.NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663562);
			Camera.NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663563);
			Camera.NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663564);
			Camera.NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663565);
			Camera.NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663566);
			Camera.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663567);
			Camera.NativeMethodInfoPtr_set_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663568);
			Camera.NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663569);
			Camera.NativeMethodInfoPtr_set_pixelRect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663570);
			Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663571);
			Camera.NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663572);
			Camera.NativeMethodInfoPtr_set_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663573);
			Camera.NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663574);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663575);
			Camera.NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663576);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663577);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663578);
			Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663579);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663580);
			Camera.NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663581);
			Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663582);
			Camera.get_renderingPathDelegateField = IL2CPP.ResolveICall<Camera.get_renderingPathDelegate>("UnityEngine.Camera::get_renderingPath");
			Camera.ResetDelegateField = IL2CPP.ResolveICall<Camera.ResetDelegate>("UnityEngine.Camera::Reset");
			Camera.get_allowMSAADelegateField = IL2CPP.ResolveICall<Camera.get_allowMSAADelegate>("UnityEngine.Camera::get_allowMSAA");
			Camera.set_allowDynamicResolutionDelegateField = IL2CPP.ResolveICall<Camera.set_allowDynamicResolutionDelegate>("UnityEngine.Camera::set_allowDynamicResolution");
			Camera.get_forceIntoRenderTextureDelegateField = IL2CPP.ResolveICall<Camera.get_forceIntoRenderTextureDelegate>("UnityEngine.Camera::get_forceIntoRenderTexture");
			Camera.set_forceIntoRenderTextureDelegateField = IL2CPP.ResolveICall<Camera.set_forceIntoRenderTextureDelegate>("UnityEngine.Camera::set_forceIntoRenderTexture");
			Camera.get_opaqueSortModeDelegateField = IL2CPP.ResolveICall<Camera.get_opaqueSortModeDelegate>("UnityEngine.Camera::get_opaqueSortMode");
			Camera.set_opaqueSortModeDelegateField = IL2CPP.ResolveICall<Camera.set_opaqueSortModeDelegate>("UnityEngine.Camera::set_opaqueSortMode");
			Camera.get_transparencySortModeDelegateField = IL2CPP.ResolveICall<Camera.get_transparencySortModeDelegate>("UnityEngine.Camera::get_transparencySortMode");
			Camera.set_transparencySortModeDelegateField = IL2CPP.ResolveICall<Camera.set_transparencySortModeDelegate>("UnityEngine.Camera::set_transparencySortMode");
			Camera.ResetTransparencySortSettingsDelegateField = IL2CPP.ResolveICall<Camera.ResetTransparencySortSettingsDelegate>("UnityEngine.Camera::ResetTransparencySortSettings");
			Camera.ResetAspectDelegateField = IL2CPP.ResolveICall<Camera.ResetAspectDelegate>("UnityEngine.Camera::ResetAspect");
			Camera.set_eventMaskDelegateField = IL2CPP.ResolveICall<Camera.set_eventMaskDelegate>("UnityEngine.Camera::set_eventMask");
			Camera.get_layerCullSphericalDelegateField = IL2CPP.ResolveICall<Camera.get_layerCullSphericalDelegate>("UnityEngine.Camera::get_layerCullSpherical");
			Camera.set_layerCullSphericalDelegateField = IL2CPP.ResolveICall<Camera.set_layerCullSphericalDelegate>("UnityEngine.Camera::set_layerCullSpherical");
			Camera.set_cameraTypeDelegateField = IL2CPP.ResolveICall<Camera.set_cameraTypeDelegate>("UnityEngine.Camera::set_cameraType");
			Camera.get_overrideSceneCullingMaskDelegateField = IL2CPP.ResolveICall<Camera.get_overrideSceneCullingMaskDelegate>("UnityEngine.Camera::get_overrideSceneCullingMask");
			Camera.set_overrideSceneCullingMaskDelegateField = IL2CPP.ResolveICall<Camera.set_overrideSceneCullingMaskDelegate>("UnityEngine.Camera::set_overrideSceneCullingMask");
			Camera.get_sceneCullingMaskDelegateField = IL2CPP.ResolveICall<Camera.get_sceneCullingMaskDelegate>("UnityEngine.Camera::get_sceneCullingMask");
			Camera.GetLayerCullDistancesDelegateField = IL2CPP.ResolveICall<Camera.GetLayerCullDistancesDelegate>("UnityEngine.Camera::GetLayerCullDistances");
			Camera.SetLayerCullDistancesDelegateField = IL2CPP.ResolveICall<Camera.SetLayerCullDistancesDelegate>("UnityEngine.Camera::SetLayerCullDistances");
			Camera.get_PreviewCullingLayerDelegateField = IL2CPP.ResolveICall<Camera.get_PreviewCullingLayerDelegate>("UnityEngine.Camera::get_PreviewCullingLayer");
			Camera.get_useOcclusionCullingDelegateField = IL2CPP.ResolveICall<Camera.get_useOcclusionCullingDelegate>("UnityEngine.Camera::get_useOcclusionCulling");
			Camera.ResetCullingMatrixDelegateField = IL2CPP.ResolveICall<Camera.ResetCullingMatrixDelegate>("UnityEngine.Camera::ResetCullingMatrix");
			Camera.get_clearStencilAfterLightingPassDelegateField = IL2CPP.ResolveICall<Camera.get_clearStencilAfterLightingPassDelegate>("UnityEngine.Camera::get_clearStencilAfterLightingPass");
			Camera.set_clearStencilAfterLightingPassDelegateField = IL2CPP.ResolveICall<Camera.set_clearStencilAfterLightingPassDelegate>("UnityEngine.Camera::set_clearStencilAfterLightingPass");
			Camera.SetReplacementShaderDelegateField = IL2CPP.ResolveICall<Camera.SetReplacementShaderDelegate>("UnityEngine.Camera::SetReplacementShader");
			Camera.ResetReplacementShaderDelegateField = IL2CPP.ResolveICall<Camera.ResetReplacementShaderDelegate>("UnityEngine.Camera::ResetReplacementShader");
			Camera.get_projectionMatrixModeDelegateField = IL2CPP.ResolveICall<Camera.get_projectionMatrixModeDelegate>("UnityEngine.Camera::get_projectionMatrixMode");
			Camera.get_focalLengthDelegateField = IL2CPP.ResolveICall<Camera.get_focalLengthDelegate>("UnityEngine.Camera::get_focalLength");
			Camera.set_focalLengthDelegateField = IL2CPP.ResolveICall<Camera.set_focalLengthDelegate>("UnityEngine.Camera::set_focalLength");
			Camera.get_gateFitDelegateField = IL2CPP.ResolveICall<Camera.get_gateFitDelegate>("UnityEngine.Camera::get_gateFit");
			Camera.set_gateFitDelegateField = IL2CPP.ResolveICall<Camera.set_gateFitDelegate>("UnityEngine.Camera::set_gateFit");
			Camera.GetGateFittedFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.GetGateFittedFieldOfViewDelegate>("UnityEngine.Camera::GetGateFittedFieldOfView");
			Camera.get_activeTextureDelegateField = IL2CPP.ResolveICall<Camera.get_activeTextureDelegate>("UnityEngine.Camera::get_activeTexture");
			Camera.set_targetDisplayDelegateField = IL2CPP.ResolveICall<Camera.set_targetDisplayDelegate>("UnityEngine.Camera::set_targetDisplay");
			Camera.GetCameraBufferWarningsDelegateField = IL2CPP.ResolveICall<Camera.GetCameraBufferWarningsDelegate>("UnityEngine.Camera::GetCameraBufferWarnings");
			Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegateField = IL2CPP.ResolveICall<Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegate>("UnityEngine.Camera::get_useJitteredProjectionMatrixForTransparentRendering");
			Camera.ResetWorldToCameraMatrixDelegateField = IL2CPP.ResolveICall<Camera.ResetWorldToCameraMatrixDelegate>("UnityEngine.Camera::ResetWorldToCameraMatrix");
			Camera.FocalLengthToFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.FocalLengthToFieldOfViewDelegate>("UnityEngine.Camera::FocalLengthToFieldOfView");
			Camera.FieldOfViewToFocalLengthDelegateField = IL2CPP.ResolveICall<Camera.FieldOfViewToFocalLengthDelegate>("UnityEngine.Camera::FieldOfViewToFocalLength");
			Camera.HorizontalToVerticalFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.HorizontalToVerticalFieldOfViewDelegate>("UnityEngine.Camera::HorizontalToVerticalFieldOfView");
			Camera.VerticalToHorizontalFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.VerticalToHorizontalFieldOfViewDelegate>("UnityEngine.Camera::VerticalToHorizontalFieldOfView");
			Camera.get_stereoSeparationDelegateField = IL2CPP.ResolveICall<Camera.get_stereoSeparationDelegate>("UnityEngine.Camera::get_stereoSeparation");
			Camera.set_stereoSeparationDelegateField = IL2CPP.ResolveICall<Camera.set_stereoSeparationDelegate>("UnityEngine.Camera::set_stereoSeparation");
			Camera.get_stereoConvergenceDelegateField = IL2CPP.ResolveICall<Camera.get_stereoConvergenceDelegate>("UnityEngine.Camera::get_stereoConvergence");
			Camera.set_stereoConvergenceDelegateField = IL2CPP.ResolveICall<Camera.set_stereoConvergenceDelegate>("UnityEngine.Camera::set_stereoConvergence");
			Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegateField = IL2CPP.ResolveICall<Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegate>("UnityEngine.Camera::get_areVRStereoViewMatricesWithinSingleCullTolerance");
			Camera.set_stereoTargetEyeDelegateField = IL2CPP.ResolveICall<Camera.set_stereoTargetEyeDelegate>("UnityEngine.Camera::set_stereoTargetEye");
			Camera.ResetStereoViewMatricesDelegateField = IL2CPP.ResolveICall<Camera.ResetStereoViewMatricesDelegate>("UnityEngine.Camera::ResetStereoViewMatrices");
			Camera.RenderToCubemapImplDelegateField = IL2CPP.ResolveICall<Camera.RenderToCubemapImplDelegate>("UnityEngine.Camera::RenderToCubemapImpl");
			Camera.RenderToCubemapEyeImplDelegateField = IL2CPP.ResolveICall<Camera.RenderToCubemapEyeImplDelegate>("UnityEngine.Camera::RenderToCubemapEyeImpl");
			Camera.RenderWithShaderDelegateField = IL2CPP.ResolveICall<Camera.RenderWithShaderDelegate>("UnityEngine.Camera::RenderWithShader");
			Camera.RenderDontRestoreDelegateField = IL2CPP.ResolveICall<Camera.RenderDontRestoreDelegate>("UnityEngine.Camera::RenderDontRestore");
			Camera.SubmitRenderRequestsInternalDelegateField = IL2CPP.ResolveICall<Camera.SubmitRenderRequestsInternalDelegate>("UnityEngine.Camera::SubmitRenderRequestsInternal");
			Camera.SetupCurrentDelegateField = IL2CPP.ResolveICall<Camera.SetupCurrentDelegate>("UnityEngine.Camera::SetupCurrent");
			Camera.CopyFromDelegateField = IL2CPP.ResolveICall<Camera.CopyFromDelegate>("UnityEngine.Camera::CopyFrom");
			Camera.get_commandBufferCountDelegateField = IL2CPP.ResolveICall<Camera.get_commandBufferCountDelegate>("UnityEngine.Camera::get_commandBufferCount");
			Camera.RemoveCommandBuffersDelegateField = IL2CPP.ResolveICall<Camera.RemoveCommandBuffersDelegate>("UnityEngine.Camera::RemoveCommandBuffers");
			Camera.RemoveAllCommandBuffersDelegateField = IL2CPP.ResolveICall<Camera.RemoveAllCommandBuffersDelegate>("UnityEngine.Camera::RemoveAllCommandBuffers");
			Camera.AddCommandBufferAsyncImplDelegateField = IL2CPP.ResolveICall<Camera.AddCommandBufferAsyncImplDelegate>("UnityEngine.Camera::AddCommandBufferAsyncImpl");
			Camera.GetCommandBuffersDelegateField = IL2CPP.ResolveICall<Camera.GetCommandBuffersDelegate>("UnityEngine.Camera::GetCommandBuffers");
			Camera.get_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_transparencySortAxis_InjectedDelegate>("UnityEngine.Camera::get_transparencySortAxis_Injected");
			Camera.set_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_transparencySortAxis_InjectedDelegate>("UnityEngine.Camera::set_transparencySortAxis_Injected");
			Camera.get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_velocity_InjectedDelegate>("UnityEngine.Camera::get_velocity_Injected");
			Camera.get_cullingMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_cullingMatrix_InjectedDelegate>("UnityEngine.Camera::get_cullingMatrix_Injected");
			Camera.set_cullingMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_cullingMatrix_InjectedDelegate>("UnityEngine.Camera::set_cullingMatrix_Injected");
			Camera.get_sensorSize_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_sensorSize_InjectedDelegate>("UnityEngine.Camera::get_sensorSize_Injected");
			Camera.set_sensorSize_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_sensorSize_InjectedDelegate>("UnityEngine.Camera::set_sensorSize_Injected");
			Camera.get_lensShift_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_lensShift_InjectedDelegate>("UnityEngine.Camera::get_lensShift_Injected");
			Camera.set_lensShift_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_lensShift_InjectedDelegate>("UnityEngine.Camera::set_lensShift_Injected");
			Camera.GetGateFittedLensShift_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetGateFittedLensShift_InjectedDelegate>("UnityEngine.Camera::GetGateFittedLensShift_Injected");
			Camera.GetLocalSpaceAim_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetLocalSpaceAim_InjectedDelegate>("UnityEngine.Camera::GetLocalSpaceAim_Injected");
			Camera.SetTargetBuffersImpl_InjectedDelegateField = IL2CPP.ResolveICall<Camera.SetTargetBuffersImpl_InjectedDelegate>("UnityEngine.Camera::SetTargetBuffersImpl_Injected");
			Camera.SetTargetBuffersMRTImpl_InjectedDelegateField = IL2CPP.ResolveICall<Camera.SetTargetBuffersMRTImpl_InjectedDelegate>("UnityEngine.Camera::SetTargetBuffersMRTImpl_Injected");
			Camera.get_cameraToWorldMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_cameraToWorldMatrix_InjectedDelegate>("UnityEngine.Camera::get_cameraToWorldMatrix_Injected");
			Camera.set_worldToCameraMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_worldToCameraMatrix_InjectedDelegate>("UnityEngine.Camera::set_worldToCameraMatrix_Injected");
			Camera.get_nonJitteredProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_nonJitteredProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::get_nonJitteredProjectionMatrix_Injected");
			Camera.get_previousViewProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_previousViewProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::get_previousViewProjectionMatrix_Injected");
			Camera.CalculateObliqueMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.CalculateObliqueMatrix_InjectedDelegate>("UnityEngine.Camera::CalculateObliqueMatrix_Injected");
			Camera.ViewportToScreenPoint_InjectedDelegateField = IL2CPP.ResolveICall<Camera.ViewportToScreenPoint_InjectedDelegate>("UnityEngine.Camera::ViewportToScreenPoint_Injected");
			Camera.GetFrustumPlaneSizeAt_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetFrustumPlaneSizeAt_InjectedDelegate>("UnityEngine.Camera::GetFrustumPlaneSizeAt_Injected");
			Camera.ViewportPointToRay_InjectedDelegateField = IL2CPP.ResolveICall<Camera.ViewportPointToRay_InjectedDelegate>("UnityEngine.Camera::ViewportPointToRay_Injected");
			Camera.CalculateFrustumCornersInternal_InjectedDelegateField = IL2CPP.ResolveICall<Camera.CalculateFrustumCornersInternal_InjectedDelegate>("UnityEngine.Camera::CalculateFrustumCornersInternal_Injected");
			Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField = IL2CPP.ResolveICall<Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate>("UnityEngine.Camera::CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected");
			Camera.get_scene_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_scene_InjectedDelegate>("UnityEngine.Camera::get_scene_Injected");
			Camera.set_scene_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_scene_InjectedDelegate>("UnityEngine.Camera::set_scene_Injected");
			Camera.GetStereoViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetStereoViewMatrix_InjectedDelegate>("UnityEngine.Camera::GetStereoViewMatrix_Injected");
			Camera.GetStereoProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetStereoProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::GetStereoProjectionMatrix_Injected");
			Camera.SetStereoViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.SetStereoViewMatrix_InjectedDelegate>("UnityEngine.Camera::SetStereoViewMatrix_Injected");
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001C460 File Offset: 0x0001A660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Camera()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0001C49C File Offset: 0x0001A69C
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0001C4D8 File Offset: 0x0001A6D8
		public unsafe float nearClipPlane
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 486248, RefRangeEnd = 486252, XrefRangeStart = 486244, XrefRangeEnd = 486248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 486256, RefRangeEnd = 486257, XrefRangeStart = 486252, XrefRangeEnd = 486256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0001C518 File Offset: 0x0001A718
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0001C554 File Offset: 0x0001A754
		public unsafe float farClipPlane
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 486261, RefRangeEnd = 486265, XrefRangeStart = 486257, XrefRangeEnd = 486261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 486269, RefRangeEnd = 486270, XrefRangeStart = 486265, XrefRangeEnd = 486269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0001C594 File Offset: 0x0001A794
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0001C5D0 File Offset: 0x0001A7D0
		public unsafe float fieldOfView
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486270, XrefRangeEnd = 486274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486274, XrefRangeEnd = 486278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000375E File Offset: 0x0000195E
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0001C610 File Offset: 0x0001A810
		public unsafe RenderingPath renderingPath
		{
			get
			{
				return Camera.get_renderingPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486278, XrefRangeEnd = 486282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_renderingPath_Public_set_Void_RenderingPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0001C650 File Offset: 0x0001A850
		public unsafe RenderingPath actualRenderingPath
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 486286, RefRangeEnd = 486287, XrefRangeStart = 486282, XrefRangeEnd = 486286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_actualRenderingPath_Public_get_RenderingPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0001C68C File Offset: 0x0001A88C
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0001C6C8 File Offset: 0x0001A8C8
		public unsafe bool allowHDR
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486287, XrefRangeEnd = 486291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 486295, RefRangeEnd = 486296, XrefRangeStart = 486291, XrefRangeEnd = 486295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00003782 File Offset: 0x00001982
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0001C708 File Offset: 0x0001A908
		public unsafe bool allowMSAA
		{
			get
			{
				return Camera.get_allowMSAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486296, XrefRangeEnd = 486300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0001C748 File Offset: 0x0001A948
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00003794 File Offset: 0x00001994
		public unsafe bool allowDynamicResolution
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486300, XrefRangeEnd = 486304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_allowDynamicResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0001C784 File Offset: 0x0001A984
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x0001C7C0 File Offset: 0x0001A9C0
		public unsafe float orthographicSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 486308, RefRangeEnd = 486309, XrefRangeStart = 486304, XrefRangeEnd = 486308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 486313, RefRangeEnd = 486323, XrefRangeStart = 486309, XrefRangeEnd = 486313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0001C800 File Offset: 0x0001AA00
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x0001C83C File Offset: 0x0001AA3C
		public unsafe bool orthographic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486323, XrefRangeEnd = 486327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486327, XrefRangeEnd = 486331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0001C87C File Offset: 0x0001AA7C
		// (set) Token: 0x060002AB RID: 683 RVA: 0x0001C8B8 File Offset: 0x0001AAB8
		public unsafe float depth
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 486335, RefRangeEnd = 486341, XrefRangeStart = 486331, XrefRangeEnd = 486335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_depth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 486345, RefRangeEnd = 486346, XrefRangeStart = 486341, XrefRangeEnd = 486345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0001C8F8 File Offset: 0x0001AAF8
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0001C934 File Offset: 0x0001AB34
		public unsafe float aspect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486346, XrefRangeEnd = 486350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_aspect_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486350, XrefRangeEnd = 486354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0001C974 File Offset: 0x0001AB74
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
		public unsafe int cullingMask
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 486358, RefRangeEnd = 486360, XrefRangeStart = 486354, XrefRangeEnd = 486358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486360, XrefRangeEnd = 486364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0001C9F0 File Offset: 0x0001ABF0
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00003844 File Offset: 0x00001A44
		public unsafe int eventMask
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 486368, RefRangeEnd = 486371, XrefRangeStart = 486364, XrefRangeEnd = 486368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_eventMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0001CA2C File Offset: 0x0001AC2C
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0000387C File Offset: 0x00001A7C
		public unsafe CameraType cameraType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486371, XrefRangeEnd = 486375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_cameraTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000321 RID: 801 RVA: 0x000038EA File Offset: 0x00001AEA
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x0001CA68 File Offset: 0x0001AC68
		public unsafe bool useOcclusionCulling
		{
			get
			{
				return Camera.get_useOcclusionCullingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 486379, RefRangeEnd = 486380, XrefRangeStart = 486375, XrefRangeEnd = 486379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0001CAA8 File Offset: 0x0001ACA8
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
		public unsafe Color backgroundColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486380, XrefRangeEnd = 486382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486382, XrefRangeEnd = 486384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0001CB24 File Offset: 0x0001AD24
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0001CB60 File Offset: 0x0001AD60
		public unsafe CameraClearFlags clearFlags
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 486388, RefRangeEnd = 486392, XrefRangeStart = 486384, XrefRangeEnd = 486388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 486396, RefRangeEnd = 486397, XrefRangeStart = 486392, XrefRangeEnd = 486396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0001CBA0 File Offset: 0x0001ADA0
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x0001CBDC File Offset: 0x0001ADDC
		public unsafe DepthTextureMode depthTextureMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486397, XrefRangeEnd = 486401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486401, XrefRangeEnd = 486405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0001CC1C File Offset: 0x0001AE1C
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0001CC58 File Offset: 0x0001AE58
		public unsafe bool usePhysicalProperties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486405, XrefRangeEnd = 486409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486409, XrefRangeEnd = 486413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_usePhysicalProperties_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0001CC98 File Offset: 0x0001AE98
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0001CCD4 File Offset: 0x0001AED4
		public unsafe Rect rect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486413, XrefRangeEnd = 486415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486415, XrefRangeEnd = 486417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0001CD14 File Offset: 0x0001AF14
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0001CD50 File Offset: 0x0001AF50
		public unsafe Rect pixelRect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486417, XrefRangeEnd = 486419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486419, XrefRangeEnd = 486421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_pixelRect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0001CD90 File Offset: 0x0001AF90
		public unsafe int pixelWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486421, XrefRangeEnd = 486425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0001CDCC File Offset: 0x0001AFCC
		public unsafe int pixelHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486425, XrefRangeEnd = 486429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0001CE08 File Offset: 0x0001B008
		public unsafe int scaledPixelWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486429, XrefRangeEnd = 486433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0001CE44 File Offset: 0x0001B044
		public unsafe int scaledPixelHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486433, XrefRangeEnd = 486437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0001CE80 File Offset: 0x0001B080
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
		public unsafe RenderTexture targetTexture
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 486441, RefRangeEnd = 486446, XrefRangeStart = 486437, XrefRangeEnd = 486441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 486450, RefRangeEnd = 486459, XrefRangeStart = 486446, XrefRangeEnd = 486450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0001CF04 File Offset: 0x0001B104
		// (set) Token: 0x06000336 RID: 822 RVA: 0x000039EF File Offset: 0x00001BEF
		public unsafe int targetDisplay
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 486463, RefRangeEnd = 486465, XrefRangeStart = 486459, XrefRangeEnd = 486463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_targetDisplayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0001CF40 File Offset: 0x0001B140
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00003A31 File Offset: 0x00001C31
		public unsafe Matrix4x4 worldToCameraMatrix
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 486467, RefRangeEnd = 486469, XrefRangeStart = 486465, XrefRangeEnd = 486467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_worldToCameraMatrix_Injected(ref value);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0001CF7C File Offset: 0x0001B17C
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x0001CFB8 File Offset: 0x0001B1B8
		public unsafe Matrix4x4 projectionMatrix
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 486471, RefRangeEnd = 486472, XrefRangeStart = 486469, XrefRangeEnd = 486471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486472, XrefRangeEnd = 486474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_projectionMatrix_Public_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0001E0F8 File Offset: 0x0001C2F8
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
		public unsafe Matrix4x4 nonJitteredProjectionMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_nonJitteredProjectionMatrix_Injected(out matrix4x);
				return matrix4x;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486474, XrefRangeEnd = 486476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Public_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00003A3B File Offset: 0x00001C3B
		// (set) Token: 0x060002CA RID: 714 RVA: 0x0001D038 File Offset: 0x0001B238
		public unsafe bool useJitteredProjectionMatrixForTransparentRendering
		{
			get
			{
				return Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486476, XrefRangeEnd = 486480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_useJitteredProjectionMatrixForTransparentRendering_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0001D078 File Offset: 0x0001B278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486484, RefRangeEnd = 486485, XrefRangeStart = 486480, XrefRangeEnd = 486484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetProjectionMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ResetProjectionMatrix_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0001D0AC File Offset: 0x0001B2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486485, XrefRangeEnd = 486487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0001D104 File Offset: 0x0001B304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486487, XrefRangeEnd = 486489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0001D15C File Offset: 0x0001B35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486489, XrefRangeEnd = 486491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0001D1B4 File Offset: 0x0001B3B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486493, RefRangeEnd = 486494, XrefRangeStart = 486491, XrefRangeEnd = 486493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0001D20C File Offset: 0x0001B40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486494, XrefRangeEnd = 486496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToScreenPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0001D258 File Offset: 0x0001B458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486496, XrefRangeEnd = 486498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToViewportPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001D2A4 File Offset: 0x0001B4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486498, XrefRangeEnd = 486500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ViewportToWorldPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0001D2F0 File Offset: 0x0001B4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486500, XrefRangeEnd = 486502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToWorldPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0001D33C File Offset: 0x0001B53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486502, XrefRangeEnd = 486504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToViewportPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0001D388 File Offset: 0x0001B588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486504, XrefRangeEnd = 486506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0001D3E0 File Offset: 0x0001B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486506, XrefRangeEnd = 486508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0001D438 File Offset: 0x0001B638
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 486510, RefRangeEnd = 486513, XrefRangeStart = 486508, XrefRangeEnd = 486510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0001D484 File Offset: 0x0001B684
		public unsafe static Camera main
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 486517, RefRangeEnd = 486520, XrefRangeStart = 486513, XrefRangeEnd = 486517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0001D4B8 File Offset: 0x0001B6B8
		public unsafe static Camera current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486520, XrefRangeEnd = 486524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0001D4EC File Offset: 0x0001B6EC
		public unsafe bool stereoEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486524, XrefRangeEnd = 486528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0001D528 File Offset: 0x0001B728
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00003B20 File Offset: 0x00001D20
		public unsafe StereoTargetEyeMask stereoTargetEye
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486528, XrefRangeEnd = 486532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_stereoTargetEye_Public_get_StereoTargetEyeMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_stereoTargetEyeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0001D564 File Offset: 0x0001B764
		public unsafe Camera.MonoOrStereoscopicEye stereoActiveEye
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 486536, RefRangeEnd = 486538, XrefRangeStart = 486532, XrefRangeEnd = 486536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_stereoActiveEye_Public_get_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486538, XrefRangeEnd = 486540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Public_Matrix4x4_StereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0001D5EC File Offset: 0x0001B7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486540, XrefRangeEnd = 486544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CopyStereoDeviceProjectionMatrixToNonJittered_Public_Void_StereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0001D62C File Offset: 0x0001B82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486544, XrefRangeEnd = 486546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001D678 File Offset: 0x0001B878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486550, RefRangeEnd = 486551, XrefRangeStart = 486546, XrefRangeEnd = 486550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetStereoProjectionMatrices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ResetStereoProjectionMatrices_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001D6AC File Offset: 0x0001B8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486551, XrefRangeEnd = 486555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCamerasCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0001D6DC File Offset: 0x0001B8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486555, XrefRangeEnd = 486559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCamerasImpl([Out] Il2CppReferenceArray<Camera> cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*cam = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Camera>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0001D730 File Offset: 0x0001B930
		public unsafe static int allCamerasCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0001D760 File Offset: 0x0001B960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486559, XrefRangeEnd = 486578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCameras(Il2CppReferenceArray<Camera> cameras)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameras);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0001D7A4 File Offset: 0x0001B9A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 486582, RefRangeEnd = 486584, XrefRangeStart = 486578, XrefRangeEnd = 486582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_Render_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486584, XrefRangeEnd = 486588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_AddCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001D828 File Offset: 0x0001BA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486588, XrefRangeEnd = 486592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RemoveCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0001D878 File Offset: 0x0001BA78
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 486612, RefRangeEnd = 486617, XrefRangeStart = 486592, XrefRangeEnd = 486612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_AddCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 486637, RefRangeEnd = 486643, XrefRangeStart = 486617, XrefRangeEnd = 486637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001D918 File Offset: 0x0001BB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486643, XrefRangeEnd = 486646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPreCull(Camera cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0001D950 File Offset: 0x0001BB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486646, XrefRangeEnd = 486649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPreRender(Camera cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0001D988 File Offset: 0x0001BB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486649, XrefRangeEnd = 486652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPostRender(Camera cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0001D9C0 File Offset: 0x0001BBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486652, XrefRangeEnd = 486656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_backgroundColor_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0001DA00 File Offset: 0x0001BC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486656, XrefRangeEnd = 486660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_backgroundColor_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001DA40 File Offset: 0x0001BC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486660, XrefRangeEnd = 486664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0001DA80 File Offset: 0x0001BC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486664, XrefRangeEnd = 486668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_rect_Injected(ref Rect value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001DAC0 File Offset: 0x0001BCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486668, XrefRangeEnd = 486672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pixelRect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0001DB00 File Offset: 0x0001BD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486672, XrefRangeEnd = 486676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_pixelRect_Injected(ref Rect value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_pixelRect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0001DB40 File Offset: 0x0001BD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486676, XrefRangeEnd = 486680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_worldToCameraMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0001DB80 File Offset: 0x0001BD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486680, XrefRangeEnd = 486684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_projectionMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0001DBC0 File Offset: 0x0001BDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486684, XrefRangeEnd = 486688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_projectionMatrix_Injected(ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0001DC00 File Offset: 0x0001BE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486688, XrefRangeEnd = 486692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0001DC40 File Offset: 0x0001BE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486692, XrefRangeEnd = 486696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0001DC9C File Offset: 0x0001BE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486696, XrefRangeEnd = 486700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0001DCF8 File Offset: 0x0001BEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486700, XrefRangeEnd = 486704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0001DD54 File Offset: 0x0001BF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486704, XrefRangeEnd = 486708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486708, XrefRangeEnd = 486712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0001DDFC File Offset: 0x0001BFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486712, XrefRangeEnd = 486716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0001DE58 File Offset: 0x0001C058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486716, XrefRangeEnd = 486720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0001DEA4 File Offset: 0x0001C0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486720, XrefRangeEnd = 486724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000371F File Offset: 0x0000191F
		public Camera(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0001DEF0 File Offset: 0x0001C0F0
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00003728 File Offset: 0x00001928
		public unsafe static Camera.CameraCallback onPreCull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPreCull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPreCull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0001DF18 File Offset: 0x0001C118
		// (set) Token: 0x06000303 RID: 771 RVA: 0x0000373A File Offset: 0x0000193A
		public unsafe static Camera.CameraCallback onPreRender
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPreRender, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPreRender, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0001DF40 File Offset: 0x0001C140
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0000374C File Offset: 0x0000194C
		public unsafe static Camera.CameraCallback onPostRender
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPostRender, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPostRender, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00003770 File Offset: 0x00001970
		public void Reset()
		{
			Camera.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000037A7 File Offset: 0x000019A7
		// (set) Token: 0x0600030B RID: 779 RVA: 0x000037B9 File Offset: 0x000019B9
		public bool forceIntoRenderTexture
		{
			get
			{
				return Camera.get_forceIntoRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_forceIntoRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000037CC File Offset: 0x000019CC
		// (set) Token: 0x0600030D RID: 781 RVA: 0x000037DE File Offset: 0x000019DE
		public UnityEngine.Rendering.OpaqueSortMode opaqueSortMode
		{
			get
			{
				return Camera.get_opaqueSortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_opaqueSortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000037F1 File Offset: 0x000019F1
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00003803 File Offset: 0x00001A03
		public TransparencySortMode transparencySortMode
		{
			get
			{
				return Camera.get_transparencySortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_transparencySortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0001DF68 File Offset: 0x0001C168
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00003816 File Offset: 0x00001A16
		public Vector3 transparencySortAxis
		{
			get
			{
				Vector3 vector;
				this.get_transparencySortAxis_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_transparencySortAxis_Injected(ref value);
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003820 File Offset: 0x00001A20
		public void ResetTransparencySortSettings()
		{
			Camera.ResetTransparencySortSettingsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00003832 File Offset: 0x00001A32
		public void ResetAspect()
		{
			Camera.ResetAspectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0001DF80 File Offset: 0x0001C180
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00003857 File Offset: 0x00001A57
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00003869 File Offset: 0x00001A69
		public bool layerCullSpherical
		{
			get
			{
				return Camera.get_layerCullSphericalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_layerCullSphericalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000388F File Offset: 0x00001A8F
		// (set) Token: 0x0600031A RID: 794 RVA: 0x000038A1 File Offset: 0x00001AA1
		public ulong overrideSceneCullingMask
		{
			get
			{
				return Camera.get_overrideSceneCullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_overrideSceneCullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600031B RID: 795 RVA: 0x000038B4 File Offset: 0x00001AB4
		public ulong sceneCullingMask
		{
			get
			{
				return Camera.get_sceneCullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0001DF98 File Offset: 0x0001C198
		public Il2CppStructArray<float> GetLayerCullDistances()
		{
			IntPtr intPtr = Camera.GetLayerCullDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000038C6 File Offset: 0x00001AC6
		public void SetLayerCullDistances(Il2CppStructArray<float> d)
		{
			Camera.SetLayerCullDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(d));
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001DFC4 File Offset: 0x0001C1C4
		// (set) Token: 0x0600031F RID: 799 RVA: 0x0001DFDC File Offset: 0x0001C1DC
		public Il2CppStructArray<float> layerCullDistances
		{
			get
			{
				return this.GetLayerCullDistances();
			}
			set
			{
				bool flag = value.Length != 32;
				if (flag)
				{
					throw new UnityException("Array needs to contain exactly 32 floats for layerCullDistances.");
				}
				this.SetLayerCullDistances(value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000320 RID: 800 RVA: 0x000038DE File Offset: 0x00001ADE
		public static int PreviewCullingLayer
		{
			get
			{
				return Camera.get_PreviewCullingLayerDelegateField();
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0001E010 File Offset: 0x0001C210
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000038FC File Offset: 0x00001AFC
		public Matrix4x4 cullingMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_cullingMatrix_Injected(out matrix4x);
				return matrix4x;
			}
			set
			{
				this.set_cullingMatrix_Injected(ref value);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00003906 File Offset: 0x00001B06
		public void ResetCullingMatrix()
		{
			Camera.ResetCullingMatrixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00003918 File Offset: 0x00001B18
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000392A File Offset: 0x00001B2A
		public bool clearStencilAfterLightingPass
		{
			get
			{
				return Camera.get_clearStencilAfterLightingPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_clearStencilAfterLightingPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000393D File Offset: 0x00001B3D
		public void SetReplacementShader(Shader shader, string replacementTag)
		{
			Camera.SetReplacementShaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), IL2CPP.ManagedStringToIl2Cpp(replacementTag));
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000395B File Offset: 0x00001B5B
		public void ResetReplacementShader()
		{
			Camera.ResetReplacementShaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000396D File Offset: 0x00001B6D
		public Camera.ProjectionMatrixMode projectionMatrixMode
		{
			get
			{
				return Camera.get_projectionMatrixModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001E028 File Offset: 0x0001C228
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0000397F File Offset: 0x00001B7F
		public Vector2 sensorSize
		{
			get
			{
				Vector2 vector;
				this.get_sensorSize_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_sensorSize_Injected(ref value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0001E040 File Offset: 0x0001C240
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003989 File Offset: 0x00001B89
		public Vector2 lensShift
		{
			get
			{
				Vector2 vector;
				this.get_lensShift_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_lensShift_Injected(ref value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00003993 File Offset: 0x00001B93
		// (set) Token: 0x0600032F RID: 815 RVA: 0x000039A5 File Offset: 0x00001BA5
		public float focalLength
		{
			get
			{
				return Camera.get_focalLengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_focalLengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000330 RID: 816 RVA: 0x000039B8 File Offset: 0x00001BB8
		// (set) Token: 0x06000331 RID: 817 RVA: 0x000039CA File Offset: 0x00001BCA
		public Camera.GateFitMode gateFit
		{
			get
			{
				return Camera.get_gateFitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_gateFitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000039DD File Offset: 0x00001BDD
		public float GetGateFittedFieldOfView()
		{
			return Camera.GetGateFittedFieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0001E058 File Offset: 0x0001C258
		public Vector2 GetGateFittedLensShift()
		{
			Vector2 vector;
			this.GetGateFittedLensShift_Injected(out vector);
			return vector;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001E070 File Offset: 0x0001C270
		public Vector3 GetLocalSpaceAim()
		{
			Vector3 vector;
			this.GetLocalSpaceAim_Injected(out vector);
			return vector;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0001E088 File Offset: 0x0001C288
		public RenderTexture activeTexture
		{
			get
			{
				IntPtr intPtr = Camera.get_activeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00003A02 File Offset: 0x00001C02
		public void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth)
		{
			this.SetTargetBuffersImpl_Injected(ref color, ref depth);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00003A0E File Offset: 0x00001C0E
		public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
		{
			this.SetTargetBuffersImpl(colorBuffer, depthBuffer);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00003A1A File Offset: 0x00001C1A
		public void SetTargetBuffersMRTImpl(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth)
		{
			this.SetTargetBuffersMRTImpl_Injected(color, ref depth);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00003A25 File Offset: 0x00001C25
		public void SetTargetBuffers(Il2CppStructArray<RenderBuffer> colorBuffer, RenderBuffer depthBuffer)
		{
			this.SetTargetBuffersMRTImpl(colorBuffer, depthBuffer);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001E0B4 File Offset: 0x0001C2B4
		public Il2CppStringArray GetCameraBufferWarnings()
		{
			IntPtr intPtr = Camera.GetCameraBufferWarningsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0001E0E0 File Offset: 0x0001C2E0
		public Matrix4x4 cameraToWorldMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_cameraToWorldMatrix_Injected(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0001E110 File Offset: 0x0001C310
		public Matrix4x4 previousViewProjectionMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_previousViewProjectionMatrix_Injected(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00003A4D File Offset: 0x00001C4D
		public void ResetWorldToCameraMatrix()
		{
			Camera.ResetWorldToCameraMatrixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0001E128 File Offset: 0x0001C328
		public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane)
		{
			Matrix4x4 matrix4x;
			this.CalculateObliqueMatrix_Injected(ref clipPlane, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0001E140 File Offset: 0x0001C340
		public Vector3 ViewportToScreenPoint(Vector3 position)
		{
			Vector3 vector;
			this.ViewportToScreenPoint_Injected(ref position, out vector);
			return vector;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0001E158 File Offset: 0x0001C358
		public Vector2 GetFrustumPlaneSizeAt(float distance)
		{
			Vector2 vector;
			this.GetFrustumPlaneSizeAt_Injected(distance, out vector);
			return vector;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001E170 File Offset: 0x0001C370
		public Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye)
		{
			Ray ray;
			this.ViewportPointToRay_Injected(ref pos, eye, out ray);
			return ray;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001E18C File Offset: 0x0001C38C
		public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye)
		{
			return this.ViewportPointToRay(pos, eye);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0001E1AC File Offset: 0x0001C3AC
		public Ray ViewportPointToRay(Vector3 pos)
		{
			return this.ViewportPointToRay(pos, Camera.MonoOrStereoscopicEye.Mono);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00003A5F File Offset: 0x00001C5F
		public void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Il2CppStructArray<Vector3> outCorners)
		{
			this.CalculateFrustumCornersInternal_Injected(ref viewport, z, eye, outCorners);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
		public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Il2CppStructArray<Vector3> outCorners)
		{
			bool flag = outCorners == null;
			if (flag)
			{
				throw new ArgumentNullException("outCorners");
			}
			bool flag2 = outCorners.Length < 4;
			if (flag2)
			{
				throw new ArgumentException("outCorners minimum size is 4", "outCorners");
			}
			this.CalculateFrustumCornersInternal(viewport, z, eye, outCorners);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00003A6D File Offset: 0x00001C6D
		public static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode)
		{
			Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out output, focalLength, ref sensorSize, ref lensShift, nearClip, farClip, gateAspect, gateFitMode);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00003A82 File Offset: 0x00001C82
		public static float FocalLengthToFieldOfView(float focalLength, float sensorSize)
		{
			return Camera.FocalLengthToFieldOfViewDelegateField(focalLength, sensorSize);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00003A90 File Offset: 0x00001C90
		public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize)
		{
			return Camera.FieldOfViewToFocalLengthDelegateField(fieldOfView, sensorSize);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00003A9E File Offset: 0x00001C9E
		public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio)
		{
			return Camera.HorizontalToVerticalFieldOfViewDelegateField(horizontalFieldOfView, aspectRatio);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00003AAC File Offset: 0x00001CAC
		public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio)
		{
			return Camera.VerticalToHorizontalFieldOfViewDelegateField(verticalFieldOfView, aspectRatio);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0001E218 File Offset: 0x0001C418
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00003ABA File Offset: 0x00001CBA
		public UnityEngine.SceneManagement.Scene scene
		{
			get
			{
				UnityEngine.SceneManagement.Scene scene;
				this.get_scene_Injected(out scene);
				return scene;
			}
			set
			{
				this.set_scene_Injected(ref value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00003AC4 File Offset: 0x00001CC4
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00003AD6 File Offset: 0x00001CD6
		public float stereoSeparation
		{
			get
			{
				return Camera.get_stereoSeparationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_stereoSeparationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00003AE9 File Offset: 0x00001CE9
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00003AFB File Offset: 0x00001CFB
		public float stereoConvergence
		{
			get
			{
				return Camera.get_stereoConvergenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_stereoConvergenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00003B0E File Offset: 0x00001D0E
		public bool areVRStereoViewMatricesWithinSingleCullTolerance
		{
			get
			{
				return Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0001E230 File Offset: 0x0001C430
		public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye)
		{
			Matrix4x4 matrix4x;
			this.GetStereoViewMatrix_Injected(eye, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0001E248 File Offset: 0x0001C448
		public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye)
		{
			Matrix4x4 matrix4x;
			this.GetStereoProjectionMatrix_Injected(eye, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003B33 File Offset: 0x00001D33
		public void SetStereoViewMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix)
		{
			this.SetStereoViewMatrix_Injected(eye, ref matrix);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003B3E File Offset: 0x00001D3E
		public void ResetStereoViewMatrices()
		{
			Camera.ResetStereoViewMatricesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0001E260 File Offset: 0x0001C460
		public static Il2CppReferenceArray<Camera> allCameras
		{
			get
			{
				Il2CppReferenceArray<Camera> il2CppReferenceArray = new Il2CppReferenceArray<Camera>((long)Camera.allCamerasCount);
				Camera.GetAllCamerasImpl(il2CppReferenceArray);
				return il2CppReferenceArray;
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003B50 File Offset: 0x00001D50
		public bool RenderToCubemapImpl(Texture tex, int faceMask)
		{
			return Camera.RenderToCubemapImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(tex), faceMask);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0001E288 File Offset: 0x0001C488
		public bool RenderToCubemap(Cubemap cubemap, int faceMask)
		{
			return this.RenderToCubemapImpl(cubemap, faceMask);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0001E2A4 File Offset: 0x0001C4A4
		public bool RenderToCubemap(Cubemap cubemap)
		{
			return this.RenderToCubemapImpl(cubemap, 63);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0001E2C0 File Offset: 0x0001C4C0
		public bool RenderToCubemap(RenderTexture cubemap, int faceMask)
		{
			return this.RenderToCubemapImpl(cubemap, faceMask);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0001E2DC File Offset: 0x0001C4DC
		public bool RenderToCubemap(RenderTexture cubemap)
		{
			return this.RenderToCubemapImpl(cubemap, 63);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003B69 File Offset: 0x00001D69
		public bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye)
		{
			return Camera.RenderToCubemapEyeImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(cubemap), faceMask, stereoEye);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0001E2F8 File Offset: 0x0001C4F8
		public bool RenderToCubemap(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye)
		{
			return this.RenderToCubemapEyeImpl(cubemap, faceMask, stereoEye);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00003B83 File Offset: 0x00001D83
		public void RenderWithShader(Shader shader, string replacementTag)
		{
			Camera.RenderWithShaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), IL2CPP.ManagedStringToIl2Cpp(replacementTag));
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00003BA1 File Offset: 0x00001DA1
		public void RenderDontRestore()
		{
			Camera.RenderDontRestoreDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0001E314 File Offset: 0x0001C514
		public void SubmitRenderRequests(List<Camera.RenderRequest> renderRequests)
		{
			bool flag = renderRequests == null || renderRequests.Count == 0;
			if (flag)
			{
				throw new ArgumentException("SubmitRenderRequests has been invoked with invalid renderRequests");
			}
			bool flag2 = UnityEngine.Rendering.GraphicsSettings.currentRenderPipeline == null;
			if (flag2)
			{
				Debug.LogWarning("Trying to invoke 'SubmitRenderRequests' when no SRP is set. A scriptable render pipeline is needed for this function call");
			}
			else
			{
				this.SubmitRenderRequestsInternal(renderRequests);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00003BB3 File Offset: 0x00001DB3
		public void SubmitRenderRequestsInternal(Object requests)
		{
			Camera.SubmitRenderRequestsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(requests));
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003BCB File Offset: 0x00001DCB
		public static void SetupCurrent(Camera cur)
		{
			Camera.SetupCurrentDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cur));
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00003BDD File Offset: 0x00001DDD
		public void CopyFrom(Camera other)
		{
			Camera.CopyFromDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(other));
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00003BF5 File Offset: 0x00001DF5
		public int commandBufferCount
		{
			get
			{
				return Camera.get_commandBufferCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00003C07 File Offset: 0x00001E07
		public void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent evt)
		{
			Camera.RemoveCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00003C1A File Offset: 0x00001E1A
		public void RemoveAllCommandBuffers()
		{
			Camera.RemoveAllCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00003C2C File Offset: 0x00001E2C
		public void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			Camera.AddCommandBufferAsyncImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer), queueType);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0001E368 File Offset: 0x0001C568
		public void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			bool flag = !UnityEngine.Rendering.CameraEventUtils.IsValid(evt);
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid CameraEvent value \"{0}\".", (int)evt), "evt");
			}
			bool flag2 = buffer == null;
			if (flag2)
			{
				throw new NullReferenceException("buffer is null");
			}
			this.AddCommandBufferAsyncImpl(evt, buffer, queueType);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0001E3BC File Offset: 0x0001C5BC
		public Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer> GetCommandBuffers(UnityEngine.Rendering.CameraEvent evt)
		{
			IntPtr intPtr = Camera.GetCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer>>(intPtr2) : null;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00003C46 File Offset: 0x00001E46
		public void OnlyUsedForTesting1()
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00003C49 File Offset: 0x00001E49
		public void OnlyUsedForTesting2()
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00003C4C File Offset: 0x00001E4C
		public void get_transparencySortAxis_Injected(out Vector3 ret)
		{
			Camera.get_transparencySortAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00003C5F File Offset: 0x00001E5F
		public void set_transparencySortAxis_Injected(ref Vector3 value)
		{
			Camera.set_transparencySortAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00003C72 File Offset: 0x00001E72
		public void get_velocity_Injected(out Vector3 ret)
		{
			Camera.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00003C85 File Offset: 0x00001E85
		public void get_cullingMatrix_Injected(out Matrix4x4 ret)
		{
			Camera.get_cullingMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00003C98 File Offset: 0x00001E98
		public void set_cullingMatrix_Injected(ref Matrix4x4 value)
		{
			Camera.set_cullingMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00003CAB File Offset: 0x00001EAB
		public void get_sensorSize_Injected(out Vector2 ret)
		{
			Camera.get_sensorSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00003CBE File Offset: 0x00001EBE
		public void set_sensorSize_Injected(ref Vector2 value)
		{
			Camera.set_sensorSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00003CD1 File Offset: 0x00001ED1
		public void get_lensShift_Injected(out Vector2 ret)
		{
			Camera.get_lensShift_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003CE4 File Offset: 0x00001EE4
		public void set_lensShift_Injected(ref Vector2 value)
		{
			Camera.set_lensShift_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00003CF7 File Offset: 0x00001EF7
		public void GetGateFittedLensShift_Injected(out Vector2 ret)
		{
			Camera.GetGateFittedLensShift_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00003D0A File Offset: 0x00001F0A
		public void GetLocalSpaceAim_Injected(out Vector3 ret)
		{
			Camera.GetLocalSpaceAim_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00003D1D File Offset: 0x00001F1D
		public void SetTargetBuffersImpl_Injected(ref RenderBuffer color, ref RenderBuffer depth)
		{
			Camera.SetTargetBuffersImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref color, ref depth);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00003D31 File Offset: 0x00001F31
		public void SetTargetBuffersMRTImpl_Injected(Il2CppStructArray<RenderBuffer> color, ref RenderBuffer depth)
		{
			Camera.SetTargetBuffersMRTImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(color), ref depth);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00003D4A File Offset: 0x00001F4A
		public void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			Camera.get_cameraToWorldMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00003D5D File Offset: 0x00001F5D
		public void set_worldToCameraMatrix_Injected(ref Matrix4x4 value)
		{
			Camera.set_worldToCameraMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00003D70 File Offset: 0x00001F70
		public void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			Camera.get_nonJitteredProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00003D83 File Offset: 0x00001F83
		public void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			Camera.get_previousViewProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00003D96 File Offset: 0x00001F96
		public void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret)
		{
			Camera.CalculateObliqueMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref clipPlane, out ret);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00003DAA File Offset: 0x00001FAA
		public void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			Camera.ViewportToScreenPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, out ret);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00003DBE File Offset: 0x00001FBE
		public void GetFrustumPlaneSizeAt_Injected(float distance, out Vector2 ret)
		{
			Camera.GetFrustumPlaneSizeAt_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), distance, out ret);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00003DD2 File Offset: 0x00001FD2
		public void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret)
		{
			Camera.ViewportPointToRay_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref pos, eye, out ret);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00003DE7 File Offset: 0x00001FE7
		public void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Il2CppStructArray<Vector3> outCorners)
		{
			Camera.CalculateFrustumCornersInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref viewport, z, eye, IL2CPP.Il2CppObjectBaseToPtr(outCorners));
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0001E3EC File Offset: 0x0001C5EC
		public static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode)
		{
			Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField(out output, focalLength, ref sensorSize, ref lensShift, nearClip, farClip, gateAspect, gateFitMode);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00003E03 File Offset: 0x00002003
		public void get_scene_Injected(out UnityEngine.SceneManagement.Scene ret)
		{
			Camera.get_scene_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00003E16 File Offset: 0x00002016
		public void set_scene_Injected(ref UnityEngine.SceneManagement.Scene value)
		{
			Camera.set_scene_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00003E29 File Offset: 0x00002029
		public void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			Camera.GetStereoViewMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye, out ret);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00003E3D File Offset: 0x0000203D
		public void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			Camera.GetStereoProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye, out ret);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00003E51 File Offset: 0x00002051
		public void SetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix)
		{
			Camera.SetStereoViewMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye, ref matrix);
		}

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_onPreCull;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_onPreRender;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_onPostRender;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingPath_Public_set_Void_RenderingPath_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_get_actualRenderingPath_Public_get_RenderingPath_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_get_Single_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_get_aspect_Public_get_Single_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_set_usePhysicalProperties_Public_set_Void_Boolean_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelRect_Public_set_Void_Rect_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_set_projectionMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_set_useJitteredProjectionMatrixForTransparentRendering_Public_set_Void_Boolean_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_ResetProjectionMatrix_Public_Void_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoTargetEye_Public_get_StereoTargetEyeMask_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoActiveEye_Public_get_MonoOrStereoscopicEye_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Public_Matrix4x4_StereoscopicEye_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_CopyStereoDeviceProjectionMatrixToNonJittered_Public_Void_StereoscopicEye_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_ResetStereoProjectionMatrices_Public_Void_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_set_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelRect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_set_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0;

		// Token: 0x04000280 RID: 640
		private static readonly Camera.get_renderingPathDelegate get_renderingPathDelegateField;

		// Token: 0x04000281 RID: 641
		private static readonly Camera.ResetDelegate ResetDelegateField;

		// Token: 0x04000282 RID: 642
		private static readonly Camera.get_allowMSAADelegate get_allowMSAADelegateField;

		// Token: 0x04000283 RID: 643
		private static readonly Camera.set_allowDynamicResolutionDelegate set_allowDynamicResolutionDelegateField;

		// Token: 0x04000284 RID: 644
		private static readonly Camera.get_forceIntoRenderTextureDelegate get_forceIntoRenderTextureDelegateField;

		// Token: 0x04000285 RID: 645
		private static readonly Camera.set_forceIntoRenderTextureDelegate set_forceIntoRenderTextureDelegateField;

		// Token: 0x04000286 RID: 646
		private static readonly Camera.get_opaqueSortModeDelegate get_opaqueSortModeDelegateField;

		// Token: 0x04000287 RID: 647
		private static readonly Camera.set_opaqueSortModeDelegate set_opaqueSortModeDelegateField;

		// Token: 0x04000288 RID: 648
		private static readonly Camera.get_transparencySortModeDelegate get_transparencySortModeDelegateField;

		// Token: 0x04000289 RID: 649
		private static readonly Camera.set_transparencySortModeDelegate set_transparencySortModeDelegateField;

		// Token: 0x0400028A RID: 650
		private static readonly Camera.ResetTransparencySortSettingsDelegate ResetTransparencySortSettingsDelegateField;

		// Token: 0x0400028B RID: 651
		private static readonly Camera.ResetAspectDelegate ResetAspectDelegateField;

		// Token: 0x0400028C RID: 652
		private static readonly Camera.set_eventMaskDelegate set_eventMaskDelegateField;

		// Token: 0x0400028D RID: 653
		private static readonly Camera.get_layerCullSphericalDelegate get_layerCullSphericalDelegateField;

		// Token: 0x0400028E RID: 654
		private static readonly Camera.set_layerCullSphericalDelegate set_layerCullSphericalDelegateField;

		// Token: 0x0400028F RID: 655
		private static readonly Camera.set_cameraTypeDelegate set_cameraTypeDelegateField;

		// Token: 0x04000290 RID: 656
		private static readonly Camera.get_overrideSceneCullingMaskDelegate get_overrideSceneCullingMaskDelegateField;

		// Token: 0x04000291 RID: 657
		private static readonly Camera.set_overrideSceneCullingMaskDelegate set_overrideSceneCullingMaskDelegateField;

		// Token: 0x04000292 RID: 658
		private static readonly Camera.get_sceneCullingMaskDelegate get_sceneCullingMaskDelegateField;

		// Token: 0x04000293 RID: 659
		private static readonly Camera.GetLayerCullDistancesDelegate GetLayerCullDistancesDelegateField;

		// Token: 0x04000294 RID: 660
		private static readonly Camera.SetLayerCullDistancesDelegate SetLayerCullDistancesDelegateField;

		// Token: 0x04000295 RID: 661
		private static readonly Camera.get_PreviewCullingLayerDelegate get_PreviewCullingLayerDelegateField;

		// Token: 0x04000296 RID: 662
		private static readonly Camera.get_useOcclusionCullingDelegate get_useOcclusionCullingDelegateField;

		// Token: 0x04000297 RID: 663
		private static readonly Camera.ResetCullingMatrixDelegate ResetCullingMatrixDelegateField;

		// Token: 0x04000298 RID: 664
		private static readonly Camera.get_clearStencilAfterLightingPassDelegate get_clearStencilAfterLightingPassDelegateField;

		// Token: 0x04000299 RID: 665
		private static readonly Camera.set_clearStencilAfterLightingPassDelegate set_clearStencilAfterLightingPassDelegateField;

		// Token: 0x0400029A RID: 666
		private static readonly Camera.SetReplacementShaderDelegate SetReplacementShaderDelegateField;

		// Token: 0x0400029B RID: 667
		private static readonly Camera.ResetReplacementShaderDelegate ResetReplacementShaderDelegateField;

		// Token: 0x0400029C RID: 668
		private static readonly Camera.get_projectionMatrixModeDelegate get_projectionMatrixModeDelegateField;

		// Token: 0x0400029D RID: 669
		private static readonly Camera.get_focalLengthDelegate get_focalLengthDelegateField;

		// Token: 0x0400029E RID: 670
		private static readonly Camera.set_focalLengthDelegate set_focalLengthDelegateField;

		// Token: 0x0400029F RID: 671
		private static readonly Camera.get_gateFitDelegate get_gateFitDelegateField;

		// Token: 0x040002A0 RID: 672
		private static readonly Camera.set_gateFitDelegate set_gateFitDelegateField;

		// Token: 0x040002A1 RID: 673
		private static readonly Camera.GetGateFittedFieldOfViewDelegate GetGateFittedFieldOfViewDelegateField;

		// Token: 0x040002A2 RID: 674
		private static readonly Camera.get_activeTextureDelegate get_activeTextureDelegateField;

		// Token: 0x040002A3 RID: 675
		private static readonly Camera.set_targetDisplayDelegate set_targetDisplayDelegateField;

		// Token: 0x040002A4 RID: 676
		private static readonly Camera.GetCameraBufferWarningsDelegate GetCameraBufferWarningsDelegateField;

		// Token: 0x040002A5 RID: 677
		private static readonly Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegate get_useJitteredProjectionMatrixForTransparentRenderingDelegateField;

		// Token: 0x040002A6 RID: 678
		private static readonly Camera.ResetWorldToCameraMatrixDelegate ResetWorldToCameraMatrixDelegateField;

		// Token: 0x040002A7 RID: 679
		private static readonly Camera.FocalLengthToFieldOfViewDelegate FocalLengthToFieldOfViewDelegateField;

		// Token: 0x040002A8 RID: 680
		private static readonly Camera.FieldOfViewToFocalLengthDelegate FieldOfViewToFocalLengthDelegateField;

		// Token: 0x040002A9 RID: 681
		private static readonly Camera.HorizontalToVerticalFieldOfViewDelegate HorizontalToVerticalFieldOfViewDelegateField;

		// Token: 0x040002AA RID: 682
		private static readonly Camera.VerticalToHorizontalFieldOfViewDelegate VerticalToHorizontalFieldOfViewDelegateField;

		// Token: 0x040002AB RID: 683
		private static readonly Camera.get_stereoSeparationDelegate get_stereoSeparationDelegateField;

		// Token: 0x040002AC RID: 684
		private static readonly Camera.set_stereoSeparationDelegate set_stereoSeparationDelegateField;

		// Token: 0x040002AD RID: 685
		private static readonly Camera.get_stereoConvergenceDelegate get_stereoConvergenceDelegateField;

		// Token: 0x040002AE RID: 686
		private static readonly Camera.set_stereoConvergenceDelegate set_stereoConvergenceDelegateField;

		// Token: 0x040002AF RID: 687
		private static readonly Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegate get_areVRStereoViewMatricesWithinSingleCullToleranceDelegateField;

		// Token: 0x040002B0 RID: 688
		private static readonly Camera.set_stereoTargetEyeDelegate set_stereoTargetEyeDelegateField;

		// Token: 0x040002B1 RID: 689
		private static readonly Camera.ResetStereoViewMatricesDelegate ResetStereoViewMatricesDelegateField;

		// Token: 0x040002B2 RID: 690
		private static readonly Camera.RenderToCubemapImplDelegate RenderToCubemapImplDelegateField;

		// Token: 0x040002B3 RID: 691
		private static readonly Camera.RenderToCubemapEyeImplDelegate RenderToCubemapEyeImplDelegateField;

		// Token: 0x040002B4 RID: 692
		private static readonly Camera.RenderWithShaderDelegate RenderWithShaderDelegateField;

		// Token: 0x040002B5 RID: 693
		private static readonly Camera.RenderDontRestoreDelegate RenderDontRestoreDelegateField;

		// Token: 0x040002B6 RID: 694
		private static readonly Camera.SubmitRenderRequestsInternalDelegate SubmitRenderRequestsInternalDelegateField;

		// Token: 0x040002B7 RID: 695
		private static readonly Camera.SetupCurrentDelegate SetupCurrentDelegateField;

		// Token: 0x040002B8 RID: 696
		private static readonly Camera.CopyFromDelegate CopyFromDelegateField;

		// Token: 0x040002B9 RID: 697
		private static readonly Camera.get_commandBufferCountDelegate get_commandBufferCountDelegateField;

		// Token: 0x040002BA RID: 698
		private static readonly Camera.RemoveCommandBuffersDelegate RemoveCommandBuffersDelegateField;

		// Token: 0x040002BB RID: 699
		private static readonly Camera.RemoveAllCommandBuffersDelegate RemoveAllCommandBuffersDelegateField;

		// Token: 0x040002BC RID: 700
		private static readonly Camera.AddCommandBufferAsyncImplDelegate AddCommandBufferAsyncImplDelegateField;

		// Token: 0x040002BD RID: 701
		private static readonly Camera.GetCommandBuffersDelegate GetCommandBuffersDelegateField;

		// Token: 0x040002BE RID: 702
		private static readonly Camera.get_transparencySortAxis_InjectedDelegate get_transparencySortAxis_InjectedDelegateField;

		// Token: 0x040002BF RID: 703
		private static readonly Camera.set_transparencySortAxis_InjectedDelegate set_transparencySortAxis_InjectedDelegateField;

		// Token: 0x040002C0 RID: 704
		private static readonly Camera.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

		// Token: 0x040002C1 RID: 705
		private static readonly Camera.get_cullingMatrix_InjectedDelegate get_cullingMatrix_InjectedDelegateField;

		// Token: 0x040002C2 RID: 706
		private static readonly Camera.set_cullingMatrix_InjectedDelegate set_cullingMatrix_InjectedDelegateField;

		// Token: 0x040002C3 RID: 707
		private static readonly Camera.get_sensorSize_InjectedDelegate get_sensorSize_InjectedDelegateField;

		// Token: 0x040002C4 RID: 708
		private static readonly Camera.set_sensorSize_InjectedDelegate set_sensorSize_InjectedDelegateField;

		// Token: 0x040002C5 RID: 709
		private static readonly Camera.get_lensShift_InjectedDelegate get_lensShift_InjectedDelegateField;

		// Token: 0x040002C6 RID: 710
		private static readonly Camera.set_lensShift_InjectedDelegate set_lensShift_InjectedDelegateField;

		// Token: 0x040002C7 RID: 711
		private static readonly Camera.GetGateFittedLensShift_InjectedDelegate GetGateFittedLensShift_InjectedDelegateField;

		// Token: 0x040002C8 RID: 712
		private static readonly Camera.GetLocalSpaceAim_InjectedDelegate GetLocalSpaceAim_InjectedDelegateField;

		// Token: 0x040002C9 RID: 713
		private static readonly Camera.SetTargetBuffersImpl_InjectedDelegate SetTargetBuffersImpl_InjectedDelegateField;

		// Token: 0x040002CA RID: 714
		private static readonly Camera.SetTargetBuffersMRTImpl_InjectedDelegate SetTargetBuffersMRTImpl_InjectedDelegateField;

		// Token: 0x040002CB RID: 715
		private static readonly Camera.get_cameraToWorldMatrix_InjectedDelegate get_cameraToWorldMatrix_InjectedDelegateField;

		// Token: 0x040002CC RID: 716
		private static readonly Camera.set_worldToCameraMatrix_InjectedDelegate set_worldToCameraMatrix_InjectedDelegateField;

		// Token: 0x040002CD RID: 717
		private static readonly Camera.get_nonJitteredProjectionMatrix_InjectedDelegate get_nonJitteredProjectionMatrix_InjectedDelegateField;

		// Token: 0x040002CE RID: 718
		private static readonly Camera.get_previousViewProjectionMatrix_InjectedDelegate get_previousViewProjectionMatrix_InjectedDelegateField;

		// Token: 0x040002CF RID: 719
		private static readonly Camera.CalculateObliqueMatrix_InjectedDelegate CalculateObliqueMatrix_InjectedDelegateField;

		// Token: 0x040002D0 RID: 720
		private static readonly Camera.ViewportToScreenPoint_InjectedDelegate ViewportToScreenPoint_InjectedDelegateField;

		// Token: 0x040002D1 RID: 721
		private static readonly Camera.GetFrustumPlaneSizeAt_InjectedDelegate GetFrustumPlaneSizeAt_InjectedDelegateField;

		// Token: 0x040002D2 RID: 722
		private static readonly Camera.ViewportPointToRay_InjectedDelegate ViewportPointToRay_InjectedDelegateField;

		// Token: 0x040002D3 RID: 723
		private static readonly Camera.CalculateFrustumCornersInternal_InjectedDelegate CalculateFrustumCornersInternal_InjectedDelegateField;

		// Token: 0x040002D4 RID: 724
		private static readonly Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField;

		// Token: 0x040002D5 RID: 725
		private static readonly Camera.get_scene_InjectedDelegate get_scene_InjectedDelegateField;

		// Token: 0x040002D6 RID: 726
		private static readonly Camera.set_scene_InjectedDelegate set_scene_InjectedDelegateField;

		// Token: 0x040002D7 RID: 727
		private static readonly Camera.GetStereoViewMatrix_InjectedDelegate GetStereoViewMatrix_InjectedDelegateField;

		// Token: 0x040002D8 RID: 728
		private static readonly Camera.GetStereoProjectionMatrix_InjectedDelegate GetStereoProjectionMatrix_InjectedDelegateField;

		// Token: 0x040002D9 RID: 729
		private static readonly Camera.SetStereoViewMatrix_InjectedDelegate SetStereoViewMatrix_InjectedDelegateField;

		// Token: 0x0200036B RID: 875
		[OriginalName("UnityEngine.CoreModule.dll", "", "StereoscopicEye")]
		public enum StereoscopicEye
		{
			// Token: 0x04001E90 RID: 7824
			Left,
			// Token: 0x04001E91 RID: 7825
			Right
		}

		// Token: 0x0200036C RID: 876
		[OriginalName("UnityEngine.CoreModule.dll", "", "MonoOrStereoscopicEye")]
		public enum MonoOrStereoscopicEye
		{
			// Token: 0x04001E93 RID: 7827
			Left,
			// Token: 0x04001E94 RID: 7828
			Right,
			// Token: 0x04001E95 RID: 7829
			Mono
		}

		// Token: 0x0200036D RID: 877
		[OriginalName("UnityEngine.CoreModule.dll", "", "RenderRequestMode")]
		public enum RenderRequestMode
		{
			// Token: 0x04001E97 RID: 7831
			None,
			// Token: 0x04001E98 RID: 7832
			ObjectId,
			// Token: 0x04001E99 RID: 7833
			Depth,
			// Token: 0x04001E9A RID: 7834
			VertexNormal,
			// Token: 0x04001E9B RID: 7835
			WorldPosition,
			// Token: 0x04001E9C RID: 7836
			EntityId,
			// Token: 0x04001E9D RID: 7837
			BaseColor,
			// Token: 0x04001E9E RID: 7838
			SpecularColor,
			// Token: 0x04001E9F RID: 7839
			Metallic,
			// Token: 0x04001EA0 RID: 7840
			Emission,
			// Token: 0x04001EA1 RID: 7841
			Normal,
			// Token: 0x04001EA2 RID: 7842
			Smoothness,
			// Token: 0x04001EA3 RID: 7843
			Occlusion,
			// Token: 0x04001EA4 RID: 7844
			DiffuseColor
		}

		// Token: 0x0200036E RID: 878
		[OriginalName("UnityEngine.CoreModule.dll", "", "RenderRequestOutputSpace")]
		public enum RenderRequestOutputSpace
		{
			// Token: 0x04001EA6 RID: 7846
			ScreenSpace = -1,
			// Token: 0x04001EA7 RID: 7847
			UV0,
			// Token: 0x04001EA8 RID: 7848
			UV1,
			// Token: 0x04001EA9 RID: 7849
			UV2,
			// Token: 0x04001EAA RID: 7850
			UV3,
			// Token: 0x04001EAB RID: 7851
			UV4,
			// Token: 0x04001EAC RID: 7852
			UV5,
			// Token: 0x04001EAD RID: 7853
			UV6,
			// Token: 0x04001EAE RID: 7854
			UV7,
			// Token: 0x04001EAF RID: 7855
			UV8
		}

		// Token: 0x0200036F RID: 879
		public sealed class RenderRequest : ValueType
		{
			// Token: 0x060024FC RID: 9468 RVA: 0x0007AC14 File Offset: 0x00078E14
			// Note: this type is marked as 'beforefieldinit'.
			static RenderRequest()
			{
				Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Camera>.NativeClassPtr, "RenderRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr);
				Camera.RenderRequest.NativeFieldInfoPtr_m_CameraRenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr, "m_CameraRenderMode");
				Camera.RenderRequest.NativeFieldInfoPtr_m_ResultRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr, "m_ResultRT");
				Camera.RenderRequest.NativeFieldInfoPtr_m_OutputSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr, "m_OutputSpace");
			}

			// Token: 0x060024FD RID: 9469 RVA: 0x000135D0 File Offset: 0x000117D0
			public RenderRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060024FE RID: 9470 RVA: 0x000135D9 File Offset: 0x000117D9
			public RenderRequest()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr))
			{
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x060024FF RID: 9471 RVA: 0x0007AC7C File Offset: 0x00078E7C
			// (set) Token: 0x06002500 RID: 9472 RVA: 0x000135EB File Offset: 0x000117EB
			public unsafe Camera.RenderRequestMode m_CameraRenderMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_CameraRenderMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_CameraRenderMode)) = value;
				}
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x06002501 RID: 9473 RVA: 0x0007ACA4 File Offset: 0x00078EA4
			// (set) Token: 0x06002502 RID: 9474 RVA: 0x00013606 File Offset: 0x00011806
			public unsafe RenderTexture m_ResultRT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_ResultRT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_ResultRT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06002503 RID: 9475 RVA: 0x0007ACD4 File Offset: 0x00078ED4
			// (set) Token: 0x06002504 RID: 9476 RVA: 0x00013625 File Offset: 0x00011825
			public unsafe Camera.RenderRequestOutputSpace m_OutputSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_OutputSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_OutputSpace)) = value;
				}
			}

			// Token: 0x04001EB0 RID: 7856
			private static readonly IntPtr NativeFieldInfoPtr_m_CameraRenderMode;

			// Token: 0x04001EB1 RID: 7857
			private static readonly IntPtr NativeFieldInfoPtr_m_ResultRT;

			// Token: 0x04001EB2 RID: 7858
			private static readonly IntPtr NativeFieldInfoPtr_m_OutputSpace;
		}

		// Token: 0x02000370 RID: 880
		public sealed class CameraCallback : MulticastDelegate
		{
			// Token: 0x06002505 RID: 9477 RVA: 0x0007ACFC File Offset: 0x00078EFC
			// Note: this type is marked as 'beforefieldinit'.
			static CameraCallback()
			{
				Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Camera>.NativeClassPtr, "CameraCallback");
				Camera.CameraCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr, 100663583);
				Camera.CameraCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr, 100663584);
				Camera.CameraCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr, 100663585);
				Camera.CameraCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr, 100663586);
			}

			// Token: 0x06002506 RID: 9478 RVA: 0x0007AD70 File Offset: 0x00078F70
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CameraCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.CameraCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002507 RID: 9479 RVA: 0x0007ADCC File Offset: 0x00078FCC
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1006, RefRangeEnd = 1022, XrefRangeStart = 1006, XrefRangeEnd = 1022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.CameraCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002508 RID: 9480 RVA: 0x0007AE10 File Offset: 0x00079010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.CameraCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002509 RID: 9481 RVA: 0x0007AE84 File Offset: 0x00079084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.CameraCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600250A RID: 9482 RVA: 0x00013640 File Offset: 0x00011840
			public CameraCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600250B RID: 9483 RVA: 0x00013649 File Offset: 0x00011849
			public static implicit operator Camera.CameraCallback(Action<Camera> A_0)
			{
				return DelegateSupport.ConvertDelegate<Camera.CameraCallback>(A_0);
			}

			// Token: 0x0600250C RID: 9484 RVA: 0x00013651 File Offset: 0x00011851
			public static Camera.CameraCallback operator +(Camera.CameraCallback A_0, Camera.CameraCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Camera.CameraCallback>();
			}

			// Token: 0x0600250D RID: 9485 RVA: 0x0001365F File Offset: 0x0001185F
			public static Camera.CameraCallback operator -(Camera.CameraCallback A_0, Camera.CameraCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Camera.CameraCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001EB3 RID: 7859
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001EB4 RID: 7860
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0;

			// Token: 0x04001EB5 RID: 7861
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0;

			// Token: 0x04001EB6 RID: 7862
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000371 RID: 881
		public enum ProjectionMatrixMode
		{
			// Token: 0x04001EB8 RID: 7864
			Explicit,
			// Token: 0x04001EB9 RID: 7865
			Implicit,
			// Token: 0x04001EBA RID: 7866
			PhysicalPropertiesBased
		}

		// Token: 0x02000372 RID: 882
		public enum GateFitMode
		{
			// Token: 0x04001EBC RID: 7868
			Vertical = 1,
			// Token: 0x04001EBD RID: 7869
			Horizontal,
			// Token: 0x04001EBE RID: 7870
			Fill,
			// Token: 0x04001EBF RID: 7871
			Overscan,
			// Token: 0x04001EC0 RID: 7872
			None = 0
		}

		// Token: 0x02000373 RID: 883
		public enum FieldOfViewAxis
		{
			// Token: 0x04001EC2 RID: 7874
			Vertical,
			// Token: 0x04001EC3 RID: 7875
			Horizontal
		}

		// Token: 0x02000374 RID: 884
		// (Invoke) Token: 0x0600250F RID: 9487
		private delegate RenderingPath get_renderingPathDelegate(IntPtr @this);

		// Token: 0x02000375 RID: 885
		// (Invoke) Token: 0x06002511 RID: 9489
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x02000376 RID: 886
		// (Invoke) Token: 0x06002513 RID: 9491
		private delegate bool get_allowMSAADelegate(IntPtr @this);

		// Token: 0x02000377 RID: 887
		// (Invoke) Token: 0x06002515 RID: 9493
		private delegate void set_allowDynamicResolutionDelegate(IntPtr @this, bool value);

		// Token: 0x02000378 RID: 888
		// (Invoke) Token: 0x06002517 RID: 9495
		private delegate bool get_forceIntoRenderTextureDelegate(IntPtr @this);

		// Token: 0x02000379 RID: 889
		// (Invoke) Token: 0x06002519 RID: 9497
		private delegate void set_forceIntoRenderTextureDelegate(IntPtr @this, bool value);

		// Token: 0x0200037A RID: 890
		// (Invoke) Token: 0x0600251B RID: 9499
		private delegate UnityEngine.Rendering.OpaqueSortMode get_opaqueSortModeDelegate(IntPtr @this);

		// Token: 0x0200037B RID: 891
		// (Invoke) Token: 0x0600251D RID: 9501
		private delegate void set_opaqueSortModeDelegate(IntPtr @this, UnityEngine.Rendering.OpaqueSortMode value);

		// Token: 0x0200037C RID: 892
		// (Invoke) Token: 0x0600251F RID: 9503
		private delegate TransparencySortMode get_transparencySortModeDelegate(IntPtr @this);

		// Token: 0x0200037D RID: 893
		// (Invoke) Token: 0x06002521 RID: 9505
		private delegate void set_transparencySortModeDelegate(IntPtr @this, TransparencySortMode value);

		// Token: 0x0200037E RID: 894
		// (Invoke) Token: 0x06002523 RID: 9507
		private delegate void ResetTransparencySortSettingsDelegate(IntPtr @this);

		// Token: 0x0200037F RID: 895
		// (Invoke) Token: 0x06002525 RID: 9509
		private delegate void ResetAspectDelegate(IntPtr @this);

		// Token: 0x02000380 RID: 896
		// (Invoke) Token: 0x06002527 RID: 9511
		private delegate void set_eventMaskDelegate(IntPtr @this, int value);

		// Token: 0x02000381 RID: 897
		// (Invoke) Token: 0x06002529 RID: 9513
		private delegate bool get_layerCullSphericalDelegate(IntPtr @this);

		// Token: 0x02000382 RID: 898
		// (Invoke) Token: 0x0600252B RID: 9515
		private delegate void set_layerCullSphericalDelegate(IntPtr @this, bool value);

		// Token: 0x02000383 RID: 899
		// (Invoke) Token: 0x0600252D RID: 9517
		private delegate void set_cameraTypeDelegate(IntPtr @this, CameraType value);

		// Token: 0x02000384 RID: 900
		// (Invoke) Token: 0x0600252F RID: 9519
		private delegate ulong get_overrideSceneCullingMaskDelegate(IntPtr @this);

		// Token: 0x02000385 RID: 901
		// (Invoke) Token: 0x06002531 RID: 9521
		private delegate void set_overrideSceneCullingMaskDelegate(IntPtr @this, ulong value);

		// Token: 0x02000386 RID: 902
		// (Invoke) Token: 0x06002533 RID: 9523
		private delegate ulong get_sceneCullingMaskDelegate(IntPtr @this);

		// Token: 0x02000387 RID: 903
		// (Invoke) Token: 0x06002535 RID: 9525
		private delegate IntPtr GetLayerCullDistancesDelegate(IntPtr @this);

		// Token: 0x02000388 RID: 904
		// (Invoke) Token: 0x06002537 RID: 9527
		private delegate void SetLayerCullDistancesDelegate(IntPtr @this, IntPtr d);

		// Token: 0x02000389 RID: 905
		// (Invoke) Token: 0x06002539 RID: 9529
		private delegate int get_PreviewCullingLayerDelegate();

		// Token: 0x0200038A RID: 906
		// (Invoke) Token: 0x0600253B RID: 9531
		private delegate bool get_useOcclusionCullingDelegate(IntPtr @this);

		// Token: 0x0200038B RID: 907
		// (Invoke) Token: 0x0600253D RID: 9533
		private delegate void ResetCullingMatrixDelegate(IntPtr @this);

		// Token: 0x0200038C RID: 908
		// (Invoke) Token: 0x0600253F RID: 9535
		private delegate bool get_clearStencilAfterLightingPassDelegate(IntPtr @this);

		// Token: 0x0200038D RID: 909
		// (Invoke) Token: 0x06002541 RID: 9537
		private delegate void set_clearStencilAfterLightingPassDelegate(IntPtr @this, bool value);

		// Token: 0x0200038E RID: 910
		// (Invoke) Token: 0x06002543 RID: 9539
		private delegate void SetReplacementShaderDelegate(IntPtr @this, IntPtr shader, IntPtr replacementTag);

		// Token: 0x0200038F RID: 911
		// (Invoke) Token: 0x06002545 RID: 9541
		private delegate void ResetReplacementShaderDelegate(IntPtr @this);

		// Token: 0x02000390 RID: 912
		// (Invoke) Token: 0x06002547 RID: 9543
		private delegate Camera.ProjectionMatrixMode get_projectionMatrixModeDelegate(IntPtr @this);

		// Token: 0x02000391 RID: 913
		// (Invoke) Token: 0x06002549 RID: 9545
		private delegate float get_focalLengthDelegate(IntPtr @this);

		// Token: 0x02000392 RID: 914
		// (Invoke) Token: 0x0600254B RID: 9547
		private delegate void set_focalLengthDelegate(IntPtr @this, float value);

		// Token: 0x02000393 RID: 915
		// (Invoke) Token: 0x0600254D RID: 9549
		private delegate Camera.GateFitMode get_gateFitDelegate(IntPtr @this);

		// Token: 0x02000394 RID: 916
		// (Invoke) Token: 0x0600254F RID: 9551
		private delegate void set_gateFitDelegate(IntPtr @this, Camera.GateFitMode value);

		// Token: 0x02000395 RID: 917
		// (Invoke) Token: 0x06002551 RID: 9553
		private delegate float GetGateFittedFieldOfViewDelegate(IntPtr @this);

		// Token: 0x02000396 RID: 918
		// (Invoke) Token: 0x06002553 RID: 9555
		private delegate IntPtr get_activeTextureDelegate(IntPtr @this);

		// Token: 0x02000397 RID: 919
		// (Invoke) Token: 0x06002555 RID: 9557
		private delegate void set_targetDisplayDelegate(IntPtr @this, int value);

		// Token: 0x02000398 RID: 920
		// (Invoke) Token: 0x06002557 RID: 9559
		private delegate IntPtr GetCameraBufferWarningsDelegate(IntPtr @this);

		// Token: 0x02000399 RID: 921
		// (Invoke) Token: 0x06002559 RID: 9561
		private delegate bool get_useJitteredProjectionMatrixForTransparentRenderingDelegate(IntPtr @this);

		// Token: 0x0200039A RID: 922
		// (Invoke) Token: 0x0600255B RID: 9563
		private delegate void ResetWorldToCameraMatrixDelegate(IntPtr @this);

		// Token: 0x0200039B RID: 923
		// (Invoke) Token: 0x0600255D RID: 9565
		private delegate float FocalLengthToFieldOfViewDelegate(float focalLength, float sensorSize);

		// Token: 0x0200039C RID: 924
		// (Invoke) Token: 0x0600255F RID: 9567
		private delegate float FieldOfViewToFocalLengthDelegate(float fieldOfView, float sensorSize);

		// Token: 0x0200039D RID: 925
		// (Invoke) Token: 0x06002561 RID: 9569
		private delegate float HorizontalToVerticalFieldOfViewDelegate(float horizontalFieldOfView, float aspectRatio);

		// Token: 0x0200039E RID: 926
		// (Invoke) Token: 0x06002563 RID: 9571
		private delegate float VerticalToHorizontalFieldOfViewDelegate(float verticalFieldOfView, float aspectRatio);

		// Token: 0x0200039F RID: 927
		// (Invoke) Token: 0x06002565 RID: 9573
		private delegate float get_stereoSeparationDelegate(IntPtr @this);

		// Token: 0x020003A0 RID: 928
		// (Invoke) Token: 0x06002567 RID: 9575
		private delegate void set_stereoSeparationDelegate(IntPtr @this, float value);

		// Token: 0x020003A1 RID: 929
		// (Invoke) Token: 0x06002569 RID: 9577
		private delegate float get_stereoConvergenceDelegate(IntPtr @this);

		// Token: 0x020003A2 RID: 930
		// (Invoke) Token: 0x0600256B RID: 9579
		private delegate void set_stereoConvergenceDelegate(IntPtr @this, float value);

		// Token: 0x020003A3 RID: 931
		// (Invoke) Token: 0x0600256D RID: 9581
		private delegate bool get_areVRStereoViewMatricesWithinSingleCullToleranceDelegate(IntPtr @this);

		// Token: 0x020003A4 RID: 932
		// (Invoke) Token: 0x0600256F RID: 9583
		private delegate void set_stereoTargetEyeDelegate(IntPtr @this, StereoTargetEyeMask value);

		// Token: 0x020003A5 RID: 933
		// (Invoke) Token: 0x06002571 RID: 9585
		private delegate void ResetStereoViewMatricesDelegate(IntPtr @this);

		// Token: 0x020003A6 RID: 934
		// (Invoke) Token: 0x06002573 RID: 9587
		private delegate bool RenderToCubemapImplDelegate(IntPtr @this, IntPtr tex, int faceMask);

		// Token: 0x020003A7 RID: 935
		// (Invoke) Token: 0x06002575 RID: 9589
		private delegate bool RenderToCubemapEyeImplDelegate(IntPtr @this, IntPtr cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye);

		// Token: 0x020003A8 RID: 936
		// (Invoke) Token: 0x06002577 RID: 9591
		private delegate void RenderWithShaderDelegate(IntPtr @this, IntPtr shader, IntPtr replacementTag);

		// Token: 0x020003A9 RID: 937
		// (Invoke) Token: 0x06002579 RID: 9593
		private delegate void RenderDontRestoreDelegate(IntPtr @this);

		// Token: 0x020003AA RID: 938
		// (Invoke) Token: 0x0600257B RID: 9595
		private delegate void SubmitRenderRequestsInternalDelegate(IntPtr @this, IntPtr requests);

		// Token: 0x020003AB RID: 939
		// (Invoke) Token: 0x0600257D RID: 9597
		private delegate void SetupCurrentDelegate(IntPtr cur);

		// Token: 0x020003AC RID: 940
		// (Invoke) Token: 0x0600257F RID: 9599
		private delegate void CopyFromDelegate(IntPtr @this, IntPtr other);

		// Token: 0x020003AD RID: 941
		// (Invoke) Token: 0x06002581 RID: 9601
		private delegate int get_commandBufferCountDelegate(IntPtr @this);

		// Token: 0x020003AE RID: 942
		// (Invoke) Token: 0x06002583 RID: 9603
		private delegate void RemoveCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.CameraEvent evt);

		// Token: 0x020003AF RID: 943
		// (Invoke) Token: 0x06002585 RID: 9605
		private delegate void RemoveAllCommandBuffersDelegate(IntPtr @this);

		// Token: 0x020003B0 RID: 944
		// (Invoke) Token: 0x06002587 RID: 9607
		private delegate void AddCommandBufferAsyncImplDelegate(IntPtr @this, UnityEngine.Rendering.CameraEvent evt, IntPtr buffer, UnityEngine.Rendering.ComputeQueueType queueType);

		// Token: 0x020003B1 RID: 945
		// (Invoke) Token: 0x06002589 RID: 9609
		private delegate IntPtr GetCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.CameraEvent evt);

		// Token: 0x020003B2 RID: 946
		// (Invoke) Token: 0x0600258B RID: 9611
		private delegate void get_transparencySortAxis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003B3 RID: 947
		// (Invoke) Token: 0x0600258D RID: 9613
		private delegate void set_transparencySortAxis_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003B4 RID: 948
		// (Invoke) Token: 0x0600258F RID: 9615
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003B5 RID: 949
		// (Invoke) Token: 0x06002591 RID: 9617
		private delegate void get_cullingMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003B6 RID: 950
		// (Invoke) Token: 0x06002593 RID: 9619
		private delegate void set_cullingMatrix_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003B7 RID: 951
		// (Invoke) Token: 0x06002595 RID: 9621
		private delegate void get_sensorSize_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003B8 RID: 952
		// (Invoke) Token: 0x06002597 RID: 9623
		private delegate void set_sensorSize_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003B9 RID: 953
		// (Invoke) Token: 0x06002599 RID: 9625
		private delegate void get_lensShift_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003BA RID: 954
		// (Invoke) Token: 0x0600259B RID: 9627
		private delegate void set_lensShift_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003BB RID: 955
		// (Invoke) Token: 0x0600259D RID: 9629
		private delegate void GetGateFittedLensShift_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003BC RID: 956
		// (Invoke) Token: 0x0600259F RID: 9631
		private delegate void GetLocalSpaceAim_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003BD RID: 957
		// (Invoke) Token: 0x060025A1 RID: 9633
		private delegate void SetTargetBuffersImpl_InjectedDelegate(IntPtr @this, IntPtr color, IntPtr depth);

		// Token: 0x020003BE RID: 958
		// (Invoke) Token: 0x060025A3 RID: 9635
		private delegate void SetTargetBuffersMRTImpl_InjectedDelegate(IntPtr @this, IntPtr color, IntPtr depth);

		// Token: 0x020003BF RID: 959
		// (Invoke) Token: 0x060025A5 RID: 9637
		private delegate void get_cameraToWorldMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003C0 RID: 960
		// (Invoke) Token: 0x060025A7 RID: 9639
		private delegate void set_worldToCameraMatrix_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003C1 RID: 961
		// (Invoke) Token: 0x060025A9 RID: 9641
		private delegate void get_nonJitteredProjectionMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003C2 RID: 962
		// (Invoke) Token: 0x060025AB RID: 9643
		private delegate void get_previousViewProjectionMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003C3 RID: 963
		// (Invoke) Token: 0x060025AD RID: 9645
		private delegate void CalculateObliqueMatrix_InjectedDelegate(IntPtr @this, IntPtr clipPlane, [Out] IntPtr ret);

		// Token: 0x020003C4 RID: 964
		// (Invoke) Token: 0x060025AF RID: 9647
		private delegate void ViewportToScreenPoint_InjectedDelegate(IntPtr @this, IntPtr position, [Out] IntPtr ret);

		// Token: 0x020003C5 RID: 965
		// (Invoke) Token: 0x060025B1 RID: 9649
		private delegate void GetFrustumPlaneSizeAt_InjectedDelegate(IntPtr @this, float distance, [Out] IntPtr ret);

		// Token: 0x020003C6 RID: 966
		// (Invoke) Token: 0x060025B3 RID: 9651
		private delegate void ViewportPointToRay_InjectedDelegate(IntPtr @this, IntPtr pos, Camera.MonoOrStereoscopicEye eye, [Out] IntPtr ret);

		// Token: 0x020003C7 RID: 967
		// (Invoke) Token: 0x060025B5 RID: 9653
		private delegate void CalculateFrustumCornersInternal_InjectedDelegate(IntPtr @this, IntPtr viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] IntPtr outCorners);

		// Token: 0x020003C8 RID: 968
		// (Invoke) Token: 0x060025B7 RID: 9655
		private delegate void CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate([Out] IntPtr output, float focalLength, IntPtr sensorSize, IntPtr lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode);

		// Token: 0x020003C9 RID: 969
		// (Invoke) Token: 0x060025B9 RID: 9657
		private delegate void get_scene_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003CA RID: 970
		// (Invoke) Token: 0x060025BB RID: 9659
		private delegate void set_scene_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003CB RID: 971
		// (Invoke) Token: 0x060025BD RID: 9661
		private delegate void GetStereoViewMatrix_InjectedDelegate(IntPtr @this, Camera.StereoscopicEye eye, [Out] IntPtr ret);

		// Token: 0x020003CC RID: 972
		// (Invoke) Token: 0x060025BF RID: 9663
		private delegate void GetStereoProjectionMatrix_InjectedDelegate(IntPtr @this, Camera.StereoscopicEye eye, [Out] IntPtr ret);

		// Token: 0x020003CD RID: 973
		// (Invoke) Token: 0x060025C1 RID: 9665
		private delegate void SetStereoViewMatrix_InjectedDelegate(IntPtr @this, Camera.StereoscopicEye eye, IntPtr matrix);
	}
}
