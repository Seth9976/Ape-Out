using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D5 RID: 981
	public class IActivator : Il2CppObjectBase
	{
		// Token: 0x06003F82 RID: 16258 RVA: 0x0012A7C4 File Offset: 0x001289C4
		// Note: this type is marked as 'beforefieldinit'.
		static IActivator()
		{
			Il2CppClassPointerStore<IActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "IActivator");
			IActivator.NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActivator>.NativeClassPtr, 100672678);
			IActivator.NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActivator>.NativeClassPtr, 100672679);
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x0012A814 File Offset: 0x00128A14
		public unsafe virtual IActivator NextActivator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActivator.NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x0012A860 File Offset: 0x00128A60
		[CallerCount(0)]
		public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActivator.NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x00017BDB File Offset: 0x00015DDB
		public IActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003446 RID: 13382
		private static readonly IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0;

		// Token: 0x04003447 RID: 13383
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0;
	}
}
