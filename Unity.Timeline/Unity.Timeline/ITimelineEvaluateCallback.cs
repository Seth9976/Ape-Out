using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Timeline
{
	// Token: 0x02000046 RID: 70
	public class ITimelineEvaluateCallback : Il2CppObjectBase
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x00003937 File Offset: 0x00001B37
		// Note: this type is marked as 'beforefieldinit'.
		static ITimelineEvaluateCallback()
		{
			Il2CppClassPointerStore<ITimelineEvaluateCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ITimelineEvaluateCallback");
			ITimelineEvaluateCallback.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimelineEvaluateCallback>.NativeClassPtr, 100664076);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00016FC0 File Offset: 0x000151C0
		[CallerCount(0)]
		public unsafe virtual void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimelineEvaluateCallback.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00003966 File Offset: 0x00001B66
		public ITimelineEvaluateCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Void_0;
	}
}
