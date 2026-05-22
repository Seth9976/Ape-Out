using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000047 RID: 71
	public class TimelinePlayable : PlayableBehaviour
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x00016FFC File Offset: 0x000151FC
		// Note: this type is marked as 'beforefieldinit'.
		static TimelinePlayable()
		{
			Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimelinePlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr);
			TimelinePlayable.NativeFieldInfoPtr_m_IntervalTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_IntervalTree");
			TimelinePlayable.NativeFieldInfoPtr_m_ActiveClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_ActiveClips");
			TimelinePlayable.NativeFieldInfoPtr_m_CurrentListOfActiveClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_CurrentListOfActiveClips");
			TimelinePlayable.NativeFieldInfoPtr_m_ActiveBit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_ActiveBit");
			TimelinePlayable.NativeFieldInfoPtr_m_EvaluateCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_EvaluateCallbacks");
			TimelinePlayable.NativeFieldInfoPtr_m_PlayableCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_PlayableCache");
			TimelinePlayable.NativeFieldInfoPtr_muteAudioScrubbing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "muteAudioScrubbing");
			TimelinePlayable.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimelinePlayable_PlayableGraph_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664077);
			TimelinePlayable.NativeMethodInfoPtr_Compile_Public_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664078);
			TimelinePlayable.NativeMethodInfoPtr_CompileTrackList_Private_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664079);
			TimelinePlayable.NativeMethodInfoPtr_CreateTrackOutput_Private_Void_PlayableGraph_TrackAsset_GameObject_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664080);
			TimelinePlayable.NativeMethodInfoPtr_EvaluateWeightsForAnimationPlayableOutput_Private_Void_TrackAsset_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664081);
			TimelinePlayable.NativeMethodInfoPtr_EvaluateAnimationPreviewUpdateCallback_Private_Void_TrackAsset_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664082);
			TimelinePlayable.NativeMethodInfoPtr_CreatePlayableGraph_Private_Static_Playable_PlayableGraph_TrackAsset_GameObject_IntervalTree_1_RuntimeElement_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664083);
			TimelinePlayable.NativeMethodInfoPtr_CreateTrackPlayable_Private_Playable_PlayableGraph_Playable_TrackAsset_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664084);
			TimelinePlayable.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664085);
			TimelinePlayable.NativeMethodInfoPtr_Evaluate_Private_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664086);
			TimelinePlayable.NativeMethodInfoPtr_CacheTrack_Private_Void_TrackAsset_Playable_Int32_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664087);
			TimelinePlayable.NativeMethodInfoPtr_ForAOTCompilationOnly_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664088);
			TimelinePlayable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664089);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000171BC File Offset: 0x000153BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479375, RefRangeEnd = 479376, XrefRangeStart = 479336, XrefRangeEnd = 479375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tracks);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRebalance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createOutputs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimelinePlayable_PlayableGraph_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ScriptPlayable<TimelinePlayable>(intPtr);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00017234 File Offset: 0x00015434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479412, RefRangeEnd = 479413, XrefRangeStart = 479376, XrefRangeEnd = 479412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timelinePlayable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tracks);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRebalance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createOutputs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr_Compile_Public_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000172C4 File Offset: 0x000154C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479433, RefRangeEnd = 479434, XrefRangeStart = 479413, XrefRangeEnd = 479433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timelinePlayable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tracks);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createOutputs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr_CompileTrackList_Private_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00017344 File Offset: 0x00015544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479536, RefRangeEnd = 479537, XrefRangeStart = 479434, XrefRangeEnd = 479536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playable;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr_CreateTrackOutput_Private_Void_PlayableGraph_TrackAsset_GameObject_Playable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000173C4 File Offset: 0x000155C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479545, RefRangeEnd = 479546, XrefRangeStart = 479537, XrefRangeEnd = 479545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animOutput;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr_EvaluateWeightsForAnimationPlayableOutput_Private_Void_TrackAsset_AnimationPlayableOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00017414 File Offset: 0x00015614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479546, XrefRangeEnd = 479554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateAnimationPreviewUpdateCallback(TrackAsset track, AnimationPlayableOutput animOutput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animOutput;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr_EvaluateAnimationPreviewUpdateCallback_Private_Void_TrackAsset_AnimationPlayableOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00017464 File Offset: 0x00015664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479554, XrefRangeEnd = 479555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Playable CreatePlayableGraph(PlayableGraph graph, TrackAsset asset, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tree);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timelinePlayable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr_CreatePlayableGraph_Private_Static_Playable_PlayableGraph_TrackAsset_GameObject_IntervalTree_1_RuntimeElement_Playable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000174E8 File Offset: 0x000156E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479602, RefRangeEnd = 479604, XrefRangeStart = 479555, XrefRangeEnd = 479602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timelinePlayable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(track);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createOutputs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr_CreateTrackPlayable_Private_Playable_PlayableGraph_Playable_TrackAsset_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00017574 File Offset: 0x00015774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479604, XrefRangeEnd = 479605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimelinePlayable.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000175CC File Offset: 0x000157CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479665, RefRangeEnd = 479666, XrefRangeStart = 479605, XrefRangeEnd = 479665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate(Playable playable, FrameData frameData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr_Evaluate_Private_Void_Playable_FrameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00017618 File Offset: 0x00015818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479666, XrefRangeEnd = 479668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr_CacheTrack_Private_Void_TrackAsset_Playable_Int32_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00017684 File Offset: 0x00015884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479668, XrefRangeEnd = 479678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForAOTCompilationOnly()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr_ForAOTCompilationOnly_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000176AC File Offset: 0x000158AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479678, XrefRangeEnd = 479701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelinePlayable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelinePlayable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000396F File Offset: 0x00001B6F
		public TimelinePlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x000176E8 File Offset: 0x000158E8
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00003978 File Offset: 0x00001B78
		public unsafe IntervalTree<RuntimeElement> m_IntervalTree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_IntervalTree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntervalTree<RuntimeElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_IntervalTree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00017718 File Offset: 0x00015918
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00003997 File Offset: 0x00001B97
		public unsafe List<RuntimeElement> m_ActiveClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_ActiveClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RuntimeElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_ActiveClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00017748 File Offset: 0x00015948
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x000039B6 File Offset: 0x00001BB6
		public unsafe List<RuntimeElement> m_CurrentListOfActiveClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_CurrentListOfActiveClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RuntimeElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_CurrentListOfActiveClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00017778 File Offset: 0x00015978
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x000039D5 File Offset: 0x00001BD5
		public unsafe int m_ActiveBit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_ActiveBit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_ActiveBit)) = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x000177A0 File Offset: 0x000159A0
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x000039F0 File Offset: 0x00001BF0
		public unsafe List<ITimelineEvaluateCallback> m_EvaluateCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_EvaluateCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ITimelineEvaluateCallback>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_EvaluateCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x000177D0 File Offset: 0x000159D0
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00003A0F File Offset: 0x00001C0F
		public unsafe Dictionary<TrackAsset, Playable> m_PlayableCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_PlayableCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TrackAsset, Playable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelinePlayable.NativeFieldInfoPtr_m_PlayableCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00017800 File Offset: 0x00015A00
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00003A2E File Offset: 0x00001C2E
		public unsafe static bool muteAudioScrubbing
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TimelinePlayable.NativeFieldInfoPtr_muteAudioScrubbing, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimelinePlayable.NativeFieldInfoPtr_muteAudioScrubbing, (void*)(&value));
			}
		}

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_m_IntervalTree;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveClips;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentListOfActiveClips;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveBit;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeFieldInfoPtr_m_EvaluateCallbacks;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayableCache;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_muteAudioScrubbing;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimelinePlayable_PlayableGraph_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_CompileTrackList_Private_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrackOutput_Private_Void_PlayableGraph_TrackAsset_GameObject_Playable_Int32_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateWeightsForAnimationPlayableOutput_Private_Void_TrackAsset_AnimationPlayableOutput_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAnimationPreviewUpdateCallback_Private_Void_TrackAsset_AnimationPlayableOutput_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayableGraph_Private_Static_Playable_PlayableGraph_TrackAsset_GameObject_IntervalTree_1_RuntimeElement_Playable_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrackPlayable_Private_Playable_PlayableGraph_Playable_TrackAsset_GameObject_Boolean_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Private_Void_Playable_FrameData_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_CacheTrack_Private_Void_TrackAsset_Playable_Int32_Playable_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_ForAOTCompilationOnly_Private_Static_Void_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
