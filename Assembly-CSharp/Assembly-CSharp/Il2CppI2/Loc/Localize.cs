using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppI2.Loc
{
	// Token: 0x02000240 RID: 576
	public class Localize : MonoBehaviour
	{
		// Token: 0x06004427 RID: 17447 RVA: 0x000FD844 File Offset: 0x000FBA44
		// Note: this type is marked as 'beforefieldinit'.
		static Localize()
		{
			Il2CppClassPointerStore<Localize>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "Localize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Localize>.NativeClassPtr);
			Localize.NativeFieldInfoPtr_mTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "mTerm");
			Localize.NativeFieldInfoPtr_mTermSecondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "mTermSecondary");
			Localize.NativeFieldInfoPtr_FinalTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "FinalTerm");
			Localize.NativeFieldInfoPtr_FinalSecondaryTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "FinalSecondaryTerm");
			Localize.NativeFieldInfoPtr_PrimaryTermModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "PrimaryTermModifier");
			Localize.NativeFieldInfoPtr_SecondaryTermModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "SecondaryTermModifier");
			Localize.NativeFieldInfoPtr_TermPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "TermPrefix");
			Localize.NativeFieldInfoPtr_TermSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "TermSuffix");
			Localize.NativeFieldInfoPtr_LocalizeOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "LocalizeOnAwake");
			Localize.NativeFieldInfoPtr_LastLocalizedLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "LastLocalizedLanguage");
			Localize.NativeFieldInfoPtr_IgnoreRTL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "IgnoreRTL");
			Localize.NativeFieldInfoPtr_MaxCharactersInRTL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "MaxCharactersInRTL");
			Localize.NativeFieldInfoPtr_IgnoreNumbersInRTL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "IgnoreNumbersInRTL");
			Localize.NativeFieldInfoPtr_CorrectAlignmentForRTL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "CorrectAlignmentForRTL");
			Localize.NativeFieldInfoPtr_AddSpacesToJoinedLanguages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "AddSpacesToJoinedLanguages");
			Localize.NativeFieldInfoPtr_AllowLocalizedParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "AllowLocalizedParameters");
			Localize.NativeFieldInfoPtr_AllowParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "AllowParameters");
			Localize.NativeFieldInfoPtr_TranslatedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "TranslatedObjects");
			Localize.NativeFieldInfoPtr_mAssetDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "mAssetDictionary");
			Localize.NativeFieldInfoPtr_LocalizeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "LocalizeEvent");
			Localize.NativeFieldInfoPtr_MainTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "MainTranslation");
			Localize.NativeFieldInfoPtr_SecondaryTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "SecondaryTranslation");
			Localize.NativeFieldInfoPtr_CallBackTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "CallBackTerm");
			Localize.NativeFieldInfoPtr_CallBackSecondaryTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "CallBackSecondaryTerm");
			Localize.NativeFieldInfoPtr_CurrentLocalizeComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "CurrentLocalizeComponent");
			Localize.NativeFieldInfoPtr_AlwaysForceLocalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "AlwaysForceLocalize");
			Localize.NativeFieldInfoPtr_LocalizeCallBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "LocalizeCallBack");
			Localize.NativeFieldInfoPtr_mGUI_ShowReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "mGUI_ShowReferences");
			Localize.NativeFieldInfoPtr_mGUI_ShowTems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "mGUI_ShowTems");
			Localize.NativeFieldInfoPtr_mGUI_ShowCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "mGUI_ShowCallback");
			Localize.NativeFieldInfoPtr_mLocalizeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "mLocalizeTarget");
			Localize.NativeFieldInfoPtr_mLocalizeTargetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize>.NativeClassPtr, "mLocalizeTargetName");
			Localize.NativeMethodInfoPtr_get_Term_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670046);
			Localize.NativeMethodInfoPtr_set_Term_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670047);
			Localize.NativeMethodInfoPtr_get_SecondaryTerm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670048);
			Localize.NativeMethodInfoPtr_set_SecondaryTerm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670049);
			Localize.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670050);
			Localize.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670051);
			Localize.NativeMethodInfoPtr_HasCallback_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670052);
			Localize.NativeMethodInfoPtr_OnLocalize_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670053);
			Localize.NativeMethodInfoPtr_FindTarget_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670054);
			Localize.NativeMethodInfoPtr_GetFinalTerms_Public_Void_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670055);
			Localize.NativeMethodInfoPtr_GetMainTargetsText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670056);
			Localize.NativeMethodInfoPtr_SetFinalTerms_Public_Void_String_String_byref_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670057);
			Localize.NativeMethodInfoPtr_SetTerm_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670058);
			Localize.NativeMethodInfoPtr_SetTerm_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670059);
			Localize.NativeMethodInfoPtr_GetSecondaryTranslatedObj_Internal_T_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670060);
			Localize.NativeMethodInfoPtr_UpdateAssetDictionary_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670061);
			Localize.NativeMethodInfoPtr_GetObject_Internal_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670062);
			Localize.NativeMethodInfoPtr_GetTranslatedObject_Private_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670063);
			Localize.NativeMethodInfoPtr_DeserializeTranslation_Private_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670064);
			Localize.NativeMethodInfoPtr_FindTranslatedObject_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670065);
			Localize.NativeMethodInfoPtr_HasTranslatedObject_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670066);
			Localize.NativeMethodInfoPtr_AddTranslatedObject_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670067);
			Localize.NativeMethodInfoPtr_SetGlobalLanguage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670068);
			Localize.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize>.NativeClassPtr, 100670069);
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x06004428 RID: 17448 RVA: 0x000FDCD4 File Offset: 0x000FBED4
		// (set) Token: 0x06004429 RID: 17449 RVA: 0x000FDD0C File Offset: 0x000FBF0C
		public unsafe string Term
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_get_Term_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110726, XrefRangeEnd = 110727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_set_Term_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x000FDD50 File Offset: 0x000FBF50
		// (set) Token: 0x0600442B RID: 17451 RVA: 0x000FDD88 File Offset: 0x000FBF88
		public unsafe string SecondaryTerm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_get_SecondaryTerm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110727, XrefRangeEnd = 110728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_set_SecondaryTerm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x000FDDCC File Offset: 0x000FBFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110728, XrefRangeEnd = 110731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x000FDE00 File Offset: 0x000FC000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110731, XrefRangeEnd = 110732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x000FDE34 File Offset: 0x000FC034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110734, RefRangeEnd = 110736, XrefRangeStart = 110732, XrefRangeEnd = 110734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_HasCallback_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x000FDE70 File Offset: 0x000FC070
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 110889, RefRangeEnd = 110898, XrefRangeStart = 110736, XrefRangeEnd = 110889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalize(bool Force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_OnLocalize_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x000FDEB0 File Offset: 0x000FC0B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110917, RefRangeEnd = 110920, XrefRangeStart = 110898, XrefRangeEnd = 110917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FindTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_FindTarget_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x000FDEEC File Offset: 0x000FC0EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110939, RefRangeEnd = 110940, XrefRangeStart = 110920, XrefRangeEnd = 110939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_GetFinalTerms_Public_Void_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			primaryTerm = IL2CPP.Il2CppStringToManaged(intPtr);
			secondaryTerm = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x000FDF50 File Offset: 0x000FC150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110940, XrefRangeEnd = 110952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMainTargetsText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_GetMainTargetsText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x000FDF88 File Offset: 0x000FC188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110952, XrefRangeEnd = 110953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Main);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Secondary);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref RemoveNonASCII;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_SetFinalTerms_Public_Void_String_String_byref_String_byref_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			primaryTerm = IL2CPP.Il2CppStringToManaged(intPtr);
			secondaryTerm = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x000FE020 File Offset: 0x000FC220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTerm(string primary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(primary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_SetTerm_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x000FE064 File Offset: 0x000FC264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110953, XrefRangeEnd = 110954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTerm(string primary, string secondary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(primary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secondary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_SetTerm_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x000FE0B8 File Offset: 0x000FC2B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 110987, RefRangeEnd = 110994, XrefRangeStart = 110954, XrefRangeEnd = 110987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(mainTranslation);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(secondaryTranslation);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Localize.MethodInfoStoreGeneric_GetSecondaryTranslatedObj_Internal_T_byref_String_byref_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			mainTranslation = IL2CPP.Il2CppStringToManaged(intPtr);
			secondaryTranslation = IL2CPP.Il2CppStringToManaged(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x000FE134 File Offset: 0x000FC334
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 111054, RefRangeEnd = 111057, XrefRangeStart = 110994, XrefRangeEnd = 111054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAssetDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_UpdateAssetDictionary_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x000FE168 File Offset: 0x000FC368
		[CallerCount(0)]
		public unsafe T GetObject<T>(string Translation) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Translation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.MethodInfoStoreGeneric_GetObject_Internal_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x000FE1B4 File Offset: 0x000FC3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111057, XrefRangeEnd = 111058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetTranslatedObject<T>(string Translation) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Translation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.MethodInfoStoreGeneric_GetTranslatedObject_Private_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x000FE200 File Offset: 0x000FC400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111058, XrefRangeEnd = 111066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeTranslation(string translation, out string value, out string secondary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(translation);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_DeserializeTranslation_Private_Void_String_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			secondary = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x000FE278 File Offset: 0x000FC478
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 111112, RefRangeEnd = 111121, XrefRangeStart = 111066, XrefRangeEnd = 111112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T FindTranslatedObject<T>(string value) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.MethodInfoStoreGeneric_FindTranslatedObject_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x000FE2C4 File Offset: 0x000FC4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111121, XrefRangeEnd = 111127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasTranslatedObject(global::UnityEngine.Object Obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_HasTranslatedObject_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x000FE314 File Offset: 0x000FC514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111127, XrefRangeEnd = 111134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTranslatedObject(global::UnityEngine.Object Obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_AddTranslatedObject_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x000FE358 File Offset: 0x000FC558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111134, XrefRangeEnd = 111138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalLanguage(string Language)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Language);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr_SetGlobalLanguage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x000FE39C File Offset: 0x000FC59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111138, XrefRangeEnd = 111168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Localize()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Localize>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00029368 File Offset: 0x00027568
		public Localize(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06004441 RID: 17473 RVA: 0x000FE3D8 File Offset: 0x000FC5D8
		// (set) Token: 0x06004442 RID: 17474 RVA: 0x00029371 File Offset: 0x00027571
		public unsafe string mTerm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x000FE400 File Offset: 0x000FC600
		// (set) Token: 0x06004444 RID: 17476 RVA: 0x00029390 File Offset: 0x00027590
		public unsafe string mTermSecondary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mTermSecondary);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mTermSecondary), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06004445 RID: 17477 RVA: 0x000FE428 File Offset: 0x000FC628
		// (set) Token: 0x06004446 RID: 17478 RVA: 0x000293AF File Offset: 0x000275AF
		public unsafe string FinalTerm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_FinalTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_FinalTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x000FE450 File Offset: 0x000FC650
		// (set) Token: 0x06004448 RID: 17480 RVA: 0x000293CE File Offset: 0x000275CE
		public unsafe string FinalSecondaryTerm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_FinalSecondaryTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_FinalSecondaryTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x06004449 RID: 17481 RVA: 0x000FE478 File Offset: 0x000FC678
		// (set) Token: 0x0600444A RID: 17482 RVA: 0x000293ED File Offset: 0x000275ED
		public unsafe Localize.TermModification PrimaryTermModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_PrimaryTermModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_PrimaryTermModifier)) = value;
			}
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x0600444B RID: 17483 RVA: 0x000FE4A0 File Offset: 0x000FC6A0
		// (set) Token: 0x0600444C RID: 17484 RVA: 0x00029408 File Offset: 0x00027608
		public unsafe Localize.TermModification SecondaryTermModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_SecondaryTermModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_SecondaryTermModifier)) = value;
			}
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x000FE4C8 File Offset: 0x000FC6C8
		// (set) Token: 0x0600444E RID: 17486 RVA: 0x00029423 File Offset: 0x00027623
		public unsafe string TermPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_TermPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_TermPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x0600444F RID: 17487 RVA: 0x000FE4F0 File Offset: 0x000FC6F0
		// (set) Token: 0x06004450 RID: 17488 RVA: 0x00029442 File Offset: 0x00027642
		public unsafe string TermSuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_TermSuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_TermSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06004451 RID: 17489 RVA: 0x000FE518 File Offset: 0x000FC718
		// (set) Token: 0x06004452 RID: 17490 RVA: 0x00029461 File Offset: 0x00027661
		public unsafe bool LocalizeOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_LocalizeOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_LocalizeOnAwake)) = value;
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06004453 RID: 17491 RVA: 0x000FE540 File Offset: 0x000FC740
		// (set) Token: 0x06004454 RID: 17492 RVA: 0x0002947C File Offset: 0x0002767C
		public unsafe string LastLocalizedLanguage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_LastLocalizedLanguage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_LastLocalizedLanguage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06004455 RID: 17493 RVA: 0x000FE568 File Offset: 0x000FC768
		// (set) Token: 0x06004456 RID: 17494 RVA: 0x0002949B File Offset: 0x0002769B
		public unsafe bool IgnoreRTL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_IgnoreRTL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_IgnoreRTL)) = value;
			}
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x06004457 RID: 17495 RVA: 0x000FE590 File Offset: 0x000FC790
		// (set) Token: 0x06004458 RID: 17496 RVA: 0x000294B6 File Offset: 0x000276B6
		public unsafe int MaxCharactersInRTL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_MaxCharactersInRTL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_MaxCharactersInRTL)) = value;
			}
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06004459 RID: 17497 RVA: 0x000FE5B8 File Offset: 0x000FC7B8
		// (set) Token: 0x0600445A RID: 17498 RVA: 0x000294D1 File Offset: 0x000276D1
		public unsafe bool IgnoreNumbersInRTL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_IgnoreNumbersInRTL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_IgnoreNumbersInRTL)) = value;
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x0600445B RID: 17499 RVA: 0x000FE5E0 File Offset: 0x000FC7E0
		// (set) Token: 0x0600445C RID: 17500 RVA: 0x000294EC File Offset: 0x000276EC
		public unsafe bool CorrectAlignmentForRTL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_CorrectAlignmentForRTL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_CorrectAlignmentForRTL)) = value;
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x000FE608 File Offset: 0x000FC808
		// (set) Token: 0x0600445E RID: 17502 RVA: 0x00029507 File Offset: 0x00027707
		public unsafe bool AddSpacesToJoinedLanguages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_AddSpacesToJoinedLanguages);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_AddSpacesToJoinedLanguages)) = value;
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x000FE630 File Offset: 0x000FC830
		// (set) Token: 0x06004460 RID: 17504 RVA: 0x00029522 File Offset: 0x00027722
		public unsafe bool AllowLocalizedParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_AllowLocalizedParameters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_AllowLocalizedParameters)) = value;
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06004461 RID: 17505 RVA: 0x000FE658 File Offset: 0x000FC858
		// (set) Token: 0x06004462 RID: 17506 RVA: 0x0002953D File Offset: 0x0002773D
		public unsafe bool AllowParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_AllowParameters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_AllowParameters)) = value;
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x06004463 RID: 17507 RVA: 0x000FE680 File Offset: 0x000FC880
		// (set) Token: 0x06004464 RID: 17508 RVA: 0x00029558 File Offset: 0x00027758
		public unsafe List<global::UnityEngine.Object> TranslatedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_TranslatedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_TranslatedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06004465 RID: 17509 RVA: 0x000FE6B0 File Offset: 0x000FC8B0
		// (set) Token: 0x06004466 RID: 17510 RVA: 0x00029577 File Offset: 0x00027777
		public unsafe Dictionary<string, global::UnityEngine.Object> mAssetDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mAssetDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mAssetDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x000FE6E0 File Offset: 0x000FC8E0
		// (set) Token: 0x06004468 RID: 17512 RVA: 0x00029596 File Offset: 0x00027796
		public unsafe UnityEvent LocalizeEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_LocalizeEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_LocalizeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x000FE710 File Offset: 0x000FC910
		// (set) Token: 0x0600446A RID: 17514 RVA: 0x000295B5 File Offset: 0x000277B5
		public unsafe static string MainTranslation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Localize.NativeFieldInfoPtr_MainTranslation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Localize.NativeFieldInfoPtr_MainTranslation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x000FE730 File Offset: 0x000FC930
		// (set) Token: 0x0600446C RID: 17516 RVA: 0x000295C7 File Offset: 0x000277C7
		public unsafe static string SecondaryTranslation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Localize.NativeFieldInfoPtr_SecondaryTranslation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Localize.NativeFieldInfoPtr_SecondaryTranslation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x000FE750 File Offset: 0x000FC950
		// (set) Token: 0x0600446E RID: 17518 RVA: 0x000295D9 File Offset: 0x000277D9
		public unsafe static string CallBackTerm
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Localize.NativeFieldInfoPtr_CallBackTerm, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Localize.NativeFieldInfoPtr_CallBackTerm, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x000FE770 File Offset: 0x000FC970
		// (set) Token: 0x06004470 RID: 17520 RVA: 0x000295EB File Offset: 0x000277EB
		public unsafe static string CallBackSecondaryTerm
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Localize.NativeFieldInfoPtr_CallBackSecondaryTerm, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Localize.NativeFieldInfoPtr_CallBackSecondaryTerm, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x06004471 RID: 17521 RVA: 0x000FE790 File Offset: 0x000FC990
		// (set) Token: 0x06004472 RID: 17522 RVA: 0x000295FD File Offset: 0x000277FD
		public unsafe static Localize CurrentLocalizeComponent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Localize.NativeFieldInfoPtr_CurrentLocalizeComponent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Localize>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Localize.NativeFieldInfoPtr_CurrentLocalizeComponent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x06004473 RID: 17523 RVA: 0x000FE7B8 File Offset: 0x000FC9B8
		// (set) Token: 0x06004474 RID: 17524 RVA: 0x0002960F File Offset: 0x0002780F
		public unsafe bool AlwaysForceLocalize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_AlwaysForceLocalize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_AlwaysForceLocalize)) = value;
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06004475 RID: 17525 RVA: 0x000FE7E0 File Offset: 0x000FC9E0
		// (set) Token: 0x06004476 RID: 17526 RVA: 0x0002962A File Offset: 0x0002782A
		public unsafe EventCallback LocalizeCallBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_LocalizeCallBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_LocalizeCallBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x000FE810 File Offset: 0x000FCA10
		// (set) Token: 0x06004478 RID: 17528 RVA: 0x00029649 File Offset: 0x00027849
		public unsafe bool mGUI_ShowReferences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mGUI_ShowReferences);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mGUI_ShowReferences)) = value;
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x06004479 RID: 17529 RVA: 0x000FE838 File Offset: 0x000FCA38
		// (set) Token: 0x0600447A RID: 17530 RVA: 0x00029664 File Offset: 0x00027864
		public unsafe bool mGUI_ShowTems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mGUI_ShowTems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mGUI_ShowTems)) = value;
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x000FE860 File Offset: 0x000FCA60
		// (set) Token: 0x0600447C RID: 17532 RVA: 0x0002967F File Offset: 0x0002787F
		public unsafe bool mGUI_ShowCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mGUI_ShowCallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mGUI_ShowCallback)) = value;
			}
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x000FE888 File Offset: 0x000FCA88
		// (set) Token: 0x0600447E RID: 17534 RVA: 0x0002969A File Offset: 0x0002789A
		public unsafe ILocalizeTarget mLocalizeTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mLocalizeTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILocalizeTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mLocalizeTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x0600447F RID: 17535 RVA: 0x000FE8B8 File Offset: 0x000FCAB8
		// (set) Token: 0x06004480 RID: 17536 RVA: 0x000296B9 File Offset: 0x000278B9
		public unsafe string mLocalizeTargetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mLocalizeTargetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localize.NativeFieldInfoPtr_mLocalizeTargetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002A0F RID: 10767
		private static readonly IntPtr NativeFieldInfoPtr_mTerm;

		// Token: 0x04002A10 RID: 10768
		private static readonly IntPtr NativeFieldInfoPtr_mTermSecondary;

		// Token: 0x04002A11 RID: 10769
		private static readonly IntPtr NativeFieldInfoPtr_FinalTerm;

		// Token: 0x04002A12 RID: 10770
		private static readonly IntPtr NativeFieldInfoPtr_FinalSecondaryTerm;

		// Token: 0x04002A13 RID: 10771
		private static readonly IntPtr NativeFieldInfoPtr_PrimaryTermModifier;

		// Token: 0x04002A14 RID: 10772
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryTermModifier;

		// Token: 0x04002A15 RID: 10773
		private static readonly IntPtr NativeFieldInfoPtr_TermPrefix;

		// Token: 0x04002A16 RID: 10774
		private static readonly IntPtr NativeFieldInfoPtr_TermSuffix;

		// Token: 0x04002A17 RID: 10775
		private static readonly IntPtr NativeFieldInfoPtr_LocalizeOnAwake;

		// Token: 0x04002A18 RID: 10776
		private static readonly IntPtr NativeFieldInfoPtr_LastLocalizedLanguage;

		// Token: 0x04002A19 RID: 10777
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreRTL;

		// Token: 0x04002A1A RID: 10778
		private static readonly IntPtr NativeFieldInfoPtr_MaxCharactersInRTL;

		// Token: 0x04002A1B RID: 10779
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreNumbersInRTL;

		// Token: 0x04002A1C RID: 10780
		private static readonly IntPtr NativeFieldInfoPtr_CorrectAlignmentForRTL;

		// Token: 0x04002A1D RID: 10781
		private static readonly IntPtr NativeFieldInfoPtr_AddSpacesToJoinedLanguages;

		// Token: 0x04002A1E RID: 10782
		private static readonly IntPtr NativeFieldInfoPtr_AllowLocalizedParameters;

		// Token: 0x04002A1F RID: 10783
		private static readonly IntPtr NativeFieldInfoPtr_AllowParameters;

		// Token: 0x04002A20 RID: 10784
		private static readonly IntPtr NativeFieldInfoPtr_TranslatedObjects;

		// Token: 0x04002A21 RID: 10785
		private static readonly IntPtr NativeFieldInfoPtr_mAssetDictionary;

		// Token: 0x04002A22 RID: 10786
		private static readonly IntPtr NativeFieldInfoPtr_LocalizeEvent;

		// Token: 0x04002A23 RID: 10787
		private static readonly IntPtr NativeFieldInfoPtr_MainTranslation;

		// Token: 0x04002A24 RID: 10788
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryTranslation;

		// Token: 0x04002A25 RID: 10789
		private static readonly IntPtr NativeFieldInfoPtr_CallBackTerm;

		// Token: 0x04002A26 RID: 10790
		private static readonly IntPtr NativeFieldInfoPtr_CallBackSecondaryTerm;

		// Token: 0x04002A27 RID: 10791
		private static readonly IntPtr NativeFieldInfoPtr_CurrentLocalizeComponent;

		// Token: 0x04002A28 RID: 10792
		private static readonly IntPtr NativeFieldInfoPtr_AlwaysForceLocalize;

		// Token: 0x04002A29 RID: 10793
		private static readonly IntPtr NativeFieldInfoPtr_LocalizeCallBack;

		// Token: 0x04002A2A RID: 10794
		private static readonly IntPtr NativeFieldInfoPtr_mGUI_ShowReferences;

		// Token: 0x04002A2B RID: 10795
		private static readonly IntPtr NativeFieldInfoPtr_mGUI_ShowTems;

		// Token: 0x04002A2C RID: 10796
		private static readonly IntPtr NativeFieldInfoPtr_mGUI_ShowCallback;

		// Token: 0x04002A2D RID: 10797
		private static readonly IntPtr NativeFieldInfoPtr_mLocalizeTarget;

		// Token: 0x04002A2E RID: 10798
		private static readonly IntPtr NativeFieldInfoPtr_mLocalizeTargetName;

		// Token: 0x04002A2F RID: 10799
		private static readonly IntPtr NativeMethodInfoPtr_get_Term_Public_get_String_0;

		// Token: 0x04002A30 RID: 10800
		private static readonly IntPtr NativeMethodInfoPtr_set_Term_Public_set_Void_String_0;

		// Token: 0x04002A31 RID: 10801
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondaryTerm_Public_get_String_0;

		// Token: 0x04002A32 RID: 10802
		private static readonly IntPtr NativeMethodInfoPtr_set_SecondaryTerm_Public_set_Void_String_0;

		// Token: 0x04002A33 RID: 10803
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002A34 RID: 10804
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04002A35 RID: 10805
		private static readonly IntPtr NativeMethodInfoPtr_HasCallback_Public_Boolean_0;

		// Token: 0x04002A36 RID: 10806
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalize_Public_Void_Boolean_0;

		// Token: 0x04002A37 RID: 10807
		private static readonly IntPtr NativeMethodInfoPtr_FindTarget_Public_Boolean_0;

		// Token: 0x04002A38 RID: 10808
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalTerms_Public_Void_byref_String_byref_String_0;

		// Token: 0x04002A39 RID: 10809
		private static readonly IntPtr NativeMethodInfoPtr_GetMainTargetsText_Public_String_0;

		// Token: 0x04002A3A RID: 10810
		private static readonly IntPtr NativeMethodInfoPtr_SetFinalTerms_Public_Void_String_String_byref_String_byref_String_Boolean_0;

		// Token: 0x04002A3B RID: 10811
		private static readonly IntPtr NativeMethodInfoPtr_SetTerm_Public_Void_String_0;

		// Token: 0x04002A3C RID: 10812
		private static readonly IntPtr NativeMethodInfoPtr_SetTerm_Public_Void_String_String_0;

		// Token: 0x04002A3D RID: 10813
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTranslatedObj_Internal_T_byref_String_byref_String_0;

		// Token: 0x04002A3E RID: 10814
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAssetDictionary_Public_Void_0;

		// Token: 0x04002A3F RID: 10815
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Internal_T_String_0;

		// Token: 0x04002A40 RID: 10816
		private static readonly IntPtr NativeMethodInfoPtr_GetTranslatedObject_Private_T_String_0;

		// Token: 0x04002A41 RID: 10817
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeTranslation_Private_Void_String_byref_String_byref_String_0;

		// Token: 0x04002A42 RID: 10818
		private static readonly IntPtr NativeMethodInfoPtr_FindTranslatedObject_Public_T_String_0;

		// Token: 0x04002A43 RID: 10819
		private static readonly IntPtr NativeMethodInfoPtr_HasTranslatedObject_Public_Boolean_Object_0;

		// Token: 0x04002A44 RID: 10820
		private static readonly IntPtr NativeMethodInfoPtr_AddTranslatedObject_Public_Void_Object_0;

		// Token: 0x04002A45 RID: 10821
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalLanguage_Public_Void_String_0;

		// Token: 0x04002A46 RID: 10822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C4 RID: 964
		[OriginalName("Assembly-CSharp.dll", "", "TermModification")]
		public enum TermModification
		{
			// Token: 0x04003BD4 RID: 15316
			DontModify,
			// Token: 0x04003BD5 RID: 15317
			ToUpper,
			// Token: 0x04003BD6 RID: 15318
			ToLower,
			// Token: 0x04003BD7 RID: 15319
			ToUpperFirst,
			// Token: 0x04003BD8 RID: 15320
			ToTitle
		}

		// Token: 0x020003C5 RID: 965
		[ObfuscatedName("I2.Loc.Localize+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06005A04 RID: 23044 RVA: 0x00145658 File Offset: 0x00143858
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Localize.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Localize>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr);
				Localize.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr, "<>9");
				Localize.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr, "<>9__50_0");
				Localize.__c.NativeFieldInfoPtr___9__50_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr, "<>9__50_1");
				Localize.__c.NativeFieldInfoPtr___9__50_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr, "<>9__50_2");
				Localize.__c.NativeFieldInfoPtr___9__50_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr, "<>9__50_3");
				Localize.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr, 100670071);
				Localize.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__50_0_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr, 100670072);
				Localize.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__50_1_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr, 100670073);
				Localize.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__50_2_Internal_String_IGrouping_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr, 100670074);
				Localize.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__50_3_Internal_Object_IGrouping_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr, 100670075);
			}

			// Token: 0x06005A05 RID: 23045 RVA: 0x0014574C File Offset: 0x0014394C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Localize.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A06 RID: 23046 RVA: 0x00145788 File Offset: 0x00143988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110707, XrefRangeEnd = 110719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateAssetDictionary_b__50_0(global::UnityEngine.Object x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__50_0_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A07 RID: 23047 RVA: 0x001457D8 File Offset: 0x001439D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _UpdateAssetDictionary_b__50_1(global::UnityEngine.Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__50_1_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005A08 RID: 23048 RVA: 0x00145820 File Offset: 0x00143A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110719, XrefRangeEnd = 110723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _UpdateAssetDictionary_b__50_2(IGrouping<string, global::UnityEngine.Object> g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__50_2_Internal_String_IGrouping_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005A09 RID: 23049 RVA: 0x00145868 File Offset: 0x00143A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110723, XrefRangeEnd = 110726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe global::UnityEngine.Object _UpdateAssetDictionary_b__50_3(IGrouping<string, global::UnityEngine.Object> g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localize.__c.NativeMethodInfoPtr__UpdateAssetDictionary_b__50_3_Internal_Object_IGrouping_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A0A RID: 23050 RVA: 0x00033813 File Offset: 0x00031A13
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020D8 RID: 8408
			// (get) Token: 0x06005A0B RID: 23051 RVA: 0x001458B8 File Offset: 0x00143AB8
			// (set) Token: 0x06005A0C RID: 23052 RVA: 0x0003381C File Offset: 0x00031A1C
			public unsafe static Localize.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Localize.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Localize.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Localize.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020D9 RID: 8409
			// (get) Token: 0x06005A0D RID: 23053 RVA: 0x001458E0 File Offset: 0x00143AE0
			// (set) Token: 0x06005A0E RID: 23054 RVA: 0x0003382E File Offset: 0x00031A2E
			public unsafe static Predicate<global::UnityEngine.Object> __9__50_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Localize.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<global::UnityEngine.Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Localize.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020DA RID: 8410
			// (get) Token: 0x06005A0F RID: 23055 RVA: 0x00145908 File Offset: 0x00143B08
			// (set) Token: 0x06005A10 RID: 23056 RVA: 0x00033840 File Offset: 0x00031A40
			public unsafe static Func<global::UnityEngine.Object, string> __9__50_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Localize.__c.NativeFieldInfoPtr___9__50_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<global::UnityEngine.Object, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Localize.__c.NativeFieldInfoPtr___9__50_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020DB RID: 8411
			// (get) Token: 0x06005A11 RID: 23057 RVA: 0x00145930 File Offset: 0x00143B30
			// (set) Token: 0x06005A12 RID: 23058 RVA: 0x00033852 File Offset: 0x00031A52
			public unsafe static Func<IGrouping<string, global::UnityEngine.Object>, string> __9__50_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Localize.__c.NativeFieldInfoPtr___9__50_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, global::UnityEngine.Object>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Localize.__c.NativeFieldInfoPtr___9__50_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020DC RID: 8412
			// (get) Token: 0x06005A13 RID: 23059 RVA: 0x00145958 File Offset: 0x00143B58
			// (set) Token: 0x06005A14 RID: 23060 RVA: 0x00033864 File Offset: 0x00031A64
			public unsafe static Func<IGrouping<string, global::UnityEngine.Object>, global::UnityEngine.Object> __9__50_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Localize.__c.NativeFieldInfoPtr___9__50_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, global::UnityEngine.Object>, global::UnityEngine.Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Localize.__c.NativeFieldInfoPtr___9__50_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BD9 RID: 15321
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003BDA RID: 15322
			private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

			// Token: 0x04003BDB RID: 15323
			private static readonly IntPtr NativeFieldInfoPtr___9__50_1;

			// Token: 0x04003BDC RID: 15324
			private static readonly IntPtr NativeFieldInfoPtr___9__50_2;

			// Token: 0x04003BDD RID: 15325
			private static readonly IntPtr NativeFieldInfoPtr___9__50_3;

			// Token: 0x04003BDE RID: 15326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BDF RID: 15327
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAssetDictionary_b__50_0_Internal_Boolean_Object_0;

			// Token: 0x04003BE0 RID: 15328
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAssetDictionary_b__50_1_Internal_String_Object_0;

			// Token: 0x04003BE1 RID: 15329
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAssetDictionary_b__50_2_Internal_String_IGrouping_2_String_Object_0;

			// Token: 0x04003BE2 RID: 15330
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAssetDictionary_b__50_3_Internal_Object_IGrouping_2_String_Object_0;
		}

		// Token: 0x020003C6 RID: 966
		private sealed class MethodInfoStoreGeneric_GetSecondaryTranslatedObj_Internal_T_byref_String_byref_String_0<T>
		{
			// Token: 0x04003BE3 RID: 15331
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Localize.NativeMethodInfoPtr_GetSecondaryTranslatedObj_Internal_T_byref_String_byref_String_0, Il2CppClassPointerStore<Localize>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003C7 RID: 967
		private sealed class MethodInfoStoreGeneric_GetObject_Internal_T_String_0<T>
		{
			// Token: 0x04003BE4 RID: 15332
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Localize.NativeMethodInfoPtr_GetObject_Internal_T_String_0, Il2CppClassPointerStore<Localize>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003C8 RID: 968
		private sealed class MethodInfoStoreGeneric_GetTranslatedObject_Private_T_String_0<T>
		{
			// Token: 0x04003BE5 RID: 15333
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Localize.NativeMethodInfoPtr_GetTranslatedObject_Private_T_String_0, Il2CppClassPointerStore<Localize>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003C9 RID: 969
		private sealed class MethodInfoStoreGeneric_FindTranslatedObject_Public_T_String_0<T>
		{
			// Token: 0x04003BE6 RID: 15334
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Localize.NativeMethodInfoPtr_FindTranslatedObject_Public_T_String_0, Il2CppClassPointerStore<Localize>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
