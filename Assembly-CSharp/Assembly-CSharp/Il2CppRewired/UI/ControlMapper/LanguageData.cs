using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001F9 RID: 505
	[Serializable]
	public class LanguageData : LanguageDataBase
	{
		// Token: 0x06003D91 RID: 15761 RVA: 0x000E6518 File Offset: 0x000E4718
		// Note: this type is marked as 'beforefieldinit'.
		static LanguageData()
		{
			Il2CppClassPointerStore<LanguageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "LanguageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageData>.NativeClassPtr);
			LanguageData.NativeFieldInfoPtr__yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_yes");
			LanguageData.NativeFieldInfoPtr__no = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_no");
			LanguageData.NativeFieldInfoPtr__add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_add");
			LanguageData.NativeFieldInfoPtr__replace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_replace");
			LanguageData.NativeFieldInfoPtr__remove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_remove");
			LanguageData.NativeFieldInfoPtr__swap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_swap");
			LanguageData.NativeFieldInfoPtr__cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_cancel");
			LanguageData.NativeFieldInfoPtr__none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_none");
			LanguageData.NativeFieldInfoPtr__okay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_okay");
			LanguageData.NativeFieldInfoPtr__done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_done");
			LanguageData.NativeFieldInfoPtr__default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_default");
			LanguageData.NativeFieldInfoPtr__assignControllerWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_assignControllerWindowTitle");
			LanguageData.NativeFieldInfoPtr__assignControllerWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_assignControllerWindowMessage");
			LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_controllerAssignmentConflictWindowTitle");
			LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_controllerAssignmentConflictWindowMessage");
			LanguageData.NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_elementAssignmentPrePollingWindowMessage");
			LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_joystickElementAssignmentPollingWindowMessage");
			LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly");
			LanguageData.NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_keyboardElementAssignmentPollingWindowMessage");
			LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mouseElementAssignmentPollingWindowMessage");
			LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly");
			LanguageData.NativeFieldInfoPtr__elementAssignmentConflictWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_elementAssignmentConflictWindowMessage");
			LanguageData.NativeFieldInfoPtr__elementAlreadyInUseBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_elementAlreadyInUseBlocked");
			LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_elementAlreadyInUseCanReplace");
			LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_elementAlreadyInUseCanReplace_conflictAllowed");
			LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mouseAssignmentConflictWindowTitle");
			LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mouseAssignmentConflictWindowMessage");
			LanguageData.NativeFieldInfoPtr__calibrateControllerWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateControllerWindowTitle");
			LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateAxisStep1WindowTitle");
			LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateAxisStep1WindowMessage");
			LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateAxisStep2WindowTitle");
			LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateAxisStep2WindowMessage");
			LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_inputBehaviorSettingsWindowTitle");
			LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_restoreDefaultsWindowTitle");
			LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_restoreDefaultsWindowMessage_onePlayer");
			LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_restoreDefaultsWindowMessage_multiPlayer");
			LanguageData.NativeFieldInfoPtr__actionColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_actionColumnLabel");
			LanguageData.NativeFieldInfoPtr__keyboardColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_keyboardColumnLabel");
			LanguageData.NativeFieldInfoPtr__mouseColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mouseColumnLabel");
			LanguageData.NativeFieldInfoPtr__controllerColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_controllerColumnLabel");
			LanguageData.NativeFieldInfoPtr__removeControllerButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_removeControllerButtonLabel");
			LanguageData.NativeFieldInfoPtr__calibrateControllerButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateControllerButtonLabel");
			LanguageData.NativeFieldInfoPtr__assignControllerButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_assignControllerButtonLabel");
			LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_inputBehaviorSettingsButtonLabel");
			LanguageData.NativeFieldInfoPtr__doneButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_doneButtonLabel");
			LanguageData.NativeFieldInfoPtr__restoreDefaultsButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_restoreDefaultsButtonLabel");
			LanguageData.NativeFieldInfoPtr__playersGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_playersGroupLabel");
			LanguageData.NativeFieldInfoPtr__controllerSettingsGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_controllerSettingsGroupLabel");
			LanguageData.NativeFieldInfoPtr__assignedControllersGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_assignedControllersGroupLabel");
			LanguageData.NativeFieldInfoPtr__settingsGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_settingsGroupLabel");
			LanguageData.NativeFieldInfoPtr__mapCategoriesGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mapCategoriesGroupLabel");
			LanguageData.NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateWindow_deadZoneSliderLabel");
			LanguageData.NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateWindow_zeroSliderLabel");
			LanguageData.NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateWindow_sensitivitySliderLabel");
			LanguageData.NativeFieldInfoPtr__calibrateWindow_invertToggleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateWindow_invertToggleLabel");
			LanguageData.NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateWindow_calibrateButtonLabel");
			LanguageData.NativeFieldInfoPtr__modifierKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_modifierKeys");
			LanguageData.NativeFieldInfoPtr__customEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_customEntries");
			LanguageData.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_initialized");
			LanguageData.NativeFieldInfoPtr_customDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "customDict");
			LanguageData.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669059);
			LanguageData.NativeMethodInfoPtr_GetCustomEntry_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669060);
			LanguageData.NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669061);
			LanguageData.NativeMethodInfoPtr_get_yes_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669062);
			LanguageData.NativeMethodInfoPtr_get_no_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669063);
			LanguageData.NativeMethodInfoPtr_get_add_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669064);
			LanguageData.NativeMethodInfoPtr_get_replace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669065);
			LanguageData.NativeMethodInfoPtr_get_remove_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669066);
			LanguageData.NativeMethodInfoPtr_get_swap_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669067);
			LanguageData.NativeMethodInfoPtr_get_cancel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669068);
			LanguageData.NativeMethodInfoPtr_get_none_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669069);
			LanguageData.NativeMethodInfoPtr_get_okay_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669070);
			LanguageData.NativeMethodInfoPtr_get_done_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669071);
			LanguageData.NativeMethodInfoPtr_get_default__Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669072);
			LanguageData.NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669073);
			LanguageData.NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669074);
			LanguageData.NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669075);
			LanguageData.NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669076);
			LanguageData.NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669077);
			LanguageData.NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669078);
			LanguageData.NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669079);
			LanguageData.NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669080);
			LanguageData.NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669081);
			LanguageData.NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669082);
			LanguageData.NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669083);
			LanguageData.NativeMethodInfoPtr_get_actionColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669084);
			LanguageData.NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669085);
			LanguageData.NativeMethodInfoPtr_get_mouseColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669086);
			LanguageData.NativeMethodInfoPtr_get_controllerColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669087);
			LanguageData.NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669088);
			LanguageData.NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669089);
			LanguageData.NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669090);
			LanguageData.NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669091);
			LanguageData.NativeMethodInfoPtr_get_doneButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669092);
			LanguageData.NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669093);
			LanguageData.NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669094);
			LanguageData.NativeMethodInfoPtr_get_playersGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669095);
			LanguageData.NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669096);
			LanguageData.NativeMethodInfoPtr_get_settingsGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669097);
			LanguageData.NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669098);
			LanguageData.NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669099);
			LanguageData.NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669100);
			LanguageData.NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669101);
			LanguageData.NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669102);
			LanguageData.NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669103);
			LanguageData.NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669104);
			LanguageData.NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Virtual_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669105);
			LanguageData.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669106);
			LanguageData.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669107);
			LanguageData.NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669108);
			LanguageData.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669109);
			LanguageData.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669110);
			LanguageData.NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669111);
			LanguageData.NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Virtual_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669112);
			LanguageData.NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669113);
			LanguageData.NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669114);
			LanguageData.NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669115);
			LanguageData.NativeMethodInfoPtr_GetPlayerName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669116);
			LanguageData.NativeMethodInfoPtr_GetControllerName_Public_Virtual_String_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669117);
			LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669118);
			LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_Controller_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669119);
			LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_KeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669120);
			LanguageData.NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669121);
			LanguageData.NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669122);
			LanguageData.NativeMethodInfoPtr_GetMapCategoryName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669123);
			LanguageData.NativeMethodInfoPtr_GetActionCategoryName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669124);
			LanguageData.NativeMethodInfoPtr_GetLayoutName_Public_Virtual_String_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669125);
			LanguageData.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Virtual_String_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669126);
			LanguageData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669127);
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x000E6F5C File Offset: 0x000E515C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98884, XrefRangeEnd = 98885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x000E6F98 File Offset: 0x000E5198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98885, XrefRangeEnd = 98889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetCustomEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetCustomEntry_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x000E6FEC File Offset: 0x000E51EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98889, XrefRangeEnd = 98891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsCustomEntryKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x000E7044 File Offset: 0x000E5244
		public unsafe override string yes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_yes_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06003D96 RID: 15766 RVA: 0x000E7088 File Offset: 0x000E5288
		public unsafe override string no
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_no_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06003D97 RID: 15767 RVA: 0x000E70CC File Offset: 0x000E52CC
		public unsafe override string add
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_add_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06003D98 RID: 15768 RVA: 0x000E7110 File Offset: 0x000E5310
		public unsafe override string replace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_replace_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06003D99 RID: 15769 RVA: 0x000E7154 File Offset: 0x000E5354
		public unsafe override string remove
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_remove_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06003D9A RID: 15770 RVA: 0x000E7198 File Offset: 0x000E5398
		public unsafe override string swap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_swap_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06003D9B RID: 15771 RVA: 0x000E71DC File Offset: 0x000E53DC
		public unsafe override string cancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_cancel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06003D9C RID: 15772 RVA: 0x000E7220 File Offset: 0x000E5420
		public unsafe override string none
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_none_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06003D9D RID: 15773 RVA: 0x000E7264 File Offset: 0x000E5464
		public unsafe override string okay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_okay_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06003D9E RID: 15774 RVA: 0x000E72A8 File Offset: 0x000E54A8
		public unsafe override string done
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_done_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06003D9F RID: 15775 RVA: 0x000E72EC File Offset: 0x000E54EC
		public unsafe override string default_
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_default__Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06003DA0 RID: 15776 RVA: 0x000E7330 File Offset: 0x000E5530
		public unsafe override string assignControllerWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06003DA1 RID: 15777 RVA: 0x000E7374 File Offset: 0x000E5574
		public unsafe override string assignControllerWindowMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06003DA2 RID: 15778 RVA: 0x000E73B8 File Offset: 0x000E55B8
		public unsafe override string controllerAssignmentConflictWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x000E73FC File Offset: 0x000E55FC
		public unsafe override string elementAssignmentPrePollingWindowMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x000E7440 File Offset: 0x000E5640
		public unsafe override string elementAssignmentConflictWindowMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x06003DA5 RID: 15781 RVA: 0x000E7484 File Offset: 0x000E5684
		public unsafe override string mouseAssignmentConflictWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x06003DA6 RID: 15782 RVA: 0x000E74C8 File Offset: 0x000E56C8
		public unsafe override string calibrateControllerWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06003DA7 RID: 15783 RVA: 0x000E750C File Offset: 0x000E570C
		public unsafe override string calibrateAxisStep1WindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06003DA8 RID: 15784 RVA: 0x000E7550 File Offset: 0x000E5750
		public unsafe override string calibrateAxisStep2WindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06003DA9 RID: 15785 RVA: 0x000E7594 File Offset: 0x000E5794
		public unsafe override string inputBehaviorSettingsWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06003DAA RID: 15786 RVA: 0x000E75D8 File Offset: 0x000E57D8
		public unsafe override string restoreDefaultsWindowTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06003DAB RID: 15787 RVA: 0x000E761C File Offset: 0x000E581C
		public unsafe override string actionColumnLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_actionColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x06003DAC RID: 15788 RVA: 0x000E7660 File Offset: 0x000E5860
		public unsafe override string keyboardColumnLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x000E76A4 File Offset: 0x000E58A4
		public unsafe override string mouseColumnLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_mouseColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x000E76E8 File Offset: 0x000E58E8
		public unsafe override string controllerColumnLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_controllerColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06003DAF RID: 15791 RVA: 0x000E772C File Offset: 0x000E592C
		public unsafe override string removeControllerButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x000E7770 File Offset: 0x000E5970
		public unsafe override string calibrateControllerButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x000E77B4 File Offset: 0x000E59B4
		public unsafe override string assignControllerButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06003DB2 RID: 15794 RVA: 0x000E77F8 File Offset: 0x000E59F8
		public unsafe override string inputBehaviorSettingsButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06003DB3 RID: 15795 RVA: 0x000E783C File Offset: 0x000E5A3C
		public unsafe override string doneButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_doneButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x000E7880 File Offset: 0x000E5A80
		public unsafe override string restoreDefaultsButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x000E78C4 File Offset: 0x000E5AC4
		public unsafe override string controllerSettingsGroupLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x000E7908 File Offset: 0x000E5B08
		public unsafe override string playersGroupLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_playersGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x000E794C File Offset: 0x000E5B4C
		public unsafe override string assignedControllersGroupLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x000E7990 File Offset: 0x000E5B90
		public unsafe override string settingsGroupLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_settingsGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x000E79D4 File Offset: 0x000E5BD4
		public unsafe override string mapCategoriesGroupLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x000E7A18 File Offset: 0x000E5C18
		public unsafe override string restoreDefaultsWindowMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98891, XrefRangeEnd = 98896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06003DBB RID: 15803 RVA: 0x000E7A5C File Offset: 0x000E5C5C
		public unsafe override string calibrateWindow_deadZoneSliderLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x000E7AA0 File Offset: 0x000E5CA0
		public unsafe override string calibrateWindow_zeroSliderLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06003DBD RID: 15805 RVA: 0x000E7AE4 File Offset: 0x000E5CE4
		public unsafe override string calibrateWindow_sensitivitySliderLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06003DBE RID: 15806 RVA: 0x000E7B28 File Offset: 0x000E5D28
		public unsafe override string calibrateWindow_invertToggleLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06003DBF RID: 15807 RVA: 0x000E7B6C File Offset: 0x000E5D6C
		public unsafe override string calibrateWindow_calibrateButtonLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x000E7BB0 File Offset: 0x000E5DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98896, XrefRangeEnd = 98897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Virtual_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x000E7C28 File Offset: 0x000E5E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98897, XrefRangeEnd = 98898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetJoystickElementAssignmentPollingWindowMessage(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x000E7C7C File Offset: 0x000E5E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98898, XrefRangeEnd = 98899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x000E7CD0 File Offset: 0x000E5ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98899, XrefRangeEnd = 98900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetKeyboardElementAssignmentPollingWindowMessage(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x000E7D24 File Offset: 0x000E5F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98900, XrefRangeEnd = 98901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetMouseElementAssignmentPollingWindowMessage(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x000E7D78 File Offset: 0x000E5F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98901, XrefRangeEnd = 98902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x000E7DCC File Offset: 0x000E5FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98902, XrefRangeEnd = 98903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetElementAlreadyInUseBlocked(string elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x000E7E20 File Offset: 0x000E6020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98903, XrefRangeEnd = 98905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Virtual_String_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x000E7E84 File Offset: 0x000E6084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98905, XrefRangeEnd = 98906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x000E7EEC File Offset: 0x000E60EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98906, XrefRangeEnd = 98907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetCalibrateAxisStep1WindowMessage(string axisName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x000E7F40 File Offset: 0x000E6140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98907, XrefRangeEnd = 98908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetCalibrateAxisStep2WindowMessage(string axisName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x000E7F94 File Offset: 0x000E6194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98908, XrefRangeEnd = 98923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetPlayerName(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetPlayerName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x000E7FE4 File Offset: 0x000E61E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98923, XrefRangeEnd = 98930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetControllerName(Controller controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetControllerName_Public_Virtual_String_Controller_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x000E8038 File Offset: 0x000E6238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98930, XrefRangeEnd = 98932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetElementIdentifierName(ActionElementMap actionElementMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionElementMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x000E808C File Offset: 0x000E628C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98932, XrefRangeEnd = 98935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_Controller_Int32_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x000E80FC File Offset: 0x000E62FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98935, XrefRangeEnd = 98940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_KeyCode_ModifierKeyFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x000E815C File Offset: 0x000E635C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98940, XrefRangeEnd = 98945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetActionName(int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x000E81AC File Offset: 0x000E63AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98945, XrefRangeEnd = 98960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetActionName(int actionId, AxisRange axisRange)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x000E820C File Offset: 0x000E640C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98960, XrefRangeEnd = 98965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetMapCategoryName(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetMapCategoryName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x000E825C File Offset: 0x000E645C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98965, XrefRangeEnd = 98970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetActionCategoryName(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetActionCategoryName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x000E82AC File Offset: 0x000E64AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98970, XrefRangeEnd = 98975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetLayoutName(ControllerType controllerType, int id)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_GetLayoutName_Public_Virtual_String_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x000E830C File Offset: 0x000E650C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98975, XrefRangeEnd = 98984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifierKeyFlagsToString(ModifierKeyFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageData.NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Virtual_String_ModifierKeyFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x000E835C File Offset: 0x000E655C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98984, XrefRangeEnd = 99098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LanguageData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x0002616B File Offset: 0x0002436B
		public LanguageData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06003DD8 RID: 15832 RVA: 0x000E8398 File Offset: 0x000E6598
		// (set) Token: 0x06003DD9 RID: 15833 RVA: 0x00026174 File Offset: 0x00024374
		public unsafe string _yes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__yes);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__yes), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x000E83C0 File Offset: 0x000E65C0
		// (set) Token: 0x06003DDB RID: 15835 RVA: 0x00026193 File Offset: 0x00024393
		public unsafe string _no
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__no);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__no), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x000E83E8 File Offset: 0x000E65E8
		// (set) Token: 0x06003DDD RID: 15837 RVA: 0x000261B2 File Offset: 0x000243B2
		public unsafe string _add
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__add);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__add), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x000E8410 File Offset: 0x000E6610
		// (set) Token: 0x06003DDF RID: 15839 RVA: 0x000261D1 File Offset: 0x000243D1
		public unsafe string _replace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__replace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__replace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06003DE0 RID: 15840 RVA: 0x000E8438 File Offset: 0x000E6638
		// (set) Token: 0x06003DE1 RID: 15841 RVA: 0x000261F0 File Offset: 0x000243F0
		public unsafe string _remove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__remove);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__remove), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x000E8460 File Offset: 0x000E6660
		// (set) Token: 0x06003DE3 RID: 15843 RVA: 0x0002620F File Offset: 0x0002440F
		public unsafe string _swap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__swap);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__swap), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x000E8488 File Offset: 0x000E6688
		// (set) Token: 0x06003DE5 RID: 15845 RVA: 0x0002622E File Offset: 0x0002442E
		public unsafe string _cancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__cancel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__cancel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x000E84B0 File Offset: 0x000E66B0
		// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x0002624D File Offset: 0x0002444D
		public unsafe string _none
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__none);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__none), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06003DE8 RID: 15848 RVA: 0x000E84D8 File Offset: 0x000E66D8
		// (set) Token: 0x06003DE9 RID: 15849 RVA: 0x0002626C File Offset: 0x0002446C
		public unsafe string _okay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__okay);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__okay), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x000E8500 File Offset: 0x000E6700
		// (set) Token: 0x06003DEB RID: 15851 RVA: 0x0002628B File Offset: 0x0002448B
		public unsafe string _done
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__done);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__done), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06003DEC RID: 15852 RVA: 0x000E8528 File Offset: 0x000E6728
		// (set) Token: 0x06003DED RID: 15853 RVA: 0x000262AA File Offset: 0x000244AA
		public unsafe string _default
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__default);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__default), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06003DEE RID: 15854 RVA: 0x000E8550 File Offset: 0x000E6750
		// (set) Token: 0x06003DEF RID: 15855 RVA: 0x000262C9 File Offset: 0x000244C9
		public unsafe string _assignControllerWindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerWindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x000E8578 File Offset: 0x000E6778
		// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x000262E8 File Offset: 0x000244E8
		public unsafe string _assignControllerWindowMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerWindowMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x000E85A0 File Offset: 0x000E67A0
		// (set) Token: 0x06003DF3 RID: 15859 RVA: 0x00026307 File Offset: 0x00024507
		public unsafe string _controllerAssignmentConflictWindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06003DF4 RID: 15860 RVA: 0x000E85C8 File Offset: 0x000E67C8
		// (set) Token: 0x06003DF5 RID: 15861 RVA: 0x00026326 File Offset: 0x00024526
		public unsafe string _controllerAssignmentConflictWindowMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x000E85F0 File Offset: 0x000E67F0
		// (set) Token: 0x06003DF7 RID: 15863 RVA: 0x00026345 File Offset: 0x00024545
		public unsafe string _elementAssignmentPrePollingWindowMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06003DF8 RID: 15864 RVA: 0x000E8618 File Offset: 0x000E6818
		// (set) Token: 0x06003DF9 RID: 15865 RVA: 0x00026364 File Offset: 0x00024564
		public unsafe string _joystickElementAssignmentPollingWindowMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06003DFA RID: 15866 RVA: 0x000E8640 File Offset: 0x000E6840
		// (set) Token: 0x06003DFB RID: 15867 RVA: 0x00026383 File Offset: 0x00024583
		public unsafe string _joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06003DFC RID: 15868 RVA: 0x000E8668 File Offset: 0x000E6868
		// (set) Token: 0x06003DFD RID: 15869 RVA: 0x000263A2 File Offset: 0x000245A2
		public unsafe string _keyboardElementAssignmentPollingWindowMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06003DFE RID: 15870 RVA: 0x000E8690 File Offset: 0x000E6890
		// (set) Token: 0x06003DFF RID: 15871 RVA: 0x000263C1 File Offset: 0x000245C1
		public unsafe string _mouseElementAssignmentPollingWindowMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06003E00 RID: 15872 RVA: 0x000E86B8 File Offset: 0x000E68B8
		// (set) Token: 0x06003E01 RID: 15873 RVA: 0x000263E0 File Offset: 0x000245E0
		public unsafe string _mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06003E02 RID: 15874 RVA: 0x000E86E0 File Offset: 0x000E68E0
		// (set) Token: 0x06003E03 RID: 15875 RVA: 0x000263FF File Offset: 0x000245FF
		public unsafe string _elementAssignmentConflictWindowMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAssignmentConflictWindowMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAssignmentConflictWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x000E8708 File Offset: 0x000E6908
		// (set) Token: 0x06003E05 RID: 15877 RVA: 0x0002641E File Offset: 0x0002461E
		public unsafe string _elementAlreadyInUseBlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseBlocked);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseBlocked), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x000E8730 File Offset: 0x000E6930
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x0002643D File Offset: 0x0002463D
		public unsafe string _elementAlreadyInUseCanReplace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x000E8758 File Offset: 0x000E6958
		// (set) Token: 0x06003E09 RID: 15881 RVA: 0x0002645C File Offset: 0x0002465C
		public unsafe string _elementAlreadyInUseCanReplace_conflictAllowed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06003E0A RID: 15882 RVA: 0x000E8780 File Offset: 0x000E6980
		// (set) Token: 0x06003E0B RID: 15883 RVA: 0x0002647B File Offset: 0x0002467B
		public unsafe string _mouseAssignmentConflictWindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06003E0C RID: 15884 RVA: 0x000E87A8 File Offset: 0x000E69A8
		// (set) Token: 0x06003E0D RID: 15885 RVA: 0x0002649A File Offset: 0x0002469A
		public unsafe string _mouseAssignmentConflictWindowMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06003E0E RID: 15886 RVA: 0x000E87D0 File Offset: 0x000E69D0
		// (set) Token: 0x06003E0F RID: 15887 RVA: 0x000264B9 File Offset: 0x000246B9
		public unsafe string _calibrateControllerWindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateControllerWindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateControllerWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x000E87F8 File Offset: 0x000E69F8
		// (set) Token: 0x06003E11 RID: 15889 RVA: 0x000264D8 File Offset: 0x000246D8
		public unsafe string _calibrateAxisStep1WindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x000E8820 File Offset: 0x000E6A20
		// (set) Token: 0x06003E13 RID: 15891 RVA: 0x000264F7 File Offset: 0x000246F7
		public unsafe string _calibrateAxisStep1WindowMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep1WindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06003E14 RID: 15892 RVA: 0x000E8848 File Offset: 0x000E6A48
		// (set) Token: 0x06003E15 RID: 15893 RVA: 0x00026516 File Offset: 0x00024716
		public unsafe string _calibrateAxisStep2WindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06003E16 RID: 15894 RVA: 0x000E8870 File Offset: 0x000E6A70
		// (set) Token: 0x06003E17 RID: 15895 RVA: 0x00026535 File Offset: 0x00024735
		public unsafe string _calibrateAxisStep2WindowMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateAxisStep2WindowMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06003E18 RID: 15896 RVA: 0x000E8898 File Offset: 0x000E6A98
		// (set) Token: 0x06003E19 RID: 15897 RVA: 0x00026554 File Offset: 0x00024754
		public unsafe string _inputBehaviorSettingsWindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x000E88C0 File Offset: 0x000E6AC0
		// (set) Token: 0x06003E1B RID: 15899 RVA: 0x00026573 File Offset: 0x00024773
		public unsafe string _restoreDefaultsWindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06003E1C RID: 15900 RVA: 0x000E88E8 File Offset: 0x000E6AE8
		// (set) Token: 0x06003E1D RID: 15901 RVA: 0x00026592 File Offset: 0x00024792
		public unsafe string _restoreDefaultsWindowMessage_onePlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x000E8910 File Offset: 0x000E6B10
		// (set) Token: 0x06003E1F RID: 15903 RVA: 0x000265B1 File Offset: 0x000247B1
		public unsafe string _restoreDefaultsWindowMessage_multiPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06003E20 RID: 15904 RVA: 0x000E8938 File Offset: 0x000E6B38
		// (set) Token: 0x06003E21 RID: 15905 RVA: 0x000265D0 File Offset: 0x000247D0
		public unsafe string _actionColumnLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__actionColumnLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__actionColumnLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x000E8960 File Offset: 0x000E6B60
		// (set) Token: 0x06003E23 RID: 15907 RVA: 0x000265EF File Offset: 0x000247EF
		public unsafe string _keyboardColumnLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__keyboardColumnLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__keyboardColumnLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x000E8988 File Offset: 0x000E6B88
		// (set) Token: 0x06003E25 RID: 15909 RVA: 0x0002660E File Offset: 0x0002480E
		public unsafe string _mouseColumnLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseColumnLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mouseColumnLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06003E26 RID: 15910 RVA: 0x000E89B0 File Offset: 0x000E6BB0
		// (set) Token: 0x06003E27 RID: 15911 RVA: 0x0002662D File Offset: 0x0002482D
		public unsafe string _controllerColumnLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerColumnLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerColumnLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06003E28 RID: 15912 RVA: 0x000E89D8 File Offset: 0x000E6BD8
		// (set) Token: 0x06003E29 RID: 15913 RVA: 0x0002664C File Offset: 0x0002484C
		public unsafe string _removeControllerButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__removeControllerButtonLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__removeControllerButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06003E2A RID: 15914 RVA: 0x000E8A00 File Offset: 0x000E6C00
		// (set) Token: 0x06003E2B RID: 15915 RVA: 0x0002666B File Offset: 0x0002486B
		public unsafe string _calibrateControllerButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateControllerButtonLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateControllerButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06003E2C RID: 15916 RVA: 0x000E8A28 File Offset: 0x000E6C28
		// (set) Token: 0x06003E2D RID: 15917 RVA: 0x0002668A File Offset: 0x0002488A
		public unsafe string _assignControllerButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerButtonLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignControllerButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06003E2E RID: 15918 RVA: 0x000E8A50 File Offset: 0x000E6C50
		// (set) Token: 0x06003E2F RID: 15919 RVA: 0x000266A9 File Offset: 0x000248A9
		public unsafe string _inputBehaviorSettingsButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06003E30 RID: 15920 RVA: 0x000E8A78 File Offset: 0x000E6C78
		// (set) Token: 0x06003E31 RID: 15921 RVA: 0x000266C8 File Offset: 0x000248C8
		public unsafe string _doneButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__doneButtonLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__doneButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06003E32 RID: 15922 RVA: 0x000E8AA0 File Offset: 0x000E6CA0
		// (set) Token: 0x06003E33 RID: 15923 RVA: 0x000266E7 File Offset: 0x000248E7
		public unsafe string _restoreDefaultsButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsButtonLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__restoreDefaultsButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06003E34 RID: 15924 RVA: 0x000E8AC8 File Offset: 0x000E6CC8
		// (set) Token: 0x06003E35 RID: 15925 RVA: 0x00026706 File Offset: 0x00024906
		public unsafe string _playersGroupLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__playersGroupLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__playersGroupLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06003E36 RID: 15926 RVA: 0x000E8AF0 File Offset: 0x000E6CF0
		// (set) Token: 0x06003E37 RID: 15927 RVA: 0x00026725 File Offset: 0x00024925
		public unsafe string _controllerSettingsGroupLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerSettingsGroupLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__controllerSettingsGroupLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06003E38 RID: 15928 RVA: 0x000E8B18 File Offset: 0x000E6D18
		// (set) Token: 0x06003E39 RID: 15929 RVA: 0x00026744 File Offset: 0x00024944
		public unsafe string _assignedControllersGroupLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignedControllersGroupLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__assignedControllersGroupLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06003E3A RID: 15930 RVA: 0x000E8B40 File Offset: 0x000E6D40
		// (set) Token: 0x06003E3B RID: 15931 RVA: 0x00026763 File Offset: 0x00024963
		public unsafe string _settingsGroupLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__settingsGroupLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__settingsGroupLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06003E3C RID: 15932 RVA: 0x000E8B68 File Offset: 0x000E6D68
		// (set) Token: 0x06003E3D RID: 15933 RVA: 0x00026782 File Offset: 0x00024982
		public unsafe string _mapCategoriesGroupLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mapCategoriesGroupLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__mapCategoriesGroupLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06003E3E RID: 15934 RVA: 0x000E8B90 File Offset: 0x000E6D90
		// (set) Token: 0x06003E3F RID: 15935 RVA: 0x000267A1 File Offset: 0x000249A1
		public unsafe string _calibrateWindow_deadZoneSliderLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06003E40 RID: 15936 RVA: 0x000E8BB8 File Offset: 0x000E6DB8
		// (set) Token: 0x06003E41 RID: 15937 RVA: 0x000267C0 File Offset: 0x000249C0
		public unsafe string _calibrateWindow_zeroSliderLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06003E42 RID: 15938 RVA: 0x000E8BE0 File Offset: 0x000E6DE0
		// (set) Token: 0x06003E43 RID: 15939 RVA: 0x000267DF File Offset: 0x000249DF
		public unsafe string _calibrateWindow_sensitivitySliderLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06003E44 RID: 15940 RVA: 0x000E8C08 File Offset: 0x000E6E08
		// (set) Token: 0x06003E45 RID: 15941 RVA: 0x000267FE File Offset: 0x000249FE
		public unsafe string _calibrateWindow_invertToggleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_invertToggleLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_invertToggleLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x000E8C30 File Offset: 0x000E6E30
		// (set) Token: 0x06003E47 RID: 15943 RVA: 0x0002681D File Offset: 0x00024A1D
		public unsafe string _calibrateWindow_calibrateButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06003E48 RID: 15944 RVA: 0x000E8C58 File Offset: 0x000E6E58
		// (set) Token: 0x06003E49 RID: 15945 RVA: 0x0002683C File Offset: 0x00024A3C
		public unsafe LanguageData.ModifierKeys _modifierKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__modifierKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageData.ModifierKeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__modifierKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06003E4A RID: 15946 RVA: 0x000E8C88 File Offset: 0x000E6E88
		// (set) Token: 0x06003E4B RID: 15947 RVA: 0x0002685B File Offset: 0x00024A5B
		public unsafe Il2CppReferenceArray<LanguageData.CustomEntry> _customEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__customEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LanguageData.CustomEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__customEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06003E4C RID: 15948 RVA: 0x000E8CB8 File Offset: 0x000E6EB8
		// (set) Token: 0x06003E4D RID: 15949 RVA: 0x0002687A File Offset: 0x00024A7A
		public unsafe bool _initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr__initialized)) = value;
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06003E4E RID: 15950 RVA: 0x000E8CE0 File Offset: 0x000E6EE0
		// (set) Token: 0x06003E4F RID: 15951 RVA: 0x00026895 File Offset: 0x00024A95
		public unsafe Dictionary<string, string> customDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_customDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_customDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeFieldInfoPtr__yes;

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeFieldInfoPtr__no;

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeFieldInfoPtr__add;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeFieldInfoPtr__replace;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeFieldInfoPtr__remove;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeFieldInfoPtr__swap;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeFieldInfoPtr__cancel;

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeFieldInfoPtr__none;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeFieldInfoPtr__okay;

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeFieldInfoPtr__done;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeFieldInfoPtr__default;

		// Token: 0x0400259A RID: 9626
		private static readonly IntPtr NativeFieldInfoPtr__assignControllerWindowTitle;

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeFieldInfoPtr__assignControllerWindowMessage;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeFieldInfoPtr__elementAssignmentConflictWindowMessage;

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeFieldInfoPtr__elementAlreadyInUseBlocked;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeFieldInfoPtr__elementAlreadyInUseCanReplace;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle;

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeFieldInfoPtr__calibrateControllerWindowTitle;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeFieldInfoPtr__calibrateAxisStep1WindowTitle;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeFieldInfoPtr__calibrateAxisStep1WindowMessage;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeFieldInfoPtr__calibrateAxisStep2WindowTitle;

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeFieldInfoPtr__calibrateAxisStep2WindowMessage;

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeFieldInfoPtr__restoreDefaultsWindowTitle;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer;

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeFieldInfoPtr__actionColumnLabel;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeFieldInfoPtr__keyboardColumnLabel;

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeFieldInfoPtr__mouseColumnLabel;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeFieldInfoPtr__controllerColumnLabel;

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeFieldInfoPtr__removeControllerButtonLabel;

		// Token: 0x040025B8 RID: 9656
		private static readonly IntPtr NativeFieldInfoPtr__calibrateControllerButtonLabel;

		// Token: 0x040025B9 RID: 9657
		private static readonly IntPtr NativeFieldInfoPtr__assignControllerButtonLabel;

		// Token: 0x040025BA RID: 9658
		private static readonly IntPtr NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel;

		// Token: 0x040025BB RID: 9659
		private static readonly IntPtr NativeFieldInfoPtr__doneButtonLabel;

		// Token: 0x040025BC RID: 9660
		private static readonly IntPtr NativeFieldInfoPtr__restoreDefaultsButtonLabel;

		// Token: 0x040025BD RID: 9661
		private static readonly IntPtr NativeFieldInfoPtr__playersGroupLabel;

		// Token: 0x040025BE RID: 9662
		private static readonly IntPtr NativeFieldInfoPtr__controllerSettingsGroupLabel;

		// Token: 0x040025BF RID: 9663
		private static readonly IntPtr NativeFieldInfoPtr__assignedControllersGroupLabel;

		// Token: 0x040025C0 RID: 9664
		private static readonly IntPtr NativeFieldInfoPtr__settingsGroupLabel;

		// Token: 0x040025C1 RID: 9665
		private static readonly IntPtr NativeFieldInfoPtr__mapCategoriesGroupLabel;

		// Token: 0x040025C2 RID: 9666
		private static readonly IntPtr NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel;

		// Token: 0x040025C3 RID: 9667
		private static readonly IntPtr NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel;

		// Token: 0x040025C4 RID: 9668
		private static readonly IntPtr NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel;

		// Token: 0x040025C5 RID: 9669
		private static readonly IntPtr NativeFieldInfoPtr__calibrateWindow_invertToggleLabel;

		// Token: 0x040025C6 RID: 9670
		private static readonly IntPtr NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel;

		// Token: 0x040025C7 RID: 9671
		private static readonly IntPtr NativeFieldInfoPtr__modifierKeys;

		// Token: 0x040025C8 RID: 9672
		private static readonly IntPtr NativeFieldInfoPtr__customEntries;

		// Token: 0x040025C9 RID: 9673
		private static readonly IntPtr NativeFieldInfoPtr__initialized;

		// Token: 0x040025CA RID: 9674
		private static readonly IntPtr NativeFieldInfoPtr_customDict;

		// Token: 0x040025CB RID: 9675
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040025CC RID: 9676
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomEntry_Public_Virtual_String_String_0;

		// Token: 0x040025CD RID: 9677
		private static readonly IntPtr NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Virtual_Boolean_String_0;

		// Token: 0x040025CE RID: 9678
		private static readonly IntPtr NativeMethodInfoPtr_get_yes_Public_Virtual_get_String_0;

		// Token: 0x040025CF RID: 9679
		private static readonly IntPtr NativeMethodInfoPtr_get_no_Public_Virtual_get_String_0;

		// Token: 0x040025D0 RID: 9680
		private static readonly IntPtr NativeMethodInfoPtr_get_add_Public_Virtual_get_String_0;

		// Token: 0x040025D1 RID: 9681
		private static readonly IntPtr NativeMethodInfoPtr_get_replace_Public_Virtual_get_String_0;

		// Token: 0x040025D2 RID: 9682
		private static readonly IntPtr NativeMethodInfoPtr_get_remove_Public_Virtual_get_String_0;

		// Token: 0x040025D3 RID: 9683
		private static readonly IntPtr NativeMethodInfoPtr_get_swap_Public_Virtual_get_String_0;

		// Token: 0x040025D4 RID: 9684
		private static readonly IntPtr NativeMethodInfoPtr_get_cancel_Public_Virtual_get_String_0;

		// Token: 0x040025D5 RID: 9685
		private static readonly IntPtr NativeMethodInfoPtr_get_none_Public_Virtual_get_String_0;

		// Token: 0x040025D6 RID: 9686
		private static readonly IntPtr NativeMethodInfoPtr_get_okay_Public_Virtual_get_String_0;

		// Token: 0x040025D7 RID: 9687
		private static readonly IntPtr NativeMethodInfoPtr_get_done_Public_Virtual_get_String_0;

		// Token: 0x040025D8 RID: 9688
		private static readonly IntPtr NativeMethodInfoPtr_get_default__Public_Virtual_get_String_0;

		// Token: 0x040025D9 RID: 9689
		private static readonly IntPtr NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Virtual_get_String_0;

		// Token: 0x040025DA RID: 9690
		private static readonly IntPtr NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Virtual_get_String_0;

		// Token: 0x040025DB RID: 9691
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Virtual_get_String_0;

		// Token: 0x040025DC RID: 9692
		private static readonly IntPtr NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Virtual_get_String_0;

		// Token: 0x040025DD RID: 9693
		private static readonly IntPtr NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Virtual_get_String_0;

		// Token: 0x040025DE RID: 9694
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Virtual_get_String_0;

		// Token: 0x040025DF RID: 9695
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Virtual_get_String_0;

		// Token: 0x040025E0 RID: 9696
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Virtual_get_String_0;

		// Token: 0x040025E1 RID: 9697
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Virtual_get_String_0;

		// Token: 0x040025E2 RID: 9698
		private static readonly IntPtr NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Virtual_get_String_0;

		// Token: 0x040025E3 RID: 9699
		private static readonly IntPtr NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Virtual_get_String_0;

		// Token: 0x040025E4 RID: 9700
		private static readonly IntPtr NativeMethodInfoPtr_get_actionColumnLabel_Public_Virtual_get_String_0;

		// Token: 0x040025E5 RID: 9701
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Virtual_get_String_0;

		// Token: 0x040025E6 RID: 9702
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseColumnLabel_Public_Virtual_get_String_0;

		// Token: 0x040025E7 RID: 9703
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerColumnLabel_Public_Virtual_get_String_0;

		// Token: 0x040025E8 RID: 9704
		private static readonly IntPtr NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Virtual_get_String_0;

		// Token: 0x040025E9 RID: 9705
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Virtual_get_String_0;

		// Token: 0x040025EA RID: 9706
		private static readonly IntPtr NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Virtual_get_String_0;

		// Token: 0x040025EB RID: 9707
		private static readonly IntPtr NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Virtual_get_String_0;

		// Token: 0x040025EC RID: 9708
		private static readonly IntPtr NativeMethodInfoPtr_get_doneButtonLabel_Public_Virtual_get_String_0;

		// Token: 0x040025ED RID: 9709
		private static readonly IntPtr NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Virtual_get_String_0;

		// Token: 0x040025EE RID: 9710
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Virtual_get_String_0;

		// Token: 0x040025EF RID: 9711
		private static readonly IntPtr NativeMethodInfoPtr_get_playersGroupLabel_Public_Virtual_get_String_0;

		// Token: 0x040025F0 RID: 9712
		private static readonly IntPtr NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Virtual_get_String_0;

		// Token: 0x040025F1 RID: 9713
		private static readonly IntPtr NativeMethodInfoPtr_get_settingsGroupLabel_Public_Virtual_get_String_0;

		// Token: 0x040025F2 RID: 9714
		private static readonly IntPtr NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Virtual_get_String_0;

		// Token: 0x040025F3 RID: 9715
		private static readonly IntPtr NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Virtual_get_String_0;

		// Token: 0x040025F4 RID: 9716
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Virtual_get_String_0;

		// Token: 0x040025F5 RID: 9717
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Virtual_get_String_0;

		// Token: 0x040025F6 RID: 9718
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Virtual_get_String_0;

		// Token: 0x040025F7 RID: 9719
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Virtual_get_String_0;

		// Token: 0x040025F8 RID: 9720
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Virtual_get_String_0;

		// Token: 0x040025F9 RID: 9721
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Virtual_String_String_String_String_0;

		// Token: 0x040025FA RID: 9722
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0;

		// Token: 0x040025FB RID: 9723
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0;

		// Token: 0x040025FC RID: 9724
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0;

		// Token: 0x040025FD RID: 9725
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0;

		// Token: 0x040025FE RID: 9726
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0;

		// Token: 0x040025FF RID: 9727
		private static readonly IntPtr NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Virtual_String_String_0;

		// Token: 0x04002600 RID: 9728
		private static readonly IntPtr NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Virtual_String_String_Boolean_0;

		// Token: 0x04002601 RID: 9729
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Virtual_String_String_String_0;

		// Token: 0x04002602 RID: 9730
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Virtual_String_String_0;

		// Token: 0x04002603 RID: 9731
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Virtual_String_String_0;

		// Token: 0x04002604 RID: 9732
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerName_Public_Virtual_String_Int32_0;

		// Token: 0x04002605 RID: 9733
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerName_Public_Virtual_String_Controller_0;

		// Token: 0x04002606 RID: 9734
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_ActionElementMap_0;

		// Token: 0x04002607 RID: 9735
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_Controller_Int32_AxisRange_0;

		// Token: 0x04002608 RID: 9736
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_KeyCode_ModifierKeyFlags_0;

		// Token: 0x04002609 RID: 9737
		private static readonly IntPtr NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_0;

		// Token: 0x0400260A RID: 9738
		private static readonly IntPtr NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_AxisRange_0;

		// Token: 0x0400260B RID: 9739
		private static readonly IntPtr NativeMethodInfoPtr_GetMapCategoryName_Public_Virtual_String_Int32_0;

		// Token: 0x0400260C RID: 9740
		private static readonly IntPtr NativeMethodInfoPtr_GetActionCategoryName_Public_Virtual_String_Int32_0;

		// Token: 0x0400260D RID: 9741
		private static readonly IntPtr NativeMethodInfoPtr_GetLayoutName_Public_Virtual_String_ControllerType_Int32_0;

		// Token: 0x0400260E RID: 9742
		private static readonly IntPtr NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Virtual_String_ModifierKeyFlags_0;

		// Token: 0x0400260F RID: 9743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000387 RID: 903
		[Serializable]
		public class CustomEntry : global::Il2CppSystem.Object
		{
			// Token: 0x06005753 RID: 22355 RVA: 0x0013CF84 File Offset: 0x0013B184
			// Note: this type is marked as 'beforefieldinit'.
			static CustomEntry()
			{
				Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "CustomEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr);
				LanguageData.CustomEntry.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr, "key");
				LanguageData.CustomEntry.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr, "value");
				LanguageData.CustomEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr, 100669128);
				LanguageData.CustomEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr, 100669129);
				LanguageData.CustomEntry.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_String_String_Il2CppReferenceArray_1_CustomEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr, 100669130);
			}

			// Token: 0x06005754 RID: 22356 RVA: 0x0013D014 File Offset: 0x0013B214
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomEntry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.CustomEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005755 RID: 22357 RVA: 0x0013D050 File Offset: 0x0013B250
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomEntry(string key, string value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageData.CustomEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.CustomEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005756 RID: 22358 RVA: 0x0013D0B0 File Offset: 0x0013B2B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 98873, RefRangeEnd = 98874, XrefRangeStart = 98853, XrefRangeEnd = 98873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Dictionary<string, string> ToDictionary(Il2CppReferenceArray<LanguageData.CustomEntry> array)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.CustomEntry.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_String_String_Il2CppReferenceArray_1_CustomEntry_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
				}
			}

			// Token: 0x06005757 RID: 22359 RVA: 0x000323DB File Offset: 0x000305DB
			public CustomEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001FE0 RID: 8160
			// (get) Token: 0x06005758 RID: 22360 RVA: 0x0013D0F4 File Offset: 0x0013B2F4
			// (set) Token: 0x06005759 RID: 22361 RVA: 0x000323E4 File Offset: 0x000305E4
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.CustomEntry.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.CustomEntry.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001FE1 RID: 8161
			// (get) Token: 0x0600575A RID: 22362 RVA: 0x0013D11C File Offset: 0x0013B31C
			// (set) Token: 0x0600575B RID: 22363 RVA: 0x00032403 File Offset: 0x00030603
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.CustomEntry.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.CustomEntry.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040039E9 RID: 14825
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040039EA RID: 14826
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040039EB RID: 14827
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040039EC RID: 14828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

			// Token: 0x040039ED RID: 14829
			private static readonly IntPtr NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_String_String_Il2CppReferenceArray_1_CustomEntry_0;
		}

		// Token: 0x02000388 RID: 904
		[Serializable]
		public class ModifierKeys : global::Il2CppSystem.Object
		{
			// Token: 0x0600575C RID: 22364 RVA: 0x0013D144 File Offset: 0x0013B344
			// Note: this type is marked as 'beforefieldinit'.
			static ModifierKeys()
			{
				Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "ModifierKeys");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr);
				LanguageData.ModifierKeys.NativeFieldInfoPtr_control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, "control");
				LanguageData.ModifierKeys.NativeFieldInfoPtr_alt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, "alt");
				LanguageData.ModifierKeys.NativeFieldInfoPtr_shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, "shift");
				LanguageData.ModifierKeys.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, "command");
				LanguageData.ModifierKeys.NativeFieldInfoPtr_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, "separator");
				LanguageData.ModifierKeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr, 100669131);
			}

			// Token: 0x0600575D RID: 22365 RVA: 0x0013D1E8 File Offset: 0x0013B3E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98874, XrefRangeEnd = 98884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModifierKeys()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageData.ModifierKeys>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.ModifierKeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600575E RID: 22366 RVA: 0x00032422 File Offset: 0x00030622
			public ModifierKeys(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001FE2 RID: 8162
			// (get) Token: 0x0600575F RID: 22367 RVA: 0x0013D224 File Offset: 0x0013B424
			// (set) Token: 0x06005760 RID: 22368 RVA: 0x0003242B File Offset: 0x0003062B
			public unsafe string control
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_control);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_control), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001FE3 RID: 8163
			// (get) Token: 0x06005761 RID: 22369 RVA: 0x0013D24C File Offset: 0x0013B44C
			// (set) Token: 0x06005762 RID: 22370 RVA: 0x0003244A File Offset: 0x0003064A
			public unsafe string alt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_alt);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_alt), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001FE4 RID: 8164
			// (get) Token: 0x06005763 RID: 22371 RVA: 0x0013D274 File Offset: 0x0013B474
			// (set) Token: 0x06005764 RID: 22372 RVA: 0x00032469 File Offset: 0x00030669
			public unsafe string shift
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_shift);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_shift), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001FE5 RID: 8165
			// (get) Token: 0x06005765 RID: 22373 RVA: 0x0013D29C File Offset: 0x0013B49C
			// (set) Token: 0x06005766 RID: 22374 RVA: 0x00032488 File Offset: 0x00030688
			public unsafe string command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_command);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_command), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001FE6 RID: 8166
			// (get) Token: 0x06005767 RID: 22375 RVA: 0x0013D2C4 File Offset: 0x0013B4C4
			// (set) Token: 0x06005768 RID: 22376 RVA: 0x000324A7 File Offset: 0x000306A7
			public unsafe string separator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_separator);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.ModifierKeys.NativeFieldInfoPtr_separator), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040039EE RID: 14830
			private static readonly IntPtr NativeFieldInfoPtr_control;

			// Token: 0x040039EF RID: 14831
			private static readonly IntPtr NativeFieldInfoPtr_alt;

			// Token: 0x040039F0 RID: 14832
			private static readonly IntPtr NativeFieldInfoPtr_shift;

			// Token: 0x040039F1 RID: 14833
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x040039F2 RID: 14834
			private static readonly IntPtr NativeFieldInfoPtr_separator;

			// Token: 0x040039F3 RID: 14835
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
