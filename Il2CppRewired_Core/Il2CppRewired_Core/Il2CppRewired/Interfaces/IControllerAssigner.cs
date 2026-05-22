using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000F0 RID: 240
	public class IControllerAssigner : Il2CppObjectBase
	{
		// Token: 0x06001896 RID: 6294 RVA: 0x0008BF5C File Offset: 0x0008A15C
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerAssigner()
		{
			Il2CppClassPointerStore<IControllerAssigner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IControllerAssigner");
			IControllerAssigner.NativeMethodInfoPtr_get_enabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerAssigner>.NativeClassPtr, 100669271);
			IControllerAssigner.NativeMethodInfoPtr_set_enabled_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerAssigner>.NativeClassPtr, 100669272);
			IControllerAssigner.NativeMethodInfoPtr_CanHandleAssignment_Public_Abstract_Virtual_New_Boolean_ControllerType_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerAssigner>.NativeClassPtr, 100669273);
			IControllerAssigner.NativeMethodInfoPtr_AssignController_Public_Abstract_Virtual_New_Void_ControllerType_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerAssigner>.NativeClassPtr, 100669274);
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x0008BFD4 File Offset: 0x0008A1D4
		// (set) Token: 0x06001898 RID: 6296 RVA: 0x0008C01C File Offset: 0x0008A21C
		public unsafe virtual bool enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerAssigner.NativeMethodInfoPtr_get_enabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerAssigner.NativeMethodInfoPtr_set_enabled_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0008C068 File Offset: 0x0008A268
		[CallerCount(0)]
		public unsafe virtual bool CanHandleAssignment(ControllerType controllerType, Controller controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerAssigner.NativeMethodInfoPtr_CanHandleAssignment_Public_Abstract_Virtual_New_Boolean_ControllerType_Controller_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0008C0D0 File Offset: 0x0008A2D0
		[CallerCount(0)]
		public unsafe virtual void AssignController(ControllerType controllerType, Controller controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerAssigner.NativeMethodInfoPtr_AssignController_Public_Abstract_Virtual_New_Void_ControllerType_Controller_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0000A237 File Offset: 0x00008437
		public IControllerAssigner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeMethodInfoPtr_CanHandleAssignment_Public_Abstract_Virtual_New_Boolean_ControllerType_Controller_0;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeMethodInfoPtr_AssignController_Public_Abstract_Virtual_New_Void_ControllerType_Controller_0;
	}
}
