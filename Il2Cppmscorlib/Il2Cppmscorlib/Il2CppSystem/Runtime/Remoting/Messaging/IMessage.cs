using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003F6 RID: 1014
	public class IMessage : Il2CppObjectBase
	{
		// Token: 0x06004113 RID: 16659 RVA: 0x00018778 File Offset: 0x00016978
		// Note: this type is marked as 'beforefieldinit'.
		static IMessage()
		{
			Il2CppClassPointerStore<IMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IMessage");
			IMessage.NativeMethodInfoPtr_get_Properties_Public_Abstract_Virtual_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessage>.NativeClassPtr, 100672848);
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06004114 RID: 16660 RVA: 0x0012FD78 File Offset: 0x0012DF78
		public unsafe virtual IDictionary Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessage.NativeMethodInfoPtr_get_Properties_Public_Abstract_Virtual_New_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x000187A7 File Offset: 0x000169A7
		public IMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003541 RID: 13633
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Abstract_Virtual_New_get_IDictionary_0;
	}
}
