using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005B RID: 91
	public class IDropHandler : Il2CppObjectBase
	{
		// Token: 0x06000951 RID: 2385 RVA: 0x0000558B File Offset: 0x0000378B
		// Note: this type is marked as 'beforefieldinit'.
		static IDropHandler()
		{
			Il2CppClassPointerStore<IDropHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IDropHandler");
			IDropHandler.NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDropHandler>.NativeClassPtr, 100664780);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0002AD7C File Offset: 0x00028F7C
		[CallerCount(0)]
		public unsafe virtual void OnDrop(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDropHandler.NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x000055BA File Offset: 0x000037BA
		public IDropHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
