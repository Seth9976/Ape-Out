using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class Physics2D : Object
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0000665C File Offset: 0x0000485C
		// Note: this type is marked as 'beforefieldinit'.
		static Physics2D()
		{
			Il2CppClassPointerStore<Physics2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Physics2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics2D>.NativeClassPtr);
			Physics2D.NativeFieldInfoPtr_m_LastDisabledRigidbody2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, "m_LastDisabledRigidbody2D");
			Physics2D.NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663337);
			Physics2D.NativeMethodInfoPtr_get_queriesHitTriggers_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663338);
			Physics2D.NativeMethodInfoPtr_set_simulationMode_Public_Static_set_Void_SimulationMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663339);
			Physics2D.NativeMethodInfoPtr_Simulate_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663340);
			Physics2D.NativeMethodInfoPtr_Simulate_Internal_Internal_Static_Boolean_PhysicsScene2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663341);
			Physics2D.NativeMethodInfoPtr_IgnoreCollision_Public_Static_Void_Collider2D_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663342);
			Physics2D.NativeMethodInfoPtr_IgnoreCollision_Public_Static_Void_Collider2D_Collider2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663343);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663344);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663345);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663346);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663347);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663348);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663349);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663350);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_List_1_RaycastHit2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663351);
			Physics2D.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector2_Vector2_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663352);
			Physics2D.NativeMethodInfoPtr_CircleCast_Public_Static_RaycastHit2D_Vector2_Single_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663353);
			Physics2D.NativeMethodInfoPtr_CircleCast_Public_Static_Int32_Vector2_Single_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663354);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663355);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663356);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663357);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Private_Static_Il2CppStructArray_1_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663358);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663359);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663360);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663361);
			Physics2D.NativeMethodInfoPtr_OverlapPoint_Public_Static_Collider2D_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663362);
			Physics2D.NativeMethodInfoPtr_OverlapCircle_Public_Static_Collider2D_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663363);
			Physics2D.NativeMethodInfoPtr_OverlapCircleAll_Public_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663364);
			Physics2D.NativeMethodInfoPtr_OverlapCircleAll_Internal_Private_Static_Il2CppReferenceArray_1_Collider2D_PhysicsScene2D_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663365);
			Physics2D.NativeMethodInfoPtr_OverlapCircleNonAlloc_Public_Static_Int32_Vector2_Single_Il2CppReferenceArray_1_Collider2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663366);
			Physics2D.NativeMethodInfoPtr_OverlapBox_Public_Static_Collider2D_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663367);
			Physics2D.NativeMethodInfoPtr_OverlapBoxAll_Public_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Vector2_Single_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663368);
			Physics2D.NativeMethodInfoPtr_OverlapBoxAll_Internal_Private_Static_Il2CppReferenceArray_1_Collider2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663369);
			Physics2D.NativeMethodInfoPtr_OverlapAreaAll_Public_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663370);
			Physics2D.NativeMethodInfoPtr_OverlapAreaAllToBox_Internal_Private_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Vector2_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663371);
			Physics2D.NativeMethodInfoPtr_OverlapAreaNonAlloc_Public_Static_Int32_Vector2_Vector2_Il2CppReferenceArray_1_Collider2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663372);
			Physics2D.NativeMethodInfoPtr_Simulate_Internal_Injected_Private_Static_Boolean_byref_PhysicsScene2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663374);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Injected_Private_Static_Il2CppStructArray_1_RaycastHit2D_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663375);
			Physics2D.NativeMethodInfoPtr_OverlapCircleAll_Internal_Injected_Private_Static_Il2CppReferenceArray_1_Collider2D_byref_PhysicsScene2D_byref_Vector2_Single_byref_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663376);
			Physics2D.NativeMethodInfoPtr_OverlapBoxAll_Internal_Injected_Private_Static_Il2CppReferenceArray_1_Collider2D_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663377);
			Physics2D.get_velocityIterationsDelegateField = IL2CPP.ResolveICall<Physics2D.get_velocityIterationsDelegate>("UnityEngine.Physics2D::get_velocityIterations");
			Physics2D.set_velocityIterationsDelegateField = IL2CPP.ResolveICall<Physics2D.set_velocityIterationsDelegate>("UnityEngine.Physics2D::set_velocityIterations");
			Physics2D.get_positionIterationsDelegateField = IL2CPP.ResolveICall<Physics2D.get_positionIterationsDelegate>("UnityEngine.Physics2D::get_positionIterations");
			Physics2D.set_positionIterationsDelegateField = IL2CPP.ResolveICall<Physics2D.set_positionIterationsDelegate>("UnityEngine.Physics2D::set_positionIterations");
			Physics2D.set_queriesHitTriggersDelegateField = IL2CPP.ResolveICall<Physics2D.set_queriesHitTriggersDelegate>("UnityEngine.Physics2D::set_queriesHitTriggers");
			Physics2D.get_queriesStartInCollidersDelegateField = IL2CPP.ResolveICall<Physics2D.get_queriesStartInCollidersDelegate>("UnityEngine.Physics2D::get_queriesStartInColliders");
			Physics2D.set_queriesStartInCollidersDelegateField = IL2CPP.ResolveICall<Physics2D.set_queriesStartInCollidersDelegate>("UnityEngine.Physics2D::set_queriesStartInColliders");
			Physics2D.get_callbacksOnDisableDelegateField = IL2CPP.ResolveICall<Physics2D.get_callbacksOnDisableDelegate>("UnityEngine.Physics2D::get_callbacksOnDisable");
			Physics2D.set_callbacksOnDisableDelegateField = IL2CPP.ResolveICall<Physics2D.set_callbacksOnDisableDelegate>("UnityEngine.Physics2D::set_callbacksOnDisable");
			Physics2D.get_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<Physics2D.get_reuseCollisionCallbacksDelegate>("UnityEngine.Physics2D::get_reuseCollisionCallbacks");
			Physics2D.set_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<Physics2D.set_reuseCollisionCallbacksDelegate>("UnityEngine.Physics2D::set_reuseCollisionCallbacks");
			Physics2D.get_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<Physics2D.get_autoSyncTransformsDelegate>("UnityEngine.Physics2D::get_autoSyncTransforms");
			Physics2D.set_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<Physics2D.set_autoSyncTransformsDelegate>("UnityEngine.Physics2D::set_autoSyncTransforms");
			Physics2D.get_simulationModeDelegateField = IL2CPP.ResolveICall<Physics2D.get_simulationModeDelegate>("UnityEngine.Physics2D::get_simulationMode");
			Physics2D.get_velocityThresholdDelegateField = IL2CPP.ResolveICall<Physics2D.get_velocityThresholdDelegate>("UnityEngine.Physics2D::get_velocityThreshold");
			Physics2D.set_velocityThresholdDelegateField = IL2CPP.ResolveICall<Physics2D.set_velocityThresholdDelegate>("UnityEngine.Physics2D::set_velocityThreshold");
			Physics2D.get_maxLinearCorrectionDelegateField = IL2CPP.ResolveICall<Physics2D.get_maxLinearCorrectionDelegate>("UnityEngine.Physics2D::get_maxLinearCorrection");
			Physics2D.set_maxLinearCorrectionDelegateField = IL2CPP.ResolveICall<Physics2D.set_maxLinearCorrectionDelegate>("UnityEngine.Physics2D::set_maxLinearCorrection");
			Physics2D.get_maxAngularCorrectionDelegateField = IL2CPP.ResolveICall<Physics2D.get_maxAngularCorrectionDelegate>("UnityEngine.Physics2D::get_maxAngularCorrection");
			Physics2D.set_maxAngularCorrectionDelegateField = IL2CPP.ResolveICall<Physics2D.set_maxAngularCorrectionDelegate>("UnityEngine.Physics2D::set_maxAngularCorrection");
			Physics2D.get_maxTranslationSpeedDelegateField = IL2CPP.ResolveICall<Physics2D.get_maxTranslationSpeedDelegate>("UnityEngine.Physics2D::get_maxTranslationSpeed");
			Physics2D.set_maxTranslationSpeedDelegateField = IL2CPP.ResolveICall<Physics2D.set_maxTranslationSpeedDelegate>("UnityEngine.Physics2D::set_maxTranslationSpeed");
			Physics2D.get_maxRotationSpeedDelegateField = IL2CPP.ResolveICall<Physics2D.get_maxRotationSpeedDelegate>("UnityEngine.Physics2D::get_maxRotationSpeed");
			Physics2D.set_maxRotationSpeedDelegateField = IL2CPP.ResolveICall<Physics2D.set_maxRotationSpeedDelegate>("UnityEngine.Physics2D::set_maxRotationSpeed");
			Physics2D.get_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<Physics2D.get_defaultContactOffsetDelegate>("UnityEngine.Physics2D::get_defaultContactOffset");
			Physics2D.set_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<Physics2D.set_defaultContactOffsetDelegate>("UnityEngine.Physics2D::set_defaultContactOffset");
			Physics2D.get_baumgarteScaleDelegateField = IL2CPP.ResolveICall<Physics2D.get_baumgarteScaleDelegate>("UnityEngine.Physics2D::get_baumgarteScale");
			Physics2D.set_baumgarteScaleDelegateField = IL2CPP.ResolveICall<Physics2D.set_baumgarteScaleDelegate>("UnityEngine.Physics2D::set_baumgarteScale");
			Physics2D.get_baumgarteTOIScaleDelegateField = IL2CPP.ResolveICall<Physics2D.get_baumgarteTOIScaleDelegate>("UnityEngine.Physics2D::get_baumgarteTOIScale");
			Physics2D.set_baumgarteTOIScaleDelegateField = IL2CPP.ResolveICall<Physics2D.set_baumgarteTOIScaleDelegate>("UnityEngine.Physics2D::set_baumgarteTOIScale");
			Physics2D.get_timeToSleepDelegateField = IL2CPP.ResolveICall<Physics2D.get_timeToSleepDelegate>("UnityEngine.Physics2D::get_timeToSleep");
			Physics2D.set_timeToSleepDelegateField = IL2CPP.ResolveICall<Physics2D.set_timeToSleepDelegate>("UnityEngine.Physics2D::set_timeToSleep");
			Physics2D.get_linearSleepToleranceDelegateField = IL2CPP.ResolveICall<Physics2D.get_linearSleepToleranceDelegate>("UnityEngine.Physics2D::get_linearSleepTolerance");
			Physics2D.set_linearSleepToleranceDelegateField = IL2CPP.ResolveICall<Physics2D.set_linearSleepToleranceDelegate>("UnityEngine.Physics2D::set_linearSleepTolerance");
			Physics2D.get_angularSleepToleranceDelegateField = IL2CPP.ResolveICall<Physics2D.get_angularSleepToleranceDelegate>("UnityEngine.Physics2D::get_angularSleepTolerance");
			Physics2D.set_angularSleepToleranceDelegateField = IL2CPP.ResolveICall<Physics2D.set_angularSleepToleranceDelegate>("UnityEngine.Physics2D::set_angularSleepTolerance");
			Physics2D.get_alwaysShowCollidersDelegateField = IL2CPP.ResolveICall<Physics2D.get_alwaysShowCollidersDelegate>("UnityEngine.Physics2D::get_alwaysShowColliders");
			Physics2D.set_alwaysShowCollidersDelegateField = IL2CPP.ResolveICall<Physics2D.set_alwaysShowCollidersDelegate>("UnityEngine.Physics2D::set_alwaysShowColliders");
			Physics2D.get_showColliderSleepDelegateField = IL2CPP.ResolveICall<Physics2D.get_showColliderSleepDelegate>("UnityEngine.Physics2D::get_showColliderSleep");
			Physics2D.set_showColliderSleepDelegateField = IL2CPP.ResolveICall<Physics2D.set_showColliderSleepDelegate>("UnityEngine.Physics2D::set_showColliderSleep");
			Physics2D.get_showColliderContactsDelegateField = IL2CPP.ResolveICall<Physics2D.get_showColliderContactsDelegate>("UnityEngine.Physics2D::get_showColliderContacts");
			Physics2D.set_showColliderContactsDelegateField = IL2CPP.ResolveICall<Physics2D.set_showColliderContactsDelegate>("UnityEngine.Physics2D::set_showColliderContacts");
			Physics2D.get_showColliderAABBDelegateField = IL2CPP.ResolveICall<Physics2D.get_showColliderAABBDelegate>("UnityEngine.Physics2D::get_showColliderAABB");
			Physics2D.set_showColliderAABBDelegateField = IL2CPP.ResolveICall<Physics2D.set_showColliderAABBDelegate>("UnityEngine.Physics2D::set_showColliderAABB");
			Physics2D.get_contactArrowScaleDelegateField = IL2CPP.ResolveICall<Physics2D.get_contactArrowScaleDelegate>("UnityEngine.Physics2D::get_contactArrowScale");
			Physics2D.set_contactArrowScaleDelegateField = IL2CPP.ResolveICall<Physics2D.set_contactArrowScaleDelegate>("UnityEngine.Physics2D::set_contactArrowScale");
			Physics2D.SyncTransformsDelegateField = IL2CPP.ResolveICall<Physics2D.SyncTransformsDelegate>("UnityEngine.Physics2D::SyncTransforms");
			Physics2D.GetIgnoreCollisionDelegateField = IL2CPP.ResolveICall<Physics2D.GetIgnoreCollisionDelegate>("UnityEngine.Physics2D::GetIgnoreCollision");
			Physics2D.IgnoreLayerCollision_InternalDelegateField = IL2CPP.ResolveICall<Physics2D.IgnoreLayerCollision_InternalDelegate>("UnityEngine.Physics2D::IgnoreLayerCollision_Internal");
			Physics2D.GetIgnoreLayerCollision_InternalDelegateField = IL2CPP.ResolveICall<Physics2D.GetIgnoreLayerCollision_InternalDelegate>("UnityEngine.Physics2D::GetIgnoreLayerCollision_Internal");
			Physics2D.SetLayerCollisionMask_InternalDelegateField = IL2CPP.ResolveICall<Physics2D.SetLayerCollisionMask_InternalDelegate>("UnityEngine.Physics2D::SetLayerCollisionMask_Internal");
			Physics2D.GetLayerCollisionMask_InternalDelegateField = IL2CPP.ResolveICall<Physics2D.GetLayerCollisionMask_InternalDelegate>("UnityEngine.Physics2D::GetLayerCollisionMask_Internal");
			Physics2D.IsTouchingDelegateField = IL2CPP.ResolveICall<Physics2D.IsTouchingDelegate>("UnityEngine.Physics2D::IsTouching");
			Physics2D.IsTouchingLayersDelegateField = IL2CPP.ResolveICall<Physics2D.IsTouchingLayersDelegate>("UnityEngine.Physics2D::IsTouchingLayers");
			Physics2D.get_gravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.get_gravity_InjectedDelegate>("UnityEngine.Physics2D::get_gravity_Injected");
			Physics2D.set_gravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.set_gravity_InjectedDelegate>("UnityEngine.Physics2D::set_gravity_Injected");
			Physics2D.get_colliderAwakeColor_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.get_colliderAwakeColor_InjectedDelegate>("UnityEngine.Physics2D::get_colliderAwakeColor_Injected");
			Physics2D.set_colliderAwakeColor_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.set_colliderAwakeColor_InjectedDelegate>("UnityEngine.Physics2D::set_colliderAwakeColor_Injected");
			Physics2D.get_colliderAsleepColor_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.get_colliderAsleepColor_InjectedDelegate>("UnityEngine.Physics2D::get_colliderAsleepColor_Injected");
			Physics2D.set_colliderAsleepColor_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.set_colliderAsleepColor_InjectedDelegate>("UnityEngine.Physics2D::set_colliderAsleepColor_Injected");
			Physics2D.get_colliderContactColor_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.get_colliderContactColor_InjectedDelegate>("UnityEngine.Physics2D::get_colliderContactColor_Injected");
			Physics2D.set_colliderContactColor_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.set_colliderContactColor_InjectedDelegate>("UnityEngine.Physics2D::set_colliderContactColor_Injected");
			Physics2D.get_colliderAABBColor_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.get_colliderAABBColor_InjectedDelegate>("UnityEngine.Physics2D::get_colliderAABBColor_Injected");
			Physics2D.set_colliderAABBColor_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.set_colliderAABBColor_InjectedDelegate>("UnityEngine.Physics2D::set_colliderAABBColor_Injected");
			Physics2D.IsTouching_TwoCollidersWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.IsTouching_TwoCollidersWithFilter_InjectedDelegate>("UnityEngine.Physics2D::IsTouching_TwoCollidersWithFilter_Injected");
			Physics2D.IsTouching_SingleColliderWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.IsTouching_SingleColliderWithFilter_InjectedDelegate>("UnityEngine.Physics2D::IsTouching_SingleColliderWithFilter_Injected");
			Physics2D.ClosestPoint_Collider_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.ClosestPoint_Collider_InjectedDelegate>("UnityEngine.Physics2D::ClosestPoint_Collider_Injected");
			Physics2D.ClosestPoint_Rigidbody_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.ClosestPoint_Rigidbody_InjectedDelegate>("UnityEngine.Physics2D::ClosestPoint_Rigidbody_Injected");
			Physics2D.LinecastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.LinecastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::LinecastAll_Internal_Injected");
			Physics2D.RaycastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.RaycastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::RaycastAll_Internal_Injected");
			Physics2D.CircleCastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.CircleCastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::CircleCastAll_Internal_Injected");
			Physics2D.BoxCastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.BoxCastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::BoxCastAll_Internal_Injected");
			Physics2D.CapsuleCastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.CapsuleCastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::CapsuleCastAll_Internal_Injected");
			Physics2D.OverlapPointAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.OverlapPointAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::OverlapPointAll_Internal_Injected");
			Physics2D.OverlapCapsuleAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.OverlapCapsuleAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::OverlapCapsuleAll_Internal_Injected");
			Physics2D.GetColliderContactsArray_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderContactsArray_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsArray_Injected");
			Physics2D.GetColliderColliderContactsArray_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderColliderContactsArray_InjectedDelegate>("UnityEngine.Physics2D::GetColliderColliderContactsArray_Injected");
			Physics2D.GetRigidbodyContactsArray_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetRigidbodyContactsArray_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsArray_Injected");
			Physics2D.GetColliderContactsCollidersOnlyArray_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderContactsCollidersOnlyArray_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsCollidersOnlyArray_Injected");
			Physics2D.GetRigidbodyContactsCollidersOnlyArray_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetRigidbodyContactsCollidersOnlyArray_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsCollidersOnlyArray_Injected");
			Physics2D.GetColliderContactsList_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderContactsList_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsList_Injected");
			Physics2D.GetColliderColliderContactsList_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderColliderContactsList_InjectedDelegate>("UnityEngine.Physics2D::GetColliderColliderContactsList_Injected");
			Physics2D.GetRigidbodyContactsList_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetRigidbodyContactsList_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsList_Injected");
			Physics2D.GetColliderContactsCollidersOnlyList_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderContactsCollidersOnlyList_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsCollidersOnlyList_Injected");
			Physics2D.GetRigidbodyContactsCollidersOnlyList_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetRigidbodyContactsCollidersOnlyList_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsCollidersOnlyList_Injected");
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00006EBC File Offset: 0x000050BC
		public unsafe static PhysicsScene2D defaultPhysicsScene
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00006EEC File Offset: 0x000050EC
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002330 File Offset: 0x00000530
		public unsafe static bool queriesHitTriggers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512641, XrefRangeEnd = 512645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_get_queriesHitTriggers_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Physics2D.set_queriesHitTriggersDelegateField(value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000023A1 File Offset: 0x000005A1
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00006F1C File Offset: 0x0000511C
		public unsafe static SimulationMode2D simulationMode
		{
			get
			{
				return Physics2D.get_simulationModeDelegateField();
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512645, XrefRangeEnd = 512649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_set_simulationMode_Public_Static_set_Void_SimulationMode2D_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00006F50 File Offset: 0x00005150
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 512658, RefRangeEnd = 512661, XrefRangeStart = 512649, XrefRangeEnd = 512658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Simulate(float step)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref step;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Simulate_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006F90 File Offset: 0x00005190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512661, XrefRangeEnd = 512666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Simulate_Internal(PhysicsScene2D physicsScene, float step)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Simulate_Internal_Internal_Static_Boolean_PhysicsScene2D_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00006FDC File Offset: 0x000051DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 512673, RefRangeEnd = 512677, XrefRangeStart = 512666, XrefRangeEnd = 512673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IgnoreCollision(Collider2D collider1, Collider2D collider2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collider2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_IgnoreCollision_Public_Static_Void_Collider2D_Collider2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00007024 File Offset: 0x00005224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512677, XrefRangeEnd = 512681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IgnoreCollision(Collider2D collider1, Collider2D collider2, bool ignore)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collider2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_IgnoreCollision_Public_Static_Void_Collider2D_Collider2D_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000707C File Offset: 0x0000527C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 512685, RefRangeEnd = 512686, XrefRangeStart = 512681, XrefRangeEnd = 512685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000070C8 File Offset: 0x000052C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512686, XrefRangeEnd = 512690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00007124 File Offset: 0x00005324
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 512696, RefRangeEnd = 512744, XrefRangeStart = 512690, XrefRangeEnd = 512696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000718C File Offset: 0x0000538C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512744, XrefRangeEnd = 512750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00007204 File Offset: 0x00005404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512750, XrefRangeEnd = 512756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDepth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00007288 File Offset: 0x00005488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512756, XrefRangeEnd = 512761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000072F4 File Offset: 0x000054F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512761, XrefRangeEnd = 512766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00007370 File Offset: 0x00005570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512766, XrefRangeEnd = 512771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = float.PositiveInfinity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_List_1_RaycastHit2D_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000073EC File Offset: 0x000055EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 512777, RefRangeEnd = 512780, XrefRangeStart = 512771, XrefRangeEnd = 512777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector2_Vector2_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00007468 File Offset: 0x00005668
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 512786, RefRangeEnd = 512789, XrefRangeStart = 512780, XrefRangeEnd = 512786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_CircleCast_Public_Static_RaycastHit2D_Vector2_Single_Vector2_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000074E0 File Offset: 0x000056E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512789, XrefRangeEnd = 512794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_CircleCast_Public_Static_Int32_Vector2_Single_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00007568 File Offset: 0x00005768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512794, XrefRangeEnd = 512803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll(Ray ray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000075A8 File Offset: 0x000057A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512803, XrefRangeEnd = 512812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll(Ray ray, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000075F8 File Offset: 0x000057F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512812, XrefRangeEnd = 512821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll(Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007654 File Offset: 0x00005854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512821, XrefRangeEnd = 512826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Private_Static_Il2CppStructArray_1_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000076CC File Offset: 0x000058CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512826, XrefRangeEnd = 512831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRayIntersectionNonAlloc(Ray ray, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000771C File Offset: 0x0000591C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512831, XrefRangeEnd = 512836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRayIntersectionNonAlloc(Ray ray, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000777C File Offset: 0x0000597C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512836, XrefRangeEnd = 512841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRayIntersectionNonAlloc(Ray ray, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000077E8 File Offset: 0x000059E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 512847, RefRangeEnd = 512855, XrefRangeStart = 512841, XrefRangeEnd = 512847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collider2D OverlapPoint(Vector2 point, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapPoint_Public_Static_Collider2D_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007838 File Offset: 0x00005A38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512861, RefRangeEnd = 512863, XrefRangeStart = 512855, XrefRangeEnd = 512861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapCircle_Public_Static_Collider2D_Vector2_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007894 File Offset: 0x00005A94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 512873, RefRangeEnd = 512876, XrefRangeStart = 512863, XrefRangeEnd = 512873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapCircleAll_Public_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr3) : null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000078F0 File Offset: 0x00005AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512876, XrefRangeEnd = 512881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Collider2D> OverlapCircleAll_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapCircleAll_Internal_Private_Static_Il2CppReferenceArray_1_Collider2D_PhysicsScene2D_Vector2_Single_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr3) : null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000795C File Offset: 0x00005B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512887, RefRangeEnd = 512889, XrefRangeStart = 512881, XrefRangeEnd = 512887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapCircleNonAlloc_Public_Static_Int32_Vector2_Single_Il2CppReferenceArray_1_Collider2D_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000079C8 File Offset: 0x00005BC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512895, RefRangeEnd = 512897, XrefRangeStart = 512889, XrefRangeEnd = 512895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapBox_Public_Static_Collider2D_Vector2_Vector2_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00007A34 File Offset: 0x00005C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512897, XrefRangeEnd = 512907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth, float maxDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDepth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapBoxAll_Public_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Vector2_Single_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr3) : null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00007ABC File Offset: 0x00005CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512907, XrefRangeEnd = 512912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Collider2D> OverlapBoxAll_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapBoxAll_Internal_Private_Static_Il2CppReferenceArray_1_Collider2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr3) : null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00007B34 File Offset: 0x00005D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512912, XrefRangeEnd = 512916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapAreaAll_Public_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr3) : null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00007B90 File Offset: 0x00005D90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512932, RefRangeEnd = 512934, XrefRangeStart = 512916, XrefRangeEnd = 512932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Collider2D> OverlapAreaAllToBox_Internal(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDepth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapAreaAllToBox_Internal_Private_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Vector2_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr3) : null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00007C08 File Offset: 0x00005E08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512939, RefRangeEnd = 512941, XrefRangeStart = 512934, XrefRangeEnd = 512939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapAreaNonAlloc_Public_Static_Int32_Vector2_Vector2_Il2CppReferenceArray_1_Collider2D_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007C74 File Offset: 0x00005E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512941, XrefRangeEnd = 512945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Simulate_Internal_Injected(ref PhysicsScene2D physicsScene, float step)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Simulate_Internal_Injected_Private_Static_Boolean_byref_PhysicsScene2D_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007CC0 File Offset: 0x00005EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512945, XrefRangeEnd = 512949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Injected_Private_Static_Il2CppStructArray_1_RaycastHit2D_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00007D38 File Offset: 0x00005F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512949, XrefRangeEnd = 512953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Collider2D> OverlapCircleAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapCircleAll_Internal_Injected_Private_Static_Il2CppReferenceArray_1_Collider2D_byref_PhysicsScene2D_byref_Vector2_Single_byref_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr3) : null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00007DA4 File Offset: 0x00005FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512953, XrefRangeEnd = 512957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Collider2D> OverlapBoxAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_OverlapBoxAll_Internal_Injected_Private_Static_Il2CppReferenceArray_1_Collider2D_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr3) : null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000022DA File Offset: 0x000004DA
		public Physics2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00007E20 File Offset: 0x00006020
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000022E3 File Offset: 0x000004E3
		public unsafe static List<Rigidbody2D> m_LastDisabledRigidbody2D
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Physics2D.NativeFieldInfoPtr_m_LastDisabledRigidbody2D, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Rigidbody2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Physics2D.NativeFieldInfoPtr_m_LastDisabledRigidbody2D, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000022F5 File Offset: 0x000004F5
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002301 File Offset: 0x00000501
		public static int velocityIterations
		{
			get
			{
				return Physics2D.get_velocityIterationsDelegateField();
			}
			set
			{
				Physics2D.set_velocityIterationsDelegateField(value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000230E File Offset: 0x0000050E
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000231A File Offset: 0x0000051A
		public static int positionIterations
		{
			get
			{
				return Physics2D.get_positionIterationsDelegateField();
			}
			set
			{
				Physics2D.set_positionIterationsDelegateField(value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00007E48 File Offset: 0x00006048
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002327 File Offset: 0x00000527
		public static Vector2 gravity
		{
			get
			{
				Vector2 vector;
				Physics2D.get_gravity_Injected(out vector);
				return vector;
			}
			set
			{
				Physics2D.set_gravity_Injected(ref value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000233D File Offset: 0x0000053D
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002349 File Offset: 0x00000549
		public static bool queriesStartInColliders
		{
			get
			{
				return Physics2D.get_queriesStartInCollidersDelegateField();
			}
			set
			{
				Physics2D.set_queriesStartInCollidersDelegateField(value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002356 File Offset: 0x00000556
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002362 File Offset: 0x00000562
		public static bool callbacksOnDisable
		{
			get
			{
				return Physics2D.get_callbacksOnDisableDelegateField();
			}
			set
			{
				Physics2D.set_callbacksOnDisableDelegateField(value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000236F File Offset: 0x0000056F
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000237B File Offset: 0x0000057B
		public static bool reuseCollisionCallbacks
		{
			get
			{
				return Physics2D.get_reuseCollisionCallbacksDelegateField();
			}
			set
			{
				Physics2D.set_reuseCollisionCallbacksDelegateField(value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002388 File Offset: 0x00000588
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002394 File Offset: 0x00000594
		public static bool autoSyncTransforms
		{
			get
			{
				return Physics2D.get_autoSyncTransformsDelegateField();
			}
			set
			{
				Physics2D.set_autoSyncTransformsDelegateField(value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000023AD File Offset: 0x000005AD
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000023B9 File Offset: 0x000005B9
		public static float velocityThreshold
		{
			get
			{
				return Physics2D.get_velocityThresholdDelegateField();
			}
			set
			{
				Physics2D.set_velocityThresholdDelegateField(value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000023C6 File Offset: 0x000005C6
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000023D2 File Offset: 0x000005D2
		public static float maxLinearCorrection
		{
			get
			{
				return Physics2D.get_maxLinearCorrectionDelegateField();
			}
			set
			{
				Physics2D.set_maxLinearCorrectionDelegateField(value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000023DF File Offset: 0x000005DF
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000023EB File Offset: 0x000005EB
		public static float maxAngularCorrection
		{
			get
			{
				return Physics2D.get_maxAngularCorrectionDelegateField();
			}
			set
			{
				Physics2D.set_maxAngularCorrectionDelegateField(value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000023F8 File Offset: 0x000005F8
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002404 File Offset: 0x00000604
		public static float maxTranslationSpeed
		{
			get
			{
				return Physics2D.get_maxTranslationSpeedDelegateField();
			}
			set
			{
				Physics2D.set_maxTranslationSpeedDelegateField(value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00002411 File Offset: 0x00000611
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000241D File Offset: 0x0000061D
		public static float maxRotationSpeed
		{
			get
			{
				return Physics2D.get_maxRotationSpeedDelegateField();
			}
			set
			{
				Physics2D.set_maxRotationSpeedDelegateField(value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000242A File Offset: 0x0000062A
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002436 File Offset: 0x00000636
		public static float defaultContactOffset
		{
			get
			{
				return Physics2D.get_defaultContactOffsetDelegateField();
			}
			set
			{
				Physics2D.set_defaultContactOffsetDelegateField(value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002443 File Offset: 0x00000643
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000244F File Offset: 0x0000064F
		public static float baumgarteScale
		{
			get
			{
				return Physics2D.get_baumgarteScaleDelegateField();
			}
			set
			{
				Physics2D.set_baumgarteScaleDelegateField(value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000245C File Offset: 0x0000065C
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002468 File Offset: 0x00000668
		public static float baumgarteTOIScale
		{
			get
			{
				return Physics2D.get_baumgarteTOIScaleDelegateField();
			}
			set
			{
				Physics2D.set_baumgarteTOIScaleDelegateField(value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002475 File Offset: 0x00000675
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00002481 File Offset: 0x00000681
		public static float timeToSleep
		{
			get
			{
				return Physics2D.get_timeToSleepDelegateField();
			}
			set
			{
				Physics2D.set_timeToSleepDelegateField(value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000248E File Offset: 0x0000068E
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000249A File Offset: 0x0000069A
		public static float linearSleepTolerance
		{
			get
			{
				return Physics2D.get_linearSleepToleranceDelegateField();
			}
			set
			{
				Physics2D.set_linearSleepToleranceDelegateField(value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000024A7 File Offset: 0x000006A7
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000024B3 File Offset: 0x000006B3
		public static float angularSleepTolerance
		{
			get
			{
				return Physics2D.get_angularSleepToleranceDelegateField();
			}
			set
			{
				Physics2D.set_angularSleepToleranceDelegateField(value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000024C0 File Offset: 0x000006C0
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000024CC File Offset: 0x000006CC
		public static bool alwaysShowColliders
		{
			get
			{
				return Physics2D.get_alwaysShowCollidersDelegateField();
			}
			set
			{
				Physics2D.set_alwaysShowCollidersDelegateField(value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000024D9 File Offset: 0x000006D9
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000024E5 File Offset: 0x000006E5
		public static bool showColliderSleep
		{
			get
			{
				return Physics2D.get_showColliderSleepDelegateField();
			}
			set
			{
				Physics2D.set_showColliderSleepDelegateField(value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000024F2 File Offset: 0x000006F2
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000024FE File Offset: 0x000006FE
		public static bool showColliderContacts
		{
			get
			{
				return Physics2D.get_showColliderContactsDelegateField();
			}
			set
			{
				Physics2D.set_showColliderContactsDelegateField(value);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000250B File Offset: 0x0000070B
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002517 File Offset: 0x00000717
		public static bool showColliderAABB
		{
			get
			{
				return Physics2D.get_showColliderAABBDelegateField();
			}
			set
			{
				Physics2D.set_showColliderAABBDelegateField(value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002524 File Offset: 0x00000724
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002530 File Offset: 0x00000730
		public static float contactArrowScale
		{
			get
			{
				return Physics2D.get_contactArrowScaleDelegateField();
			}
			set
			{
				Physics2D.set_contactArrowScaleDelegateField(value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00007E60 File Offset: 0x00006060
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000253D File Offset: 0x0000073D
		public static Color colliderAwakeColor
		{
			get
			{
				Color color;
				Physics2D.get_colliderAwakeColor_Injected(out color);
				return color;
			}
			set
			{
				Physics2D.set_colliderAwakeColor_Injected(ref value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00007E78 File Offset: 0x00006078
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002546 File Offset: 0x00000746
		public static Color colliderAsleepColor
		{
			get
			{
				Color color;
				Physics2D.get_colliderAsleepColor_Injected(out color);
				return color;
			}
			set
			{
				Physics2D.set_colliderAsleepColor_Injected(ref value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00007E90 File Offset: 0x00006090
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000254F File Offset: 0x0000074F
		public static Color colliderContactColor
		{
			get
			{
				Color color;
				Physics2D.get_colliderContactColor_Injected(out color);
				return color;
			}
			set
			{
				Physics2D.set_colliderContactColor_Injected(ref value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00007EA8 File Offset: 0x000060A8
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002558 File Offset: 0x00000758
		public static Color colliderAABBColor
		{
			get
			{
				Color color;
				Physics2D.get_colliderAABBColor_Injected(out color);
				return color;
			}
			set
			{
				Physics2D.set_colliderAABBColor_Injected(ref value);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002561 File Offset: 0x00000761
		public static void SyncTransforms()
		{
			Physics2D.SyncTransformsDelegateField();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000256D File Offset: 0x0000076D
		public static bool GetIgnoreCollision(Collider2D collider1, Collider2D collider2)
		{
			return Physics2D.GetIgnoreCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2));
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002585 File Offset: 0x00000785
		public static void IgnoreLayerCollision(int layer1, int layer2)
		{
			Physics2D.IgnoreLayerCollision(layer1, layer2, true);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007EC0 File Offset: 0x000060C0
		public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
		{
			bool flag = layer1 < 0 || layer1 > 31;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			bool flag2 = layer2 < 0 || layer2 > 31;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("layer2 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			Physics2D.IgnoreLayerCollision_Internal(layer1, layer2, ignore);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002591 File Offset: 0x00000791
		public static void IgnoreLayerCollision_Internal(int layer1, int layer2, bool ignore)
		{
			Physics2D.IgnoreLayerCollision_InternalDelegateField(layer1, layer2, ignore);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00007F10 File Offset: 0x00006110
		public static bool GetIgnoreLayerCollision(int layer1, int layer2)
		{
			bool flag = layer1 < 0 || layer1 > 31;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			bool flag2 = layer2 < 0 || layer2 > 31;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("layer2 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			return Physics2D.GetIgnoreLayerCollision_Internal(layer1, layer2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000025A0 File Offset: 0x000007A0
		public static bool GetIgnoreLayerCollision_Internal(int layer1, int layer2)
		{
			return Physics2D.GetIgnoreLayerCollision_InternalDelegateField(layer1, layer2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00007F60 File Offset: 0x00006160
		public static void SetLayerCollisionMask(int layer, int layerMask)
		{
			bool flag = layer < 0 || layer > 31;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			Physics2D.SetLayerCollisionMask_Internal(layer, layerMask);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000025AE File Offset: 0x000007AE
		public static void SetLayerCollisionMask_Internal(int layer, int layerMask)
		{
			Physics2D.SetLayerCollisionMask_InternalDelegateField(layer, layerMask);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00007F94 File Offset: 0x00006194
		public static int GetLayerCollisionMask(int layer)
		{
			bool flag = layer < 0 || layer > 31;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			return Physics2D.GetLayerCollisionMask_Internal(layer);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000025BC File Offset: 0x000007BC
		public static int GetLayerCollisionMask_Internal(int layer)
		{
			return Physics2D.GetLayerCollisionMask_InternalDelegateField(layer);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000025C9 File Offset: 0x000007C9
		public static bool IsTouching(Collider2D collider1, Collider2D collider2)
		{
			return Physics2D.IsTouchingDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2));
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00007FC8 File Offset: 0x000061C8
		public static bool IsTouching(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_TwoCollidersWithFilter(collider1, collider2, contactFilter);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool IsTouching_TwoCollidersWithFilter(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_TwoCollidersWithFilter_Injected(collider1, collider2, ref contactFilter);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007FE4 File Offset: 0x000061E4
		public static bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_SingleColliderWithFilter(collider, contactFilter);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000025EC File Offset: 0x000007EC
		public static bool IsTouching_SingleColliderWithFilter(Collider2D collider, ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_SingleColliderWithFilter_Injected(collider, ref contactFilter);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00008000 File Offset: 0x00006200
		public static bool IsTouchingLayers(Collider2D collider)
		{
			return Physics2D.IsTouchingLayers(collider, -1);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000025F6 File Offset: 0x000007F6
		public static bool IsTouchingLayers(Collider2D collider, int layerMask)
		{
			return Physics2D.IsTouchingLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), layerMask);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000801C File Offset: 0x0000621C
		public static Vector2 ClosestPoint(Vector2 position, Collider2D collider)
		{
			bool flag = collider == null;
			if (flag)
			{
				throw new ArgumentNullException("Collider cannot be NULL.");
			}
			return Physics2D.ClosestPoint_Collider(position, collider);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000804C File Offset: 0x0000624C
		public static Vector2 ClosestPoint(Vector2 position, Rigidbody2D rigidbody)
		{
			bool flag = rigidbody == null;
			if (flag)
			{
				throw new ArgumentNullException("Rigidbody cannot be NULL.");
			}
			return Physics2D.ClosestPoint_Rigidbody(position, rigidbody);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000807C File Offset: 0x0000627C
		public static Vector2 ClosestPoint_Collider(Vector2 position, Collider2D collider)
		{
			Vector2 vector;
			Physics2D.ClosestPoint_Collider_Injected(ref position, collider, out vector);
			return vector;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00008094 File Offset: 0x00006294
		public static Vector2 ClosestPoint_Rigidbody(Vector2 position, Rigidbody2D rigidbody)
		{
			Vector2 vector;
			Physics2D.ClosestPoint_Rigidbody_Injected(ref position, rigidbody, out vector);
			return vector;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000080AC File Offset: 0x000062AC
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end)
		{
			return Physics2D.defaultPhysicsScene.Linecast(start, end, -5);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000080D0 File Offset: 0x000062D0
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00008104 File Offset: 0x00006304
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00008134 File Offset: 0x00006334
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00008160 File Offset: 0x00006360
		public static int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter, results);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00008184 File Offset: 0x00006384
		public static int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter, results);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000081A8 File Offset: 0x000063A8
		public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, contactFilter2D);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000081DC File Offset: 0x000063DC
		public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, contactFilter2D);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000820C File Offset: 0x0000640C
		public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, contactFilter2D);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00008238 File Offset: 0x00006438
		public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, contactFilter2D);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002609 File Offset: 0x00000809
		public static Il2CppStructArray<RaycastHit2D> LinecastAll_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter)
		{
			return Physics2D.LinecastAll_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00008264 File Offset: 0x00006464
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.Linecast(start, end, results, -5);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00008288 File Offset: 0x00006488
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D, results);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000082BC File Offset: 0x000064BC
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D, results);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000082F0 File Offset: 0x000064F0
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D, results);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00008320 File Offset: 0x00006520
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.Raycast(origin, direction, float.PositiveInfinity, results, -5);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000834C File Offset: 0x0000654C
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, results, -5);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00008374 File Offset: 0x00006574
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000083A8 File Offset: 0x000065A8
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000083D8 File Offset: 0x000065D8
		public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, float.PositiveInfinity, contactFilter2D);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00008410 File Offset: 0x00006610
		public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, contactFilter2D);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008444 File Offset: 0x00006644
		public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, contactFilter2D);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008478 File Offset: 0x00006678
		public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, contactFilter2D);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000084A8 File Offset: 0x000066A8
		public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, contactFilter2D);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002618 File Offset: 0x00000818
		public static Il2CppStructArray<RaycastHit2D> RaycastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.RaycastAll_Internal_Injected(ref physicsScene, ref origin, ref direction, distance, ref contactFilter);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000084D4 File Offset: 0x000066D4
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity, -5);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00008500 File Offset: 0x00006700
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, -5);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00008528 File Offset: 0x00006728
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000855C File Offset: 0x0000675C
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000858C File Offset: 0x0000678C
		public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity, contactFilter, results);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000085B8 File Offset: 0x000067B8
		public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter, results);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000085E0 File Offset: 0x000067E0
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, float.PositiveInfinity, contactFilter2D);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00008618 File Offset: 0x00006818
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000864C File Offset: 0x0000684C
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00008680 File Offset: 0x00006880
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000086B0 File Offset: 0x000068B0
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002628 File Offset: 0x00000828
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.CircleCastAll_Internal_Injected(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000086E0 File Offset: 0x000068E0
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity, results, -5);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000870C File Offset: 0x0000690C
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, results, -5);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008734 File Offset: 0x00006934
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter2D, results);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000876C File Offset: 0x0000696C
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter2D, results);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000087A4 File Offset: 0x000069A4
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter2D, results);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000087D8 File Offset: 0x000069D8
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity, -5);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00008804 File Offset: 0x00006A04
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, -5);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000882C File Offset: 0x00006A2C
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00008864 File Offset: 0x00006A64
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000889C File Offset: 0x00006A9C
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000088D0 File Offset: 0x00006AD0
		public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity, contactFilter, results);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000088FC File Offset: 0x00006AFC
		public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00008928 File Offset: 0x00006B28
		public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00008954 File Offset: 0x00006B54
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, float.PositiveInfinity, contactFilter2D);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000898C File Offset: 0x00006B8C
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000089C4 File Offset: 0x00006BC4
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000089FC File Offset: 0x00006BFC
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00008A30 File Offset: 0x00006C30
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000263A File Offset: 0x0000083A
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.BoxCastAll_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008A60 File Offset: 0x00006C60
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity, results, -5);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008A8C File Offset: 0x00006C8C
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, results, -5);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00008AB8 File Offset: 0x00006CB8
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00008AF4 File Offset: 0x00006CF4
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00008B2C File Offset: 0x00006D2C
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00008B60 File Offset: 0x00006D60
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, -5);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00008B8C File Offset: 0x00006D8C
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, -5);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00008BB8 File Offset: 0x00006DB8
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00008BF4 File Offset: 0x00006DF4
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00008C2C File Offset: 0x00006E2C
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00008C60 File Offset: 0x00006E60
		public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, contactFilter, results);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00008C90 File Offset: 0x00006E90
		public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00008CBC File Offset: 0x00006EBC
		public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00008CE8 File Offset: 0x00006EE8
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, contactFilter2D);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00008D24 File Offset: 0x00006F24
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000264E File Offset: 0x0000084E
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.CapsuleCastAll_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00008D5C File Offset: 0x00006F5C
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00008D94 File Offset: 0x00006F94
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00008DC8 File Offset: 0x00006FC8
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00008DFC File Offset: 0x00006FFC
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, results, -5);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00008E2C File Offset: 0x0000702C
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, results, -5);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00008E58 File Offset: 0x00007058
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00008E94 File Offset: 0x00007094
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00008ED0 File Offset: 0x000070D0
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00008F08 File Offset: 0x00007108
		public static RaycastHit2D GetRayIntersection(Ray ray)
		{
			return Physics2D.defaultPhysicsScene.GetRayIntersection(ray, float.PositiveInfinity, -5);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00008F30 File Offset: 0x00007130
		public static RaycastHit2D GetRayIntersection(Ray ray, float distance)
		{
			return Physics2D.defaultPhysicsScene.GetRayIntersection(ray, distance, -5);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00008F54 File Offset: 0x00007154
		public static RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask)
		{
			return Physics2D.defaultPhysicsScene.GetRayIntersection(ray, distance, layerMask);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00008F78 File Offset: 0x00007178
		public static Collider2D OverlapPoint(Vector2 point)
		{
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, -5);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00008F9C File Offset: 0x0000719C
		public static Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter2D);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00008FCC File Offset: 0x000071CC
		public static Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter2D);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00008FF8 File Offset: 0x000071F8
		public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter, results);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000901C File Offset: 0x0000721C
		public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter, results);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00009040 File Offset: 0x00007240
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, contactFilter2D);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00009070 File Offset: 0x00007270
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, contactFilter2D);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000090A0 File Offset: 0x000072A0
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, contactFilter2D);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000090CC File Offset: 0x000072CC
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, contactFilter2D);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002664 File Offset: 0x00000864
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter)
		{
			return Physics2D.OverlapPointAll_Internal_Injected(ref physicsScene, ref point, ref contactFilter);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000090F4 File Offset: 0x000072F4
		public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, results, -5);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00009118 File Offset: 0x00007318
		public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter2D, results);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000914C File Offset: 0x0000734C
		public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter2D, results);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000917C File Offset: 0x0000737C
		public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter2D, results);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000091A8 File Offset: 0x000073A8
		public static Collider2D OverlapCircle(Vector2 point, float radius)
		{
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, -5);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000091CC File Offset: 0x000073CC
		public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter2D);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000091FC File Offset: 0x000073FC
		public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter2D);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00009228 File Offset: 0x00007428
		public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter, results);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000924C File Offset: 0x0000744C
		public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter, results);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00009270 File Offset: 0x00007470
		public static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapCircleAll_Internal(Physics2D.defaultPhysicsScene, point, radius, contactFilter2D);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000092A4 File Offset: 0x000074A4
		public static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.OverlapCircleAll_Internal(Physics2D.defaultPhysicsScene, point, radius, contactFilter2D);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000092D0 File Offset: 0x000074D0
		public static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.OverlapCircleAll_Internal(Physics2D.defaultPhysicsScene, point, radius, contactFilter2D);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000092FC File Offset: 0x000074FC
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, results, -5);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00009320 File Offset: 0x00007520
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter2D, results);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00009354 File Offset: 0x00007554
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter2D, results);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00009384 File Offset: 0x00007584
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle)
		{
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, -5);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000093A8 File Offset: 0x000075A8
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter2D);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000093DC File Offset: 0x000075DC
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter2D);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000940C File Offset: 0x0000760C
		public static int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter, results);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00009434 File Offset: 0x00007634
		public static int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter, results);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000945C File Offset: 0x0000765C
		public static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapBoxAll_Internal(Physics2D.defaultPhysicsScene, point, size, angle, contactFilter2D);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00009490 File Offset: 0x00007690
		public static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapBoxAll_Internal(Physics2D.defaultPhysicsScene, point, size, angle, contactFilter2D);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000094C4 File Offset: 0x000076C4
		public static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.OverlapBoxAll_Internal(Physics2D.defaultPhysicsScene, point, size, angle, contactFilter2D);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000094F4 File Offset: 0x000076F4
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, results, -5);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000951C File Offset: 0x0000771C
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter2D, results);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00009554 File Offset: 0x00007754
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter2D, results);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00009588 File Offset: 0x00007788
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter2D, results);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000095B8 File Offset: 0x000077B8
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB)
		{
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, -5);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000095DC File Offset: 0x000077DC
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter2D);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00009610 File Offset: 0x00007810
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter2D);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00009640 File Offset: 0x00007840
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter2D);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000966C File Offset: 0x0000786C
		public static int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter, results);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00009690 File Offset: 0x00007890
		public static int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter, results);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000096B4 File Offset: 0x000078B4
		public static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB)
		{
			return Physics2D.OverlapAreaAllToBox_Internal(pointA, pointB, -5, float.NegativeInfinity, float.PositiveInfinity);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000096DC File Offset: 0x000078DC
		public static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth)
		{
			return Physics2D.OverlapAreaAllToBox_Internal(pointA, pointB, layerMask, minDepth, float.PositiveInfinity);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000096FC File Offset: 0x000078FC
		public static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth)
		{
			return Physics2D.OverlapAreaAllToBox_Internal(pointA, pointB, layerMask, minDepth, maxDepth);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000971C File Offset: 0x0000791C
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, results, -5);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00009740 File Offset: 0x00007940
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter2D, results);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00009774 File Offset: 0x00007974
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter2D, results);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000097A4 File Offset: 0x000079A4
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle)
		{
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, -5);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000097CC File Offset: 0x000079CC
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00009804 File Offset: 0x00007A04
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00009838 File Offset: 0x00007A38
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00009868 File Offset: 0x00007A68
		public static int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter, results);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00009890 File Offset: 0x00007A90
		public static int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter, results);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000098B8 File Offset: 0x00007AB8
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000098EC File Offset: 0x00007AEC
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00009920 File Offset: 0x00007B20
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00009950 File Offset: 0x00007B50
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002671 File Offset: 0x00000871
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter)
		{
			return Physics2D.OverlapCapsuleAll_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00009980 File Offset: 0x00007B80
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, results, -5);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000099A8 File Offset: 0x00007BA8
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D, results);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000099E0 File Offset: 0x00007BE0
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D, results);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00009A18 File Offset: 0x00007C18
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D, results);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00009A4C File Offset: 0x00007C4C
		public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCollider(collider, contactFilter, results);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00009A68 File Offset: 0x00007C68
		public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCollider(collider, contactFilter, results);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00009A84 File Offset: 0x00007C84
		public static int GetContacts(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderColliderContactsArray(collider1, collider2, contactFilter, contacts);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009AA0 File Offset: 0x00007CA0
		public static int GetContacts(Collider2D collider, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderContactsArray(collider, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009AC8 File Offset: 0x00007CC8
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderContactsArray(collider, contactFilter, contacts);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00009AE4 File Offset: 0x00007CE4
		public static int GetContacts(Collider2D collider, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetColliderContactsCollidersOnlyArray(collider, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00009B0C File Offset: 0x00007D0C
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetColliderContactsCollidersOnlyArray(collider, contactFilter, colliders);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00009B28 File Offset: 0x00007D28
		public static int GetContacts(Rigidbody2D rigidbody, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetRigidbodyContactsArray(rigidbody, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00009B50 File Offset: 0x00007D50
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetRigidbodyContactsArray(rigidbody, contactFilter, contacts);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00009B6C File Offset: 0x00007D6C
		public static int GetContacts(Rigidbody2D rigidbody, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyArray(rigidbody, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00009B94 File Offset: 0x00007D94
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyArray(rigidbody, contactFilter, colliders);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002683 File Offset: 0x00000883
		public static int GetColliderContactsArray(Collider2D collider, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetColliderContactsArray_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000268E File Offset: 0x0000088E
		public static int GetColliderColliderContactsArray(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetColliderColliderContactsArray_Injected(collider1, collider2, ref contactFilter, results);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000269A File Offset: 0x0000089A
		public static int GetRigidbodyContactsArray(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetRigidbodyContactsArray_Injected(rigidbody, ref contactFilter, results);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000026A5 File Offset: 0x000008A5
		public static int GetColliderContactsCollidersOnlyArray(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.GetColliderContactsCollidersOnlyArray_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000026B0 File Offset: 0x000008B0
		public static int GetRigidbodyContactsCollidersOnlyArray(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyArray_Injected(rigidbody, ref contactFilter, results);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00009BB0 File Offset: 0x00007DB0
		public static int GetContacts(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderColliderContactsList(collider1, collider2, contactFilter, contacts);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009BCC File Offset: 0x00007DCC
		public static int GetContacts(Collider2D collider, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderContactsList(collider, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00009BF4 File Offset: 0x00007DF4
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderContactsList(collider, contactFilter, contacts);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00009C10 File Offset: 0x00007E10
		public static int GetContacts(Collider2D collider, List<Collider2D> colliders)
		{
			return Physics2D.GetColliderContactsCollidersOnlyList(collider, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00009C38 File Offset: 0x00007E38
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> colliders)
		{
			return Physics2D.GetColliderContactsCollidersOnlyList(collider, contactFilter, colliders);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00009C54 File Offset: 0x00007E54
		public static int GetContacts(Rigidbody2D rigidbody, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetRigidbodyContactsList(rigidbody, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00009C7C File Offset: 0x00007E7C
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetRigidbodyContactsList(rigidbody, contactFilter, contacts);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00009C98 File Offset: 0x00007E98
		public static int GetContacts(Rigidbody2D rigidbody, List<Collider2D> colliders)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyList(rigidbody, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00009CC0 File Offset: 0x00007EC0
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> colliders)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyList(rigidbody, contactFilter, colliders);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000026BB File Offset: 0x000008BB
		public static int GetColliderContactsList(Collider2D collider, ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetColliderContactsList_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000026C6 File Offset: 0x000008C6
		public static int GetColliderColliderContactsList(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetColliderColliderContactsList_Injected(collider1, collider2, ref contactFilter, results);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000026D2 File Offset: 0x000008D2
		public static int GetRigidbodyContactsList(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetRigidbodyContactsList_Injected(rigidbody, ref contactFilter, results);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000026DD File Offset: 0x000008DD
		public static int GetColliderContactsCollidersOnlyList(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.GetColliderContactsCollidersOnlyList_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000026E8 File Offset: 0x000008E8
		public static int GetRigidbodyContactsCollidersOnlyList(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyList_Injected(rigidbody, ref contactFilter, results);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000026F3 File Offset: 0x000008F3
		public static void SetEditorDragMovement(bool dragging, Il2CppReferenceArray<GameObject> objs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002700 File Offset: 0x00000900
		public static void get_gravity_Injected(out Vector2 ret)
		{
			Physics2D.get_gravity_InjectedDelegateField(out ret);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000270D File Offset: 0x0000090D
		public static void set_gravity_Injected(ref Vector2 value)
		{
			Physics2D.set_gravity_InjectedDelegateField(ref value);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000271A File Offset: 0x0000091A
		public static void get_colliderAwakeColor_Injected(out Color ret)
		{
			Physics2D.get_colliderAwakeColor_InjectedDelegateField(out ret);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002727 File Offset: 0x00000927
		public static void set_colliderAwakeColor_Injected(ref Color value)
		{
			Physics2D.set_colliderAwakeColor_InjectedDelegateField(ref value);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002734 File Offset: 0x00000934
		public static void get_colliderAsleepColor_Injected(out Color ret)
		{
			Physics2D.get_colliderAsleepColor_InjectedDelegateField(out ret);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002741 File Offset: 0x00000941
		public static void set_colliderAsleepColor_Injected(ref Color value)
		{
			Physics2D.set_colliderAsleepColor_InjectedDelegateField(ref value);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000274E File Offset: 0x0000094E
		public static void get_colliderContactColor_Injected(out Color ret)
		{
			Physics2D.get_colliderContactColor_InjectedDelegateField(out ret);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000275B File Offset: 0x0000095B
		public static void set_colliderContactColor_Injected(ref Color value)
		{
			Physics2D.set_colliderContactColor_InjectedDelegateField(ref value);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002768 File Offset: 0x00000968
		public static void get_colliderAABBColor_Injected(out Color ret)
		{
			Physics2D.get_colliderAABBColor_InjectedDelegateField(out ret);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002775 File Offset: 0x00000975
		public static void set_colliderAABBColor_Injected(ref Color value)
		{
			Physics2D.set_colliderAABBColor_InjectedDelegateField(ref value);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002782 File Offset: 0x00000982
		public static bool IsTouching_TwoCollidersWithFilter_Injected(Collider2D collider1, Collider2D collider2, ref ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_TwoCollidersWithFilter_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2), ref contactFilter);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000279B File Offset: 0x0000099B
		public static bool IsTouching_SingleColliderWithFilter_Injected(Collider2D collider, ref ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_SingleColliderWithFilter_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000027AE File Offset: 0x000009AE
		public static void ClosestPoint_Collider_Injected(ref Vector2 position, Collider2D collider, out Vector2 ret)
		{
			Physics2D.ClosestPoint_Collider_InjectedDelegateField(ref position, IL2CPP.Il2CppObjectBaseToPtr(collider), out ret);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000027C2 File Offset: 0x000009C2
		public static void ClosestPoint_Rigidbody_Injected(ref Vector2 position, Rigidbody2D rigidbody, out Vector2 ret)
		{
			Physics2D.ClosestPoint_Rigidbody_InjectedDelegateField(ref position, IL2CPP.Il2CppObjectBaseToPtr(rigidbody), out ret);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00009CDC File Offset: 0x00007EDC
		public static Il2CppStructArray<RaycastHit2D> LinecastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.LinecastAll_Internal_InjectedDelegateField(ref physicsScene, ref start, ref end, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00009D08 File Offset: 0x00007F08
		public static Il2CppStructArray<RaycastHit2D> RaycastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.RaycastAll_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref direction, distance, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009D34 File Offset: 0x00007F34
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.CircleCastAll_Internal_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00009D64 File Offset: 0x00007F64
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.BoxCastAll_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00009D94 File Offset: 0x00007F94
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.CapsuleCastAll_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00009DC8 File Offset: 0x00007FC8
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.OverlapPointAll_Internal_InjectedDelegateField(ref physicsScene, ref point, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00009DF4 File Offset: 0x00007FF4
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, CapsuleDirection2D direction, float angle, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.OverlapCapsuleAll_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000027D6 File Offset: 0x000009D6
		public static int GetColliderContactsArray_Injected(Collider2D collider, ref ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetColliderContactsArray_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000027EF File Offset: 0x000009EF
		public static int GetColliderColliderContactsArray_Injected(Collider2D collider1, Collider2D collider2, ref ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetColliderColliderContactsArray_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000280E File Offset: 0x00000A0E
		public static int GetRigidbodyContactsArray_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetRigidbodyContactsArray_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rigidbody), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002827 File Offset: 0x00000A27
		public static int GetColliderContactsCollidersOnlyArray_Injected(Collider2D collider, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.GetColliderContactsCollidersOnlyArray_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002840 File Offset: 0x00000A40
		public static int GetRigidbodyContactsCollidersOnlyArray_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyArray_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rigidbody), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002859 File Offset: 0x00000A59
		public static int GetColliderContactsList_Injected(Collider2D collider, ref ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetColliderContactsList_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002872 File Offset: 0x00000A72
		public static int GetColliderColliderContactsList_Injected(Collider2D collider1, Collider2D collider2, ref ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetColliderColliderContactsList_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002891 File Offset: 0x00000A91
		public static int GetRigidbodyContactsList_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetRigidbodyContactsList_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rigidbody), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000028AA File Offset: 0x00000AAA
		public static int GetColliderContactsCollidersOnlyList_Injected(Collider2D collider, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.GetColliderContactsCollidersOnlyList_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000028C3 File Offset: 0x00000AC3
		public static int GetRigidbodyContactsCollidersOnlyList_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyList_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rigidbody), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_m_LastDisabledRigidbody2D;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene2D_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_queriesHitTriggers_Public_Static_get_Boolean_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_set_simulationMode_Public_Static_set_Void_SimulationMode2D_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Public_Static_Boolean_Single_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Internal_Internal_Static_Boolean_PhysicsScene2D_Single_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_IgnoreCollision_Public_Static_Void_Collider2D_Collider2D_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_IgnoreCollision_Public_Static_Void_Collider2D_Collider2D_Boolean_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_Single_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_List_1_RaycastHit2D_Single_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector2_Vector2_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_CircleCast_Public_Static_RaycastHit2D_Vector2_Single_Vector2_Single_Int32_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_CircleCast_Public_Static_Int32_Vector2_Single_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Private_Static_Il2CppStructArray_1_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_OverlapPoint_Public_Static_Collider2D_Vector2_Int32_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_OverlapCircle_Public_Static_Collider2D_Vector2_Single_Int32_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_OverlapCircleAll_Public_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Single_Int32_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_OverlapCircleAll_Internal_Private_Static_Il2CppReferenceArray_1_Collider2D_PhysicsScene2D_Vector2_Single_ContactFilter2D_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_OverlapCircleNonAlloc_Public_Static_Int32_Vector2_Single_Il2CppReferenceArray_1_Collider2D_Int32_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBox_Public_Static_Collider2D_Vector2_Vector2_Single_Int32_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBoxAll_Public_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Vector2_Single_Int32_Single_Single_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBoxAll_Internal_Private_Static_Il2CppReferenceArray_1_Collider2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_OverlapAreaAll_Public_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Vector2_Int32_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_OverlapAreaAllToBox_Internal_Private_Static_Il2CppReferenceArray_1_Collider2D_Vector2_Vector2_Int32_Single_Single_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_OverlapAreaNonAlloc_Public_Static_Int32_Vector2_Vector2_Il2CppReferenceArray_1_Collider2D_Int32_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Internal_Injected_Private_Static_Boolean_byref_PhysicsScene2D_Single_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Injected_Private_Static_Il2CppStructArray_1_RaycastHit2D_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_OverlapCircleAll_Internal_Injected_Private_Static_Il2CppReferenceArray_1_Collider2D_byref_PhysicsScene2D_byref_Vector2_Single_byref_ContactFilter2D_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBoxAll_Internal_Injected_Private_Static_Il2CppReferenceArray_1_Collider2D_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_0;

		// Token: 0x0400006B RID: 107
		public const int IgnoreRaycastLayer = 4;

		// Token: 0x0400006C RID: 108
		public const int DefaultRaycastLayers = -5;

		// Token: 0x0400006D RID: 109
		public const int AllLayers = -1;

		// Token: 0x0400006E RID: 110
		private static readonly Physics2D.get_velocityIterationsDelegate get_velocityIterationsDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Physics2D.set_velocityIterationsDelegate set_velocityIterationsDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly Physics2D.get_positionIterationsDelegate get_positionIterationsDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly Physics2D.set_positionIterationsDelegate set_positionIterationsDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly Physics2D.set_queriesHitTriggersDelegate set_queriesHitTriggersDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly Physics2D.get_queriesStartInCollidersDelegate get_queriesStartInCollidersDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly Physics2D.set_queriesStartInCollidersDelegate set_queriesStartInCollidersDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly Physics2D.get_callbacksOnDisableDelegate get_callbacksOnDisableDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly Physics2D.set_callbacksOnDisableDelegate set_callbacksOnDisableDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly Physics2D.get_reuseCollisionCallbacksDelegate get_reuseCollisionCallbacksDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly Physics2D.set_reuseCollisionCallbacksDelegate set_reuseCollisionCallbacksDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly Physics2D.get_autoSyncTransformsDelegate get_autoSyncTransformsDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly Physics2D.set_autoSyncTransformsDelegate set_autoSyncTransformsDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly Physics2D.get_simulationModeDelegate get_simulationModeDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly Physics2D.get_velocityThresholdDelegate get_velocityThresholdDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly Physics2D.set_velocityThresholdDelegate set_velocityThresholdDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly Physics2D.get_maxLinearCorrectionDelegate get_maxLinearCorrectionDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly Physics2D.set_maxLinearCorrectionDelegate set_maxLinearCorrectionDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly Physics2D.get_maxAngularCorrectionDelegate get_maxAngularCorrectionDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly Physics2D.set_maxAngularCorrectionDelegate set_maxAngularCorrectionDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly Physics2D.get_maxTranslationSpeedDelegate get_maxTranslationSpeedDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly Physics2D.set_maxTranslationSpeedDelegate set_maxTranslationSpeedDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly Physics2D.get_maxRotationSpeedDelegate get_maxRotationSpeedDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly Physics2D.set_maxRotationSpeedDelegate set_maxRotationSpeedDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly Physics2D.get_defaultContactOffsetDelegate get_defaultContactOffsetDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly Physics2D.set_defaultContactOffsetDelegate set_defaultContactOffsetDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly Physics2D.get_baumgarteScaleDelegate get_baumgarteScaleDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly Physics2D.set_baumgarteScaleDelegate set_baumgarteScaleDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly Physics2D.get_baumgarteTOIScaleDelegate get_baumgarteTOIScaleDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly Physics2D.set_baumgarteTOIScaleDelegate set_baumgarteTOIScaleDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly Physics2D.get_timeToSleepDelegate get_timeToSleepDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly Physics2D.set_timeToSleepDelegate set_timeToSleepDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly Physics2D.get_linearSleepToleranceDelegate get_linearSleepToleranceDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly Physics2D.set_linearSleepToleranceDelegate set_linearSleepToleranceDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly Physics2D.get_angularSleepToleranceDelegate get_angularSleepToleranceDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly Physics2D.set_angularSleepToleranceDelegate set_angularSleepToleranceDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly Physics2D.get_alwaysShowCollidersDelegate get_alwaysShowCollidersDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly Physics2D.set_alwaysShowCollidersDelegate set_alwaysShowCollidersDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly Physics2D.get_showColliderSleepDelegate get_showColliderSleepDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly Physics2D.set_showColliderSleepDelegate set_showColliderSleepDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly Physics2D.get_showColliderContactsDelegate get_showColliderContactsDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly Physics2D.set_showColliderContactsDelegate set_showColliderContactsDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly Physics2D.get_showColliderAABBDelegate get_showColliderAABBDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly Physics2D.set_showColliderAABBDelegate set_showColliderAABBDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly Physics2D.get_contactArrowScaleDelegate get_contactArrowScaleDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly Physics2D.set_contactArrowScaleDelegate set_contactArrowScaleDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly Physics2D.SyncTransformsDelegate SyncTransformsDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly Physics2D.GetIgnoreCollisionDelegate GetIgnoreCollisionDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly Physics2D.IgnoreLayerCollision_InternalDelegate IgnoreLayerCollision_InternalDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly Physics2D.GetIgnoreLayerCollision_InternalDelegate GetIgnoreLayerCollision_InternalDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly Physics2D.SetLayerCollisionMask_InternalDelegate SetLayerCollisionMask_InternalDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly Physics2D.GetLayerCollisionMask_InternalDelegate GetLayerCollisionMask_InternalDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly Physics2D.IsTouchingDelegate IsTouchingDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly Physics2D.IsTouchingLayersDelegate IsTouchingLayersDelegateField;

		// Token: 0x040000A4 RID: 164
		private static readonly Physics2D.get_gravity_InjectedDelegate get_gravity_InjectedDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly Physics2D.set_gravity_InjectedDelegate set_gravity_InjectedDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly Physics2D.get_colliderAwakeColor_InjectedDelegate get_colliderAwakeColor_InjectedDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly Physics2D.set_colliderAwakeColor_InjectedDelegate set_colliderAwakeColor_InjectedDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly Physics2D.get_colliderAsleepColor_InjectedDelegate get_colliderAsleepColor_InjectedDelegateField;

		// Token: 0x040000A9 RID: 169
		private static readonly Physics2D.set_colliderAsleepColor_InjectedDelegate set_colliderAsleepColor_InjectedDelegateField;

		// Token: 0x040000AA RID: 170
		private static readonly Physics2D.get_colliderContactColor_InjectedDelegate get_colliderContactColor_InjectedDelegateField;

		// Token: 0x040000AB RID: 171
		private static readonly Physics2D.set_colliderContactColor_InjectedDelegate set_colliderContactColor_InjectedDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly Physics2D.get_colliderAABBColor_InjectedDelegate get_colliderAABBColor_InjectedDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly Physics2D.set_colliderAABBColor_InjectedDelegate set_colliderAABBColor_InjectedDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly Physics2D.IsTouching_TwoCollidersWithFilter_InjectedDelegate IsTouching_TwoCollidersWithFilter_InjectedDelegateField;

		// Token: 0x040000AF RID: 175
		private static readonly Physics2D.IsTouching_SingleColliderWithFilter_InjectedDelegate IsTouching_SingleColliderWithFilter_InjectedDelegateField;

		// Token: 0x040000B0 RID: 176
		private static readonly Physics2D.ClosestPoint_Collider_InjectedDelegate ClosestPoint_Collider_InjectedDelegateField;

		// Token: 0x040000B1 RID: 177
		private static readonly Physics2D.ClosestPoint_Rigidbody_InjectedDelegate ClosestPoint_Rigidbody_InjectedDelegateField;

		// Token: 0x040000B2 RID: 178
		private static readonly Physics2D.LinecastAll_Internal_InjectedDelegate LinecastAll_Internal_InjectedDelegateField;

		// Token: 0x040000B3 RID: 179
		private static readonly Physics2D.RaycastAll_Internal_InjectedDelegate RaycastAll_Internal_InjectedDelegateField;

		// Token: 0x040000B4 RID: 180
		private static readonly Physics2D.CircleCastAll_Internal_InjectedDelegate CircleCastAll_Internal_InjectedDelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly Physics2D.BoxCastAll_Internal_InjectedDelegate BoxCastAll_Internal_InjectedDelegateField;

		// Token: 0x040000B6 RID: 182
		private static readonly Physics2D.CapsuleCastAll_Internal_InjectedDelegate CapsuleCastAll_Internal_InjectedDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly Physics2D.OverlapPointAll_Internal_InjectedDelegate OverlapPointAll_Internal_InjectedDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly Physics2D.OverlapCapsuleAll_Internal_InjectedDelegate OverlapCapsuleAll_Internal_InjectedDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly Physics2D.GetColliderContactsArray_InjectedDelegate GetColliderContactsArray_InjectedDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly Physics2D.GetColliderColliderContactsArray_InjectedDelegate GetColliderColliderContactsArray_InjectedDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly Physics2D.GetRigidbodyContactsArray_InjectedDelegate GetRigidbodyContactsArray_InjectedDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly Physics2D.GetColliderContactsCollidersOnlyArray_InjectedDelegate GetColliderContactsCollidersOnlyArray_InjectedDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly Physics2D.GetRigidbodyContactsCollidersOnlyArray_InjectedDelegate GetRigidbodyContactsCollidersOnlyArray_InjectedDelegateField;

		// Token: 0x040000BE RID: 190
		private static readonly Physics2D.GetColliderContactsList_InjectedDelegate GetColliderContactsList_InjectedDelegateField;

		// Token: 0x040000BF RID: 191
		private static readonly Physics2D.GetColliderColliderContactsList_InjectedDelegate GetColliderColliderContactsList_InjectedDelegateField;

		// Token: 0x040000C0 RID: 192
		private static readonly Physics2D.GetRigidbodyContactsList_InjectedDelegate GetRigidbodyContactsList_InjectedDelegateField;

		// Token: 0x040000C1 RID: 193
		private static readonly Physics2D.GetColliderContactsCollidersOnlyList_InjectedDelegate GetColliderContactsCollidersOnlyList_InjectedDelegateField;

		// Token: 0x040000C2 RID: 194
		private static readonly Physics2D.GetRigidbodyContactsCollidersOnlyList_InjectedDelegate GetRigidbodyContactsCollidersOnlyList_InjectedDelegateField;

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x0600046A RID: 1130
		private delegate int get_velocityIterationsDelegate();

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600046C RID: 1132
		private delegate void set_velocityIterationsDelegate(int value);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600046E RID: 1134
		private delegate int get_positionIterationsDelegate();

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000470 RID: 1136
		private delegate void set_positionIterationsDelegate(int value);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000472 RID: 1138
		private delegate void set_queriesHitTriggersDelegate(bool value);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000474 RID: 1140
		private delegate bool get_queriesStartInCollidersDelegate();

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000476 RID: 1142
		private delegate void set_queriesStartInCollidersDelegate(bool value);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000478 RID: 1144
		private delegate bool get_callbacksOnDisableDelegate();

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x0600047A RID: 1146
		private delegate void set_callbacksOnDisableDelegate(bool value);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600047C RID: 1148
		private delegate bool get_reuseCollisionCallbacksDelegate();

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x0600047E RID: 1150
		private delegate void set_reuseCollisionCallbacksDelegate(bool value);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000480 RID: 1152
		private delegate bool get_autoSyncTransformsDelegate();

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000482 RID: 1154
		private delegate void set_autoSyncTransformsDelegate(bool value);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000484 RID: 1156
		private delegate SimulationMode2D get_simulationModeDelegate();

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000486 RID: 1158
		private delegate float get_velocityThresholdDelegate();

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000488 RID: 1160
		private delegate void set_velocityThresholdDelegate(float value);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600048A RID: 1162
		private delegate float get_maxLinearCorrectionDelegate();

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600048C RID: 1164
		private delegate void set_maxLinearCorrectionDelegate(float value);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600048E RID: 1166
		private delegate float get_maxAngularCorrectionDelegate();

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000490 RID: 1168
		private delegate void set_maxAngularCorrectionDelegate(float value);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000492 RID: 1170
		private delegate float get_maxTranslationSpeedDelegate();

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000494 RID: 1172
		private delegate void set_maxTranslationSpeedDelegate(float value);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000496 RID: 1174
		private delegate float get_maxRotationSpeedDelegate();

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000498 RID: 1176
		private delegate void set_maxRotationSpeedDelegate(float value);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x0600049A RID: 1178
		private delegate float get_defaultContactOffsetDelegate();

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600049C RID: 1180
		private delegate void set_defaultContactOffsetDelegate(float value);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600049E RID: 1182
		private delegate float get_baumgarteScaleDelegate();

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060004A0 RID: 1184
		private delegate void set_baumgarteScaleDelegate(float value);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060004A2 RID: 1186
		private delegate float get_baumgarteTOIScaleDelegate();

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060004A4 RID: 1188
		private delegate void set_baumgarteTOIScaleDelegate(float value);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060004A6 RID: 1190
		private delegate float get_timeToSleepDelegate();

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060004A8 RID: 1192
		private delegate void set_timeToSleepDelegate(float value);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060004AA RID: 1194
		private delegate float get_linearSleepToleranceDelegate();

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060004AC RID: 1196
		private delegate void set_linearSleepToleranceDelegate(float value);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060004AE RID: 1198
		private delegate float get_angularSleepToleranceDelegate();

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060004B0 RID: 1200
		private delegate void set_angularSleepToleranceDelegate(float value);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060004B2 RID: 1202
		private delegate bool get_alwaysShowCollidersDelegate();

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060004B4 RID: 1204
		private delegate void set_alwaysShowCollidersDelegate(bool value);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060004B6 RID: 1206
		private delegate bool get_showColliderSleepDelegate();

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060004B8 RID: 1208
		private delegate void set_showColliderSleepDelegate(bool value);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060004BA RID: 1210
		private delegate bool get_showColliderContactsDelegate();

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060004BC RID: 1212
		private delegate void set_showColliderContactsDelegate(bool value);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060004BE RID: 1214
		private delegate bool get_showColliderAABBDelegate();

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060004C0 RID: 1216
		private delegate void set_showColliderAABBDelegate(bool value);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060004C2 RID: 1218
		private delegate float get_contactArrowScaleDelegate();

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060004C4 RID: 1220
		private delegate void set_contactArrowScaleDelegate(float value);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060004C6 RID: 1222
		private delegate void SyncTransformsDelegate();

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060004C8 RID: 1224
		private delegate bool GetIgnoreCollisionDelegate(IntPtr collider1, IntPtr collider2);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060004CA RID: 1226
		private delegate void IgnoreLayerCollision_InternalDelegate(int layer1, int layer2, bool ignore);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060004CC RID: 1228
		private delegate bool GetIgnoreLayerCollision_InternalDelegate(int layer1, int layer2);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060004CE RID: 1230
		private delegate void SetLayerCollisionMask_InternalDelegate(int layer, int layerMask);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060004D0 RID: 1232
		private delegate int GetLayerCollisionMask_InternalDelegate(int layer);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060004D2 RID: 1234
		private delegate bool IsTouchingDelegate(IntPtr collider1, IntPtr collider2);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060004D4 RID: 1236
		private delegate bool IsTouchingLayersDelegate(IntPtr collider, int layerMask);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060004D6 RID: 1238
		private delegate void get_gravity_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060004D8 RID: 1240
		private delegate void set_gravity_InjectedDelegate(IntPtr value);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060004DA RID: 1242
		private delegate void get_colliderAwakeColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060004DC RID: 1244
		private delegate void set_colliderAwakeColor_InjectedDelegate(IntPtr value);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060004DE RID: 1246
		private delegate void get_colliderAsleepColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060004E0 RID: 1248
		private delegate void set_colliderAsleepColor_InjectedDelegate(IntPtr value);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060004E2 RID: 1250
		private delegate void get_colliderContactColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060004E4 RID: 1252
		private delegate void set_colliderContactColor_InjectedDelegate(IntPtr value);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060004E6 RID: 1254
		private delegate void get_colliderAABBColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060004E8 RID: 1256
		private delegate void set_colliderAABBColor_InjectedDelegate(IntPtr value);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060004EA RID: 1258
		private delegate bool IsTouching_TwoCollidersWithFilter_InjectedDelegate(IntPtr collider1, IntPtr collider2, IntPtr contactFilter);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060004EC RID: 1260
		private delegate bool IsTouching_SingleColliderWithFilter_InjectedDelegate(IntPtr collider, IntPtr contactFilter);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060004EE RID: 1262
		private delegate void ClosestPoint_Collider_InjectedDelegate(IntPtr position, IntPtr collider, [Out] IntPtr ret);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060004F0 RID: 1264
		private delegate void ClosestPoint_Rigidbody_InjectedDelegate(IntPtr position, IntPtr rigidbody, [Out] IntPtr ret);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060004F2 RID: 1266
		private delegate IntPtr LinecastAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr start, IntPtr end, IntPtr contactFilter);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060004F4 RID: 1268
		private delegate IntPtr RaycastAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr direction, float distance, IntPtr contactFilter);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060004F6 RID: 1270
		private delegate IntPtr CircleCastAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float distance, IntPtr contactFilter);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060004F8 RID: 1272
		private delegate IntPtr BoxCastAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, float angle, IntPtr direction, float distance, IntPtr contactFilter);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060004FA RID: 1274
		private delegate IntPtr CapsuleCastAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, CapsuleDirection2D capsuleDirection, float angle, IntPtr direction, float distance, IntPtr contactFilter);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060004FC RID: 1276
		private delegate IntPtr OverlapPointAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr contactFilter);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060004FE RID: 1278
		private delegate IntPtr OverlapCapsuleAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, CapsuleDirection2D direction, float angle, IntPtr contactFilter);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000500 RID: 1280
		private delegate int GetColliderContactsArray_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000502 RID: 1282
		private delegate int GetColliderColliderContactsArray_InjectedDelegate(IntPtr collider1, IntPtr collider2, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06000504 RID: 1284
		private delegate int GetRigidbodyContactsArray_InjectedDelegate(IntPtr rigidbody, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000506 RID: 1286
		private delegate int GetColliderContactsCollidersOnlyArray_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000508 RID: 1288
		private delegate int GetRigidbodyContactsCollidersOnlyArray_InjectedDelegate(IntPtr rigidbody, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x0600050A RID: 1290
		private delegate int GetColliderContactsList_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x0600050C RID: 1292
		private delegate int GetColliderColliderContactsList_InjectedDelegate(IntPtr collider1, IntPtr collider2, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x0600050E RID: 1294
		private delegate int GetRigidbodyContactsList_InjectedDelegate(IntPtr rigidbody, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000510 RID: 1296
		private delegate int GetColliderContactsCollidersOnlyList_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000512 RID: 1298
		private delegate int GetRigidbodyContactsCollidersOnlyList_InjectedDelegate(IntPtr rigidbody, IntPtr contactFilter, IntPtr results);
	}
}
