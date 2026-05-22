using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001C6 RID: 454
	public sealed class MidiNoteConverter : Object
	{
		// Token: 0x060015F9 RID: 5625 RVA: 0x0006434C File Offset: 0x0006254C
		// Note: this type is marked as 'beforefieldinit'.
		static MidiNoteConverter()
		{
			Il2CppClassPointerStore<MidiNoteConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiNoteConverter");
			MidiNoteConverter.NativeFieldInfoPtr_NoteIDMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiNoteConverter>.NativeClassPtr, "NoteIDMinValue");
			MidiNoteConverter.NativeFieldInfoPtr_NoteIDMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiNoteConverter>.NativeClassPtr, "NoteIDMaxValue");
			MidiNoteConverter.NativeFieldInfoPtr_NoteToFrequencyTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiNoteConverter>.NativeClassPtr, "NoteToFrequencyTable");
			MidiNoteConverter.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiNoteConverter>.NativeClassPtr, 100666418);
			MidiNoteConverter.NativeMethodInfoPtr_NoteToFrequency_Public_Static_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiNoteConverter>.NativeClassPtr, 100666419);
			MidiNoteConverter.NativeMethodInfoPtr_FrequencyToNote_Public_Static_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiNoteConverter>.NativeClassPtr, 100666420);
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x000643EC File Offset: 0x000625EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiNoteConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiNoteConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiNoteConverter.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00064428 File Offset: 0x00062628
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 16947, RefRangeEnd = 16950, XrefRangeStart = 16943, XrefRangeEnd = 16947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double NoteToFrequency(int noteID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref noteID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiNoteConverter.NativeMethodInfoPtr_NoteToFrequency_Public_Static_Double_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00064468 File Offset: 0x00062668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16950, XrefRangeEnd = 16958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FrequencyToNote(double frequency)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frequency;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiNoteConverter.NativeMethodInfoPtr_FrequencyToNote_Public_Static_Int32_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00008CDA File Offset: 0x00006EDA
		public MidiNoteConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x000644A8 File Offset: 0x000626A8
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x00008CE3 File Offset: 0x00006EE3
		public unsafe static int NoteIDMinValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiNoteConverter.NativeFieldInfoPtr_NoteIDMinValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiNoteConverter.NativeFieldInfoPtr_NoteIDMinValue, (void*)(&value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x000644C4 File Offset: 0x000626C4
		// (set) Token: 0x06001601 RID: 5633 RVA: 0x00008CF1 File Offset: 0x00006EF1
		public unsafe static int NoteIDMaxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiNoteConverter.NativeFieldInfoPtr_NoteIDMaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiNoteConverter.NativeFieldInfoPtr_NoteIDMaxValue, (void*)(&value));
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x000644E0 File Offset: 0x000626E0
		// (set) Token: 0x06001603 RID: 5635 RVA: 0x00008CFF File Offset: 0x00006EFF
		public unsafe static Il2CppStructArray<double> NoteToFrequencyTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MidiNoteConverter.NativeFieldInfoPtr_NoteToFrequencyTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiNoteConverter.NativeFieldInfoPtr_NoteToFrequencyTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeFieldInfoPtr_NoteIDMinValue;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeFieldInfoPtr_NoteIDMaxValue;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeFieldInfoPtr_NoteToFrequencyTable;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeMethodInfoPtr_NoteToFrequency_Public_Static_Double_Int32_0;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeMethodInfoPtr_FrequencyToNote_Public_Static_Int32_Double_0;
	}
}
