using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace UnityEngine.Apple
{
	// Token: 0x020002E1 RID: 737
	public class FrameCapture
	{
		// Token: 0x060023B2 RID: 9138 RVA: 0x00013321 File Offset: 0x00011521
		public static bool IsDestinationSupportedImpl(FrameCaptureDestination dest)
		{
			return FrameCapture.IsDestinationSupportedImplDelegateField(dest);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0001332E File Offset: 0x0001152E
		public static void BeginCaptureImpl(FrameCaptureDestination dest, string path)
		{
			FrameCapture.BeginCaptureImplDelegateField(dest, IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00013341 File Offset: 0x00011541
		public static void EndCaptureImpl()
		{
			FrameCapture.EndCaptureImplDelegateField();
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0001334D File Offset: 0x0001154D
		public static void CaptureNextFrameImpl(FrameCaptureDestination dest, string path)
		{
			FrameCapture.CaptureNextFrameImplDelegateField(dest, IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00079570 File Offset: 0x00077770
		public static bool IsDestinationSupported(FrameCaptureDestination dest)
		{
			bool flag = dest != FrameCaptureDestination.DevTools && dest != FrameCaptureDestination.GPUTraceDocument;
			if (flag)
			{
				throw new ArgumentException("dest", "Argument dest has bad value (not one of FrameCaptureDestination enum values)");
			}
			return FrameCapture.IsDestinationSupportedImpl(dest);
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x000795AC File Offset: 0x000777AC
		public static void BeginCaptureToXcode()
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.DevTools);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture with DevTools is not supported.");
			}
			FrameCapture.BeginCaptureImpl(FrameCaptureDestination.DevTools, null);
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x000795DC File Offset: 0x000777DC
		public static void BeginCaptureToFile(string path)
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.GPUTraceDocument);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture to file is not supported.");
			}
			bool flag2 = String.IsNullOrEmpty(path);
			if (flag2)
			{
				throw new ArgumentException("path", "Path must be supplied when capture destination is GPUTraceDocument.");
			}
			bool flag3 = Path.GetExtension(path) != ".gputrace";
			if (flag3)
			{
				throw new ArgumentException("path", "Destination file should have .gputrace extension.");
			}
			FrameCapture.BeginCaptureImpl(FrameCaptureDestination.GPUTraceDocument, new Uri(path).AbsoluteUri);
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x00013360 File Offset: 0x00011560
		public static void EndCapture()
		{
			FrameCapture.EndCaptureImpl();
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00079654 File Offset: 0x00077854
		public static void CaptureNextFrameToXcode()
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.DevTools);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture with DevTools is not supported.");
			}
			FrameCapture.CaptureNextFrameImpl(FrameCaptureDestination.DevTools, null);
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00079684 File Offset: 0x00077884
		public static void CaptureNextFrameToFile(string path)
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.GPUTraceDocument);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture to file is not supported.");
			}
			bool flag2 = String.IsNullOrEmpty(path);
			if (flag2)
			{
				throw new ArgumentException("path", "Path must be supplied when capture destination is GPUTraceDocument.");
			}
			bool flag3 = Path.GetExtension(path) != ".gputrace";
			if (flag3)
			{
				throw new ArgumentException("path", "Destination file should have .gputrace extension.");
			}
			FrameCapture.CaptureNextFrameImpl(FrameCaptureDestination.GPUTraceDocument, new Uri(path).AbsoluteUri);
		}

		// Token: 0x04001E49 RID: 7753
		private static readonly FrameCapture.IsDestinationSupportedImplDelegate IsDestinationSupportedImplDelegateField = IL2CPP.ResolveICall<FrameCapture.IsDestinationSupportedImplDelegate>("UnityEngine.Apple.FrameCapture::IsDestinationSupportedImpl");

		// Token: 0x04001E4A RID: 7754
		private static readonly FrameCapture.BeginCaptureImplDelegate BeginCaptureImplDelegateField = IL2CPP.ResolveICall<FrameCapture.BeginCaptureImplDelegate>("UnityEngine.Apple.FrameCapture::BeginCaptureImpl");

		// Token: 0x04001E4B RID: 7755
		private static readonly FrameCapture.EndCaptureImplDelegate EndCaptureImplDelegateField = IL2CPP.ResolveICall<FrameCapture.EndCaptureImplDelegate>("UnityEngine.Apple.FrameCapture::EndCaptureImpl");

		// Token: 0x04001E4C RID: 7756
		private static readonly FrameCapture.CaptureNextFrameImplDelegate CaptureNextFrameImplDelegateField = IL2CPP.ResolveICall<FrameCapture.CaptureNextFrameImplDelegate>("UnityEngine.Apple.FrameCapture::CaptureNextFrameImpl");

		// Token: 0x02000C2F RID: 3119
		// (Invoke) Token: 0x060036B0 RID: 14000
		private delegate bool IsDestinationSupportedImplDelegate(FrameCaptureDestination dest);

		// Token: 0x02000C30 RID: 3120
		// (Invoke) Token: 0x060036B2 RID: 14002
		private delegate void BeginCaptureImplDelegate(FrameCaptureDestination dest, IntPtr path);

		// Token: 0x02000C31 RID: 3121
		// (Invoke) Token: 0x060036B4 RID: 14004
		private delegate void EndCaptureImplDelegate();

		// Token: 0x02000C32 RID: 3122
		// (Invoke) Token: 0x060036B6 RID: 14006
		private delegate void CaptureNextFrameImplDelegate(FrameCaptureDestination dest, IntPtr path);
	}
}
