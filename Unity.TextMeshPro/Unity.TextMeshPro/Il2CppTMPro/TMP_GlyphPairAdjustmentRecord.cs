using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace Il2CppTMPro
{
	// Token: 0x02000029 RID: 41
	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord : Object
	{
		// Token: 0x0600036B RID: 875 RVA: 0x000156BC File Offset: 0x000138BC
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_GlyphPairAdjustmentRecord()
		{
			Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_GlyphPairAdjustmentRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr);
			TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FirstAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FirstAdjustmentRecord");
			TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_SecondAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, "m_SecondAdjustmentRecord");
			TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FeatureLookupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FeatureLookupFlags");
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663695);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663696);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663697);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_secondAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663698);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663699);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_featureLookupFlags_Public_set_Void_FontFeatureLookupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663700);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr__ctor_Public_Void_TMP_GlyphAdjustmentRecord_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663701);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663702);
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000157C8 File Offset: 0x000139C8
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00015804 File Offset: 0x00013A04
		public unsafe TMP_GlyphAdjustmentRecord firstAdjustmentRecord
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00015844 File Offset: 0x00013A44
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00015880 File Offset: 0x00013A80
		public unsafe TMP_GlyphAdjustmentRecord secondAdjustmentRecord
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_secondAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000370 RID: 880 RVA: 0x000158C0 File Offset: 0x00013AC0
		// (set) Token: 0x06000371 RID: 881 RVA: 0x000158FC File Offset: 0x00013AFC
		public unsafe FontFeatureLookupFlags featureLookupFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_featureLookupFlags_Public_set_Void_FontFeatureLookupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0001593C File Offset: 0x00013B3C
		[CallerCount(0)]
		public unsafe TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstAdjustmentRecord;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondAdjustmentRecord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr__ctor_Public_Void_TMP_GlyphAdjustmentRecord_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00015994 File Offset: 0x00013B94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 454070, RefRangeEnd = 454072, XrefRangeStart = 454070, XrefRangeEnd = 454070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphPairAdjustmentRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00003B07 File Offset: 0x00001D07
		public TMP_GlyphPairAdjustmentRecord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000375 RID: 885 RVA: 0x000159DC File Offset: 0x00013BDC
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00003B10 File Offset: 0x00001D10
		public unsafe TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FirstAdjustmentRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FirstAdjustmentRecord)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00015A04 File Offset: 0x00013C04
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00003B2B File Offset: 0x00001D2B
		public unsafe TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_SecondAdjustmentRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_SecondAdjustmentRecord)) = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00015A2C File Offset: 0x00013C2C
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00003B46 File Offset: 0x00001D46
		public unsafe FontFeatureLookupFlags m_FeatureLookupFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FeatureLookupFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FeatureLookupFlags)) = value;
			}
		}

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstAdjustmentRecord;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondAdjustmentRecord;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_m_FeatureLookupFlags;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_set_secondAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_set_featureLookupFlags_Public_set_Void_FontFeatureLookupFlags_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMP_GlyphAdjustmentRecord_TMP_GlyphAdjustmentRecord_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphPairAdjustmentRecord_0;
	}
}
