using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200024D RID: 589
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		// Token: 0x06004562 RID: 17762 RVA: 0x00102758 File Offset: 0x00100958
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeTarget_UnityStandard_MeshRenderer()
		{
			Il2CppClassPointerStore<LocalizeTarget_UnityStandard_MeshRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizeTarget_UnityStandard_MeshRenderer");
			LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_MeshRenderer>.NativeClassPtr, 100670260);
			LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_MeshRenderer>.NativeClassPtr, 100670261);
			LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_MeshRenderer>.NativeClassPtr, 100670262);
			LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_MeshRenderer>.NativeClassPtr, 100670263);
			LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_MeshRenderer>.NativeClassPtr, 100670264);
			LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_MeshRenderer>.NativeClassPtr, 100670265);
			LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_MeshRenderer>.NativeClassPtr, 100670266);
			LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_MeshRenderer>.NativeClassPtr, 100670267);
			LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_MeshRenderer>.NativeClassPtr, 100670268);
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00102834 File Offset: 0x00100A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113336, XrefRangeEnd = 113348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoRegister()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x0010285C File Offset: 0x00100A5C
		[CallerCount(0)]
		public unsafe override eTermType GetPrimaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x001028B4 File Offset: 0x00100AB4
		[CallerCount(0)]
		public unsafe override eTermType GetSecondaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x0010290C File Offset: 0x00100B0C
		[CallerCount(0)]
		public unsafe override bool CanUseSecondaryTerm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x00102954 File Offset: 0x00100B54
		[CallerCount(0)]
		public unsafe override bool AllowMainTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x0010299C File Offset: 0x00100B9C
		[CallerCount(0)]
		public unsafe override bool AllowSecondTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x001029E4 File Offset: 0x00100BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113348, XrefRangeEnd = 113420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			primaryTerm = IL2CPP.Il2CppStringToManaged(intPtr);
			secondaryTerm = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x00102A8C File Offset: 0x00100C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113420, XrefRangeEnd = 113488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x00102B00 File Offset: 0x00100D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113488, XrefRangeEnd = 113491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeTarget_UnityStandard_MeshRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeTarget_UnityStandard_MeshRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTarget_UnityStandard_MeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x000299A1 File Offset: 0x00027BA1
		public LocalizeTarget_UnityStandard_MeshRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AF2 RID: 10994
		private static readonly IntPtr NativeMethodInfoPtr_AutoRegister_Private_Static_Void_0;

		// Token: 0x04002AF3 RID: 10995
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002AF4 RID: 10996
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTermType_Public_Virtual_eTermType_Localize_0;

		// Token: 0x04002AF5 RID: 10997
		private static readonly IntPtr NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Virtual_Boolean_0;

		// Token: 0x04002AF6 RID: 10998
		private static readonly IntPtr NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002AF7 RID: 10999
		private static readonly IntPtr NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Virtual_Boolean_0;

		// Token: 0x04002AF8 RID: 11000
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalTerms_Public_Virtual_Void_Localize_String_String_byref_String_byref_String_0;

		// Token: 0x04002AF9 RID: 11001
		private static readonly IntPtr NativeMethodInfoPtr_DoLocalize_Public_Virtual_Void_Localize_String_String_0;

		// Token: 0x04002AFA RID: 11002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
