using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000390 RID: 912
	public class IEnvoyInfo : Il2CppObjectBase
	{
		// Token: 0x06003C3B RID: 15419 RVA: 0x00016765 File Offset: 0x00014965
		// Note: this type is marked as 'beforefieldinit'.
		static IEnvoyInfo()
		{
			Il2CppClassPointerStore<IEnvoyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "IEnvoyInfo");
			IEnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Abstract_Virtual_New_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnvoyInfo>.NativeClassPtr, 100672259);
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06003C3C RID: 15420 RVA: 0x0011E66C File Offset: 0x0011C86C
		public unsafe virtual IMessageSink EnvoySinks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Abstract_Virtual_New_get_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x00016794 File Offset: 0x00014994
		public IEnvoyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003218 RID: 12824
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoySinks_Public_Abstract_Virtual_New_get_IMessageSink_0;
	}
}
