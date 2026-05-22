using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x02000064 RID: 100
	public class IControllerVibrator : Il2CppObjectBase
	{
		// Token: 0x06000E4E RID: 3662 RVA: 0x00060884 File Offset: 0x0005EA84
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerVibrator()
		{
			Il2CppClassPointerStore<IControllerVibrator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IControllerVibrator");
			IControllerVibrator.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerVibrator>.NativeClassPtr, 100665501);
			IControllerVibrator.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerVibrator>.NativeClassPtr, 100665502);
			IControllerVibrator.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerVibrator>.NativeClassPtr, 100665503);
			IControllerVibrator.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerVibrator>.NativeClassPtr, 100665504);
			IControllerVibrator.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerVibrator>.NativeClassPtr, 100665505);
			IControllerVibrator.NativeMethodInfoPtr_GetVibration_Public_Abstract_Virtual_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerVibrator>.NativeClassPtr, 100665506);
			IControllerVibrator.NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerVibrator>.NativeClassPtr, 100665507);
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00060938 File Offset: 0x0005EB38
		public unsafe virtual int vibrationMotorCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerVibrator.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00060980 File Offset: 0x0005EB80
		[CallerCount(0)]
		public unsafe virtual void SetVibration(int motorIndex, float motorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerVibrator.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x000609D8 File Offset: 0x0005EBD8
		[CallerCount(0)]
		public unsafe virtual void SetVibration(int motorIndex, float motorLevel, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerVibrator.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00060A40 File Offset: 0x0005EC40
		[CallerCount(0)]
		public unsafe virtual void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerVibrator.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00060AA8 File Offset: 0x0005ECA8
		[CallerCount(0)]
		public unsafe virtual void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerVibrator.NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00060B1C File Offset: 0x0005ED1C
		[CallerCount(0)]
		public unsafe virtual float GetVibration(int motorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerVibrator.NativeMethodInfoPtr_GetVibration_Public_Abstract_Virtual_New_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00060B70 File Offset: 0x0005ED70
		[CallerCount(0)]
		public unsafe virtual void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerVibrator.NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00006ECC File Offset: 0x000050CC
		public IControllerVibrator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_get_vibrationMotorCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_Single_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_Boolean_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Abstract_Virtual_New_Void_Int32_Single_Single_Boolean_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Abstract_Virtual_New_Single_Int32_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Abstract_Virtual_New_Void_0;
	}
}
