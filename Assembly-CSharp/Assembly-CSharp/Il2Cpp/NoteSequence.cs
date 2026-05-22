using System;
using Il2CppAudioHelm;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000003 RID: 3
	[Serializable]
	public class NoteSequence : ScriptableObject
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00034B50 File Offset: 0x00032D50
		// Note: this type is marked as 'beforefieldinit'.
		static NoteSequence()
		{
			Il2CppClassPointerStore<NoteSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NoteSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr);
			NoteSequence.NativeFieldInfoPtr_NoteRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "NoteRows");
			NoteSequence.NativeFieldInfoPtr_midiFileOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "midiFileOrigin");
			NoteSequence.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "length");
			NoteSequence.NativeFieldInfoPtr_noteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "noteCount");
			NoteSequence.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "intensity");
			NoteSequence.NativeFieldInfoPtr_noteCountPerQuarter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "noteCountPerQuarter");
			NoteSequence.NativeFieldInfoPtr_flaggedByGabe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "flaggedByGabe");
			NoteSequence.NativeFieldInfoPtr_similarityList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "similarityList");
			NoteSequence.NativeFieldInfoPtr_similarityOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "similarityOrder");
			NoteSequence.NativeFieldInfoPtr_simlarityIntensityArrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "simlarityIntensityArrays");
			NoteSequence.NativeFieldInfoPtr_similarityIntensityIndexedShuffleBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "similarityIntensityIndexedShuffleBags");
			NoteSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, 100663310);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00034C70 File Offset: 0x00032E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30313, XrefRangeEnd = 30334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteSequence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020FF File Offset: 0x000002FF
		public NoteSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00034CAC File Offset: 0x00032EAC
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002108 File Offset: 0x00000308
		public unsafe Il2CppReferenceArray<NoteRow> NoteRows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_NoteRows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NoteRow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_NoteRows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00034CDC File Offset: 0x00032EDC
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002127 File Offset: 0x00000327
		public unsafe string midiFileOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_midiFileOrigin);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_midiFileOrigin), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00034D04 File Offset: 0x00032F04
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002146 File Offset: 0x00000346
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00034D2C File Offset: 0x00032F2C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002161 File Offset: 0x00000361
		public unsafe int noteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_noteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_noteCount)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00034D54 File Offset: 0x00032F54
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000217C File Offset: 0x0000037C
		public unsafe int intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_intensity)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00034D7C File Offset: 0x00032F7C
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002197 File Offset: 0x00000397
		public unsafe Il2CppStructArray<int> noteCountPerQuarter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_noteCountPerQuarter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_noteCountPerQuarter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00034DAC File Offset: 0x00032FAC
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000021B6 File Offset: 0x000003B6
		public unsafe bool flaggedByGabe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_flaggedByGabe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_flaggedByGabe)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00034DD4 File Offset: 0x00032FD4
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000021D1 File Offset: 0x000003D1
		public unsafe Il2CppReferenceArray<Il2CppStructArray<float>> similarityList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_similarityList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<float>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_similarityList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00034E04 File Offset: 0x00033004
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000021F0 File Offset: 0x000003F0
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> similarityOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_similarityOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_similarityOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00034E34 File Offset: 0x00033034
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000220F File Offset: 0x0000040F
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<Il2CppReferenceArray<Il2CppStructArray<int>>>> simlarityIntensityArrays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_simlarityIntensityArrays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<Il2CppReferenceArray<Il2CppStructArray<int>>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_simlarityIntensityArrays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00034E64 File Offset: 0x00033064
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0000222E File Offset: 0x0000042E
		public unsafe Il2CppReferenceArray<NoteSequence.similarityEntry> similarityIntensityIndexedShuffleBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_similarityIntensityIndexedShuffleBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NoteSequence.similarityEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.NativeFieldInfoPtr_similarityIntensityIndexedShuffleBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_NoteRows;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_midiFileOrigin;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_noteCount;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_noteCountPerQuarter;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_flaggedByGabe;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_similarityList;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_similarityOrder;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_simlarityIntensityArrays;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_similarityIntensityIndexedShuffleBags;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000290 RID: 656
		[Serializable]
		public sealed class intensityEntry : ValueType
		{
			// Token: 0x060049A9 RID: 18857 RVA: 0x0002B5A1 File Offset: 0x000297A1
			// Note: this type is marked as 'beforefieldinit'.
			static intensityEntry()
			{
				Il2CppClassPointerStore<NoteSequence.intensityEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "intensityEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteSequence.intensityEntry>.NativeClassPtr);
				NoteSequence.intensityEntry.NativeFieldInfoPtr_ints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence.intensityEntry>.NativeClassPtr, "ints");
			}

			// Token: 0x060049AA RID: 18858 RVA: 0x0002B5D5 File Offset: 0x000297D5
			public intensityEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060049AB RID: 18859 RVA: 0x0002B5DE File Offset: 0x000297DE
			public intensityEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteSequence.intensityEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17001ACB RID: 6859
			// (get) Token: 0x060049AC RID: 18860 RVA: 0x00111D70 File Offset: 0x0010FF70
			// (set) Token: 0x060049AD RID: 18861 RVA: 0x0002B5F0 File Offset: 0x000297F0
			public unsafe Il2CppReferenceArray<ShuffleBag> ints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.intensityEntry.NativeFieldInfoPtr_ints);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ShuffleBag>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.intensityEntry.NativeFieldInfoPtr_ints), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FB0 RID: 12208
			private static readonly IntPtr NativeFieldInfoPtr_ints;
		}

		// Token: 0x02000291 RID: 657
		[Serializable]
		public sealed class similarityEntry : ValueType
		{
			// Token: 0x060049AE RID: 18862 RVA: 0x0002B60F File Offset: 0x0002980F
			// Note: this type is marked as 'beforefieldinit'.
			static similarityEntry()
			{
				Il2CppClassPointerStore<NoteSequence.similarityEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteSequence>.NativeClassPtr, "similarityEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteSequence.similarityEntry>.NativeClassPtr);
				NoteSequence.similarityEntry.NativeFieldInfoPtr_sims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteSequence.similarityEntry>.NativeClassPtr, "sims");
			}

			// Token: 0x060049AF RID: 18863 RVA: 0x0002B643 File Offset: 0x00029843
			public similarityEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060049B0 RID: 18864 RVA: 0x0002B64C File Offset: 0x0002984C
			public similarityEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteSequence.similarityEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17001ACC RID: 6860
			// (get) Token: 0x060049B1 RID: 18865 RVA: 0x00111DA0 File Offset: 0x0010FFA0
			// (set) Token: 0x060049B2 RID: 18866 RVA: 0x0002B65E File Offset: 0x0002985E
			public unsafe Il2CppReferenceArray<NoteSequence.intensityEntry> sims
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.similarityEntry.NativeFieldInfoPtr_sims);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NoteSequence.intensityEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteSequence.similarityEntry.NativeFieldInfoPtr_sims), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FB1 RID: 12209
			private static readonly IntPtr NativeFieldInfoPtr_sims;
		}
	}
}
