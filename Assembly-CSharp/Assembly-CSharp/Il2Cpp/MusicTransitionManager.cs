using System;
using Il2CppAudioHelm;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200000C RID: 12
	public class MusicTransitionManager : MonoBehaviour
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x00038B90 File Offset: 0x00036D90
		// Note: this type is marked as 'beforefieldinit'.
		static MusicTransitionManager()
		{
			Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MusicTransitionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr);
			MusicTransitionManager.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "me");
			MusicTransitionManager.NativeFieldInfoPtr_Transitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "Transitions");
			MusicTransitionManager.NativeFieldInfoPtr_DeathTransitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "DeathTransitions");
			MusicTransitionManager.NativeFieldInfoPtr_ArcadeTransitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "ArcadeTransitions");
			MusicTransitionManager.NativeFieldInfoPtr_ClearTransitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "ClearTransitions");
			MusicTransitionManager.NativeFieldInfoPtr_TransitionTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "TransitionTitles");
			MusicTransitionManager.NativeFieldInfoPtr_Clock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "Clock");
			MusicTransitionManager.NativeFieldInfoPtr_boop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "boop");
			MusicTransitionManager.NativeFieldInfoPtr_AuthoringTransitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "AuthoringTransitions");
			MusicTransitionManager.NativeFieldInfoPtr_lastNotePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "lastNotePos");
			MusicTransitionManager.NativeFieldInfoPtr_musicSys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "musicSys");
			MusicTransitionManager.NativeFieldInfoPtr__subscribedNoteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "_subscribedNoteAction");
			MusicTransitionManager.NativeFieldInfoPtr_cleared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "cleared");
			MusicTransitionManager.NativeFieldInfoPtr_over = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "over");
			MusicTransitionManager.NativeFieldInfoPtr_isThisTheEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "isThisTheEnd");
			MusicTransitionManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663393);
			MusicTransitionManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663394);
			MusicTransitionManager.NativeMethodInfoPtr_GetTransitionTitles_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663395);
			MusicTransitionManager.NativeMethodInfoPtr_CallTransition_Public_Void_NoteAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663396);
			MusicTransitionManager.NativeMethodInfoPtr_CallTransition_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663397);
			MusicTransitionManager.NativeMethodInfoPtr_DeathTransition_Public_Void_NoteAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663398);
			MusicTransitionManager.NativeMethodInfoPtr_ArcadeTransition_Public_Void_NoteAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663399);
			MusicTransitionManager.NativeMethodInfoPtr_ClearTransition_Public_Void_NoteAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663400);
			MusicTransitionManager.NativeMethodInfoPtr_ForceTransistionEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663401);
			MusicTransitionManager.NativeMethodInfoPtr_ThisTheEnd_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663402);
			MusicTransitionManager.NativeMethodInfoPtr_WaitForEnd_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663403);
			MusicTransitionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, 100663404);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00038DDC File Offset: 0x00036FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31409, XrefRangeEnd = 31429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00038E10 File Offset: 0x00037010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31429, XrefRangeEnd = 31450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00038E44 File Offset: 0x00037044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31450, XrefRangeEnd = 31463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetTransitionTitles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr_GetTransitionTitles_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00038E84 File Offset: 0x00037084
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31529, RefRangeEnd = 31533, XrefRangeStart = 31463, XrefRangeEnd = 31529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallTransition(Sequencer.NoteAction drumBeatAnimation, int transitionIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drumBeatAnimation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transitionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr_CallTransition_Public_Void_NoteAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00038ED4 File Offset: 0x000370D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31533, XrefRangeEnd = 31598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallTransition(int transitionIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transitionIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr_CallTransition_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00038F14 File Offset: 0x00037114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31626, RefRangeEnd = 31627, XrefRangeStart = 31598, XrefRangeEnd = 31626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeathTransition(Sequencer.NoteAction drumBeatAnimation, int transitionIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drumBeatAnimation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transitionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr_DeathTransition_Public_Void_NoteAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00038F64 File Offset: 0x00037164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31654, RefRangeEnd = 31655, XrefRangeStart = 31627, XrefRangeEnd = 31654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArcadeTransition(Sequencer.NoteAction drumBeatAnimation, int transitionIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drumBeatAnimation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transitionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr_ArcadeTransition_Public_Void_NoteAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00038FB4 File Offset: 0x000371B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31655, XrefRangeEnd = 31678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTransition(Sequencer.NoteAction drumBeatAnimation, int transitionIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drumBeatAnimation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transitionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr_ClearTransition_Public_Void_NoteAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00039004 File Offset: 0x00037204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31682, RefRangeEnd = 31683, XrefRangeStart = 31678, XrefRangeEnd = 31682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceTransistionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr_ForceTransistionEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00039038 File Offset: 0x00037238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31683, XrefRangeEnd = 31684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ThisTheEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr_ThisTheEnd_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00039074 File Offset: 0x00037274
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 31687, RefRangeEnd = 31692, XrefRangeStart = 31684, XrefRangeEnd = 31687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr_WaitForEnd_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000390B4 File Offset: 0x000372B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31692, XrefRangeEnd = 31716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicTransitionManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000345A File Offset: 0x0000165A
		public MusicTransitionManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000390F0 File Offset: 0x000372F0
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00003463 File Offset: 0x00001663
		public unsafe static MusicTransitionManager me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicTransitionManager.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTransitionManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicTransitionManager.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00039118 File Offset: 0x00037318
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00003475 File Offset: 0x00001675
		public unsafe List<NoteSequence> Transitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_Transitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NoteSequence>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_Transitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00039148 File Offset: 0x00037348
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00003494 File Offset: 0x00001694
		public unsafe List<NoteSequence> DeathTransitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_DeathTransitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NoteSequence>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_DeathTransitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00039178 File Offset: 0x00037378
		// (set) Token: 0x060001CE RID: 462 RVA: 0x000034B3 File Offset: 0x000016B3
		public unsafe List<NoteSequence> ArcadeTransitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_ArcadeTransitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NoteSequence>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_ArcadeTransitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000391A8 File Offset: 0x000373A8
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x000034D2 File Offset: 0x000016D2
		public unsafe List<NoteSequence> ClearTransitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_ClearTransitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NoteSequence>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_ClearTransitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000391D8 File Offset: 0x000373D8
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x000034F1 File Offset: 0x000016F1
		public unsafe Il2CppStringArray TransitionTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_TransitionTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_TransitionTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00039208 File Offset: 0x00037408
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00003510 File Offset: 0x00001710
		public unsafe AudioHelmClock Clock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_Clock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioHelmClock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_Clock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00039238 File Offset: 0x00037438
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0000352F File Offset: 0x0000172F
		public unsafe float boop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_boop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_boop)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00039260 File Offset: 0x00037460
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000354A File Offset: 0x0000174A
		public unsafe bool AuthoringTransitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_AuthoringTransitions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_AuthoringTransitions)) = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00039288 File Offset: 0x00037488
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00003565 File Offset: 0x00001765
		public unsafe float lastNotePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_lastNotePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_lastNotePos)) = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000392B0 File Offset: 0x000374B0
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00003580 File Offset: 0x00001780
		public unsafe MusicSystem musicSys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_musicSys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_musicSys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000392E0 File Offset: 0x000374E0
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000359F File Offset: 0x0000179F
		public unsafe Sequencer.NoteAction _subscribedNoteAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr__subscribedNoteAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequencer.NoteAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr__subscribedNoteAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00039310 File Offset: 0x00037510
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x000035BE File Offset: 0x000017BE
		public unsafe bool cleared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_cleared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_cleared)) = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00039338 File Offset: 0x00037538
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x000035D9 File Offset: 0x000017D9
		public unsafe bool over
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_over);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_over)) = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00039360 File Offset: 0x00037560
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x000035F4 File Offset: 0x000017F4
		public unsafe bool isThisTheEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_isThisTheEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager.NativeFieldInfoPtr_isThisTheEnd)) = value;
			}
		}

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_Transitions;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_DeathTransitions;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_ArcadeTransitions;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_ClearTransitions;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_TransitionTitles;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_Clock;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_boop;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_AuthoringTransitions;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_lastNotePos;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_musicSys;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr__subscribedNoteAction;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_cleared;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_over;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_isThisTheEnd;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_GetTransitionTitles_Public_Il2CppStringArray_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_CallTransition_Public_Void_NoteAction_Int32_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_CallTransition_Public_Void_Int32_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_DeathTransition_Public_Void_NoteAction_Int32_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_ArcadeTransition_Public_Void_NoteAction_Int32_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_ClearTransition_Public_Void_NoteAction_Int32_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_ForceTransistionEnd_Public_Void_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_ThisTheEnd_Public_Boolean_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_WaitForEnd_Private_IEnumerator_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000299 RID: 665
		[ObfuscatedName("MusicTransitionManager+<WaitForEnd>d__25")]
		public sealed class _WaitForEnd_d__25 : global::Il2CppSystem.Object
		{
			// Token: 0x06004A08 RID: 18952 RVA: 0x00112BB0 File Offset: 0x00110DB0
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForEnd_d__25()
			{
				Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicTransitionManager>.NativeClassPtr, "<WaitForEnd>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr);
				MusicTransitionManager._WaitForEnd_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr, "<>1__state");
				MusicTransitionManager._WaitForEnd_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr, "<>2__current");
				MusicTransitionManager._WaitForEnd_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr, "<>4__this");
				MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr, 100663405);
				MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr, 100663406);
				MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr, 100663407);
				MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr, 100663408);
				MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr, 100663409);
				MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr, 100663410);
			}

			// Token: 0x06004A09 RID: 18953 RVA: 0x00112C90 File Offset: 0x00110E90
			[CallerCount(0)]
			public unsafe _WaitForEnd_d__25(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicTransitionManager._WaitForEnd_d__25>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A0A RID: 18954 RVA: 0x00112CD8 File Offset: 0x00110ED8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A0B RID: 18955 RVA: 0x00112D0C File Offset: 0x00110F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31395, XrefRangeEnd = 31404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001AF3 RID: 6899
			// (get) Token: 0x06004A0C RID: 18956 RVA: 0x00112D48 File Offset: 0x00110F48
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004A0D RID: 18957 RVA: 0x00112D88 File Offset: 0x00110F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31404, XrefRangeEnd = 31409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AF4 RID: 6900
			// (get) Token: 0x06004A0E RID: 18958 RVA: 0x00112DBC File Offset: 0x00110FBC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTransitionManager._WaitForEnd_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004A0F RID: 18959 RVA: 0x0002B9E4 File Offset: 0x00029BE4
			public _WaitForEnd_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AF0 RID: 6896
			// (get) Token: 0x06004A10 RID: 18960 RVA: 0x00112DFC File Offset: 0x00110FFC
			// (set) Token: 0x06004A11 RID: 18961 RVA: 0x0002B9ED File Offset: 0x00029BED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager._WaitForEnd_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager._WaitForEnd_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AF1 RID: 6897
			// (get) Token: 0x06004A12 RID: 18962 RVA: 0x00112E24 File Offset: 0x00111024
			// (set) Token: 0x06004A13 RID: 18963 RVA: 0x0002BA08 File Offset: 0x00029C08
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager._WaitForEnd_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager._WaitForEnd_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF2 RID: 6898
			// (get) Token: 0x06004A14 RID: 18964 RVA: 0x00112E54 File Offset: 0x00111054
			// (set) Token: 0x06004A15 RID: 18965 RVA: 0x0002BA27 File Offset: 0x00029C27
			public unsafe MusicTransitionManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager._WaitForEnd_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTransitionManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTransitionManager._WaitForEnd_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003039 RID: 12345
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400303A RID: 12346
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400303B RID: 12347
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400303C RID: 12348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400303D RID: 12349
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400303E RID: 12350
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400303F RID: 12351
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003040 RID: 12352
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003041 RID: 12353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
