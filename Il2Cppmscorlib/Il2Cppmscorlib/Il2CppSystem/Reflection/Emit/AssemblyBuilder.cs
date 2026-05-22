using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x020001E7 RID: 487
	public class AssemblyBuilder : Assembly
	{
		// Token: 0x06001FA1 RID: 8097 RVA: 0x0000AADB File Offset: 0x00008CDB
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyBuilder()
		{
			Il2CppClassPointerStore<AssemblyBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "AssemblyBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyBuilder>.NativeClassPtr);
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0000AB00 File Offset: 0x00008D00
		public AssemblyBuilder(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
