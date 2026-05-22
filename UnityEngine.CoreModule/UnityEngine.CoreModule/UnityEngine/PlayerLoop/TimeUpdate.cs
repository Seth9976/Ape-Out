using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x02000144 RID: 324
	[StructLayout(2)]
	public struct TimeUpdate
	{
		// Token: 0x06001978 RID: 6520 RVA: 0x0000D526 File Offset: 0x0000B726
		// Note: this type is marked as 'beforefieldinit'.
		static TimeUpdate()
		{
			Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "TimeUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x0000D54B File Offset: 0x0000B74B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x020008BB RID: 2235
		[StructLayout(2)]
		public struct WaitForLastPresentationAndUpdateTime
		{
			// Token: 0x06002FF5 RID: 12277 RVA: 0x00013CB8 File Offset: 0x00011EB8
			// Note: this type is marked as 'beforefieldinit'.
			static WaitForLastPresentationAndUpdateTime()
			{
				Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, "WaitForLastPresentationAndUpdateTime");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr);
			}

			// Token: 0x06002FF6 RID: 12278 RVA: 0x00013CD8 File Offset: 0x00011ED8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr, ref this));
			}
		}
	}
}
