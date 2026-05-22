using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppRewired.Drivers.Interfaces
{
	// Token: 0x02000100 RID: 256
	public class IDriver_DualShock4 : Il2CppObjectBase
	{
		// Token: 0x0600192D RID: 6445 RVA: 0x0008F908 File Offset: 0x0008DB08
		// Note: this type is marked as 'beforefieldinit'.
		static IDriver_DualShock4()
		{
			Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Drivers.Interfaces", "IDriver_DualShock4");
			IDriver_DualShock4.NativeMethodInfoPtr_get_BatteryLevel_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669390);
			IDriver_DualShock4.NativeMethodInfoPtr_get_LeftMotor_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669391);
			IDriver_DualShock4.NativeMethodInfoPtr_set_LeftMotor_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669392);
			IDriver_DualShock4.NativeMethodInfoPtr_get_RightMotor_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669393);
			IDriver_DualShock4.NativeMethodInfoPtr_set_RightMotor_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669394);
			IDriver_DualShock4.NativeMethodInfoPtr_get_LightColorR_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669395);
			IDriver_DualShock4.NativeMethodInfoPtr_set_LightColorR_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669396);
			IDriver_DualShock4.NativeMethodInfoPtr_get_LightColorG_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669397);
			IDriver_DualShock4.NativeMethodInfoPtr_set_LightColorG_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669398);
			IDriver_DualShock4.NativeMethodInfoPtr_get_LightColorB_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669399);
			IDriver_DualShock4.NativeMethodInfoPtr_set_LightColorB_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669400);
			IDriver_DualShock4.NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669401);
			IDriver_DualShock4.NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669402);
			IDriver_DualShock4.NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669403);
			IDriver_DualShock4.NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669404);
			IDriver_DualShock4.NativeMethodInfoPtr_get_AccelerometerValue_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669405);
			IDriver_DualShock4.NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669406);
			IDriver_DualShock4.NativeMethodInfoPtr_get_GyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669407);
			IDriver_DualShock4.NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669408);
			IDriver_DualShock4.NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669409);
			IDriver_DualShock4.NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669410);
			IDriver_DualShock4.NativeMethodInfoPtr_get_Orientation_Public_Abstract_Virtual_New_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669411);
			IDriver_DualShock4.NativeMethodInfoPtr_ResetOrientation_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669412);
			IDriver_DualShock4.NativeMethodInfoPtr_get_MaxTouches_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669413);
			IDriver_DualShock4.NativeMethodInfoPtr_GetTouchCount_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669414);
			IDriver_DualShock4.NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669415);
			IDriver_DualShock4.NativeMethodInfoPtr_IsTouchingAtIndex_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669416);
			IDriver_DualShock4.NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669417);
			IDriver_DualShock4.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669418);
			IDriver_DualShock4.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669419);
			IDriver_DualShock4.NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669420);
			IDriver_DualShock4.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669421);
			IDriver_DualShock4.NativeMethodInfoPtr_StopLightFlash_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669422);
			IDriver_DualShock4.NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualShock4>.NativeClassPtr, 100669423);
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0008FBD8 File Offset: 0x0008DDD8
		public unsafe virtual float BatteryLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_BatteryLevel_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x0008FC20 File Offset: 0x0008DE20
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x0008FC68 File Offset: 0x0008DE68
		public unsafe virtual float LeftMotor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_LeftMotor_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_set_LeftMotor_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x0008FCB4 File Offset: 0x0008DEB4
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x0008FCFC File Offset: 0x0008DEFC
		public unsafe virtual float RightMotor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_RightMotor_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_set_RightMotor_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x0008FD48 File Offset: 0x0008DF48
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x0008FD90 File Offset: 0x0008DF90
		public unsafe virtual float LightColorR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_LightColorR_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_set_LightColorR_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x0008FDDC File Offset: 0x0008DFDC
		// (set) Token: 0x06001936 RID: 6454 RVA: 0x0008FE24 File Offset: 0x0008E024
		public unsafe virtual float LightColorG
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_LightColorG_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_set_LightColorG_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x0008FE70 File Offset: 0x0008E070
		// (set) Token: 0x06001938 RID: 6456 RVA: 0x0008FEB8 File Offset: 0x0008E0B8
		public unsafe virtual float LightColorB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_LightColorB_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_set_LightColorB_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x0008FF04 File Offset: 0x0008E104
		// (set) Token: 0x0600193A RID: 6458 RVA: 0x0008FF4C File Offset: 0x0008E14C
		public unsafe virtual float LightFlashOnDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x0008FF98 File Offset: 0x0008E198
		// (set) Token: 0x0600193C RID: 6460 RVA: 0x0008FFE0 File Offset: 0x0008E1E0
		public unsafe virtual float LightFlashOffDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x0009002C File Offset: 0x0008E22C
		public unsafe virtual Vector3 AccelerometerValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_AccelerometerValue_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x00090074 File Offset: 0x0008E274
		public unsafe virtual Vector3 AccelerometerValueRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x000900BC File Offset: 0x0008E2BC
		public unsafe virtual Vector3 GyroscopeValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_GyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x00090104 File Offset: 0x0008E304
		public unsafe virtual Vector3 GyroscopeValueRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x0009014C File Offset: 0x0008E34C
		public unsafe virtual Vector3 LastGyroscopeValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x00090194 File Offset: 0x0008E394
		public unsafe virtual Vector3 LastGyroscopeValueRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x000901DC File Offset: 0x0008E3DC
		public unsafe virtual Quaternion Orientation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_Orientation_Public_Abstract_Virtual_New_get_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00090224 File Offset: 0x0008E424
		[CallerCount(0)]
		public unsafe virtual void ResetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_ResetOrientation_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x00090260 File Offset: 0x0008E460
		public unsafe virtual int MaxTouches
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_get_MaxTouches_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000902A8 File Offset: 0x0008E4A8
		[CallerCount(0)]
		public unsafe virtual int GetTouchCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_GetTouchCount_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000902F0 File Offset: 0x0008E4F0
		[CallerCount(0)]
		public unsafe virtual bool IsTouchingAtTouchId(int touchId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00090344 File Offset: 0x0008E544
		[CallerCount(0)]
		public unsafe virtual bool IsTouchingAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_IsTouchingAtIndex_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00090398 File Offset: 0x0008E598
		[CallerCount(0)]
		public unsafe virtual int GetTouchIdAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x000903EC File Offset: 0x0008E5EC
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionByIndex(int index, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00090450 File Offset: 0x0008E650
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000904B4 File Offset: 0x0008E6B4
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00090524 File Offset: 0x0008E724
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00090594 File Offset: 0x0008E794
		[CallerCount(0)]
		public unsafe virtual void StopLightFlash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_StopLightFlash_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x000905D0 File Offset: 0x0008E7D0
		[CallerCount(0)]
		public unsafe virtual void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualShock4.NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0000A2F6 File Offset: 0x000084F6
		public IDriver_DualShock4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_get_BatteryLevel_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftMotor_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftMotor_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_get_RightMotor_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_set_RightMotor_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorR_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorR_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorG_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorG_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorB_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorB_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr_get_AccelerometerValue_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeMethodInfoPtr_get_GyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeMethodInfoPtr_get_Orientation_Public_Abstract_Virtual_New_get_Quaternion_0;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeMethodInfoPtr_ResetOrientation_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxTouches_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchCount_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingAtIndex_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeMethodInfoPtr_StopLightFlash_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0;
	}
}
