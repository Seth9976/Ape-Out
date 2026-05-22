using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C9 RID: 969
	public class IChannel : Il2CppObjectBase
	{
		// Token: 0x06003F40 RID: 16192 RVA: 0x00129A98 File Offset: 0x00127C98
		// Note: this type is marked as 'beforefieldinit'.
		static IChannel()
		{
			Il2CppClassPointerStore<IChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IChannel");
			IChannel.NativeMethodInfoPtr_get_ChannelName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannel>.NativeClassPtr, 100672650);
			IChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannel>.NativeClassPtr, 100672651);
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06003F41 RID: 16193 RVA: 0x00129AE8 File Offset: 0x00127CE8
		public unsafe virtual string ChannelName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannel.NativeMethodInfoPtr_get_ChannelName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06003F42 RID: 16194 RVA: 0x00129B2C File Offset: 0x00127D2C
		public unsafe virtual int ChannelPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x000179CC File Offset: 0x00015BCC
		public IChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003423 RID: 13347
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04003424 RID: 13348
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelPriority_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
