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
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class TimelineAsset : PlayableAsset
	{
		// Token: 0x0600019F RID: 415 RVA: 0x0000A92C File Offset: 0x00008B2C
		// Note: this type is marked as 'beforefieldinit'.
		static TimelineAsset()
		{
			Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimelineAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr);
			TimelineAsset.NativeFieldInfoPtr_k_LatestVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "k_LatestVersion");
			TimelineAsset.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "m_Version");
			TimelineAsset.NativeFieldInfoPtr_m_Tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "m_Tracks");
			TimelineAsset.NativeFieldInfoPtr_m_FixedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "m_FixedDuration");
			TimelineAsset.NativeFieldInfoPtr_m_CacheOutputTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "m_CacheOutputTracks");
			TimelineAsset.NativeFieldInfoPtr_m_CacheRootTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "m_CacheRootTracks");
			TimelineAsset.NativeFieldInfoPtr_m_CacheFlattenedTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "m_CacheFlattenedTracks");
			TimelineAsset.NativeFieldInfoPtr_m_EditorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "m_EditorSettings");
			TimelineAsset.NativeFieldInfoPtr_m_DurationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "m_DurationMode");
			TimelineAsset.NativeFieldInfoPtr_m_MarkerTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "m_MarkerTrack");
			TimelineAsset.NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663558);
			TimelineAsset.NativeMethodInfoPtr_get_editorSettings_Public_get_EditorSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663559);
			TimelineAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663560);
			TimelineAsset.NativeMethodInfoPtr_get_fixedDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663561);
			TimelineAsset.NativeMethodInfoPtr_set_fixedDuration_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663562);
			TimelineAsset.NativeMethodInfoPtr_get_durationMode_Public_get_DurationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663563);
			TimelineAsset.NativeMethodInfoPtr_set_durationMode_Public_set_Void_DurationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663564);
			TimelineAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663565);
			TimelineAsset.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663566);
			TimelineAsset.NativeMethodInfoPtr_get_outputTrackCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663567);
			TimelineAsset.NativeMethodInfoPtr_get_rootTrackCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663568);
			TimelineAsset.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663569);
			TimelineAsset.NativeMethodInfoPtr_GetValidFramerate_Internal_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663570);
			TimelineAsset.NativeMethodInfoPtr_GetRootTrack_Public_TrackAsset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663571);
			TimelineAsset.NativeMethodInfoPtr_GetRootTracks_Public_IEnumerable_1_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663572);
			TimelineAsset.NativeMethodInfoPtr_GetOutputTrack_Public_TrackAsset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663573);
			TimelineAsset.NativeMethodInfoPtr_GetOutputTracks_Public_IEnumerable_1_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663574);
			TimelineAsset.NativeMethodInfoPtr_UpdateRootTrackCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663575);
			TimelineAsset.NativeMethodInfoPtr_UpdateOutputTrackCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663576);
			TimelineAsset.NativeMethodInfoPtr_get_flattenedTracks_Internal_get_IEnumerable_1_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663577);
			TimelineAsset.NativeMethodInfoPtr_get_markerTrack_Public_get_MarkerTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663578);
			TimelineAsset.NativeMethodInfoPtr_get_trackObjects_Internal_get_List_1_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663579);
			TimelineAsset.NativeMethodInfoPtr_AddTrackInternal_Internal_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663580);
			TimelineAsset.NativeMethodInfoPtr_RemoveTrack_Internal_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663581);
			TimelineAsset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663582);
			TimelineAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663583);
			TimelineAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663584);
			TimelineAsset.NativeMethodInfoPtr___internalAwake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663585);
			TimelineAsset.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663586);
			TimelineAsset.NativeMethodInfoPtr_CreateMarkerTrack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663587);
			TimelineAsset.NativeMethodInfoPtr_Invalidate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663588);
			TimelineAsset.NativeMethodInfoPtr_UpdateFixedDurationWithItemsDuration_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663589);
			TimelineAsset.NativeMethodInfoPtr_CalculateItemsDuration_Private_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663590);
			TimelineAsset.NativeMethodInfoPtr_AddSubTracksRecursive_Private_Static_Void_TrackAsset_byref_List_1_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663591);
			TimelineAsset.NativeMethodInfoPtr_CreateTrack_Public_TrackAsset_Type_TrackAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663592);
			TimelineAsset.NativeMethodInfoPtr_CreateTrack_Public_T_TrackAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663593);
			TimelineAsset.NativeMethodInfoPtr_CreateTrack_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663594);
			TimelineAsset.NativeMethodInfoPtr_CreateTrack_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663595);
			TimelineAsset.NativeMethodInfoPtr_DeleteClip_Public_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663596);
			TimelineAsset.NativeMethodInfoPtr_DeleteTrack_Public_Boolean_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663597);
			TimelineAsset.NativeMethodInfoPtr_MoveLastTrackBefore_Internal_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663598);
			TimelineAsset.NativeMethodInfoPtr_AllocateTrack_Internal_TrackAsset_TrackAsset_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663599);
			TimelineAsset.NativeMethodInfoPtr_DeleteRecordedAnimation_Private_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663600);
			TimelineAsset.NativeMethodInfoPtr_DeleteRecordedAnimation_Private_Void_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663601);
			TimelineAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, 100663602);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgradeToLatestVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000ADDC File Offset: 0x00008FDC
		public unsafe TimelineAsset.EditorSettings editorSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_get_editorSettings_Public_get_EditorSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineAsset.EditorSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000AE1C File Offset: 0x0000901C
		public unsafe override double duration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474238, XrefRangeEnd = 474239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimelineAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000AE64 File Offset: 0x00009064
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000AEA0 File Offset: 0x000090A0
		public unsafe double fixedDuration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474239, XrefRangeEnd = 474254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_get_fixedDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474254, XrefRangeEnd = 474258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_set_fixedDuration_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000AEE0 File Offset: 0x000090E0
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000AF1C File Offset: 0x0000911C
		public unsafe TimelineAsset.DurationMode durationMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_get_durationMode_Public_get_DurationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_set_durationMode_Public_set_Void_DurationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000AF5C File Offset: 0x0000915C
		public unsafe override IEnumerable<PlayableBinding> outputs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474258, XrefRangeEnd = 474263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimelineAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayableBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000AFA8 File Offset: 0x000091A8
		public unsafe virtual ClipCaps clipCaps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474263, XrefRangeEnd = 474280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000AFE4 File Offset: 0x000091E4
		public unsafe int outputTrackCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474280, XrefRangeEnd = 474281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_get_outputTrackCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000B020 File Offset: 0x00009220
		public unsafe int rootTrackCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474281, XrefRangeEnd = 474283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_get_rootTrackCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000B05C File Offset: 0x0000925C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474283, XrefRangeEnd = 474285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000B090 File Offset: 0x00009290
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 474289, RefRangeEnd = 474292, XrefRangeStart = 474285, XrefRangeEnd = 474289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetValidFramerate(float framerate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref framerate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_GetValidFramerate_Internal_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000B0D0 File Offset: 0x000092D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474292, XrefRangeEnd = 474294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackAsset GetRootTrack(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_GetRootTrack_Public_TrackAsset_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr3) : null;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000B11C File Offset: 0x0000931C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474294, XrefRangeEnd = 474295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<TrackAsset> GetRootTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_GetRootTracks_Public_IEnumerable_1_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TrackAsset>>(intPtr3) : null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000B15C File Offset: 0x0000935C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474295, XrefRangeEnd = 474296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackAsset GetOutputTrack(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_GetOutputTrack_Public_TrackAsset_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr3) : null;
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474296, XrefRangeEnd = 474297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<TrackAsset> GetOutputTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_GetOutputTracks_Public_IEnumerable_1_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TrackAsset>>(intPtr3) : null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000B1E8 File Offset: 0x000093E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 474351, RefRangeEnd = 474356, XrefRangeStart = 474297, XrefRangeEnd = 474351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRootTrackCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_UpdateRootTrackCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000B21C File Offset: 0x0000941C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 474404, RefRangeEnd = 474410, XrefRangeStart = 474356, XrefRangeEnd = 474404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOutputTrackCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_UpdateOutputTrackCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000B250 File Offset: 0x00009450
		public unsafe IEnumerable<TrackAsset> flattenedTracks
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 474424, RefRangeEnd = 474426, XrefRangeStart = 474410, XrefRangeEnd = 474424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_get_flattenedTracks_Internal_get_IEnumerable_1_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TrackAsset>>(intPtr3) : null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000B290 File Offset: 0x00009490
		public unsafe MarkerTrack markerTrack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_get_markerTrack_Public_get_MarkerTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarkerTrack>(intPtr3) : null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000B2D0 File Offset: 0x000094D0
		public unsafe List<ScriptableObject> trackObjects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_get_trackObjects_Internal_get_List_1_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ScriptableObject>>(intPtr3) : null;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000B310 File Offset: 0x00009510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474426, XrefRangeEnd = 474431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrackInternal(TrackAsset track)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_AddTrackInternal_Internal_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000B354 File Offset: 0x00009554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474451, RefRangeEnd = 474452, XrefRangeStart = 474431, XrefRangeEnd = 474451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrack(TrackAsset track)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_RemoveTrack_Internal_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000B398 File Offset: 0x00009598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474452, XrefRangeEnd = 474480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimelineAsset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000B400 File Offset: 0x00009600
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000B434 File Offset: 0x00009634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474480, XrefRangeEnd = 474481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000B468 File Offset: 0x00009668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474481, XrefRangeEnd = 474509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __internalAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr___internalAwake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000B49C File Offset: 0x0000969C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474526, RefRangeEnd = 474527, XrefRangeStart = 474509, XrefRangeEnd = 474526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474527, XrefRangeEnd = 474547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateMarkerTrack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_CreateMarkerTrack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000B524 File Offset: 0x00009724
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 474547, RefRangeEnd = 474554, XrefRangeStart = 474547, XrefRangeEnd = 474547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invalidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_Invalidate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000B558 File Offset: 0x00009758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474554, XrefRangeEnd = 474562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFixedDurationWithItemsDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_UpdateFixedDurationWithItemsDuration_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000B58C File Offset: 0x0000978C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474594, RefRangeEnd = 474595, XrefRangeStart = 474562, XrefRangeEnd = 474594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiscreteTime CalculateItemsDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_CalculateItemsDuration_Private_DiscreteTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474627, RefRangeEnd = 474629, XrefRangeStart = 474595, XrefRangeEnd = 474627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(allTracks);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_AddSubTracksRecursive_Private_Static_Void_TrackAsset_byref_List_1_TrackAsset_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			allTracks = ((intPtr4 == 0) ? null : new List<TrackAsset>(intPtr4));
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000B628 File Offset: 0x00009828
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 474718, RefRangeEnd = 474721, XrefRangeStart = 474629, XrefRangeEnd = 474718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackAsset CreateTrack(Type type, TrackAsset parent, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_CreateTrack_Public_TrackAsset_Type_TrackAsset_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr3) : null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000B69C File Offset: 0x0000989C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474721, XrefRangeEnd = 474728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CreateTrack<T>(TrackAsset parent, string trackName) where T : TrackAsset, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trackName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.MethodInfoStoreGeneric_CreateTrack_Public_T_TrackAsset_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000B6F8 File Offset: 0x000098F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474728, XrefRangeEnd = 474735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CreateTrack<T>(string trackName) where T : TrackAsset, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.MethodInfoStoreGeneric_CreateTrack_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000B744 File Offset: 0x00009944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474735, XrefRangeEnd = 474742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CreateTrack<T>() where T : TrackAsset, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.MethodInfoStoreGeneric_CreateTrack_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000B780 File Offset: 0x00009980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474781, RefRangeEnd = 474782, XrefRangeStart = 474742, XrefRangeEnd = 474781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteClip(TimelineClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_DeleteClip_Public_Boolean_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000B7D0 File Offset: 0x000099D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474782, XrefRangeEnd = 474814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteTrack(TrackAsset track)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_DeleteTrack_Public_Boolean_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000B820 File Offset: 0x00009A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474814, XrefRangeEnd = 474861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveLastTrackBefore(TrackAsset asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_MoveLastTrackBefore_Internal_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000B864 File Offset: 0x00009A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474917, RefRangeEnd = 474918, XrefRangeStart = 474861, XrefRangeEnd = 474917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trackAssetParent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trackName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trackType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_AllocateTrack_Internal_TrackAsset_TrackAsset_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr3) : null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000B8D8 File Offset: 0x00009AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474918, XrefRangeEnd = 474961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteRecordedAnimation(TrackAsset track)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_DeleteRecordedAnimation_Private_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000B91C File Offset: 0x00009B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474961, XrefRangeEnd = 475004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteRecordedAnimation(TimelineClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr_DeleteRecordedAnimation_Private_Void_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000B960 File Offset: 0x00009B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475004, XrefRangeEnd = 475012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002877 File Offset: 0x00000A77
		public TimelineAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000B99C File Offset: 0x00009B9C
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002880 File Offset: 0x00000A80
		public unsafe static int k_LatestVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimelineAsset.NativeFieldInfoPtr_k_LatestVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimelineAsset.NativeFieldInfoPtr_k_LatestVersion, (void*)(&value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x0000288E File Offset: 0x00000A8E
		public unsafe int m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000B9E0 File Offset: 0x00009BE0
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x000028A9 File Offset: 0x00000AA9
		public unsafe List<ScriptableObject> m_Tracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_Tracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScriptableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_Tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000BA10 File Offset: 0x00009C10
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x000028C8 File Offset: 0x00000AC8
		public unsafe double m_FixedDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_FixedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_FixedDuration)) = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000BA38 File Offset: 0x00009C38
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x000028E3 File Offset: 0x00000AE3
		public unsafe Il2CppReferenceArray<TrackAsset> m_CacheOutputTracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_CacheOutputTracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrackAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_CacheOutputTracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000BA68 File Offset: 0x00009C68
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002902 File Offset: 0x00000B02
		public unsafe List<TrackAsset> m_CacheRootTracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_CacheRootTracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrackAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_CacheRootTracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000BA98 File Offset: 0x00009C98
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002921 File Offset: 0x00000B21
		public unsafe List<TrackAsset> m_CacheFlattenedTracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_CacheFlattenedTracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrackAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_CacheFlattenedTracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002940 File Offset: 0x00000B40
		public unsafe TimelineAsset.EditorSettings m_EditorSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_EditorSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimelineAsset.EditorSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_EditorSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000BAF8 File Offset: 0x00009CF8
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0000295F File Offset: 0x00000B5F
		public unsafe TimelineAsset.DurationMode m_DurationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_DurationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_DurationMode)) = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000BB20 File Offset: 0x00009D20
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0000297A File Offset: 0x00000B7A
		public unsafe MarkerTrack m_MarkerTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_MarkerTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarkerTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.NativeFieldInfoPtr_m_MarkerTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_k_LatestVersion;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracks;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_m_FixedDuration;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheOutputTracks;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheRootTracks;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheFlattenedTracks;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_m_EditorSettings;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_m_DurationMode;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkerTrack;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_get_editorSettings_Public_get_EditorSettings_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedDuration_Public_get_Double_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_set_fixedDuration_Public_set_Void_Double_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_get_durationMode_Public_get_DurationMode_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_set_durationMode_Public_set_Void_DurationMode_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_get_outputTrackCount_Public_get_Int32_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_get_rootTrackCount_Public_get_Int32_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_GetValidFramerate_Internal_Static_Single_Single_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_GetRootTrack_Public_TrackAsset_Int32_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_GetRootTracks_Public_IEnumerable_1_TrackAsset_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputTrack_Public_TrackAsset_Int32_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputTracks_Public_IEnumerable_1_TrackAsset_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRootTrackCache_Private_Void_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOutputTrackCache_Private_Void_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_get_flattenedTracks_Internal_get_IEnumerable_1_TrackAsset_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_get_markerTrack_Public_get_MarkerTrack_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_get_trackObjects_Internal_get_List_1_ScriptableObject_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_AddTrackInternal_Internal_Void_TrackAsset_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrack_Internal_Void_TrackAsset_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr___internalAwake_Private_Void_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarkerTrack_Public_Void_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_Invalidate_Internal_Void_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFixedDurationWithItemsDuration_Internal_Void_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_CalculateItemsDuration_Private_DiscreteTime_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_AddSubTracksRecursive_Private_Static_Void_TrackAsset_byref_List_1_TrackAsset_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrack_Public_TrackAsset_Type_TrackAsset_String_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrack_Public_T_TrackAsset_String_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrack_Public_T_String_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrack_Public_T_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_DeleteClip_Public_Boolean_TimelineClip_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_DeleteTrack_Public_Boolean_TrackAsset_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_MoveLastTrackBefore_Internal_Void_TrackAsset_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_AllocateTrack_Internal_TrackAsset_TrackAsset_String_Type_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_DeleteRecordedAnimation_Private_Void_TrackAsset_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_DeleteRecordedAnimation_Private_Void_TimelineClip_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200005D RID: 93
		[OriginalName("Unity.Timeline.dll", "", "Versions")]
		public enum Versions
		{
			// Token: 0x0400042D RID: 1069
			Initial
		}

		// Token: 0x0200005E RID: 94
		public static class TimelineAssetUpgrade : Object
		{
			// Token: 0x0600055A RID: 1370 RVA: 0x00003CDA File Offset: 0x00001EDA
			// Note: this type is marked as 'beforefieldinit'.
			static TimelineAssetUpgrade()
			{
				Il2CppClassPointerStore<TimelineAsset.TimelineAssetUpgrade>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "TimelineAssetUpgrade");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineAsset.TimelineAssetUpgrade>.NativeClassPtr);
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x00003CFA File Offset: 0x00001EFA
			public TimelineAssetUpgrade(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x0200005F RID: 95
		[OriginalName("Unity.Timeline.dll", "", "MediaType")]
		public enum MediaType
		{
			// Token: 0x0400042F RID: 1071
			Animation,
			// Token: 0x04000430 RID: 1072
			Audio,
			// Token: 0x04000431 RID: 1073
			Texture,
			// Token: 0x04000432 RID: 1074
			Video = 2,
			// Token: 0x04000433 RID: 1075
			Script,
			// Token: 0x04000434 RID: 1076
			Hybrid,
			// Token: 0x04000435 RID: 1077
			Group
		}

		// Token: 0x02000060 RID: 96
		[OriginalName("Unity.Timeline.dll", "", "DurationMode")]
		public enum DurationMode
		{
			// Token: 0x04000437 RID: 1079
			BasedOnClips,
			// Token: 0x04000438 RID: 1080
			FixedLength
		}

		// Token: 0x02000061 RID: 97
		[Serializable]
		public class EditorSettings : Object
		{
			// Token: 0x0600055C RID: 1372 RVA: 0x0001972C File Offset: 0x0001792C
			// Note: this type is marked as 'beforefieldinit'.
			static EditorSettings()
			{
				Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "EditorSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr);
				TimelineAsset.EditorSettings.NativeFieldInfoPtr_kMinFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr, "kMinFps");
				TimelineAsset.EditorSettings.NativeFieldInfoPtr_kMaxFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr, "kMaxFps");
				TimelineAsset.EditorSettings.NativeFieldInfoPtr_kDefaultFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr, "kDefaultFps");
				TimelineAsset.EditorSettings.NativeFieldInfoPtr_m_Framerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr, "m_Framerate");
				TimelineAsset.EditorSettings.NativeFieldInfoPtr_m_ScenePreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr, "m_ScenePreview");
				TimelineAsset.EditorSettings.NativeMethodInfoPtr_get_fps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr, 100663603);
				TimelineAsset.EditorSettings.NativeMethodInfoPtr_set_fps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr, 100663604);
				TimelineAsset.EditorSettings.NativeMethodInfoPtr_get_scenePreview_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr, 100663605);
				TimelineAsset.EditorSettings.NativeMethodInfoPtr_set_scenePreview_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr, 100663606);
				TimelineAsset.EditorSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr, 100663607);
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x0600055D RID: 1373 RVA: 0x00019820 File Offset: 0x00017A20
			// (set) Token: 0x0600055E RID: 1374 RVA: 0x0001985C File Offset: 0x00017A5C
			public unsafe float fps
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.EditorSettings.NativeMethodInfoPtr_get_fps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474177, XrefRangeEnd = 474178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.EditorSettings.NativeMethodInfoPtr_set_fps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x0600055F RID: 1375 RVA: 0x0001989C File Offset: 0x00017A9C
			// (set) Token: 0x06000560 RID: 1376 RVA: 0x000198D8 File Offset: 0x00017AD8
			public unsafe bool scenePreview
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.EditorSettings.NativeMethodInfoPtr_get_scenePreview_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.EditorSettings.NativeMethodInfoPtr_set_scenePreview_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000561 RID: 1377 RVA: 0x00019918 File Offset: 0x00017B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474178, XrefRangeEnd = 474182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EditorSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineAsset.EditorSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset.EditorSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000562 RID: 1378 RVA: 0x00003D03 File Offset: 0x00001F03
			public EditorSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x06000563 RID: 1379 RVA: 0x00019954 File Offset: 0x00017B54
			// (set) Token: 0x06000564 RID: 1380 RVA: 0x00003D0C File Offset: 0x00001F0C
			public unsafe static float kMinFps
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(TimelineAsset.EditorSettings.NativeFieldInfoPtr_kMinFps, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimelineAsset.EditorSettings.NativeFieldInfoPtr_kMinFps, (void*)(&value));
				}
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x06000565 RID: 1381 RVA: 0x00019970 File Offset: 0x00017B70
			// (set) Token: 0x06000566 RID: 1382 RVA: 0x00003D1A File Offset: 0x00001F1A
			public unsafe static float kMaxFps
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(TimelineAsset.EditorSettings.NativeFieldInfoPtr_kMaxFps, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimelineAsset.EditorSettings.NativeFieldInfoPtr_kMaxFps, (void*)(&value));
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x06000567 RID: 1383 RVA: 0x0001998C File Offset: 0x00017B8C
			// (set) Token: 0x06000568 RID: 1384 RVA: 0x00003D28 File Offset: 0x00001F28
			public unsafe static float kDefaultFps
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(TimelineAsset.EditorSettings.NativeFieldInfoPtr_kDefaultFps, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimelineAsset.EditorSettings.NativeFieldInfoPtr_kDefaultFps, (void*)(&value));
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x06000569 RID: 1385 RVA: 0x000199A8 File Offset: 0x00017BA8
			// (set) Token: 0x0600056A RID: 1386 RVA: 0x00003D36 File Offset: 0x00001F36
			public unsafe float m_Framerate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.EditorSettings.NativeFieldInfoPtr_m_Framerate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.EditorSettings.NativeFieldInfoPtr_m_Framerate)) = value;
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x0600056B RID: 1387 RVA: 0x000199D0 File Offset: 0x00017BD0
			// (set) Token: 0x0600056C RID: 1388 RVA: 0x00003D51 File Offset: 0x00001F51
			public unsafe bool m_ScenePreview
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.EditorSettings.NativeFieldInfoPtr_m_ScenePreview);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset.EditorSettings.NativeFieldInfoPtr_m_ScenePreview)) = value;
				}
			}

			// Token: 0x04000439 RID: 1081
			private static readonly IntPtr NativeFieldInfoPtr_kMinFps;

			// Token: 0x0400043A RID: 1082
			private static readonly IntPtr NativeFieldInfoPtr_kMaxFps;

			// Token: 0x0400043B RID: 1083
			private static readonly IntPtr NativeFieldInfoPtr_kDefaultFps;

			// Token: 0x0400043C RID: 1084
			private static readonly IntPtr NativeFieldInfoPtr_m_Framerate;

			// Token: 0x0400043D RID: 1085
			private static readonly IntPtr NativeFieldInfoPtr_m_ScenePreview;

			// Token: 0x0400043E RID: 1086
			private static readonly IntPtr NativeMethodInfoPtr_get_fps_Public_get_Single_0;

			// Token: 0x0400043F RID: 1087
			private static readonly IntPtr NativeMethodInfoPtr_set_fps_Public_set_Void_Single_0;

			// Token: 0x04000440 RID: 1088
			private static readonly IntPtr NativeMethodInfoPtr_get_scenePreview_Public_get_Boolean_0;

			// Token: 0x04000441 RID: 1089
			private static readonly IntPtr NativeMethodInfoPtr_set_scenePreview_Public_set_Void_Boolean_0;

			// Token: 0x04000442 RID: 1090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000062 RID: 98
		[ObfuscatedName("UnityEngine.Timeline.TimelineAsset+<get_outputs>d__27")]
		public sealed class _get_outputs_d__27 : Object
		{
			// Token: 0x0600056D RID: 1389 RVA: 0x000199F8 File Offset: 0x00017BF8
			// Note: this type is marked as 'beforefieldinit'.
			static _get_outputs_d__27()
			{
				Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr, "<get_outputs>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr);
				TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, "<>1__state");
				TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, "<>2__current");
				TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, "<>l__initialThreadId");
				TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, "<>4__this");
				TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, "<>7__wrap1");
				TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, "<>7__wrap2");
				TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, 100663609);
				TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, 100663610);
				TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, 100663611);
				TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, 100663612);
				TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, 100663613);
				TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, 100663614);
				TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, 100663615);
				TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, 100663616);
				TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, 100663617);
				TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr, 100663618);
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x00019B64 File Offset: 0x00017D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_outputs_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineAsset._get_outputs_d__27>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600056F RID: 1391 RVA: 0x00019BAC File Offset: 0x00017DAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 474190, RefRangeEnd = 474191, XrefRangeStart = 474182, XrefRangeEnd = 474190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x00019BE0 File Offset: 0x00017DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474191, XrefRangeEnd = 474221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000571 RID: 1393 RVA: 0x00019C1C File Offset: 0x00017E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474221, XrefRangeEnd = 474224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000572 RID: 1394 RVA: 0x00019C50 File Offset: 0x00017E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474224, XrefRangeEnd = 474227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x06000573 RID: 1395 RVA: 0x00019C84 File Offset: 0x00017E84
			public unsafe PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new PlayableBinding(intPtr);
				}
			}

			// Token: 0x06000574 RID: 1396 RVA: 0x00019CBC File Offset: 0x00017EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474227, XrefRangeEnd = 474232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x06000575 RID: 1397 RVA: 0x00019CF0 File Offset: 0x00017EF0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474232, XrefRangeEnd = 474235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x00019D30 File Offset: 0x00017F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474235, XrefRangeEnd = 474238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayableBinding> System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayableBinding>>(intPtr3) : null;
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x00019D70 File Offset: 0x00017F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineAsset._get_outputs_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x00003D6C File Offset: 0x00001F6C
			public _get_outputs_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x06000579 RID: 1401 RVA: 0x00019DB0 File Offset: 0x00017FB0
			// (set) Token: 0x0600057A RID: 1402 RVA: 0x00003D75 File Offset: 0x00001F75
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x0600057B RID: 1403 RVA: 0x00019DD8 File Offset: 0x00017FD8
			// (set) Token: 0x0600057C RID: 1404 RVA: 0x00003D90 File Offset: 0x00001F90
			public PlayableBinding __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___2__current);
					return new PlayableBinding(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x0600057D RID: 1405 RVA: 0x00019E08 File Offset: 0x00018008
			// (set) Token: 0x0600057E RID: 1406 RVA: 0x00003DBE File Offset: 0x00001FBE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x0600057F RID: 1407 RVA: 0x00019E30 File Offset: 0x00018030
			// (set) Token: 0x06000580 RID: 1408 RVA: 0x00003DD9 File Offset: 0x00001FD9
			public unsafe TimelineAsset __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimelineAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06000581 RID: 1409 RVA: 0x00019E60 File Offset: 0x00018060
			// (set) Token: 0x06000582 RID: 1410 RVA: 0x00003DF8 File Offset: 0x00001FF8
			public unsafe IEnumerator<TrackAsset> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TrackAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x06000583 RID: 1411 RVA: 0x00019E90 File Offset: 0x00018090
			// (set) Token: 0x06000584 RID: 1412 RVA: 0x00003E17 File Offset: 0x00002017
			public unsafe IEnumerator<PlayableBinding> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayableBinding>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineAsset._get_outputs_d__27.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000443 RID: 1091
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000444 RID: 1092
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000445 RID: 1093
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000446 RID: 1094
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000447 RID: 1095
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000448 RID: 1096
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000449 RID: 1097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400044A RID: 1098
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400044B RID: 1099
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400044C RID: 1100
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400044D RID: 1101
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x0400044E RID: 1102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0;

			// Token: 0x0400044F RID: 1103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000450 RID: 1104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000451 RID: 1105
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0;

			// Token: 0x04000452 RID: 1106
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000063 RID: 99
		private sealed class MethodInfoStoreGeneric_CreateTrack_Public_T_TrackAsset_String_0<T>
		{
			// Token: 0x04000453 RID: 1107
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TimelineAsset.NativeMethodInfoPtr_CreateTrack_Public_T_TrackAsset_String_0, Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000064 RID: 100
		private sealed class MethodInfoStoreGeneric_CreateTrack_Public_T_String_0<T>
		{
			// Token: 0x04000454 RID: 1108
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TimelineAsset.NativeMethodInfoPtr_CreateTrack_Public_T_String_0, Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000065 RID: 101
		private sealed class MethodInfoStoreGeneric_CreateTrack_Public_T_0<T>
		{
			// Token: 0x04000455 RID: 1109
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TimelineAsset.NativeMethodInfoPtr_CreateTrack_Public_T_0, Il2CppClassPointerStore<TimelineAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
