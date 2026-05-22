using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppTMPro;

namespace Il2CppI2.Loc
{
	// Token: 0x02000249 RID: 585
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		// Token: 0x06004534 RID: 17716 RVA: 0x00101964 File Offset: 0x000FFB64
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeTarget_TextMeshPro_UGUI()
		{
			Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizeTarget_TextMeshPro_UGUI");
			LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mAlignment_RTL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, "mAlignment_RTL");
			LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mAlignment_LTR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, "mAlignment_LTR");
			LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mAlignmentWasRTL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, "mAlignmentWasRTL");
			LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mInitializeAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, "mInitializeAlignment");
			LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, 100670227);
			LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, 100670228);
			LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, 100670229);
			LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, 100670230);
			LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, 100670231);
			LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, 100670232);
			LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, 100670233);
			LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, 100670234);
			LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr, 100670235);
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x00101A90 File Offset: 0x000FFC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113094, XrefRangeEnd = 113106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoRegister()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x00101AB8 File Offset: 0x000FFCB8
		[CallerCount(0)]
		public unsafe override eTermType GetPrimaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x00101B10 File Offset: 0x000FFD10
		[CallerCount(0)]
		public unsafe override eTermType GetSecondaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x00101B68 File Offset: 0x000FFD68
		[CallerCount(0)]
		public unsafe override bool CanUseSecondaryTerm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x00101BB0 File Offset: 0x000FFDB0
		[CallerCount(0)]
		public unsafe override bool AllowMainTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00101BF8 File Offset: 0x000FFDF8
		[CallerCount(0)]
		public unsafe override bool AllowSecondTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00101C40 File Offset: 0x000FFE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113106, XrefRangeEnd = 113126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			primaryTerm = IL2CPP.Il2CppStringToManaged(intPtr);
			secondaryTerm = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x00101CE8 File Offset: 0x000FFEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113126, XrefRangeEnd = 113228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00101D5C File Offset: 0x000FFF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113228, XrefRangeEnd = 113230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeTarget_TextMeshPro_UGUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeTarget_TextMeshPro_UGUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_TextMeshPro_UGUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00029911 File Offset: 0x00027B11
		public LocalizeTarget_TextMeshPro_UGUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x0600453F RID: 17727 RVA: 0x00101D98 File Offset: 0x000FFF98
		// (set) Token: 0x06004540 RID: 17728 RVA: 0x0002991A File Offset: 0x00027B1A
		public unsafe TextAlignmentOptions mAlignment_RTL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mAlignment_RTL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mAlignment_RTL)) = value;
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06004541 RID: 17729 RVA: 0x00101DC0 File Offset: 0x000FFFC0
		// (set) Token: 0x06004542 RID: 17730 RVA: 0x00029935 File Offset: 0x00027B35
		public unsafe TextAlignmentOptions mAlignment_LTR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mAlignment_LTR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mAlignment_LTR)) = value;
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x00101DE8 File Offset: 0x000FFFE8
		// (set) Token: 0x06004544 RID: 17732 RVA: 0x00029950 File Offset: 0x00027B50
		public unsafe bool mAlignmentWasRTL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mAlignmentWasRTL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mAlignmentWasRTL)) = value;
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x00101E10 File Offset: 0x00100010
		// (set) Token: 0x06004546 RID: 17734 RVA: 0x0002996B File Offset: 0x00027B6B
		public unsafe bool mInitializeAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mInitializeAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeTarget_TextMeshPro_UGUI.NativeFieldInfoPtr_mInitializeAlignment)) = value;
			}
		}

		// Token: 0x04002AD0 RID: 10960
		private static readonly IntPtr NativeFieldInfoPtr_mAlignment_RTL;

		// Token: 0x04002AD1 RID: 10961
		private static readonly IntPtr NativeFieldInfoPtr_mAlignment_LTR;

		// Token: 0x04002AD2 RID: 10962
		private static readonly IntPtr NativeFieldInfoPtr_mAlignmentWasRTL;

		// Token: 0x04002AD3 RID: 10963
		private static readonly IntPtr NativeFieldInfoPtr_mInitializeAlignment;

		// Token: 0x04002AD4 RID: 10964
		private static readonly IntPtr NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0;

		// Token: 0x04002AD5 RID: 10965
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002AD6 RID: 10966
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002AD7 RID: 10967
		private static readonly IntPtr NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0;

		// Token: 0x04002AD8 RID: 10968
		private static readonly IntPtr NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002AD9 RID: 10969
		private static readonly IntPtr NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002ADA RID: 10970
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0;

		// Token: 0x04002ADB RID: 10971
		private static readonly IntPtr NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0;

		// Token: 0x04002ADC RID: 10972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
