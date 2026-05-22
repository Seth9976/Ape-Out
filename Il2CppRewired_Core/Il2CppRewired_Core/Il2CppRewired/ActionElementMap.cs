using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Text;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000136 RID: 310
	[Serializable]
	public sealed class ActionElementMap : global::Il2CppSystem.Object
	{
		// Token: 0x060021B9 RID: 8633 RVA: 0x000AD84C File Offset: 0x000ABA4C
		// Note: this type is marked as 'beforefieldinit'.
		static ActionElementMap()
		{
			Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ActionElementMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr);
			ActionElementMap.NativeFieldInfoPtr__actionCategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "_actionCategoryId");
			ActionElementMap.NativeFieldInfoPtr__actionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "_actionId");
			ActionElementMap.NativeFieldInfoPtr__elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "_elementType");
			ActionElementMap.NativeFieldInfoPtr__elementIdentifierId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "_elementIdentifierId");
			ActionElementMap.NativeFieldInfoPtr__axisRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "_axisRange");
			ActionElementMap.NativeFieldInfoPtr__invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "_invert");
			ActionElementMap.NativeFieldInfoPtr__axisContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "_axisContribution");
			ActionElementMap.NativeFieldInfoPtr__keyboardKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "_keyboardKeyCode");
			ActionElementMap.NativeFieldInfoPtr__modifierKey1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "_modifierKey1");
			ActionElementMap.NativeFieldInfoPtr__modifierKey2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "_modifierKey2");
			ActionElementMap.NativeFieldInfoPtr__modifierKey3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "_modifierKey3");
			ActionElementMap.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "wQXdFKgaEVDIjgjfyWReFTcBhsTt");
			ActionElementMap.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "kOIBhhDgDUQCZtioVlUwqEtbkMdb");
			ActionElementMap.NativeFieldInfoPtr_ZPacqaCAVpflBQYrSgvMUALUMJO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "ZPacqaCAVpflBQYrSgvMUALUMJO");
			ActionElementMap.NativeFieldInfoPtr_GgNYsxujNcPgJuFllfjraihYVWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "GgNYsxujNcPgJuFllfjraihYVWD");
			ActionElementMap.NativeFieldInfoPtr_RYFkGEtFkaatTiIhlQWJSrLicphK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "RYFkGEtFkaatTiIhlQWJSrLicphK");
			ActionElementMap.NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "CbRqAjZxgMVAIemGtzhaFTknHqR");
			ActionElementMap.NativeFieldInfoPtr_rWfkzQpkUSysRnjtFhxjnoCIqSi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "rWfkzQpkUSysRnjtFhxjnoCIqSi");
			ActionElementMap.NativeFieldInfoPtr_jinVnrWnYxodDlQALEVnKRKlbgB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "jinVnrWnYxodDlQALEVnKRKlbgB");
			ActionElementMap.NativeFieldInfoPtr_uidCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "uidCounter");
			ActionElementMap.NativeFieldInfoPtr_s_toStringSB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, "s_toStringSB");
			ActionElementMap.NativeMethodInfoPtr_EFQCIbgjMcfzjoRZPkfPJEmIHwXS_Internal_Static_Boolean_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670606);
			ActionElementMap.NativeMethodInfoPtr_XRZrEVnCQvwsOBOaVbfSufGwqhh_Internal_Static_Void_ActionElementMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670607);
			ActionElementMap.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670608);
			ActionElementMap.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670609);
			ActionElementMap.NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670610);
			ActionElementMap.NativeMethodInfoPtr_set_elementType_Internal_set_Void_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670611);
			ActionElementMap.NativeMethodInfoPtr_get_elementIdentifierId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670612);
			ActionElementMap.NativeMethodInfoPtr_set_elementIdentifierId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670613);
			ActionElementMap.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670614);
			ActionElementMap.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670615);
			ActionElementMap.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670616);
			ActionElementMap.NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670617);
			ActionElementMap.NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670618);
			ActionElementMap.NativeMethodInfoPtr_set_axisContribution_Public_set_Void_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670619);
			ActionElementMap.NativeMethodInfoPtr_get_keyboardKeyCode_Public_get_KeyboardKeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670620);
			ActionElementMap.NativeMethodInfoPtr_set_keyboardKeyCode_Public_set_Void_KeyboardKeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670621);
			ActionElementMap.NativeMethodInfoPtr_get_modifierKey1_Public_get_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670622);
			ActionElementMap.NativeMethodInfoPtr_set_modifierKey1_Public_set_Void_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670623);
			ActionElementMap.NativeMethodInfoPtr_get_modifierKey2_Public_get_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670624);
			ActionElementMap.NativeMethodInfoPtr_set_modifierKey2_Public_set_Void_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670625);
			ActionElementMap.NativeMethodInfoPtr_get_modifierKey3_Public_get_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670626);
			ActionElementMap.NativeMethodInfoPtr_set_modifierKey3_Public_set_Void_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670627);
			ActionElementMap.NativeMethodInfoPtr_get_axisType_Public_get_AxisType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670628);
			ActionElementMap.NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670629);
			ActionElementMap.NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670630);
			ActionElementMap.NativeMethodInfoPtr_set_keyCode_Public_set_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670631);
			ActionElementMap.NativeMethodInfoPtr_get_hasModifiers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670632);
			ActionElementMap.NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670633);
			ActionElementMap.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670634);
			ActionElementMap.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670635);
			ActionElementMap.NativeMethodInfoPtr_get_elementIdentifierName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670636);
			ActionElementMap.NativeMethodInfoPtr_get_actionDescriptiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670637);
			ActionElementMap.NativeMethodInfoPtr_get_elementIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670638);
			ActionElementMap.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670639);
			ActionElementMap.NativeMethodInfoPtr_get_isKeyboardMap_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670640);
			ActionElementMap.NativeMethodInfoPtr_get_nextUid_Private_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670641);
			ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670642);
			ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670643);
			ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670644);
			ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Int32_Pole_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670645);
			ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Int32_Pole_AxisRange_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670646);
			ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Pole_KeyboardKeyCode_ModifierKey_ModifierKey_ModifierKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670647);
			ActionElementMap.NativeMethodInfoPtr_CheckForAssignmentConflict_Public_Boolean_ElementAssignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670648);
			ActionElementMap.NativeMethodInfoPtr_CheckForAssignmentConflict_Public_Boolean_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670649);
			ActionElementMap.NativeMethodInfoPtr_ShowInField_Public_Boolean_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670650);
			ActionElementMap.NativeMethodInfoPtr_IsTarget_Public_Boolean_ControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670651);
			ActionElementMap.NativeMethodInfoPtr_IsTarget_Public_Boolean_IControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670652);
			ActionElementMap.NativeMethodInfoPtr_zZTCTGPgyLFuQXoKQzclFDyyjbK_Internal_Void_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670653);
			ActionElementMap.NativeMethodInfoPtr_DtTwhVQqWnfZXmZekytlnAjwCFJ_Internal_Void_ControllerMap_HardwareControllerMap_Game_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670654);
			ActionElementMap.NativeMethodInfoPtr_zZTCTGPgyLFuQXoKQzclFDyyjbK_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670655);
			ActionElementMap.NativeMethodInfoPtr_zZTCTGPgyLFuQXoKQzclFDyyjbK_Private_Void_ControllerType_HardwareControllerMap_Game_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670656);
			ActionElementMap.NativeMethodInfoPtr_OEOvFPTAJeCPzdsxUPSxOAhrevna_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670657);
			ActionElementMap.NativeMethodInfoPtr_LwJAARGscGwKkcSgflOycXIGpQQu_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670658);
			ActionElementMap.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670659);
			ActionElementMap.NativeMethodInfoPtr_xoVgvXBKOpPtrvxBQWaFwazmgvq_Private_Boolean_KeyboardKeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670660);
			ActionElementMap.NativeMethodInfoPtr_XvcFNMfUYNoHAjPxflBVjxPCAtnU_Private_Boolean_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670661);
			ActionElementMap.NativeMethodInfoPtr_TvDatNBXBhkyuGeRwywxzKSdkdc_Private_Boolean_ElementAssignmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670662);
			ActionElementMap.NativeMethodInfoPtr_KcPSZHJItIRMbxohNzfdQZiqTep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670663);
			ActionElementMap.NativeMethodInfoPtr_zTOxAPSdRQKtGqKoIkQHwLXxSVu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670664);
			ActionElementMap.NativeMethodInfoPtr_UqEKMUddoRmOOkzBGbBWxmqVzyD_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670665);
			ActionElementMap.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Internal_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670666);
			ActionElementMap.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670667);
			ActionElementMap.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr, 100670668);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x000ADF0C File Offset: 0x000AC10C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286794, RefRangeEnd = 286796, XrefRangeStart = 286790, XrefRangeEnd = 286794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EFQCIbgjMcfzjoRZPkfPJEmIHwXS(ActionElementMap A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_EFQCIbgjMcfzjoRZPkfPJEmIHwXS_Internal_Static_Boolean_ActionElementMap_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x000ADF50 File Offset: 0x000AC150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286796, XrefRangeEnd = 286811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XRZrEVnCQvwsOBOaVbfSufGwqhh(ActionElementMap A_0, ActionElementMap A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_XRZrEVnCQvwsOBOaVbfSufGwqhh_Internal_Static_Void_ActionElementMap_ActionElementMap_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x000ADF98 File Offset: 0x000AC198
		// (set) Token: 0x060021BD RID: 8637 RVA: 0x000ADFD4 File Offset: 0x000AC1D4
		public unsafe int actionId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286811, XrefRangeEnd = 286814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x000AE014 File Offset: 0x000AC214
		// (set) Token: 0x060021BF RID: 8639 RVA: 0x000AE050 File Offset: 0x000AC250
		public unsafe ControllerElementType elementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_elementType_Internal_set_Void_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x000AE090 File Offset: 0x000AC290
		// (set) Token: 0x060021C1 RID: 8641 RVA: 0x000AE0CC File Offset: 0x000AC2CC
		public unsafe int elementIdentifierId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_elementIdentifierId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286814, XrefRangeEnd = 286826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_elementIdentifierId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x000AE10C File Offset: 0x000AC30C
		// (set) Token: 0x060021C3 RID: 8643 RVA: 0x000AE148 File Offset: 0x000AC348
		public unsafe AxisRange axisRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 286834, RefRangeEnd = 286836, XrefRangeStart = 286826, XrefRangeEnd = 286834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x000AE188 File Offset: 0x000AC388
		// (set) Token: 0x060021C5 RID: 8645 RVA: 0x000AE1C4 File Offset: 0x000AC3C4
		public unsafe bool invert
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x000AE204 File Offset: 0x000AC404
		// (set) Token: 0x060021C7 RID: 8647 RVA: 0x000AE240 File Offset: 0x000AC440
		public unsafe Pole axisContribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 286839, RefRangeEnd = 286840, XrefRangeStart = 286836, XrefRangeEnd = 286839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_axisContribution_Public_set_Void_Pole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x000AE280 File Offset: 0x000AC480
		// (set) Token: 0x060021C9 RID: 8649 RVA: 0x000AE2BC File Offset: 0x000AC4BC
		public unsafe KeyboardKeyCode keyboardKeyCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_keyboardKeyCode_Public_get_KeyboardKeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286840, XrefRangeEnd = 286847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_keyboardKeyCode_Public_set_Void_KeyboardKeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x000AE2FC File Offset: 0x000AC4FC
		// (set) Token: 0x060021CB RID: 8651 RVA: 0x000AE338 File Offset: 0x000AC538
		public unsafe ModifierKey modifierKey1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_modifierKey1_Public_get_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286847, XrefRangeEnd = 286855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_modifierKey1_Public_set_Void_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x000AE378 File Offset: 0x000AC578
		// (set) Token: 0x060021CD RID: 8653 RVA: 0x000AE3B4 File Offset: 0x000AC5B4
		public unsafe ModifierKey modifierKey2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_modifierKey2_Public_get_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286855, XrefRangeEnd = 286863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_modifierKey2_Public_set_Void_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x000AE3F4 File Offset: 0x000AC5F4
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x000AE430 File Offset: 0x000AC630
		public unsafe ModifierKey modifierKey3
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_modifierKey3_Public_get_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286863, XrefRangeEnd = 286871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_modifierKey3_Public_set_Void_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x000AE470 File Offset: 0x000AC670
		public unsafe AxisType axisType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_axisType_Public_get_AxisType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x000AE4AC File Offset: 0x000AC6AC
		public unsafe ModifierKeyFlags modifierKeyFlags
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 286879, RefRangeEnd = 286896, XrefRangeStart = 286871, XrefRangeEnd = 286879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x000AE4E8 File Offset: 0x000AC6E8
		// (set) Token: 0x060021D3 RID: 8659 RVA: 0x000AE524 File Offset: 0x000AC724
		public unsafe KeyCode keyCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_keyCode_Public_set_Void_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x000AE564 File Offset: 0x000AC764
		public unsafe bool hasModifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_hasModifiers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x000AE5A0 File Offset: 0x000AC7A0
		public unsafe ControllerMap controllerMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr3) : null;
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x000AE5E0 File Offset: 0x000AC7E0
		// (set) Token: 0x060021D7 RID: 8663 RVA: 0x000AE61C File Offset: 0x000AC81C
		public unsafe bool enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x000AE65C File Offset: 0x000AC85C
		public unsafe string elementIdentifierName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 286898, RefRangeEnd = 286902, XrefRangeStart = 286896, XrefRangeEnd = 286898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_elementIdentifierName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x000AE694 File Offset: 0x000AC894
		public unsafe string actionDescriptiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_actionDescriptiveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x000AE6CC File Offset: 0x000AC8CC
		public unsafe int elementIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_elementIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x000AE708 File Offset: 0x000AC908
		public unsafe int id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x000AE744 File Offset: 0x000AC944
		public unsafe bool isKeyboardMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_isKeyboardMap_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x000AE780 File Offset: 0x000AC980
		public unsafe static int nextUid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286902, XrefRangeEnd = 286908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_get_nextUid_Private_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x000AE7B0 File Offset: 0x000AC9B0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 286921, RefRangeEnd = 286942, XrefRangeStart = 286908, XrefRangeEnd = 286921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x000AE7EC File Offset: 0x000AC9EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 286961, RefRangeEnd = 286968, XrefRangeStart = 286942, XrefRangeEnd = 286961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap(ActionElementMap map)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000AE838 File Offset: 0x000ACA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286968, XrefRangeEnd = 286969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000AE89C File Offset: 0x000ACA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286969, XrefRangeEnd = 286970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisContribution;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Int32_Pole_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000AE91C File Offset: 0x000ACB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286970, XrefRangeEnd = 286971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange, bool invert)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisContribution;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Int32_Pole_AxisRange_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x000AE9AC File Offset: 0x000ACBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286971, XrefRangeEnd = 286973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap(int actionId, ControllerElementType elementType, Pole axisContribution, KeyboardKeyCode keyboardKeyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionElementMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisContribution;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardKeyCode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifierKey1;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifierKey2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifierKey3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Pole_KeyboardKeyCode_ModifierKey_ModifierKey_ModifierKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000AEA48 File Offset: 0x000ACC48
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 286976, RefRangeEnd = 286985, XrefRangeStart = 286973, XrefRangeEnd = 286976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForAssignmentConflict(ElementAssignment elementAssignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementAssignment;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_CheckForAssignmentConflict_Public_Boolean_ElementAssignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000AEA94 File Offset: 0x000ACC94
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 286989, RefRangeEnd = 287008, XrefRangeStart = 286985, XrefRangeEnd = 286989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForAssignmentConflict(ActionElementMap elementMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_CheckForAssignmentConflict_Public_Boolean_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000AEAE4 File Offset: 0x000ACCE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287016, RefRangeEnd = 287018, XrefRangeStart = 287008, XrefRangeEnd = 287016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShowInField(AxisRange fieldActionRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fieldActionRange;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_ShowInField_Public_Boolean_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000AEB30 File Offset: 0x000ACD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287018, XrefRangeEnd = 287025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTarget(ControllerElementTarget elementTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(elementTarget));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_IsTarget_Public_Boolean_ControllerElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000AEB84 File Offset: 0x000ACD84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 287041, RefRangeEnd = 287046, XrefRangeStart = 287025, XrefRangeEnd = 287041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTarget(IControllerElementTarget elementTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementTarget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_IsTarget_Public_Boolean_IControllerElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x000AEBD4 File Offset: 0x000ACDD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 287051, RefRangeEnd = 287055, XrefRangeStart = 287046, XrefRangeEnd = 287051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zZTCTGPgyLFuQXoKQzclFDyyjbK(ControllerMap A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_zZTCTGPgyLFuQXoKQzclFDyyjbK_Internal_Void_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000AEC18 File Offset: 0x000ACE18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 287058, RefRangeEnd = 287062, XrefRangeStart = 287055, XrefRangeEnd = 287058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtTwhVQqWnfZXmZekytlnAjwCFJ(ControllerMap A_1, HardwareControllerMap_Game A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_DtTwhVQqWnfZXmZekytlnAjwCFJ_Internal_Void_ControllerMap_HardwareControllerMap_Game_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000AEC6C File Offset: 0x000ACE6C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 287067, RefRangeEnd = 287075, XrefRangeStart = 287062, XrefRangeEnd = 287067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zZTCTGPgyLFuQXoKQzclFDyyjbK(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_zZTCTGPgyLFuQXoKQzclFDyyjbK_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x000AECAC File Offset: 0x000ACEAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287129, RefRangeEnd = 287132, XrefRangeStart = 287075, XrefRangeEnd = 287129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zZTCTGPgyLFuQXoKQzclFDyyjbK(ControllerType A_1, HardwareControllerMap_Game A_2, bool A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_zZTCTGPgyLFuQXoKQzclFDyyjbK_Private_Void_ControllerType_HardwareControllerMap_Game_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x000AED0C File Offset: 0x000ACF0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287138, RefRangeEnd = 287140, XrefRangeStart = 287132, XrefRangeEnd = 287138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OEOvFPTAJeCPzdsxUPSxOAhrevna()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_OEOvFPTAJeCPzdsxUPSxOAhrevna_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x000AED40 File Offset: 0x000ACF40
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 287169, RefRangeEnd = 287182, XrefRangeStart = 287140, XrefRangeEnd = 287169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LwJAARGscGwKkcSgflOycXIGpQQu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_LwJAARGscGwKkcSgflOycXIGpQQu_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x000AED78 File Offset: 0x000ACF78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 287184, RefRangeEnd = 287188, XrefRangeStart = 287182, XrefRangeEnd = 287184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GMFpQqtyJcjzYToWCrZsZQAhPYh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x000AEDAC File Offset: 0x000ACFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287189, RefRangeEnd = 287190, XrefRangeStart = 287188, XrefRangeEnd = 287189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool xoVgvXBKOpPtrvxBQWaFwazmgvq(KeyboardKeyCode A_1, ModifierKeyFlags A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_xoVgvXBKOpPtrvxBQWaFwazmgvq_Private_Boolean_KeyboardKeyCode_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x000AEE04 File Offset: 0x000AD004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287190, RefRangeEnd = 287192, XrefRangeStart = 287190, XrefRangeEnd = 287190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool XvcFNMfUYNoHAjPxflBVjxPCAtnU(int A_1, AxisRange A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_XvcFNMfUYNoHAjPxflBVjxPCAtnU_Private_Boolean_Int32_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x000AEE5C File Offset: 0x000AD05C
		[CallerCount(0)]
		public unsafe bool TvDatNBXBhkyuGeRwywxzKSdkdc(ElementAssignmentType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_TvDatNBXBhkyuGeRwywxzKSdkdc_Private_Boolean_ElementAssignmentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x000AEEA8 File Offset: 0x000AD0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287192, XrefRangeEnd = 287193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KcPSZHJItIRMbxohNzfdQZiqTep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_KcPSZHJItIRMbxohNzfdQZiqTep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x000AEEDC File Offset: 0x000AD0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287193, XrefRangeEnd = 287201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zTOxAPSdRQKtGqKoIkQHwLXxSVu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_zTOxAPSdRQKtGqKoIkQHwLXxSVu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x000AEF10 File Offset: 0x000AD110
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287202, RefRangeEnd = 287205, XrefRangeStart = 287201, XrefRangeEnd = 287202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UqEKMUddoRmOOkzBGbBWxmqVzyD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_UqEKMUddoRmOOkzBGbBWxmqVzyD_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x000AEF44 File Offset: 0x000AD144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287260, RefRangeEnd = 287262, XrefRangeStart = 287205, XrefRangeEnd = 287260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject TUpbRFbZCQXGnqKfXoSpZTimZpRE()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Internal_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject>(intPtr3) : null;
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x000AEF84 File Offset: 0x000AD184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287305, RefRangeEnd = 287307, XrefRangeStart = 287262, XrefRangeEnd = 287305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void qMMTpeQwXdHPjVTnNgIqFdgetDa(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x000AEFC8 File Offset: 0x000AD1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287307, XrefRangeEnd = 287449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionElementMap.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x0000DA16 File Offset: 0x0000BC16
		public ActionElementMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x000AF000 File Offset: 0x000AD200
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x0000DA1F File Offset: 0x0000BC1F
		public unsafe int _actionCategoryId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__actionCategoryId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__actionCategoryId)) = value;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x000AF028 File Offset: 0x000AD228
		// (set) Token: 0x060021FD RID: 8701 RVA: 0x0000DA3A File Offset: 0x0000BC3A
		public unsafe int _actionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__actionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__actionId)) = value;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x000AF050 File Offset: 0x000AD250
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x0000DA55 File Offset: 0x0000BC55
		public unsafe ControllerElementType _elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__elementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__elementType)) = value;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x000AF078 File Offset: 0x000AD278
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x0000DA70 File Offset: 0x0000BC70
		public unsafe int _elementIdentifierId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__elementIdentifierId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__elementIdentifierId)) = value;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x000AF0A0 File Offset: 0x000AD2A0
		// (set) Token: 0x06002203 RID: 8707 RVA: 0x0000DA8B File Offset: 0x0000BC8B
		public unsafe AxisRange _axisRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__axisRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__axisRange)) = value;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x000AF0C8 File Offset: 0x000AD2C8
		// (set) Token: 0x06002205 RID: 8709 RVA: 0x0000DAA6 File Offset: 0x0000BCA6
		public unsafe bool _invert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__invert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__invert)) = value;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x000AF0F0 File Offset: 0x000AD2F0
		// (set) Token: 0x06002207 RID: 8711 RVA: 0x0000DAC1 File Offset: 0x0000BCC1
		public unsafe Pole _axisContribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__axisContribution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__axisContribution)) = value;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002208 RID: 8712 RVA: 0x000AF118 File Offset: 0x000AD318
		// (set) Token: 0x06002209 RID: 8713 RVA: 0x0000DADC File Offset: 0x0000BCDC
		public unsafe KeyboardKeyCode _keyboardKeyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__keyboardKeyCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__keyboardKeyCode)) = value;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x000AF140 File Offset: 0x000AD340
		// (set) Token: 0x0600220B RID: 8715 RVA: 0x0000DAF7 File Offset: 0x0000BCF7
		public unsafe ModifierKey _modifierKey1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__modifierKey1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__modifierKey1)) = value;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x000AF168 File Offset: 0x000AD368
		// (set) Token: 0x0600220D RID: 8717 RVA: 0x0000DB12 File Offset: 0x0000BD12
		public unsafe ModifierKey _modifierKey2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__modifierKey2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__modifierKey2)) = value;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x000AF190 File Offset: 0x000AD390
		// (set) Token: 0x0600220F RID: 8719 RVA: 0x0000DB2D File Offset: 0x0000BD2D
		public unsafe ModifierKey _modifierKey3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__modifierKey3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr__modifierKey3)) = value;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x000AF1B8 File Offset: 0x000AD3B8
		// (set) Token: 0x06002211 RID: 8721 RVA: 0x0000DB48 File Offset: 0x0000BD48
		public unsafe ControllerMap wQXdFKgaEVDIjgjfyWReFTcBhsTt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x000AF1E8 File Offset: 0x000AD3E8
		// (set) Token: 0x06002213 RID: 8723 RVA: 0x0000DB67 File Offset: 0x0000BD67
		public unsafe bool kOIBhhDgDUQCZtioVlUwqEtbkMdb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb)) = value;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x000AF210 File Offset: 0x000AD410
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x0000DB82 File Offset: 0x0000BD82
		public unsafe string ZPacqaCAVpflBQYrSgvMUALUMJO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_ZPacqaCAVpflBQYrSgvMUALUMJO);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_ZPacqaCAVpflBQYrSgvMUALUMJO), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000AF238 File Offset: 0x000AD438
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x0000DBA1 File Offset: 0x0000BDA1
		public unsafe string GgNYsxujNcPgJuFllfjraihYVWD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_GgNYsxujNcPgJuFllfjraihYVWD);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_GgNYsxujNcPgJuFllfjraihYVWD), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x000AF260 File Offset: 0x000AD460
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		public unsafe int RYFkGEtFkaatTiIhlQWJSrLicphK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_RYFkGEtFkaatTiIhlQWJSrLicphK);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_RYFkGEtFkaatTiIhlQWJSrLicphK)) = value;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x000AF288 File Offset: 0x000AD488
		// (set) Token: 0x0600221B RID: 8731 RVA: 0x0000DBDB File Offset: 0x0000BDDB
		public unsafe int CbRqAjZxgMVAIemGtzhaFTknHqR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR)) = value;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x000AF2B0 File Offset: 0x000AD4B0
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x0000DBF6 File Offset: 0x0000BDF6
		public unsafe string rWfkzQpkUSysRnjtFhxjnoCIqSi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_rWfkzQpkUSysRnjtFhxjnoCIqSi);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_rWfkzQpkUSysRnjtFhxjnoCIqSi), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x000AF2D8 File Offset: 0x000AD4D8
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x0000DC15 File Offset: 0x0000BE15
		public unsafe ModifierKeyFlags jinVnrWnYxodDlQALEVnKRKlbgB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_jinVnrWnYxodDlQALEVnKRKlbgB);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionElementMap.NativeFieldInfoPtr_jinVnrWnYxodDlQALEVnKRKlbgB)) = value;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x000AF300 File Offset: 0x000AD500
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x0000DC30 File Offset: 0x0000BE30
		public unsafe static int uidCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ActionElementMap.NativeFieldInfoPtr_uidCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActionElementMap.NativeFieldInfoPtr_uidCounter, (void*)(&value));
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x000AF31C File Offset: 0x000AD51C
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x0000DC3E File Offset: 0x0000BE3E
		public unsafe static StringBuilder s_toStringSB
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActionElementMap.NativeFieldInfoPtr_s_toStringSB, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActionElementMap.NativeFieldInfoPtr_s_toStringSB, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeFieldInfoPtr__actionCategoryId;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeFieldInfoPtr__actionId;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeFieldInfoPtr__elementType;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeFieldInfoPtr__elementIdentifierId;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeFieldInfoPtr__axisRange;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeFieldInfoPtr__invert;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeFieldInfoPtr__axisContribution;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeFieldInfoPtr__keyboardKeyCode;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeFieldInfoPtr__modifierKey1;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeFieldInfoPtr__modifierKey2;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeFieldInfoPtr__modifierKey3;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeFieldInfoPtr_ZPacqaCAVpflBQYrSgvMUALUMJO;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeFieldInfoPtr_GgNYsxujNcPgJuFllfjraihYVWD;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeFieldInfoPtr_RYFkGEtFkaatTiIhlQWJSrLicphK;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeFieldInfoPtr_rWfkzQpkUSysRnjtFhxjnoCIqSi;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeFieldInfoPtr_jinVnrWnYxodDlQALEVnKRKlbgB;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeFieldInfoPtr_uidCounter;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeFieldInfoPtr_s_toStringSB;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeMethodInfoPtr_EFQCIbgjMcfzjoRZPkfPJEmIHwXS_Internal_Static_Boolean_ActionElementMap_0;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeMethodInfoPtr_XRZrEVnCQvwsOBOaVbfSufGwqhh_Internal_Static_Void_ActionElementMap_ActionElementMap_0;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeMethodInfoPtr_get_actionId_Public_get_Int32_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr_set_elementType_Internal_set_Void_ControllerElementType_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifierId_Public_get_Int32_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr_set_elementIdentifierId_Public_set_Void_Int32_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeMethodInfoPtr_get_invert_Public_get_Boolean_0;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_set_axisContribution_Public_set_Void_Pole_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardKeyCode_Public_get_KeyboardKeyCode_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_set_keyboardKeyCode_Public_set_Void_KeyboardKeyCode_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_get_modifierKey1_Public_get_ModifierKey_0;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeMethodInfoPtr_set_modifierKey1_Public_set_Void_ModifierKey_0;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeMethodInfoPtr_get_modifierKey2_Public_get_ModifierKey_0;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_set_modifierKey2_Public_set_Void_ModifierKey_0;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr_get_modifierKey3_Public_get_ModifierKey_0;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_set_modifierKey3_Public_set_Void_ModifierKey_0;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_get_axisType_Public_get_AxisType_0;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_set_keyCode_Public_set_Void_KeyCode_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_get_hasModifiers_Public_get_Boolean_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifierName_Public_get_String_0;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeMethodInfoPtr_get_actionDescriptiveName_Public_get_String_0;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIndex_Public_get_Int32_0;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeMethodInfoPtr_get_isKeyboardMap_Private_get_Boolean_0;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeMethodInfoPtr_get_nextUid_Private_Static_get_Int32_0;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ActionElementMap_0;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Int32_0;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Int32_Pole_AxisRange_0;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Int32_Pole_AxisRange_Boolean_0;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerElementType_Pole_KeyboardKeyCode_ModifierKey_ModifierKey_ModifierKey_0;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeMethodInfoPtr_CheckForAssignmentConflict_Public_Boolean_ElementAssignment_0;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeMethodInfoPtr_CheckForAssignmentConflict_Public_Boolean_ActionElementMap_0;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeMethodInfoPtr_ShowInField_Public_Boolean_AxisRange_0;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeMethodInfoPtr_IsTarget_Public_Boolean_ControllerElementTarget_0;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeMethodInfoPtr_IsTarget_Public_Boolean_IControllerElementTarget_0;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeMethodInfoPtr_zZTCTGPgyLFuQXoKQzclFDyyjbK_Internal_Void_ControllerMap_0;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr_DtTwhVQqWnfZXmZekytlnAjwCFJ_Internal_Void_ControllerMap_HardwareControllerMap_Game_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_zZTCTGPgyLFuQXoKQzclFDyyjbK_Private_Void_Boolean_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr_zZTCTGPgyLFuQXoKQzclFDyyjbK_Private_Void_ControllerType_HardwareControllerMap_Game_Boolean_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr_OEOvFPTAJeCPzdsxUPSxOAhrevna_Private_Void_0;

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeMethodInfoPtr_LwJAARGscGwKkcSgflOycXIGpQQu_Private_String_0;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Void_0;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeMethodInfoPtr_xoVgvXBKOpPtrvxBQWaFwazmgvq_Private_Boolean_KeyboardKeyCode_ModifierKeyFlags_0;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr_XvcFNMfUYNoHAjPxflBVjxPCAtnU_Private_Boolean_Int32_AxisRange_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeMethodInfoPtr_TvDatNBXBhkyuGeRwywxzKSdkdc_Private_Boolean_ElementAssignmentType_0;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeMethodInfoPtr_KcPSZHJItIRMbxohNzfdQZiqTep_Private_Void_0;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeMethodInfoPtr_zTOxAPSdRQKtGqKoIkQHwLXxSVu_Private_Void_0;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeMethodInfoPtr_UqEKMUddoRmOOkzBGbBWxmqVzyD_Private_Void_0;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Internal_SerializedObject_0;

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Void_SerializedObject_0;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
