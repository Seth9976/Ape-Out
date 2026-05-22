using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000021 RID: 33
	public sealed class NativeFixedLengthAttribute : Attribute
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00002A6A File Offset: 0x00000C6A
		// Note: this type is marked as 'beforefieldinit'.
		static NativeFixedLengthAttribute()
		{
			Il2CppClassPointerStore<NativeFixedLengthAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeFixedLengthAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeFixedLengthAttribute>.NativeClassPtr);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002A8F File Offset: 0x00000C8F
		public NativeFixedLengthAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
