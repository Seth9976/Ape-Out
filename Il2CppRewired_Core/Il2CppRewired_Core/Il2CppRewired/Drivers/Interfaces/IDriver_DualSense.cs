using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppRewired.ControllerExtensions;
using UnityEngine;

namespace Il2CppRewired.Drivers.Interfaces
{
	// Token: 0x02000101 RID: 257
	public class IDriver_DualSense : Il2CppObjectBase
	{
		// Token: 0x06001951 RID: 6481 RVA: 0x0009060C File Offset: 0x0008E80C
		// Note: this type is marked as 'beforefieldinit'.
		static IDriver_DualSense()
		{
			Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Drivers.Interfaces", "IDriver_DualSense");
			IDriver_DualSense.NativeMethodInfoPtr_get_BatteryLevel_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669424);
			IDriver_DualSense.NativeMethodInfoPtr_get_BatteryCharging_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669425);
			IDriver_DualSense.NativeMethodInfoPtr_get_LeftMotor_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669426);
			IDriver_DualSense.NativeMethodInfoPtr_set_LeftMotor_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669427);
			IDriver_DualSense.NativeMethodInfoPtr_get_RightMotor_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669428);
			IDriver_DualSense.NativeMethodInfoPtr_set_RightMotor_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669429);
			IDriver_DualSense.NativeMethodInfoPtr_get_LightColorR_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669430);
			IDriver_DualSense.NativeMethodInfoPtr_set_LightColorR_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669431);
			IDriver_DualSense.NativeMethodInfoPtr_get_LightColorG_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669432);
			IDriver_DualSense.NativeMethodInfoPtr_set_LightColorG_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669433);
			IDriver_DualSense.NativeMethodInfoPtr_get_LightColorB_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669434);
			IDriver_DualSense.NativeMethodInfoPtr_set_LightColorB_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669435);
			IDriver_DualSense.NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669436);
			IDriver_DualSense.NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669437);
			IDriver_DualSense.NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669438);
			IDriver_DualSense.NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669439);
			IDriver_DualSense.NativeMethodInfoPtr_get_microphoneLightMode_Public_Abstract_Virtual_New_get_DualSenseMicrophoneLightMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669440);
			IDriver_DualSense.NativeMethodInfoPtr_set_microphoneLightMode_Public_Abstract_Virtual_New_set_Void_DualSenseMicrophoneLightMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669441);
			IDriver_DualSense.NativeMethodInfoPtr_get_otherLightBrightness_Public_Abstract_Virtual_New_get_DualSenseOtherLightBrightness_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669442);
			IDriver_DualSense.NativeMethodInfoPtr_set_otherLightBrightness_Public_Abstract_Virtual_New_set_Void_DualSenseOtherLightBrightness_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669443);
			IDriver_DualSense.NativeMethodInfoPtr_get_playerLights_Public_Abstract_Virtual_New_get_DualSensePlayerLightFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669444);
			IDriver_DualSense.NativeMethodInfoPtr_set_playerLights_Public_Abstract_Virtual_New_set_Void_DualSensePlayerLightFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669445);
			IDriver_DualSense.NativeMethodInfoPtr_get_AccelerometerValue_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669446);
			IDriver_DualSense.NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669447);
			IDriver_DualSense.NativeMethodInfoPtr_get_GyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669448);
			IDriver_DualSense.NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669449);
			IDriver_DualSense.NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669450);
			IDriver_DualSense.NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669451);
			IDriver_DualSense.NativeMethodInfoPtr_get_Orientation_Public_Abstract_Virtual_New_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669452);
			IDriver_DualSense.NativeMethodInfoPtr_ResetOrientation_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669453);
			IDriver_DualSense.NativeMethodInfoPtr_get_MaxTouches_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669454);
			IDriver_DualSense.NativeMethodInfoPtr_GetTouchCount_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669455);
			IDriver_DualSense.NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669456);
			IDriver_DualSense.NativeMethodInfoPtr_IsTouchingAtIndex_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669457);
			IDriver_DualSense.NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669458);
			IDriver_DualSense.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669459);
			IDriver_DualSense.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669460);
			IDriver_DualSense.NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669461);
			IDriver_DualSense.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669462);
			IDriver_DualSense.NativeMethodInfoPtr_StopLightFlash_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669463);
			IDriver_DualSense.NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDriver_DualSense>.NativeClassPtr, 100669464);
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x00090968 File Offset: 0x0008EB68
		public unsafe virtual float BatteryLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_BatteryLevel_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x000909B0 File Offset: 0x0008EBB0
		public unsafe virtual bool BatteryCharging
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_BatteryCharging_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x000909F8 File Offset: 0x0008EBF8
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x00090A40 File Offset: 0x0008EC40
		public unsafe virtual float LeftMotor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_LeftMotor_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_set_LeftMotor_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x00090A8C File Offset: 0x0008EC8C
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x00090AD4 File Offset: 0x0008ECD4
		public unsafe virtual float RightMotor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_RightMotor_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_set_RightMotor_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00090B20 File Offset: 0x0008ED20
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x00090B68 File Offset: 0x0008ED68
		public unsafe virtual float LightColorR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_LightColorR_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_set_LightColorR_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x00090BB4 File Offset: 0x0008EDB4
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x00090BFC File Offset: 0x0008EDFC
		public unsafe virtual float LightColorG
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_LightColorG_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_set_LightColorG_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x00090C48 File Offset: 0x0008EE48
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x00090C90 File Offset: 0x0008EE90
		public unsafe virtual float LightColorB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_LightColorB_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_set_LightColorB_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x00090CDC File Offset: 0x0008EEDC
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x00090D24 File Offset: 0x0008EF24
		public unsafe virtual float LightFlashOnDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x00090D70 File Offset: 0x0008EF70
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x00090DB8 File Offset: 0x0008EFB8
		public unsafe virtual float LightFlashOffDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00090E04 File Offset: 0x0008F004
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x00090E4C File Offset: 0x0008F04C
		public unsafe virtual DualSenseMicrophoneLightMode microphoneLightMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_microphoneLightMode_Public_Abstract_Virtual_New_get_DualSenseMicrophoneLightMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_set_microphoneLightMode_Public_Abstract_Virtual_New_set_Void_DualSenseMicrophoneLightMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00090E98 File Offset: 0x0008F098
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00090EE0 File Offset: 0x0008F0E0
		public unsafe virtual DualSenseOtherLightBrightness otherLightBrightness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_otherLightBrightness_Public_Abstract_Virtual_New_get_DualSenseOtherLightBrightness_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_set_otherLightBrightness_Public_Abstract_Virtual_New_set_Void_DualSenseOtherLightBrightness_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00090F2C File Offset: 0x0008F12C
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00090F74 File Offset: 0x0008F174
		public unsafe virtual DualSensePlayerLightFlags playerLights
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_playerLights_Public_Abstract_Virtual_New_get_DualSensePlayerLightFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_set_playerLights_Public_Abstract_Virtual_New_set_Void_DualSensePlayerLightFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00090FC0 File Offset: 0x0008F1C0
		public unsafe virtual Vector3 AccelerometerValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_AccelerometerValue_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x00091008 File Offset: 0x0008F208
		public unsafe virtual Vector3 AccelerometerValueRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00091050 File Offset: 0x0008F250
		public unsafe virtual Vector3 GyroscopeValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_GyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00091098 File Offset: 0x0008F298
		public unsafe virtual Vector3 GyroscopeValueRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x000910E0 File Offset: 0x0008F2E0
		public unsafe virtual Vector3 LastGyroscopeValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x00091128 File Offset: 0x0008F328
		public unsafe virtual Vector3 LastGyroscopeValueRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x00091170 File Offset: 0x0008F370
		public unsafe virtual Quaternion Orientation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_Orientation_Public_Abstract_Virtual_New_get_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x000911B8 File Offset: 0x0008F3B8
		[CallerCount(0)]
		public unsafe virtual void ResetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_ResetOrientation_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x000911F4 File Offset: 0x0008F3F4
		public unsafe virtual int MaxTouches
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_get_MaxTouches_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x0009123C File Offset: 0x0008F43C
		[CallerCount(0)]
		public unsafe virtual int GetTouchCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_GetTouchCount_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00091284 File Offset: 0x0008F484
		[CallerCount(0)]
		public unsafe virtual bool IsTouchingAtTouchId(int touchId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x000912D8 File Offset: 0x0008F4D8
		[CallerCount(0)]
		public unsafe virtual bool IsTouchingAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_IsTouchingAtIndex_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x0009132C File Offset: 0x0008F52C
		[CallerCount(0)]
		public unsafe virtual int GetTouchIdAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00091380 File Offset: 0x0008F580
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000913E4 File Offset: 0x0008F5E4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00091448 File Offset: 0x0008F648
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000914B8 File Offset: 0x0008F6B8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00091528 File Offset: 0x0008F728
		[CallerCount(0)]
		public unsafe virtual void StopLightFlash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_StopLightFlash_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00091564 File Offset: 0x0008F764
		[CallerCount(0)]
		public unsafe virtual void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDriver_DualSense.NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0000A2FF File Offset: 0x000084FF
		public IDriver_DualSense(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeMethodInfoPtr_get_BatteryLevel_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeMethodInfoPtr_get_BatteryCharging_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftMotor_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftMotor_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeMethodInfoPtr_get_RightMotor_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeMethodInfoPtr_set_RightMotor_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorR_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorR_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorG_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorG_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorB_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorB_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeMethodInfoPtr_get_microphoneLightMode_Public_Abstract_Virtual_New_get_DualSenseMicrophoneLightMode_0;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeMethodInfoPtr_set_microphoneLightMode_Public_Abstract_Virtual_New_set_Void_DualSenseMicrophoneLightMode_0;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeMethodInfoPtr_get_otherLightBrightness_Public_Abstract_Virtual_New_get_DualSenseOtherLightBrightness_0;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeMethodInfoPtr_set_otherLightBrightness_Public_Abstract_Virtual_New_set_Void_DualSenseOtherLightBrightness_0;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeMethodInfoPtr_get_playerLights_Public_Abstract_Virtual_New_get_DualSensePlayerLightFlags_0;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeMethodInfoPtr_set_playerLights_Public_Abstract_Virtual_New_set_Void_DualSensePlayerLightFlags_0;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeMethodInfoPtr_get_AccelerometerValue_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeMethodInfoPtr_get_GyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeMethodInfoPtr_get_Orientation_Public_Abstract_Virtual_New_get_Quaternion_0;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeMethodInfoPtr_ResetOrientation_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxTouches_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchCount_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingAtIndex_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Abstract_Virtual_New_Boolean_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeMethodInfoPtr_StopLightFlash_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0;
	}
}
