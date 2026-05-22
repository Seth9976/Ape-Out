using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppTMPro
{
	// Token: 0x0200001C RID: 28
	[Serializable]
	public class TMP_Glyph : TMP_TextElement_Legacy
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x000136C0 File Offset: 0x000118C0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Glyph()
		{
			Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Glyph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr);
			TMP_Glyph.NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr, 100663622);
			TMP_Glyph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr, 100663623);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00013718 File Offset: 0x00011918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453577, XrefRangeEnd = 453580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Glyph Clone(TMP_Glyph source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Glyph.NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Glyph>(intPtr3) : null;
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001375C File Offset: 0x0001195C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Glyph()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Glyph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000036FC File Offset: 0x000018FC
		public TMP_Glyph(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
