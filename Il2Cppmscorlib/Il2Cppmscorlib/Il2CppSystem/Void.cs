using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200014B RID: 331
	[Serializable]
	[StructLayout(2)]
	public struct Void
	{
		// Token: 0x06001746 RID: 5958 RVA: 0x00008134 File Offset: 0x00006334
		// Note: this type is marked as 'beforefieldinit'.
		static Void()
		{
			Il2CppClassPointerStore<Void>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Void");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Void>.NativeClassPtr);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00008159 File Offset: 0x00006359
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Void>.NativeClassPtr, ref this));
		}
	}
}
