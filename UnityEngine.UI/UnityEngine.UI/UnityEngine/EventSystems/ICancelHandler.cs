using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000062 RID: 98
	public class ICancelHandler : Il2CppObjectBase
	{
		// Token: 0x06000966 RID: 2406 RVA: 0x00005713 File Offset: 0x00003913
		// Note: this type is marked as 'beforefieldinit'.
		static ICancelHandler()
		{
			Il2CppClassPointerStore<ICancelHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ICancelHandler");
			ICancelHandler.NativeMethodInfoPtr_OnCancel_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICancelHandler>.NativeClassPtr, 100664787);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0002AFAC File Offset: 0x000291AC
		[CallerCount(0)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICancelHandler.NativeMethodInfoPtr_OnCancel_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00005742 File Offset: 0x00003942
		public ICancelHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
