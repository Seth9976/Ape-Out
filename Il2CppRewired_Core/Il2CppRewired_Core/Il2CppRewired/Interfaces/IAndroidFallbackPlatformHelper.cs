using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000F2 RID: 242
	public class IAndroidFallbackPlatformHelper : Il2CppObjectBase
	{
		// Token: 0x060018A0 RID: 6304 RVA: 0x0008C228 File Offset: 0x0008A428
		// Note: this type is marked as 'beforefieldinit'.
		static IAndroidFallbackPlatformHelper()
		{
			Il2CppClassPointerStore<IAndroidFallbackPlatformHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IAndroidFallbackPlatformHelper");
			IAndroidFallbackPlatformHelper.NativeMethodInfoPtr_add_DeviceChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAndroidFallbackPlatformHelper>.NativeClassPtr, 100669277);
			IAndroidFallbackPlatformHelper.NativeMethodInfoPtr_remove_DeviceChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAndroidFallbackPlatformHelper>.NativeClassPtr, 100669278);
			IAndroidFallbackPlatformHelper.NativeMethodInfoPtr_get_ds4Helper_Public_Abstract_Virtual_New_get_IAndroidFallbackDS4Helper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAndroidFallbackPlatformHelper>.NativeClassPtr, 100669279);
			IAndroidFallbackPlatformHelper.NativeMethodInfoPtr_GetUniqueDeviceIdentifier_Public_Abstract_Virtual_New_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAndroidFallbackPlatformHelper>.NativeClassPtr, 100669280);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0008C2A0 File Offset: 0x0008A4A0
		[CallerCount(0)]
		public unsafe virtual void add_DeviceChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAndroidFallbackPlatformHelper.NativeMethodInfoPtr_add_DeviceChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0008C2F0 File Offset: 0x0008A4F0
		[CallerCount(0)]
		public unsafe virtual void remove_DeviceChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAndroidFallbackPlatformHelper.NativeMethodInfoPtr_remove_DeviceChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0008C340 File Offset: 0x0008A540
		public unsafe virtual IAndroidFallbackDS4Helper ds4Helper
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAndroidFallbackPlatformHelper.NativeMethodInfoPtr_get_ds4Helper_Public_Abstract_Virtual_New_get_IAndroidFallbackDS4Helper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAndroidFallbackDS4Helper>(intPtr3) : null;
			}
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0008C38C File Offset: 0x0008A58C
		[CallerCount(0)]
		public unsafe virtual string GetUniqueDeviceIdentifier(string unityJoystickName, int unityArrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(unityJoystickName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityArrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAndroidFallbackPlatformHelper.NativeMethodInfoPtr_GetUniqueDeviceIdentifier_Public_Abstract_Virtual_New_String_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0000A249 File Offset: 0x00008449
		public IAndroidFallbackPlatformHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeMethodInfoPtr_add_DeviceChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_0;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeMethodInfoPtr_remove_DeviceChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_0;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr_get_ds4Helper_Public_Abstract_Virtual_New_get_IAndroidFallbackDS4Helper_0;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr_GetUniqueDeviceIdentifier_Public_Abstract_Virtual_New_String_String_Int32_0;
	}
}
