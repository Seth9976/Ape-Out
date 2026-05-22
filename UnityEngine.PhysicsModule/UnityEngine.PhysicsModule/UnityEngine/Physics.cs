using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	public class Physics : Object
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00007A48 File Offset: 0x00005C48
		// Note: this type is marked as 'beforefieldinit'.
		static Physics()
		{
			Il2CppClassPointerStore<Physics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Physics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics>.NativeClassPtr);
			Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663376);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663377);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663378);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663379);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663380);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663381);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663382);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663383);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663384);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663385);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663386);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663387);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663388);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663389);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663390);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663391);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663392);
			Physics.NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663393);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663394);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663395);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663396);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663397);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663398);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663399);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663400);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663401);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663402);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663403);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663404);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663405);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663406);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663407);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663408);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663409);
			Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Injected_Private_Static_Void_byref_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663410);
			Physics.NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Il2CppStructArray_1_RaycastHit_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663411);
			Physics.get_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<Physics.get_defaultContactOffsetDelegate>("UnityEngine.Physics::get_defaultContactOffset");
			Physics.set_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<Physics.set_defaultContactOffsetDelegate>("UnityEngine.Physics::set_defaultContactOffset");
			Physics.get_sleepThresholdDelegateField = IL2CPP.ResolveICall<Physics.get_sleepThresholdDelegate>("UnityEngine.Physics::get_sleepThreshold");
			Physics.set_sleepThresholdDelegateField = IL2CPP.ResolveICall<Physics.set_sleepThresholdDelegate>("UnityEngine.Physics::set_sleepThreshold");
			Physics.get_queriesHitTriggersDelegateField = IL2CPP.ResolveICall<Physics.get_queriesHitTriggersDelegate>("UnityEngine.Physics::get_queriesHitTriggers");
			Physics.set_queriesHitTriggersDelegateField = IL2CPP.ResolveICall<Physics.set_queriesHitTriggersDelegate>("UnityEngine.Physics::set_queriesHitTriggers");
			Physics.get_queriesHitBackfacesDelegateField = IL2CPP.ResolveICall<Physics.get_queriesHitBackfacesDelegate>("UnityEngine.Physics::get_queriesHitBackfaces");
			Physics.set_queriesHitBackfacesDelegateField = IL2CPP.ResolveICall<Physics.set_queriesHitBackfacesDelegate>("UnityEngine.Physics::set_queriesHitBackfaces");
			Physics.get_bounceThresholdDelegateField = IL2CPP.ResolveICall<Physics.get_bounceThresholdDelegate>("UnityEngine.Physics::get_bounceThreshold");
			Physics.set_bounceThresholdDelegateField = IL2CPP.ResolveICall<Physics.set_bounceThresholdDelegate>("UnityEngine.Physics::set_bounceThreshold");
			Physics.get_defaultMaxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Physics.get_defaultMaxDepenetrationVelocityDelegate>("UnityEngine.Physics::get_defaultMaxDepenetrationVelocity");
			Physics.set_defaultMaxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Physics.set_defaultMaxDepenetrationVelocityDelegate>("UnityEngine.Physics::set_defaultMaxDepenetrationVelocity");
			Physics.get_defaultSolverIterationsDelegateField = IL2CPP.ResolveICall<Physics.get_defaultSolverIterationsDelegate>("UnityEngine.Physics::get_defaultSolverIterations");
			Physics.set_defaultSolverIterationsDelegateField = IL2CPP.ResolveICall<Physics.set_defaultSolverIterationsDelegate>("UnityEngine.Physics::set_defaultSolverIterations");
			Physics.get_defaultSolverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Physics.get_defaultSolverVelocityIterationsDelegate>("UnityEngine.Physics::get_defaultSolverVelocityIterations");
			Physics.set_defaultSolverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Physics.set_defaultSolverVelocityIterationsDelegate>("UnityEngine.Physics::set_defaultSolverVelocityIterations");
			Physics.get_defaultMaxAngularSpeedDelegateField = IL2CPP.ResolveICall<Physics.get_defaultMaxAngularSpeedDelegate>("UnityEngine.Physics::get_defaultMaxAngularSpeed");
			Physics.set_defaultMaxAngularSpeedDelegateField = IL2CPP.ResolveICall<Physics.set_defaultMaxAngularSpeedDelegate>("UnityEngine.Physics::set_defaultMaxAngularSpeed");
			Physics.IgnoreCollisionDelegateField = IL2CPP.ResolveICall<Physics.IgnoreCollisionDelegate>("UnityEngine.Physics::IgnoreCollision");
			Physics.IgnoreLayerCollisionDelegateField = IL2CPP.ResolveICall<Physics.IgnoreLayerCollisionDelegate>("UnityEngine.Physics::IgnoreLayerCollision");
			Physics.GetIgnoreLayerCollisionDelegateField = IL2CPP.ResolveICall<Physics.GetIgnoreLayerCollisionDelegate>("UnityEngine.Physics::GetIgnoreLayerCollision");
			Physics.GetIgnoreCollisionDelegateField = IL2CPP.ResolveICall<Physics.GetIgnoreCollisionDelegate>("UnityEngine.Physics::GetIgnoreCollision");
			Physics.get_autoSimulationDelegateField = IL2CPP.ResolveICall<Physics.get_autoSimulationDelegate>("UnityEngine.Physics::get_autoSimulation");
			Physics.set_autoSimulationDelegateField = IL2CPP.ResolveICall<Physics.set_autoSimulationDelegate>("UnityEngine.Physics::set_autoSimulation");
			Physics.SyncTransformsDelegateField = IL2CPP.ResolveICall<Physics.SyncTransformsDelegate>("UnityEngine.Physics::SyncTransforms");
			Physics.get_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<Physics.get_autoSyncTransformsDelegate>("UnityEngine.Physics::get_autoSyncTransforms");
			Physics.set_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<Physics.set_autoSyncTransformsDelegate>("UnityEngine.Physics::set_autoSyncTransforms");
			Physics.get_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<Physics.get_reuseCollisionCallbacksDelegate>("UnityEngine.Physics::get_reuseCollisionCallbacks");
			Physics.set_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<Physics.set_reuseCollisionCallbacksDelegate>("UnityEngine.Physics::set_reuseCollisionCallbacks");
			Physics.get_interCollisionDistanceDelegateField = IL2CPP.ResolveICall<Physics.get_interCollisionDistanceDelegate>("UnityEngine.Physics::get_interCollisionDistance");
			Physics.set_interCollisionDistanceDelegateField = IL2CPP.ResolveICall<Physics.set_interCollisionDistanceDelegate>("UnityEngine.Physics::set_interCollisionDistance");
			Physics.get_interCollisionStiffnessDelegateField = IL2CPP.ResolveICall<Physics.get_interCollisionStiffnessDelegate>("UnityEngine.Physics::get_interCollisionStiffness");
			Physics.set_interCollisionStiffnessDelegateField = IL2CPP.ResolveICall<Physics.set_interCollisionStiffnessDelegate>("UnityEngine.Physics::set_interCollisionStiffness");
			Physics.get_interCollisionSettingsToggleDelegateField = IL2CPP.ResolveICall<Physics.get_interCollisionSettingsToggleDelegate>("UnityEngine.Physics::get_interCollisionSettingsToggle");
			Physics.set_interCollisionSettingsToggleDelegateField = IL2CPP.ResolveICall<Physics.set_interCollisionSettingsToggleDelegate>("UnityEngine.Physics::set_interCollisionSettingsToggle");
			Physics.BakeMeshDelegateField = IL2CPP.ResolveICall<Physics.BakeMeshDelegate>("UnityEngine.Physics::BakeMesh");
			Physics.get_gravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.get_gravity_InjectedDelegate>("UnityEngine.Physics::get_gravity_Injected");
			Physics.set_gravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.set_gravity_InjectedDelegate>("UnityEngine.Physics::set_gravity_Injected");
			Physics.Query_CapsuleCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_CapsuleCastAll_InjectedDelegate>("UnityEngine.Physics::Query_CapsuleCastAll_Injected");
			Physics.Query_SphereCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_SphereCastAll_InjectedDelegate>("UnityEngine.Physics::Query_SphereCastAll_Injected");
			Physics.OverlapCapsule_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.OverlapCapsule_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapCapsule_Internal_Injected");
			Physics.OverlapSphere_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.OverlapSphere_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapSphere_Internal_Injected");
			Physics.Simulate_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Simulate_Internal_InjectedDelegate>("UnityEngine.Physics::Simulate_Internal_Injected");
			Physics.Query_ComputePenetration_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_ComputePenetration_InjectedDelegate>("UnityEngine.Physics::Query_ComputePenetration_Injected");
			Physics.Query_ClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_ClosestPoint_InjectedDelegate>("UnityEngine.Physics::Query_ClosestPoint_Injected");
			Physics.get_clothGravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.get_clothGravity_InjectedDelegate>("UnityEngine.Physics::get_clothGravity_Injected");
			Physics.set_clothGravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.set_clothGravity_InjectedDelegate>("UnityEngine.Physics::set_clothGravity_Injected");
			Physics.CheckSphere_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.CheckSphere_Internal_InjectedDelegate>("UnityEngine.Physics::CheckSphere_Internal_Injected");
			Physics.CheckCapsule_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.CheckCapsule_Internal_InjectedDelegate>("UnityEngine.Physics::CheckCapsule_Internal_Injected");
			Physics.CheckBox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.CheckBox_Internal_InjectedDelegate>("UnityEngine.Physics::CheckBox_Internal_Injected");
			Physics.OverlapBox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.OverlapBox_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapBox_Internal_Injected");
			Physics.Internal_BoxCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Internal_BoxCastAll_InjectedDelegate>("UnityEngine.Physics::Internal_BoxCastAll_Injected");
			Physics.Internal_RebuildBroadphaseRegions_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Internal_RebuildBroadphaseRegions_InjectedDelegate>("UnityEngine.Physics::Internal_RebuildBroadphaseRegions_Injected");
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00008064 File Offset: 0x00006264
		public unsafe static PhysicsScene defaultPhysicsScene
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 513801, RefRangeEnd = 513802, XrefRangeStart = 513799, XrefRangeEnd = 513801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008094 File Offset: 0x00006294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513802, XrefRangeEnd = 513805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000810C File Offset: 0x0000630C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513805, XrefRangeEnd = 513808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00008174 File Offset: 0x00006374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513808, XrefRangeEnd = 513811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000081D0 File Offset: 0x000063D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513811, XrefRangeEnd = 513814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000821C File Offset: 0x0000641C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513814, XrefRangeEnd = 513817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000082A0 File Offset: 0x000064A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513817, XrefRangeEnd = 513820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00008318 File Offset: 0x00006518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513820, XrefRangeEnd = 513823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00008380 File Offset: 0x00006580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513823, XrefRangeEnd = 513826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000083DC File Offset: 0x000065DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513826, XrefRangeEnd = 513829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00008444 File Offset: 0x00006644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513829, XrefRangeEnd = 513832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000084A0 File Offset: 0x000066A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513832, XrefRangeEnd = 513835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000084EC File Offset: 0x000066EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513835, XrefRangeEnd = 513838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000852C File Offset: 0x0000672C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513838, XrefRangeEnd = 513841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000085A4 File Offset: 0x000067A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513841, XrefRangeEnd = 513844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000860C File Offset: 0x0000680C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513844, XrefRangeEnd = 513847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00008668 File Offset: 0x00006868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513847, XrefRangeEnd = 513850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000086B4 File Offset: 0x000068B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513850, XrefRangeEnd = 513852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000872C File Offset: 0x0000692C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 513864, RefRangeEnd = 513871, XrefRangeStart = 513852, XrefRangeEnd = 513864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000087A4 File Offset: 0x000069A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513871, XrefRangeEnd = 513872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00008810 File Offset: 0x00006A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513872, XrefRangeEnd = 513873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000886C File Offset: 0x00006A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513873, XrefRangeEnd = 513874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000088BC File Offset: 0x00006ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513874, XrefRangeEnd = 513875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00008928 File Offset: 0x00006B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513875, XrefRangeEnd = 513876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00008984 File Offset: 0x00006B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513876, XrefRangeEnd = 513877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000089D4 File Offset: 0x00006BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513877, XrefRangeEnd = 513878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00008A14 File Offset: 0x00006C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513878, XrefRangeEnd = 513881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00008A90 File Offset: 0x00006C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513881, XrefRangeEnd = 513884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00008AFC File Offset: 0x00006CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513884, XrefRangeEnd = 513887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00008B5C File Offset: 0x00006D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513887, XrefRangeEnd = 513890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00008BAC File Offset: 0x00006DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513890, XrefRangeEnd = 513893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00008C34 File Offset: 0x00006E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513893, XrefRangeEnd = 513896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00008CB0 File Offset: 0x00006EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513896, XrefRangeEnd = 513899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00008D1C File Offset: 0x00006F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513899, XrefRangeEnd = 513902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00008D7C File Offset: 0x00006F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513902, XrefRangeEnd = 513906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_defaultPhysicsScene_Injected(out PhysicsScene ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Injected_Private_Static_Void_byref_PhysicsScene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00008DB0 File Offset: 0x00006FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513906, XrefRangeEnd = 513910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Il2CppStructArray_1_RaycastHit_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002DAE File Offset: 0x00000FAE
		public Physics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00008E28 File Offset: 0x00007028
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00002DB7 File Offset: 0x00000FB7
		public static float minPenetrationForPenalty
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00008E40 File Offset: 0x00007040
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002DBA File Offset: 0x00000FBA
		public static Vector3 gravity
		{
			get
			{
				Vector3 vector;
				Physics.get_gravity_Injected(out vector);
				return vector;
			}
			set
			{
				Physics.set_gravity_Injected(ref value);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002DC3 File Offset: 0x00000FC3
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00002DCF File Offset: 0x00000FCF
		public static float defaultContactOffset
		{
			get
			{
				return Physics.get_defaultContactOffsetDelegateField();
			}
			set
			{
				Physics.set_defaultContactOffsetDelegateField(value);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00002DDC File Offset: 0x00000FDC
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002DE8 File Offset: 0x00000FE8
		public static float sleepThreshold
		{
			get
			{
				return Physics.get_sleepThresholdDelegateField();
			}
			set
			{
				Physics.set_sleepThresholdDelegateField(value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00002DF5 File Offset: 0x00000FF5
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002E01 File Offset: 0x00001001
		public static bool queriesHitTriggers
		{
			get
			{
				return Physics.get_queriesHitTriggersDelegateField();
			}
			set
			{
				Physics.set_queriesHitTriggersDelegateField(value);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00002E0E File Offset: 0x0000100E
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00002E1A File Offset: 0x0000101A
		public static bool queriesHitBackfaces
		{
			get
			{
				return Physics.get_queriesHitBackfacesDelegateField();
			}
			set
			{
				Physics.set_queriesHitBackfacesDelegateField(value);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00002E27 File Offset: 0x00001027
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002E33 File Offset: 0x00001033
		public static float bounceThreshold
		{
			get
			{
				return Physics.get_bounceThresholdDelegateField();
			}
			set
			{
				Physics.set_bounceThresholdDelegateField(value);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002E40 File Offset: 0x00001040
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002E4C File Offset: 0x0000104C
		public static float defaultMaxDepenetrationVelocity
		{
			get
			{
				return Physics.get_defaultMaxDepenetrationVelocityDelegateField();
			}
			set
			{
				Physics.set_defaultMaxDepenetrationVelocityDelegateField(value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002E59 File Offset: 0x00001059
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002E65 File Offset: 0x00001065
		public static int defaultSolverIterations
		{
			get
			{
				return Physics.get_defaultSolverIterationsDelegateField();
			}
			set
			{
				Physics.set_defaultSolverIterationsDelegateField(value);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00002E72 File Offset: 0x00001072
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002E7E File Offset: 0x0000107E
		public static int defaultSolverVelocityIterations
		{
			get
			{
				return Physics.get_defaultSolverVelocityIterationsDelegateField();
			}
			set
			{
				Physics.set_defaultSolverVelocityIterationsDelegateField(value);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00008E58 File Offset: 0x00007058
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002E8B File Offset: 0x0000108B
		public static float bounceTreshold
		{
			get
			{
				return Physics.bounceThreshold;
			}
			set
			{
				Physics.bounceThreshold = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00008E70 File Offset: 0x00007070
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002E95 File Offset: 0x00001095
		public static float sleepVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00008E88 File Offset: 0x00007088
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002E98 File Offset: 0x00001098
		public static float sleepAngularVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00008EA0 File Offset: 0x000070A0
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002E9B File Offset: 0x0000109B
		public static float maxAngularVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00008EB8 File Offset: 0x000070B8
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002E9E File Offset: 0x0000109E
		public static int solverIterationCount
		{
			get
			{
				return Physics.defaultSolverIterations;
			}
			set
			{
				Physics.defaultSolverIterations = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00008ED0 File Offset: 0x000070D0
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002EA8 File Offset: 0x000010A8
		public static int solverVelocityIterationCount
		{
			get
			{
				return Physics.defaultSolverVelocityIterations;
			}
			set
			{
				Physics.defaultSolverVelocityIterations = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00008EE8 File Offset: 0x000070E8
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002EB2 File Offset: 0x000010B2
		public static float penetrationPenaltyForce
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00002EB5 File Offset: 0x000010B5
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002EC1 File Offset: 0x000010C1
		public static float defaultMaxAngularSpeed
		{
			get
			{
				return Physics.get_defaultMaxAngularSpeedDelegateField();
			}
			set
			{
				Physics.set_defaultMaxAngularSpeedDelegateField(value);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002ECE File Offset: 0x000010CE
		public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore)
		{
			Physics.IgnoreCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2), ignore);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002EE7 File Offset: 0x000010E7
		public static void IgnoreCollision(Collider collider1, Collider collider2)
		{
			Physics.IgnoreCollision(collider1, collider2, true);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002EF3 File Offset: 0x000010F3
		public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
		{
			Physics.IgnoreLayerCollisionDelegateField(layer1, layer2, ignore);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002F02 File Offset: 0x00001102
		public static void IgnoreLayerCollision(int layer1, int layer2)
		{
			Physics.IgnoreLayerCollision(layer1, layer2, true);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002F0E File Offset: 0x0000110E
		public static bool GetIgnoreLayerCollision(int layer1, int layer2)
		{
			return Physics.GetIgnoreLayerCollisionDelegateField(layer1, layer2);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002F1C File Offset: 0x0000111C
		public static bool GetIgnoreCollision(Collider collider1, Collider collider2)
		{
			return Physics.GetIgnoreCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2));
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00008F00 File Offset: 0x00007100
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			Vector3 vector = end - start;
			return Physics.defaultPhysicsScene.Raycast(start, vector, vector.magnitude, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00008F34 File Offset: 0x00007134
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask)
		{
			return Physics.Linecast(start, end, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00008F50 File Offset: 0x00007150
		public static bool Linecast(Vector3 start, Vector3 end)
		{
			return Physics.Linecast(start, end, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00008F6C File Offset: 0x0000716C
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			Vector3 vector = end - start;
			return Physics.defaultPhysicsScene.Raycast(start, vector, out hitInfo, vector.magnitude, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00008FA0 File Offset: 0x000071A0
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask)
		{
			return Physics.Linecast(start, end, out hitInfo, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00008FBC File Offset: 0x000071BC
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo)
		{
			return Physics.Linecast(start, end, out hitInfo, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00008FDC File Offset: 0x000071DC
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, out raycastHit, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00009008 File Offset: 0x00007208
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00009028 File Offset: 0x00007228
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00009048 File Offset: 0x00007248
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000906C File Offset: 0x0000726C
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00009098 File Offset: 0x00007298
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000090BC File Offset: 0x000072BC
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000090E0 File Offset: 0x000072E0
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00009108 File Offset: 0x00007308
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00009134 File Offset: 0x00007334
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			return Physics.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00009154 File Offset: 0x00007354
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			return Physics.SphereCast(origin, radius, direction, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00009174 File Offset: 0x00007374
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo)
		{
			return Physics.SphereCast(origin, radius, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00009198 File Offset: 0x00007398
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.SphereCast(ray.origin, radius, ray.direction, out raycastHit, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000091C4 File Offset: 0x000073C4
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask)
		{
			return Physics.SphereCast(ray, radius, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000091E0 File Offset: 0x000073E0
		public static bool SphereCast(Ray ray, float radius, float maxDistance)
		{
			return Physics.SphereCast(ray, radius, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00009200 File Offset: 0x00007400
		public static bool SphereCast(Ray ray, float radius)
		{
			return Physics.SphereCast(ray, radius, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00009224 File Offset: 0x00007424
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.SphereCast(ray.origin, radius, ray.direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00009250 File Offset: 0x00007450
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			return Physics.SphereCast(ray, radius, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00009270 File Offset: 0x00007470
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance)
		{
			return Physics.SphereCast(ray, radius, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00009290 File Offset: 0x00007490
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo)
		{
			return Physics.SphereCast(ray, radius, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000092B4 File Offset: 0x000074B4
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.defaultPhysicsScene.BoxCast(center, halfExtents, direction, out raycastHit, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000092E0 File Offset: 0x000074E0
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00009300 File Offset: 0x00007500
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00009320 File Offset: 0x00007520
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
		{
			return Physics.BoxCast(center, halfExtents, direction, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00009344 File Offset: 0x00007544
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction)
		{
			return Physics.BoxCast(center, halfExtents, direction, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000936C File Offset: 0x0000756C
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00009398 File Offset: 0x00007598
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000093BC File Offset: 0x000075BC
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000093E0 File Offset: 0x000075E0
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00009408 File Offset: 0x00007608
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002F34 File Offset: 0x00001134
		public static Il2CppStructArray<RaycastHit> Query_CapsuleCastAll(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Query_CapsuleCastAll_Injected(ref physicsScene, ref p0, ref p1, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002F4A File Offset: 0x0000114A
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00009430 File Offset: 0x00007630
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCastAll(point1, point2, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00009450 File Offset: 0x00007650
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
		{
			return Physics.CapsuleCastAll(point1, point2, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00009470 File Offset: 0x00007670
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
		{
			return Physics.CapsuleCastAll(point1, point2, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002F57 File Offset: 0x00001157
		public static Il2CppStructArray<RaycastHit> Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Query_SphereCastAll_Injected(ref physicsScene, ref origin, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002F6B File Offset: 0x0000116B
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00009494 File Offset: 0x00007694
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask)
		{
			return Physics.SphereCastAll(origin, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000094B4 File Offset: 0x000076B4
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance)
		{
			return Physics.SphereCastAll(origin, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000094D4 File Offset: 0x000076D4
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction)
		{
			return Physics.SphereCastAll(origin, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000094F8 File Offset: 0x000076F8
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.SphereCastAll(ray.origin, radius, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00009524 File Offset: 0x00007724
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask)
		{
			return Physics.SphereCastAll(ray, radius, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00009540 File Offset: 0x00007740
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance)
		{
			return Physics.SphereCastAll(ray, radius, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00009560 File Offset: 0x00007760
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius)
		{
			return Physics.SphereCastAll(ray, radius, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002F78 File Offset: 0x00001178
		public static Il2CppReferenceArray<Collider> OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapCapsule_Internal_Injected(ref physicsScene, ref point0, ref point1, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00009584 File Offset: 0x00007784
		public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapCapsule_Internal(Physics.defaultPhysicsScene, point0, point1, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000095A8 File Offset: 0x000077A8
		public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask)
		{
			return Physics.OverlapCapsule(point0, point1, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000095C4 File Offset: 0x000077C4
		public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius)
		{
			return Physics.OverlapCapsule(point0, point1, radius, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002F8A File Offset: 0x0000118A
		public static Il2CppReferenceArray<Collider> OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapSphere_Internal_Injected(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000095E0 File Offset: 0x000077E0
		public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapSphere_Internal(Physics.defaultPhysicsScene, position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00009600 File Offset: 0x00007800
		public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius, int layerMask)
		{
			return Physics.OverlapSphere(position, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000961C File Offset: 0x0000781C
		public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius)
		{
			return Physics.OverlapSphere(position, radius, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002F99 File Offset: 0x00001199
		public static void Simulate_Internal(PhysicsScene physicsScene, float step)
		{
			Physics.Simulate_Internal_Injected(ref physicsScene, step);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00009638 File Offset: 0x00007838
		public static void Simulate(float step)
		{
			bool autoSimulation = Physics.autoSimulation;
			if (autoSimulation)
			{
				Debug.LogWarning("Physics.Simulate(...) was called but auto simulation is active. You should disable auto simulation first before calling this function therefore the simulation was not run.");
			}
			else
			{
				Physics.Simulate_Internal(Physics.defaultPhysicsScene, step);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00002FA3 File Offset: 0x000011A3
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002FAF File Offset: 0x000011AF
		public static bool autoSimulation
		{
			get
			{
				return Physics.get_autoSimulationDelegateField();
			}
			set
			{
				Physics.set_autoSimulationDelegateField(value);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002FBC File Offset: 0x000011BC
		public static void SyncTransforms()
		{
			Physics.SyncTransformsDelegateField();
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00002FC8 File Offset: 0x000011C8
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002FD4 File Offset: 0x000011D4
		public static bool autoSyncTransforms
		{
			get
			{
				return Physics.get_autoSyncTransformsDelegateField();
			}
			set
			{
				Physics.set_autoSyncTransformsDelegateField(value);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00002FE1 File Offset: 0x000011E1
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002FED File Offset: 0x000011ED
		public static bool reuseCollisionCallbacks
		{
			get
			{
				return Physics.get_reuseCollisionCallbacksDelegateField();
			}
			set
			{
				Physics.set_reuseCollisionCallbacksDelegateField(value);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002FFA File Offset: 0x000011FA
		public static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance)
		{
			return Physics.Query_ComputePenetration_Injected(colliderA, ref positionA, ref rotationA, colliderB, ref positionB, ref rotationB, ref direction, ref distance);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000966C File Offset: 0x0000786C
		public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance)
		{
			direction = Vector3.zero;
			distance = 0f;
			return Physics.Query_ComputePenetration(colliderA, positionA, rotationA, colliderB, positionB, rotationB, ref direction, ref distance);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000096A4 File Offset: 0x000078A4
		public static Vector3 Query_ClosestPoint(Collider collider, Vector3 position, Quaternion rotation, Vector3 point)
		{
			Vector3 vector;
			Physics.Query_ClosestPoint_Injected(collider, ref position, ref rotation, ref point, out vector);
			return vector;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000096C0 File Offset: 0x000078C0
		public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation)
		{
			return Physics.Query_ClosestPoint(collider, position, rotation, point);
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000300F File Offset: 0x0000120F
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0000301B File Offset: 0x0000121B
		public static float interCollisionDistance
		{
			get
			{
				return Physics.get_interCollisionDistanceDelegateField();
			}
			set
			{
				Physics.set_interCollisionDistanceDelegateField(value);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00003028 File Offset: 0x00001228
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00003034 File Offset: 0x00001234
		public static float interCollisionStiffness
		{
			get
			{
				return Physics.get_interCollisionStiffnessDelegateField();
			}
			set
			{
				Physics.set_interCollisionStiffnessDelegateField(value);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00003041 File Offset: 0x00001241
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0000304D File Offset: 0x0000124D
		public static bool interCollisionSettingsToggle
		{
			get
			{
				return Physics.get_interCollisionSettingsToggleDelegateField();
			}
			set
			{
				Physics.set_interCollisionSettingsToggleDelegateField(value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000096DC File Offset: 0x000078DC
		// (set) Token: 0x06000232 RID: 562 RVA: 0x0000305A File Offset: 0x0000125A
		public static Vector3 clothGravity
		{
			get
			{
				Vector3 vector;
				Physics.get_clothGravity_Injected(out vector);
				return vector;
			}
			set
			{
				Physics.set_clothGravity_Injected(ref value);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000096F4 File Offset: 0x000078F4
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.OverlapSphere(position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000971C File Offset: 0x0000791C
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask)
		{
			return Physics.OverlapSphereNonAlloc(position, radius, results, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00009738 File Offset: 0x00007938
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results)
		{
			return Physics.OverlapSphereNonAlloc(position, radius, results, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00003063 File Offset: 0x00001263
		public static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckSphere_Internal_Injected(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00009754 File Offset: 0x00007954
		public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckSphere_Internal(Physics.defaultPhysicsScene, position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00009774 File Offset: 0x00007974
		public static bool CheckSphere(Vector3 position, float radius, int layerMask)
		{
			return Physics.CheckSphere(position, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00009790 File Offset: 0x00007990
		public static bool CheckSphere(Vector3 position, float radius)
		{
			return Physics.CheckSphere(position, radius, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000097AC File Offset: 0x000079AC
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000097D8 File Offset: 0x000079D8
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000097FC File Offset: 0x000079FC
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			return Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00009820 File Offset: 0x00007A20
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00009848 File Offset: 0x00007A48
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.SphereCast(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00009874 File Offset: 0x00007A74
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00009894 File Offset: 0x00007A94
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000098B4 File Offset: 0x00007AB4
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000098D8 File Offset: 0x00007AD8
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.SphereCastNonAlloc(ray.origin, radius, ray.direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00009904 File Offset: 0x00007B04
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			return Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00009924 File Offset: 0x00007B24
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			return Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00009944 File Offset: 0x00007B44
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.SphereCastNonAlloc(ray, radius, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00003072 File Offset: 0x00001272
		public static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckCapsule_Internal_Injected(ref physicsScene, ref start, ref end, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00009968 File Offset: 0x00007B68
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckCapsule_Internal(Physics.defaultPhysicsScene, start, end, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000998C File Offset: 0x00007B8C
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask)
		{
			return Physics.CheckCapsule(start, end, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000099A8 File Offset: 0x00007BA8
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius)
		{
			return Physics.CheckCapsule(start, end, radius, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00003084 File Offset: 0x00001284
		public static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckBox_Internal_Injected(ref physicsScene, ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000099C8 File Offset: 0x00007BC8
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckBox_Internal(Physics.defaultPhysicsScene, center, halfExtents, orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000099EC File Offset: 0x00007BEC
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask)
		{
			return Physics.CheckBox(center, halfExtents, orientation, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00009A08 File Offset: 0x00007C08
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
		{
			return Physics.CheckBox(center, halfExtents, orientation, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00009A28 File Offset: 0x00007C28
		public static bool CheckBox(Vector3 center, Vector3 halfExtents)
		{
			return Physics.CheckBox(center, halfExtents, Quaternion.identity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00003097 File Offset: 0x00001297
		public static Il2CppReferenceArray<Collider> OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapBox_Internal_Injected(ref physicsScene, ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00009A4C File Offset: 0x00007C4C
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapBox_Internal(Physics.defaultPhysicsScene, center, halfExtents, orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00009A70 File Offset: 0x00007C70
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask)
		{
			return Physics.OverlapBox(center, halfExtents, orientation, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00009A8C File Offset: 0x00007C8C
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
		{
			return Physics.OverlapBox(center, halfExtents, orientation, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00009AA8 File Offset: 0x00007CA8
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents)
		{
			return Physics.OverlapBox(center, halfExtents, Quaternion.identity, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00009AC8 File Offset: 0x00007CC8
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.OverlapBox(center, halfExtents, results, orientation, mask, queryTriggerInteraction);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00009AF0 File Offset: 0x00007CF0
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask)
		{
			return Physics.OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00009B10 File Offset: 0x00007D10
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation)
		{
			return Physics.OverlapBoxNonAlloc(center, halfExtents, results, orientation, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00009B30 File Offset: 0x00007D30
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results)
		{
			return Physics.OverlapBoxNonAlloc(center, halfExtents, results, Quaternion.identity, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00009B54 File Offset: 0x00007D54
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.BoxCast(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00009B80 File Offset: 0x00007D80
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00009BA8 File Offset: 0x00007DA8
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00009BCC File Offset: 0x00007DCC
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00009BF0 File Offset: 0x00007DF0
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000030AA File Offset: 0x000012AA
		public static Il2CppStructArray<RaycastHit> Internal_BoxCastAll(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Internal_BoxCastAll_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000030C1 File Offset: 0x000012C1
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00009C18 File Offset: 0x00007E18
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00009C38 File Offset: 0x00007E38
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00009C58 File Offset: 0x00007E58
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00009C7C File Offset: 0x00007E7C
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00009CA4 File Offset: 0x00007EA4
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.OverlapCapsule(point0, point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00009CCC File Offset: 0x00007ECC
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask)
		{
			return Physics.OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00009CEC File Offset: 0x00007EEC
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results)
		{
			return Physics.OverlapCapsuleNonAlloc(point0, point1, radius, results, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000030CE File Offset: 0x000012CE
		public static void Internal_RebuildBroadphaseRegions(Bounds bounds, int subdivisions)
		{
			Physics.Internal_RebuildBroadphaseRegions_Injected(ref bounds, subdivisions);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00009D0C File Offset: 0x00007F0C
		public static void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions)
		{
			bool flag = subdivisions < 1 || subdivisions > 16;
			if (flag)
			{
				throw new ArgumentException("Physics.RebuildBroadphaseRegions requires the subdivisions to be greater than zero and less than 17.");
			}
			bool flag2 = worldBounds.extents.x <= 0f || worldBounds.extents.y <= 0f || worldBounds.extents.z <= 0f;
			if (flag2)
			{
				throw new ArgumentException("Physics.RebuildBroadphaseRegions requires the world bounds to be non-empty, and have positive extents.");
			}
			Physics.Internal_RebuildBroadphaseRegions(worldBounds, subdivisions);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000030D8 File Offset: 0x000012D8
		public static void BakeMesh(int meshID, bool convex)
		{
			Physics.BakeMeshDelegateField(meshID, convex);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000030E6 File Offset: 0x000012E6
		public static void get_gravity_Injected(out Vector3 ret)
		{
			Physics.get_gravity_InjectedDelegateField(out ret);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000030F3 File Offset: 0x000012F3
		public static void set_gravity_Injected(ref Vector3 value)
		{
			Physics.set_gravity_InjectedDelegateField(ref value);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00009D90 File Offset: 0x00007F90
		public static Il2CppStructArray<RaycastHit> Query_CapsuleCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.Query_CapsuleCastAll_InjectedDelegateField(ref physicsScene, ref p0, ref p1, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00009DC4 File Offset: 0x00007FC4
		public static Il2CppStructArray<RaycastHit> Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.Query_SphereCastAll_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00009DF4 File Offset: 0x00007FF4
		public static Il2CppReferenceArray<Collider> OverlapCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.OverlapCapsule_Internal_InjectedDelegateField(ref physicsScene, ref point0, ref point1, radius, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00009E24 File Offset: 0x00008024
		public static Il2CppReferenceArray<Collider> OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.OverlapSphere_Internal_InjectedDelegateField(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00003100 File Offset: 0x00001300
		public static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step)
		{
			Physics.Simulate_Internal_InjectedDelegateField(ref physicsScene, step);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00009E50 File Offset: 0x00008050
		public static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance)
		{
			return Physics.Query_ComputePenetration_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(colliderA), ref positionA, ref rotationA, IL2CPP.Il2CppObjectBaseToPtr(colliderB), ref positionB, ref rotationB, ref direction, ref distance);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000310E File Offset: 0x0000130E
		public static void Query_ClosestPoint_Injected(Collider collider, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret)
		{
			Physics.Query_ClosestPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref position, ref rotation, ref point, out ret);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00003125 File Offset: 0x00001325
		public static void get_clothGravity_Injected(out Vector3 ret)
		{
			Physics.get_clothGravity_InjectedDelegateField(out ret);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00003132 File Offset: 0x00001332
		public static void set_clothGravity_Injected(ref Vector3 value)
		{
			Physics.set_clothGravity_InjectedDelegateField(ref value);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000313F File Offset: 0x0000133F
		public static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckSphere_Internal_InjectedDelegateField(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00003151 File Offset: 0x00001351
		public static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckCapsule_Internal_InjectedDelegateField(ref physicsScene, ref start, ref end, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00003165 File Offset: 0x00001365
		public static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckBox_Internal_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00009E80 File Offset: 0x00008080
		public static Il2CppReferenceArray<Collider> OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.OverlapBox_Internal_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00009EB0 File Offset: 0x000080B0
		public static Il2CppStructArray<RaycastHit> Internal_BoxCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.Internal_BoxCastAll_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00003179 File Offset: 0x00001379
		public static void Internal_RebuildBroadphaseRegions_Injected(ref Bounds bounds, int subdivisions)
		{
			Physics.Internal_RebuildBroadphaseRegions_InjectedDelegateField(ref bounds, subdivisions);
		}

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultPhysicsScene_Injected_Private_Static_Void_byref_PhysicsScene_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Il2CppStructArray_1_RaycastHit_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000125 RID: 293
		public const float k_MaxFloatMinusEpsilon = 3.4028233E+38f;

		// Token: 0x04000126 RID: 294
		public const int IgnoreRaycastLayer = 4;

		// Token: 0x04000127 RID: 295
		public const int DefaultRaycastLayers = -5;

		// Token: 0x04000128 RID: 296
		public const int AllLayers = -1;

		// Token: 0x04000129 RID: 297
		public const int kIgnoreRaycastLayer = 4;

		// Token: 0x0400012A RID: 298
		public const int kDefaultRaycastLayers = -5;

		// Token: 0x0400012B RID: 299
		public const int kAllLayers = -1;

		// Token: 0x0400012C RID: 300
		private static readonly Physics.get_defaultContactOffsetDelegate get_defaultContactOffsetDelegateField;

		// Token: 0x0400012D RID: 301
		private static readonly Physics.set_defaultContactOffsetDelegate set_defaultContactOffsetDelegateField;

		// Token: 0x0400012E RID: 302
		private static readonly Physics.get_sleepThresholdDelegate get_sleepThresholdDelegateField;

		// Token: 0x0400012F RID: 303
		private static readonly Physics.set_sleepThresholdDelegate set_sleepThresholdDelegateField;

		// Token: 0x04000130 RID: 304
		private static readonly Physics.get_queriesHitTriggersDelegate get_queriesHitTriggersDelegateField;

		// Token: 0x04000131 RID: 305
		private static readonly Physics.set_queriesHitTriggersDelegate set_queriesHitTriggersDelegateField;

		// Token: 0x04000132 RID: 306
		private static readonly Physics.get_queriesHitBackfacesDelegate get_queriesHitBackfacesDelegateField;

		// Token: 0x04000133 RID: 307
		private static readonly Physics.set_queriesHitBackfacesDelegate set_queriesHitBackfacesDelegateField;

		// Token: 0x04000134 RID: 308
		private static readonly Physics.get_bounceThresholdDelegate get_bounceThresholdDelegateField;

		// Token: 0x04000135 RID: 309
		private static readonly Physics.set_bounceThresholdDelegate set_bounceThresholdDelegateField;

		// Token: 0x04000136 RID: 310
		private static readonly Physics.get_defaultMaxDepenetrationVelocityDelegate get_defaultMaxDepenetrationVelocityDelegateField;

		// Token: 0x04000137 RID: 311
		private static readonly Physics.set_defaultMaxDepenetrationVelocityDelegate set_defaultMaxDepenetrationVelocityDelegateField;

		// Token: 0x04000138 RID: 312
		private static readonly Physics.get_defaultSolverIterationsDelegate get_defaultSolverIterationsDelegateField;

		// Token: 0x04000139 RID: 313
		private static readonly Physics.set_defaultSolverIterationsDelegate set_defaultSolverIterationsDelegateField;

		// Token: 0x0400013A RID: 314
		private static readonly Physics.get_defaultSolverVelocityIterationsDelegate get_defaultSolverVelocityIterationsDelegateField;

		// Token: 0x0400013B RID: 315
		private static readonly Physics.set_defaultSolverVelocityIterationsDelegate set_defaultSolverVelocityIterationsDelegateField;

		// Token: 0x0400013C RID: 316
		private static readonly Physics.get_defaultMaxAngularSpeedDelegate get_defaultMaxAngularSpeedDelegateField;

		// Token: 0x0400013D RID: 317
		private static readonly Physics.set_defaultMaxAngularSpeedDelegate set_defaultMaxAngularSpeedDelegateField;

		// Token: 0x0400013E RID: 318
		private static readonly Physics.IgnoreCollisionDelegate IgnoreCollisionDelegateField;

		// Token: 0x0400013F RID: 319
		private static readonly Physics.IgnoreLayerCollisionDelegate IgnoreLayerCollisionDelegateField;

		// Token: 0x04000140 RID: 320
		private static readonly Physics.GetIgnoreLayerCollisionDelegate GetIgnoreLayerCollisionDelegateField;

		// Token: 0x04000141 RID: 321
		private static readonly Physics.GetIgnoreCollisionDelegate GetIgnoreCollisionDelegateField;

		// Token: 0x04000142 RID: 322
		private static readonly Physics.get_autoSimulationDelegate get_autoSimulationDelegateField;

		// Token: 0x04000143 RID: 323
		private static readonly Physics.set_autoSimulationDelegate set_autoSimulationDelegateField;

		// Token: 0x04000144 RID: 324
		private static readonly Physics.SyncTransformsDelegate SyncTransformsDelegateField;

		// Token: 0x04000145 RID: 325
		private static readonly Physics.get_autoSyncTransformsDelegate get_autoSyncTransformsDelegateField;

		// Token: 0x04000146 RID: 326
		private static readonly Physics.set_autoSyncTransformsDelegate set_autoSyncTransformsDelegateField;

		// Token: 0x04000147 RID: 327
		private static readonly Physics.get_reuseCollisionCallbacksDelegate get_reuseCollisionCallbacksDelegateField;

		// Token: 0x04000148 RID: 328
		private static readonly Physics.set_reuseCollisionCallbacksDelegate set_reuseCollisionCallbacksDelegateField;

		// Token: 0x04000149 RID: 329
		private static readonly Physics.get_interCollisionDistanceDelegate get_interCollisionDistanceDelegateField;

		// Token: 0x0400014A RID: 330
		private static readonly Physics.set_interCollisionDistanceDelegate set_interCollisionDistanceDelegateField;

		// Token: 0x0400014B RID: 331
		private static readonly Physics.get_interCollisionStiffnessDelegate get_interCollisionStiffnessDelegateField;

		// Token: 0x0400014C RID: 332
		private static readonly Physics.set_interCollisionStiffnessDelegate set_interCollisionStiffnessDelegateField;

		// Token: 0x0400014D RID: 333
		private static readonly Physics.get_interCollisionSettingsToggleDelegate get_interCollisionSettingsToggleDelegateField;

		// Token: 0x0400014E RID: 334
		private static readonly Physics.set_interCollisionSettingsToggleDelegate set_interCollisionSettingsToggleDelegateField;

		// Token: 0x0400014F RID: 335
		private static readonly Physics.BakeMeshDelegate BakeMeshDelegateField;

		// Token: 0x04000150 RID: 336
		private static readonly Physics.get_gravity_InjectedDelegate get_gravity_InjectedDelegateField;

		// Token: 0x04000151 RID: 337
		private static readonly Physics.set_gravity_InjectedDelegate set_gravity_InjectedDelegateField;

		// Token: 0x04000152 RID: 338
		private static readonly Physics.Query_CapsuleCastAll_InjectedDelegate Query_CapsuleCastAll_InjectedDelegateField;

		// Token: 0x04000153 RID: 339
		private static readonly Physics.Query_SphereCastAll_InjectedDelegate Query_SphereCastAll_InjectedDelegateField;

		// Token: 0x04000154 RID: 340
		private static readonly Physics.OverlapCapsule_Internal_InjectedDelegate OverlapCapsule_Internal_InjectedDelegateField;

		// Token: 0x04000155 RID: 341
		private static readonly Physics.OverlapSphere_Internal_InjectedDelegate OverlapSphere_Internal_InjectedDelegateField;

		// Token: 0x04000156 RID: 342
		private static readonly Physics.Simulate_Internal_InjectedDelegate Simulate_Internal_InjectedDelegateField;

		// Token: 0x04000157 RID: 343
		private static readonly Physics.Query_ComputePenetration_InjectedDelegate Query_ComputePenetration_InjectedDelegateField;

		// Token: 0x04000158 RID: 344
		private static readonly Physics.Query_ClosestPoint_InjectedDelegate Query_ClosestPoint_InjectedDelegateField;

		// Token: 0x04000159 RID: 345
		private static readonly Physics.get_clothGravity_InjectedDelegate get_clothGravity_InjectedDelegateField;

		// Token: 0x0400015A RID: 346
		private static readonly Physics.set_clothGravity_InjectedDelegate set_clothGravity_InjectedDelegateField;

		// Token: 0x0400015B RID: 347
		private static readonly Physics.CheckSphere_Internal_InjectedDelegate CheckSphere_Internal_InjectedDelegateField;

		// Token: 0x0400015C RID: 348
		private static readonly Physics.CheckCapsule_Internal_InjectedDelegate CheckCapsule_Internal_InjectedDelegateField;

		// Token: 0x0400015D RID: 349
		private static readonly Physics.CheckBox_Internal_InjectedDelegate CheckBox_Internal_InjectedDelegateField;

		// Token: 0x0400015E RID: 350
		private static readonly Physics.OverlapBox_Internal_InjectedDelegate OverlapBox_Internal_InjectedDelegateField;

		// Token: 0x0400015F RID: 351
		private static readonly Physics.Internal_BoxCastAll_InjectedDelegate Internal_BoxCastAll_InjectedDelegateField;

		// Token: 0x04000160 RID: 352
		private static readonly Physics.Internal_RebuildBroadphaseRegions_InjectedDelegate Internal_RebuildBroadphaseRegions_InjectedDelegateField;

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x0600046A RID: 1130
		private delegate float get_defaultContactOffsetDelegate();

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x0600046C RID: 1132
		private delegate void set_defaultContactOffsetDelegate(float value);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x0600046E RID: 1134
		private delegate float get_sleepThresholdDelegate();

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000470 RID: 1136
		private delegate void set_sleepThresholdDelegate(float value);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x06000472 RID: 1138
		private delegate bool get_queriesHitTriggersDelegate();

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x06000474 RID: 1140
		private delegate void set_queriesHitTriggersDelegate(bool value);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x06000476 RID: 1142
		private delegate bool get_queriesHitBackfacesDelegate();

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x06000478 RID: 1144
		private delegate void set_queriesHitBackfacesDelegate(bool value);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x0600047A RID: 1146
		private delegate float get_bounceThresholdDelegate();

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x0600047C RID: 1148
		private delegate void set_bounceThresholdDelegate(float value);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x0600047E RID: 1150
		private delegate float get_defaultMaxDepenetrationVelocityDelegate();

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000480 RID: 1152
		private delegate void set_defaultMaxDepenetrationVelocityDelegate(float value);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x06000482 RID: 1154
		private delegate int get_defaultSolverIterationsDelegate();

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x06000484 RID: 1156
		private delegate void set_defaultSolverIterationsDelegate(int value);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x06000486 RID: 1158
		private delegate int get_defaultSolverVelocityIterationsDelegate();

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x06000488 RID: 1160
		private delegate void set_defaultSolverVelocityIterationsDelegate(int value);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x0600048A RID: 1162
		private delegate float get_defaultMaxAngularSpeedDelegate();

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x0600048C RID: 1164
		private delegate void set_defaultMaxAngularSpeedDelegate(float value);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x0600048E RID: 1166
		private delegate void IgnoreCollisionDelegate(IntPtr collider1, IntPtr collider2, bool ignore);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x06000490 RID: 1168
		private delegate void IgnoreLayerCollisionDelegate(int layer1, int layer2, bool ignore);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x06000492 RID: 1170
		private delegate bool GetIgnoreLayerCollisionDelegate(int layer1, int layer2);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x06000494 RID: 1172
		private delegate bool GetIgnoreCollisionDelegate(IntPtr collider1, IntPtr collider2);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x06000496 RID: 1174
		private delegate bool get_autoSimulationDelegate();

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x06000498 RID: 1176
		private delegate void set_autoSimulationDelegate(bool value);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x0600049A RID: 1178
		private delegate void SyncTransformsDelegate();

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x0600049C RID: 1180
		private delegate bool get_autoSyncTransformsDelegate();

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x0600049E RID: 1182
		private delegate void set_autoSyncTransformsDelegate(bool value);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x060004A0 RID: 1184
		private delegate bool get_reuseCollisionCallbacksDelegate();

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x060004A2 RID: 1186
		private delegate void set_reuseCollisionCallbacksDelegate(bool value);

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x060004A4 RID: 1188
		private delegate float get_interCollisionDistanceDelegate();

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x060004A6 RID: 1190
		private delegate void set_interCollisionDistanceDelegate(float value);

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x060004A8 RID: 1192
		private delegate float get_interCollisionStiffnessDelegate();

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x060004AA RID: 1194
		private delegate void set_interCollisionStiffnessDelegate(float value);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x060004AC RID: 1196
		private delegate bool get_interCollisionSettingsToggleDelegate();

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x060004AE RID: 1198
		private delegate void set_interCollisionSettingsToggleDelegate(bool value);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x060004B0 RID: 1200
		private delegate void BakeMeshDelegate(int meshID, bool convex);

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x060004B2 RID: 1202
		private delegate void get_gravity_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x060004B4 RID: 1204
		private delegate void set_gravity_InjectedDelegate(IntPtr value);

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x060004B6 RID: 1206
		private delegate IntPtr Query_CapsuleCastAll_InjectedDelegate(IntPtr physicsScene, IntPtr p0, IntPtr p1, float radius, IntPtr direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x060004B8 RID: 1208
		private delegate IntPtr Query_SphereCastAll_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x060004BA RID: 1210
		private delegate IntPtr OverlapCapsule_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point0, IntPtr point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x060004BC RID: 1212
		private delegate IntPtr OverlapSphere_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x060004BE RID: 1214
		private delegate void Simulate_Internal_InjectedDelegate(IntPtr physicsScene, float step);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x060004C0 RID: 1216
		private delegate bool Query_ComputePenetration_InjectedDelegate(IntPtr colliderA, IntPtr positionA, IntPtr rotationA, IntPtr colliderB, IntPtr positionB, IntPtr rotationB, IntPtr direction, IntPtr distance);

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x060004C2 RID: 1218
		private delegate void Query_ClosestPoint_InjectedDelegate(IntPtr collider, IntPtr position, IntPtr rotation, IntPtr point, [Out] IntPtr ret);

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x060004C4 RID: 1220
		private delegate void get_clothGravity_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x060004C6 RID: 1222
		private delegate void set_clothGravity_InjectedDelegate(IntPtr value);

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x060004C8 RID: 1224
		private delegate bool CheckSphere_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x060004CA RID: 1226
		private delegate bool CheckCapsule_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr start, IntPtr end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x060004CC RID: 1228
		private delegate bool CheckBox_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x060004CE RID: 1230
		private delegate IntPtr OverlapBox_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x060004D0 RID: 1232
		private delegate IntPtr Internal_BoxCastAll_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr direction, IntPtr orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x060004D2 RID: 1234
		private delegate void Internal_RebuildBroadphaseRegions_InjectedDelegate(IntPtr bounds, int subdivisions);
	}
}
