using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x02000021 RID: 33
	[Serializable]
	public class KerningPair : Object
	{
		// Token: 0x0600030E RID: 782 RVA: 0x00013F14 File Offset: 0x00012114
		// Note: this type is marked as 'beforefieldinit'.
		static KerningPair()
		{
			Il2CppClassPointerStore<KerningPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "KerningPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningPair>.NativeClassPtr);
			KerningPair.NativeFieldInfoPtr_m_FirstGlyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_FirstGlyph");
			KerningPair.NativeFieldInfoPtr_m_FirstGlyphAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_FirstGlyphAdjustments");
			KerningPair.NativeFieldInfoPtr_m_SecondGlyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_SecondGlyph");
			KerningPair.NativeFieldInfoPtr_m_SecondGlyphAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_SecondGlyphAdjustments");
			KerningPair.NativeFieldInfoPtr_xOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "xOffset");
			KerningPair.NativeFieldInfoPtr_empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "empty");
			KerningPair.NativeFieldInfoPtr_m_IgnoreSpacingAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_IgnoreSpacingAdjustments");
			KerningPair.NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663628);
			KerningPair.NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663629);
			KerningPair.NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663630);
			KerningPair.NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663631);
			KerningPair.NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663632);
			KerningPair.NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663633);
			KerningPair.NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663634);
			KerningPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663635);
			KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663636);
			KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663637);
			KerningPair.NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663638);
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600030F RID: 783 RVA: 0x000140AC File Offset: 0x000122AC
		// (set) Token: 0x06000310 RID: 784 RVA: 0x000140E8 File Offset: 0x000122E8
		public unsafe uint firstGlyph
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00014128 File Offset: 0x00012328
		public unsafe GlyphValueRecord_Legacy firstGlyphAdjustments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00014164 File Offset: 0x00012364
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000141A0 File Offset: 0x000123A0
		public unsafe uint secondGlyph
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000141E0 File Offset: 0x000123E0
		public unsafe GlyphValueRecord_Legacy secondGlyphAdjustments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0001421C File Offset: 0x0001241C
		public unsafe bool ignoreSpacingAdjustments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00014258 File Offset: 0x00012458
		[CallerCount(0)]
		public unsafe KerningPair()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00014294 File Offset: 0x00012494
		[CallerCount(0)]
		public unsafe KerningPair(uint left, uint right, float offset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000142F8 File Offset: 0x000124F8
		[CallerCount(0)]
		public unsafe KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstGlyph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstGlyphAdjustments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondGlyph;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondGlyphAdjustments;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0001436C File Offset: 0x0001256C
		[CallerCount(0)]
		public unsafe void ConvertLegacyKerningData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPair.NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00003961 File Offset: 0x00001B61
		public KerningPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600031B RID: 795 RVA: 0x000143A0 File Offset: 0x000125A0
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0000396A File Offset: 0x00001B6A
		public unsafe uint m_FirstGlyph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyph);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyph)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600031D RID: 797 RVA: 0x000143C8 File Offset: 0x000125C8
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00003985 File Offset: 0x00001B85
		public unsafe GlyphValueRecord_Legacy m_FirstGlyphAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyphAdjustments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_FirstGlyphAdjustments)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600031F RID: 799 RVA: 0x000143F0 File Offset: 0x000125F0
		// (set) Token: 0x06000320 RID: 800 RVA: 0x000039A0 File Offset: 0x00001BA0
		public unsafe uint m_SecondGlyph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyph);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyph)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00014418 File Offset: 0x00012618
		// (set) Token: 0x06000322 RID: 802 RVA: 0x000039BB File Offset: 0x00001BBB
		public unsafe GlyphValueRecord_Legacy m_SecondGlyphAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyphAdjustments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_SecondGlyphAdjustments)) = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00014440 File Offset: 0x00012640
		// (set) Token: 0x06000324 RID: 804 RVA: 0x000039D6 File Offset: 0x00001BD6
		public unsafe float xOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_xOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_xOffset)) = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00014468 File Offset: 0x00012668
		// (set) Token: 0x06000326 RID: 806 RVA: 0x000039F1 File Offset: 0x00001BF1
		public unsafe static KerningPair empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KerningPair.NativeFieldInfoPtr_empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KerningPair>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KerningPair.NativeFieldInfoPtr_empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00014490 File Offset: 0x00012690
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00003A03 File Offset: 0x00001C03
		public unsafe bool m_IgnoreSpacingAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_IgnoreSpacingAdjustments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningPair.NativeFieldInfoPtr_m_IgnoreSpacingAdjustments)) = value;
			}
		}

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstGlyph;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstGlyphAdjustments;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondGlyph;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondGlyphAdjustments;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr_xOffset;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_empty;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreSpacingAdjustments;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0;
	}
}
