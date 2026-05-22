using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x02000027 RID: 39
	public static class AudioSampleProviderExtensionsInternal
	{
		// Token: 0x060001FF RID: 511 RVA: 0x000080EC File Offset: 0x000062EC
		public static float GetSpeed(AudioSampleProvider provider)
		{
			return AudioSampleProviderExtensionsInternal.InternalGetAudioSampleProviderSpeed(provider.id);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00003271 File Offset: 0x00001471
		public static float InternalGetAudioSampleProviderSpeed(uint providerId)
		{
			return AudioSampleProviderExtensionsInternal.InternalGetAudioSampleProviderSpeedDelegateField(providerId);
		}

		// Token: 0x040001C3 RID: 451
		private static readonly AudioSampleProviderExtensionsInternal.InternalGetAudioSampleProviderSpeedDelegate InternalGetAudioSampleProviderSpeedDelegateField = IL2CPP.ResolveICall<AudioSampleProviderExtensionsInternal.InternalGetAudioSampleProviderSpeedDelegate>("UnityEngine.Experimental.Audio.AudioSampleProviderExtensionsInternal::InternalGetAudioSampleProviderSpeed");

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x060003C3 RID: 963
		private delegate float InternalGetAudioSampleProviderSpeedDelegate(uint providerId);
	}
}
