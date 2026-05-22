using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Interfaces
{
	// Token: 0x02000016 RID: 22
	public class IDeepCloneable : Il2CppObjectBase
	{
		// Token: 0x060001AE RID: 430 RVA: 0x000027CC File Offset: 0x000009CC
		// Note: this type is marked as 'beforefieldinit'.
		static IDeepCloneable()
		{
			Il2CppClassPointerStore<IDeepCloneable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Interfaces", "IDeepCloneable");
			IDeepCloneable.NativeMethodInfoPtr_DeepClone_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeepCloneable>.NativeClassPtr, 100663570);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00033FF0 File Offset: 0x000321F0
		[CallerCount(0)]
		public unsafe virtual Object DeepClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeepCloneable.NativeMethodInfoPtr_DeepClone_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000027FB File Offset: 0x000009FB
		public IDeepCloneable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Abstract_Virtual_New_Object_0;
	}
}
