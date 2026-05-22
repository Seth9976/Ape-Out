using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000E8 RID: 232
	public class IInputManagerJoystick : Il2CppObjectBase
	{
		// Token: 0x0600184F RID: 6223 RVA: 0x0008A8E0 File Offset: 0x00088AE0
		// Note: this type is marked as 'beforefieldinit'.
		static IInputManagerJoystick()
		{
			Il2CppClassPointerStore<IInputManagerJoystick>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IInputManagerJoystick");
			IInputManagerJoystick.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystick>.NativeClassPtr, 100669216);
			IInputManagerJoystick.NativeMethodInfoPtr_FillData_Public_Abstract_Virtual_New_Void_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystick>.NativeClassPtr, 100669217);
			IInputManagerJoystick.NativeMethodInfoPtr_ToBridgedController_Public_Abstract_Virtual_New_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystick>.NativeClassPtr, 100669218);
			IInputManagerJoystick.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Abstract_Virtual_New_ControllerDisconnectedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputManagerJoystick>.NativeClassPtr, 100669219);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0008A958 File Offset: 0x00088B58
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystick.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0008A994 File Offset: 0x00088B94
		[CallerCount(0)]
		public unsafe virtual void FillData(ControllerDataUpdater dataUpdater)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystick.NativeMethodInfoPtr_FillData_Public_Abstract_Virtual_New_Void_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0008A9E4 File Offset: 0x00088BE4
		[CallerCount(0)]
		public unsafe virtual BridgedController ToBridgedController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystick.NativeMethodInfoPtr_ToBridgedController_Public_Abstract_Virtual_New_BridgedController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BridgedController>(intPtr3) : null;
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0008AA30 File Offset: 0x00088C30
		[CallerCount(0)]
		public unsafe virtual ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputManagerJoystick.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Abstract_Virtual_New_ControllerDisconnectedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerDisconnectedEventArgs>(intPtr3) : null;
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0000A1C0 File Offset: 0x000083C0
		public IInputManagerJoystick(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_FillData_Public_Abstract_Virtual_New_Void_ControllerDataUpdater_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_ToBridgedController_Public_Abstract_Virtual_New_BridgedController_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Abstract_Virtual_New_ControllerDisconnectedEventArgs_0;
	}
}
