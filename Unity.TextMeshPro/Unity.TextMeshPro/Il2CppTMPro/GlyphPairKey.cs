using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x0200002A RID: 42
	[StructLayout(2)]
	public struct GlyphPairKey
	{
		// Token: 0x0600037B RID: 891 RVA: 0x00015A54 File Offset: 0x00013C54
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphPairKey()
		{
			Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "GlyphPairKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr);
			GlyphPairKey.NativeFieldInfoPtr_firstGlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, "firstGlyphIndex");
			GlyphPairKey.NativeFieldInfoPtr_secondGlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, "secondGlyphIndex");
			GlyphPairKey.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, "key");
			GlyphPairKey.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, 100663703);
			GlyphPairKey.NativeMethodInfoPtr__ctor_Internal_Void_TMP_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, 100663704);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00015AE8 File Offset: 0x00013CE8
		[CallerCount(0)]
		public unsafe GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstGlyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondGlyphIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairKey.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00015B28 File Offset: 0x00013D28
		[CallerCount(0)]
		public unsafe GlyphPairKey(TMP_GlyphPairAdjustmentRecord record)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairKey.NativeMethodInfoPtr__ctor_Internal_Void_TMP_GlyphPairAdjustmentRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00003B61 File Offset: 0x00001D61
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, ref this));
		}

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_firstGlyphIndex;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_secondGlyphIndex;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TMP_GlyphPairAdjustmentRecord_0;

		// Token: 0x04000281 RID: 641
		[FieldOffset(0)]
		public uint firstGlyphIndex;

		// Token: 0x04000282 RID: 642
		[FieldOffset(4)]
		public uint secondGlyphIndex;

		// Token: 0x04000283 RID: 643
		[FieldOffset(8)]
		public uint key;
	}
}
