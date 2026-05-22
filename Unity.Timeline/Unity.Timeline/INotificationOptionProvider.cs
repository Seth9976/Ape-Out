using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Timeline
{
	// Token: 0x02000024 RID: 36
	public class INotificationOptionProvider : Il2CppObjectBase
	{
		// Token: 0x0600039B RID: 923 RVA: 0x00003214 File Offset: 0x00001414
		// Note: this type is marked as 'beforefieldinit'.
		static INotificationOptionProvider()
		{
			Il2CppClassPointerStore<INotificationOptionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "INotificationOptionProvider");
			INotificationOptionProvider.NativeMethodInfoPtr_get_flags_Public_Abstract_Virtual_New_get_NotificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotificationOptionProvider>.NativeClassPtr, 100663915);
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00012B8C File Offset: 0x00010D8C
		public unsafe virtual NotificationFlags flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotificationOptionProvider.NativeMethodInfoPtr_get_flags_Public_Abstract_Virtual_New_get_NotificationFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00003243 File Offset: 0x00001443
		public INotificationOptionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_get_flags_Public_Abstract_Virtual_New_get_NotificationFlags_0;
	}
}
