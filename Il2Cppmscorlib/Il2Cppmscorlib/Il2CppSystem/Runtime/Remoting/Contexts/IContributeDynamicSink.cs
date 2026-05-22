using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003BD RID: 957
	public class IContributeDynamicSink : Il2CppObjectBase
	{
		// Token: 0x06003EE1 RID: 16097 RVA: 0x00017733 File Offset: 0x00015933
		// Note: this type is marked as 'beforefieldinit'.
		static IContributeDynamicSink()
		{
			Il2CppClassPointerStore<IContributeDynamicSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeDynamicSink");
			IContributeDynamicSink.NativeMethodInfoPtr_GetDynamicSink_Public_Abstract_Virtual_New_IDynamicMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeDynamicSink>.NativeClassPtr, 100672604);
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x001285E0 File Offset: 0x001267E0
		[CallerCount(0)]
		public unsafe virtual IDynamicMessageSink GetDynamicSink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContributeDynamicSink.NativeMethodInfoPtr_GetDynamicSink_Public_Abstract_Virtual_New_IDynamicMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDynamicMessageSink>(intPtr3) : null;
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x00017762 File Offset: 0x00015962
		public IContributeDynamicSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040033EA RID: 13290
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicSink_Public_Abstract_Virtual_New_IDynamicMessageSink_0;
	}
}
