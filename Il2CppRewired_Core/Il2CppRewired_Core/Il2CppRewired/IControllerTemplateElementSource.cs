using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired
{
	// Token: 0x0200008C RID: 140
	public class IControllerTemplateElementSource : Il2CppObjectBase
	{
		// Token: 0x0600110C RID: 4364 RVA: 0x00007975 File Offset: 0x00005B75
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateElementSource()
		{
			Il2CppClassPointerStore<IControllerTemplateElementSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateElementSource");
			IControllerTemplateElementSource.NativeMethodInfoPtr_get_type_Public_Abstract_Virtual_New_get_ControllerTemplateElementSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElementSource>.NativeClassPtr, 100666097);
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x0006CD04 File Offset: 0x0006AF04
		public unsafe virtual ControllerTemplateElementSourceType type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElementSource.NativeMethodInfoPtr_get_type_Public_Abstract_Virtual_New_get_ControllerTemplateElementSourceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x000079A4 File Offset: 0x00005BA4
		public IControllerTemplateElementSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_Abstract_Virtual_New_get_ControllerTemplateElementSourceType_0;
	}
}
