using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class AnimationTrack : TrackAsset
	{
		// Token: 0x06000082 RID: 130 RVA: 0x0000605C File Offset: 0x0000425C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationTrack()
		{
			Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "AnimationTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr);
			AnimationTrack.NativeFieldInfoPtr_k_DefaultInfiniteClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "k_DefaultInfiniteClipName");
			AnimationTrack.NativeFieldInfoPtr_k_DefaultRecordableClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "k_DefaultRecordableClipName");
			AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipPreExtrapolation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipPreExtrapolation");
			AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipPostExtrapolation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipPostExtrapolation");
			AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipOffsetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipOffsetPosition");
			AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipOffsetEulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipOffsetEulerAngles");
			AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipTimeOffset");
			AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipRemoveOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipRemoveOffset");
			AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipApplyFootIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipApplyFootIK");
			AnimationTrack.NativeFieldInfoPtr_mInfiniteClipLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "mInfiniteClipLoop");
			AnimationTrack.NativeFieldInfoPtr_m_MatchTargetFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_MatchTargetFields");
			AnimationTrack.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_Position");
			AnimationTrack.NativeFieldInfoPtr_m_EulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_EulerAngles");
			AnimationTrack.NativeFieldInfoPtr_m_AvatarMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_AvatarMask");
			AnimationTrack.NativeFieldInfoPtr_m_ApplyAvatarMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_ApplyAvatarMask");
			AnimationTrack.NativeFieldInfoPtr_m_TrackOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_TrackOffset");
			AnimationTrack.NativeFieldInfoPtr_m_InfiniteClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClip");
			AnimationTrack.NativeFieldInfoPtr_s_CachedQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "s_CachedQueue");
			AnimationTrack.NativeFieldInfoPtr_m_OpenClipOffsetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_OpenClipOffsetRotation");
			AnimationTrack.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_Rotation");
			AnimationTrack.NativeFieldInfoPtr_m_ApplyOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_ApplyOffsets");
			AnimationTrack.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663369);
			AnimationTrack.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663370);
			AnimationTrack.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663371);
			AnimationTrack.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663372);
			AnimationTrack.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663373);
			AnimationTrack.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663374);
			AnimationTrack.NativeMethodInfoPtr_get_applyOffsets_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663375);
			AnimationTrack.NativeMethodInfoPtr_set_applyOffsets_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663376);
			AnimationTrack.NativeMethodInfoPtr_get_trackOffset_Public_get_TrackOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663377);
			AnimationTrack.NativeMethodInfoPtr_set_trackOffset_Public_set_Void_TrackOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663378);
			AnimationTrack.NativeMethodInfoPtr_get_matchTargetFields_Public_get_MatchTargetFields_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663379);
			AnimationTrack.NativeMethodInfoPtr_set_matchTargetFields_Public_set_Void_MatchTargetFields_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663380);
			AnimationTrack.NativeMethodInfoPtr_get_infiniteClip_Public_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663381);
			AnimationTrack.NativeMethodInfoPtr_set_infiniteClip_Internal_set_Void_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663382);
			AnimationTrack.NativeMethodInfoPtr_get_infiniteClipRemoveOffset_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663383);
			AnimationTrack.NativeMethodInfoPtr_set_infiniteClipRemoveOffset_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663384);
			AnimationTrack.NativeMethodInfoPtr_get_avatarMask_Public_get_AvatarMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663385);
			AnimationTrack.NativeMethodInfoPtr_set_avatarMask_Public_set_Void_AvatarMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663386);
			AnimationTrack.NativeMethodInfoPtr_get_applyAvatarMask_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663387);
			AnimationTrack.NativeMethodInfoPtr_set_applyAvatarMask_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663388);
			AnimationTrack.NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663389);
			AnimationTrack.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663390);
			AnimationTrack.NativeMethodInfoPtr_get_inClipMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663391);
			AnimationTrack.NativeMethodInfoPtr_get_infiniteClipOffsetPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663392);
			AnimationTrack.NativeMethodInfoPtr_set_infiniteClipOffsetPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663393);
			AnimationTrack.NativeMethodInfoPtr_get_infiniteClipOffsetRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663394);
			AnimationTrack.NativeMethodInfoPtr_set_infiniteClipOffsetRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663395);
			AnimationTrack.NativeMethodInfoPtr_get_infiniteClipOffsetEulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663396);
			AnimationTrack.NativeMethodInfoPtr_set_infiniteClipOffsetEulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663397);
			AnimationTrack.NativeMethodInfoPtr_get_infiniteClipApplyFootIK_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663398);
			AnimationTrack.NativeMethodInfoPtr_set_infiniteClipApplyFootIK_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663399);
			AnimationTrack.NativeMethodInfoPtr_get_infiniteClipTimeOffset_Internal_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663400);
			AnimationTrack.NativeMethodInfoPtr_set_infiniteClipTimeOffset_Internal_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663401);
			AnimationTrack.NativeMethodInfoPtr_get_infiniteClipPreExtrapolation_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663402);
			AnimationTrack.NativeMethodInfoPtr_set_infiniteClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663403);
			AnimationTrack.NativeMethodInfoPtr_get_infiniteClipPostExtrapolation_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663404);
			AnimationTrack.NativeMethodInfoPtr_set_infiniteClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663405);
			AnimationTrack.NativeMethodInfoPtr_get_infiniteClipLoop_Internal_get_LoopMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663406);
			AnimationTrack.NativeMethodInfoPtr_set_infiniteClipLoop_Internal_set_Void_LoopMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663407);
			AnimationTrack.NativeMethodInfoPtr_ResetOffsets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663408);
			AnimationTrack.NativeMethodInfoPtr_CreateClip_Public_TimelineClip_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663409);
			AnimationTrack.NativeMethodInfoPtr_CreateInfiniteClip_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663410);
			AnimationTrack.NativeMethodInfoPtr_CreateRecordableClip_Public_TimelineClip_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663411);
			AnimationTrack.NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663412);
			AnimationTrack.NativeMethodInfoPtr_CalculateItemsHash_FamOrAssem_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663413);
			AnimationTrack.NativeMethodInfoPtr_UpdateClipOffsets_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663414);
			AnimationTrack.NativeMethodInfoPtr_CompileTrackPlayable_Private_Playable_PlayableGraph_AnimationTrack_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663415);
			AnimationTrack.NativeMethodInfoPtr_UnityEngine_Timeline_ILayerable_CreateLayerMixer_Private_Virtual_Final_New_Playable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663416);
			AnimationTrack.NativeMethodInfoPtr_OnCreateClipPlayableGraph_Internal_Virtual_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663417);
			AnimationTrack.NativeMethodInfoPtr_GetDefaultBlendCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663418);
			AnimationTrack.NativeMethodInfoPtr_AttachDefaultBlend_Private_Void_PlayableGraph_AnimationLayerMixerPlayable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663419);
			AnimationTrack.NativeMethodInfoPtr_AttachOffsetPlayable_Private_Playable_PlayableGraph_Playable_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663420);
			AnimationTrack.NativeMethodInfoPtr_RequiresMotionXPlayable_Private_Boolean_AppliedOffsetMode_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663421);
			AnimationTrack.NativeMethodInfoPtr_UsesAbsoluteMotion_Private_Static_Boolean_AppliedOffsetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663422);
			AnimationTrack.NativeMethodInfoPtr_HasController_Private_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663423);
			AnimationTrack.NativeMethodInfoPtr_GetBinding_Internal_Animator_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663424);
			AnimationTrack.NativeMethodInfoPtr_CreateGroupMixer_Private_Static_AnimationLayerMixerPlayable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663425);
			AnimationTrack.NativeMethodInfoPtr_CreateInfiniteTrackPlayable_Private_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663426);
			AnimationTrack.NativeMethodInfoPtr_ApplyTrackOffset_Private_Playable_PlayableGraph_Playable_GameObject_AppliedOffsetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663427);
			AnimationTrack.NativeMethodInfoPtr_GetEvaluationTime_Internal_Virtual_Void_byref_Double_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663428);
			AnimationTrack.NativeMethodInfoPtr_GetSequenceTime_Internal_Virtual_Void_byref_Double_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663429);
			AnimationTrack.NativeMethodInfoPtr_AssignAnimationClip_Private_Void_TimelineClip_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663430);
			AnimationTrack.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663431);
			AnimationTrack.NativeMethodInfoPtr_GetAnimationClips_Private_Void_List_1_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663432);
			AnimationTrack.NativeMethodInfoPtr_GetOffsetMode_Private_AppliedOffsetMode_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663433);
			AnimationTrack.NativeMethodInfoPtr_IsRootTransformDisabledByMask_Private_Boolean_GameObject_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663434);
			AnimationTrack.NativeMethodInfoPtr_GetGenericRootNode_Private_Transform_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663435);
			AnimationTrack.NativeMethodInfoPtr_AnimatesRootTransform_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663436);
			AnimationTrack.NativeMethodInfoPtr_FindInHierarchyBreadthFirst_Private_Static_Transform_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663437);
			AnimationTrack.NativeMethodInfoPtr_get_openClipOffsetPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663438);
			AnimationTrack.NativeMethodInfoPtr_set_openClipOffsetPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663439);
			AnimationTrack.NativeMethodInfoPtr_get_openClipOffsetRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663440);
			AnimationTrack.NativeMethodInfoPtr_set_openClipOffsetRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663441);
			AnimationTrack.NativeMethodInfoPtr_get_openClipOffsetEulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663442);
			AnimationTrack.NativeMethodInfoPtr_set_openClipOffsetEulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663443);
			AnimationTrack.NativeMethodInfoPtr_get_openClipPreExtrapolation_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663444);
			AnimationTrack.NativeMethodInfoPtr_set_openClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663445);
			AnimationTrack.NativeMethodInfoPtr_get_openClipPostExtrapolation_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663446);
			AnimationTrack.NativeMethodInfoPtr_set_openClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663447);
			AnimationTrack.NativeMethodInfoPtr_OnUpgradeFromVersion_Internal_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663448);
			AnimationTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663449);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00006884 File Offset: 0x00004A84
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000068C0 File Offset: 0x00004AC0
		public unsafe Vector3 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00006900 File Offset: 0x00004B00
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000693C File Offset: 0x00004B3C
		public unsafe Quaternion rotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472806, XrefRangeEnd = 472808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472808, XrefRangeEnd = 472809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000697C File Offset: 0x00004B7C
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000069B8 File Offset: 0x00004BB8
		public unsafe Vector3 eulerAngles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000069F8 File Offset: 0x00004BF8
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00006A34 File Offset: 0x00004C34
		public unsafe bool applyOffsets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_applyOffsets_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_applyOffsets_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00006A74 File Offset: 0x00004C74
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00006AB0 File Offset: 0x00004CB0
		public unsafe TrackOffset trackOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_trackOffset_Public_get_TrackOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_trackOffset_Public_set_Void_TrackOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00006AF0 File Offset: 0x00004CF0
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00006B2C File Offset: 0x00004D2C
		public unsafe MatchTargetFields matchTargetFields
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_matchTargetFields_Public_get_MatchTargetFields_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472809, XrefRangeEnd = 472813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_matchTargetFields_Public_set_Void_MatchTargetFields_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00006B6C File Offset: 0x00004D6C
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00006BAC File Offset: 0x00004DAC
		public unsafe AnimationClip infiniteClip
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_infiniteClip_Public_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 92153, RefRangeEnd = 92154, XrefRangeStart = 92153, XrefRangeEnd = 92154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_infiniteClip_Internal_set_Void_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00006BF0 File Offset: 0x00004DF0
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00006C2C File Offset: 0x00004E2C
		public unsafe bool infiniteClipRemoveOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_infiniteClipRemoveOffset_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_infiniteClipRemoveOffset_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00006C6C File Offset: 0x00004E6C
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00006CAC File Offset: 0x00004EAC
		public unsafe AvatarMask avatarMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_avatarMask_Public_get_AvatarMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarMask>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_avatarMask_Public_set_Void_AvatarMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00006CF0 File Offset: 0x00004EF0
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00006D2C File Offset: 0x00004F2C
		public unsafe bool applyAvatarMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_applyAvatarMask_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_applyAvatarMask_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00006D6C File Offset: 0x00004F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472813, XrefRangeEnd = 472815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanCompileClips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationTrack.NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00006DB4 File Offset: 0x00004FB4
		public unsafe override IEnumerable<PlayableBinding> outputs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472815, XrefRangeEnd = 472820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationTrack.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayableBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00006E00 File Offset: 0x00005000
		public unsafe bool inClipMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 472821, RefRangeEnd = 472823, XrefRangeStart = 472820, XrefRangeEnd = 472821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_inClipMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00006E3C File Offset: 0x0000503C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00006E78 File Offset: 0x00005078
		public unsafe Vector3 infiniteClipOffsetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_infiniteClipOffsetPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_infiniteClipOffsetPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00006EB8 File Offset: 0x000050B8
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00006EF4 File Offset: 0x000050F4
		public unsafe Quaternion infiniteClipOffsetRotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472823, XrefRangeEnd = 472825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_infiniteClipOffsetRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472825, XrefRangeEnd = 472826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_infiniteClipOffsetRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00006F34 File Offset: 0x00005134
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00006F70 File Offset: 0x00005170
		public unsafe Vector3 infiniteClipOffsetEulerAngles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_infiniteClipOffsetEulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_infiniteClipOffsetEulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00006FB0 File Offset: 0x000051B0
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00006FEC File Offset: 0x000051EC
		public unsafe bool infiniteClipApplyFootIK
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_infiniteClipApplyFootIK_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_infiniteClipApplyFootIK_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000702C File Offset: 0x0000522C
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00007068 File Offset: 0x00005268
		public unsafe double infiniteClipTimeOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_infiniteClipTimeOffset_Internal_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_infiniteClipTimeOffset_Internal_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000070A8 File Offset: 0x000052A8
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000070E4 File Offset: 0x000052E4
		public unsafe TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_infiniteClipPreExtrapolation_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_infiniteClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00007124 File Offset: 0x00005324
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00007160 File Offset: 0x00005360
		public unsafe TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_infiniteClipPostExtrapolation_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_infiniteClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000071A0 File Offset: 0x000053A0
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000071DC File Offset: 0x000053DC
		public unsafe AnimationPlayableAsset.LoopMode infiniteClipLoop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_infiniteClipLoop_Internal_get_LoopMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_infiniteClipLoop_Internal_set_Void_LoopMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000721C File Offset: 0x0000541C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472826, XrefRangeEnd = 472830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOffsets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_ResetOffsets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00007250 File Offset: 0x00005450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472830, XrefRangeEnd = 472846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineClip CreateClip(AnimationClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_CreateClip_Public_TimelineClip_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000072A0 File Offset: 0x000054A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472846, XrefRangeEnd = 472870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateInfiniteClip(string infiniteClipName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(infiniteClipName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_CreateInfiniteClip_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000072E4 File Offset: 0x000054E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472870, XrefRangeEnd = 472907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineClip CreateRecordableClip(string animClipName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(animClipName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_CreateRecordableClip_Public_TimelineClip_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00007334 File Offset: 0x00005534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472907, XrefRangeEnd = 472910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCreateClip(TimelineClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationTrack.NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007384 File Offset: 0x00005584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472910, XrefRangeEnd = 472920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CalculateItemsHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationTrack.NativeMethodInfoPtr_CalculateItemsHash_FamOrAssem_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000073CC File Offset: 0x000055CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateClipOffsets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_UpdateClipOffsets_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00007400 File Offset: 0x00005600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472978, RefRangeEnd = 472979, XrefRangeStart = 472920, XrefRangeEnd = 472978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(track);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tree);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_CompileTrackPlayable_Private_Playable_PlayableGraph_AnimationTrack_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00007490 File Offset: 0x00005690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472979, XrefRangeEnd = 472987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Playable UnityEngine_Timeline_ILayerable_CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_UnityEngine_Timeline_ILayerable_CreateLayerMixer_Private_Virtual_Final_New_Playable_PlayableGraph_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000074FC File Offset: 0x000056FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472987, XrefRangeEnd = 473093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tree);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationTrack.NativeMethodInfoPtr_OnCreateClipPlayableGraph_Internal_Virtual_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00007574 File Offset: 0x00005774
		[CallerCount(0)]
		public unsafe int GetDefaultBlendCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_GetDefaultBlendCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000075B0 File Offset: 0x000057B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mixer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requireOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_AttachDefaultBlend_Private_Void_PlayableGraph_AnimationLayerMixerPlayable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000760C File Offset: 0x0000580C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473093, XrefRangeEnd = 473102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_AttachOffsetPlayable_Private_Playable_PlayableGraph_Playable_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00007680 File Offset: 0x00005880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 473104, RefRangeEnd = 473105, XrefRangeStart = 473102, XrefRangeEnd = 473104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_RequiresMotionXPlayable_Private_Boolean_AppliedOffsetMode_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000076DC File Offset: 0x000058DC
		[CallerCount(0)]
		public unsafe static bool UsesAbsoluteMotion(AppliedOffsetMode mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_UsesAbsoluteMotion_Private_Static_Boolean_AppliedOffsetMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000771C File Offset: 0x0000591C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 473146, RefRangeEnd = 473147, XrefRangeStart = 473105, XrefRangeEnd = 473146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasController(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_HasController_Private_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000776C File Offset: 0x0000596C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 473221, RefRangeEnd = 473224, XrefRangeStart = 473147, XrefRangeEnd = 473221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Animator GetBinding(PlayableDirector director)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(director);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_GetBinding_Internal_Animator_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000077BC File Offset: 0x000059BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473224, XrefRangeEnd = 473228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_CreateGroupMixer_Private_Static_AnimationLayerMixerPlayable_PlayableGraph_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000781C File Offset: 0x00005A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 473272, RefRangeEnd = 473273, XrefRangeStart = 473228, XrefRangeEnd = 473272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tree);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_CreateInfiniteTrackPlayable_Private_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00007898 File Offset: 0x00005A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 473285, RefRangeEnd = 473287, XrefRangeStart = 473273, XrefRangeEnd = 473285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref root;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_ApplyTrackOffset_Private_Playable_PlayableGraph_Playable_GameObject_AppliedOffsetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00007910 File Offset: 0x00005B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473287, XrefRangeEnd = 473294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetEvaluationTime(out double outStart, out double outDuration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationTrack.NativeMethodInfoPtr_GetEvaluationTime_Internal_Virtual_Void_byref_Double_byref_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00007968 File Offset: 0x00005B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473294, XrefRangeEnd = 473305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetSequenceTime(out double outStart, out double outDuration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationTrack.NativeMethodInfoPtr_GetSequenceTime_Internal_Virtual_Void_byref_Double_byref_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000079C0 File Offset: 0x00005BC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 473367, RefRangeEnd = 473369, XrefRangeStart = 473305, XrefRangeEnd = 473367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignAnimationClip(TimelineClip clip, AnimationClip animClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(animClip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_AssignAnimationClip_Private_Void_TimelineClip_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00007A14 File Offset: 0x00005C14
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationTrack.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00007A74 File Offset: 0x00005C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 473448, RefRangeEnd = 473449, XrefRangeStart = 473369, XrefRangeEnd = 473448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAnimationClips(List<AnimationClip> animClips)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animClips);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_GetAnimationClips_Private_Void_List_1_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 473450, RefRangeEnd = 473451, XrefRangeStart = 473449, XrefRangeEnd = 473450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animatesRootTransform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_GetOffsetMode_Private_AppliedOffsetMode_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00007B14 File Offset: 0x00005D14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 473533, RefRangeEnd = 473536, XrefRangeStart = 473451, XrefRangeEnd = 473533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericRootNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_IsRootTransformDisabledByMask_Private_Boolean_GameObject_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00007B74 File Offset: 0x00005D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 473588, RefRangeEnd = 473589, XrefRangeStart = 473536, XrefRangeEnd = 473588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetGenericRootNode(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_GetGenericRootNode_Private_Transform_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00007BC4 File Offset: 0x00005DC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 473625, RefRangeEnd = 473630, XrefRangeStart = 473589, XrefRangeEnd = 473625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnimatesRootTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_AnimatesRootTransform_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00007C00 File Offset: 0x00005E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 473659, RefRangeEnd = 473660, XrefRangeStart = 473630, XrefRangeEnd = 473659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindInHierarchyBreadthFirst(Transform t, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_FindInHierarchyBreadthFirst_Private_Static_Transform_Transform_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00007C58 File Offset: 0x00005E58
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00007C94 File Offset: 0x00005E94
		public unsafe Vector3 openClipOffsetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_openClipOffsetPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_openClipOffsetPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00007CD4 File Offset: 0x00005ED4
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00007D10 File Offset: 0x00005F10
		public unsafe Quaternion openClipOffsetRotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_openClipOffsetRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473660, XrefRangeEnd = 473661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_openClipOffsetRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00007D50 File Offset: 0x00005F50
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00007D8C File Offset: 0x00005F8C
		public unsafe Vector3 openClipOffsetEulerAngles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_openClipOffsetEulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_openClipOffsetEulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00007DCC File Offset: 0x00005FCC
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00007E08 File Offset: 0x00006008
		public unsafe TimelineClip.ClipExtrapolation openClipPreExtrapolation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_openClipPreExtrapolation_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_openClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00007E48 File Offset: 0x00006048
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00007E84 File Offset: 0x00006084
		public unsafe TimelineClip.ClipExtrapolation openClipPostExtrapolation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_get_openClipPostExtrapolation_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr_set_openClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00007EC4 File Offset: 0x000060C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473661, XrefRangeEnd = 473669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpgradeFromVersion(int oldVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldVersion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationTrack.NativeMethodInfoPtr_OnUpgradeFromVersion_Internal_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00007F10 File Offset: 0x00006110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473669, XrefRangeEnd = 473698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationTrack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000233B File Offset: 0x0000053B
		public AnimationTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00007F4C File Offset: 0x0000614C
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002344 File Offset: 0x00000544
		public unsafe static string k_DefaultInfiniteClipName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTrack.NativeFieldInfoPtr_k_DefaultInfiniteClipName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTrack.NativeFieldInfoPtr_k_DefaultInfiniteClipName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00007F6C File Offset: 0x0000616C
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002356 File Offset: 0x00000556
		public unsafe static string k_DefaultRecordableClipName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTrack.NativeFieldInfoPtr_k_DefaultRecordableClipName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTrack.NativeFieldInfoPtr_k_DefaultRecordableClipName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00007F8C File Offset: 0x0000618C
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002368 File Offset: 0x00000568
		public unsafe TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipPreExtrapolation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipPreExtrapolation)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00007FB4 File Offset: 0x000061B4
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002383 File Offset: 0x00000583
		public unsafe TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipPostExtrapolation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipPostExtrapolation)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00007FDC File Offset: 0x000061DC
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000239E File Offset: 0x0000059E
		public unsafe Vector3 m_InfiniteClipOffsetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipOffsetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipOffsetPosition)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00008004 File Offset: 0x00006204
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000023B9 File Offset: 0x000005B9
		public unsafe Vector3 m_InfiniteClipOffsetEulerAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipOffsetEulerAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipOffsetEulerAngles)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000802C File Offset: 0x0000622C
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000023D4 File Offset: 0x000005D4
		public unsafe double m_InfiniteClipTimeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipTimeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipTimeOffset)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00008054 File Offset: 0x00006254
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000023EF File Offset: 0x000005EF
		public unsafe bool m_InfiniteClipRemoveOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipRemoveOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipRemoveOffset)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000807C File Offset: 0x0000627C
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000240A File Offset: 0x0000060A
		public unsafe bool m_InfiniteClipApplyFootIK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipApplyFootIK);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClipApplyFootIK)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000080A4 File Offset: 0x000062A4
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002425 File Offset: 0x00000625
		public unsafe AnimationPlayableAsset.LoopMode mInfiniteClipLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_mInfiniteClipLoop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_mInfiniteClipLoop)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000080CC File Offset: 0x000062CC
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002440 File Offset: 0x00000640
		public unsafe MatchTargetFields m_MatchTargetFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_MatchTargetFields);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_MatchTargetFields)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000080F4 File Offset: 0x000062F4
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000245B File Offset: 0x0000065B
		public unsafe Vector3 m_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000811C File Offset: 0x0000631C
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002476 File Offset: 0x00000676
		public unsafe Vector3 m_EulerAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_EulerAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_EulerAngles)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00008144 File Offset: 0x00006344
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002491 File Offset: 0x00000691
		public unsafe AvatarMask m_AvatarMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_AvatarMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMask>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_AvatarMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00008174 File Offset: 0x00006374
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000024B0 File Offset: 0x000006B0
		public unsafe bool m_ApplyAvatarMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_ApplyAvatarMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_ApplyAvatarMask)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000819C File Offset: 0x0000639C
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000024CB File Offset: 0x000006CB
		public unsafe TrackOffset m_TrackOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_TrackOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_TrackOffset)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000081C4 File Offset: 0x000063C4
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000024E6 File Offset: 0x000006E6
		public unsafe AnimationClip m_InfiniteClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_InfiniteClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000081F4 File Offset: 0x000063F4
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002505 File Offset: 0x00000705
		public unsafe static Queue<Transform> s_CachedQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTrack.NativeFieldInfoPtr_s_CachedQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Transform>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTrack.NativeFieldInfoPtr_s_CachedQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000821C File Offset: 0x0000641C
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002517 File Offset: 0x00000717
		public unsafe Quaternion m_OpenClipOffsetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_OpenClipOffsetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_OpenClipOffsetRotation)) = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00008244 File Offset: 0x00006444
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002532 File Offset: 0x00000732
		public unsafe Quaternion m_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_Rotation)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000826C File Offset: 0x0000646C
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000254D File Offset: 0x0000074D
		public unsafe bool m_ApplyOffsets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_ApplyOffsets);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack.NativeFieldInfoPtr_m_ApplyOffsets)) = value;
			}
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultInfiniteClipName;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultRecordableClipName;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_m_InfiniteClipPreExtrapolation;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_m_InfiniteClipPostExtrapolation;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_m_InfiniteClipOffsetPosition;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_m_InfiniteClipOffsetEulerAngles;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_m_InfiniteClipTimeOffset;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_m_InfiniteClipRemoveOffset;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_m_InfiniteClipApplyFootIK;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_mInfiniteClipLoop;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_m_MatchTargetFields;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_m_EulerAngles;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_m_AvatarMask;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_m_ApplyAvatarMask;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_m_TrackOffset;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_m_InfiniteClip;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_s_CachedQueue;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_m_OpenClipOffsetRotation;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_m_ApplyOffsets;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_applyOffsets_Public_get_Boolean_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_set_applyOffsets_Public_set_Void_Boolean_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_trackOffset_Public_get_TrackOffset_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_set_trackOffset_Public_set_Void_TrackOffset_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_get_matchTargetFields_Public_get_MatchTargetFields_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_set_matchTargetFields_Public_set_Void_MatchTargetFields_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_get_infiniteClip_Public_get_AnimationClip_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_set_infiniteClip_Internal_set_Void_AnimationClip_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_get_infiniteClipRemoveOffset_Internal_get_Boolean_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_set_infiniteClipRemoveOffset_Internal_set_Void_Boolean_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_get_avatarMask_Public_get_AvatarMask_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_set_avatarMask_Public_set_Void_AvatarMask_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_get_applyAvatarMask_Public_get_Boolean_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_set_applyAvatarMask_Public_set_Void_Boolean_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_get_inClipMode_Public_get_Boolean_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_get_infiniteClipOffsetPosition_Public_get_Vector3_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_set_infiniteClipOffsetPosition_Public_set_Void_Vector3_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_get_infiniteClipOffsetRotation_Public_get_Quaternion_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_set_infiniteClipOffsetRotation_Public_set_Void_Quaternion_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_infiniteClipOffsetEulerAngles_Public_get_Vector3_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_set_infiniteClipOffsetEulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_get_infiniteClipApplyFootIK_Internal_get_Boolean_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_set_infiniteClipApplyFootIK_Internal_set_Void_Boolean_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_get_infiniteClipTimeOffset_Internal_get_Double_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_set_infiniteClipTimeOffset_Internal_set_Void_Double_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_get_infiniteClipPreExtrapolation_Public_get_ClipExtrapolation_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_set_infiniteClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_get_infiniteClipPostExtrapolation_Public_get_ClipExtrapolation_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_set_infiniteClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_infiniteClipLoop_Internal_get_LoopMode_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_set_infiniteClipLoop_Internal_set_Void_LoopMode_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_ResetOffsets_Private_Void_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_CreateClip_Public_TimelineClip_AnimationClip_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_CreateInfiniteClip_Public_Void_String_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_CreateRecordableClip_Public_TimelineClip_String_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_CalculateItemsHash_FamOrAssem_Virtual_Int32_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClipOffsets_Internal_Void_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_CompileTrackPlayable_Private_Playable_PlayableGraph_AnimationTrack_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ILayerable_CreateLayerMixer_Private_Virtual_Final_New_Playable_PlayableGraph_GameObject_Int32_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_OnCreateClipPlayableGraph_Internal_Virtual_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultBlendCount_Private_Int32_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_AttachDefaultBlend_Private_Void_PlayableGraph_AnimationLayerMixerPlayable_Boolean_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_AttachOffsetPlayable_Private_Playable_PlayableGraph_Playable_Vector3_Quaternion_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_RequiresMotionXPlayable_Private_Boolean_AppliedOffsetMode_GameObject_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_UsesAbsoluteMotion_Private_Static_Boolean_AppliedOffsetMode_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_HasController_Private_Boolean_GameObject_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_GetBinding_Internal_Animator_PlayableDirector_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_CreateGroupMixer_Private_Static_AnimationLayerMixerPlayable_PlayableGraph_GameObject_Int32_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_CreateInfiniteTrackPlayable_Private_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTrackOffset_Private_Playable_PlayableGraph_Playable_GameObject_AppliedOffsetMode_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_GetEvaluationTime_Internal_Virtual_Void_byref_Double_byref_Double_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_GetSequenceTime_Internal_Virtual_Void_byref_Double_byref_Double_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_AssignAnimationClip_Private_Void_TimelineClip_AnimationClip_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationClips_Private_Void_List_1_AnimationClip_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_GetOffsetMode_Private_AppliedOffsetMode_GameObject_Boolean_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_IsRootTransformDisabledByMask_Private_Boolean_GameObject_Transform_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericRootNode_Private_Transform_GameObject_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_AnimatesRootTransform_Internal_Boolean_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_FindInHierarchyBreadthFirst_Private_Static_Transform_Transform_String_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_get_openClipOffsetPosition_Public_get_Vector3_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_set_openClipOffsetPosition_Public_set_Void_Vector3_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_get_openClipOffsetRotation_Public_get_Quaternion_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_set_openClipOffsetRotation_Public_set_Void_Quaternion_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_get_openClipOffsetEulerAngles_Public_get_Vector3_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_set_openClipOffsetEulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_get_openClipPreExtrapolation_Public_get_ClipExtrapolation_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_set_openClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_get_openClipPostExtrapolation_Public_get_ClipExtrapolation_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_set_openClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_OnUpgradeFromVersion_Internal_Virtual_Void_Int32_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000057 RID: 87
		public static class AnimationTrackUpgrade : Object
		{
			// Token: 0x06000540 RID: 1344 RVA: 0x00019234 File Offset: 0x00017434
			// Note: this type is marked as 'beforefieldinit'.
			static AnimationTrackUpgrade()
			{
				Il2CppClassPointerStore<AnimationTrack.AnimationTrackUpgrade>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "AnimationTrackUpgrade");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationTrack.AnimationTrackUpgrade>.NativeClassPtr);
				AnimationTrack.AnimationTrackUpgrade.NativeMethodInfoPtr_ConvertRotationsToEuler_Public_Static_Void_AnimationTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack.AnimationTrackUpgrade>.NativeClassPtr, 100663451);
				AnimationTrack.AnimationTrackUpgrade.NativeMethodInfoPtr_ConvertRootMotion_Public_Static_Void_AnimationTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack.AnimationTrackUpgrade>.NativeClassPtr, 100663452);
				AnimationTrack.AnimationTrackUpgrade.NativeMethodInfoPtr_ConvertInfiniteTrack_Public_Static_Void_AnimationTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack.AnimationTrackUpgrade>.NativeClassPtr, 100663453);
			}

			// Token: 0x06000541 RID: 1345 RVA: 0x0001929C File Offset: 0x0001749C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472789, XrefRangeEnd = 472791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ConvertRotationsToEuler(AnimationTrack track)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.AnimationTrackUpgrade.NativeMethodInfoPtr_ConvertRotationsToEuler_Public_Static_Void_AnimationTrack_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000542 RID: 1346 RVA: 0x000192D4 File Offset: 0x000174D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472791, XrefRangeEnd = 472795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ConvertRootMotion(AnimationTrack track)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.AnimationTrackUpgrade.NativeMethodInfoPtr_ConvertRootMotion_Public_Static_Void_AnimationTrack_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000543 RID: 1347 RVA: 0x0001930C File Offset: 0x0001750C
			[CallerCount(0)]
			public unsafe static void ConvertInfiniteTrack(AnimationTrack track)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack.AnimationTrackUpgrade.NativeMethodInfoPtr_ConvertInfiniteTrack_Public_Static_Void_AnimationTrack_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x00003C08 File Offset: 0x00001E08
			public AnimationTrackUpgrade(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000410 RID: 1040
			private static readonly IntPtr NativeMethodInfoPtr_ConvertRotationsToEuler_Public_Static_Void_AnimationTrack_0;

			// Token: 0x04000411 RID: 1041
			private static readonly IntPtr NativeMethodInfoPtr_ConvertRootMotion_Public_Static_Void_AnimationTrack_0;

			// Token: 0x04000412 RID: 1042
			private static readonly IntPtr NativeMethodInfoPtr_ConvertInfiniteTrack_Public_Static_Void_AnimationTrack_0;
		}

		// Token: 0x02000058 RID: 88
		[ObfuscatedName("UnityEngine.Timeline.AnimationTrack+<get_outputs>d__49")]
		public sealed class _get_outputs_d__49 : Object
		{
			// Token: 0x06000545 RID: 1349 RVA: 0x00019344 File Offset: 0x00017544
			// Note: this type is marked as 'beforefieldinit'.
			static _get_outputs_d__49()
			{
				Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "<get_outputs>d__49");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr);
				AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, "<>1__state");
				AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, "<>2__current");
				AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, "<>l__initialThreadId");
				AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, "<>4__this");
				AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, 100663454);
				AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, 100663455);
				AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, 100663456);
				AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, 100663457);
				AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, 100663458);
				AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, 100663459);
				AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, 100663460);
				AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr, 100663461);
			}

			// Token: 0x06000546 RID: 1350 RVA: 0x00019460 File Offset: 0x00017660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_outputs_d__49(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationTrack._get_outputs_d__49>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000547 RID: 1351 RVA: 0x000194A8 File Offset: 0x000176A8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000548 RID: 1352 RVA: 0x000194DC File Offset: 0x000176DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x06000549 RID: 1353 RVA: 0x00019518 File Offset: 0x00017718
			public unsafe PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new PlayableBinding(intPtr);
				}
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x00019550 File Offset: 0x00017750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472795, XrefRangeEnd = 472800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x0600054B RID: 1355 RVA: 0x00019584 File Offset: 0x00017784
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472800, XrefRangeEnd = 472803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600054C RID: 1356 RVA: 0x000195C4 File Offset: 0x000177C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472803, XrefRangeEnd = 472806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayableBinding> System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayableBinding>>(intPtr3) : null;
			}

			// Token: 0x0600054D RID: 1357 RVA: 0x00019604 File Offset: 0x00017804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTrack._get_outputs_d__49.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600054E RID: 1358 RVA: 0x00003C11 File Offset: 0x00001E11
			public _get_outputs_d__49(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000196 RID: 406
			// (get) Token: 0x0600054F RID: 1359 RVA: 0x00019644 File Offset: 0x00017844
			// (set) Token: 0x06000550 RID: 1360 RVA: 0x00003C1A File Offset: 0x00001E1A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000197 RID: 407
			// (get) Token: 0x06000551 RID: 1361 RVA: 0x0001966C File Offset: 0x0001786C
			// (set) Token: 0x06000552 RID: 1362 RVA: 0x00003C35 File Offset: 0x00001E35
			public PlayableBinding __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___2__current);
					return new PlayableBinding(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x06000553 RID: 1363 RVA: 0x0001969C File Offset: 0x0001789C
			// (set) Token: 0x06000554 RID: 1364 RVA: 0x00003C63 File Offset: 0x00001E63
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x06000555 RID: 1365 RVA: 0x000196C4 File Offset: 0x000178C4
			// (set) Token: 0x06000556 RID: 1366 RVA: 0x00003C7E File Offset: 0x00001E7E
			public unsafe AnimationTrack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTrack._get_outputs_d__49.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000413 RID: 1043
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000414 RID: 1044
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000415 RID: 1045
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000416 RID: 1046
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000417 RID: 1047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000418 RID: 1048
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000419 RID: 1049
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400041A RID: 1050
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0;

			// Token: 0x0400041B RID: 1051
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400041C RID: 1052
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400041D RID: 1053
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0;

			// Token: 0x0400041E RID: 1054
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
