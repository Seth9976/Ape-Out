using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class TrackAsset : PlayableAsset
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x0000BB50 File Offset: 0x00009D50
		// Note: this type is marked as 'beforefieldinit'.
		static TrackAsset()
		{
			Il2CppClassPointerStore<TrackAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TrackAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr);
			TrackAsset.NativeFieldInfoPtr_k_LatestVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "k_LatestVersion");
			TrackAsset.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_Version");
			TrackAsset.NativeFieldInfoPtr_m_AnimClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_AnimClip");
			TrackAsset.NativeFieldInfoPtr_s_BuildData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "s_BuildData");
			TrackAsset.NativeFieldInfoPtr_kDefaultCurvesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "kDefaultCurvesName");
			TrackAsset.NativeFieldInfoPtr_OnClipPlayableCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "OnClipPlayableCreate");
			TrackAsset.NativeFieldInfoPtr_OnTrackAnimationPlayableCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "OnTrackAnimationPlayableCreate");
			TrackAsset.NativeFieldInfoPtr_m_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_Locked");
			TrackAsset.NativeFieldInfoPtr_m_Muted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_Muted");
			TrackAsset.NativeFieldInfoPtr_m_CustomPlayableFullTypename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_CustomPlayableFullTypename");
			TrackAsset.NativeFieldInfoPtr_m_Curves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_Curves");
			TrackAsset.NativeFieldInfoPtr_m_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_Parent");
			TrackAsset.NativeFieldInfoPtr_m_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_Children");
			TrackAsset.NativeFieldInfoPtr_m_ItemsHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_ItemsHash");
			TrackAsset.NativeFieldInfoPtr_m_ClipsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_ClipsCache");
			TrackAsset.NativeFieldInfoPtr_m_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_Start");
			TrackAsset.NativeFieldInfoPtr_m_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_End");
			TrackAsset.NativeFieldInfoPtr_m_CacheSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_CacheSorted");
			TrackAsset.NativeFieldInfoPtr_m_SupportsNotifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_SupportsNotifications");
			TrackAsset.NativeFieldInfoPtr_s_EmptyCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "s_EmptyCache");
			TrackAsset.NativeFieldInfoPtr_m_ChildTrackCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_ChildTrackCache");
			TrackAsset.NativeFieldInfoPtr_s_TrackBindingTypeAttributeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "s_TrackBindingTypeAttributeCache");
			TrackAsset.NativeFieldInfoPtr_m_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_Clips");
			TrackAsset.NativeFieldInfoPtr_m_Markers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "m_Markers");
			TrackAsset.NativeMethodInfoPtr_OnBeforeTrackSerialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663619);
			TrackAsset.NativeMethodInfoPtr_OnAfterTrackDeserialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663620);
			TrackAsset.NativeMethodInfoPtr_OnUpgradeFromVersion_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663621);
			TrackAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663622);
			TrackAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663623);
			TrackAsset.NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663624);
			TrackAsset.NativeMethodInfoPtr_add_OnClipPlayableCreate_Internal_Static_add_Void_Action_3_TimelineClip_GameObject_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663625);
			TrackAsset.NativeMethodInfoPtr_remove_OnClipPlayableCreate_Internal_Static_rem_Void_Action_3_TimelineClip_GameObject_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663626);
			TrackAsset.NativeMethodInfoPtr_add_OnTrackAnimationPlayableCreate_Internal_Static_add_Void_Action_3_TrackAsset_GameObject_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663627);
			TrackAsset.NativeMethodInfoPtr_remove_OnTrackAnimationPlayableCreate_Internal_Static_rem_Void_Action_3_TrackAsset_GameObject_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663628);
			TrackAsset.NativeMethodInfoPtr_get_start_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663629);
			TrackAsset.NativeMethodInfoPtr_get_end_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663630);
			TrackAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663631);
			TrackAsset.NativeMethodInfoPtr_get_muted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663632);
			TrackAsset.NativeMethodInfoPtr_set_muted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663633);
			TrackAsset.NativeMethodInfoPtr_get_mutedInHierarchy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663634);
			TrackAsset.NativeMethodInfoPtr_get_timelineAsset_Public_get_TimelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663635);
			TrackAsset.NativeMethodInfoPtr_get_parent_Public_get_PlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663636);
			TrackAsset.NativeMethodInfoPtr_set_parent_Internal_set_Void_PlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663637);
			TrackAsset.NativeMethodInfoPtr_GetClips_Public_IEnumerable_1_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663638);
			TrackAsset.NativeMethodInfoPtr_get_clips_Internal_get_Il2CppReferenceArray_1_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663639);
			TrackAsset.NativeMethodInfoPtr_get_isEmpty_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663640);
			TrackAsset.NativeMethodInfoPtr_get_hasClips_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663641);
			TrackAsset.NativeMethodInfoPtr_get_hasCurves_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663642);
			TrackAsset.NativeMethodInfoPtr_get_isSubTrack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663643);
			TrackAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663644);
			TrackAsset.NativeMethodInfoPtr_GetChildTracks_Public_IEnumerable_1_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663645);
			TrackAsset.NativeMethodInfoPtr_get_customPlayableTypename_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663646);
			TrackAsset.NativeMethodInfoPtr_set_customPlayableTypename_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663647);
			TrackAsset.NativeMethodInfoPtr_get_curves_Public_Virtual_Final_New_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663648);
			TrackAsset.NativeMethodInfoPtr_set_curves_Internal_set_Void_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663649);
			TrackAsset.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_defaultCurvesName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663650);
			TrackAsset.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_asset_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663651);
			TrackAsset.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_assetOwner_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663652);
			TrackAsset.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_targetTrack_Private_Virtual_Final_New_get_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663653);
			TrackAsset.NativeMethodInfoPtr_get_subTracksObjects_Internal_get_List_1_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663654);
			TrackAsset.NativeMethodInfoPtr_get_locked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663655);
			TrackAsset.NativeMethodInfoPtr_set_locked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663656);
			TrackAsset.NativeMethodInfoPtr_get_lockedInHierarchy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663657);
			TrackAsset.NativeMethodInfoPtr_get_supportsNotifications_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663658);
			TrackAsset.NativeMethodInfoPtr___internalAwake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663659);
			TrackAsset.NativeMethodInfoPtr_CreateCurves_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663660);
			TrackAsset.NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_New_Playable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663661);
			TrackAsset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Final_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663662);
			TrackAsset.NativeMethodInfoPtr_CreateDefaultClip_Public_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663663);
			TrackAsset.NativeMethodInfoPtr_CreateClip_Public_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663664);
			TrackAsset.NativeMethodInfoPtr_DeleteClip_Public_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663665);
			TrackAsset.NativeMethodInfoPtr_CreateMarker_Public_IMarker_Type_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663666);
			TrackAsset.NativeMethodInfoPtr_CreateMarker_Public_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663667);
			TrackAsset.NativeMethodInfoPtr_DeleteMarker_Public_Boolean_IMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663668);
			TrackAsset.NativeMethodInfoPtr_GetMarkers_Public_IEnumerable_1_IMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663669);
			TrackAsset.NativeMethodInfoPtr_GetMarkerCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663670);
			TrackAsset.NativeMethodInfoPtr_GetMarker_Public_IMarker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663671);
			TrackAsset.NativeMethodInfoPtr_CreateClip_Internal_TimelineClip_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663672);
			TrackAsset.NativeMethodInfoPtr_CreateAndAddNewClipOfType_Internal_TimelineClip_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663673);
			TrackAsset.NativeMethodInfoPtr_CreateClipOfType_Internal_TimelineClip_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663674);
			TrackAsset.NativeMethodInfoPtr_CreateClipFromPlayableAsset_Internal_TimelineClip_IPlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663675);
			TrackAsset.NativeMethodInfoPtr_CreateClipFromAsset_Private_TimelineClip_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663676);
			TrackAsset.NativeMethodInfoPtr_GetMarkersRaw_Internal_IEnumerable_1_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663677);
			TrackAsset.NativeMethodInfoPtr_ClearMarkers_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663678);
			TrackAsset.NativeMethodInfoPtr_AddMarker_Internal_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663679);
			TrackAsset.NativeMethodInfoPtr_DeleteMarkerRaw_Internal_Boolean_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663680);
			TrackAsset.NativeMethodInfoPtr_GetTimeRangeHash_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663681);
			TrackAsset.NativeMethodInfoPtr_AddClip_Internal_Void_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663682);
			TrackAsset.NativeMethodInfoPtr_CreateNotificationsPlayable_Private_Playable_PlayableGraph_Playable_GameObject_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663683);
			TrackAsset.NativeMethodInfoPtr_CreatePlayableGraph_Internal_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663684);
			TrackAsset.NativeMethodInfoPtr_CompileClips_Internal_Virtual_New_Playable_PlayableGraph_GameObject_IList_1_TimelineClip_IntervalTree_1_RuntimeElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663685);
			TrackAsset.NativeMethodInfoPtr_GatherCompilableTracks_Private_Void_IList_1_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663686);
			TrackAsset.NativeMethodInfoPtr_GatherNotificiations_Private_Void_List_1_IMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663687);
			TrackAsset.NativeMethodInfoPtr_OnCreateClipPlayableGraph_Internal_Virtual_New_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663688);
			TrackAsset.NativeMethodInfoPtr_ConfigureTrackAnimation_Internal_Void_IntervalTree_1_RuntimeElement_GameObject_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663689);
			TrackAsset.NativeMethodInfoPtr_SortClips_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663690);
			TrackAsset.NativeMethodInfoPtr_ClearClipsInternal_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663691);
			TrackAsset.NativeMethodInfoPtr_ClearSubTracksInternal_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663692);
			TrackAsset.NativeMethodInfoPtr_OnClipMove_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663693);
			TrackAsset.NativeMethodInfoPtr_CreateNewClipContainerInternal_Internal_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663694);
			TrackAsset.NativeMethodInfoPtr_AddChild_Internal_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663695);
			TrackAsset.NativeMethodInfoPtr_MoveLastTrackBefore_Internal_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663696);
			TrackAsset.NativeMethodInfoPtr_RemoveSubTrack_Internal_Boolean_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663697);
			TrackAsset.NativeMethodInfoPtr_RemoveClip_Internal_Void_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663698);
			TrackAsset.NativeMethodInfoPtr_GetEvaluationTime_Internal_Virtual_New_Void_byref_Double_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663699);
			TrackAsset.NativeMethodInfoPtr_GetSequenceTime_Internal_Virtual_New_Void_byref_Double_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663700);
			TrackAsset.NativeMethodInfoPtr_GatherProperties_Public_Virtual_New_Void_PlayableDirector_IPropertyCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663701);
			TrackAsset.NativeMethodInfoPtr_GetGameObjectBinding_Internal_GameObject_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663702);
			TrackAsset.NativeMethodInfoPtr_ValidateClipType_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663703);
			TrackAsset.NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_New_Void_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663704);
			TrackAsset.NativeMethodInfoPtr_UpdateDuration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663705);
			TrackAsset.NativeMethodInfoPtr_CalculateItemsHash_FamOrAssem_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663706);
			TrackAsset.NativeMethodInfoPtr_CreatePlayable_Protected_Virtual_New_Playable_PlayableGraph_GameObject_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663707);
			TrackAsset.NativeMethodInfoPtr_Invalidate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663708);
			TrackAsset.NativeMethodInfoPtr_GetNotificationDuration_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663709);
			TrackAsset.NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663710);
			TrackAsset.NativeMethodInfoPtr_IsCompilable_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663711);
			TrackAsset.NativeMethodInfoPtr_UpdateChildTrackCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663712);
			TrackAsset.NativeMethodInfoPtr_Hash_Internal_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663713);
			TrackAsset.NativeMethodInfoPtr_GetClipsHash_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663714);
			TrackAsset.NativeMethodInfoPtr_GetAnimationClipHash_Protected_Static_Int32_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663715);
			TrackAsset.NativeMethodInfoPtr_HasNotifications_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663716);
			TrackAsset.NativeMethodInfoPtr_CanCompileNotifications_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663717);
			TrackAsset.NativeMethodInfoPtr_CanCompileClipsRecursive_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663718);
			TrackAsset.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, 100663719);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000C544 File Offset: 0x0000A744
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeTrackSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_OnBeforeTrackSerialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000C580 File Offset: 0x0000A780
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterTrackDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_OnAfterTrackDeserialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpgradeFromVersion(int oldVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldVersion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_OnUpgradeFromVersion_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000C608 File Offset: 0x0000A808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475084, XrefRangeEnd = 475121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000C63C File Offset: 0x0000A83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475121, XrefRangeEnd = 475146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000C670 File Offset: 0x0000A870
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgradeToLatestVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475146, XrefRangeEnd = 475156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_add_OnClipPlayableCreate_Internal_Static_add_Void_Action_3_TimelineClip_GameObject_Playable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000C6DC File Offset: 0x0000A8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475156, XrefRangeEnd = 475166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_remove_OnClipPlayableCreate_Internal_Static_rem_Void_Action_3_TimelineClip_GameObject_Playable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000C714 File Offset: 0x0000A914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475166, XrefRangeEnd = 475176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_add_OnTrackAnimationPlayableCreate_Internal_Static_add_Void_Action_3_TrackAsset_GameObject_Playable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000C74C File Offset: 0x0000A94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475176, XrefRangeEnd = 475186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_remove_OnTrackAnimationPlayableCreate_Internal_Static_rem_Void_Action_3_TrackAsset_GameObject_Playable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000C784 File Offset: 0x0000A984
		public unsafe double start
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475186, XrefRangeEnd = 475194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_start_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
		public unsafe double end
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 475202, RefRangeEnd = 475203, XrefRangeStart = 475194, XrefRangeEnd = 475202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_end_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000C7FC File Offset: 0x0000A9FC
		public unsafe override double duration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475203, XrefRangeEnd = 475211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000C838 File Offset: 0x0000AA38
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0000C874 File Offset: 0x0000AA74
		public unsafe bool muted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_muted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_set_muted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		public unsafe bool mutedInHierarchy
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 475247, RefRangeEnd = 475250, XrefRangeStart = 475211, XrefRangeEnd = 475247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_mutedInHierarchy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
		public unsafe TimelineAsset timelineAsset
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 475297, RefRangeEnd = 475313, XrefRangeStart = 475250, XrefRangeEnd = 475297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_timelineAsset_Public_get_TimelineAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineAsset>(intPtr3) : null;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000C930 File Offset: 0x0000AB30
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000C970 File Offset: 0x0000AB70
		public unsafe PlayableAsset parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_parent_Public_get_PlayableAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_set_parent_Internal_set_Void_PlayableAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000C9B4 File Offset: 0x0000ABB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475313, XrefRangeEnd = 475314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<TimelineClip> GetClips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GetClips_Public_IEnumerable_1_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TimelineClip>>(intPtr3) : null;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000C9F4 File Offset: 0x0000ABF4
		public unsafe Il2CppReferenceArray<TimelineClip> clips
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 475323, RefRangeEnd = 475345, XrefRangeStart = 475314, XrefRangeEnd = 475323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_clips_Internal_get_Il2CppReferenceArray_1_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimelineClip>>(intPtr3) : null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000CA34 File Offset: 0x0000AC34
		public unsafe virtual bool isEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475345, XrefRangeEnd = 475347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_get_isEmpty_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		public unsafe bool hasClips
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475347, XrefRangeEnd = 475348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_hasClips_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
		public unsafe virtual bool hasCurves
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 475362, RefRangeEnd = 475368, XrefRangeStart = 475348, XrefRangeEnd = 475362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_hasCurves_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		public unsafe bool isSubTrack
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 475389, RefRangeEnd = 475397, XrefRangeStart = 475368, XrefRangeEnd = 475389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_isSubTrack_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000CB30 File Offset: 0x0000AD30
		public unsafe override IEnumerable<PlayableBinding> outputs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475397, XrefRangeEnd = 475402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayableBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475402, XrefRangeEnd = 475403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<TrackAsset> GetChildTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GetChildTracks_Public_IEnumerable_1_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TrackAsset>>(intPtr3) : null;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		// (set) Token: 0x060001FF RID: 511 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		public unsafe string customPlayableTypename
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_customPlayableTypename_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_set_customPlayableTypename_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000CC38 File Offset: 0x0000AE38
		// (set) Token: 0x06000201 RID: 513 RVA: 0x0000CC78 File Offset: 0x0000AE78
		public unsafe virtual AnimationClip curves
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_curves_Public_Virtual_Final_New_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_set_curves_Internal_set_Void_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000CCBC File Offset: 0x0000AEBC
		public unsafe virtual string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475403, XrefRangeEnd = 475405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_defaultCurvesName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000CCF4 File Offset: 0x0000AEF4
		public unsafe virtual Object UnityEngine.Timeline.ICurvesOwner.asset
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_asset_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000CD34 File Offset: 0x0000AF34
		public unsafe virtual Object UnityEngine.Timeline.ICurvesOwner.assetOwner
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475405, XrefRangeEnd = 475406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_assetOwner_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000CD74 File Offset: 0x0000AF74
		public unsafe virtual TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_targetTrack_Private_Virtual_Final_New_get_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr3) : null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000CDB4 File Offset: 0x0000AFB4
		public unsafe List<ScriptableObject> subTracksObjects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_subTracksObjects_Internal_get_List_1_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ScriptableObject>>(intPtr3) : null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0000CE30 File Offset: 0x0000B030
		public unsafe bool locked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_locked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_set_locked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000CE70 File Offset: 0x0000B070
		public unsafe bool lockedInHierarchy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 475442, RefRangeEnd = 475443, XrefRangeStart = 475406, XrefRangeEnd = 475442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_lockedInHierarchy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		public unsafe bool supportsNotifications
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 475449, RefRangeEnd = 475453, XrefRangeStart = 475443, XrefRangeEnd = 475449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_get_supportsNotifications_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475453, XrefRangeEnd = 475465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __internalAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr___internalAwake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000CF1C File Offset: 0x0000B11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475465, XrefRangeEnd = 475480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateCurves(string curvesClipName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(curvesClipName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreateCurves_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000CF60 File Offset: 0x0000B160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475480, XrefRangeEnd = 475484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_New_Playable_PlayableGraph_GameObject_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475484, XrefRangeEnd = 475492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Final_Playable_PlayableGraph_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000D030 File Offset: 0x0000B230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 475519, RefRangeEnd = 475520, XrefRangeStart = 475492, XrefRangeEnd = 475519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineClip CreateDefaultClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreateDefaultClip_Public_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000D070 File Offset: 0x0000B270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 475527, RefRangeEnd = 475529, XrefRangeStart = 475520, XrefRangeEnd = 475527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineClip CreateClip<T>() where T : ScriptableObject
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.MethodInfoStoreGeneric_CreateClip_Public_TimelineClip_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475529, XrefRangeEnd = 475547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteClip(TimelineClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_DeleteClip_Public_Boolean_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000D100 File Offset: 0x0000B300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475547, XrefRangeEnd = 475548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMarker CreateMarker(Type type, double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreateMarker_Public_IMarker_Type_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMarker>(intPtr3) : null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000D160 File Offset: 0x0000B360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475548, XrefRangeEnd = 475555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CreateMarker<T>(double time) where T : ScriptableObject
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.MethodInfoStoreGeneric_CreateMarker_Public_T_Double_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475555, XrefRangeEnd = 475556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteMarker(IMarker marker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(marker);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_DeleteMarker_Public_Boolean_IMarker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000D1F8 File Offset: 0x0000B3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475556, XrefRangeEnd = 475557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IMarker> GetMarkers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GetMarkers_Public_IEnumerable_1_IMarker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IMarker>>(intPtr3) : null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000D238 File Offset: 0x0000B438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475557, XrefRangeEnd = 475559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMarkerCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GetMarkerCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000D274 File Offset: 0x0000B474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475559, XrefRangeEnd = 475560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMarker GetMarker(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GetMarker_Public_IMarker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMarker>(intPtr3) : null;
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475560, XrefRangeEnd = 475563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineClip CreateClip(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreateClip_Internal_TimelineClip_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000D310 File Offset: 0x0000B510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475563, XrefRangeEnd = 475565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineClip CreateAndAddNewClipOfType(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreateAndAddNewClipOfType_Internal_TimelineClip_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000D360 File Offset: 0x0000B560
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 475612, RefRangeEnd = 475616, XrefRangeStart = 475565, XrefRangeEnd = 475612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineClip CreateClipOfType(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreateClipOfType_Internal_TimelineClip_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475616, XrefRangeEnd = 475667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreateClipFromPlayableAsset_Internal_TimelineClip_IPlayableAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000D400 File Offset: 0x0000B600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 475688, RefRangeEnd = 475690, XrefRangeStart = 475667, XrefRangeEnd = 475688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineClip CreateClipFromAsset(ScriptableObject playableAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playableAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreateClipFromAsset_Private_TimelineClip_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000D450 File Offset: 0x0000B650
		[CallerCount(0)]
		public unsafe IEnumerable<ScriptableObject> GetMarkersRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GetMarkersRaw_Internal_IEnumerable_1_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ScriptableObject>>(intPtr3) : null;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000D490 File Offset: 0x0000B690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475690, XrefRangeEnd = 475691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearMarkers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_ClearMarkers_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475691, XrefRangeEnd = 475692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMarker(ScriptableObject e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_AddMarker_Internal_Void_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000D508 File Offset: 0x0000B708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475692, XrefRangeEnd = 475694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteMarkerRaw(ScriptableObject marker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(marker);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_DeleteMarkerRaw_Internal_Boolean_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000D558 File Offset: 0x0000B758
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 475724, RefRangeEnd = 475726, XrefRangeStart = 475694, XrefRangeEnd = 475724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTimeRangeHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GetTimeRangeHash_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000D594 File Offset: 0x0000B794
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 475732, RefRangeEnd = 475737, XrefRangeStart = 475726, XrefRangeEnd = 475732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClip(TimelineClip newClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newClip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_AddClip_Internal_Void_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 475795, RefRangeEnd = 475796, XrefRangeStart = 475737, XrefRangeEnd = 475795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mixerPlayable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timelinePlayable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreateNotificationsPlayable_Private_Playable_PlayableGraph_Playable_GameObject_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000D650 File Offset: 0x0000B850
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 475841, RefRangeEnd = 475843, XrefRangeStart = 475796, XrefRangeEnd = 475841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timelinePlayable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreatePlayableGraph_Internal_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000D6CC File Offset: 0x0000B8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475843, XrefRangeEnd = 475876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(timelineClips);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tree);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_CompileClips_Internal_Virtual_New_Playable_PlayableGraph_GameObject_IList_1_TimelineClip_IntervalTree_1_RuntimeElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000D758 File Offset: 0x0000B958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 475907, RefRangeEnd = 475909, XrefRangeStart = 475876, XrefRangeEnd = 475907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GatherCompilableTracks(IList<TrackAsset> tracks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tracks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GatherCompilableTracks_Private_Void_IList_1_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000D79C File Offset: 0x0000B99C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 475942, RefRangeEnd = 475944, XrefRangeStart = 475909, XrefRangeEnd = 475942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GatherNotificiations(List<IMarker> markers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(markers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GatherNotificiations_Private_Void_List_1_IMarker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475944, XrefRangeEnd = 476005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_OnCreateClipPlayableGraph_Internal_Virtual_New_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000D858 File Offset: 0x0000BA58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476023, RefRangeEnd = 476025, XrefRangeStart = 476005, XrefRangeEnd = 476023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_ConfigureTrackAnimation_Internal_Void_IntervalTree_1_RuntimeElement_GameObject_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000D8BC File Offset: 0x0000BABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476042, RefRangeEnd = 476043, XrefRangeStart = 476025, XrefRangeEnd = 476042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortClips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_SortClips_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476043, XrefRangeEnd = 476049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClipsInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_ClearClipsInternal_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000D924 File Offset: 0x0000BB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476049, XrefRangeEnd = 476056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSubTracksInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_ClearSubTracksInternal_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000D958 File Offset: 0x0000BB58
		[CallerCount(0)]
		public unsafe void OnClipMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_OnClipMove_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000D98C File Offset: 0x0000BB8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476082, RefRangeEnd = 476083, XrefRangeStart = 476056, XrefRangeEnd = 476082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineClip CreateNewClipContainerInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CreateNewClipContainerInternal_Internal_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000D9CC File Offset: 0x0000BBCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476099, RefRangeEnd = 476101, XrefRangeStart = 476083, XrefRangeEnd = 476099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(TrackAsset child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_AddChild_Internal_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000DA10 File Offset: 0x0000BC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476101, XrefRangeEnd = 476148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveLastTrackBefore(TrackAsset asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_MoveLastTrackBefore_Internal_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000DA54 File Offset: 0x0000BC54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476151, RefRangeEnd = 476153, XrefRangeStart = 476148, XrefRangeEnd = 476151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveSubTrack(TrackAsset child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_RemoveSubTrack_Internal_Boolean_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000DAA4 File Offset: 0x0000BCA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476155, RefRangeEnd = 476156, XrefRangeStart = 476153, XrefRangeEnd = 476155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveClip(TimelineClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_RemoveClip_Internal_Void_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476179, RefRangeEnd = 476180, XrefRangeStart = 476156, XrefRangeEnd = 476179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetEvaluationTime(out double outStart, out double outDuration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_GetEvaluationTime_Internal_Virtual_New_Void_byref_Double_byref_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000DB40 File Offset: 0x0000BD40
		[CallerCount(0)]
		public unsafe virtual void GetSequenceTime(out double outStart, out double outDuration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_GetSequenceTime_Internal_Virtual_New_Void_byref_Double_byref_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000DB98 File Offset: 0x0000BD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476180, XrefRangeEnd = 476268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_GatherProperties_Public_Virtual_New_Void_PlayableDirector_IPropertyCollector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476298, RefRangeEnd = 476300, XrefRangeStart = 476268, XrefRangeEnd = 476298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetGameObjectBinding(PlayableDirector director)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(director);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GetGameObjectBinding_Internal_GameObject_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000DC48 File Offset: 0x0000BE48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 476313, RefRangeEnd = 476317, XrefRangeStart = 476300, XrefRangeEnd = 476313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateClipType(Type clipType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clipType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_ValidateClipType_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCreateClip(TimelineClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_New_Void_TimelineClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000DCE8 File Offset: 0x0000BEE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 476333, RefRangeEnd = 476337, XrefRangeStart = 476317, XrefRangeEnd = 476333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_UpdateDuration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000DD1C File Offset: 0x0000BF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476337, XrefRangeEnd = 476343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CalculateItemsHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_CalculateItemsHash_FamOrAssem_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000DD64 File Offset: 0x0000BF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476343, XrefRangeEnd = 476378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_CreatePlayable_Protected_Virtual_New_Playable_PlayableGraph_GameObject_TimelineClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000DDDC File Offset: 0x0000BFDC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 476392, RefRangeEnd = 476397, XrefRangeStart = 476378, XrefRangeEnd = 476392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invalidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_Invalidate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000DE10 File Offset: 0x0000C010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476424, RefRangeEnd = 476426, XrefRangeStart = 476397, XrefRangeEnd = 476424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetNotificationDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GetNotificationDuration_Internal_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000DE4C File Offset: 0x0000C04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476426, XrefRangeEnd = 476427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanCompileClips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000DE94 File Offset: 0x0000C094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476440, RefRangeEnd = 476442, XrefRangeStart = 476427, XrefRangeEnd = 476440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCompilable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_IsCompilable_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000DED0 File Offset: 0x0000C0D0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 476474, RefRangeEnd = 476483, XrefRangeStart = 476442, XrefRangeEnd = 476474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChildTrackCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_UpdateChildTrackCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000DF04 File Offset: 0x0000C104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476483, XrefRangeEnd = 476486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Hash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackAsset.NativeMethodInfoPtr_Hash_Internal_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000DF4C File Offset: 0x0000C14C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476498, RefRangeEnd = 476500, XrefRangeStart = 476486, XrefRangeEnd = 476498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetClipsHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GetClipsHash_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000DF88 File Offset: 0x0000C188
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 476518, RefRangeEnd = 476521, XrefRangeStart = 476500, XrefRangeEnd = 476518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAnimationClipHash(AnimationClip clip)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_GetAnimationClipHash_Protected_Static_Int32_AnimationClip_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000DFCC File Offset: 0x0000C1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476521, XrefRangeEnd = 476522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_HasNotifications_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000E008 File Offset: 0x0000C208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476522, XrefRangeEnd = 476523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCompileNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CanCompileNotifications_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000E044 File Offset: 0x0000C244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476539, RefRangeEnd = 476541, XrefRangeStart = 476523, XrefRangeEnd = 476539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCompileClipsRecursive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr_CanCompileClipsRecursive_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000E080 File Offset: 0x0000C280
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 476551, RefRangeEnd = 476560, XrefRangeStart = 476541, XrefRangeEnd = 476551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002999 File Offset: 0x00000B99
		public TrackAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000E0BC File Offset: 0x0000C2BC
		// (set) Token: 0x0600024A RID: 586 RVA: 0x000029A2 File Offset: 0x00000BA2
		public unsafe static int k_LatestVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TrackAsset.NativeFieldInfoPtr_k_LatestVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackAsset.NativeFieldInfoPtr_k_LatestVersion, (void*)(&value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000E0D8 File Offset: 0x0000C2D8
		// (set) Token: 0x0600024C RID: 588 RVA: 0x000029B0 File Offset: 0x00000BB0
		public unsafe int m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000E100 File Offset: 0x0000C300
		// (set) Token: 0x0600024E RID: 590 RVA: 0x000029CB File Offset: 0x00000BCB
		public unsafe AnimationClip m_AnimClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_AnimClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_AnimClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000E130 File Offset: 0x0000C330
		// (set) Token: 0x06000250 RID: 592 RVA: 0x000029EA File Offset: 0x00000BEA
		public unsafe static TrackAsset.TransientBuildData s_BuildData
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TrackAsset.TransientBuildData>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TrackAsset.NativeFieldInfoPtr_s_BuildData, intPtr);
				return new TrackAsset.TransientBuildData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrackAsset.TransientBuildData>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackAsset.NativeFieldInfoPtr_s_BuildData, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000E16C File Offset: 0x0000C36C
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002A01 File Offset: 0x00000C01
		public unsafe static string kDefaultCurvesName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackAsset.NativeFieldInfoPtr_kDefaultCurvesName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackAsset.NativeFieldInfoPtr_kDefaultCurvesName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000E18C File Offset: 0x0000C38C
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00002A13 File Offset: 0x00000C13
		public unsafe static Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackAsset.NativeFieldInfoPtr_OnClipPlayableCreate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TimelineClip, GameObject, Playable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackAsset.NativeFieldInfoPtr_OnClipPlayableCreate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002A25 File Offset: 0x00000C25
		public unsafe static Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackAsset.NativeFieldInfoPtr_OnTrackAnimationPlayableCreate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TrackAsset, GameObject, Playable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackAsset.NativeFieldInfoPtr_OnTrackAnimationPlayableCreate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000E1DC File Offset: 0x0000C3DC
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002A37 File Offset: 0x00000C37
		public unsafe bool m_Locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Locked)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000E204 File Offset: 0x0000C404
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00002A52 File Offset: 0x00000C52
		public unsafe bool m_Muted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Muted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Muted)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000E22C File Offset: 0x0000C42C
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00002A6D File Offset: 0x00000C6D
		public unsafe string m_CustomPlayableFullTypename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_CustomPlayableFullTypename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_CustomPlayableFullTypename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000E254 File Offset: 0x0000C454
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00002A8C File Offset: 0x00000C8C
		public unsafe AnimationClip m_Curves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Curves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Curves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000E284 File Offset: 0x0000C484
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00002AAB File Offset: 0x00000CAB
		public unsafe PlayableAsset m_Parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00002ACA File Offset: 0x00000CCA
		public unsafe List<ScriptableObject> m_Children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScriptableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000E2E4 File Offset: 0x0000C4E4
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00002AE9 File Offset: 0x00000CE9
		public unsafe int m_ItemsHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_ItemsHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_ItemsHash)) = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000E30C File Offset: 0x0000C50C
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00002B04 File Offset: 0x00000D04
		public unsafe Il2CppReferenceArray<TimelineClip> m_ClipsCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_ClipsCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimelineClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_ClipsCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000E33C File Offset: 0x0000C53C
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00002B23 File Offset: 0x00000D23
		public unsafe DiscreteTime m_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Start)) = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000E364 File Offset: 0x0000C564
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002B3E File Offset: 0x00000D3E
		public unsafe DiscreteTime m_End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_End);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_End)) = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000E38C File Offset: 0x0000C58C
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002B59 File Offset: 0x00000D59
		public unsafe bool m_CacheSorted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_CacheSorted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_CacheSorted)) = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00002B74 File Offset: 0x00000D74
		public Nullable<bool> m_SupportsNotifications
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_SupportsNotifications);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_SupportsNotifications), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000E3E4 File Offset: 0x0000C5E4
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002BA2 File Offset: 0x00000DA2
		public unsafe static Il2CppReferenceArray<TrackAsset> s_EmptyCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackAsset.NativeFieldInfoPtr_s_EmptyCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrackAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackAsset.NativeFieldInfoPtr_s_EmptyCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000E40C File Offset: 0x0000C60C
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00002BB4 File Offset: 0x00000DB4
		public unsafe IEnumerable<TrackAsset> m_ChildTrackCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_ChildTrackCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TrackAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_ChildTrackCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000E43C File Offset: 0x0000C63C
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002BD3 File Offset: 0x00000DD3
		public unsafe static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackAsset.NativeFieldInfoPtr_s_TrackBindingTypeAttributeCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, TrackBindingTypeAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackAsset.NativeFieldInfoPtr_s_TrackBindingTypeAttributeCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000E464 File Offset: 0x0000C664
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002BE5 File Offset: 0x00000DE5
		public unsafe List<TimelineClip> m_Clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TimelineClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000E494 File Offset: 0x0000C694
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00002C04 File Offset: 0x00000E04
		public MarkerList m_Markers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Markers);
				return new MarkerList(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.NativeFieldInfoPtr_m_Markers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_k_LatestVersion;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimClip;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_s_BuildData;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultCurvesName;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_OnClipPlayableCreate;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_OnTrackAnimationPlayableCreate;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_m_Locked;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_m_Muted;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomPlayableFullTypename;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_m_Curves;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_m_Parent;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_m_Children;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemsHash;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipsCache;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_m_Start;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_m_End;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheSorted;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeFieldInfoPtr_m_SupportsNotifications;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyCache;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildTrackCache;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr_s_TrackBindingTypeAttributeCache;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeFieldInfoPtr_m_Clips;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeFieldInfoPtr_m_Markers;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeTrackSerialize_Protected_Virtual_New_Void_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterTrackDeserialize_Protected_Virtual_New_Void_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_OnUpgradeFromVersion_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_add_OnClipPlayableCreate_Internal_Static_add_Void_Action_3_TimelineClip_GameObject_Playable_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnClipPlayableCreate_Internal_Static_rem_Void_Action_3_TimelineClip_GameObject_Playable_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_add_OnTrackAnimationPlayableCreate_Internal_Static_add_Void_Action_3_TrackAsset_GameObject_Playable_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnTrackAnimationPlayableCreate_Internal_Static_rem_Void_Action_3_TrackAsset_GameObject_Playable_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_get_start_Public_get_Double_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_get_end_Public_get_Double_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_Final_get_Double_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_get_muted_Public_get_Boolean_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_set_muted_Public_set_Void_Boolean_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_get_mutedInHierarchy_Public_get_Boolean_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_get_timelineAsset_Public_get_TimelineAsset_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_get_parent_Public_get_PlayableAsset_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_set_parent_Internal_set_Void_PlayableAsset_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_GetClips_Public_IEnumerable_1_TimelineClip_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_get_clips_Internal_get_Il2CppReferenceArray_1_TimelineClip_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_get_isEmpty_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_get_hasClips_Public_get_Boolean_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_get_hasCurves_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_get_isSubTrack_Public_get_Boolean_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_GetChildTracks_Public_IEnumerable_1_TrackAsset_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_get_customPlayableTypename_Internal_get_String_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_set_customPlayableTypename_Internal_set_Void_String_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_get_curves_Public_Virtual_Final_New_get_AnimationClip_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_set_curves_Internal_set_Void_AnimationClip_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_defaultCurvesName_Private_Virtual_Final_New_get_String_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_asset_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_assetOwner_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_targetTrack_Private_Virtual_Final_New_get_TrackAsset_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_get_subTracksObjects_Internal_get_List_1_ScriptableObject_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_get_locked_Public_get_Boolean_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_set_locked_Public_set_Void_Boolean_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_get_lockedInHierarchy_Public_get_Boolean_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsNotifications_Public_get_Boolean_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr___internalAwake_Private_Void_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_CreateCurves_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_New_Playable_PlayableGraph_GameObject_Int32_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Final_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultClip_Public_TimelineClip_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_CreateClip_Public_TimelineClip_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_DeleteClip_Public_Boolean_TimelineClip_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarker_Public_IMarker_Type_Double_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarker_Public_T_Double_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_DeleteMarker_Public_Boolean_IMarker_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkers_Public_IEnumerable_1_IMarker_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkerCount_Public_Int32_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_GetMarker_Public_IMarker_Int32_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_CreateClip_Internal_TimelineClip_Type_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_CreateAndAddNewClipOfType_Internal_TimelineClip_Type_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_CreateClipOfType_Internal_TimelineClip_Type_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_CreateClipFromPlayableAsset_Internal_TimelineClip_IPlayableAsset_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_CreateClipFromAsset_Private_TimelineClip_ScriptableObject_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkersRaw_Internal_IEnumerable_1_ScriptableObject_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_ClearMarkers_Internal_Void_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_AddMarker_Internal_Void_ScriptableObject_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_DeleteMarkerRaw_Internal_Boolean_ScriptableObject_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeRangeHash_Private_Int32_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_AddClip_Internal_Void_TimelineClip_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_CreateNotificationsPlayable_Private_Playable_PlayableGraph_Playable_GameObject_Playable_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayableGraph_Internal_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_Playable_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_CompileClips_Internal_Virtual_New_Playable_PlayableGraph_GameObject_IList_1_TimelineClip_IntervalTree_1_RuntimeElement_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_GatherCompilableTracks_Private_Void_IList_1_TrackAsset_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_GatherNotificiations_Private_Void_List_1_IMarker_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_OnCreateClipPlayableGraph_Internal_Virtual_New_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTrackAnimation_Internal_Void_IntervalTree_1_RuntimeElement_GameObject_Playable_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_SortClips_Internal_Void_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_ClearClipsInternal_Internal_Void_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_ClearSubTracksInternal_Internal_Void_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_OnClipMove_Internal_Void_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewClipContainerInternal_Internal_TimelineClip_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Internal_Void_TrackAsset_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_MoveLastTrackBefore_Internal_Void_TrackAsset_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSubTrack_Internal_Boolean_TrackAsset_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_RemoveClip_Internal_Void_TimelineClip_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_GetEvaluationTime_Internal_Virtual_New_Void_byref_Double_byref_Double_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_GetSequenceTime_Internal_Virtual_New_Void_byref_Double_byref_Double_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_GatherProperties_Public_Virtual_New_Void_PlayableDirector_IPropertyCollector_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_GetGameObjectBinding_Internal_GameObject_PlayableDirector_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_ValidateClipType_Internal_Boolean_Type_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_New_Void_TimelineClip_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDuration_Private_Void_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_CalculateItemsHash_FamOrAssem_Virtual_New_Int32_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Protected_Virtual_New_Playable_PlayableGraph_GameObject_TimelineClip_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_Invalidate_Internal_Void_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_GetNotificationDuration_Internal_Double_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_New_Boolean_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_IsCompilable_Internal_Boolean_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChildTrackCache_Private_Void_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_Hash_Internal_Virtual_New_Int32_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_GetClipsHash_Private_Int32_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationClipHash_Protected_Static_Int32_AnimationClip_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_HasNotifications_Private_Boolean_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_CanCompileNotifications_Private_Boolean_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_CanCompileClipsRecursive_Private_Boolean_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000066 RID: 102
		[OriginalName("Unity.Timeline.dll", "", "Versions")]
		public enum Versions
		{
			// Token: 0x04000457 RID: 1111
			Initial,
			// Token: 0x04000458 RID: 1112
			RotationAsEuler,
			// Token: 0x04000459 RID: 1113
			RootMotionUpgrade,
			// Token: 0x0400045A RID: 1114
			AnimatedTrackProperties
		}

		// Token: 0x02000067 RID: 103
		public static class TrackAssetUpgrade : Object
		{
			// Token: 0x06000588 RID: 1416 RVA: 0x00003E36 File Offset: 0x00002036
			// Note: this type is marked as 'beforefieldinit'.
			static TrackAssetUpgrade()
			{
				Il2CppClassPointerStore<TrackAsset.TrackAssetUpgrade>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "TrackAssetUpgrade");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackAsset.TrackAssetUpgrade>.NativeClassPtr);
			}

			// Token: 0x06000589 RID: 1417 RVA: 0x00003E56 File Offset: 0x00002056
			public TrackAssetUpgrade(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x02000068 RID: 104
		public sealed class TransientBuildData : ValueType
		{
			// Token: 0x0600058A RID: 1418 RVA: 0x00019FBC File Offset: 0x000181BC
			// Note: this type is marked as 'beforefieldinit'.
			static TransientBuildData()
			{
				Il2CppClassPointerStore<TrackAsset.TransientBuildData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "TransientBuildData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackAsset.TransientBuildData>.NativeClassPtr);
				TrackAsset.TransientBuildData.NativeFieldInfoPtr_trackList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset.TransientBuildData>.NativeClassPtr, "trackList");
				TrackAsset.TransientBuildData.NativeFieldInfoPtr_clipList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset.TransientBuildData>.NativeClassPtr, "clipList");
				TrackAsset.TransientBuildData.NativeFieldInfoPtr_markerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset.TransientBuildData>.NativeClassPtr, "markerList");
				TrackAsset.TransientBuildData.NativeMethodInfoPtr_Create_Public_Static_TransientBuildData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset.TransientBuildData>.NativeClassPtr, 100663721);
				TrackAsset.TransientBuildData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset.TransientBuildData>.NativeClassPtr, 100663722);
			}

			// Token: 0x0600058B RID: 1419 RVA: 0x0001A04C File Offset: 0x0001824C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475012, XrefRangeEnd = 475036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TrackAsset.TransientBuildData Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.TransientBuildData.NativeMethodInfoPtr_Create_Public_Static_TransientBuildData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TrackAsset.TransientBuildData(intPtr);
			}

			// Token: 0x0600058C RID: 1420 RVA: 0x0001A078 File Offset: 0x00018278
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 475042, RefRangeEnd = 475044, XrefRangeStart = 475036, XrefRangeEnd = 475042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.TransientBuildData.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600058D RID: 1421 RVA: 0x00003E5F File Offset: 0x0000205F
			public TransientBuildData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600058E RID: 1422 RVA: 0x00003E68 File Offset: 0x00002068
			public TransientBuildData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackAsset.TransientBuildData>.NativeClassPtr))
			{
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x0600058F RID: 1423 RVA: 0x0001A0B0 File Offset: 0x000182B0
			// (set) Token: 0x06000590 RID: 1424 RVA: 0x00003E7A File Offset: 0x0000207A
			public unsafe List<TrackAsset> trackList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.TransientBuildData.NativeFieldInfoPtr_trackList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrackAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.TransientBuildData.NativeFieldInfoPtr_trackList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x06000591 RID: 1425 RVA: 0x0001A0E0 File Offset: 0x000182E0
			// (set) Token: 0x06000592 RID: 1426 RVA: 0x00003E99 File Offset: 0x00002099
			public unsafe List<TimelineClip> clipList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.TransientBuildData.NativeFieldInfoPtr_clipList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TimelineClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.TransientBuildData.NativeFieldInfoPtr_clipList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x06000593 RID: 1427 RVA: 0x0001A110 File Offset: 0x00018310
			// (set) Token: 0x06000594 RID: 1428 RVA: 0x00003EB8 File Offset: 0x000020B8
			public unsafe List<IMarker> markerList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.TransientBuildData.NativeFieldInfoPtr_markerList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IMarker>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset.TransientBuildData.NativeFieldInfoPtr_markerList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400045B RID: 1115
			private static readonly IntPtr NativeFieldInfoPtr_trackList;

			// Token: 0x0400045C RID: 1116
			private static readonly IntPtr NativeFieldInfoPtr_clipList;

			// Token: 0x0400045D RID: 1117
			private static readonly IntPtr NativeFieldInfoPtr_markerList;

			// Token: 0x0400045E RID: 1118
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_TransientBuildData_0;

			// Token: 0x0400045F RID: 1119
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
		}

		// Token: 0x02000069 RID: 105
		[ObfuscatedName("UnityEngine.Timeline.TrackAsset+<get_outputs>d__65")]
		public sealed class _get_outputs_d__65 : Object
		{
			// Token: 0x06000595 RID: 1429 RVA: 0x0001A140 File Offset: 0x00018340
			// Note: this type is marked as 'beforefieldinit'.
			static _get_outputs_d__65()
			{
				Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "<get_outputs>d__65");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr);
				TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, "<>1__state");
				TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, "<>2__current");
				TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, "<>l__initialThreadId");
				TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, "<>4__this");
				TrackAsset._get_outputs_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, 100663723);
				TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, 100663724);
				TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, 100663725);
				TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, 100663726);
				TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, 100663727);
				TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, 100663728);
				TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, 100663729);
				TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr, 100663730);
			}

			// Token: 0x06000596 RID: 1430 RVA: 0x0001A25C File Offset: 0x0001845C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_outputs_d__65(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackAsset._get_outputs_d__65>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset._get_outputs_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000597 RID: 1431 RVA: 0x0001A2A4 File Offset: 0x000184A4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000598 RID: 1432 RVA: 0x0001A2D8 File Offset: 0x000184D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475044, XrefRangeEnd = 475072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x06000599 RID: 1433 RVA: 0x0001A314 File Offset: 0x00018514
			public unsafe PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new PlayableBinding(intPtr);
				}
			}

			// Token: 0x0600059A RID: 1434 RVA: 0x0001A34C File Offset: 0x0001854C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475072, XrefRangeEnd = 475077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x0600059B RID: 1435 RVA: 0x0001A380 File Offset: 0x00018580
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475077, XrefRangeEnd = 475080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600059C RID: 1436 RVA: 0x0001A3C0 File Offset: 0x000185C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475080, XrefRangeEnd = 475083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayableBinding> System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayableBinding>>(intPtr3) : null;
			}

			// Token: 0x0600059D RID: 1437 RVA: 0x0001A400 File Offset: 0x00018600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset._get_outputs_d__65.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600059E RID: 1438 RVA: 0x00003ED7 File Offset: 0x000020D7
			public _get_outputs_d__65(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x0600059F RID: 1439 RVA: 0x0001A440 File Offset: 0x00018640
			// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00003EE0 File Offset: 0x000020E0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0001A468 File Offset: 0x00018668
			// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00003EFB File Offset: 0x000020FB
			public PlayableBinding __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___2__current);
					return new PlayableBinding(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0001A498 File Offset: 0x00018698
			// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00003F29 File Offset: 0x00002129
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001A4C0 File Offset: 0x000186C0
			// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00003F44 File Offset: 0x00002144
			public unsafe TrackAsset __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackAsset._get_outputs_d__65.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000460 RID: 1120
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000461 RID: 1121
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000462 RID: 1122
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000463 RID: 1123
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000464 RID: 1124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000465 RID: 1125
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000466 RID: 1126
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000467 RID: 1127
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0;

			// Token: 0x04000468 RID: 1128
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000469 RID: 1129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400046A RID: 1130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0;

			// Token: 0x0400046B RID: 1131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200006A RID: 106
		[ObfuscatedName("UnityEngine.Timeline.TrackAsset+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060005A7 RID: 1447 RVA: 0x0001A4F0 File Offset: 0x000186F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TrackAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackAsset>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackAsset.__c>.NativeClassPtr);
				TrackAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset.__c>.NativeClassPtr, "<>9");
				TrackAsset.__c.NativeFieldInfoPtr___9__121_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackAsset.__c>.NativeClassPtr, "<>9__121_0");
				TrackAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset.__c>.NativeClassPtr, 100663732);
				TrackAsset.__c.NativeMethodInfoPtr__SortClips_b__121_0_Internal_Int32_TimelineClip_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAsset.__c>.NativeClassPtr, 100663733);
			}

			// Token: 0x060005A8 RID: 1448 RVA: 0x0001A56C File Offset: 0x0001876C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackAsset.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005A9 RID: 1449 RVA: 0x0001A5A8 File Offset: 0x000187A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475083, XrefRangeEnd = 475084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortClips_b__121_0(TimelineClip clip1, TimelineClip clip2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackAsset.__c.NativeMethodInfoPtr__SortClips_b__121_0_Internal_Int32_TimelineClip_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005AA RID: 1450 RVA: 0x00003F63 File Offset: 0x00002163
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x060005AB RID: 1451 RVA: 0x0001A608 File Offset: 0x00018808
			// (set) Token: 0x060005AC RID: 1452 RVA: 0x00003F6C File Offset: 0x0000216C
			public unsafe static TrackAsset.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackAsset.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackAsset.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackAsset.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x060005AD RID: 1453 RVA: 0x0001A630 File Offset: 0x00018830
			// (set) Token: 0x060005AE RID: 1454 RVA: 0x00003F7E File Offset: 0x0000217E
			public unsafe static Comparison<TimelineClip> __9__121_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackAsset.__c.NativeFieldInfoPtr___9__121_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<TimelineClip>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackAsset.__c.NativeFieldInfoPtr___9__121_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400046C RID: 1132
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400046D RID: 1133
			private static readonly IntPtr NativeFieldInfoPtr___9__121_0;

			// Token: 0x0400046E RID: 1134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400046F RID: 1135
			private static readonly IntPtr NativeMethodInfoPtr__SortClips_b__121_0_Internal_Int32_TimelineClip_TimelineClip_0;
		}

		// Token: 0x0200006B RID: 107
		private sealed class MethodInfoStoreGeneric_CreateClip_Public_TimelineClip_0<T>
		{
			// Token: 0x04000470 RID: 1136
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TrackAsset.NativeMethodInfoPtr_CreateClip_Public_TimelineClip_0, Il2CppClassPointerStore<TrackAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006C RID: 108
		private sealed class MethodInfoStoreGeneric_CreateMarker_Public_T_Double_0<T>
		{
			// Token: 0x04000471 RID: 1137
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TrackAsset.NativeMethodInfoPtr_CreateMarker_Public_T_Double_0, Il2CppClassPointerStore<TrackAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
