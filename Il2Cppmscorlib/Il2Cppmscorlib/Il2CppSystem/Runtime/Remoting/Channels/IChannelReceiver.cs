using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003CB RID: 971
	public class IChannelReceiver : Il2CppObjectBase
	{
		// Token: 0x06003F46 RID: 16198 RVA: 0x00129B74 File Offset: 0x00127D74
		// Note: this type is marked as 'beforefieldinit'.
		static IChannelReceiver()
		{
			Il2CppClassPointerStore<IChannelReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IChannelReceiver");
			IChannelReceiver.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelReceiver>.NativeClassPtr, 100672652);
			IChannelReceiver.NativeMethodInfoPtr_StartListening_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelReceiver>.NativeClassPtr, 100672653);
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06003F47 RID: 16199 RVA: 0x00129BC4 File Offset: 0x00127DC4
		public unsafe virtual Object ChannelData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelReceiver.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x00129C10 File Offset: 0x00127E10
		[CallerCount(0)]
		public unsafe virtual void StartListening(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelReceiver.NativeMethodInfoPtr_StartListening_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x000179F9 File Offset: 0x00015BF9
		public IChannelReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003425 RID: 13349
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04003426 RID: 13350
		private static readonly IntPtr NativeMethodInfoPtr_StartListening_Public_Abstract_Virtual_New_Void_Object_0;
	}
}
