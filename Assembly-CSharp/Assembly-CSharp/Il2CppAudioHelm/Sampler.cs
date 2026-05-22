using System;
using System.Runtime.InteropServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2CppAudioHelm
{
	// Token: 0x02000288 RID: 648
	public class Sampler : MonoBehaviour
	{
		// Token: 0x06004831 RID: 18481 RVA: 0x0010DAE8 File Offset: 0x0010BCE8
		// Note: this type is marked as 'beforefieldinit'.
		static Sampler()
		{
			Il2CppClassPointerStore<Sampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "Sampler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sampler>.NativeClassPtr);
			Sampler.NativeFieldInfoPtr_keyzones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "keyzones");
			Sampler.NativeFieldInfoPtr_keyzonePlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "keyzonePlayMode");
			Sampler.NativeFieldInfoPtr_velocityTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "velocityTracking");
			Sampler.NativeFieldInfoPtr_numVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "numVoices");
			Sampler.NativeFieldInfoPtr_voiceAvailabilityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "voiceAvailabilityMask");
			Sampler.NativeFieldInfoPtr_useNoteOff_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "useNoteOff_");
			Sampler.NativeFieldInfoPtr_LoadMinimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "LoadMinimal");
			Sampler.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "Volume");
			Sampler.NativeFieldInfoPtr_audioIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "audioIndex");
			Sampler.NativeFieldInfoPtr_activeNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "activeNotes");
			Sampler.NativeFieldInfoPtr_endEarlyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "endEarlyTime");
			Sampler.NativeFieldInfoPtr_OutputMixerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "OutputMixerGroup");
			Sampler.NativeFieldInfoPtr_HitHatPedalMixerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "HitHatPedalMixerGroup");
			Sampler.NativeFieldInfoPtr_CymbalMixerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "CymbalMixerGroup");
			Sampler.NativeFieldInfoPtr_Patch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "Patch");
			Sampler.NativeFieldInfoPtr_activeNoteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "activeNoteIndex");
			Sampler.NativeFieldInfoPtr_keyZoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "keyZoneIndex");
			Sampler.NativeFieldInfoPtr_voicesToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "voicesToAdd");
			Sampler.NativeFieldInfoPtr_originalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "originalIndex");
			Sampler.NativeFieldInfoPtr_toPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "toPlay");
			Sampler.NativeFieldInfoPtr_oldest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "oldest");
			Sampler.NativeFieldInfoPtr_oldestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "oldestTime");
			Sampler.NativeFieldInfoPtr_indexKZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "indexKZ");
			Sampler.NativeFieldInfoPtr_lastSourceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "lastSourceIndex");
			Sampler.NativeFieldInfoPtr_validKeyzones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "validKeyzones");
			Sampler.NativeFieldInfoPtr_audios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "audios");
			Sampler.NativeFieldInfoPtr_sourceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "sourceIndex");
			Sampler.NativeFieldInfoPtr_validKeyzoneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "validKeyzoneCount");
			Sampler.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "min");
			Sampler.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "max");
			Sampler.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "length");
			Sampler.NativeFieldInfoPtr_myActiveNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "myActiveNote");
			Sampler.NativeFieldInfoPtr_HiHatIsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "HiHatIsOpen");
			Sampler.NativeFieldInfoPtr_preppedAudioSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "preppedAudioSources");
			Sampler.NativeFieldInfoPtr_activeNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "activeNote");
			Sampler.NativeFieldInfoPtr_midiNoteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "midiNoteIndex");
			Sampler.NativeFieldInfoPtr_setPatchIterator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "setPatchIterator");
			Sampler.NativeFieldInfoPtr_sampleCountInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "sampleCountInt");
			Sampler.NativeFieldInfoPtr_increment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "increment");
			Sampler.NativeFieldInfoPtr_roundRobinIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "roundRobinIncrement");
			Sampler.NativeFieldInfoPtr_incrementAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "incrementAmount");
			Sampler.NativeFieldInfoPtr_velocityLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "velocityLevels");
			Sampler.NativeFieldInfoPtr_latinString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "latinString");
			Sampler.NativeFieldInfoPtr_bongoString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "bongoString");
			Sampler.NativeFieldInfoPtr_congaString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "congaString");
			Sampler.NativeFieldInfoPtr_metallicString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "metallicString");
			Sampler.NativeFieldInfoPtr_popKeyZoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "popKeyZoneIndex");
			Sampler.NativeFieldInfoPtr_popKeyZonesClipCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "popKeyZonesClipCounter");
			Sampler.NativeFieldInfoPtr_popKeyZonesIterator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "popKeyZonesIterator");
			Sampler.NativeMethodInfoPtr_get_useNoteOff_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670729);
			Sampler.NativeMethodInfoPtr_set_useNoteOff_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670730);
			Sampler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670731);
			Sampler.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670732);
			Sampler.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670733);
			Sampler.NativeMethodInfoPtr_AddKeyzone_Public_Keyzone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670734);
			Sampler.NativeMethodInfoPtr_AddKeyzoneGetIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670735);
			Sampler.NativeMethodInfoPtr_RemoveKeyzone_Public_Int32_Keyzone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670736);
			Sampler.NativeMethodInfoPtr_GetNextAudioSourceIndex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670737);
			Sampler.NativeMethodInfoPtr_PrepNote_Private_Void_AudioSource_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670738);
			Sampler.NativeMethodInfoPtr_PrepNote_Private_Void_AudioSource_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670739);
			Sampler.NativeMethodInfoPtr_GetValidKeyzones_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670740);
			Sampler.NativeMethodInfoPtr_GetKeyzonesToPlay_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670741);
			Sampler.NativeMethodInfoPtr_GetPreppedAudioSources_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670742);
			Sampler.NativeMethodInfoPtr_GetMinKey_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670743);
			Sampler.NativeMethodInfoPtr_GetMaxKey_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670744);
			Sampler.NativeMethodInfoPtr_AllNotesOff_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670745);
			Sampler.NativeMethodInfoPtr_TurnVoiceOffInSeconds_Private_IEnumerator_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670746);
			Sampler.NativeMethodInfoPtr_AddNoteToActiveNotes_Private_Void_ActiveNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670747);
			Sampler.NativeMethodInfoPtr_RemoveFromActiveNotes_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670748);
			Sampler.NativeMethodInfoPtr_NoteOn_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670749);
			Sampler.NativeMethodInfoPtr_NoteOn_Public_Void_Int32_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670750);
			Sampler.NativeMethodInfoPtr_ManageHiHat_Private_IEnumerator_Int32_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670751);
			Sampler.NativeMethodInfoPtr_NoteOnScheduled_Public_Void_Int32_Single_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670752);
			Sampler.NativeMethodInfoPtr_FindActiveNoteIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670753);
			Sampler.NativeMethodInfoPtr_NoteOff_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670754);
			Sampler.NativeMethodInfoPtr_DoNoteOff_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670755);
			Sampler.NativeMethodInfoPtr_SetPatch_Public_Void_SamplerPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670756);
			Sampler.NativeMethodInfoPtr_SetPanValuesFromMidiNote_Private_Void_byref_Keyzone_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670757);
			Sampler.NativeMethodInfoPtr_PopulateKeyZones_Private_Void_SamplerPatch_List_1_AudioClip_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670758);
			Sampler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100670759);
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x0010E158 File Offset: 0x0010C358
		// (set) Token: 0x06004833 RID: 18483 RVA: 0x0010E194 File Offset: 0x0010C394
		public unsafe bool useNoteOff
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_get_useNoteOff_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117109, XrefRangeEnd = 117110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_set_useNoteOff_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x0010E1D4 File Offset: 0x0010C3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117110, XrefRangeEnd = 117154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x0010E208 File Offset: 0x0010C408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117154, XrefRangeEnd = 117155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x0010E23C File Offset: 0x0010C43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x0010E270 File Offset: 0x0010C470
		[CallerCount(0)]
		public unsafe Keyzone AddKeyzone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_AddKeyzone_Public_Keyzone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Keyzone(intPtr);
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x0010E2A8 File Offset: 0x0010C4A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117155, RefRangeEnd = 117159, XrefRangeStart = 117155, XrefRangeEnd = 117155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKeyzoneGetIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_AddKeyzoneGetIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x0010E2E4 File Offset: 0x0010C4E4
		[CallerCount(0)]
		public unsafe int RemoveKeyzone(Keyzone keyzone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyzone));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_RemoveKeyzone_Public_Int32_Keyzone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x0010E338 File Offset: 0x0010C538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117159, XrefRangeEnd = 117175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNextAudioSourceIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_GetNextAudioSourceIndex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x0010E36C File Offset: 0x0010C56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117175, XrefRangeEnd = 117188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepNote(AudioSource audioSource, int note, float velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioSource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_PrepNote_Private_Void_AudioSource_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x0010E3CC File Offset: 0x0010C5CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117221, RefRangeEnd = 117222, XrefRangeStart = 117188, XrefRangeEnd = 117221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepNote(AudioSource audioSource, int keyzoneIndex, int note, float velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioSource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyzoneIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_PrepNote_Private_Void_AudioSource_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x0010E438 File Offset: 0x0010C638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117238, RefRangeEnd = 117239, XrefRangeStart = 117222, XrefRangeEnd = 117238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetValidKeyzones(int note, float velocity = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_GetValidKeyzones_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x0010E484 File Offset: 0x0010C684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117252, RefRangeEnd = 117253, XrefRangeStart = 117239, XrefRangeEnd = 117252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetKeyzonesToPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_GetKeyzonesToPlay_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600483F RID: 18495 RVA: 0x0010E4C0 File Offset: 0x0010C6C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117279, RefRangeEnd = 117281, XrefRangeStart = 117253, XrefRangeEnd = 117279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPreppedAudioSources(int note, float velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_GetPreppedAudioSources_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x0010E50C File Offset: 0x0010C70C
		[CallerCount(0)]
		public unsafe int GetMinKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_GetMinKey_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x0010E548 File Offset: 0x0010C748
		[CallerCount(0)]
		public unsafe int GetMaxKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_GetMaxKey_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x0010E584 File Offset: 0x0010C784
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117296, RefRangeEnd = 117300, XrefRangeStart = 117281, XrefRangeEnd = 117296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AllNotesOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_AllNotesOff_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x0010E5B8 File Offset: 0x0010C7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117300, XrefRangeEnd = 117303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TurnVoiceOffInSeconds(int note, float seconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_TurnVoiceOffInSeconds_Private_IEnumerator_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x0010E614 File Offset: 0x0010C814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117310, RefRangeEnd = 117312, XrefRangeStart = 117303, XrefRangeEnd = 117310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNoteToActiveNotes(Sampler.ActiveNote note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_AddNoteToActiveNotes_Private_Void_ActiveNote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x0010E654 File Offset: 0x0010C854
		[CallerCount(0)]
		public unsafe void RemoveFromActiveNotes(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_RemoveFromActiveNotes_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x0010E694 File Offset: 0x0010C894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117312, XrefRangeEnd = 117313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoteOn(int note, float velocity = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_NoteOn_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x0010E6E0 File Offset: 0x0010C8E0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 117335, RefRangeEnd = 117349, XrefRangeStart = 117313, XrefRangeEnd = 117335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoteOn(int note, bool isKill = false, float velocity = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKill;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_NoteOn_Public_Void_Int32_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x0010E73C File Offset: 0x0010C93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117349, XrefRangeEnd = 117352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ManageHiHat(int note, bool scheduled, float timeUntilPlay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scheduled;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeUntilPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_ManageHiHat_Private_IEnumerator_Int32_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x0010E7A4 File Offset: 0x0010C9A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117363, RefRangeEnd = 117364, XrefRangeStart = 117352, XrefRangeEnd = 117363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoteOnScheduled(int note, float velocity, double timeToStart, double timeToEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeToStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeToEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_NoteOnScheduled_Public_Void_Int32_Single_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x0010E80C File Offset: 0x0010CA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117364, XrefRangeEnd = 117365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindActiveNoteIndex(int note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_FindActiveNoteIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x0010E858 File Offset: 0x0010CA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117365, XrefRangeEnd = 117366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoteOff(int note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_NoteOff_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x0010E898 File Offset: 0x0010CA98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117367, RefRangeEnd = 117369, XrefRangeStart = 117366, XrefRangeEnd = 117367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoNoteOff(int note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_DoNoteOff_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x0010E8D8 File Offset: 0x0010CAD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117403, RefRangeEnd = 117407, XrefRangeStart = 117369, XrefRangeEnd = 117403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPatch(SamplerPatch patch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_SetPatch_Public_Void_SamplerPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x0010E91C File Offset: 0x0010CB1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117407, RefRangeEnd = 117411, XrefRangeStart = 117407, XrefRangeEnd = 117407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPanValuesFromMidiNote(ref Keyzone kz, int midiNote)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kz));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref midiNote;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_SetPanValuesFromMidiNote_Private_Void_byref_Keyzone_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x0010E974 File Offset: 0x0010CB74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117464, RefRangeEnd = 117465, XrefRangeStart = 117411, XrefRangeEnd = 117464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateKeyZones(SamplerPatch patch, List<AudioClip> clips, int VelocityLevels, int TheRoundRobinCount, int midiNote, bool loadMinimal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clips);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref VelocityLevels;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TheRoundRobinCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref midiNote;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadMinimal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_PopulateKeyZones_Private_Void_SamplerPatch_List_1_AudioClip_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x0010EA00 File Offset: 0x0010CC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117465, XrefRangeEnd = 117501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sampler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sampler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x0002A76D File Offset: 0x0002896D
		public Sampler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x06004852 RID: 18514 RVA: 0x0010EA3C File Offset: 0x0010CC3C
		// (set) Token: 0x06004853 RID: 18515 RVA: 0x0002A776 File Offset: 0x00028976
		public unsafe Il2CppReferenceArray<Keyzone> keyzones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_keyzones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Keyzone>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_keyzones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06004854 RID: 18516 RVA: 0x0010EA6C File Offset: 0x0010CC6C
		// (set) Token: 0x06004855 RID: 18517 RVA: 0x0002A795 File Offset: 0x00028995
		public unsafe Sampler.KeyzonePlayMode keyzonePlayMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_keyzonePlayMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_keyzonePlayMode)) = value;
			}
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06004856 RID: 18518 RVA: 0x0010EA94 File Offset: 0x0010CC94
		// (set) Token: 0x06004857 RID: 18519 RVA: 0x0002A7B0 File Offset: 0x000289B0
		public unsafe float velocityTracking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_velocityTracking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_velocityTracking)) = value;
			}
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x0010EABC File Offset: 0x0010CCBC
		// (set) Token: 0x06004859 RID: 18521 RVA: 0x0002A7CB File Offset: 0x000289CB
		public unsafe int numVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_numVoices);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_numVoices)) = value;
			}
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x0010EAE4 File Offset: 0x0010CCE4
		// (set) Token: 0x0600485B RID: 18523 RVA: 0x0002A7E6 File Offset: 0x000289E6
		public unsafe List<bool> voiceAvailabilityMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_voiceAvailabilityMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_voiceAvailabilityMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x0600485C RID: 18524 RVA: 0x0010EB14 File Offset: 0x0010CD14
		// (set) Token: 0x0600485D RID: 18525 RVA: 0x0002A805 File Offset: 0x00028A05
		public unsafe bool useNoteOff_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_useNoteOff_);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_useNoteOff_)) = value;
			}
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x0010EB3C File Offset: 0x0010CD3C
		// (set) Token: 0x0600485F RID: 18527 RVA: 0x0002A820 File Offset: 0x00028A20
		public unsafe bool LoadMinimal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_LoadMinimal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_LoadMinimal)) = value;
			}
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x0010EB64 File Offset: 0x0010CD64
		// (set) Token: 0x06004861 RID: 18529 RVA: 0x0002A83B File Offset: 0x00028A3B
		public unsafe float Volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_Volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_Volume)) = value;
			}
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06004862 RID: 18530 RVA: 0x0010EB8C File Offset: 0x0010CD8C
		// (set) Token: 0x06004863 RID: 18531 RVA: 0x0002A856 File Offset: 0x00028A56
		public unsafe int audioIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_audioIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_audioIndex)) = value;
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06004864 RID: 18532 RVA: 0x0010EBB4 File Offset: 0x0010CDB4
		// (set) Token: 0x06004865 RID: 18533 RVA: 0x0002A871 File Offset: 0x00028A71
		public unsafe Il2CppStructArray<Sampler.ActiveNote> activeNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_activeNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Sampler.ActiveNote>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_activeNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06004866 RID: 18534 RVA: 0x0010EBE4 File Offset: 0x0010CDE4
		// (set) Token: 0x06004867 RID: 18535 RVA: 0x0002A890 File Offset: 0x00028A90
		public unsafe static double endEarlyTime
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Sampler.NativeFieldInfoPtr_endEarlyTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sampler.NativeFieldInfoPtr_endEarlyTime, (void*)(&value));
			}
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06004868 RID: 18536 RVA: 0x0010EC00 File Offset: 0x0010CE00
		// (set) Token: 0x06004869 RID: 18537 RVA: 0x0002A89E File Offset: 0x00028A9E
		public unsafe AudioMixerGroup OutputMixerGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_OutputMixerGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_OutputMixerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x0600486A RID: 18538 RVA: 0x0010EC30 File Offset: 0x0010CE30
		// (set) Token: 0x0600486B RID: 18539 RVA: 0x0002A8BD File Offset: 0x00028ABD
		public unsafe AudioMixerGroup HitHatPedalMixerGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_HitHatPedalMixerGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_HitHatPedalMixerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x0600486C RID: 18540 RVA: 0x0010EC60 File Offset: 0x0010CE60
		// (set) Token: 0x0600486D RID: 18541 RVA: 0x0002A8DC File Offset: 0x00028ADC
		public unsafe AudioMixerGroup CymbalMixerGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_CymbalMixerGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_CymbalMixerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x0600486E RID: 18542 RVA: 0x0010EC90 File Offset: 0x0010CE90
		// (set) Token: 0x0600486F RID: 18543 RVA: 0x0002A8FB File Offset: 0x00028AFB
		public unsafe SamplerPatch Patch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_Patch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SamplerPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_Patch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x0010ECC0 File Offset: 0x0010CEC0
		// (set) Token: 0x06004871 RID: 18545 RVA: 0x0002A91A File Offset: 0x00028B1A
		public unsafe int activeNoteIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_activeNoteIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_activeNoteIndex)) = value;
			}
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06004872 RID: 18546 RVA: 0x0010ECE8 File Offset: 0x0010CEE8
		// (set) Token: 0x06004873 RID: 18547 RVA: 0x0002A935 File Offset: 0x00028B35
		public unsafe int keyZoneIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_keyZoneIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_keyZoneIndex)) = value;
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06004874 RID: 18548 RVA: 0x0010ED10 File Offset: 0x0010CF10
		// (set) Token: 0x06004875 RID: 18549 RVA: 0x0002A950 File Offset: 0x00028B50
		public unsafe int voicesToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_voicesToAdd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_voicesToAdd)) = value;
			}
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06004876 RID: 18550 RVA: 0x0010ED38 File Offset: 0x0010CF38
		// (set) Token: 0x06004877 RID: 18551 RVA: 0x0002A96B File Offset: 0x00028B6B
		public unsafe int originalIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_originalIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_originalIndex)) = value;
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06004878 RID: 18552 RVA: 0x0010ED60 File Offset: 0x0010CF60
		// (set) Token: 0x06004879 RID: 18553 RVA: 0x0002A986 File Offset: 0x00028B86
		public unsafe Il2CppReferenceArray<Keyzone> toPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_toPlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Keyzone>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_toPlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x0600487A RID: 18554 RVA: 0x0010ED90 File Offset: 0x0010CF90
		// (set) Token: 0x0600487B RID: 18555 RVA: 0x0002A9A5 File Offset: 0x00028BA5
		public Keyzone oldest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_oldest);
				return new Keyzone(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_oldest), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x0600487C RID: 18556 RVA: 0x0010EDC0 File Offset: 0x0010CFC0
		// (set) Token: 0x0600487D RID: 18557 RVA: 0x0002A9D3 File Offset: 0x00028BD3
		public unsafe double oldestTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_oldestTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_oldestTime)) = value;
			}
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x0010EDE8 File Offset: 0x0010CFE8
		// (set) Token: 0x0600487F RID: 18559 RVA: 0x0002A9EE File Offset: 0x00028BEE
		public unsafe int indexKZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_indexKZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_indexKZ)) = value;
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06004880 RID: 18560 RVA: 0x0010EE10 File Offset: 0x0010D010
		// (set) Token: 0x06004881 RID: 18561 RVA: 0x0002AA09 File Offset: 0x00028C09
		public unsafe int lastSourceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_lastSourceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_lastSourceIndex)) = value;
			}
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x0010EE38 File Offset: 0x0010D038
		// (set) Token: 0x06004883 RID: 18563 RVA: 0x0002AA24 File Offset: 0x00028C24
		public unsafe Il2CppReferenceArray<Keyzone> validKeyzones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_validKeyzones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Keyzone>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_validKeyzones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06004884 RID: 18564 RVA: 0x0010EE68 File Offset: 0x0010D068
		// (set) Token: 0x06004885 RID: 18565 RVA: 0x0002AA43 File Offset: 0x00028C43
		public unsafe Il2CppReferenceArray<AudioSource> audios
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_audios);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_audios), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06004886 RID: 18566 RVA: 0x0010EE98 File Offset: 0x0010D098
		// (set) Token: 0x06004887 RID: 18567 RVA: 0x0002AA62 File Offset: 0x00028C62
		public unsafe int sourceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_sourceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_sourceIndex)) = value;
			}
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06004888 RID: 18568 RVA: 0x0010EEC0 File Offset: 0x0010D0C0
		// (set) Token: 0x06004889 RID: 18569 RVA: 0x0002AA7D File Offset: 0x00028C7D
		public unsafe int validKeyzoneCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_validKeyzoneCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_validKeyzoneCount)) = value;
			}
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x0600488A RID: 18570 RVA: 0x0010EEE8 File Offset: 0x0010D0E8
		// (set) Token: 0x0600488B RID: 18571 RVA: 0x0002AA98 File Offset: 0x00028C98
		public unsafe static int min
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Sampler.NativeFieldInfoPtr_min, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sampler.NativeFieldInfoPtr_min, (void*)(&value));
			}
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x0600488C RID: 18572 RVA: 0x0010EF04 File Offset: 0x0010D104
		// (set) Token: 0x0600488D RID: 18573 RVA: 0x0002AAA6 File Offset: 0x00028CA6
		public unsafe static int max
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Sampler.NativeFieldInfoPtr_max, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sampler.NativeFieldInfoPtr_max, (void*)(&value));
			}
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x0600488E RID: 18574 RVA: 0x0010EF20 File Offset: 0x0010D120
		// (set) Token: 0x0600488F RID: 18575 RVA: 0x0002AAB4 File Offset: 0x00028CB4
		public unsafe double length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06004890 RID: 18576 RVA: 0x0010EF48 File Offset: 0x0010D148
		// (set) Token: 0x06004891 RID: 18577 RVA: 0x0002AACF File Offset: 0x00028CCF
		public unsafe Sampler.ActiveNote myActiveNote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_myActiveNote);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_myActiveNote)) = value;
			}
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x06004892 RID: 18578 RVA: 0x0010EF70 File Offset: 0x0010D170
		// (set) Token: 0x06004893 RID: 18579 RVA: 0x0002AAEA File Offset: 0x00028CEA
		public unsafe bool HiHatIsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_HiHatIsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_HiHatIsOpen)) = value;
			}
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x0010EF98 File Offset: 0x0010D198
		// (set) Token: 0x06004895 RID: 18581 RVA: 0x0002AB05 File Offset: 0x00028D05
		public unsafe Il2CppReferenceArray<AudioSource> preppedAudioSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_preppedAudioSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_preppedAudioSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06004896 RID: 18582 RVA: 0x0010EFC8 File Offset: 0x0010D1C8
		// (set) Token: 0x06004897 RID: 18583 RVA: 0x0002AB24 File Offset: 0x00028D24
		public unsafe Sampler.ActiveNote activeNote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_activeNote);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_activeNote)) = value;
			}
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x06004898 RID: 18584 RVA: 0x0010EFF0 File Offset: 0x0010D1F0
		// (set) Token: 0x06004899 RID: 18585 RVA: 0x0002AB3F File Offset: 0x00028D3F
		public unsafe int midiNoteIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_midiNoteIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_midiNoteIndex)) = value;
			}
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x0600489A RID: 18586 RVA: 0x0010F018 File Offset: 0x0010D218
		// (set) Token: 0x0600489B RID: 18587 RVA: 0x0002AB5A File Offset: 0x00028D5A
		public unsafe int setPatchIterator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_setPatchIterator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_setPatchIterator)) = value;
			}
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x0600489C RID: 18588 RVA: 0x0010F040 File Offset: 0x0010D240
		// (set) Token: 0x0600489D RID: 18589 RVA: 0x0002AB75 File Offset: 0x00028D75
		public unsafe int sampleCountInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_sampleCountInt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_sampleCountInt)) = value;
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x0010F068 File Offset: 0x0010D268
		// (set) Token: 0x0600489F RID: 18591 RVA: 0x0002AB90 File Offset: 0x00028D90
		public unsafe int increment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_increment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_increment)) = value;
			}
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x060048A0 RID: 18592 RVA: 0x0010F090 File Offset: 0x0010D290
		// (set) Token: 0x060048A1 RID: 18593 RVA: 0x0002ABAB File Offset: 0x00028DAB
		public unsafe int roundRobinIncrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_roundRobinIncrement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_roundRobinIncrement)) = value;
			}
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x060048A2 RID: 18594 RVA: 0x0010F0B8 File Offset: 0x0010D2B8
		// (set) Token: 0x060048A3 RID: 18595 RVA: 0x0002ABC6 File Offset: 0x00028DC6
		public unsafe float incrementAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_incrementAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_incrementAmount)) = value;
			}
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x060048A4 RID: 18596 RVA: 0x0010F0E0 File Offset: 0x0010D2E0
		// (set) Token: 0x060048A5 RID: 18597 RVA: 0x0002ABE1 File Offset: 0x00028DE1
		public unsafe int velocityLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_velocityLevels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_velocityLevels)) = value;
			}
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x0010F108 File Offset: 0x0010D308
		// (set) Token: 0x060048A7 RID: 18599 RVA: 0x0002ABFC File Offset: 0x00028DFC
		public unsafe string latinString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_latinString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_latinString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x0010F130 File Offset: 0x0010D330
		// (set) Token: 0x060048A9 RID: 18601 RVA: 0x0002AC1B File Offset: 0x00028E1B
		public unsafe string bongoString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_bongoString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_bongoString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x0010F158 File Offset: 0x0010D358
		// (set) Token: 0x060048AB RID: 18603 RVA: 0x0002AC3A File Offset: 0x00028E3A
		public unsafe string congaString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_congaString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_congaString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x060048AC RID: 18604 RVA: 0x0010F180 File Offset: 0x0010D380
		// (set) Token: 0x060048AD RID: 18605 RVA: 0x0002AC59 File Offset: 0x00028E59
		public unsafe string metallicString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_metallicString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_metallicString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x060048AE RID: 18606 RVA: 0x0010F1A8 File Offset: 0x0010D3A8
		// (set) Token: 0x060048AF RID: 18607 RVA: 0x0002AC78 File Offset: 0x00028E78
		public unsafe int popKeyZoneIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_popKeyZoneIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_popKeyZoneIndex)) = value;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x060048B0 RID: 18608 RVA: 0x0010F1D0 File Offset: 0x0010D3D0
		// (set) Token: 0x060048B1 RID: 18609 RVA: 0x0002AC93 File Offset: 0x00028E93
		public unsafe int popKeyZonesClipCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_popKeyZonesClipCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_popKeyZonesClipCounter)) = value;
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x060048B2 RID: 18610 RVA: 0x0010F1F8 File Offset: 0x0010D3F8
		// (set) Token: 0x060048B3 RID: 18611 RVA: 0x0002ACAE File Offset: 0x00028EAE
		public unsafe int popKeyZonesIterator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_popKeyZonesIterator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_popKeyZonesIterator)) = value;
			}
		}

		// Token: 0x04002E4C RID: 11852
		private static readonly IntPtr NativeFieldInfoPtr_keyzones;

		// Token: 0x04002E4D RID: 11853
		private static readonly IntPtr NativeFieldInfoPtr_keyzonePlayMode;

		// Token: 0x04002E4E RID: 11854
		private static readonly IntPtr NativeFieldInfoPtr_velocityTracking;

		// Token: 0x04002E4F RID: 11855
		private static readonly IntPtr NativeFieldInfoPtr_numVoices;

		// Token: 0x04002E50 RID: 11856
		private static readonly IntPtr NativeFieldInfoPtr_voiceAvailabilityMask;

		// Token: 0x04002E51 RID: 11857
		private static readonly IntPtr NativeFieldInfoPtr_useNoteOff_;

		// Token: 0x04002E52 RID: 11858
		private static readonly IntPtr NativeFieldInfoPtr_LoadMinimal;

		// Token: 0x04002E53 RID: 11859
		private static readonly IntPtr NativeFieldInfoPtr_Volume;

		// Token: 0x04002E54 RID: 11860
		private static readonly IntPtr NativeFieldInfoPtr_audioIndex;

		// Token: 0x04002E55 RID: 11861
		private static readonly IntPtr NativeFieldInfoPtr_activeNotes;

		// Token: 0x04002E56 RID: 11862
		private static readonly IntPtr NativeFieldInfoPtr_endEarlyTime;

		// Token: 0x04002E57 RID: 11863
		private static readonly IntPtr NativeFieldInfoPtr_OutputMixerGroup;

		// Token: 0x04002E58 RID: 11864
		private static readonly IntPtr NativeFieldInfoPtr_HitHatPedalMixerGroup;

		// Token: 0x04002E59 RID: 11865
		private static readonly IntPtr NativeFieldInfoPtr_CymbalMixerGroup;

		// Token: 0x04002E5A RID: 11866
		private static readonly IntPtr NativeFieldInfoPtr_Patch;

		// Token: 0x04002E5B RID: 11867
		private static readonly IntPtr NativeFieldInfoPtr_activeNoteIndex;

		// Token: 0x04002E5C RID: 11868
		private static readonly IntPtr NativeFieldInfoPtr_keyZoneIndex;

		// Token: 0x04002E5D RID: 11869
		private static readonly IntPtr NativeFieldInfoPtr_voicesToAdd;

		// Token: 0x04002E5E RID: 11870
		private static readonly IntPtr NativeFieldInfoPtr_originalIndex;

		// Token: 0x04002E5F RID: 11871
		private static readonly IntPtr NativeFieldInfoPtr_toPlay;

		// Token: 0x04002E60 RID: 11872
		private static readonly IntPtr NativeFieldInfoPtr_oldest;

		// Token: 0x04002E61 RID: 11873
		private static readonly IntPtr NativeFieldInfoPtr_oldestTime;

		// Token: 0x04002E62 RID: 11874
		private static readonly IntPtr NativeFieldInfoPtr_indexKZ;

		// Token: 0x04002E63 RID: 11875
		private static readonly IntPtr NativeFieldInfoPtr_lastSourceIndex;

		// Token: 0x04002E64 RID: 11876
		private static readonly IntPtr NativeFieldInfoPtr_validKeyzones;

		// Token: 0x04002E65 RID: 11877
		private static readonly IntPtr NativeFieldInfoPtr_audios;

		// Token: 0x04002E66 RID: 11878
		private static readonly IntPtr NativeFieldInfoPtr_sourceIndex;

		// Token: 0x04002E67 RID: 11879
		private static readonly IntPtr NativeFieldInfoPtr_validKeyzoneCount;

		// Token: 0x04002E68 RID: 11880
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04002E69 RID: 11881
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04002E6A RID: 11882
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04002E6B RID: 11883
		private static readonly IntPtr NativeFieldInfoPtr_myActiveNote;

		// Token: 0x04002E6C RID: 11884
		private static readonly IntPtr NativeFieldInfoPtr_HiHatIsOpen;

		// Token: 0x04002E6D RID: 11885
		private static readonly IntPtr NativeFieldInfoPtr_preppedAudioSources;

		// Token: 0x04002E6E RID: 11886
		private static readonly IntPtr NativeFieldInfoPtr_activeNote;

		// Token: 0x04002E6F RID: 11887
		private static readonly IntPtr NativeFieldInfoPtr_midiNoteIndex;

		// Token: 0x04002E70 RID: 11888
		private static readonly IntPtr NativeFieldInfoPtr_setPatchIterator;

		// Token: 0x04002E71 RID: 11889
		private static readonly IntPtr NativeFieldInfoPtr_sampleCountInt;

		// Token: 0x04002E72 RID: 11890
		private static readonly IntPtr NativeFieldInfoPtr_increment;

		// Token: 0x04002E73 RID: 11891
		private static readonly IntPtr NativeFieldInfoPtr_roundRobinIncrement;

		// Token: 0x04002E74 RID: 11892
		private static readonly IntPtr NativeFieldInfoPtr_incrementAmount;

		// Token: 0x04002E75 RID: 11893
		private static readonly IntPtr NativeFieldInfoPtr_velocityLevels;

		// Token: 0x04002E76 RID: 11894
		private static readonly IntPtr NativeFieldInfoPtr_latinString;

		// Token: 0x04002E77 RID: 11895
		private static readonly IntPtr NativeFieldInfoPtr_bongoString;

		// Token: 0x04002E78 RID: 11896
		private static readonly IntPtr NativeFieldInfoPtr_congaString;

		// Token: 0x04002E79 RID: 11897
		private static readonly IntPtr NativeFieldInfoPtr_metallicString;

		// Token: 0x04002E7A RID: 11898
		private static readonly IntPtr NativeFieldInfoPtr_popKeyZoneIndex;

		// Token: 0x04002E7B RID: 11899
		private static readonly IntPtr NativeFieldInfoPtr_popKeyZonesClipCounter;

		// Token: 0x04002E7C RID: 11900
		private static readonly IntPtr NativeFieldInfoPtr_popKeyZonesIterator;

		// Token: 0x04002E7D RID: 11901
		private static readonly IntPtr NativeMethodInfoPtr_get_useNoteOff_Public_get_Boolean_0;

		// Token: 0x04002E7E RID: 11902
		private static readonly IntPtr NativeMethodInfoPtr_set_useNoteOff_Public_set_Void_Boolean_0;

		// Token: 0x04002E7F RID: 11903
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002E80 RID: 11904
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002E81 RID: 11905
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04002E82 RID: 11906
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyzone_Public_Keyzone_0;

		// Token: 0x04002E83 RID: 11907
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyzoneGetIndex_Public_Int32_0;

		// Token: 0x04002E84 RID: 11908
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKeyzone_Public_Int32_Keyzone_0;

		// Token: 0x04002E85 RID: 11909
		private static readonly IntPtr NativeMethodInfoPtr_GetNextAudioSourceIndex_Private_Void_0;

		// Token: 0x04002E86 RID: 11910
		private static readonly IntPtr NativeMethodInfoPtr_PrepNote_Private_Void_AudioSource_Int32_Single_0;

		// Token: 0x04002E87 RID: 11911
		private static readonly IntPtr NativeMethodInfoPtr_PrepNote_Private_Void_AudioSource_Int32_Int32_Single_0;

		// Token: 0x04002E88 RID: 11912
		private static readonly IntPtr NativeMethodInfoPtr_GetValidKeyzones_Private_Void_Int32_Single_0;

		// Token: 0x04002E89 RID: 11913
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyzonesToPlay_Private_Int32_0;

		// Token: 0x04002E8A RID: 11914
		private static readonly IntPtr NativeMethodInfoPtr_GetPreppedAudioSources_Private_Void_Int32_Single_0;

		// Token: 0x04002E8B RID: 11915
		private static readonly IntPtr NativeMethodInfoPtr_GetMinKey_Public_Int32_0;

		// Token: 0x04002E8C RID: 11916
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxKey_Public_Int32_0;

		// Token: 0x04002E8D RID: 11917
		private static readonly IntPtr NativeMethodInfoPtr_AllNotesOff_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002E8E RID: 11918
		private static readonly IntPtr NativeMethodInfoPtr_TurnVoiceOffInSeconds_Private_IEnumerator_Int32_Single_0;

		// Token: 0x04002E8F RID: 11919
		private static readonly IntPtr NativeMethodInfoPtr_AddNoteToActiveNotes_Private_Void_ActiveNote_0;

		// Token: 0x04002E90 RID: 11920
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromActiveNotes_Private_Void_Int32_0;

		// Token: 0x04002E91 RID: 11921
		private static readonly IntPtr NativeMethodInfoPtr_NoteOn_Public_Virtual_Final_New_Void_Int32_Single_0;

		// Token: 0x04002E92 RID: 11922
		private static readonly IntPtr NativeMethodInfoPtr_NoteOn_Public_Void_Int32_Boolean_Single_0;

		// Token: 0x04002E93 RID: 11923
		private static readonly IntPtr NativeMethodInfoPtr_ManageHiHat_Private_IEnumerator_Int32_Boolean_Single_0;

		// Token: 0x04002E94 RID: 11924
		private static readonly IntPtr NativeMethodInfoPtr_NoteOnScheduled_Public_Void_Int32_Single_Double_Double_0;

		// Token: 0x04002E95 RID: 11925
		private static readonly IntPtr NativeMethodInfoPtr_FindActiveNoteIndex_Private_Int32_Int32_0;

		// Token: 0x04002E96 RID: 11926
		private static readonly IntPtr NativeMethodInfoPtr_NoteOff_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04002E97 RID: 11927
		private static readonly IntPtr NativeMethodInfoPtr_DoNoteOff_Private_Void_Int32_0;

		// Token: 0x04002E98 RID: 11928
		private static readonly IntPtr NativeMethodInfoPtr_SetPatch_Public_Void_SamplerPatch_0;

		// Token: 0x04002E99 RID: 11929
		private static readonly IntPtr NativeMethodInfoPtr_SetPanValuesFromMidiNote_Private_Void_byref_Keyzone_Int32_0;

		// Token: 0x04002E9A RID: 11930
		private static readonly IntPtr NativeMethodInfoPtr_PopulateKeyZones_Private_Void_SamplerPatch_List_1_AudioClip_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04002E9B RID: 11931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003EA RID: 1002
		[OriginalName("Assembly-CSharp.dll", "", "KeyzonePlayMode")]
		public enum KeyzonePlayMode
		{
			// Token: 0x04003C89 RID: 15497
			kAll,
			// Token: 0x04003C8A RID: 15498
			kRoundRobin,
			// Token: 0x04003C8B RID: 15499
			kRandom
		}

		// Token: 0x020003EB RID: 1003
		[StructLayout(2)]
		public struct ActiveNote
		{
			// Token: 0x06005B31 RID: 23345 RVA: 0x001490C0 File Offset: 0x001472C0
			// Note: this type is marked as 'beforefieldinit'.
			static ActiveNote()
			{
				Il2CppClassPointerStore<Sampler.ActiveNote>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "ActiveNote");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sampler.ActiveNote>.NativeClassPtr);
				Sampler.ActiveNote.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler.ActiveNote>.NativeClassPtr, "note");
				Sampler.ActiveNote.NativeFieldInfoPtr_sourceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler.ActiveNote>.NativeClassPtr, "sourceIndex");
				Sampler.ActiveNote.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler.ActiveNote>.NativeClassPtr, "startTime");
				Sampler.ActiveNote.NativeFieldInfoPtr_activeNoteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler.ActiveNote>.NativeClassPtr, "activeNoteIndex");
				Sampler.ActiveNote.NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler.ActiveNote>.NativeClassPtr, "isActive");
				Sampler.ActiveNote.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Double_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler.ActiveNote>.NativeClassPtr, 100670760);
			}

			// Token: 0x06005B32 RID: 23346 RVA: 0x00149164 File Offset: 0x00147364
			[CallerCount(0)]
			public unsafe ActiveNote(int n, int _sourceIndex, double start, int _activeNoteIndex, bool _isActive)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _sourceIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _activeNoteIndex;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _isActive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.ActiveNote.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Double_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B33 RID: 23347 RVA: 0x00034059 File Offset: 0x00032259
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Sampler.ActiveNote>.NativeClassPtr, ref this));
			}

			// Token: 0x04003C8C RID: 15500
			private static readonly IntPtr NativeFieldInfoPtr_note;

			// Token: 0x04003C8D RID: 15501
			private static readonly IntPtr NativeFieldInfoPtr_sourceIndex;

			// Token: 0x04003C8E RID: 15502
			private static readonly IntPtr NativeFieldInfoPtr_startTime;

			// Token: 0x04003C8F RID: 15503
			private static readonly IntPtr NativeFieldInfoPtr_activeNoteIndex;

			// Token: 0x04003C90 RID: 15504
			private static readonly IntPtr NativeFieldInfoPtr_isActive;

			// Token: 0x04003C91 RID: 15505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Double_Int32_Boolean_0;

			// Token: 0x04003C92 RID: 15506
			[FieldOffset(0)]
			public int note;

			// Token: 0x04003C93 RID: 15507
			[FieldOffset(4)]
			public int sourceIndex;

			// Token: 0x04003C94 RID: 15508
			[FieldOffset(8)]
			public double startTime;

			// Token: 0x04003C95 RID: 15509
			[FieldOffset(16)]
			public int activeNoteIndex;

			// Token: 0x04003C96 RID: 15510
			[FieldOffset(20)]
			[MarshalAs(4)]
			public bool isActive;
		}

		// Token: 0x020003EC RID: 1004
		[ObfuscatedName("AudioHelm.Sampler+<TurnVoiceOffInSeconds>d__50")]
		public sealed class _TurnVoiceOffInSeconds_d__50 : global::Il2CppSystem.Object
		{
			// Token: 0x06005B34 RID: 23348 RVA: 0x001491D0 File Offset: 0x001473D0
			// Note: this type is marked as 'beforefieldinit'.
			static _TurnVoiceOffInSeconds_d__50()
			{
				Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "<TurnVoiceOffInSeconds>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr);
				Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr, "<>1__state");
				Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr, "<>2__current");
				Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr, "seconds");
				Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr, "<>4__this");
				Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr, "note");
				Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr, 100670761);
				Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr, 100670762);
				Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr, 100670763);
				Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr, 100670764);
				Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr, 100670765);
				Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr, 100670766);
			}

			// Token: 0x06005B35 RID: 23349 RVA: 0x001492D8 File Offset: 0x001474D8
			[CallerCount(0)]
			public unsafe _TurnVoiceOffInSeconds_d__50(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sampler._TurnVoiceOffInSeconds_d__50>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B36 RID: 23350 RVA: 0x00149320 File Offset: 0x00147520
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B37 RID: 23351 RVA: 0x00149354 File Offset: 0x00147554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117093, XrefRangeEnd = 117096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700212C RID: 8492
			// (get) Token: 0x06005B38 RID: 23352 RVA: 0x00149390 File Offset: 0x00147590
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005B39 RID: 23353 RVA: 0x001493D0 File Offset: 0x001475D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117096, XrefRangeEnd = 117101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700212D RID: 8493
			// (get) Token: 0x06005B3A RID: 23354 RVA: 0x00149404 File Offset: 0x00147604
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._TurnVoiceOffInSeconds_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005B3B RID: 23355 RVA: 0x0003406B File Offset: 0x0003226B
			public _TurnVoiceOffInSeconds_d__50(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002127 RID: 8487
			// (get) Token: 0x06005B3C RID: 23356 RVA: 0x00149444 File Offset: 0x00147644
			// (set) Token: 0x06005B3D RID: 23357 RVA: 0x00034074 File Offset: 0x00032274
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002128 RID: 8488
			// (get) Token: 0x06005B3E RID: 23358 RVA: 0x0014946C File Offset: 0x0014766C
			// (set) Token: 0x06005B3F RID: 23359 RVA: 0x0003408F File Offset: 0x0003228F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002129 RID: 8489
			// (get) Token: 0x06005B40 RID: 23360 RVA: 0x0014949C File Offset: 0x0014769C
			// (set) Token: 0x06005B41 RID: 23361 RVA: 0x000340AE File Offset: 0x000322AE
			public unsafe float seconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr_seconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr_seconds)) = value;
				}
			}

			// Token: 0x1700212A RID: 8490
			// (get) Token: 0x06005B42 RID: 23362 RVA: 0x001494C4 File Offset: 0x001476C4
			// (set) Token: 0x06005B43 RID: 23363 RVA: 0x000340C9 File Offset: 0x000322C9
			public unsafe Sampler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sampler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700212B RID: 8491
			// (get) Token: 0x06005B44 RID: 23364 RVA: 0x001494F4 File Offset: 0x001476F4
			// (set) Token: 0x06005B45 RID: 23365 RVA: 0x000340E8 File Offset: 0x000322E8
			public unsafe int note
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr_note);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._TurnVoiceOffInSeconds_d__50.NativeFieldInfoPtr_note)) = value;
				}
			}

			// Token: 0x04003C97 RID: 15511
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C98 RID: 15512
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C99 RID: 15513
			private static readonly IntPtr NativeFieldInfoPtr_seconds;

			// Token: 0x04003C9A RID: 15514
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003C9B RID: 15515
			private static readonly IntPtr NativeFieldInfoPtr_note;

			// Token: 0x04003C9C RID: 15516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C9D RID: 15517
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C9E RID: 15518
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C9F RID: 15519
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CA0 RID: 15520
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CA1 RID: 15521
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003ED RID: 1005
		[ObfuscatedName("AudioHelm.Sampler+<ManageHiHat>d__57")]
		public sealed class _ManageHiHat_d__57 : global::Il2CppSystem.Object
		{
			// Token: 0x06005B46 RID: 23366 RVA: 0x0014951C File Offset: 0x0014771C
			// Note: this type is marked as 'beforefieldinit'.
			static _ManageHiHat_d__57()
			{
				Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "<ManageHiHat>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr);
				Sampler._ManageHiHat_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, "<>1__state");
				Sampler._ManageHiHat_d__57.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, "<>2__current");
				Sampler._ManageHiHat_d__57.NativeFieldInfoPtr_scheduled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, "scheduled");
				Sampler._ManageHiHat_d__57.NativeFieldInfoPtr_timeUntilPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, "timeUntilPlay");
				Sampler._ManageHiHat_d__57.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, "note");
				Sampler._ManageHiHat_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, "<>4__this");
				Sampler._ManageHiHat_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, 100670767);
				Sampler._ManageHiHat_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, 100670768);
				Sampler._ManageHiHat_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, 100670769);
				Sampler._ManageHiHat_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, 100670770);
				Sampler._ManageHiHat_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, 100670771);
				Sampler._ManageHiHat_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr, 100670772);
			}

			// Token: 0x06005B47 RID: 23367 RVA: 0x00149638 File Offset: 0x00147838
			[CallerCount(0)]
			public unsafe _ManageHiHat_d__57(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sampler._ManageHiHat_d__57>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._ManageHiHat_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B48 RID: 23368 RVA: 0x00149680 File Offset: 0x00147880
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._ManageHiHat_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B49 RID: 23369 RVA: 0x001496B4 File Offset: 0x001478B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117101, XrefRangeEnd = 117104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._ManageHiHat_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002134 RID: 8500
			// (get) Token: 0x06005B4A RID: 23370 RVA: 0x001496F0 File Offset: 0x001478F0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._ManageHiHat_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005B4B RID: 23371 RVA: 0x00149730 File Offset: 0x00147930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117104, XrefRangeEnd = 117109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._ManageHiHat_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002135 RID: 8501
			// (get) Token: 0x06005B4C RID: 23372 RVA: 0x00149764 File Offset: 0x00147964
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler._ManageHiHat_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005B4D RID: 23373 RVA: 0x00034103 File Offset: 0x00032303
			public _ManageHiHat_d__57(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700212E RID: 8494
			// (get) Token: 0x06005B4E RID: 23374 RVA: 0x001497A4 File Offset: 0x001479A4
			// (set) Token: 0x06005B4F RID: 23375 RVA: 0x0003410C File Offset: 0x0003230C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700212F RID: 8495
			// (get) Token: 0x06005B50 RID: 23376 RVA: 0x001497CC File Offset: 0x001479CC
			// (set) Token: 0x06005B51 RID: 23377 RVA: 0x00034127 File Offset: 0x00032327
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002130 RID: 8496
			// (get) Token: 0x06005B52 RID: 23378 RVA: 0x001497FC File Offset: 0x001479FC
			// (set) Token: 0x06005B53 RID: 23379 RVA: 0x00034146 File Offset: 0x00032346
			public unsafe bool scheduled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr_scheduled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr_scheduled)) = value;
				}
			}

			// Token: 0x17002131 RID: 8497
			// (get) Token: 0x06005B54 RID: 23380 RVA: 0x00149824 File Offset: 0x00147A24
			// (set) Token: 0x06005B55 RID: 23381 RVA: 0x00034161 File Offset: 0x00032361
			public unsafe float timeUntilPlay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr_timeUntilPlay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr_timeUntilPlay)) = value;
				}
			}

			// Token: 0x17002132 RID: 8498
			// (get) Token: 0x06005B56 RID: 23382 RVA: 0x0014984C File Offset: 0x00147A4C
			// (set) Token: 0x06005B57 RID: 23383 RVA: 0x0003417C File Offset: 0x0003237C
			public unsafe int note
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr_note);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr_note)) = value;
				}
			}

			// Token: 0x17002133 RID: 8499
			// (get) Token: 0x06005B58 RID: 23384 RVA: 0x00149874 File Offset: 0x00147A74
			// (set) Token: 0x06005B59 RID: 23385 RVA: 0x00034197 File Offset: 0x00032397
			public unsafe Sampler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sampler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler._ManageHiHat_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CA2 RID: 15522
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003CA3 RID: 15523
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003CA4 RID: 15524
			private static readonly IntPtr NativeFieldInfoPtr_scheduled;

			// Token: 0x04003CA5 RID: 15525
			private static readonly IntPtr NativeFieldInfoPtr_timeUntilPlay;

			// Token: 0x04003CA6 RID: 15526
			private static readonly IntPtr NativeFieldInfoPtr_note;

			// Token: 0x04003CA7 RID: 15527
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003CA8 RID: 15528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003CA9 RID: 15529
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CAA RID: 15530
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003CAB RID: 15531
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CAC RID: 15532
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CAD RID: 15533
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
