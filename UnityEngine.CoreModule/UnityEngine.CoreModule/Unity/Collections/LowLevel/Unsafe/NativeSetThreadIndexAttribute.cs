using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000031 RID: 49
	public sealed class NativeSetThreadIndexAttribute : Attribute
	{
		// Token: 0x06000167 RID: 359 RVA: 0x00002EA0 File Offset: 0x000010A0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSetThreadIndexAttribute()
		{
			Il2CppClassPointerStore<NativeSetThreadIndexAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeSetThreadIndexAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSetThreadIndexAttribute>.NativeClassPtr);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002EC5 File Offset: 0x000010C5
		public NativeSetThreadIndexAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
