using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C6 RID: 1222
	[StructLayout(2)]
	public struct EmptyStruct
	{
		// Token: 0x0600495E RID: 18782 RVA: 0x0001B725 File Offset: 0x00019925
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyStruct()
		{
			Il2CppClassPointerStore<EmptyStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EmptyStruct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyStruct>.NativeClassPtr);
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x0001B74A File Offset: 0x0001994A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EmptyStruct>.NativeClassPtr, ref this));
		}
	}
}
