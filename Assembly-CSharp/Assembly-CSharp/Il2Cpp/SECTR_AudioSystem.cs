using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2Cpp
{
	// Token: 0x0200003C RID: 60
	public class SECTR_AudioSystem : MonoBehaviour
	{
		// Token: 0x06000982 RID: 2434 RVA: 0x00050538 File Offset: 0x0004E738
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_AudioSystem()
		{
			Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_AudioSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr);
			SECTR_AudioSystem.NativeFieldInfoPtr_system = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "system");
			SECTR_AudioSystem.NativeFieldInfoPtr_instancePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "instancePool");
			SECTR_AudioSystem.NativeFieldInfoPtr_simpleSourcePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "simpleSourcePool");
			SECTR_AudioSystem.NativeFieldInfoPtr_lowpassSourcePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "lowpassSourcePool");
			SECTR_AudioSystem.NativeFieldInfoPtr_prefabSourcePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "prefabSourcePool");
			SECTR_AudioSystem.NativeFieldInfoPtr_sourcePoolParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "sourcePoolParent");
			SECTR_AudioSystem.NativeFieldInfoPtr_activeInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "activeInstances");
			SECTR_AudioSystem.NativeFieldInfoPtr_maxInstancesTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "maxInstancesTable");
			SECTR_AudioSystem.NativeFieldInfoPtr_proximityTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "proximityTable");
			SECTR_AudioSystem.NativeFieldInfoPtr_RollOffCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "RollOffCurves");
			SECTR_AudioSystem.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "currentTime");
			SECTR_AudioSystem.NativeFieldInfoPtr_ambienceStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "ambienceStack");
			SECTR_AudioSystem.NativeFieldInfoPtr_currentAmbience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "currentAmbience");
			SECTR_AudioSystem.NativeFieldInfoPtr_ambienceLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "ambienceLoop");
			SECTR_AudioSystem.NativeFieldInfoPtr_ambienceOneShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "ambienceOneShot");
			SECTR_AudioSystem.NativeFieldInfoPtr_nextAmbienceOneShotTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "nextAmbienceOneShotTime");
			SECTR_AudioSystem.NativeFieldInfoPtr_currentMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "currentMusic");
			SECTR_AudioSystem.NativeFieldInfoPtr_musicLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "musicLoop");
			SECTR_AudioSystem.NativeFieldInfoPtr_windowHDRMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "windowHDRMax");
			SECTR_AudioSystem.NativeFieldInfoPtr_windowHDRMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "windowHDRMin");
			SECTR_AudioSystem.NativeFieldInfoPtr_currentLoudness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "currentLoudness");
			SECTR_AudioSystem.NativeFieldInfoPtr_occlusionPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "occlusionPath");
			SECTR_AudioSystem.NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "hit");
			SECTR_AudioSystem.NativeFieldInfoPtr_cachedMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "cachedMember");
			SECTR_AudioSystem.NativeFieldInfoPtr_EPSILON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "EPSILON");
			SECTR_AudioSystem.NativeFieldInfoPtr_Cues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "Cues");
			SECTR_AudioSystem.NativeFieldInfoPtr_MaxInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "MaxInstances");
			SECTR_AudioSystem.NativeFieldInfoPtr_LowpassInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "LowpassInstances");
			SECTR_AudioSystem.NativeFieldInfoPtr_Mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "Mixer");
			SECTR_AudioSystem.NativeFieldInfoPtr_UseResonance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "UseResonance");
			SECTR_AudioSystem.NativeFieldInfoPtr_ResonanceOcclusionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "ResonanceOcclusionPrefab");
			SECTR_AudioSystem.NativeFieldInfoPtr_ResonanceNoOcclusionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "ResonanceNoOcclusionPrefab");
			SECTR_AudioSystem.NativeFieldInfoPtr_MasterBus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "MasterBus");
			SECTR_AudioSystem.NativeFieldInfoPtr_DefaultAmbience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "DefaultAmbience");
			SECTR_AudioSystem.NativeFieldInfoPtr_HDRBaseLoudness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "HDRBaseLoudness");
			SECTR_AudioSystem.NativeFieldInfoPtr_HDRWindowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "HDRWindowSize");
			SECTR_AudioSystem.NativeFieldInfoPtr_HDRDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "HDRDecay");
			SECTR_AudioSystem.NativeFieldInfoPtr_BlendNearbySounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "BlendNearbySounds");
			SECTR_AudioSystem.NativeFieldInfoPtr_NearBlendRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "NearBlendRange");
			SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "OcclusionFlags");
			SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "OcclusionDistance");
			SECTR_AudioSystem.NativeFieldInfoPtr_RaycastLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "RaycastLayers");
			SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "OcclusionVolume");
			SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionCutoff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "OcclusionCutoff");
			SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionResonanceQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "OcclusionResonanceQ");
			SECTR_AudioSystem.NativeFieldInfoPtr_RetestInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "RetestInterval");
			SECTR_AudioSystem.NativeFieldInfoPtr_CullingBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "CullingBuffer");
			SECTR_AudioSystem.NativeFieldInfoPtr_ShowAudioHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "ShowAudioHUD");
			SECTR_AudioSystem.NativeFieldInfoPtr_HUDLineMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "HUDLineMaterial");
			SECTR_AudioSystem.NativeFieldInfoPtr_Debugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "Debugging");
			SECTR_AudioSystem.NativeFieldInfoPtr_ListenerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "ListenerPos");
			SECTR_AudioSystem.NativeFieldInfoPtr_rolloffsGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "rolloffsGenerated");
			SECTR_AudioSystem.NativeFieldInfoPtr_alt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "alt");
			SECTR_AudioSystem.NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664034);
			SECTR_AudioSystem.NativeMethodInfoPtr_get_Member_Public_Static_get_SECTR_Member_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664035);
			SECTR_AudioSystem.NativeMethodInfoPtr_get_System_Public_Static_get_SECTR_AudioSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664036);
			SECTR_AudioSystem.NativeMethodInfoPtr_get_Listener_Public_Static_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664037);
			SECTR_AudioSystem.NativeMethodInfoPtr_Logarithmic_Public_Static_AnimationCurve_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664038);
			SECTR_AudioSystem.NativeMethodInfoPtr_LogarithmicValue_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664039);
			SECTR_AudioSystem.NativeMethodInfoPtr_Play_Public_Static_SECTR_AudioCueInstance_SECTR_AudioCue_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664040);
			SECTR_AudioSystem.NativeMethodInfoPtr_PlayLoopThrough_Public_Static_SECTR_AudioCueInstance_SECTRLoopThrough_SECTR_AudioCue_Transform_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664041);
			SECTR_AudioSystem.NativeMethodInfoPtr_Play_Public_Static_SECTR_AudioCueInstance_SECTR_AudioCue_Transform_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664042);
			SECTR_AudioSystem.NativeMethodInfoPtr_Clone_Public_Static_SECTR_AudioCueInstance_SECTR_AudioCueInstance_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664043);
			SECTR_AudioSystem.NativeMethodInfoPtr_StopAll_Public_Static_Void_SECTR_AudioCue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664044);
			SECTR_AudioSystem.NativeMethodInfoPtr_PlayMusic_Public_Static_Void_SECTR_AudioCue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664045);
			SECTR_AudioSystem.NativeMethodInfoPtr_StopMusic_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664046);
			SECTR_AudioSystem.NativeMethodInfoPtr_PushAmbience_Public_Static_Void_SECTR_AudioAmbience_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664047);
			SECTR_AudioSystem.NativeMethodInfoPtr_RemoveAmbience_Public_Static_Void_SECTR_AudioAmbience_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664048);
			SECTR_AudioSystem.NativeMethodInfoPtr_SetBusVolume_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664049);
			SECTR_AudioSystem.NativeMethodInfoPtr_SetBusVolume_Public_Static_Void_SECTR_AudioBus_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664050);
			SECTR_AudioSystem.NativeMethodInfoPtr_MuteBus_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664051);
			SECTR_AudioSystem.NativeMethodInfoPtr_MuteBus_Public_Static_Void_SECTR_AudioBus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664052);
			SECTR_AudioSystem.NativeMethodInfoPtr_PauseBus_Public_Static_Void_SECTR_AudioBus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664053);
			SECTR_AudioSystem.NativeMethodInfoPtr_IsOccluded_Public_Static_Int32_Vector3_OcclusionModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664054);
			SECTR_AudioSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664055);
			SECTR_AudioSystem.NativeMethodInfoPtr_GenerateRollOffs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664056);
			SECTR_AudioSystem.NativeMethodInfoPtr_RetainAmbiance_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664057);
			SECTR_AudioSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664058);
			SECTR_AudioSystem.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664059);
			SECTR_AudioSystem.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664060);
			SECTR_AudioSystem.NativeMethodInfoPtr__CheckInstances_Private_Static_Boolean_SECTR_AudioCue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664061);
			SECTR_AudioSystem.NativeMethodInfoPtr__CheckProximity_Private_Static_Boolean_SECTR_AudioCue_Transform_Vector3_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664062);
			SECTR_AudioSystem.NativeMethodInfoPtr__UpdateTime_Private_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664063);
			SECTR_AudioSystem.NativeMethodInfoPtr__UpdateBusPitchVolume_Private_Static_Void_SECTR_AudioBus_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664064);
			SECTR_AudioSystem.NativeMethodInfoPtr__UpdateAmbience_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664065);
			SECTR_AudioSystem.NativeMethodInfoPtr__FindBus_Private_Static_SECTR_AudioBus_SECTR_AudioBus_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664066);
			SECTR_AudioSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, 100664067);
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00050C34 File Offset: 0x0004EE34
		public unsafe static bool Initialized
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 38488, RefRangeEnd = 38507, XrefRangeStart = 38472, XrefRangeEnd = 38488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00050C64 File Offset: 0x0004EE64
		public unsafe static SECTR_Member Member
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38507, XrefRangeEnd = 38511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_get_Member_Public_Static_get_SECTR_Member_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_Member>(intPtr3) : null;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x00050C98 File Offset: 0x0004EE98
		public unsafe static SECTR_AudioSystem System
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38511, XrefRangeEnd = 38515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_get_System_Public_Static_get_SECTR_AudioSystem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_AudioSystem>(intPtr3) : null;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00050CCC File Offset: 0x0004EECC
		public unsafe static Transform Listener
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 38524, RefRangeEnd = 38539, XrefRangeStart = 38515, XrefRangeEnd = 38524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_get_Listener_Public_Static_get_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00050D00 File Offset: 0x0004EF00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38566, RefRangeEnd = 38567, XrefRangeStart = 38539, XrefRangeEnd = 38566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationCurve Logarithmic(float timeStart, float timeEnd, float logBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_Logarithmic_Public_Static_AnimationCurve_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00050D5C File Offset: 0x0004EF5C
		[CallerCount(0)]
		public unsafe static float LogarithmicValue(float distance, float minDistance, float rolloffScale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref distance;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rolloffScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_LogarithmicValue_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00050DB8 File Offset: 0x0004EFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38567, XrefRangeEnd = 38571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SECTR_AudioCueInstance Play(SECTR_AudioCue audioCue, Vector3 position, bool loop)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioCue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_Play_Public_Static_SECTR_AudioCueInstance_SECTR_AudioCue_Vector3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SECTR_AudioCueInstance(intPtr);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00050E10 File Offset: 0x0004F010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38609, RefRangeEnd = 38611, XrefRangeStart = 38571, XrefRangeEnd = 38609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SECTR_AudioCueInstance PlayLoopThrough(SECTRLoopThrough _loopThrough, SECTR_AudioCue audioCue, Transform parent, Vector3 localPosition, bool loop)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_loopThrough);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(audioCue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localPosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_PlayLoopThrough_Public_Static_SECTR_AudioCueInstance_SECTRLoopThrough_SECTR_AudioCue_Transform_Vector3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SECTR_AudioCueInstance(intPtr);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00050E8C File Offset: 0x0004F08C
		[CallerCount(150)]
		[CachedScanResults(RefRangeStart = 38663, RefRangeEnd = 38813, XrefRangeStart = 38611, XrefRangeEnd = 38663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SECTR_AudioCueInstance Play(SECTR_AudioCue audioCue, Transform parent, Vector3 localPosition, bool loop)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioCue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_Play_Public_Static_SECTR_AudioCueInstance_SECTR_AudioCue_Transform_Vector3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SECTR_AudioCueInstance(intPtr);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00050EF8 File Offset: 0x0004F0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38813, XrefRangeEnd = 38836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SECTR_AudioCueInstance Clone(SECTR_AudioCueInstance instance, Vector3 newPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instance));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_Clone_Public_Static_SECTR_AudioCueInstance_SECTR_AudioCueInstance_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SECTR_AudioCueInstance(intPtr);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00050F48 File Offset: 0x0004F148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38836, XrefRangeEnd = 38867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopAll(SECTR_AudioCue cue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_StopAll_Public_Static_Void_SECTR_AudioCue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00050F80 File Offset: 0x0004F180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38906, RefRangeEnd = 38908, XrefRangeStart = 38867, XrefRangeEnd = 38906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayMusic(SECTR_AudioCue musicCue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(musicCue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_PlayMusic_Public_Static_Void_SECTR_AudioCue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00050FB8 File Offset: 0x0004F1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38908, XrefRangeEnd = 38917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopMusic(bool stopImmediate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopImmediate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_StopMusic_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00050FEC File Offset: 0x0004F1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38917, XrefRangeEnd = 38933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushAmbience(SECTR_AudioAmbience ambience)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ambience);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_PushAmbience_Public_Static_Void_SECTR_AudioAmbience_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00051024 File Offset: 0x0004F224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38933, XrefRangeEnd = 38942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveAmbience(SECTR_AudioAmbience ambience)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ambience);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_RemoveAmbience_Public_Static_Void_SECTR_AudioAmbience_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0005105C File Offset: 0x0004F25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38942, XrefRangeEnd = 38962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBusVolume(string busName, float volume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(busName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_SetBusVolume_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000510A0 File Offset: 0x0004F2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38962, XrefRangeEnd = 38972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBusVolume(SECTR_AudioBus bus, float volume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bus);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_SetBusVolume_Public_Static_Void_SECTR_AudioBus_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000510E4 File Offset: 0x0004F2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38972, XrefRangeEnd = 38992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MuteBus(string busName, bool mute)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(busName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_MuteBus_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00051128 File Offset: 0x0004F328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38992, XrefRangeEnd = 39002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MuteBus(SECTR_AudioBus bus, bool mute)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bus);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_MuteBus_Public_Static_Void_SECTR_AudioBus_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0005116C File Offset: 0x0004F36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39002, XrefRangeEnd = 39028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PauseBus(SECTR_AudioBus bus, bool paused)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bus);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paused;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_PauseBus_Public_Static_Void_SECTR_AudioBus_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000511B0 File Offset: 0x0004F3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39028, XrefRangeEnd = 39083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IsOccluded(Vector3 worldSpacePosition, SECTR_AudioSystem.OcclusionModes occlusionFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldSpacePosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref occlusionFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_IsOccluded_Public_Static_Int32_Vector3_OcclusionModes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000511FC File Offset: 0x0004F3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39083, XrefRangeEnd = 39148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00051230 File Offset: 0x0004F430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39183, RefRangeEnd = 39184, XrefRangeStart = 39148, XrefRangeEnd = 39183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRollOffs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_GenerateRollOffs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00051264 File Offset: 0x0004F464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39184, XrefRangeEnd = 39202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RetainAmbiance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_RetainAmbiance_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0005128C File Offset: 0x0004F48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39202, XrefRangeEnd = 39293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000512C0 File Offset: 0x0004F4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39293, XrefRangeEnd = 39294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000512F4 File Offset: 0x0004F4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39294, XrefRangeEnd = 39363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00051328 File Offset: 0x0004F528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39370, RefRangeEnd = 39372, XrefRangeStart = 39363, XrefRangeEnd = 39370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CheckInstances(SECTR_AudioCue audioCue, bool isPlaying)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioCue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPlaying;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr__CheckInstances_Private_Static_Boolean_SECTR_AudioCue_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00051378 File Offset: 0x0004F578
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 39390, RefRangeEnd = 39393, XrefRangeStart = 39372, XrefRangeEnd = 39390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CheckProximity(SECTR_AudioCue audioCue, Transform parent, Vector3 position, SECTR_AudioSystem.Instance testInstance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioCue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(testInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr__CheckProximity_Private_Static_Boolean_SECTR_AudioCue_Transform_Vector3_Instance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000513EC File Offset: 0x0004F5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39399, RefRangeEnd = 39400, XrefRangeStart = 39393, XrefRangeEnd = 39399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float _UpdateTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr__UpdateTime_Private_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0005141C File Offset: 0x0004F61C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39412, RefRangeEnd = 39414, XrefRangeStart = 39400, XrefRangeEnd = 39412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _UpdateBusPitchVolume(SECTR_AudioBus bus, float effectiveVolume, float effectivePitch)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bus);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref effectiveVolume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref effectivePitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr__UpdateBusPitchVolume_Private_Static_Void_SECTR_AudioBus_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00051470 File Offset: 0x0004F670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39548, RefRangeEnd = 39549, XrefRangeStart = 39414, XrefRangeEnd = 39548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _UpdateAmbience()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr__UpdateAmbience_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00051498 File Offset: 0x0004F698
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 39563, RefRangeEnd = 39566, XrefRangeStart = 39549, XrefRangeEnd = 39563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SECTR_AudioBus _FindBus(SECTR_AudioBus bus, string busName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bus);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(busName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr__FindBus_Private_Static_SECTR_AudioBus_SECTR_AudioBus_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_AudioBus>(intPtr3) : null;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000514F0 File Offset: 0x0004F6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39566, XrefRangeEnd = 39573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0000811C File Offset: 0x0000631C
		public SECTR_AudioSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0005152C File Offset: 0x0004F72C
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00008125 File Offset: 0x00006325
		public unsafe static SECTR_AudioSystem system
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_system, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioSystem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_system, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00051554 File Offset: 0x0004F754
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00008137 File Offset: 0x00006337
		public unsafe static Stack<SECTR_AudioSystem.Instance> instancePool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_instancePool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<SECTR_AudioSystem.Instance>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_instancePool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0005157C File Offset: 0x0004F77C
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00008149 File Offset: 0x00006349
		public unsafe static Stack<AudioSource> simpleSourcePool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_simpleSourcePool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<AudioSource>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_simpleSourcePool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x000515A4 File Offset: 0x0004F7A4
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x0000815B File Offset: 0x0000635B
		public unsafe static Stack<AudioSource> lowpassSourcePool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_lowpassSourcePool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<AudioSource>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_lowpassSourcePool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x000515CC File Offset: 0x0004F7CC
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x0000816D File Offset: 0x0000636D
		public unsafe static Dictionary<GameObject, Stack<AudioSource>> prefabSourcePool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_prefabSourcePool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, Stack<AudioSource>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_prefabSourcePool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x000515F4 File Offset: 0x0004F7F4
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x0000817F File Offset: 0x0000637F
		public unsafe static Transform sourcePoolParent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_sourcePoolParent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_sourcePoolParent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0005161C File Offset: 0x0004F81C
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x00008191 File Offset: 0x00006391
		public unsafe static List<SECTR_AudioSystem.Instance> activeInstances
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_activeInstances, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_AudioSystem.Instance>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_activeInstances, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x00051644 File Offset: 0x0004F844
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x000081A3 File Offset: 0x000063A3
		public unsafe static Dictionary<SECTR_AudioCue, int> maxInstancesTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_maxInstancesTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SECTR_AudioCue, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_maxInstancesTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0005166C File Offset: 0x0004F86C
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x000081B5 File Offset: 0x000063B5
		public unsafe static Dictionary<SECTR_AudioCue, List<SECTR_AudioSystem.Instance>> proximityTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_proximityTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SECTR_AudioCue, List<SECTR_AudioSystem.Instance>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_proximityTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00051694 File Offset: 0x0004F894
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x000081C7 File Offset: 0x000063C7
		public unsafe static Il2CppReferenceArray<AnimationCurve> RollOffCurves
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_RollOffCurves, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationCurve>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_RollOffCurves, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x000516BC File Offset: 0x0004F8BC
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x000081D9 File Offset: 0x000063D9
		public unsafe static float currentTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_currentTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_currentTime, (void*)(&value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x000516D8 File Offset: 0x0004F8D8
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x000081E7 File Offset: 0x000063E7
		public unsafe static List<SECTR_AudioAmbience> ambienceStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_ambienceStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_AudioAmbience>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_ambienceStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x00051700 File Offset: 0x0004F900
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x000081F9 File Offset: 0x000063F9
		public unsafe static SECTR_AudioAmbience currentAmbience
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_currentAmbience, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioAmbience>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_currentAmbience, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00051728 File Offset: 0x0004F928
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x0000820B File Offset: 0x0000640B
		public unsafe static SECTR_AudioCueInstance ambienceLoop
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_ambienceLoop, intPtr);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_ambienceLoop, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00051764 File Offset: 0x0004F964
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x00008222 File Offset: 0x00006422
		public unsafe static SECTR_AudioCueInstance ambienceOneShot
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_ambienceOneShot, intPtr);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_ambienceOneShot, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x000517A0 File Offset: 0x0004F9A0
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x00008239 File Offset: 0x00006439
		public unsafe static float nextAmbienceOneShotTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_nextAmbienceOneShotTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_nextAmbienceOneShotTime, (void*)(&value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x000517BC File Offset: 0x0004F9BC
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x00008247 File Offset: 0x00006447
		public unsafe static SECTR_AudioCue currentMusic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_currentMusic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_currentMusic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x000517E4 File Offset: 0x0004F9E4
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00008259 File Offset: 0x00006459
		public unsafe static SECTR_AudioCueInstance musicLoop
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_musicLoop, intPtr);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_musicLoop, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00051820 File Offset: 0x0004FA20
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00008270 File Offset: 0x00006470
		public unsafe static float windowHDRMax
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_windowHDRMax, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_windowHDRMax, (void*)(&value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0005183C File Offset: 0x0004FA3C
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x0000827E File Offset: 0x0000647E
		public unsafe static float windowHDRMin
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_windowHDRMin, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_windowHDRMin, (void*)(&value));
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00051858 File Offset: 0x0004FA58
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x0000828C File Offset: 0x0000648C
		public unsafe static float currentLoudness
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_currentLoudness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_currentLoudness, (void*)(&value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00051874 File Offset: 0x0004FA74
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x0000829A File Offset: 0x0000649A
		public unsafe static List<SECTR_Graph.Node> occlusionPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_occlusionPath, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Graph.Node>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_occlusionPath, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0005189C File Offset: 0x0004FA9C
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x000082AC File Offset: 0x000064AC
		public unsafe static Il2CppStructArray<RaycastHit2D> hit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_hit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_hit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x000518C4 File Offset: 0x0004FAC4
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x000082BE File Offset: 0x000064BE
		public unsafe static SECTR_Member cachedMember
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_cachedMember, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Member>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_cachedMember, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x000518EC File Offset: 0x0004FAEC
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x000082D0 File Offset: 0x000064D0
		public unsafe static float EPSILON
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_EPSILON, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_EPSILON, (void*)(&value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x00051908 File Offset: 0x0004FB08
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x000082DE File Offset: 0x000064DE
		public unsafe Il2CppReferenceArray<SECTR_AudioCue> Cues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_Cues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SECTR_AudioCue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_Cues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00051938 File Offset: 0x0004FB38
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x000082FD File Offset: 0x000064FD
		public unsafe int MaxInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_MaxInstances);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_MaxInstances)) = value;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00051960 File Offset: 0x0004FB60
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00008318 File Offset: 0x00006518
		public unsafe int LowpassInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_LowpassInstances);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_LowpassInstances)) = value;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00051988 File Offset: 0x0004FB88
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x00008333 File Offset: 0x00006533
		public unsafe AudioMixer Mixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_Mixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_Mixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x000519B8 File Offset: 0x0004FBB8
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00008352 File Offset: 0x00006552
		public unsafe bool UseResonance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_UseResonance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_UseResonance)) = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000519E0 File Offset: 0x0004FBE0
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x0000836D File Offset: 0x0000656D
		public unsafe GameObject ResonanceOcclusionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_ResonanceOcclusionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_ResonanceOcclusionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00051A10 File Offset: 0x0004FC10
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x0000838C File Offset: 0x0000658C
		public unsafe GameObject ResonanceNoOcclusionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_ResonanceNoOcclusionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_ResonanceNoOcclusionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00051A40 File Offset: 0x0004FC40
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x000083AB File Offset: 0x000065AB
		public unsafe SECTR_AudioBus MasterBus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_MasterBus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioBus>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_MasterBus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00051A70 File Offset: 0x0004FC70
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x000083CA File Offset: 0x000065CA
		public unsafe SECTR_AudioAmbience DefaultAmbience
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_DefaultAmbience);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioAmbience>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_DefaultAmbience), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00051AA0 File Offset: 0x0004FCA0
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x000083E9 File Offset: 0x000065E9
		public unsafe float HDRBaseLoudness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_HDRBaseLoudness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_HDRBaseLoudness)) = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00051AC8 File Offset: 0x0004FCC8
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x00008404 File Offset: 0x00006604
		public unsafe float HDRWindowSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_HDRWindowSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_HDRWindowSize)) = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00051AF0 File Offset: 0x0004FCF0
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x0000841F File Offset: 0x0000661F
		public unsafe float HDRDecay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_HDRDecay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_HDRDecay)) = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00051B18 File Offset: 0x0004FD18
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0000843A File Offset: 0x0000663A
		public unsafe bool BlendNearbySounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_BlendNearbySounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_BlendNearbySounds)) = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00051B40 File Offset: 0x0004FD40
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00008455 File Offset: 0x00006655
		public unsafe Vector2 NearBlendRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_NearBlendRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_NearBlendRange)) = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00051B68 File Offset: 0x0004FD68
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00008470 File Offset: 0x00006670
		public unsafe SECTR_AudioSystem.OcclusionModes OcclusionFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionFlags)) = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00051B90 File Offset: 0x0004FD90
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x0000848B File Offset: 0x0000668B
		public unsafe float OcclusionDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionDistance)) = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00051BB8 File Offset: 0x0004FDB8
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x000084A6 File Offset: 0x000066A6
		public unsafe LayerMask RaycastLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_RaycastLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_RaycastLayers)) = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00051BE0 File Offset: 0x0004FDE0
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x000084C1 File Offset: 0x000066C1
		public unsafe float OcclusionVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionVolume)) = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00051C08 File Offset: 0x0004FE08
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x000084DC File Offset: 0x000066DC
		public unsafe float OcclusionCutoff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionCutoff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionCutoff)) = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00051C30 File Offset: 0x0004FE30
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x000084F7 File Offset: 0x000066F7
		public unsafe float OcclusionResonanceQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionResonanceQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_OcclusionResonanceQ)) = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00051C58 File Offset: 0x0004FE58
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00008512 File Offset: 0x00006712
		public unsafe Vector2 RetestInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_RetestInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_RetestInterval)) = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00051C80 File Offset: 0x0004FE80
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x0000852D File Offset: 0x0000672D
		public unsafe float CullingBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_CullingBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_CullingBuffer)) = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00051CA8 File Offset: 0x0004FEA8
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00008548 File Offset: 0x00006748
		public unsafe bool ShowAudioHUD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_ShowAudioHUD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_ShowAudioHUD)) = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00051CD0 File Offset: 0x0004FED0
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00008563 File Offset: 0x00006763
		public unsafe Material HUDLineMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_HUDLineMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_HUDLineMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00051D00 File Offset: 0x0004FF00
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00008582 File Offset: 0x00006782
		public unsafe bool Debugging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_Debugging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_Debugging)) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00051D28 File Offset: 0x0004FF28
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x0000859D File Offset: 0x0000679D
		public unsafe static Vector2 ListenerPos
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(SECTR_AudioSystem.NativeFieldInfoPtr_ListenerPos, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_AudioSystem.NativeFieldInfoPtr_ListenerPos, (void*)(&value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00051D44 File Offset: 0x0004FF44
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x000085AB File Offset: 0x000067AB
		public unsafe bool rolloffsGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_rolloffsGenerated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_rolloffsGenerated)) = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00051D6C File Offset: 0x0004FF6C
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x000085C6 File Offset: 0x000067C6
		public unsafe bool alt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_alt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.NativeFieldInfoPtr_alt)) = value;
			}
		}

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeFieldInfoPtr_system;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeFieldInfoPtr_instancePool;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeFieldInfoPtr_simpleSourcePool;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_lowpassSourcePool;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_prefabSourcePool;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeFieldInfoPtr_sourcePoolParent;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeFieldInfoPtr_activeInstances;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeFieldInfoPtr_maxInstancesTable;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeFieldInfoPtr_proximityTable;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeFieldInfoPtr_RollOffCurves;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr_currentTime;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr_ambienceStack;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr_currentAmbience;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeFieldInfoPtr_ambienceLoop;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr_ambienceOneShot;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_nextAmbienceOneShotTime;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_currentMusic;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_musicLoop;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_windowHDRMax;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr_windowHDRMin;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr_currentLoudness;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr_occlusionPath;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr_hit;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr_cachedMember;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeFieldInfoPtr_EPSILON;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeFieldInfoPtr_Cues;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr_MaxInstances;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr_LowpassInstances;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr_Mixer;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeFieldInfoPtr_UseResonance;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeFieldInfoPtr_ResonanceOcclusionPrefab;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeFieldInfoPtr_ResonanceNoOcclusionPrefab;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeFieldInfoPtr_MasterBus;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAmbience;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeFieldInfoPtr_HDRBaseLoudness;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeFieldInfoPtr_HDRWindowSize;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeFieldInfoPtr_HDRDecay;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeFieldInfoPtr_BlendNearbySounds;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeFieldInfoPtr_NearBlendRange;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeFieldInfoPtr_OcclusionFlags;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr_OcclusionDistance;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr_RaycastLayers;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeFieldInfoPtr_OcclusionVolume;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr_OcclusionCutoff;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeFieldInfoPtr_OcclusionResonanceQ;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeFieldInfoPtr_RetestInterval;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeFieldInfoPtr_CullingBuffer;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeFieldInfoPtr_ShowAudioHUD;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeFieldInfoPtr_HUDLineMaterial;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeFieldInfoPtr_Debugging;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_ListenerPos;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr_rolloffsGenerated;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_alt;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_get_Member_Public_Static_get_SECTR_Member_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_get_System_Public_Static_get_SECTR_AudioSystem_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_get_Listener_Public_Static_get_Transform_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_Logarithmic_Public_Static_AnimationCurve_Single_Single_Single_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_LogarithmicValue_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_SECTR_AudioCueInstance_SECTR_AudioCue_Vector3_Boolean_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_PlayLoopThrough_Public_Static_SECTR_AudioCueInstance_SECTRLoopThrough_SECTR_AudioCue_Transform_Vector3_Boolean_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_SECTR_AudioCueInstance_SECTR_AudioCue_Transform_Vector3_Boolean_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_SECTR_AudioCueInstance_SECTR_AudioCueInstance_Vector3_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_StopAll_Public_Static_Void_SECTR_AudioCue_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_PlayMusic_Public_Static_Void_SECTR_AudioCue_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_StopMusic_Public_Static_Void_Boolean_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_PushAmbience_Public_Static_Void_SECTR_AudioAmbience_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAmbience_Public_Static_Void_SECTR_AudioAmbience_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_SetBusVolume_Public_Static_Void_String_Single_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_SetBusVolume_Public_Static_Void_SECTR_AudioBus_Single_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_MuteBus_Public_Static_Void_String_Boolean_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_MuteBus_Public_Static_Void_SECTR_AudioBus_Boolean_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_PauseBus_Public_Static_Void_SECTR_AudioBus_Boolean_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_IsOccluded_Public_Static_Int32_Vector3_OcclusionModes_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRollOffs_Private_Void_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_RetainAmbiance_Public_Static_Void_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr__CheckInstances_Private_Static_Boolean_SECTR_AudioCue_Boolean_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr__CheckProximity_Private_Static_Boolean_SECTR_AudioCue_Transform_Vector3_Instance_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr__UpdateTime_Private_Static_Single_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr__UpdateBusPitchVolume_Private_Static_Void_SECTR_AudioBus_Single_Single_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr__UpdateAmbience_Private_Static_Void_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr__FindBus_Private_Static_SECTR_AudioBus_SECTR_AudioBus_String_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002B5 RID: 693
		public class Instance : global::Il2CppSystem.Object
		{
			// Token: 0x06004B09 RID: 19209 RVA: 0x00115948 File Offset: 0x00113B48
			// Note: this type is marked as 'beforefieldinit'.
			static Instance()
			{
				Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_AudioSystem>.NativeClassPtr, "Instance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr);
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_OcclusionAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "OcclusionAmount");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_loopThrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "loopThrough");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_generation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "generation");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "source");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_sourceTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "sourceTransform");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_rsource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "rsource");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_lowpass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "lowpass");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_audioCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "audioCue");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "parent");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "localPosition");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "flags");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_nextTestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "nextTestTime");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_fadeStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "fadeStartTime");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_basePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "basePitch");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_baseVolumeLoudness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "baseVolumeLoudness");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_userVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "userVolume");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_userPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "userPitch");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_occlusionAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "occlusionAlpha");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_hdrCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "hdrCurve");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_paramTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "paramTable");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_volumeParamValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "volumeParamValues");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_pitchParamValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "pitchParamValues");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_attributeParamValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "attributeParamValues");
				SECTR_AudioSystem.Instance.NativeFieldInfoPtr_attributeParamBaseValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, "attributeParamBaseValues");
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Generation_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664069);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Active_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664070);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664071);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664072);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_LocalPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664073);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_LocalPosition_Public_Virtual_Final_New_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664074);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Volume_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664075);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_Volume_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664076);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Pitch_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664077);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_Pitch_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664078);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Mute_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664079);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_Mute_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664080);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Pause_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664081);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_Pause_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664082);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_TimeSeconds_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664083);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_TimeSeconds_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664084);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_TimeSamples_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664085);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_TimeSamples_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664086);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_ForceInfinite_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664087);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_ForceOcclusion_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664088);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_SetParameter_Public_Virtual_Final_New_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664089);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_GetInternalAudioSource_Public_Virtual_Final_New_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664090);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Loops_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664091);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Local_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664092);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_ThreeD_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664093);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_FadingIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664094);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_FadingOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664095);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Muted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664096);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Paused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664097);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_HDR_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664098);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Occludable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664099);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Occluded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664100);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_ForcedInfinite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664101);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Delayed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664102);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_LoopThroughCued_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664103);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_LoopThroughStopping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664104);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Bus_Public_get_SECTR_AudioBus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664105);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Cue_Public_get_SECTR_AudioCue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664106);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Init_Public_Void_SECTR_AudioCue_Transform_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664107);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Clone_Public_Void_Instance_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664108);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Uninit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664109);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664110);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664111);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Update_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664112);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr__SetFlag_Private_Void_Flags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664113);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr__GetFlag_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664114);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr__AcquireSource_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664115);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr__ReleaseSource_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664116);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr__AddProximityInstance_Private_Void_SECTR_AudioCue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664117);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr__ScheduleNextTest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664118);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr__Stop_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664119);
				SECTR_AudioSystem.Instance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr, 100664120);
			}

			// Token: 0x17001B5D RID: 7005
			// (get) Token: 0x06004B0A RID: 19210 RVA: 0x00115F64 File Offset: 0x00114164
			public unsafe virtual int Generation
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Generation_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B5E RID: 7006
			// (get) Token: 0x06004B0B RID: 19211 RVA: 0x00115FA0 File Offset: 0x001141A0
			public unsafe virtual bool Active
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 37607, RefRangeEnd = 37609, XrefRangeStart = 37601, XrefRangeEnd = 37607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Active_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B5F RID: 7007
			// (get) Token: 0x06004B0C RID: 19212 RVA: 0x00115FDC File Offset: 0x001141DC
			// (set) Token: 0x06004B0D RID: 19213 RVA: 0x00116018 File Offset: 0x00114218
			public unsafe virtual Vector3 Position
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 37615, RefRangeEnd = 37621, XrefRangeStart = 37609, XrefRangeEnd = 37615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 37636, RefRangeEnd = 37637, XrefRangeStart = 37621, XrefRangeEnd = 37636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001B60 RID: 7008
			// (get) Token: 0x06004B0E RID: 19214 RVA: 0x00116058 File Offset: 0x00114258
			// (set) Token: 0x06004B0F RID: 19215 RVA: 0x00116094 File Offset: 0x00114294
			public unsafe virtual Vector3 LocalPosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_LocalPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37637, XrefRangeEnd = 37644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_LocalPosition_Public_Virtual_Final_New_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001B61 RID: 7009
			// (get) Token: 0x06004B10 RID: 19216 RVA: 0x001160D4 File Offset: 0x001142D4
			// (set) Token: 0x06004B11 RID: 19217 RVA: 0x00116110 File Offset: 0x00114310
			public unsafe virtual float Volume
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Volume_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37644, XrefRangeEnd = 37646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_Volume_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001B62 RID: 7010
			// (get) Token: 0x06004B12 RID: 19218 RVA: 0x00116150 File Offset: 0x00114350
			// (set) Token: 0x06004B13 RID: 19219 RVA: 0x0011618C File Offset: 0x0011438C
			public unsafe virtual float Pitch
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Pitch_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37646, XrefRangeEnd = 37647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_Pitch_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001B63 RID: 7011
			// (get) Token: 0x06004B14 RID: 19220 RVA: 0x001161CC File Offset: 0x001143CC
			// (set) Token: 0x06004B15 RID: 19221 RVA: 0x00116208 File Offset: 0x00114408
			public unsafe virtual bool Mute
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Mute_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37647, XrefRangeEnd = 37652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_Mute_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001B64 RID: 7012
			// (get) Token: 0x06004B16 RID: 19222 RVA: 0x00116248 File Offset: 0x00114448
			// (set) Token: 0x06004B17 RID: 19223 RVA: 0x00116284 File Offset: 0x00114484
			public unsafe virtual bool Pause
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 37652, RefRangeEnd = 37655, XrefRangeStart = 37652, XrefRangeEnd = 37652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Pause_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 37660, RefRangeEnd = 37661, XrefRangeStart = 37655, XrefRangeEnd = 37660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_Pause_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001B65 RID: 7013
			// (get) Token: 0x06004B18 RID: 19224 RVA: 0x001162C4 File Offset: 0x001144C4
			// (set) Token: 0x06004B19 RID: 19225 RVA: 0x00116300 File Offset: 0x00114500
			public unsafe virtual float TimeSeconds
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37661, XrefRangeEnd = 37675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_TimeSeconds_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37675, XrefRangeEnd = 37680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_TimeSeconds_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001B66 RID: 7014
			// (get) Token: 0x06004B1A RID: 19226 RVA: 0x00116340 File Offset: 0x00114540
			// (set) Token: 0x06004B1B RID: 19227 RVA: 0x0011637C File Offset: 0x0011457C
			public unsafe virtual int TimeSamples
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37680, XrefRangeEnd = 37694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_TimeSamples_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37694, XrefRangeEnd = 37700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_set_TimeSamples_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004B1C RID: 19228 RVA: 0x001163BC File Offset: 0x001145BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37700, XrefRangeEnd = 37723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void ForceInfinite()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_ForceInfinite_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B1D RID: 19229 RVA: 0x001163F0 File Offset: 0x001145F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37723, XrefRangeEnd = 37728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void ForceOcclusion(bool occluded)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref occluded;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_ForceOcclusion_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B1E RID: 19230 RVA: 0x00116430 File Offset: 0x00114630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37728, XrefRangeEnd = 37757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetParameter(string param, float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_SetParameter_Public_Virtual_Final_New_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B1F RID: 19231 RVA: 0x00116480 File Offset: 0x00114680
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual AudioSource GetInternalAudioSource()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_GetInternalAudioSource_Public_Virtual_Final_New_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
			}

			// Token: 0x17001B67 RID: 7015
			// (get) Token: 0x06004B20 RID: 19232 RVA: 0x001164C0 File Offset: 0x001146C0
			public unsafe bool Loops
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Loops_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B68 RID: 7016
			// (get) Token: 0x06004B21 RID: 19233 RVA: 0x001164FC File Offset: 0x001146FC
			public unsafe bool Local
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Local_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B69 RID: 7017
			// (get) Token: 0x06004B22 RID: 19234 RVA: 0x00116538 File Offset: 0x00114738
			public unsafe bool ThreeD
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_ThreeD_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B6A RID: 7018
			// (get) Token: 0x06004B23 RID: 19235 RVA: 0x00116574 File Offset: 0x00114774
			public unsafe bool FadingIn
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_FadingIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B6B RID: 7019
			// (get) Token: 0x06004B24 RID: 19236 RVA: 0x001165B0 File Offset: 0x001147B0
			public unsafe bool FadingOut
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_FadingOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B6C RID: 7020
			// (get) Token: 0x06004B25 RID: 19237 RVA: 0x001165EC File Offset: 0x001147EC
			public unsafe bool Muted
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Muted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B6D RID: 7021
			// (get) Token: 0x06004B26 RID: 19238 RVA: 0x00116628 File Offset: 0x00114828
			public unsafe bool Paused
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 37652, RefRangeEnd = 37655, XrefRangeStart = 37652, XrefRangeEnd = 37655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Paused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B6E RID: 7022
			// (get) Token: 0x06004B27 RID: 19239 RVA: 0x00116664 File Offset: 0x00114864
			public unsafe bool HDR
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_HDR_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B6F RID: 7023
			// (get) Token: 0x06004B28 RID: 19240 RVA: 0x001166A0 File Offset: 0x001148A0
			public unsafe bool Occludable
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Occludable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B70 RID: 7024
			// (get) Token: 0x06004B29 RID: 19241 RVA: 0x001166DC File Offset: 0x001148DC
			public unsafe bool Occluded
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Occluded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B71 RID: 7025
			// (get) Token: 0x06004B2A RID: 19242 RVA: 0x00116718 File Offset: 0x00114918
			public unsafe bool ForcedInfinite
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_ForcedInfinite_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B72 RID: 7026
			// (get) Token: 0x06004B2B RID: 19243 RVA: 0x00116754 File Offset: 0x00114954
			public unsafe bool Delayed
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Delayed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B73 RID: 7027
			// (get) Token: 0x06004B2C RID: 19244 RVA: 0x00116790 File Offset: 0x00114990
			public unsafe bool LoopThroughCued
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_LoopThroughCued_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B74 RID: 7028
			// (get) Token: 0x06004B2D RID: 19245 RVA: 0x001167CC File Offset: 0x001149CC
			public unsafe bool LoopThroughStopping
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_LoopThroughStopping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001B75 RID: 7029
			// (get) Token: 0x06004B2E RID: 19246 RVA: 0x00116808 File Offset: 0x00114A08
			public unsafe SECTR_AudioBus Bus
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 37769, RefRangeEnd = 37773, XrefRangeStart = 37757, XrefRangeEnd = 37769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Bus_Public_get_SECTR_AudioBus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_AudioBus>(intPtr3) : null;
				}
			}

			// Token: 0x17001B76 RID: 7030
			// (get) Token: 0x06004B2F RID: 19247 RVA: 0x00116848 File Offset: 0x00114A48
			public unsafe SECTR_AudioCue Cue
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_get_Cue_Public_get_SECTR_AudioCue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr3) : null;
				}
			}

			// Token: 0x06004B30 RID: 19248 RVA: 0x00116888 File Offset: 0x00114A88
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37793, RefRangeEnd = 37795, XrefRangeStart = 37773, XrefRangeEnd = 37793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(SECTR_AudioCue audioCue, Transform parent, Vector3 localPosition, bool loops)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioCue);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localPosition;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loops;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Init_Public_Void_SECTR_AudioCue_Transform_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B31 RID: 19249 RVA: 0x001168F8 File Offset: 0x00114AF8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37814, RefRangeEnd = 37815, XrefRangeStart = 37795, XrefRangeEnd = 37814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clone(SECTR_AudioSystem.Instance instance, Vector3 newPosition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Clone_Public_Void_Instance_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B32 RID: 19250 RVA: 0x00116948 File Offset: 0x00114B48
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37850, RefRangeEnd = 37851, XrefRangeStart = 37815, XrefRangeEnd = 37850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Uninit()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Uninit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B33 RID: 19251 RVA: 0x0011697C File Offset: 0x00114B7C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37918, RefRangeEnd = 37920, XrefRangeStart = 37851, XrefRangeEnd = 37918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Play()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B34 RID: 19252 RVA: 0x001169B0 File Offset: 0x00114BB0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37934, RefRangeEnd = 37936, XrefRangeStart = 37920, XrefRangeEnd = 37934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Stop(bool stopImmediately)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref stopImmediately;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B35 RID: 19253 RVA: 0x001169F0 File Offset: 0x00114BF0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 38123, RefRangeEnd = 38129, XrefRangeStart = 37936, XrefRangeEnd = 38123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update(float deltaTime, bool volumeOnly)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref deltaTime;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr_Update_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B36 RID: 19254 RVA: 0x00116A3C File Offset: 0x00114C3C
			[CallerCount(0)]
			public unsafe void _SetFlag(SECTR_AudioSystem.Instance.Flags flag, bool on)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref flag;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr__SetFlag_Private_Void_Flags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B37 RID: 19255 RVA: 0x00116A88 File Offset: 0x00114C88
			[CallerCount(0)]
			public unsafe bool _GetFlag(SECTR_AudioSystem.Instance.Flags flag)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref flag;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr__GetFlag_Private_Boolean_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B38 RID: 19256 RVA: 0x00116AD4 File Offset: 0x00114CD4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 38324, RefRangeEnd = 38326, XrefRangeStart = 38129, XrefRangeEnd = 38324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AcquireSource()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr__AcquireSource_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004B39 RID: 19257 RVA: 0x00116B10 File Offset: 0x00114D10
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38389, RefRangeEnd = 38392, XrefRangeStart = 38326, XrefRangeEnd = 38389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReleaseSource()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr__ReleaseSource_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B3A RID: 19258 RVA: 0x00116B44 File Offset: 0x00114D44
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 38413, RefRangeEnd = 38415, XrefRangeStart = 38392, XrefRangeEnd = 38413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddProximityInstance(SECTR_AudioCue srcCue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcCue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr__AddProximityInstance_Private_Void_SECTR_AudioCue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B3B RID: 19259 RVA: 0x00116B88 File Offset: 0x00114D88
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 38420, RefRangeEnd = 38424, XrefRangeStart = 38415, XrefRangeEnd = 38420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ScheduleNextTest()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr__ScheduleNextTest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B3C RID: 19260 RVA: 0x00116BBC File Offset: 0x00114DBC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 38447, RefRangeEnd = 38449, XrefRangeStart = 38424, XrefRangeEnd = 38447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Stop(bool stopImmediately)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref stopImmediately;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr__Stop_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B3D RID: 19261 RVA: 0x00116BFC File Offset: 0x00114DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38449, XrefRangeEnd = 38472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Instance()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioSystem.Instance>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSystem.Instance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B3E RID: 19262 RVA: 0x0002C249 File Offset: 0x0002A449
			public Instance(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B45 RID: 6981
			// (get) Token: 0x06004B3F RID: 19263 RVA: 0x00116C38 File Offset: 0x00114E38
			// (set) Token: 0x06004B40 RID: 19264 RVA: 0x0002C252 File Offset: 0x0002A452
			public unsafe int OcclusionAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_OcclusionAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_OcclusionAmount)) = value;
				}
			}

			// Token: 0x17001B46 RID: 6982
			// (get) Token: 0x06004B41 RID: 19265 RVA: 0x00116C60 File Offset: 0x00114E60
			// (set) Token: 0x06004B42 RID: 19266 RVA: 0x0002C26D File Offset: 0x0002A46D
			public unsafe SECTRLoopThrough loopThrough
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_loopThrough);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTRLoopThrough>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_loopThrough), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B47 RID: 6983
			// (get) Token: 0x06004B43 RID: 19267 RVA: 0x00116C90 File Offset: 0x00114E90
			// (set) Token: 0x06004B44 RID: 19268 RVA: 0x0002C28C File Offset: 0x0002A48C
			public unsafe int generation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_generation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_generation)) = value;
				}
			}

			// Token: 0x17001B48 RID: 6984
			// (get) Token: 0x06004B45 RID: 19269 RVA: 0x00116CB8 File Offset: 0x00114EB8
			// (set) Token: 0x06004B46 RID: 19270 RVA: 0x0002C2A7 File Offset: 0x0002A4A7
			public unsafe AudioSource source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B49 RID: 6985
			// (get) Token: 0x06004B47 RID: 19271 RVA: 0x00116CE8 File Offset: 0x00114EE8
			// (set) Token: 0x06004B48 RID: 19272 RVA: 0x0002C2C6 File Offset: 0x0002A4C6
			public unsafe Transform sourceTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_sourceTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_sourceTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4A RID: 6986
			// (get) Token: 0x06004B49 RID: 19273 RVA: 0x00116D18 File Offset: 0x00114F18
			// (set) Token: 0x06004B4A RID: 19274 RVA: 0x0002C2E5 File Offset: 0x0002A4E5
			public unsafe ResonanceAudioSource rsource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_rsource);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceAudioSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_rsource), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4B RID: 6987
			// (get) Token: 0x06004B4B RID: 19275 RVA: 0x00116D48 File Offset: 0x00114F48
			// (set) Token: 0x06004B4C RID: 19276 RVA: 0x0002C304 File Offset: 0x0002A504
			public unsafe AudioLowPassFilter lowpass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_lowpass);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioLowPassFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_lowpass), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4C RID: 6988
			// (get) Token: 0x06004B4D RID: 19277 RVA: 0x00116D78 File Offset: 0x00114F78
			// (set) Token: 0x06004B4E RID: 19278 RVA: 0x0002C323 File Offset: 0x0002A523
			public unsafe SECTR_AudioCue audioCue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_audioCue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_audioCue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4D RID: 6989
			// (get) Token: 0x06004B4F RID: 19279 RVA: 0x00116DA8 File Offset: 0x00114FA8
			// (set) Token: 0x06004B50 RID: 19280 RVA: 0x0002C342 File Offset: 0x0002A542
			public unsafe Transform parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4E RID: 6990
			// (get) Token: 0x06004B51 RID: 19281 RVA: 0x00116DD8 File Offset: 0x00114FD8
			// (set) Token: 0x06004B52 RID: 19282 RVA: 0x0002C361 File Offset: 0x0002A561
			public unsafe Vector3 localPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_localPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_localPosition)) = value;
				}
			}

			// Token: 0x17001B4F RID: 6991
			// (get) Token: 0x06004B53 RID: 19283 RVA: 0x00116E00 File Offset: 0x00115000
			// (set) Token: 0x06004B54 RID: 19284 RVA: 0x0002C37C File Offset: 0x0002A57C
			public unsafe SECTR_AudioSystem.Instance.Flags flags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_flags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_flags)) = value;
				}
			}

			// Token: 0x17001B50 RID: 6992
			// (get) Token: 0x06004B55 RID: 19285 RVA: 0x00116E28 File Offset: 0x00115028
			// (set) Token: 0x06004B56 RID: 19286 RVA: 0x0002C397 File Offset: 0x0002A597
			public unsafe float nextTestTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_nextTestTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_nextTestTime)) = value;
				}
			}

			// Token: 0x17001B51 RID: 6993
			// (get) Token: 0x06004B57 RID: 19287 RVA: 0x00116E50 File Offset: 0x00115050
			// (set) Token: 0x06004B58 RID: 19288 RVA: 0x0002C3B2 File Offset: 0x0002A5B2
			public unsafe float fadeStartTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_fadeStartTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_fadeStartTime)) = value;
				}
			}

			// Token: 0x17001B52 RID: 6994
			// (get) Token: 0x06004B59 RID: 19289 RVA: 0x00116E78 File Offset: 0x00115078
			// (set) Token: 0x06004B5A RID: 19290 RVA: 0x0002C3CD File Offset: 0x0002A5CD
			public unsafe float basePitch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_basePitch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_basePitch)) = value;
				}
			}

			// Token: 0x17001B53 RID: 6995
			// (get) Token: 0x06004B5B RID: 19291 RVA: 0x00116EA0 File Offset: 0x001150A0
			// (set) Token: 0x06004B5C RID: 19292 RVA: 0x0002C3E8 File Offset: 0x0002A5E8
			public unsafe float baseVolumeLoudness
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_baseVolumeLoudness);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_baseVolumeLoudness)) = value;
				}
			}

			// Token: 0x17001B54 RID: 6996
			// (get) Token: 0x06004B5D RID: 19293 RVA: 0x00116EC8 File Offset: 0x001150C8
			// (set) Token: 0x06004B5E RID: 19294 RVA: 0x0002C403 File Offset: 0x0002A603
			public unsafe float userVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_userVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_userVolume)) = value;
				}
			}

			// Token: 0x17001B55 RID: 6997
			// (get) Token: 0x06004B5F RID: 19295 RVA: 0x00116EF0 File Offset: 0x001150F0
			// (set) Token: 0x06004B60 RID: 19296 RVA: 0x0002C41E File Offset: 0x0002A61E
			public unsafe float userPitch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_userPitch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_userPitch)) = value;
				}
			}

			// Token: 0x17001B56 RID: 6998
			// (get) Token: 0x06004B61 RID: 19297 RVA: 0x00116F18 File Offset: 0x00115118
			// (set) Token: 0x06004B62 RID: 19298 RVA: 0x0002C439 File Offset: 0x0002A639
			public unsafe float occlusionAlpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_occlusionAlpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_occlusionAlpha)) = value;
				}
			}

			// Token: 0x17001B57 RID: 6999
			// (get) Token: 0x06004B63 RID: 19299 RVA: 0x00116F40 File Offset: 0x00115140
			// (set) Token: 0x06004B64 RID: 19300 RVA: 0x0002C454 File Offset: 0x0002A654
			public unsafe AnimationCurve hdrCurve
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_hdrCurve);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_hdrCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B58 RID: 7000
			// (get) Token: 0x06004B65 RID: 19301 RVA: 0x00116F70 File Offset: 0x00115170
			// (set) Token: 0x06004B66 RID: 19302 RVA: 0x0002C473 File Offset: 0x0002A673
			public unsafe Dictionary<SECTR_CueParam, float> paramTable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_paramTable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SECTR_CueParam, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_paramTable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B59 RID: 7001
			// (get) Token: 0x06004B67 RID: 19303 RVA: 0x00116FA0 File Offset: 0x001151A0
			// (set) Token: 0x06004B68 RID: 19304 RVA: 0x0002C492 File Offset: 0x0002A692
			public unsafe List<float> volumeParamValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_volumeParamValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_volumeParamValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B5A RID: 7002
			// (get) Token: 0x06004B69 RID: 19305 RVA: 0x00116FD0 File Offset: 0x001151D0
			// (set) Token: 0x06004B6A RID: 19306 RVA: 0x0002C4B1 File Offset: 0x0002A6B1
			public unsafe List<float> pitchParamValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_pitchParamValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_pitchParamValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B5B RID: 7003
			// (get) Token: 0x06004B6B RID: 19307 RVA: 0x00117000 File Offset: 0x00115200
			// (set) Token: 0x06004B6C RID: 19308 RVA: 0x0002C4D0 File Offset: 0x0002A6D0
			public unsafe Dictionary<SECTR_CueParam.AttributeData, float> attributeParamValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_attributeParamValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SECTR_CueParam.AttributeData, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_attributeParamValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B5C RID: 7004
			// (get) Token: 0x06004B6D RID: 19309 RVA: 0x00117030 File Offset: 0x00115230
			// (set) Token: 0x06004B6E RID: 19310 RVA: 0x0002C4EF File Offset: 0x0002A6EF
			public unsafe Dictionary<SECTR_CueParam.AttributeData, float> attributeParamBaseValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_attributeParamBaseValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SECTR_CueParam.AttributeData, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSystem.Instance.NativeFieldInfoPtr_attributeParamBaseValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400312B RID: 12587
			private static readonly IntPtr NativeFieldInfoPtr_OcclusionAmount;

			// Token: 0x0400312C RID: 12588
			private static readonly IntPtr NativeFieldInfoPtr_loopThrough;

			// Token: 0x0400312D RID: 12589
			private static readonly IntPtr NativeFieldInfoPtr_generation;

			// Token: 0x0400312E RID: 12590
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400312F RID: 12591
			private static readonly IntPtr NativeFieldInfoPtr_sourceTransform;

			// Token: 0x04003130 RID: 12592
			private static readonly IntPtr NativeFieldInfoPtr_rsource;

			// Token: 0x04003131 RID: 12593
			private static readonly IntPtr NativeFieldInfoPtr_lowpass;

			// Token: 0x04003132 RID: 12594
			private static readonly IntPtr NativeFieldInfoPtr_audioCue;

			// Token: 0x04003133 RID: 12595
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x04003134 RID: 12596
			private static readonly IntPtr NativeFieldInfoPtr_localPosition;

			// Token: 0x04003135 RID: 12597
			private static readonly IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x04003136 RID: 12598
			private static readonly IntPtr NativeFieldInfoPtr_nextTestTime;

			// Token: 0x04003137 RID: 12599
			private static readonly IntPtr NativeFieldInfoPtr_fadeStartTime;

			// Token: 0x04003138 RID: 12600
			private static readonly IntPtr NativeFieldInfoPtr_basePitch;

			// Token: 0x04003139 RID: 12601
			private static readonly IntPtr NativeFieldInfoPtr_baseVolumeLoudness;

			// Token: 0x0400313A RID: 12602
			private static readonly IntPtr NativeFieldInfoPtr_userVolume;

			// Token: 0x0400313B RID: 12603
			private static readonly IntPtr NativeFieldInfoPtr_userPitch;

			// Token: 0x0400313C RID: 12604
			private static readonly IntPtr NativeFieldInfoPtr_occlusionAlpha;

			// Token: 0x0400313D RID: 12605
			private static readonly IntPtr NativeFieldInfoPtr_hdrCurve;

			// Token: 0x0400313E RID: 12606
			private static readonly IntPtr NativeFieldInfoPtr_paramTable;

			// Token: 0x0400313F RID: 12607
			private static readonly IntPtr NativeFieldInfoPtr_volumeParamValues;

			// Token: 0x04003140 RID: 12608
			private static readonly IntPtr NativeFieldInfoPtr_pitchParamValues;

			// Token: 0x04003141 RID: 12609
			private static readonly IntPtr NativeFieldInfoPtr_attributeParamValues;

			// Token: 0x04003142 RID: 12610
			private static readonly IntPtr NativeFieldInfoPtr_attributeParamBaseValues;

			// Token: 0x04003143 RID: 12611
			private static readonly IntPtr NativeMethodInfoPtr_get_Generation_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04003144 RID: 12612
			private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04003145 RID: 12613
			private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04003146 RID: 12614
			private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector3_0;

			// Token: 0x04003147 RID: 12615
			private static readonly IntPtr NativeMethodInfoPtr_get_LocalPosition_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04003148 RID: 12616
			private static readonly IntPtr NativeMethodInfoPtr_set_LocalPosition_Public_Virtual_Final_New_set_Void_Vector3_0;

			// Token: 0x04003149 RID: 12617
			private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x0400314A RID: 12618
			private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Public_Virtual_Final_New_set_Void_Single_0;

			// Token: 0x0400314B RID: 12619
			private static readonly IntPtr NativeMethodInfoPtr_get_Pitch_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x0400314C RID: 12620
			private static readonly IntPtr NativeMethodInfoPtr_set_Pitch_Public_Virtual_Final_New_set_Void_Single_0;

			// Token: 0x0400314D RID: 12621
			private static readonly IntPtr NativeMethodInfoPtr_get_Mute_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400314E RID: 12622
			private static readonly IntPtr NativeMethodInfoPtr_set_Mute_Public_Virtual_Final_New_set_Void_Boolean_0;

			// Token: 0x0400314F RID: 12623
			private static readonly IntPtr NativeMethodInfoPtr_get_Pause_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04003150 RID: 12624
			private static readonly IntPtr NativeMethodInfoPtr_set_Pause_Public_Virtual_Final_New_set_Void_Boolean_0;

			// Token: 0x04003151 RID: 12625
			private static readonly IntPtr NativeMethodInfoPtr_get_TimeSeconds_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04003152 RID: 12626
			private static readonly IntPtr NativeMethodInfoPtr_set_TimeSeconds_Public_Virtual_Final_New_set_Void_Single_0;

			// Token: 0x04003153 RID: 12627
			private static readonly IntPtr NativeMethodInfoPtr_get_TimeSamples_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04003154 RID: 12628
			private static readonly IntPtr NativeMethodInfoPtr_set_TimeSamples_Public_Virtual_Final_New_set_Void_Int32_0;

			// Token: 0x04003155 RID: 12629
			private static readonly IntPtr NativeMethodInfoPtr_ForceInfinite_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003156 RID: 12630
			private static readonly IntPtr NativeMethodInfoPtr_ForceOcclusion_Public_Virtual_Final_New_Void_Boolean_0;

			// Token: 0x04003157 RID: 12631
			private static readonly IntPtr NativeMethodInfoPtr_SetParameter_Public_Virtual_Final_New_Void_String_Single_0;

			// Token: 0x04003158 RID: 12632
			private static readonly IntPtr NativeMethodInfoPtr_GetInternalAudioSource_Public_Virtual_Final_New_AudioSource_0;

			// Token: 0x04003159 RID: 12633
			private static readonly IntPtr NativeMethodInfoPtr_get_Loops_Public_get_Boolean_0;

			// Token: 0x0400315A RID: 12634
			private static readonly IntPtr NativeMethodInfoPtr_get_Local_Public_get_Boolean_0;

			// Token: 0x0400315B RID: 12635
			private static readonly IntPtr NativeMethodInfoPtr_get_ThreeD_Public_get_Boolean_0;

			// Token: 0x0400315C RID: 12636
			private static readonly IntPtr NativeMethodInfoPtr_get_FadingIn_Public_get_Boolean_0;

			// Token: 0x0400315D RID: 12637
			private static readonly IntPtr NativeMethodInfoPtr_get_FadingOut_Public_get_Boolean_0;

			// Token: 0x0400315E RID: 12638
			private static readonly IntPtr NativeMethodInfoPtr_get_Muted_Public_get_Boolean_0;

			// Token: 0x0400315F RID: 12639
			private static readonly IntPtr NativeMethodInfoPtr_get_Paused_Public_get_Boolean_0;

			// Token: 0x04003160 RID: 12640
			private static readonly IntPtr NativeMethodInfoPtr_get_HDR_Public_get_Boolean_0;

			// Token: 0x04003161 RID: 12641
			private static readonly IntPtr NativeMethodInfoPtr_get_Occludable_Public_get_Boolean_0;

			// Token: 0x04003162 RID: 12642
			private static readonly IntPtr NativeMethodInfoPtr_get_Occluded_Public_get_Boolean_0;

			// Token: 0x04003163 RID: 12643
			private static readonly IntPtr NativeMethodInfoPtr_get_ForcedInfinite_Public_get_Boolean_0;

			// Token: 0x04003164 RID: 12644
			private static readonly IntPtr NativeMethodInfoPtr_get_Delayed_Public_get_Boolean_0;

			// Token: 0x04003165 RID: 12645
			private static readonly IntPtr NativeMethodInfoPtr_get_LoopThroughCued_Public_get_Boolean_0;

			// Token: 0x04003166 RID: 12646
			private static readonly IntPtr NativeMethodInfoPtr_get_LoopThroughStopping_Public_get_Boolean_0;

			// Token: 0x04003167 RID: 12647
			private static readonly IntPtr NativeMethodInfoPtr_get_Bus_Public_get_SECTR_AudioBus_0;

			// Token: 0x04003168 RID: 12648
			private static readonly IntPtr NativeMethodInfoPtr_get_Cue_Public_get_SECTR_AudioCue_0;

			// Token: 0x04003169 RID: 12649
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_SECTR_AudioCue_Transform_Vector3_Boolean_0;

			// Token: 0x0400316A RID: 12650
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Void_Instance_Vector3_0;

			// Token: 0x0400316B RID: 12651
			private static readonly IntPtr NativeMethodInfoPtr_Uninit_Public_Void_0;

			// Token: 0x0400316C RID: 12652
			private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

			// Token: 0x0400316D RID: 12653
			private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_Boolean_0;

			// Token: 0x0400316E RID: 12654
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_Boolean_0;

			// Token: 0x0400316F RID: 12655
			private static readonly IntPtr NativeMethodInfoPtr__SetFlag_Private_Void_Flags_Boolean_0;

			// Token: 0x04003170 RID: 12656
			private static readonly IntPtr NativeMethodInfoPtr__GetFlag_Private_Boolean_Flags_0;

			// Token: 0x04003171 RID: 12657
			private static readonly IntPtr NativeMethodInfoPtr__AcquireSource_Private_Boolean_0;

			// Token: 0x04003172 RID: 12658
			private static readonly IntPtr NativeMethodInfoPtr__ReleaseSource_Private_Void_0;

			// Token: 0x04003173 RID: 12659
			private static readonly IntPtr NativeMethodInfoPtr__AddProximityInstance_Private_Void_SECTR_AudioCue_0;

			// Token: 0x04003174 RID: 12660
			private static readonly IntPtr NativeMethodInfoPtr__ScheduleNextTest_Private_Void_0;

			// Token: 0x04003175 RID: 12661
			private static readonly IntPtr NativeMethodInfoPtr__Stop_Private_Void_Boolean_0;

			// Token: 0x04003176 RID: 12662
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x020003FB RID: 1019
			[OriginalName("Assembly-CSharp.dll", "", "Flags")]
			[Flags]
			public enum Flags
			{
				// Token: 0x04003CC4 RID: 15556
				Loops = 1,
				// Token: 0x04003CC5 RID: 15557
				FadingIn = 2,
				// Token: 0x04003CC6 RID: 15558
				FadingOut = 4,
				// Token: 0x04003CC7 RID: 15559
				Muted = 8,
				// Token: 0x04003CC8 RID: 15560
				Local = 16,
				// Token: 0x04003CC9 RID: 15561
				ThreeD = 32,
				// Token: 0x04003CCA RID: 15562
				Paused = 64,
				// Token: 0x04003CCB RID: 15563
				HDR = 128,
				// Token: 0x04003CCC RID: 15564
				Occludable = 256,
				// Token: 0x04003CCD RID: 15565
				Occluded = 512,
				// Token: 0x04003CCE RID: 15566
				ForcedInfinite = 1024,
				// Token: 0x04003CCF RID: 15567
				Delayed = 2048,
				// Token: 0x04003CD0 RID: 15568
				LoopThroughCued = 4096,
				// Token: 0x04003CD1 RID: 15569
				LoopThroughStopping = 8192
			}
		}

		// Token: 0x020002B6 RID: 694
		[OriginalName("Assembly-CSharp.dll", "", "OcclusionModes")]
		[Flags]
		public enum OcclusionModes
		{
			// Token: 0x04003178 RID: 12664
			Graph = 1,
			// Token: 0x04003179 RID: 12665
			Raycast = 2,
			// Token: 0x0400317A RID: 12666
			Distance = 4
		}
	}
}
