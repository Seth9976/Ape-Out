using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Il2CppKlak.Timeline
{
	// Token: 0x020001EC RID: 492
	public class AudioPreviewTrack : TrackAsset
	{
		// Token: 0x0600192B RID: 6443 RVA: 0x00071330 File Offset: 0x0006F530
		// Note: this type is marked as 'beforefieldinit'.
		static AudioPreviewTrack()
		{
			Il2CppClassPointerStore<AudioPreviewTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Klak.Timeline", "AudioPreviewTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPreviewTrack>.NativeClassPtr);
			AudioPreviewTrack.NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreviewTrack>.NativeClassPtr, 100667032);
			AudioPreviewTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreviewTrack>.NativeClassPtr, 100667033);
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x00071388 File Offset: 0x0006F588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20626, XrefRangeEnd = 20635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioPreviewTrack.NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x000713FC File Offset: 0x0006F5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20635, XrefRangeEnd = 20639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioPreviewTrack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioPreviewTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreviewTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00009EE3 File Offset: 0x000080E3
		public AudioPreviewTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
