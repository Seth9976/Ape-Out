using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003CD RID: 973
	public class IClientChannelSinkProvider : Il2CppObjectBase
	{
		// Token: 0x06003F4D RID: 16205 RVA: 0x00017A3A File Offset: 0x00015C3A
		// Note: this type is marked as 'beforefieldinit'.
		static IClientChannelSinkProvider()
		{
			Il2CppClassPointerStore<IClientChannelSinkProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IClientChannelSinkProvider");
			IClientChannelSinkProvider.NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IClientChannelSinkProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientChannelSinkProvider>.NativeClassPtr, 100672655);
		}

		// Token: 0x17000FD5 RID: 4053
		// (set) Token: 0x06003F4E RID: 16206 RVA: 0x00129CE8 File Offset: 0x00127EE8
		public unsafe virtual IClientChannelSinkProvider Next
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientChannelSinkProvider.NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IClientChannelSinkProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x00017A69 File Offset: 0x00015C69
		public IClientChannelSinkProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003428 RID: 13352
		private static readonly IntPtr NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IClientChannelSinkProvider_0;
	}
}
