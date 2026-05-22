using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;

namespace Il2CppTMPro
{
	// Token: 0x0200003F RID: 63
	public class TMP_SpriteAsset : TMP_Asset
	{
		// Token: 0x060006EF RID: 1775 RVA: 0x00020AA4 File Offset: 0x0001ECA4
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteAsset()
		{
			Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr);
			TMP_SpriteAsset.NativeFieldInfoPtr_m_NameLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_NameLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_GlyphIndexLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_Version");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_FaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_FaceInfo");
			TMP_SpriteAsset.NativeFieldInfoPtr_spriteSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "spriteSheet");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteCharacterTable");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteCharacterLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteGlyphTable");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteGlyphLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_spriteInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "spriteInfoList");
			TMP_SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "fallbackSpriteAssets");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_IsSpriteAssetLookupTablesDirty");
			TMP_SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "k_searchedSpriteAssets");
			TMP_SpriteAsset.NativeMethodInfoPtr_get_version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664096);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664097);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664098);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664099);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664100);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664101);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664102);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664103);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664104);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664105);
			TMP_SpriteAsset.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664106);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetDefaultSpriteMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664107);
			TMP_SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664108);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664109);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664110);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664111);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664112);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664113);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664114);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664115);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664116);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664117);
			TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphTable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664118);
			TMP_SpriteAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664119);
			TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664120);
			TMP_SpriteAsset.NativeMethodInfoPtr_UpgradeSpriteAsset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664121);
			TMP_SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664122);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00020DF4 File Offset: 0x0001EFF4
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00020E2C File Offset: 0x0001F02C
		public unsafe string version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00020E70 File Offset: 0x0001F070
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x00020EA8 File Offset: 0x0001F0A8
		public unsafe FaceInfo faceInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FaceInfo(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00020EF0 File Offset: 0x0001F0F0
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00020F30 File Offset: 0x0001F130
		public unsafe List<TMP_SpriteCharacter> spriteCharacterTable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 459187, RefRangeEnd = 459189, XrefRangeStart = 459186, XrefRangeEnd = 459187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteCharacter>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 426723, RefRangeEnd = 426724, XrefRangeStart = 426723, XrefRangeEnd = 426724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00020F74 File Offset: 0x0001F174
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00020FB4 File Offset: 0x0001F1B4
		public unsafe Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459189, XrefRangeEnd = 459190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_SpriteCharacter>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00020FF8 File Offset: 0x0001F1F8
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00021038 File Offset: 0x0001F238
		public unsafe List<TMP_SpriteGlyph> spriteGlyphTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteGlyph>>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 386301, RefRangeEnd = 386305, XrefRangeStart = 386301, XrefRangeEnd = 386305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0002107C File Offset: 0x0001F27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459190, XrefRangeEnd = 459203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x000210B0 File Offset: 0x0001F2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459203, XrefRangeEnd = 459219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetDefaultSpriteMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetDefaultSpriteMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x000210F0 File Offset: 0x0001F2F0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 459295, RefRangeEnd = 459311, XrefRangeStart = 459219, XrefRangeEnd = 459295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLookupTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00021124 File Offset: 0x0001F324
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 459314, RefRangeEnd = 459318, XrefRangeStart = 459311, XrefRangeEnd = 459314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromHashcode(int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00021170 File Offset: 0x0001F370
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 459321, RefRangeEnd = 459326, XrefRangeStart = 459318, XrefRangeEnd = 459321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromUnicode(uint unicode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000211BC File Offset: 0x0001F3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459326, XrefRangeEnd = 459338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0002120C File Offset: 0x0001F40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459338, XrefRangeEnd = 459388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0002127C File Offset: 0x0001F47C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 459423, RefRangeEnd = 459428, XrefRangeStart = 459388, XrefRangeEnd = 459423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAssets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000212EC File Offset: 0x0001F4EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459431, RefRangeEnd = 459432, XrefRangeStart = 459428, XrefRangeEnd = 459431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0002135C File Offset: 0x0001F55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459432, XrefRangeEnd = 459505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000213CC File Offset: 0x0001F5CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 459540, RefRangeEnd = 459543, XrefRangeStart = 459505, XrefRangeEnd = 459540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAssets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0002143C File Offset: 0x0001F63C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459546, RefRangeEnd = 459547, XrefRangeStart = 459543, XrefRangeEnd = 459546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x000214AC File Offset: 0x0001F6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459569, RefRangeEnd = 459570, XrefRangeStart = 459547, XrefRangeEnd = 459569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphTable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x000214E0 File Offset: 0x0001F6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459592, RefRangeEnd = 459593, XrefRangeStart = 459570, XrefRangeEnd = 459592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortCharacterTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00021514 File Offset: 0x0001F714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459593, XrefRangeEnd = 459595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphAndCharacterTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00021548 File Offset: 0x0001F748
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 459658, RefRangeEnd = 459660, XrefRangeStart = 459595, XrefRangeEnd = 459658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgradeSpriteAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_UpgradeSpriteAsset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0002157C File Offset: 0x0001F77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459660, XrefRangeEnd = 459673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0000528E File Offset: 0x0000348E
		public TMP_SpriteAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x000215B8 File Offset: 0x0001F7B8
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00005297 File Offset: 0x00003497
		public unsafe Dictionary<int, int> m_NameLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_NameLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_NameLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x000215E8 File Offset: 0x0001F7E8
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x000052B6 File Offset: 0x000034B6
		public unsafe Dictionary<uint, int> m_GlyphIndexLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00021618 File Offset: 0x0001F818
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x000052D5 File Offset: 0x000034D5
		public unsafe string m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_Version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_Version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00021640 File Offset: 0x0001F840
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x000052F4 File Offset: 0x000034F4
		public FaceInfo m_FaceInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_FaceInfo);
				return new FaceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_FaceInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00021670 File Offset: 0x0001F870
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00005322 File Offset: 0x00003522
		public unsafe Texture spriteSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x000216A0 File Offset: 0x0001F8A0
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00005341 File Offset: 0x00003541
		public unsafe List<TMP_SpriteCharacter> m_SpriteCharacterTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteCharacter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000216D0 File Offset: 0x0001F8D0
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00005360 File Offset: 0x00003560
		public unsafe Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_SpriteCharacter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00021700 File Offset: 0x0001F900
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0000537F File Offset: 0x0000357F
		public unsafe List<TMP_SpriteGlyph> m_SpriteGlyphTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteGlyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00021730 File Offset: 0x0001F930
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0000539E File Offset: 0x0000359E
		public unsafe Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_SpriteGlyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00021760 File Offset: 0x0001F960
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x000053BD File Offset: 0x000035BD
		public unsafe List<TMP_Sprite> spriteInfoList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteInfoList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteInfoList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00021790 File Offset: 0x0001F990
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x000053DC File Offset: 0x000035DC
		public unsafe List<TMP_SpriteAsset> fallbackSpriteAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x000217C0 File Offset: 0x0001F9C0
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x000053FB File Offset: 0x000035FB
		public unsafe bool m_IsSpriteAssetLookupTablesDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty)) = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x000217E8 File Offset: 0x0001F9E8
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00005416 File Offset: 0x00003616
		public unsafe static HashSet<int> k_searchedSpriteAssets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeFieldInfoPtr_m_NameLookup;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndexLookup;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceInfo;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeFieldInfoPtr_spriteSheet;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteCharacterTable;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteCharacterLookup;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteGlyphTable;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteGlyphLookup;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_spriteInfoList;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr_fallbackSpriteAssets;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeFieldInfoPtr_k_searchedSpriteAssets;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_get_String_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_set_version_Internal_set_Void_String_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_TMP_SpriteCharacter_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_TMP_SpriteCharacter_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_TMP_SpriteCharacter_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_TMP_SpriteCharacter_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_TMP_SpriteGlyph_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_TMP_SpriteGlyph_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultSpriteMaterial_Private_Material_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphTable_Public_Void_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeSpriteAsset_Private_Void_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000A3 RID: 163
		[ObfuscatedName("TMPro.TMP_SpriteAsset+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000FC4 RID: 4036 RVA: 0x0003E554 File Offset: 0x0003C754
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr);
				TMP_SpriteAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, "<>9");
				TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, "<>9__40_0");
				TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, "<>9__41_0");
				TMP_SpriteAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, 100664124);
				TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__40_0_Internal_UInt32_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, 100664125);
				TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__41_0_Internal_UInt32_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, 100664126);
			}

			// Token: 0x06000FC5 RID: 4037 RVA: 0x0003E5F8 File Offset: 0x0003C7F8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FC6 RID: 4038 RVA: 0x0003E634 File Offset: 0x0003C834
			[CallerCount(0)]
			public unsafe uint _SortGlyphTable_b__40_0(TMP_SpriteGlyph item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__40_0_Internal_UInt32_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FC7 RID: 4039 RVA: 0x0003E684 File Offset: 0x0003C884
			[CallerCount(0)]
			public unsafe uint _SortCharacterTable_b__41_0(TMP_SpriteCharacter c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__41_0_Internal_UInt32_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FC8 RID: 4040 RVA: 0x000098C6 File Offset: 0x00007AC6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005BC RID: 1468
			// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0003E6D4 File Offset: 0x0003C8D4
			// (set) Token: 0x06000FCA RID: 4042 RVA: 0x000098CF File Offset: 0x00007ACF
			public unsafe static TMP_SpriteAsset.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005BD RID: 1469
			// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0003E6FC File Offset: 0x0003C8FC
			// (set) Token: 0x06000FCC RID: 4044 RVA: 0x000098E1 File Offset: 0x00007AE1
			public unsafe static Func<TMP_SpriteGlyph, uint> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_SpriteGlyph, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005BE RID: 1470
			// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0003E724 File Offset: 0x0003C924
			// (set) Token: 0x06000FCE RID: 4046 RVA: 0x000098F3 File Offset: 0x00007AF3
			public unsafe static Func<TMP_SpriteCharacter, uint> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_SpriteCharacter, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C5D RID: 3165
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C5E RID: 3166
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04000C5F RID: 3167
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x04000C60 RID: 3168
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C61 RID: 3169
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphTable_b__40_0_Internal_UInt32_TMP_SpriteGlyph_0;

			// Token: 0x04000C62 RID: 3170
			private static readonly IntPtr NativeMethodInfoPtr__SortCharacterTable_b__41_0_Internal_UInt32_TMP_SpriteCharacter_0;
		}
	}
}
