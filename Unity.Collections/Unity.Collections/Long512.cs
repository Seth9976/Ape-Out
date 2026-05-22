using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct Long512
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00004394 File Offset: 0x00002594
		// Note: this type is marked as 'beforefieldinit'.
		static Long512()
		{
			Il2CppClassPointerStore<Long512>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "Long512");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Long512>.NativeClassPtr);
			Long512.NativeFieldInfoPtr_f0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long512>.NativeClassPtr, "f0");
			Long512.NativeFieldInfoPtr_f1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long512>.NativeClassPtr, "f1");
			Long512.NativeFieldInfoPtr_f2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long512>.NativeClassPtr, "f2");
			Long512.NativeFieldInfoPtr_f3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long512>.NativeClassPtr, "f3");
			Long512.NativeFieldInfoPtr_f4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long512>.NativeClassPtr, "f4");
			Long512.NativeFieldInfoPtr_f5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long512>.NativeClassPtr, "f5");
			Long512.NativeFieldInfoPtr_f6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long512>.NativeClassPtr, "f6");
			Long512.NativeFieldInfoPtr_f7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long512>.NativeClassPtr, "f7");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000220A File Offset: 0x0000040A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Long512>.NativeClassPtr, ref this));
		}

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_f0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_f1;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_f2;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_f3;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_f4;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_f5;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_f6;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_f7;

		// Token: 0x04000049 RID: 73
		[FieldOffset(0)]
		public Long64 f0;

		// Token: 0x0400004A RID: 74
		[FieldOffset(512)]
		public Long64 f1;

		// Token: 0x0400004B RID: 75
		[FieldOffset(1024)]
		public Long64 f2;

		// Token: 0x0400004C RID: 76
		[FieldOffset(1536)]
		public Long64 f3;

		// Token: 0x0400004D RID: 77
		[FieldOffset(2048)]
		public Long64 f4;

		// Token: 0x0400004E RID: 78
		[FieldOffset(2560)]
		public Long64 f5;

		// Token: 0x0400004F RID: 79
		[FieldOffset(3072)]
		public Long64 f6;

		// Token: 0x04000050 RID: 80
		[FieldOffset(3584)]
		public Long64 f7;
	}
}
