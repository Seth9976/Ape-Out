using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x02000290 RID: 656
	public static class AsyncGPUReadback
	{
		// Token: 0x060022B3 RID: 8883 RVA: 0x00078534 File Offset: 0x00076734
		public static void ValidateFormat(Texture src, UnityEngine.Experimental.Rendering.GraphicsFormat dstformat)
		{
			UnityEngine.Experimental.Rendering.GraphicsFormat format = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetFormat(src);
			bool flag = !SystemInfo.IsFormatSupported(format, UnityEngine.Experimental.Rendering.FormatUsage.ReadPixels);
			if (flag)
			{
				Debug.LogError(String.Format("'{0}' doesn't support ReadPixels usage on this platform. Async GPU readback failed.", format));
			}
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x0001288A File Offset: 0x00010A8A
		public static void WaitAllRequests()
		{
			AsyncGPUReadback.WaitAllRequestsDelegateField();
		}

		// Token: 0x04001C94 RID: 7316
		private static readonly AsyncGPUReadback.WaitAllRequestsDelegate WaitAllRequestsDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.WaitAllRequestsDelegate>("UnityEngine.Rendering.AsyncGPUReadback::WaitAllRequests");

		// Token: 0x02000BEB RID: 3051
		// (Invoke) Token: 0x0600362E RID: 13870
		private delegate void WaitAllRequestsDelegate();
	}
}
