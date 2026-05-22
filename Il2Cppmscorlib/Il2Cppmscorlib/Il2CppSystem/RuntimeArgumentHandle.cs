using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000130 RID: 304
	[StructLayout(2)]
	public struct RuntimeArgumentHandle
	{
		// Token: 0x060015ED RID: 5613 RVA: 0x000077A0 File Offset: 0x000059A0
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeArgumentHandle()
		{
			Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RuntimeArgumentHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr);
			RuntimeArgumentHandle.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr, "args");
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000077D9 File Offset: 0x000059D9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x040012A6 RID: 4774
		[FieldOffset(0)]
		public IntPtr args;
	}
}
