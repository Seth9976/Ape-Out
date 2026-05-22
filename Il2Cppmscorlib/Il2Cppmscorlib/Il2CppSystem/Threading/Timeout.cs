using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200028E RID: 654
	public static class Timeout : Object
	{
		// Token: 0x06002CD4 RID: 11476 RVA: 0x0000F71A File Offset: 0x0000D91A
		// Note: this type is marked as 'beforefieldinit'.
		static Timeout()
		{
			Il2CppClassPointerStore<Timeout>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Timeout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timeout>.NativeClassPtr);
			Timeout.NativeFieldInfoPtr_InfiniteTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timeout>.NativeClassPtr, "InfiniteTimeSpan");
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x0000F753 File Offset: 0x0000D953
		public Timeout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x000E6E90 File Offset: 0x000E5090
		// (set) Token: 0x06002CD7 RID: 11479 RVA: 0x0000F75C File Offset: 0x0000D95C
		public unsafe static TimeSpan InfiniteTimeSpan
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Timeout.NativeFieldInfoPtr_InfiniteTimeSpan, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Timeout.NativeFieldInfoPtr_InfiniteTimeSpan, (void*)(&value));
			}
		}

		// Token: 0x04002705 RID: 9989
		private static readonly IntPtr NativeFieldInfoPtr_InfiniteTimeSpan;
	}
}
