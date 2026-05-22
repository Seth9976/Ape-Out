using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003CF RID: 975
	public class IServerChannelSinkProvider : Il2CppObjectBase
	{
		// Token: 0x06003F53 RID: 16211 RVA: 0x00017AAA File Offset: 0x00015CAA
		// Note: this type is marked as 'beforefieldinit'.
		static IServerChannelSinkProvider()
		{
			Il2CppClassPointerStore<IServerChannelSinkProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IServerChannelSinkProvider");
			IServerChannelSinkProvider.NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IServerChannelSinkProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IServerChannelSinkProvider>.NativeClassPtr, 100672657);
		}

		// Token: 0x17000FD7 RID: 4055
		// (set) Token: 0x06003F54 RID: 16212 RVA: 0x00129D84 File Offset: 0x00127F84
		public unsafe virtual IServerChannelSinkProvider Next
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IServerChannelSinkProvider.NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IServerChannelSinkProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x00017AD9 File Offset: 0x00015CD9
		public IServerChannelSinkProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400342A RID: 13354
		private static readonly IntPtr NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IServerChannelSinkProvider_0;
	}
}
