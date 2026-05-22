using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000057 RID: 87
	public class IBeginDragHandler : Il2CppObjectBase
	{
		// Token: 0x06000945 RID: 2373 RVA: 0x000054AB File Offset: 0x000036AB
		// Note: this type is marked as 'beforefieldinit'.
		static IBeginDragHandler()
		{
			Il2CppClassPointerStore<IBeginDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IBeginDragHandler");
			IBeginDragHandler.NativeMethodInfoPtr_OnBeginDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBeginDragHandler>.NativeClassPtr, 100664776);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0002AC3C File Offset: 0x00028E3C
		[CallerCount(0)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBeginDragHandler.NativeMethodInfoPtr_OnBeginDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000054DA File Offset: 0x000036DA
		public IBeginDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
