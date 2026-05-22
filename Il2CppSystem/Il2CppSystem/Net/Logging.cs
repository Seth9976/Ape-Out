using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x0200011E RID: 286
	public static class Logging : Object
	{
		// Token: 0x0600101F RID: 4127 RVA: 0x000085D9 File Offset: 0x000067D9
		// Note: this type is marked as 'beforefieldinit'.
		static Logging()
		{
			Il2CppClassPointerStore<Logging>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Logging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Logging>.NativeClassPtr);
			Logging.NativeFieldInfoPtr_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logging>.NativeClassPtr, "On");
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00008612 File Offset: 0x00006812
		public Logging(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x0004D26C File Offset: 0x0004B46C
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x0000861B File Offset: 0x0000681B
		public unsafe static bool On
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Logging.NativeFieldInfoPtr_On, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Logging.NativeFieldInfoPtr_On, (void*)(&value));
			}
		}

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeFieldInfoPtr_On;
	}
}
