using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel.Design
{
	// Token: 0x0200009D RID: 157
	public class IDesignerHost : Il2CppObjectBase
	{
		// Token: 0x0600092A RID: 2346 RVA: 0x00005B8C File Offset: 0x00003D8C
		// Note: this type is marked as 'beforefieldinit'.
		static IDesignerHost()
		{
			Il2CppClassPointerStore<IDesignerHost>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design", "IDesignerHost");
			IDesignerHost.NativeMethodInfoPtr_get_RootComponent_Public_Abstract_Virtual_New_get_IComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDesignerHost>.NativeClassPtr, 100664590);
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x000327AC File Offset: 0x000309AC
		public unsafe virtual IComponent RootComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDesignerHost.NativeMethodInfoPtr_get_RootComponent_Public_Abstract_Virtual_New_get_IComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComponent>(intPtr3) : null;
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00005BBB File Offset: 0x00003DBB
		public IDesignerHost(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_get_RootComponent_Public_Abstract_Virtual_New_get_IComponent_0;
	}
}
