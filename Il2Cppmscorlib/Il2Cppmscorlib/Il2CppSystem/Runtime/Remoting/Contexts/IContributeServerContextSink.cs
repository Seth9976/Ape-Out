using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003C0 RID: 960
	public class IContributeServerContextSink : Il2CppObjectBase
	{
		// Token: 0x06003EEA RID: 16106 RVA: 0x000177DB File Offset: 0x000159DB
		// Note: this type is marked as 'beforefieldinit'.
		static IContributeServerContextSink()
		{
			Il2CppClassPointerStore<IContributeServerContextSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeServerContextSink");
			IContributeServerContextSink.NativeMethodInfoPtr_GetServerContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeServerContextSink>.NativeClassPtr, 100672607);
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x0012870C File Offset: 0x0012690C
		[CallerCount(0)]
		public unsafe virtual IMessageSink GetServerContextSink(IMessageSink nextSink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContributeServerContextSink.NativeMethodInfoPtr_GetServerContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x0001780A File Offset: 0x00015A0A
		public IContributeServerContextSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040033ED RID: 13293
		private static readonly IntPtr NativeMethodInfoPtr_GetServerContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0;
	}
}
