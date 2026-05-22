using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200024F RID: 591
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		// Token: 0x06004571 RID: 17777 RVA: 0x00102C28 File Offset: 0x00100E28
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeTarget_UnityStandard_Prefab()
		{
			Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizeTarget_UnityStandard_Prefab");
			LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr, 100670272);
			LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr, 100670273);
			LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr, 100670274);
			LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr, 100670275);
			LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr, 100670276);
			LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr, 100670277);
			LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr, 100670278);
			LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr, 100670279);
			LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr, 100670280);
			LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_InstantiateNewPrefab_Private_Transform_Localize_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr, 100670281);
			LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr, 100670282);
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x00102D2C File Offset: 0x00100F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113492, XrefRangeEnd = 113503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoRegister()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x00102D54 File Offset: 0x00100F54
		[CallerCount(0)]
		public unsafe override bool IsValid(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x00102DAC File Offset: 0x00100FAC
		[CallerCount(0)]
		public unsafe override eTermType GetPrimaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x00102E04 File Offset: 0x00101004
		[CallerCount(0)]
		public unsafe override eTermType GetSecondaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x00102E5C File Offset: 0x0010105C
		[CallerCount(0)]
		public unsafe override bool CanUseSecondaryTerm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00102EA4 File Offset: 0x001010A4
		[CallerCount(0)]
		public unsafe override bool AllowMainTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00102EEC File Offset: 0x001010EC
		[CallerCount(0)]
		public unsafe override bool AllowSecondTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00102F34 File Offset: 0x00101134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			primaryTerm = IL2CPP.Il2CppStringToManaged(intPtr);
			secondaryTerm = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x00102FDC File Offset: 0x001011DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113503, XrefRangeEnd = 113548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x00103050 File Offset: 0x00101250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113594, RefRangeEnd = 113595, XrefRangeStart = 113548, XrefRangeEnd = 113594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mainTranslation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr_InstantiateNewPrefab_Private_Transform_Localize_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x001030B4 File Offset: 0x001012B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113595, XrefRangeEnd = 113598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeTarget_UnityStandard_Prefab()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_Prefab>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_UnityStandard_Prefab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x000299B3 File Offset: 0x00027BB3
		public LocalizeTarget_UnityStandard_Prefab(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AFD RID: 11005
		private static readonly IntPtr NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0;

		// Token: 0x04002AFE RID: 11006
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Virtual_Boolean_Localize_0;

		// Token: 0x04002AFF RID: 11007
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002B00 RID: 11008
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002B01 RID: 11009
		private static readonly IntPtr NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0;

		// Token: 0x04002B02 RID: 11010
		private static readonly IntPtr NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002B03 RID: 11011
		private static readonly IntPtr NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002B04 RID: 11012
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0;

		// Token: 0x04002B05 RID: 11013
		private static readonly IntPtr NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0;

		// Token: 0x04002B06 RID: 11014
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateNewPrefab_Private_Transform_Localize_String_0;

		// Token: 0x04002B07 RID: 11015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
