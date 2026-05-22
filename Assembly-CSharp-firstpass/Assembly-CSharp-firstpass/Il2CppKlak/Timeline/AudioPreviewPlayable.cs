using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Il2CppKlak.Timeline
{
	// Token: 0x020001EB RID: 491
	[Serializable]
	public class AudioPreviewPlayable : PlayableBehaviour
	{
		// Token: 0x06001926 RID: 6438 RVA: 0x0007126C File Offset: 0x0006F46C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioPreviewPlayable()
		{
			Il2CppClassPointerStore<AudioPreviewPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Klak.Timeline", "AudioPreviewPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPreviewPlayable>.NativeClassPtr);
			AudioPreviewPlayable.NativeFieldInfoPtr_clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioPreviewPlayable>.NativeClassPtr, "clip");
			AudioPreviewPlayable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreviewPlayable>.NativeClassPtr, 100667031);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x000712C4 File Offset: 0x0006F4C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioPreviewPlayable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioPreviewPlayable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreviewPlayable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00009EBB File Offset: 0x000080BB
		public AudioPreviewPlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00071300 File Offset: 0x0006F500
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x00009EC4 File Offset: 0x000080C4
		public unsafe AudioClip clip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreviewPlayable.NativeFieldInfoPtr_clip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreviewPlayable.NativeFieldInfoPtr_clip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeFieldInfoPtr_clip;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
