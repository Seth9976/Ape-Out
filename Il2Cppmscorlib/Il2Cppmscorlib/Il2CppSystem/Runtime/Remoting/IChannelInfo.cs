using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200038F RID: 911
	public class IChannelInfo : Il2CppObjectBase
	{
		// Token: 0x06003C38 RID: 15416 RVA: 0x0001672D File Offset: 0x0001492D
		// Note: this type is marked as 'beforefieldinit'.
		static IChannelInfo()
		{
			Il2CppClassPointerStore<IChannelInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "IChannelInfo");
			IChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelInfo>.NativeClassPtr, 100672258);
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x0011E620 File Offset: 0x0011C820
		public unsafe virtual Il2CppReferenceArray<Object> ChannelData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x0001675C File Offset: 0x0001495C
		public IChannelInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003217 RID: 12823
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0;
	}
}
