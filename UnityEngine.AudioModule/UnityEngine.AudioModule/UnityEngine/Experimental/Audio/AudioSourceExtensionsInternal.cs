using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x02000028 RID: 40
	public static class AudioSourceExtensionsInternal
	{
		// Token: 0x06000202 RID: 514 RVA: 0x0000329E File Offset: 0x0000149E
		public static void RegisterSampleProvider(AudioSource source, AudioSampleProvider provider)
		{
			AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSource(source, provider.id);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000032AE File Offset: 0x000014AE
		public static void UnregisterSampleProvider(AudioSource source, AudioSampleProvider provider)
		{
			AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSource(source, provider.id);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000032BE File Offset: 0x000014BE
		public static void Internal_RegisterSampleProviderWithAudioSource(AudioSource source, uint providerId)
		{
			AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), providerId);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000032D1 File Offset: 0x000014D1
		public static void Internal_UnregisterSampleProviderFromAudioSource(AudioSource source, uint providerId)
		{
			AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), providerId);
		}

		// Token: 0x040001C4 RID: 452
		private static readonly AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSourceDelegate Internal_RegisterSampleProviderWithAudioSourceDelegateField = IL2CPP.ResolveICall<AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSourceDelegate>("UnityEngine.Experimental.Audio.AudioSourceExtensionsInternal::Internal_RegisterSampleProviderWithAudioSource");

		// Token: 0x040001C5 RID: 453
		private static readonly AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSourceDelegate Internal_UnregisterSampleProviderFromAudioSourceDelegateField = IL2CPP.ResolveICall<AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSourceDelegate>("UnityEngine.Experimental.Audio.AudioSourceExtensionsInternal::Internal_UnregisterSampleProviderFromAudioSource");

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x060003C5 RID: 965
		private delegate void Internal_RegisterSampleProviderWithAudioSourceDelegate(IntPtr source, uint providerId);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x060003C7 RID: 967
		private delegate void Internal_UnregisterSampleProviderFromAudioSourceDelegate(IntPtr source, uint providerId);
	}
}
