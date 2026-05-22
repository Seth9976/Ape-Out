using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005F RID: 95
	public class IDeselectHandler : Il2CppObjectBase
	{
		// Token: 0x0600095D RID: 2397 RVA: 0x0000566B File Offset: 0x0000386B
		// Note: this type is marked as 'beforefieldinit'.
		static IDeselectHandler()
		{
			Il2CppClassPointerStore<IDeselectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IDeselectHandler");
			IDeselectHandler.NativeMethodInfoPtr_OnDeselect_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeselectHandler>.NativeClassPtr, 100664784);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0002AEBC File Offset: 0x000290BC
		[CallerCount(0)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeselectHandler.NativeMethodInfoPtr_OnDeselect_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0000569A File Offset: 0x0000389A
		public IDeselectHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
