using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	// Token: 0x02000170 RID: 368
	[StructLayout(2)]
	public struct BatchRendererCullingOutput
	{
		// Token: 0x06001BBB RID: 7099 RVA: 0x00067E80 File Offset: 0x00066080
		// Note: this type is marked as 'beforefieldinit'.
		static BatchRendererCullingOutput()
		{
			Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchRendererCullingOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr);
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingJobsFence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingJobsFence");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingMatrix");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingPlanes");
			BatchRendererCullingOutput.NativeFieldInfoPtr_batchVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "batchVisibility");
			BatchRendererCullingOutput.NativeFieldInfoPtr_visibleIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "visibleIndices");
			BatchRendererCullingOutput.NativeFieldInfoPtr_visibleIndicesY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "visibleIndicesY");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingPlanesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingPlanesCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_batchVisibilityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "batchVisibilityCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_visibleIndicesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "visibleIndicesCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_nearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "nearPlane");
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0000EE06 File Offset: 0x0000D006
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeFieldInfoPtr_cullingJobsFence;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeFieldInfoPtr_cullingMatrix;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlanes;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeFieldInfoPtr_batchVisibility;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeFieldInfoPtr_visibleIndices;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeFieldInfoPtr_visibleIndicesY;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlanesCount;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeFieldInfoPtr_batchVisibilityCount;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeFieldInfoPtr_visibleIndicesCount;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeFieldInfoPtr_nearPlane;

		// Token: 0x04001596 RID: 5526
		[FieldOffset(0)]
		public Unity.Jobs.JobHandle cullingJobsFence;

		// Token: 0x04001597 RID: 5527
		[FieldOffset(16)]
		public Matrix4x4 cullingMatrix;

		// Token: 0x04001598 RID: 5528
		[FieldOffset(80)]
		public IntPtr cullingPlanes;

		// Token: 0x04001599 RID: 5529
		[FieldOffset(88)]
		public IntPtr batchVisibility;

		// Token: 0x0400159A RID: 5530
		[FieldOffset(96)]
		public IntPtr visibleIndices;

		// Token: 0x0400159B RID: 5531
		[FieldOffset(104)]
		public IntPtr visibleIndicesY;

		// Token: 0x0400159C RID: 5532
		[FieldOffset(112)]
		public int cullingPlanesCount;

		// Token: 0x0400159D RID: 5533
		[FieldOffset(116)]
		public int batchVisibilityCount;

		// Token: 0x0400159E RID: 5534
		[FieldOffset(120)]
		public int visibleIndicesCount;

		// Token: 0x0400159F RID: 5535
		[FieldOffset(124)]
		public float nearPlane;
	}
}
