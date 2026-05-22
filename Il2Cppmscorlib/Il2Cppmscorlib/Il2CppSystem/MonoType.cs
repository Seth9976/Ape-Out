using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000125 RID: 293
	public sealed class MonoType : RuntimeType
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x00007368 File Offset: 0x00005568
		// Note: this type is marked as 'beforefieldinit'.
		static MonoType()
		{
			Il2CppClassPointerStore<MonoType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoType>.NativeClassPtr);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0000738D File Offset: 0x0000558D
		public MonoType(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
