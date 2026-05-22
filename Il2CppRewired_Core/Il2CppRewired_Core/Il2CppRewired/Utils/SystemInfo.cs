using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001E9 RID: 489
	public static class SystemInfo : Object
	{
		// Token: 0x060031C1 RID: 12737 RVA: 0x00011C5B File Offset: 0x0000FE5B
		// Note: this type is marked as 'beforefieldinit'.
		static SystemInfo()
		{
			Il2CppClassPointerStore<SystemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "SystemInfo");
			SystemInfo.NativeFieldInfoPtr_is64Bit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, "is64Bit");
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x00011C8A File Offset: 0x0000FE8A
		public SystemInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x000F72E8 File Offset: 0x000F54E8
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x00011C93 File Offset: 0x0000FE93
		public unsafe static bool is64Bit
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SystemInfo.NativeFieldInfoPtr_is64Bit, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemInfo.NativeFieldInfoPtr_is64Bit, (void*)(&value));
			}
		}

		// Token: 0x04002A62 RID: 10850
		private static readonly IntPtr NativeFieldInfoPtr_is64Bit;
	}
}
