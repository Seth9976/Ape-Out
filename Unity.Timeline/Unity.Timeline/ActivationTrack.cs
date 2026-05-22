using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	public class ActivationTrack : TrackAsset
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000047F4 File Offset: 0x000029F4
		// Note: this type is marked as 'beforefieldinit'.
		static ActivationTrack()
		{
			Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ActivationTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr);
			ActivationTrack.NativeFieldInfoPtr_m_PostPlaybackState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, "m_PostPlaybackState");
			ActivationTrack.NativeFieldInfoPtr_m_ActivationMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, "m_ActivationMixer");
			ActivationTrack.NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663306);
			ActivationTrack.NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663307);
			ActivationTrack.NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663308);
			ActivationTrack.NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663309);
			ActivationTrack.NativeMethodInfoPtr_UpdateTrackMode_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663310);
			ActivationTrack.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663311);
			ActivationTrack.NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663312);
			ActivationTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663313);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000048EC File Offset: 0x00002AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472353, XrefRangeEnd = 472356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanCompileClips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivationTrack.NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00004934 File Offset: 0x00002B34
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00004970 File Offset: 0x00002B70
		public unsafe ActivationTrack.PostPlaybackState postPlaybackState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationTrack.NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationTrack.NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000049B0 File Offset: 0x00002BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472356, XrefRangeEnd = 472372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivationTrack.NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004A24 File Offset: 0x00002C24
		[CallerCount(0)]
		public unsafe void UpdateTrackMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationTrack.NativeMethodInfoPtr_UpdateTrackMode_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004A58 File Offset: 0x00002C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472372, XrefRangeEnd = 472388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(director);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(driver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivationTrack.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472388, XrefRangeEnd = 472390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCreateClip(TimelineClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivationTrack.NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004B08 File Offset: 0x00002D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472390, XrefRangeEnd = 472394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivationTrack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020B7 File Offset: 0x000002B7
		public ActivationTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00004B44 File Offset: 0x00002D44
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000020C0 File Offset: 0x000002C0
		public unsafe ActivationTrack.PostPlaybackState m_PostPlaybackState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationTrack.NativeFieldInfoPtr_m_PostPlaybackState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationTrack.NativeFieldInfoPtr_m_PostPlaybackState)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00004B6C File Offset: 0x00002D6C
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000020DB File Offset: 0x000002DB
		public unsafe ActivationMixerPlayable m_ActivationMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationTrack.NativeFieldInfoPtr_m_ActivationMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivationMixerPlayable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationTrack.NativeFieldInfoPtr_m_ActivationMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_m_PostPlaybackState;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_m_ActivationMixer;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTrackMode_Internal_Void_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000051 RID: 81
		[OriginalName("Unity.Timeline.dll", "", "PostPlaybackState")]
		public enum PostPlaybackState
		{
			// Token: 0x040003F2 RID: 1010
			Active,
			// Token: 0x040003F3 RID: 1011
			Inactive,
			// Token: 0x040003F4 RID: 1012
			Revert,
			// Token: 0x040003F5 RID: 1013
			LeaveAsIs
		}
	}
}
