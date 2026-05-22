using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200024C RID: 588
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		// Token: 0x06004556 RID: 17750 RVA: 0x00102308 File Offset: 0x00100508
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeTarget_UnityStandard_Child()
		{
			Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizeTarget_UnityStandard_Child");
			LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr, 100670249);
			LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr, 100670250);
			LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr, 100670251);
			LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr, 100670252);
			LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr, 100670253);
			LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr, 100670254);
			LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr, 100670255);
			LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr, 100670256);
			LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr, 100670257);
			LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr, 100670258);
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x001023F8 File Offset: 0x001005F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113297, XrefRangeEnd = 113308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoRegister()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00102420 File Offset: 0x00100620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValid(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00102478 File Offset: 0x00100678
		[CallerCount(0)]
		public unsafe override eTermType GetPrimaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x001024D0 File Offset: 0x001006D0
		[CallerCount(0)]
		public unsafe override eTermType GetSecondaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00102528 File Offset: 0x00100728
		[CallerCount(0)]
		public unsafe override bool CanUseSecondaryTerm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x00102570 File Offset: 0x00100770
		[CallerCount(0)]
		public unsafe override bool AllowMainTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x001025B8 File Offset: 0x001007B8
		[CallerCount(0)]
		public unsafe override bool AllowSecondTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00102600 File Offset: 0x00100800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113308, XrefRangeEnd = 113309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			primaryTerm = IL2CPP.Il2CppStringToManaged(intPtr);
			secondaryTerm = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x001026A8 File Offset: 0x001008A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113309, XrefRangeEnd = 113333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x0010271C File Offset: 0x0010091C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113333, XrefRangeEnd = 113336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeTarget_UnityStandard_Child()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Child>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_UnityStandard_Child.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x00029998 File Offset: 0x00027B98
		public LocalizeTarget_UnityStandard_Child(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AE8 RID: 10984
		private static readonly IntPtr NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0;

		// Token: 0x04002AE9 RID: 10985
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_Localize_0;

		// Token: 0x04002AEA RID: 10986
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002AEB RID: 10987
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002AEC RID: 10988
		private static readonly IntPtr NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0;

		// Token: 0x04002AED RID: 10989
		private static readonly IntPtr NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002AEE RID: 10990
		private static readonly IntPtr NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002AEF RID: 10991
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0;

		// Token: 0x04002AF0 RID: 10992
		private static readonly IntPtr NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0;

		// Token: 0x04002AF1 RID: 10993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
