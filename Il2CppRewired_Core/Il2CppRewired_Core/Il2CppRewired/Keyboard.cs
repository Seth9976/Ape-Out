using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200006F RID: 111
	public sealed class Keyboard : ControllerWithMap
	{
		// Token: 0x06000F61 RID: 3937 RVA: 0x00065E78 File Offset: 0x00064078
		// Note: this type is marked as 'beforefieldinit'.
		static Keyboard()
		{
			Il2CppClassPointerStore<Keyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "Keyboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyboard>.NativeClassPtr);
			Keyboard.NativeFieldInfoPtr_ZNibkCKwJbeAOxZdsrMSpgvEMGiI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "ZNibkCKwJbeAOxZdsrMSpgvEMGiI");
			Keyboard.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "qtbpemUQyoPTMaHrxCYIFOqVxvz");
			Keyboard.NativeFieldInfoPtr_pSQAtFlHSYtgfsIdcFmjjwUOBibm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "pSQAtFlHSYtgfsIdcFmjjwUOBibm");
			Keyboard.NativeFieldInfoPtr_BtnSAkUYTyMfhVKOctPSpGHXBSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "BtnSAkUYTyMfhVKOctPSpGHXBSE");
			Keyboard.NativeFieldInfoPtr_gDkZMgdfLopFlWmLsURoblhHOrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "gDkZMgdfLopFlWmLsURoblhHOrs");
			Keyboard.NativeFieldInfoPtr_iGppYSmdCQQOOAuolPgqgTBkCRm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "iGppYSmdCQQOOAuolPgqgTBkCRm");
			Keyboard.NativeFieldInfoPtr_tBzdgIIaxwOgkColCkJvADAfZUfU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "tBzdgIIaxwOgkColCkJvADAfZUfU");
			Keyboard.NativeFieldInfoPtr_wSOrwFBNHJCgwHpdCNaWBdHhEjOI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "wSOrwFBNHJCgwHpdCNaWBdHhEjOI");
			Keyboard.NativeFieldInfoPtr_zOKGWxVZlauLMyWkKaSvRmejxUJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "zOKGWxVZlauLMyWkKaSvRmejxUJ");
			Keyboard.NativeMethodInfoPtr_get_keyIndexToKeyboardKeyCode_Private_Static_get_Il2CppStructArray_1_KeyboardKeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665720);
			Keyboard.NativeMethodInfoPtr__ctor_Internal_Void_String_IUnifiedKeyboardSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665721);
			Keyboard.NativeMethodInfoPtr__ctor_Private_Void_Int32_InputSource_String_String_HardwareControllerMap_Game_Int32_Extension_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665722);
			Keyboard.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665723);
			Keyboard.NativeMethodInfoPtr_GetKey_Public_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665724);
			Keyboard.NativeMethodInfoPtr_GetKeyDown_Public_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665725);
			Keyboard.NativeMethodInfoPtr_GetKeyUp_Public_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665726);
			Keyboard.NativeMethodInfoPtr_GetKeyDoublePressHold_Public_Boolean_KeyCode_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665727);
			Keyboard.NativeMethodInfoPtr_GetKeyDoublePressHold_Public_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665728);
			Keyboard.NativeMethodInfoPtr_GetKeyDoublePressDown_Public_Boolean_KeyCode_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665729);
			Keyboard.NativeMethodInfoPtr_GetKeyDoublePressDown_Public_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665730);
			Keyboard.NativeMethodInfoPtr_GetKeyPrev_Public_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665731);
			Keyboard.NativeMethodInfoPtr_GetKeyTimePressed_Public_Double_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665732);
			Keyboard.NativeMethodInfoPtr_GetKeyTimeUnpressed_Public_Double_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665733);
			Keyboard.NativeMethodInfoPtr_GetModifierKey_Public_Boolean_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665734);
			Keyboard.NativeMethodInfoPtr_GetModifierKeyDown_Public_Boolean_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665735);
			Keyboard.NativeMethodInfoPtr_GetModifierKeyUp_Public_Boolean_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665736);
			Keyboard.NativeMethodInfoPtr_GetModifierKeyPrev_Public_Boolean_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665737);
			Keyboard.NativeMethodInfoPtr_GetModifierKeyTimePressed_Public_Double_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665738);
			Keyboard.NativeMethodInfoPtr_GetModifierKeyTimeUnpressed_Public_Double_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665739);
			Keyboard.NativeMethodInfoPtr_GetKeyCodeByButtonIndex_Public_KeyCode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665740);
			Keyboard.NativeMethodInfoPtr_GetKeyCodeById_Public_KeyCode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665741);
			Keyboard.NativeMethodInfoPtr_GetButtonIndexByKeyCode_Public_Int32_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665742);
			Keyboard.NativeMethodInfoPtr_GetElementIdentifierByKeyCode_Public_ControllerElementIdentifier_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665743);
			Keyboard.NativeMethodInfoPtr_PollForFirstKey_Public_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665744);
			Keyboard.NativeMethodInfoPtr_PollForAllKeys_Public_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665745);
			Keyboard.NativeMethodInfoPtr_PollForAllKeysDown_Public_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665746);
			Keyboard.NativeMethodInfoPtr_PollForFirstKeyDown_Public_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665747);
			Keyboard.NativeMethodInfoPtr_PollForFirstButton_Public_Virtual_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665748);
			Keyboard.NativeMethodInfoPtr_PollForFirstButtonDown_Public_Virtual_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665749);
			Keyboard.NativeMethodInfoPtr_PollForAllButtons_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665750);
			Keyboard.NativeMethodInfoPtr_PollForAllButtonsDown_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665751);
			Keyboard.NativeMethodInfoPtr_IsModifierKey_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665752);
			Keyboard.NativeMethodInfoPtr_fUYQhRKvGBNsiWQoRZftwcDTKlt_Internal_Static_Boolean_KeyboardKeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665753);
			Keyboard.NativeMethodInfoPtr_KeyCodeToModifierKey_Public_Static_ModifierKey_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665754);
			Keyboard.NativeMethodInfoPtr_KeyCodeToModifierKeyFlags_Public_Static_ModifierKeyFlags_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665755);
			Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsContain_Public_Static_Boolean_ModifierKeyFlags_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665756);
			Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsContain_Public_Static_Boolean_ModifierKeyFlags_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665757);
			Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsToModifierKey_Public_Static_ModifierKey_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665758);
			Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsToKeyCode_Public_Static_KeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665759);
			Keyboard.NativeMethodInfoPtr_ModifierKeyToModifierKeyFlags_Public_Static_ModifierKeyFlags_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665760);
			Keyboard.NativeMethodInfoPtr_GetKeyName_Public_Static_String_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665761);
			Keyboard.NativeMethodInfoPtr_GetKeyName_Public_Static_String_KeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665762);
			Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Static_String_ModifierKeyFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665763);
			Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Static_String_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665764);
			Keyboard.NativeMethodInfoPtr_zDXHhwdGJmDcxrjzwwHwpLvCcJm_Internal_Static_KeyboardKeyCode_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665765);
			Keyboard.NativeMethodInfoPtr_JmyCrkiVWuPeIdoteGYvtuTgytKl_Internal_Static_KeyCode_KeyboardKeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665766);
			Keyboard.NativeMethodInfoPtr_wiMNqBqGCUbqbBCiWJsizkcgEWpG_Internal_Static_ModifierKeyFlags_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665767);
			Keyboard.NativeMethodInfoPtr_LYCLlxLYMAjxXpJeiYVPoYDuvVV_Internal_Static_Int32_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665768);
			Keyboard.NativeMethodInfoPtr_GetKeyboardKeyCodeByButtonIndex_Internal_Static_KeyboardKeyCode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665769);
			Keyboard.NativeMethodInfoPtr_mGdgcuUqFniVVBrFpoJTxPUJkNlT_Internal_Static_Int32_KeyboardKeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665770);
			Keyboard.NativeMethodInfoPtr_AFuBkdymBQIYocVPAeklDagSGs_Internal_Static_Void_byref_Int32_byref_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665771);
			Keyboard.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665772);
			Keyboard.NativeMethodInfoPtr_LpvEleWOQVSsylyMWBUQwZeUvIZ_Internal_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665773);
			Keyboard.NativeMethodInfoPtr_LMsHZelDUTtCyPfElOCChmigCsa_Internal_Boolean_KeyboardKeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665774);
			Keyboard.NativeMethodInfoPtr_iSbpViPVgqGNmWxjGpGXRVtzLiA_Internal_Boolean_KeyboardKeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665775);
			Keyboard.NativeMethodInfoPtr_lIHEWntFKPZpNPKNBAwfXPqXyWP_Internal_Boolean_KeyboardKeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665776);
			Keyboard.NativeMethodInfoPtr_fIkfFWEMRWDcHIijwOzxqAGfkFS_Internal_Boolean_KeyboardKeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665777);
			Keyboard.NativeMethodInfoPtr_GetButtonIndex_Internal_Int32_KeyboardKeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665778);
			Keyboard.NativeMethodInfoPtr_BakeMap_Internal_Virtual_Void_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665779);
			Keyboard.NativeMethodInfoPtr_BakeActionElementMap_Internal_Virtual_Void_ControllerMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665780);
			Keyboard.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665781);
			Keyboard.NativeMethodInfoPtr_UNFuHXVPqxRkpHJqbeSGgbbZpipm_Private_Boolean_byref_Button_byref_Button_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665782);
			Keyboard.NativeMethodInfoPtr_FpINqVljWUTCEKDizhWnVrhouOO_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665783);
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0006645C File Offset: 0x0006465C
		public unsafe static Il2CppStructArray<KeyboardKeyCode> keyIndexToKeyboardKeyCode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257350, XrefRangeEnd = 257362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_get_keyIndexToKeyboardKeyCode_Private_Static_get_Il2CppStructArray_1_KeyboardKeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyboardKeyCode>>(intPtr3) : null;
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00066490 File Offset: 0x00064690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257416, RefRangeEnd = 257417, XrefRangeStart = 257362, XrefRangeEnd = 257416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Keyboard(string name, IUnifiedKeyboardSource source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Keyboard>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr__ctor_Internal_Void_String_IUnifiedKeyboardSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x000664F0 File Offset: 0x000646F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257417, XrefRangeEnd = 257424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Keyboard(int controllerId, InputSource inputSource, string name, string hardwareIdentifier, HardwareControllerMap_Game hardwareMap, int buttonCount, Controller.Extension extension, ControllerDataUpdater dataUpdater)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Keyboard>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareIdentifier);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareMap);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extension);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr__ctor_Private_Void_Int32_InputSource_String_String_HardwareControllerMap_Game_Int32_Extension_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x000665B4 File Offset: 0x000647B4
		public unsafe override Guid deviceInstanceGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257424, XrefRangeEnd = 257431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x000665F0 File Offset: 0x000647F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257438, RefRangeEnd = 257440, XrefRangeStart = 257431, XrefRangeEnd = 257438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetKey(KeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKey_Public_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0006663C File Offset: 0x0006483C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 257447, RefRangeEnd = 257460, XrefRangeStart = 257440, XrefRangeEnd = 257447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetKeyDown(KeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyDown_Public_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00066688 File Offset: 0x00064888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257460, XrefRangeEnd = 257467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetKeyUp(KeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyUp_Public_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x000666D4 File Offset: 0x000648D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257467, XrefRangeEnd = 257475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetKeyDoublePressHold(KeyCode keyCode, float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyDoublePressHold_Public_Boolean_KeyCode_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0006672C File Offset: 0x0006492C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257475, XrefRangeEnd = 257476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetKeyDoublePressHold(KeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyDoublePressHold_Public_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00066778 File Offset: 0x00064978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257476, XrefRangeEnd = 257484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetKeyDoublePressDown(KeyCode keyCode, float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyDoublePressDown_Public_Boolean_KeyCode_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000667D0 File Offset: 0x000649D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257484, XrefRangeEnd = 257491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetKeyDoublePressDown(KeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyDoublePressDown_Public_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0006681C File Offset: 0x00064A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257491, XrefRangeEnd = 257498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetKeyPrev(KeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyPrev_Public_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00066868 File Offset: 0x00064A68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257505, RefRangeEnd = 257507, XrefRangeStart = 257498, XrefRangeEnd = 257505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetKeyTimePressed(KeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyTimePressed_Public_Double_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000668B4 File Offset: 0x00064AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257507, XrefRangeEnd = 257514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetKeyTimeUnpressed(KeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyTimeUnpressed_Public_Double_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00066900 File Offset: 0x00064B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257514, XrefRangeEnd = 257521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetModifierKey(ModifierKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetModifierKey_Public_Boolean_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0006694C File Offset: 0x00064B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257521, XrefRangeEnd = 257530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetModifierKeyDown(ModifierKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetModifierKeyDown_Public_Boolean_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00066998 File Offset: 0x00064B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257530, XrefRangeEnd = 257539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetModifierKeyUp(ModifierKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetModifierKeyUp_Public_Boolean_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x000669E4 File Offset: 0x00064BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257539, XrefRangeEnd = 257546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetModifierKeyPrev(ModifierKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetModifierKeyPrev_Public_Boolean_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00066A30 File Offset: 0x00064C30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 257553, RefRangeEnd = 257557, XrefRangeStart = 257546, XrefRangeEnd = 257553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetModifierKeyTimePressed(ModifierKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetModifierKeyTimePressed_Public_Double_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00066A7C File Offset: 0x00064C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257557, XrefRangeEnd = 257564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetModifierKeyTimeUnpressed(ModifierKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetModifierKeyTimeUnpressed_Public_Double_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00066AC8 File Offset: 0x00064CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257564, XrefRangeEnd = 257571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyCode GetKeyCodeByButtonIndex(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyCodeByButtonIndex_Public_KeyCode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00066B14 File Offset: 0x00064D14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257583, RefRangeEnd = 257586, XrefRangeStart = 257571, XrefRangeEnd = 257583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyCode GetKeyCodeById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyCodeById_Public_KeyCode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00066B60 File Offset: 0x00064D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257586, XrefRangeEnd = 257590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetButtonIndexByKeyCode(KeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetButtonIndexByKeyCode_Public_Int32_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00066BAC File Offset: 0x00064DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257590, XrefRangeEnd = 257594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier GetElementIdentifierByKeyCode(KeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetElementIdentifierByKeyCode_Public_ControllerElementIdentifier_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00066BF8 File Offset: 0x00064DF8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 257613, RefRangeEnd = 257624, XrefRangeStart = 257594, XrefRangeEnd = 257613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerPollingInfo PollForFirstKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_PollForFirstKey_Public_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00066C30 File Offset: 0x00064E30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 257629, RefRangeEnd = 257636, XrefRangeStart = 257624, XrefRangeEnd = 257629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ControllerPollingInfo> PollForAllKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_PollForAllKeys_Public_IEnumerable_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00066C70 File Offset: 0x00064E70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 257641, RefRangeEnd = 257646, XrefRangeStart = 257636, XrefRangeEnd = 257641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ControllerPollingInfo> PollForAllKeysDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_PollForAllKeysDown_Public_IEnumerable_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00066CB0 File Offset: 0x00064EB0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 257665, RefRangeEnd = 257676, XrefRangeStart = 257646, XrefRangeEnd = 257665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerPollingInfo PollForFirstKeyDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_PollForFirstKeyDown_Public_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00066CE8 File Offset: 0x00064EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257676, XrefRangeEnd = 257677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ControllerPollingInfo PollForFirstButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_PollForFirstButton_Public_Virtual_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00066D20 File Offset: 0x00064F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257677, XrefRangeEnd = 257678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ControllerPollingInfo PollForFirstButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_PollForFirstButtonDown_Public_Virtual_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00066D58 File Offset: 0x00064F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257678, XrefRangeEnd = 257679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ControllerPollingInfo> PollForAllButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_PollForAllButtons_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00066D98 File Offset: 0x00064F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257679, XrefRangeEnd = 257680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ControllerPollingInfo> PollForAllButtonsDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_PollForAllButtonsDown_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00066DD8 File Offset: 0x00064FD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257680, RefRangeEnd = 257682, XrefRangeStart = 257680, XrefRangeEnd = 257680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsModifierKey(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_IsModifierKey_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00066E18 File Offset: 0x00065018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257680, RefRangeEnd = 257682, XrefRangeStart = 257680, XrefRangeEnd = 257682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool fUYQhRKvGBNsiWQoRZftwcDTKlt(KeyboardKeyCode A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_fUYQhRKvGBNsiWQoRZftwcDTKlt_Internal_Static_Boolean_KeyboardKeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00066E58 File Offset: 0x00065058
		[CallerCount(0)]
		public unsafe static ModifierKey KeyCodeToModifierKey(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_KeyCodeToModifierKey_Public_Static_ModifierKey_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00066E98 File Offset: 0x00065098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257682, RefRangeEnd = 257684, XrefRangeStart = 257682, XrefRangeEnd = 257682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ModifierKeyFlags KeyCodeToModifierKeyFlags(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_KeyCodeToModifierKeyFlags_Public_Static_ModifierKeyFlags_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00066ED8 File Offset: 0x000650D8
		[CallerCount(0)]
		public unsafe static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, ModifierKey key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsContain_Public_Static_Boolean_ModifierKeyFlags_ModifierKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00066F24 File Offset: 0x00065124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257684, RefRangeEnd = 257685, XrefRangeStart = 257684, XrefRangeEnd = 257684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, KeyCode key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsContain_Public_Static_Boolean_ModifierKeyFlags_KeyCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00066F70 File Offset: 0x00065170
		[CallerCount(0)]
		public unsafe static ModifierKey ModifierKeyFlagsToModifierKey(ModifierKeyFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsToModifierKey_Public_Static_ModifierKey_ModifierKeyFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00066FB0 File Offset: 0x000651B0
		[CallerCount(0)]
		public unsafe static KeyCode ModifierKeyFlagsToKeyCode(ModifierKeyFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsToKeyCode_Public_Static_KeyCode_ModifierKeyFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00066FF0 File Offset: 0x000651F0
		[CallerCount(0)]
		public unsafe static ModifierKeyFlags ModifierKeyToModifierKeyFlags(ModifierKey key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_ModifierKeyToModifierKeyFlags_Public_Static_ModifierKeyFlags_ModifierKey_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00067030 File Offset: 0x00065230
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 257691, RefRangeEnd = 257698, XrefRangeStart = 257685, XrefRangeEnd = 257691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetKeyName(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyName_Public_Static_String_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00067068 File Offset: 0x00065268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257698, XrefRangeEnd = 257703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetKeyName(KeyCode key, ModifierKeyFlags flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyName_Public_Static_String_KeyCode_ModifierKeyFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000670B0 File Offset: 0x000652B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 257728, RefRangeEnd = 257732, XrefRangeStart = 257703, XrefRangeEnd = 257728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ModifierKeyFlagsToString(ModifierKeyFlags flags, bool abbreviate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref abbreviate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Static_String_ModifierKeyFlags_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000670F8 File Offset: 0x000652F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257732, XrefRangeEnd = 257733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ModifierKeyFlagsToString(ModifierKeyFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Static_String_ModifierKeyFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00067130 File Offset: 0x00065330
		[CallerCount(0)]
		public unsafe static KeyboardKeyCode zDXHhwdGJmDcxrjzwwHwpLvCcJm(KeyCode A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_zDXHhwdGJmDcxrjzwwHwpLvCcJm_Internal_Static_KeyboardKeyCode_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00067170 File Offset: 0x00065370
		[CallerCount(0)]
		public unsafe static KeyCode JmyCrkiVWuPeIdoteGYvtuTgytKl(KeyboardKeyCode A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_JmyCrkiVWuPeIdoteGYvtuTgytKl_Internal_Static_KeyCode_KeyboardKeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000671B0 File Offset: 0x000653B0
		[CallerCount(0)]
		public unsafe static ModifierKeyFlags wiMNqBqGCUbqbBCiWJsizkcgEWpG(ModifierKeyFlags A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_wiMNqBqGCUbqbBCiWJsizkcgEWpG_Internal_Static_ModifierKeyFlags_ModifierKeyFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000671F0 File Offset: 0x000653F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257733, RefRangeEnd = 257734, XrefRangeStart = 257733, XrefRangeEnd = 257733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LYCLlxLYMAjxXpJeiYVPoYDuvVV(ModifierKeyFlags A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_LYCLlxLYMAjxXpJeiYVPoYDuvVV_Internal_Static_Int32_ModifierKeyFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00067230 File Offset: 0x00065430
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 257746, RefRangeEnd = 257750, XrefRangeStart = 257734, XrefRangeEnd = 257746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KeyboardKeyCode GetKeyboardKeyCodeByButtonIndex(int buttonIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetKeyboardKeyCodeByButtonIndex_Internal_Static_KeyboardKeyCode_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00067270 File Offset: 0x00065470
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 257755, RefRangeEnd = 257763, XrefRangeStart = 257750, XrefRangeEnd = 257755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mGdgcuUqFniVVBrFpoJTxPUJkNlT(KeyboardKeyCode A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_mGdgcuUqFniVVBrFpoJTxPUJkNlT_Internal_Static_Int32_KeyboardKeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000672B0 File Offset: 0x000654B0
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 257768, RefRangeEnd = 257794, XrefRangeStart = 257763, XrefRangeEnd = 257768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AFuBkdymBQIYocVPAeklDagSGs(ref int A_0, ref KeyCode A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_AFuBkdymBQIYocVPAeklDagSGs_Internal_Static_Void_byref_Int32_byref_KeyCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000672F0 File Offset: 0x000654F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257794, XrefRangeEnd = 257800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ZTVaYQHtFassaSGDSzEcxNiGpigu(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00067330 File Offset: 0x00065530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257817, RefRangeEnd = 257818, XrefRangeStart = 257800, XrefRangeEnd = 257817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LpvEleWOQVSsylyMWBUQwZeUvIZ(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_LpvEleWOQVSsylyMWBUQwZeUvIZ_Internal_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00067370 File Offset: 0x00065570
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257819, RefRangeEnd = 257821, XrefRangeStart = 257818, XrefRangeEnd = 257819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LMsHZelDUTtCyPfElOCChmigCsa(KeyboardKeyCode A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_LMsHZelDUTtCyPfElOCChmigCsa_Internal_Boolean_KeyboardKeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000673BC File Offset: 0x000655BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257821, XrefRangeEnd = 257822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool iSbpViPVgqGNmWxjGpGXRVtzLiA(KeyboardKeyCode A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_iSbpViPVgqGNmWxjGpGXRVtzLiA_Internal_Boolean_KeyboardKeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00067408 File Offset: 0x00065608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257829, RefRangeEnd = 257831, XrefRangeStart = 257822, XrefRangeEnd = 257829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool lIHEWntFKPZpNPKNBAwfXPqXyWP(KeyboardKeyCode A_1, ModifierKeyFlags A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_lIHEWntFKPZpNPKNBAwfXPqXyWP_Internal_Boolean_KeyboardKeyCode_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00067460 File Offset: 0x00065660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257831, XrefRangeEnd = 257843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool fIkfFWEMRWDcHIijwOzxqAGfkFS(KeyboardKeyCode A_1, ModifierKeyFlags A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_fIkfFWEMRWDcHIijwOzxqAGfkFS_Internal_Boolean_KeyboardKeyCode_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000674B8 File Offset: 0x000656B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257843, RefRangeEnd = 257844, XrefRangeStart = 257843, XrefRangeEnd = 257843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetButtonIndex(KeyboardKeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GetButtonIndex_Internal_Int32_KeyboardKeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00067504 File Offset: 0x00065704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257844, XrefRangeEnd = 257850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BakeMap(ControllerMap controllerMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_BakeMap_Internal_Virtual_Void_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00067548 File Offset: 0x00065748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257850, XrefRangeEnd = 257851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BakeActionElementMap(ControllerMap controllerMap, ActionElementMap map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(map);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_BakeActionElementMap_Internal_Virtual_Void_ControllerMap_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0006759C File Offset: 0x0006579C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257851, XrefRangeEnd = 257852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GMFpQqtyJcjzYToWCrZsZQAhPYh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x000675D0 File Offset: 0x000657D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 257860, RefRangeEnd = 257867, XrefRangeStart = 257852, XrefRangeEnd = 257860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UNFuHXVPqxRkpHJqbeSGgbbZpipm(out Controller.Button A_1, out Controller.Button A_2, ModifierKey A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_UNFuHXVPqxRkpHJqbeSGgbbZpipm_Private_Boolean_byref_Button_byref_Button_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			A_1 = ((intPtr5 == 0) ? null : new Controller.Button(intPtr5));
			IntPtr intPtr6 = intPtr2;
			A_2 = ((intPtr6 == 0) ? null : new Controller.Button(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00067660 File Offset: 0x00065860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257875, RefRangeEnd = 257876, XrefRangeStart = 257867, XrefRangeEnd = 257875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FpINqVljWUTCEKDizhWnVrhouOO()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.NativeMethodInfoPtr_FpINqVljWUTCEKDizhWnVrhouOO_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0000719B File Offset: 0x0000539B
		public Keyboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00067694 File Offset: 0x00065894
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x000071A4 File Offset: 0x000053A4
		public unsafe static Keyboard ZNibkCKwJbeAOxZdsrMSpgvEMGiI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Keyboard.NativeFieldInfoPtr_ZNibkCKwJbeAOxZdsrMSpgvEMGiI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Keyboard>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Keyboard.NativeFieldInfoPtr_ZNibkCKwJbeAOxZdsrMSpgvEMGiI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x000676BC File Offset: 0x000658BC
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x000071B6 File Offset: 0x000053B6
		public unsafe IUnifiedKeyboardSource qtbpemUQyoPTMaHrxCYIFOqVxvz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUnifiedKeyboardSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x000676EC File Offset: 0x000658EC
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x000071D5 File Offset: 0x000053D5
		public unsafe ModifierKeyFlags pSQAtFlHSYtgfsIdcFmjjwUOBibm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_pSQAtFlHSYtgfsIdcFmjjwUOBibm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_pSQAtFlHSYtgfsIdcFmjjwUOBibm)) = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00067714 File Offset: 0x00065914
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x000071F0 File Offset: 0x000053F0
		public unsafe ModifierKeyFlags BtnSAkUYTyMfhVKOctPSpGHXBSE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_BtnSAkUYTyMfhVKOctPSpGHXBSE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_BtnSAkUYTyMfhVKOctPSpGHXBSE)) = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x0006773C File Offset: 0x0006593C
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x0000720B File Offset: 0x0000540B
		public unsafe Func<KeyboardKeyCode, int> gDkZMgdfLopFlWmLsURoblhHOrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_gDkZMgdfLopFlWmLsURoblhHOrs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyboardKeyCode, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_gDkZMgdfLopFlWmLsURoblhHOrs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x0006776C File Offset: 0x0006596C
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x0000722A File Offset: 0x0000542A
		public unsafe Il2CppStructArray<int> iGppYSmdCQQOOAuolPgqgTBkCRm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_iGppYSmdCQQOOAuolPgqgTBkCRm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_iGppYSmdCQQOOAuolPgqgTBkCRm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x0006779C File Offset: 0x0006599C
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00007249 File Offset: 0x00005449
		public unsafe static Il2CppStructArray<KeyboardKeyCode> tBzdgIIaxwOgkColCkJvADAfZUfU
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Keyboard.NativeFieldInfoPtr_tBzdgIIaxwOgkColCkJvADAfZUfU, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyboardKeyCode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Keyboard.NativeFieldInfoPtr_tBzdgIIaxwOgkColCkJvADAfZUfU, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x000677C4 File Offset: 0x000659C4
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x0000725B File Offset: 0x0000545B
		public unsafe int wSOrwFBNHJCgwHpdCNaWBdHhEjOI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_wSOrwFBNHJCgwHpdCNaWBdHhEjOI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.NativeFieldInfoPtr_wSOrwFBNHJCgwHpdCNaWBdHhEjOI)) = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x000677EC File Offset: 0x000659EC
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x00007276 File Offset: 0x00005476
		public unsafe static Guid zOKGWxVZlauLMyWkKaSvRmejxUJ
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Keyboard.NativeFieldInfoPtr_zOKGWxVZlauLMyWkKaSvRmejxUJ, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Keyboard.NativeFieldInfoPtr_zOKGWxVZlauLMyWkKaSvRmejxUJ, (void*)(&value));
			}
		}

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr_ZNibkCKwJbeAOxZdsrMSpgvEMGiI;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeFieldInfoPtr_pSQAtFlHSYtgfsIdcFmjjwUOBibm;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeFieldInfoPtr_BtnSAkUYTyMfhVKOctPSpGHXBSE;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeFieldInfoPtr_gDkZMgdfLopFlWmLsURoblhHOrs;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeFieldInfoPtr_iGppYSmdCQQOOAuolPgqgTBkCRm;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeFieldInfoPtr_tBzdgIIaxwOgkColCkJvADAfZUfU;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeFieldInfoPtr_wSOrwFBNHJCgwHpdCNaWBdHhEjOI;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeFieldInfoPtr_zOKGWxVZlauLMyWkKaSvRmejxUJ;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_get_keyIndexToKeyboardKeyCode_Private_Static_get_Il2CppStructArray_1_KeyboardKeyCode_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_IUnifiedKeyboardSource_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_InputSource_String_String_HardwareControllerMap_Game_Int32_Extension_ControllerDataUpdater_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Boolean_KeyCode_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDown_Public_Boolean_KeyCode_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyUp_Public_Boolean_KeyCode_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDoublePressHold_Public_Boolean_KeyCode_Single_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDoublePressHold_Public_Boolean_KeyCode_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDoublePressDown_Public_Boolean_KeyCode_Single_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDoublePressDown_Public_Boolean_KeyCode_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyPrev_Public_Boolean_KeyCode_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyTimePressed_Public_Double_KeyCode_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyTimeUnpressed_Public_Double_KeyCode_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_GetModifierKey_Public_Boolean_ModifierKey_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_GetModifierKeyDown_Public_Boolean_ModifierKey_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_GetModifierKeyUp_Public_Boolean_ModifierKey_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_GetModifierKeyPrev_Public_Boolean_ModifierKey_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_GetModifierKeyTimePressed_Public_Double_ModifierKey_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_GetModifierKeyTimeUnpressed_Public_Double_ModifierKey_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyCodeByButtonIndex_Public_KeyCode_Int32_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyCodeById_Public_KeyCode_Int32_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonIndexByKeyCode_Public_Int32_KeyCode_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierByKeyCode_Public_ControllerElementIdentifier_KeyCode_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_PollForFirstKey_Public_ControllerPollingInfo_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_PollForAllKeys_Public_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_PollForAllKeysDown_Public_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_PollForFirstKeyDown_Public_ControllerPollingInfo_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_PollForFirstButton_Public_Virtual_ControllerPollingInfo_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_PollForFirstButtonDown_Public_Virtual_ControllerPollingInfo_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_PollForAllButtons_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_PollForAllButtonsDown_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_IsModifierKey_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_fUYQhRKvGBNsiWQoRZftwcDTKlt_Internal_Static_Boolean_KeyboardKeyCode_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_KeyCodeToModifierKey_Public_Static_ModifierKey_KeyCode_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_KeyCodeToModifierKeyFlags_Public_Static_ModifierKeyFlags_KeyCode_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_ModifierKeyFlagsContain_Public_Static_Boolean_ModifierKeyFlags_ModifierKey_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_ModifierKeyFlagsContain_Public_Static_Boolean_ModifierKeyFlags_KeyCode_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_ModifierKeyFlagsToModifierKey_Public_Static_ModifierKey_ModifierKeyFlags_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_ModifierKeyFlagsToKeyCode_Public_Static_KeyCode_ModifierKeyFlags_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_ModifierKeyToModifierKeyFlags_Public_Static_ModifierKeyFlags_ModifierKey_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyName_Public_Static_String_KeyCode_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyName_Public_Static_String_KeyCode_ModifierKeyFlags_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Static_String_ModifierKeyFlags_Boolean_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Static_String_ModifierKeyFlags_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_zDXHhwdGJmDcxrjzwwHwpLvCcJm_Internal_Static_KeyboardKeyCode_KeyCode_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_JmyCrkiVWuPeIdoteGYvtuTgytKl_Internal_Static_KeyCode_KeyboardKeyCode_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_wiMNqBqGCUbqbBCiWJsizkcgEWpG_Internal_Static_ModifierKeyFlags_ModifierKeyFlags_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_LYCLlxLYMAjxXpJeiYVPoYDuvVV_Internal_Static_Int32_ModifierKeyFlags_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyboardKeyCodeByButtonIndex_Internal_Static_KeyboardKeyCode_Int32_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_mGdgcuUqFniVVBrFpoJTxPUJkNlT_Internal_Static_Int32_KeyboardKeyCode_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_AFuBkdymBQIYocVPAeklDagSGs_Internal_Static_Void_byref_Int32_byref_KeyCode_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_LpvEleWOQVSsylyMWBUQwZeUvIZ_Internal_Void_UpdateLoopType_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_LMsHZelDUTtCyPfElOCChmigCsa_Internal_Boolean_KeyboardKeyCode_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_iSbpViPVgqGNmWxjGpGXRVtzLiA_Internal_Boolean_KeyboardKeyCode_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_lIHEWntFKPZpNPKNBAwfXPqXyWP_Internal_Boolean_KeyboardKeyCode_ModifierKeyFlags_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_fIkfFWEMRWDcHIijwOzxqAGfkFS_Internal_Boolean_KeyboardKeyCode_ModifierKeyFlags_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonIndex_Internal_Int32_KeyboardKeyCode_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_BakeMap_Internal_Virtual_Void_ControllerMap_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_BakeActionElementMap_Internal_Virtual_Void_ControllerMap_ActionElementMap_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_UNFuHXVPqxRkpHJqbeSGgbbZpipm_Private_Boolean_byref_Button_byref_Button_ModifierKey_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_FpINqVljWUTCEKDizhWnVrhouOO_Private_Void_0;

		// Token: 0x02000289 RID: 649
		public sealed class mgFKBpiBDaMcMyKaILUfPaDvGyZ : global::Il2CppSystem.Object
		{
			// Token: 0x06003B17 RID: 15127 RVA: 0x0011D0C8 File Offset: 0x0011B2C8
			// Note: this type is marked as 'beforefieldinit'.
			static mgFKBpiBDaMcMyKaILUfPaDvGyZ()
			{
				Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "mgFKBpiBDaMcMyKaILUfPaDvGyZ");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr);
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_TSwrRcCYkazQJeOykgDMDMJCimR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, "TSwrRcCYkazQJeOykgDMDMJCimR");
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, "hAStVwJVMBBvRtdqjAJKGEgHfju");
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_CtHfFrgTWxSHKMPevnUHqlghBrgv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, "CtHfFrgTWxSHKMPevnUHqlghBrgv");
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_PhaAbdAOytzIGPrVrWSVfoNLUVCq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, "PhaAbdAOytzIGPrVrWSVfoNLUVCq");
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, 100665784);
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, 100665785);
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, 100665786);
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, 100665787);
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, 100665788);
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, 100665789);
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, 100665790);
				Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr, 100665791);
			}

			// Token: 0x06003B18 RID: 15128 RVA: 0x0011D234 File Offset: 0x0011B434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257284, XrefRangeEnd = 257287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerPollingInfo> System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerPollingInfo>>(intPtr3) : null;
			}

			// Token: 0x06003B19 RID: 15129 RVA: 0x0011D274 File Offset: 0x0011B474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003B1A RID: 15130 RVA: 0x0011D2B4 File Offset: 0x0011B4B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257287, XrefRangeEnd = 257309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170011D2 RID: 4562
			// (get) Token: 0x06003B1B RID: 15131 RVA: 0x0011D2F0 File Offset: 0x0011B4F0
			public unsafe ControllerPollingInfo eQOjYWBVDjtNugCRnQImrgdgoxJ
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ControllerPollingInfo(intPtr);
				}
			}

			// Token: 0x06003B1C RID: 15132 RVA: 0x0011D328 File Offset: 0x0011B528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257309, XrefRangeEnd = 257314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B1D RID: 15133 RVA: 0x0011D35C File Offset: 0x0011B55C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011D3 RID: 4563
			// (get) Token: 0x06003B1E RID: 15134 RVA: 0x0011D390 File Offset: 0x0011B590
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257314, XrefRangeEnd = 257317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003B1F RID: 15135 RVA: 0x0011D3D0 File Offset: 0x0011B5D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe mgFKBpiBDaMcMyKaILUfPaDvGyZ(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003B20 RID: 15136 RVA: 0x00014FD6 File Offset: 0x000131D6
			public mgFKBpiBDaMcMyKaILUfPaDvGyZ(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011CA RID: 4554
			// (get) Token: 0x06003B21 RID: 15137 RVA: 0x0011D418 File Offset: 0x0011B618
			// (set) Token: 0x06003B22 RID: 15138 RVA: 0x00014FDF File Offset: 0x000131DF
			public ControllerPollingInfo NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011CB RID: 4555
			// (get) Token: 0x06003B23 RID: 15139 RVA: 0x0011D448 File Offset: 0x0011B648
			// (set) Token: 0x06003B24 RID: 15140 RVA: 0x0001500D File Offset: 0x0001320D
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170011CC RID: 4556
			// (get) Token: 0x06003B25 RID: 15141 RVA: 0x0011D470 File Offset: 0x0011B670
			// (set) Token: 0x06003B26 RID: 15142 RVA: 0x00015028 File Offset: 0x00013228
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x170011CD RID: 4557
			// (get) Token: 0x06003B27 RID: 15143 RVA: 0x0011D498 File Offset: 0x0011B698
			// (set) Token: 0x06003B28 RID: 15144 RVA: 0x00015043 File Offset: 0x00013243
			public unsafe Keyboard HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Keyboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011CE RID: 4558
			// (get) Token: 0x06003B29 RID: 15145 RVA: 0x0011D4C8 File Offset: 0x0011B6C8
			// (set) Token: 0x06003B2A RID: 15146 RVA: 0x00015062 File Offset: 0x00013262
			public unsafe int TSwrRcCYkazQJeOykgDMDMJCimR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_TSwrRcCYkazQJeOykgDMDMJCimR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_TSwrRcCYkazQJeOykgDMDMJCimR)) = value;
				}
			}

			// Token: 0x170011CF RID: 4559
			// (get) Token: 0x06003B2B RID: 15147 RVA: 0x0011D4F0 File Offset: 0x0011B6F0
			// (set) Token: 0x06003B2C RID: 15148 RVA: 0x0001507D File Offset: 0x0001327D
			public unsafe int hAStVwJVMBBvRtdqjAJKGEgHfju
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju)) = value;
				}
			}

			// Token: 0x170011D0 RID: 4560
			// (get) Token: 0x06003B2D RID: 15149 RVA: 0x0011D518 File Offset: 0x0011B718
			// (set) Token: 0x06003B2E RID: 15150 RVA: 0x00015098 File Offset: 0x00013298
			public unsafe KeyCode CtHfFrgTWxSHKMPevnUHqlghBrgv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_CtHfFrgTWxSHKMPevnUHqlghBrgv);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_CtHfFrgTWxSHKMPevnUHqlghBrgv)) = value;
				}
			}

			// Token: 0x170011D1 RID: 4561
			// (get) Token: 0x06003B2F RID: 15151 RVA: 0x0011D540 File Offset: 0x0011B740
			// (set) Token: 0x06003B30 RID: 15152 RVA: 0x000150B3 File Offset: 0x000132B3
			public unsafe bool PhaAbdAOytzIGPrVrWSVfoNLUVCq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_PhaAbdAOytzIGPrVrWSVfoNLUVCq);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.mgFKBpiBDaMcMyKaILUfPaDvGyZ.NativeFieldInfoPtr_PhaAbdAOytzIGPrVrWSVfoNLUVCq)) = value;
				}
			}

			// Token: 0x04003192 RID: 12690
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003193 RID: 12691
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003194 RID: 12692
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x04003195 RID: 12693
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04003196 RID: 12694
			private static readonly IntPtr NativeFieldInfoPtr_TSwrRcCYkazQJeOykgDMDMJCimR;

			// Token: 0x04003197 RID: 12695
			private static readonly IntPtr NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju;

			// Token: 0x04003198 RID: 12696
			private static readonly IntPtr NativeFieldInfoPtr_CtHfFrgTWxSHKMPevnUHqlghBrgv;

			// Token: 0x04003199 RID: 12697
			private static readonly IntPtr NativeFieldInfoPtr_PhaAbdAOytzIGPrVrWSVfoNLUVCq;

			// Token: 0x0400319A RID: 12698
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0;

			// Token: 0x0400319B RID: 12699
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400319C RID: 12700
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400319D RID: 12701
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0;

			// Token: 0x0400319E RID: 12702
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400319F RID: 12703
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040031A0 RID: 12704
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040031A1 RID: 12705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}

		// Token: 0x0200028A RID: 650
		public sealed class puLWACnOKCefwvGsugTBfdnycJvx : global::Il2CppSystem.Object
		{
			// Token: 0x06003B31 RID: 15153 RVA: 0x0011D568 File Offset: 0x0011B768
			// Note: this type is marked as 'beforefieldinit'.
			static puLWACnOKCefwvGsugTBfdnycJvx()
			{
				Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "puLWACnOKCefwvGsugTBfdnycJvx");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr);
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_pAabKEhOccLqzlxnfhbRgnODEgg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, "pAabKEhOccLqzlxnfhbRgnODEgg");
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_bDYnrorPzebwNAxgTwUTOSZDHkJM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, "bDYnrorPzebwNAxgTwUTOSZDHkJM");
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_JWprSLBjEYYAeshfvBRUdFKbcpJu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, "JWprSLBjEYYAeshfvBRUdFKbcpJu");
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_ydGRfHsiuGAOpTFHPcJhHQWYRjrp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, "ydGRfHsiuGAOpTFHPcJhHQWYRjrp");
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, 100665792);
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, 100665793);
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, 100665794);
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, 100665795);
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, 100665796);
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, 100665797);
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, 100665798);
				Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr, 100665799);
			}

			// Token: 0x06003B32 RID: 15154 RVA: 0x0011D6D4 File Offset: 0x0011B8D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257317, XrefRangeEnd = 257320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerPollingInfo> System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerPollingInfo>>(intPtr3) : null;
			}

			// Token: 0x06003B33 RID: 15155 RVA: 0x0011D714 File Offset: 0x0011B914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003B34 RID: 15156 RVA: 0x0011D754 File Offset: 0x0011B954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257320, XrefRangeEnd = 257342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170011DC RID: 4572
			// (get) Token: 0x06003B35 RID: 15157 RVA: 0x0011D790 File Offset: 0x0011B990
			public unsafe ControllerPollingInfo eQOjYWBVDjtNugCRnQImrgdgoxJ
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ControllerPollingInfo(intPtr);
				}
			}

			// Token: 0x06003B36 RID: 15158 RVA: 0x0011D7C8 File Offset: 0x0011B9C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257342, XrefRangeEnd = 257347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B37 RID: 15159 RVA: 0x0011D7FC File Offset: 0x0011B9FC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011DD RID: 4573
			// (get) Token: 0x06003B38 RID: 15160 RVA: 0x0011D830 File Offset: 0x0011BA30
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257347, XrefRangeEnd = 257350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003B39 RID: 15161 RVA: 0x0011D870 File Offset: 0x0011BA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe puLWACnOKCefwvGsugTBfdnycJvx(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Keyboard.puLWACnOKCefwvGsugTBfdnycJvx>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003B3A RID: 15162 RVA: 0x000150CE File Offset: 0x000132CE
			public puLWACnOKCefwvGsugTBfdnycJvx(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011D4 RID: 4564
			// (get) Token: 0x06003B3B RID: 15163 RVA: 0x0011D8B8 File Offset: 0x0011BAB8
			// (set) Token: 0x06003B3C RID: 15164 RVA: 0x000150D7 File Offset: 0x000132D7
			public ControllerPollingInfo NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011D5 RID: 4565
			// (get) Token: 0x06003B3D RID: 15165 RVA: 0x0011D8E8 File Offset: 0x0011BAE8
			// (set) Token: 0x06003B3E RID: 15166 RVA: 0x00015105 File Offset: 0x00013305
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170011D6 RID: 4566
			// (get) Token: 0x06003B3F RID: 15167 RVA: 0x0011D910 File Offset: 0x0011BB10
			// (set) Token: 0x06003B40 RID: 15168 RVA: 0x00015120 File Offset: 0x00013320
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x170011D7 RID: 4567
			// (get) Token: 0x06003B41 RID: 15169 RVA: 0x0011D938 File Offset: 0x0011BB38
			// (set) Token: 0x06003B42 RID: 15170 RVA: 0x0001513B File Offset: 0x0001333B
			public unsafe Keyboard HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Keyboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011D8 RID: 4568
			// (get) Token: 0x06003B43 RID: 15171 RVA: 0x0011D968 File Offset: 0x0011BB68
			// (set) Token: 0x06003B44 RID: 15172 RVA: 0x0001515A File Offset: 0x0001335A
			public unsafe int pAabKEhOccLqzlxnfhbRgnODEgg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_pAabKEhOccLqzlxnfhbRgnODEgg);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_pAabKEhOccLqzlxnfhbRgnODEgg)) = value;
				}
			}

			// Token: 0x170011D9 RID: 4569
			// (get) Token: 0x06003B45 RID: 15173 RVA: 0x0011D990 File Offset: 0x0011BB90
			// (set) Token: 0x06003B46 RID: 15174 RVA: 0x00015175 File Offset: 0x00013375
			public unsafe int bDYnrorPzebwNAxgTwUTOSZDHkJM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_bDYnrorPzebwNAxgTwUTOSZDHkJM);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_bDYnrorPzebwNAxgTwUTOSZDHkJM)) = value;
				}
			}

			// Token: 0x170011DA RID: 4570
			// (get) Token: 0x06003B47 RID: 15175 RVA: 0x0011D9B8 File Offset: 0x0011BBB8
			// (set) Token: 0x06003B48 RID: 15176 RVA: 0x00015190 File Offset: 0x00013390
			public unsafe KeyCode JWprSLBjEYYAeshfvBRUdFKbcpJu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_JWprSLBjEYYAeshfvBRUdFKbcpJu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_JWprSLBjEYYAeshfvBRUdFKbcpJu)) = value;
				}
			}

			// Token: 0x170011DB RID: 4571
			// (get) Token: 0x06003B49 RID: 15177 RVA: 0x0011D9E0 File Offset: 0x0011BBE0
			// (set) Token: 0x06003B4A RID: 15178 RVA: 0x000151AB File Offset: 0x000133AB
			public unsafe bool ydGRfHsiuGAOpTFHPcJhHQWYRjrp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_ydGRfHsiuGAOpTFHPcJhHQWYRjrp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyboard.puLWACnOKCefwvGsugTBfdnycJvx.NativeFieldInfoPtr_ydGRfHsiuGAOpTFHPcJhHQWYRjrp)) = value;
				}
			}

			// Token: 0x040031A2 RID: 12706
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x040031A3 RID: 12707
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x040031A4 RID: 12708
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x040031A5 RID: 12709
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x040031A6 RID: 12710
			private static readonly IntPtr NativeFieldInfoPtr_pAabKEhOccLqzlxnfhbRgnODEgg;

			// Token: 0x040031A7 RID: 12711
			private static readonly IntPtr NativeFieldInfoPtr_bDYnrorPzebwNAxgTwUTOSZDHkJM;

			// Token: 0x040031A8 RID: 12712
			private static readonly IntPtr NativeFieldInfoPtr_JWprSLBjEYYAeshfvBRUdFKbcpJu;

			// Token: 0x040031A9 RID: 12713
			private static readonly IntPtr NativeFieldInfoPtr_ydGRfHsiuGAOpTFHPcJhHQWYRjrp;

			// Token: 0x040031AA RID: 12714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0;

			// Token: 0x040031AB RID: 12715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x040031AC RID: 12716
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040031AD RID: 12717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0;

			// Token: 0x040031AE RID: 12718
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040031AF RID: 12719
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040031B0 RID: 12720
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040031B1 RID: 12721
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
