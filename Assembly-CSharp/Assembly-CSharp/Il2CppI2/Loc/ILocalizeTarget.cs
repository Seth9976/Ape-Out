using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000243 RID: 579
	public class ILocalizeTarget : ScriptableObject
	{
		// Token: 0x060044F8 RID: 17656 RVA: 0x00100768 File Offset: 0x000FE968
		// Note: this type is marked as 'beforefieldinit'.
		static ILocalizeTarget()
		{
			Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "ILocalizeTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr);
			ILocalizeTarget.NativeMethodInfoPtr_IsValid_Public_Abstract_Virtual_New_Boolean_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr, 100670191);
			ILocalizeTarget.NativeMethodInfoPtr_GetFinalTerms_Public_Abstract_Virtual_New_Void_Localize_String_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr, 100670192);
			ILocalizeTarget.NativeMethodInfoPtr_DoLocalize_Public_Abstract_Virtual_New_Void_Localize_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr, 100670193);
			ILocalizeTarget.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr, 100670194);
			ILocalizeTarget.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr, 100670195);
			ILocalizeTarget.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr, 100670196);
			ILocalizeTarget.NativeMethodInfoPtr_GetPrimaryTermType_Public_Abstract_Virtual_New_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr, 100670197);
			ILocalizeTarget.NativeMethodInfoPtr_GetSecondaryTermType_Public_Abstract_Virtual_New_eTermType_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr, 100670198);
			ILocalizeTarget.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr, 100670199);
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x0010084C File Offset: 0x000FEA4C
		[CallerCount(0)]
		public unsafe virtual bool IsValid(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizeTarget.NativeMethodInfoPtr_IsValid_Public_Abstract_Virtual_New_Boolean_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x001008A4 File Offset: 0x000FEAA4
		[CallerCount(0)]
		public unsafe virtual void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizeTarget.NativeMethodInfoPtr_GetFinalTerms_Public_Abstract_Virtual_New_Void_Localize_String_String_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			primaryTerm = IL2CPP.Il2CppStringToManaged(intPtr);
			secondaryTerm = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x0010094C File Offset: 0x000FEB4C
		[CallerCount(0)]
		public unsafe virtual void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizeTarget.NativeMethodInfoPtr_DoLocalize_Public_Abstract_Virtual_New_Void_Localize_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x001009C0 File Offset: 0x000FEBC0
		[CallerCount(0)]
		public unsafe virtual bool CanUseSecondaryTerm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizeTarget.NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00100A08 File Offset: 0x000FEC08
		[CallerCount(0)]
		public unsafe virtual bool AllowMainTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizeTarget.NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00100A50 File Offset: 0x000FEC50
		[CallerCount(0)]
		public unsafe virtual bool AllowSecondTermToBeRTL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizeTarget.NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00100A98 File Offset: 0x000FEC98
		[CallerCount(0)]
		public unsafe virtual eTermType GetPrimaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizeTarget.NativeMethodInfoPtr_GetPrimaryTermType_Public_Abstract_Virtual_New_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00100AF0 File Offset: 0x000FECF0
		[CallerCount(0)]
		public unsafe virtual eTermType GetSecondaryTermType(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizeTarget.NativeMethodInfoPtr_GetSecondaryTermType_Public_Abstract_Virtual_New_eTermType_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00100B48 File Offset: 0x000FED48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ILocalizeTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ILocalizeTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILocalizeTarget.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00029835 File Offset: 0x00027A35
		public ILocalizeTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AA7 RID: 10919
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Abstract_Virtual_New_Boolean_Localize_0;

		// Token: 0x04002AA8 RID: 10920
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalTerms_Public_Abstract_Virtual_New_Void_Localize_String_String_byref_String_byref_String_0;

		// Token: 0x04002AA9 RID: 10921
		private static readonly IntPtr NativeMethodInfoPtr_DoLocalize_Public_Abstract_Virtual_New_Void_Localize_String_String_0;

		// Token: 0x04002AAA RID: 10922
		private static readonly IntPtr NativeMethodInfoPtr_CanUseSecondaryTerm_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04002AAB RID: 10923
		private static readonly IntPtr NativeMethodInfoPtr_AllowMainTermToBeRTL_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04002AAC RID: 10924
		private static readonly IntPtr NativeMethodInfoPtr_AllowSecondTermToBeRTL_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04002AAD RID: 10925
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryTermType_Public_Abstract_Virtual_New_eTermType_Localize_0;

		// Token: 0x04002AAE RID: 10926
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTermType_Public_Abstract_Virtual_New_eTermType_Localize_0;

		// Token: 0x04002AAF RID: 10927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
