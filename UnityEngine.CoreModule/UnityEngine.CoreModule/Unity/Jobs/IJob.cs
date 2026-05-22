using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Unity.Jobs
{
	// Token: 0x0200000D RID: 13
	public class IJob : Il2CppObjectBase
	{
		// Token: 0x06000041 RID: 65 RVA: 0x0000234B File Offset: 0x0000054B
		// Note: this type is marked as 'beforefieldinit'.
		static IJob()
		{
			Il2CppClassPointerStore<IJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "IJob");
			IJob.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJob>.NativeClassPtr, 100663307);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00015E1C File Offset: 0x0001401C
		[CallerCount(0)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IJob.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000237A File Offset: 0x0000057A
		public IJob(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0;
	}
}
