using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class SequencerPatch : ScriptableObject
	{
		// Token: 0x0600029C RID: 668 RVA: 0x0003AC34 File Offset: 0x00038E34
		// Note: this type is marked as 'beforefieldinit'.
		static SequencerPatch()
		{
			Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SequencerPatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr);
			SequencerPatch.NativeFieldInfoPtr_MainNoteSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, "MainNoteSequences");
			SequencerPatch.NativeFieldInfoPtr_NoteSequenceIntensityOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, "NoteSequenceIntensityOrder");
			SequencerPatch.NativeFieldInfoPtr_NoteSequenceIntensityPercentile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, "NoteSequenceIntensityPercentile");
			SequencerPatch.NativeFieldInfoPtr_ShuffleBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, "ShuffleBag");
			SequencerPatch.NativeFieldInfoPtr_BPMmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, "BPMmin");
			SequencerPatch.NativeFieldInfoPtr_BPMmax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, "BPMmax");
			SequencerPatch.NativeMethodInfoPtr_Forbes_Private_Double_List_1_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, 100663418);
			SequencerPatch.NativeMethodInfoPtr_BuildIntensitySimilarityArrays_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, 100663419);
			SequencerPatch.NativeMethodInfoPtr_BuildBinaryVectorForNoteRange_Private_List_1_Int32_NoteSequence_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, 100663420);
			SequencerPatch.NativeMethodInfoPtr_BuildBinaryVectorForDrumLine_Private_List_1_Int32_NoteSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, 100663421);
			SequencerPatch.NativeMethodInfoPtr_BuildBinaryVectorForNormalDrums_Private_List_1_Int32_NoteSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, 100663422);
			SequencerPatch.NativeMethodInfoPtr_CalculateSimilarity_Public_Void_List_1_List_1_IndexValuePair_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, 100663423);
			SequencerPatch.NativeMethodInfoPtr_BuildIntensityOrder_Public_List_1_List_1_IndexValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, 100663424);
			SequencerPatch.NativeMethodInfoPtr_percentRank_Private_Single_Il2CppStructArray_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, 100663425);
			SequencerPatch.NativeMethodInfoPtr_percentRank_Private_Single_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, 100663426);
			SequencerPatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, 100663427);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0003ADA4 File Offset: 0x00038FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32226, RefRangeEnd = 32227, XrefRangeStart = 32221, XrefRangeEnd = 32226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double Forbes(List<int> x, List<int> y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.NativeMethodInfoPtr_Forbes_Private_Double_List_1_Int32_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0003AE04 File Offset: 0x00039004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32227, XrefRangeEnd = 32229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildIntensitySimilarityArrays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.NativeMethodInfoPtr_BuildIntensitySimilarityArrays_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0003AE38 File Offset: 0x00039038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 32248, RefRangeEnd = 32250, XrefRangeStart = 32229, XrefRangeEnd = 32248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> BuildBinaryVectorForNoteRange(NoteSequence nSeq, int startingNote, int endingNote, int startingBeat, int endingBeat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nSeq);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startingNote;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endingNote;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startingBeat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endingBeat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.NativeMethodInfoPtr_BuildBinaryVectorForNoteRange_Private_List_1_Int32_NoteSequence_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0003AEC0 File Offset: 0x000390C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32250, XrefRangeEnd = 32273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> BuildBinaryVectorForDrumLine(NoteSequence nSeq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nSeq);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.NativeMethodInfoPtr_BuildBinaryVectorForDrumLine_Private_List_1_Int32_NoteSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0003AF10 File Offset: 0x00039110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32273, XrefRangeEnd = 32329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> BuildBinaryVectorForNormalDrums(NoteSequence nSeq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nSeq);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.NativeMethodInfoPtr_BuildBinaryVectorForNormalDrums_Private_List_1_Int32_NoteSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0003AF60 File Offset: 0x00039160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32629, RefRangeEnd = 32630, XrefRangeStart = 32329, XrefRangeEnd = 32629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateSimilarity(List<List<SequencerPatch.IndexValuePair>> intensityList, bool isCongas = false, bool isDrumLine = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(intensityList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCongas;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDrumLine;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.NativeMethodInfoPtr_CalculateSimilarity_Public_Void_List_1_List_1_IndexValuePair_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0003AFC0 File Offset: 0x000391C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32800, RefRangeEnd = 32801, XrefRangeStart = 32630, XrefRangeEnd = 32800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<List<SequencerPatch.IndexValuePair>> BuildIntensityOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.NativeMethodInfoPtr_BuildIntensityOrder_Public_List_1_List_1_IndexValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<SequencerPatch.IndexValuePair>>>(intPtr3) : null;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0003B000 File Offset: 0x00039200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 32803, RefRangeEnd = 32805, XrefRangeStart = 32801, XrefRangeEnd = 32803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float percentRank(Il2CppStructArray<float> array, float n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.NativeMethodInfoPtr_percentRank_Private_Single_Il2CppStructArray_1_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0003B05C File Offset: 0x0003925C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32805, XrefRangeEnd = 32807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float percentRank(Il2CppStructArray<int> array, int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.NativeMethodInfoPtr_percentRank_Private_Single_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0003B0B8 File Offset: 0x000392B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32807, XrefRangeEnd = 32811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequencerPatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00004007 File Offset: 0x00002207
		public SequencerPatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0003B0F4 File Offset: 0x000392F4
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00004010 File Offset: 0x00002210
		public unsafe Il2CppReferenceArray<NoteSequence> MainNoteSequences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_MainNoteSequences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NoteSequence>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_MainNoteSequences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0003B124 File Offset: 0x00039324
		// (set) Token: 0x060002AB RID: 683 RVA: 0x0000402F File Offset: 0x0000222F
		public unsafe Il2CppStructArray<int> NoteSequenceIntensityOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_NoteSequenceIntensityOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_NoteSequenceIntensityOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0003B154 File Offset: 0x00039354
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0000404E File Offset: 0x0000224E
		public unsafe Il2CppStructArray<float> NoteSequenceIntensityPercentile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_NoteSequenceIntensityPercentile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_NoteSequenceIntensityPercentile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0003B184 File Offset: 0x00039384
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0000406D File Offset: 0x0000226D
		public unsafe ShuffleBag ShuffleBag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_ShuffleBag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShuffleBag>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_ShuffleBag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0003B1B4 File Offset: 0x000393B4
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x0000408C File Offset: 0x0000228C
		public unsafe int BPMmin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_BPMmin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_BPMmin)) = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0003B1DC File Offset: 0x000393DC
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x000040A7 File Offset: 0x000022A7
		public unsafe int BPMmax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_BPMmax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.NativeFieldInfoPtr_BPMmax)) = value;
			}
		}

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_MainNoteSequences;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_NoteSequenceIntensityOrder;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_NoteSequenceIntensityPercentile;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_ShuffleBag;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_BPMmin;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_BPMmax;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_Forbes_Private_Double_List_1_Int32_List_1_Int32_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_BuildIntensitySimilarityArrays_Public_Void_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_BuildBinaryVectorForNoteRange_Private_List_1_Int32_NoteSequence_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_BuildBinaryVectorForDrumLine_Private_List_1_Int32_NoteSequence_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_BuildBinaryVectorForNormalDrums_Private_List_1_Int32_NoteSequence_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSimilarity_Public_Void_List_1_List_1_IndexValuePair_Boolean_Boolean_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_BuildIntensityOrder_Public_List_1_List_1_IndexValuePair_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_percentRank_Private_Single_Il2CppStructArray_1_Single_Single_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_percentRank_Private_Single_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200029A RID: 666
		public class IndexValuePair : global::Il2CppSystem.Object
		{
			// Token: 0x06004A16 RID: 18966 RVA: 0x00112E84 File Offset: 0x00111084
			// Note: this type is marked as 'beforefieldinit'.
			static IndexValuePair()
			{
				Il2CppClassPointerStore<SequencerPatch.IndexValuePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, "IndexValuePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPatch.IndexValuePair>.NativeClassPtr);
				SequencerPatch.IndexValuePair.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch.IndexValuePair>.NativeClassPtr, "Index");
				SequencerPatch.IndexValuePair.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch.IndexValuePair>.NativeClassPtr, "Value");
				SequencerPatch.IndexValuePair.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch.IndexValuePair>.NativeClassPtr, 100663428);
			}

			// Token: 0x06004A17 RID: 18967 RVA: 0x00112EEC File Offset: 0x001110EC
			[CallerCount(0)]
			public unsafe IndexValuePair(int index, float value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPatch.IndexValuePair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.IndexValuePair.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A18 RID: 18968 RVA: 0x0002BA46 File Offset: 0x00029C46
			public IndexValuePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AF5 RID: 6901
			// (get) Token: 0x06004A19 RID: 18969 RVA: 0x00112F44 File Offset: 0x00111144
			// (set) Token: 0x06004A1A RID: 18970 RVA: 0x0002BA4F File Offset: 0x00029C4F
			public unsafe int Index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.IndexValuePair.NativeFieldInfoPtr_Index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.IndexValuePair.NativeFieldInfoPtr_Index)) = value;
				}
			}

			// Token: 0x17001AF6 RID: 6902
			// (get) Token: 0x06004A1B RID: 18971 RVA: 0x00112F6C File Offset: 0x0011116C
			// (set) Token: 0x06004A1C RID: 18972 RVA: 0x0002BA6A File Offset: 0x00029C6A
			public unsafe float Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.IndexValuePair.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerPatch.IndexValuePair.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x04003042 RID: 12354
			private static readonly IntPtr NativeFieldInfoPtr_Index;

			// Token: 0x04003043 RID: 12355
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04003044 RID: 12356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;
		}

		// Token: 0x0200029B RID: 667
		[ObfuscatedName("SequencerPatch+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004A1D RID: 18973 RVA: 0x00112F94 File Offset: 0x00111194
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPatch>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr);
				SequencerPatch.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, "<>9");
				SequencerPatch.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, "<>9__12_0");
				SequencerPatch.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, "<>9__12_1");
				SequencerPatch.__c.NativeFieldInfoPtr___9__12_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, "<>9__12_2");
				SequencerPatch.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, "<>9__13_0");
				SequencerPatch.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, "<>9__13_1");
				SequencerPatch.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, "<>9__13_2");
				SequencerPatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, 100663430);
				SequencerPatch.__c.NativeMethodInfoPtr__CalculateSimilarity_b__12_0_Internal_Single_IndexValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, 100663431);
				SequencerPatch.__c.NativeMethodInfoPtr__CalculateSimilarity_b__12_1_Internal_Single_IndexValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, 100663432);
				SequencerPatch.__c.NativeMethodInfoPtr__CalculateSimilarity_b__12_2_Internal_Int32_IndexValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, 100663433);
				SequencerPatch.__c.NativeMethodInfoPtr__BuildIntensityOrder_b__13_0_Internal_Single_IndexValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, 100663434);
				SequencerPatch.__c.NativeMethodInfoPtr__BuildIntensityOrder_b__13_1_Internal_Int32_IndexValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, 100663435);
				SequencerPatch.__c.NativeMethodInfoPtr__BuildIntensityOrder_b__13_2_Internal_Single_IndexValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr, 100663436);
			}

			// Token: 0x06004A1E RID: 18974 RVA: 0x001130D8 File Offset: 0x001112D8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPatch.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A1F RID: 18975 RVA: 0x00113114 File Offset: 0x00111314
			[CallerCount(0)]
			public unsafe float _CalculateSimilarity_b__12_0(SequencerPatch.IndexValuePair o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.__c.NativeMethodInfoPtr__CalculateSimilarity_b__12_0_Internal_Single_IndexValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A20 RID: 18976 RVA: 0x00113164 File Offset: 0x00111364
			[CallerCount(0)]
			public unsafe float _CalculateSimilarity_b__12_1(SequencerPatch.IndexValuePair o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.__c.NativeMethodInfoPtr__CalculateSimilarity_b__12_1_Internal_Single_IndexValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A21 RID: 18977 RVA: 0x001131B4 File Offset: 0x001113B4
			[CallerCount(0)]
			public unsafe int _CalculateSimilarity_b__12_2(SequencerPatch.IndexValuePair o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.__c.NativeMethodInfoPtr__CalculateSimilarity_b__12_2_Internal_Int32_IndexValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A22 RID: 18978 RVA: 0x00113204 File Offset: 0x00111404
			[CallerCount(0)]
			public unsafe float _BuildIntensityOrder_b__13_0(SequencerPatch.IndexValuePair o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.__c.NativeMethodInfoPtr__BuildIntensityOrder_b__13_0_Internal_Single_IndexValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A23 RID: 18979 RVA: 0x00113254 File Offset: 0x00111454
			[CallerCount(0)]
			public unsafe int _BuildIntensityOrder_b__13_1(SequencerPatch.IndexValuePair o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.__c.NativeMethodInfoPtr__BuildIntensityOrder_b__13_1_Internal_Int32_IndexValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A24 RID: 18980 RVA: 0x001132A4 File Offset: 0x001114A4
			[CallerCount(0)]
			public unsafe float _BuildIntensityOrder_b__13_2(SequencerPatch.IndexValuePair o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerPatch.__c.NativeMethodInfoPtr__BuildIntensityOrder_b__13_2_Internal_Single_IndexValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A25 RID: 18981 RVA: 0x0002BA85 File Offset: 0x00029C85
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AF7 RID: 6903
			// (get) Token: 0x06004A26 RID: 18982 RVA: 0x001132F4 File Offset: 0x001114F4
			// (set) Token: 0x06004A27 RID: 18983 RVA: 0x0002BA8E File Offset: 0x00029C8E
			public unsafe static SequencerPatch.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequencerPatch.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequencerPatch.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequencerPatch.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF8 RID: 6904
			// (get) Token: 0x06004A28 RID: 18984 RVA: 0x0011331C File Offset: 0x0011151C
			// (set) Token: 0x06004A29 RID: 18985 RVA: 0x0002BAA0 File Offset: 0x00029CA0
			public unsafe static Func<SequencerPatch.IndexValuePair, float> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequencerPatch.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SequencerPatch.IndexValuePair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequencerPatch.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF9 RID: 6905
			// (get) Token: 0x06004A2A RID: 18986 RVA: 0x00113344 File Offset: 0x00111544
			// (set) Token: 0x06004A2B RID: 18987 RVA: 0x0002BAB2 File Offset: 0x00029CB2
			public unsafe static Func<SequencerPatch.IndexValuePair, float> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequencerPatch.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SequencerPatch.IndexValuePair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequencerPatch.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFA RID: 6906
			// (get) Token: 0x06004A2C RID: 18988 RVA: 0x0011336C File Offset: 0x0011156C
			// (set) Token: 0x06004A2D RID: 18989 RVA: 0x0002BAC4 File Offset: 0x00029CC4
			public unsafe static Func<SequencerPatch.IndexValuePair, int> __9__12_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequencerPatch.__c.NativeFieldInfoPtr___9__12_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SequencerPatch.IndexValuePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequencerPatch.__c.NativeFieldInfoPtr___9__12_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFB RID: 6907
			// (get) Token: 0x06004A2E RID: 18990 RVA: 0x00113394 File Offset: 0x00111594
			// (set) Token: 0x06004A2F RID: 18991 RVA: 0x0002BAD6 File Offset: 0x00029CD6
			public unsafe static Func<SequencerPatch.IndexValuePair, float> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequencerPatch.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SequencerPatch.IndexValuePair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequencerPatch.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFC RID: 6908
			// (get) Token: 0x06004A30 RID: 18992 RVA: 0x001133BC File Offset: 0x001115BC
			// (set) Token: 0x06004A31 RID: 18993 RVA: 0x0002BAE8 File Offset: 0x00029CE8
			public unsafe static Func<SequencerPatch.IndexValuePair, int> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequencerPatch.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SequencerPatch.IndexValuePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequencerPatch.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFD RID: 6909
			// (get) Token: 0x06004A32 RID: 18994 RVA: 0x001133E4 File Offset: 0x001115E4
			// (set) Token: 0x06004A33 RID: 18995 RVA: 0x0002BAFA File Offset: 0x00029CFA
			public unsafe static Func<SequencerPatch.IndexValuePair, float> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequencerPatch.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SequencerPatch.IndexValuePair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequencerPatch.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003045 RID: 12357
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003046 RID: 12358
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04003047 RID: 12359
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04003048 RID: 12360
			private static readonly IntPtr NativeFieldInfoPtr___9__12_2;

			// Token: 0x04003049 RID: 12361
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400304A RID: 12362
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x0400304B RID: 12363
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x0400304C RID: 12364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400304D RID: 12365
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSimilarity_b__12_0_Internal_Single_IndexValuePair_0;

			// Token: 0x0400304E RID: 12366
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSimilarity_b__12_1_Internal_Single_IndexValuePair_0;

			// Token: 0x0400304F RID: 12367
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSimilarity_b__12_2_Internal_Int32_IndexValuePair_0;

			// Token: 0x04003050 RID: 12368
			private static readonly IntPtr NativeMethodInfoPtr__BuildIntensityOrder_b__13_0_Internal_Single_IndexValuePair_0;

			// Token: 0x04003051 RID: 12369
			private static readonly IntPtr NativeMethodInfoPtr__BuildIntensityOrder_b__13_1_Internal_Int32_IndexValuePair_0;

			// Token: 0x04003052 RID: 12370
			private static readonly IntPtr NativeMethodInfoPtr__BuildIntensityOrder_b__13_2_Internal_Single_IndexValuePair_0;
		}
	}
}
