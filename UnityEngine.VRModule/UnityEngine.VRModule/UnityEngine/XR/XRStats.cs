using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR
{
	// Token: 0x02000007 RID: 7
	public static class XRStats
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002207 File Offset: 0x00000407
		public static bool TryGetGPUTimeLastFrame(out float gpuTimeLastFrame)
		{
			return XRStats.TryGetGPUTimeLastFrameDelegateField(out gpuTimeLastFrame);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002214 File Offset: 0x00000414
		public static bool TryGetDroppedFrameCount(out int droppedFrameCount)
		{
			return XRStats.TryGetDroppedFrameCountDelegateField(out droppedFrameCount);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002221 File Offset: 0x00000421
		public static bool TryGetFramePresentCount(out int framePresentCount)
		{
			return XRStats.TryGetFramePresentCountDelegateField(out framePresentCount);
		}

		// Token: 0x0400002D RID: 45
		private static readonly XRStats.TryGetGPUTimeLastFrameDelegate TryGetGPUTimeLastFrameDelegateField = IL2CPP.ResolveICall<XRStats.TryGetGPUTimeLastFrameDelegate>("UnityEngine.XR.XRStats::TryGetGPUTimeLastFrame");

		// Token: 0x0400002E RID: 46
		private static readonly XRStats.TryGetDroppedFrameCountDelegate TryGetDroppedFrameCountDelegateField = IL2CPP.ResolveICall<XRStats.TryGetDroppedFrameCountDelegate>("UnityEngine.XR.XRStats::TryGetDroppedFrameCount");

		// Token: 0x0400002F RID: 47
		private static readonly XRStats.TryGetFramePresentCountDelegate TryGetFramePresentCountDelegateField = IL2CPP.ResolveICall<XRStats.TryGetFramePresentCountDelegate>("UnityEngine.XR.XRStats::TryGetFramePresentCount");

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000067 RID: 103
		private delegate bool TryGetGPUTimeLastFrameDelegate([Out] IntPtr gpuTimeLastFrame);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000069 RID: 105
		private delegate bool TryGetDroppedFrameCountDelegate([Out] IntPtr droppedFrameCount);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x0600006B RID: 107
		private delegate bool TryGetFramePresentCountDelegate([Out] IntPtr framePresentCount);
	}
}
