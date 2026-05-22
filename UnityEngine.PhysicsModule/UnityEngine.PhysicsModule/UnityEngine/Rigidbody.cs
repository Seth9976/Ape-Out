using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public class Rigidbody : Component
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00004F88 File Offset: 0x00003188
		// Note: this type is marked as 'beforefieldinit'.
		static Rigidbody()
		{
			Il2CppClassPointerStore<Rigidbody>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Rigidbody");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr);
			Rigidbody.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663310);
			Rigidbody.NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663311);
			Rigidbody.NativeMethodInfoPtr_set_useGravity_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663312);
			Rigidbody.NativeMethodInfoPtr_get_isKinematic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663313);
			Rigidbody.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663314);
			Rigidbody.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663315);
			Rigidbody.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663316);
			Rigidbody.NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663317);
			Rigidbody.NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663318);
			Rigidbody.NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663319);
			Rigidbody.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663320);
			Rigidbody.NativeMethodInfoPtr_set_velocity_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663321);
			Rigidbody.NativeMethodInfoPtr_set_angularVelocity_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663322);
			Rigidbody.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663323);
			Rigidbody.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663324);
			Rigidbody.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663325);
			Rigidbody.NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663326);
			Rigidbody.NativeMethodInfoPtr_MoveRotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663327);
			Rigidbody.NativeMethodInfoPtr_AddForce_Injected_Private_Void_byref_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663328);
			Rigidbody.get_dragDelegateField = IL2CPP.ResolveICall<Rigidbody.get_dragDelegate>("UnityEngine.Rigidbody::get_drag");
			Rigidbody.set_dragDelegateField = IL2CPP.ResolveICall<Rigidbody.set_dragDelegate>("UnityEngine.Rigidbody::set_drag");
			Rigidbody.get_angularDragDelegateField = IL2CPP.ResolveICall<Rigidbody.get_angularDragDelegate>("UnityEngine.Rigidbody::get_angularDrag");
			Rigidbody.set_angularDragDelegateField = IL2CPP.ResolveICall<Rigidbody.set_angularDragDelegate>("UnityEngine.Rigidbody::set_angularDrag");
			Rigidbody.get_massDelegateField = IL2CPP.ResolveICall<Rigidbody.get_massDelegate>("UnityEngine.Rigidbody::get_mass");
			Rigidbody.set_massDelegateField = IL2CPP.ResolveICall<Rigidbody.set_massDelegate>("UnityEngine.Rigidbody::set_mass");
			Rigidbody.SetDensityDelegateField = IL2CPP.ResolveICall<Rigidbody.SetDensityDelegate>("UnityEngine.Rigidbody::SetDensity");
			Rigidbody.get_useGravityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_useGravityDelegate>("UnityEngine.Rigidbody::get_useGravity");
			Rigidbody.get_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_maxDepenetrationVelocityDelegate>("UnityEngine.Rigidbody::get_maxDepenetrationVelocity");
			Rigidbody.set_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.set_maxDepenetrationVelocityDelegate>("UnityEngine.Rigidbody::set_maxDepenetrationVelocity");
			Rigidbody.set_isKinematicDelegateField = IL2CPP.ResolveICall<Rigidbody.set_isKinematicDelegate>("UnityEngine.Rigidbody::set_isKinematic");
			Rigidbody.get_freezeRotationDelegateField = IL2CPP.ResolveICall<Rigidbody.get_freezeRotationDelegate>("UnityEngine.Rigidbody::get_freezeRotation");
			Rigidbody.set_freezeRotationDelegateField = IL2CPP.ResolveICall<Rigidbody.set_freezeRotationDelegate>("UnityEngine.Rigidbody::set_freezeRotation");
			Rigidbody.get_constraintsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_constraintsDelegate>("UnityEngine.Rigidbody::get_constraints");
			Rigidbody.set_constraintsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_constraintsDelegate>("UnityEngine.Rigidbody::set_constraints");
			Rigidbody.get_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<Rigidbody.get_collisionDetectionModeDelegate>("UnityEngine.Rigidbody::get_collisionDetectionMode");
			Rigidbody.set_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<Rigidbody.set_collisionDetectionModeDelegate>("UnityEngine.Rigidbody::set_collisionDetectionMode");
			Rigidbody.get_detectCollisionsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_detectCollisionsDelegate>("UnityEngine.Rigidbody::get_detectCollisions");
			Rigidbody.set_detectCollisionsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_detectCollisionsDelegate>("UnityEngine.Rigidbody::set_detectCollisions");
			Rigidbody.get_interpolationDelegateField = IL2CPP.ResolveICall<Rigidbody.get_interpolationDelegate>("UnityEngine.Rigidbody::get_interpolation");
			Rigidbody.set_interpolationDelegateField = IL2CPP.ResolveICall<Rigidbody.set_interpolationDelegate>("UnityEngine.Rigidbody::set_interpolation");
			Rigidbody.get_solverIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_solverIterationsDelegate>("UnityEngine.Rigidbody::get_solverIterations");
			Rigidbody.set_solverIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_solverIterationsDelegate>("UnityEngine.Rigidbody::set_solverIterations");
			Rigidbody.get_sleepThresholdDelegateField = IL2CPP.ResolveICall<Rigidbody.get_sleepThresholdDelegate>("UnityEngine.Rigidbody::get_sleepThreshold");
			Rigidbody.set_sleepThresholdDelegateField = IL2CPP.ResolveICall<Rigidbody.set_sleepThresholdDelegate>("UnityEngine.Rigidbody::set_sleepThreshold");
			Rigidbody.get_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_maxAngularVelocityDelegate>("UnityEngine.Rigidbody::get_maxAngularVelocity");
			Rigidbody.set_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.set_maxAngularVelocityDelegate>("UnityEngine.Rigidbody::set_maxAngularVelocity");
			Rigidbody.SleepDelegateField = IL2CPP.ResolveICall<Rigidbody.SleepDelegate>("UnityEngine.Rigidbody::Sleep");
			Rigidbody.IsSleepingDelegateField = IL2CPP.ResolveICall<Rigidbody.IsSleepingDelegate>("UnityEngine.Rigidbody::IsSleeping");
			Rigidbody.WakeUpDelegateField = IL2CPP.ResolveICall<Rigidbody.WakeUpDelegate>("UnityEngine.Rigidbody::WakeUp");
			Rigidbody.ResetCenterOfMassDelegateField = IL2CPP.ResolveICall<Rigidbody.ResetCenterOfMassDelegate>("UnityEngine.Rigidbody::ResetCenterOfMass");
			Rigidbody.ResetInertiaTensorDelegateField = IL2CPP.ResolveICall<Rigidbody.ResetInertiaTensorDelegate>("UnityEngine.Rigidbody::ResetInertiaTensor");
			Rigidbody.get_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_solverVelocityIterationsDelegate>("UnityEngine.Rigidbody::get_solverVelocityIterations");
			Rigidbody.set_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_solverVelocityIterationsDelegate>("UnityEngine.Rigidbody::set_solverVelocityIterations");
			Rigidbody.get_sleepVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_sleepVelocityDelegate>("UnityEngine.Rigidbody::get_sleepVelocity");
			Rigidbody.set_sleepVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.set_sleepVelocityDelegate>("UnityEngine.Rigidbody::set_sleepVelocity");
			Rigidbody.get_sleepAngularVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_sleepAngularVelocityDelegate>("UnityEngine.Rigidbody::get_sleepAngularVelocity");
			Rigidbody.set_sleepAngularVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.set_sleepAngularVelocityDelegate>("UnityEngine.Rigidbody::set_sleepAngularVelocity");
			Rigidbody.get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_velocity_InjectedDelegate>("UnityEngine.Rigidbody::get_velocity_Injected");
			Rigidbody.get_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_angularVelocity_InjectedDelegate>("UnityEngine.Rigidbody::get_angularVelocity_Injected");
			Rigidbody.get_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody::get_centerOfMass_Injected");
			Rigidbody.set_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody::set_centerOfMass_Injected");
			Rigidbody.get_worldCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_worldCenterOfMass_InjectedDelegate>("UnityEngine.Rigidbody::get_worldCenterOfMass_Injected");
			Rigidbody.get_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_inertiaTensorRotation_InjectedDelegate>("UnityEngine.Rigidbody::get_inertiaTensorRotation_Injected");
			Rigidbody.set_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_inertiaTensorRotation_InjectedDelegate>("UnityEngine.Rigidbody::set_inertiaTensorRotation_Injected");
			Rigidbody.get_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_inertiaTensor_InjectedDelegate>("UnityEngine.Rigidbody::get_inertiaTensor_Injected");
			Rigidbody.set_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_inertiaTensor_InjectedDelegate>("UnityEngine.Rigidbody::set_inertiaTensor_Injected");
			Rigidbody.set_position_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_position_InjectedDelegate>("UnityEngine.Rigidbody::set_position_Injected");
			Rigidbody.GetRelativePointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.GetRelativePointVelocity_InjectedDelegate>("UnityEngine.Rigidbody::GetRelativePointVelocity_Injected");
			Rigidbody.GetPointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.GetPointVelocity_InjectedDelegate>("UnityEngine.Rigidbody::GetPointVelocity_Injected");
			Rigidbody.AddRelativeForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddRelativeForce_InjectedDelegate>("UnityEngine.Rigidbody::AddRelativeForce_Injected");
			Rigidbody.AddTorque_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddTorque_InjectedDelegate>("UnityEngine.Rigidbody::AddTorque_Injected");
			Rigidbody.AddRelativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddRelativeTorque_InjectedDelegate>("UnityEngine.Rigidbody::AddRelativeTorque_Injected");
			Rigidbody.AddForceAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddForceAtPosition_InjectedDelegate>("UnityEngine.Rigidbody::AddForceAtPosition_Injected");
			Rigidbody.AddExplosionForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddExplosionForce_InjectedDelegate>("UnityEngine.Rigidbody::AddExplosionForce_Injected");
			Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegate>("UnityEngine.Rigidbody::Internal_ClosestPointOnBounds_Injected");
			Rigidbody.SweepTest_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.SweepTest_InjectedDelegate>("UnityEngine.Rigidbody::SweepTest_Injected");
			Rigidbody.Internal_SweepTestAll_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.Internal_SweepTestAll_InjectedDelegate>("UnityEngine.Rigidbody::Internal_SweepTestAll_Injected");
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00005964 File Offset: 0x00003B64
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000549C File Offset: 0x0000369C
		public unsafe Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513536, XrefRangeEnd = 513538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000597C File Offset: 0x00003B7C
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000054DC File Offset: 0x000036DC
		public unsafe Vector3 angularVelocity
		{
			get
			{
				Vector3 vector;
				this.get_angularVelocity_Injected(out vector);
				return vector;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513538, XrefRangeEnd = 513540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000023C0 File Offset: 0x000005C0
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000551C File Offset: 0x0000371C
		public unsafe bool useGravity
		{
			get
			{
				return Rigidbody.get_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513540, XrefRangeEnd = 513544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_set_useGravity_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000555C File Offset: 0x0000375C
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000023F7 File Offset: 0x000005F7
		public unsafe bool isKinematic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513544, XrefRangeEnd = 513548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_get_isKinematic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Rigidbody.set_isKinematicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00005598 File Offset: 0x00003798
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000024BC File Offset: 0x000006BC
		public unsafe Vector3 position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513548, XrefRangeEnd = 513550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_position_Injected(ref value);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000055D4 File Offset: 0x000037D4
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00005610 File Offset: 0x00003810
		public unsafe Quaternion rotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513550, XrefRangeEnd = 513552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513552, XrefRangeEnd = 513554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005650 File Offset: 0x00003850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513554, XrefRangeEnd = 513556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00005690 File Offset: 0x00003890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513556, XrefRangeEnd = 513558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRotation(Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000056D0 File Offset: 0x000038D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513558, XrefRangeEnd = 513560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForce(Vector3 force, ForceMode mode)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000571C File Offset: 0x0000391C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rigidbody()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005758 File Offset: 0x00003958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513560, XrefRangeEnd = 513564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_velocity_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_set_velocity_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005798 File Offset: 0x00003998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513564, XrefRangeEnd = 513568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_angularVelocity_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_set_angularVelocity_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000057D8 File Offset: 0x000039D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513568, XrefRangeEnd = 513572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_position_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005818 File Offset: 0x00003A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513572, XrefRangeEnd = 513576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rotation_Injected(out Quaternion ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00005858 File Offset: 0x00003A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513576, XrefRangeEnd = 513580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_rotation_Injected(ref Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00005898 File Offset: 0x00003A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513580, XrefRangeEnd = 513584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePosition_Injected(ref Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000058D8 File Offset: 0x00003AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513584, XrefRangeEnd = 513588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRotation_Injected(ref Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MoveRotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005918 File Offset: 0x00003B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513588, XrefRangeEnd = 513592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForce_Injected(ref Vector3 force, ForceMode mode)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_AddForce_Injected_Private_Void_byref_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002335 File Offset: 0x00000535
		public Rigidbody(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000233E File Offset: 0x0000053E
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002350 File Offset: 0x00000550
		public float drag
		{
			get
			{
				return Rigidbody.get_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002363 File Offset: 0x00000563
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002375 File Offset: 0x00000575
		public float angularDrag
		{
			get
			{
				return Rigidbody.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002388 File Offset: 0x00000588
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000239A File Offset: 0x0000059A
		public float mass
		{
			get
			{
				return Rigidbody.get_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000023AD File Offset: 0x000005AD
		public void SetDensity(float density)
		{
			Rigidbody.SetDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), density);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000023D2 File Offset: 0x000005D2
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000023E4 File Offset: 0x000005E4
		public float maxDepenetrationVelocity
		{
			get
			{
				return Rigidbody.get_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000240A File Offset: 0x0000060A
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000241C File Offset: 0x0000061C
		public bool freezeRotation
		{
			get
			{
				return Rigidbody.get_freezeRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_freezeRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000242F File Offset: 0x0000062F
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002441 File Offset: 0x00000641
		public RigidbodyConstraints constraints
		{
			get
			{
				return Rigidbody.get_constraintsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_constraintsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002454 File Offset: 0x00000654
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002466 File Offset: 0x00000666
		public CollisionDetectionMode collisionDetectionMode
		{
			get
			{
				return Rigidbody.get_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00005994 File Offset: 0x00003B94
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002479 File Offset: 0x00000679
		public Vector3 centerOfMass
		{
			get
			{
				Vector3 vector;
				this.get_centerOfMass_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_centerOfMass_Injected(ref value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000059AC File Offset: 0x00003BAC
		public Vector3 worldCenterOfMass
		{
			get
			{
				Vector3 vector;
				this.get_worldCenterOfMass_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000059C4 File Offset: 0x00003BC4
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002483 File Offset: 0x00000683
		public Quaternion inertiaTensorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_inertiaTensorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_inertiaTensorRotation_Injected(ref value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000059DC File Offset: 0x00003BDC
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000248D File Offset: 0x0000068D
		public Vector3 inertiaTensor
		{
			get
			{
				Vector3 vector;
				this.get_inertiaTensor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_inertiaTensor_Injected(ref value);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002497 File Offset: 0x00000697
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000024A9 File Offset: 0x000006A9
		public bool detectCollisions
		{
			get
			{
				return Rigidbody.get_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000024C6 File Offset: 0x000006C6
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000024D8 File Offset: 0x000006D8
		public RigidbodyInterpolation interpolation
		{
			get
			{
				return Rigidbody.get_interpolationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_interpolationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000024EB File Offset: 0x000006EB
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000024FD File Offset: 0x000006FD
		public int solverIterations
		{
			get
			{
				return Rigidbody.get_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002510 File Offset: 0x00000710
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002522 File Offset: 0x00000722
		public float sleepThreshold
		{
			get
			{
				return Rigidbody.get_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002535 File Offset: 0x00000735
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002547 File Offset: 0x00000747
		public float maxAngularVelocity
		{
			get
			{
				return Rigidbody.get_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000255A File Offset: 0x0000075A
		public void Sleep()
		{
			Rigidbody.SleepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000256C File Offset: 0x0000076C
		public bool IsSleeping()
		{
			return Rigidbody.IsSleepingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000257E File Offset: 0x0000077E
		public void WakeUp()
		{
			Rigidbody.WakeUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002590 File Offset: 0x00000790
		public void ResetCenterOfMass()
		{
			Rigidbody.ResetCenterOfMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000025A2 File Offset: 0x000007A2
		public void ResetInertiaTensor()
		{
			Rigidbody.ResetInertiaTensorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000059F4 File Offset: 0x00003BF4
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint)
		{
			Vector3 vector;
			this.GetRelativePointVelocity_Injected(ref relativePoint, out vector);
			return vector;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005A0C File Offset: 0x00003C0C
		public Vector3 GetPointVelocity(Vector3 worldPoint)
		{
			Vector3 vector;
			this.GetPointVelocity_Injected(ref worldPoint, out vector);
			return vector;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000025B4 File Offset: 0x000007B4
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000025C6 File Offset: 0x000007C6
		public int solverVelocityIterations
		{
			get
			{
				return Rigidbody.get_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000025D9 File Offset: 0x000007D9
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000025EB File Offset: 0x000007EB
		public float sleepVelocity
		{
			get
			{
				return Rigidbody.get_sleepVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_sleepVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000025FE File Offset: 0x000007FE
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002610 File Offset: 0x00000810
		public float sleepAngularVelocity
		{
			get
			{
				return Rigidbody.get_sleepAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_sleepAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002623 File Offset: 0x00000823
		public void SetMaxAngularVelocity(float a)
		{
			this.maxAngularVelocity = a;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00005A24 File Offset: 0x00003C24
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000262E File Offset: 0x0000082E
		public bool useConeFriction
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00005A38 File Offset: 0x00003C38
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002631 File Offset: 0x00000831
		public int solverIterationCount
		{
			get
			{
				return this.solverIterations;
			}
			set
			{
				this.solverIterations = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005A50 File Offset: 0x00003C50
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000263C File Offset: 0x0000083C
		public int solverVelocityIterationCount
		{
			get
			{
				return this.solverVelocityIterations;
			}
			set
			{
				this.solverVelocityIterations = value;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002647 File Offset: 0x00000847
		public void AddForce(Vector3 force)
		{
			this.AddForce(force, ForceMode.Force);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002653 File Offset: 0x00000853
		public void AddForce(float x, float y, float z, ForceMode mode)
		{
			this.AddForce(new Vector3(x, y, z), mode);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002667 File Offset: 0x00000867
		public void AddForce(float x, float y, float z)
		{
			this.AddForce(new Vector3(x, y, z), ForceMode.Force);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000267A File Offset: 0x0000087A
		public void AddRelativeForce(Vector3 force, ForceMode mode)
		{
			this.AddRelativeForce_Injected(ref force, mode);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002685 File Offset: 0x00000885
		public void AddRelativeForce(Vector3 force)
		{
			this.AddRelativeForce(force, ForceMode.Force);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002691 File Offset: 0x00000891
		public void AddRelativeForce(float x, float y, float z, ForceMode mode)
		{
			this.AddRelativeForce(new Vector3(x, y, z), mode);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000026A5 File Offset: 0x000008A5
		public void AddRelativeForce(float x, float y, float z)
		{
			this.AddRelativeForce(new Vector3(x, y, z), ForceMode.Force);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000026B8 File Offset: 0x000008B8
		public void AddTorque(Vector3 torque, ForceMode mode)
		{
			this.AddTorque_Injected(ref torque, mode);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000026C3 File Offset: 0x000008C3
		public void AddTorque(Vector3 torque)
		{
			this.AddTorque(torque, ForceMode.Force);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000026CF File Offset: 0x000008CF
		public void AddTorque(float x, float y, float z, ForceMode mode)
		{
			this.AddTorque(new Vector3(x, y, z), mode);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000026E3 File Offset: 0x000008E3
		public void AddTorque(float x, float y, float z)
		{
			this.AddTorque(new Vector3(x, y, z), ForceMode.Force);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000026F6 File Offset: 0x000008F6
		public void AddRelativeTorque(Vector3 torque, ForceMode mode)
		{
			this.AddRelativeTorque_Injected(ref torque, mode);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002701 File Offset: 0x00000901
		public void AddRelativeTorque(Vector3 torque)
		{
			this.AddRelativeTorque(torque, ForceMode.Force);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000270D File Offset: 0x0000090D
		public void AddRelativeTorque(float x, float y, float z, ForceMode mode)
		{
			this.AddRelativeTorque(new Vector3(x, y, z), mode);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002721 File Offset: 0x00000921
		public void AddRelativeTorque(float x, float y, float z)
		{
			this.AddRelativeTorque(x, y, z, ForceMode.Force);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000272F File Offset: 0x0000092F
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode)
		{
			this.AddForceAtPosition_Injected(ref force, ref position, mode);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000273C File Offset: 0x0000093C
		public void AddForceAtPosition(Vector3 force, Vector3 position)
		{
			this.AddForceAtPosition(force, position, ForceMode.Force);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002749 File Offset: 0x00000949
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode)
		{
			this.AddExplosionForce_Injected(explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, mode);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002759 File Offset: 0x00000959
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier)
		{
			this.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, upwardsModifier, ForceMode.Force);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002769 File Offset: 0x00000969
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius)
		{
			this.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, 0f, ForceMode.Force);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000277C File Offset: 0x0000097C
		public void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance)
		{
			this.Internal_ClosestPointOnBounds_Injected(ref point, ref outPos, ref distance);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005A68 File Offset: 0x00003C68
		public Vector3 ClosestPointOnBounds(Vector3 position)
		{
			float num = 0f;
			Vector3 zero = Vector3.zero;
			this.Internal_ClosestPointOnBounds(position, ref zero, ref num);
			return zero;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005A94 File Offset: 0x00003C94
		public RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit)
		{
			RaycastHit raycastHit;
			this.SweepTest_Injected(ref direction, maxDistance, queryTriggerInteraction, ref hasHit, out raycastHit);
			return raycastHit;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005AB0 File Offset: 0x00003CB0
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			bool flag3;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				bool flag2 = false;
				hitInfo = this.SweepTest(vector, maxDistance, queryTriggerInteraction, ref flag2);
				flag3 = flag2;
			}
			else
			{
				hitInfo = default(RaycastHit);
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005B04 File Offset: 0x00003D04
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			return this.SweepTest(direction, out hitInfo, maxDistance, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005B20 File Offset: 0x00003D20
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo)
		{
			return this.SweepTest(direction, out hitInfo, float.PositiveInfinity, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002788 File Offset: 0x00000988
		public Il2CppStructArray<RaycastHit> Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			return this.Internal_SweepTestAll_Injected(ref direction, maxDistance, queryTriggerInteraction);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002794 File Offset: 0x00000994
		public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005B40 File Offset: 0x00003D40
		public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction, float maxDistance)
		{
			return this.SweepTestAll(direction, maxDistance, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005B5C File Offset: 0x00003D5C
		public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction)
		{
			return this.SweepTestAll(direction, float.PositiveInfinity, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000027A1 File Offset: 0x000009A1
		public void get_velocity_Injected(out Vector3 ret)
		{
			Rigidbody.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000027B4 File Offset: 0x000009B4
		public void get_angularVelocity_Injected(out Vector3 ret)
		{
			Rigidbody.get_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000027C7 File Offset: 0x000009C7
		public void get_centerOfMass_Injected(out Vector3 ret)
		{
			Rigidbody.get_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000027DA File Offset: 0x000009DA
		public void set_centerOfMass_Injected(ref Vector3 value)
		{
			Rigidbody.set_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000027ED File Offset: 0x000009ED
		public void get_worldCenterOfMass_Injected(out Vector3 ret)
		{
			Rigidbody.get_worldCenterOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002800 File Offset: 0x00000A00
		public void get_inertiaTensorRotation_Injected(out Quaternion ret)
		{
			Rigidbody.get_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002813 File Offset: 0x00000A13
		public void set_inertiaTensorRotation_Injected(ref Quaternion value)
		{
			Rigidbody.set_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002826 File Offset: 0x00000A26
		public void get_inertiaTensor_Injected(out Vector3 ret)
		{
			Rigidbody.get_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002839 File Offset: 0x00000A39
		public void set_inertiaTensor_Injected(ref Vector3 value)
		{
			Rigidbody.set_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000284C File Offset: 0x00000A4C
		public void set_position_Injected(ref Vector3 value)
		{
			Rigidbody.set_position_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000285F File Offset: 0x00000A5F
		public void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret)
		{
			Rigidbody.GetRelativePointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativePoint, out ret);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002873 File Offset: 0x00000A73
		public void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret)
		{
			Rigidbody.GetPointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref worldPoint, out ret);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002887 File Offset: 0x00000A87
		public void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode)
		{
			Rigidbody.AddRelativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, mode);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000289B File Offset: 0x00000A9B
		public void AddTorque_Injected(ref Vector3 torque, ForceMode mode)
		{
			Rigidbody.AddTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque, mode);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000028AF File Offset: 0x00000AAF
		public void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode)
		{
			Rigidbody.AddRelativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque, mode);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000028C3 File Offset: 0x00000AC3
		public void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode)
		{
			Rigidbody.AddForceAtPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, ref position, mode);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000028D8 File Offset: 0x00000AD8
		public void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode)
		{
			Rigidbody.AddExplosionForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, mode);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000028F1 File Offset: 0x00000AF1
		public void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance)
		{
			Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, ref outPos, ref distance);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002906 File Offset: 0x00000B06
		public void SweepTest_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret)
		{
			Rigidbody.SweepTest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, maxDistance, queryTriggerInteraction, ref hasHit, out ret);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005B7C File Offset: 0x00003D7C
		public Il2CppStructArray<RaycastHit> Internal_SweepTestAll_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Rigidbody.Internal_SweepTestAll_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, maxDistance, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Vector3_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_set_useGravity_Public_set_Void_Boolean_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_isKinematic_Public_get_Boolean_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_set_angularVelocity_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_MoveRotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_AddForce_Injected_Private_Void_byref_Vector3_ForceMode_0;

		// Token: 0x04000057 RID: 87
		private static readonly Rigidbody.get_dragDelegate get_dragDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly Rigidbody.set_dragDelegate set_dragDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly Rigidbody.get_angularDragDelegate get_angularDragDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly Rigidbody.set_angularDragDelegate set_angularDragDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly Rigidbody.get_massDelegate get_massDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly Rigidbody.set_massDelegate set_massDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly Rigidbody.SetDensityDelegate SetDensityDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly Rigidbody.get_useGravityDelegate get_useGravityDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly Rigidbody.get_maxDepenetrationVelocityDelegate get_maxDepenetrationVelocityDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly Rigidbody.set_maxDepenetrationVelocityDelegate set_maxDepenetrationVelocityDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly Rigidbody.set_isKinematicDelegate set_isKinematicDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly Rigidbody.get_freezeRotationDelegate get_freezeRotationDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly Rigidbody.set_freezeRotationDelegate set_freezeRotationDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly Rigidbody.get_constraintsDelegate get_constraintsDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly Rigidbody.set_constraintsDelegate set_constraintsDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly Rigidbody.get_collisionDetectionModeDelegate get_collisionDetectionModeDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly Rigidbody.set_collisionDetectionModeDelegate set_collisionDetectionModeDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly Rigidbody.get_detectCollisionsDelegate get_detectCollisionsDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly Rigidbody.set_detectCollisionsDelegate set_detectCollisionsDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly Rigidbody.get_interpolationDelegate get_interpolationDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly Rigidbody.set_interpolationDelegate set_interpolationDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly Rigidbody.get_solverIterationsDelegate get_solverIterationsDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly Rigidbody.set_solverIterationsDelegate set_solverIterationsDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly Rigidbody.get_sleepThresholdDelegate get_sleepThresholdDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Rigidbody.set_sleepThresholdDelegate set_sleepThresholdDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly Rigidbody.get_maxAngularVelocityDelegate get_maxAngularVelocityDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly Rigidbody.set_maxAngularVelocityDelegate set_maxAngularVelocityDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly Rigidbody.SleepDelegate SleepDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly Rigidbody.IsSleepingDelegate IsSleepingDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly Rigidbody.WakeUpDelegate WakeUpDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly Rigidbody.ResetCenterOfMassDelegate ResetCenterOfMassDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly Rigidbody.ResetInertiaTensorDelegate ResetInertiaTensorDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly Rigidbody.get_solverVelocityIterationsDelegate get_solverVelocityIterationsDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly Rigidbody.set_solverVelocityIterationsDelegate set_solverVelocityIterationsDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly Rigidbody.get_sleepVelocityDelegate get_sleepVelocityDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly Rigidbody.set_sleepVelocityDelegate set_sleepVelocityDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly Rigidbody.get_sleepAngularVelocityDelegate get_sleepAngularVelocityDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly Rigidbody.set_sleepAngularVelocityDelegate set_sleepAngularVelocityDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly Rigidbody.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly Rigidbody.get_angularVelocity_InjectedDelegate get_angularVelocity_InjectedDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly Rigidbody.get_centerOfMass_InjectedDelegate get_centerOfMass_InjectedDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly Rigidbody.set_centerOfMass_InjectedDelegate set_centerOfMass_InjectedDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly Rigidbody.get_worldCenterOfMass_InjectedDelegate get_worldCenterOfMass_InjectedDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly Rigidbody.get_inertiaTensorRotation_InjectedDelegate get_inertiaTensorRotation_InjectedDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly Rigidbody.set_inertiaTensorRotation_InjectedDelegate set_inertiaTensorRotation_InjectedDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly Rigidbody.get_inertiaTensor_InjectedDelegate get_inertiaTensor_InjectedDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly Rigidbody.set_inertiaTensor_InjectedDelegate set_inertiaTensor_InjectedDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly Rigidbody.set_position_InjectedDelegate set_position_InjectedDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly Rigidbody.GetRelativePointVelocity_InjectedDelegate GetRelativePointVelocity_InjectedDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly Rigidbody.GetPointVelocity_InjectedDelegate GetPointVelocity_InjectedDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly Rigidbody.AddRelativeForce_InjectedDelegate AddRelativeForce_InjectedDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly Rigidbody.AddTorque_InjectedDelegate AddTorque_InjectedDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly Rigidbody.AddRelativeTorque_InjectedDelegate AddRelativeTorque_InjectedDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly Rigidbody.AddForceAtPosition_InjectedDelegate AddForceAtPosition_InjectedDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly Rigidbody.AddExplosionForce_InjectedDelegate AddExplosionForce_InjectedDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegate Internal_ClosestPointOnBounds_InjectedDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly Rigidbody.SweepTest_InjectedDelegate SweepTest_InjectedDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly Rigidbody.Internal_SweepTestAll_InjectedDelegate Internal_SweepTestAll_InjectedDelegateField;

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x0600038C RID: 908
		private delegate float get_dragDelegate(IntPtr @this);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x0600038E RID: 910
		private delegate void set_dragDelegate(IntPtr @this, float value);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000390 RID: 912
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000392 RID: 914
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000394 RID: 916
		private delegate float get_massDelegate(IntPtr @this);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000396 RID: 918
		private delegate void set_massDelegate(IntPtr @this, float value);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000398 RID: 920
		private delegate void SetDensityDelegate(IntPtr @this, float density);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600039A RID: 922
		private delegate bool get_useGravityDelegate(IntPtr @this);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x0600039C RID: 924
		private delegate float get_maxDepenetrationVelocityDelegate(IntPtr @this);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x0600039E RID: 926
		private delegate void set_maxDepenetrationVelocityDelegate(IntPtr @this, float value);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060003A0 RID: 928
		private delegate void set_isKinematicDelegate(IntPtr @this, bool value);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x060003A2 RID: 930
		private delegate bool get_freezeRotationDelegate(IntPtr @this);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060003A4 RID: 932
		private delegate void set_freezeRotationDelegate(IntPtr @this, bool value);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060003A6 RID: 934
		private delegate RigidbodyConstraints get_constraintsDelegate(IntPtr @this);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060003A8 RID: 936
		private delegate void set_constraintsDelegate(IntPtr @this, RigidbodyConstraints value);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060003AA RID: 938
		private delegate CollisionDetectionMode get_collisionDetectionModeDelegate(IntPtr @this);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060003AC RID: 940
		private delegate void set_collisionDetectionModeDelegate(IntPtr @this, CollisionDetectionMode value);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060003AE RID: 942
		private delegate bool get_detectCollisionsDelegate(IntPtr @this);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x060003B0 RID: 944
		private delegate void set_detectCollisionsDelegate(IntPtr @this, bool value);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060003B2 RID: 946
		private delegate RigidbodyInterpolation get_interpolationDelegate(IntPtr @this);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060003B4 RID: 948
		private delegate void set_interpolationDelegate(IntPtr @this, RigidbodyInterpolation value);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060003B6 RID: 950
		private delegate int get_solverIterationsDelegate(IntPtr @this);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060003B8 RID: 952
		private delegate void set_solverIterationsDelegate(IntPtr @this, int value);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x060003BA RID: 954
		private delegate float get_sleepThresholdDelegate(IntPtr @this);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x060003BC RID: 956
		private delegate void set_sleepThresholdDelegate(IntPtr @this, float value);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060003BE RID: 958
		private delegate float get_maxAngularVelocityDelegate(IntPtr @this);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060003C0 RID: 960
		private delegate void set_maxAngularVelocityDelegate(IntPtr @this, float value);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x060003C2 RID: 962
		private delegate void SleepDelegate(IntPtr @this);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x060003C4 RID: 964
		private delegate bool IsSleepingDelegate(IntPtr @this);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x060003C6 RID: 966
		private delegate void WakeUpDelegate(IntPtr @this);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x060003C8 RID: 968
		private delegate void ResetCenterOfMassDelegate(IntPtr @this);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x060003CA RID: 970
		private delegate void ResetInertiaTensorDelegate(IntPtr @this);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x060003CC RID: 972
		private delegate int get_solverVelocityIterationsDelegate(IntPtr @this);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x060003CE RID: 974
		private delegate void set_solverVelocityIterationsDelegate(IntPtr @this, int value);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x060003D0 RID: 976
		private delegate float get_sleepVelocityDelegate(IntPtr @this);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060003D2 RID: 978
		private delegate void set_sleepVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x060003D4 RID: 980
		private delegate float get_sleepAngularVelocityDelegate(IntPtr @this);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060003D6 RID: 982
		private delegate void set_sleepAngularVelocityDelegate(IntPtr @this, float value);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x060003D8 RID: 984
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060003DA RID: 986
		private delegate void get_angularVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x060003DC RID: 988
		private delegate void get_centerOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x060003DE RID: 990
		private delegate void set_centerOfMass_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x060003E0 RID: 992
		private delegate void get_worldCenterOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x060003E2 RID: 994
		private delegate void get_inertiaTensorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x060003E4 RID: 996
		private delegate void set_inertiaTensorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x060003E6 RID: 998
		private delegate void get_inertiaTensor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x060003E8 RID: 1000
		private delegate void set_inertiaTensor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060003EA RID: 1002
		private delegate void set_position_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060003EC RID: 1004
		private delegate void GetRelativePointVelocity_InjectedDelegate(IntPtr @this, IntPtr relativePoint, [Out] IntPtr ret);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060003EE RID: 1006
		private delegate void GetPointVelocity_InjectedDelegate(IntPtr @this, IntPtr worldPoint, [Out] IntPtr ret);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060003F0 RID: 1008
		private delegate void AddRelativeForce_InjectedDelegate(IntPtr @this, IntPtr force, ForceMode mode);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060003F2 RID: 1010
		private delegate void AddTorque_InjectedDelegate(IntPtr @this, IntPtr torque, ForceMode mode);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060003F4 RID: 1012
		private delegate void AddRelativeTorque_InjectedDelegate(IntPtr @this, IntPtr torque, ForceMode mode);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060003F6 RID: 1014
		private delegate void AddForceAtPosition_InjectedDelegate(IntPtr @this, IntPtr force, IntPtr position, ForceMode mode);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060003F8 RID: 1016
		private delegate void AddExplosionForce_InjectedDelegate(IntPtr @this, float explosionForce, IntPtr explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060003FA RID: 1018
		private delegate void Internal_ClosestPointOnBounds_InjectedDelegate(IntPtr @this, IntPtr point, IntPtr outPos, IntPtr distance);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060003FC RID: 1020
		private delegate void SweepTest_InjectedDelegate(IntPtr @this, IntPtr direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, IntPtr hasHit, [Out] IntPtr ret);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060003FE RID: 1022
		private delegate IntPtr Internal_SweepTestAll_InjectedDelegate(IntPtr @this, IntPtr direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction);
	}
}
