using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired
{
	// Token: 0x0200008E RID: 142
	public class IControllerTemplateButtonSource : Il2CppObjectBase
	{
		// Token: 0x06001115 RID: 4373 RVA: 0x000079B6 File Offset: 0x00005BB6
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateButtonSource()
		{
			Il2CppClassPointerStore<IControllerTemplateButtonSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateButtonSource");
			IControllerTemplateButtonSource.NativeMethodInfoPtr_get_target_Public_Abstract_Virtual_New_get_IControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateButtonSource>.NativeClassPtr, 100666102);
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0006CEF0 File Offset: 0x0006B0F0
		public unsafe virtual IControllerElementTarget target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateButtonSource.NativeMethodInfoPtr_get_target_Public_Abstract_Virtual_New_get_IControllerElementTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerElementTarget>(intPtr3) : null;
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x000079E5 File Offset: 0x00005BE5
		public IControllerTemplateButtonSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_Abstract_Virtual_New_get_IControllerElementTarget_0;
	}
}
