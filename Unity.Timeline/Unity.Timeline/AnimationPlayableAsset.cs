using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public class AnimationPlayableAsset : PlayableAsset
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00004DE4 File Offset: 0x00002FE4
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPlayableAsset()
		{
			Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "AnimationPlayableAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr);
			AnimationPlayableAsset.NativeFieldInfoPtr_m_Clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "m_Clip");
			AnimationPlayableAsset.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "m_Position");
			AnimationPlayableAsset.NativeFieldInfoPtr_m_EulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "m_EulerAngles");
			AnimationPlayableAsset.NativeFieldInfoPtr_m_UseTrackMatchFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "m_UseTrackMatchFields");
			AnimationPlayableAsset.NativeFieldInfoPtr_m_MatchTargetFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "m_MatchTargetFields");
			AnimationPlayableAsset.NativeFieldInfoPtr_m_RemoveStartOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "m_RemoveStartOffset");
			AnimationPlayableAsset.NativeFieldInfoPtr_m_ApplyFootIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "m_ApplyFootIK");
			AnimationPlayableAsset.NativeFieldInfoPtr_m_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "m_Loop");
			AnimationPlayableAsset.NativeFieldInfoPtr__appliedOffsetMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "<appliedOffsetMode>k__BackingField");
			AnimationPlayableAsset.NativeFieldInfoPtr_k_LatestVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "k_LatestVersion");
			AnimationPlayableAsset.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "m_Version");
			AnimationPlayableAsset.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "m_Rotation");
			AnimationPlayableAsset.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663318);
			AnimationPlayableAsset.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663319);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663320);
			AnimationPlayableAsset.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663321);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663322);
			AnimationPlayableAsset.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663323);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_useTrackMatchFields_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663324);
			AnimationPlayableAsset.NativeMethodInfoPtr_set_useTrackMatchFields_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663325);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_matchTargetFields_Public_get_MatchTargetFields_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663326);
			AnimationPlayableAsset.NativeMethodInfoPtr_set_matchTargetFields_Public_set_Void_MatchTargetFields_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663327);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_removeStartOffset_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663328);
			AnimationPlayableAsset.NativeMethodInfoPtr_set_removeStartOffset_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663329);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_applyFootIK_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663330);
			AnimationPlayableAsset.NativeMethodInfoPtr_set_applyFootIK_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663331);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_loop_Public_get_LoopMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663332);
			AnimationPlayableAsset.NativeMethodInfoPtr_set_loop_Public_set_Void_LoopMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663333);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_hasRootTransforms_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663334);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_appliedOffsetMode_Internal_get_AppliedOffsetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663335);
			AnimationPlayableAsset.NativeMethodInfoPtr_set_appliedOffsetMode_Internal_set_Void_AppliedOffsetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663336);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_clip_Public_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663337);
			AnimationPlayableAsset.NativeMethodInfoPtr_set_clip_Public_set_Void_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663338);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663339);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663340);
			AnimationPlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663341);
			AnimationPlayableAsset.NativeMethodInfoPtr_CreatePlayable_Internal_Static_Playable_PlayableGraph_AnimationClip_Vector3_Vector3_Boolean_AppliedOffsetMode_Boolean_LoopMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663342);
			AnimationPlayableAsset.NativeMethodInfoPtr_ShouldApplyOffset_Private_Static_Boolean_AppliedOffsetMode_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663343);
			AnimationPlayableAsset.NativeMethodInfoPtr_ShouldApplyScaleRemove_Private_Static_Boolean_AppliedOffsetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663344);
			AnimationPlayableAsset.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663345);
			AnimationPlayableAsset.NativeMethodInfoPtr_ResetOffsets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663346);
			AnimationPlayableAsset.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663347);
			AnimationPlayableAsset.NativeMethodInfoPtr_HasRootTransforms_Internal_Static_Boolean_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663348);
			AnimationPlayableAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663349);
			AnimationPlayableAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663350);
			AnimationPlayableAsset.NativeMethodInfoPtr_OnUpgradeFromVersion_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663351);
			AnimationPlayableAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, 100663352);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000051C0 File Offset: 0x000033C0
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000051FC File Offset: 0x000033FC
		public unsafe Vector3 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000523C File Offset: 0x0000343C
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00005278 File Offset: 0x00003478
		public unsafe Quaternion rotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472517, XrefRangeEnd = 472519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472519, XrefRangeEnd = 472520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000052B8 File Offset: 0x000034B8
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000052F4 File Offset: 0x000034F4
		public unsafe Vector3 eulerAngles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00005334 File Offset: 0x00003534
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00005370 File Offset: 0x00003570
		public unsafe bool useTrackMatchFields
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_useTrackMatchFields_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_set_useTrackMatchFields_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000053B0 File Offset: 0x000035B0
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000053EC File Offset: 0x000035EC
		public unsafe MatchTargetFields matchTargetFields
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_matchTargetFields_Public_get_MatchTargetFields_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_set_matchTargetFields_Public_set_Void_MatchTargetFields_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000542C File Offset: 0x0000362C
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00005468 File Offset: 0x00003668
		public unsafe bool removeStartOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_removeStartOffset_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_set_removeStartOffset_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000054A8 File Offset: 0x000036A8
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000054E4 File Offset: 0x000036E4
		public unsafe bool applyFootIK
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_applyFootIK_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_set_applyFootIK_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00005524 File Offset: 0x00003724
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00005560 File Offset: 0x00003760
		public unsafe AnimationPlayableAsset.LoopMode loop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_loop_Public_get_LoopMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_set_loop_Public_set_Void_LoopMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000055A0 File Offset: 0x000037A0
		public unsafe bool hasRootTransforms
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 472536, RefRangeEnd = 472537, XrefRangeStart = 472520, XrefRangeEnd = 472536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_hasRootTransforms_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000055DC File Offset: 0x000037DC
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00005618 File Offset: 0x00003818
		public unsafe AppliedOffsetMode appliedOffsetMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 93966, RefRangeEnd = 93969, XrefRangeStart = 93966, XrefRangeEnd = 93969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_appliedOffsetMode_Internal_get_AppliedOffsetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_set_appliedOffsetMode_Internal_set_Void_AppliedOffsetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00005658 File Offset: 0x00003858
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00005698 File Offset: 0x00003898
		public unsafe AnimationClip clip
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_clip_Public_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472537, XrefRangeEnd = 472554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_set_clip_Public_set_Void_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000056DC File Offset: 0x000038DC
		public unsafe override double duration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472554, XrefRangeEnd = 472562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationPlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00005724 File Offset: 0x00003924
		public unsafe override IEnumerable<PlayableBinding> outputs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472562, XrefRangeEnd = 472567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationPlayableAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayableBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005770 File Offset: 0x00003970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472567, XrefRangeEnd = 472571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationPlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000057D8 File Offset: 0x000039D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 472630, RefRangeEnd = 472632, XrefRangeStart = 472571, XrefRangeEnd = 472630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, AnimationPlayableAsset.LoopMode loop)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eulerOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeStartOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyFootIK;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_CreatePlayable_Internal_Static_Playable_PlayableGraph_AnimationClip_Vector3_Vector3_Boolean_AppliedOffsetMode_Boolean_LoopMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000587C File Offset: 0x00003A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472632, XrefRangeEnd = 472636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_ShouldApplyOffset_Private_Static_Boolean_AppliedOffsetMode_AnimationClip_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000058CC File Offset: 0x00003ACC
		[CallerCount(0)]
		public unsafe static bool ShouldApplyScaleRemove(AppliedOffsetMode mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_ShouldApplyScaleRemove_Private_Static_Boolean_AppliedOffsetMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000590C File Offset: 0x00003B0C
		public unsafe virtual ClipCaps clipCaps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472636, XrefRangeEnd = 472665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005948 File Offset: 0x00003B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472665, XrefRangeEnd = 472669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOffsets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_ResetOffsets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000597C File Offset: 0x00003B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472669, XrefRangeEnd = 472674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000059D0 File Offset: 0x00003BD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 472696, RefRangeEnd = 472700, XrefRangeStart = 472674, XrefRangeEnd = 472696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasRootTransforms(AnimationClip clip)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_HasRootTransforms_Internal_Static_Boolean_AnimationClip_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005A14 File Offset: 0x00003C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472700, XrefRangeEnd = 472704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005A48 File Offset: 0x00003C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472704, XrefRangeEnd = 472709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005A7C File Offset: 0x00003C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472709, XrefRangeEnd = 472710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUpgradeFromVersion(int oldVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldVersion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr_OnUpgradeFromVersion_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005ABC File Offset: 0x00003CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472710, XrefRangeEnd = 472723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationPlayableAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002158 File Offset: 0x00000358
		public AnimationPlayableAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00005AF8 File Offset: 0x00003CF8
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002161 File Offset: 0x00000361
		public unsafe AnimationClip m_Clip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_Clip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_Clip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00005B28 File Offset: 0x00003D28
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002180 File Offset: 0x00000380
		public unsafe Vector3 m_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00005B50 File Offset: 0x00003D50
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000219B File Offset: 0x0000039B
		public unsafe Vector3 m_EulerAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_EulerAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_EulerAngles)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00005B78 File Offset: 0x00003D78
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000021B6 File Offset: 0x000003B6
		public unsafe bool m_UseTrackMatchFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_UseTrackMatchFields);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_UseTrackMatchFields)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00005BA0 File Offset: 0x00003DA0
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000021D1 File Offset: 0x000003D1
		public unsafe MatchTargetFields m_MatchTargetFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_MatchTargetFields);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_MatchTargetFields)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00005BC8 File Offset: 0x00003DC8
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000021EC File Offset: 0x000003EC
		public unsafe bool m_RemoveStartOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_RemoveStartOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_RemoveStartOffset)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00005BF0 File Offset: 0x00003DF0
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002207 File Offset: 0x00000407
		public unsafe bool m_ApplyFootIK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_ApplyFootIK);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_ApplyFootIK)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00005C18 File Offset: 0x00003E18
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002222 File Offset: 0x00000422
		public unsafe AnimationPlayableAsset.LoopMode m_Loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_Loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_Loop)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00005C40 File Offset: 0x00003E40
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000223D File Offset: 0x0000043D
		public unsafe AppliedOffsetMode _appliedOffsetMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr__appliedOffsetMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr__appliedOffsetMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00005C68 File Offset: 0x00003E68
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002258 File Offset: 0x00000458
		public unsafe static int k_LatestVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AnimationPlayableAsset.NativeFieldInfoPtr_k_LatestVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationPlayableAsset.NativeFieldInfoPtr_k_LatestVersion, (void*)(&value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00005C84 File Offset: 0x00003E84
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002266 File Offset: 0x00000466
		public unsafe int m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00005CAC File Offset: 0x00003EAC
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002281 File Offset: 0x00000481
		public unsafe Quaternion m_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset.NativeFieldInfoPtr_m_Rotation)) = value;
			}
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_m_Clip;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_m_EulerAngles;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_m_UseTrackMatchFields;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_m_MatchTargetFields;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_m_RemoveStartOffset;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_m_ApplyFootIK;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_m_Loop;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr__appliedOffsetMode_k__BackingField;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_k_LatestVersion;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_useTrackMatchFields_Public_get_Boolean_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_set_useTrackMatchFields_Public_set_Void_Boolean_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_get_matchTargetFields_Public_get_MatchTargetFields_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_set_matchTargetFields_Public_set_Void_MatchTargetFields_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_removeStartOffset_Public_get_Boolean_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_set_removeStartOffset_Public_set_Void_Boolean_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_get_applyFootIK_Public_get_Boolean_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_set_applyFootIK_Public_set_Void_Boolean_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_get_loop_Public_get_LoopMode_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_set_loop_Public_set_Void_LoopMode_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_hasRootTransforms_Internal_get_Boolean_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_appliedOffsetMode_Internal_get_AppliedOffsetMode_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_set_appliedOffsetMode_Internal_set_Void_AppliedOffsetMode_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_clip_Public_get_AnimationClip_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_set_clip_Public_set_Void_AnimationClip_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Internal_Static_Playable_PlayableGraph_AnimationClip_Vector3_Vector3_Boolean_AppliedOffsetMode_Boolean_LoopMode_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_ShouldApplyOffset_Private_Static_Boolean_AppliedOffsetMode_AnimationClip_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_ShouldApplyScaleRemove_Private_Static_Boolean_AppliedOffsetMode_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_ResetOffsets_Public_Void_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_HasRootTransforms_Internal_Static_Boolean_AnimationClip_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_OnUpgradeFromVersion_Private_Void_Int32_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000053 RID: 83
		[OriginalName("Unity.Timeline.dll", "", "LoopMode")]
		public enum LoopMode
		{
			// Token: 0x040003FD RID: 1021
			UseSourceAsset,
			// Token: 0x040003FE RID: 1022
			On,
			// Token: 0x040003FF RID: 1023
			Off
		}

		// Token: 0x02000054 RID: 84
		[OriginalName("Unity.Timeline.dll", "", "Versions")]
		public enum Versions
		{
			// Token: 0x04000401 RID: 1025
			Initial,
			// Token: 0x04000402 RID: 1026
			RotationAsEuler
		}

		// Token: 0x02000055 RID: 85
		public static class AnimationPlayableAssetUpgrade : Object
		{
			// Token: 0x0600052B RID: 1323 RVA: 0x00003B3F File Offset: 0x00001D3F
			// Note: this type is marked as 'beforefieldinit'.
			static AnimationPlayableAssetUpgrade()
			{
				Il2CppClassPointerStore<AnimationPlayableAsset.AnimationPlayableAssetUpgrade>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "AnimationPlayableAssetUpgrade");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableAsset.AnimationPlayableAssetUpgrade>.NativeClassPtr);
				AnimationPlayableAsset.AnimationPlayableAssetUpgrade.NativeMethodInfoPtr_ConvertRotationToEuler_Public_Static_Void_AnimationPlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset.AnimationPlayableAssetUpgrade>.NativeClassPtr, 100663354);
			}

			// Token: 0x0600052C RID: 1324 RVA: 0x00018E4C File Offset: 0x0001704C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472501, XrefRangeEnd = 472502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ConvertRotationToEuler(AnimationPlayableAsset asset)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset.AnimationPlayableAssetUpgrade.NativeMethodInfoPtr_ConvertRotationToEuler_Public_Static_Void_AnimationPlayableAsset_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600052D RID: 1325 RVA: 0x00003B73 File Offset: 0x00001D73
			public AnimationPlayableAssetUpgrade(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000403 RID: 1027
			private static readonly IntPtr NativeMethodInfoPtr_ConvertRotationToEuler_Public_Static_Void_AnimationPlayableAsset_0;
		}

		// Token: 0x02000056 RID: 86
		[ObfuscatedName("UnityEngine.Timeline.AnimationPlayableAsset+<get_outputs>d__45")]
		public sealed class _get_outputs_d__45 : Object
		{
			// Token: 0x0600052E RID: 1326 RVA: 0x00018E84 File Offset: 0x00017084
			// Note: this type is marked as 'beforefieldinit'.
			static _get_outputs_d__45()
			{
				Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationPlayableAsset>.NativeClassPtr, "<get_outputs>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr);
				AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, "<>1__state");
				AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, "<>2__current");
				AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, "<>l__initialThreadId");
				AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, "<>4__this");
				AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, 100663355);
				AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, 100663356);
				AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, 100663357);
				AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, 100663358);
				AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, 100663359);
				AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, 100663360);
				AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, 100663361);
				AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr, 100663362);
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x00018FA0 File Offset: 0x000171A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472502, XrefRangeEnd = 472504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_outputs_d__45(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationPlayableAsset._get_outputs_d__45>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x00018FE8 File Offset: 0x000171E8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x0001901C File Offset: 0x0001721C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472504, XrefRangeEnd = 472506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000194 RID: 404
			// (get) Token: 0x06000532 RID: 1330 RVA: 0x00019058 File Offset: 0x00017258
			public unsafe PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new PlayableBinding(intPtr);
				}
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x00019090 File Offset: 0x00017290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472506, XrefRangeEnd = 472511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000195 RID: 405
			// (get) Token: 0x06000534 RID: 1332 RVA: 0x000190C4 File Offset: 0x000172C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472511, XrefRangeEnd = 472514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x00019104 File Offset: 0x00017304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472514, XrefRangeEnd = 472517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayableBinding> System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayableBinding>>(intPtr3) : null;
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x00019144 File Offset: 0x00017344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableAsset._get_outputs_d__45.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000537 RID: 1335 RVA: 0x00003B7C File Offset: 0x00001D7C
			public _get_outputs_d__45(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x06000538 RID: 1336 RVA: 0x00019184 File Offset: 0x00017384
			// (set) Token: 0x06000539 RID: 1337 RVA: 0x00003B85 File Offset: 0x00001D85
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x0600053A RID: 1338 RVA: 0x000191AC File Offset: 0x000173AC
			// (set) Token: 0x0600053B RID: 1339 RVA: 0x00003BA0 File Offset: 0x00001DA0
			public PlayableBinding __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___2__current);
					return new PlayableBinding(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x0600053C RID: 1340 RVA: 0x000191DC File Offset: 0x000173DC
			// (set) Token: 0x0600053D RID: 1341 RVA: 0x00003BCE File Offset: 0x00001DCE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x0600053E RID: 1342 RVA: 0x00019204 File Offset: 0x00017404
			// (set) Token: 0x0600053F RID: 1343 RVA: 0x00003BE9 File Offset: 0x00001DE9
			public unsafe AnimationPlayableAsset __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationPlayableAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlayableAsset._get_outputs_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000404 RID: 1028
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000405 RID: 1029
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000406 RID: 1030
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000407 RID: 1031
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000408 RID: 1032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000409 RID: 1033
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400040A RID: 1034
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400040B RID: 1035
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0;

			// Token: 0x0400040C RID: 1036
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400040D RID: 1037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400040E RID: 1038
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0;

			// Token: 0x0400040F RID: 1039
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
