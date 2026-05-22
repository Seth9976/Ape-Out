using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Audio
{
	// Token: 0x02000010 RID: 16
	public class AudioMixerGroup : Object
	{
		// Token: 0x0600011C RID: 284 RVA: 0x0000699C File Offset: 0x00004B9C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioMixerGroup()
		{
			Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixerGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr);
			AudioMixerGroup.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr, 100663430);
			AudioMixerGroup.get_audioMixerDelegateField = IL2CPP.ResolveICall<AudioMixerGroup.get_audioMixerDelegate>("UnityEngine.Audio.AudioMixerGroup::get_audioMixer");
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000069F0 File Offset: 0x00004BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485518, XrefRangeEnd = 485521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioMixerGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixerGroup.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000280D File Offset: 0x00000A0D
		public AudioMixerGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00006A2C File Offset: 0x00004C2C
		public AudioMixer audioMixer
		{
			get
			{
				IntPtr intPtr = AudioMixerGroup.get_audioMixerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
		}

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000106 RID: 262
		private static readonly AudioMixerGroup.get_audioMixerDelegate get_audioMixerDelegateField;

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060002CC RID: 716
		private delegate IntPtr get_audioMixerDelegate(IntPtr @this);
	}
}
