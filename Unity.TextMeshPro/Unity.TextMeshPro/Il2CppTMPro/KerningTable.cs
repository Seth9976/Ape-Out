using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppTMPro
{
	// Token: 0x02000022 RID: 34
	[Serializable]
	public class KerningTable : Object
	{
		// Token: 0x06000329 RID: 809 RVA: 0x000144B8 File Offset: 0x000126B8
		// Note: this type is marked as 'beforefieldinit'.
		static KerningTable()
		{
			Il2CppClassPointerStore<KerningTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "KerningTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable>.NativeClassPtr);
			KerningTable.NativeFieldInfoPtr_kerningPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "kerningPairs");
			KerningTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663640);
			KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663641);
			KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Int32_UInt32_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663642);
			KerningTable.NativeMethodInfoPtr_AddGlyphPairAdjustmentRecord_Public_Int32_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663643);
			KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663644);
			KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663645);
			KerningTable.NativeMethodInfoPtr_SortKerningPairs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663646);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00014588 File Offset: 0x00012788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453584, XrefRangeEnd = 453590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KerningTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000145C4 File Offset: 0x000127C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453590, XrefRangeEnd = 453608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKerningPair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000145F8 File Offset: 0x000127F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453608, XrefRangeEnd = 453621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKerningPair(uint first, uint second, float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Int32_UInt32_UInt32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00014660 File Offset: 0x00012860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453621, XrefRangeEnd = 453634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstAdjustments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondAdjustments;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_AddGlyphPairAdjustmentRecord_Public_Int32_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000146D4 File Offset: 0x000128D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453634, XrefRangeEnd = 453648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKerningPair(int left, int right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00014720 File Offset: 0x00012920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453648, XrefRangeEnd = 453652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKerningPair(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00014760 File Offset: 0x00012960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453652, XrefRangeEnd = 453686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortKerningPairs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_SortKerningPairs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003A1E File Offset: 0x00001C1E
		public KerningTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00014794 File Offset: 0x00012994
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00003A27 File Offset: 0x00001C27
		public unsafe List<KerningPair> kerningPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.NativeFieldInfoPtr_kerningPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KerningPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.NativeFieldInfoPtr_kerningPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeFieldInfoPtr_kerningPairs;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_AddKerningPair_Public_Void_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_AddKerningPair_Public_Int32_UInt32_UInt32_Single_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_AddGlyphPairAdjustmentRecord_Public_Int32_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_Int32_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_SortKerningPairs_Public_Void_0;

		// Token: 0x02000085 RID: 133
		[ObfuscatedName("TMPro.KerningTable+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06000EF8 RID: 3832 RVA: 0x0003C31C File Offset: 0x0003A51C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr);
				KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, "first");
				KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, "second");
				KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, 100663647);
				KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__AddKerningPair_b__0_Internal_Boolean_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, 100663648);
			}

			// Token: 0x06000EF9 RID: 3833 RVA: 0x0003C398 File Offset: 0x0003A598
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EFA RID: 3834 RVA: 0x0003C3D4 File Offset: 0x0003A5D4
			[CallerCount(0)]
			public unsafe bool _AddKerningPair_b__0(KerningPair item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__AddKerningPair_b__0_Internal_Boolean_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000EFB RID: 3835 RVA: 0x00009145 File Offset: 0x00007345
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000583 RID: 1411
			// (get) Token: 0x06000EFC RID: 3836 RVA: 0x0003C424 File Offset: 0x0003A624
			// (set) Token: 0x06000EFD RID: 3837 RVA: 0x0000914E File Offset: 0x0000734E
			public unsafe uint first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_first);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_first)) = value;
				}
			}

			// Token: 0x17000584 RID: 1412
			// (get) Token: 0x06000EFE RID: 3838 RVA: 0x0003C44C File Offset: 0x0003A64C
			// (set) Token: 0x06000EFF RID: 3839 RVA: 0x00009169 File Offset: 0x00007369
			public unsafe uint second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_second);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_second)) = value;
				}
			}

			// Token: 0x04000BD3 RID: 3027
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x04000BD4 RID: 3028
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000BD5 RID: 3029
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BD6 RID: 3030
			private static readonly IntPtr NativeMethodInfoPtr__AddKerningPair_b__0_Internal_Boolean_KerningPair_0;
		}

		// Token: 0x02000086 RID: 134
		[ObfuscatedName("TMPro.KerningTable+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06000F00 RID: 3840 RVA: 0x0003C474 File Offset: 0x0003A674
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr);
				KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, "first");
				KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, "second");
				KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, 100663649);
				KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__AddGlyphPairAdjustmentRecord_b__0_Internal_Boolean_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, 100663650);
			}

			// Token: 0x06000F01 RID: 3841 RVA: 0x0003C4F0 File Offset: 0x0003A6F0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F02 RID: 3842 RVA: 0x0003C52C File Offset: 0x0003A72C
			[CallerCount(0)]
			public unsafe bool _AddGlyphPairAdjustmentRecord_b__0(KerningPair item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__AddGlyphPairAdjustmentRecord_b__0_Internal_Boolean_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F03 RID: 3843 RVA: 0x00009184 File Offset: 0x00007384
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000585 RID: 1413
			// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0003C57C File Offset: 0x0003A77C
			// (set) Token: 0x06000F05 RID: 3845 RVA: 0x0000918D File Offset: 0x0000738D
			public unsafe uint first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_first);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_first)) = value;
				}
			}

			// Token: 0x17000586 RID: 1414
			// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0003C5A4 File Offset: 0x0003A7A4
			// (set) Token: 0x06000F07 RID: 3847 RVA: 0x000091A8 File Offset: 0x000073A8
			public unsafe uint second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_second);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_second)) = value;
				}
			}

			// Token: 0x04000BD7 RID: 3031
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x04000BD8 RID: 3032
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000BD9 RID: 3033
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BDA RID: 3034
			private static readonly IntPtr NativeMethodInfoPtr__AddGlyphPairAdjustmentRecord_b__0_Internal_Boolean_KerningPair_0;
		}

		// Token: 0x02000087 RID: 135
		[ObfuscatedName("TMPro.KerningTable+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06000F08 RID: 3848 RVA: 0x0003C5CC File Offset: 0x0003A7CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr);
				KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, "left");
				KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, "right");
				KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, 100663651);
				KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__RemoveKerningPair_b__0_Internal_Boolean_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, 100663652);
			}

			// Token: 0x06000F09 RID: 3849 RVA: 0x0003C648 File Offset: 0x0003A848
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F0A RID: 3850 RVA: 0x0003C684 File Offset: 0x0003A884
			[CallerCount(0)]
			public unsafe bool _RemoveKerningPair_b__0(KerningPair item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__RemoveKerningPair_b__0_Internal_Boolean_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F0B RID: 3851 RVA: 0x000091C3 File Offset: 0x000073C3
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000587 RID: 1415
			// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0003C6D4 File Offset: 0x0003A8D4
			// (set) Token: 0x06000F0D RID: 3853 RVA: 0x000091CC File Offset: 0x000073CC
			public unsafe int left
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_left);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_left)) = value;
				}
			}

			// Token: 0x17000588 RID: 1416
			// (get) Token: 0x06000F0E RID: 3854 RVA: 0x0003C6FC File Offset: 0x0003A8FC
			// (set) Token: 0x06000F0F RID: 3855 RVA: 0x000091E7 File Offset: 0x000073E7
			public unsafe int right
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_right);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_right)) = value;
				}
			}

			// Token: 0x04000BDB RID: 3035
			private static readonly IntPtr NativeFieldInfoPtr_left;

			// Token: 0x04000BDC RID: 3036
			private static readonly IntPtr NativeFieldInfoPtr_right;

			// Token: 0x04000BDD RID: 3037
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BDE RID: 3038
			private static readonly IntPtr NativeMethodInfoPtr__RemoveKerningPair_b__0_Internal_Boolean_KerningPair_0;
		}

		// Token: 0x02000088 RID: 136
		[ObfuscatedName("TMPro.KerningTable+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F10 RID: 3856 RVA: 0x0003C724 File Offset: 0x0003A924
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr);
				KerningTable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, "<>9");
				KerningTable.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, "<>9__7_0");
				KerningTable.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, "<>9__7_1");
				KerningTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, 100663654);
				KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_0_Internal_UInt32_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, 100663655);
				KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_1_Internal_UInt32_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, 100663656);
			}

			// Token: 0x06000F11 RID: 3857 RVA: 0x0003C7C8 File Offset: 0x0003A9C8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F12 RID: 3858 RVA: 0x0003C804 File Offset: 0x0003AA04
			[CallerCount(0)]
			public unsafe uint _SortKerningPairs_b__7_0(KerningPair s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_0_Internal_UInt32_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F13 RID: 3859 RVA: 0x0003C854 File Offset: 0x0003AA54
			[CallerCount(0)]
			public unsafe uint _SortKerningPairs_b__7_1(KerningPair s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_1_Internal_UInt32_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F14 RID: 3860 RVA: 0x00009202 File Offset: 0x00007402
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000589 RID: 1417
			// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
			// (set) Token: 0x06000F16 RID: 3862 RVA: 0x0000920B File Offset: 0x0000740B
			public unsafe static KerningTable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KerningTable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KerningTable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KerningTable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058A RID: 1418
			// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0003C8CC File Offset: 0x0003AACC
			// (set) Token: 0x06000F18 RID: 3864 RVA: 0x0000921D File Offset: 0x0000741D
			public unsafe static Func<KerningPair, uint> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KerningTable.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KerningPair, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KerningTable.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058B RID: 1419
			// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0003C8F4 File Offset: 0x0003AAF4
			// (set) Token: 0x06000F1A RID: 3866 RVA: 0x0000922F File Offset: 0x0000742F
			public unsafe static Func<KerningPair, uint> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KerningTable.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KerningPair, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KerningTable.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BDF RID: 3039
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000BE0 RID: 3040
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04000BE1 RID: 3041
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04000BE2 RID: 3042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BE3 RID: 3043
			private static readonly IntPtr NativeMethodInfoPtr__SortKerningPairs_b__7_0_Internal_UInt32_KerningPair_0;

			// Token: 0x04000BE4 RID: 3044
			private static readonly IntPtr NativeMethodInfoPtr__SortKerningPairs_b__7_1_Internal_UInt32_KerningPair_0;
		}
	}
}
