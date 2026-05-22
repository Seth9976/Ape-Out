using System;
using System.Runtime.InteropServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppAudioHelm
{
	// Token: 0x02000289 RID: 649
	public class Sequencer : MonoBehaviour
	{
		// Token: 0x060048B4 RID: 18612 RVA: 0x0010F220 File Offset: 0x0010D420
		// Note: this type is marked as 'beforefieldinit'.
		static Sequencer()
		{
			Il2CppClassPointerStore<Sequencer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "Sequencer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequencer>.NativeClassPtr);
			Sequencer.NativeFieldInfoPtr_OnNoteOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "OnNoteOn");
			Sequencer.NativeFieldInfoPtr_OnNoteOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "OnNoteOff");
			Sequencer.NativeFieldInfoPtr_OnBeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "OnBeat");
			Sequencer.NativeFieldInfoPtr_noteOnEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "noteOnEvent");
			Sequencer.NativeFieldInfoPtr_noteOffEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "noteOffEvent");
			Sequencer.NativeFieldInfoPtr_beatEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "beatEvent");
			Sequencer.NativeFieldInfoPtr_activeNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "activeNotes");
			Sequencer.NativeFieldInfoPtr_SequenceToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "SequenceToLoad");
			Sequencer.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "length");
			Sequencer.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "currentIndex");
			Sequencer.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "loop");
			Sequencer.NativeFieldInfoPtr_beatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "beatTime");
			Sequencer.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "paused");
			Sequencer.NativeFieldInfoPtr_allNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "allNotes");
			Sequencer.NativeFieldInfoPtr_scrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "scrollPosition");
			Sequencer.NativeFieldInfoPtr_autoScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "autoScroll");
			Sequencer.NativeFieldInfoPtr_division = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "division");
			Sequencer.NativeFieldInfoPtr_zoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "zoom");
			Sequencer.NativeFieldInfoPtr_VelocityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "VelocityMultiplier");
			Sequencer.NativeFieldInfoPtr_allNoteOns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "allNoteOns");
			Sequencer.NativeFieldInfoPtr_allNoteOffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "allNoteOffs");
			Sequencer.NativeFieldInfoPtr_lastSequencerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "lastSequencerPosition");
			Sequencer.NativeFieldInfoPtr_clock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "clock");
			Sequencer.NativeFieldInfoPtr_offPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "offPosition");
			Sequencer.NativeFieldInfoPtr_allNoteOffsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "allNoteOffsIndex");
			Sequencer.NativeFieldInfoPtr_allNoteOnsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "allNoteOnsIndex");
			Sequencer.NativeFieldInfoPtr_seq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "seq");
			Sequencer.NativeFieldInfoPtr_cleared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "cleared");
			Sequencer.NativeFieldInfoPtr_nl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "nl");
			Sequencer.NativeFieldInfoPtr_seqCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "seqCount");
			Sequencer.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "offset");
			Sequencer.NativeFieldInfoPtr_halfOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "halfOffset");
			Sequencer.NativeFieldInfoPtr_wrapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "wrapping");
			Sequencer.NativeFieldInfoPtr_wrapAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "wrapAmount");
			Sequencer.NativeFieldInfoPtr_preWrapAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "preWrapAmount");
			Sequencer.NativeFieldInfoPtr_skippedStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "skippedStart");
			Sequencer.NativeFieldInfoPtr_skippedEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "skippedEnd");
			Sequencer.NativeFieldInfoPtr_beatsPrinted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "beatsPrinted");
			Sequencer.NativeFieldInfoPtr_getAllNotesNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "getAllNotesNotes");
			Sequencer.NativeFieldInfoPtr_noteInRangeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "noteInRangeIndex");
			Sequencer.NativeFieldInfoPtr_noteObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "noteObject");
			Sequencer.NativeFieldInfoPtr_allNotesCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "allNotesCounts");
			Sequencer.NativeFieldInfoPtr_notesInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "notesInRange");
			Sequencer.NativeFieldInfoPtr_startSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "startSearch");
			Sequencer.NativeFieldInfoPtr_endSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "endSearch");
			Sequencer.NativeFieldInfoPtr_indexStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "indexStart");
			Sequencer.NativeFieldInfoPtr_indexEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "indexEnd");
			Sequencer.NativeFieldInfoPtr_notesIList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "notesIList");
			Sequencer.NativeFieldInfoPtr_numNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "numNotes");
			Sequencer.NativeFieldInfoPtr_nextIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "nextIndex");
			Sequencer.NativeFieldInfoPtr_globalBeatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "globalBeatTime");
			Sequencer.NativeFieldInfoPtr_bpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "bpm");
			Sequencer.NativeFieldInfoPtr_lastUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "lastUpdate");
			Sequencer.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "time");
			Sequencer.NativeFieldInfoPtr_nextActiveNoteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "nextActiveNoteIndex");
			Sequencer.NativeFieldInfoPtr_numActiveNoteSearchLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "numActiveNoteSearchLoops");
			Sequencer.NativeFieldInfoPtr_noteOns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "noteOns");
			Sequencer.NativeFieldInfoPtr_noteOffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "noteOffs");
			Sequencer.NativeFieldInfoPtr_noteOnIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "noteOnIndex");
			Sequencer.NativeFieldInfoPtr_noteOffIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "noteOffIndex");
			Sequencer.NativeMethodInfoPtr_add_OnNoteOn_Public_add_Void_NoteAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670773);
			Sequencer.NativeMethodInfoPtr_remove_OnNoteOn_Public_rem_Void_NoteAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670774);
			Sequencer.NativeMethodInfoPtr_add_OnNoteOff_Public_add_Void_NoteAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670775);
			Sequencer.NativeMethodInfoPtr_remove_OnNoteOff_Public_rem_Void_NoteAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670776);
			Sequencer.NativeMethodInfoPtr_add_OnBeat_Public_add_Void_BeatAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670777);
			Sequencer.NativeMethodInfoPtr_remove_OnBeat_Public_rem_Void_BeatAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670778);
			Sequencer.NativeMethodInfoPtr_AllNotesOff_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670779);
			Sequencer.NativeMethodInfoPtr_NoteOn_Public_Abstract_Virtual_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670780);
			Sequencer.NativeMethodInfoPtr_NoteOff_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670781);
			Sequencer.NativeMethodInfoPtr_StartScheduled_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670782);
			Sequencer.NativeMethodInfoPtr_StartOnNextCycle_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670783);
			Sequencer.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670784);
			Sequencer.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670785);
			Sequencer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670786);
			Sequencer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670787);
			Sequencer.NativeMethodInfoPtr_RemoveSortedNoteEvents_Protected_Void_byref_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670788);
			Sequencer.NativeMethodInfoPtr_AddSortedNoteEvents_Protected_Void_byref_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670789);
			Sequencer.NativeMethodInfoPtr_LoadSequence_Public_Void_NoteSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670790);
			Sequencer.NativeMethodInfoPtr_LoadSequenceStreaming_Public_Void_NoteSequence_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670791);
			Sequencer.NativeMethodInfoPtr_InitNoteRows_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670792);
			Sequencer.NativeMethodInfoPtr_GetDivisionLength_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670793);
			Sequencer.NativeMethodInfoPtr_RemoveNote_Public_Void_byref_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670794);
			Sequencer.NativeMethodInfoPtr_NoteExistsInRange_Public_Boolean_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670795);
			Sequencer.NativeMethodInfoPtr_GetNoteInRange_Public_Int32_Int32_Single_Single_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670796);
			Sequencer.NativeMethodInfoPtr_GetAllNotes_Public_Il2CppStructArray_1_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670797);
			Sequencer.NativeMethodInfoPtr_GetAllNoteOnsInRange_Public_Il2CppStructArray_1_Note_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670798);
			Sequencer.NativeMethodInfoPtr_GetAllNoteOffsInRange_Public_Il2CppStructArray_1_Note_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670799);
			Sequencer.NativeMethodInfoPtr_RemoveNotesInRange_Public_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670800);
			Sequencer.NativeMethodInfoPtr_RemoveNotesContainedInRange_Public_Void_Int32_Single_Single_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670801);
			Sequencer.NativeMethodInfoPtr_ClampNotesInRange_Public_Void_Int32_Single_Single_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670802);
			Sequencer.NativeMethodInfoPtr_AddNote_Public_Void_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670803);
			Sequencer.NativeMethodInfoPtr_ReadMidiData_Private_Void_MidiData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670804);
			Sequencer.NativeMethodInfoPtr_ReadMidiFile_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670805);
			Sequencer.NativeMethodInfoPtr_ReadMidiFile_Public_Void_MidiFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670806);
			Sequencer.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670807);
			Sequencer.NativeMethodInfoPtr_GetSixteenthTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670808);
			Sequencer.NativeMethodInfoPtr_GetSequencerTime_Protected_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670809);
			Sequencer.NativeMethodInfoPtr_GetSequencerPosition_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670810);
			Sequencer.NativeMethodInfoPtr_GetAllNoteEventsInRange_Private_Il2CppStructArray_1_Note_Single_Single_Il2CppStructArray_1_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670811);
			Sequencer.NativeMethodInfoPtr_UpdateIndex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670812);
			Sequencer.NativeMethodInfoPtr_UpdateBeatTime_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670813);
			Sequencer.NativeMethodInfoPtr_SendNoteOff_Private_Void_Note_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670814);
			Sequencer.NativeMethodInfoPtr_SendNoteOn_Private_Void_Note_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670815);
			Sequencer.NativeMethodInfoPtr_UpdatePosition_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670816);
			Sequencer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, 100670817);
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x0010FA84 File Offset: 0x0010DC84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117517, RefRangeEnd = 117521, XrefRangeStart = 117514, XrefRangeEnd = 117517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnNoteOn(Sequencer.NoteAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_add_OnNoteOn_Public_add_Void_NoteAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x0010FAC8 File Offset: 0x0010DCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117521, XrefRangeEnd = 117524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnNoteOn(Sequencer.NoteAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_remove_OnNoteOn_Public_rem_Void_NoteAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x0010FB0C File Offset: 0x0010DD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117524, XrefRangeEnd = 117527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnNoteOff(Sequencer.NoteAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_add_OnNoteOff_Public_add_Void_NoteAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x0010FB50 File Offset: 0x0010DD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117527, XrefRangeEnd = 117530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnNoteOff(Sequencer.NoteAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_remove_OnNoteOff_Public_rem_Void_NoteAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x0010FB94 File Offset: 0x0010DD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117530, XrefRangeEnd = 117533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnBeat(Sequencer.BeatAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_add_OnBeat_Public_add_Void_BeatAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x0010FBD8 File Offset: 0x0010DDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117533, XrefRangeEnd = 117536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnBeat(Sequencer.BeatAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_remove_OnBeat_Public_rem_Void_BeatAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x0010FC1C File Offset: 0x0010DE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AllNotesOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sequencer.NativeMethodInfoPtr_AllNotesOff_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x0010FC58 File Offset: 0x0010DE58
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sequencer.NativeMethodInfoPtr_NoteOn_Public_Abstract_Virtual_New_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x0010FCB0 File Offset: 0x0010DEB0
		[CallerCount(0)]
		public unsafe virtual void NoteOff(int note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sequencer.NativeMethodInfoPtr_NoteOff_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x0010FCFC File Offset: 0x0010DEFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartScheduled(double dspTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dspTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_StartScheduled_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x0010FD3C File Offset: 0x0010DF3C
		[CallerCount(0)]
		public unsafe virtual void StartOnNextCycle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sequencer.NativeMethodInfoPtr_StartOnNextCycle_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x0010FD78 File Offset: 0x0010DF78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x0010FDAC File Offset: 0x0010DFAC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x0010FDE0 File Offset: 0x0010DFE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117558, RefRangeEnd = 117559, XrefRangeStart = 117536, XrefRangeEnd = 117558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sequencer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x0010FE1C File Offset: 0x0010E01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117573, RefRangeEnd = 117574, XrefRangeStart = 117559, XrefRangeEnd = 117573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sequencer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x0010FE58 File Offset: 0x0010E058
		[CallerCount(0)]
		public unsafe void RemoveSortedNoteEvents(ref Note note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_RemoveSortedNoteEvents_Protected_Void_byref_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x0010FE98 File Offset: 0x0010E098
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117574, RefRangeEnd = 117577, XrefRangeStart = 117574, XrefRangeEnd = 117574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSortedNoteEvents(ref Note note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_AddSortedNoteEvents_Protected_Void_byref_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x0010FED8 File Offset: 0x0010E0D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 117580, RefRangeEnd = 117586, XrefRangeStart = 117577, XrefRangeEnd = 117580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSequence(NoteSequence thisSeq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisSeq);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_LoadSequence_Public_Void_NoteSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x0010FF1C File Offset: 0x0010E11C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117591, RefRangeEnd = 117593, XrefRangeStart = 117586, XrefRangeEnd = 117591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSequenceStreaming(NoteSequence seq, int beatsToGrab, int beatOffset, int startOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seq);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beatsToGrab;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beatOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_LoadSequenceStreaming_Public_Void_NoteSequence_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x0010FF88 File Offset: 0x0010E188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117593, XrefRangeEnd = 117597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNoteRows()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_InitNoteRows_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x0010FFBC File Offset: 0x0010E1BC
		[CallerCount(0)]
		public unsafe float GetDivisionLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_GetDivisionLength_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x0010FFF8 File Offset: 0x0010E1F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117597, RefRangeEnd = 117600, XrefRangeStart = 117597, XrefRangeEnd = 117597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNote(ref Note note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_RemoveNote_Public_Void_byref_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x00110038 File Offset: 0x0010E238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117600, XrefRangeEnd = 117601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NoteExistsInRange(int note, float start, float end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_NoteExistsInRange_Public_Boolean_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x001100A0 File Offset: 0x0010E2A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117604, RefRangeEnd = 117607, XrefRangeStart = 117601, XrefRangeEnd = 117604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNoteInRange(int note, float start, float end, Note ignore = default(Note))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_GetNoteInRange_Public_Int32_Int32_Single_Single_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x00110114 File Offset: 0x0010E314
		[CallerCount(0)]
		public unsafe Il2CppStructArray<Note> GetAllNotes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_GetAllNotes_Public_Il2CppStructArray_1_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr3) : null;
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x00110154 File Offset: 0x0010E354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117607, XrefRangeEnd = 117608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Note> GetAllNoteOnsInRange(float start, float end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_GetAllNoteOnsInRange_Public_Il2CppStructArray_1_Note_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr3) : null;
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x001101B0 File Offset: 0x0010E3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117608, XrefRangeEnd = 117609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Note> GetAllNoteOffsInRange(float start, float end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_GetAllNoteOffsInRange_Public_Il2CppStructArray_1_Note_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr3) : null;
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x0011020C File Offset: 0x0010E40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117609, XrefRangeEnd = 117612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNotesInRange(int note, float start, float end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_RemoveNotesInRange_Public_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00110268 File Offset: 0x0010E468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117612, XrefRangeEnd = 117614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNotesContainedInRange(int note, float start, float end, Note ignore = default(Note))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_RemoveNotesContainedInRange_Public_Void_Int32_Single_Single_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x001102D0 File Offset: 0x0010E4D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117621, RefRangeEnd = 117622, XrefRangeStart = 117614, XrefRangeEnd = 117621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampNotesInRange(int note, float start, float end, Note ignore = default(Note))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_ClampNotesInRange_Public_Void_Int32_Single_Single_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x00110338 File Offset: 0x0010E538
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117630, RefRangeEnd = 117633, XrefRangeStart = 117622, XrefRangeEnd = 117630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNote(int note, float start, float end, float velocity = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_AddNote_Public_Void_Int32_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x001103A0 File Offset: 0x0010E5A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117643, RefRangeEnd = 117645, XrefRangeStart = 117633, XrefRangeEnd = 117643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMidiData(MidiFile.MidiData midiData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(midiData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_ReadMidiData_Private_Void_MidiData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x001103E4 File Offset: 0x0010E5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117645, XrefRangeEnd = 117650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMidiFile(Stream midiStream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(midiStream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_ReadMidiFile_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x00110428 File Offset: 0x0010E628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117650, XrefRangeEnd = 117663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMidiFile(MidiFile midiFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(midiFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_ReadMidiFile_Public_Void_MidiFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x0011046C File Offset: 0x0010E66C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 117670, RefRangeEnd = 117682, XrefRangeStart = 117663, XrefRangeEnd = 117670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x001104A0 File Offset: 0x0010E6A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117686, RefRangeEnd = 117689, XrefRangeStart = 117682, XrefRangeEnd = 117686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSixteenthTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_GetSixteenthTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x001104DC File Offset: 0x0010E6DC
		[CallerCount(0)]
		public unsafe double GetSequencerTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_GetSequencerTime_Protected_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x00110518 File Offset: 0x0010E718
		[CallerCount(0)]
		public unsafe double GetSequencerPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_GetSequencerPosition_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x00110554 File Offset: 0x0010E754
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 117692, RefRangeEnd = 117697, XrefRangeStart = 117689, XrefRangeEnd = 117692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Note> GetAllNoteEventsInRange(float start, float end, Il2CppStructArray<Note> events)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_GetAllNoteEventsInRange_Private_Il2CppStructArray_1_Note_Single_Single_Il2CppStructArray_1_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr3) : null;
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x001105C0 File Offset: 0x0010E7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117697, XrefRangeEnd = 117704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_UpdateIndex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x001105F4 File Offset: 0x0010E7F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117712, RefRangeEnd = 117714, XrefRangeStart = 117704, XrefRangeEnd = 117712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBeatTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_UpdateBeatTime_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x00110628 File Offset: 0x0010E828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117718, RefRangeEnd = 117719, XrefRangeStart = 117714, XrefRangeEnd = 117718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNoteOff(Note note, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_SendNoteOff_Private_Void_Note_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x00110674 File Offset: 0x0010E874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117729, RefRangeEnd = 117730, XrefRangeStart = 117719, XrefRangeEnd = 117729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNoteOn(Note note, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_SendNoteOn_Private_Void_Note_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x001106C0 File Offset: 0x0010E8C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117750, RefRangeEnd = 117752, XrefRangeStart = 117730, XrefRangeEnd = 117750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr_UpdatePosition_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x001106F4 File Offset: 0x0010E8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117782, RefRangeEnd = 117783, XrefRangeStart = 117752, XrefRangeEnd = 117782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sequencer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sequencer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x0002ACC9 File Offset: 0x00028EC9
		public Sequencer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x00110730 File Offset: 0x0010E930
		// (set) Token: 0x060048E4 RID: 18660 RVA: 0x0002ACD2 File Offset: 0x00028ED2
		public unsafe Sequencer.NoteAction OnNoteOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_OnNoteOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequencer.NoteAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_OnNoteOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x00110760 File Offset: 0x0010E960
		// (set) Token: 0x060048E6 RID: 18662 RVA: 0x0002ACF1 File Offset: 0x00028EF1
		public unsafe Sequencer.NoteAction OnNoteOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_OnNoteOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequencer.NoteAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_OnNoteOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x060048E7 RID: 18663 RVA: 0x00110790 File Offset: 0x0010E990
		// (set) Token: 0x060048E8 RID: 18664 RVA: 0x0002AD10 File Offset: 0x00028F10
		public unsafe Sequencer.BeatAction OnBeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_OnBeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequencer.BeatAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_OnBeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x060048E9 RID: 18665 RVA: 0x001107C0 File Offset: 0x0010E9C0
		// (set) Token: 0x060048EA RID: 18666 RVA: 0x0002AD2F File Offset: 0x00028F2F
		public unsafe Sequencer.NoteEvent noteOnEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOnEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequencer.NoteEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOnEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x060048EB RID: 18667 RVA: 0x001107F0 File Offset: 0x0010E9F0
		// (set) Token: 0x060048EC RID: 18668 RVA: 0x0002AD4E File Offset: 0x00028F4E
		public unsafe Sequencer.NoteEvent noteOffEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOffEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequencer.NoteEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOffEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x060048ED RID: 18669 RVA: 0x00110820 File Offset: 0x0010EA20
		// (set) Token: 0x060048EE RID: 18670 RVA: 0x0002AD6D File Offset: 0x00028F6D
		public unsafe Sequencer.BeatEvent beatEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_beatEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequencer.BeatEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_beatEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x060048EF RID: 18671 RVA: 0x00110850 File Offset: 0x0010EA50
		// (set) Token: 0x060048F0 RID: 18672 RVA: 0x0002AD8C File Offset: 0x00028F8C
		public unsafe Il2CppStructArray<Note> activeNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_activeNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_activeNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x060048F1 RID: 18673 RVA: 0x00110880 File Offset: 0x0010EA80
		// (set) Token: 0x060048F2 RID: 18674 RVA: 0x0002ADAB File Offset: 0x00028FAB
		public unsafe NoteSequence SequenceToLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_SequenceToLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteSequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_SequenceToLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x060048F3 RID: 18675 RVA: 0x001108B0 File Offset: 0x0010EAB0
		// (set) Token: 0x060048F4 RID: 18676 RVA: 0x0002ADCA File Offset: 0x00028FCA
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x060048F5 RID: 18677 RVA: 0x001108D8 File Offset: 0x0010EAD8
		// (set) Token: 0x060048F6 RID: 18678 RVA: 0x0002ADE5 File Offset: 0x00028FE5
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x060048F7 RID: 18679 RVA: 0x00110900 File Offset: 0x0010EB00
		// (set) Token: 0x060048F8 RID: 18680 RVA: 0x0002AE00 File Offset: 0x00029000
		public unsafe bool loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_loop)) = value;
			}
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x060048F9 RID: 18681 RVA: 0x00110928 File Offset: 0x0010EB28
		// (set) Token: 0x060048FA RID: 18682 RVA: 0x0002AE1B File Offset: 0x0002901B
		public unsafe double beatTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_beatTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_beatTime)) = value;
			}
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x060048FB RID: 18683 RVA: 0x00110950 File Offset: 0x0010EB50
		// (set) Token: 0x060048FC RID: 18684 RVA: 0x0002AE36 File Offset: 0x00029036
		public unsafe bool paused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_paused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_paused)) = value;
			}
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x060048FD RID: 18685 RVA: 0x00110978 File Offset: 0x0010EB78
		// (set) Token: 0x060048FE RID: 18686 RVA: 0x0002AE51 File Offset: 0x00029051
		public unsafe Il2CppReferenceArray<NoteRow> allNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NoteRow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x060048FF RID: 18687 RVA: 0x001109A8 File Offset: 0x0010EBA8
		// (set) Token: 0x06004900 RID: 18688 RVA: 0x0002AE70 File Offset: 0x00029070
		public unsafe Vector2 scrollPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_scrollPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_scrollPosition)) = value;
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06004901 RID: 18689 RVA: 0x001109D0 File Offset: 0x0010EBD0
		// (set) Token: 0x06004902 RID: 18690 RVA: 0x0002AE8B File Offset: 0x0002908B
		public unsafe bool autoScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_autoScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_autoScroll)) = value;
			}
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06004903 RID: 18691 RVA: 0x001109F8 File Offset: 0x0010EBF8
		// (set) Token: 0x06004904 RID: 18692 RVA: 0x0002AEA6 File Offset: 0x000290A6
		public unsafe Sequencer.Division division
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_division);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_division)) = value;
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06004905 RID: 18693 RVA: 0x00110A20 File Offset: 0x0010EC20
		// (set) Token: 0x06004906 RID: 18694 RVA: 0x0002AEC1 File Offset: 0x000290C1
		public unsafe float zoom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_zoom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_zoom)) = value;
			}
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x06004907 RID: 18695 RVA: 0x00110A48 File Offset: 0x0010EC48
		// (set) Token: 0x06004908 RID: 18696 RVA: 0x0002AEDC File Offset: 0x000290DC
		public unsafe float VelocityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_VelocityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_VelocityMultiplier)) = value;
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x06004909 RID: 18697 RVA: 0x00110A70 File Offset: 0x0010EC70
		// (set) Token: 0x0600490A RID: 18698 RVA: 0x0002AEF7 File Offset: 0x000290F7
		public unsafe Il2CppStructArray<Note> allNoteOns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNoteOns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNoteOns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x0600490B RID: 18699 RVA: 0x00110AA0 File Offset: 0x0010ECA0
		// (set) Token: 0x0600490C RID: 18700 RVA: 0x0002AF16 File Offset: 0x00029116
		public unsafe Il2CppStructArray<Note> allNoteOffs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNoteOffs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNoteOffs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x0600490D RID: 18701 RVA: 0x00110AD0 File Offset: 0x0010ECD0
		// (set) Token: 0x0600490E RID: 18702 RVA: 0x0002AF35 File Offset: 0x00029135
		public unsafe float lastSequencerPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_lastSequencerPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_lastSequencerPosition)) = value;
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x0600490F RID: 18703 RVA: 0x00110AF8 File Offset: 0x0010ECF8
		// (set) Token: 0x06004910 RID: 18704 RVA: 0x0002AF50 File Offset: 0x00029150
		public unsafe AudioHelmClock clock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_clock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioHelmClock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_clock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06004911 RID: 18705 RVA: 0x00110B28 File Offset: 0x0010ED28
		// (set) Token: 0x06004912 RID: 18706 RVA: 0x0002AF6F File Offset: 0x0002916F
		public unsafe Sequencer.NotePosition offPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_offPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_offPosition)) = value;
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06004913 RID: 18707 RVA: 0x00110B50 File Offset: 0x0010ED50
		// (set) Token: 0x06004914 RID: 18708 RVA: 0x0002AF8A File Offset: 0x0002918A
		public unsafe int allNoteOffsIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNoteOffsIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNoteOffsIndex)) = value;
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06004915 RID: 18709 RVA: 0x00110B78 File Offset: 0x0010ED78
		// (set) Token: 0x06004916 RID: 18710 RVA: 0x0002AFA5 File Offset: 0x000291A5
		public unsafe int allNoteOnsIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNoteOnsIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNoteOnsIndex)) = value;
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06004917 RID: 18711 RVA: 0x00110BA0 File Offset: 0x0010EDA0
		// (set) Token: 0x06004918 RID: 18712 RVA: 0x0002AFC0 File Offset: 0x000291C0
		public unsafe NoteSequence seq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_seq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteSequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_seq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x06004919 RID: 18713 RVA: 0x00110BD0 File Offset: 0x0010EDD0
		// (set) Token: 0x0600491A RID: 18714 RVA: 0x0002AFDF File Offset: 0x000291DF
		public unsafe bool cleared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_cleared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_cleared)) = value;
			}
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x0600491B RID: 18715 RVA: 0x00110BF8 File Offset: 0x0010EDF8
		// (set) Token: 0x0600491C RID: 18716 RVA: 0x0002AFFA File Offset: 0x000291FA
		public unsafe Il2CppStructArray<Note> nl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_nl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_nl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x0600491D RID: 18717 RVA: 0x00110C28 File Offset: 0x0010EE28
		// (set) Token: 0x0600491E RID: 18718 RVA: 0x0002B019 File Offset: 0x00029219
		public unsafe int seqCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_seqCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_seqCount)) = value;
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x0600491F RID: 18719 RVA: 0x00110C50 File Offset: 0x0010EE50
		// (set) Token: 0x06004920 RID: 18720 RVA: 0x0002B034 File Offset: 0x00029234
		public unsafe int offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x06004921 RID: 18721 RVA: 0x00110C78 File Offset: 0x0010EE78
		// (set) Token: 0x06004922 RID: 18722 RVA: 0x0002B04F File Offset: 0x0002924F
		public unsafe int halfOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_halfOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_halfOffset)) = value;
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x06004923 RID: 18723 RVA: 0x00110CA0 File Offset: 0x0010EEA0
		// (set) Token: 0x06004924 RID: 18724 RVA: 0x0002B06A File Offset: 0x0002926A
		public unsafe bool wrapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_wrapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_wrapping)) = value;
			}
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x06004925 RID: 18725 RVA: 0x00110CC8 File Offset: 0x0010EEC8
		// (set) Token: 0x06004926 RID: 18726 RVA: 0x0002B085 File Offset: 0x00029285
		public unsafe int wrapAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_wrapAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_wrapAmount)) = value;
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06004927 RID: 18727 RVA: 0x00110CF0 File Offset: 0x0010EEF0
		// (set) Token: 0x06004928 RID: 18728 RVA: 0x0002B0A0 File Offset: 0x000292A0
		public unsafe int preWrapAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_preWrapAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_preWrapAmount)) = value;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06004929 RID: 18729 RVA: 0x00110D18 File Offset: 0x0010EF18
		// (set) Token: 0x0600492A RID: 18730 RVA: 0x0002B0BB File Offset: 0x000292BB
		public unsafe int skippedStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_skippedStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_skippedStart)) = value;
			}
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x0600492B RID: 18731 RVA: 0x00110D40 File Offset: 0x0010EF40
		// (set) Token: 0x0600492C RID: 18732 RVA: 0x0002B0D6 File Offset: 0x000292D6
		public unsafe int skippedEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_skippedEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_skippedEnd)) = value;
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x0600492D RID: 18733 RVA: 0x00110D68 File Offset: 0x0010EF68
		// (set) Token: 0x0600492E RID: 18734 RVA: 0x0002B0F1 File Offset: 0x000292F1
		public unsafe int beatsPrinted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_beatsPrinted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_beatsPrinted)) = value;
			}
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x0600492F RID: 18735 RVA: 0x00110D90 File Offset: 0x0010EF90
		// (set) Token: 0x06004930 RID: 18736 RVA: 0x0002B10C File Offset: 0x0002930C
		public unsafe Il2CppStructArray<Note> getAllNotesNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_getAllNotesNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_getAllNotesNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x06004931 RID: 18737 RVA: 0x00110DC0 File Offset: 0x0010EFC0
		// (set) Token: 0x06004932 RID: 18738 RVA: 0x0002B12B File Offset: 0x0002932B
		public unsafe int noteInRangeIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteInRangeIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteInRangeIndex)) = value;
			}
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x00110DE8 File Offset: 0x0010EFE8
		// (set) Token: 0x06004934 RID: 18740 RVA: 0x0002B146 File Offset: 0x00029346
		public unsafe Note noteObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteObject)) = value;
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x06004935 RID: 18741 RVA: 0x00110E10 File Offset: 0x0010F010
		// (set) Token: 0x06004936 RID: 18742 RVA: 0x0002B161 File Offset: 0x00029361
		public unsafe Il2CppStructArray<int> allNotesCounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNotesCounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_allNotesCounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x06004937 RID: 18743 RVA: 0x00110E40 File Offset: 0x0010F040
		// (set) Token: 0x06004938 RID: 18744 RVA: 0x0002B180 File Offset: 0x00029380
		public unsafe Il2CppStructArray<Note> notesInRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_notesInRange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_notesInRange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x06004939 RID: 18745 RVA: 0x00110E70 File Offset: 0x0010F070
		// (set) Token: 0x0600493A RID: 18746 RVA: 0x0002B19F File Offset: 0x0002939F
		public unsafe Sequencer.NotePosition startSearch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_startSearch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_startSearch)) = value;
			}
		}

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x0600493B RID: 18747 RVA: 0x00110E98 File Offset: 0x0010F098
		// (set) Token: 0x0600493C RID: 18748 RVA: 0x0002B1BA File Offset: 0x000293BA
		public unsafe Sequencer.NotePosition endSearch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_endSearch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_endSearch)) = value;
			}
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x0600493D RID: 18749 RVA: 0x00110EC0 File Offset: 0x0010F0C0
		// (set) Token: 0x0600493E RID: 18750 RVA: 0x0002B1D5 File Offset: 0x000293D5
		public unsafe int indexStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_indexStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_indexStart)) = value;
			}
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x0600493F RID: 18751 RVA: 0x00110EE8 File Offset: 0x0010F0E8
		// (set) Token: 0x06004940 RID: 18752 RVA: 0x0002B1F0 File Offset: 0x000293F0
		public unsafe int indexEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_indexEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_indexEnd)) = value;
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x06004941 RID: 18753 RVA: 0x00110F10 File Offset: 0x0010F110
		// (set) Token: 0x06004942 RID: 18754 RVA: 0x0002B20B File Offset: 0x0002940B
		public unsafe IList<Note> notesIList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_notesIList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Note>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_notesIList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06004943 RID: 18755 RVA: 0x00110F40 File Offset: 0x0010F140
		// (set) Token: 0x06004944 RID: 18756 RVA: 0x0002B22A File Offset: 0x0002942A
		public unsafe int numNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_numNotes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_numNotes)) = value;
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x06004945 RID: 18757 RVA: 0x00110F68 File Offset: 0x0010F168
		// (set) Token: 0x06004946 RID: 18758 RVA: 0x0002B245 File Offset: 0x00029445
		public unsafe int nextIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_nextIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_nextIndex)) = value;
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06004947 RID: 18759 RVA: 0x00110F90 File Offset: 0x0010F190
		// (set) Token: 0x06004948 RID: 18760 RVA: 0x0002B260 File Offset: 0x00029460
		public unsafe double globalBeatTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_globalBeatTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_globalBeatTime)) = value;
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06004949 RID: 18761 RVA: 0x00110FB8 File Offset: 0x0010F1B8
		// (set) Token: 0x0600494A RID: 18762 RVA: 0x0002B27B File Offset: 0x0002947B
		public unsafe double bpm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_bpm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_bpm)) = value;
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x00110FE0 File Offset: 0x0010F1E0
		// (set) Token: 0x0600494C RID: 18764 RVA: 0x0002B296 File Offset: 0x00029496
		public unsafe double lastUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_lastUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_lastUpdate)) = value;
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x00111008 File Offset: 0x0010F208
		// (set) Token: 0x0600494E RID: 18766 RVA: 0x0002B2B1 File Offset: 0x000294B1
		public unsafe double time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x0600494F RID: 18767 RVA: 0x00111030 File Offset: 0x0010F230
		// (set) Token: 0x06004950 RID: 18768 RVA: 0x0002B2CC File Offset: 0x000294CC
		public unsafe int nextActiveNoteIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_nextActiveNoteIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_nextActiveNoteIndex)) = value;
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06004951 RID: 18769 RVA: 0x00111058 File Offset: 0x0010F258
		// (set) Token: 0x06004952 RID: 18770 RVA: 0x0002B2E7 File Offset: 0x000294E7
		public unsafe int numActiveNoteSearchLoops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_numActiveNoteSearchLoops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_numActiveNoteSearchLoops)) = value;
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06004953 RID: 18771 RVA: 0x00111080 File Offset: 0x0010F280
		// (set) Token: 0x06004954 RID: 18772 RVA: 0x0002B302 File Offset: 0x00029502
		public unsafe Il2CppStructArray<Note> noteOns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06004955 RID: 18773 RVA: 0x001110B0 File Offset: 0x0010F2B0
		// (set) Token: 0x06004956 RID: 18774 RVA: 0x0002B321 File Offset: 0x00029521
		public unsafe Il2CppStructArray<Note> noteOffs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOffs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOffs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x001110E0 File Offset: 0x0010F2E0
		// (set) Token: 0x06004958 RID: 18776 RVA: 0x0002B340 File Offset: 0x00029540
		public unsafe int noteOnIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOnIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOnIndex)) = value;
			}
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06004959 RID: 18777 RVA: 0x00111108 File Offset: 0x0010F308
		// (set) Token: 0x0600495A RID: 18778 RVA: 0x0002B35B File Offset: 0x0002955B
		public unsafe int noteOffIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOffIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequencer.NativeFieldInfoPtr_noteOffIndex)) = value;
			}
		}

		// Token: 0x04002E9C RID: 11932
		private static readonly IntPtr NativeFieldInfoPtr_OnNoteOn;

		// Token: 0x04002E9D RID: 11933
		private static readonly IntPtr NativeFieldInfoPtr_OnNoteOff;

		// Token: 0x04002E9E RID: 11934
		private static readonly IntPtr NativeFieldInfoPtr_OnBeat;

		// Token: 0x04002E9F RID: 11935
		private static readonly IntPtr NativeFieldInfoPtr_noteOnEvent;

		// Token: 0x04002EA0 RID: 11936
		private static readonly IntPtr NativeFieldInfoPtr_noteOffEvent;

		// Token: 0x04002EA1 RID: 11937
		private static readonly IntPtr NativeFieldInfoPtr_beatEvent;

		// Token: 0x04002EA2 RID: 11938
		private static readonly IntPtr NativeFieldInfoPtr_activeNotes;

		// Token: 0x04002EA3 RID: 11939
		private static readonly IntPtr NativeFieldInfoPtr_SequenceToLoad;

		// Token: 0x04002EA4 RID: 11940
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04002EA5 RID: 11941
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x04002EA6 RID: 11942
		private static readonly IntPtr NativeFieldInfoPtr_loop;

		// Token: 0x04002EA7 RID: 11943
		private static readonly IntPtr NativeFieldInfoPtr_beatTime;

		// Token: 0x04002EA8 RID: 11944
		private static readonly IntPtr NativeFieldInfoPtr_paused;

		// Token: 0x04002EA9 RID: 11945
		private static readonly IntPtr NativeFieldInfoPtr_allNotes;

		// Token: 0x04002EAA RID: 11946
		private static readonly IntPtr NativeFieldInfoPtr_scrollPosition;

		// Token: 0x04002EAB RID: 11947
		private static readonly IntPtr NativeFieldInfoPtr_autoScroll;

		// Token: 0x04002EAC RID: 11948
		private static readonly IntPtr NativeFieldInfoPtr_division;

		// Token: 0x04002EAD RID: 11949
		private static readonly IntPtr NativeFieldInfoPtr_zoom;

		// Token: 0x04002EAE RID: 11950
		private static readonly IntPtr NativeFieldInfoPtr_VelocityMultiplier;

		// Token: 0x04002EAF RID: 11951
		private static readonly IntPtr NativeFieldInfoPtr_allNoteOns;

		// Token: 0x04002EB0 RID: 11952
		private static readonly IntPtr NativeFieldInfoPtr_allNoteOffs;

		// Token: 0x04002EB1 RID: 11953
		private static readonly IntPtr NativeFieldInfoPtr_lastSequencerPosition;

		// Token: 0x04002EB2 RID: 11954
		private static readonly IntPtr NativeFieldInfoPtr_clock;

		// Token: 0x04002EB3 RID: 11955
		private static readonly IntPtr NativeFieldInfoPtr_offPosition;

		// Token: 0x04002EB4 RID: 11956
		private static readonly IntPtr NativeFieldInfoPtr_allNoteOffsIndex;

		// Token: 0x04002EB5 RID: 11957
		private static readonly IntPtr NativeFieldInfoPtr_allNoteOnsIndex;

		// Token: 0x04002EB6 RID: 11958
		private static readonly IntPtr NativeFieldInfoPtr_seq;

		// Token: 0x04002EB7 RID: 11959
		private static readonly IntPtr NativeFieldInfoPtr_cleared;

		// Token: 0x04002EB8 RID: 11960
		private static readonly IntPtr NativeFieldInfoPtr_nl;

		// Token: 0x04002EB9 RID: 11961
		private static readonly IntPtr NativeFieldInfoPtr_seqCount;

		// Token: 0x04002EBA RID: 11962
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x04002EBB RID: 11963
		private static readonly IntPtr NativeFieldInfoPtr_halfOffset;

		// Token: 0x04002EBC RID: 11964
		private static readonly IntPtr NativeFieldInfoPtr_wrapping;

		// Token: 0x04002EBD RID: 11965
		private static readonly IntPtr NativeFieldInfoPtr_wrapAmount;

		// Token: 0x04002EBE RID: 11966
		private static readonly IntPtr NativeFieldInfoPtr_preWrapAmount;

		// Token: 0x04002EBF RID: 11967
		private static readonly IntPtr NativeFieldInfoPtr_skippedStart;

		// Token: 0x04002EC0 RID: 11968
		private static readonly IntPtr NativeFieldInfoPtr_skippedEnd;

		// Token: 0x04002EC1 RID: 11969
		private static readonly IntPtr NativeFieldInfoPtr_beatsPrinted;

		// Token: 0x04002EC2 RID: 11970
		private static readonly IntPtr NativeFieldInfoPtr_getAllNotesNotes;

		// Token: 0x04002EC3 RID: 11971
		private static readonly IntPtr NativeFieldInfoPtr_noteInRangeIndex;

		// Token: 0x04002EC4 RID: 11972
		private static readonly IntPtr NativeFieldInfoPtr_noteObject;

		// Token: 0x04002EC5 RID: 11973
		private static readonly IntPtr NativeFieldInfoPtr_allNotesCounts;

		// Token: 0x04002EC6 RID: 11974
		private static readonly IntPtr NativeFieldInfoPtr_notesInRange;

		// Token: 0x04002EC7 RID: 11975
		private static readonly IntPtr NativeFieldInfoPtr_startSearch;

		// Token: 0x04002EC8 RID: 11976
		private static readonly IntPtr NativeFieldInfoPtr_endSearch;

		// Token: 0x04002EC9 RID: 11977
		private static readonly IntPtr NativeFieldInfoPtr_indexStart;

		// Token: 0x04002ECA RID: 11978
		private static readonly IntPtr NativeFieldInfoPtr_indexEnd;

		// Token: 0x04002ECB RID: 11979
		private static readonly IntPtr NativeFieldInfoPtr_notesIList;

		// Token: 0x04002ECC RID: 11980
		private static readonly IntPtr NativeFieldInfoPtr_numNotes;

		// Token: 0x04002ECD RID: 11981
		private static readonly IntPtr NativeFieldInfoPtr_nextIndex;

		// Token: 0x04002ECE RID: 11982
		private static readonly IntPtr NativeFieldInfoPtr_globalBeatTime;

		// Token: 0x04002ECF RID: 11983
		private static readonly IntPtr NativeFieldInfoPtr_bpm;

		// Token: 0x04002ED0 RID: 11984
		private static readonly IntPtr NativeFieldInfoPtr_lastUpdate;

		// Token: 0x04002ED1 RID: 11985
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04002ED2 RID: 11986
		private static readonly IntPtr NativeFieldInfoPtr_nextActiveNoteIndex;

		// Token: 0x04002ED3 RID: 11987
		private static readonly IntPtr NativeFieldInfoPtr_numActiveNoteSearchLoops;

		// Token: 0x04002ED4 RID: 11988
		private static readonly IntPtr NativeFieldInfoPtr_noteOns;

		// Token: 0x04002ED5 RID: 11989
		private static readonly IntPtr NativeFieldInfoPtr_noteOffs;

		// Token: 0x04002ED6 RID: 11990
		private static readonly IntPtr NativeFieldInfoPtr_noteOnIndex;

		// Token: 0x04002ED7 RID: 11991
		private static readonly IntPtr NativeFieldInfoPtr_noteOffIndex;

		// Token: 0x04002ED8 RID: 11992
		private static readonly IntPtr NativeMethodInfoPtr_add_OnNoteOn_Public_add_Void_NoteAction_0;

		// Token: 0x04002ED9 RID: 11993
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnNoteOn_Public_rem_Void_NoteAction_0;

		// Token: 0x04002EDA RID: 11994
		private static readonly IntPtr NativeMethodInfoPtr_add_OnNoteOff_Public_add_Void_NoteAction_0;

		// Token: 0x04002EDB RID: 11995
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnNoteOff_Public_rem_Void_NoteAction_0;

		// Token: 0x04002EDC RID: 11996
		private static readonly IntPtr NativeMethodInfoPtr_add_OnBeat_Public_add_Void_BeatAction_0;

		// Token: 0x04002EDD RID: 11997
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnBeat_Public_rem_Void_BeatAction_0;

		// Token: 0x04002EDE RID: 11998
		private static readonly IntPtr NativeMethodInfoPtr_AllNotesOff_Public_Virtual_New_Void_0;

		// Token: 0x04002EDF RID: 11999
		private static readonly IntPtr NativeMethodInfoPtr_NoteOn_Public_Abstract_Virtual_New_Void_Int32_Single_0;

		// Token: 0x04002EE0 RID: 12000
		private static readonly IntPtr NativeMethodInfoPtr_NoteOff_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04002EE1 RID: 12001
		private static readonly IntPtr NativeMethodInfoPtr_StartScheduled_Public_Void_Double_0;

		// Token: 0x04002EE2 RID: 12002
		private static readonly IntPtr NativeMethodInfoPtr_StartOnNextCycle_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002EE3 RID: 12003
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002EE4 RID: 12004
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002EE5 RID: 12005
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04002EE6 RID: 12006
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x04002EE7 RID: 12007
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSortedNoteEvents_Protected_Void_byref_Note_0;

		// Token: 0x04002EE8 RID: 12008
		private static readonly IntPtr NativeMethodInfoPtr_AddSortedNoteEvents_Protected_Void_byref_Note_0;

		// Token: 0x04002EE9 RID: 12009
		private static readonly IntPtr NativeMethodInfoPtr_LoadSequence_Public_Void_NoteSequence_0;

		// Token: 0x04002EEA RID: 12010
		private static readonly IntPtr NativeMethodInfoPtr_LoadSequenceStreaming_Public_Void_NoteSequence_Int32_Int32_Int32_0;

		// Token: 0x04002EEB RID: 12011
		private static readonly IntPtr NativeMethodInfoPtr_InitNoteRows_Protected_Void_0;

		// Token: 0x04002EEC RID: 12012
		private static readonly IntPtr NativeMethodInfoPtr_GetDivisionLength_Public_Single_0;

		// Token: 0x04002EED RID: 12013
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNote_Public_Void_byref_Note_0;

		// Token: 0x04002EEE RID: 12014
		private static readonly IntPtr NativeMethodInfoPtr_NoteExistsInRange_Public_Boolean_Int32_Single_Single_0;

		// Token: 0x04002EEF RID: 12015
		private static readonly IntPtr NativeMethodInfoPtr_GetNoteInRange_Public_Int32_Int32_Single_Single_Note_0;

		// Token: 0x04002EF0 RID: 12016
		private static readonly IntPtr NativeMethodInfoPtr_GetAllNotes_Public_Il2CppStructArray_1_Note_0;

		// Token: 0x04002EF1 RID: 12017
		private static readonly IntPtr NativeMethodInfoPtr_GetAllNoteOnsInRange_Public_Il2CppStructArray_1_Note_Single_Single_0;

		// Token: 0x04002EF2 RID: 12018
		private static readonly IntPtr NativeMethodInfoPtr_GetAllNoteOffsInRange_Public_Il2CppStructArray_1_Note_Single_Single_0;

		// Token: 0x04002EF3 RID: 12019
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNotesInRange_Public_Void_Int32_Single_Single_0;

		// Token: 0x04002EF4 RID: 12020
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNotesContainedInRange_Public_Void_Int32_Single_Single_Note_0;

		// Token: 0x04002EF5 RID: 12021
		private static readonly IntPtr NativeMethodInfoPtr_ClampNotesInRange_Public_Void_Int32_Single_Single_Note_0;

		// Token: 0x04002EF6 RID: 12022
		private static readonly IntPtr NativeMethodInfoPtr_AddNote_Public_Void_Int32_Single_Single_Single_0;

		// Token: 0x04002EF7 RID: 12023
		private static readonly IntPtr NativeMethodInfoPtr_ReadMidiData_Private_Void_MidiData_0;

		// Token: 0x04002EF8 RID: 12024
		private static readonly IntPtr NativeMethodInfoPtr_ReadMidiFile_Public_Void_Stream_0;

		// Token: 0x04002EF9 RID: 12025
		private static readonly IntPtr NativeMethodInfoPtr_ReadMidiFile_Public_Void_MidiFile_0;

		// Token: 0x04002EFA RID: 12026
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002EFB RID: 12027
		private static readonly IntPtr NativeMethodInfoPtr_GetSixteenthTime_Public_Single_0;

		// Token: 0x04002EFC RID: 12028
		private static readonly IntPtr NativeMethodInfoPtr_GetSequencerTime_Protected_Double_0;

		// Token: 0x04002EFD RID: 12029
		private static readonly IntPtr NativeMethodInfoPtr_GetSequencerPosition_Public_Double_0;

		// Token: 0x04002EFE RID: 12030
		private static readonly IntPtr NativeMethodInfoPtr_GetAllNoteEventsInRange_Private_Il2CppStructArray_1_Note_Single_Single_Il2CppStructArray_1_Note_0;

		// Token: 0x04002EFF RID: 12031
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIndex_Private_Void_0;

		// Token: 0x04002F00 RID: 12032
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBeatTime_Protected_Void_0;

		// Token: 0x04002F01 RID: 12033
		private static readonly IntPtr NativeMethodInfoPtr_SendNoteOff_Private_Void_Note_Int32_0;

		// Token: 0x04002F02 RID: 12034
		private static readonly IntPtr NativeMethodInfoPtr_SendNoteOn_Private_Void_Note_Int32_0;

		// Token: 0x04002F03 RID: 12035
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Protected_Void_0;

		// Token: 0x04002F04 RID: 12036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020003EE RID: 1006
		public sealed class NoteAction : MulticastDelegate
		{
			// Token: 0x06005B5A RID: 23386 RVA: 0x001498A4 File Offset: 0x00147AA4
			// Note: this type is marked as 'beforefieldinit'.
			static NoteAction()
			{
				Il2CppClassPointerStore<Sequencer.NoteAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "NoteAction");
				Sequencer.NoteAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer.NoteAction>.NativeClassPtr, 100670818);
				Sequencer.NoteAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer.NoteAction>.NativeClassPtr, 100670819);
				Sequencer.NoteAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Note_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer.NoteAction>.NativeClassPtr, 100670820);
				Sequencer.NoteAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer.NoteAction>.NativeClassPtr, 100670821);
			}

			// Token: 0x06005B5B RID: 23387 RVA: 0x00149918 File Offset: 0x00147B18
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NoteAction(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sequencer.NoteAction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NoteAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B5C RID: 23388 RVA: 0x00149974 File Offset: 0x00147B74
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 117501, RefRangeEnd = 117502, XrefRangeStart = 117501, XrefRangeEnd = 117501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Note note)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref note;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NoteAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B5D RID: 23389 RVA: 0x001499B4 File Offset: 0x00147BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117502, XrefRangeEnd = 117506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Note note, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref note;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NoteAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Note_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005B5E RID: 23390 RVA: 0x00149A24 File Offset: 0x00147C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NoteAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B5F RID: 23391 RVA: 0x000341B6 File Offset: 0x000323B6
			public NoteAction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005B60 RID: 23392 RVA: 0x000341BF File Offset: 0x000323BF
			public static implicit operator Sequencer.NoteAction(Action<Note> A_0)
			{
				return DelegateSupport.ConvertDelegate<Sequencer.NoteAction>(A_0);
			}

			// Token: 0x06005B61 RID: 23393 RVA: 0x000341C7 File Offset: 0x000323C7
			public static Sequencer.NoteAction operator +(Sequencer.NoteAction A_0, Sequencer.NoteAction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Sequencer.NoteAction>();
			}

			// Token: 0x06005B62 RID: 23394 RVA: 0x000341D5 File Offset: 0x000323D5
			public static Sequencer.NoteAction operator -(Sequencer.NoteAction A_0, Sequencer.NoteAction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Sequencer.NoteAction>();
				}
				return delegate2;
			}

			// Token: 0x04003CAE RID: 15534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003CAF RID: 15535
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Note_0;

			// Token: 0x04003CB0 RID: 15536
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Note_AsyncCallback_Object_0;

			// Token: 0x04003CB1 RID: 15537
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003EF RID: 1007
		public sealed class BeatAction : MulticastDelegate
		{
			// Token: 0x06005B63 RID: 23395 RVA: 0x00149A68 File Offset: 0x00147C68
			// Note: this type is marked as 'beforefieldinit'.
			static BeatAction()
			{
				Il2CppClassPointerStore<Sequencer.BeatAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "BeatAction");
				Sequencer.BeatAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer.BeatAction>.NativeClassPtr, 100670822);
				Sequencer.BeatAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer.BeatAction>.NativeClassPtr, 100670823);
				Sequencer.BeatAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer.BeatAction>.NativeClassPtr, 100670824);
				Sequencer.BeatAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer.BeatAction>.NativeClassPtr, 100670825);
			}

			// Token: 0x06005B64 RID: 23396 RVA: 0x00149ADC File Offset: 0x00147CDC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BeatAction(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sequencer.BeatAction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.BeatAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B65 RID: 23397 RVA: 0x00149B38 File Offset: 0x00147D38
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 12882, RefRangeEnd = 12902, XrefRangeStart = 12882, XrefRangeEnd = 12902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.BeatAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B66 RID: 23398 RVA: 0x00149B78 File Offset: 0x00147D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117506, XrefRangeEnd = 117510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int index, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.BeatAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005B67 RID: 23399 RVA: 0x00149BE8 File Offset: 0x00147DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.BeatAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B68 RID: 23400 RVA: 0x000341E6 File Offset: 0x000323E6
			public BeatAction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005B69 RID: 23401 RVA: 0x000341EF File Offset: 0x000323EF
			public static implicit operator Sequencer.BeatAction(Action<int> A_0)
			{
				return DelegateSupport.ConvertDelegate<Sequencer.BeatAction>(A_0);
			}

			// Token: 0x06005B6A RID: 23402 RVA: 0x000341F7 File Offset: 0x000323F7
			public static Sequencer.BeatAction operator +(Sequencer.BeatAction A_0, Sequencer.BeatAction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Sequencer.BeatAction>();
			}

			// Token: 0x06005B6B RID: 23403 RVA: 0x00034205 File Offset: 0x00032405
			public static Sequencer.BeatAction operator -(Sequencer.BeatAction A_0, Sequencer.BeatAction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Sequencer.BeatAction>();
				}
				return delegate2;
			}

			// Token: 0x04003CB2 RID: 15538
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003CB3 RID: 15539
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

			// Token: 0x04003CB4 RID: 15540
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

			// Token: 0x04003CB5 RID: 15541
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003F0 RID: 1008
		[Serializable]
		public class NoteEvent : UnityEvent<Note>
		{
			// Token: 0x06005B6C RID: 23404 RVA: 0x00034216 File Offset: 0x00032416
			// Note: this type is marked as 'beforefieldinit'.
			static NoteEvent()
			{
				Il2CppClassPointerStore<Sequencer.NoteEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "NoteEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequencer.NoteEvent>.NativeClassPtr);
				Sequencer.NoteEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer.NoteEvent>.NativeClassPtr, 100670826);
			}

			// Token: 0x06005B6D RID: 23405 RVA: 0x00149C2C File Offset: 0x00147E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117510, XrefRangeEnd = 117512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NoteEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sequencer.NoteEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NoteEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B6E RID: 23406 RVA: 0x0003424A File Offset: 0x0003244A
			public NoteEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003CB6 RID: 15542
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003F1 RID: 1009
		[Serializable]
		public class BeatEvent : UnityEvent<int>
		{
			// Token: 0x06005B6F RID: 23407 RVA: 0x00034253 File Offset: 0x00032453
			// Note: this type is marked as 'beforefieldinit'.
			static BeatEvent()
			{
				Il2CppClassPointerStore<Sequencer.BeatEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "BeatEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequencer.BeatEvent>.NativeClassPtr);
				Sequencer.BeatEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer.BeatEvent>.NativeClassPtr, 100670827);
			}

			// Token: 0x06005B70 RID: 23408 RVA: 0x00149C68 File Offset: 0x00147E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117512, XrefRangeEnd = 117514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BeatEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sequencer.BeatEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.BeatEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B71 RID: 23409 RVA: 0x00034287 File Offset: 0x00032487
			public BeatEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003CB7 RID: 15543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003F2 RID: 1010
		[StructLayout(2)]
		public struct NotePosition
		{
			// Token: 0x06005B72 RID: 23410 RVA: 0x00149CA4 File Offset: 0x00147EA4
			// Note: this type is marked as 'beforefieldinit'.
			static NotePosition()
			{
				Il2CppClassPointerStore<Sequencer.NotePosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sequencer>.NativeClassPtr, "NotePosition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequencer.NotePosition>.NativeClassPtr);
				Sequencer.NotePosition.NativeFieldInfoPtr_position_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer.NotePosition>.NativeClassPtr, "position_");
				Sequencer.NotePosition.NativeFieldInfoPtr_note_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequencer.NotePosition>.NativeClassPtr, "note_");
				Sequencer.NotePosition.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequencer.NotePosition>.NativeClassPtr, 100670828);
			}

			// Token: 0x06005B73 RID: 23411 RVA: 0x00149D0C File Offset: 0x00147F0C
			[CallerCount(0)]
			public unsafe NotePosition(float position, int note)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref position;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequencer.NotePosition.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B74 RID: 23412 RVA: 0x00034290 File Offset: 0x00032490
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Sequencer.NotePosition>.NativeClassPtr, ref this));
			}

			// Token: 0x04003CB8 RID: 15544
			private static readonly IntPtr NativeFieldInfoPtr_position_;

			// Token: 0x04003CB9 RID: 15545
			private static readonly IntPtr NativeFieldInfoPtr_note_;

			// Token: 0x04003CBA RID: 15546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0;

			// Token: 0x04003CBB RID: 15547
			[FieldOffset(0)]
			public float position_;

			// Token: 0x04003CBC RID: 15548
			[FieldOffset(4)]
			public int note_;
		}

		// Token: 0x020003F3 RID: 1011
		[OriginalName("Assembly-CSharp.dll", "", "Division")]
		public enum Division
		{
			// Token: 0x04003CBE RID: 15550
			kEighth,
			// Token: 0x04003CBF RID: 15551
			kSixteenth,
			// Token: 0x04003CC0 RID: 15552
			kTriplet,
			// Token: 0x04003CC1 RID: 15553
			kThirtySecond
		}
	}
}
