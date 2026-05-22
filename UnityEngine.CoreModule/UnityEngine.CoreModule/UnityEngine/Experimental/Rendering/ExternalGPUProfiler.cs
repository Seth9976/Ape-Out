using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002D3 RID: 723
	public static class ExternalGPUProfiler
	{
		// Token: 0x06002308 RID: 8968 RVA: 0x00012BD7 File Offset: 0x00010DD7
		public static void BeginGPUCapture()
		{
			ExternalGPUProfiler.BeginGPUCaptureDelegateField();
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00012BE3 File Offset: 0x00010DE3
		public static void EndGPUCapture()
		{
			ExternalGPUProfiler.EndGPUCaptureDelegateField();
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00012BEF File Offset: 0x00010DEF
		public static bool IsAttached()
		{
			return ExternalGPUProfiler.IsAttachedDelegateField();
		}

		// Token: 0x04001E15 RID: 7701
		private static readonly ExternalGPUProfiler.BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.BeginGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::BeginGPUCapture");

		// Token: 0x04001E16 RID: 7702
		private static readonly ExternalGPUProfiler.EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.EndGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::EndGPUCapture");

		// Token: 0x04001E17 RID: 7703
		private static readonly ExternalGPUProfiler.IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.IsAttachedDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::IsAttached");

		// Token: 0x02000C0D RID: 3085
		// (Invoke) Token: 0x06003670 RID: 13936
		private delegate void BeginGPUCaptureDelegate();

		// Token: 0x02000C0E RID: 3086
		// (Invoke) Token: 0x06003672 RID: 13938
		private delegate void EndGPUCaptureDelegate();

		// Token: 0x02000C0F RID: 3087
		// (Invoke) Token: 0x06003674 RID: 13940
		private delegate bool IsAttachedDelegate();
	}
}
