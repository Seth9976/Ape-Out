using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Audio
{
	// Token: 0x02000012 RID: 18
	public class AudioMixerSnapshot : Object
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00002828 File Offset: 0x00000A28
		// Note: this type is marked as 'beforefieldinit'.
		static AudioMixerSnapshot()
		{
			Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixerSnapshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr);
			AudioMixerSnapshot.get_audioMixerDelegateField = IL2CPP.ResolveICall<AudioMixerSnapshot.get_audioMixerDelegate>("UnityEngine.Audio.AudioMixerSnapshot::get_audioMixer");
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000285C File Offset: 0x00000A5C
		public AudioMixerSnapshot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00006D40 File Offset: 0x00004F40
		public AudioMixer audioMixer
		{
			get
			{
				IntPtr intPtr = AudioMixerSnapshot.get_audioMixerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002865 File Offset: 0x00000A65
		public void TransitionTo(float timeToReach)
		{
			this.audioMixer.TransitionToSnapshot(this, timeToReach);
		}

		// Token: 0x04000110 RID: 272
		private static readonly AudioMixerSnapshot.get_audioMixerDelegate get_audioMixerDelegateField;

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060002CE RID: 718
		private delegate IntPtr get_audioMixerDelegate(IntPtr @this);
	}
}
