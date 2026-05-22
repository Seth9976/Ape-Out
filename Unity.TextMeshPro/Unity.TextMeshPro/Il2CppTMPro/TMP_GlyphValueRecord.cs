using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace Il2CppTMPro
{
	// Token: 0x02000027 RID: 39
	[Serializable]
	[StructLayout(2)]
	public struct TMP_GlyphValueRecord
	{
		// Token: 0x06000355 RID: 853 RVA: 0x000150A0 File Offset: 0x000132A0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_GlyphValueRecord()
		{
			Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_GlyphValueRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr);
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_XPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_XPlacement");
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_YPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_YPlacement");
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_XAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_XAdvance");
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_YAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_YAdvance");
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663677);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663678);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663679);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663680);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663681);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xAdvance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663682);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663683);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yAdvance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663684);
			TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663685);
			TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663686);
			TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663687);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_op_Addition_Public_Static_TMP_GlyphValueRecord_TMP_GlyphValueRecord_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663688);
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00015210 File Offset: 0x00013410
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00015240 File Offset: 0x00013440
		public unsafe float xPlacement
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00015274 File Offset: 0x00013474
		// (set) Token: 0x06000359 RID: 857 RVA: 0x000152A4 File Offset: 0x000134A4
		public unsafe float yPlacement
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600035A RID: 858 RVA: 0x000152D8 File Offset: 0x000134D8
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00015308 File Offset: 0x00013508
		public unsafe float xAdvance
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 450440, RefRangeEnd = 450443, XrefRangeStart = 450440, XrefRangeEnd = 450443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xAdvance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0001533C File Offset: 0x0001353C
		// (set) Token: 0x0600035D RID: 861 RVA: 0x0001536C File Offset: 0x0001356C
		public unsafe float yAdvance
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yAdvance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000153A0 File Offset: 0x000135A0
		[CallerCount(0)]
		public unsafe TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xPlacement;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yPlacement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xAdvance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAdvance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000153FC File Offset: 0x000135FC
		[CallerCount(0)]
		public unsafe TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_Legacy_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00015430 File Offset: 0x00013630
		[CallerCount(0)]
		public unsafe TMP_GlyphValueRecord(GlyphValueRecord valueRecord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00015464 File Offset: 0x00013664
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335340, RefRangeEnd = 335343, XrefRangeStart = 335340, XrefRangeEnd = 335343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_op_Addition_Public_Static_TMP_GlyphValueRecord_TMP_GlyphValueRecord_TMP_GlyphValueRecord_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003AE3 File Offset: 0x00001CE3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_m_XPlacement;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_m_YPlacement;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_m_XAdvance;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_m_YAdvance;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_set_xAdvance_Public_set_Void_Single_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_set_yAdvance_Public_set_Void_Single_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_Legacy_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_TMP_GlyphValueRecord_TMP_GlyphValueRecord_TMP_GlyphValueRecord_0;

		// Token: 0x04000263 RID: 611
		[FieldOffset(0)]
		public float m_XPlacement;

		// Token: 0x04000264 RID: 612
		[FieldOffset(4)]
		public float m_YPlacement;

		// Token: 0x04000265 RID: 613
		[FieldOffset(8)]
		public float m_XAdvance;

		// Token: 0x04000266 RID: 614
		[FieldOffset(12)]
		public float m_YAdvance;
	}
}
