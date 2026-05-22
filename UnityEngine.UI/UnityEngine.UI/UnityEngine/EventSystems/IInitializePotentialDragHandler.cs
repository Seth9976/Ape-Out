using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000058 RID: 88
	public class IInitializePotentialDragHandler : Il2CppObjectBase
	{
		// Token: 0x06000948 RID: 2376 RVA: 0x000054E3 File Offset: 0x000036E3
		// Note: this type is marked as 'beforefieldinit'.
		static IInitializePotentialDragHandler()
		{
			Il2CppClassPointerStore<IInitializePotentialDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IInitializePotentialDragHandler");
			IInitializePotentialDragHandler.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInitializePotentialDragHandler>.NativeClassPtr, 100664777);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0002AC8C File Offset: 0x00028E8C
		[CallerCount(0)]
		public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInitializePotentialDragHandler.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00005512 File Offset: 0x00003712
		public IInitializePotentialDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
