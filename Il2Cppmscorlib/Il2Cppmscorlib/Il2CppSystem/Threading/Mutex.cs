using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000293 RID: 659
	public sealed class Mutex : WaitHandle
	{
		// Token: 0x06002D2D RID: 11565 RVA: 0x0000F88D File Offset: 0x0000DA8D
		// Note: this type is marked as 'beforefieldinit'.
		static Mutex()
		{
			Il2CppClassPointerStore<Mutex>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Mutex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mutex>.NativeClassPtr);
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x0000F8B2 File Offset: 0x0000DAB2
		public Mutex(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
