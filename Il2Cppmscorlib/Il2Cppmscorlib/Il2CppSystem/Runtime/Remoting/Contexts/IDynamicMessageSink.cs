using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003C1 RID: 961
	public class IDynamicMessageSink : Il2CppObjectBase
	{
		// Token: 0x06003EED RID: 16109 RVA: 0x00128768 File Offset: 0x00126968
		// Note: this type is marked as 'beforefieldinit'.
		static IDynamicMessageSink()
		{
			Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IDynamicMessageSink");
			IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr, 100672608);
			IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr, 100672609);
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x001287B8 File Offset: 0x001269B8
		[CallerCount(0)]
		public unsafe virtual void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replyMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCliSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x00128824 File Offset: 0x00126A24
		[CallerCount(0)]
		public unsafe virtual void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reqMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCliSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x00017813 File Offset: 0x00015A13
		public IDynamicMessageSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040033EE RID: 13294
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0;

		// Token: 0x040033EF RID: 13295
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0;
	}
}
