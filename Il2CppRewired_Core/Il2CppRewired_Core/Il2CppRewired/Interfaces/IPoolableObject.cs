using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x02000093 RID: 147
	public class IPoolableObject : Il2CppObjectBase
	{
		// Token: 0x0600115A RID: 4442 RVA: 0x00007B3D File Offset: 0x00005D3D
		// Note: this type is marked as 'beforefieldinit'.
		static IPoolableObject()
		{
			Il2CppClassPointerStore<IPoolableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IPoolableObject");
			IPoolableObject.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPoolableObject>.NativeClassPtr, 100666141);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0006DFDC File Offset: 0x0006C1DC
		[CallerCount(0)]
		public unsafe virtual void Return()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPoolableObject.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00007B6C File Offset: 0x00005D6C
		public IPoolableObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Void_0;
	}
}
