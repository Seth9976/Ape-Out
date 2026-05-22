using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000054 RID: 84
	public class IPointerDownHandler : Il2CppObjectBase
	{
		// Token: 0x0600093C RID: 2364 RVA: 0x00005403 File Offset: 0x00003603
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerDownHandler()
		{
			Il2CppClassPointerStore<IPointerDownHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerDownHandler");
			IPointerDownHandler.NativeMethodInfoPtr_OnPointerDown_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerDownHandler>.NativeClassPtr, 100664773);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0002AB4C File Offset: 0x00028D4C
		[CallerCount(0)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerDownHandler.NativeMethodInfoPtr_OnPointerDown_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00005432 File Offset: 0x00003632
		public IPointerDownHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
