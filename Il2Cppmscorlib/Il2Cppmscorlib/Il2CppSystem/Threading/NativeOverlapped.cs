using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000295 RID: 661
	[StructLayout(2)]
	public struct NativeOverlapped
	{
		// Token: 0x06002D37 RID: 11575 RVA: 0x000E8974 File Offset: 0x000E6B74
		// Note: this type is marked as 'beforefieldinit'.
		static NativeOverlapped()
		{
			Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "NativeOverlapped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr);
			NativeOverlapped.NativeFieldInfoPtr_InternalLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "InternalLow");
			NativeOverlapped.NativeFieldInfoPtr_InternalHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "InternalHigh");
			NativeOverlapped.NativeFieldInfoPtr_OffsetLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "OffsetLow");
			NativeOverlapped.NativeFieldInfoPtr_OffsetHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "OffsetHigh");
			NativeOverlapped.NativeFieldInfoPtr_EventHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "EventHandle");
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x0000F8C4 File Offset: 0x0000DAC4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, ref this));
		}

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeFieldInfoPtr_InternalLow;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeFieldInfoPtr_InternalHigh;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeFieldInfoPtr_OffsetLow;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeFieldInfoPtr_OffsetHigh;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeFieldInfoPtr_EventHandle;

		// Token: 0x04002751 RID: 10065
		[FieldOffset(0)]
		public IntPtr InternalLow;

		// Token: 0x04002752 RID: 10066
		[FieldOffset(8)]
		public IntPtr InternalHigh;

		// Token: 0x04002753 RID: 10067
		[FieldOffset(16)]
		public int OffsetLow;

		// Token: 0x04002754 RID: 10068
		[FieldOffset(20)]
		public int OffsetHigh;

		// Token: 0x04002755 RID: 10069
		[FieldOffset(24)]
		public IntPtr EventHandle;
	}
}
