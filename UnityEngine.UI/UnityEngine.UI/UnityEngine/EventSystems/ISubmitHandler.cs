using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000061 RID: 97
	public class ISubmitHandler : Il2CppObjectBase
	{
		// Token: 0x06000963 RID: 2403 RVA: 0x000056DB File Offset: 0x000038DB
		// Note: this type is marked as 'beforefieldinit'.
		static ISubmitHandler()
		{
			Il2CppClassPointerStore<ISubmitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ISubmitHandler");
			ISubmitHandler.NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISubmitHandler>.NativeClassPtr, 100664786);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0002AF5C File Offset: 0x0002915C
		[CallerCount(0)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISubmitHandler.NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0000570A File Offset: 0x0000390A
		public ISubmitHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
