using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Platforms.PS4
{
	// Token: 0x0200018D RID: 397
	public class IPS4GamepadExtensionSource : Il2CppObjectBase
	{
		// Token: 0x060028F4 RID: 10484 RVA: 0x000CED9C File Offset: 0x000CCF9C
		// Note: this type is marked as 'beforefieldinit'.
		static IPS4GamepadExtensionSource()
		{
			Il2CppClassPointerStore<IPS4GamepadExtensionSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4", "IPS4GamepadExtensionSource");
			IPS4GamepadExtensionSource.NativeMethodInfoPtr_GetConnectionType_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4GamepadExtensionSource>.NativeClassPtr, 100673232);
			IPS4GamepadExtensionSource.NativeMethodInfoPtr_GetAnalogDeadZoneLeft_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4GamepadExtensionSource>.NativeClassPtr, 100673233);
			IPS4GamepadExtensionSource.NativeMethodInfoPtr_GetAnalogDeadZoneRight_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4GamepadExtensionSource>.NativeClassPtr, 100673234);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x000CEE00 File Offset: 0x000CD000
		[CallerCount(0)]
		public unsafe virtual int GetConnectionType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4GamepadExtensionSource.NativeMethodInfoPtr_GetConnectionType_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000CEE48 File Offset: 0x000CD048
		[CallerCount(0)]
		public unsafe virtual int GetAnalogDeadZoneLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4GamepadExtensionSource.NativeMethodInfoPtr_GetAnalogDeadZoneLeft_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x000CEE90 File Offset: 0x000CD090
		[CallerCount(0)]
		public unsafe virtual int GetAnalogDeadZoneRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4GamepadExtensionSource.NativeMethodInfoPtr_GetAnalogDeadZoneRight_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x0000FB42 File Offset: 0x0000DD42
		public IPS4GamepadExtensionSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040022BA RID: 8890
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionType_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x040022BB RID: 8891
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogDeadZoneLeft_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x040022BC RID: 8892
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogDeadZoneRight_Public_Abstract_Virtual_New_Int32_0;
	}
}
