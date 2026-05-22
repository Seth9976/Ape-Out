using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Timeline
{
	// Token: 0x0200001C RID: 28
	public class IInterval : Il2CppObjectBase
	{
		// Token: 0x06000336 RID: 822 RVA: 0x00011200 File Offset: 0x0000F400
		// Note: this type is marked as 'beforefieldinit'.
		static IInterval()
		{
			Il2CppClassPointerStore<IInterval>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "IInterval");
			IInterval.NativeMethodInfoPtr_get_intervalStart_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInterval>.NativeClassPtr, 100663862);
			IInterval.NativeMethodInfoPtr_get_intervalEnd_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInterval>.NativeClassPtr, 100663863);
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00011250 File Offset: 0x0000F450
		public unsafe virtual long intervalStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInterval.NativeMethodInfoPtr_get_intervalStart_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00011298 File Offset: 0x0000F498
		public unsafe virtual long intervalEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInterval.NativeMethodInfoPtr_get_intervalEnd_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000302A File Offset: 0x0000122A
		public IInterval(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_get_intervalStart_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_get_intervalEnd_Public_Abstract_Virtual_New_get_Int64_0;
	}
}
