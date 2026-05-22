using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ExceptionServices
{
	// Token: 0x0200040D RID: 1037
	public class FirstChanceExceptionEventArgs : EventArgs
	{
		// Token: 0x0600426D RID: 17005 RVA: 0x0001910B File Offset: 0x0001730B
		// Note: this type is marked as 'beforefieldinit'.
		static FirstChanceExceptionEventArgs()
		{
			Il2CppClassPointerStore<FirstChanceExceptionEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "FirstChanceExceptionEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstChanceExceptionEventArgs>.NativeClassPtr);
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x00019130 File Offset: 0x00017330
		public FirstChanceExceptionEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
