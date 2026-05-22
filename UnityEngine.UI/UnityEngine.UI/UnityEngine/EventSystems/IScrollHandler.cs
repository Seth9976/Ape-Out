using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005C RID: 92
	public class IScrollHandler : Il2CppObjectBase
	{
		// Token: 0x06000954 RID: 2388 RVA: 0x000055C3 File Offset: 0x000037C3
		// Note: this type is marked as 'beforefieldinit'.
		static IScrollHandler()
		{
			Il2CppClassPointerStore<IScrollHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IScrollHandler");
			IScrollHandler.NativeMethodInfoPtr_OnScroll_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScrollHandler>.NativeClassPtr, 100664781);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0002ADCC File Offset: 0x00028FCC
		[CallerCount(0)]
		public unsafe virtual void OnScroll(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScrollHandler.NativeMethodInfoPtr_OnScroll_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000055F2 File Offset: 0x000037F2
		public IScrollHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
