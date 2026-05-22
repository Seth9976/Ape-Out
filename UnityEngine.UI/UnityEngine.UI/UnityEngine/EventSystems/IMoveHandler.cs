using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000060 RID: 96
	public class IMoveHandler : Il2CppObjectBase
	{
		// Token: 0x06000960 RID: 2400 RVA: 0x000056A3 File Offset: 0x000038A3
		// Note: this type is marked as 'beforefieldinit'.
		static IMoveHandler()
		{
			Il2CppClassPointerStore<IMoveHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IMoveHandler");
			IMoveHandler.NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMoveHandler>.NativeClassPtr, 100664785);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0002AF0C File Offset: 0x0002910C
		[CallerCount(0)]
		public unsafe virtual void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMoveHandler.NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000056D2 File Offset: 0x000038D2
		public IMoveHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_AxisEventData_0;
	}
}
