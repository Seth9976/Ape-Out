using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000013 RID: 19
	[StructLayout(2)]
	public struct JobRanges
	{
		// Token: 0x0600006C RID: 108 RVA: 0x000164BC File Offset: 0x000146BC
		// Note: this type is marked as 'beforefieldinit'.
		static JobRanges()
		{
			Il2CppClassPointerStore<JobRanges>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "JobRanges");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobRanges>.NativeClassPtr);
			JobRanges.NativeFieldInfoPtr_BatchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "BatchSize");
			JobRanges.NativeFieldInfoPtr_NumJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "NumJobs");
			JobRanges.NativeFieldInfoPtr_TotalIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "TotalIterationCount");
			JobRanges.NativeFieldInfoPtr_NumPhases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "NumPhases");
			JobRanges.NativeFieldInfoPtr_StartEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "StartEndIndex");
			JobRanges.NativeFieldInfoPtr_PhaseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "PhaseData");
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000024EC File Offset: 0x000006EC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, ref this));
		}

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_BatchSize;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_NumJobs;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_TotalIterationCount;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_NumPhases;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_StartEndIndex;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_PhaseData;

		// Token: 0x04000064 RID: 100
		[FieldOffset(0)]
		public int BatchSize;

		// Token: 0x04000065 RID: 101
		[FieldOffset(4)]
		public int NumJobs;

		// Token: 0x04000066 RID: 102
		[FieldOffset(8)]
		public int TotalIterationCount;

		// Token: 0x04000067 RID: 103
		[FieldOffset(12)]
		public int NumPhases;

		// Token: 0x04000068 RID: 104
		[FieldOffset(16)]
		public IntPtr StartEndIndex;

		// Token: 0x04000069 RID: 105
		[FieldOffset(24)]
		public IntPtr PhaseData;
	}
}
