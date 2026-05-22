using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003BE RID: 958
	public class IContributeEnvoySink : Il2CppObjectBase
	{
		// Token: 0x06003EE4 RID: 16100 RVA: 0x0001776B File Offset: 0x0001596B
		// Note: this type is marked as 'beforefieldinit'.
		static IContributeEnvoySink()
		{
			Il2CppClassPointerStore<IContributeEnvoySink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeEnvoySink");
			IContributeEnvoySink.NativeMethodInfoPtr_GetEnvoySink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeEnvoySink>.NativeClassPtr, 100672605);
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x0012862C File Offset: 0x0012682C
		[CallerCount(0)]
		public unsafe virtual IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContributeEnvoySink.NativeMethodInfoPtr_GetEnvoySink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0001779A File Offset: 0x0001599A
		public IContributeEnvoySink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040033EB RID: 13291
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvoySink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0;
	}
}
