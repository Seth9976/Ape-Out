using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Il2CppCodeStage.AntiCheat.Detectors
{
	// Token: 0x02000210 RID: 528
	public class WallHackDetector : ActDetectorBase
	{
		// Token: 0x06001DA0 RID: 7584 RVA: 0x00085524 File Offset: 0x00083724
		// Note: this type is marked as 'beforefieldinit'.
		static WallHackDetector()
		{
			Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.Detectors", "WallHackDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr);
			WallHackDetector.NativeFieldInfoPtr_ComponentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "ComponentName");
			WallHackDetector.NativeFieldInfoPtr_FinalLogPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "FinalLogPrefix");
			WallHackDetector.NativeFieldInfoPtr_ServiceContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "ServiceContainerName");
			WallHackDetector.NativeFieldInfoPtr_WireframeShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "WireframeShaderName");
			WallHackDetector.NativeFieldInfoPtr_ShaderTextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "ShaderTextureSize");
			WallHackDetector.NativeFieldInfoPtr_RenderTextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "RenderTextureSize");
			WallHackDetector.NativeFieldInfoPtr_rigidPlayerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "rigidPlayerVelocity");
			WallHackDetector.NativeFieldInfoPtr_instancesInScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "instancesInScene");
			WallHackDetector.NativeFieldInfoPtr_waitForEndOfFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "waitForEndOfFrame");
			WallHackDetector.NativeFieldInfoPtr_checkRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "checkRigidbody");
			WallHackDetector.NativeFieldInfoPtr_checkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "checkController");
			WallHackDetector.NativeFieldInfoPtr_checkWireframe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "checkWireframe");
			WallHackDetector.NativeFieldInfoPtr_checkRaycast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "checkRaycast");
			WallHackDetector.NativeFieldInfoPtr_wireframeDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "wireframeDelay");
			WallHackDetector.NativeFieldInfoPtr_raycastDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "raycastDelay");
			WallHackDetector.NativeFieldInfoPtr_spawnPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "spawnPosition");
			WallHackDetector.NativeFieldInfoPtr_maxFalsePositives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "maxFalsePositives");
			WallHackDetector.NativeFieldInfoPtr_serviceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "serviceContainer");
			WallHackDetector.NativeFieldInfoPtr_solidWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "solidWall");
			WallHackDetector.NativeFieldInfoPtr_thinWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "thinWall");
			WallHackDetector.NativeFieldInfoPtr_wfCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "wfCamera");
			WallHackDetector.NativeFieldInfoPtr_foregroundRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "foregroundRenderer");
			WallHackDetector.NativeFieldInfoPtr_backgroundRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "backgroundRenderer");
			WallHackDetector.NativeFieldInfoPtr_wfColor1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "wfColor1");
			WallHackDetector.NativeFieldInfoPtr_wfColor2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "wfColor2");
			WallHackDetector.NativeFieldInfoPtr_wfShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "wfShader");
			WallHackDetector.NativeFieldInfoPtr_wfMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "wfMaterial");
			WallHackDetector.NativeFieldInfoPtr_shaderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "shaderTexture");
			WallHackDetector.NativeFieldInfoPtr_targetTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "targetTexture");
			WallHackDetector.NativeFieldInfoPtr_renderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "renderTexture");
			WallHackDetector.NativeFieldInfoPtr_whLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "whLayer");
			WallHackDetector.NativeFieldInfoPtr_raycastMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "raycastMask");
			WallHackDetector.NativeFieldInfoPtr_rigidPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "rigidPlayer");
			WallHackDetector.NativeFieldInfoPtr_charControllerPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "charControllerPlayer");
			WallHackDetector.NativeFieldInfoPtr_charControllerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "charControllerVelocity");
			WallHackDetector.NativeFieldInfoPtr_rigidbodyDetections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "rigidbodyDetections");
			WallHackDetector.NativeFieldInfoPtr_controllerDetections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "controllerDetections");
			WallHackDetector.NativeFieldInfoPtr_wireframeDetections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "wireframeDetections");
			WallHackDetector.NativeFieldInfoPtr_raycastDetections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "raycastDetections");
			WallHackDetector.NativeFieldInfoPtr_wireframeDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "wireframeDetected");
			WallHackDetector.NativeFieldInfoPtr_rayHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "rayHits");
			WallHackDetector.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "<Instance>k__BackingField");
			WallHackDetector.NativeMethodInfoPtr_get_CheckRigidbody_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668114);
			WallHackDetector.NativeMethodInfoPtr_set_CheckRigidbody_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668115);
			WallHackDetector.NativeMethodInfoPtr_get_CheckController_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668116);
			WallHackDetector.NativeMethodInfoPtr_set_CheckController_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668117);
			WallHackDetector.NativeMethodInfoPtr_get_CheckWireframe_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668118);
			WallHackDetector.NativeMethodInfoPtr_set_CheckWireframe_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668119);
			WallHackDetector.NativeMethodInfoPtr_get_CheckRaycast_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668120);
			WallHackDetector.NativeMethodInfoPtr_set_CheckRaycast_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668121);
			WallHackDetector.NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_WallHackDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668122);
			WallHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668123);
			WallHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668124);
			WallHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668125);
			WallHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Vector3_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668126);
			WallHackDetector.NativeMethodInfoPtr_StopDetection_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668127);
			WallHackDetector.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668128);
			WallHackDetector.NativeMethodInfoPtr_get_Instance_Public_Static_get_WallHackDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668129);
			WallHackDetector.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_WallHackDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668130);
			WallHackDetector.NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_WallHackDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668131);
			WallHackDetector.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668132);
			WallHackDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668133);
			WallHackDetector.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668134);
			WallHackDetector.NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668135);
			WallHackDetector.NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668136);
			WallHackDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668137);
			WallHackDetector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668138);
			WallHackDetector.NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Action_Vector3_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668139);
			WallHackDetector.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668140);
			WallHackDetector.NativeMethodInfoPtr_PauseDetector_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668141);
			WallHackDetector.NativeMethodInfoPtr_ResumeDetector_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668142);
			WallHackDetector.NativeMethodInfoPtr_StopDetectionInternal_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668143);
			WallHackDetector.NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668144);
			WallHackDetector.NativeMethodInfoPtr_UpdateServiceContainer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668145);
			WallHackDetector.NativeMethodInfoPtr_InitDetector_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668146);
			WallHackDetector.NativeMethodInfoPtr_StartRigidModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668147);
			WallHackDetector.NativeMethodInfoPtr_StartControllerModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668148);
			WallHackDetector.NativeMethodInfoPtr_StartWireframeModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668149);
			WallHackDetector.NativeMethodInfoPtr_ShootWireframeModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668150);
			WallHackDetector.NativeMethodInfoPtr_CaptureFrame_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668151);
			WallHackDetector.NativeMethodInfoPtr_StartRaycastModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668152);
			WallHackDetector.NativeMethodInfoPtr_ShootRaycastModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668153);
			WallHackDetector.NativeMethodInfoPtr_StopRigidModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668154);
			WallHackDetector.NativeMethodInfoPtr_StopControllerModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668155);
			WallHackDetector.NativeMethodInfoPtr_StopWireframeModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668156);
			WallHackDetector.NativeMethodInfoPtr_StopRaycastModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668157);
			WallHackDetector.NativeMethodInfoPtr_InitRigidModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668158);
			WallHackDetector.NativeMethodInfoPtr_InitControllerModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668159);
			WallHackDetector.NativeMethodInfoPtr_UninitRigidModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668160);
			WallHackDetector.NativeMethodInfoPtr_UninitControllerModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668161);
			WallHackDetector.NativeMethodInfoPtr_Detect_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668162);
			WallHackDetector.NativeMethodInfoPtr_GenerateColor_Private_Static_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668163);
			WallHackDetector.NativeMethodInfoPtr_ColorsSimilar_Private_Static_Boolean_Color32_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, 100668164);
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x00085C98 File Offset: 0x00083E98
		// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x00085CD4 File Offset: 0x00083ED4
		public unsafe bool CheckRigidbody
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_get_CheckRigidbody_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29087, XrefRangeEnd = 29095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_set_CheckRigidbody_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x00085D14 File Offset: 0x00083F14
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x00085D50 File Offset: 0x00083F50
		public unsafe bool CheckController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_get_CheckController_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29095, XrefRangeEnd = 29103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_set_CheckController_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x00085D90 File Offset: 0x00083F90
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x00085DCC File Offset: 0x00083FCC
		public unsafe bool CheckWireframe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_get_CheckWireframe_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29103, XrefRangeEnd = 29111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_set_CheckWireframe_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00085E0C File Offset: 0x0008400C
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x00085E48 File Offset: 0x00084048
		public unsafe bool CheckRaycast
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_get_CheckRaycast_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29111, XrefRangeEnd = 29119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_set_CheckRaycast_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00085E88 File Offset: 0x00084088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29119, XrefRangeEnd = 29120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WallHackDetector AddToSceneOrGetExisting()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_WallHackDetector_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WallHackDetector>(intPtr3) : null;
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00085EBC File Offset: 0x000840BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29120, XrefRangeEnd = 29143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00085EE4 File Offset: 0x000840E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29143, XrefRangeEnd = 29147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00085F1C File Offset: 0x0008411C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29147, XrefRangeEnd = 29150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action callback, Vector3 spawnPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00085F60 File Offset: 0x00084160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29150, XrefRangeEnd = 29152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxFalsePositives;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Vector3_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00085FB4 File Offset: 0x000841B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29152, XrefRangeEnd = 29168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopDetection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StopDetection_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00085FDC File Offset: 0x000841DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29168, XrefRangeEnd = 29184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x00086004 File Offset: 0x00084204
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x00086038 File Offset: 0x00084238
		public unsafe static WallHackDetector Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29184, XrefRangeEnd = 29186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_get_Instance_Public_Static_get_WallHackDetector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WallHackDetector>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29186, XrefRangeEnd = 29188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_WallHackDetector_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00086070 File Offset: 0x00084270
		public unsafe static WallHackDetector GetOrCreateInstance
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 29231, RefRangeEnd = 29238, XrefRangeStart = 29188, XrefRangeEnd = 29231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_WallHackDetector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WallHackDetector>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x000860A4 File Offset: 0x000842A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29238, XrefRangeEnd = 29247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WallHackDetector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x000860E0 File Offset: 0x000842E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29247, XrefRangeEnd = 29264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00086114 File Offset: 0x00084314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29264, XrefRangeEnd = 29303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WallHackDetector.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00086150 File Offset: 0x00084350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29303, XrefRangeEnd = 29320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0008619C File Offset: 0x0008439C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLevelLoadedCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x000861D0 File Offset: 0x000843D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29320, XrefRangeEnd = 29338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00086204 File Offset: 0x00084404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29338, XrefRangeEnd = 29359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00086238 File Offset: 0x00084438
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 29391, RefRangeEnd = 29396, XrefRangeStart = 29359, XrefRangeEnd = 29391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDetectionInternal(Action callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref servicePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref falsePositivesInRow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Action_Vector3_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00086298 File Offset: 0x00084498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29396, XrefRangeEnd = 29397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartDetectionAutomatically()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WallHackDetector.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x000862D4 File Offset: 0x000844D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29397, XrefRangeEnd = 29401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PauseDetector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WallHackDetector.NativeMethodInfoPtr_PauseDetector_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00086310 File Offset: 0x00084510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29401, XrefRangeEnd = 29412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ResumeDetector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WallHackDetector.NativeMethodInfoPtr_ResumeDetector_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00086358 File Offset: 0x00084558
		[CallerCount(0)]
		public unsafe override void StopDetectionInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WallHackDetector.NativeMethodInfoPtr_StopDetectionInternal_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00086394 File Offset: 0x00084594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29412, XrefRangeEnd = 29435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DisposeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WallHackDetector.NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x000863D0 File Offset: 0x000845D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 29785, RefRangeEnd = 29791, XrefRangeStart = 29435, XrefRangeEnd = 29785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateServiceContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_UpdateServiceContainer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00086404 File Offset: 0x00084604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29791, XrefRangeEnd = 29794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InitDetector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_InitDetector_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00086444 File Offset: 0x00084644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29820, RefRangeEnd = 29822, XrefRangeStart = 29794, XrefRangeEnd = 29820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartRigidModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StartRigidModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00086478 File Offset: 0x00084678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29838, RefRangeEnd = 29840, XrefRangeStart = 29822, XrefRangeEnd = 29838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartControllerModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StartControllerModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x000864AC File Offset: 0x000846AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29840, XrefRangeEnd = 29843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartWireframeModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StartWireframeModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x000864E0 File Offset: 0x000846E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29843, XrefRangeEnd = 29850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShootWireframeModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_ShootWireframeModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00086514 File Offset: 0x00084714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29850, XrefRangeEnd = 29853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CaptureFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_CaptureFrame_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00086554 File Offset: 0x00084754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29853, XrefRangeEnd = 29856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartRaycastModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StartRaycastModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00086588 File Offset: 0x00084788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29856, XrefRangeEnd = 29870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShootRaycastModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_ShootRaycastModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x000865BC File Offset: 0x000847BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 29887, RefRangeEnd = 29890, XrefRangeStart = 29870, XrefRangeEnd = 29887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopRigidModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StopRigidModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x000865F0 File Offset: 0x000847F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 29900, RefRangeEnd = 29903, XrefRangeStart = 29890, XrefRangeEnd = 29900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopControllerModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StopControllerModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00086624 File Offset: 0x00084824
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 29909, RefRangeEnd = 29912, XrefRangeStart = 29903, XrefRangeEnd = 29909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopWireframeModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StopWireframeModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00086658 File Offset: 0x00084858
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 29918, RefRangeEnd = 29921, XrefRangeStart = 29912, XrefRangeEnd = 29918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopRaycastModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_StopRaycastModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x0008668C File Offset: 0x0008488C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29963, RefRangeEnd = 29964, XrefRangeStart = 29921, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitRigidModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_InitRigidModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x000866C0 File Offset: 0x000848C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29989, RefRangeEnd = 29990, XrefRangeStart = 29964, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitControllerModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_InitControllerModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x000866F4 File Offset: 0x000848F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29990, XrefRangeEnd = 29999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UninitRigidModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_UninitRigidModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00086728 File Offset: 0x00084928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29999, XrefRangeEnd = 30008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UninitControllerModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_UninitControllerModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0008675C File Offset: 0x0008495C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30008, RefRangeEnd = 30010, XrefRangeStart = 30008, XrefRangeEnd = 30008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Detect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_Detect_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00086798 File Offset: 0x00084998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30016, RefRangeEnd = 30018, XrefRangeStart = 30010, XrefRangeEnd = 30016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 GenerateColor()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_GenerateColor_Private_Static_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x000867C8 File Offset: 0x000849C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30018, XrefRangeEnd = 30025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tolerance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector.NativeMethodInfoPtr_ColorsSimilar_Private_Static_Boolean_Color32_Color32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0000AA5F File Offset: 0x00008C5F
		public WallHackDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x00086824 File Offset: 0x00084A24
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x0000AA68 File Offset: 0x00008C68
		public unsafe static string ComponentName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WallHackDetector.NativeFieldInfoPtr_ComponentName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WallHackDetector.NativeFieldInfoPtr_ComponentName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00086844 File Offset: 0x00084A44
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x0000AA7A File Offset: 0x00008C7A
		public unsafe static string FinalLogPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WallHackDetector.NativeFieldInfoPtr_FinalLogPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WallHackDetector.NativeFieldInfoPtr_FinalLogPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x00086864 File Offset: 0x00084A64
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x0000AA8C File Offset: 0x00008C8C
		public unsafe static string ServiceContainerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WallHackDetector.NativeFieldInfoPtr_ServiceContainerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WallHackDetector.NativeFieldInfoPtr_ServiceContainerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00086884 File Offset: 0x00084A84
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x0000AA9E File Offset: 0x00008C9E
		public unsafe static string WireframeShaderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WallHackDetector.NativeFieldInfoPtr_WireframeShaderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WallHackDetector.NativeFieldInfoPtr_WireframeShaderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x000868A4 File Offset: 0x00084AA4
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x0000AAB0 File Offset: 0x00008CB0
		public unsafe static int ShaderTextureSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WallHackDetector.NativeFieldInfoPtr_ShaderTextureSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WallHackDetector.NativeFieldInfoPtr_ShaderTextureSize, (void*)(&value));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x000868C0 File Offset: 0x00084AC0
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x0000AABE File Offset: 0x00008CBE
		public unsafe static int RenderTextureSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WallHackDetector.NativeFieldInfoPtr_RenderTextureSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WallHackDetector.NativeFieldInfoPtr_RenderTextureSize, (void*)(&value));
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x000868DC File Offset: 0x00084ADC
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x0000AACC File Offset: 0x00008CCC
		public unsafe Vector3 rigidPlayerVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_rigidPlayerVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_rigidPlayerVelocity)) = value;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x00086904 File Offset: 0x00084B04
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0000AAE7 File Offset: 0x00008CE7
		public unsafe static int instancesInScene
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WallHackDetector.NativeFieldInfoPtr_instancesInScene, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WallHackDetector.NativeFieldInfoPtr_instancesInScene, (void*)(&value));
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x00086920 File Offset: 0x00084B20
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x0000AAF5 File Offset: 0x00008CF5
		public unsafe WaitForEndOfFrame waitForEndOfFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_waitForEndOfFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForEndOfFrame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_waitForEndOfFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x00086950 File Offset: 0x00084B50
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x0000AB14 File Offset: 0x00008D14
		public unsafe bool checkRigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_checkRigidbody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_checkRigidbody)) = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00086978 File Offset: 0x00084B78
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x0000AB2F File Offset: 0x00008D2F
		public unsafe bool checkController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_checkController);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_checkController)) = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x000869A0 File Offset: 0x00084BA0
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x0000AB4A File Offset: 0x00008D4A
		public unsafe bool checkWireframe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_checkWireframe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_checkWireframe)) = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x000869C8 File Offset: 0x00084BC8
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x0000AB65 File Offset: 0x00008D65
		public unsafe bool checkRaycast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_checkRaycast);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_checkRaycast)) = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x000869F0 File Offset: 0x00084BF0
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x0000AB80 File Offset: 0x00008D80
		public unsafe int wireframeDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wireframeDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wireframeDelay)) = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x00086A18 File Offset: 0x00084C18
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x0000AB9B File Offset: 0x00008D9B
		public unsafe int raycastDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_raycastDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_raycastDelay)) = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x00086A40 File Offset: 0x00084C40
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x0000ABB6 File Offset: 0x00008DB6
		public unsafe Vector3 spawnPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_spawnPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_spawnPosition)) = value;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x00086A68 File Offset: 0x00084C68
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x0000ABD1 File Offset: 0x00008DD1
		public unsafe byte maxFalsePositives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_maxFalsePositives);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_maxFalsePositives)) = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x00086A90 File Offset: 0x00084C90
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x0000ABEC File Offset: 0x00008DEC
		public unsafe GameObject serviceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_serviceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_serviceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x00086AC0 File Offset: 0x00084CC0
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x0000AC0B File Offset: 0x00008E0B
		public unsafe GameObject solidWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_solidWall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_solidWall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x00086AF0 File Offset: 0x00084CF0
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x0000AC2A File Offset: 0x00008E2A
		public unsafe GameObject thinWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_thinWall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_thinWall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x00086B20 File Offset: 0x00084D20
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x0000AC49 File Offset: 0x00008E49
		public unsafe Camera wfCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wfCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wfCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x00086B50 File Offset: 0x00084D50
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x0000AC68 File Offset: 0x00008E68
		public unsafe MeshRenderer foregroundRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_foregroundRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_foregroundRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x00086B80 File Offset: 0x00084D80
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x0000AC87 File Offset: 0x00008E87
		public unsafe MeshRenderer backgroundRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_backgroundRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_backgroundRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00086BB0 File Offset: 0x00084DB0
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0000ACA6 File Offset: 0x00008EA6
		public unsafe Color wfColor1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wfColor1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wfColor1)) = value;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x00086BD8 File Offset: 0x00084DD8
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0000ACC1 File Offset: 0x00008EC1
		public unsafe Color wfColor2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wfColor2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wfColor2)) = value;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x00086C00 File Offset: 0x00084E00
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0000ACDC File Offset: 0x00008EDC
		public unsafe Shader wfShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wfShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wfShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x00086C30 File Offset: 0x00084E30
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0000ACFB File Offset: 0x00008EFB
		public unsafe Material wfMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wfMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wfMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x00086C60 File Offset: 0x00084E60
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x0000AD1A File Offset: 0x00008F1A
		public unsafe Texture2D shaderTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_shaderTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_shaderTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x00086C90 File Offset: 0x00084E90
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x0000AD39 File Offset: 0x00008F39
		public unsafe Texture2D targetTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_targetTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_targetTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x00086CC0 File Offset: 0x00084EC0
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x0000AD58 File Offset: 0x00008F58
		public unsafe RenderTexture renderTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_renderTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_renderTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x00086CF0 File Offset: 0x00084EF0
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0000AD77 File Offset: 0x00008F77
		public unsafe int whLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_whLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_whLayer)) = value;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00086D18 File Offset: 0x00084F18
		// (set) Token: 0x06001E14 RID: 7700 RVA: 0x0000AD92 File Offset: 0x00008F92
		public unsafe int raycastMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_raycastMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_raycastMask)) = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x00086D40 File Offset: 0x00084F40
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x0000ADAD File Offset: 0x00008FAD
		public unsafe Rigidbody rigidPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_rigidPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_rigidPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x00086D70 File Offset: 0x00084F70
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x0000ADCC File Offset: 0x00008FCC
		public unsafe CharacterController charControllerPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_charControllerPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_charControllerPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x00086DA0 File Offset: 0x00084FA0
		// (set) Token: 0x06001E1A RID: 7706 RVA: 0x0000ADEB File Offset: 0x00008FEB
		public unsafe float charControllerVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_charControllerVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_charControllerVelocity)) = value;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00086DC8 File Offset: 0x00084FC8
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x0000AE06 File Offset: 0x00009006
		public unsafe byte rigidbodyDetections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_rigidbodyDetections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_rigidbodyDetections)) = value;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x00086DF0 File Offset: 0x00084FF0
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x0000AE21 File Offset: 0x00009021
		public unsafe byte controllerDetections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_controllerDetections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_controllerDetections)) = value;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x00086E18 File Offset: 0x00085018
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x0000AE3C File Offset: 0x0000903C
		public unsafe byte wireframeDetections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wireframeDetections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wireframeDetections)) = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x00086E40 File Offset: 0x00085040
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x0000AE57 File Offset: 0x00009057
		public unsafe byte raycastDetections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_raycastDetections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_raycastDetections)) = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x00086E68 File Offset: 0x00085068
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x0000AE72 File Offset: 0x00009072
		public unsafe bool wireframeDetected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wireframeDetected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_wireframeDetected)) = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00086E90 File Offset: 0x00085090
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x0000AE8D File Offset: 0x0000908D
		public unsafe Il2CppStructArray<RaycastHit> rayHits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_rayHits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector.NativeFieldInfoPtr_rayHits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00086EC0 File Offset: 0x000850C0
		// (set) Token: 0x06001E28 RID: 7720 RVA: 0x0000AEAC File Offset: 0x000090AC
		public unsafe static WallHackDetector _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WallHackDetector.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WallHackDetector>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WallHackDetector.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeFieldInfoPtr_ComponentName;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeFieldInfoPtr_FinalLogPrefix;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeFieldInfoPtr_ServiceContainerName;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeFieldInfoPtr_WireframeShaderName;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeFieldInfoPtr_ShaderTextureSize;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeFieldInfoPtr_RenderTextureSize;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeFieldInfoPtr_rigidPlayerVelocity;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeFieldInfoPtr_instancesInScene;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeFieldInfoPtr_waitForEndOfFrame;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeFieldInfoPtr_checkRigidbody;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeFieldInfoPtr_checkController;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeFieldInfoPtr_checkWireframe;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeFieldInfoPtr_checkRaycast;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeFieldInfoPtr_wireframeDelay;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeFieldInfoPtr_raycastDelay;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeFieldInfoPtr_spawnPosition;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeFieldInfoPtr_maxFalsePositives;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeFieldInfoPtr_serviceContainer;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeFieldInfoPtr_solidWall;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeFieldInfoPtr_thinWall;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeFieldInfoPtr_wfCamera;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeFieldInfoPtr_foregroundRenderer;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeFieldInfoPtr_backgroundRenderer;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeFieldInfoPtr_wfColor1;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeFieldInfoPtr_wfColor2;

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeFieldInfoPtr_wfShader;

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeFieldInfoPtr_wfMaterial;

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeFieldInfoPtr_shaderTexture;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeFieldInfoPtr_targetTexture;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeFieldInfoPtr_renderTexture;

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeFieldInfoPtr_whLayer;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeFieldInfoPtr_raycastMask;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeFieldInfoPtr_rigidPlayer;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeFieldInfoPtr_charControllerPlayer;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeFieldInfoPtr_charControllerVelocity;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeFieldInfoPtr_rigidbodyDetections;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeFieldInfoPtr_controllerDetections;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeFieldInfoPtr_wireframeDetections;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeFieldInfoPtr_raycastDetections;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeFieldInfoPtr_wireframeDetected;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeFieldInfoPtr_rayHits;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckRigidbody_Public_get_Boolean_0;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckRigidbody_Public_set_Void_Boolean_0;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckController_Public_get_Boolean_0;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckController_Public_set_Void_Boolean_0;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckWireframe_Public_get_Boolean_0;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckWireframe_Public_set_Void_Boolean_0;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckRaycast_Public_get_Boolean_0;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckRaycast_Public_set_Void_Boolean_0;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_WallHackDetector_0;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_0;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_0;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Vector3_0;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Vector3_Byte_0;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeMethodInfoPtr_StopDetection_Public_Static_Void_0;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_WallHackDetector_0;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_WallHackDetector_0;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_WallHackDetector_0;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001ED8 RID: 7896
		private static readonly IntPtr NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Action_Vector3_Byte_0;

		// Token: 0x04001ED9 RID: 7897
		private static readonly IntPtr NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0;

		// Token: 0x04001EDA RID: 7898
		private static readonly IntPtr NativeMethodInfoPtr_PauseDetector_Protected_Virtual_Void_0;

		// Token: 0x04001EDB RID: 7899
		private static readonly IntPtr NativeMethodInfoPtr_ResumeDetector_Protected_Virtual_Boolean_0;

		// Token: 0x04001EDC RID: 7900
		private static readonly IntPtr NativeMethodInfoPtr_StopDetectionInternal_Protected_Virtual_Void_0;

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeMethodInfoPtr_UpdateServiceContainer_Private_Void_0;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeMethodInfoPtr_InitDetector_Private_IEnumerator_0;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeMethodInfoPtr_StartRigidModule_Private_Void_0;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeMethodInfoPtr_StartControllerModule_Private_Void_0;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeMethodInfoPtr_StartWireframeModule_Private_Void_0;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeMethodInfoPtr_ShootWireframeModule_Private_Void_0;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeMethodInfoPtr_CaptureFrame_Private_IEnumerator_0;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeMethodInfoPtr_StartRaycastModule_Private_Void_0;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeMethodInfoPtr_ShootRaycastModule_Private_Void_0;

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeMethodInfoPtr_StopRigidModule_Private_Void_0;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeMethodInfoPtr_StopControllerModule_Private_Void_0;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeMethodInfoPtr_StopWireframeModule_Private_Void_0;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeMethodInfoPtr_StopRaycastModule_Private_Void_0;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeMethodInfoPtr_InitRigidModule_Private_Void_0;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeMethodInfoPtr_InitControllerModule_Private_Void_0;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr_UninitRigidModule_Private_Void_0;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeMethodInfoPtr_UninitControllerModule_Private_Void_0;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeMethodInfoPtr_Detect_Private_Boolean_0;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeMethodInfoPtr_GenerateColor_Private_Static_Color32_0;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeMethodInfoPtr_ColorsSimilar_Private_Static_Boolean_Color32_Color32_Int32_0;

		// Token: 0x020002C8 RID: 712
		[ObfuscatedName("CodeStage.AntiCheat.Detectors.WallHackDetector+<InitDetector>d__80")]
		public sealed class _InitDetector_d__80 : global::Il2CppSystem.Object
		{
			// Token: 0x06002483 RID: 9347 RVA: 0x0009B66C File Offset: 0x0009986C
			// Note: this type is marked as 'beforefieldinit'.
			static _InitDetector_d__80()
			{
				Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "<InitDetector>d__80");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr);
				WallHackDetector._InitDetector_d__80.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr, "<>1__state");
				WallHackDetector._InitDetector_d__80.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr, "<>2__current");
				WallHackDetector._InitDetector_d__80.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr, "<>4__this");
				WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr, 100668165);
				WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr, 100668166);
				WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr, 100668167);
				WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr, 100668168);
				WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr, 100668169);
				WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr, 100668170);
			}

			// Token: 0x06002484 RID: 9348 RVA: 0x0009B74C File Offset: 0x0009994C
			[CallerCount(0)]
			public unsafe _InitDetector_d__80(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallHackDetector._InitDetector_d__80>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002485 RID: 9349 RVA: 0x0009B794 File Offset: 0x00099994
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002486 RID: 9350 RVA: 0x0009B7C8 File Offset: 0x000999C8
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x06002487 RID: 9351 RVA: 0x0009B804 File Offset: 0x00099A04
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002488 RID: 9352 RVA: 0x0009B844 File Offset: 0x00099A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29064, XrefRangeEnd = 29069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x06002489 RID: 9353 RVA: 0x0009B878 File Offset: 0x00099A78
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._InitDetector_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600248A RID: 9354 RVA: 0x0000DC18 File Offset: 0x0000BE18
			public _InitDetector_d__80(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700076B RID: 1899
			// (get) Token: 0x0600248B RID: 9355 RVA: 0x0009B8B8 File Offset: 0x00099AB8
			// (set) Token: 0x0600248C RID: 9356 RVA: 0x0000DC21 File Offset: 0x0000BE21
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._InitDetector_d__80.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._InitDetector_d__80.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700076C RID: 1900
			// (get) Token: 0x0600248D RID: 9357 RVA: 0x0009B8E0 File Offset: 0x00099AE0
			// (set) Token: 0x0600248E RID: 9358 RVA: 0x0000DC3C File Offset: 0x0000BE3C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._InitDetector_d__80.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._InitDetector_d__80.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x0600248F RID: 9359 RVA: 0x0009B910 File Offset: 0x00099B10
			// (set) Token: 0x06002490 RID: 9360 RVA: 0x0000DC5B File Offset: 0x0000BE5B
			public unsafe WallHackDetector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._InitDetector_d__80.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WallHackDetector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._InitDetector_d__80.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022F8 RID: 8952
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022F9 RID: 8953
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040022FA RID: 8954
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040022FB RID: 8955
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040022FC RID: 8956
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022FD RID: 8957
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040022FE RID: 8958
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040022FF RID: 8959
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002300 RID: 8960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002C9 RID: 713
		[ObfuscatedName("CodeStage.AntiCheat.Detectors.WallHackDetector+<CaptureFrame>d__85")]
		public sealed class _CaptureFrame_d__85 : global::Il2CppSystem.Object
		{
			// Token: 0x06002491 RID: 9361 RVA: 0x0009B940 File Offset: 0x00099B40
			// Note: this type is marked as 'beforefieldinit'.
			static _CaptureFrame_d__85()
			{
				Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WallHackDetector>.NativeClassPtr, "<CaptureFrame>d__85");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr);
				WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr, "<>1__state");
				WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr, "<>2__current");
				WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr, "<>4__this");
				WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr__previousActive_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr, "<previousActive>5__2");
				WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr, 100668171);
				WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr, 100668172);
				WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr, 100668173);
				WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr, 100668174);
				WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr, 100668175);
				WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr, 100668176);
			}

			// Token: 0x06002492 RID: 9362 RVA: 0x0009BA34 File Offset: 0x00099C34
			[CallerCount(0)]
			public unsafe _CaptureFrame_d__85(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallHackDetector._CaptureFrame_d__85>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002493 RID: 9363 RVA: 0x0009BA7C File Offset: 0x00099C7C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002494 RID: 9364 RVA: 0x0009BAB0 File Offset: 0x00099CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29069, XrefRangeEnd = 29082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000774 RID: 1908
			// (get) Token: 0x06002495 RID: 9365 RVA: 0x0009BAEC File Offset: 0x00099CEC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002496 RID: 9366 RVA: 0x0009BB2C File Offset: 0x00099D2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29082, XrefRangeEnd = 29087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000775 RID: 1909
			// (get) Token: 0x06002497 RID: 9367 RVA: 0x0009BB60 File Offset: 0x00099D60
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallHackDetector._CaptureFrame_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002498 RID: 9368 RVA: 0x0000DC7A File Offset: 0x0000BE7A
			public _CaptureFrame_d__85(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x06002499 RID: 9369 RVA: 0x0009BBA0 File Offset: 0x00099DA0
			// (set) Token: 0x0600249A RID: 9370 RVA: 0x0000DC83 File Offset: 0x0000BE83
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x0600249B RID: 9371 RVA: 0x0009BBC8 File Offset: 0x00099DC8
			// (set) Token: 0x0600249C RID: 9372 RVA: 0x0000DC9E File Offset: 0x0000BE9E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x0600249D RID: 9373 RVA: 0x0009BBF8 File Offset: 0x00099DF8
			// (set) Token: 0x0600249E RID: 9374 RVA: 0x0000DCBD File Offset: 0x0000BEBD
			public unsafe WallHackDetector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WallHackDetector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000773 RID: 1907
			// (get) Token: 0x0600249F RID: 9375 RVA: 0x0009BC28 File Offset: 0x00099E28
			// (set) Token: 0x060024A0 RID: 9376 RVA: 0x0000DCDC File Offset: 0x0000BEDC
			public unsafe RenderTexture _previousActive_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr__previousActive_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallHackDetector._CaptureFrame_d__85.NativeFieldInfoPtr__previousActive_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002301 RID: 8961
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002302 RID: 8962
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002303 RID: 8963
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002304 RID: 8964
			private static readonly IntPtr NativeFieldInfoPtr__previousActive_5__2;

			// Token: 0x04002305 RID: 8965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002306 RID: 8966
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002307 RID: 8967
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002308 RID: 8968
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002309 RID: 8969
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400230A RID: 8970
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
