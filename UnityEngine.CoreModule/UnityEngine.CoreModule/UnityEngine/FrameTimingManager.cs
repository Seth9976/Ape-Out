using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000209 RID: 521
	public static class FrameTimingManager
	{
		// Token: 0x060020C2 RID: 8386 RVA: 0x000111C1 File Offset: 0x0000F3C1
		public static void CaptureFrameTimings()
		{
			FrameTimingManager.CaptureFrameTimingsDelegateField();
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x000111CD File Offset: 0x0000F3CD
		public static float GetVSyncsPerSecond()
		{
			return FrameTimingManager.GetVSyncsPerSecondDelegateField();
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x000111D9 File Offset: 0x0000F3D9
		public static ulong GetGpuTimerFrequency()
		{
			return FrameTimingManager.GetGpuTimerFrequencyDelegateField();
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x000111E5 File Offset: 0x0000F3E5
		public static ulong GetCpuTimerFrequency()
		{
			return FrameTimingManager.GetCpuTimerFrequencyDelegateField();
		}

		// Token: 0x04001AAC RID: 6828
		private static readonly FrameTimingManager.CaptureFrameTimingsDelegate CaptureFrameTimingsDelegateField = IL2CPP.ResolveICall<FrameTimingManager.CaptureFrameTimingsDelegate>("UnityEngine.FrameTimingManager::CaptureFrameTimings");

		// Token: 0x04001AAD RID: 6829
		private static readonly FrameTimingManager.GetVSyncsPerSecondDelegate GetVSyncsPerSecondDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetVSyncsPerSecondDelegate>("UnityEngine.FrameTimingManager::GetVSyncsPerSecond");

		// Token: 0x04001AAE RID: 6830
		private static readonly FrameTimingManager.GetGpuTimerFrequencyDelegate GetGpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetGpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetGpuTimerFrequency");

		// Token: 0x04001AAF RID: 6831
		private static readonly FrameTimingManager.GetCpuTimerFrequencyDelegate GetCpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetCpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetCpuTimerFrequency");

		// Token: 0x02000B02 RID: 2818
		// (Invoke) Token: 0x06003466 RID: 13414
		private delegate void CaptureFrameTimingsDelegate();

		// Token: 0x02000B03 RID: 2819
		// (Invoke) Token: 0x06003468 RID: 13416
		private delegate float GetVSyncsPerSecondDelegate();

		// Token: 0x02000B04 RID: 2820
		// (Invoke) Token: 0x0600346A RID: 13418
		private delegate ulong GetGpuTimerFrequencyDelegate();

		// Token: 0x02000B05 RID: 2821
		// (Invoke) Token: 0x0600346C RID: 13420
		private delegate ulong GetCpuTimerFrequencyDelegate();
	}
}
