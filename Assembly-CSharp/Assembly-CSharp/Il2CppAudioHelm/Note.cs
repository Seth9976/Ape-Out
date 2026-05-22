using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAudioHelm
{
	// Token: 0x02000284 RID: 644
	[Serializable]
	[StructLayout(2)]
	public struct Note
	{
		// Token: 0x060047D6 RID: 18390 RVA: 0x0010C938 File Offset: 0x0010AB38
		// Note: this type is marked as 'beforefieldinit'.
		static Note()
		{
			Il2CppClassPointerStore<Note>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "Note");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Note>.NativeClassPtr);
			Note.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "note");
			Note.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "start");
			Note.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "end");
			Note.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "velocity");
			Note.NativeFieldInfoPtr_allNoteOnIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "allNoteOnIndex");
			Note.NativeFieldInfoPtr_allNoteOffIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "allNoteOffIndex");
			Note.NativeFieldInfoPtr_activeNotesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "activeNotesIndex");
			Note.NativeFieldInfoPtr_allNotesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "allNotesIndex");
			Note.NativeFieldInfoPtr_allNotesEditorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "allNotesEditorIndex");
			Note.NativeFieldInfoPtr_allNoteOnEditorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "allNoteOnEditorIndex");
			Note.NativeFieldInfoPtr_allNoteOffEditorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "allNoteOffEditorIndex");
			Note.NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "isActive");
			Note.NativeFieldInfoPtr_isScheduled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "isScheduled");
			Note.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Note>.NativeClassPtr, "Initialized");
			Note.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Single_Boolean_Boolean_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Note>.NativeClassPtr, 100670701);
			Note.NativeMethodInfoPtr_SetNote_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Note>.NativeClassPtr, 100670702);
			Note.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Note>.NativeClassPtr, 100670703);
			Note.NativeMethodInfoPtr_DeInitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Note>.NativeClassPtr, 100670704);
			Note.NativeMethodInfoPtr_SetActive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Note>.NativeClassPtr, 100670705);
			Note.NativeMethodInfoPtr_SetInactive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Note>.NativeClassPtr, 100670706);
			Note.NativeMethodInfoPtr_SetScheduled_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Note>.NativeClassPtr, 100670707);
			Note.NativeMethodInfoPtr_OverlapsRange_Public_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Note>.NativeClassPtr, 100670708);
			Note.NativeMethodInfoPtr_InsideRange_Public_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Note>.NativeClassPtr, 100670709);
			Note.NativeMethodInfoPtr_RemoveRange_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Note>.NativeClassPtr, 100670710);
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x0010CB48 File Offset: 0x0010AD48
		[CallerCount(0)]
		public unsafe Note(int _note, float _start, float _end, float _velocity, bool _initialized, bool _isScheduled, bool _isActive, int _activeNotesIndex, int _allNoteOnIndex, int _allNoteOffIndex, int _allNoteOnEditorIndex, int _allNoteOffEditorIndex, int _allNotesEditorIndex, int _allNotesIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _initialized;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _isScheduled;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _isActive;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _activeNotesIndex;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _allNoteOnIndex;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _allNoteOffIndex;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _allNoteOnEditorIndex;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _allNoteOffEditorIndex;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _allNotesEditorIndex;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _allNotesIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Note.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Single_Boolean_Boolean_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x0010CC38 File Offset: 0x0010AE38
		[CallerCount(0)]
		public unsafe void SetNote(int aNote)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aNote;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Note.NativeMethodInfoPtr_SetNote_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x0010CC6C File Offset: 0x0010AE6C
		[CallerCount(0)]
		public unsafe void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Note.NativeMethodInfoPtr_Initialize_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x0010CC94 File Offset: 0x0010AE94
		[CallerCount(0)]
		public unsafe void DeInitialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Note.NativeMethodInfoPtr_DeInitialize_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x0010CCBC File Offset: 0x0010AEBC
		[CallerCount(0)]
		public unsafe void SetActive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Note.NativeMethodInfoPtr_SetActive_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x0010CCE4 File Offset: 0x0010AEE4
		[CallerCount(0)]
		public unsafe void SetInactive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Note.NativeMethodInfoPtr_SetInactive_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x0010CD0C File Offset: 0x0010AF0C
		[CallerCount(0)]
		public unsafe void SetScheduled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Note.NativeMethodInfoPtr_SetScheduled_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x0010CD34 File Offset: 0x0010AF34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117009, RefRangeEnd = 117013, XrefRangeStart = 117004, XrefRangeEnd = 117009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OverlapsRange(float rangeStart, float rangeEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rangeStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangeEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Note.NativeMethodInfoPtr_OverlapsRange_Public_Boolean_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x0010CD80 File Offset: 0x0010AF80
		[CallerCount(0)]
		public unsafe bool InsideRange(float rangeStart, float rangeEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rangeStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangeEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Note.NativeMethodInfoPtr_InsideRange_Public_Boolean_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x0010CDCC File Offset: 0x0010AFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117013, XrefRangeEnd = 117014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRange(float rangeStart, float rangeEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rangeStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangeEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Note.NativeMethodInfoPtr_RemoveRange_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x0002A446 File Offset: 0x00028646
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Note>.NativeClassPtr, ref this));
		}

		// Token: 0x04002DF9 RID: 11769
		private static readonly IntPtr NativeFieldInfoPtr_note;

		// Token: 0x04002DFA RID: 11770
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x04002DFB RID: 11771
		private static readonly IntPtr NativeFieldInfoPtr_end;

		// Token: 0x04002DFC RID: 11772
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x04002DFD RID: 11773
		private static readonly IntPtr NativeFieldInfoPtr_allNoteOnIndex;

		// Token: 0x04002DFE RID: 11774
		private static readonly IntPtr NativeFieldInfoPtr_allNoteOffIndex;

		// Token: 0x04002DFF RID: 11775
		private static readonly IntPtr NativeFieldInfoPtr_activeNotesIndex;

		// Token: 0x04002E00 RID: 11776
		private static readonly IntPtr NativeFieldInfoPtr_allNotesIndex;

		// Token: 0x04002E01 RID: 11777
		private static readonly IntPtr NativeFieldInfoPtr_allNotesEditorIndex;

		// Token: 0x04002E02 RID: 11778
		private static readonly IntPtr NativeFieldInfoPtr_allNoteOnEditorIndex;

		// Token: 0x04002E03 RID: 11779
		private static readonly IntPtr NativeFieldInfoPtr_allNoteOffEditorIndex;

		// Token: 0x04002E04 RID: 11780
		private static readonly IntPtr NativeFieldInfoPtr_isActive;

		// Token: 0x04002E05 RID: 11781
		private static readonly IntPtr NativeFieldInfoPtr_isScheduled;

		// Token: 0x04002E06 RID: 11782
		private static readonly IntPtr NativeFieldInfoPtr_Initialized;

		// Token: 0x04002E07 RID: 11783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Single_Boolean_Boolean_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002E08 RID: 11784
		private static readonly IntPtr NativeMethodInfoPtr_SetNote_Public_Void_Int32_0;

		// Token: 0x04002E09 RID: 11785
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04002E0A RID: 11786
		private static readonly IntPtr NativeMethodInfoPtr_DeInitialize_Public_Void_0;

		// Token: 0x04002E0B RID: 11787
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_0;

		// Token: 0x04002E0C RID: 11788
		private static readonly IntPtr NativeMethodInfoPtr_SetInactive_Public_Void_0;

		// Token: 0x04002E0D RID: 11789
		private static readonly IntPtr NativeMethodInfoPtr_SetScheduled_Public_Void_0;

		// Token: 0x04002E0E RID: 11790
		private static readonly IntPtr NativeMethodInfoPtr_OverlapsRange_Public_Boolean_Single_Single_0;

		// Token: 0x04002E0F RID: 11791
		private static readonly IntPtr NativeMethodInfoPtr_InsideRange_Public_Boolean_Single_Single_0;

		// Token: 0x04002E10 RID: 11792
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRange_Public_Void_Single_Single_0;

		// Token: 0x04002E11 RID: 11793
		[FieldOffset(0)]
		public int note;

		// Token: 0x04002E12 RID: 11794
		[FieldOffset(4)]
		public float start;

		// Token: 0x04002E13 RID: 11795
		[FieldOffset(8)]
		public float end;

		// Token: 0x04002E14 RID: 11796
		[FieldOffset(12)]
		public float velocity;

		// Token: 0x04002E15 RID: 11797
		[NonSerialized]
		[FieldOffset(16)]
		public int allNoteOnIndex;

		// Token: 0x04002E16 RID: 11798
		[NonSerialized]
		[FieldOffset(20)]
		public int allNoteOffIndex;

		// Token: 0x04002E17 RID: 11799
		[NonSerialized]
		[FieldOffset(24)]
		public int activeNotesIndex;

		// Token: 0x04002E18 RID: 11800
		[NonSerialized]
		[FieldOffset(28)]
		public int allNotesIndex;

		// Token: 0x04002E19 RID: 11801
		[NonSerialized]
		[FieldOffset(32)]
		public int allNotesEditorIndex;

		// Token: 0x04002E1A RID: 11802
		[NonSerialized]
		[FieldOffset(36)]
		public int allNoteOnEditorIndex;

		// Token: 0x04002E1B RID: 11803
		[NonSerialized]
		[FieldOffset(40)]
		public int allNoteOffEditorIndex;

		// Token: 0x04002E1C RID: 11804
		[NonSerialized]
		[FieldOffset(44)]
		[MarshalAs(4)]
		public bool isActive;

		// Token: 0x04002E1D RID: 11805
		[NonSerialized]
		[FieldOffset(45)]
		[MarshalAs(4)]
		public bool isScheduled;

		// Token: 0x04002E1E RID: 11806
		[NonSerialized]
		[FieldOffset(46)]
		[MarshalAs(4)]
		public bool Initialized;
	}
}
