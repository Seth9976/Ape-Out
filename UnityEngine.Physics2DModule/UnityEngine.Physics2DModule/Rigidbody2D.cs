using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public sealed class Rigidbody2D : Component
	{
		// Token: 0x0600022C RID: 556 RVA: 0x0000AEDC File Offset: 0x000090DC
		// Note: this type is marked as 'beforefieldinit'.
		static Rigidbody2D()
		{
			Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Rigidbody2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr);
			Rigidbody2D.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663402);
			Rigidbody2D.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663403);
			Rigidbody2D.NativeMethodInfoPtr_get_rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663404);
			Rigidbody2D.NativeMethodInfoPtr_MovePosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663405);
			Rigidbody2D.NativeMethodInfoPtr_MoveRotation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663406);
			Rigidbody2D.NativeMethodInfoPtr_MoveRotation_Angle_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663407);
			Rigidbody2D.NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663408);
			Rigidbody2D.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663409);
			Rigidbody2D.NativeMethodInfoPtr_get_angularVelocity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663410);
			Rigidbody2D.NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663411);
			Rigidbody2D.NativeMethodInfoPtr_get_mass_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663412);
			Rigidbody2D.NativeMethodInfoPtr_set_centerOfMass_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663413);
			Rigidbody2D.NativeMethodInfoPtr_set_drag_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663414);
			Rigidbody2D.NativeMethodInfoPtr_set_angularDrag_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663415);
			Rigidbody2D.NativeMethodInfoPtr_get_bodyType_Public_get_RigidbodyType2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663416);
			Rigidbody2D.NativeMethodInfoPtr_set_bodyType_Public_set_Void_RigidbodyType2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663417);
			Rigidbody2D.NativeMethodInfoPtr_get_isKinematic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663418);
			Rigidbody2D.NativeMethodInfoPtr_set_isKinematic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663419);
			Rigidbody2D.NativeMethodInfoPtr_set_simulated_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663420);
			Rigidbody2D.NativeMethodInfoPtr_AddForce_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663421);
			Rigidbody2D.NativeMethodInfoPtr_AddForce_Public_Void_Vector2_ForceMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663422);
			Rigidbody2D.NativeMethodInfoPtr_AddTorque_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663423);
			Rigidbody2D.NativeMethodInfoPtr_AddTorque_Public_Void_Single_ForceMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663424);
			Rigidbody2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663425);
			Rigidbody2D.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663426);
			Rigidbody2D.NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663427);
			Rigidbody2D.NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663428);
			Rigidbody2D.NativeMethodInfoPtr_get_velocity_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663429);
			Rigidbody2D.NativeMethodInfoPtr_set_velocity_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663430);
			Rigidbody2D.NativeMethodInfoPtr_set_centerOfMass_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663431);
			Rigidbody2D.NativeMethodInfoPtr_AddForce_Injected_Private_Void_byref_Vector2_ForceMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663432);
			Rigidbody2D.set_rotationDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_rotationDelegate>("UnityEngine.Rigidbody2D::set_rotation");
			Rigidbody2D.SetRotation_AngleDelegateField = IL2CPP.ResolveICall<Rigidbody2D.SetRotation_AngleDelegate>("UnityEngine.Rigidbody2D::SetRotation_Angle");
			Rigidbody2D.get_useAutoMassDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_useAutoMassDelegate>("UnityEngine.Rigidbody2D::get_useAutoMass");
			Rigidbody2D.set_useAutoMassDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_useAutoMassDelegate>("UnityEngine.Rigidbody2D::set_useAutoMass");
			Rigidbody2D.set_massDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_massDelegate>("UnityEngine.Rigidbody2D::set_mass");
			Rigidbody2D.get_sharedMaterialDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_sharedMaterialDelegate>("UnityEngine.Rigidbody2D::get_sharedMaterial");
			Rigidbody2D.set_sharedMaterialDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_sharedMaterialDelegate>("UnityEngine.Rigidbody2D::set_sharedMaterial");
			Rigidbody2D.get_inertiaDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_inertiaDelegate>("UnityEngine.Rigidbody2D::get_inertia");
			Rigidbody2D.set_inertiaDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_inertiaDelegate>("UnityEngine.Rigidbody2D::set_inertia");
			Rigidbody2D.get_dragDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_dragDelegate>("UnityEngine.Rigidbody2D::get_drag");
			Rigidbody2D.get_angularDragDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_angularDragDelegate>("UnityEngine.Rigidbody2D::get_angularDrag");
			Rigidbody2D.get_gravityScaleDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_gravityScaleDelegate>("UnityEngine.Rigidbody2D::get_gravityScale");
			Rigidbody2D.set_gravityScaleDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_gravityScaleDelegate>("UnityEngine.Rigidbody2D::set_gravityScale");
			Rigidbody2D.SetDragBehaviourDelegateField = IL2CPP.ResolveICall<Rigidbody2D.SetDragBehaviourDelegate>("UnityEngine.Rigidbody2D::SetDragBehaviour");
			Rigidbody2D.get_useFullKinematicContactsDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_useFullKinematicContactsDelegate>("UnityEngine.Rigidbody2D::get_useFullKinematicContacts");
			Rigidbody2D.set_useFullKinematicContactsDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_useFullKinematicContactsDelegate>("UnityEngine.Rigidbody2D::set_useFullKinematicContacts");
			Rigidbody2D.get_fixedAngleDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_fixedAngleDelegate>("UnityEngine.Rigidbody2D::get_fixedAngle");
			Rigidbody2D.set_fixedAngleDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_fixedAngleDelegate>("UnityEngine.Rigidbody2D::set_fixedAngle");
			Rigidbody2D.get_freezeRotationDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_freezeRotationDelegate>("UnityEngine.Rigidbody2D::get_freezeRotation");
			Rigidbody2D.set_freezeRotationDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_freezeRotationDelegate>("UnityEngine.Rigidbody2D::set_freezeRotation");
			Rigidbody2D.get_constraintsDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_constraintsDelegate>("UnityEngine.Rigidbody2D::get_constraints");
			Rigidbody2D.set_constraintsDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_constraintsDelegate>("UnityEngine.Rigidbody2D::set_constraints");
			Rigidbody2D.IsSleepingDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsSleepingDelegate>("UnityEngine.Rigidbody2D::IsSleeping");
			Rigidbody2D.IsAwakeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsAwakeDelegate>("UnityEngine.Rigidbody2D::IsAwake");
			Rigidbody2D.SleepDelegateField = IL2CPP.ResolveICall<Rigidbody2D.SleepDelegate>("UnityEngine.Rigidbody2D::Sleep");
			Rigidbody2D.WakeUpDelegateField = IL2CPP.ResolveICall<Rigidbody2D.WakeUpDelegate>("UnityEngine.Rigidbody2D::WakeUp");
			Rigidbody2D.get_simulatedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_simulatedDelegate>("UnityEngine.Rigidbody2D::get_simulated");
			Rigidbody2D.get_interpolationDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_interpolationDelegate>("UnityEngine.Rigidbody2D::get_interpolation");
			Rigidbody2D.set_interpolationDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_interpolationDelegate>("UnityEngine.Rigidbody2D::set_interpolation");
			Rigidbody2D.get_sleepModeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_sleepModeDelegate>("UnityEngine.Rigidbody2D::get_sleepMode");
			Rigidbody2D.set_sleepModeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_sleepModeDelegate>("UnityEngine.Rigidbody2D::set_sleepMode");
			Rigidbody2D.get_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_collisionDetectionModeDelegate>("UnityEngine.Rigidbody2D::get_collisionDetectionMode");
			Rigidbody2D.set_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_collisionDetectionModeDelegate>("UnityEngine.Rigidbody2D::set_collisionDetectionMode");
			Rigidbody2D.get_attachedColliderCountDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_attachedColliderCountDelegate>("UnityEngine.Rigidbody2D::get_attachedColliderCount");
			Rigidbody2D.IsTouchingDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsTouchingDelegate>("UnityEngine.Rigidbody2D::IsTouching");
			Rigidbody2D.IsTouchingLayersDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsTouchingLayersDelegate>("UnityEngine.Rigidbody2D::IsTouchingLayers");
			Rigidbody2D.GetAttachedCollidersArray_InternalDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetAttachedCollidersArray_InternalDelegate>("UnityEngine.Rigidbody2D::GetAttachedCollidersArray_Internal");
			Rigidbody2D.GetAttachedCollidersList_InternalDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetAttachedCollidersList_InternalDelegate>("UnityEngine.Rigidbody2D::GetAttachedCollidersList_Internal");
			Rigidbody2D.SetRotation_Quaternion_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.SetRotation_Quaternion_InjectedDelegate>("UnityEngine.Rigidbody2D::SetRotation_Quaternion_Injected");
			Rigidbody2D.MoveRotation_Quaternion_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.MoveRotation_Quaternion_InjectedDelegate>("UnityEngine.Rigidbody2D::MoveRotation_Quaternion_Injected");
			Rigidbody2D.get_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody2D::get_centerOfMass_Injected");
			Rigidbody2D.get_worldCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_worldCenterOfMass_InjectedDelegate>("UnityEngine.Rigidbody2D::get_worldCenterOfMass_Injected");
			Rigidbody2D.IsTouching_OtherColliderWithFilter_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsTouching_OtherColliderWithFilter_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::IsTouching_OtherColliderWithFilter_Internal_Injected");
			Rigidbody2D.IsTouching_AnyColliderWithFilter_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsTouching_AnyColliderWithFilter_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::IsTouching_AnyColliderWithFilter_Internal_Injected");
			Rigidbody2D.OverlapPoint_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.OverlapPoint_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapPoint_Injected");
			Rigidbody2D.AddRelativeForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.AddRelativeForce_InjectedDelegate>("UnityEngine.Rigidbody2D::AddRelativeForce_Injected");
			Rigidbody2D.AddForceAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.AddForceAtPosition_InjectedDelegate>("UnityEngine.Rigidbody2D::AddForceAtPosition_Injected");
			Rigidbody2D.GetPoint_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetPoint_InjectedDelegate>("UnityEngine.Rigidbody2D::GetPoint_Injected");
			Rigidbody2D.GetRelativePoint_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetRelativePoint_InjectedDelegate>("UnityEngine.Rigidbody2D::GetRelativePoint_Injected");
			Rigidbody2D.GetVector_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetVector_InjectedDelegate>("UnityEngine.Rigidbody2D::GetVector_Injected");
			Rigidbody2D.GetRelativeVector_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetRelativeVector_InjectedDelegate>("UnityEngine.Rigidbody2D::GetRelativeVector_Injected");
			Rigidbody2D.GetPointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetPointVelocity_InjectedDelegate>("UnityEngine.Rigidbody2D::GetPointVelocity_Injected");
			Rigidbody2D.GetRelativePointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetRelativePointVelocity_InjectedDelegate>("UnityEngine.Rigidbody2D::GetRelativePointVelocity_Injected");
			Rigidbody2D.OverlapColliderArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.OverlapColliderArray_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapColliderArray_Internal_Injected");
			Rigidbody2D.OverlapColliderList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.OverlapColliderList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapColliderList_Internal_Injected");
			Rigidbody2D.CastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.CastArray_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastArray_Internal_Injected");
			Rigidbody2D.CastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.CastList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastList_Internal_Injected");
			Rigidbody2D.CastFilteredArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.CastFilteredArray_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastFilteredArray_Internal_Injected");
			Rigidbody2D.CastFilteredList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.CastFilteredList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastFilteredList_Internal_Injected");
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000B4F0 File Offset: 0x000096F0
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0000B52C File Offset: 0x0000972C
		public unsafe Vector2 position
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 513286, RefRangeEnd = 513287, XrefRangeStart = 513284, XrefRangeEnd = 513286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513287, XrefRangeEnd = 513289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000B56C File Offset: 0x0000976C
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002ACE File Offset: 0x00000CCE
		public unsafe float rotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513289, XrefRangeEnd = 513293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_get_rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Rigidbody2D.set_rotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000B5A8 File Offset: 0x000097A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 513295, RefRangeEnd = 513298, XrefRangeStart = 513293, XrefRangeEnd = 513295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePosition(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_MovePosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000B5E8 File Offset: 0x000097E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 513302, RefRangeEnd = 513306, XrefRangeStart = 513298, XrefRangeEnd = 513302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRotation(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_MoveRotation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000B628 File Offset: 0x00009828
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 513302, RefRangeEnd = 513306, XrefRangeStart = 513302, XrefRangeEnd = 513306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRotation_Angle(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_MoveRotation_Angle_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000B668 File Offset: 0x00009868
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0000B6A4 File Offset: 0x000098A4
		public unsafe Vector2 velocity
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 513308, RefRangeEnd = 513326, XrefRangeStart = 513306, XrefRangeEnd = 513308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 513328, RefRangeEnd = 513336, XrefRangeStart = 513326, XrefRangeEnd = 513328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000B6E4 File Offset: 0x000098E4
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0000B720 File Offset: 0x00009920
		public unsafe float angularVelocity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513336, XrefRangeEnd = 513340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_get_angularVelocity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 513344, RefRangeEnd = 513345, XrefRangeStart = 513340, XrefRangeEnd = 513344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000B760 File Offset: 0x00009960
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002B4E File Offset: 0x00000D4E
		public unsafe float mass
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513345, XrefRangeEnd = 513349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_get_mass_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Rigidbody2D.set_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000BCE0 File Offset: 0x00009EE0
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0000B79C File Offset: 0x0000999C
		public unsafe Vector2 centerOfMass
		{
			get
			{
				Vector2 vector;
				this.get_centerOfMass_Injected(out vector);
				return vector;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513349, XrefRangeEnd = 513351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_centerOfMass_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00002B9E File Offset: 0x00000D9E
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0000B7DC File Offset: 0x000099DC
		public unsafe float drag
		{
			get
			{
				return Rigidbody2D.get_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 513355, RefRangeEnd = 513357, XrefRangeStart = 513351, XrefRangeEnd = 513355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_drag_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0000B81C File Offset: 0x00009A1C
		public unsafe float angularDrag
		{
			get
			{
				return Rigidbody2D.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513357, XrefRangeEnd = 513361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_angularDrag_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000B85C File Offset: 0x00009A5C
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0000B898 File Offset: 0x00009A98
		public unsafe RigidbodyType2D bodyType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513361, XrefRangeEnd = 513365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_get_bodyType_Public_get_RigidbodyType2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513365, XrefRangeEnd = 513369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_bodyType_Public_set_Void_RigidbodyType2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000B8D8 File Offset: 0x00009AD8
		// (set) Token: 0x0600023E RID: 574 RVA: 0x0000B914 File Offset: 0x00009B14
		public unsafe bool isKinematic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513369, XrefRangeEnd = 513371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_get_isKinematic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 513376, RefRangeEnd = 513379, XrefRangeStart = 513371, XrefRangeEnd = 513376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_isKinematic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00002CD6 File Offset: 0x00000ED6
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0000B954 File Offset: 0x00009B54
		public unsafe bool simulated
		{
			get
			{
				return Rigidbody2D.get_simulatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 513383, RefRangeEnd = 513384, XrefRangeStart = 513379, XrefRangeEnd = 513383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_simulated_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000B994 File Offset: 0x00009B94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 513386, RefRangeEnd = 513390, XrefRangeStart = 513384, XrefRangeEnd = 513386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForce(Vector2 force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_AddForce_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000B9D4 File Offset: 0x00009BD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 513392, RefRangeEnd = 513396, XrefRangeStart = 513390, XrefRangeEnd = 513392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForce(Vector2 force, ForceMode2D mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_AddForce_Public_Void_Vector2_ForceMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000BA20 File Offset: 0x00009C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513396, XrefRangeEnd = 513400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTorque(float torque)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref torque;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_AddTorque_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000BA60 File Offset: 0x00009C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513400, XrefRangeEnd = 513404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTorque(float torque, ForceMode2D mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref torque;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_AddTorque_Public_Void_Single_ForceMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000BAAC File Offset: 0x00009CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rigidbody2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000BAE8 File Offset: 0x00009CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513404, XrefRangeEnd = 513408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_position_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000BB28 File Offset: 0x00009D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513408, XrefRangeEnd = 513412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_position_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000BB68 File Offset: 0x00009D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513412, XrefRangeEnd = 513416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePosition_Injected(ref Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000BBA8 File Offset: 0x00009DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513416, XrefRangeEnd = 513420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_velocity_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_get_velocity_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000BBE8 File Offset: 0x00009DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513420, XrefRangeEnd = 513424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_velocity_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_velocity_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000BC28 File Offset: 0x00009E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513424, XrefRangeEnd = 513428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_centerOfMass_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_set_centerOfMass_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000BC68 File Offset: 0x00009E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513428, XrefRangeEnd = 513432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForce_Injected(ref Vector2 force, ForceMode2D mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &force;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody2D.NativeMethodInfoPtr_AddForce_Injected_Private_Void_byref_Vector2_ForceMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public Rigidbody2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002AE1 File Offset: 0x00000CE1
		public void SetRotation(float angle)
		{
			this.SetRotation_Angle(angle);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002AEC File Offset: 0x00000CEC
		public void SetRotation_Angle(float angle)
		{
			Rigidbody2D.SetRotation_AngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), angle);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002AFF File Offset: 0x00000CFF
		public void SetRotation(Quaternion rotation)
		{
			this.SetRotation_Quaternion(rotation);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002B0A File Offset: 0x00000D0A
		public void SetRotation_Quaternion(Quaternion rotation)
		{
			this.SetRotation_Quaternion_Injected(ref rotation);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002B14 File Offset: 0x00000D14
		public void MoveRotation(Quaternion rotation)
		{
			this.MoveRotation_Quaternion(rotation);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002B1F File Offset: 0x00000D1F
		public void MoveRotation_Quaternion(Quaternion rotation)
		{
			this.MoveRotation_Quaternion_Injected(ref rotation);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00002B29 File Offset: 0x00000D29
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002B3B File Offset: 0x00000D3B
		public bool useAutoMass
		{
			get
			{
				return Rigidbody2D.get_useAutoMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_useAutoMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002B61 File Offset: 0x00000D61
		public PhysicsMaterial2D sharedMaterial
		{
			get
			{
				IntPtr intPtr = Rigidbody2D.get_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterial2D>(intPtr2) : null;
			}
			set
			{
				Rigidbody2D.set_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000BCF8 File Offset: 0x00009EF8
		public Vector2 worldCenterOfMass
		{
			get
			{
				Vector2 vector;
				this.get_worldCenterOfMass_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00002B79 File Offset: 0x00000D79
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00002B8B File Offset: 0x00000D8B
		public float inertia
		{
			get
			{
				return Rigidbody2D.get_inertiaDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_inertiaDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00002BC2 File Offset: 0x00000DC2
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00002BD4 File Offset: 0x00000DD4
		public float gravityScale
		{
			get
			{
				return Rigidbody2D.get_gravityScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_gravityScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002BE7 File Offset: 0x00000DE7
		public void SetDragBehaviour(bool dragged)
		{
			Rigidbody2D.SetDragBehaviourDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), dragged);
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00002BFA File Offset: 0x00000DFA
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00002C0C File Offset: 0x00000E0C
		public bool useFullKinematicContacts
		{
			get
			{
				return Rigidbody2D.get_useFullKinematicContactsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_useFullKinematicContactsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00002C1F File Offset: 0x00000E1F
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002C31 File Offset: 0x00000E31
		public bool fixedAngle
		{
			get
			{
				return Rigidbody2D.get_fixedAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_fixedAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00002C44 File Offset: 0x00000E44
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002C56 File Offset: 0x00000E56
		public bool freezeRotation
		{
			get
			{
				return Rigidbody2D.get_freezeRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_freezeRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00002C69 File Offset: 0x00000E69
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002C7B File Offset: 0x00000E7B
		public RigidbodyConstraints2D constraints
		{
			get
			{
				return Rigidbody2D.get_constraintsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_constraintsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002C8E File Offset: 0x00000E8E
		public bool IsSleeping()
		{
			return Rigidbody2D.IsSleepingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002CA0 File Offset: 0x00000EA0
		public bool IsAwake()
		{
			return Rigidbody2D.IsAwakeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002CB2 File Offset: 0x00000EB2
		public void Sleep()
		{
			Rigidbody2D.SleepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002CC4 File Offset: 0x00000EC4
		public void WakeUp()
		{
			Rigidbody2D.WakeUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002CFA File Offset: 0x00000EFA
		public RigidbodyInterpolation2D interpolation
		{
			get
			{
				return Rigidbody2D.get_interpolationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_interpolationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00002D0D File Offset: 0x00000F0D
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00002D1F File Offset: 0x00000F1F
		public RigidbodySleepMode2D sleepMode
		{
			get
			{
				return Rigidbody2D.get_sleepModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_sleepModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00002D32 File Offset: 0x00000F32
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002D44 File Offset: 0x00000F44
		public CollisionDetectionMode2D collisionDetectionMode
		{
			get
			{
				return Rigidbody2D.get_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00002D57 File Offset: 0x00000F57
		public int attachedColliderCount
		{
			get
			{
				return Rigidbody2D.get_attachedColliderCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002D69 File Offset: 0x00000F69
		public bool IsTouching(Collider2D collider)
		{
			return Rigidbody2D.IsTouchingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(collider));
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000BD10 File Offset: 0x00009F10
		public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.IsTouching_OtherColliderWithFilter_Internal(collider, contactFilter);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002D81 File Offset: 0x00000F81
		public bool IsTouching_OtherColliderWithFilter_Internal(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.IsTouching_OtherColliderWithFilter_Internal_Injected(collider, ref contactFilter);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000BD2C File Offset: 0x00009F2C
		public bool IsTouching(ContactFilter2D contactFilter)
		{
			return this.IsTouching_AnyColliderWithFilter_Internal(contactFilter);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002D8C File Offset: 0x00000F8C
		public bool IsTouching_AnyColliderWithFilter_Internal(ContactFilter2D contactFilter)
		{
			return this.IsTouching_AnyColliderWithFilter_Internal_Injected(ref contactFilter);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000BD48 File Offset: 0x00009F48
		public bool IsTouchingLayers()
		{
			return this.IsTouchingLayers(-1);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002D96 File Offset: 0x00000F96
		public bool IsTouchingLayers(int layerMask)
		{
			return Rigidbody2D.IsTouchingLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerMask);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002DA9 File Offset: 0x00000FA9
		public bool OverlapPoint(Vector2 point)
		{
			return this.OverlapPoint_Injected(ref point);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000BD64 File Offset: 0x00009F64
		public Vector2 ClosestPoint(Vector2 position)
		{
			return Physics2D.ClosestPoint(position, this);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002DB3 File Offset: 0x00000FB3
		public void AddRelativeForce(Vector2 relativeForce)
		{
			this.AddRelativeForce(relativeForce, ForceMode2D.Force);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002DBF File Offset: 0x00000FBF
		public void AddRelativeForce(Vector2 relativeForce, ForceMode2D mode)
		{
			this.AddRelativeForce_Injected(ref relativeForce, mode);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002DCA File Offset: 0x00000FCA
		public void AddForceAtPosition(Vector2 force, Vector2 position)
		{
			this.AddForceAtPosition(force, position, ForceMode2D.Force);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002DD7 File Offset: 0x00000FD7
		public void AddForceAtPosition(Vector2 force, Vector2 position, ForceMode2D mode)
		{
			this.AddForceAtPosition_Injected(ref force, ref position, mode);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000BD80 File Offset: 0x00009F80
		public Vector2 GetPoint(Vector2 point)
		{
			Vector2 vector;
			this.GetPoint_Injected(ref point, out vector);
			return vector;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000BD98 File Offset: 0x00009F98
		public Vector2 GetRelativePoint(Vector2 relativePoint)
		{
			Vector2 vector;
			this.GetRelativePoint_Injected(ref relativePoint, out vector);
			return vector;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000BDB0 File Offset: 0x00009FB0
		public Vector2 GetVector(Vector2 vector)
		{
			Vector2 vector2;
			this.GetVector_Injected(ref vector, out vector2);
			return vector2;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		public Vector2 GetRelativeVector(Vector2 relativeVector)
		{
			Vector2 vector;
			this.GetRelativeVector_Injected(ref relativeVector, out vector);
			return vector;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		public Vector2 GetPointVelocity(Vector2 point)
		{
			Vector2 vector;
			this.GetPointVelocity_Injected(ref point, out vector);
			return vector;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000BDF8 File Offset: 0x00009FF8
		public Vector2 GetRelativePointVelocity(Vector2 relativePoint)
		{
			Vector2 vector;
			this.GetRelativePointVelocity_Injected(ref relativePoint, out vector);
			return vector;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000BE10 File Offset: 0x0000A010
		public int OverlapCollider(ContactFilter2D contactFilter, [Out] Il2CppReferenceArray<Collider2D> results)
		{
			return this.OverlapColliderArray_Internal(contactFilter, results);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002DE4 File Offset: 0x00000FE4
		public int OverlapColliderArray_Internal(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return this.OverlapColliderArray_Internal_Injected(ref contactFilter, results);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000BE2C File Offset: 0x0000A02C
		public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return this.OverlapColliderList_Internal(contactFilter, results);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002DEF File Offset: 0x00000FEF
		public int OverlapColliderList_Internal(ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return this.OverlapColliderList_Internal_Injected(ref contactFilter, results);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000BE48 File Offset: 0x0000A048
		public int GetContacts(Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000BE70 File Offset: 0x0000A070
		public int GetContacts(List<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000BE98 File Offset: 0x0000A098
		public int GetContacts(ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000BED0 File Offset: 0x0000A0D0
		public int GetContacts(Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		public int GetContacts(List<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000BF20 File Offset: 0x0000A120
		public int GetContacts(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000BF3C File Offset: 0x0000A13C
		public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000BF58 File Offset: 0x0000A158
		public int GetAttachedColliders([Out] Il2CppReferenceArray<Collider2D> results)
		{
			return this.GetAttachedCollidersArray_Internal(results);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002DFA File Offset: 0x00000FFA
		public int GetAttachedCollidersArray_Internal(Il2CppReferenceArray<Collider2D> results)
		{
			return Rigidbody2D.GetAttachedCollidersArray_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000BF74 File Offset: 0x0000A174
		public int GetAttachedColliders(List<Collider2D> results)
		{
			return this.GetAttachedCollidersList_Internal(results);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002E12 File Offset: 0x00001012
		public int GetAttachedCollidersList_Internal(List<Collider2D> results)
		{
			return Rigidbody2D.GetAttachedCollidersList_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000BF90 File Offset: 0x0000A190
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastArray_Internal(direction, float.PositiveInfinity, results);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return this.CastArray_Internal(direction, distance, results);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002E2A File Offset: 0x0000102A
		public int CastArray_Internal(Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastArray_Internal_Injected(ref direction, distance, results);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		public int Cast(Vector2 direction, List<RaycastHit2D> results, [Optional] float distance)
		{
			return this.CastList_Internal(direction, distance, results);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002E36 File Offset: 0x00001036
		public int CastList_Internal(Vector2 direction, float distance, List<RaycastHit2D> results)
		{
			return this.CastList_Internal_Injected(ref direction, distance, results);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastFilteredArray_Internal(direction, float.PositiveInfinity, contactFilter, results);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000C008 File Offset: 0x0000A208
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return this.CastFilteredArray_Internal(direction, distance, contactFilter, results);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002E42 File Offset: 0x00001042
		public int CastFilteredArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastFilteredArray_Internal_Injected(ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000C028 File Offset: 0x0000A228
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance)
		{
			return this.CastFilteredList_Internal(direction, distance, contactFilter, results);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002E51 File Offset: 0x00001051
		public int CastFilteredList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return this.CastFilteredList_Internal_Injected(ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002E60 File Offset: 0x00001060
		public void SetRotation_Quaternion_Injected(ref Quaternion rotation)
		{
			Rigidbody2D.SetRotation_Quaternion_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rotation);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002E73 File Offset: 0x00001073
		public void MoveRotation_Quaternion_Injected(ref Quaternion rotation)
		{
			Rigidbody2D.MoveRotation_Quaternion_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rotation);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002E86 File Offset: 0x00001086
		public void get_centerOfMass_Injected(out Vector2 ret)
		{
			Rigidbody2D.get_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002E99 File Offset: 0x00001099
		public void get_worldCenterOfMass_Injected(out Vector2 ret)
		{
			Rigidbody2D.get_worldCenterOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002EAC File Offset: 0x000010AC
		public bool IsTouching_OtherColliderWithFilter_Internal_Injected(Collider2D collider, ref ContactFilter2D contactFilter)
		{
			return Rigidbody2D.IsTouching_OtherColliderWithFilter_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002EC5 File Offset: 0x000010C5
		public bool IsTouching_AnyColliderWithFilter_Internal_Injected(ref ContactFilter2D contactFilter)
		{
			return Rigidbody2D.IsTouching_AnyColliderWithFilter_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref contactFilter);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002ED8 File Offset: 0x000010D8
		public bool OverlapPoint_Injected(ref Vector2 point)
		{
			return Rigidbody2D.OverlapPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002EEB File Offset: 0x000010EB
		public void AddRelativeForce_Injected(ref Vector2 relativeForce, ForceMode2D mode)
		{
			Rigidbody2D.AddRelativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeForce, mode);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002EFF File Offset: 0x000010FF
		public void AddForceAtPosition_Injected(ref Vector2 force, ref Vector2 position, ForceMode2D mode)
		{
			Rigidbody2D.AddForceAtPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, ref position, mode);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002F14 File Offset: 0x00001114
		public void GetPoint_Injected(ref Vector2 point, out Vector2 ret)
		{
			Rigidbody2D.GetPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, out ret);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002F28 File Offset: 0x00001128
		public void GetRelativePoint_Injected(ref Vector2 relativePoint, out Vector2 ret)
		{
			Rigidbody2D.GetRelativePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativePoint, out ret);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002F3C File Offset: 0x0000113C
		public void GetVector_Injected(ref Vector2 vector, out Vector2 ret)
		{
			Rigidbody2D.GetVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref vector, out ret);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002F50 File Offset: 0x00001150
		public void GetRelativeVector_Injected(ref Vector2 relativeVector, out Vector2 ret)
		{
			Rigidbody2D.GetRelativeVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeVector, out ret);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002F64 File Offset: 0x00001164
		public void GetPointVelocity_Injected(ref Vector2 point, out Vector2 ret)
		{
			Rigidbody2D.GetPointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, out ret);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002F78 File Offset: 0x00001178
		public void GetRelativePointVelocity_Injected(ref Vector2 relativePoint, out Vector2 ret)
		{
			Rigidbody2D.GetRelativePointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativePoint, out ret);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002F8C File Offset: 0x0000118C
		public int OverlapColliderArray_Internal_Injected(ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Rigidbody2D.OverlapColliderArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002FA5 File Offset: 0x000011A5
		public int OverlapColliderList_Internal_Injected(ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Rigidbody2D.OverlapColliderList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002FBE File Offset: 0x000011BE
		public int CastArray_Internal_Injected(ref Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results)
		{
			return Rigidbody2D.CastArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002FD8 File Offset: 0x000011D8
		public int CastList_Internal_Injected(ref Vector2 direction, float distance, List<RaycastHit2D> results)
		{
			return Rigidbody2D.CastList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002FF2 File Offset: 0x000011F2
		public int CastFilteredArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Rigidbody2D.CastFilteredArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000300E File Offset: 0x0000120E
		public int CastFilteredList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return Rigidbody2D.CastFilteredList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Single_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_MovePosition_Public_Void_Vector2_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_MoveRotation_Public_Void_Single_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_MoveRotation_Angle_Private_Void_Single_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_get_angularVelocity_Public_get_Single_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Single_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_get_mass_Public_get_Single_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_set_centerOfMass_Public_set_Void_Vector2_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_set_drag_Public_set_Void_Single_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_set_angularDrag_Public_set_Void_Single_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_get_bodyType_Public_get_RigidbodyType2D_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_set_bodyType_Public_set_Void_RigidbodyType2D_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_get_isKinematic_Public_get_Boolean_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_set_isKinematic_Public_set_Void_Boolean_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_set_simulated_Public_set_Void_Boolean_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_AddForce_Public_Void_Vector2_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_AddForce_Public_Void_Vector2_ForceMode2D_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_AddTorque_Public_Void_Single_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_AddTorque_Public_Void_Single_ForceMode2D_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_get_velocity_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_set_centerOfMass_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_AddForce_Injected_Private_Void_byref_Vector2_ForceMode2D_0;

		// Token: 0x04000155 RID: 341
		private static readonly Rigidbody2D.set_rotationDelegate set_rotationDelegateField;

		// Token: 0x04000156 RID: 342
		private static readonly Rigidbody2D.SetRotation_AngleDelegate SetRotation_AngleDelegateField;

		// Token: 0x04000157 RID: 343
		private static readonly Rigidbody2D.get_useAutoMassDelegate get_useAutoMassDelegateField;

		// Token: 0x04000158 RID: 344
		private static readonly Rigidbody2D.set_useAutoMassDelegate set_useAutoMassDelegateField;

		// Token: 0x04000159 RID: 345
		private static readonly Rigidbody2D.set_massDelegate set_massDelegateField;

		// Token: 0x0400015A RID: 346
		private static readonly Rigidbody2D.get_sharedMaterialDelegate get_sharedMaterialDelegateField;

		// Token: 0x0400015B RID: 347
		private static readonly Rigidbody2D.set_sharedMaterialDelegate set_sharedMaterialDelegateField;

		// Token: 0x0400015C RID: 348
		private static readonly Rigidbody2D.get_inertiaDelegate get_inertiaDelegateField;

		// Token: 0x0400015D RID: 349
		private static readonly Rigidbody2D.set_inertiaDelegate set_inertiaDelegateField;

		// Token: 0x0400015E RID: 350
		private static readonly Rigidbody2D.get_dragDelegate get_dragDelegateField;

		// Token: 0x0400015F RID: 351
		private static readonly Rigidbody2D.get_angularDragDelegate get_angularDragDelegateField;

		// Token: 0x04000160 RID: 352
		private static readonly Rigidbody2D.get_gravityScaleDelegate get_gravityScaleDelegateField;

		// Token: 0x04000161 RID: 353
		private static readonly Rigidbody2D.set_gravityScaleDelegate set_gravityScaleDelegateField;

		// Token: 0x04000162 RID: 354
		private static readonly Rigidbody2D.SetDragBehaviourDelegate SetDragBehaviourDelegateField;

		// Token: 0x04000163 RID: 355
		private static readonly Rigidbody2D.get_useFullKinematicContactsDelegate get_useFullKinematicContactsDelegateField;

		// Token: 0x04000164 RID: 356
		private static readonly Rigidbody2D.set_useFullKinematicContactsDelegate set_useFullKinematicContactsDelegateField;

		// Token: 0x04000165 RID: 357
		private static readonly Rigidbody2D.get_fixedAngleDelegate get_fixedAngleDelegateField;

		// Token: 0x04000166 RID: 358
		private static readonly Rigidbody2D.set_fixedAngleDelegate set_fixedAngleDelegateField;

		// Token: 0x04000167 RID: 359
		private static readonly Rigidbody2D.get_freezeRotationDelegate get_freezeRotationDelegateField;

		// Token: 0x04000168 RID: 360
		private static readonly Rigidbody2D.set_freezeRotationDelegate set_freezeRotationDelegateField;

		// Token: 0x04000169 RID: 361
		private static readonly Rigidbody2D.get_constraintsDelegate get_constraintsDelegateField;

		// Token: 0x0400016A RID: 362
		private static readonly Rigidbody2D.set_constraintsDelegate set_constraintsDelegateField;

		// Token: 0x0400016B RID: 363
		private static readonly Rigidbody2D.IsSleepingDelegate IsSleepingDelegateField;

		// Token: 0x0400016C RID: 364
		private static readonly Rigidbody2D.IsAwakeDelegate IsAwakeDelegateField;

		// Token: 0x0400016D RID: 365
		private static readonly Rigidbody2D.SleepDelegate SleepDelegateField;

		// Token: 0x0400016E RID: 366
		private static readonly Rigidbody2D.WakeUpDelegate WakeUpDelegateField;

		// Token: 0x0400016F RID: 367
		private static readonly Rigidbody2D.get_simulatedDelegate get_simulatedDelegateField;

		// Token: 0x04000170 RID: 368
		private static readonly Rigidbody2D.get_interpolationDelegate get_interpolationDelegateField;

		// Token: 0x04000171 RID: 369
		private static readonly Rigidbody2D.set_interpolationDelegate set_interpolationDelegateField;

		// Token: 0x04000172 RID: 370
		private static readonly Rigidbody2D.get_sleepModeDelegate get_sleepModeDelegateField;

		// Token: 0x04000173 RID: 371
		private static readonly Rigidbody2D.set_sleepModeDelegate set_sleepModeDelegateField;

		// Token: 0x04000174 RID: 372
		private static readonly Rigidbody2D.get_collisionDetectionModeDelegate get_collisionDetectionModeDelegateField;

		// Token: 0x04000175 RID: 373
		private static readonly Rigidbody2D.set_collisionDetectionModeDelegate set_collisionDetectionModeDelegateField;

		// Token: 0x04000176 RID: 374
		private static readonly Rigidbody2D.get_attachedColliderCountDelegate get_attachedColliderCountDelegateField;

		// Token: 0x04000177 RID: 375
		private static readonly Rigidbody2D.IsTouchingDelegate IsTouchingDelegateField;

		// Token: 0x04000178 RID: 376
		private static readonly Rigidbody2D.IsTouchingLayersDelegate IsTouchingLayersDelegateField;

		// Token: 0x04000179 RID: 377
		private static readonly Rigidbody2D.GetAttachedCollidersArray_InternalDelegate GetAttachedCollidersArray_InternalDelegateField;

		// Token: 0x0400017A RID: 378
		private static readonly Rigidbody2D.GetAttachedCollidersList_InternalDelegate GetAttachedCollidersList_InternalDelegateField;

		// Token: 0x0400017B RID: 379
		private static readonly Rigidbody2D.SetRotation_Quaternion_InjectedDelegate SetRotation_Quaternion_InjectedDelegateField;

		// Token: 0x0400017C RID: 380
		private static readonly Rigidbody2D.MoveRotation_Quaternion_InjectedDelegate MoveRotation_Quaternion_InjectedDelegateField;

		// Token: 0x0400017D RID: 381
		private static readonly Rigidbody2D.get_centerOfMass_InjectedDelegate get_centerOfMass_InjectedDelegateField;

		// Token: 0x0400017E RID: 382
		private static readonly Rigidbody2D.get_worldCenterOfMass_InjectedDelegate get_worldCenterOfMass_InjectedDelegateField;

		// Token: 0x0400017F RID: 383
		private static readonly Rigidbody2D.IsTouching_OtherColliderWithFilter_Internal_InjectedDelegate IsTouching_OtherColliderWithFilter_Internal_InjectedDelegateField;

		// Token: 0x04000180 RID: 384
		private static readonly Rigidbody2D.IsTouching_AnyColliderWithFilter_Internal_InjectedDelegate IsTouching_AnyColliderWithFilter_Internal_InjectedDelegateField;

		// Token: 0x04000181 RID: 385
		private static readonly Rigidbody2D.OverlapPoint_InjectedDelegate OverlapPoint_InjectedDelegateField;

		// Token: 0x04000182 RID: 386
		private static readonly Rigidbody2D.AddRelativeForce_InjectedDelegate AddRelativeForce_InjectedDelegateField;

		// Token: 0x04000183 RID: 387
		private static readonly Rigidbody2D.AddForceAtPosition_InjectedDelegate AddForceAtPosition_InjectedDelegateField;

		// Token: 0x04000184 RID: 388
		private static readonly Rigidbody2D.GetPoint_InjectedDelegate GetPoint_InjectedDelegateField;

		// Token: 0x04000185 RID: 389
		private static readonly Rigidbody2D.GetRelativePoint_InjectedDelegate GetRelativePoint_InjectedDelegateField;

		// Token: 0x04000186 RID: 390
		private static readonly Rigidbody2D.GetVector_InjectedDelegate GetVector_InjectedDelegateField;

		// Token: 0x04000187 RID: 391
		private static readonly Rigidbody2D.GetRelativeVector_InjectedDelegate GetRelativeVector_InjectedDelegateField;

		// Token: 0x04000188 RID: 392
		private static readonly Rigidbody2D.GetPointVelocity_InjectedDelegate GetPointVelocity_InjectedDelegateField;

		// Token: 0x04000189 RID: 393
		private static readonly Rigidbody2D.GetRelativePointVelocity_InjectedDelegate GetRelativePointVelocity_InjectedDelegateField;

		// Token: 0x0400018A RID: 394
		private static readonly Rigidbody2D.OverlapColliderArray_Internal_InjectedDelegate OverlapColliderArray_Internal_InjectedDelegateField;

		// Token: 0x0400018B RID: 395
		private static readonly Rigidbody2D.OverlapColliderList_Internal_InjectedDelegate OverlapColliderList_Internal_InjectedDelegateField;

		// Token: 0x0400018C RID: 396
		private static readonly Rigidbody2D.CastArray_Internal_InjectedDelegate CastArray_Internal_InjectedDelegateField;

		// Token: 0x0400018D RID: 397
		private static readonly Rigidbody2D.CastList_Internal_InjectedDelegate CastList_Internal_InjectedDelegateField;

		// Token: 0x0400018E RID: 398
		private static readonly Rigidbody2D.CastFilteredArray_Internal_InjectedDelegate CastFilteredArray_Internal_InjectedDelegateField;

		// Token: 0x0400018F RID: 399
		private static readonly Rigidbody2D.CastFilteredList_Internal_InjectedDelegate CastFilteredList_Internal_InjectedDelegateField;

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000518 RID: 1304
		private delegate void set_rotationDelegate(IntPtr @this, float value);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x0600051A RID: 1306
		private delegate void SetRotation_AngleDelegate(IntPtr @this, float angle);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x0600051C RID: 1308
		private delegate bool get_useAutoMassDelegate(IntPtr @this);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x0600051E RID: 1310
		private delegate void set_useAutoMassDelegate(IntPtr @this, bool value);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x06000520 RID: 1312
		private delegate void set_massDelegate(IntPtr @this, float value);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000522 RID: 1314
		private delegate IntPtr get_sharedMaterialDelegate(IntPtr @this);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000524 RID: 1316
		private delegate void set_sharedMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000526 RID: 1318
		private delegate float get_inertiaDelegate(IntPtr @this);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x06000528 RID: 1320
		private delegate void set_inertiaDelegate(IntPtr @this, float value);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x0600052A RID: 1322
		private delegate float get_dragDelegate(IntPtr @this);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x0600052C RID: 1324
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x0600052E RID: 1326
		private delegate float get_gravityScaleDelegate(IntPtr @this);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x06000530 RID: 1328
		private delegate void set_gravityScaleDelegate(IntPtr @this, float value);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x06000532 RID: 1330
		private delegate void SetDragBehaviourDelegate(IntPtr @this, bool dragged);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x06000534 RID: 1332
		private delegate bool get_useFullKinematicContactsDelegate(IntPtr @this);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000536 RID: 1334
		private delegate void set_useFullKinematicContactsDelegate(IntPtr @this, bool value);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x06000538 RID: 1336
		private delegate bool get_fixedAngleDelegate(IntPtr @this);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x0600053A RID: 1338
		private delegate void set_fixedAngleDelegate(IntPtr @this, bool value);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x0600053C RID: 1340
		private delegate bool get_freezeRotationDelegate(IntPtr @this);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x0600053E RID: 1342
		private delegate void set_freezeRotationDelegate(IntPtr @this, bool value);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x06000540 RID: 1344
		private delegate RigidbodyConstraints2D get_constraintsDelegate(IntPtr @this);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x06000542 RID: 1346
		private delegate void set_constraintsDelegate(IntPtr @this, RigidbodyConstraints2D value);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x06000544 RID: 1348
		private delegate bool IsSleepingDelegate(IntPtr @this);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x06000546 RID: 1350
		private delegate bool IsAwakeDelegate(IntPtr @this);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x06000548 RID: 1352
		private delegate void SleepDelegate(IntPtr @this);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x0600054A RID: 1354
		private delegate void WakeUpDelegate(IntPtr @this);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x0600054C RID: 1356
		private delegate bool get_simulatedDelegate(IntPtr @this);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x0600054E RID: 1358
		private delegate RigidbodyInterpolation2D get_interpolationDelegate(IntPtr @this);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x06000550 RID: 1360
		private delegate void set_interpolationDelegate(IntPtr @this, RigidbodyInterpolation2D value);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x06000552 RID: 1362
		private delegate RigidbodySleepMode2D get_sleepModeDelegate(IntPtr @this);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x06000554 RID: 1364
		private delegate void set_sleepModeDelegate(IntPtr @this, RigidbodySleepMode2D value);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x06000556 RID: 1366
		private delegate CollisionDetectionMode2D get_collisionDetectionModeDelegate(IntPtr @this);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x06000558 RID: 1368
		private delegate void set_collisionDetectionModeDelegate(IntPtr @this, CollisionDetectionMode2D value);

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x0600055A RID: 1370
		private delegate int get_attachedColliderCountDelegate(IntPtr @this);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x0600055C RID: 1372
		private delegate bool IsTouchingDelegate(IntPtr @this, IntPtr collider);

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x0600055E RID: 1374
		private delegate bool IsTouchingLayersDelegate(IntPtr @this, int layerMask);

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x06000560 RID: 1376
		private delegate int GetAttachedCollidersArray_InternalDelegate(IntPtr @this, IntPtr results);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x06000562 RID: 1378
		private delegate int GetAttachedCollidersList_InternalDelegate(IntPtr @this, IntPtr results);

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x06000564 RID: 1380
		private delegate void SetRotation_Quaternion_InjectedDelegate(IntPtr @this, IntPtr rotation);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x06000566 RID: 1382
		private delegate void MoveRotation_Quaternion_InjectedDelegate(IntPtr @this, IntPtr rotation);

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x06000568 RID: 1384
		private delegate void get_centerOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x0600056A RID: 1386
		private delegate void get_worldCenterOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x0600056C RID: 1388
		private delegate bool IsTouching_OtherColliderWithFilter_Internal_InjectedDelegate(IntPtr @this, IntPtr collider, IntPtr contactFilter);

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x0600056E RID: 1390
		private delegate bool IsTouching_AnyColliderWithFilter_Internal_InjectedDelegate(IntPtr @this, IntPtr contactFilter);

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x06000570 RID: 1392
		private delegate bool OverlapPoint_InjectedDelegate(IntPtr @this, IntPtr point);

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x06000572 RID: 1394
		private delegate void AddRelativeForce_InjectedDelegate(IntPtr @this, IntPtr relativeForce, ForceMode2D mode);

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x06000574 RID: 1396
		private delegate void AddForceAtPosition_InjectedDelegate(IntPtr @this, IntPtr force, IntPtr position, ForceMode2D mode);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x06000576 RID: 1398
		private delegate void GetPoint_InjectedDelegate(IntPtr @this, IntPtr point, [Out] IntPtr ret);

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x06000578 RID: 1400
		private delegate void GetRelativePoint_InjectedDelegate(IntPtr @this, IntPtr relativePoint, [Out] IntPtr ret);

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x0600057A RID: 1402
		private delegate void GetVector_InjectedDelegate(IntPtr @this, IntPtr vector, [Out] IntPtr ret);

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x0600057C RID: 1404
		private delegate void GetRelativeVector_InjectedDelegate(IntPtr @this, IntPtr relativeVector, [Out] IntPtr ret);

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x0600057E RID: 1406
		private delegate void GetPointVelocity_InjectedDelegate(IntPtr @this, IntPtr point, [Out] IntPtr ret);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x06000580 RID: 1408
		private delegate void GetRelativePointVelocity_InjectedDelegate(IntPtr @this, IntPtr relativePoint, [Out] IntPtr ret);

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x06000582 RID: 1410
		private delegate int OverlapColliderArray_Internal_InjectedDelegate(IntPtr @this, IntPtr contactFilter, IntPtr results);

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x06000584 RID: 1412
		private delegate int OverlapColliderList_Internal_InjectedDelegate(IntPtr @this, IntPtr contactFilter, IntPtr results);

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x06000586 RID: 1414
		private delegate int CastArray_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr results);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x06000588 RID: 1416
		private delegate int CastList_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr results);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x0600058A RID: 1418
		private delegate int CastFilteredArray_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x0600058C RID: 1420
		private delegate int CastFilteredList_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);
	}
}
