using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000053 RID: 83
	public class IPointerExitHandler : Il2CppObjectBase
	{
		// Token: 0x06000939 RID: 2361 RVA: 0x000053CB File Offset: 0x000035CB
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerExitHandler()
		{
			Il2CppClassPointerStore<IPointerExitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerExitHandler");
			IPointerExitHandler.NativeMethodInfoPtr_OnPointerExit_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerExitHandler>.NativeClassPtr, 100664772);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0002AAFC File Offset: 0x00028CFC
		[CallerCount(0)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerExitHandler.NativeMethodInfoPtr_OnPointerExit_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000053FA File Offset: 0x000035FA
		public IPointerExitHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
