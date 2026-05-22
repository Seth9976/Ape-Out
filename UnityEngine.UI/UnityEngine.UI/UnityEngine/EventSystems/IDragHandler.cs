using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000059 RID: 89
	public class IDragHandler : Il2CppObjectBase
	{
		// Token: 0x0600094B RID: 2379 RVA: 0x0000551B File Offset: 0x0000371B
		// Note: this type is marked as 'beforefieldinit'.
		static IDragHandler()
		{
			Il2CppClassPointerStore<IDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IDragHandler");
			IDragHandler.NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragHandler>.NativeClassPtr, 100664778);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0002ACDC File Offset: 0x00028EDC
		[CallerCount(0)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragHandler.NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0000554A File Offset: 0x0000374A
		public IDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
