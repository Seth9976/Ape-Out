using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppTMPro
{
	// Token: 0x02000025 RID: 37
	[Serializable]
	public class TMP_FontFeatureTable : Object
	{
		// Token: 0x0600034B RID: 843 RVA: 0x00014EA4 File Offset: 0x000130A4
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontFeatureTable()
		{
			Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontFeatureTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr);
			TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_GlyphPairAdjustmentRecords");
			TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_GlyphPairAdjustmentRecordLookupDictionary");
			TMP_FontFeatureTable.NativeMethodInfoPtr_get_glyphPairAdjustmentRecords_Public_get_List_1_TMP_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100663669);
			TMP_FontFeatureTable.NativeMethodInfoPtr_set_glyphPairAdjustmentRecords_Public_set_Void_List_1_TMP_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100663670);
			TMP_FontFeatureTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100663671);
			TMP_FontFeatureTable.NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100663672);
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00014F4C File Offset: 0x0001314C
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00014F8C File Offset: 0x0001318C
		public unsafe List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.NativeMethodInfoPtr_get_glyphPairAdjustmentRecords_Public_get_List_1_TMP_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_GlyphPairAdjustmentRecord>>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.NativeMethodInfoPtr_set_glyphPairAdjustmentRecords_Public_set_Void_List_1_TMP_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00014FD0 File Offset: 0x000131D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 454030, RefRangeEnd = 454034, XrefRangeStart = 454019, XrefRangeEnd = 454030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_FontFeatureTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001500C File Offset: 0x0001320C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 454068, RefRangeEnd = 454070, XrefRangeStart = 454034, XrefRangeEnd = 454068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphPairAdjustmentRecords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003A9C File Offset: 0x00001C9C
		public TMP_FontFeatureTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00015040 File Offset: 0x00013240
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00003AA5 File Offset: 0x00001CA5
		public unsafe List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_GlyphPairAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00015070 File Offset: 0x00013270
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00003AC4 File Offset: 0x00001CC4
		public unsafe Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookupDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_GlyphPairAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontFeatureTable.NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookupDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookupDictionary;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphPairAdjustmentRecords_Public_get_List_1_TMP_GlyphPairAdjustmentRecord_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphPairAdjustmentRecords_Public_set_Void_List_1_TMP_GlyphPairAdjustmentRecord_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0;

		// Token: 0x02000089 RID: 137
		[ObfuscatedName("TMPro.TMP_FontFeatureTable+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F1B RID: 3867 RVA: 0x0003C91C File Offset: 0x0003AB1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr);
				TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, "<>9");
				TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, "<>9__6_0");
				TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, "<>9__6_1");
				TMP_FontFeatureTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, 100663674);
				TMP_FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_0_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, 100663675);
				TMP_FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_1_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr, 100663676);
			}

			// Token: 0x06000F1C RID: 3868 RVA: 0x0003C9C0 File Offset: 0x0003ABC0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontFeatureTable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F1D RID: 3869 RVA: 0x0003C9FC File Offset: 0x0003ABFC
			[CallerCount(0)]
			public unsafe uint _SortGlyphPairAdjustmentRecords_b__6_0(TMP_GlyphPairAdjustmentRecord s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_0_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F1E RID: 3870 RVA: 0x0003CA4C File Offset: 0x0003AC4C
			[CallerCount(0)]
			public unsafe uint _SortGlyphPairAdjustmentRecords_b__6_1(TMP_GlyphPairAdjustmentRecord s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontFeatureTable.__c.NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_1_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F1F RID: 3871 RVA: 0x00009241 File Offset: 0x00007441
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700058C RID: 1420
			// (get) Token: 0x06000F20 RID: 3872 RVA: 0x0003CA9C File Offset: 0x0003AC9C
			// (set) Token: 0x06000F21 RID: 3873 RVA: 0x0000924A File Offset: 0x0000744A
			public unsafe static TMP_FontFeatureTable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontFeatureTable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058D RID: 1421
			// (get) Token: 0x06000F22 RID: 3874 RVA: 0x0003CAC4 File Offset: 0x0003ACC4
			// (set) Token: 0x06000F23 RID: 3875 RVA: 0x0000925C File Offset: 0x0000745C
			public unsafe static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_GlyphPairAdjustmentRecord, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058E RID: 1422
			// (get) Token: 0x06000F24 RID: 3876 RVA: 0x0003CAEC File Offset: 0x0003ACEC
			// (set) Token: 0x06000F25 RID: 3877 RVA: 0x0000926E File Offset: 0x0000746E
			public unsafe static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_GlyphPairAdjustmentRecord, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontFeatureTable.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BE5 RID: 3045
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000BE6 RID: 3046
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04000BE7 RID: 3047
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04000BE8 RID: 3048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BE9 RID: 3049
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_0_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0;

			// Token: 0x04000BEA RID: 3050
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__6_1_Internal_UInt32_TMP_GlyphPairAdjustmentRecord_0;
		}
	}
}
