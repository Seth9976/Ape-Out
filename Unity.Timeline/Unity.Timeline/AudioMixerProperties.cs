using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000013 RID: 19
	[Serializable]
	public class AudioMixerProperties : PlayableBehaviour
	{
		// Token: 0x06000284 RID: 644 RVA: 0x0000E6B4 File Offset: 0x0000C8B4
		// Note: this type is marked as 'beforefieldinit'.
		static AudioMixerProperties()
		{
			Il2CppClassPointerStore<AudioMixerProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "AudioMixerProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixerProperties>.NativeClassPtr);
			AudioMixerProperties.NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioMixerProperties>.NativeClassPtr, "volume");
			AudioMixerProperties.NativeFieldInfoPtr_stereoPan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioMixerProperties>.NativeClassPtr, "stereoPan");
			AudioMixerProperties.NativeFieldInfoPtr_spatialBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioMixerProperties>.NativeClassPtr, "spatialBlend");
			AudioMixerProperties.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerProperties>.NativeClassPtr, 100663737);
			AudioMixerProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerProperties>.NativeClassPtr, 100663738);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000E748 File Offset: 0x0000C948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476560, XrefRangeEnd = 476605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PrepareFrame(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioMixerProperties.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
		[CallerCount(0)]
		public unsafe AudioMixerProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioMixerProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixerProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002C7A File Offset: 0x00000E7A
		public AudioMixerProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000E7DC File Offset: 0x0000C9DC
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00002C83 File Offset: 0x00000E83
		public unsafe float volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioMixerProperties.NativeFieldInfoPtr_volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioMixerProperties.NativeFieldInfoPtr_volume)) = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000E804 File Offset: 0x0000CA04
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00002C9E File Offset: 0x00000E9E
		public unsafe float stereoPan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioMixerProperties.NativeFieldInfoPtr_stereoPan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioMixerProperties.NativeFieldInfoPtr_stereoPan)) = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000E82C File Offset: 0x0000CA2C
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00002CB9 File Offset: 0x00000EB9
		public unsafe float spatialBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioMixerProperties.NativeFieldInfoPtr_spatialBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioMixerProperties.NativeFieldInfoPtr_spatialBlend)) = value;
			}
		}

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_volume;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_stereoPan;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_spatialBlend;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
