using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Timeline
{
	// Token: 0x02000039 RID: 57
	[Serializable]
	public class PlayableTrack : TrackAsset
	{
		// Token: 0x06000482 RID: 1154 RVA: 0x00016648 File Offset: 0x00014848
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableTrack()
		{
			Il2CppClassPointerStore<PlayableTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "PlayableTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableTrack>.NativeClassPtr);
			PlayableTrack.NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableTrack>.NativeClassPtr, 100664060);
			PlayableTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableTrack>.NativeClassPtr, 100664061);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000166A0 File Offset: 0x000148A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479317, XrefRangeEnd = 479330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCreateClip(TimelineClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableTrack.NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000166F0 File Offset: 0x000148F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479330, XrefRangeEnd = 479334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableTrack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000036CF File Offset: 0x000018CF
		public PlayableTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
