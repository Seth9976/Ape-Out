using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public class AudioClipProperties : PlayableBehaviour
	{
		// Token: 0x0600027F RID: 639 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		// Note: this type is marked as 'beforefieldinit'.
		static AudioClipProperties()
		{
			Il2CppClassPointerStore<AudioClipProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "AudioClipProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioClipProperties>.NativeClassPtr);
			AudioClipProperties.NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipProperties>.NativeClassPtr, "volume");
			AudioClipProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipProperties>.NativeClassPtr, 100663736);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000E650 File Offset: 0x0000C850
		[CallerCount(0)]
		public unsafe AudioClipProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClipProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002C56 File Offset: 0x00000E56
		public AudioClipProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000E68C File Offset: 0x0000C88C
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00002C5F File Offset: 0x00000E5F
		public unsafe float volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClipProperties.NativeFieldInfoPtr_volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClipProperties.NativeFieldInfoPtr_volume)) = value;
			}
		}

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_volume;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
