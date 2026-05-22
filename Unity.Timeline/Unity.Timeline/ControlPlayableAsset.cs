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
	// Token: 0x02000018 RID: 24
	[Serializable]
	public class ControlPlayableAsset : PlayableAsset
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x0000F268 File Offset: 0x0000D468
		// Note: this type is marked as 'beforefieldinit'.
		static ControlPlayableAsset()
		{
			Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ControlPlayableAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr);
			ControlPlayableAsset.NativeFieldInfoPtr_k_MaxRandInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "k_MaxRandInt");
			ControlPlayableAsset.NativeFieldInfoPtr_k_EmptyDirectorsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "k_EmptyDirectorsList");
			ControlPlayableAsset.NativeFieldInfoPtr_k_EmptyParticlesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "k_EmptyParticlesList");
			ControlPlayableAsset.NativeFieldInfoPtr_s_SubEmitterCollector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "s_SubEmitterCollector");
			ControlPlayableAsset.NativeFieldInfoPtr_sourceGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "sourceGameObject");
			ControlPlayableAsset.NativeFieldInfoPtr_prefabGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "prefabGameObject");
			ControlPlayableAsset.NativeFieldInfoPtr_updateParticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "updateParticle");
			ControlPlayableAsset.NativeFieldInfoPtr_particleRandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "particleRandomSeed");
			ControlPlayableAsset.NativeFieldInfoPtr_updateDirector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "updateDirector");
			ControlPlayableAsset.NativeFieldInfoPtr_updateITimeControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "updateITimeControl");
			ControlPlayableAsset.NativeFieldInfoPtr_searchHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "searchHierarchy");
			ControlPlayableAsset.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "active");
			ControlPlayableAsset.NativeFieldInfoPtr_postPlayback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "postPlayback");
			ControlPlayableAsset.NativeFieldInfoPtr_m_ControlDirectorAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "m_ControlDirectorAsset");
			ControlPlayableAsset.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "m_Duration");
			ControlPlayableAsset.NativeFieldInfoPtr_m_SupportLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "m_SupportLoop");
			ControlPlayableAsset.NativeFieldInfoPtr_s_ProcessedDirectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "s_ProcessedDirectors");
			ControlPlayableAsset.NativeFieldInfoPtr_s_CreatedPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "s_CreatedPrefabs");
			ControlPlayableAsset.NativeFieldInfoPtr__controllingDirectors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "<controllingDirectors>k__BackingField");
			ControlPlayableAsset.NativeFieldInfoPtr__controllingParticles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "<controllingParticles>k__BackingField");
			ControlPlayableAsset.NativeMethodInfoPtr_get_controllingDirectors_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663778);
			ControlPlayableAsset.NativeMethodInfoPtr_set_controllingDirectors_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663779);
			ControlPlayableAsset.NativeMethodInfoPtr_get_controllingParticles_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663780);
			ControlPlayableAsset.NativeMethodInfoPtr_set_controllingParticles_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663781);
			ControlPlayableAsset.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663782);
			ControlPlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663783);
			ControlPlayableAsset.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663784);
			ControlPlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663785);
			ControlPlayableAsset.NativeMethodInfoPtr_ConnectPlayablesToMixer_Private_Static_Playable_PlayableGraph_List_1_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663786);
			ControlPlayableAsset.NativeMethodInfoPtr_CreateActivationPlayable_Private_Void_GameObject_PlayableGraph_List_1_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663787);
			ControlPlayableAsset.NativeMethodInfoPtr_SearchHierarchyAndConnectParticleSystem_Private_Void_IEnumerable_1_ParticleSystem_PlayableGraph_List_1_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663788);
			ControlPlayableAsset.NativeMethodInfoPtr_SearchHierarchyAndConnectDirector_Private_Void_IEnumerable_1_PlayableDirector_PlayableGraph_List_1_Playable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663789);
			ControlPlayableAsset.NativeMethodInfoPtr_SearchHierarchyAndConnectControlableScripts_Private_Static_Void_IEnumerable_1_MonoBehaviour_PlayableGraph_List_1_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663790);
			ControlPlayableAsset.NativeMethodInfoPtr_ConnectMixerAndPlayable_Private_Static_Void_PlayableGraph_Playable_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663791);
			ControlPlayableAsset.NativeMethodInfoPtr_GetComponent_Internal_IList_1_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663792);
			ControlPlayableAsset.NativeMethodInfoPtr_GetControlableScripts_Internal_Static_IEnumerable_1_MonoBehaviour_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663793);
			ControlPlayableAsset.NativeMethodInfoPtr_UpdateDurationAndLoopFlag_Internal_Void_IList_1_PlayableDirector_IList_1_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663794);
			ControlPlayableAsset.NativeMethodInfoPtr_GetControllableParticleSystems_Private_IList_1_ParticleSystem_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663795);
			ControlPlayableAsset.NativeMethodInfoPtr_GetControllableParticleSystems_Private_Static_Void_Transform_ICollection_1_ParticleSystem_HashSet_1_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663796);
			ControlPlayableAsset.NativeMethodInfoPtr_CacheSubEmitters_Private_Static_Void_ParticleSystem_HashSet_1_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663797);
			ControlPlayableAsset.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663798);
			ControlPlayableAsset.NativeMethodInfoPtr_PreviewParticles_Internal_Static_Void_IPropertyCollector_IEnumerable_1_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663799);
			ControlPlayableAsset.NativeMethodInfoPtr_PreviewActivation_Internal_Static_Void_IPropertyCollector_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663800);
			ControlPlayableAsset.NativeMethodInfoPtr_PreviewTimeControl_Internal_Static_Void_IPropertyCollector_PlayableDirector_IEnumerable_1_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663801);
			ControlPlayableAsset.NativeMethodInfoPtr_PreviewDirectors_Internal_Static_Void_IPropertyCollector_IEnumerable_1_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663802);
			ControlPlayableAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, 100663803);
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000F630 File Offset: 0x0000D830
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0000F66C File Offset: 0x0000D86C
		public unsafe bool controllingDirectors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_get_controllingDirectors_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_set_controllingDirectors_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000F6AC File Offset: 0x0000D8AC
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0000F6E8 File Offset: 0x0000D8E8
		public unsafe bool controllingParticles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_get_controllingParticles_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_set_controllingParticles_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000F728 File Offset: 0x0000D928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476847, XrefRangeEnd = 476849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000F75C File Offset: 0x0000D95C
		public unsafe override double duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControlPlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
		public unsafe virtual ClipCaps clipCaps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476849, XrefRangeEnd = 476920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControlPlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000F848 File Offset: 0x0000DA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476920, XrefRangeEnd = 476937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_ConnectPlayablesToMixer_Private_Static_Playable_PlayableGraph_List_1_Playable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000F898 File Offset: 0x0000DA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476937, XrefRangeEnd = 476949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref graph;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outplayables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_CreateActivationPlayable_Private_Void_GameObject_PlayableGraph_List_1_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476949, XrefRangeEnd = 476983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, PlayableGraph graph, List<Playable> outplayables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystems);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref graph;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outplayables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_SearchHierarchyAndConnectParticleSystem_Private_Void_IEnumerable_1_ParticleSystem_PlayableGraph_List_1_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000F960 File Offset: 0x0000DB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476983, XrefRangeEnd = 477035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(directors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref graph;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outplayables);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disableSelfReferences;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_SearchHierarchyAndConnectDirector_Private_Void_IEnumerable_1_PlayableDirector_PlayableGraph_List_1_Playable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477035, XrefRangeEnd = 477075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlableScripts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref graph;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outplayables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_SearchHierarchyAndConnectControlableScripts_Private_Static_Void_IEnumerable_1_MonoBehaviour_PlayableGraph_List_1_Playable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000FA28 File Offset: 0x0000DC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477084, RefRangeEnd = 477085, XrefRangeStart = 477075, XrefRangeEnd = 477084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mixer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref portIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_ConnectMixerAndPlayable_Private_Static_Void_PlayableGraph_Playable_Playable_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000FA84 File Offset: 0x0000DC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477085, XrefRangeEnd = 477100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<T> GetComponent<T>(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.MethodInfoStoreGeneric_GetComponent_Internal_IList_1_T_GameObject_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477105, RefRangeEnd = 477106, XrefRangeStart = 477100, XrefRangeEnd = 477105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_GetControlableScripts_Internal_Static_IEnumerable_1_MonoBehaviour_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MonoBehaviour>>(intPtr3) : null;
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000FB18 File Offset: 0x0000DD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477106, XrefRangeEnd = 477180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(directors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particleSystems);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_UpdateDurationAndLoopFlag_Internal_Void_IList_1_PlayableDirector_IList_1_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477180, XrefRangeEnd = 477212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<ParticleSystem> GetControllableParticleSystems(GameObject go)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_GetControllableParticleSystems_Private_IList_1_ParticleSystem_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ParticleSystem>>(intPtr3) : null;
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000FBBC File Offset: 0x0000DDBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477246, RefRangeEnd = 477248, XrefRangeStart = 477212, XrefRangeEnd = 477246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roots);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subEmitters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_GetControllableParticleSystems_Private_Static_Void_Transform_ICollection_1_ParticleSystem_HashSet_1_ParticleSystem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000FC18 File Offset: 0x0000DE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477267, RefRangeEnd = 477268, XrefRangeStart = 477248, XrefRangeEnd = 477267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subEmitters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_CacheSubEmitters_Private_Static_Void_ParticleSystem_HashSet_1_ParticleSystem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000FC60 File Offset: 0x0000DE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477268, XrefRangeEnd = 477334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000FCB4 File Offset: 0x0000DEB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477368, RefRangeEnd = 477369, XrefRangeStart = 477334, XrefRangeEnd = 477368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_PreviewParticles_Internal_Static_Void_IPropertyCollector_IEnumerable_1_ParticleSystem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000FCFC File Offset: 0x0000DEFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477390, RefRangeEnd = 477391, XrefRangeStart = 477369, XrefRangeEnd = 477390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_PreviewActivation_Internal_Static_Void_IPropertyCollector_IEnumerable_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000FD44 File Offset: 0x0000DF44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477418, RefRangeEnd = 477419, XrefRangeStart = 477391, XrefRangeEnd = 477418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(director);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scripts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_PreviewTimeControl_Internal_Static_Void_IPropertyCollector_PlayableDirector_IEnumerable_1_MonoBehaviour_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000FDA0 File Offset: 0x0000DFA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477461, RefRangeEnd = 477462, XrefRangeStart = 477419, XrefRangeEnd = 477461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(directors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr_PreviewDirectors_Internal_Static_Void_IPropertyCollector_IEnumerable_1_PlayableDirector_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477462, XrefRangeEnd = 477510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlPlayableAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002D82 File Offset: 0x00000F82
		public ControlPlayableAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000FE24 File Offset: 0x0000E024
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00002D8B File Offset: 0x00000F8B
		public unsafe static int k_MaxRandInt
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ControlPlayableAsset.NativeFieldInfoPtr_k_MaxRandInt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControlPlayableAsset.NativeFieldInfoPtr_k_MaxRandInt, (void*)(&value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000FE40 File Offset: 0x0000E040
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00002D99 File Offset: 0x00000F99
		public unsafe static List<PlayableDirector> k_EmptyDirectorsList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ControlPlayableAsset.NativeFieldInfoPtr_k_EmptyDirectorsList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayableDirector>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControlPlayableAsset.NativeFieldInfoPtr_k_EmptyDirectorsList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000FE68 File Offset: 0x0000E068
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00002DAB File Offset: 0x00000FAB
		public unsafe static List<ParticleSystem> k_EmptyParticlesList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ControlPlayableAsset.NativeFieldInfoPtr_k_EmptyParticlesList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControlPlayableAsset.NativeFieldInfoPtr_k_EmptyParticlesList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000FE90 File Offset: 0x0000E090
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00002DBD File Offset: 0x00000FBD
		public unsafe static HashSet<ParticleSystem> s_SubEmitterCollector
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ControlPlayableAsset.NativeFieldInfoPtr_s_SubEmitterCollector, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControlPlayableAsset.NativeFieldInfoPtr_s_SubEmitterCollector, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00002DCF File Offset: 0x00000FCF
		public ExposedReference<GameObject> sourceGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_sourceGameObject);
				return new ExposedReference<GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExposedReference<GameObject>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_sourceGameObject), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExposedReference<GameObject>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00002DFD File Offset: 0x00000FFD
		public unsafe GameObject prefabGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_prefabGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_prefabGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000FF18 File Offset: 0x0000E118
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00002E1C File Offset: 0x0000101C
		public unsafe bool updateParticle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_updateParticle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_updateParticle)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000FF40 File Offset: 0x0000E140
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00002E37 File Offset: 0x00001037
		public unsafe uint particleRandomSeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_particleRandomSeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_particleRandomSeed)) = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000FF68 File Offset: 0x0000E168
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00002E52 File Offset: 0x00001052
		public unsafe bool updateDirector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_updateDirector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_updateDirector)) = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000FF90 File Offset: 0x0000E190
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00002E6D File Offset: 0x0000106D
		public unsafe bool updateITimeControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_updateITimeControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_updateITimeControl)) = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000FFB8 File Offset: 0x0000E1B8
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00002E88 File Offset: 0x00001088
		public unsafe bool searchHierarchy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_searchHierarchy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_searchHierarchy)) = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000FFE0 File Offset: 0x0000E1E0
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00002EA3 File Offset: 0x000010A3
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00010008 File Offset: 0x0000E208
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00002EBE File Offset: 0x000010BE
		public unsafe ActivationControlPlayable.PostPlaybackState postPlayback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_postPlayback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_postPlayback)) = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00010030 File Offset: 0x0000E230
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00002ED9 File Offset: 0x000010D9
		public unsafe PlayableAsset m_ControlDirectorAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_m_ControlDirectorAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_m_ControlDirectorAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00010060 File Offset: 0x0000E260
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00002EF8 File Offset: 0x000010F8
		public unsafe double m_Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_m_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_m_Duration)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00010088 File Offset: 0x0000E288
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00002F13 File Offset: 0x00001113
		public unsafe bool m_SupportLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_m_SupportLoop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr_m_SupportLoop)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x000100B0 File Offset: 0x0000E2B0
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00002F2E File Offset: 0x0000112E
		public unsafe static HashSet<PlayableDirector> s_ProcessedDirectors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ControlPlayableAsset.NativeFieldInfoPtr_s_ProcessedDirectors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<PlayableDirector>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControlPlayableAsset.NativeFieldInfoPtr_s_ProcessedDirectors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x000100D8 File Offset: 0x0000E2D8
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00002F40 File Offset: 0x00001140
		public unsafe static HashSet<GameObject> s_CreatedPrefabs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ControlPlayableAsset.NativeFieldInfoPtr_s_CreatedPrefabs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GameObject>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControlPlayableAsset.NativeFieldInfoPtr_s_CreatedPrefabs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00010100 File Offset: 0x0000E300
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00002F52 File Offset: 0x00001152
		public unsafe bool _controllingDirectors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr__controllingDirectors_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr__controllingDirectors_k__BackingField)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00010128 File Offset: 0x0000E328
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00002F6D File Offset: 0x0000116D
		public unsafe bool _controllingParticles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr__controllingParticles_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset.NativeFieldInfoPtr__controllingParticles_k__BackingField)) = value;
			}
		}

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxRandInt;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_k_EmptyDirectorsList;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_k_EmptyParticlesList;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_s_SubEmitterCollector;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_sourceGameObject;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_prefabGameObject;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_updateParticle;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_particleRandomSeed;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_updateDirector;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_updateITimeControl;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_searchHierarchy;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_postPlayback;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_m_ControlDirectorAsset;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_m_SupportLoop;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr_s_ProcessedDirectors;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr_s_CreatedPrefabs;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr__controllingDirectors_k__BackingField;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr__controllingParticles_k__BackingField;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_get_controllingDirectors_Internal_get_Boolean_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_set_controllingDirectors_Private_set_Void_Boolean_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_get_controllingParticles_Internal_get_Boolean_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_set_controllingParticles_Private_set_Void_Boolean_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_ConnectPlayablesToMixer_Private_Static_Playable_PlayableGraph_List_1_Playable_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_CreateActivationPlayable_Private_Void_GameObject_PlayableGraph_List_1_Playable_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_SearchHierarchyAndConnectParticleSystem_Private_Void_IEnumerable_1_ParticleSystem_PlayableGraph_List_1_Playable_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_SearchHierarchyAndConnectDirector_Private_Void_IEnumerable_1_PlayableDirector_PlayableGraph_List_1_Playable_Boolean_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_SearchHierarchyAndConnectControlableScripts_Private_Static_Void_IEnumerable_1_MonoBehaviour_PlayableGraph_List_1_Playable_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_ConnectMixerAndPlayable_Private_Static_Void_PlayableGraph_Playable_Playable_Int32_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Internal_IList_1_T_GameObject_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_GetControlableScripts_Internal_Static_IEnumerable_1_MonoBehaviour_GameObject_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDurationAndLoopFlag_Internal_Void_IList_1_PlayableDirector_IList_1_ParticleSystem_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_GetControllableParticleSystems_Private_IList_1_ParticleSystem_GameObject_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_GetControllableParticleSystems_Private_Static_Void_Transform_ICollection_1_ParticleSystem_HashSet_1_ParticleSystem_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_CacheSubEmitters_Private_Static_Void_ParticleSystem_HashSet_1_ParticleSystem_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_PreviewParticles_Internal_Static_Void_IPropertyCollector_IEnumerable_1_ParticleSystem_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_PreviewActivation_Internal_Static_Void_IPropertyCollector_IEnumerable_1_GameObject_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_PreviewTimeControl_Internal_Static_Void_IPropertyCollector_PlayableDirector_IEnumerable_1_MonoBehaviour_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_PreviewDirectors_Internal_Static_Void_IPropertyCollector_IEnumerable_1_PlayableDirector_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200006F RID: 111
		[ObfuscatedName("UnityEngine.Timeline.ControlPlayableAsset+<GetControlableScripts>d__39")]
		public sealed class _GetControlableScripts_d__39 : Object
		{
			// Token: 0x060005D5 RID: 1493 RVA: 0x0001AE60 File Offset: 0x00019060
			// Note: this type is marked as 'beforefieldinit'.
			static _GetControlableScripts_d__39()
			{
				Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr, "<GetControlableScripts>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr);
				ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, "<>1__state");
				ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, "<>2__current");
				ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, "<>l__initialThreadId");
				ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, "root");
				ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___3__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, "<>3__root");
				ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, "<>7__wrap1");
				ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, "<>7__wrap2");
				ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, 100663805);
				ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, 100663806);
				ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, 100663807);
				ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_MonoBehaviour__get_Current_Private_Virtual_Final_New_get_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, 100663808);
				ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, 100663809);
				ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, 100663810);
				ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_MonoBehaviour__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, 100663811);
				ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr, 100663812);
			}

			// Token: 0x060005D6 RID: 1494 RVA: 0x0001AFB8 File Offset: 0x000191B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetControlableScripts_d__39(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlPlayableAsset._GetControlableScripts_d__39>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005D7 RID: 1495 RVA: 0x0001B000 File Offset: 0x00019200
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005D8 RID: 1496 RVA: 0x0001B034 File Offset: 0x00019234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476815, XrefRangeEnd = 476834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001B070 File Offset: 0x00019270
			public unsafe MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_MonoBehaviour__get_Current_Private_Virtual_Final_New_get_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr3) : null;
				}
			}

			// Token: 0x060005DA RID: 1498 RVA: 0x0001B0B0 File Offset: 0x000192B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476834, XrefRangeEnd = 476839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x060005DB RID: 1499 RVA: 0x0001B0E4 File Offset: 0x000192E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060005DC RID: 1500 RVA: 0x0001B124 File Offset: 0x00019324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476839, XrefRangeEnd = 476847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<MonoBehaviour> System_Collections_Generic_IEnumerable_UnityEngine_MonoBehaviour__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_MonoBehaviour__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<MonoBehaviour>>(intPtr3) : null;
			}

			// Token: 0x060005DD RID: 1501 RVA: 0x0001B164 File Offset: 0x00019364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPlayableAsset._GetControlableScripts_d__39.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060005DE RID: 1502 RVA: 0x000040A8 File Offset: 0x000022A8
			public _GetControlableScripts_d__39(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001C2 RID: 450
			// (get) Token: 0x060005DF RID: 1503 RVA: 0x0001B1A4 File Offset: 0x000193A4
			// (set) Token: 0x060005E0 RID: 1504 RVA: 0x000040B1 File Offset: 0x000022B1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001C3 RID: 451
			// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001B1CC File Offset: 0x000193CC
			// (set) Token: 0x060005E2 RID: 1506 RVA: 0x000040CC File Offset: 0x000022CC
			public unsafe MonoBehaviour __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C4 RID: 452
			// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0001B1FC File Offset: 0x000193FC
			// (set) Token: 0x060005E4 RID: 1508 RVA: 0x000040EB File Offset: 0x000022EB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170001C5 RID: 453
			// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001B224 File Offset: 0x00019424
			// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00004106 File Offset: 0x00002306
			public unsafe GameObject root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr_root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0001B254 File Offset: 0x00019454
			// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00004125 File Offset: 0x00002325
			public unsafe GameObject __3__root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___3__root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___3__root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0001B284 File Offset: 0x00019484
			// (set) Token: 0x060005EA RID: 1514 RVA: 0x00004144 File Offset: 0x00002344
			public unsafe Il2CppReferenceArray<MonoBehaviour> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MonoBehaviour>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x060005EB RID: 1515 RVA: 0x0001B2B4 File Offset: 0x000194B4
			// (set) Token: 0x060005EC RID: 1516 RVA: 0x00004163 File Offset: 0x00002363
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlPlayableAsset._GetControlableScripts_d__39.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x0400048A RID: 1162
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400048B RID: 1163
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400048C RID: 1164
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400048D RID: 1165
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x0400048E RID: 1166
			private static readonly IntPtr NativeFieldInfoPtr___3__root;

			// Token: 0x0400048F RID: 1167
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000490 RID: 1168
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000491 RID: 1169
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000492 RID: 1170
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000493 RID: 1171
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000494 RID: 1172
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_MonoBehaviour__get_Current_Private_Virtual_Final_New_get_MonoBehaviour_0;

			// Token: 0x04000495 RID: 1173
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000496 RID: 1174
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000497 RID: 1175
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_MonoBehaviour__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MonoBehaviour_0;

			// Token: 0x04000498 RID: 1176
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000070 RID: 112
		private sealed class MethodInfoStoreGeneric_GetComponent_Internal_IList_1_T_GameObject_0<T>
		{
			// Token: 0x04000499 RID: 1177
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ControlPlayableAsset.NativeMethodInfoPtr_GetComponent_Internal_IList_1_T_GameObject_0, Il2CppClassPointerStore<ControlPlayableAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
