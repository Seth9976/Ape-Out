using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200002C RID: 44
	public sealed class NativeContainerIsReadOnlyAttribute : Attribute
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00002D7E File Offset: 0x00000F7E
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerIsReadOnlyAttribute()
		{
			Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerIsReadOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002DA3 File Offset: 0x00000FA3
		public NativeContainerIsReadOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
