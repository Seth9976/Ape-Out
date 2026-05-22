using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200000A RID: 10
	[StructLayout(2)]
	public struct Long64
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000042C4 File Offset: 0x000024C4
		// Note: this type is marked as 'beforefieldinit'.
		static Long64()
		{
			Il2CppClassPointerStore<Long64>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "Long64");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Long64>.NativeClassPtr);
			Long64.NativeFieldInfoPtr_f0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long64>.NativeClassPtr, "f0");
			Long64.NativeFieldInfoPtr_f1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long64>.NativeClassPtr, "f1");
			Long64.NativeFieldInfoPtr_f2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long64>.NativeClassPtr, "f2");
			Long64.NativeFieldInfoPtr_f3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long64>.NativeClassPtr, "f3");
			Long64.NativeFieldInfoPtr_f4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long64>.NativeClassPtr, "f4");
			Long64.NativeFieldInfoPtr_f5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long64>.NativeClassPtr, "f5");
			Long64.NativeFieldInfoPtr_f6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long64>.NativeClassPtr, "f6");
			Long64.NativeFieldInfoPtr_f7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long64>.NativeClassPtr, "f7");
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000021F8 File Offset: 0x000003F8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Long64>.NativeClassPtr, ref this));
		}

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_f0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_f1;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_f2;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_f3;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_f4;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_f5;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_f6;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_f7;

		// Token: 0x04000039 RID: 57
		[FieldOffset(0)]
		public Long8 f0;

		// Token: 0x0400003A RID: 58
		[FieldOffset(64)]
		public Long8 f1;

		// Token: 0x0400003B RID: 59
		[FieldOffset(128)]
		public Long8 f2;

		// Token: 0x0400003C RID: 60
		[FieldOffset(192)]
		public Long8 f3;

		// Token: 0x0400003D RID: 61
		[FieldOffset(256)]
		public Long8 f4;

		// Token: 0x0400003E RID: 62
		[FieldOffset(320)]
		public Long8 f5;

		// Token: 0x0400003F RID: 63
		[FieldOffset(384)]
		public Long8 f6;

		// Token: 0x04000040 RID: 64
		[FieldOffset(448)]
		public Long8 f7;
	}
}
