using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000032 RID: 50
	public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00002ECE File Offset: 0x000010CE
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerNeedsThreadIndexAttribute()
		{
			Il2CppClassPointerStore<NativeContainerNeedsThreadIndexAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerNeedsThreadIndexAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerNeedsThreadIndexAttribute>.NativeClassPtr);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002EF3 File Offset: 0x000010F3
		public NativeContainerNeedsThreadIndexAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
