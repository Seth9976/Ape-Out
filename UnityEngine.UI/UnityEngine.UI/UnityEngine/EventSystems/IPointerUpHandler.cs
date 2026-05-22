using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000055 RID: 85
	public class IPointerUpHandler : Il2CppObjectBase
	{
		// Token: 0x0600093F RID: 2367 RVA: 0x0000543B File Offset: 0x0000363B
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerUpHandler()
		{
			Il2CppClassPointerStore<IPointerUpHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerUpHandler");
			IPointerUpHandler.NativeMethodInfoPtr_OnPointerUp_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerUpHandler>.NativeClassPtr, 100664774);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0002AB9C File Offset: 0x00028D9C
		[CallerCount(0)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerUpHandler.NativeMethodInfoPtr_OnPointerUp_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0000546A File Offset: 0x0000366A
		public IPointerUpHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
