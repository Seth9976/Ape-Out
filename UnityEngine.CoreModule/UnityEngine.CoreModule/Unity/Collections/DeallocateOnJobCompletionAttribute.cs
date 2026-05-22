using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000020 RID: 32
	public sealed class DeallocateOnJobCompletionAttribute : Attribute
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00002A3C File Offset: 0x00000C3C
		// Note: this type is marked as 'beforefieldinit'.
		static DeallocateOnJobCompletionAttribute()
		{
			Il2CppClassPointerStore<DeallocateOnJobCompletionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "DeallocateOnJobCompletionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeallocateOnJobCompletionAttribute>.NativeClassPtr);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002A61 File Offset: 0x00000C61
		public DeallocateOnJobCompletionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
