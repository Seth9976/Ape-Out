using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000052 RID: 82
	public class IPointerEnterHandler : Il2CppObjectBase
	{
		// Token: 0x06000936 RID: 2358 RVA: 0x00005393 File Offset: 0x00003593
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerEnterHandler()
		{
			Il2CppClassPointerStore<IPointerEnterHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerEnterHandler");
			IPointerEnterHandler.NativeMethodInfoPtr_OnPointerEnter_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEnterHandler>.NativeClassPtr, 100664771);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0002AAAC File Offset: 0x00028CAC
		[CallerCount(0)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEnterHandler.NativeMethodInfoPtr_OnPointerEnter_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000053C2 File Offset: 0x000035C2
		public IPointerEnterHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
