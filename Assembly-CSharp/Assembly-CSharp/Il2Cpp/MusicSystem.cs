using System;
using Il2CppAudioHelm;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMusicUtils;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2Cpp
{
	// Token: 0x0200000B RID: 11
	public class MusicSystem : MonoBehaviour
	{
		// Token: 0x060000CF RID: 207 RVA: 0x0003677C File Offset: 0x0003497C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicSystem()
		{
			Il2CppClassPointerStore<MusicSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MusicSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr);
			MusicSystem.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "me");
			MusicSystem.NativeFieldInfoPtr_Mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "Mixer");
			MusicSystem.NativeFieldInfoPtr_PrimarySequencer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "PrimarySequencer");
			MusicSystem.NativeFieldInfoPtr_SecondarySequencer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "SecondarySequencer");
			MusicSystem.NativeFieldInfoPtr_TransitionSequencer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "TransitionSequencer");
			MusicSystem.NativeFieldInfoPtr_Sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "Sampler");
			MusicSystem.NativeFieldInfoPtr_AltSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "AltSampler");
			MusicSystem.NativeFieldInfoPtr_Clock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "Clock");
			MusicSystem.NativeFieldInfoPtr_ActivePatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "ActivePatch");
			MusicSystem.NativeFieldInfoPtr_StickSeqPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "StickSeqPath");
			MusicSystem.NativeFieldInfoPtr_BrushSeqPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "BrushSeqPath");
			MusicSystem.NativeFieldInfoPtr_FunkySeqPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "FunkySeqPath");
			MusicSystem.NativeFieldInfoPtr_CongasSeqPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "CongasSeqPath");
			MusicSystem.NativeFieldInfoPtr_MilitarySeqPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "MilitarySeqPath");
			MusicSystem.NativeFieldInfoPtr_GlobalSeqPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "GlobalSeqPath");
			MusicSystem.NativeFieldInfoPtr_StickDrumsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "StickDrumsPath");
			MusicSystem.NativeFieldInfoPtr_BrushDrumsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "BrushDrumsPath");
			MusicSystem.NativeFieldInfoPtr_BucketDrumsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "BucketDrumsPath");
			MusicSystem.NativeFieldInfoPtr_CongasPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "CongasPath");
			MusicSystem.NativeFieldInfoPtr_MarchingBandPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "MarchingBandPath");
			MusicSystem.NativeFieldInfoPtr_FrameDrumsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "FrameDrumsPath");
			MusicSystem.NativeFieldInfoPtr_GatedDrumsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "GatedDrumsPath");
			MusicSystem.NativeFieldInfoPtr_MetallicDrumsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "MetallicDrumsPath");
			MusicSystem.NativeFieldInfoPtr_ReversedMarchingBandPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "ReversedMarchingBandPath");
			MusicSystem.NativeFieldInfoPtr_UnderConstructionPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "UnderConstructionPath");
			MusicSystem.NativeFieldInfoPtr_UnusedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "UnusedPath");
			MusicSystem.NativeFieldInfoPtr_WoodWaterPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "WoodWaterPath");
			MusicSystem.NativeFieldInfoPtr_DrumIntensitySearchTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "DrumIntensitySearchTolerance");
			MusicSystem.NativeFieldInfoPtr_VelocityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "VelocityCurve");
			MusicSystem.NativeFieldInfoPtr_VolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "VolumeCurve");
			MusicSystem.NativeFieldInfoPtr_TestDrumVelocityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "TestDrumVelocityMultiplier");
			MusicSystem.NativeFieldInfoPtr_BeatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "BeatTime");
			MusicSystem.NativeFieldInfoPtr_Vary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "Vary");
			MusicSystem.NativeFieldInfoPtr_TempoAddition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "TempoAddition");
			MusicSystem.NativeFieldInfoPtr_HiHatAttenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "HiHatAttenuation");
			MusicSystem.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "Random");
			MusicSystem.NativeFieldInfoPtr_distortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "distortion");
			MusicSystem.NativeFieldInfoPtr_drumVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "drumVolume");
			MusicSystem.NativeFieldInfoPtr_cymbalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "cymbalVolume");
			MusicSystem.NativeFieldInfoPtr_compressorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "compressorLevel");
			MusicSystem.NativeFieldInfoPtr_Stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "Stopped");
			MusicSystem.NativeFieldInfoPtr_CurrentSequencerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "CurrentSequencerPatch");
			MusicSystem.NativeFieldInfoPtr_TestPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "TestPatch");
			MusicSystem.NativeFieldInfoPtr_CurrentSamplerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "CurrentSamplerPatch");
			MusicSystem.NativeFieldInfoPtr_CurrentAltSamplerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "CurrentAltSamplerPatch");
			MusicSystem.NativeFieldInfoPtr_LevelSequencerPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "LevelSequencerPatches");
			MusicSystem.NativeFieldInfoPtr_LevelSamplerPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "LevelSamplerPatches");
			MusicSystem.NativeFieldInfoPtr_TestingNoteSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "TestingNoteSequence");
			MusicSystem.NativeFieldInfoPtr_beatOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "beatOffset");
			MusicSystem.NativeFieldInfoPtr_nextPredictedChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "nextPredictedChange");
			MusicSystem.NativeFieldInfoPtr_usePrimarySeq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "usePrimarySeq");
			MusicSystem.NativeFieldInfoPtr_usedSeq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "usedSeq");
			MusicSystem.NativeFieldInfoPtr_numLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "numLoops");
			MusicSystem.NativeFieldInfoPtr_startOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "startOffset");
			MusicSystem.NativeFieldInfoPtr_currentIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "currentIntensity");
			MusicSystem.NativeFieldInfoPtr_nextNoteSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "nextNoteSequence");
			MusicSystem.NativeFieldInfoPtr_intensityVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "intensityVelocity");
			MusicSystem.NativeFieldInfoPtr_reloadSeq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "reloadSeq");
			MusicSystem.NativeFieldInfoPtr_lastStinger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "lastStinger");
			MusicSystem.NativeFieldInfoPtr_randomStinger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "randomStinger");
			MusicSystem.NativeFieldInfoPtr_InContainerAltOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "InContainerAltOverride");
			MusicSystem.NativeFieldInfoPtr_LabPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "LabPatches");
			MusicSystem.NativeFieldInfoPtr_OfficePatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "OfficePatches");
			MusicSystem.NativeFieldInfoPtr_BunkerPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "BunkerPatches");
			MusicSystem.NativeFieldInfoPtr_BoatPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "BoatPatches");
			MusicSystem.NativeFieldInfoPtr_SinglePatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "SinglePatches");
			MusicSystem.NativeFieldInfoPtr_AllSamplerPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "AllSamplerPatches");
			MusicSystem.NativeFieldInfoPtr_LabSeqPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "LabSeqPatches");
			MusicSystem.NativeFieldInfoPtr_OfficeSeqPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "OfficeSeqPatches");
			MusicSystem.NativeFieldInfoPtr_BunkerSeqPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "BunkerSeqPatches");
			MusicSystem.NativeFieldInfoPtr_BoatSeqPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "BoatSeqPatches");
			MusicSystem.NativeFieldInfoPtr_SingleSeqPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "SingleSeqPatches");
			MusicSystem.NativeFieldInfoPtr_AllSeqPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "AllSeqPatches");
			MusicSystem.NativeFieldInfoPtr_prevLoadedPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "prevLoadedPatch");
			MusicSystem.NativeFieldInfoPtr_prevLoadedBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "prevLoadedBundles");
			MusicSystem.NativeFieldInfoPtr_loadedSeqPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "loadedSeqPatch");
			MusicSystem.NativeFieldInfoPtr_prevLoadedSeqPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "prevLoadedSeqPatch");
			MusicSystem.NativeFieldInfoPtr_ReplaceCymbals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "ReplaceCymbals");
			MusicSystem.NativeFieldInfoPtr_loadedPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "loadedPatch");
			MusicSystem.NativeFieldInfoPtr_swappingAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "swappingAlt");
			MusicSystem.NativeFieldInfoPtr_SetPieceAltOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "SetPieceAltOverride");
			MusicSystem.NativeFieldInfoPtr_usingAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "usingAlt");
			MusicSystem.NativeFieldInfoPtr_DamageOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "DamageOn");
			MusicSystem.NativeFieldInfoPtr_DamageStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "DamageStartTime");
			MusicSystem.NativeFieldInfoPtr_DamageEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "DamageEndTime");
			MusicSystem.NativeFieldInfoPtr_DamageBreakLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "DamageBreakLength");
			MusicSystem.NativeFieldInfoPtr_prevDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "prevDelta");
			MusicSystem.NativeFieldInfoPtr_rideBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "rideBool");
			MusicSystem.NativeFieldInfoPtr_crashBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "crashBool");
			MusicSystem.NativeFieldInfoPtr_hiHatBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "hiHatBool");
			MusicSystem.NativeFieldInfoPtr_auxBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "auxBool");
			MusicSystem.NativeFieldInfoPtr_prevIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "prevIndex");
			MusicSystem.NativeFieldInfoPtr_simming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "simming");
			MusicSystem.NativeFieldInfoPtr_seqCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "seqCount");
			MusicSystem.NativeFieldInfoPtr_recentHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "recentHistory");
			MusicSystem.NativeFieldInfoPtr_recentHistoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "recentHistoryIndex");
			MusicSystem.NativeFieldInfoPtr_forceChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "forceChange");
			MusicSystem.NativeFieldInfoPtr_forceSame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "forceSame");
			MusicSystem.NativeFieldInfoPtr_forceSameSeqCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "forceSameSeqCount");
			MusicSystem.NativeFieldInfoPtr_actuallySamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "actuallySamed");
			MusicSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663343);
			MusicSystem.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663344);
			MusicSystem.NativeMethodInfoPtr_LoadPatchesForWorld_Public_Void_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663345);
			MusicSystem.NativeMethodInfoPtr_UnloadPatchesNotUsedInLevel_Private_Void_Il2CppStructArray_1_LevelSamplerPatch_Il2CppStructArray_1_LevelSequencerPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663346);
			MusicSystem.NativeMethodInfoPtr_UnloadPrevPatches_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663347);
			MusicSystem.NativeMethodInfoPtr_AsyncLoadPatches_Private_IEnumerator_Il2CppStructArray_1_LevelSamplerPatch_Il2CppStructArray_1_LevelSequencerPatch_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663348);
			MusicSystem.NativeMethodInfoPtr_WaitToSetFloats_Private_IEnumerator_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663349);
			MusicSystem.NativeMethodInfoPtr_GetStringFromLevelSamplerPatch_Private_String_LevelSamplerPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663350);
			MusicSystem.NativeMethodInfoPtr_GetStringFromLevelSequencerPatch_Private_String_LevelSequencerPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663351);
			MusicSystem.NativeMethodInfoPtr_StartTestMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663352);
			MusicSystem.NativeMethodInfoPtr_StartSequentialSimmilarityTest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663353);
			MusicSystem.NativeMethodInfoPtr_LoopNoteSequence_Public_Void_NoteSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663354);
			MusicSystem.NativeMethodInfoPtr_setTempoAddition_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663355);
			MusicSystem.NativeMethodInfoPtr_LoadUnusedMusic_Public_Void_LevelSamplerPatch_LevelSequencerPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663356);
			MusicSystem.NativeMethodInfoPtr_SamplerSwap_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663357);
			MusicSystem.NativeMethodInfoPtr_StartUnusedMusic_Public_Void_LevelSamplerPatch_LevelSequencerPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663358);
			MusicSystem.NativeMethodInfoPtr_StartMusic_Public_Void_Int32_LevelSequencerPatch_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663359);
			MusicSystem.NativeMethodInfoPtr_StartMusicMix_Public_Void_LevelSamplerPatch_LevelSequencerPatch_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663360);
			MusicSystem.NativeMethodInfoPtr_StopMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663361);
			MusicSystem.NativeMethodInfoPtr_TookDamage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663362);
			MusicSystem.NativeMethodInfoPtr_GetArcadeTempoDelta_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663363);
			MusicSystem.NativeMethodInfoPtr_LoadMusicForLevel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663364);
			MusicSystem.NativeMethodInfoPtr_KillStinger_Public_Void_Single_MidiCymbal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663365);
			MusicSystem.NativeMethodInfoPtr_KillStinger_Public_Void_Single_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663366);
			MusicSystem.NativeMethodInfoPtr_ChangeTempo_Public_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663367);
			MusicSystem.NativeMethodInfoPtr_loadPatchAndStartSim_Private_Void_SequencerPatch_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663368);
			MusicSystem.NativeMethodInfoPtr_KeepSequencesTheSame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663369);
			MusicSystem.NativeMethodInfoPtr_MakeNextSequenceDifferent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663370);
			MusicSystem.NativeMethodInfoPtr_cueNextNoteSequenceSim_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663371);
			MusicSystem.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663372);
			MusicSystem.NativeMethodInfoPtr_TransitionStarting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663373);
			MusicSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100663374);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000371FC File Offset: 0x000353FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30742, XrefRangeEnd = 30771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00037230 File Offset: 0x00035430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30771, XrefRangeEnd = 30777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00037264 File Offset: 0x00035464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30777, XrefRangeEnd = 30790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadPatchesForWorld(int worldInt, Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldInt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_LoadPatchesForWorld_Public_Void_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000372B4 File Offset: 0x000354B4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 30832, RefRangeEnd = 30842, XrefRangeStart = 30790, XrefRangeEnd = 30832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadPatchesNotUsedInLevel(Il2CppStructArray<MusicSystem.LevelSamplerPatch> patch, Il2CppStructArray<MusicSystem.LevelSequencerPatch> seqPatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(seqPatch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_UnloadPatchesNotUsedInLevel_Private_Void_Il2CppStructArray_1_LevelSamplerPatch_Il2CppStructArray_1_LevelSequencerPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00037308 File Offset: 0x00035508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30842, XrefRangeEnd = 30848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadPrevPatches(int nextWordInt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nextWordInt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_UnloadPrevPatches_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00037348 File Offset: 0x00035548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30851, RefRangeEnd = 30852, XrefRangeStart = 30848, XrefRangeEnd = 30851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AsyncLoadPatches(Il2CppStructArray<MusicSystem.LevelSamplerPatch> patches, Il2CppStructArray<MusicSystem.LevelSequencerPatch> seqPatches, Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patches);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(seqPatches);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_AsyncLoadPatches_Private_IEnumerator_Il2CppStructArray_1_LevelSamplerPatch_Il2CppStructArray_1_LevelSequencerPatch_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000373BC File Offset: 0x000355BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30852, XrefRangeEnd = 30855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitToSetFloats(float DistortionLevel, float DrumVolume, float CymbalVolume, float CompressorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref DistortionLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref DrumVolume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CymbalVolume;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CompressorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_WaitToSetFloats_Private_IEnumerator_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00037434 File Offset: 0x00035634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30855, RefRangeEnd = 30856, XrefRangeStart = 30855, XrefRangeEnd = 30855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringFromLevelSamplerPatch(MusicSystem.LevelSamplerPatch lsp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lsp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_GetStringFromLevelSamplerPatch_Private_String_LevelSamplerPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00037478 File Offset: 0x00035678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30856, RefRangeEnd = 30858, XrefRangeStart = 30856, XrefRangeEnd = 30856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringFromLevelSequencerPatch(MusicSystem.LevelSequencerPatch lsp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lsp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_GetStringFromLevelSequencerPatch_Private_String_LevelSequencerPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000374BC File Offset: 0x000356BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30858, XrefRangeEnd = 30859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTestMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_StartTestMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000374F0 File Offset: 0x000356F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSequentialSimmilarityTest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_StartSequentialSimmilarityTest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00037524 File Offset: 0x00035724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30859, XrefRangeEnd = 30870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoopNoteSequence(NoteSequence noteSeq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteSeq);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_LoopNoteSequence_Public_Void_NoteSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00037568 File Offset: 0x00035768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30870, RefRangeEnd = 30871, XrefRangeStart = 30870, XrefRangeEnd = 30870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setTempoAddition(int lseq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lseq;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_setTempoAddition_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000375A8 File Offset: 0x000357A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30871, XrefRangeEnd = 30883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadUnusedMusic(MusicSystem.LevelSamplerPatch sampPatch, MusicSystem.LevelSequencerPatch lSeq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sampPatch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lSeq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_LoadUnusedMusic_Public_Void_LevelSamplerPatch_LevelSequencerPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000375F4 File Offset: 0x000357F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30895, RefRangeEnd = 30897, XrefRangeStart = 30883, XrefRangeEnd = 30895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SamplerSwap(bool SwapInAlt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref SwapInAlt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_SamplerSwap_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00037634 File Offset: 0x00035834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30918, RefRangeEnd = 30919, XrefRangeStart = 30897, XrefRangeEnd = 30918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartUnusedMusic(MusicSystem.LevelSamplerPatch sampPatch, MusicSystem.LevelSequencerPatch lSeq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sampPatch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lSeq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_StartUnusedMusic_Public_Void_LevelSamplerPatch_LevelSequencerPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00037680 File Offset: 0x00035880
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 31004, RefRangeEnd = 31015, XrefRangeStart = 30919, XrefRangeEnd = 31004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMusic(int LevelNumber, MusicSystem.LevelSequencerPatch lSeq, bool altSamp, bool halfSpeed = false, bool forceMinTempo = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref LevelNumber;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lSeq;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref altSamp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref halfSpeed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMinTempo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_StartMusic_Public_Void_Int32_LevelSequencerPatch_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000376F8 File Offset: 0x000358F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31056, RefRangeEnd = 31057, XrefRangeStart = 31015, XrefRangeEnd = 31056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMusicMix(MusicSystem.LevelSamplerPatch lSamp, MusicSystem.LevelSequencerPatch lSeq, bool halfSpeed = false, bool forceMinTempo = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lSamp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lSeq;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref halfSpeed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMinTempo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_StartMusicMix_Public_Void_LevelSamplerPatch_LevelSequencerPatch_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00037760 File Offset: 0x00035960
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 31062, RefRangeEnd = 31077, XrefRangeStart = 31057, XrefRangeEnd = 31062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_StopMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00037794 File Offset: 0x00035994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31077, XrefRangeEnd = 31094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TookDamage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_TookDamage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000377C8 File Offset: 0x000359C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31100, RefRangeEnd = 31102, XrefRangeStart = 31094, XrefRangeEnd = 31100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetArcadeTempoDelta()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_GetArcadeTempoDelta_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00037804 File Offset: 0x00035A04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31121, RefRangeEnd = 31124, XrefRangeStart = 31102, XrefRangeEnd = 31121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadMusicForLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_LoadMusicForLevel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00037838 File Offset: 0x00035A38
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 31135, RefRangeEnd = 31142, XrefRangeStart = 31124, XrefRangeEnd = 31135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KillStinger(float intensity = -1f, MidiCymbal cymbal = MidiCymbal.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intensity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cymbal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_KillStinger_Public_Void_Single_MidiCymbal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00037884 File Offset: 0x00035A84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 31159, RefRangeEnd = 31164, XrefRangeStart = 31142, XrefRangeEnd = 31159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KillStinger(float intensity, int quadrant = 0, bool hitOther = false, bool exploded = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intensity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadrant;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitOther;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exploded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_KillStinger_Public_Void_Single_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000378EC File Offset: 0x00035AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31164, XrefRangeEnd = 31167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ChangeTempo(float newTempo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newTempo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_ChangeTempo_Public_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00037938 File Offset: 0x00035B38
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 31249, RefRangeEnd = 31254, XrefRangeStart = 31167, XrefRangeEnd = 31249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void loadPatchAndStartSim(SequencerPatch sp, bool halfSpeed = false, bool forceMinTempo = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref halfSpeed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMinTempo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_loadPatchAndStartSim_Private_Void_SequencerPatch_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00037998 File Offset: 0x00035B98
		[CallerCount(0)]
		public unsafe void KeepSequencesTheSame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_KeepSequencesTheSame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000379CC File Offset: 0x00035BCC
		[CallerCount(0)]
		public unsafe void MakeNextSequenceDifferent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_MakeNextSequenceDifferent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00037A00 File Offset: 0x00035C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31302, RefRangeEnd = 31303, XrefRangeStart = 31254, XrefRangeEnd = 31302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void cueNextNoteSequenceSim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_cueNextNoteSequenceSim_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00037A34 File Offset: 0x00035C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31303, XrefRangeEnd = 31334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00037A68 File Offset: 0x00035C68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31337, RefRangeEnd = 31340, XrefRangeStart = 31334, XrefRangeEnd = 31337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransitionStarting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_TransitionStarting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00037A9C File Offset: 0x00035C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31340, XrefRangeEnd = 31395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000028EA File Offset: 0x00000AEA
		public MusicSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00037AD8 File Offset: 0x00035CD8
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000028F3 File Offset: 0x00000AF3
		public unsafe static MusicSystem me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSystem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00037B00 File Offset: 0x00035D00
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002905 File Offset: 0x00000B05
		public unsafe AudioMixer Mixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Mixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Mixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00037B30 File Offset: 0x00035D30
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002924 File Offset: 0x00000B24
		public unsafe SampleSequencer PrimarySequencer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_PrimarySequencer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SampleSequencer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_PrimarySequencer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00037B60 File Offset: 0x00035D60
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002943 File Offset: 0x00000B43
		public unsafe SampleSequencer SecondarySequencer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_SecondarySequencer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SampleSequencer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_SecondarySequencer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00037B90 File Offset: 0x00035D90
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002962 File Offset: 0x00000B62
		public unsafe SampleSequencer TransitionSequencer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_TransitionSequencer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SampleSequencer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_TransitionSequencer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00037BC0 File Offset: 0x00035DC0
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002981 File Offset: 0x00000B81
		public unsafe Sampler Sampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Sampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Sampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00037BF0 File Offset: 0x00035DF0
		// (set) Token: 0x060000FE RID: 254 RVA: 0x000029A0 File Offset: 0x00000BA0
		public unsafe Sampler AltSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_AltSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_AltSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00037C20 File Offset: 0x00035E20
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000029BF File Offset: 0x00000BBF
		public unsafe AudioHelmClock Clock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Clock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioHelmClock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Clock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00037C50 File Offset: 0x00035E50
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000029DE File Offset: 0x00000BDE
		public unsafe SequencerPatch ActivePatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_ActivePatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequencerPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_ActivePatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00037C80 File Offset: 0x00035E80
		// (set) Token: 0x06000104 RID: 260 RVA: 0x000029FD File Offset: 0x00000BFD
		public unsafe string StickSeqPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_StickSeqPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_StickSeqPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00037CA8 File Offset: 0x00035EA8
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002A1C File Offset: 0x00000C1C
		public unsafe string BrushSeqPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BrushSeqPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BrushSeqPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00037CD0 File Offset: 0x00035ED0
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002A3B File Offset: 0x00000C3B
		public unsafe string FunkySeqPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_FunkySeqPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_FunkySeqPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00037CF8 File Offset: 0x00035EF8
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002A5A File Offset: 0x00000C5A
		public unsafe string CongasSeqPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_CongasSeqPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_CongasSeqPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00037D20 File Offset: 0x00035F20
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002A79 File Offset: 0x00000C79
		public unsafe string MilitarySeqPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_MilitarySeqPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_MilitarySeqPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00037D48 File Offset: 0x00035F48
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002A98 File Offset: 0x00000C98
		public unsafe string GlobalSeqPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_GlobalSeqPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_GlobalSeqPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00037D70 File Offset: 0x00035F70
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002AB7 File Offset: 0x00000CB7
		public unsafe string StickDrumsPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_StickDrumsPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_StickDrumsPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00037D98 File Offset: 0x00035F98
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002AD6 File Offset: 0x00000CD6
		public unsafe string BrushDrumsPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BrushDrumsPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BrushDrumsPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00037DC0 File Offset: 0x00035FC0
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002AF5 File Offset: 0x00000CF5
		public unsafe string BucketDrumsPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BucketDrumsPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BucketDrumsPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00037DE8 File Offset: 0x00035FE8
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00002B14 File Offset: 0x00000D14
		public unsafe string CongasPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_CongasPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_CongasPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00037E10 File Offset: 0x00036010
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002B33 File Offset: 0x00000D33
		public unsafe string MarchingBandPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_MarchingBandPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_MarchingBandPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00037E38 File Offset: 0x00036038
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002B52 File Offset: 0x00000D52
		public unsafe string FrameDrumsPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_FrameDrumsPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_FrameDrumsPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00037E60 File Offset: 0x00036060
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00002B71 File Offset: 0x00000D71
		public unsafe string GatedDrumsPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_GatedDrumsPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_GatedDrumsPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00037E88 File Offset: 0x00036088
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00002B90 File Offset: 0x00000D90
		public unsafe string MetallicDrumsPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_MetallicDrumsPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_MetallicDrumsPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00037EB0 File Offset: 0x000360B0
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002BAF File Offset: 0x00000DAF
		public unsafe string ReversedMarchingBandPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_ReversedMarchingBandPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_ReversedMarchingBandPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00037ED8 File Offset: 0x000360D8
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00002BCE File Offset: 0x00000DCE
		public unsafe string UnderConstructionPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_UnderConstructionPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_UnderConstructionPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00037F00 File Offset: 0x00036100
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002BED File Offset: 0x00000DED
		public unsafe string UnusedPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_UnusedPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_UnusedPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00037F28 File Offset: 0x00036128
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002C0C File Offset: 0x00000E0C
		public unsafe string WoodWaterPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_WoodWaterPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_WoodWaterPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00037F50 File Offset: 0x00036150
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002C2B File Offset: 0x00000E2B
		public unsafe float DrumIntensitySearchTolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_DrumIntensitySearchTolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_DrumIntensitySearchTolerance)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00037F78 File Offset: 0x00036178
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002C46 File Offset: 0x00000E46
		public unsafe AnimationCurve VelocityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_VelocityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_VelocityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00037FA8 File Offset: 0x000361A8
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002C65 File Offset: 0x00000E65
		public unsafe AnimationCurve VolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_VolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_VolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00037FD8 File Offset: 0x000361D8
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00002C84 File Offset: 0x00000E84
		public unsafe float TestDrumVelocityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_TestDrumVelocityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_TestDrumVelocityMultiplier)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00038000 File Offset: 0x00036200
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002C9F File Offset: 0x00000E9F
		public unsafe float BeatTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BeatTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BeatTime)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00038028 File Offset: 0x00036228
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002CBA File Offset: 0x00000EBA
		public unsafe bool Vary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Vary);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Vary)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00038050 File Offset: 0x00036250
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002CD5 File Offset: 0x00000ED5
		public unsafe int TempoAddition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_TempoAddition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_TempoAddition)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00038078 File Offset: 0x00036278
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public unsafe float HiHatAttenuation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_HiHatAttenuation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_HiHatAttenuation)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000380A0 File Offset: 0x000362A0
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002D0B File Offset: 0x00000F0B
		public unsafe global::Il2CppSystem.Random Random
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Random);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Random>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Random), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000380D0 File Offset: 0x000362D0
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002D2A File Offset: 0x00000F2A
		public unsafe string distortion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_distortion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_distortion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000380F8 File Offset: 0x000362F8
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002D49 File Offset: 0x00000F49
		public unsafe string drumVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_drumVolume);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_drumVolume), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00038120 File Offset: 0x00036320
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002D68 File Offset: 0x00000F68
		public unsafe string cymbalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_cymbalVolume);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_cymbalVolume), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00038148 File Offset: 0x00036348
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002D87 File Offset: 0x00000F87
		public unsafe string compressorLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_compressorLevel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_compressorLevel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00038170 File Offset: 0x00036370
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002DA6 File Offset: 0x00000FA6
		public unsafe bool Stopped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Stopped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_Stopped)) = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00038198 File Offset: 0x00036398
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002DC1 File Offset: 0x00000FC1
		public unsafe MusicSystem.LevelSequencerPatch CurrentSequencerPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_CurrentSequencerPatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_CurrentSequencerPatch)) = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000381C0 File Offset: 0x000363C0
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002DDC File Offset: 0x00000FDC
		public unsafe SequencerPatch TestPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_TestPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequencerPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_TestPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000381F0 File Offset: 0x000363F0
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002DFB File Offset: 0x00000FFB
		public unsafe MusicSystem.LevelSamplerPatch CurrentSamplerPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_CurrentSamplerPatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_CurrentSamplerPatch)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00038218 File Offset: 0x00036418
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002E16 File Offset: 0x00001016
		public unsafe MusicSystem.LevelSamplerPatch CurrentAltSamplerPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_CurrentAltSamplerPatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_CurrentAltSamplerPatch)) = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00038240 File Offset: 0x00036440
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002E31 File Offset: 0x00001031
		public unsafe Dictionary<MusicSystem.LevelSequencerPatch, SequencerPatch> LevelSequencerPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_LevelSequencerPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MusicSystem.LevelSequencerPatch, SequencerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_LevelSequencerPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00038270 File Offset: 0x00036470
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002E50 File Offset: 0x00001050
		public unsafe Dictionary<MusicSystem.LevelSamplerPatch, SamplerPatch> LevelSamplerPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_LevelSamplerPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MusicSystem.LevelSamplerPatch, SamplerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_LevelSamplerPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000382A0 File Offset: 0x000364A0
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002E6F File Offset: 0x0000106F
		public unsafe NoteSequence TestingNoteSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_TestingNoteSequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteSequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_TestingNoteSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000382D0 File Offset: 0x000364D0
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002E8E File Offset: 0x0000108E
		public unsafe int beatOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_beatOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_beatOffset)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000382F8 File Offset: 0x000364F8
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002EA9 File Offset: 0x000010A9
		public unsafe float nextPredictedChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_nextPredictedChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_nextPredictedChange)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00038320 File Offset: 0x00036520
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002EC4 File Offset: 0x000010C4
		public unsafe bool usePrimarySeq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_usePrimarySeq);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_usePrimarySeq)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00038348 File Offset: 0x00036548
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002EDF File Offset: 0x000010DF
		public unsafe Sequencer usedSeq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_usedSeq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequencer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_usedSeq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00038378 File Offset: 0x00036578
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002EFE File Offset: 0x000010FE
		public unsafe int numLoops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_numLoops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_numLoops)) = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000383A0 File Offset: 0x000365A0
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002F19 File Offset: 0x00001119
		public unsafe int startOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_startOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_startOffset)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000383C8 File Offset: 0x000365C8
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002F34 File Offset: 0x00001134
		public unsafe float currentIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_currentIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_currentIntensity)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000383F0 File Offset: 0x000365F0
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002F4F File Offset: 0x0000114F
		public unsafe SequencerBagEntry nextNoteSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_nextNoteSequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequencerBagEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_nextNoteSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00038420 File Offset: 0x00036620
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002F6E File Offset: 0x0000116E
		public unsafe float intensityVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_intensityVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_intensityVelocity)) = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00038448 File Offset: 0x00036648
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002F89 File Offset: 0x00001189
		public unsafe bool reloadSeq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_reloadSeq);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_reloadSeq)) = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00038470 File Offset: 0x00036670
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00002FA4 File Offset: 0x000011A4
		public unsafe int lastStinger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_lastStinger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_lastStinger)) = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00038498 File Offset: 0x00036698
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00002FBF File Offset: 0x000011BF
		public unsafe int randomStinger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_randomStinger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_randomStinger)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000384C0 File Offset: 0x000366C0
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002FDA File Offset: 0x000011DA
		public unsafe bool InContainerAltOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_InContainerAltOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_InContainerAltOverride)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000384E8 File Offset: 0x000366E8
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002FF5 File Offset: 0x000011F5
		public unsafe Il2CppStructArray<MusicSystem.LevelSamplerPatch> LabPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_LabPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSamplerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_LabPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00038518 File Offset: 0x00036718
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00003014 File Offset: 0x00001214
		public unsafe Il2CppStructArray<MusicSystem.LevelSamplerPatch> OfficePatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_OfficePatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSamplerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_OfficePatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00038548 File Offset: 0x00036748
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00003033 File Offset: 0x00001233
		public unsafe Il2CppStructArray<MusicSystem.LevelSamplerPatch> BunkerPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BunkerPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSamplerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BunkerPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00038578 File Offset: 0x00036778
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00003052 File Offset: 0x00001252
		public unsafe Il2CppStructArray<MusicSystem.LevelSamplerPatch> BoatPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BoatPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSamplerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BoatPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000385A8 File Offset: 0x000367A8
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00003071 File Offset: 0x00001271
		public unsafe Il2CppStructArray<MusicSystem.LevelSamplerPatch> SinglePatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_SinglePatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSamplerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_SinglePatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000385D8 File Offset: 0x000367D8
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00003090 File Offset: 0x00001290
		public unsafe Il2CppStructArray<MusicSystem.LevelSamplerPatch> AllSamplerPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_AllSamplerPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSamplerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_AllSamplerPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00038608 File Offset: 0x00036808
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000030AF File Offset: 0x000012AF
		public unsafe Il2CppStructArray<MusicSystem.LevelSequencerPatch> LabSeqPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_LabSeqPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSequencerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_LabSeqPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00038638 File Offset: 0x00036838
		// (set) Token: 0x0600017A RID: 378 RVA: 0x000030CE File Offset: 0x000012CE
		public unsafe Il2CppStructArray<MusicSystem.LevelSequencerPatch> OfficeSeqPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_OfficeSeqPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSequencerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_OfficeSeqPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00038668 File Offset: 0x00036868
		// (set) Token: 0x0600017C RID: 380 RVA: 0x000030ED File Offset: 0x000012ED
		public unsafe Il2CppStructArray<MusicSystem.LevelSequencerPatch> BunkerSeqPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BunkerSeqPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSequencerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BunkerSeqPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00038698 File Offset: 0x00036898
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0000310C File Offset: 0x0000130C
		public unsafe Il2CppStructArray<MusicSystem.LevelSequencerPatch> BoatSeqPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BoatSeqPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSequencerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_BoatSeqPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000386C8 File Offset: 0x000368C8
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000312B File Offset: 0x0000132B
		public unsafe Il2CppStructArray<MusicSystem.LevelSequencerPatch> SingleSeqPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_SingleSeqPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSequencerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_SingleSeqPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000386F8 File Offset: 0x000368F8
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000314A File Offset: 0x0000134A
		public unsafe Il2CppStructArray<MusicSystem.LevelSequencerPatch> AllSeqPatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_AllSeqPatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSequencerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_AllSeqPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00038728 File Offset: 0x00036928
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00003169 File Offset: 0x00001369
		public unsafe Il2CppStructArray<MusicSystem.LevelSamplerPatch> prevLoadedPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_prevLoadedPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSamplerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_prevLoadedPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00038758 File Offset: 0x00036958
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00003188 File Offset: 0x00001388
		public unsafe Il2CppReferenceArray<AssetBundle> prevLoadedBundles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_prevLoadedBundles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetBundle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_prevLoadedBundles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00038788 File Offset: 0x00036988
		// (set) Token: 0x06000188 RID: 392 RVA: 0x000031A7 File Offset: 0x000013A7
		public unsafe SequencerPatch loadedSeqPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_loadedSeqPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequencerPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_loadedSeqPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000387B8 File Offset: 0x000369B8
		// (set) Token: 0x0600018A RID: 394 RVA: 0x000031C6 File Offset: 0x000013C6
		public unsafe Il2CppStructArray<MusicSystem.LevelSequencerPatch> prevLoadedSeqPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_prevLoadedSeqPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSequencerPatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_prevLoadedSeqPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000387E8 File Offset: 0x000369E8
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000031E5 File Offset: 0x000013E5
		public unsafe bool ReplaceCymbals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_ReplaceCymbals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_ReplaceCymbals)) = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00038810 File Offset: 0x00036A10
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00003200 File Offset: 0x00001400
		public unsafe SamplerPatch loadedPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_loadedPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SamplerPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_loadedPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00038840 File Offset: 0x00036A40
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0000321F File Offset: 0x0000141F
		public unsafe bool swappingAlt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_swappingAlt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_swappingAlt)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00038868 File Offset: 0x00036A68
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0000323A File Offset: 0x0000143A
		public unsafe bool SetPieceAltOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_SetPieceAltOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_SetPieceAltOverride)) = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00038890 File Offset: 0x00036A90
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00003255 File Offset: 0x00001455
		public unsafe bool usingAlt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_usingAlt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_usingAlt)) = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000388B8 File Offset: 0x00036AB8
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00003270 File Offset: 0x00001470
		public unsafe bool DamageOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_DamageOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_DamageOn)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000388E0 File Offset: 0x00036AE0
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0000328B File Offset: 0x0000148B
		public unsafe double DamageStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_DamageStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_DamageStartTime)) = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00038908 File Offset: 0x00036B08
		// (set) Token: 0x0600019A RID: 410 RVA: 0x000032A6 File Offset: 0x000014A6
		public unsafe double DamageEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_DamageEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_DamageEndTime)) = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00038930 File Offset: 0x00036B30
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000032C1 File Offset: 0x000014C1
		public unsafe int DamageBreakLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_DamageBreakLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_DamageBreakLength)) = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00038958 File Offset: 0x00036B58
		// (set) Token: 0x0600019E RID: 414 RVA: 0x000032DC File Offset: 0x000014DC
		public unsafe float prevDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_prevDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_prevDelta)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00038980 File Offset: 0x00036B80
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000032F7 File Offset: 0x000014F7
		public unsafe bool rideBool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_rideBool);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_rideBool)) = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000389A8 File Offset: 0x00036BA8
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00003312 File Offset: 0x00001512
		public unsafe bool crashBool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_crashBool);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_crashBool)) = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000389D0 File Offset: 0x00036BD0
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000332D File Offset: 0x0000152D
		public unsafe bool hiHatBool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_hiHatBool);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_hiHatBool)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x000389F8 File Offset: 0x00036BF8
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00003348 File Offset: 0x00001548
		public unsafe bool auxBool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_auxBool);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_auxBool)) = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00038A20 File Offset: 0x00036C20
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00003363 File Offset: 0x00001563
		public unsafe int prevIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_prevIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_prevIndex)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00038A48 File Offset: 0x00036C48
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0000337E File Offset: 0x0000157E
		public unsafe bool simming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_simming);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_simming)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00038A70 File Offset: 0x00036C70
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00003399 File Offset: 0x00001599
		public unsafe int seqCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_seqCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_seqCount)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00038A98 File Offset: 0x00036C98
		// (set) Token: 0x060001AE RID: 430 RVA: 0x000033B4 File Offset: 0x000015B4
		public unsafe Il2CppStructArray<int> recentHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_recentHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_recentHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00038AC8 File Offset: 0x00036CC8
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x000033D3 File Offset: 0x000015D3
		public unsafe int recentHistoryIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_recentHistoryIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_recentHistoryIndex)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00038AF0 File Offset: 0x00036CF0
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x000033EE File Offset: 0x000015EE
		public unsafe bool forceChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_forceChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_forceChange)) = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00038B18 File Offset: 0x00036D18
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00003409 File Offset: 0x00001609
		public unsafe bool forceSame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_forceSame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_forceSame)) = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00038B40 File Offset: 0x00036D40
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00003424 File Offset: 0x00001624
		public unsafe int forceSameSeqCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_forceSameSeqCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_forceSameSeqCount)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00038B68 File Offset: 0x00036D68
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x0000343F File Offset: 0x0000163F
		public unsafe bool actuallySamed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_actuallySamed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_actuallySamed)) = value;
			}
		}

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_Mixer;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_PrimarySequencer;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_SecondarySequencer;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_TransitionSequencer;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_Sampler;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_AltSampler;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_Clock;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_ActivePatch;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_StickSeqPath;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_BrushSeqPath;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_FunkySeqPath;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_CongasSeqPath;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_MilitarySeqPath;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_GlobalSeqPath;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_StickDrumsPath;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_BrushDrumsPath;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_BucketDrumsPath;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_CongasPath;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_MarchingBandPath;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_FrameDrumsPath;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_GatedDrumsPath;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_MetallicDrumsPath;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_ReversedMarchingBandPath;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_UnderConstructionPath;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_UnusedPath;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_WoodWaterPath;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_DrumIntensitySearchTolerance;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCurve;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_VolumeCurve;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_TestDrumVelocityMultiplier;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_BeatTime;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_Vary;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_TempoAddition;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_HiHatAttenuation;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_Random;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_distortion;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_drumVolume;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_cymbalVolume;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_compressorLevel;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_Stopped;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_CurrentSequencerPatch;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_TestPatch;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_CurrentSamplerPatch;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_CurrentAltSamplerPatch;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_LevelSequencerPatches;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_LevelSamplerPatches;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_TestingNoteSequence;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_beatOffset;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_nextPredictedChange;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_usePrimarySeq;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_usedSeq;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_numLoops;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_startOffset;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_currentIntensity;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_nextNoteSequence;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_intensityVelocity;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_reloadSeq;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_lastStinger;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_randomStinger;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_InContainerAltOverride;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_LabPatches;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_OfficePatches;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_BunkerPatches;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_BoatPatches;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_SinglePatches;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_AllSamplerPatches;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_LabSeqPatches;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_OfficeSeqPatches;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_BunkerSeqPatches;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_BoatSeqPatches;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_SingleSeqPatches;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_AllSeqPatches;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_prevLoadedPatch;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_prevLoadedBundles;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_loadedSeqPatch;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_prevLoadedSeqPatch;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_ReplaceCymbals;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_loadedPatch;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_swappingAlt;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_SetPieceAltOverride;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_usingAlt;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_DamageOn;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_DamageStartTime;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_DamageEndTime;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_DamageBreakLength;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_prevDelta;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_rideBool;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_crashBool;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_hiHatBool;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_auxBool;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_prevIndex;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_simming;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_seqCount;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_recentHistory;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_recentHistoryIndex;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_forceChange;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_forceSame;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_forceSameSeqCount;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_actuallySamed;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_LoadPatchesForWorld_Public_Void_Int32_Action_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_UnloadPatchesNotUsedInLevel_Private_Void_Il2CppStructArray_1_LevelSamplerPatch_Il2CppStructArray_1_LevelSequencerPatch_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_UnloadPrevPatches_Private_Void_Int32_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_AsyncLoadPatches_Private_IEnumerator_Il2CppStructArray_1_LevelSamplerPatch_Il2CppStructArray_1_LevelSequencerPatch_Action_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_WaitToSetFloats_Private_IEnumerator_Single_Single_Single_Single_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_GetStringFromLevelSamplerPatch_Private_String_LevelSamplerPatch_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_GetStringFromLevelSequencerPatch_Private_String_LevelSequencerPatch_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_StartTestMusic_Public_Void_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_StartSequentialSimmilarityTest_Public_Void_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_LoopNoteSequence_Public_Void_NoteSequence_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_setTempoAddition_Private_Void_Int32_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_LoadUnusedMusic_Public_Void_LevelSamplerPatch_LevelSequencerPatch_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_SamplerSwap_Public_Void_Boolean_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_StartUnusedMusic_Public_Void_LevelSamplerPatch_LevelSequencerPatch_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_StartMusic_Public_Void_Int32_LevelSequencerPatch_Boolean_Boolean_Boolean_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_StartMusicMix_Public_Void_LevelSamplerPatch_LevelSequencerPatch_Boolean_Boolean_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_StopMusic_Public_Void_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_TookDamage_Public_Void_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_GetArcadeTempoDelta_Public_Single_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_LoadMusicForLevel_Public_Void_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_KillStinger_Public_Void_Single_MidiCymbal_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_KillStinger_Public_Void_Single_Int32_Boolean_Boolean_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTempo_Public_IEnumerator_Single_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_loadPatchAndStartSim_Private_Void_SequencerPatch_Boolean_Boolean_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_KeepSequencesTheSame_Public_Void_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_MakeNextSequenceDifferent_Public_Void_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_cueNextNoteSequenceSim_Private_Void_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_TransitionStarting_Public_Void_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000294 RID: 660
		[OriginalName("Assembly-CSharp.dll", "", "LevelSequencerPatch")]
		public enum LevelSequencerPatch
		{
			// Token: 0x04002FDC RID: 12252
			Level11,
			// Token: 0x04002FDD RID: 12253
			Level12,
			// Token: 0x04002FDE RID: 12254
			Level13,
			// Token: 0x04002FDF RID: 12255
			Level14,
			// Token: 0x04002FE0 RID: 12256
			Level15,
			// Token: 0x04002FE1 RID: 12257
			Level16,
			// Token: 0x04002FE2 RID: 12258
			Level17,
			// Token: 0x04002FE3 RID: 12259
			Level18,
			// Token: 0x04002FE4 RID: 12260
			Level21,
			// Token: 0x04002FE5 RID: 12261
			Level22,
			// Token: 0x04002FE6 RID: 12262
			Level23,
			// Token: 0x04002FE7 RID: 12263
			Level24,
			// Token: 0x04002FE8 RID: 12264
			Level25,
			// Token: 0x04002FE9 RID: 12265
			Level26,
			// Token: 0x04002FEA RID: 12266
			Level27,
			// Token: 0x04002FEB RID: 12267
			Level28,
			// Token: 0x04002FEC RID: 12268
			Level31,
			// Token: 0x04002FED RID: 12269
			Level32,
			// Token: 0x04002FEE RID: 12270
			Level33,
			// Token: 0x04002FEF RID: 12271
			Level34,
			// Token: 0x04002FF0 RID: 12272
			Level35,
			// Token: 0x04002FF1 RID: 12273
			Level36,
			// Token: 0x04002FF2 RID: 12274
			Level37,
			// Token: 0x04002FF3 RID: 12275
			Level38,
			// Token: 0x04002FF4 RID: 12276
			Level41,
			// Token: 0x04002FF5 RID: 12277
			Level42,
			// Token: 0x04002FF6 RID: 12278
			Level43,
			// Token: 0x04002FF7 RID: 12279
			Level44,
			// Token: 0x04002FF8 RID: 12280
			Level45,
			// Token: 0x04002FF9 RID: 12281
			Level46,
			// Token: 0x04002FFA RID: 12282
			Level47,
			// Token: 0x04002FFB RID: 12283
			Level48,
			// Token: 0x04002FFC RID: 12284
			LevelS1,
			// Token: 0x04002FFD RID: 12285
			Sticks,
			// Token: 0x04002FFE RID: 12286
			Brushes,
			// Token: 0x04002FFF RID: 12287
			Buckets,
			// Token: 0x04003000 RID: 12288
			Metallic,
			// Token: 0x04003001 RID: 12289
			DrumLine,
			// Token: 0x04003002 RID: 12290
			Congas,
			// Token: 0x04003003 RID: 12291
			GatedVerb,
			// Token: 0x04003004 RID: 12292
			ReversedDrumLine,
			// Token: 0x04003005 RID: 12293
			UnderConstruction,
			// Token: 0x04003006 RID: 12294
			Default
		}

		// Token: 0x02000295 RID: 661
		[OriginalName("Assembly-CSharp.dll", "", "LevelSamplerPatch")]
		public enum LevelSamplerPatch
		{
			// Token: 0x04003008 RID: 12296
			Default,
			// Token: 0x04003009 RID: 12297
			Sticks,
			// Token: 0x0400300A RID: 12298
			Brushes,
			// Token: 0x0400300B RID: 12299
			Buckets,
			// Token: 0x0400300C RID: 12300
			Metallic,
			// Token: 0x0400300D RID: 12301
			DrumLine,
			// Token: 0x0400300E RID: 12302
			Congas,
			// Token: 0x0400300F RID: 12303
			GatedVerb,
			// Token: 0x04003010 RID: 12304
			ReversedDrumLine,
			// Token: 0x04003011 RID: 12305
			UnderConstruction,
			// Token: 0x04003012 RID: 12306
			Unused,
			// Token: 0x04003013 RID: 12307
			FrameDrums,
			// Token: 0x04003014 RID: 12308
			WoodWater
		}

		// Token: 0x02000296 RID: 662
		[ObfuscatedName("MusicSystem+<AsyncLoadPatches>d__86")]
		public sealed class _AsyncLoadPatches_d__86 : global::Il2CppSystem.Object
		{
			// Token: 0x060049CC RID: 18892 RVA: 0x001120F0 File Offset: 0x001102F0
			// Note: this type is marked as 'beforefieldinit'.
			static _AsyncLoadPatches_d__86()
			{
				Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<AsyncLoadPatches>d__86");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr);
				MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, "<>1__state");
				MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, "<>2__current");
				MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, "<>4__this");
				MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr_patches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, "patches");
				MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr_seqPatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, "seqPatches");
				MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, "callback");
				MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, "<i>5__2");
				MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr__req_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, "<req>5__3");
				MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr__patch_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, "<patch>5__4");
				MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, 100663375);
				MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, 100663376);
				MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, 100663377);
				MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, 100663378);
				MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, 100663379);
				MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr, 100663380);
			}

			// Token: 0x060049CD RID: 18893 RVA: 0x00112248 File Offset: 0x00110448
			[CallerCount(0)]
			public unsafe _AsyncLoadPatches_d__86(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSystem._AsyncLoadPatches_d__86>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060049CE RID: 18894 RVA: 0x00112290 File Offset: 0x00110490
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049CF RID: 18895 RVA: 0x001122C4 File Offset: 0x001104C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30677, XrefRangeEnd = 30712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001AE1 RID: 6881
			// (get) Token: 0x060049D0 RID: 18896 RVA: 0x00112300 File Offset: 0x00110500
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060049D1 RID: 18897 RVA: 0x00112340 File Offset: 0x00110540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30712, XrefRangeEnd = 30717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AE2 RID: 6882
			// (get) Token: 0x060049D2 RID: 18898 RVA: 0x00112374 File Offset: 0x00110574
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._AsyncLoadPatches_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060049D3 RID: 18899 RVA: 0x0002B7B7 File Offset: 0x000299B7
			public _AsyncLoadPatches_d__86(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AD8 RID: 6872
			// (get) Token: 0x060049D4 RID: 18900 RVA: 0x001123B4 File Offset: 0x001105B4
			// (set) Token: 0x060049D5 RID: 18901 RVA: 0x0002B7C0 File Offset: 0x000299C0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AD9 RID: 6873
			// (get) Token: 0x060049D6 RID: 18902 RVA: 0x001123DC File Offset: 0x001105DC
			// (set) Token: 0x060049D7 RID: 18903 RVA: 0x0002B7DB File Offset: 0x000299DB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ADA RID: 6874
			// (get) Token: 0x060049D8 RID: 18904 RVA: 0x0011240C File Offset: 0x0011060C
			// (set) Token: 0x060049D9 RID: 18905 RVA: 0x0002B7FA File Offset: 0x000299FA
			public unsafe MusicSystem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ADB RID: 6875
			// (get) Token: 0x060049DA RID: 18906 RVA: 0x0011243C File Offset: 0x0011063C
			// (set) Token: 0x060049DB RID: 18907 RVA: 0x0002B819 File Offset: 0x00029A19
			public unsafe Il2CppStructArray<MusicSystem.LevelSamplerPatch> patches
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr_patches);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSamplerPatch>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr_patches), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ADC RID: 6876
			// (get) Token: 0x060049DC RID: 18908 RVA: 0x0011246C File Offset: 0x0011066C
			// (set) Token: 0x060049DD RID: 18909 RVA: 0x0002B838 File Offset: 0x00029A38
			public unsafe Il2CppStructArray<MusicSystem.LevelSequencerPatch> seqPatches
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr_seqPatches);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MusicSystem.LevelSequencerPatch>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr_seqPatches), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ADD RID: 6877
			// (get) Token: 0x060049DE RID: 18910 RVA: 0x0011249C File Offset: 0x0011069C
			// (set) Token: 0x060049DF RID: 18911 RVA: 0x0002B857 File Offset: 0x00029A57
			public unsafe Action callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ADE RID: 6878
			// (get) Token: 0x060049E0 RID: 18912 RVA: 0x001124CC File Offset: 0x001106CC
			// (set) Token: 0x060049E1 RID: 18913 RVA: 0x0002B876 File Offset: 0x00029A76
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x17001ADF RID: 6879
			// (get) Token: 0x060049E2 RID: 18914 RVA: 0x001124F4 File Offset: 0x001106F4
			// (set) Token: 0x060049E3 RID: 18915 RVA: 0x0002B891 File Offset: 0x00029A91
			public unsafe ResourceRequest _req_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr__req_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr__req_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE0 RID: 6880
			// (get) Token: 0x060049E4 RID: 18916 RVA: 0x00112524 File Offset: 0x00110724
			// (set) Token: 0x060049E5 RID: 18917 RVA: 0x0002B8B0 File Offset: 0x00029AB0
			public unsafe AssetBundleRequest _patch_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr__patch_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._AsyncLoadPatches_d__86.NativeFieldInfoPtr__patch_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003015 RID: 12309
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003016 RID: 12310
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003017 RID: 12311
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003018 RID: 12312
			private static readonly IntPtr NativeFieldInfoPtr_patches;

			// Token: 0x04003019 RID: 12313
			private static readonly IntPtr NativeFieldInfoPtr_seqPatches;

			// Token: 0x0400301A RID: 12314
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400301B RID: 12315
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400301C RID: 12316
			private static readonly IntPtr NativeFieldInfoPtr__req_5__3;

			// Token: 0x0400301D RID: 12317
			private static readonly IntPtr NativeFieldInfoPtr__patch_5__4;

			// Token: 0x0400301E RID: 12318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400301F RID: 12319
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003020 RID: 12320
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003021 RID: 12321
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003022 RID: 12322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003023 RID: 12323
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000297 RID: 663
		[ObfuscatedName("MusicSystem+<WaitToSetFloats>d__87")]
		public sealed class _WaitToSetFloats_d__87 : global::Il2CppSystem.Object
		{
			// Token: 0x060049E6 RID: 18918 RVA: 0x00112554 File Offset: 0x00110754
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitToSetFloats_d__87()
			{
				Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<WaitToSetFloats>d__87");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr);
				MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr, "<>1__state");
				MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr, "<>2__current");
				MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr, "<>4__this");
				MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr_DistortionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr, "DistortionLevel");
				MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr_CompressorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr, "CompressorLevel");
				MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr, 100663381);
				MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr, 100663382);
				MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr, 100663383);
				MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr, 100663384);
				MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr, 100663385);
				MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr, 100663386);
			}

			// Token: 0x060049E7 RID: 18919 RVA: 0x0011265C File Offset: 0x0011085C
			[CallerCount(0)]
			public unsafe _WaitToSetFloats_d__87(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSystem._WaitToSetFloats_d__87>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060049E8 RID: 18920 RVA: 0x001126A4 File Offset: 0x001108A4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049E9 RID: 18921 RVA: 0x001126D8 File Offset: 0x001108D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30717, XrefRangeEnd = 30720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001AE8 RID: 6888
			// (get) Token: 0x060049EA RID: 18922 RVA: 0x00112714 File Offset: 0x00110914
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060049EB RID: 18923 RVA: 0x00112754 File Offset: 0x00110954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30720, XrefRangeEnd = 30725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AE9 RID: 6889
			// (get) Token: 0x060049EC RID: 18924 RVA: 0x00112788 File Offset: 0x00110988
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._WaitToSetFloats_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060049ED RID: 18925 RVA: 0x0002B8CF File Offset: 0x00029ACF
			public _WaitToSetFloats_d__87(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AE3 RID: 6883
			// (get) Token: 0x060049EE RID: 18926 RVA: 0x001127C8 File Offset: 0x001109C8
			// (set) Token: 0x060049EF RID: 18927 RVA: 0x0002B8D8 File Offset: 0x00029AD8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AE4 RID: 6884
			// (get) Token: 0x060049F0 RID: 18928 RVA: 0x001127F0 File Offset: 0x001109F0
			// (set) Token: 0x060049F1 RID: 18929 RVA: 0x0002B8F3 File Offset: 0x00029AF3
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE5 RID: 6885
			// (get) Token: 0x060049F2 RID: 18930 RVA: 0x00112820 File Offset: 0x00110A20
			// (set) Token: 0x060049F3 RID: 18931 RVA: 0x0002B912 File Offset: 0x00029B12
			public unsafe MusicSystem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE6 RID: 6886
			// (get) Token: 0x060049F4 RID: 18932 RVA: 0x00112850 File Offset: 0x00110A50
			// (set) Token: 0x060049F5 RID: 18933 RVA: 0x0002B931 File Offset: 0x00029B31
			public unsafe float DistortionLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr_DistortionLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr_DistortionLevel)) = value;
				}
			}

			// Token: 0x17001AE7 RID: 6887
			// (get) Token: 0x060049F6 RID: 18934 RVA: 0x00112878 File Offset: 0x00110A78
			// (set) Token: 0x060049F7 RID: 18935 RVA: 0x0002B94C File Offset: 0x00029B4C
			public unsafe float CompressorLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr_CompressorLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._WaitToSetFloats_d__87.NativeFieldInfoPtr_CompressorLevel)) = value;
				}
			}

			// Token: 0x04003024 RID: 12324
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003025 RID: 12325
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003026 RID: 12326
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003027 RID: 12327
			private static readonly IntPtr NativeFieldInfoPtr_DistortionLevel;

			// Token: 0x04003028 RID: 12328
			private static readonly IntPtr NativeFieldInfoPtr_CompressorLevel;

			// Token: 0x04003029 RID: 12329
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400302A RID: 12330
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400302B RID: 12331
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400302C RID: 12332
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400302D RID: 12333
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400302E RID: 12334
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000298 RID: 664
		[ObfuscatedName("MusicSystem+<ChangeTempo>d__117")]
		public sealed class _ChangeTempo_d__117 : global::Il2CppSystem.Object
		{
			// Token: 0x060049F8 RID: 18936 RVA: 0x001128A0 File Offset: 0x00110AA0
			// Note: this type is marked as 'beforefieldinit'.
			static _ChangeTempo_d__117()
			{
				Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<ChangeTempo>d__117");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr);
				MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr, "<>1__state");
				MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr, "<>2__current");
				MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr_newTempo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr, "newTempo");
				MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr, "<>4__this");
				MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr, 100663387);
				MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr, 100663388);
				MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr, 100663389);
				MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr, 100663390);
				MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr, 100663391);
				MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr, 100663392);
			}

			// Token: 0x060049F9 RID: 18937 RVA: 0x00112994 File Offset: 0x00110B94
			[CallerCount(0)]
			public unsafe _ChangeTempo_d__117(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSystem._ChangeTempo_d__117>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060049FA RID: 18938 RVA: 0x001129DC File Offset: 0x00110BDC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049FB RID: 18939 RVA: 0x00112A10 File Offset: 0x00110C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30725, XrefRangeEnd = 30737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001AEE RID: 6894
			// (get) Token: 0x060049FC RID: 18940 RVA: 0x00112A4C File Offset: 0x00110C4C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060049FD RID: 18941 RVA: 0x00112A8C File Offset: 0x00110C8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30737, XrefRangeEnd = 30742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AEF RID: 6895
			// (get) Token: 0x060049FE RID: 18942 RVA: 0x00112AC0 File Offset: 0x00110CC0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSystem._ChangeTempo_d__117.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060049FF RID: 18943 RVA: 0x0002B967 File Offset: 0x00029B67
			public _ChangeTempo_d__117(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AEA RID: 6890
			// (get) Token: 0x06004A00 RID: 18944 RVA: 0x00112B00 File Offset: 0x00110D00
			// (set) Token: 0x06004A01 RID: 18945 RVA: 0x0002B970 File Offset: 0x00029B70
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AEB RID: 6891
			// (get) Token: 0x06004A02 RID: 18946 RVA: 0x00112B28 File Offset: 0x00110D28
			// (set) Token: 0x06004A03 RID: 18947 RVA: 0x0002B98B File Offset: 0x00029B8B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AEC RID: 6892
			// (get) Token: 0x06004A04 RID: 18948 RVA: 0x00112B58 File Offset: 0x00110D58
			// (set) Token: 0x06004A05 RID: 18949 RVA: 0x0002B9AA File Offset: 0x00029BAA
			public unsafe float newTempo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr_newTempo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr_newTempo)) = value;
				}
			}

			// Token: 0x17001AED RID: 6893
			// (get) Token: 0x06004A06 RID: 18950 RVA: 0x00112B80 File Offset: 0x00110D80
			// (set) Token: 0x06004A07 RID: 18951 RVA: 0x0002B9C5 File Offset: 0x00029BC5
			public unsafe MusicSystem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSystem._ChangeTempo_d__117.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400302F RID: 12335
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003030 RID: 12336
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003031 RID: 12337
			private static readonly IntPtr NativeFieldInfoPtr_newTempo;

			// Token: 0x04003032 RID: 12338
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003033 RID: 12339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003034 RID: 12340
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003035 RID: 12341
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003036 RID: 12342
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003037 RID: 12343
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003038 RID: 12344
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
