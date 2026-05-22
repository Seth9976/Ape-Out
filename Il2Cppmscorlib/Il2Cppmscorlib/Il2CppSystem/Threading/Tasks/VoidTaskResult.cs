using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AD RID: 685
	[StructLayout(2)]
	public struct VoidTaskResult
	{
		// Token: 0x06002F0F RID: 12047 RVA: 0x0001044C File Offset: 0x0000E64C
		// Note: this type is marked as 'beforefieldinit'.
		static VoidTaskResult()
		{
			Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "VoidTaskResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr);
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00010471 File Offset: 0x0000E671
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr, ref this));
		}
	}
}
