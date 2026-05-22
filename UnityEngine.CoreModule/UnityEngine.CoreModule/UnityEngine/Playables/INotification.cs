using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Playables
{
	// Token: 0x0200017C RID: 380
	public class INotification : Il2CppObjectBase
	{
		// Token: 0x06001D2C RID: 7468 RVA: 0x0000F9B6 File Offset: 0x0000DBB6
		// Note: this type is marked as 'beforefieldinit'.
		static INotification()
		{
			Il2CppClassPointerStore<INotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "INotification");
			INotification.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotification>.NativeClassPtr, 100665900);
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x0006B1C8 File Offset: 0x000693C8
		public unsafe virtual PropertyName id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotification.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x0000F9E5 File Offset: 0x0000DBE5
		public INotification(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0;
	}
}
