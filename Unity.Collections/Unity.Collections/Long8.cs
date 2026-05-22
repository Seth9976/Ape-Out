using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000009 RID: 9
	[StructLayout(2)]
	public struct Long8
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000041F4 File Offset: 0x000023F4
		// Note: this type is marked as 'beforefieldinit'.
		static Long8()
		{
			Il2CppClassPointerStore<Long8>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "Long8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Long8>.NativeClassPtr);
			Long8.NativeFieldInfoPtr_f0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long8>.NativeClassPtr, "f0");
			Long8.NativeFieldInfoPtr_f1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long8>.NativeClassPtr, "f1");
			Long8.NativeFieldInfoPtr_f2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long8>.NativeClassPtr, "f2");
			Long8.NativeFieldInfoPtr_f3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long8>.NativeClassPtr, "f3");
			Long8.NativeFieldInfoPtr_f4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long8>.NativeClassPtr, "f4");
			Long8.NativeFieldInfoPtr_f5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long8>.NativeClassPtr, "f5");
			Long8.NativeFieldInfoPtr_f6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long8>.NativeClassPtr, "f6");
			Long8.NativeFieldInfoPtr_f7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long8>.NativeClassPtr, "f7");
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000021E6 File Offset: 0x000003E6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Long8>.NativeClassPtr, ref this));
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_f0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_f1;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_f2;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_f3;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_f4;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_f5;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_f6;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_f7;

		// Token: 0x04000029 RID: 41
		[FieldOffset(0)]
		public long f0;

		// Token: 0x0400002A RID: 42
		[FieldOffset(8)]
		public long f1;

		// Token: 0x0400002B RID: 43
		[FieldOffset(16)]
		public long f2;

		// Token: 0x0400002C RID: 44
		[FieldOffset(24)]
		public long f3;

		// Token: 0x0400002D RID: 45
		[FieldOffset(32)]
		public long f4;

		// Token: 0x0400002E RID: 46
		[FieldOffset(40)]
		public long f5;

		// Token: 0x0400002F RID: 47
		[FieldOffset(48)]
		public long f6;

		// Token: 0x04000030 RID: 48
		[FieldOffset(56)]
		public long f7;
	}
}
