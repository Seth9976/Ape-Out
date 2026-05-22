using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000AF RID: 175
	[StructLayout(2)]
	public struct DateTimeToken
	{
		// Token: 0x06000CAC RID: 3244 RVA: 0x0005D7A0 File Offset: 0x0005B9A0
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeToken()
		{
			Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr);
			DateTimeToken.NativeFieldInfoPtr_dtt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "dtt");
			DateTimeToken.NativeFieldInfoPtr_suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "suffix");
			DateTimeToken.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "num");
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00005330 File Offset: 0x00003530
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, ref this));
		}

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeFieldInfoPtr_dtt;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr_suffix;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeFieldInfoPtr_num;

		// Token: 0x04000A91 RID: 2705
		[FieldOffset(0)]
		public DateTimeParse.DTT dtt;

		// Token: 0x04000A92 RID: 2706
		[FieldOffset(4)]
		public TokenType suffix;

		// Token: 0x04000A93 RID: 2707
		[FieldOffset(8)]
		public int num;
	}
}
