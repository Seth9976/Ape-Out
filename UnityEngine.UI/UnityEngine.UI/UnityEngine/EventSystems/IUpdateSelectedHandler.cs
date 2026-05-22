using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005D RID: 93
	public class IUpdateSelectedHandler : Il2CppObjectBase
	{
		// Token: 0x06000957 RID: 2391 RVA: 0x000055FB File Offset: 0x000037FB
		// Note: this type is marked as 'beforefieldinit'.
		static IUpdateSelectedHandler()
		{
			Il2CppClassPointerStore<IUpdateSelectedHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IUpdateSelectedHandler");
			IUpdateSelectedHandler.NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpdateSelectedHandler>.NativeClassPtr, 100664782);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0002AE1C File Offset: 0x0002901C
		[CallerCount(0)]
		public unsafe virtual void OnUpdateSelected(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUpdateSelectedHandler.NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0000562A File Offset: 0x0000382A
		public IUpdateSelectedHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
