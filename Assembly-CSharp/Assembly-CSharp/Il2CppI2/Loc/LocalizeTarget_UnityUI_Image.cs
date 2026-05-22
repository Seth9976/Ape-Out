using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.UI;

namespace Il2CppI2.Loc
{
	// Token: 0x02000253 RID: 595
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		// Token: 0x060045A7 RID: 17831 RVA: 0x00103D8C File Offset: 0x00101F8C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeTarget_UnityUI_Image()
		{
			Il2CppClassPointerStore<LocalizeTarget_UnityUI_Image>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizeTarget_UnityUI_Image");
			LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityUI_Image>.NativeClassPtr, 100670314);
			LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityUI_Image>.NativeClassPtr, 100670315);
			LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityUI_Image>.NativeClassPtr, 100670316);
			LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityUI_Image>.NativeClassPtr, 100670317);
			LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityUI_Image>.NativeClassPtr, 100670318);
			LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityUI_Image>.NativeClassPtr, 100670319);
			LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityUI_Image>.NativeClassPtr, 100670320);
			LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityUI_Image>.NativeClassPtr, 100670321);
			LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityUI_Image>.NativeClassPtr, 100670322);
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x00103E68 File Offset: 0x00102068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113804, XrefRangeEnd = 113816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoRegister()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x00103E90 File Offset: 0x00102090
		[CallerCount(0)]
		public unsafe override bool CanUseSecondaryTerm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x00103ED8 File Offset: 0x001020D8
		[CallerCount(0)]
		public unsafe override bool AllowMainTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x00103F20 File Offset: 0x00102120
		[CallerCount(0)]
		public unsafe override bool AllowSecondTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x00103F68 File Offset: 0x00102168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113816, XrefRangeEnd = 113828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override eTermType GetPrimaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00103FC0 File Offset: 0x001021C0
		[CallerCount(0)]
		public unsafe override eTermType GetSecondaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x00104018 File Offset: 0x00102218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113828, XrefRangeEnd = 113852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			primaryTerm = IL2CPP.Il2CppStringToManaged(intPtr);
			secondaryTerm = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x001040C0 File Offset: 0x001022C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113852, XrefRangeEnd = 113869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x00104134 File Offset: 0x00102334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113869, XrefRangeEnd = 113872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeTarget_UnityUI_Image()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeTarget_UnityUI_Image>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_UnityUI_Image.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x00029A43 File Offset: 0x00027C43
		public LocalizeTarget_UnityUI_Image(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B27 RID: 11047
		private static readonly IntPtr NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0;

		// Token: 0x04002B28 RID: 11048
		private static readonly IntPtr NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0;

		// Token: 0x04002B29 RID: 11049
		private static readonly IntPtr NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002B2A RID: 11050
		private static readonly IntPtr NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002B2B RID: 11051
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002B2C RID: 11052
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002B2D RID: 11053
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0;

		// Token: 0x04002B2E RID: 11054
		private static readonly IntPtr NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0;

		// Token: 0x04002B2F RID: 11055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
