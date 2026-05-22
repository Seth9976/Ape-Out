using System;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Audio;

namespace UnityEngine
{
	// Token: 0x02000021 RID: 33
	public class AudioRenderer
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x00007DC4 File Offset: 0x00005FC4
		public static bool Start()
		{
			return AudioRenderer.Internal_AudioRenderer_Start();
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00007DDC File Offset: 0x00005FDC
		public static bool Stop()
		{
			return AudioRenderer.Internal_AudioRenderer_Stop();
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00007DF4 File Offset: 0x00005FF4
		public static int GetSampleCountForCaptureFrame()
		{
			return AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrame();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00007E0C File Offset: 0x0000600C
		public static bool AddMixerGroupSink(AudioMixerGroup mixerGroup, NativeArray<float> buffer, bool excludeFromMix)
		{
			return AudioRenderer.Internal_AudioRenderer_AddMixerGroupSink(mixerGroup, NativeArrayUnsafeUtility.GetUnsafePtr<float>(buffer), buffer.Length, excludeFromMix);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00007E34 File Offset: 0x00006034
		public static bool Render(NativeArray<float> buffer)
		{
			return AudioRenderer.Internal_AudioRenderer_Render(NativeArrayUnsafeUtility.GetUnsafePtr<float>(buffer), buffer.Length);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000304C File Offset: 0x0000124C
		public static bool Internal_AudioRenderer_Start()
		{
			return AudioRenderer.Internal_AudioRenderer_StartDelegateField();
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00003058 File Offset: 0x00001258
		public static bool Internal_AudioRenderer_Stop()
		{
			return AudioRenderer.Internal_AudioRenderer_StopDelegateField();
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00003064 File Offset: 0x00001264
		public static int Internal_AudioRenderer_GetSampleCountForCaptureFrame()
		{
			return AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegateField();
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00003070 File Offset: 0x00001270
		public unsafe static bool Internal_AudioRenderer_AddMixerGroupSink(AudioMixerGroup mixerGroup, void* ptr, int length, bool excludeFromMix)
		{
			return AudioRenderer.Internal_AudioRenderer_AddMixerGroupSinkDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mixerGroup), ptr, length, excludeFromMix);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00003085 File Offset: 0x00001285
		public unsafe static bool Internal_AudioRenderer_Render(void* ptr, int length)
		{
			return AudioRenderer.Internal_AudioRenderer_RenderDelegateField(ptr, length);
		}

		// Token: 0x0400019C RID: 412
		private static readonly AudioRenderer.Internal_AudioRenderer_StartDelegate Internal_AudioRenderer_StartDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_StartDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Start");

		// Token: 0x0400019D RID: 413
		private static readonly AudioRenderer.Internal_AudioRenderer_StopDelegate Internal_AudioRenderer_StopDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_StopDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Stop");

		// Token: 0x0400019E RID: 414
		private static readonly AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_GetSampleCountForCaptureFrame");

		// Token: 0x0400019F RID: 415
		private static readonly AudioRenderer.Internal_AudioRenderer_AddMixerGroupSinkDelegate Internal_AudioRenderer_AddMixerGroupSinkDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_AddMixerGroupSinkDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_AddMixerGroupSink");

		// Token: 0x040001A0 RID: 416
		private static readonly AudioRenderer.Internal_AudioRenderer_RenderDelegate Internal_AudioRenderer_RenderDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_RenderDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Render");

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x0600038B RID: 907
		private delegate bool Internal_AudioRenderer_StartDelegate();

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x0600038D RID: 909
		private delegate bool Internal_AudioRenderer_StopDelegate();

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x0600038F RID: 911
		private delegate int Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate();

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x06000391 RID: 913
		private delegate bool Internal_AudioRenderer_AddMixerGroupSinkDelegate(IntPtr mixerGroup, IntPtr ptr, int length, bool excludeFromMix);

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x06000393 RID: 915
		private delegate bool Internal_AudioRenderer_RenderDelegate(IntPtr ptr, int length);
	}
}
