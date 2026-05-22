using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000056 RID: 86
	public class IPointerClickHandler : Il2CppObjectBase
	{
		// Token: 0x06000942 RID: 2370 RVA: 0x00005473 File Offset: 0x00003673
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerClickHandler()
		{
			Il2CppClassPointerStore<IPointerClickHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerClickHandler");
			IPointerClickHandler.NativeMethodInfoPtr_OnPointerClick_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerClickHandler>.NativeClassPtr, 100664775);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0002ABEC File Offset: 0x00028DEC
		[CallerCount(0)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerClickHandler.NativeMethodInfoPtr_OnPointerClick_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x000054A2 File Offset: 0x000036A2
		public IPointerClickHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
