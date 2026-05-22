using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Timeline
{
	// Token: 0x02000045 RID: 69
	public class ITimelineClipAsset : Il2CppObjectBase
	{
		// Token: 0x060004BB RID: 1211 RVA: 0x000038FF File Offset: 0x00001AFF
		// Note: this type is marked as 'beforefieldinit'.
		static ITimelineClipAsset()
		{
			Il2CppClassPointerStore<ITimelineClipAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ITimelineClipAsset");
			ITimelineClipAsset.NativeMethodInfoPtr_get_clipCaps_Public_Abstract_Virtual_New_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimelineClipAsset>.NativeClassPtr, 100664075);
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00016F78 File Offset: 0x00015178
		public unsafe virtual ClipCaps clipCaps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimelineClipAsset.NativeMethodInfoPtr_get_clipCaps_Public_Abstract_Virtual_New_get_ClipCaps_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000392E File Offset: 0x00001B2E
		public ITimelineClipAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_get_clipCaps_Public_Abstract_Virtual_New_get_ClipCaps_0;
	}
}
