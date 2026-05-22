using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003BC RID: 956
	public class IContributeClientContextSink : Il2CppObjectBase
	{
		// Token: 0x06003EDE RID: 16094 RVA: 0x000176FB File Offset: 0x000158FB
		// Note: this type is marked as 'beforefieldinit'.
		static IContributeClientContextSink()
		{
			Il2CppClassPointerStore<IContributeClientContextSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeClientContextSink");
			IContributeClientContextSink.NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeClientContextSink>.NativeClassPtr, 100672603);
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00128584 File Offset: 0x00126784
		[CallerCount(0)]
		public unsafe virtual IMessageSink GetClientContextSink(IMessageSink nextSink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContributeClientContextSink.NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x0001772A File Offset: 0x0001592A
		public IContributeClientContextSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040033E9 RID: 13289
		private static readonly IntPtr NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0;
	}
}
