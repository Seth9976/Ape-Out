using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000248 RID: 584
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
	{
		// Token: 0x0600451D RID: 17693 RVA: 0x001012FC File Offset: 0x000FF4FC
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeTarget_TextMeshPro_Label()
		{
			Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizeTarget_TextMeshPro_Label");
			LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mAlignment_RTL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, "mAlignment_RTL");
			LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mAlignment_LTR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, "mAlignment_LTR");
			LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mAlignmentWasRTL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, "mAlignmentWasRTL");
			LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mInitializeAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, "mInitializeAlignment");
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670213);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670214);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670215);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670216);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670217);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670218);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670219);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670220);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_GetTMPFontFromMaterial_Internal_Static_TMP_FontAsset_Localize_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670221);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_InitAlignment_TMPro_Internal_Static_Void_Boolean_TextAlignmentOptions_byref_TextAlignmentOptions_byref_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670222);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_SetFont_Internal_Static_Void_TMP_Text_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670223);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_SetMaterial_Internal_Static_Void_TMP_Text_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670224);
			LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr, 100670225);
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x00101478 File Offset: 0x000FF678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112866, XrefRangeEnd = 112878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoRegister()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x001014A0 File Offset: 0x000FF6A0
		[CallerCount(0)]
		public unsafe override eTermType GetPrimaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x001014F8 File Offset: 0x000FF6F8
		[CallerCount(0)]
		public unsafe override eTermType GetSecondaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x00101550 File Offset: 0x000FF750
		[CallerCount(0)]
		public unsafe override bool CanUseSecondaryTerm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x00101598 File Offset: 0x000FF798
		[CallerCount(0)]
		public unsafe override bool AllowMainTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x001015E0 File Offset: 0x000FF7E0
		[CallerCount(0)]
		public unsafe override bool AllowSecondTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x00101628 File Offset: 0x000FF828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112878, XrefRangeEnd = 112898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Main);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Secondary);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			primaryTerm = IL2CPP.Il2CppStringToManaged(intPtr);
			secondaryTerm = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x001016D0 File Offset: 0x000FF8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112898, XrefRangeEnd = 113000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mainTranslation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secondaryTranslation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x00101744 File Offset: 0x000FF944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113006, RefRangeEnd = 113008, XrefRangeStart = 113000, XrefRangeEnd = 113006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(matName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_GetTMPFontFromMaterial_Internal_Static_TMP_FontAsset_Localize_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x0010179C File Offset: 0x000FF99C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 113008, RefRangeEnd = 113012, XrefRangeStart = 113008, XrefRangeEnd = 113008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isRTL;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &alignLTR;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &alignRTL;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_InitAlignment_TMPro_Internal_Static_Void_Boolean_TextAlignmentOptions_byref_TextAlignmentOptions_byref_TextAlignmentOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x001017F8 File Offset: 0x000FF9F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 113051, RefRangeEnd = 113055, XrefRangeStart = 113012, XrefRangeEnd = 113051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newFont);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_SetFont_Internal_Static_Void_TMP_Text_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x00101840 File Offset: 0x000FFA40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113090, RefRangeEnd = 113092, XrefRangeStart = 113055, XrefRangeEnd = 113090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMaterial(TMP_Text label, Material newMat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newMat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr_SetMaterial_Internal_Static_Void_TMP_Text_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x00101888 File Offset: 0x000FFA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113092, XrefRangeEnd = 113094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeTarget_TextMeshPro_Label()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_Label>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_TextMeshPro_Label.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x0002989C File Offset: 0x00027A9C
		public LocalizeTarget_TextMeshPro_Label(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x0600452C RID: 17708 RVA: 0x001018C4 File Offset: 0x000FFAC4
		// (set) Token: 0x0600452D RID: 17709 RVA: 0x000298A5 File Offset: 0x00027AA5
		public unsafe TextAlignmentOptions mAlignment_RTL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mAlignment_RTL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mAlignment_RTL)) = value;
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x0600452E RID: 17710 RVA: 0x001018EC File Offset: 0x000FFAEC
		// (set) Token: 0x0600452F RID: 17711 RVA: 0x000298C0 File Offset: 0x00027AC0
		public unsafe TextAlignmentOptions mAlignment_LTR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mAlignment_LTR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mAlignment_LTR)) = value;
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06004530 RID: 17712 RVA: 0x00101914 File Offset: 0x000FFB14
		// (set) Token: 0x06004531 RID: 17713 RVA: 0x000298DB File Offset: 0x00027ADB
		public unsafe bool mAlignmentWasRTL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mAlignmentWasRTL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mAlignmentWasRTL)) = value;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06004532 RID: 17714 RVA: 0x0010193C File Offset: 0x000FFB3C
		// (set) Token: 0x06004533 RID: 17715 RVA: 0x000298F6 File Offset: 0x00027AF6
		public unsafe bool mInitializeAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mInitializeAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_Label.NativeFieldInfoPtr_mInitializeAlignment)) = value;
			}
		}

		// Token: 0x04002ABF RID: 10943
		private static readonly IntPtr NativeFieldInfoPtr_mAlignment_RTL;

		// Token: 0x04002AC0 RID: 10944
		private static readonly IntPtr NativeFieldInfoPtr_mAlignment_LTR;

		// Token: 0x04002AC1 RID: 10945
		private static readonly IntPtr NativeFieldInfoPtr_mAlignmentWasRTL;

		// Token: 0x04002AC2 RID: 10946
		private static readonly IntPtr NativeFieldInfoPtr_mInitializeAlignment;

		// Token: 0x04002AC3 RID: 10947
		private static readonly IntPtr NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0;

		// Token: 0x04002AC4 RID: 10948
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002AC5 RID: 10949
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002AC6 RID: 10950
		private static readonly IntPtr NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0;

		// Token: 0x04002AC7 RID: 10951
		private static readonly IntPtr NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002AC8 RID: 10952
		private static readonly IntPtr NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002AC9 RID: 10953
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0;

		// Token: 0x04002ACA RID: 10954
		private static readonly IntPtr NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0;

		// Token: 0x04002ACB RID: 10955
		private static readonly IntPtr NativeMethodInfoPtr_GetTMPFontFromMaterial_Internal_Static_TMP_FontAsset_Localize_String_0;

		// Token: 0x04002ACC RID: 10956
		private static readonly IntPtr NativeMethodInfoPtr_InitAlignment_TMPro_Internal_Static_Void_Boolean_TextAlignmentOptions_byref_TextAlignmentOptions_byref_TextAlignmentOptions_0;

		// Token: 0x04002ACD RID: 10957
		private static readonly IntPtr NativeMethodInfoPtr_SetFont_Internal_Static_Void_TMP_Text_TMP_FontAsset_0;

		// Token: 0x04002ACE RID: 10958
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Internal_Static_Void_TMP_Text_Material_0;

		// Token: 0x04002ACF RID: 10959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
