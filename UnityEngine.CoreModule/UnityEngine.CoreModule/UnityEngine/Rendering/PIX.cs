using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000293 RID: 659
	public class PIX
	{
		// Token: 0x060022B7 RID: 8887 RVA: 0x000128C5 File Offset: 0x00010AC5
		public static void BeginGPUCapture()
		{
			PIX.BeginGPUCaptureDelegateField();
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x000128D1 File Offset: 0x00010AD1
		public static void EndGPUCapture()
		{
			PIX.EndGPUCaptureDelegateField();
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x000128DD File Offset: 0x00010ADD
		public static bool IsAttached()
		{
			return PIX.IsAttachedDelegateField();
		}

		// Token: 0x04001C98 RID: 7320
		private static readonly PIX.BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<PIX.BeginGPUCaptureDelegate>("UnityEngine.Rendering.PIX::BeginGPUCapture");

		// Token: 0x04001C99 RID: 7321
		private static readonly PIX.EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<PIX.EndGPUCaptureDelegate>("UnityEngine.Rendering.PIX::EndGPUCapture");

		// Token: 0x04001C9A RID: 7322
		private static readonly PIX.IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<PIX.IsAttachedDelegate>("UnityEngine.Rendering.PIX::IsAttached");

		// Token: 0x02000BEC RID: 3052
		// (Invoke) Token: 0x06003630 RID: 13872
		private delegate void BeginGPUCaptureDelegate();

		// Token: 0x02000BED RID: 3053
		// (Invoke) Token: 0x06003632 RID: 13874
		private delegate void EndGPUCaptureDelegate();

		// Token: 0x02000BEE RID: 3054
		// (Invoke) Token: 0x06003634 RID: 13876
		private delegate bool IsAttachedDelegate();
	}
}
