using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Platforms.PS4
{
	// Token: 0x02000187 RID: 391
	public class IPS4ControllerExtensionSourceVibrator : Il2CppObjectBase
	{
		// Token: 0x060028D3 RID: 10451 RVA: 0x000CE4A8 File Offset: 0x000CC6A8
		// Note: this type is marked as 'beforefieldinit'.
		static IPS4ControllerExtensionSourceVibrator()
		{
			Il2CppClassPointerStore<IPS4ControllerExtensionSourceVibrator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4", "IPS4ControllerExtensionSourceVibrator");
			IPS4ControllerExtensionSourceVibrator.NativeMethodInfoPtr_get_supportsVibration_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceVibrator>.NativeClassPtr, 100673211);
			IPS4ControllerExtensionSourceVibrator.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceVibrator>.NativeClassPtr, 100673212);
			IPS4ControllerExtensionSourceVibrator.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceVibrator>.NativeClassPtr, 100673213);
			IPS4ControllerExtensionSourceVibrator.NativeMethodInfoPtr_GetVibration_Public_Abstract_Virtual_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceVibrator>.NativeClassPtr, 100673214);
			IPS4ControllerExtensionSourceVibrator.NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceVibrator>.NativeClassPtr, 100673215);
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x000CE534 File Offset: 0x000CC734
		public unsafe virtual bool supportsVibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceVibrator.NativeMethodInfoPtr_get_supportsVibration_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x000CE57C File Offset: 0x000CC77C
		public unsafe virtual int vibrationMotorCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceVibrator.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000CE5C4 File Offset: 0x000CC7C4
		[CallerCount(0)]
		public unsafe virtual void SetVibration(int motorIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceVibrator.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000CE61C File Offset: 0x000CC81C
		[CallerCount(0)]
		public unsafe virtual float GetVibration(int motorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceVibrator.NativeMethodInfoPtr_GetVibration_Public_Abstract_Virtual_New_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000CE670 File Offset: 0x000CC870
		[CallerCount(0)]
		public unsafe virtual void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceVibrator.NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0000FAD6 File Offset: 0x0000DCD6
		public IPS4ControllerExtensionSourceVibrator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsVibration_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeMethodInfoPtr_get_vibrationMotorCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_0;

		// Token: 0x040022A8 RID: 8872
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Abstract_Virtual_New_Single_Int32_0;

		// Token: 0x040022A9 RID: 8873
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0;
	}
}
