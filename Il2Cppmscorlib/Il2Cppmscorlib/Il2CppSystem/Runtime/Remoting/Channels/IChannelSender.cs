using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003CC RID: 972
	public class IChannelSender : Il2CppObjectBase
	{
		// Token: 0x06003F4A RID: 16202 RVA: 0x00017A02 File Offset: 0x00015C02
		// Note: this type is marked as 'beforefieldinit'.
		static IChannelSender()
		{
			Il2CppClassPointerStore<IChannelSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IChannelSender");
			IChannelSender.NativeMethodInfoPtr_CreateMessageSink_Public_Abstract_Virtual_New_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelSender>.NativeClassPtr, 100672654);
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x00129C60 File Offset: 0x00127E60
		[CallerCount(0)]
		public unsafe virtual IMessageSink CreateMessageSink(string url, Object remoteChannelData, out string objectURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelSender.NativeMethodInfoPtr_CreateMessageSink_Public_Abstract_Virtual_New_IMessageSink_String_Object_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectURI = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x00017A31 File Offset: 0x00015C31
		public IChannelSender(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003427 RID: 13351
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessageSink_Public_Abstract_Virtual_New_IMessageSink_String_Object_byref_String_0;
	}
}
