using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppRewired.Platforms.PS4
{
	// Token: 0x02000186 RID: 390
	public class IPS4ControllerExtensionSourceSixAxisSensor : Il2CppObjectBase
	{
		// Token: 0x060028C7 RID: 10439 RVA: 0x000CE0E8 File Offset: 0x000CC2E8
		// Note: this type is marked as 'beforefieldinit'.
		static IPS4ControllerExtensionSourceSixAxisSensor()
		{
			Il2CppClassPointerStore<IPS4ControllerExtensionSourceSixAxisSensor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4", "IPS4ControllerExtensionSourceSixAxisSensor");
			IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_SetMotionSensorState_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceSixAxisSensor>.NativeClassPtr, 100673201);
			IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_SetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceSixAxisSensor>.NativeClassPtr, 100673202);
			IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_SetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceSixAxisSensor>.NativeClassPtr, 100673203);
			IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_ResetOrientation_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceSixAxisSensor>.NativeClassPtr, 100673204);
			IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastAcceleration_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceSixAxisSensor>.NativeClassPtr, 100673205);
			IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastAccelerationRaw_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceSixAxisSensor>.NativeClassPtr, 100673206);
			IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastGyro_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceSixAxisSensor>.NativeClassPtr, 100673207);
			IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastGyroRaw_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceSixAxisSensor>.NativeClassPtr, 100673208);
			IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastOrientation_Public_Abstract_Virtual_New_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceSixAxisSensor>.NativeClassPtr, 100673209);
			IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastOrientationRaw_Public_Abstract_Virtual_New_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceSixAxisSensor>.NativeClassPtr, 100673210);
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000CE1D8 File Offset: 0x000CC3D8
		[CallerCount(0)]
		public unsafe virtual void SetMotionSensorState(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_SetMotionSensorState_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x000CE224 File Offset: 0x000CC424
		[CallerCount(0)]
		public unsafe virtual void SetTiltCorrectionState(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_SetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x000CE270 File Offset: 0x000CC470
		[CallerCount(0)]
		public unsafe virtual void SetAngularVelocityDeadbandState(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_SetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x000CE2BC File Offset: 0x000CC4BC
		[CallerCount(0)]
		public unsafe virtual void ResetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_ResetOrientation_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x000CE2F8 File Offset: 0x000CC4F8
		[CallerCount(0)]
		public unsafe virtual Vector3 GetLastAcceleration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastAcceleration_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000CE340 File Offset: 0x000CC540
		[CallerCount(0)]
		public unsafe virtual Vector3 GetLastAccelerationRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastAccelerationRaw_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000CE388 File Offset: 0x000CC588
		[CallerCount(0)]
		public unsafe virtual Vector3 GetLastGyro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastGyro_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x000CE3D0 File Offset: 0x000CC5D0
		[CallerCount(0)]
		public unsafe virtual Vector3 GetLastGyroRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastGyroRaw_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x000CE418 File Offset: 0x000CC618
		[CallerCount(0)]
		public unsafe virtual Quaternion GetLastOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastOrientation_Public_Abstract_Virtual_New_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000CE460 File Offset: 0x000CC660
		[CallerCount(0)]
		public unsafe virtual Quaternion GetLastOrientationRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceSixAxisSensor.NativeMethodInfoPtr_GetLastOrientationRaw_Public_Abstract_Virtual_New_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0000FACD File Offset: 0x0000DCCD
		public IPS4ControllerExtensionSourceSixAxisSensor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400229B RID: 8859
		private static readonly IntPtr NativeMethodInfoPtr_SetMotionSensorState_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x0400229C RID: 8860
		private static readonly IntPtr NativeMethodInfoPtr_SetTiltCorrectionState_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeMethodInfoPtr_SetAngularVelocityDeadbandState_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeMethodInfoPtr_ResetOrientation_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeMethodInfoPtr_GetLastAcceleration_Public_Abstract_Virtual_New_Vector3_0;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeMethodInfoPtr_GetLastAccelerationRaw_Public_Abstract_Virtual_New_Vector3_0;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeMethodInfoPtr_GetLastGyro_Public_Abstract_Virtual_New_Vector3_0;

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeMethodInfoPtr_GetLastGyroRaw_Public_Abstract_Virtual_New_Vector3_0;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeMethodInfoPtr_GetLastOrientation_Public_Abstract_Virtual_New_Quaternion_0;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeMethodInfoPtr_GetLastOrientationRaw_Public_Abstract_Virtual_New_Quaternion_0;
	}
}
