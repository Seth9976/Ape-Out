using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppTMPro
{
	// Token: 0x02000023 RID: 35
	public static class TMP_FontUtilities : Object
	{
		// Token: 0x06000334 RID: 820 RVA: 0x000147C4 File Offset: 0x000129C4
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontUtilities()
		{
			Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr);
			TMP_FontUtilities.NativeFieldInfoPtr_k_searchedFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, "k_searchedFontAssets");
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663657);
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663658);
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663659);
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663660);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00014858 File Offset: 0x00012A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453686, XrefRangeEnd = 453700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000148D0 File Offset: 0x00012AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453700, XrefRangeEnd = 453701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fonts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00014948 File Offset: 0x00012B48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 453759, RefRangeEnd = 453762, XrefRangeStart = 453701, XrefRangeEnd = 453759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000149C0 File Offset: 0x00012BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453779, RefRangeEnd = 453780, XrefRangeStart = 453762, XrefRangeEnd = 453779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fonts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00003A46 File Offset: 0x00001C46
		public TMP_FontUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00014A38 File Offset: 0x00012C38
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00003A4F File Offset: 0x00001C4F
		public unsafe static List<int> k_searchedFontAssets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontUtilities.NativeFieldInfoPtr_k_searchedFontAssets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontUtilities.NativeFieldInfoPtr_k_searchedFontAssets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_k_searchedFontAssets;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0;
	}
}
