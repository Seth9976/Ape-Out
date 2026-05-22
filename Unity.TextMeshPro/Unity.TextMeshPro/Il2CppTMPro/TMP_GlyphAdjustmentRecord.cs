using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace Il2CppTMPro
{
	// Token: 0x02000028 RID: 40
	[Serializable]
	[StructLayout(2)]
	public struct TMP_GlyphAdjustmentRecord
	{
		// Token: 0x06000363 RID: 867 RVA: 0x000154B0 File Offset: 0x000136B0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_GlyphAdjustmentRecord()
		{
			Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_GlyphAdjustmentRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr);
			TMP_GlyphAdjustmentRecord.NativeFieldInfoPtr_m_GlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphIndex");
			TMP_GlyphAdjustmentRecord.NativeFieldInfoPtr_m_GlyphValueRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphValueRecord");
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663689);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663690);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphValueRecord_Public_get_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663691);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphValueRecord_Public_set_Void_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663692);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663693);
			TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, 100663694);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00015580 File Offset: 0x00013780
		// (set) Token: 0x06000365 RID: 869 RVA: 0x000155B0 File Offset: 0x000137B0
		public unsafe uint glyphIndex
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000366 RID: 870 RVA: 0x000155E4 File Offset: 0x000137E4
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00015614 File Offset: 0x00013814
		public unsafe TMP_GlyphValueRecord glyphValueRecord
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_get_glyphValueRecord_Public_get_TMP_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr_set_glyphValueRecord_Public_set_Void_TMP_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00015648 File Offset: 0x00013848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 450469, RefRangeEnd = 450471, XrefRangeStart = 450469, XrefRangeEnd = 450471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphValueRecord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00015688 File Offset: 0x00013888
		[CallerCount(0)]
		public unsafe TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref adjustmentRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphAdjustmentRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphAdjustmentRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00003AF5 File Offset: 0x00001CF5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_GlyphAdjustmentRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndex;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphValueRecord;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphValueRecord_Public_get_TMP_GlyphValueRecord_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphValueRecord_Public_set_Void_TMP_GlyphValueRecord_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_GlyphValueRecord_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphAdjustmentRecord_0;

		// Token: 0x0400026F RID: 623
		[FieldOffset(0)]
		public uint m_GlyphIndex;

		// Token: 0x04000270 RID: 624
		[FieldOffset(4)]
		public TMP_GlyphValueRecord m_GlyphValueRecord;
	}
}
