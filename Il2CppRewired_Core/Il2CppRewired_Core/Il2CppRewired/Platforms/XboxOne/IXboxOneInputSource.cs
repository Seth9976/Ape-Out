using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Platforms.XboxOne
{
	// Token: 0x02000217 RID: 535
	public class IXboxOneInputSource : Il2CppObjectBase
	{
		// Token: 0x06003719 RID: 14105 RVA: 0x00110204 File Offset: 0x0010E404
		// Note: this type is marked as 'beforefieldinit'.
		static IXboxOneInputSource()
		{
			Il2CppClassPointerStore<IXboxOneInputSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.XboxOne", "IXboxOneInputSource");
			IXboxOneInputSource.NativeMethodInfoPtr_GetXboxOneUserIdFromUnityJoystick_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXboxOneInputSource>.NativeClassPtr, 100676894);
			IXboxOneInputSource.NativeMethodInfoPtr_SetXboxOneVibration_Public_Abstract_Virtual_New_Boolean_UInt64_AkPWZxJICqXISLazpKqWsMZEWa_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXboxOneInputSource>.NativeClassPtr, 100676895);
			IXboxOneInputSource.NativeMethodInfoPtr_PulseVibrateMotor_Public_Abstract_Virtual_New_Void_UInt64_XboxOneGamepadMotorType_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXboxOneInputSource>.NativeClassPtr, 100676896);
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00110268 File Offset: 0x0010E468
		[CallerCount(0)]
		public unsafe virtual int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unityJoystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXboxOneInputSource.NativeMethodInfoPtr_GetXboxOneUserIdFromUnityJoystick_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x001102BC File Offset: 0x0010E4BC
		[CallerCount(0)]
		public unsafe virtual bool SetXboxOneVibration(ulong xboxOneJoystickId, AkPWZxJICqXISLazpKqWsMZEWa vibration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xboxOneJoystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXboxOneInputSource.NativeMethodInfoPtr_SetXboxOneVibration_Public_Abstract_Virtual_New_Boolean_UInt64_AkPWZxJICqXISLazpKqWsMZEWa_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00110320 File Offset: 0x0010E520
		[CallerCount(0)]
		public unsafe virtual void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xboxOneJoystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXboxOneInputSource.NativeMethodInfoPtr_PulseVibrateMotor_Public_Abstract_Virtual_New_Void_UInt64_XboxOneGamepadMotorType_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x00012FFD File Offset: 0x000111FD
		public IXboxOneInputSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002EA0 RID: 11936
		private static readonly IntPtr NativeMethodInfoPtr_GetXboxOneUserIdFromUnityJoystick_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x04002EA1 RID: 11937
		private static readonly IntPtr NativeMethodInfoPtr_SetXboxOneVibration_Public_Abstract_Virtual_New_Boolean_UInt64_AkPWZxJICqXISLazpKqWsMZEWa_0;

		// Token: 0x04002EA2 RID: 11938
		private static readonly IntPtr NativeMethodInfoPtr_PulseVibrateMotor_Public_Abstract_Virtual_New_Void_UInt64_XboxOneGamepadMotorType_Single_Single_Single_0;
	}
}
