using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppTMPro
{
	// Token: 0x02000024 RID: 36
	public class TMP_FontAssetUtilities : Object
	{
		// Token: 0x0600033C RID: 828 RVA: 0x00014A60 File Offset: 0x00012C60
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontAssetUtilities()
		{
			Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontAssetUtilities");
			TMP_FontAssetUtilities.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, "s_Instance");
			TMP_FontAssetUtilities.NativeFieldInfoPtr_k_SearchedAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, "k_SearchedAssets");
			TMP_FontAssetUtilities.NativeFieldInfoPtr_k_IsFontEngineInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, "k_IsFontEngineInitialized");
			TMP_FontAssetUtilities.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_FontAssetUtilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663662);
			TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Public_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663663);
			TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663664);
			TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_TMP_Character_UInt32_TMP_FontAsset_List_1_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663665);
			TMP_FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663666);
			TMP_FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663667);
			TMP_FontAssetUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663668);
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00014B50 File Offset: 0x00012D50
		public unsafe static TMP_FontAssetUtilities instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453780, XrefRangeEnd = 453784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_FontAssetUtilities_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAssetUtilities>(intPtr3) : null;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00014B84 File Offset: 0x00012D84
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 453806, RefRangeEnd = 453816, XrefRangeStart = 453784, XrefRangeEnd = 453806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceFontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontStyle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontWeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAlternativeTypeface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Public_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr3) : null;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00014C10 File Offset: 0x00012E10
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 453871, RefRangeEnd = 453877, XrefRangeStart = 453816, XrefRangeEnd = 453871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceFontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontStyle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontWeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAlternativeTypeface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr3) : null;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00014C9C File Offset: 0x00012E9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 453918, RefRangeEnd = 453924, XrefRangeStart = 453877, XrefRangeEnd = 453918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceFontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAssets);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontStyle;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontWeight;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAlternativeTypeface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_TMP_Character_UInt32_TMP_FontAsset_List_1_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr3) : null;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00014D3C File Offset: 0x00012F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453924, XrefRangeEnd = 453987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteCharacter>(intPtr3) : null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00014D9C File Offset: 0x00012F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 454017, RefRangeEnd = 454019, XrefRangeStart = 453987, XrefRangeEnd = 454017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteCharacter>(intPtr3) : null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00014DFC File Offset: 0x00012FFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_FontAssetUtilities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00003A61 File Offset: 0x00001C61
		public TMP_FontAssetUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00014E38 File Offset: 0x00013038
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00003A6A File Offset: 0x00001C6A
		public unsafe static TMP_FontAssetUtilities s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAssetUtilities>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00014E60 File Offset: 0x00013060
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00003A7C File Offset: 0x00001C7C
		public unsafe static HashSet<int> k_SearchedAssets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_k_SearchedAssets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_k_SearchedAssets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00014E88 File Offset: 0x00013088
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00003A8E File Offset: 0x00001C8E
		public unsafe static bool k_IsFontEngineInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_k_IsFontEngineInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_k_IsFontEngineInitialized, (void*)(&value));
			}
		}

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr_k_SearchedAssets;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_k_IsFontEngineInitialized;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_FontAssetUtilities_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterFromFontAsset_Public_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_TMP_Character_UInt32_TMP_FontAsset_List_1_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
