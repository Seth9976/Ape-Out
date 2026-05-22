using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.TextCore;

namespace Il2CppTMPro
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public class TMP_Character : TMP_TextElement
	{
		// Token: 0x0600007A RID: 122 RVA: 0x0000BA4C File Offset: 0x00009C4C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Character()
		{
			Il2CppClassPointerStore<TMP_Character>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Character");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr);
			TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663342);
			TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663343);
			TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_FontAsset_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663344);
			TMP_Character.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663345);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000BACC File Offset: 0x00009CCC
		[CallerCount(0)]
		public unsafe TMP_Character()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000BB08 File Offset: 0x00009D08
		[CallerCount(0)]
		public unsafe TMP_Character(uint unicode, Glyph glyph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(glyph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000BB64 File Offset: 0x00009D64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 450432, RefRangeEnd = 450434, XrefRangeStart = 450432, XrefRangeEnd = 450432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Character(uint unicode, TMP_FontAsset fontAsset, Glyph glyph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(glyph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_FontAsset_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 450434, RefRangeEnd = 450436, XrefRangeStart = 450434, XrefRangeEnd = 450434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Character(uint unicode, uint glyphIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002427 File Offset: 0x00000627
		public TMP_Character(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_Glyph_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_FontAsset_Glyph_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0;
	}
}
