using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace Il2CppKlak.Timeline
{
	// Token: 0x020001EA RID: 490
	[Serializable]
	public class AudioPreviewMixer : PlayableBehaviour
	{
		// Token: 0x06001923 RID: 6435 RVA: 0x00009E79 File Offset: 0x00008079
		// Note: this type is marked as 'beforefieldinit'.
		static AudioPreviewMixer()
		{
			Il2CppClassPointerStore<AudioPreviewMixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Klak.Timeline", "AudioPreviewMixer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPreviewMixer>.NativeClassPtr);
			AudioPreviewMixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreviewMixer>.NativeClassPtr, 100667030);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00071230 File Offset: 0x0006F430
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioPreviewMixer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioPreviewMixer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreviewMixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00009EB2 File Offset: 0x000080B2
		public AudioPreviewMixer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
