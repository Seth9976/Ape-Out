using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001FA RID: 506
	[Serializable]
	public class LanguageDataBase : ScriptableObject
	{
		// Token: 0x06003E50 RID: 15952 RVA: 0x000E8D10 File Offset: 0x000E6F10
		// Note: this type is marked as 'beforefieldinit'.
		static LanguageDataBase()
		{
			Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "LanguageDataBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr);
			LanguageDataBase.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669132);
			LanguageDataBase.NativeMethodInfoPtr_GetCustomEntry_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669133);
			LanguageDataBase.NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669134);
			LanguageDataBase.NativeMethodInfoPtr_get_yes_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669135);
			LanguageDataBase.NativeMethodInfoPtr_get_no_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669136);
			LanguageDataBase.NativeMethodInfoPtr_get_add_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669137);
			LanguageDataBase.NativeMethodInfoPtr_get_replace_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669138);
			LanguageDataBase.NativeMethodInfoPtr_get_remove_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669139);
			LanguageDataBase.NativeMethodInfoPtr_get_swap_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669140);
			LanguageDataBase.NativeMethodInfoPtr_get_cancel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669141);
			LanguageDataBase.NativeMethodInfoPtr_get_none_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669142);
			LanguageDataBase.NativeMethodInfoPtr_get_okay_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669143);
			LanguageDataBase.NativeMethodInfoPtr_get_done_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669144);
			LanguageDataBase.NativeMethodInfoPtr_get_default__Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669145);
			LanguageDataBase.NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669146);
			LanguageDataBase.NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669147);
			LanguageDataBase.NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669148);
			LanguageDataBase.NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669149);
			LanguageDataBase.NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669150);
			LanguageDataBase.NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669151);
			LanguageDataBase.NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669152);
			LanguageDataBase.NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669153);
			LanguageDataBase.NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669154);
			LanguageDataBase.NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669155);
			LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669156);
			LanguageDataBase.NativeMethodInfoPtr_get_actionColumnLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669157);
			LanguageDataBase.NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669158);
			LanguageDataBase.NativeMethodInfoPtr_get_mouseColumnLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669159);
			LanguageDataBase.NativeMethodInfoPtr_get_controllerColumnLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669160);
			LanguageDataBase.NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669161);
			LanguageDataBase.NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669162);
			LanguageDataBase.NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669163);
			LanguageDataBase.NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669164);
			LanguageDataBase.NativeMethodInfoPtr_get_doneButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669165);
			LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669166);
			LanguageDataBase.NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669167);
			LanguageDataBase.NativeMethodInfoPtr_get_playersGroupLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669168);
			LanguageDataBase.NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669169);
			LanguageDataBase.NativeMethodInfoPtr_get_settingsGroupLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669170);
			LanguageDataBase.NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669171);
			LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669172);
			LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669173);
			LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669174);
			LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669175);
			LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669176);
			LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669177);
			LanguageDataBase.NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669178);
			LanguageDataBase.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669179);
			LanguageDataBase.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669180);
			LanguageDataBase.NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669181);
			LanguageDataBase.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669182);
			LanguageDataBase.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669183);
			LanguageDataBase.NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669184);
			LanguageDataBase.NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Abstract_Virtual_New_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669185);
			LanguageDataBase.NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669186);
			LanguageDataBase.NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669187);
			LanguageDataBase.NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669188);
			LanguageDataBase.NativeMethodInfoPtr_GetPlayerName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669189);
			LanguageDataBase.NativeMethodInfoPtr_GetControllerName_Public_Abstract_Virtual_New_String_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669190);
			LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669191);
			LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_Controller_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669192);
			LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_KeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669193);
			LanguageDataBase.NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669194);
			LanguageDataBase.NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669195);
			LanguageDataBase.NativeMethodInfoPtr_GetMapCategoryName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669196);
			LanguageDataBase.NativeMethodInfoPtr_GetActionCategoryName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669197);
			LanguageDataBase.NativeMethodInfoPtr_GetLayoutName_Public_Abstract_Virtual_New_String_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669198);
			LanguageDataBase.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Abstract_Virtual_New_String_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669199);
			LanguageDataBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr, 100669200);
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x000E92A4 File Offset: 0x000E74A4
		[CallerCount(0)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x000E92E0 File Offset: 0x000E74E0
		[CallerCount(0)]
		public unsafe virtual string GetCustomEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetCustomEntry_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x000E9334 File Offset: 0x000E7534
		[CallerCount(0)]
		public unsafe virtual bool ContainsCustomEntryKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06003E54 RID: 15956 RVA: 0x000E938C File Offset: 0x000E758C
		public unsafe virtual string yes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_yes_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06003E55 RID: 15957 RVA: 0x000E93D0 File Offset: 0x000E75D0
		public unsafe virtual string no
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_no_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06003E56 RID: 15958 RVA: 0x000E9414 File Offset: 0x000E7614
		public unsafe virtual string add
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_add_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06003E57 RID: 15959 RVA: 0x000E9458 File Offset: 0x000E7658
		public unsafe virtual string replace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_replace_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06003E58 RID: 15960 RVA: 0x000E949C File Offset: 0x000E769C
		public unsafe virtual string remove
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_remove_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06003E59 RID: 15961 RVA: 0x000E94E0 File Offset: 0x000E76E0
		public unsafe virtual string swap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_swap_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06003E5A RID: 15962 RVA: 0x000E9524 File Offset: 0x000E7724
		public unsafe virtual string cancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_cancel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06003E5B RID: 15963 RVA: 0x000E9568 File Offset: 0x000E7768
		public unsafe virtual string none
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_none_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06003E5C RID: 15964 RVA: 0x000E95AC File Offset: 0x000E77AC
		public unsafe virtual string okay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_okay_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06003E5D RID: 15965 RVA: 0x000E95F0 File Offset: 0x000E77F0
		public unsafe virtual string done
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_done_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06003E5E RID: 15966 RVA: 0x000E9634 File Offset: 0x000E7834
		public unsafe virtual string default_
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_default__Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06003E5F RID: 15967 RVA: 0x000E9678 File Offset: 0x000E7878
		public unsafe virtual string assignControllerWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06003E60 RID: 15968 RVA: 0x000E96BC File Offset: 0x000E78BC
		public unsafe virtual string assignControllerWindowMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06003E61 RID: 15969 RVA: 0x000E9700 File Offset: 0x000E7900
		public unsafe virtual string controllerAssignmentConflictWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06003E62 RID: 15970 RVA: 0x000E9744 File Offset: 0x000E7944
		public unsafe virtual string elementAssignmentPrePollingWindowMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06003E63 RID: 15971 RVA: 0x000E9788 File Offset: 0x000E7988
		public unsafe virtual string elementAssignmentConflictWindowMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06003E64 RID: 15972 RVA: 0x000E97CC File Offset: 0x000E79CC
		public unsafe virtual string mouseAssignmentConflictWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06003E65 RID: 15973 RVA: 0x000E9810 File Offset: 0x000E7A10
		public unsafe virtual string calibrateControllerWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06003E66 RID: 15974 RVA: 0x000E9854 File Offset: 0x000E7A54
		public unsafe virtual string calibrateAxisStep1WindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06003E67 RID: 15975 RVA: 0x000E9898 File Offset: 0x000E7A98
		public unsafe virtual string calibrateAxisStep2WindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06003E68 RID: 15976 RVA: 0x000E98DC File Offset: 0x000E7ADC
		public unsafe virtual string inputBehaviorSettingsWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06003E69 RID: 15977 RVA: 0x000E9920 File Offset: 0x000E7B20
		public unsafe virtual string restoreDefaultsWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06003E6A RID: 15978 RVA: 0x000E9964 File Offset: 0x000E7B64
		public unsafe virtual string actionColumnLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_actionColumnLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x000E99A8 File Offset: 0x000E7BA8
		public unsafe virtual string keyboardColumnLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06003E6C RID: 15980 RVA: 0x000E99EC File Offset: 0x000E7BEC
		public unsafe virtual string mouseColumnLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_mouseColumnLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06003E6D RID: 15981 RVA: 0x000E9A30 File Offset: 0x000E7C30
		public unsafe virtual string controllerColumnLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_controllerColumnLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06003E6E RID: 15982 RVA: 0x000E9A74 File Offset: 0x000E7C74
		public unsafe virtual string removeControllerButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06003E6F RID: 15983 RVA: 0x000E9AB8 File Offset: 0x000E7CB8
		public unsafe virtual string calibrateControllerButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06003E70 RID: 15984 RVA: 0x000E9AFC File Offset: 0x000E7CFC
		public unsafe virtual string assignControllerButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06003E71 RID: 15985 RVA: 0x000E9B40 File Offset: 0x000E7D40
		public unsafe virtual string inputBehaviorSettingsButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06003E72 RID: 15986 RVA: 0x000E9B84 File Offset: 0x000E7D84
		public unsafe virtual string doneButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_doneButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06003E73 RID: 15987 RVA: 0x000E9BC8 File Offset: 0x000E7DC8
		public unsafe virtual string restoreDefaultsButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06003E74 RID: 15988 RVA: 0x000E9C0C File Offset: 0x000E7E0C
		public unsafe virtual string controllerSettingsGroupLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06003E75 RID: 15989 RVA: 0x000E9C50 File Offset: 0x000E7E50
		public unsafe virtual string playersGroupLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_playersGroupLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06003E76 RID: 15990 RVA: 0x000E9C94 File Offset: 0x000E7E94
		public unsafe virtual string assignedControllersGroupLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06003E77 RID: 15991 RVA: 0x000E9CD8 File Offset: 0x000E7ED8
		public unsafe virtual string settingsGroupLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_settingsGroupLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x000E9D1C File Offset: 0x000E7F1C
		public unsafe virtual string mapCategoriesGroupLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06003E79 RID: 15993 RVA: 0x000E9D60 File Offset: 0x000E7F60
		public unsafe virtual string restoreDefaultsWindowMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06003E7A RID: 15994 RVA: 0x000E9DA4 File Offset: 0x000E7FA4
		public unsafe virtual string calibrateWindow_deadZoneSliderLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06003E7B RID: 15995 RVA: 0x000E9DE8 File Offset: 0x000E7FE8
		public unsafe virtual string calibrateWindow_zeroSliderLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06003E7C RID: 15996 RVA: 0x000E9E2C File Offset: 0x000E802C
		public unsafe virtual string calibrateWindow_sensitivitySliderLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06003E7D RID: 15997 RVA: 0x000E9E70 File Offset: 0x000E8070
		public unsafe virtual string calibrateWindow_invertToggleLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x000E9EB4 File Offset: 0x000E80B4
		public unsafe virtual string calibrateWindow_calibrateButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x000E9EF8 File Offset: 0x000E80F8
		[CallerCount(0)]
		public unsafe virtual string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(joystickName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(otherPlayerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currentPlayerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x000E9F70 File Offset: 0x000E8170
		[CallerCount(0)]
		public unsafe virtual string GetJoystickElementAssignmentPollingWindowMessage(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x000E9FC4 File Offset: 0x000E81C4
		[CallerCount(0)]
		public unsafe virtual string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x000EA018 File Offset: 0x000E8218
		[CallerCount(0)]
		public unsafe virtual string GetKeyboardElementAssignmentPollingWindowMessage(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x000EA06C File Offset: 0x000E826C
		[CallerCount(0)]
		public unsafe virtual string GetMouseElementAssignmentPollingWindowMessage(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x000EA0C0 File Offset: 0x000E82C0
		[CallerCount(0)]
		public unsafe virtual string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x000EA114 File Offset: 0x000E8314
		[CallerCount(0)]
		public unsafe virtual string GetElementAlreadyInUseBlocked(string elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x000EA168 File Offset: 0x000E8368
		[CallerCount(0)]
		public unsafe virtual string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowConflicts;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Abstract_Virtual_New_String_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x000EA1CC File Offset: 0x000E83CC
		[CallerCount(0)]
		public unsafe virtual string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(otherPlayerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(thisPlayerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x000EA234 File Offset: 0x000E8434
		[CallerCount(0)]
		public unsafe virtual string GetCalibrateAxisStep1WindowMessage(string axisName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x000EA288 File Offset: 0x000E8488
		[CallerCount(0)]
		public unsafe virtual string GetCalibrateAxisStep2WindowMessage(string axisName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x000EA2DC File Offset: 0x000E84DC
		[CallerCount(0)]
		public unsafe virtual string GetPlayerName(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetPlayerName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x000EA32C File Offset: 0x000E852C
		[CallerCount(0)]
		public unsafe virtual string GetControllerName(Controller controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetControllerName_Public_Abstract_Virtual_New_String_Controller_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x000EA380 File Offset: 0x000E8580
		[CallerCount(0)]
		public unsafe virtual string GetElementIdentifierName(ActionElementMap actionElementMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionElementMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x000EA3D4 File Offset: 0x000E85D4
		[CallerCount(0)]
		public unsafe virtual string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_Controller_Int32_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x000EA444 File Offset: 0x000E8644
		[CallerCount(0)]
		public unsafe virtual string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifierKeyFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_KeyCode_ModifierKeyFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x000EA4A4 File Offset: 0x000E86A4
		[CallerCount(0)]
		public unsafe virtual string GetActionName(int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x000EA4F4 File Offset: 0x000E86F4
		[CallerCount(0)]
		public unsafe virtual string GetActionName(int actionId, AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x000EA554 File Offset: 0x000E8754
		[CallerCount(0)]
		public unsafe virtual string GetMapCategoryName(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetMapCategoryName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x000EA5A4 File Offset: 0x000E87A4
		[CallerCount(0)]
		public unsafe virtual string GetActionCategoryName(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetActionCategoryName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x000EA5F4 File Offset: 0x000E87F4
		[CallerCount(0)]
		public unsafe virtual string GetLayoutName(ControllerType controllerType, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_GetLayoutName_Public_Abstract_Virtual_New_String_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x000EA654 File Offset: 0x000E8854
		[CallerCount(0)]
		public unsafe virtual string ModifierKeyFlagsToString(ModifierKeyFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageDataBase.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Abstract_Virtual_New_String_ModifierKeyFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x000EA6A4 File Offset: 0x000E88A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LanguageDataBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageDataBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageDataBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x000268B4 File Offset: 0x00024AB4
		public LanguageDataBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002610 RID: 9744
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002611 RID: 9745
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomEntry_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x04002612 RID: 9746
		private static readonly IntPtr NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x04002613 RID: 9747
		private static readonly IntPtr NativeMethodInfoPtr_get_yes_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002614 RID: 9748
		private static readonly IntPtr NativeMethodInfoPtr_get_no_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002615 RID: 9749
		private static readonly IntPtr NativeMethodInfoPtr_get_add_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002616 RID: 9750
		private static readonly IntPtr NativeMethodInfoPtr_get_replace_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002617 RID: 9751
		private static readonly IntPtr NativeMethodInfoPtr_get_remove_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002618 RID: 9752
		private static readonly IntPtr NativeMethodInfoPtr_get_swap_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002619 RID: 9753
		private static readonly IntPtr NativeMethodInfoPtr_get_cancel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400261A RID: 9754
		private static readonly IntPtr NativeMethodInfoPtr_get_none_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400261B RID: 9755
		private static readonly IntPtr NativeMethodInfoPtr_get_okay_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400261C RID: 9756
		private static readonly IntPtr NativeMethodInfoPtr_get_done_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400261D RID: 9757
		private static readonly IntPtr NativeMethodInfoPtr_get_default__Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400261E RID: 9758
		private static readonly IntPtr NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400261F RID: 9759
		private static readonly IntPtr NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002620 RID: 9760
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002621 RID: 9761
		private static readonly IntPtr NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002622 RID: 9762
		private static readonly IntPtr NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002623 RID: 9763
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002624 RID: 9764
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002625 RID: 9765
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002626 RID: 9766
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002627 RID: 9767
		private static readonly IntPtr NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002628 RID: 9768
		private static readonly IntPtr NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002629 RID: 9769
		private static readonly IntPtr NativeMethodInfoPtr_get_actionColumnLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400262A RID: 9770
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400262B RID: 9771
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseColumnLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400262C RID: 9772
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerColumnLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400262D RID: 9773
		private static readonly IntPtr NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400262E RID: 9774
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400262F RID: 9775
		private static readonly IntPtr NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002630 RID: 9776
		private static readonly IntPtr NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002631 RID: 9777
		private static readonly IntPtr NativeMethodInfoPtr_get_doneButtonLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002632 RID: 9778
		private static readonly IntPtr NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002633 RID: 9779
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002634 RID: 9780
		private static readonly IntPtr NativeMethodInfoPtr_get_playersGroupLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002635 RID: 9781
		private static readonly IntPtr NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002636 RID: 9782
		private static readonly IntPtr NativeMethodInfoPtr_get_settingsGroupLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002637 RID: 9783
		private static readonly IntPtr NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002638 RID: 9784
		private static readonly IntPtr NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002639 RID: 9785
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400263A RID: 9786
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400263B RID: 9787
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400263C RID: 9788
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400263D RID: 9789
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400263E RID: 9790
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_String_0;

		// Token: 0x0400263F RID: 9791
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x04002640 RID: 9792
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x04002641 RID: 9793
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x04002642 RID: 9794
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x04002643 RID: 9795
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x04002644 RID: 9796
		private static readonly IntPtr NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x04002645 RID: 9797
		private static readonly IntPtr NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Abstract_Virtual_New_String_String_Boolean_0;

		// Token: 0x04002646 RID: 9798
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Abstract_Virtual_New_String_String_String_0;

		// Token: 0x04002647 RID: 9799
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x04002648 RID: 9800
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerName_Public_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x0400264A RID: 9802
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerName_Public_Abstract_Virtual_New_String_Controller_0;

		// Token: 0x0400264B RID: 9803
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_ActionElementMap_0;

		// Token: 0x0400264C RID: 9804
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_Controller_Int32_AxisRange_0;

		// Token: 0x0400264D RID: 9805
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Abstract_Virtual_New_String_KeyCode_ModifierKeyFlags_0;

		// Token: 0x0400264E RID: 9806
		private static readonly IntPtr NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x0400264F RID: 9807
		private static readonly IntPtr NativeMethodInfoPtr_GetActionName_Public_Abstract_Virtual_New_String_Int32_AxisRange_0;

		// Token: 0x04002650 RID: 9808
		private static readonly IntPtr NativeMethodInfoPtr_GetMapCategoryName_Public_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x04002651 RID: 9809
		private static readonly IntPtr NativeMethodInfoPtr_GetActionCategoryName_Public_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x04002652 RID: 9810
		private static readonly IntPtr NativeMethodInfoPtr_GetLayoutName_Public_Abstract_Virtual_New_String_ControllerType_Int32_0;

		// Token: 0x04002653 RID: 9811
		private static readonly IntPtr NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Abstract_Virtual_New_String_ModifierKeyFlags_0;

		// Token: 0x04002654 RID: 9812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
