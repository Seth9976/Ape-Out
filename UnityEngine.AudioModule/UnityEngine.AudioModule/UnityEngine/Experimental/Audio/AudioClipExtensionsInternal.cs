using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x02000026 RID: 38
	public static class AudioClipExtensionsInternal
	{
		// Token: 0x060001FD RID: 509 RVA: 0x00003247 File Offset: 0x00001447
		public static uint Internal_CreateAudioClipSampleProvider(AudioClip audioClip, ulong start, long end, bool loop, bool allowDrop, [Optional] bool loopPointIsStart)
		{
			return AudioClipExtensionsInternal.Internal_CreateAudioClipSampleProviderDelegateField(IL2CPP.Il2CppObjectBaseToPtr(audioClip), start, end, loop, allowDrop, loopPointIsStart);
		}

		// Token: 0x040001C2 RID: 450
		private static readonly AudioClipExtensionsInternal.Internal_CreateAudioClipSampleProviderDelegate Internal_CreateAudioClipSampleProviderDelegateField = IL2CPP.ResolveICall<AudioClipExtensionsInternal.Internal_CreateAudioClipSampleProviderDelegate>("UnityEngine.Experimental.Audio.AudioClipExtensionsInternal::Internal_CreateAudioClipSampleProvider");

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x060003C1 RID: 961
		private delegate uint Internal_CreateAudioClipSampleProviderDelegate(IntPtr audioClip, ulong start, long end, bool loop, bool allowDrop, bool loopPointIsStart);
	}
}
