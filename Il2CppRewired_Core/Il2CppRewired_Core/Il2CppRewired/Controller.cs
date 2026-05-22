using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Config;
using Il2CppRewired.Data.Mapping;
using Il2CppRewired.Interfaces;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200005D RID: 93
	public class Controller : global::Il2CppSystem.Object
	{
		// Token: 0x06000D2F RID: 3375 RVA: 0x0005B4B4 File Offset: 0x000596B4
		// Note: this type is marked as 'beforefieldinit'.
		static Controller()
		{
			Il2CppClassPointerStore<Controller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "Controller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller>.NativeClassPtr);
			Controller.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "id");
			Controller.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "_tag");
			Controller.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "_name");
			Controller.NativeFieldInfoPtr__hardwareName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "_hardwareName");
			Controller.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "_type");
			Controller.NativeFieldInfoPtr_fIcXfqCOzQsnxIOcRigOBZXpXnvF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "fIcXfqCOzQsnxIOcRigOBZXpXnvF");
			Controller.NativeFieldInfoPtr__hardwareIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "_hardwareIdentifier");
			Controller.NativeFieldInfoPtr__isConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "_isConnected");
			Controller.NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "sZKOvZaohDAzdPVObwABOvwFgQN");
			Controller.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "kOIBhhDgDUQCZtioVlUwqEtbkMdb");
			Controller.NativeFieldInfoPtr_VRXiejtUDZpPQeLVYwMNZjtbFsL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "VRXiejtUDZpPQeLVYwMNZjtbFsL");
			Controller.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "SBmxkshsppDFZPZvftqYxbMuemu");
			Controller.NativeFieldInfoPtr__buttonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "_buttonCount");
			Controller.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "buttons");
			Controller.NativeFieldInfoPtr_buttons_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "buttons_readOnly");
			Controller.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "xQkGABJRsmzTPSmeXgqJmJTMBma");
			Controller.NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "FaxDYKiOiLbKbaDgSKQsyfLUaPD");
			Controller.NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "tamJGhaDrwcqghjueRIJXoQsGYe");
			Controller.NativeFieldInfoPtr_PMXDiYGmcXVVkDcmgDWXjFJkhrb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "PMXDiYGmcXVVkDcmgDWXjFJkhrb");
			Controller.NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "iNsxDqPHPTqhYqUYyDyQzTlxlTE");
			Controller.NativeFieldInfoPtr_euujNstWUJPsDbTKKcaexZORnTO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "euujNstWUJPsDbTKKcaexZORnTO");
			Controller.NativeFieldInfoPtr_uHgdTRrupCOjmyLWlTbhSSrxNGg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "uHgdTRrupCOjmyLWlTbhSSrxNGg");
			Controller.NativeFieldInfoPtr_zeuBHSTCctkLRaCULEBmvlednWB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "zeuBHSTCctkLRaCULEBmvlednWB");
			Controller.NativeFieldInfoPtr_qqpveziflpDCMqhzVMsvgajLKBW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "qqpveziflpDCMqhzVMsvgajLKBW");
			Controller.NativeFieldInfoPtr_LtIuQBqpAvXVONgNUhAiNnjilPJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "LtIuQBqpAvXVONgNUhAiNnjilPJ");
			Controller.NativeFieldInfoPtr_FNUyKIuPARrWKhDiXoKaNJOOEQof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "FNUyKIuPARrWKhDiXoKaNJOOEQof");
			Controller.NativeFieldInfoPtr_msxgtQqXJSjoKXblriFyJsNhsaPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "msxgtQqXJSjoKXblriFyJsNhsaPS");
			Controller.NativeFieldInfoPtr_rWFAQldkUxHoabEdJagoEbvjxEoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "rWFAQldkUxHoabEdJagoEbvjxEoM");
			Controller.NativeFieldInfoPtr_fLFpHVQnsuobZbdJnHTVVQDxIDpa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "fLFpHVQnsuobZbdJnHTVVQDxIDpa");
			Controller.NativeFieldInfoPtr_gCuUadDmcMFLNzQinFNSXhAQJry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "gCuUadDmcMFLNzQinFNSXhAQJry");
			Controller.NativeMethodInfoPtr_get_wasPollingPrev_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665123);
			Controller.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665124);
			Controller.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665125);
			Controller.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665126);
			Controller.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665127);
			Controller.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665128);
			Controller.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665129);
			Controller.NativeMethodInfoPtr_get_hardwareName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665130);
			Controller.NativeMethodInfoPtr_get_type_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665131);
			Controller.NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665132);
			Controller.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665133);
			Controller.NativeMethodInfoPtr_get_identifier_Public_get_ControllerIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665134);
			Controller.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665135);
			Controller.NativeMethodInfoPtr_set_isConnected_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665136);
			Controller.NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665137);
			Controller.NativeMethodInfoPtr_get_mapTypeString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665138);
			Controller.NativeMethodInfoPtr_get_elementCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665139);
			Controller.NativeMethodInfoPtr_get_buttonCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665140);
			Controller.NativeMethodInfoPtr_get_Elements_Public_get_IList_1_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665141);
			Controller.NativeMethodInfoPtr_get_Buttons_Public_get_IList_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665142);
			Controller.NativeMethodInfoPtr_get_extension_Public_get_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665143);
			Controller.NativeMethodInfoPtr_get_ElementIdentifiers_Public_get_IList_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665144);
			Controller.NativeMethodInfoPtr_get_ButtonElementIdentifiers_Public_get_IList_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665145);
			Controller.NativeMethodInfoPtr_add_EnabledStateChangedEvent_Internal_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665146);
			Controller.NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Internal_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665147);
			Controller.NativeMethodInfoPtr__ctor_Internal_Void_Int32_InputSource_String_String_String_ControllerType_Guid_Int32_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_HardwareButtonInfo_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665148);
			Controller.NativeMethodInfoPtr_VBMAdMfUBOwERgwdflafhltpBVWY_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665149);
			Controller.NativeMethodInfoPtr_GetElementById_Public_Virtual_New_Element_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665150);
			Controller.NativeMethodInfoPtr_GetButtonIndexById_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665151);
			Controller.NativeMethodInfoPtr_GetElementIdentifierById_Public_ControllerElementIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665152);
			Controller.NativeMethodInfoPtr_GetButton_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665153);
			Controller.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665154);
			Controller.NativeMethodInfoPtr_GetButtonUp_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665155);
			Controller.NativeMethodInfoPtr_GetButtonChanged_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665156);
			Controller.NativeMethodInfoPtr_GetButtonPrev_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665157);
			Controller.NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665158);
			Controller.NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Virtual_New_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665159);
			Controller.NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665160);
			Controller.NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Virtual_New_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665161);
			Controller.NativeMethodInfoPtr_GetButtonTimePressed_Public_Virtual_New_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665162);
			Controller.NativeMethodInfoPtr_GetButtonTimeUnpressed_Public_Virtual_New_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665163);
			Controller.NativeMethodInfoPtr_GetButtonLastTimePressed_Public_Virtual_New_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665164);
			Controller.NativeMethodInfoPtr_GetButtonLastTimeUnpressed_Public_Virtual_New_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665165);
			Controller.NativeMethodInfoPtr_GetAnyButton_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665166);
			Controller.NativeMethodInfoPtr_GetAnyButtonDown_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665167);
			Controller.NativeMethodInfoPtr_GetAnyButtonUp_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665168);
			Controller.NativeMethodInfoPtr_GetAnyButtonPrev_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665169);
			Controller.NativeMethodInfoPtr_GetAnyButtonChanged_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665170);
			Controller.NativeMethodInfoPtr_GetButtonById_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665171);
			Controller.NativeMethodInfoPtr_GetButtonDownById_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665172);
			Controller.NativeMethodInfoPtr_GetButtonUpById_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665173);
			Controller.NativeMethodInfoPtr_GetButtonDoublePressHoldById_Public_Virtual_New_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665174);
			Controller.NativeMethodInfoPtr_GetButtonDoublePressDownById_Public_Virtual_New_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665175);
			Controller.NativeMethodInfoPtr_GetButtonDoublePressHoldById_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665176);
			Controller.NativeMethodInfoPtr_GetButtonDoublePressDownById_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665177);
			Controller.NativeMethodInfoPtr_GetButtonPrevById_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665178);
			Controller.NativeMethodInfoPtr_GetButtonTimePressedById_Public_Virtual_New_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665179);
			Controller.NativeMethodInfoPtr_GetButtonTimeUnpressedById_Public_Virtual_New_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665180);
			Controller.NativeMethodInfoPtr_GetButtonLastTimePressedById_Public_Virtual_New_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665181);
			Controller.NativeMethodInfoPtr_GetButtonLastTimeUnpressedById_Public_Virtual_New_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665182);
			Controller.NativeMethodInfoPtr_PollForFirstElement_Public_Virtual_New_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665183);
			Controller.NativeMethodInfoPtr_PollForFirstElementDown_Public_Virtual_New_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665184);
			Controller.NativeMethodInfoPtr_PollForFirstButton_Public_Virtual_New_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665185);
			Controller.NativeMethodInfoPtr_PollForFirstButtonDown_Public_Virtual_New_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665186);
			Controller.NativeMethodInfoPtr_PollForAllElements_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665187);
			Controller.NativeMethodInfoPtr_PollForAllElementsDown_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665188);
			Controller.NativeMethodInfoPtr_PollForAllButtons_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665189);
			Controller.NativeMethodInfoPtr_PollForAllButtonsDown_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665190);
			Controller.NativeMethodInfoPtr_ezcxwwMBAShkckFadwqucsvGOGqn_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665191);
			Controller.NativeMethodInfoPtr_cZnZBUDXfBEWnivhVcCnlQCBqpS_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665192);
			Controller.NativeMethodInfoPtr_UpdatePollingFrameTracking_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665193);
			Controller.NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_New_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665194);
			Controller.NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_New_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665195);
			Controller.NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_New_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665196);
			Controller.NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_New_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665197);
			Controller.NativeMethodInfoPtr_GetLastTimeAnyButtonPressed_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665198);
			Controller.NativeMethodInfoPtr_GetLastTimeAnyButtonChanged_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665199);
			Controller.NativeMethodInfoPtr_GetExtension_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665200);
			Controller.NativeMethodInfoPtr_get_Templates_Public_get_IList_1_IControllerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665201);
			Controller.NativeMethodInfoPtr_get_templateCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665202);
			Controller.NativeMethodInfoPtr_GetTemplate_Public_IControllerTemplate_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665203);
			Controller.NativeMethodInfoPtr_GetTemplate_Public_IControllerTemplate_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665204);
			Controller.NativeMethodInfoPtr_GetTemplate_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665205);
			Controller.NativeMethodInfoPtr_ImplementsTemplate_Public_Boolean_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665206);
			Controller.NativeMethodInfoPtr_ImplementsTemplate_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665207);
			Controller.NativeMethodInfoPtr_ImplementsTemplate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665208);
			Controller.NativeMethodInfoPtr_WgmUOrDLGlmvZYpcMBtxBtqkohh_Internal_Void_Il2CppReferenceArray_1_IControllerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665209);
			Controller.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_New_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665210);
			Controller.NativeMethodInfoPtr_FzhWgnQeRcXBpClnAbkhPUSvcSzG_Internal_Virtual_New_ButtonStateFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665211);
			Controller.NativeMethodInfoPtr_HhjfTuVPdxBkWXmHCIKPGrtaPpU_Internal_Void_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665212);
			Controller.NativeMethodInfoPtr_RuglyNxbeUVEKWvtsQgguwCgpTY_Internal_Void_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665213);
			Controller.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665214);
			Controller.NativeMethodInfoPtr_DmSiOupNgsMWUccocIUOZmnzejoJ_Internal_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665215);
			Controller.NativeMethodInfoPtr_pZoQVaXjWpxKnkHUeJUpyVawiKT_Internal_Virtual_New_Void_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665216);
			Controller.NativeMethodInfoPtr_RliirvzCZqWXcPEGpRIuiOoLMRg_Internal_Virtual_New_Void_ControllerMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665217);
			Controller.NativeMethodInfoPtr_QtAGTczuKNIRNdPrziddijJqXAd_Internal_Boolean_ActionElementMap_Int32_byref_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665218);
			Controller.NativeMethodInfoPtr_QtAGTczuKNIRNdPrziddijJqXAd_Internal_Boolean_ActionElementMap_Int32_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665219);
			Controller.NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Void_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665220);
			Controller.NativeMethodInfoPtr_dpOcYpiEjVqmqIagMFgWQQnyfJmZ_Internal_Virtual_New_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665221);
			Controller.NativeMethodInfoPtr_zmCSqHjkWDCylUlUderSfqqEXvh_Internal_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665222);
			Controller.NativeMethodInfoPtr_Connected_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665223);
			Controller.NativeMethodInfoPtr_Disconnected_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665224);
			Controller.NativeMethodInfoPtr_get_implementsTemplateDelegate_Guid_Internal_Static_get_Func_3_Controller_Guid_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665225);
			Controller.NativeMethodInfoPtr_get_implementsTemplateDelegate_Type_Internal_Static_get_Func_3_Controller_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665226);
			Controller.NativeMethodInfoPtr_AFpswjVoVDCITVCaHZTSAJiVRZp_Private_Static_Boolean_Controller_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665227);
			Controller.NativeMethodInfoPtr_oBTctCvhzzvdhYSKOUYKrzaDMzV_Private_Static_Boolean_Controller_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100665228);
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0005BF84 File Offset: 0x0005A184
		public unsafe bool wasPollingPrev
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253287, XrefRangeEnd = 253291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_wasPollingPrev_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0005BFC0 File Offset: 0x0005A1C0
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x0005BFFC File Offset: 0x0005A1FC
		public unsafe bool enabled
		{
			[CallerCount(101)]
			[CachedScanResults(RefRangeStart = 253295, RefRangeEnd = 253396, XrefRangeStart = 253291, XrefRangeEnd = 253295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x0005C03C File Offset: 0x0005A23C
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x0005C074 File Offset: 0x0005A274
		public unsafe string name
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 253401, RefRangeEnd = 253426, XrefRangeStart = 253396, XrefRangeEnd = 253401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x0005C0B8 File Offset: 0x0005A2B8
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x0005C0F0 File Offset: 0x0005A2F0
		public unsafe string tag
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 253431, RefRangeEnd = 253436, XrefRangeStart = 253426, XrefRangeEnd = 253431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 253440, RefRangeEnd = 253442, XrefRangeStart = 253436, XrefRangeEnd = 253440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0005C134 File Offset: 0x0005A334
		public unsafe string hardwareName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 253447, RefRangeEnd = 253452, XrefRangeStart = 253442, XrefRangeEnd = 253447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_hardwareName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x0005C16C File Offset: 0x0005A36C
		public unsafe ControllerType type
		{
			[CallerCount(100)]
			[CachedScanResults(RefRangeStart = 253456, RefRangeEnd = 253556, XrefRangeStart = 253452, XrefRangeEnd = 253456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_type_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x0005C1A8 File Offset: 0x0005A3A8
		public unsafe Guid hardwareTypeGuid
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 253567, RefRangeEnd = 253580, XrefRangeStart = 253556, XrefRangeEnd = 253567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x0005C1E4 File Offset: 0x0005A3E4
		public unsafe virtual Guid deviceInstanceGuid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0005C22C File Offset: 0x0005A42C
		public unsafe ControllerIdentifier identifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_identifier_Public_get_ControllerIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ControllerIdentifier(intPtr);
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0005C264 File Offset: 0x0005A464
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x0005C2A0 File Offset: 0x0005A4A0
		public unsafe bool isConnected
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253580, XrefRangeEnd = 253584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 253590, RefRangeEnd = 253592, XrefRangeStart = 253584, XrefRangeEnd = 253590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_set_isConnected_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0005C2E0 File Offset: 0x0005A4E0
		public unsafe string hardwareIdentifier
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 253597, RefRangeEnd = 253609, XrefRangeStart = 253592, XrefRangeEnd = 253597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0005C318 File Offset: 0x0005A518
		public unsafe string mapTypeString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253609, XrefRangeEnd = 253616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_mapTypeString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0005C350 File Offset: 0x0005A550
		public unsafe int elementCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253616, XrefRangeEnd = 253625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_elementCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0005C38C File Offset: 0x0005A58C
		public unsafe int buttonCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253625, XrefRangeEnd = 253629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_buttonCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0005C3C8 File Offset: 0x0005A5C8
		public unsafe IList<Controller.Element> Elements
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253629, XrefRangeEnd = 253634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_Elements_Public_get_IList_1_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Controller.Element>>(intPtr3) : null;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x0005C408 File Offset: 0x0005A608
		public unsafe IList<Controller.Button> Buttons
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 253639, RefRangeEnd = 253643, XrefRangeStart = 253634, XrefRangeEnd = 253639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_Buttons_Public_get_IList_1_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Controller.Button>>(intPtr3) : null;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0005C448 File Offset: 0x0005A648
		public unsafe Controller.Extension extension
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 253647, RefRangeEnd = 253664, XrefRangeStart = 253643, XrefRangeEnd = 253647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_extension_Public_get_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0005C488 File Offset: 0x0005A688
		public unsafe IList<ControllerElementIdentifier> ElementIdentifiers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253664, XrefRangeEnd = 253669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_ElementIdentifiers_Public_get_IList_1_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ControllerElementIdentifier>>(intPtr3) : null;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x0005C4C8 File Offset: 0x0005A6C8
		public unsafe IList<ControllerElementIdentifier> ButtonElementIdentifiers
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 253674, RefRangeEnd = 253686, XrefRangeStart = 253669, XrefRangeEnd = 253674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_ButtonElementIdentifiers_Public_get_IList_1_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ControllerElementIdentifier>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0005C508 File Offset: 0x0005A708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253686, XrefRangeEnd = 253689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_EnabledStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_add_EnabledStateChangedEvent_Internal_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0005C54C File Offset: 0x0005A74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253689, XrefRangeEnd = 253692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_EnabledStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Internal_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0005C590 File Offset: 0x0005A790
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253781, RefRangeEnd = 253785, XrefRangeStart = 253692, XrefRangeEnd = 253781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Controller(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int buttonCount, Il2CppStructArray<bool> isButtonPressureSensitive, Il2CppReferenceArray<HardwareButtonInfo> hwButtonInfo, HardwareControllerMap_Game hardwareMap, Controller.Extension extension, ControllerDataUpdater dataUpdater)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareIdentifier);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardwareTypeGuid;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isButtonPressureSensitive);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwButtonInfo);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareMap);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extension);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr__ctor_Internal_Void_Int32_InputSource_String_String_String_ControllerType_Guid_Int32_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_HardwareButtonInfo_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0005C6AC File Offset: 0x0005A8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253785, XrefRangeEnd = 253787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void VBMAdMfUBOwERgwdflafhltpBVWY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_VBMAdMfUBOwERgwdflafhltpBVWY_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0005C6E8 File Offset: 0x0005A8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253787, XrefRangeEnd = 253792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Controller.Element GetElementById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetElementById_Public_Virtual_New_Element_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Element>(intPtr3) : null;
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0005C740 File Offset: 0x0005A940
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 253796, RefRangeEnd = 253798, XrefRangeStart = 253792, XrefRangeEnd = 253796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetButtonIndexById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_GetButtonIndexById_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0005C78C File Offset: 0x0005A98C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 253803, RefRangeEnd = 253817, XrefRangeStart = 253798, XrefRangeEnd = 253803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier GetElementIdentifierById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_GetElementIdentifierById_Public_ControllerElementIdentifier_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x0005C7D8 File Offset: 0x0005A9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253817, XrefRangeEnd = 253824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButton(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButton_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0005C82C File Offset: 0x0005AA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253824, XrefRangeEnd = 253831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDown(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0005C880 File Offset: 0x0005AA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253831, XrefRangeEnd = 253838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonUp(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonUp_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0005C8D4 File Offset: 0x0005AAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253838, XrefRangeEnd = 253844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonChanged(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonChanged_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0005C928 File Offset: 0x0005AB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253844, XrefRangeEnd = 253851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonPrev(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonPrev_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0005C97C File Offset: 0x0005AB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253851, XrefRangeEnd = 253857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDoublePressHold(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0005C9D0 File Offset: 0x0005ABD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253857, XrefRangeEnd = 253865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDoublePressHold(int index, float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Virtual_New_Boolean_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0005CA34 File Offset: 0x0005AC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253865, XrefRangeEnd = 253871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDoublePressDown(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0005CA88 File Offset: 0x0005AC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253871, XrefRangeEnd = 253879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDoublePressDown(int index, float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Virtual_New_Boolean_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0005CAEC File Offset: 0x0005ACEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253879, XrefRangeEnd = 253886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetButtonTimePressed(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonTimePressed_Public_Virtual_New_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0005CB40 File Offset: 0x0005AD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253886, XrefRangeEnd = 253893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetButtonTimeUnpressed(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonTimeUnpressed_Public_Virtual_New_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0005CB94 File Offset: 0x0005AD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253893, XrefRangeEnd = 253900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetButtonLastTimePressed(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonLastTimePressed_Public_Virtual_New_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0005CBE8 File Offset: 0x0005ADE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253900, XrefRangeEnd = 253907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetButtonLastTimeUnpressed(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonLastTimeUnpressed_Public_Virtual_New_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0005CC3C File Offset: 0x0005AE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253907, XrefRangeEnd = 253912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetAnyButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetAnyButton_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0005CC84 File Offset: 0x0005AE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253912, XrefRangeEnd = 253917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetAnyButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetAnyButtonDown_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0005CCCC File Offset: 0x0005AECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253917, XrefRangeEnd = 253922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetAnyButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetAnyButtonUp_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0005CD14 File Offset: 0x0005AF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253922, XrefRangeEnd = 253927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetAnyButtonPrev()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetAnyButtonPrev_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0005CD5C File Offset: 0x0005AF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253927, XrefRangeEnd = 253941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetAnyButtonChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetAnyButtonChanged_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0005CDA4 File Offset: 0x0005AFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253941, XrefRangeEnd = 253945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonById_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0005CDF8 File Offset: 0x0005AFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253945, XrefRangeEnd = 253949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDownById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonDownById_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0005CE4C File Offset: 0x0005B04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253949, XrefRangeEnd = 253953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonUpById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonUpById_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0005CEA0 File Offset: 0x0005B0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253953, XrefRangeEnd = 253962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDoublePressHoldById(int elementIdentifierId, float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonDoublePressHoldById_Public_Virtual_New_Boolean_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0005CF04 File Offset: 0x0005B104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253962, XrefRangeEnd = 253971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDoublePressDownById(int elementIdentifierId, float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonDoublePressDownById_Public_Virtual_New_Boolean_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0005CF68 File Offset: 0x0005B168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253971, XrefRangeEnd = 253977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDoublePressHoldById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonDoublePressHoldById_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0005CFBC File Offset: 0x0005B1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253977, XrefRangeEnd = 253983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDoublePressDownById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonDoublePressDownById_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0005D010 File Offset: 0x0005B210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253983, XrefRangeEnd = 253987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonPrevById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonPrevById_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0005D064 File Offset: 0x0005B264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253987, XrefRangeEnd = 253991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetButtonTimePressedById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonTimePressedById_Public_Virtual_New_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0005D0B8 File Offset: 0x0005B2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253991, XrefRangeEnd = 253995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetButtonTimeUnpressedById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonTimeUnpressedById_Public_Virtual_New_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0005D10C File Offset: 0x0005B30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253995, XrefRangeEnd = 253999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetButtonLastTimePressedById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonLastTimePressedById_Public_Virtual_New_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0005D160 File Offset: 0x0005B360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253999, XrefRangeEnd = 254003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetButtonLastTimeUnpressedById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetButtonLastTimeUnpressedById_Public_Virtual_New_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0005D1B4 File Offset: 0x0005B3B4
		[CallerCount(0)]
		public unsafe virtual ControllerPollingInfo PollForFirstElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_PollForFirstElement_Public_Virtual_New_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0005D1F8 File Offset: 0x0005B3F8
		[CallerCount(0)]
		public unsafe virtual ControllerPollingInfo PollForFirstElementDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_PollForFirstElementDown_Public_Virtual_New_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0005D23C File Offset: 0x0005B43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254003, XrefRangeEnd = 254012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ControllerPollingInfo PollForFirstButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_PollForFirstButton_Public_Virtual_New_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0005D280 File Offset: 0x0005B480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254012, XrefRangeEnd = 254021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ControllerPollingInfo PollForFirstButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_PollForFirstButtonDown_Public_Virtual_New_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0005D2C4 File Offset: 0x0005B4C4
		[CallerCount(0)]
		public unsafe virtual IEnumerable<ControllerPollingInfo> PollForAllElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_PollForAllElements_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0005D310 File Offset: 0x0005B510
		[CallerCount(0)]
		public unsafe virtual IEnumerable<ControllerPollingInfo> PollForAllElementsDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_PollForAllElementsDown_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0005D35C File Offset: 0x0005B55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254021, XrefRangeEnd = 254026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<ControllerPollingInfo> PollForAllButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_PollForAllButtons_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0005D3A8 File Offset: 0x0005B5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254026, XrefRangeEnd = 254031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<ControllerPollingInfo> PollForAllButtonsDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_PollForAllButtonsDown_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0005D3F4 File Offset: 0x0005B5F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254032, RefRangeEnd = 254034, XrefRangeStart = 254031, XrefRangeEnd = 254032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ezcxwwMBAShkckFadwqucsvGOGqn(int A_1, out int A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_ezcxwwMBAShkckFadwqucsvGOGqn_Private_Boolean_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0005D44C File Offset: 0x0005B64C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254035, RefRangeEnd = 254037, XrefRangeStart = 254034, XrefRangeEnd = 254035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool cZnZBUDXfBEWnivhVcCnlQCBqpS(int A_1, out int A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_cZnZBUDXfBEWnivhVcCnlQCBqpS_Private_Boolean_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0005D4A4 File Offset: 0x0005B6A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 254048, RefRangeEnd = 254054, XrefRangeStart = 254037, XrefRangeEnd = 254048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePollingFrameTracking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_UpdatePollingFrameTracking_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0005D4D8 File Offset: 0x0005B6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254054, XrefRangeEnd = 254060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetLastTimeActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_New_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0005D520 File Offset: 0x0005B720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254072, RefRangeEnd = 254073, XrefRangeStart = 254060, XrefRangeEnd = 254072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetLastTimeActive(bool useRawValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useRawValues;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_New_Double_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0005D574 File Offset: 0x0005B774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254073, XrefRangeEnd = 254079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetLastTimeAnyElementChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_New_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0005D5BC File Offset: 0x0005B7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254079, XrefRangeEnd = 254086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double GetLastTimeAnyElementChanged(bool useRawValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useRawValues;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_New_Double_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0005D610 File Offset: 0x0005B810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254086, XrefRangeEnd = 254092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetLastTimeAnyButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_GetLastTimeAnyButtonPressed_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0005D64C File Offset: 0x0005B84C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254107, RefRangeEnd = 254109, XrefRangeStart = 254092, XrefRangeEnd = 254107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetLastTimeAnyButtonChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_GetLastTimeAnyButtonChanged_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0005D688 File Offset: 0x0005B888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254109, XrefRangeEnd = 254120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetExtension<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.MethodInfoStoreGeneric_GetExtension_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0005D6C4 File Offset: 0x0005B8C4
		public unsafe IList<IControllerTemplate> Templates
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 254125, RefRangeEnd = 254128, XrefRangeStart = 254120, XrefRangeEnd = 254125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_Templates_Public_get_IList_1_IControllerTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IControllerTemplate>>(intPtr3) : null;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0005D704 File Offset: 0x0005B904
		public unsafe int templateCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 254132, RefRangeEnd = 254136, XrefRangeStart = 254128, XrefRangeEnd = 254132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_templateCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0005D740 File Offset: 0x0005B940
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254149, RefRangeEnd = 254152, XrefRangeStart = 254136, XrefRangeEnd = 254149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IControllerTemplate GetTemplate(Guid typeGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeGuid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_GetTemplate_Public_IControllerTemplate_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0005D78C File Offset: 0x0005B98C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254158, RefRangeEnd = 254160, XrefRangeStart = 254152, XrefRangeEnd = 254158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IControllerTemplate GetTemplate(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_GetTemplate_Public_IControllerTemplate_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0005D7DC File Offset: 0x0005B9DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254173, RefRangeEnd = 254175, XrefRangeStart = 254160, XrefRangeEnd = 254173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetTemplate<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.MethodInfoStoreGeneric_GetTemplate_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0005D818 File Offset: 0x0005BA18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254188, RefRangeEnd = 254190, XrefRangeStart = 254175, XrefRangeEnd = 254188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImplementsTemplate(Guid typeGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeGuid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_ImplementsTemplate_Public_Boolean_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0005D864 File Offset: 0x0005BA64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254196, RefRangeEnd = 254198, XrefRangeStart = 254190, XrefRangeEnd = 254196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImplementsTemplate(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_ImplementsTemplate_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0005D8B4 File Offset: 0x0005BAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254198, XrefRangeEnd = 254204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImplementsTemplate<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.MethodInfoStoreGeneric_ImplementsTemplate_Public_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0005D8F0 File Offset: 0x0005BAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254204, XrefRangeEnd = 254208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WgmUOrDLGlmvZYpcMBtxBtqkohh(Il2CppReferenceArray<IControllerTemplate> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_WgmUOrDLGlmvZYpcMBtxBtqkohh_Internal_Void_Il2CppReferenceArray_1_IControllerTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0005D934 File Offset: 0x0005BB34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254213, RefRangeEnd = 254215, XrefRangeStart = 254208, XrefRangeEnd = 254213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ZTVaYQHtFassaSGDSzEcxNiGpigu(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_New_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0005D980 File Offset: 0x0005BB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254215, XrefRangeEnd = 254217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ButtonStateFlags FzhWgnQeRcXBpClnAbkhPUSvcSzG(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_FzhWgnQeRcXBpClnAbkhPUSvcSzG_Internal_Virtual_New_ButtonStateFlags_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0005D9D4 File Offset: 0x0005BBD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254222, RefRangeEnd = 254225, XrefRangeStart = 254217, XrefRangeEnd = 254222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HhjfTuVPdxBkWXmHCIKPGrtaPpU(Controller.Extension A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_HhjfTuVPdxBkWXmHCIKPGrtaPpU_Internal_Void_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0005DA18 File Offset: 0x0005BC18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254229, RefRangeEnd = 254230, XrefRangeStart = 254225, XrefRangeEnd = 254229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RuglyNxbeUVEKWvtsQgguwCgpTY(Controller.Extension A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_RuglyNxbeUVEKWvtsQgguwCgpTY_Internal_Void_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0005DA5C File Offset: 0x0005BC5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254235, RefRangeEnd = 254237, XrefRangeStart = 254230, XrefRangeEnd = 254235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GMFpQqtyJcjzYToWCrZsZQAhPYh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0005DA98 File Offset: 0x0005BC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254237, XrefRangeEnd = 254240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DmSiOupNgsMWUccocIUOZmnzejoJ(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_DmSiOupNgsMWUccocIUOZmnzejoJ_Internal_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0005DAEC File Offset: 0x0005BCEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254255, RefRangeEnd = 254256, XrefRangeStart = 254240, XrefRangeEnd = 254255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void pZoQVaXjWpxKnkHUeJUpyVawiKT(ControllerMap A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_pZoQVaXjWpxKnkHUeJUpyVawiKT_Internal_Virtual_New_Void_ControllerMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0005DB3C File Offset: 0x0005BD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254256, XrefRangeEnd = 254257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RliirvzCZqWXcPEGpRIuiOoLMRg(ControllerMap A_1, ActionElementMap A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_RliirvzCZqWXcPEGpRIuiOoLMRg_Internal_Virtual_New_Void_ControllerMap_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0005DB9C File Offset: 0x0005BD9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254262, RefRangeEnd = 254264, XrefRangeStart = 254257, XrefRangeEnd = 254262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool QtAGTczuKNIRNdPrziddijJqXAd(ActionElementMap A_1, int A_2, out float A_3, out bool A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_QtAGTczuKNIRNdPrziddijJqXAd_Internal_Boolean_ActionElementMap_Int32_byref_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0005DC14 File Offset: 0x0005BE14
		[CallerCount(0)]
		public unsafe bool QtAGTczuKNIRNdPrziddijJqXAd(ActionElementMap A_1, int A_2, bool A_3, out float A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_QtAGTczuKNIRNdPrziddijJqXAd_Internal_Boolean_ActionElementMap_Int32_Boolean_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0005DC8C File Offset: 0x0005BE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254264, XrefRangeEnd = 254267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FtpfwMCKfMCnbBBezixohHaJHAGb(Controller.Element A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Void_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0005DCD0 File Offset: 0x0005BED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254267, XrefRangeEnd = 254271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Guid dpOcYpiEjVqmqIagMFgWQQnyfJmZ()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_dpOcYpiEjVqmqIagMFgWQQnyfJmZ_Internal_Virtual_New_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0005DD18 File Offset: 0x0005BF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254271, XrefRangeEnd = 254275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void zmCSqHjkWDCylUlUderSfqqEXvh(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_zmCSqHjkWDCylUlUderSfqqEXvh_Internal_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0005DD64 File Offset: 0x0005BF64
		[CallerCount(0)]
		public unsafe virtual void Connected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_Connected_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0005DDA0 File Offset: 0x0005BFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254275, XrefRangeEnd = 254276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Disconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.NativeMethodInfoPtr_Disconnected_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0005DDDC File Offset: 0x0005BFDC
		public unsafe static Func<Controller, Guid, bool> implementsTemplateDelegate_Guid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254286, RefRangeEnd = 254287, XrefRangeStart = 254276, XrefRangeEnd = 254286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_implementsTemplateDelegate_Guid_Internal_Static_get_Func_3_Controller_Guid_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Controller, Guid, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0005DE10 File Offset: 0x0005C010
		public unsafe static Func<Controller, Type, bool> implementsTemplateDelegate_Type
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 254297, RefRangeEnd = 254299, XrefRangeStart = 254287, XrefRangeEnd = 254297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_implementsTemplateDelegate_Type_Internal_Static_get_Func_3_Controller_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Controller, Type, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0005DE44 File Offset: 0x0005C044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254299, XrefRangeEnd = 254300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AFpswjVoVDCITVCaHZTSAJiVRZp(Controller A_0, Guid A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_AFpswjVoVDCITVCaHZTSAJiVRZp_Private_Static_Boolean_Controller_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0005DE94 File Offset: 0x0005C094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254300, XrefRangeEnd = 254302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool oBTctCvhzzvdhYSKOUYKrzaDMzV(Controller A_0, Type A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_oBTctCvhzzvdhYSKOUYKrzaDMzV_Private_Static_Boolean_Controller_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00006965 File Offset: 0x00004B65
		public Controller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0005DEE8 File Offset: 0x0005C0E8
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x0000696E File Offset: 0x00004B6E
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0005DF10 File Offset: 0x0005C110
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00006989 File Offset: 0x00004B89
		public unsafe string _tag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__tag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0005DF38 File Offset: 0x0005C138
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x000069A8 File Offset: 0x00004BA8
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0005DF60 File Offset: 0x0005C160
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x000069C7 File Offset: 0x00004BC7
		public unsafe string _hardwareName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__hardwareName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__hardwareName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0005DF88 File Offset: 0x0005C188
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x000069E6 File Offset: 0x00004BE6
		public unsafe ControllerType _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0005DFB0 File Offset: 0x0005C1B0
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x00006A01 File Offset: 0x00004C01
		public unsafe Guid fIcXfqCOzQsnxIOcRigOBZXpXnvF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_fIcXfqCOzQsnxIOcRigOBZXpXnvF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_fIcXfqCOzQsnxIOcRigOBZXpXnvF)) = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0005DFD8 File Offset: 0x0005C1D8
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x00006A1C File Offset: 0x00004C1C
		public unsafe string _hardwareIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__hardwareIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__hardwareIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x0005E000 File Offset: 0x0005C200
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x00006A3B File Offset: 0x00004C3B
		public unsafe bool _isConnected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__isConnected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__isConnected)) = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x0005E028 File Offset: 0x0005C228
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x00006A56 File Offset: 0x00004C56
		public unsafe Controller.Extension sZKOvZaohDAzdPVObwABOvwFgQN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x0005E058 File Offset: 0x0005C258
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x00006A75 File Offset: 0x00004C75
		public unsafe bool kOIBhhDgDUQCZtioVlUwqEtbkMdb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb)) = value;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x0005E080 File Offset: 0x0005C280
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x00006A90 File Offset: 0x00004C90
		public ControllerIdentifier VRXiejtUDZpPQeLVYwMNZjtbFsL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_VRXiejtUDZpPQeLVYwMNZjtbFsL);
				return new ControllerIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_VRXiejtUDZpPQeLVYwMNZjtbFsL), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0005E0B0 File Offset: 0x0005C2B0
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x00006ABE File Offset: 0x00004CBE
		public unsafe int SBmxkshsppDFZPZvftqYxbMuemu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu)) = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x0005E0D8 File Offset: 0x0005C2D8
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x00006AD9 File Offset: 0x00004CD9
		public unsafe int _buttonCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__buttonCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr__buttonCount)) = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x0005E100 File Offset: 0x0005C300
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x00006AF4 File Offset: 0x00004CF4
		public unsafe Il2CppReferenceArray<Controller.Button> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Controller.Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0005E130 File Offset: 0x0005C330
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x00006B13 File Offset: 0x00004D13
		public unsafe ReadOnlyCollection<Controller.Button> buttons_readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_buttons_readOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Controller.Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_buttons_readOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0005E160 File Offset: 0x0005C360
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x00006B32 File Offset: 0x00004D32
		public unsafe IList<Controller.Element> xQkGABJRsmzTPSmeXgqJmJTMBma
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Controller.Element>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x0005E190 File Offset: 0x0005C390
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x00006B51 File Offset: 0x00004D51
		public unsafe ReadOnlyCollection<Controller.Element> FaxDYKiOiLbKbaDgSKQsyfLUaPD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Controller.Element>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x0005E1C0 File Offset: 0x0005C3C0
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x00006B70 File Offset: 0x00004D70
		public unsafe InputSource tamJGhaDrwcqghjueRIJXoQsGYe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe)) = value;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x0005E1E8 File Offset: 0x0005C3E8
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x00006B8B File Offset: 0x00004D8B
		public unsafe ControllerDataUpdater PMXDiYGmcXVVkDcmgDWXjFJkhrb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_PMXDiYGmcXVVkDcmgDWXjFJkhrb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerDataUpdater>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_PMXDiYGmcXVVkDcmgDWXjFJkhrb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x0005E218 File Offset: 0x0005C418
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00006BAA File Offset: 0x00004DAA
		public unsafe HardwareControllerMap_Game iNsxDqPHPTqhYqUYyDyQzTlxlTE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareControllerMap_Game>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0005E248 File Offset: 0x0005C448
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x00006BC9 File Offset: 0x00004DC9
		public unsafe uint euujNstWUJPsDbTKKcaexZORnTO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_euujNstWUJPsDbTKKcaexZORnTO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_euujNstWUJPsDbTKKcaexZORnTO)) = value;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x0005E270 File Offset: 0x0005C470
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00006BE4 File Offset: 0x00004DE4
		public unsafe uint uHgdTRrupCOjmyLWlTbhSSrxNGg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_uHgdTRrupCOjmyLWlTbhSSrxNGg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_uHgdTRrupCOjmyLWlTbhSSrxNGg)) = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x0005E298 File Offset: 0x0005C498
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x00006BFF File Offset: 0x00004DFF
		public unsafe uint zeuBHSTCctkLRaCULEBmvlednWB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_zeuBHSTCctkLRaCULEBmvlednWB);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_zeuBHSTCctkLRaCULEBmvlednWB)) = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x0005E2C0 File Offset: 0x0005C4C0
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x00006C1A File Offset: 0x00004E1A
		public unsafe Action<bool> qqpveziflpDCMqhzVMsvgajLKBW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_qqpveziflpDCMqhzVMsvgajLKBW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_qqpveziflpDCMqhzVMsvgajLKBW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x0005E2F0 File Offset: 0x0005C4F0
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x00006C39 File Offset: 0x00004E39
		public unsafe Il2CppReferenceArray<IControllerTemplate> LtIuQBqpAvXVONgNUhAiNnjilPJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_LtIuQBqpAvXVONgNUhAiNnjilPJ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IControllerTemplate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_LtIuQBqpAvXVONgNUhAiNnjilPJ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x0005E320 File Offset: 0x0005C520
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00006C58 File Offset: 0x00004E58
		public unsafe ReadOnlyCollection<IControllerTemplate> FNUyKIuPARrWKhDiXoKaNJOOEQof
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_FNUyKIuPARrWKhDiXoKaNJOOEQof);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<IControllerTemplate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.NativeFieldInfoPtr_FNUyKIuPARrWKhDiXoKaNJOOEQof), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x0005E350 File Offset: 0x0005C550
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00006C77 File Offset: 0x00004E77
		public unsafe static Func<Controller, Guid, bool> msxgtQqXJSjoKXblriFyJsNhsaPS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Controller.NativeFieldInfoPtr_msxgtQqXJSjoKXblriFyJsNhsaPS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Controller, Guid, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Controller.NativeFieldInfoPtr_msxgtQqXJSjoKXblriFyJsNhsaPS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0005E378 File Offset: 0x0005C578
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00006C89 File Offset: 0x00004E89
		public unsafe static Func<Controller, Type, bool> rWFAQldkUxHoabEdJagoEbvjxEoM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Controller.NativeFieldInfoPtr_rWFAQldkUxHoabEdJagoEbvjxEoM, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Controller, Type, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Controller.NativeFieldInfoPtr_rWFAQldkUxHoabEdJagoEbvjxEoM, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0005E3A0 File Offset: 0x0005C5A0
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x00006C9B File Offset: 0x00004E9B
		public unsafe static Func<Controller, Guid, bool> fLFpHVQnsuobZbdJnHTVVQDxIDpa
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Controller.NativeFieldInfoPtr_fLFpHVQnsuobZbdJnHTVVQDxIDpa, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Controller, Guid, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Controller.NativeFieldInfoPtr_fLFpHVQnsuobZbdJnHTVVQDxIDpa, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x0005E3C8 File Offset: 0x0005C5C8
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x00006CAD File Offset: 0x00004EAD
		public unsafe static Func<Controller, Type, bool> gCuUadDmcMFLNzQinFNSXhAQJry
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Controller.NativeFieldInfoPtr_gCuUadDmcMFLNzQinFNSXhAQJry, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Controller, Type, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Controller.NativeFieldInfoPtr_gCuUadDmcMFLNzQinFNSXhAQJry, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeFieldInfoPtr__tag;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeFieldInfoPtr__hardwareName;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeFieldInfoPtr_fIcXfqCOzQsnxIOcRigOBZXpXnvF;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeFieldInfoPtr__hardwareIdentifier;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeFieldInfoPtr__isConnected;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_VRXiejtUDZpPQeLVYwMNZjtbFsL;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr__buttonCount;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeFieldInfoPtr_buttons_readOnly;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr_PMXDiYGmcXVVkDcmgDWXjFJkhrb;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr_euujNstWUJPsDbTKKcaexZORnTO;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr_uHgdTRrupCOjmyLWlTbhSSrxNGg;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeFieldInfoPtr_zeuBHSTCctkLRaCULEBmvlednWB;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeFieldInfoPtr_qqpveziflpDCMqhzVMsvgajLKBW;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeFieldInfoPtr_LtIuQBqpAvXVONgNUhAiNnjilPJ;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeFieldInfoPtr_FNUyKIuPARrWKhDiXoKaNJOOEQof;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeFieldInfoPtr_msxgtQqXJSjoKXblriFyJsNhsaPS;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeFieldInfoPtr_rWFAQldkUxHoabEdJagoEbvjxEoM;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeFieldInfoPtr_fLFpHVQnsuobZbdJnHTVVQDxIDpa;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeFieldInfoPtr_gCuUadDmcMFLNzQinFNSXhAQJry;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_get_wasPollingPrev_Internal_get_Boolean_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Internal_set_Void_String_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareName_Public_get_String_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_ControllerType_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_get_identifier_Public_get_ControllerIdentifier_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_set_isConnected_Internal_set_Void_Boolean_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_get_mapTypeString_Public_get_String_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_get_elementCount_Public_get_Int32_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonCount_Public_get_Int32_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_get_Elements_Public_get_IList_1_Element_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_get_Buttons_Public_get_IList_1_Button_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_get_extension_Public_get_Extension_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementIdentifiers_Public_get_IList_1_ControllerElementIdentifier_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_get_ButtonElementIdentifiers_Public_get_IList_1_ControllerElementIdentifier_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_add_EnabledStateChangedEvent_Internal_add_Void_Action_1_Boolean_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Internal_rem_Void_Action_1_Boolean_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_InputSource_String_String_String_ControllerType_Guid_Int32_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_HardwareButtonInfo_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_VBMAdMfUBOwERgwdflafhltpBVWY_Internal_Virtual_New_Void_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_GetElementById_Public_Virtual_New_Element_Int32_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonIndexById_Public_Int32_Int32_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierById_Public_ControllerElementIdentifier_Int32_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonChanged_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonPrev_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Virtual_New_Boolean_Int32_Single_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Virtual_New_Boolean_Int32_Single_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTimePressed_Public_Virtual_New_Double_Int32_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTimeUnpressed_Public_Virtual_New_Double_Int32_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonLastTimePressed_Public_Virtual_New_Double_Int32_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonLastTimeUnpressed_Public_Virtual_New_Double_Int32_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyButton_Public_Virtual_New_Boolean_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyButtonDown_Public_Virtual_New_Boolean_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyButtonUp_Public_Virtual_New_Boolean_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyButtonPrev_Public_Virtual_New_Boolean_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyButtonChanged_Public_Virtual_New_Boolean_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonById_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDownById_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUpById_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressHoldById_Public_Virtual_New_Boolean_Int32_Single_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressDownById_Public_Virtual_New_Boolean_Int32_Single_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressHoldById_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressDownById_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonPrevById_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTimePressedById_Public_Virtual_New_Double_Int32_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTimeUnpressedById_Public_Virtual_New_Double_Int32_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonLastTimePressedById_Public_Virtual_New_Double_Int32_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonLastTimeUnpressedById_Public_Virtual_New_Double_Int32_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_PollForFirstElement_Public_Virtual_New_ControllerPollingInfo_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_PollForFirstElementDown_Public_Virtual_New_ControllerPollingInfo_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_PollForFirstButton_Public_Virtual_New_ControllerPollingInfo_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_PollForFirstButtonDown_Public_Virtual_New_ControllerPollingInfo_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_PollForAllElements_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_PollForAllElementsDown_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_PollForAllButtons_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_PollForAllButtonsDown_Public_Virtual_New_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_ezcxwwMBAShkckFadwqucsvGOGqn_Private_Boolean_Int32_byref_Int32_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr_cZnZBUDXfBEWnivhVcCnlQCBqpS_Private_Boolean_Int32_byref_Int32_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePollingFrameTracking_Protected_Void_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_New_Double_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_New_Double_Boolean_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_New_Double_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_New_Double_Boolean_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeAnyButtonPressed_Public_Double_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeAnyButtonChanged_Public_Double_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_GetExtension_Public_T_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_get_Templates_Public_get_IList_1_IControllerTemplate_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_get_templateCount_Public_get_Int32_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_GetTemplate_Public_IControllerTemplate_Guid_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_GetTemplate_Public_IControllerTemplate_Type_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_GetTemplate_Public_T_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_ImplementsTemplate_Public_Boolean_Guid_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_ImplementsTemplate_Public_Boolean_Type_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_ImplementsTemplate_Public_Boolean_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_WgmUOrDLGlmvZYpcMBtxBtqkohh_Internal_Void_Il2CppReferenceArray_1_IControllerTemplate_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_New_Void_UpdateLoopType_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_FzhWgnQeRcXBpClnAbkhPUSvcSzG_Internal_Virtual_New_ButtonStateFlags_Int32_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_HhjfTuVPdxBkWXmHCIKPGrtaPpU_Internal_Void_Extension_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_RuglyNxbeUVEKWvtsQgguwCgpTY_Internal_Void_Extension_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_New_Void_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_DmSiOupNgsMWUccocIUOZmnzejoJ_Internal_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_pZoQVaXjWpxKnkHUeJUpyVawiKT_Internal_Virtual_New_Void_ControllerMap_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_RliirvzCZqWXcPEGpRIuiOoLMRg_Internal_Virtual_New_Void_ControllerMap_ActionElementMap_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_QtAGTczuKNIRNdPrziddijJqXAd_Internal_Boolean_ActionElementMap_Int32_byref_Single_byref_Boolean_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_QtAGTczuKNIRNdPrziddijJqXAd_Internal_Boolean_ActionElementMap_Int32_Boolean_byref_Single_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Void_Element_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_dpOcYpiEjVqmqIagMFgWQQnyfJmZ_Internal_Virtual_New_Guid_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_zmCSqHjkWDCylUlUderSfqqEXvh_Internal_Virtual_New_Void_Boolean_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_Connected_Protected_Virtual_New_Void_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_Disconnected_Protected_Virtual_New_Void_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_get_implementsTemplateDelegate_Guid_Internal_Static_get_Func_3_Controller_Guid_Boolean_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_get_implementsTemplateDelegate_Type_Internal_Static_get_Func_3_Controller_Type_Boolean_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_AFpswjVoVDCITVCaHZTSAJiVRZp_Private_Static_Boolean_Controller_Guid_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_oBTctCvhzzvdhYSKOUYKrzaDMzV_Private_Static_Boolean_Controller_Type_0;

		// Token: 0x02000276 RID: 630
		public class Element : global::Il2CppSystem.Object
		{
			// Token: 0x060039AC RID: 14764 RVA: 0x0011803C File Offset: 0x0011623C
			// Note: this type is marked as 'beforefieldinit'.
			static Element()
			{
				Il2CppClassPointerStore<Controller.Element>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller>.NativeClassPtr, "Element");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr);
				Controller.Element.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, "id");
				Controller.Element.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, "name");
				Controller.Element.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, "type");
				Controller.Element.NativeFieldInfoPtr_aKnFhlrAeutGastyVpQLwzZITJF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, "aKnFhlrAeutGastyVpQLwzZITJF");
				Controller.Element.NativeFieldInfoPtr_RiwpMzSknBARsCWXiVluhzXWZsW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, "RiwpMzSknBARsCWXiVluhzXWZsW");
				Controller.Element.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, "egOPTGwnsPnUJWHsXfaRAFkRlvOu");
				Controller.Element.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, "SBmxkshsppDFZPZvftqYxbMuemu");
				Controller.Element.NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, 100665229);
				Controller.Element.NativeMethodInfoPtr_get_isMemberElement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, 100665230);
				Controller.Element.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, 100665231);
				Controller.Element.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, 100665232);
				Controller.Element.NativeMethodInfoPtr_gVXcAPUthjZOukPQJfrWbaZmFfS_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, 100665233);
				Controller.Element.NativeMethodInfoPtr_HktvIQUDGRvlbtgLYgsTUIGKbKZ_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, 100665234);
			}

			// Token: 0x17001134 RID: 4404
			// (get) Token: 0x060039AD RID: 14765 RVA: 0x0011816C File Offset: 0x0011636C
			public unsafe ControllerElementIdentifier elementIdentifier
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 252189, RefRangeEnd = 252192, XrefRangeStart = 252181, XrefRangeEnd = 252189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Element.NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
				}
			}

			// Token: 0x17001135 RID: 4405
			// (get) Token: 0x060039AE RID: 14766 RVA: 0x001181AC File Offset: 0x001163AC
			public unsafe bool isMemberElement
			{
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 252196, RefRangeEnd = 252205, XrefRangeStart = 252192, XrefRangeEnd = 252196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Element.NativeMethodInfoPtr_get_isMemberElement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060039AF RID: 14767 RVA: 0x001181E8 File Offset: 0x001163E8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 252209, RefRangeEnd = 252213, XrefRangeStart = 252205, XrefRangeEnd = 252209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Element(Controller controller, int elementIdentifierId, string name, ControllerElementType type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Element.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039B0 RID: 14768 RVA: 0x00118264 File Offset: 0x00116464
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 252217, RefRangeEnd = 252219, XrefRangeStart = 252213, XrefRangeEnd = 252217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Element.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039B1 RID: 14769 RVA: 0x00118298 File Offset: 0x00116498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252219, XrefRangeEnd = 252222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void gVXcAPUthjZOukPQJfrWbaZmFfS()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Element.NativeMethodInfoPtr_gVXcAPUthjZOukPQJfrWbaZmFfS_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039B2 RID: 14770 RVA: 0x001182CC File Offset: 0x001164CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252222, XrefRangeEnd = 252223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void HktvIQUDGRvlbtgLYgsTUIGKbKZ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Element.NativeMethodInfoPtr_HktvIQUDGRvlbtgLYgsTUIGKbKZ_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039B3 RID: 14771 RVA: 0x00014641 File Offset: 0x00012841
			public Element(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700112D RID: 4397
			// (get) Token: 0x060039B4 RID: 14772 RVA: 0x00118300 File Offset: 0x00116500
			// (set) Token: 0x060039B5 RID: 14773 RVA: 0x0001464A File Offset: 0x0001284A
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x1700112E RID: 4398
			// (get) Token: 0x060039B6 RID: 14774 RVA: 0x00118328 File Offset: 0x00116528
			// (set) Token: 0x060039B7 RID: 14775 RVA: 0x00014665 File Offset: 0x00012865
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700112F RID: 4399
			// (get) Token: 0x060039B8 RID: 14776 RVA: 0x00118350 File Offset: 0x00116550
			// (set) Token: 0x060039B9 RID: 14777 RVA: 0x00014684 File Offset: 0x00012884
			public unsafe ControllerElementType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x17001130 RID: 4400
			// (get) Token: 0x060039BA RID: 14778 RVA: 0x00118378 File Offset: 0x00116578
			// (set) Token: 0x060039BB RID: 14779 RVA: 0x0001469F File Offset: 0x0001289F
			public unsafe Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ aKnFhlrAeutGastyVpQLwzZITJF
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_aKnFhlrAeutGastyVpQLwzZITJF);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_aKnFhlrAeutGastyVpQLwzZITJF), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001131 RID: 4401
			// (get) Token: 0x060039BC RID: 14780 RVA: 0x001183A8 File Offset: 0x001165A8
			// (set) Token: 0x060039BD RID: 14781 RVA: 0x000146BE File Offset: 0x000128BE
			public unsafe int RiwpMzSknBARsCWXiVluhzXWZsW
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_RiwpMzSknBARsCWXiVluhzXWZsW);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_RiwpMzSknBARsCWXiVluhzXWZsW)) = value;
				}
			}

			// Token: 0x17001132 RID: 4402
			// (get) Token: 0x060039BE RID: 14782 RVA: 0x001183D0 File Offset: 0x001165D0
			// (set) Token: 0x060039BF RID: 14783 RVA: 0x000146D9 File Offset: 0x000128D9
			public unsafe Controller egOPTGwnsPnUJWHsXfaRAFkRlvOu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001133 RID: 4403
			// (get) Token: 0x060039C0 RID: 14784 RVA: 0x00118400 File Offset: 0x00116600
			// (set) Token: 0x060039C1 RID: 14785 RVA: 0x000146F8 File Offset: 0x000128F8
			public unsafe int SBmxkshsppDFZPZvftqYxbMuemu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu)) = value;
				}
			}

			// Token: 0x04003097 RID: 12439
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04003098 RID: 12440
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04003099 RID: 12441
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400309A RID: 12442
			private static readonly IntPtr NativeFieldInfoPtr_aKnFhlrAeutGastyVpQLwzZITJF;

			// Token: 0x0400309B RID: 12443
			private static readonly IntPtr NativeFieldInfoPtr_RiwpMzSknBARsCWXiVluhzXWZsW;

			// Token: 0x0400309C RID: 12444
			private static readonly IntPtr NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu;

			// Token: 0x0400309D RID: 12445
			private static readonly IntPtr NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu;

			// Token: 0x0400309E RID: 12446
			private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0;

			// Token: 0x0400309F RID: 12447
			private static readonly IntPtr NativeMethodInfoPtr_get_isMemberElement_Public_get_Boolean_0;

			// Token: 0x040030A0 RID: 12448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_ControllerElementType_0;

			// Token: 0x040030A1 RID: 12449
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

			// Token: 0x040030A2 RID: 12450
			private static readonly IntPtr NativeMethodInfoPtr_gVXcAPUthjZOukPQJfrWbaZmFfS_Internal_Void_0;

			// Token: 0x040030A3 RID: 12451
			private static readonly IntPtr NativeMethodInfoPtr_HktvIQUDGRvlbtgLYgsTUIGKbKZ_Internal_Void_0;

			// Token: 0x020004C4 RID: 1220
			public class VCFdbkuSuhBPXbbRzRdjSBdnqUJ : global::Il2CppSystem.Object
			{
				// Token: 0x0600527E RID: 21118 RVA: 0x00176168 File Offset: 0x00174368
				// Note: this type is marked as 'beforefieldinit'.
				static VCFdbkuSuhBPXbbRzRdjSBdnqUJ()
				{
					Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller.Element>.NativeClassPtr, "VCFdbkuSuhBPXbbRzRdjSBdnqUJ");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr);
					Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_dbbSwkArnKBFftKDiGfmukfGPWR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, "dbbSwkArnKBFftKDiGfmukfGPWR");
					Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_jtZTOBUiTDkSIlXnntPwHKTcYMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, "jtZTOBUiTDkSIlXnntPwHKTcYMp");
					Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_FdnRvmaTOwBrRhxTobULlZTUAPv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, "FdnRvmaTOwBrRhxTobULlZTUAPv");
					Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, "EDWjCkozGqmyQyquicPQVDMTCVq");
					Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, "czPgrBYcuMpJrlqXpuRJAvvkFiI");
					Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_wkOliZmFNdcmVbcKCVrLJZyhQJc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, "wkOliZmFNdcmVbcKCVrLJZyhQJc");
					Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_ncgiEQQMzUzFFvMYBwcAVSwMZCy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, "ncgiEQQMzUzFFvMYBwcAVSwMZCy");
					Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeMethodInfoPtr_get_Data_Public_get_IList_1_rHjtRNYnIdipfucnHOXblPwzKMj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, 100665235);
					Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeMethodInfoPtr_set_updateLoop_Public_set_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, 100665236);
					Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, 100665237);
					Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, 100665238);
				}

				// Token: 0x17001953 RID: 6483
				// (get) Token: 0x0600527F RID: 21119 RVA: 0x00176270 File Offset: 0x00174470
				public unsafe IList<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj> ZtOdywxtFRGJngOPanEWgvMGjHdC
				{
					[CallerCount(5)]
					[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeMethodInfoPtr_get_Data_Public_get_IList_1_rHjtRNYnIdipfucnHOXblPwzKMj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj>>(intPtr3) : null;
					}
				}

				// Token: 0x17001954 RID: 6484
				// (set) Token: 0x06005280 RID: 21120 RVA: 0x001762B0 File Offset: 0x001744B0
				public unsafe UpdateLoopType HmLJOEaFHWwVymwfHWYgZGnwyFG
				{
					[CallerCount(4)]
					[CachedScanResults(RefRangeStart = 252153, RefRangeEnd = 252157, XrefRangeStart = 252153, XrefRangeEnd = 252153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref value;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeMethodInfoPtr_set_updateLoop_Public_set_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x06005281 RID: 21121 RVA: 0x001762F0 File Offset: 0x001744F0
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252179, RefRangeEnd = 252181, XrefRangeStart = 252157, XrefRangeEnd = 252179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe VCFdbkuSuhBPXbbRzRdjSBdnqUJ(UpdateLoopSetting updateLoopSetting)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref updateLoopSetting;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06005282 RID: 21122 RVA: 0x00176338 File Offset: 0x00174538
				[CallerCount(0)]
				public unsafe void vsfKIEzLYgmvYXdfRKJgdqwirYk()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005283 RID: 21123 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
				public VCFdbkuSuhBPXbbRzRdjSBdnqUJ(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700194C RID: 6476
				// (get) Token: 0x06005284 RID: 21124 RVA: 0x0017636C File Offset: 0x0017456C
				// (set) Token: 0x06005285 RID: 21125 RVA: 0x0001DCA9 File Offset: 0x0001BEA9
				public unsafe int dbbSwkArnKBFftKDiGfmukfGPWR
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_dbbSwkArnKBFftKDiGfmukfGPWR);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_dbbSwkArnKBFftKDiGfmukfGPWR)) = value;
					}
				}

				// Token: 0x1700194D RID: 6477
				// (get) Token: 0x06005286 RID: 21126 RVA: 0x00176394 File Offset: 0x00174594
				// (set) Token: 0x06005287 RID: 21127 RVA: 0x0001DCC4 File Offset: 0x0001BEC4
				public unsafe Il2CppStructArray<int> jtZTOBUiTDkSIlXnntPwHKTcYMp
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_jtZTOBUiTDkSIlXnntPwHKTcYMp);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_jtZTOBUiTDkSIlXnntPwHKTcYMp), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700194E RID: 6478
				// (get) Token: 0x06005288 RID: 21128 RVA: 0x001763C4 File Offset: 0x001745C4
				// (set) Token: 0x06005289 RID: 21129 RVA: 0x0001DCE3 File Offset: 0x0001BEE3
				public unsafe Il2CppReferenceArray<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj> FdnRvmaTOwBrRhxTobULlZTUAPv
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_FdnRvmaTOwBrRhxTobULlZTUAPv);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_FdnRvmaTOwBrRhxTobULlZTUAPv), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700194F RID: 6479
				// (get) Token: 0x0600528A RID: 21130 RVA: 0x001763F4 File Offset: 0x001745F4
				// (set) Token: 0x0600528B RID: 21131 RVA: 0x0001DD02 File Offset: 0x0001BF02
				public unsafe Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj EDWjCkozGqmyQyquicPQVDMTCVq
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001950 RID: 6480
				// (get) Token: 0x0600528C RID: 21132 RVA: 0x00176424 File Offset: 0x00174624
				// (set) Token: 0x0600528D RID: 21133 RVA: 0x0001DD21 File Offset: 0x0001BF21
				public unsafe int czPgrBYcuMpJrlqXpuRJAvvkFiI
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI)) = value;
					}
				}

				// Token: 0x17001951 RID: 6481
				// (get) Token: 0x0600528E RID: 21134 RVA: 0x0017644C File Offset: 0x0017464C
				// (set) Token: 0x0600528F RID: 21135 RVA: 0x0001DD3C File Offset: 0x0001BF3C
				public unsafe int wkOliZmFNdcmVbcKCVrLJZyhQJc
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_wkOliZmFNdcmVbcKCVrLJZyhQJc);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_wkOliZmFNdcmVbcKCVrLJZyhQJc)) = value;
					}
				}

				// Token: 0x17001952 RID: 6482
				// (get) Token: 0x06005290 RID: 21136 RVA: 0x00176474 File Offset: 0x00174674
				// (set) Token: 0x06005291 RID: 21137 RVA: 0x0001DD57 File Offset: 0x0001BF57
				public unsafe ReadOnlyCollection<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj> ncgiEQQMzUzFFvMYBwcAVSwMZCy
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_ncgiEQQMzUzFFvMYBwcAVSwMZCy);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.NativeFieldInfoPtr_ncgiEQQMzUzFFvMYBwcAVSwMZCy), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400452D RID: 17709
				private static readonly IntPtr NativeFieldInfoPtr_dbbSwkArnKBFftKDiGfmukfGPWR;

				// Token: 0x0400452E RID: 17710
				private static readonly IntPtr NativeFieldInfoPtr_jtZTOBUiTDkSIlXnntPwHKTcYMp;

				// Token: 0x0400452F RID: 17711
				private static readonly IntPtr NativeFieldInfoPtr_FdnRvmaTOwBrRhxTobULlZTUAPv;

				// Token: 0x04004530 RID: 17712
				private static readonly IntPtr NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq;

				// Token: 0x04004531 RID: 17713
				private static readonly IntPtr NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI;

				// Token: 0x04004532 RID: 17714
				private static readonly IntPtr NativeFieldInfoPtr_wkOliZmFNdcmVbcKCVrLJZyhQJc;

				// Token: 0x04004533 RID: 17715
				private static readonly IntPtr NativeFieldInfoPtr_ncgiEQQMzUzFFvMYBwcAVSwMZCy;

				// Token: 0x04004534 RID: 17716
				private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_IList_1_rHjtRNYnIdipfucnHOXblPwzKMj_0;

				// Token: 0x04004535 RID: 17717
				private static readonly IntPtr NativeMethodInfoPtr_set_updateLoop_Public_set_Void_UpdateLoopType_0;

				// Token: 0x04004536 RID: 17718
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0;

				// Token: 0x04004537 RID: 17719
				private static readonly IntPtr NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Void_0;

				// Token: 0x020005B1 RID: 1457
				public class rHjtRNYnIdipfucnHOXblPwzKMj : global::Il2CppSystem.Object
				{
					// Token: 0x06006111 RID: 24849 RVA: 0x001AF930 File Offset: 0x001ADB30
					// Note: this type is marked as 'beforefieldinit'.
					static rHjtRNYnIdipfucnHOXblPwzKMj()
					{
						Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ>.NativeClassPtr, "rHjtRNYnIdipfucnHOXblPwzKMj");
						IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj>.NativeClassPtr);
						Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj>.NativeClassPtr, 100665239);
						Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj>.NativeClassPtr, 100665240);
					}

					// Token: 0x06006112 RID: 24850 RVA: 0x001AF984 File Offset: 0x001ADB84
					[CallerCount(0)]
					public unsafe virtual void vsfKIEzLYgmvYXdfRKJgdqwirYk()
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}

					// Token: 0x06006113 RID: 24851 RVA: 0x001AF9C0 File Offset: 0x001ADBC0
					[CallerCount(7)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe rHjtRNYnIdipfucnHOXblPwzKMj()
						: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj>.NativeClassPtr))
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}

					// Token: 0x06006114 RID: 24852 RVA: 0x00023D72 File Offset: 0x00021F72
					public rHjtRNYnIdipfucnHOXblPwzKMj(IntPtr pointer)
						: base(pointer)
					{
					}

					// Token: 0x04004F95 RID: 20373
					private static readonly IntPtr NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Abstract_Virtual_New_Void_0;

					// Token: 0x04004F96 RID: 20374
					private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
				}
			}
		}

		// Token: 0x02000277 RID: 631
		public sealed class Axis : Controller.Element
		{
			// Token: 0x060039C2 RID: 14786 RVA: 0x00118428 File Offset: 0x00116628
			// Note: this type is marked as 'beforefieldinit'.
			static Axis()
			{
				Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller>.NativeClassPtr, "Axis");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr);
				Controller.Axis.NativeFieldInfoPtr_fDIHCXxKWzIBcWjRyUjPuXoIgcA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, "fDIHCXxKWzIBcWjRyUjPuXoIgcA");
				Controller.Axis.NativeFieldInfoPtr_OgYRCieCJefyrdQarbNtAvtWEWi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, "OgYRCieCJefyrdQarbNtAvtWEWi");
				Controller.Axis.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665241);
				Controller.Axis.NativeMethodInfoPtr_get_valuePrev_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665242);
				Controller.Axis.NativeMethodInfoPtr_get_valueRaw_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665243);
				Controller.Axis.NativeMethodInfoPtr_set_valueRaw_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665244);
				Controller.Axis.NativeMethodInfoPtr_get_valueRawPrev_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665245);
				Controller.Axis.NativeMethodInfoPtr_get_valueDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665246);
				Controller.Axis.NativeMethodInfoPtr_get_valueDeltaRaw_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665247);
				Controller.Axis.NativeMethodInfoPtr_get_lastTimeActive_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665248);
				Controller.Axis.NativeMethodInfoPtr_get_lastTimeActiveRaw_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665249);
				Controller.Axis.NativeMethodInfoPtr_get_lastTimeInactive_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665250);
				Controller.Axis.NativeMethodInfoPtr_get_lastTimeInactiveRaw_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665251);
				Controller.Axis.NativeMethodInfoPtr_get_lastTimeValueChanged_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665252);
				Controller.Axis.NativeMethodInfoPtr_get_lastTimeValueChangedRaw_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665253);
				Controller.Axis.NativeMethodInfoPtr_get_timeActive_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665254);
				Controller.Axis.NativeMethodInfoPtr_get_timeActiveRaw_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665255);
				Controller.Axis.NativeMethodInfoPtr_get_timeInactive_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665256);
				Controller.Axis.NativeMethodInfoPtr_get_timeInactiveRaw_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665257);
				Controller.Axis.NativeMethodInfoPtr_get_pollingDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665258);
				Controller.Axis.NativeMethodInfoPtr_set_pollingDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665259);
				Controller.Axis.NativeMethodInfoPtr_get_selfValue_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665260);
				Controller.Axis.NativeMethodInfoPtr_get_selfValuePrev_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665261);
				Controller.Axis.NativeMethodInfoPtr_zdjbCtxxcNeSINWdALGZOqnWWan_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665262);
				Controller.Axis.NativeMethodInfoPtr_get_effectivePollingDeadZone_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665263);
				Controller.Axis.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_AxisRange_HardwareAxisInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665264);
				Controller.Axis.NativeMethodInfoPtr_OUcvkyJdgsDqccHXTzfRFTxSgUWv_Internal_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665265);
				Controller.Axis.NativeMethodInfoPtr_noHaMSFFgNmzSdsIpqSbNAxZzgP_Internal_Void_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665266);
				Controller.Axis.NativeMethodInfoPtr_noHaMSFFgNmzSdsIpqSbNAxZzgP_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665267);
				Controller.Axis.NativeMethodInfoPtr_ACWslvTmrJUvUdQHwjBngSRrHBwZ_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665268);
				Controller.Axis.NativeMethodInfoPtr_SPuLXGnIgfzfStgTpoQuDdeEgbv_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665269);
				Controller.Axis.NativeMethodInfoPtr_iQIkOXadIqbSxfYACywghOyFKcxa_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665270);
				Controller.Axis.NativeMethodInfoPtr_tVkuhWGJxXAqJqCGQqPuqHUgFKP_Internal_Single_UpdateLoopType_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, 100665271);
			}

			// Token: 0x17001138 RID: 4408
			// (get) Token: 0x060039C3 RID: 14787 RVA: 0x001186E8 File Offset: 0x001168E8
			public unsafe float value
			{
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 252267, RefRangeEnd = 252276, XrefRangeStart = 252260, XrefRangeEnd = 252267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001139 RID: 4409
			// (get) Token: 0x060039C4 RID: 14788 RVA: 0x00118724 File Offset: 0x00116924
			public unsafe float valuePrev
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 252283, RefRangeEnd = 252289, XrefRangeStart = 252276, XrefRangeEnd = 252283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_valuePrev_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700113A RID: 4410
			// (get) Token: 0x060039C5 RID: 14789 RVA: 0x00118760 File Offset: 0x00116960
			// (set) Token: 0x060039C6 RID: 14790 RVA: 0x0011879C File Offset: 0x0011699C
			public unsafe float valueRaw
			{
				[CallerCount(21)]
				[CachedScanResults(RefRangeStart = 252295, RefRangeEnd = 252316, XrefRangeStart = 252289, XrefRangeEnd = 252295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_valueRaw_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252318, RefRangeEnd = 252320, XrefRangeStart = 252316, XrefRangeEnd = 252318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_set_valueRaw_Internal_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700113B RID: 4411
			// (get) Token: 0x060039C7 RID: 14791 RVA: 0x001187DC File Offset: 0x001169DC
			public unsafe float valueRawPrev
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 252326, RefRangeEnd = 252338, XrefRangeStart = 252320, XrefRangeEnd = 252326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_valueRawPrev_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700113C RID: 4412
			// (get) Token: 0x060039C8 RID: 14792 RVA: 0x00118818 File Offset: 0x00116A18
			public unsafe float valueDelta
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 252344, RefRangeEnd = 252345, XrefRangeStart = 252338, XrefRangeEnd = 252344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_valueDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700113D RID: 4413
			// (get) Token: 0x060039C9 RID: 14793 RVA: 0x00118854 File Offset: 0x00116A54
			public unsafe float valueDeltaRaw
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 252351, RefRangeEnd = 252352, XrefRangeStart = 252345, XrefRangeEnd = 252351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_valueDeltaRaw_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700113E RID: 4414
			// (get) Token: 0x060039CA RID: 14794 RVA: 0x00118890 File Offset: 0x00116A90
			public unsafe double lastTimeActive
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 252358, RefRangeEnd = 252361, XrefRangeStart = 252352, XrefRangeEnd = 252358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_lastTimeActive_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700113F RID: 4415
			// (get) Token: 0x060039CB RID: 14795 RVA: 0x001188CC File Offset: 0x00116ACC
			public unsafe double lastTimeActiveRaw
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 252367, RefRangeEnd = 252370, XrefRangeStart = 252361, XrefRangeEnd = 252367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_lastTimeActiveRaw_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001140 RID: 4416
			// (get) Token: 0x060039CC RID: 14796 RVA: 0x00118908 File Offset: 0x00116B08
			public unsafe double lastTimeInactive
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252376, RefRangeEnd = 252378, XrefRangeStart = 252370, XrefRangeEnd = 252376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_lastTimeInactive_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001141 RID: 4417
			// (get) Token: 0x060039CD RID: 14797 RVA: 0x00118944 File Offset: 0x00116B44
			public unsafe double lastTimeInactiveRaw
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252384, RefRangeEnd = 252386, XrefRangeStart = 252378, XrefRangeEnd = 252384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_lastTimeInactiveRaw_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001142 RID: 4418
			// (get) Token: 0x060039CE RID: 14798 RVA: 0x00118980 File Offset: 0x00116B80
			public unsafe double lastTimeValueChanged
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 252392, RefRangeEnd = 252393, XrefRangeStart = 252386, XrefRangeEnd = 252392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_lastTimeValueChanged_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001143 RID: 4419
			// (get) Token: 0x060039CF RID: 14799 RVA: 0x001189BC File Offset: 0x00116BBC
			public unsafe double lastTimeValueChangedRaw
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 252399, RefRangeEnd = 252400, XrefRangeStart = 252393, XrefRangeEnd = 252399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_lastTimeValueChangedRaw_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001144 RID: 4420
			// (get) Token: 0x060039D0 RID: 14800 RVA: 0x001189F8 File Offset: 0x00116BF8
			public unsafe double timeActive
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252409, RefRangeEnd = 252411, XrefRangeStart = 252400, XrefRangeEnd = 252409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_timeActive_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001145 RID: 4421
			// (get) Token: 0x060039D1 RID: 14801 RVA: 0x00118A34 File Offset: 0x00116C34
			public unsafe double timeActiveRaw
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252420, RefRangeEnd = 252422, XrefRangeStart = 252411, XrefRangeEnd = 252420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_timeActiveRaw_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001146 RID: 4422
			// (get) Token: 0x060039D2 RID: 14802 RVA: 0x00118A70 File Offset: 0x00116C70
			public unsafe double timeInactive
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252432, RefRangeEnd = 252434, XrefRangeStart = 252422, XrefRangeEnd = 252432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_timeInactive_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001147 RID: 4423
			// (get) Token: 0x060039D3 RID: 14803 RVA: 0x00118AAC File Offset: 0x00116CAC
			public unsafe double timeInactiveRaw
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252444, RefRangeEnd = 252446, XrefRangeStart = 252434, XrefRangeEnd = 252444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_timeInactiveRaw_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001148 RID: 4424
			// (get) Token: 0x060039D4 RID: 14804 RVA: 0x00118AE8 File Offset: 0x00116CE8
			// (set) Token: 0x060039D5 RID: 14805 RVA: 0x00118B24 File Offset: 0x00116D24
			public unsafe float pollingDeadZone
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252446, XrefRangeEnd = 252450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_pollingDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252450, XrefRangeEnd = 252454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_set_pollingDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001149 RID: 4425
			// (get) Token: 0x060039D6 RID: 14806 RVA: 0x00118B64 File Offset: 0x00116D64
			public unsafe float selfValue
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252454, XrefRangeEnd = 252456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_selfValue_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700114A RID: 4426
			// (get) Token: 0x060039D7 RID: 14807 RVA: 0x00118BA0 File Offset: 0x00116DA0
			public unsafe float selfValuePrev
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252456, XrefRangeEnd = 252458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_selfValuePrev_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060039D8 RID: 14808 RVA: 0x00118BDC File Offset: 0x00116DDC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 252460, RefRangeEnd = 252462, XrefRangeStart = 252458, XrefRangeEnd = 252460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void zdjbCtxxcNeSINWdALGZOqnWWan(float A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_zdjbCtxxcNeSINWdALGZOqnWWan_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700114B RID: 4427
			// (get) Token: 0x060039D9 RID: 14809 RVA: 0x00118C1C File Offset: 0x00116E1C
			public unsafe float effectivePollingDeadZone
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252470, RefRangeEnd = 252472, XrefRangeStart = 252462, XrefRangeEnd = 252470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_get_effectivePollingDeadZone_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060039DA RID: 14810 RVA: 0x00118C58 File Offset: 0x00116E58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252472, XrefRangeEnd = 252481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Axis(Controller controller, int elementIdentifierId, string name, AxisRange axisRange, HardwareAxisInfo axisInfo)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_AxisRange_HardwareAxisInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039DB RID: 14811 RVA: 0x00118CE4 File Offset: 0x00116EE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252481, XrefRangeEnd = 252482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OUcvkyJdgsDqccHXTzfRFTxSgUWv(UpdateLoopType A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_OUcvkyJdgsDqccHXTzfRFTxSgUWv_Internal_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039DC RID: 14812 RVA: 0x00118D24 File Offset: 0x00116F24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252485, RefRangeEnd = 252486, XrefRangeStart = 252482, XrefRangeEnd = 252485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void noHaMSFFgNmzSdsIpqSbNAxZzgP(AxisCalibration A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_noHaMSFFgNmzSdsIpqSbNAxZzgP_Internal_Void_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039DD RID: 14813 RVA: 0x00118D68 File Offset: 0x00116F68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252488, RefRangeEnd = 252489, XrefRangeStart = 252486, XrefRangeEnd = 252488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void noHaMSFFgNmzSdsIpqSbNAxZzgP()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_noHaMSFFgNmzSdsIpqSbNAxZzgP_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039DE RID: 14814 RVA: 0x00118D9C File Offset: 0x00116F9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252491, RefRangeEnd = 252492, XrefRangeStart = 252489, XrefRangeEnd = 252491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ACWslvTmrJUvUdQHwjBngSRrHBwZ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_ACWslvTmrJUvUdQHwjBngSRrHBwZ_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039DF RID: 14815 RVA: 0x00118DD0 File Offset: 0x00116FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252492, XrefRangeEnd = 252499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SPuLXGnIgfzfStgTpoQuDdeEgbv()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_SPuLXGnIgfzfStgTpoQuDdeEgbv_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039E0 RID: 14816 RVA: 0x00118E04 File Offset: 0x00117004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252499, XrefRangeEnd = 252512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void iQIkOXadIqbSxfYACywghOyFKcxa(float A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_iQIkOXadIqbSxfYACywghOyFKcxa_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039E1 RID: 14817 RVA: 0x00118E44 File Offset: 0x00117044
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 252517, RefRangeEnd = 252519, XrefRangeStart = 252512, XrefRangeEnd = 252517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float tVkuhWGJxXAqJqCGQqPuqHUgFKP(UpdateLoopType A_1, AxisCalibration A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.NativeMethodInfoPtr_tVkuhWGJxXAqJqCGQqPuqHUgFKP_Internal_Single_UpdateLoopType_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060039E2 RID: 14818 RVA: 0x00014713 File Offset: 0x00012913
			public Axis(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001136 RID: 4406
			// (get) Token: 0x060039E3 RID: 14819 RVA: 0x00118EA0 File Offset: 0x001170A0
			// (set) Token: 0x060039E4 RID: 14820 RVA: 0x0001471C File Offset: 0x0001291C
			public unsafe AxisRange fDIHCXxKWzIBcWjRyUjPuXoIgcA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.NativeFieldInfoPtr_fDIHCXxKWzIBcWjRyUjPuXoIgcA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.NativeFieldInfoPtr_fDIHCXxKWzIBcWjRyUjPuXoIgcA)) = value;
				}
			}

			// Token: 0x17001137 RID: 4407
			// (get) Token: 0x060039E5 RID: 14821 RVA: 0x00118EC8 File Offset: 0x001170C8
			// (set) Token: 0x060039E6 RID: 14822 RVA: 0x00014737 File Offset: 0x00012937
			public unsafe HardwareAxisInfo OgYRCieCJefyrdQarbNtAvtWEWi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.NativeFieldInfoPtr_OgYRCieCJefyrdQarbNtAvtWEWi);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareAxisInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.NativeFieldInfoPtr_OgYRCieCJefyrdQarbNtAvtWEWi), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040030A4 RID: 12452
			private static readonly IntPtr NativeFieldInfoPtr_fDIHCXxKWzIBcWjRyUjPuXoIgcA;

			// Token: 0x040030A5 RID: 12453
			private static readonly IntPtr NativeFieldInfoPtr_OgYRCieCJefyrdQarbNtAvtWEWi;

			// Token: 0x040030A6 RID: 12454
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

			// Token: 0x040030A7 RID: 12455
			private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_get_Single_0;

			// Token: 0x040030A8 RID: 12456
			private static readonly IntPtr NativeMethodInfoPtr_get_valueRaw_Public_get_Single_0;

			// Token: 0x040030A9 RID: 12457
			private static readonly IntPtr NativeMethodInfoPtr_set_valueRaw_Internal_set_Void_Single_0;

			// Token: 0x040030AA RID: 12458
			private static readonly IntPtr NativeMethodInfoPtr_get_valueRawPrev_Public_get_Single_0;

			// Token: 0x040030AB RID: 12459
			private static readonly IntPtr NativeMethodInfoPtr_get_valueDelta_Public_get_Single_0;

			// Token: 0x040030AC RID: 12460
			private static readonly IntPtr NativeMethodInfoPtr_get_valueDeltaRaw_Public_get_Single_0;

			// Token: 0x040030AD RID: 12461
			private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeActive_Public_get_Double_0;

			// Token: 0x040030AE RID: 12462
			private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeActiveRaw_Public_get_Double_0;

			// Token: 0x040030AF RID: 12463
			private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeInactive_Public_get_Double_0;

			// Token: 0x040030B0 RID: 12464
			private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeInactiveRaw_Public_get_Double_0;

			// Token: 0x040030B1 RID: 12465
			private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeValueChanged_Public_get_Double_0;

			// Token: 0x040030B2 RID: 12466
			private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeValueChangedRaw_Public_get_Double_0;

			// Token: 0x040030B3 RID: 12467
			private static readonly IntPtr NativeMethodInfoPtr_get_timeActive_Public_get_Double_0;

			// Token: 0x040030B4 RID: 12468
			private static readonly IntPtr NativeMethodInfoPtr_get_timeActiveRaw_Public_get_Double_0;

			// Token: 0x040030B5 RID: 12469
			private static readonly IntPtr NativeMethodInfoPtr_get_timeInactive_Public_get_Double_0;

			// Token: 0x040030B6 RID: 12470
			private static readonly IntPtr NativeMethodInfoPtr_get_timeInactiveRaw_Public_get_Double_0;

			// Token: 0x040030B7 RID: 12471
			private static readonly IntPtr NativeMethodInfoPtr_get_pollingDeadZone_Public_get_Single_0;

			// Token: 0x040030B8 RID: 12472
			private static readonly IntPtr NativeMethodInfoPtr_set_pollingDeadZone_Public_set_Void_Single_0;

			// Token: 0x040030B9 RID: 12473
			private static readonly IntPtr NativeMethodInfoPtr_get_selfValue_Internal_get_Single_0;

			// Token: 0x040030BA RID: 12474
			private static readonly IntPtr NativeMethodInfoPtr_get_selfValuePrev_Internal_get_Single_0;

			// Token: 0x040030BB RID: 12475
			private static readonly IntPtr NativeMethodInfoPtr_zdjbCtxxcNeSINWdALGZOqnWWan_Internal_Void_Single_0;

			// Token: 0x040030BC RID: 12476
			private static readonly IntPtr NativeMethodInfoPtr_get_effectivePollingDeadZone_Internal_get_Single_0;

			// Token: 0x040030BD RID: 12477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_AxisRange_HardwareAxisInfo_0;

			// Token: 0x040030BE RID: 12478
			private static readonly IntPtr NativeMethodInfoPtr_OUcvkyJdgsDqccHXTzfRFTxSgUWv_Internal_Void_UpdateLoopType_0;

			// Token: 0x040030BF RID: 12479
			private static readonly IntPtr NativeMethodInfoPtr_noHaMSFFgNmzSdsIpqSbNAxZzgP_Internal_Void_AxisCalibration_0;

			// Token: 0x040030C0 RID: 12480
			private static readonly IntPtr NativeMethodInfoPtr_noHaMSFFgNmzSdsIpqSbNAxZzgP_Internal_Void_0;

			// Token: 0x040030C1 RID: 12481
			private static readonly IntPtr NativeMethodInfoPtr_ACWslvTmrJUvUdQHwjBngSRrHBwZ_Internal_Void_0;

			// Token: 0x040030C2 RID: 12482
			private static readonly IntPtr NativeMethodInfoPtr_SPuLXGnIgfzfStgTpoQuDdeEgbv_Internal_Void_0;

			// Token: 0x040030C3 RID: 12483
			private static readonly IntPtr NativeMethodInfoPtr_iQIkOXadIqbSxfYACywghOyFKcxa_Internal_Void_Single_0;

			// Token: 0x040030C4 RID: 12484
			private static readonly IntPtr NativeMethodInfoPtr_tVkuhWGJxXAqJqCGQqPuqHUgFKP_Internal_Single_UpdateLoopType_AxisCalibration_0;

			// Token: 0x020004C5 RID: 1221
			public class SxVdyrwlldgbDBhkDwRYVOXJmwma : Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ
			{
				// Token: 0x06005292 RID: 21138 RVA: 0x0001DD76 File Offset: 0x0001BF76
				// Note: this type is marked as 'beforefieldinit'.
				static SxVdyrwlldgbDBhkDwRYVOXJmwma()
				{
					Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller.Axis>.NativeClassPtr, "SxVdyrwlldgbDBhkDwRYVOXJmwma");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma>.NativeClassPtr);
					Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma>.NativeClassPtr, 100665272);
				}

				// Token: 0x06005293 RID: 21139 RVA: 0x001764A4 File Offset: 0x001746A4
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252258, RefRangeEnd = 252260, XrefRangeStart = 252252, XrefRangeEnd = 252258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SxVdyrwlldgbDBhkDwRYVOXJmwma(UpdateLoopSetting updateCycle)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref updateCycle;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06005294 RID: 21140 RVA: 0x0001DDAA File Offset: 0x0001BFAA
				public SxVdyrwlldgbDBhkDwRYVOXJmwma(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04004538 RID: 17720
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0;

				// Token: 0x020005B2 RID: 1458
				public class tkokRiCPewKHjiwNOwYCDAqPTuI : Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj
				{
					// Token: 0x06006115 RID: 24853 RVA: 0x001AF9FC File Offset: 0x001ADBFC
					// Note: this type is marked as 'beforefieldinit'.
					static tkokRiCPewKHjiwNOwYCDAqPTuI()
					{
						Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma>.NativeClassPtr, "tkokRiCPewKHjiwNOwYCDAqPTuI");
						IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr);
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_rZncCoUHfzdegAUtBALBmlzEyAo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "rZncCoUHfzdegAUtBALBmlzEyAo");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "wvNaDPcNUyHJKWogdKCZCqbNISpy");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_wFLVcWuuYBAokRPUVqFImzEdKYb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "wFLVcWuuYBAokRPUVqFImzEdKYb");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_ehhdQVFhDHXypkrDkapBQMneQuY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "ehhdQVFhDHXypkrDkapBQMneQuY");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_NqoVkHBrOwpgvNjSVOgakopJuNX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "NqoVkHBrOwpgvNjSVOgakopJuNX");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_PcUqjRDwSeQbTuBHEbQWlMgrlwF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "PcUqjRDwSeQbTuBHEbQWlMgrlwF");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_cMlgKfrfWpNvSFflUUGAKlQyQAA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "cMlgKfrfWpNvSFflUUGAKlQyQAA");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_JELYDyELjObtBFpOYOFlpihygDbE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "JELYDyELjObtBFpOYOFlpihygDbE");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_xaxRXmuLrHejOIGZEmjRUlAVGGDG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "xaxRXmuLrHejOIGZEmjRUlAVGGDG");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_myRFBpAXLGLsruoEWufemwZNTXy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "myRFBpAXLGLsruoEWufemwZNTXy");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_qdMMOnhcDmogKeklpmZjElKNRAw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "qdMMOnhcDmogKeklpmZjElKNRAw");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_VCUygWeHaMiQdVsyhmIKRVIWVbs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "VCUygWeHaMiQdVsyhmIKRVIWVbs");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_TnEwkGRKVVAZJeonDqRGcjOaKjW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, "TnEwkGRKVVAZJeonDqRGcjOaKjW");
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_get_timeActive_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, 100665273);
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_get_timeActiveRaw_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, 100665274);
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_get_timeInactive_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, 100665275);
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_get_timeInactiveRaw_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, 100665276);
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, 100665277);
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_LsFvnYIXQbBWmRDLZfrgzvkPCEMF_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, 100665278);
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, 100665279);
						Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr, 100665280);
					}

					// Token: 0x17001D70 RID: 7536
					// (get) Token: 0x06006116 RID: 24854 RVA: 0x001AFBCC File Offset: 0x001ADDCC
					public unsafe double XaZgQWQBXvbxkdAxzKTgBKvDaIUw
					{
						[CallerCount(2)]
						[CachedScanResults(RefRangeStart = 252227, RefRangeEnd = 252229, XrefRangeStart = 252223, XrefRangeEnd = 252227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
						get
						{
							IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
							IntPtr* ptr = null;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_get_timeActive_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
							return *IL2CPP.il2cpp_object_unbox(intPtr);
						}
					}

					// Token: 0x17001D71 RID: 7537
					// (get) Token: 0x06006117 RID: 24855 RVA: 0x001AFC08 File Offset: 0x001ADE08
					public unsafe double URRaiSPnsKwKeLIPlXbGxYjsEBT
					{
						[CallerCount(0)]
						[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252229, XrefRangeEnd = 252233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
						get
						{
							IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
							IntPtr* ptr = null;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_get_timeActiveRaw_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
							return *IL2CPP.il2cpp_object_unbox(intPtr);
						}
					}

					// Token: 0x17001D72 RID: 7538
					// (get) Token: 0x06006118 RID: 24856 RVA: 0x001AFC44 File Offset: 0x001ADE44
					public unsafe double BahBYEjCCIKbuxjByppFhtHpktf
					{
						[CallerCount(0)]
						[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252233, XrefRangeEnd = 252237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
						get
						{
							IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
							IntPtr* ptr = null;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_get_timeInactive_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
							return *IL2CPP.il2cpp_object_unbox(intPtr);
						}
					}

					// Token: 0x17001D73 RID: 7539
					// (get) Token: 0x06006119 RID: 24857 RVA: 0x001AFC80 File Offset: 0x001ADE80
					public unsafe double vnADeddDPSuoBhZwxMpShQMoqxKe
					{
						[CallerCount(0)]
						[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252237, XrefRangeEnd = 252241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
						get
						{
							IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
							IntPtr* ptr = null;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_get_timeInactiveRaw_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
							return *IL2CPP.il2cpp_object_unbox(intPtr);
						}
					}

					// Token: 0x0600611A RID: 24858 RVA: 0x001AFCBC File Offset: 0x001ADEBC
					[CallerCount(3)]
					[CachedScanResults(RefRangeStart = 252249, RefRangeEnd = 252252, XrefRangeStart = 252241, XrefRangeEnd = 252249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe void xozDTcGUrsCTUDmjINWIvPSceAOJ(bool A_1)
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref A_1;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}

					// Token: 0x0600611B RID: 24859 RVA: 0x001AFCFC File Offset: 0x001ADEFC
					[CallerCount(0)]
					public unsafe void LsFvnYIXQbBWmRDLZfrgzvkPCEMF(float A_1)
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref A_1;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_LsFvnYIXQbBWmRDLZfrgzvkPCEMF_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}

					// Token: 0x0600611C RID: 24860 RVA: 0x001AFD3C File Offset: 0x001ADF3C
					[CallerCount(0)]
					public unsafe override void vsfKIEzLYgmvYXdfRKJgdqwirYk()
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}

					// Token: 0x0600611D RID: 24861 RVA: 0x001AFD78 File Offset: 0x001ADF78
					[CallerCount(7)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe tkokRiCPewKHjiwNOwYCDAqPTuI()
						: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI>.NativeClassPtr))
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}

					// Token: 0x0600611E RID: 24862 RVA: 0x00023D7B File Offset: 0x00021F7B
					public tkokRiCPewKHjiwNOwYCDAqPTuI(IntPtr pointer)
						: base(pointer)
					{
					}

					// Token: 0x17001D63 RID: 7523
					// (get) Token: 0x0600611F RID: 24863 RVA: 0x001AFDB4 File Offset: 0x001ADFB4
					// (set) Token: 0x06006120 RID: 24864 RVA: 0x00023D84 File Offset: 0x00021F84
					public unsafe static float rZncCoUHfzdegAUtBALBmlzEyAo
					{
						get
						{
							float num;
							IL2CPP.il2cpp_field_static_get_value(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_rZncCoUHfzdegAUtBALBmlzEyAo, (void*)(&num));
							return num;
						}
						set
						{
							IL2CPP.il2cpp_field_static_set_value(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_rZncCoUHfzdegAUtBALBmlzEyAo, (void*)(&value));
						}
					}

					// Token: 0x17001D64 RID: 7524
					// (get) Token: 0x06006121 RID: 24865 RVA: 0x001AFDD0 File Offset: 0x001ADFD0
					// (set) Token: 0x06006122 RID: 24866 RVA: 0x00023D92 File Offset: 0x00021F92
					public unsafe float wvNaDPcNUyHJKWogdKCZCqbNISpy
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy)) = value;
						}
					}

					// Token: 0x17001D65 RID: 7525
					// (get) Token: 0x06006123 RID: 24867 RVA: 0x001AFDF8 File Offset: 0x001ADFF8
					// (set) Token: 0x06006124 RID: 24868 RVA: 0x00023DAD File Offset: 0x00021FAD
					public unsafe float wFLVcWuuYBAokRPUVqFImzEdKYb
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_wFLVcWuuYBAokRPUVqFImzEdKYb);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_wFLVcWuuYBAokRPUVqFImzEdKYb)) = value;
						}
					}

					// Token: 0x17001D66 RID: 7526
					// (get) Token: 0x06006125 RID: 24869 RVA: 0x001AFE20 File Offset: 0x001AE020
					// (set) Token: 0x06006126 RID: 24870 RVA: 0x00023DC8 File Offset: 0x00021FC8
					public unsafe float ehhdQVFhDHXypkrDkapBQMneQuY
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_ehhdQVFhDHXypkrDkapBQMneQuY);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_ehhdQVFhDHXypkrDkapBQMneQuY)) = value;
						}
					}

					// Token: 0x17001D67 RID: 7527
					// (get) Token: 0x06006127 RID: 24871 RVA: 0x001AFE48 File Offset: 0x001AE048
					// (set) Token: 0x06006128 RID: 24872 RVA: 0x00023DE3 File Offset: 0x00021FE3
					public unsafe float NqoVkHBrOwpgvNjSVOgakopJuNX
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_NqoVkHBrOwpgvNjSVOgakopJuNX);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_NqoVkHBrOwpgvNjSVOgakopJuNX)) = value;
						}
					}

					// Token: 0x17001D68 RID: 7528
					// (get) Token: 0x06006129 RID: 24873 RVA: 0x001AFE70 File Offset: 0x001AE070
					// (set) Token: 0x0600612A RID: 24874 RVA: 0x00023DFE File Offset: 0x00021FFE
					public unsafe float PcUqjRDwSeQbTuBHEbQWlMgrlwF
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_PcUqjRDwSeQbTuBHEbQWlMgrlwF);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_PcUqjRDwSeQbTuBHEbQWlMgrlwF)) = value;
						}
					}

					// Token: 0x17001D69 RID: 7529
					// (get) Token: 0x0600612B RID: 24875 RVA: 0x001AFE98 File Offset: 0x001AE098
					// (set) Token: 0x0600612C RID: 24876 RVA: 0x00023E19 File Offset: 0x00022019
					public unsafe float cMlgKfrfWpNvSFflUUGAKlQyQAA
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_cMlgKfrfWpNvSFflUUGAKlQyQAA);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_cMlgKfrfWpNvSFflUUGAKlQyQAA)) = value;
						}
					}

					// Token: 0x17001D6A RID: 7530
					// (get) Token: 0x0600612D RID: 24877 RVA: 0x001AFEC0 File Offset: 0x001AE0C0
					// (set) Token: 0x0600612E RID: 24878 RVA: 0x00023E34 File Offset: 0x00022034
					public unsafe double JELYDyELjObtBFpOYOFlpihygDbE
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_JELYDyELjObtBFpOYOFlpihygDbE);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_JELYDyELjObtBFpOYOFlpihygDbE)) = value;
						}
					}

					// Token: 0x17001D6B RID: 7531
					// (get) Token: 0x0600612F RID: 24879 RVA: 0x001AFEE8 File Offset: 0x001AE0E8
					// (set) Token: 0x06006130 RID: 24880 RVA: 0x00023E4F File Offset: 0x0002204F
					public unsafe double xaxRXmuLrHejOIGZEmjRUlAVGGDG
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_xaxRXmuLrHejOIGZEmjRUlAVGGDG);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_xaxRXmuLrHejOIGZEmjRUlAVGGDG)) = value;
						}
					}

					// Token: 0x17001D6C RID: 7532
					// (get) Token: 0x06006131 RID: 24881 RVA: 0x001AFF10 File Offset: 0x001AE110
					// (set) Token: 0x06006132 RID: 24882 RVA: 0x00023E6A File Offset: 0x0002206A
					public unsafe double myRFBpAXLGLsruoEWufemwZNTXy
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_myRFBpAXLGLsruoEWufemwZNTXy);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_myRFBpAXLGLsruoEWufemwZNTXy)) = value;
						}
					}

					// Token: 0x17001D6D RID: 7533
					// (get) Token: 0x06006133 RID: 24883 RVA: 0x001AFF38 File Offset: 0x001AE138
					// (set) Token: 0x06006134 RID: 24884 RVA: 0x00023E85 File Offset: 0x00022085
					public unsafe double qdMMOnhcDmogKeklpmZjElKNRAw
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_qdMMOnhcDmogKeklpmZjElKNRAw);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_qdMMOnhcDmogKeklpmZjElKNRAw)) = value;
						}
					}

					// Token: 0x17001D6E RID: 7534
					// (get) Token: 0x06006135 RID: 24885 RVA: 0x001AFF60 File Offset: 0x001AE160
					// (set) Token: 0x06006136 RID: 24886 RVA: 0x00023EA0 File Offset: 0x000220A0
					public unsafe double VCUygWeHaMiQdVsyhmIKRVIWVbs
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_VCUygWeHaMiQdVsyhmIKRVIWVbs);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_VCUygWeHaMiQdVsyhmIKRVIWVbs)) = value;
						}
					}

					// Token: 0x17001D6F RID: 7535
					// (get) Token: 0x06006137 RID: 24887 RVA: 0x001AFF88 File Offset: 0x001AE188
					// (set) Token: 0x06006138 RID: 24888 RVA: 0x00023EBB File Offset: 0x000220BB
					public unsafe double TnEwkGRKVVAZJeonDqRGcjOaKjW
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_TnEwkGRKVVAZJeonDqRGcjOaKjW);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis.SxVdyrwlldgbDBhkDwRYVOXJmwma.tkokRiCPewKHjiwNOwYCDAqPTuI.NativeFieldInfoPtr_TnEwkGRKVVAZJeonDqRGcjOaKjW)) = value;
						}
					}

					// Token: 0x04004F97 RID: 20375
					private static readonly IntPtr NativeFieldInfoPtr_rZncCoUHfzdegAUtBALBmlzEyAo;

					// Token: 0x04004F98 RID: 20376
					private static readonly IntPtr NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy;

					// Token: 0x04004F99 RID: 20377
					private static readonly IntPtr NativeFieldInfoPtr_wFLVcWuuYBAokRPUVqFImzEdKYb;

					// Token: 0x04004F9A RID: 20378
					private static readonly IntPtr NativeFieldInfoPtr_ehhdQVFhDHXypkrDkapBQMneQuY;

					// Token: 0x04004F9B RID: 20379
					private static readonly IntPtr NativeFieldInfoPtr_NqoVkHBrOwpgvNjSVOgakopJuNX;

					// Token: 0x04004F9C RID: 20380
					private static readonly IntPtr NativeFieldInfoPtr_PcUqjRDwSeQbTuBHEbQWlMgrlwF;

					// Token: 0x04004F9D RID: 20381
					private static readonly IntPtr NativeFieldInfoPtr_cMlgKfrfWpNvSFflUUGAKlQyQAA;

					// Token: 0x04004F9E RID: 20382
					private static readonly IntPtr NativeFieldInfoPtr_JELYDyELjObtBFpOYOFlpihygDbE;

					// Token: 0x04004F9F RID: 20383
					private static readonly IntPtr NativeFieldInfoPtr_xaxRXmuLrHejOIGZEmjRUlAVGGDG;

					// Token: 0x04004FA0 RID: 20384
					private static readonly IntPtr NativeFieldInfoPtr_myRFBpAXLGLsruoEWufemwZNTXy;

					// Token: 0x04004FA1 RID: 20385
					private static readonly IntPtr NativeFieldInfoPtr_qdMMOnhcDmogKeklpmZjElKNRAw;

					// Token: 0x04004FA2 RID: 20386
					private static readonly IntPtr NativeFieldInfoPtr_VCUygWeHaMiQdVsyhmIKRVIWVbs;

					// Token: 0x04004FA3 RID: 20387
					private static readonly IntPtr NativeFieldInfoPtr_TnEwkGRKVVAZJeonDqRGcjOaKjW;

					// Token: 0x04004FA4 RID: 20388
					private static readonly IntPtr NativeMethodInfoPtr_get_timeActive_Public_get_Double_0;

					// Token: 0x04004FA5 RID: 20389
					private static readonly IntPtr NativeMethodInfoPtr_get_timeActiveRaw_Public_get_Double_0;

					// Token: 0x04004FA6 RID: 20390
					private static readonly IntPtr NativeMethodInfoPtr_get_timeInactive_Public_get_Double_0;

					// Token: 0x04004FA7 RID: 20391
					private static readonly IntPtr NativeMethodInfoPtr_get_timeInactiveRaw_Public_get_Double_0;

					// Token: 0x04004FA8 RID: 20392
					private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_Boolean_0;

					// Token: 0x04004FA9 RID: 20393
					private static readonly IntPtr NativeMethodInfoPtr_LsFvnYIXQbBWmRDLZfrgzvkPCEMF_Public_Void_Single_0;

					// Token: 0x04004FAA RID: 20394
					private static readonly IntPtr NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0;

					// Token: 0x04004FAB RID: 20395
					private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
				}
			}
		}

		// Token: 0x02000278 RID: 632
		public sealed class Button : Controller.Element
		{
			// Token: 0x060039E7 RID: 14823 RVA: 0x00118EF8 File Offset: 0x001170F8
			// Note: this type is marked as 'beforefieldinit'.
			static Button()
			{
				Il2CppClassPointerStore<Controller.Button>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller>.NativeClassPtr, "Button");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr);
				Controller.Button.NativeFieldInfoPtr_pbTmHIwzBNFCngWudUCIldFdyXX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, "pbTmHIwzBNFCngWudUCIldFdyXX");
				Controller.Button.NativeFieldInfoPtr_uRnlqWpgOCBvHXdvnCHOCgWMKdwC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, "uRnlqWpgOCBvHXdvnCHOCgWMKdwC");
				Controller.Button.NativeMethodInfoPtr_get_valuePrev_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665281);
				Controller.Button.NativeMethodInfoPtr_get_value_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665282);
				Controller.Button.NativeMethodInfoPtr_get_pressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665283);
				Controller.Button.NativeMethodInfoPtr_get_pressurePrev_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665284);
				Controller.Button.NativeMethodInfoPtr_get_isPressureSensitive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665285);
				Controller.Button.NativeMethodInfoPtr_get_justPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665286);
				Controller.Button.NativeMethodInfoPtr_get_justReleased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665287);
				Controller.Button.NativeMethodInfoPtr_get_justChangedState_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665288);
				Controller.Button.NativeMethodInfoPtr_get_doublePressedAndHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665289);
				Controller.Button.NativeMethodInfoPtr_get_justDoublePressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665290);
				Controller.Button.NativeMethodInfoPtr_get_timePressed_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665291);
				Controller.Button.NativeMethodInfoPtr_get_timeUnpressed_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665292);
				Controller.Button.NativeMethodInfoPtr_get_lastTimePressed_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665293);
				Controller.Button.NativeMethodInfoPtr_get_lastTimeUnpressed_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665294);
				Controller.Button.NativeMethodInfoPtr_get_lastTimeStateChanged_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665295);
				Controller.Button.NativeMethodInfoPtr_get_state_Internal_get_ButtonStateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665296);
				Controller.Button.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_HardwareButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665297);
				Controller.Button.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_Boolean_HardwareButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665298);
				Controller.Button.NativeMethodInfoPtr_DoublePressedAndHeld_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665299);
				Controller.Button.NativeMethodInfoPtr_JustDoublePressed_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665300);
				Controller.Button.NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Internal_Void_UpdateLoopType_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665301);
				Controller.Button.NativeMethodInfoPtr_qJEmVJDatZArCEGgigjUSmewLOpG_Internal_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665302);
				Controller.Button.NativeMethodInfoPtr_iQIkOXadIqbSxfYACywghOyFKcxa_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, 100665303);
			}

			// Token: 0x1700114E RID: 4430
			// (get) Token: 0x060039E8 RID: 14824 RVA: 0x00119118 File Offset: 0x00117318
			public unsafe bool valuePrev
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 252575, RefRangeEnd = 252589, XrefRangeStart = 252569, XrefRangeEnd = 252575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_valuePrev_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700114F RID: 4431
			// (get) Token: 0x060039E9 RID: 14825 RVA: 0x00119154 File Offset: 0x00117354
			public unsafe bool value
			{
				[CallerCount(28)]
				[CachedScanResults(RefRangeStart = 252595, RefRangeEnd = 252623, XrefRangeStart = 252589, XrefRangeEnd = 252595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_value_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001150 RID: 4432
			// (get) Token: 0x060039EA RID: 14826 RVA: 0x00119190 File Offset: 0x00117390
			public unsafe float pressure
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 252630, RefRangeEnd = 252633, XrefRangeStart = 252623, XrefRangeEnd = 252630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_pressure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001151 RID: 4433
			// (get) Token: 0x060039EB RID: 14827 RVA: 0x001191CC File Offset: 0x001173CC
			public unsafe float pressurePrev
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 252640, RefRangeEnd = 252641, XrefRangeStart = 252633, XrefRangeEnd = 252640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_pressurePrev_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001152 RID: 4434
			// (get) Token: 0x060039EC RID: 14828 RVA: 0x00119208 File Offset: 0x00117408
			public unsafe bool isPressureSensitive
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 252645, RefRangeEnd = 252648, XrefRangeStart = 252641, XrefRangeEnd = 252645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_isPressureSensitive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001153 RID: 4435
			// (get) Token: 0x060039ED RID: 14829 RVA: 0x00119244 File Offset: 0x00117444
			public unsafe bool justPressed
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 252654, RefRangeEnd = 252661, XrefRangeStart = 252648, XrefRangeEnd = 252654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_justPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001154 RID: 4436
			// (get) Token: 0x060039EE RID: 14830 RVA: 0x00119280 File Offset: 0x00117480
			public unsafe bool justReleased
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 252667, RefRangeEnd = 252671, XrefRangeStart = 252661, XrefRangeEnd = 252667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_justReleased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001155 RID: 4437
			// (get) Token: 0x060039EF RID: 14831 RVA: 0x001192BC File Offset: 0x001174BC
			public unsafe bool justChangedState
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252671, XrefRangeEnd = 252677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_justChangedState_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001156 RID: 4438
			// (get) Token: 0x060039F0 RID: 14832 RVA: 0x001192F8 File Offset: 0x001174F8
			public unsafe bool doublePressedAndHeld
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 252683, RefRangeEnd = 252684, XrefRangeStart = 252677, XrefRangeEnd = 252683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_doublePressedAndHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001157 RID: 4439
			// (get) Token: 0x060039F1 RID: 14833 RVA: 0x00119334 File Offset: 0x00117534
			public unsafe bool justDoublePressed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 252691, RefRangeEnd = 252692, XrefRangeStart = 252684, XrefRangeEnd = 252691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_justDoublePressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001158 RID: 4440
			// (get) Token: 0x060039F2 RID: 14834 RVA: 0x00119370 File Offset: 0x00117570
			public unsafe double timePressed
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 252701, RefRangeEnd = 252706, XrefRangeStart = 252692, XrefRangeEnd = 252701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_timePressed_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001159 RID: 4441
			// (get) Token: 0x060039F3 RID: 14835 RVA: 0x001193AC File Offset: 0x001175AC
			public unsafe double timeUnpressed
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 252715, RefRangeEnd = 252720, XrefRangeStart = 252706, XrefRangeEnd = 252715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_timeUnpressed_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700115A RID: 4442
			// (get) Token: 0x060039F4 RID: 14836 RVA: 0x001193E8 File Offset: 0x001175E8
			public unsafe double lastTimePressed
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 252728, RefRangeEnd = 252732, XrefRangeStart = 252720, XrefRangeEnd = 252728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_lastTimePressed_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700115B RID: 4443
			// (get) Token: 0x060039F5 RID: 14837 RVA: 0x00119424 File Offset: 0x00117624
			public unsafe double lastTimeUnpressed
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252741, RefRangeEnd = 252743, XrefRangeStart = 252732, XrefRangeEnd = 252741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_lastTimeUnpressed_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700115C RID: 4444
			// (get) Token: 0x060039F6 RID: 14838 RVA: 0x00119460 File Offset: 0x00117660
			public unsafe double lastTimeStateChanged
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252743, XrefRangeEnd = 252749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_lastTimeStateChanged_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700115D RID: 4445
			// (get) Token: 0x060039F7 RID: 14839 RVA: 0x0011949C File Offset: 0x0011769C
			public unsafe ButtonStateFlags state
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252749, XrefRangeEnd = 252751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_get_state_Internal_get_ButtonStateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060039F8 RID: 14840 RVA: 0x001194D8 File Offset: 0x001176D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252751, XrefRangeEnd = 252760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Button(Controller controller, int elementIdentifierId, string name, HardwareButtonInfo buttonInfo)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttonInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_HardwareButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039F9 RID: 14841 RVA: 0x00119558 File Offset: 0x00117758
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 252769, RefRangeEnd = 252771, XrefRangeStart = 252760, XrefRangeEnd = 252769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Button(Controller controller, int elementIdentifierId, string name, bool isPressureSensitive, HardwareButtonInfo buttonInfo)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPressureSensitive;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttonInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_Boolean_HardwareButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039FA RID: 14842 RVA: 0x001195E4 File Offset: 0x001177E4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 252779, RefRangeEnd = 252783, XrefRangeStart = 252771, XrefRangeEnd = 252779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool DoublePressedAndHeld(float speed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref speed;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_DoublePressedAndHeld_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060039FB RID: 14843 RVA: 0x00119630 File Offset: 0x00117830
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 252792, RefRangeEnd = 252796, XrefRangeStart = 252783, XrefRangeEnd = 252792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool JustDoublePressed(float speed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref speed;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_JustDoublePressed_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060039FC RID: 14844 RVA: 0x0011967C File Offset: 0x0011787C
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 252811, RefRangeEnd = 252820, XrefRangeStart = 252796, XrefRangeEnd = 252811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void jDuDLbhduyqRAnokNKSffDLOAphG(UpdateLoopType A_1, int A_2, ControllerDataUpdater A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Internal_Void_UpdateLoopType_Int32_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039FD RID: 14845 RVA: 0x001196DC File Offset: 0x001178DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252830, RefRangeEnd = 252831, XrefRangeStart = 252820, XrefRangeEnd = 252830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void qJEmVJDatZArCEGgigjUSmewLOpG(UpdateLoopType A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_qJEmVJDatZArCEGgigjUSmewLOpG_Internal_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039FE RID: 14846 RVA: 0x0011971C File Offset: 0x0011791C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252831, XrefRangeEnd = 252847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void iQIkOXadIqbSxfYACywghOyFKcxa()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.NativeMethodInfoPtr_iQIkOXadIqbSxfYACywghOyFKcxa_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039FF RID: 14847 RVA: 0x00014756 File Offset: 0x00012956
			public Button(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700114C RID: 4428
			// (get) Token: 0x06003A00 RID: 14848 RVA: 0x00119750 File Offset: 0x00117950
			// (set) Token: 0x06003A01 RID: 14849 RVA: 0x0001475F File Offset: 0x0001295F
			public unsafe bool pbTmHIwzBNFCngWudUCIldFdyXX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.NativeFieldInfoPtr_pbTmHIwzBNFCngWudUCIldFdyXX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.NativeFieldInfoPtr_pbTmHIwzBNFCngWudUCIldFdyXX)) = value;
				}
			}

			// Token: 0x1700114D RID: 4429
			// (get) Token: 0x06003A02 RID: 14850 RVA: 0x00119778 File Offset: 0x00117978
			// (set) Token: 0x06003A03 RID: 14851 RVA: 0x0001477A File Offset: 0x0001297A
			public unsafe HardwareButtonInfo uRnlqWpgOCBvHXdvnCHOCgWMKdwC
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.NativeFieldInfoPtr_uRnlqWpgOCBvHXdvnCHOCgWMKdwC);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareButtonInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.NativeFieldInfoPtr_uRnlqWpgOCBvHXdvnCHOCgWMKdwC), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040030C5 RID: 12485
			private static readonly IntPtr NativeFieldInfoPtr_pbTmHIwzBNFCngWudUCIldFdyXX;

			// Token: 0x040030C6 RID: 12486
			private static readonly IntPtr NativeFieldInfoPtr_uRnlqWpgOCBvHXdvnCHOCgWMKdwC;

			// Token: 0x040030C7 RID: 12487
			private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_get_Boolean_0;

			// Token: 0x040030C8 RID: 12488
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Boolean_0;

			// Token: 0x040030C9 RID: 12489
			private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_get_Single_0;

			// Token: 0x040030CA RID: 12490
			private static readonly IntPtr NativeMethodInfoPtr_get_pressurePrev_Public_get_Single_0;

			// Token: 0x040030CB RID: 12491
			private static readonly IntPtr NativeMethodInfoPtr_get_isPressureSensitive_Public_get_Boolean_0;

			// Token: 0x040030CC RID: 12492
			private static readonly IntPtr NativeMethodInfoPtr_get_justPressed_Public_get_Boolean_0;

			// Token: 0x040030CD RID: 12493
			private static readonly IntPtr NativeMethodInfoPtr_get_justReleased_Public_get_Boolean_0;

			// Token: 0x040030CE RID: 12494
			private static readonly IntPtr NativeMethodInfoPtr_get_justChangedState_Public_get_Boolean_0;

			// Token: 0x040030CF RID: 12495
			private static readonly IntPtr NativeMethodInfoPtr_get_doublePressedAndHeld_Public_get_Boolean_0;

			// Token: 0x040030D0 RID: 12496
			private static readonly IntPtr NativeMethodInfoPtr_get_justDoublePressed_Public_get_Boolean_0;

			// Token: 0x040030D1 RID: 12497
			private static readonly IntPtr NativeMethodInfoPtr_get_timePressed_Public_get_Double_0;

			// Token: 0x040030D2 RID: 12498
			private static readonly IntPtr NativeMethodInfoPtr_get_timeUnpressed_Public_get_Double_0;

			// Token: 0x040030D3 RID: 12499
			private static readonly IntPtr NativeMethodInfoPtr_get_lastTimePressed_Public_get_Double_0;

			// Token: 0x040030D4 RID: 12500
			private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeUnpressed_Public_get_Double_0;

			// Token: 0x040030D5 RID: 12501
			private static readonly IntPtr NativeMethodInfoPtr_get_lastTimeStateChanged_Public_get_Double_0;

			// Token: 0x040030D6 RID: 12502
			private static readonly IntPtr NativeMethodInfoPtr_get_state_Internal_get_ButtonStateFlags_0;

			// Token: 0x040030D7 RID: 12503
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_HardwareButtonInfo_0;

			// Token: 0x040030D8 RID: 12504
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_Boolean_HardwareButtonInfo_0;

			// Token: 0x040030D9 RID: 12505
			private static readonly IntPtr NativeMethodInfoPtr_DoublePressedAndHeld_Public_Boolean_Single_0;

			// Token: 0x040030DA RID: 12506
			private static readonly IntPtr NativeMethodInfoPtr_JustDoublePressed_Public_Boolean_Single_0;

			// Token: 0x040030DB RID: 12507
			private static readonly IntPtr NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Internal_Void_UpdateLoopType_Int32_ControllerDataUpdater_0;

			// Token: 0x040030DC RID: 12508
			private static readonly IntPtr NativeMethodInfoPtr_qJEmVJDatZArCEGgigjUSmewLOpG_Internal_Void_UpdateLoopType_0;

			// Token: 0x040030DD RID: 12509
			private static readonly IntPtr NativeMethodInfoPtr_iQIkOXadIqbSxfYACywghOyFKcxa_Internal_Void_0;

			// Token: 0x020004C6 RID: 1222
			public class JRWdhfCTtbnlgJbadaNoEDQEyCs : Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ
			{
				// Token: 0x06005295 RID: 21141 RVA: 0x001764EC File Offset: 0x001746EC
				// Note: this type is marked as 'beforefieldinit'.
				static JRWdhfCTtbnlgJbadaNoEDQEyCs()
				{
					Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller.Button>.NativeClassPtr, "JRWdhfCTtbnlgJbadaNoEDQEyCs");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs>.NativeClassPtr);
					Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs>.NativeClassPtr, 100665304);
					Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.NativeMethodInfoPtr_ZTbbPphpRvfTjtvRokzCFscjJNrN_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs>.NativeClassPtr, 100665305);
					Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.NativeMethodInfoPtr_poOUNsZdKZSbJmltiLSnnEHFaqw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs>.NativeClassPtr, 100665306);
				}

				// Token: 0x06005296 RID: 21142 RVA: 0x00176554 File Offset: 0x00174754
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 252561, RefRangeEnd = 252563, XrefRangeStart = 252548, XrefRangeEnd = 252561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe JRWdhfCTtbnlgJbadaNoEDQEyCs(UpdateLoopSetting updateCycle, bool isPressureSensitive)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref updateCycle;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPressureSensitive;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005297 RID: 21143 RVA: 0x001765AC File Offset: 0x001747AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252563, XrefRangeEnd = 252566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void ZTbbPphpRvfTjtvRokzCFscjJNrN(float A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref A_1;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.NativeMethodInfoPtr_ZTbbPphpRvfTjtvRokzCFscjJNrN_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06005298 RID: 21144 RVA: 0x001765EC File Offset: 0x001747EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252566, XrefRangeEnd = 252569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void poOUNsZdKZSbJmltiLSnnEHFaqw()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.NativeMethodInfoPtr_poOUNsZdKZSbJmltiLSnnEHFaqw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005299 RID: 21145 RVA: 0x0001DDB3 File Offset: 0x0001BFB3
				public JRWdhfCTtbnlgJbadaNoEDQEyCs(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04004539 RID: 17721
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Boolean_0;

				// Token: 0x0400453A RID: 17722
				private static readonly IntPtr NativeMethodInfoPtr_ZTbbPphpRvfTjtvRokzCFscjJNrN_Public_Void_Single_0;

				// Token: 0x0400453B RID: 17723
				private static readonly IntPtr NativeMethodInfoPtr_poOUNsZdKZSbJmltiLSnnEHFaqw_Public_Void_0;

				// Token: 0x020005B3 RID: 1459
				public class OfyzxROrrIMgRihbCCIPUozXRIv : Controller.Element.VCFdbkuSuhBPXbbRzRdjSBdnqUJ.rHjtRNYnIdipfucnHOXblPwzKMj
				{
					// Token: 0x06006139 RID: 24889 RVA: 0x001AFFB0 File Offset: 0x001AE1B0
					// Note: this type is marked as 'beforefieldinit'.
					static OfyzxROrrIMgRihbCCIPUozXRIv()
					{
						Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs>.NativeClassPtr, "OfyzxROrrIMgRihbCCIPUozXRIv");
						IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv>.NativeClassPtr);
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv>.NativeClassPtr, "wvNaDPcNUyHJKWogdKCZCqbNISpy");
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_wFLVcWuuYBAokRPUVqFImzEdKYb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv>.NativeClassPtr, "wFLVcWuuYBAokRPUVqFImzEdKYb");
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_arXBdnBfxOmeRMyKIEKhTGpjcWb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv>.NativeClassPtr, "arXBdnBfxOmeRMyKIEKhTGpjcWb");
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_roRhnhXgnPCEyrmXaWJijoQnnBt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv>.NativeClassPtr, "roRhnhXgnPCEyrmXaWJijoQnnBt");
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv>.NativeClassPtr, 100665307);
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv>.NativeClassPtr, 100665308);
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv>.NativeClassPtr, 100665309);
					}

					// Token: 0x0600613A RID: 24890 RVA: 0x001B0068 File Offset: 0x001AE268
					[CallerCount(3)]
					[CachedScanResults(RefRangeStart = 252527, RefRangeEnd = 252530, XrefRangeStart = 252519, XrefRangeEnd = 252527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe OfyzxROrrIMgRihbCCIPUozXRIv()
						: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv>.NativeClassPtr))
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}

					// Token: 0x0600613B RID: 24891 RVA: 0x001B00A4 File Offset: 0x001AE2A4
					[CallerCount(5)]
					[CachedScanResults(RefRangeStart = 252537, RefRangeEnd = 252542, XrefRangeStart = 252530, XrefRangeEnd = 252537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe void jDuDLbhduyqRAnokNKSffDLOAphG(bool A_1)
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref A_1;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}

					// Token: 0x0600613C RID: 24892 RVA: 0x001B00E4 File Offset: 0x001AE2E4
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252542, XrefRangeEnd = 252543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe override void vsfKIEzLYgmvYXdfRKJgdqwirYk()
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}

					// Token: 0x0600613D RID: 24893 RVA: 0x00023ED6 File Offset: 0x000220D6
					public OfyzxROrrIMgRihbCCIPUozXRIv(IntPtr pointer)
						: base(pointer)
					{
					}

					// Token: 0x17001D74 RID: 7540
					// (get) Token: 0x0600613E RID: 24894 RVA: 0x001B0120 File Offset: 0x001AE320
					// (set) Token: 0x0600613F RID: 24895 RVA: 0x00023EDF File Offset: 0x000220DF
					public unsafe bool wvNaDPcNUyHJKWogdKCZCqbNISpy
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy)) = value;
						}
					}

					// Token: 0x17001D75 RID: 7541
					// (get) Token: 0x06006140 RID: 24896 RVA: 0x001B0148 File Offset: 0x001AE348
					// (set) Token: 0x06006141 RID: 24897 RVA: 0x00023EFA File Offset: 0x000220FA
					public unsafe bool wFLVcWuuYBAokRPUVqFImzEdKYb
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_wFLVcWuuYBAokRPUVqFImzEdKYb);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_wFLVcWuuYBAokRPUVqFImzEdKYb)) = value;
						}
					}

					// Token: 0x17001D76 RID: 7542
					// (get) Token: 0x06006142 RID: 24898 RVA: 0x001B0170 File Offset: 0x001AE370
					// (set) Token: 0x06006143 RID: 24899 RVA: 0x00023F15 File Offset: 0x00022115
					public unsafe ButtonStateRecorder arXBdnBfxOmeRMyKIEKhTGpjcWb
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_arXBdnBfxOmeRMyKIEKhTGpjcWb);
							IntPtr intPtr2 = *intPtr;
							return (intPtr2 != 0) ? Il2CppObjectPool.Get<ButtonStateRecorder>(intPtr2) : null;
						}
						set
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_arXBdnBfxOmeRMyKIEKhTGpjcWb), IL2CPP.Il2CppObjectBaseToPtr(value));
						}
					}

					// Token: 0x17001D77 RID: 7543
					// (get) Token: 0x06006144 RID: 24900 RVA: 0x001B01A0 File Offset: 0x001AE3A0
					// (set) Token: 0x06006145 RID: 24901 RVA: 0x00023F34 File Offset: 0x00022134
					public unsafe AYsdKyoSdUZuLebsxarNdnEZZsG roRhnhXgnPCEyrmXaWJijoQnnBt
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_roRhnhXgnPCEyrmXaWJijoQnnBt);
							IntPtr intPtr2 = *intPtr;
							return (intPtr2 != 0) ? Il2CppObjectPool.Get<AYsdKyoSdUZuLebsxarNdnEZZsG>(intPtr2) : null;
						}
						set
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv.NativeFieldInfoPtr_roRhnhXgnPCEyrmXaWJijoQnnBt), IL2CPP.Il2CppObjectBaseToPtr(value));
						}
					}

					// Token: 0x04004FAC RID: 20396
					private static readonly IntPtr NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy;

					// Token: 0x04004FAD RID: 20397
					private static readonly IntPtr NativeFieldInfoPtr_wFLVcWuuYBAokRPUVqFImzEdKYb;

					// Token: 0x04004FAE RID: 20398
					private static readonly IntPtr NativeFieldInfoPtr_arXBdnBfxOmeRMyKIEKhTGpjcWb;

					// Token: 0x04004FAF RID: 20399
					private static readonly IntPtr NativeFieldInfoPtr_roRhnhXgnPCEyrmXaWJijoQnnBt;

					// Token: 0x04004FB0 RID: 20400
					private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

					// Token: 0x04004FB1 RID: 20401
					private static readonly IntPtr NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Public_Void_Boolean_0;

					// Token: 0x04004FB2 RID: 20402
					private static readonly IntPtr NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0;
				}

				// Token: 0x020005B4 RID: 1460
				public class mWYSjXtdMEwzrnVjXVWMxJYMnO : Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.OfyzxROrrIMgRihbCCIPUozXRIv
				{
					// Token: 0x06006146 RID: 24902 RVA: 0x001B01D0 File Offset: 0x001AE3D0
					// Note: this type is marked as 'beforefieldinit'.
					static mWYSjXtdMEwzrnVjXVWMxJYMnO()
					{
						Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs>.NativeClassPtr, "mWYSjXtdMEwzrnVjXVWMxJYMnO");
						IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO>.NativeClassPtr);
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeFieldInfoPtr_RnrkiaExrAMASchzDNVWGHVqXiA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO>.NativeClassPtr, "RnrkiaExrAMASchzDNVWGHVqXiA");
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeFieldInfoPtr_ijueuZlHpstEuRKTAhgyHHPheks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO>.NativeClassPtr, "ijueuZlHpstEuRKTAhgyHHPheks");
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO>.NativeClassPtr, 100665310);
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO>.NativeClassPtr, 100665311);
						Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO>.NativeClassPtr, 100665312);
					}

					// Token: 0x06006147 RID: 24903 RVA: 0x001B0260 File Offset: 0x001AE460
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252543, XrefRangeEnd = 252544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe mWYSjXtdMEwzrnVjXVWMxJYMnO()
						: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO>.NativeClassPtr))
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}

					// Token: 0x06006148 RID: 24904 RVA: 0x001B029C File Offset: 0x001AE49C
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 252546, RefRangeEnd = 252547, XrefRangeStart = 252544, XrefRangeEnd = 252546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe void jDuDLbhduyqRAnokNKSffDLOAphG(float A_1)
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref A_1;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}

					// Token: 0x06006149 RID: 24905 RVA: 0x001B02DC File Offset: 0x001AE4DC
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252547, XrefRangeEnd = 252548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe override void vsfKIEzLYgmvYXdfRKJgdqwirYk()
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}

					// Token: 0x0600614A RID: 24906 RVA: 0x00023F53 File Offset: 0x00022153
					public mWYSjXtdMEwzrnVjXVWMxJYMnO(IntPtr pointer)
						: base(pointer)
					{
					}

					// Token: 0x17001D78 RID: 7544
					// (get) Token: 0x0600614B RID: 24907 RVA: 0x001B0318 File Offset: 0x001AE518
					// (set) Token: 0x0600614C RID: 24908 RVA: 0x00023F5C File Offset: 0x0002215C
					public unsafe float RnrkiaExrAMASchzDNVWGHVqXiA
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeFieldInfoPtr_RnrkiaExrAMASchzDNVWGHVqXiA);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeFieldInfoPtr_RnrkiaExrAMASchzDNVWGHVqXiA)) = value;
						}
					}

					// Token: 0x17001D79 RID: 7545
					// (get) Token: 0x0600614D RID: 24909 RVA: 0x001B0340 File Offset: 0x001AE540
					// (set) Token: 0x0600614E RID: 24910 RVA: 0x00023F77 File Offset: 0x00022177
					public unsafe float ijueuZlHpstEuRKTAhgyHHPheks
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeFieldInfoPtr_ijueuZlHpstEuRKTAhgyHHPheks);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Button.JRWdhfCTtbnlgJbadaNoEDQEyCs.mWYSjXtdMEwzrnVjXVWMxJYMnO.NativeFieldInfoPtr_ijueuZlHpstEuRKTAhgyHHPheks)) = value;
						}
					}

					// Token: 0x04004FB3 RID: 20403
					private static readonly IntPtr NativeFieldInfoPtr_RnrkiaExrAMASchzDNVWGHVqXiA;

					// Token: 0x04004FB4 RID: 20404
					private static readonly IntPtr NativeFieldInfoPtr_ijueuZlHpstEuRKTAhgyHHPheks;

					// Token: 0x04004FB5 RID: 20405
					private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

					// Token: 0x04004FB6 RID: 20406
					private static readonly IntPtr NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Public_Void_Single_0;

					// Token: 0x04004FB7 RID: 20407
					private static readonly IntPtr NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0;
				}
			}
		}

		// Token: 0x02000279 RID: 633
		public class CompoundElement : global::Il2CppSystem.Object
		{
			// Token: 0x06003A04 RID: 14852 RVA: 0x001197A8 File Offset: 0x001179A8
			// Note: this type is marked as 'beforefieldinit'.
			static CompoundElement()
			{
				Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller>.NativeClassPtr, "CompoundElement");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr);
				Controller.CompoundElement.NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, "LmpWzzgHGngqvdvpwzTKPbztfdh");
				Controller.CompoundElement.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, "dBMfgEzHekDWhMsmrRiTWJogtDs");
				Controller.CompoundElement.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, "HLmDmUQWoPLmPsyHTHuhoXXcGIu");
				Controller.CompoundElement.NativeFieldInfoPtr_bmcVHPhFqcClKFnlNjKbtEssOMVv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, "bmcVHPhFqcClKFnlNjKbtEssOMVv");
				Controller.CompoundElement.NativeFieldInfoPtr_yJYXnEfdkJNRmdgBKhiaglsvHpUg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, "yJYXnEfdkJNRmdgBKhiaglsvHpUg");
				Controller.CompoundElement.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, "egOPTGwnsPnUJWHsXfaRAFkRlvOu");
				Controller.CompoundElement.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, "SBmxkshsppDFZPZvftqYxbMuemu");
				Controller.CompoundElement.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665313);
				Controller.CompoundElement.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665314);
				Controller.CompoundElement.NativeMethodInfoPtr_get_type_Public_get_CompoundControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665315);
				Controller.CompoundElement.NativeMethodInfoPtr_get_hasElements_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665316);
				Controller.CompoundElement.NativeMethodInfoPtr_get_elementCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665317);
				Controller.CompoundElement.NativeMethodInfoPtr_get_elementCapacity_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665318);
				Controller.CompoundElement.NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665319);
				Controller.CompoundElement.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_CompoundControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665320);
				Controller.CompoundElement.NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_Element_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665321);
				Controller.CompoundElement.NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665322);
				Controller.CompoundElement.NativeMethodInfoPtr_xAZkgOELHNlJeHgdEyErZxcneWF_Internal_T_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665323);
				Controller.CompoundElement.NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Boolean_Element_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665324);
				Controller.CompoundElement.NativeMethodInfoPtr_fynaAcbvGTSPmdVEGMobmUIJkKvy_Internal_Boolean_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665325);
				Controller.CompoundElement.NativeMethodInfoPtr_tqsrbfolkxBdPzSvMJkFZNmosWB_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665326);
				Controller.CompoundElement.NativeMethodInfoPtr_cDnaXNudHhkGVwNJBkjCspzORSz_Private_Int32_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665327);
				Controller.CompoundElement.NativeMethodInfoPtr_eTIYoWTyDUbVxUsjLMGacHHRKmP_Private_Boolean_Element_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665328);
				Controller.CompoundElement.NativeMethodInfoPtr_DngaJTFclyRdIhdnxSjYNaleatvR_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665329);
				Controller.CompoundElement.NativeMethodInfoPtr_OkzuVDKNGElpKHRzbKkWehbPHfM_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, 100665330);
			}

			// Token: 0x17001165 RID: 4453
			// (get) Token: 0x06003A05 RID: 14853 RVA: 0x001199C8 File Offset: 0x00117BC8
			public unsafe int id
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252847, XrefRangeEnd = 252851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001166 RID: 4454
			// (get) Token: 0x06003A06 RID: 14854 RVA: 0x00119A04 File Offset: 0x00117C04
			public unsafe string name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252851, XrefRangeEnd = 252856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001167 RID: 4455
			// (get) Token: 0x06003A07 RID: 14855 RVA: 0x00119A3C File Offset: 0x00117C3C
			public unsafe CompoundControllerElementType type
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252856, XrefRangeEnd = 252860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_get_type_Public_get_CompoundControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001168 RID: 4456
			// (get) Token: 0x06003A08 RID: 14856 RVA: 0x00119A78 File Offset: 0x00117C78
			public unsafe bool hasElements
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252860, XrefRangeEnd = 252864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_get_hasElements_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001169 RID: 4457
			// (get) Token: 0x06003A09 RID: 14857 RVA: 0x00119AB4 File Offset: 0x00117CB4
			public unsafe int elementCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252864, XrefRangeEnd = 252868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_get_elementCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700116A RID: 4458
			// (get) Token: 0x06003A0A RID: 14858 RVA: 0x00119AF0 File Offset: 0x00117CF0
			public unsafe virtual int elementCapacity
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.CompoundElement.NativeMethodInfoPtr_get_elementCapacity_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700116B RID: 4459
			// (get) Token: 0x06003A0B RID: 14859 RVA: 0x00119B38 File Offset: 0x00117D38
			public unsafe ControllerElementIdentifier elementIdentifier
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252868, XrefRangeEnd = 252876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
				}
			}

			// Token: 0x06003A0C RID: 14860 RVA: 0x00119B78 File Offset: 0x00117D78
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 252883, RefRangeEnd = 252885, XrefRangeStart = 252876, XrefRangeEnd = 252883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CompoundElement(Controller controller, int elementIdentifierId, string name, CompoundControllerElementType type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_CompoundControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A0D RID: 14861 RVA: 0x00119BF4 File Offset: 0x00117DF4
			[CallerCount(0)]
			public unsafe Controller.Element ffDeAbKJpVsIgLYjXxEUfwosxXOK(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_Element_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Element>(intPtr3) : null;
				}
			}

			// Token: 0x06003A0E RID: 14862 RVA: 0x00119C40 File Offset: 0x00117E40
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 252888, RefRangeEnd = 252898, XrefRangeStart = 252885, XrefRangeEnd = 252888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T ffDeAbKJpVsIgLYjXxEUfwosxXOK<T>(int A_1) where T : Controller.Element
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.MethodInfoStoreGeneric_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06003A0F RID: 14863 RVA: 0x00119C88 File Offset: 0x00117E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252898, XrefRangeEnd = 252901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T xAZkgOELHNlJeHgdEyErZxcneWF<T>(int A_1, out int A_2) where T : Controller.Element
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.MethodInfoStoreGeneric_xAZkgOELHNlJeHgdEyErZxcneWF_Internal_T_Int32_byref_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06003A10 RID: 14864 RVA: 0x00119CDC File Offset: 0x00117EDC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 252910, RefRangeEnd = 252913, XrefRangeStart = 252901, XrefRangeEnd = 252910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool FtpfwMCKfMCnbBBezixohHaJHAGb(Controller.Element A_1, int A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Boolean_Element_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003A11 RID: 14865 RVA: 0x00119D38 File Offset: 0x00117F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252913, XrefRangeEnd = 252921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool fynaAcbvGTSPmdVEGMobmUIJkKvy(Controller.Element A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_fynaAcbvGTSPmdVEGMobmUIJkKvy_Internal_Boolean_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A12 RID: 14866 RVA: 0x00119D88 File Offset: 0x00117F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252921, XrefRangeEnd = 252927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void tqsrbfolkxBdPzSvMJkFZNmosWB()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_tqsrbfolkxBdPzSvMJkFZNmosWB_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A13 RID: 14867 RVA: 0x00119DBC File Offset: 0x00117FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252927, XrefRangeEnd = 252928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int cDnaXNudHhkGVwNJBkjCspzORSz(Controller.Element A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_cDnaXNudHhkGVwNJBkjCspzORSz_Private_Int32_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A14 RID: 14868 RVA: 0x00119E0C File Offset: 0x0011800C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252937, RefRangeEnd = 252938, XrefRangeStart = 252928, XrefRangeEnd = 252937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool eTIYoWTyDUbVxUsjLMGacHHRKmP(Controller.Element A_1, int A_2, int A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_eTIYoWTyDUbVxUsjLMGacHHRKmP_Private_Boolean_Element_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003A15 RID: 14869 RVA: 0x00119E78 File Offset: 0x00118078
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252943, RefRangeEnd = 252944, XrefRangeStart = 252938, XrefRangeEnd = 252943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool DngaJTFclyRdIhdnxSjYNaleatvR(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_DngaJTFclyRdIhdnxSjYNaleatvR_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A16 RID: 14870 RVA: 0x00119EC4 File Offset: 0x001180C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252944, XrefRangeEnd = 252945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int OkzuVDKNGElpKHRzbKkWehbPHfM()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.NativeMethodInfoPtr_OkzuVDKNGElpKHRzbKkWehbPHfM_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003A17 RID: 14871 RVA: 0x00014799 File Offset: 0x00012999
			public CompoundElement(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700115E RID: 4446
			// (get) Token: 0x06003A18 RID: 14872 RVA: 0x00119F00 File Offset: 0x00118100
			// (set) Token: 0x06003A19 RID: 14873 RVA: 0x000147A2 File Offset: 0x000129A2
			public unsafe int LmpWzzgHGngqvdvpwzTKPbztfdh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh)) = value;
				}
			}

			// Token: 0x1700115F RID: 4447
			// (get) Token: 0x06003A1A RID: 14874 RVA: 0x00119F28 File Offset: 0x00118128
			// (set) Token: 0x06003A1B RID: 14875 RVA: 0x000147BD File Offset: 0x000129BD
			public unsafe string dBMfgEzHekDWhMsmrRiTWJogtDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001160 RID: 4448
			// (get) Token: 0x06003A1C RID: 14876 RVA: 0x00119F50 File Offset: 0x00118150
			// (set) Token: 0x06003A1D RID: 14877 RVA: 0x000147DC File Offset: 0x000129DC
			public unsafe CompoundControllerElementType HLmDmUQWoPLmPsyHTHuhoXXcGIu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu)) = value;
				}
			}

			// Token: 0x17001161 RID: 4449
			// (get) Token: 0x06003A1E RID: 14878 RVA: 0x00119F78 File Offset: 0x00118178
			// (set) Token: 0x06003A1F RID: 14879 RVA: 0x000147F7 File Offset: 0x000129F7
			public unsafe int bmcVHPhFqcClKFnlNjKbtEssOMVv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_bmcVHPhFqcClKFnlNjKbtEssOMVv);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_bmcVHPhFqcClKFnlNjKbtEssOMVv)) = value;
				}
			}

			// Token: 0x17001162 RID: 4450
			// (get) Token: 0x06003A20 RID: 14880 RVA: 0x00119FA0 File Offset: 0x001181A0
			// (set) Token: 0x06003A21 RID: 14881 RVA: 0x00014812 File Offset: 0x00012A12
			public unsafe Il2CppReferenceArray<Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck> yJYXnEfdkJNRmdgBKhiaglsvHpUg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_yJYXnEfdkJNRmdgBKhiaglsvHpUg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_yJYXnEfdkJNRmdgBKhiaglsvHpUg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001163 RID: 4451
			// (get) Token: 0x06003A22 RID: 14882 RVA: 0x00119FD0 File Offset: 0x001181D0
			// (set) Token: 0x06003A23 RID: 14883 RVA: 0x00014831 File Offset: 0x00012A31
			public unsafe Controller egOPTGwnsPnUJWHsXfaRAFkRlvOu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001164 RID: 4452
			// (get) Token: 0x06003A24 RID: 14884 RVA: 0x0011A000 File Offset: 0x00118200
			// (set) Token: 0x06003A25 RID: 14885 RVA: 0x00014850 File Offset: 0x00012A50
			public unsafe int SBmxkshsppDFZPZvftqYxbMuemu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu)) = value;
				}
			}

			// Token: 0x040030DE RID: 12510
			private static readonly IntPtr NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh;

			// Token: 0x040030DF RID: 12511
			private static readonly IntPtr NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs;

			// Token: 0x040030E0 RID: 12512
			private static readonly IntPtr NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu;

			// Token: 0x040030E1 RID: 12513
			private static readonly IntPtr NativeFieldInfoPtr_bmcVHPhFqcClKFnlNjKbtEssOMVv;

			// Token: 0x040030E2 RID: 12514
			private static readonly IntPtr NativeFieldInfoPtr_yJYXnEfdkJNRmdgBKhiaglsvHpUg;

			// Token: 0x040030E3 RID: 12515
			private static readonly IntPtr NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu;

			// Token: 0x040030E4 RID: 12516
			private static readonly IntPtr NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu;

			// Token: 0x040030E5 RID: 12517
			private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

			// Token: 0x040030E6 RID: 12518
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x040030E7 RID: 12519
			private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_CompoundControllerElementType_0;

			// Token: 0x040030E8 RID: 12520
			private static readonly IntPtr NativeMethodInfoPtr_get_hasElements_Public_get_Boolean_0;

			// Token: 0x040030E9 RID: 12521
			private static readonly IntPtr NativeMethodInfoPtr_get_elementCount_Public_get_Int32_0;

			// Token: 0x040030EA RID: 12522
			private static readonly IntPtr NativeMethodInfoPtr_get_elementCapacity_Public_Abstract_Virtual_New_get_Int32_0;

			// Token: 0x040030EB RID: 12523
			private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0;

			// Token: 0x040030EC RID: 12524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_CompoundControllerElementType_0;

			// Token: 0x040030ED RID: 12525
			private static readonly IntPtr NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_Element_Int32_0;

			// Token: 0x040030EE RID: 12526
			private static readonly IntPtr NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_T_Int32_0;

			// Token: 0x040030EF RID: 12527
			private static readonly IntPtr NativeMethodInfoPtr_xAZkgOELHNlJeHgdEyErZxcneWF_Internal_T_Int32_byref_Int32_0;

			// Token: 0x040030F0 RID: 12528
			private static readonly IntPtr NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Boolean_Element_Int32_0;

			// Token: 0x040030F1 RID: 12529
			private static readonly IntPtr NativeMethodInfoPtr_fynaAcbvGTSPmdVEGMobmUIJkKvy_Internal_Boolean_Element_0;

			// Token: 0x040030F2 RID: 12530
			private static readonly IntPtr NativeMethodInfoPtr_tqsrbfolkxBdPzSvMJkFZNmosWB_Internal_Void_0;

			// Token: 0x040030F3 RID: 12531
			private static readonly IntPtr NativeMethodInfoPtr_cDnaXNudHhkGVwNJBkjCspzORSz_Private_Int32_Element_0;

			// Token: 0x040030F4 RID: 12532
			private static readonly IntPtr NativeMethodInfoPtr_eTIYoWTyDUbVxUsjLMGacHHRKmP_Private_Boolean_Element_Int32_Int32_0;

			// Token: 0x040030F5 RID: 12533
			private static readonly IntPtr NativeMethodInfoPtr_DngaJTFclyRdIhdnxSjYNaleatvR_Private_Boolean_Int32_0;

			// Token: 0x040030F6 RID: 12534
			private static readonly IntPtr NativeMethodInfoPtr_OkzuVDKNGElpKHRzbKkWehbPHfM_Private_Int32_0;

			// Token: 0x020004C7 RID: 1223
			public class InnEdrVNqOIjniSXDVLxLPphZck : global::Il2CppSystem.Object
			{
				// Token: 0x0600529A RID: 21146 RVA: 0x00176620 File Offset: 0x00174820
				// Note: this type is marked as 'beforefieldinit'.
				static InnEdrVNqOIjniSXDVLxLPphZck()
				{
					Il2CppClassPointerStore<Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr, "InnEdrVNqOIjniSXDVLxLPphZck");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck>.NativeClassPtr);
					Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck.NativeFieldInfoPtr_GGGVwMYDkxCdXGBbfYmviLbbnxc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck>.NativeClassPtr, "GGGVwMYDkxCdXGBbfYmviLbbnxc");
					Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck.NativeFieldInfoPtr_juGKsGmYeZHIktxrIxnDupwKTXQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck>.NativeClassPtr, "juGKsGmYeZHIktxrIxnDupwKTXQ");
					Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck.NativeMethodInfoPtr__ctor_Public_Void_Element_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck>.NativeClassPtr, 100665331);
				}

				// Token: 0x0600529B RID: 21147 RVA: 0x00176688 File Offset: 0x00174888
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 22674, RefRangeEnd = 22677, XrefRangeStart = 22674, XrefRangeEnd = 22677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe InnEdrVNqOIjniSXDVLxLPphZck(Controller.Element element, int elementIndex)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck.NativeMethodInfoPtr__ctor_Public_Void_Element_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600529C RID: 21148 RVA: 0x0001DDBC File Offset: 0x0001BFBC
				public InnEdrVNqOIjniSXDVLxLPphZck(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001955 RID: 6485
				// (get) Token: 0x0600529D RID: 21149 RVA: 0x001766E4 File Offset: 0x001748E4
				// (set) Token: 0x0600529E RID: 21150 RVA: 0x0001DDC5 File Offset: 0x0001BFC5
				public unsafe Controller.Element GGGVwMYDkxCdXGBbfYmviLbbnxc
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck.NativeFieldInfoPtr_GGGVwMYDkxCdXGBbfYmviLbbnxc);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller.Element>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck.NativeFieldInfoPtr_GGGVwMYDkxCdXGBbfYmviLbbnxc), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001956 RID: 6486
				// (get) Token: 0x0600529F RID: 21151 RVA: 0x00176714 File Offset: 0x00174914
				// (set) Token: 0x060052A0 RID: 21152 RVA: 0x0001DDE4 File Offset: 0x0001BFE4
				public unsafe int juGKsGmYeZHIktxrIxnDupwKTXQ
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck.NativeFieldInfoPtr_juGKsGmYeZHIktxrIxnDupwKTXQ);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.CompoundElement.InnEdrVNqOIjniSXDVLxLPphZck.NativeFieldInfoPtr_juGKsGmYeZHIktxrIxnDupwKTXQ)) = value;
					}
				}

				// Token: 0x0400453C RID: 17724
				private static readonly IntPtr NativeFieldInfoPtr_GGGVwMYDkxCdXGBbfYmviLbbnxc;

				// Token: 0x0400453D RID: 17725
				private static readonly IntPtr NativeFieldInfoPtr_juGKsGmYeZHIktxrIxnDupwKTXQ;

				// Token: 0x0400453E RID: 17726
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Element_Int32_0;
			}

			// Token: 0x020004C8 RID: 1224
			private sealed class MethodInfoStoreGeneric_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_T_Int32_0<T>
			{
				// Token: 0x0400453F RID: 17727
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Controller.CompoundElement.NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_T_Int32_0, Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020004C9 RID: 1225
			private sealed class MethodInfoStoreGeneric_xAZkgOELHNlJeHgdEyErZxcneWF_Internal_T_Int32_byref_Int32_0<T>
			{
				// Token: 0x04004540 RID: 17728
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Controller.CompoundElement.NativeMethodInfoPtr_xAZkgOELHNlJeHgdEyErZxcneWF_Internal_T_Int32_byref_Int32_0, Il2CppClassPointerStore<Controller.CompoundElement>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x0200027A RID: 634
		public sealed class Axis2D : Controller.CompoundElement
		{
			// Token: 0x06003A26 RID: 14886 RVA: 0x0011A028 File Offset: 0x00118228
			// Note: this type is marked as 'beforefieldinit'.
			static Axis2D()
			{
				Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller>.NativeClassPtr, "Axis2D");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr);
				Controller.Axis2D.NativeFieldInfoPtr_fzBpBUjngPBzTSveoDVGlkPWlEi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, "fzBpBUjngPBzTSveoDVGlkPWlEi");
				Controller.Axis2D.NativeFieldInfoPtr_WSxFBMDFFJivjRjllHNxaUsvdXLS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, "WSxFBMDFFJivjRjllHNxaUsvdXLS");
				Controller.Axis2D.NativeMethodInfoPtr_get_elementCapacity_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, 100665332);
				Controller.Axis2D.NativeMethodInfoPtr_get_xAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, 100665333);
				Controller.Axis2D.NativeMethodInfoPtr_get_yAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, 100665334);
				Controller.Axis2D.NativeMethodInfoPtr_get_value_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, 100665335);
				Controller.Axis2D.NativeMethodInfoPtr_get_valuePrev_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, 100665336);
				Controller.Axis2D.NativeMethodInfoPtr_get_valueRaw_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, 100665337);
				Controller.Axis2D.NativeMethodInfoPtr_get_valueRawPrev_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, 100665338);
				Controller.Axis2D.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_Axis_Axis_Int32_Int32_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, 100665339);
				Controller.Axis2D.NativeMethodInfoPtr_GhMrbkYufhVqjfNUBgEdRvaLvMw_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, 100665340);
				Controller.Axis2D.NativeMethodInfoPtr_VPGVraaDwWOPmYdRzUXaMcMXTpB_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, 100665341);
				Controller.Axis2D.NativeMethodInfoPtr_DGppKHsTiqAmOiZWovHGhkfLqma_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr, 100665342);
			}

			// Token: 0x1700116E RID: 4462
			// (get) Token: 0x06003A27 RID: 14887 RVA: 0x0011A158 File Offset: 0x00118358
			public unsafe override int elementCapacity
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis2D.NativeMethodInfoPtr_get_elementCapacity_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700116F RID: 4463
			// (get) Token: 0x06003A28 RID: 14888 RVA: 0x0011A194 File Offset: 0x00118394
			public unsafe Controller.Axis xAxis
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 252954, RefRangeEnd = 252966, XrefRangeStart = 252945, XrefRangeEnd = 252954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis2D.NativeMethodInfoPtr_get_xAxis_Public_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Axis>(intPtr3) : null;
				}
			}

			// Token: 0x17001170 RID: 4464
			// (get) Token: 0x06003A29 RID: 14889 RVA: 0x0011A1D4 File Offset: 0x001183D4
			public unsafe Controller.Axis yAxis
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 252975, RefRangeEnd = 252987, XrefRangeStart = 252966, XrefRangeEnd = 252975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis2D.NativeMethodInfoPtr_get_yAxis_Public_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Axis>(intPtr3) : null;
				}
			}

			// Token: 0x17001171 RID: 4465
			// (get) Token: 0x06003A2A RID: 14890 RVA: 0x0011A214 File Offset: 0x00118414
			public unsafe Vector2 value
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 253004, RefRangeEnd = 253007, XrefRangeStart = 252987, XrefRangeEnd = 253004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis2D.NativeMethodInfoPtr_get_value_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001172 RID: 4466
			// (get) Token: 0x06003A2B RID: 14891 RVA: 0x0011A250 File Offset: 0x00118450
			public unsafe Vector2 valuePrev
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 253024, RefRangeEnd = 253025, XrefRangeStart = 253007, XrefRangeEnd = 253024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis2D.NativeMethodInfoPtr_get_valuePrev_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001173 RID: 4467
			// (get) Token: 0x06003A2C RID: 14892 RVA: 0x0011A28C File Offset: 0x0011848C
			public unsafe Vector2 valueRaw
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253025, XrefRangeEnd = 253036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis2D.NativeMethodInfoPtr_get_valueRaw_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001174 RID: 4468
			// (get) Token: 0x06003A2D RID: 14893 RVA: 0x0011A2C8 File Offset: 0x001184C8
			public unsafe Vector2 valueRawPrev
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253036, XrefRangeEnd = 253047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis2D.NativeMethodInfoPtr_get_valueRawPrev_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A2E RID: 14894 RVA: 0x0011A304 File Offset: 0x00118504
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 253050, RefRangeEnd = 253053, XrefRangeStart = 253047, XrefRangeEnd = 253050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Axis2D(Controller controller, int elementIdentifierId, string name, Controller.Axis xAxis, Controller.Axis yAxis, int xAxisIndex, int yAxisIndex, CalibrationMap calibratonMap)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Axis2D>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xAxis);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(yAxis);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xAxisIndex;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAxisIndex;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(calibratonMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis2D.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_Axis_Axis_Int32_Int32_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A2F RID: 14895 RVA: 0x0011A3C4 File Offset: 0x001185C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253053, XrefRangeEnd = 253060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GhMrbkYufhVqjfNUBgEdRvaLvMw()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis2D.NativeMethodInfoPtr_GhMrbkYufhVqjfNUBgEdRvaLvMw_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A30 RID: 14896 RVA: 0x0011A3F8 File Offset: 0x001185F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253060, XrefRangeEnd = 253072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 VPGVraaDwWOPmYdRzUXaMcMXTpB()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis2D.NativeMethodInfoPtr_VPGVraaDwWOPmYdRzUXaMcMXTpB_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003A31 RID: 14897 RVA: 0x0011A434 File Offset: 0x00118634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253072, XrefRangeEnd = 253084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 DGppKHsTiqAmOiZWovHGhkfLqma()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Axis2D.NativeMethodInfoPtr_DGppKHsTiqAmOiZWovHGhkfLqma_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003A32 RID: 14898 RVA: 0x0001486B File Offset: 0x00012A6B
			public Axis2D(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700116C RID: 4460
			// (get) Token: 0x06003A33 RID: 14899 RVA: 0x0011A470 File Offset: 0x00118670
			// (set) Token: 0x06003A34 RID: 14900 RVA: 0x00014874 File Offset: 0x00012A74
			public unsafe static int fzBpBUjngPBzTSveoDVGlkPWlEi
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Controller.Axis2D.NativeFieldInfoPtr_fzBpBUjngPBzTSveoDVGlkPWlEi, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Controller.Axis2D.NativeFieldInfoPtr_fzBpBUjngPBzTSveoDVGlkPWlEi, (void*)(&value));
				}
			}

			// Token: 0x1700116D RID: 4461
			// (get) Token: 0x06003A35 RID: 14901 RVA: 0x0011A48C File Offset: 0x0011868C
			// (set) Token: 0x06003A36 RID: 14902 RVA: 0x00014882 File Offset: 0x00012A82
			public unsafe CalibrationMap WSxFBMDFFJivjRjllHNxaUsvdXLS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis2D.NativeFieldInfoPtr_WSxFBMDFFJivjRjllHNxaUsvdXLS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CalibrationMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Axis2D.NativeFieldInfoPtr_WSxFBMDFFJivjRjllHNxaUsvdXLS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040030F7 RID: 12535
			private static readonly IntPtr NativeFieldInfoPtr_fzBpBUjngPBzTSveoDVGlkPWlEi;

			// Token: 0x040030F8 RID: 12536
			private static readonly IntPtr NativeFieldInfoPtr_WSxFBMDFFJivjRjllHNxaUsvdXLS;

			// Token: 0x040030F9 RID: 12537
			private static readonly IntPtr NativeMethodInfoPtr_get_elementCapacity_Public_Virtual_get_Int32_0;

			// Token: 0x040030FA RID: 12538
			private static readonly IntPtr NativeMethodInfoPtr_get_xAxis_Public_get_Axis_0;

			// Token: 0x040030FB RID: 12539
			private static readonly IntPtr NativeMethodInfoPtr_get_yAxis_Public_get_Axis_0;

			// Token: 0x040030FC RID: 12540
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Vector2_0;

			// Token: 0x040030FD RID: 12541
			private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_get_Vector2_0;

			// Token: 0x040030FE RID: 12542
			private static readonly IntPtr NativeMethodInfoPtr_get_valueRaw_Public_get_Vector2_0;

			// Token: 0x040030FF RID: 12543
			private static readonly IntPtr NativeMethodInfoPtr_get_valueRawPrev_Public_get_Vector2_0;

			// Token: 0x04003100 RID: 12544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_Axis_Axis_Int32_Int32_CalibrationMap_0;

			// Token: 0x04003101 RID: 12545
			private static readonly IntPtr NativeMethodInfoPtr_GhMrbkYufhVqjfNUBgEdRvaLvMw_Internal_Void_0;

			// Token: 0x04003102 RID: 12546
			private static readonly IntPtr NativeMethodInfoPtr_VPGVraaDwWOPmYdRzUXaMcMXTpB_Private_Vector2_0;

			// Token: 0x04003103 RID: 12547
			private static readonly IntPtr NativeMethodInfoPtr_DGppKHsTiqAmOiZWovHGhkfLqma_Private_Vector2_0;
		}

		// Token: 0x0200027B RID: 635
		public sealed class Hat : Controller.CompoundElement
		{
			// Token: 0x06003A37 RID: 14903 RVA: 0x0011A4BC File Offset: 0x001186BC
			// Note: this type is marked as 'beforefieldinit'.
			static Hat()
			{
				Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller>.NativeClassPtr, "Hat");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr);
				Controller.Hat.NativeFieldInfoPtr_fzBpBUjngPBzTSveoDVGlkPWlEi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "fzBpBUjngPBzTSveoDVGlkPWlEi");
				Controller.Hat.NativeFieldInfoPtr_WkXUZjVbqGeiidqYrpmLtZDDKBF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "WkXUZjVbqGeiidqYrpmLtZDDKBF");
				Controller.Hat.NativeFieldInfoPtr_tjFaQmecUqCdukeGXoQSwIdfswt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "tjFaQmecUqCdukeGXoQSwIdfswt");
				Controller.Hat.NativeFieldInfoPtr_AXOsOdKSPzxeoOGWhvVFBKKunnm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "AXOsOdKSPzxeoOGWhvVFBKKunnm");
				Controller.Hat.NativeFieldInfoPtr_dcEqVACdQBicgPRbrgsprkUIdiIk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "dcEqVACdQBicgPRbrgsprkUIdiIk");
				Controller.Hat.NativeFieldInfoPtr_GTwweAutxkLSNlXHjdYrhPAPeWg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "GTwweAutxkLSNlXHjdYrhPAPeWg");
				Controller.Hat.NativeFieldInfoPtr_IoECjzOgZmMfZRRCfGilXuUQKaQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "IoECjzOgZmMfZRRCfGilXuUQKaQ");
				Controller.Hat.NativeFieldInfoPtr_KDGelYKKyRQwNtiULdbqOWwcDpW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "KDGelYKKyRQwNtiULdbqOWwcDpW");
				Controller.Hat.NativeFieldInfoPtr_nnertcJsGpZBTLeMmHpJFwhdMWy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "nnertcJsGpZBTLeMmHpJFwhdMWy");
				Controller.Hat.NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "AHoQaCqgIOGogOpDnwRoZuWfUKU");
				Controller.Hat.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "GuxtgegCZiWJDenlSEVuDZKGNKPu");
				Controller.Hat.NativeFieldInfoPtr_bCnIdwtMnlRDGfFrrxrzizULGlv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "bCnIdwtMnlRDGfFrrxrzizULGlv");
				Controller.Hat.NativeFieldInfoPtr_sSOCwOiujaAiAzCqAeovmWAtkKX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "sSOCwOiujaAiAzCqAeovmWAtkKX");
				Controller.Hat.NativeFieldInfoPtr_UzLmzNiQkmTZhbKSQrFgOiPkZGg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, "UzLmzNiQkmTZhbKSQrFgOiPkZGg");
				Controller.Hat.NativeMethodInfoPtr_get_elementCapacity_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665343);
				Controller.Hat.NativeMethodInfoPtr_get_force4Way_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665344);
				Controller.Hat.NativeMethodInfoPtr_set_force4Way_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665345);
				Controller.Hat.NativeMethodInfoPtr_get_directionCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665346);
				Controller.Hat.NativeMethodInfoPtr_get_Buttons_Public_get_IList_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665347);
				Controller.Hat.NativeMethodInfoPtr_get_buttonUp_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665348);
				Controller.Hat.NativeMethodInfoPtr_get_buttonRight_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665349);
				Controller.Hat.NativeMethodInfoPtr_get_buttonDown_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665350);
				Controller.Hat.NativeMethodInfoPtr_get_buttonLeft_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665351);
				Controller.Hat.NativeMethodInfoPtr_get_buttonUpRight_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665352);
				Controller.Hat.NativeMethodInfoPtr_get_buttonDownRight_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665353);
				Controller.Hat.NativeMethodInfoPtr_get_buttonDownLeft_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665354);
				Controller.Hat.NativeMethodInfoPtr_get_buttonUpLeft_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665355);
				Controller.Hat.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_Il2CppReferenceArray_1_Button_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665356);
				Controller.Hat.NativeMethodInfoPtr_GhMrbkYufhVqjfNUBgEdRvaLvMw_Internal_Void_UpdateLoopType_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665357);
				Controller.Hat.NativeMethodInfoPtr_tEZZQFMFQyXzgFdVHANZtAoULQA_Private_Void_Button_Int32_Int32_Int32_UpdateLoopType_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665358);
				Controller.Hat.NativeMethodInfoPtr_aoHGXFYTSBLsplaprRRnvaawtoj_Private_Void_Button_Int32_UpdateLoopType_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr, 100665359);
			}

			// Token: 0x17001183 RID: 4483
			// (get) Token: 0x06003A38 RID: 14904 RVA: 0x0011A754 File Offset: 0x00118954
			public unsafe override int elementCapacity
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_elementCapacity_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001184 RID: 4484
			// (get) Token: 0x06003A39 RID: 14905 RVA: 0x0011A790 File Offset: 0x00118990
			// (set) Token: 0x06003A3A RID: 14906 RVA: 0x0011A7CC File Offset: 0x001189CC
			public unsafe bool force4Way
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253084, XrefRangeEnd = 253088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_force4Way_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253088, XrefRangeEnd = 253092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_set_force4Way_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001185 RID: 4485
			// (get) Token: 0x06003A3B RID: 14907 RVA: 0x0011A80C File Offset: 0x00118A0C
			public unsafe int directionCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253092, XrefRangeEnd = 253096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_directionCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001186 RID: 4486
			// (get) Token: 0x06003A3C RID: 14908 RVA: 0x0011A848 File Offset: 0x00118A48
			public unsafe IList<Controller.Button> Buttons
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253096, XrefRangeEnd = 253101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_Buttons_Public_get_IList_1_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Controller.Button>>(intPtr3) : null;
				}
			}

			// Token: 0x17001187 RID: 4487
			// (get) Token: 0x06003A3D RID: 14909 RVA: 0x0011A888 File Offset: 0x00118A88
			public unsafe Controller.Button buttonUp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253101, XrefRangeEnd = 253110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_buttonUp_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Button>(intPtr3) : null;
				}
			}

			// Token: 0x17001188 RID: 4488
			// (get) Token: 0x06003A3E RID: 14910 RVA: 0x0011A8C8 File Offset: 0x00118AC8
			public unsafe Controller.Button buttonRight
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253110, XrefRangeEnd = 253119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_buttonRight_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Button>(intPtr3) : null;
				}
			}

			// Token: 0x17001189 RID: 4489
			// (get) Token: 0x06003A3F RID: 14911 RVA: 0x0011A908 File Offset: 0x00118B08
			public unsafe Controller.Button buttonDown
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253119, XrefRangeEnd = 253128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_buttonDown_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Button>(intPtr3) : null;
				}
			}

			// Token: 0x1700118A RID: 4490
			// (get) Token: 0x06003A40 RID: 14912 RVA: 0x0011A948 File Offset: 0x00118B48
			public unsafe Controller.Button buttonLeft
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253128, XrefRangeEnd = 253137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_buttonLeft_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Button>(intPtr3) : null;
				}
			}

			// Token: 0x1700118B RID: 4491
			// (get) Token: 0x06003A41 RID: 14913 RVA: 0x0011A988 File Offset: 0x00118B88
			public unsafe Controller.Button buttonUpRight
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253137, XrefRangeEnd = 253146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_buttonUpRight_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Button>(intPtr3) : null;
				}
			}

			// Token: 0x1700118C RID: 4492
			// (get) Token: 0x06003A42 RID: 14914 RVA: 0x0011A9C8 File Offset: 0x00118BC8
			public unsafe Controller.Button buttonDownRight
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253146, XrefRangeEnd = 253155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_buttonDownRight_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Button>(intPtr3) : null;
				}
			}

			// Token: 0x1700118D RID: 4493
			// (get) Token: 0x06003A43 RID: 14915 RVA: 0x0011AA08 File Offset: 0x00118C08
			public unsafe Controller.Button buttonDownLeft
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253155, XrefRangeEnd = 253164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_buttonDownLeft_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Button>(intPtr3) : null;
				}
			}

			// Token: 0x1700118E RID: 4494
			// (get) Token: 0x06003A44 RID: 14916 RVA: 0x0011AA48 File Offset: 0x00118C48
			public unsafe Controller.Button buttonUpLeft
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253164, XrefRangeEnd = 253173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_get_buttonUpLeft_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Button>(intPtr3) : null;
				}
			}

			// Token: 0x06003A45 RID: 14917 RVA: 0x0011AA88 File Offset: 0x00118C88
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 253181, RefRangeEnd = 253183, XrefRangeStart = 253173, XrefRangeEnd = 253181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Hat(Controller controller, int elementIdentifierId, string name, Il2CppReferenceArray<Controller.Button> buttons, Il2CppStructArray<int> buttonIndices)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Hat>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttonIndices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_Il2CppReferenceArray_1_Button_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A46 RID: 14918 RVA: 0x0011AB1C File Offset: 0x00118D1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 253195, RefRangeEnd = 253196, XrefRangeStart = 253183, XrefRangeEnd = 253195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GhMrbkYufhVqjfNUBgEdRvaLvMw(UpdateLoopType A_1, ControllerDataUpdater A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_GhMrbkYufhVqjfNUBgEdRvaLvMw_Internal_Void_UpdateLoopType_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A47 RID: 14919 RVA: 0x0011AB6C File Offset: 0x00118D6C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 253201, RefRangeEnd = 253205, XrefRangeStart = 253196, XrefRangeEnd = 253201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void tEZZQFMFQyXzgFdVHANZtAoULQA(Controller.Button A_1, int A_2, int A_3, int A_4, UpdateLoopType A_5, ControllerDataUpdater A_6)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_5;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_6);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_tEZZQFMFQyXzgFdVHANZtAoULQA_Private_Void_Button_Int32_Int32_Int32_UpdateLoopType_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A48 RID: 14920 RVA: 0x0011ABFC File Offset: 0x00118DFC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 253208, RefRangeEnd = 253212, XrefRangeStart = 253205, XrefRangeEnd = 253208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void aoHGXFYTSBLsplaprRRnvaawtoj(Controller.Button A_1, int A_2, UpdateLoopType A_3, ControllerDataUpdater A_4)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Hat.NativeMethodInfoPtr_aoHGXFYTSBLsplaprRRnvaawtoj_Private_Void_Button_Int32_UpdateLoopType_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A49 RID: 14921 RVA: 0x000148A1 File Offset: 0x00012AA1
			public Hat(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001175 RID: 4469
			// (get) Token: 0x06003A4A RID: 14922 RVA: 0x0011AC70 File Offset: 0x00118E70
			// (set) Token: 0x06003A4B RID: 14923 RVA: 0x000148AA File Offset: 0x00012AAA
			public unsafe static int fzBpBUjngPBzTSveoDVGlkPWlEi
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Controller.Hat.NativeFieldInfoPtr_fzBpBUjngPBzTSveoDVGlkPWlEi, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Controller.Hat.NativeFieldInfoPtr_fzBpBUjngPBzTSveoDVGlkPWlEi, (void*)(&value));
				}
			}

			// Token: 0x17001176 RID: 4470
			// (get) Token: 0x06003A4C RID: 14924 RVA: 0x0011AC8C File Offset: 0x00118E8C
			// (set) Token: 0x06003A4D RID: 14925 RVA: 0x000148B8 File Offset: 0x00012AB8
			public unsafe static int WkXUZjVbqGeiidqYrpmLtZDDKBF
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Controller.Hat.NativeFieldInfoPtr_WkXUZjVbqGeiidqYrpmLtZDDKBF, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Controller.Hat.NativeFieldInfoPtr_WkXUZjVbqGeiidqYrpmLtZDDKBF, (void*)(&value));
				}
			}

			// Token: 0x17001177 RID: 4471
			// (get) Token: 0x06003A4E RID: 14926 RVA: 0x0011ACA8 File Offset: 0x00118EA8
			// (set) Token: 0x06003A4F RID: 14927 RVA: 0x000148C6 File Offset: 0x00012AC6
			public unsafe static int tjFaQmecUqCdukeGXoQSwIdfswt
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Controller.Hat.NativeFieldInfoPtr_tjFaQmecUqCdukeGXoQSwIdfswt, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Controller.Hat.NativeFieldInfoPtr_tjFaQmecUqCdukeGXoQSwIdfswt, (void*)(&value));
				}
			}

			// Token: 0x17001178 RID: 4472
			// (get) Token: 0x06003A50 RID: 14928 RVA: 0x0011ACC4 File Offset: 0x00118EC4
			// (set) Token: 0x06003A51 RID: 14929 RVA: 0x000148D4 File Offset: 0x00012AD4
			public unsafe static int AXOsOdKSPzxeoOGWhvVFBKKunnm
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Controller.Hat.NativeFieldInfoPtr_AXOsOdKSPzxeoOGWhvVFBKKunnm, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Controller.Hat.NativeFieldInfoPtr_AXOsOdKSPzxeoOGWhvVFBKKunnm, (void*)(&value));
				}
			}

			// Token: 0x17001179 RID: 4473
			// (get) Token: 0x06003A52 RID: 14930 RVA: 0x0011ACE0 File Offset: 0x00118EE0
			// (set) Token: 0x06003A53 RID: 14931 RVA: 0x000148E2 File Offset: 0x00012AE2
			public unsafe static int dcEqVACdQBicgPRbrgsprkUIdiIk
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Controller.Hat.NativeFieldInfoPtr_dcEqVACdQBicgPRbrgsprkUIdiIk, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Controller.Hat.NativeFieldInfoPtr_dcEqVACdQBicgPRbrgsprkUIdiIk, (void*)(&value));
				}
			}

			// Token: 0x1700117A RID: 4474
			// (get) Token: 0x06003A54 RID: 14932 RVA: 0x0011ACFC File Offset: 0x00118EFC
			// (set) Token: 0x06003A55 RID: 14933 RVA: 0x000148F0 File Offset: 0x00012AF0
			public unsafe static int GTwweAutxkLSNlXHjdYrhPAPeWg
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Controller.Hat.NativeFieldInfoPtr_GTwweAutxkLSNlXHjdYrhPAPeWg, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Controller.Hat.NativeFieldInfoPtr_GTwweAutxkLSNlXHjdYrhPAPeWg, (void*)(&value));
				}
			}

			// Token: 0x1700117B RID: 4475
			// (get) Token: 0x06003A56 RID: 14934 RVA: 0x0011AD18 File Offset: 0x00118F18
			// (set) Token: 0x06003A57 RID: 14935 RVA: 0x000148FE File Offset: 0x00012AFE
			public unsafe static int IoECjzOgZmMfZRRCfGilXuUQKaQ
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Controller.Hat.NativeFieldInfoPtr_IoECjzOgZmMfZRRCfGilXuUQKaQ, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Controller.Hat.NativeFieldInfoPtr_IoECjzOgZmMfZRRCfGilXuUQKaQ, (void*)(&value));
				}
			}

			// Token: 0x1700117C RID: 4476
			// (get) Token: 0x06003A58 RID: 14936 RVA: 0x0011AD34 File Offset: 0x00118F34
			// (set) Token: 0x06003A59 RID: 14937 RVA: 0x0001490C File Offset: 0x00012B0C
			public unsafe static int KDGelYKKyRQwNtiULdbqOWwcDpW
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Controller.Hat.NativeFieldInfoPtr_KDGelYKKyRQwNtiULdbqOWwcDpW, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Controller.Hat.NativeFieldInfoPtr_KDGelYKKyRQwNtiULdbqOWwcDpW, (void*)(&value));
				}
			}

			// Token: 0x1700117D RID: 4477
			// (get) Token: 0x06003A5A RID: 14938 RVA: 0x0011AD50 File Offset: 0x00118F50
			// (set) Token: 0x06003A5B RID: 14939 RVA: 0x0001491A File Offset: 0x00012B1A
			public unsafe static int nnertcJsGpZBTLeMmHpJFwhdMWy
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Controller.Hat.NativeFieldInfoPtr_nnertcJsGpZBTLeMmHpJFwhdMWy, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Controller.Hat.NativeFieldInfoPtr_nnertcJsGpZBTLeMmHpJFwhdMWy, (void*)(&value));
				}
			}

			// Token: 0x1700117E RID: 4478
			// (get) Token: 0x06003A5C RID: 14940 RVA: 0x0011AD6C File Offset: 0x00118F6C
			// (set) Token: 0x06003A5D RID: 14941 RVA: 0x00014928 File Offset: 0x00012B28
			public unsafe int AHoQaCqgIOGogOpDnwRoZuWfUKU
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Hat.NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Hat.NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU)) = value;
				}
			}

			// Token: 0x1700117F RID: 4479
			// (get) Token: 0x06003A5E RID: 14942 RVA: 0x0011AD94 File Offset: 0x00118F94
			// (set) Token: 0x06003A5F RID: 14943 RVA: 0x00014943 File Offset: 0x00012B43
			public unsafe Il2CppReferenceArray<Controller.Button> GuxtgegCZiWJDenlSEVuDZKGNKPu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Hat.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Controller.Button>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Hat.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001180 RID: 4480
			// (get) Token: 0x06003A60 RID: 14944 RVA: 0x0011ADC4 File Offset: 0x00118FC4
			// (set) Token: 0x06003A61 RID: 14945 RVA: 0x00014962 File Offset: 0x00012B62
			public unsafe ReadOnlyCollection<Controller.Button> bCnIdwtMnlRDGfFrrxrzizULGlv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Hat.NativeFieldInfoPtr_bCnIdwtMnlRDGfFrrxrzizULGlv);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Controller.Button>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Hat.NativeFieldInfoPtr_bCnIdwtMnlRDGfFrrxrzizULGlv), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001181 RID: 4481
			// (get) Token: 0x06003A62 RID: 14946 RVA: 0x0011ADF4 File Offset: 0x00118FF4
			// (set) Token: 0x06003A63 RID: 14947 RVA: 0x00014981 File Offset: 0x00012B81
			public unsafe Il2CppStructArray<int> sSOCwOiujaAiAzCqAeovmWAtkKX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Hat.NativeFieldInfoPtr_sSOCwOiujaAiAzCqAeovmWAtkKX);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Hat.NativeFieldInfoPtr_sSOCwOiujaAiAzCqAeovmWAtkKX), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001182 RID: 4482
			// (get) Token: 0x06003A64 RID: 14948 RVA: 0x0011AE24 File Offset: 0x00119024
			// (set) Token: 0x06003A65 RID: 14949 RVA: 0x000149A0 File Offset: 0x00012BA0
			public unsafe bool UzLmzNiQkmTZhbKSQrFgOiPkZGg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Hat.NativeFieldInfoPtr_UzLmzNiQkmTZhbKSQrFgOiPkZGg);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Hat.NativeFieldInfoPtr_UzLmzNiQkmTZhbKSQrFgOiPkZGg)) = value;
				}
			}

			// Token: 0x04003104 RID: 12548
			private static readonly IntPtr NativeFieldInfoPtr_fzBpBUjngPBzTSveoDVGlkPWlEi;

			// Token: 0x04003105 RID: 12549
			private static readonly IntPtr NativeFieldInfoPtr_WkXUZjVbqGeiidqYrpmLtZDDKBF;

			// Token: 0x04003106 RID: 12550
			private static readonly IntPtr NativeFieldInfoPtr_tjFaQmecUqCdukeGXoQSwIdfswt;

			// Token: 0x04003107 RID: 12551
			private static readonly IntPtr NativeFieldInfoPtr_AXOsOdKSPzxeoOGWhvVFBKKunnm;

			// Token: 0x04003108 RID: 12552
			private static readonly IntPtr NativeFieldInfoPtr_dcEqVACdQBicgPRbrgsprkUIdiIk;

			// Token: 0x04003109 RID: 12553
			private static readonly IntPtr NativeFieldInfoPtr_GTwweAutxkLSNlXHjdYrhPAPeWg;

			// Token: 0x0400310A RID: 12554
			private static readonly IntPtr NativeFieldInfoPtr_IoECjzOgZmMfZRRCfGilXuUQKaQ;

			// Token: 0x0400310B RID: 12555
			private static readonly IntPtr NativeFieldInfoPtr_KDGelYKKyRQwNtiULdbqOWwcDpW;

			// Token: 0x0400310C RID: 12556
			private static readonly IntPtr NativeFieldInfoPtr_nnertcJsGpZBTLeMmHpJFwhdMWy;

			// Token: 0x0400310D RID: 12557
			private static readonly IntPtr NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU;

			// Token: 0x0400310E RID: 12558
			private static readonly IntPtr NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu;

			// Token: 0x0400310F RID: 12559
			private static readonly IntPtr NativeFieldInfoPtr_bCnIdwtMnlRDGfFrrxrzizULGlv;

			// Token: 0x04003110 RID: 12560
			private static readonly IntPtr NativeFieldInfoPtr_sSOCwOiujaAiAzCqAeovmWAtkKX;

			// Token: 0x04003111 RID: 12561
			private static readonly IntPtr NativeFieldInfoPtr_UzLmzNiQkmTZhbKSQrFgOiPkZGg;

			// Token: 0x04003112 RID: 12562
			private static readonly IntPtr NativeMethodInfoPtr_get_elementCapacity_Public_Virtual_get_Int32_0;

			// Token: 0x04003113 RID: 12563
			private static readonly IntPtr NativeMethodInfoPtr_get_force4Way_Public_get_Boolean_0;

			// Token: 0x04003114 RID: 12564
			private static readonly IntPtr NativeMethodInfoPtr_set_force4Way_Public_set_Void_Boolean_0;

			// Token: 0x04003115 RID: 12565
			private static readonly IntPtr NativeMethodInfoPtr_get_directionCount_Public_get_Int32_0;

			// Token: 0x04003116 RID: 12566
			private static readonly IntPtr NativeMethodInfoPtr_get_Buttons_Public_get_IList_1_Button_0;

			// Token: 0x04003117 RID: 12567
			private static readonly IntPtr NativeMethodInfoPtr_get_buttonUp_Public_get_Button_0;

			// Token: 0x04003118 RID: 12568
			private static readonly IntPtr NativeMethodInfoPtr_get_buttonRight_Public_get_Button_0;

			// Token: 0x04003119 RID: 12569
			private static readonly IntPtr NativeMethodInfoPtr_get_buttonDown_Public_get_Button_0;

			// Token: 0x0400311A RID: 12570
			private static readonly IntPtr NativeMethodInfoPtr_get_buttonLeft_Public_get_Button_0;

			// Token: 0x0400311B RID: 12571
			private static readonly IntPtr NativeMethodInfoPtr_get_buttonUpRight_Public_get_Button_0;

			// Token: 0x0400311C RID: 12572
			private static readonly IntPtr NativeMethodInfoPtr_get_buttonDownRight_Public_get_Button_0;

			// Token: 0x0400311D RID: 12573
			private static readonly IntPtr NativeMethodInfoPtr_get_buttonDownLeft_Public_get_Button_0;

			// Token: 0x0400311E RID: 12574
			private static readonly IntPtr NativeMethodInfoPtr_get_buttonUpLeft_Public_get_Button_0;

			// Token: 0x0400311F RID: 12575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Controller_Int32_String_Il2CppReferenceArray_1_Button_Il2CppStructArray_1_Int32_0;

			// Token: 0x04003120 RID: 12576
			private static readonly IntPtr NativeMethodInfoPtr_GhMrbkYufhVqjfNUBgEdRvaLvMw_Internal_Void_UpdateLoopType_ControllerDataUpdater_0;

			// Token: 0x04003121 RID: 12577
			private static readonly IntPtr NativeMethodInfoPtr_tEZZQFMFQyXzgFdVHANZtAoULQA_Private_Void_Button_Int32_Int32_Int32_UpdateLoopType_ControllerDataUpdater_0;

			// Token: 0x04003122 RID: 12578
			private static readonly IntPtr NativeMethodInfoPtr_aoHGXFYTSBLsplaprRRnvaawtoj_Private_Void_Button_Int32_UpdateLoopType_ControllerDataUpdater_0;
		}

		// Token: 0x0200027C RID: 636
		public class Extension : global::Il2CppSystem.Object
		{
			// Token: 0x06003A66 RID: 14950 RVA: 0x0011AE4C File Offset: 0x0011904C
			// Note: this type is marked as 'beforefieldinit'.
			static Extension()
			{
				Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller>.NativeClassPtr, "Extension");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr);
				Controller.Extension.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, "egOPTGwnsPnUJWHsXfaRAFkRlvOu");
				Controller.Extension.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, "qtbpemUQyoPTMaHrxCYIFOqVxvz");
				Controller.Extension.NativeFieldInfoPtr__reInputId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, "_reInputId");
				Controller.Extension.NativeMethodInfoPtr_get_isJoystickConnected_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665360);
				Controller.Extension.NativeMethodInfoPtr_get_enabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665361);
				Controller.Extension.NativeMethodInfoPtr_get_controller_Internal_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665362);
				Controller.Extension.NativeMethodInfoPtr__ctor_Internal_Void_IControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665363);
				Controller.Extension.NativeMethodInfoPtr__ctor_Internal_Void_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665364);
				Controller.Extension.NativeMethodInfoPtr_GetController_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665365);
				Controller.Extension.NativeMethodInfoPtr_SetController_Internal_Void_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665366);
				Controller.Extension.NativeMethodInfoPtr_GetSource_Internal_IControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665367);
				Controller.Extension.NativeMethodInfoPtr_SetSource_Internal_Void_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665368);
				Controller.Extension.NativeMethodInfoPtr_OiZFMkHlTPjihGJCQqjejHFcLCE_Private_Void_IControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665369);
				Controller.Extension.NativeMethodInfoPtr_Clear_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665370);
				Controller.Extension.NativeMethodInfoPtr_SourceUpdated_Internal_Abstract_Virtual_New_Void_IControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665371);
				Controller.Extension.NativeMethodInfoPtr_UpdateData_Internal_Abstract_Virtual_New_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665372);
				Controller.Extension.NativeMethodInfoPtr_Clone_Internal_Abstract_Virtual_New_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr, 100665373);
			}

			// Token: 0x17001192 RID: 4498
			// (get) Token: 0x06003A67 RID: 14951 RVA: 0x0011AFCC File Offset: 0x001191CC
			public unsafe bool isJoystickConnected
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Extension.NativeMethodInfoPtr_get_isJoystickConnected_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001193 RID: 4499
			// (get) Token: 0x06003A68 RID: 14952 RVA: 0x0011B008 File Offset: 0x00119208
			public unsafe bool enabled
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253212, XrefRangeEnd = 253213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Extension.NativeMethodInfoPtr_get_enabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001194 RID: 4500
			// (get) Token: 0x06003A69 RID: 14953 RVA: 0x0011B044 File Offset: 0x00119244
			public unsafe Controller controller
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Extension.NativeMethodInfoPtr_get_controller_Internal_get_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
				}
			}

			// Token: 0x06003A6A RID: 14954 RVA: 0x0011B084 File Offset: 0x00119284
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 253218, RefRangeEnd = 253235, XrefRangeStart = 253213, XrefRangeEnd = 253218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Extension(IControllerExtensionSource source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Extension.NativeMethodInfoPtr__ctor_Internal_Void_IControllerExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003A6B RID: 14955 RVA: 0x0011B0D0 File Offset: 0x001192D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253235, XrefRangeEnd = 253236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Extension(Controller.Extension source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Extension.NativeMethodInfoPtr__ctor_Internal_Void_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003A6C RID: 14956 RVA: 0x0011B11C File Offset: 0x0011931C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253236, XrefRangeEnd = 253239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T GetController<T>() where T : Controller
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Extension.MethodInfoStoreGeneric_GetController_Internal_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06003A6D RID: 14957 RVA: 0x0011B158 File Offset: 0x00119358
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetController(Controller controller)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Extension.NativeMethodInfoPtr_SetController_Internal_Void_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003A6E RID: 14958 RVA: 0x0011B19C File Offset: 0x0011939C
			[CallerCount(0)]
			public unsafe IControllerExtensionSource GetSource()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Extension.NativeMethodInfoPtr_GetSource_Internal_IControllerExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerExtensionSource>(intPtr3) : null;
			}

			// Token: 0x06003A6F RID: 14959 RVA: 0x0011B1DC File Offset: 0x001193DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253239, XrefRangeEnd = 253240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetSource(Controller.Extension extension)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Extension.NativeMethodInfoPtr_SetSource_Internal_Void_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003A70 RID: 14960 RVA: 0x0011B220 File Offset: 0x00119420
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 253240, RefRangeEnd = 253243, XrefRangeStart = 253240, XrefRangeEnd = 253240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OiZFMkHlTPjihGJCQqjejHFcLCE(IControllerExtensionSource A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.Extension.NativeMethodInfoPtr_OiZFMkHlTPjihGJCQqjejHFcLCE_Private_Void_IControllerExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003A71 RID: 14961 RVA: 0x0011B264 File Offset: 0x00119464
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.Extension.NativeMethodInfoPtr_Clear_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A72 RID: 14962 RVA: 0x0011B2A0 File Offset: 0x001194A0
			[CallerCount(0)]
			public unsafe virtual void SourceUpdated(IControllerExtensionSource source)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.Extension.NativeMethodInfoPtr_SourceUpdated_Internal_Abstract_Virtual_New_Void_IControllerExtensionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003A73 RID: 14963 RVA: 0x0011B2F0 File Offset: 0x001194F0
			[CallerCount(0)]
			public unsafe virtual void UpdateData(UpdateLoopType updateLoop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref updateLoop;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.Extension.NativeMethodInfoPtr_UpdateData_Internal_Abstract_Virtual_New_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003A74 RID: 14964 RVA: 0x0011B33C File Offset: 0x0011953C
			[CallerCount(0)]
			public unsafe virtual Controller.Extension Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Controller.Extension.NativeMethodInfoPtr_Clone_Internal_Abstract_Virtual_New_Extension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
			}

			// Token: 0x06003A75 RID: 14965 RVA: 0x000149BB File Offset: 0x00012BBB
			public Extension(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700118F RID: 4495
			// (get) Token: 0x06003A76 RID: 14966 RVA: 0x0011B388 File Offset: 0x00119588
			// (set) Token: 0x06003A77 RID: 14967 RVA: 0x000149C4 File Offset: 0x00012BC4
			public unsafe Controller egOPTGwnsPnUJWHsXfaRAFkRlvOu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Extension.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Extension.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001190 RID: 4496
			// (get) Token: 0x06003A78 RID: 14968 RVA: 0x0011B3B8 File Offset: 0x001195B8
			// (set) Token: 0x06003A79 RID: 14969 RVA: 0x000149E3 File Offset: 0x00012BE3
			public unsafe IControllerExtensionSource qtbpemUQyoPTMaHrxCYIFOqVxvz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Extension.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IControllerExtensionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Extension.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001191 RID: 4497
			// (get) Token: 0x06003A7A RID: 14970 RVA: 0x0011B3E8 File Offset: 0x001195E8
			// (set) Token: 0x06003A7B RID: 14971 RVA: 0x00014A02 File Offset: 0x00012C02
			public unsafe int _reInputId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Extension.NativeFieldInfoPtr__reInputId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.Extension.NativeFieldInfoPtr__reInputId)) = value;
				}
			}

			// Token: 0x04003123 RID: 12579
			private static readonly IntPtr NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu;

			// Token: 0x04003124 RID: 12580
			private static readonly IntPtr NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz;

			// Token: 0x04003125 RID: 12581
			private static readonly IntPtr NativeFieldInfoPtr__reInputId;

			// Token: 0x04003126 RID: 12582
			private static readonly IntPtr NativeMethodInfoPtr_get_isJoystickConnected_Internal_get_Boolean_0;

			// Token: 0x04003127 RID: 12583
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Internal_get_Boolean_0;

			// Token: 0x04003128 RID: 12584
			private static readonly IntPtr NativeMethodInfoPtr_get_controller_Internal_get_Controller_0;

			// Token: 0x04003129 RID: 12585
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IControllerExtensionSource_0;

			// Token: 0x0400312A RID: 12586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Extension_0;

			// Token: 0x0400312B RID: 12587
			private static readonly IntPtr NativeMethodInfoPtr_GetController_Internal_T_0;

			// Token: 0x0400312C RID: 12588
			private static readonly IntPtr NativeMethodInfoPtr_SetController_Internal_Void_Controller_0;

			// Token: 0x0400312D RID: 12589
			private static readonly IntPtr NativeMethodInfoPtr_GetSource_Internal_IControllerExtensionSource_0;

			// Token: 0x0400312E RID: 12590
			private static readonly IntPtr NativeMethodInfoPtr_SetSource_Internal_Void_Extension_0;

			// Token: 0x0400312F RID: 12591
			private static readonly IntPtr NativeMethodInfoPtr_OiZFMkHlTPjihGJCQqjejHFcLCE_Private_Void_IControllerExtensionSource_0;

			// Token: 0x04003130 RID: 12592
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Virtual_New_Void_0;

			// Token: 0x04003131 RID: 12593
			private static readonly IntPtr NativeMethodInfoPtr_SourceUpdated_Internal_Abstract_Virtual_New_Void_IControllerExtensionSource_0;

			// Token: 0x04003132 RID: 12594
			private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Internal_Abstract_Virtual_New_Void_UpdateLoopType_0;

			// Token: 0x04003133 RID: 12595
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Abstract_Virtual_New_Extension_0;

			// Token: 0x020004CA RID: 1226
			private sealed class MethodInfoStoreGeneric_GetController_Internal_T_0<T>
			{
				// Token: 0x04004541 RID: 17729
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Controller.Extension.NativeMethodInfoPtr_GetController_Internal_T_0, Il2CppClassPointerStore<Controller.Extension>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x0200027D RID: 637
		public sealed class DTgcZICwceHqACLGnmvOYCwiRbk : global::Il2CppSystem.Object
		{
			// Token: 0x06003A7C RID: 14972 RVA: 0x0011B410 File Offset: 0x00119610
			// Note: this type is marked as 'beforefieldinit'.
			static DTgcZICwceHqACLGnmvOYCwiRbk()
			{
				Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller>.NativeClassPtr, "DTgcZICwceHqACLGnmvOYCwiRbk");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr);
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, "kUBcJcFfgoKKiApkBmiZbFhcTlkZ");
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_xFLzBQRXYlihrqYQXvPnLOQJuIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, "xFLzBQRXYlihrqYQXvPnLOQJuIs");
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, 100665374);
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, 100665375);
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, 100665376);
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, 100665377);
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, 100665378);
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, 100665379);
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, 100665380);
				Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr, 100665381);
			}

			// Token: 0x06003A7D RID: 14973 RVA: 0x0011B554 File Offset: 0x00119754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253243, XrefRangeEnd = 253246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerPollingInfo> System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerPollingInfo>>(intPtr3) : null;
			}

			// Token: 0x06003A7E RID: 14974 RVA: 0x0011B594 File Offset: 0x00119794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003A7F RID: 14975 RVA: 0x0011B5D4 File Offset: 0x001197D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253246, XrefRangeEnd = 253256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700119B RID: 4507
			// (get) Token: 0x06003A80 RID: 14976 RVA: 0x0011B610 File Offset: 0x00119810
			public unsafe ControllerPollingInfo eQOjYWBVDjtNugCRnQImrgdgoxJ
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ControllerPollingInfo(intPtr);
				}
			}

			// Token: 0x06003A81 RID: 14977 RVA: 0x0011B648 File Offset: 0x00119848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253256, XrefRangeEnd = 253261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A82 RID: 14978 RVA: 0x0011B67C File Offset: 0x0011987C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700119C RID: 4508
			// (get) Token: 0x06003A83 RID: 14979 RVA: 0x0011B6B0 File Offset: 0x001198B0
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253261, XrefRangeEnd = 253264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003A84 RID: 14980 RVA: 0x0011B6F0 File Offset: 0x001198F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253264, XrefRangeEnd = 253266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DTgcZICwceHqACLGnmvOYCwiRbk(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.DTgcZICwceHqACLGnmvOYCwiRbk>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003A85 RID: 14981 RVA: 0x00014A1D File Offset: 0x00012C1D
			public DTgcZICwceHqACLGnmvOYCwiRbk(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001195 RID: 4501
			// (get) Token: 0x06003A86 RID: 14982 RVA: 0x0011B738 File Offset: 0x00119938
			// (set) Token: 0x06003A87 RID: 14983 RVA: 0x00014A26 File Offset: 0x00012C26
			public ControllerPollingInfo NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001196 RID: 4502
			// (get) Token: 0x06003A88 RID: 14984 RVA: 0x0011B768 File Offset: 0x00119968
			// (set) Token: 0x06003A89 RID: 14985 RVA: 0x00014A54 File Offset: 0x00012C54
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x17001197 RID: 4503
			// (get) Token: 0x06003A8A RID: 14986 RVA: 0x0011B790 File Offset: 0x00119990
			// (set) Token: 0x06003A8B RID: 14987 RVA: 0x00014A6F File Offset: 0x00012C6F
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x17001198 RID: 4504
			// (get) Token: 0x06003A8C RID: 14988 RVA: 0x0011B7B8 File Offset: 0x001199B8
			// (set) Token: 0x06003A8D RID: 14989 RVA: 0x00014A8A File Offset: 0x00012C8A
			public unsafe Controller HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001199 RID: 4505
			// (get) Token: 0x06003A8E RID: 14990 RVA: 0x0011B7E8 File Offset: 0x001199E8
			// (set) Token: 0x06003A8F RID: 14991 RVA: 0x00014AA9 File Offset: 0x00012CA9
			public unsafe int kUBcJcFfgoKKiApkBmiZbFhcTlkZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ)) = value;
				}
			}

			// Token: 0x1700119A RID: 4506
			// (get) Token: 0x06003A90 RID: 14992 RVA: 0x0011B810 File Offset: 0x00119A10
			// (set) Token: 0x06003A91 RID: 14993 RVA: 0x00014AC4 File Offset: 0x00012CC4
			public unsafe int xFLzBQRXYlihrqYQXvPnLOQJuIs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_xFLzBQRXYlihrqYQXvPnLOQJuIs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.DTgcZICwceHqACLGnmvOYCwiRbk.NativeFieldInfoPtr_xFLzBQRXYlihrqYQXvPnLOQJuIs)) = value;
				}
			}

			// Token: 0x04003134 RID: 12596
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003135 RID: 12597
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003136 RID: 12598
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x04003137 RID: 12599
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04003138 RID: 12600
			private static readonly IntPtr NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ;

			// Token: 0x04003139 RID: 12601
			private static readonly IntPtr NativeFieldInfoPtr_xFLzBQRXYlihrqYQXvPnLOQJuIs;

			// Token: 0x0400313A RID: 12602
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0;

			// Token: 0x0400313B RID: 12603
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400313C RID: 12604
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400313D RID: 12605
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0;

			// Token: 0x0400313E RID: 12606
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400313F RID: 12607
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003140 RID: 12608
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003141 RID: 12609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}

		// Token: 0x0200027E RID: 638
		public sealed class WDicykQauMEVXOVLWpNaoROoVFe : global::Il2CppSystem.Object
		{
			// Token: 0x06003A92 RID: 14994 RVA: 0x0011B838 File Offset: 0x00119A38
			// Note: this type is marked as 'beforefieldinit'.
			static WDicykQauMEVXOVLWpNaoROoVFe()
			{
				Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Controller>.NativeClassPtr, "WDicykQauMEVXOVLWpNaoROoVFe");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr);
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_eNWNWwLKNoAPUQvvTfXqhTeZGcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, "eNWNWwLKNoAPUQvvTfXqhTeZGcs");
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_SfbKmuOoCXnCAzweCwAHmNIXDiE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, "SfbKmuOoCXnCAzweCwAHmNIXDiE");
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, 100665382);
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, 100665383);
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, 100665384);
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, 100665385);
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, 100665386);
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, 100665387);
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, 100665388);
				Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr, 100665389);
			}

			// Token: 0x06003A93 RID: 14995 RVA: 0x0011B97C File Offset: 0x00119B7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253266, XrefRangeEnd = 253269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerPollingInfo> System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerPollingInfo>>(intPtr3) : null;
			}

			// Token: 0x06003A94 RID: 14996 RVA: 0x0011B9BC File Offset: 0x00119BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003A95 RID: 14997 RVA: 0x0011B9FC File Offset: 0x00119BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253269, XrefRangeEnd = 253279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170011A3 RID: 4515
			// (get) Token: 0x06003A96 RID: 14998 RVA: 0x0011BA38 File Offset: 0x00119C38
			public unsafe ControllerPollingInfo eQOjYWBVDjtNugCRnQImrgdgoxJ
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ControllerPollingInfo(intPtr);
				}
			}

			// Token: 0x06003A97 RID: 14999 RVA: 0x0011BA70 File Offset: 0x00119C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253279, XrefRangeEnd = 253284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A98 RID: 15000 RVA: 0x0011BAA4 File Offset: 0x00119CA4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011A4 RID: 4516
			// (get) Token: 0x06003A99 RID: 15001 RVA: 0x0011BAD8 File Offset: 0x00119CD8
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253284, XrefRangeEnd = 253287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003A9A RID: 15002 RVA: 0x0011BB18 File Offset: 0x00119D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WDicykQauMEVXOVLWpNaoROoVFe(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller.WDicykQauMEVXOVLWpNaoROoVFe>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003A9B RID: 15003 RVA: 0x00014ADF File Offset: 0x00012CDF
			public WDicykQauMEVXOVLWpNaoROoVFe(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700119D RID: 4509
			// (get) Token: 0x06003A9C RID: 15004 RVA: 0x0011BB60 File Offset: 0x00119D60
			// (set) Token: 0x06003A9D RID: 15005 RVA: 0x00014AE8 File Offset: 0x00012CE8
			public ControllerPollingInfo NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700119E RID: 4510
			// (get) Token: 0x06003A9E RID: 15006 RVA: 0x0011BB90 File Offset: 0x00119D90
			// (set) Token: 0x06003A9F RID: 15007 RVA: 0x00014B16 File Offset: 0x00012D16
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x1700119F RID: 4511
			// (get) Token: 0x06003AA0 RID: 15008 RVA: 0x0011BBB8 File Offset: 0x00119DB8
			// (set) Token: 0x06003AA1 RID: 15009 RVA: 0x00014B31 File Offset: 0x00012D31
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x170011A0 RID: 4512
			// (get) Token: 0x06003AA2 RID: 15010 RVA: 0x0011BBE0 File Offset: 0x00119DE0
			// (set) Token: 0x06003AA3 RID: 15011 RVA: 0x00014B4C File Offset: 0x00012D4C
			public unsafe Controller HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A1 RID: 4513
			// (get) Token: 0x06003AA4 RID: 15012 RVA: 0x0011BC10 File Offset: 0x00119E10
			// (set) Token: 0x06003AA5 RID: 15013 RVA: 0x00014B6B File Offset: 0x00012D6B
			public unsafe int eNWNWwLKNoAPUQvvTfXqhTeZGcs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_eNWNWwLKNoAPUQvvTfXqhTeZGcs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_eNWNWwLKNoAPUQvvTfXqhTeZGcs)) = value;
				}
			}

			// Token: 0x170011A2 RID: 4514
			// (get) Token: 0x06003AA6 RID: 15014 RVA: 0x0011BC38 File Offset: 0x00119E38
			// (set) Token: 0x06003AA7 RID: 15015 RVA: 0x00014B86 File Offset: 0x00012D86
			public unsafe int SfbKmuOoCXnCAzweCwAHmNIXDiE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_SfbKmuOoCXnCAzweCwAHmNIXDiE);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Controller.WDicykQauMEVXOVLWpNaoROoVFe.NativeFieldInfoPtr_SfbKmuOoCXnCAzweCwAHmNIXDiE)) = value;
				}
			}

			// Token: 0x04003142 RID: 12610
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003143 RID: 12611
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003144 RID: 12612
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x04003145 RID: 12613
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04003146 RID: 12614
			private static readonly IntPtr NativeFieldInfoPtr_eNWNWwLKNoAPUQvvTfXqhTeZGcs;

			// Token: 0x04003147 RID: 12615
			private static readonly IntPtr NativeFieldInfoPtr_SfbKmuOoCXnCAzweCwAHmNIXDiE;

			// Token: 0x04003148 RID: 12616
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0;

			// Token: 0x04003149 RID: 12617
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400314A RID: 12618
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400314B RID: 12619
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0;

			// Token: 0x0400314C RID: 12620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400314D RID: 12621
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400314E RID: 12622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400314F RID: 12623
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}

		// Token: 0x0200027F RID: 639
		private sealed class MethodInfoStoreGeneric_GetExtension_Public_T_0<T>
		{
			// Token: 0x04003150 RID: 12624
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Controller.NativeMethodInfoPtr_GetExtension_Public_T_0, Il2CppClassPointerStore<Controller>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000280 RID: 640
		private sealed class MethodInfoStoreGeneric_GetTemplate_Public_T_0<T>
		{
			// Token: 0x04003151 RID: 12625
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Controller.NativeMethodInfoPtr_GetTemplate_Public_T_0, Il2CppClassPointerStore<Controller>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000281 RID: 641
		private sealed class MethodInfoStoreGeneric_ImplementsTemplate_Public_Boolean_0<T>
		{
			// Token: 0x04003152 RID: 12626
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Controller.NativeMethodInfoPtr_ImplementsTemplate_Public_Boolean_0, Il2CppClassPointerStore<Controller>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
