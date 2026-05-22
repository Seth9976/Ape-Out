using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.ComponentControls.Data;
using Il2CppRewired.Internal;
using Il2CppRewired.Utils.UI;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x0200004E RID: 78
	[Serializable]
	public sealed class TouchButton : TouchInteractable
	{
		// Token: 0x06000841 RID: 2113 RVA: 0x0004D334 File Offset: 0x0004B534
		// Note: this type is marked as 'beforefieldinit'.
		static TouchButton()
		{
			Il2CppClassPointerStore<TouchButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "TouchButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchButton>.NativeClassPtr);
			TouchButton.NativeFieldInfoPtr_GFXDOIgDVjqaGarFVueWbAseTfNl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "GFXDOIgDVjqaGarFVueWbAseTfNl");
			TouchButton.NativeFieldInfoPtr__targetCustomControllerElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_targetCustomControllerElement");
			TouchButton.NativeFieldInfoPtr__buttonType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_buttonType");
			TouchButton.NativeFieldInfoPtr__activateOnSwipeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_activateOnSwipeIn");
			TouchButton.NativeFieldInfoPtr__stayActiveOnSwipeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_stayActiveOnSwipeOut");
			TouchButton.NativeFieldInfoPtr__useDigitalAxisSimulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_useDigitalAxisSimulation");
			TouchButton.NativeFieldInfoPtr__digitalAxisGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_digitalAxisGravity");
			TouchButton.NativeFieldInfoPtr__digitalAxisSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_digitalAxisSensitivity");
			TouchButton.NativeFieldInfoPtr__axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_axis");
			TouchButton.NativeFieldInfoPtr__touchRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_touchRegion");
			TouchButton.NativeFieldInfoPtr__useTouchRegionOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_useTouchRegionOnly");
			TouchButton.NativeFieldInfoPtr__moveToTouchPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_moveToTouchPosition");
			TouchButton.NativeFieldInfoPtr__returnOnRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_returnOnRelease");
			TouchButton.NativeFieldInfoPtr__followTouchPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_followTouchPosition");
			TouchButton.NativeFieldInfoPtr__animateOnMoveToTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_animateOnMoveToTouch");
			TouchButton.NativeFieldInfoPtr__moveToTouchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_moveToTouchSpeed");
			TouchButton.NativeFieldInfoPtr__animateOnReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_animateOnReturn");
			TouchButton.NativeFieldInfoPtr__returnSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_returnSpeed");
			TouchButton.NativeFieldInfoPtr__manageRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_manageRaycasting");
			TouchButton.NativeFieldInfoPtr_IBhURWvpvnuuNtoNdqMGNdrqBVg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "IBhURWvpvnuuNtoNdqMGNdrqBVg");
			TouchButton.NativeFieldInfoPtr_DAZpDQGiyEvogoGNisnRfosoEaj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "DAZpDQGiyEvogoGNisnRfosoEaj");
			TouchButton.NativeFieldInfoPtr_FAXAaZIljCwYAnlkqdNSmoTxBOQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "FAXAaZIljCwYAnlkqdNSmoTxBOQ");
			TouchButton.NativeFieldInfoPtr_nKtkSEEFRrKhTrIrBAYNseYwyoH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "nKtkSEEFRrKhTrIrBAYNseYwyoH");
			TouchButton.NativeFieldInfoPtr_lyVdtmXfxMthMLPyLHCxprKYioV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "lyVdtmXfxMthMLPyLHCxprKYioV");
			TouchButton.NativeFieldInfoPtr_qqxivRifIBLfOVuHQUTleLQjOji = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "qqxivRifIBLfOVuHQUTleLQjOji");
			TouchButton.NativeFieldInfoPtr_uGlOHkjRObFeMCELeIVFjndPZrq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "uGlOHkjRObFeMCELeIVFjndPZrq");
			TouchButton.NativeFieldInfoPtr_eADEEFJCWOUCaLyBSJdNMqZhUUHS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "eADEEFJCWOUCaLyBSJdNMqZhUUHS");
			TouchButton.NativeFieldInfoPtr_TYJtttUMRYRjjXRzqHXzAEuRdcA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "TYJtttUMRYRjjXRzqHXzAEuRdcA");
			TouchButton.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "AJKoOMhkVHACBErfSbaQmDfyxZV");
			TouchButton.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "xISHKSqmxBFBXboSBVekNAulortJ");
			TouchButton.NativeFieldInfoPtr_RxttpxjtekTAUyOYUVaxldAmGktk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "RxttpxjtekTAUyOYUVaxldAmGktk");
			TouchButton.NativeFieldInfoPtr_FklVTrSZNzYhKyjSveDfZMwzRTm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "FklVTrSZNzYhKyjSveDfZMwzRTm");
			TouchButton.NativeFieldInfoPtr_tTDWZVTIwSKYKXvLROgABNVYNMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "tTDWZVTIwSKYKXvLROgABNVYNMp");
			TouchButton.NativeFieldInfoPtr_QsWnnSMnkDQQzlFljYojzfgruoE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "QsWnnSMnkDQQzlFljYojzfgruoE");
			TouchButton.NativeFieldInfoPtr__onAxisValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_onAxisValueChanged");
			TouchButton.NativeFieldInfoPtr__onButtonValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_onButtonValueChanged");
			TouchButton.NativeFieldInfoPtr__onButtonDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_onButtonDown");
			TouchButton.NativeFieldInfoPtr__onButtonUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "_onButtonUp");
			TouchButton.NativeFieldInfoPtr_QUsuNeFpdczRPYGqJmIJuaIEeo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "QUsuNeFpdczRPYGqJmIJuaIEeo");
			TouchButton.NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_add_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664647);
			TouchButton.NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_rem_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664648);
			TouchButton.NativeMethodInfoPtr_add_ButtonValueChangedEvent_Public_add_Void_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664649);
			TouchButton.NativeMethodInfoPtr_remove_ButtonValueChangedEvent_Public_rem_Void_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664650);
			TouchButton.NativeMethodInfoPtr_add_ButtonDownEvent_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664651);
			TouchButton.NativeMethodInfoPtr_remove_ButtonDownEvent_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664652);
			TouchButton.NativeMethodInfoPtr_add_ButtonUpEvent_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664653);
			TouchButton.NativeMethodInfoPtr_remove_ButtonUpEvent_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664654);
			TouchButton.NativeMethodInfoPtr_get_targetCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664655);
			TouchButton.NativeMethodInfoPtr_get_buttonType_Public_get_ButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664656);
			TouchButton.NativeMethodInfoPtr_set_buttonType_Public_set_Void_ButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664657);
			TouchButton.NativeMethodInfoPtr_get_activateOnSwipeIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664658);
			TouchButton.NativeMethodInfoPtr_set_activateOnSwipeIn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664659);
			TouchButton.NativeMethodInfoPtr_get_stayActiveOnSwipeOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664660);
			TouchButton.NativeMethodInfoPtr_set_stayActiveOnSwipeOut_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664661);
			TouchButton.NativeMethodInfoPtr_get_useDigitalAxisSimulation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664662);
			TouchButton.NativeMethodInfoPtr_set_useDigitalAxisSimulation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664663);
			TouchButton.NativeMethodInfoPtr_get_digitalAxisGravity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664664);
			TouchButton.NativeMethodInfoPtr_set_digitalAxisGravity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664665);
			TouchButton.NativeMethodInfoPtr_get_digitalAxisSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664666);
			TouchButton.NativeMethodInfoPtr_set_digitalAxisSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664667);
			TouchButton.NativeMethodInfoPtr_get_touchRegion_Public_get_TouchRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664668);
			TouchButton.NativeMethodInfoPtr_set_touchRegion_Public_set_Void_TouchRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664669);
			TouchButton.NativeMethodInfoPtr_get_useTouchRegionOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664670);
			TouchButton.NativeMethodInfoPtr_set_useTouchRegionOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664671);
			TouchButton.NativeMethodInfoPtr_get_moveToTouchPosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664672);
			TouchButton.NativeMethodInfoPtr_set_moveToTouchPosition_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664673);
			TouchButton.NativeMethodInfoPtr_get_returnOnRelease_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664674);
			TouchButton.NativeMethodInfoPtr_set_returnOnRelease_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664675);
			TouchButton.NativeMethodInfoPtr_get_followTouchPosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664676);
			TouchButton.NativeMethodInfoPtr_set_followTouchPosition_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664677);
			TouchButton.NativeMethodInfoPtr_get_animateOnMoveToTouch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664678);
			TouchButton.NativeMethodInfoPtr_set_animateOnMoveToTouch_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664679);
			TouchButton.NativeMethodInfoPtr_get_moveToTouchSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664680);
			TouchButton.NativeMethodInfoPtr_set_moveToTouchSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664681);
			TouchButton.NativeMethodInfoPtr_get_animateOnReturn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664682);
			TouchButton.NativeMethodInfoPtr_set_animateOnReturn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664683);
			TouchButton.NativeMethodInfoPtr_get_returnSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664684);
			TouchButton.NativeMethodInfoPtr_set_returnSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664685);
			TouchButton.NativeMethodInfoPtr_get_manageRaycasting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664686);
			TouchButton.NativeMethodInfoPtr_set_manageRaycasting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664687);
			TouchButton.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664688);
			TouchButton.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664689);
			TouchButton.NativeMethodInfoPtr_get_hasPointer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664690);
			TouchButton.NativeMethodInfoPtr_get_axis_Internal_get_StandaloneAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664691);
			TouchButton.NativeMethodInfoPtr_get_moveStartedDelegate_Private_get_Action_1_OnblsOyajJhlGzXGxhVSRFdUfck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664692);
			TouchButton.NativeMethodInfoPtr_get_moveEndedDelegate_Private_get_Action_1_OnblsOyajJhlGzXGxhVSRFdUfck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664693);
			TouchButton.NativeMethodInfoPtr_get_axisValue_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664694);
			TouchButton.NativeMethodInfoPtr_get_axisValuePrev_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664695);
			TouchButton.NativeMethodInfoPtr_get_buttonValue_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664696);
			TouchButton.NativeMethodInfoPtr_get_buttonValuePrev_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664697);
			TouchButton.NativeMethodInfoPtr_get_effectivePointerId_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664698);
			TouchButton.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664699);
			TouchButton.NativeMethodInfoPtr_SetRawValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664700);
			TouchButton.NativeMethodInfoPtr_SetDefaultPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664701);
			TouchButton.NativeMethodInfoPtr_INvchJBcQkSeGZgUXICnVqDkNBa_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664702);
			TouchButton.NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664703);
			TouchButton.NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664704);
			TouchButton.NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664705);
			TouchButton.NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664706);
			TouchButton.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664707);
			TouchButton.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664708);
			TouchButton.NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664709);
			TouchButton.NativeMethodInfoPtr_OnUpdate_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664710);
			TouchButton.NativeMethodInfoPtr_OnInitialize_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664711);
			TouchButton.NativeMethodInfoPtr_OnCustomControllerUpdate_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664712);
			TouchButton.NativeMethodInfoPtr_OnSubscribeEvents_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664713);
			TouchButton.NativeMethodInfoPtr_OnUnsubscribeEvents_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664714);
			TouchButton.NativeMethodInfoPtr_OnSetProperty_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664715);
			TouchButton.NativeMethodInfoPtr_OnClear_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664716);
			TouchButton.NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664717);
			TouchButton.NativeMethodInfoPtr_IsPressed_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664718);
			TouchButton.NativeMethodInfoPtr_IsThisOrTouchRegionGameObject_Internal_Virtual_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664719);
			TouchButton.NativeMethodInfoPtr_coCktQilPOISLyNbctBSEIUxdMQ_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664720);
			TouchButton.NativeMethodInfoPtr_MxbCcxKTOWdnROXxllKLaVpRTmM_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664721);
			TouchButton.NativeMethodInfoPtr_wmhPWgtyCACcqshxUEPgYAfQTVg_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664722);
			TouchButton.NativeMethodInfoPtr_QdPfgKcoUhelODRleGPVOdGAgaKG_Private_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664723);
			TouchButton.NativeMethodInfoPtr_nSceUIGDHgPszSpiYHYtkxHPzZio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664724);
			TouchButton.NativeMethodInfoPtr_zbfuTECUoAsSiPyAnhuqUMjwNub_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664725);
			TouchButton.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664726);
			TouchButton.NativeMethodInfoPtr_oCddbrAzLSgARApvwyLBgfvztGoB_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664727);
			TouchButton.NativeMethodInfoPtr_ScfGINmFMxfNAJVmpKaJsxmTkXqf_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664728);
			TouchButton.NativeMethodInfoPtr_nRvokDeWGGctkRtLitHwbAHZIso_Private_Void_TouchRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664729);
			TouchButton.NativeMethodInfoPtr_fOwxbxkERGiUgPApbIWvgPmZPSO_Private_Void_TouchRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664730);
			TouchButton.NativeMethodInfoPtr_EqPWznbcqXfSbBqHkAxpEdqMLyWN_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664731);
			TouchButton.NativeMethodInfoPtr_lYFqcNqPVQUWLQzfHypznAkffnR_Private_Void_Vector2_Boolean_Single_OnblsOyajJhlGzXGxhVSRFdUfck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664732);
			TouchButton.NativeMethodInfoPtr_bndCRqovhXNzogiaEgObWGJQjPoa_Private_Void_Vector2_PositionType_Boolean_Single_OnblsOyajJhlGzXGxhVSRFdUfck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664733);
			TouchButton.NativeMethodInfoPtr_vkcfalFMzcgemqDQsIhfobMLjflg_Private_IEnumerator_Vector2_PositionType_Single_OnblsOyajJhlGzXGxhVSRFdUfck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664734);
			TouchButton.NativeMethodInfoPtr_DsphDRCaOcDcijQVdImpyNcwmHe_Private_Void_OnblsOyajJhlGzXGxhVSRFdUfck_Vector2_PositionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664735);
			TouchButton.NativeMethodInfoPtr_XLLNWtCwXRBqlTJzCfKrbpeyhQGq_Private_Void_OnblsOyajJhlGzXGxhVSRFdUfck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664736);
			TouchButton.NativeMethodInfoPtr_SIuBcTqDlIpUZIPLQnVORwJXTBJ_Private_Void_OnblsOyajJhlGzXGxhVSRFdUfck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664737);
			TouchButton.NativeMethodInfoPtr_UIxnocxzYFfsRxEkPqhqIOluQjN_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664738);
			TouchButton.NativeMethodInfoPtr_nUDeYYbgQCDNaKgGyfLeqdHdeMxP_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664739);
			TouchButton.NativeMethodInfoPtr_baEViyRRodmuwhaehpMDycKSVwN_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664740);
			TouchButton.NativeMethodInfoPtr_JAmblvHRjTbFRpLqVhkTwYaNJHM_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664741);
			TouchButton.NativeMethodInfoPtr_tvfieGHVIvJAwOWABvkfZuaYRdg_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664742);
			TouchButton.NativeMethodInfoPtr_EzuEKEcRDHQOUwaaCWnntUCHasKc_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664743);
			TouchButton.NativeMethodInfoPtr_sPcvSSlGvTmwkQDQWFTYqTVIcix_Private_PointerEventData_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664744);
			TouchButton.NativeMethodInfoPtr_fygGGlEnKmuTNSTfXSwkyGEfsJS_Private_PointerEventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664745);
			TouchButton.NativeMethodInfoPtr_BtCjHnVCQQZOUErBybAPpoLjeBj_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664746);
			TouchButton.NativeMethodInfoPtr_RTRyejIHkYVUBLhWNMKKFAUfreV_Private_PointerEventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664747);
			TouchButton.NativeMethodInfoPtr_kigeNwWVsYERXqwjreancGuqqDE_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664748);
			TouchButton.NativeMethodInfoPtr_NJoaOsRdPOKjssNjRbxAqdXWPan_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664749);
			TouchButton.NativeMethodInfoPtr_ZAVdRrdxNFckOYQCbBCUgAfIgTyA_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664750);
			TouchButton.NativeMethodInfoPtr_lfnXGCYWqVSkgcSxlPOzgNuXEtM_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664751);
			TouchButton.NativeMethodInfoPtr_DDUCAWJSvpGMNhYKUcwQBJMrScy_Private_Void_Int32_Vector2_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664752);
			TouchButton.NativeMethodInfoPtr_YItZvqPcQhbqZIBTSJcwAqrHqkd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664753);
			TouchButton.NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664754);
			TouchButton.NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664755);
			TouchButton.NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664756);
			TouchButton.NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664757);
			TouchButton.NativeMethodInfoPtr_dUHXYlsiNyoGytvpHasBSXDaouo_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664758);
			TouchButton.NativeMethodInfoPtr_MqVGxwdIhdkYxCeELtBHDUDBqHw_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664759);
			TouchButton.NativeMethodInfoPtr_SrFgwGeyWNweDotJFrWgeGBpDYGh_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664760);
			TouchButton.NativeMethodInfoPtr_RQQGpvvccMPqUmqcSAznEENoAPi_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664761);
			TouchButton.NativeMethodInfoPtr_iKvhyyDmHyilyjqsJZrcpJwxVPj_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664762);
			TouchButton.NativeMethodInfoPtr_sCFRpqDtzffscZKEOGCXHMrJESW_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664763);
			TouchButton.NativeMethodInfoPtr_nipKcSFQsALEMgjEUAArcMlLaVWD_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664764);
			TouchButton.NativeMethodInfoPtr_YgQMShjEgpkqDOagAFOXernqyEc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, 100664765);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0004DFBC File Offset: 0x0004C1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249091, XrefRangeEnd = 249096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_AxisValueChangedEvent(UnityAction<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_add_Void_UnityAction_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0004E000 File Offset: 0x0004C200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249096, XrefRangeEnd = 249099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_AxisValueChangedEvent(UnityAction<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_rem_Void_UnityAction_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0004E044 File Offset: 0x0004C244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249099, XrefRangeEnd = 249104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ButtonValueChangedEvent(UnityAction<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_add_ButtonValueChangedEvent_Public_add_Void_UnityAction_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0004E088 File Offset: 0x0004C288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249104, XrefRangeEnd = 249107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ButtonValueChangedEvent(UnityAction<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_remove_ButtonValueChangedEvent_Public_rem_Void_UnityAction_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0004E0CC File Offset: 0x0004C2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249107, XrefRangeEnd = 249109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ButtonDownEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_add_ButtonDownEvent_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0004E110 File Offset: 0x0004C310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249109, XrefRangeEnd = 249111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ButtonDownEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_remove_ButtonDownEvent_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0004E154 File Offset: 0x0004C354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249111, XrefRangeEnd = 249113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ButtonUpEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_add_ButtonUpEvent_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0004E198 File Offset: 0x0004C398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249113, XrefRangeEnd = 249115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ButtonUpEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_remove_ButtonUpEvent_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x0004E1DC File Offset: 0x0004C3DC
		public unsafe CustomControllerElementTargetSetForFloat targetCustomControllerElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_targetCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr3) : null;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0004E21C File Offset: 0x0004C41C
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x0004E258 File Offset: 0x0004C458
		public unsafe TouchButton.ButtonType buttonType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_buttonType_Public_get_ButtonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_buttonType_Public_set_Void_ButtonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0004E298 File Offset: 0x0004C498
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0004E2D4 File Offset: 0x0004C4D4
		public unsafe bool activateOnSwipeIn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_activateOnSwipeIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_activateOnSwipeIn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0004E314 File Offset: 0x0004C514
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x0004E350 File Offset: 0x0004C550
		public unsafe bool stayActiveOnSwipeOut
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 249127, RefRangeEnd = 249130, XrefRangeStart = 249115, XrefRangeEnd = 249127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_stayActiveOnSwipeOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_stayActiveOnSwipeOut_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0004E390 File Offset: 0x0004C590
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x0004E3CC File Offset: 0x0004C5CC
		public unsafe bool useDigitalAxisSimulation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_useDigitalAxisSimulation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_useDigitalAxisSimulation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x0004E40C File Offset: 0x0004C60C
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x0004E448 File Offset: 0x0004C648
		public unsafe float digitalAxisGravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_digitalAxisGravity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_digitalAxisGravity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0004E488 File Offset: 0x0004C688
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x0004E4C4 File Offset: 0x0004C6C4
		public unsafe float digitalAxisSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_digitalAxisSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_digitalAxisSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0004E504 File Offset: 0x0004C704
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x0004E544 File Offset: 0x0004C744
		public unsafe TouchRegion touchRegion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_touchRegion_Public_get_TouchRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchRegion>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249130, XrefRangeEnd = 249146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_touchRegion_Public_set_Void_TouchRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0004E588 File Offset: 0x0004C788
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x0004E5C4 File Offset: 0x0004C7C4
		public unsafe bool useTouchRegionOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_useTouchRegionOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_useTouchRegionOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0004E604 File Offset: 0x0004C804
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x0004E640 File Offset: 0x0004C840
		public unsafe bool moveToTouchPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_moveToTouchPosition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_moveToTouchPosition_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0004E680 File Offset: 0x0004C880
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x0004E6BC File Offset: 0x0004C8BC
		public unsafe bool returnOnRelease
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_returnOnRelease_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_returnOnRelease_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0004E6FC File Offset: 0x0004C8FC
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x0004E738 File Offset: 0x0004C938
		public unsafe bool followTouchPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_followTouchPosition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_followTouchPosition_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0004E778 File Offset: 0x0004C978
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x0004E7B4 File Offset: 0x0004C9B4
		public unsafe bool animateOnMoveToTouch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_animateOnMoveToTouch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_animateOnMoveToTouch_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0004E7F4 File Offset: 0x0004C9F4
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x0004E830 File Offset: 0x0004CA30
		public unsafe float moveToTouchSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_moveToTouchSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249146, XrefRangeEnd = 249147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_moveToTouchSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0004E870 File Offset: 0x0004CA70
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x0004E8AC File Offset: 0x0004CAAC
		public unsafe bool animateOnReturn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_animateOnReturn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_animateOnReturn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0004E8EC File Offset: 0x0004CAEC
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x0004E928 File Offset: 0x0004CB28
		public unsafe float returnSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_returnSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249147, XrefRangeEnd = 249148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_returnSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0004E968 File Offset: 0x0004CB68
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x0004E9A4 File Offset: 0x0004CBA4
		public unsafe bool manageRaycasting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_manageRaycasting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249148, XrefRangeEnd = 249151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_manageRaycasting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0004E9E4 File Offset: 0x0004CBE4
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x0004EA20 File Offset: 0x0004CC20
		public unsafe int pointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0004EA60 File Offset: 0x0004CC60
		public unsafe bool hasPointer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_hasPointer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0004EA9C File Offset: 0x0004CC9C
		public unsafe StandaloneAxis axis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_axis_Internal_get_StandaloneAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandaloneAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0004EADC File Offset: 0x0004CCDC
		public unsafe Action<TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck> moveStartedDelegate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 249157, RefRangeEnd = 249158, XrefRangeStart = 249151, XrefRangeEnd = 249157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_moveStartedDelegate_Private_get_Action_1_OnblsOyajJhlGzXGxhVSRFdUfck_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck>>(intPtr3) : null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0004EB1C File Offset: 0x0004CD1C
		public unsafe Action<TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck> moveEndedDelegate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249158, XrefRangeEnd = 249164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_moveEndedDelegate_Private_get_Action_1_OnblsOyajJhlGzXGxhVSRFdUfck_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck>>(intPtr3) : null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0004EB5C File Offset: 0x0004CD5C
		public unsafe float axisValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_axisValue_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0004EB98 File Offset: 0x0004CD98
		public unsafe float axisValuePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_axisValuePrev_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0004EBD4 File Offset: 0x0004CDD4
		public unsafe bool buttonValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249164, XrefRangeEnd = 249167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_buttonValue_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x0004EC10 File Offset: 0x0004CE10
		public unsafe bool buttonValuePrev
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249167, XrefRangeEnd = 249170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_buttonValuePrev_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0004EC4C File Offset: 0x0004CE4C
		public unsafe int effectivePointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_get_effectivePointerId_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0004EC88 File Offset: 0x0004CE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249170, XrefRangeEnd = 249211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0004ECC4 File Offset: 0x0004CEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249211, XrefRangeEnd = 249212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRawValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_SetRawValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0004ED04 File Offset: 0x0004CF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249212, XrefRangeEnd = 249215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_SetDefaultPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0004ED38 File Offset: 0x0004CF38
		[CallerCount(0)]
		public unsafe void INvchJBcQkSeGZgUXICnVqDkNBa(Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_INvchJBcQkSeGZgUXICnVqDkNBa_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0004ED78 File Offset: 0x0004CF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249215, XrefRangeEnd = 249217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnToDefaultPosition(bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instant;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0004EDB8 File Offset: 0x0004CFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249217, XrefRangeEnd = 249218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnToDefaultPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0004EDEC File Offset: 0x0004CFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249218, XrefRangeEnd = 249223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0004EE20 File Offset: 0x0004D020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249223, XrefRangeEnd = 249226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0004EE54 File Offset: 0x0004D054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249226, XrefRangeEnd = 249227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0004EE88 File Offset: 0x0004D088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249227, XrefRangeEnd = 249230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0004EEBC File Offset: 0x0004D0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249230, XrefRangeEnd = 249235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0004EEF0 File Offset: 0x0004D0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249235, XrefRangeEnd = 249240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnUpdate_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0004EF24 File Offset: 0x0004D124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnInitialize_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0004EF60 File Offset: 0x0004D160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249240, XrefRangeEnd = 249243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCustomControllerUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnCustomControllerUpdate_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0004EF94 File Offset: 0x0004D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249243, XrefRangeEnd = 249274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSubscribeEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnSubscribeEvents_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0004EFC8 File Offset: 0x0004D1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249274, XrefRangeEnd = 249305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUnsubscribeEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnUnsubscribeEvents_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0004EFFC File Offset: 0x0004D1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249305, XrefRangeEnd = 249310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSetProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnSetProperty_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0004F030 File Offset: 0x0004D230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249310, XrefRangeEnd = 249316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnClear_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0004F064 File Offset: 0x0004D264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249316, XrefRangeEnd = 249320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0004F098 File Offset: 0x0004D298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249320, XrefRangeEnd = 249326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_IsPressed_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0004F0D4 File Offset: 0x0004D2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249326, XrefRangeEnd = 249360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsThisOrTouchRegionGameObject(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_IsThisOrTouchRegionGameObject_Internal_Virtual_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0004F124 File Offset: 0x0004D324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249369, RefRangeEnd = 249370, XrefRangeStart = 249360, XrefRangeEnd = 249369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void coCktQilPOISLyNbctBSEIUxdMQ()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_coCktQilPOISLyNbctBSEIUxdMQ_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0004F158 File Offset: 0x0004D358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249370, XrefRangeEnd = 249380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MxbCcxKTOWdnROXxllKLaVpRTmM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_MxbCcxKTOWdnROXxllKLaVpRTmM_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0004F18C File Offset: 0x0004D38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249380, XrefRangeEnd = 249386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void wmhPWgtyCACcqshxUEPgYAfQTVg()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_wmhPWgtyCACcqshxUEPgYAfQTVg_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0004F1C0 File Offset: 0x0004D3C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249390, RefRangeEnd = 249392, XrefRangeStart = 249386, XrefRangeEnd = 249390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QdPfgKcoUhelODRleGPVOdGAgaKG(float A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_QdPfgKcoUhelODRleGPVOdGAgaKG_Private_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0004F20C File Offset: 0x0004D40C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249397, RefRangeEnd = 249400, XrefRangeStart = 249392, XrefRangeEnd = 249397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void nSceUIGDHgPszSpiYHYtkxHPzZio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_nSceUIGDHgPszSpiYHYtkxHPzZio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0004F240 File Offset: 0x0004D440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249400, XrefRangeEnd = 249402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zbfuTECUoAsSiPyAnhuqUMjwNub()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_zbfuTECUoAsSiPyAnhuqUMjwNub_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0004F274 File Offset: 0x0004D474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249402, XrefRangeEnd = 249405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void iJzeeVgTFhPQqdRTfUGBACRnMOF()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0004F2A8 File Offset: 0x0004D4A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 249409, RefRangeEnd = 249415, XrefRangeStart = 249405, XrefRangeEnd = 249409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void oCddbrAzLSgARApvwyLBgfvztGoB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_oCddbrAzLSgARApvwyLBgfvztGoB_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0004F2DC File Offset: 0x0004D4DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249427, RefRangeEnd = 249429, XrefRangeStart = 249415, XrefRangeEnd = 249427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ScfGINmFMxfNAJVmpKaJsxmTkXqf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_ScfGINmFMxfNAJVmpKaJsxmTkXqf_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0004F318 File Offset: 0x0004D518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249464, RefRangeEnd = 249465, XrefRangeStart = 249429, XrefRangeEnd = 249464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void nRvokDeWGGctkRtLitHwbAHZIso(TouchRegion A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_nRvokDeWGGctkRtLitHwbAHZIso_Private_Void_TouchRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0004F35C File Offset: 0x0004D55C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249503, RefRangeEnd = 249505, XrefRangeStart = 249465, XrefRangeEnd = 249503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void fOwxbxkERGiUgPApbIWvgPmZPSO(TouchRegion A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_fOwxbxkERGiUgPApbIWvgPmZPSO_Private_Void_TouchRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0004F3A0 File Offset: 0x0004D5A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 249523, RefRangeEnd = 249529, XrefRangeStart = 249505, XrefRangeEnd = 249523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EqPWznbcqXfSbBqHkAxpEdqMLyWN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_EqPWznbcqXfSbBqHkAxpEdqMLyWN_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0004F3D4 File Offset: 0x0004D5D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249546, RefRangeEnd = 249549, XrefRangeStart = 249529, XrefRangeEnd = 249546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void lYFqcNqPVQUWLQzfHypznAkffnR(Vector2 A_1, bool A_2, float A_3, TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_lYFqcNqPVQUWLQzfHypznAkffnR_Private_Void_Vector2_Boolean_Single_OnblsOyajJhlGzXGxhVSRFdUfck_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0004F43C File Offset: 0x0004D63C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 249619, RefRangeEnd = 249624, XrefRangeStart = 249549, XrefRangeEnd = 249619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void bndCRqovhXNzogiaEgObWGJQjPoa(Vector2 A_1, PositionType A_2, bool A_3, float A_4, TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck A_5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_bndCRqovhXNzogiaEgObWGJQjPoa_Private_Void_Vector2_PositionType_Boolean_Single_OnblsOyajJhlGzXGxhVSRFdUfck_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0004F4B4 File Offset: 0x0004D6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249624, XrefRangeEnd = 249627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator vkcfalFMzcgemqDQsIhfobMLjflg(Vector2 A_1, PositionType A_2, float A_3, TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_vkcfalFMzcgemqDQsIhfobMLjflg_Private_IEnumerator_Vector2_PositionType_Single_OnblsOyajJhlGzXGxhVSRFdUfck_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0004F52C File Offset: 0x0004D72C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249641, RefRangeEnd = 249642, XrefRangeStart = 249627, XrefRangeEnd = 249641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DsphDRCaOcDcijQVdImpyNcwmHe(TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck A_1, Vector2 A_2, PositionType A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_DsphDRCaOcDcijQVdImpyNcwmHe_Private_Void_OnblsOyajJhlGzXGxhVSRFdUfck_Vector2_PositionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0004F588 File Offset: 0x0004D788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249642, XrefRangeEnd = 249658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void XLLNWtCwXRBqlTJzCfKrbpeyhQGq(TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_XLLNWtCwXRBqlTJzCfKrbpeyhQGq_Private_Void_OnblsOyajJhlGzXGxhVSRFdUfck_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0004F5C8 File Offset: 0x0004D7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249658, XrefRangeEnd = 249675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SIuBcTqDlIpUZIPLQnVORwJXTBJ(TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_SIuBcTqDlIpUZIPLQnVORwJXTBJ_Private_Void_OnblsOyajJhlGzXGxhVSRFdUfck_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0004F608 File Offset: 0x0004D808
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249683, RefRangeEnd = 249687, XrefRangeStart = 249675, XrefRangeEnd = 249683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIxnocxzYFfsRxEkPqhqIOluQjN(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_UIxnocxzYFfsRxEkPqhqIOluQjN_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0004F648 File Offset: 0x0004D848
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249689, RefRangeEnd = 249692, XrefRangeStart = 249687, XrefRangeEnd = 249689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void nUDeYYbgQCDNaKgGyfLeqdHdeMxP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_nUDeYYbgQCDNaKgGyfLeqdHdeMxP_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0004F67C File Offset: 0x0004D87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249713, RefRangeEnd = 249714, XrefRangeStart = 249692, XrefRangeEnd = 249713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void baEViyRRodmuwhaehpMDycKSVwN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_baEViyRRodmuwhaehpMDycKSVwN_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0004F6B0 File Offset: 0x0004D8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249714, XrefRangeEnd = 249726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool JAmblvHRjTbFRpLqVhkTwYaNJHM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_JAmblvHRjTbFRpLqVhkTwYaNJHM_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0004F6EC File Offset: 0x0004D8EC
		[CallerCount(0)]
		public unsafe void tvfieGHVIvJAwOWABvkfZuaYRdg()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_tvfieGHVIvJAwOWABvkfZuaYRdg_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0004F720 File Offset: 0x0004D920
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249729, RefRangeEnd = 249733, XrefRangeStart = 249726, XrefRangeEnd = 249729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EzuEKEcRDHQOUwaaCWnntUCHasKc(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_EzuEKEcRDHQOUwaaCWnntUCHasKc_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0004F76C File Offset: 0x0004D96C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249750, RefRangeEnd = 249751, XrefRangeStart = 249733, XrefRangeEnd = 249750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData sPcvSSlGvTmwkQDQWFTYqTVIcix(int A_1, GameObject A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_sPcvSSlGvTmwkQDQWFTYqTVIcix_Private_PointerEventData_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0004F7CC File Offset: 0x0004D9CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249766, RefRangeEnd = 249770, XrefRangeStart = 249751, XrefRangeEnd = 249766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData fygGGlEnKmuTNSTfXSwkyGEfsJS(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_fygGGlEnKmuTNSTfXSwkyGEfsJS_Private_PointerEventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0004F818 File Offset: 0x0004DA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249770, XrefRangeEnd = 249772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BtCjHnVCQQZOUErBybAPpoLjeBj(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_BtCjHnVCQQZOUErBybAPpoLjeBj_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0004F85C File Offset: 0x0004DA5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249795, RefRangeEnd = 249798, XrefRangeStart = 249772, XrefRangeEnd = 249795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData RTRyejIHkYVUBLhWNMKKFAUfreV(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_RTRyejIHkYVUBLhWNMKKFAUfreV_Private_PointerEventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0004F8A8 File Offset: 0x0004DAA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249808, RefRangeEnd = 249811, XrefRangeStart = 249798, XrefRangeEnd = 249808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void kigeNwWVsYERXqwjreancGuqqDE(PointerEventData A_1, TouchButton.IkdCQCEtiIDNGOuEuNKfEZIVOAiF A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_kigeNwWVsYERXqwjreancGuqqDE_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0004F8F8 File Offset: 0x0004DAF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249819, RefRangeEnd = 249821, XrefRangeStart = 249811, XrefRangeEnd = 249819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NJoaOsRdPOKjssNjRbxAqdXWPan(PointerEventData A_1, TouchButton.IkdCQCEtiIDNGOuEuNKfEZIVOAiF A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_NJoaOsRdPOKjssNjRbxAqdXWPan_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0004F948 File Offset: 0x0004DB48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249850, RefRangeEnd = 249852, XrefRangeStart = 249821, XrefRangeEnd = 249850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZAVdRrdxNFckOYQCbBCUgAfIgTyA(PointerEventData A_1, TouchButton.IkdCQCEtiIDNGOuEuNKfEZIVOAiF A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_ZAVdRrdxNFckOYQCbBCUgAfIgTyA_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0004F998 File Offset: 0x0004DB98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249861, RefRangeEnd = 249863, XrefRangeStart = 249852, XrefRangeEnd = 249861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void lfnXGCYWqVSkgcSxlPOzgNuXEtM(PointerEventData A_1, TouchButton.IkdCQCEtiIDNGOuEuNKfEZIVOAiF A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_lfnXGCYWqVSkgcSxlPOzgNuXEtM_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0004F9E8 File Offset: 0x0004DBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249863, XrefRangeEnd = 249867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DDUCAWJSvpGMNhYKUcwQBJMrScy(int A_1, Vector2 A_2, TouchButton.IkdCQCEtiIDNGOuEuNKfEZIVOAiF A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_DDUCAWJSvpGMNhYKUcwQBJMrScy_Private_Void_Int32_Vector2_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0004FA44 File Offset: 0x0004DC44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249870, RefRangeEnd = 249873, XrefRangeStart = 249867, XrefRangeEnd = 249870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void YItZvqPcQhbqZIBTSJcwAqrHqkd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_YItZvqPcQhbqZIBTSJcwAqrHqkd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0004FA78 File Offset: 0x0004DC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249873, XrefRangeEnd = 249890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0004FABC File Offset: 0x0004DCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249890, XrefRangeEnd = 249907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0004FB00 File Offset: 0x0004DD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249907, XrefRangeEnd = 249924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0004FB44 File Offset: 0x0004DD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249924, XrefRangeEnd = 249941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0004FB88 File Offset: 0x0004DD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249941, XrefRangeEnd = 249946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dUHXYlsiNyoGytvpHasBSXDaouo(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_dUHXYlsiNyoGytvpHasBSXDaouo_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0004FBCC File Offset: 0x0004DDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249946, XrefRangeEnd = 249951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MqVGxwdIhdkYxCeELtBHDUDBqHw(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_MqVGxwdIhdkYxCeELtBHDUDBqHw_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0004FC10 File Offset: 0x0004DE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249951, XrefRangeEnd = 249956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SrFgwGeyWNweDotJFrWgeGBpDYGh(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_SrFgwGeyWNweDotJFrWgeGBpDYGh_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0004FC54 File Offset: 0x0004DE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249956, XrefRangeEnd = 249961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RQQGpvvccMPqUmqcSAznEENoAPi(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_RQQGpvvccMPqUmqcSAznEENoAPi_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0004FC98 File Offset: 0x0004DE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249961, XrefRangeEnd = 249965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void iKvhyyDmHyilyjqsJZrcpJwxVPj(float A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_iKvhyyDmHyilyjqsJZrcpJwxVPj_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0004FCD8 File Offset: 0x0004DED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249965, XrefRangeEnd = 249969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sCFRpqDtzffscZKEOGCXHMrJESW(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_sCFRpqDtzffscZKEOGCXHMrJESW_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0004FD18 File Offset: 0x0004DF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249969, XrefRangeEnd = 249971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void nipKcSFQsALEMgjEUAArcMlLaVWD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_nipKcSFQsALEMgjEUAArcMlLaVWD_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0004FD4C File Offset: 0x0004DF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249971, XrefRangeEnd = 249973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void YgQMShjEgpkqDOagAFOXernqyEc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.NativeMethodInfoPtr_YgQMShjEgpkqDOagAFOXernqyEc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00004BE9 File Offset: 0x00002DE9
		public TouchButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0004FD80 File Offset: 0x0004DF80
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00004BF2 File Offset: 0x00002DF2
		public unsafe static float GFXDOIgDVjqaGarFVueWbAseTfNl
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TouchButton.NativeFieldInfoPtr_GFXDOIgDVjqaGarFVueWbAseTfNl, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchButton.NativeFieldInfoPtr_GFXDOIgDVjqaGarFVueWbAseTfNl, (void*)(&value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0004FD9C File Offset: 0x0004DF9C
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00004C00 File Offset: 0x00002E00
		public unsafe CustomControllerElementTargetSetForFloat _targetCustomControllerElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__targetCustomControllerElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__targetCustomControllerElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0004FDCC File Offset: 0x0004DFCC
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00004C1F File Offset: 0x00002E1F
		public unsafe TouchButton.ButtonType _buttonType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__buttonType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__buttonType)) = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0004FDF4 File Offset: 0x0004DFF4
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00004C3A File Offset: 0x00002E3A
		public unsafe bool _activateOnSwipeIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__activateOnSwipeIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__activateOnSwipeIn)) = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0004FE1C File Offset: 0x0004E01C
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00004C55 File Offset: 0x00002E55
		public unsafe bool _stayActiveOnSwipeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__stayActiveOnSwipeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__stayActiveOnSwipeOut)) = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0004FE44 File Offset: 0x0004E044
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00004C70 File Offset: 0x00002E70
		public unsafe bool _useDigitalAxisSimulation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__useDigitalAxisSimulation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__useDigitalAxisSimulation)) = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0004FE6C File Offset: 0x0004E06C
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00004C8B File Offset: 0x00002E8B
		public unsafe float _digitalAxisGravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__digitalAxisGravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__digitalAxisGravity)) = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0004FE94 File Offset: 0x0004E094
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00004CA6 File Offset: 0x00002EA6
		public unsafe float _digitalAxisSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__digitalAxisSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__digitalAxisSensitivity)) = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0004FEBC File Offset: 0x0004E0BC
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00004CC1 File Offset: 0x00002EC1
		public unsafe StandaloneAxis _axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__axis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__axis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0004FEEC File Offset: 0x0004E0EC
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public unsafe TouchRegion _touchRegion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__touchRegion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchRegion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__touchRegion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0004FF1C File Offset: 0x0004E11C
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00004CFF File Offset: 0x00002EFF
		public unsafe bool _useTouchRegionOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__useTouchRegionOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__useTouchRegionOnly)) = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0004FF44 File Offset: 0x0004E144
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00004D1A File Offset: 0x00002F1A
		public unsafe bool _moveToTouchPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__moveToTouchPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__moveToTouchPosition)) = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0004FF6C File Offset: 0x0004E16C
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00004D35 File Offset: 0x00002F35
		public unsafe bool _returnOnRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__returnOnRelease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__returnOnRelease)) = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0004FF94 File Offset: 0x0004E194
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00004D50 File Offset: 0x00002F50
		public unsafe bool _followTouchPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__followTouchPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__followTouchPosition)) = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0004FFBC File Offset: 0x0004E1BC
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00004D6B File Offset: 0x00002F6B
		public unsafe bool _animateOnMoveToTouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__animateOnMoveToTouch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__animateOnMoveToTouch)) = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0004FFE4 File Offset: 0x0004E1E4
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00004D86 File Offset: 0x00002F86
		public unsafe float _moveToTouchSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__moveToTouchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__moveToTouchSpeed)) = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0005000C File Offset: 0x0004E20C
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00004DA1 File Offset: 0x00002FA1
		public unsafe bool _animateOnReturn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__animateOnReturn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__animateOnReturn)) = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x00050034 File Offset: 0x0004E234
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00004DBC File Offset: 0x00002FBC
		public unsafe float _returnSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__returnSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__returnSpeed)) = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0005005C File Offset: 0x0004E25C
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00004DD7 File Offset: 0x00002FD7
		public unsafe bool _manageRaycasting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__manageRaycasting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__manageRaycasting)) = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00050084 File Offset: 0x0004E284
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00004DF2 File Offset: 0x00002FF2
		public unsafe float IBhURWvpvnuuNtoNdqMGNdrqBVg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_IBhURWvpvnuuNtoNdqMGNdrqBVg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_IBhURWvpvnuuNtoNdqMGNdrqBVg)) = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x000500AC File Offset: 0x0004E2AC
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00004E0D File Offset: 0x0000300D
		public unsafe float DAZpDQGiyEvogoGNisnRfosoEaj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_DAZpDQGiyEvogoGNisnRfosoEaj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_DAZpDQGiyEvogoGNisnRfosoEaj)) = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x000500D4 File Offset: 0x0004E2D4
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00004E28 File Offset: 0x00003028
		public unsafe TouchRegion FAXAaZIljCwYAnlkqdNSmoTxBOQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_FAXAaZIljCwYAnlkqdNSmoTxBOQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchRegion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_FAXAaZIljCwYAnlkqdNSmoTxBOQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00050104 File Offset: 0x0004E304
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00004E47 File Offset: 0x00003047
		public unsafe Vector2 nKtkSEEFRrKhTrIrBAYNseYwyoH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_nKtkSEEFRrKhTrIrBAYNseYwyoH);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_nKtkSEEFRrKhTrIrBAYNseYwyoH)) = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0005012C File Offset: 0x0004E32C
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00004E62 File Offset: 0x00003062
		public unsafe bool lyVdtmXfxMthMLPyLHCxprKYioV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_lyVdtmXfxMthMLPyLHCxprKYioV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_lyVdtmXfxMthMLPyLHCxprKYioV)) = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x00050154 File Offset: 0x0004E354
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00004E7D File Offset: 0x0000307D
		public unsafe bool qqxivRifIBLfOVuHQUTleLQjOji
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_qqxivRifIBLfOVuHQUTleLQjOji);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_qqxivRifIBLfOVuHQUTleLQjOji)) = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0005017C File Offset: 0x0004E37C
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00004E98 File Offset: 0x00003098
		public unsafe TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck uGlOHkjRObFeMCELeIVFjndPZrq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_uGlOHkjRObFeMCELeIVFjndPZrq);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_uGlOHkjRObFeMCELeIVFjndPZrq)) = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x000501A4 File Offset: 0x0004E3A4
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00004EB3 File Offset: 0x000030B3
		public unsafe int eADEEFJCWOUCaLyBSJdNMqZhUUHS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_eADEEFJCWOUCaLyBSJdNMqZhUUHS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_eADEEFJCWOUCaLyBSJdNMqZhUUHS)) = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x000501CC File Offset: 0x0004E3CC
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00004ECE File Offset: 0x000030CE
		public unsafe int TYJtttUMRYRjjXRzqHXzAEuRdcA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_TYJtttUMRYRjjXRzqHXzAEuRdcA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_TYJtttUMRYRjjXRzqHXzAEuRdcA)) = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x000501F4 File Offset: 0x0004E3F4
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00004EE9 File Offset: 0x000030E9
		public new unsafe bool AJKoOMhkVHACBErfSbaQmDfyxZV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV)) = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0005021C File Offset: 0x0004E41C
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00004F04 File Offset: 0x00003104
		public new unsafe bool xISHKSqmxBFBXboSBVekNAulortJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ)) = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00050244 File Offset: 0x0004E444
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00004F1F File Offset: 0x0000311F
		public unsafe IEnumerator RxttpxjtekTAUyOYUVaxldAmGktk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_RxttpxjtekTAUyOYUVaxldAmGktk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_RxttpxjtekTAUyOYUVaxldAmGktk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00050274 File Offset: 0x0004E474
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00004F3E File Offset: 0x0000313E
		public unsafe kmRUwlUPdxkBYAIjfDmUhHgmIqam FklVTrSZNzYhKyjSveDfZMwzRTm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_FklVTrSZNzYhKyjSveDfZMwzRTm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<kmRUwlUPdxkBYAIjfDmUhHgmIqam>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_FklVTrSZNzYhKyjSveDfZMwzRTm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x000502A4 File Offset: 0x0004E4A4
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x00004F5D File Offset: 0x0000315D
		public unsafe Action<TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck> tTDWZVTIwSKYKXvLROgABNVYNMp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_tTDWZVTIwSKYKXvLROgABNVYNMp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_tTDWZVTIwSKYKXvLROgABNVYNMp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x000502D4 File Offset: 0x0004E4D4
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00004F7C File Offset: 0x0000317C
		public unsafe Action<TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck> QsWnnSMnkDQQzlFljYojzfgruoE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_QsWnnSMnkDQQzlFljYojzfgruoE);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_QsWnnSMnkDQQzlFljYojzfgruoE), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00050304 File Offset: 0x0004E504
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00004F9B File Offset: 0x0000319B
		public unsafe TouchButton.AxisValueChangedEventHandler _onAxisValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__onAxisValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchButton.AxisValueChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__onAxisValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x00050334 File Offset: 0x0004E534
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00004FBA File Offset: 0x000031BA
		public unsafe TouchButton.ButtonValueChangedEventHandler _onButtonValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__onButtonValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchButton.ButtonValueChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__onButtonValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00050364 File Offset: 0x0004E564
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00004FD9 File Offset: 0x000031D9
		public unsafe TouchButton.ButtonDownEventHandler _onButtonDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__onButtonDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchButton.ButtonDownEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__onButtonDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00050394 File Offset: 0x0004E594
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00004FF8 File Offset: 0x000031F8
		public unsafe TouchButton.ButtonUpEventHandler _onButtonUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__onButtonUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchButton.ButtonUpEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr__onButtonUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x000503C4 File Offset: 0x0004E5C4
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x00005017 File Offset: 0x00003217
		public unsafe Dictionary<int, PointerEventData> QUsuNeFpdczRPYGqJmIJuaIEeo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_QUsuNeFpdczRPYGqJmIJuaIEeo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PointerEventData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.NativeFieldInfoPtr_QUsuNeFpdczRPYGqJmIJuaIEeo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeFieldInfoPtr_GFXDOIgDVjqaGarFVueWbAseTfNl;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr__targetCustomControllerElement;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr__buttonType;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr__activateOnSwipeIn;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr__stayActiveOnSwipeOut;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr__useDigitalAxisSimulation;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr__digitalAxisGravity;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeFieldInfoPtr__digitalAxisSensitivity;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeFieldInfoPtr__axis;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr__touchRegion;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr__useTouchRegionOnly;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr__moveToTouchPosition;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr__returnOnRelease;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr__followTouchPosition;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr__animateOnMoveToTouch;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr__moveToTouchSpeed;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr__animateOnReturn;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr__returnSpeed;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr__manageRaycasting;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr_IBhURWvpvnuuNtoNdqMGNdrqBVg;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr_DAZpDQGiyEvogoGNisnRfosoEaj;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr_FAXAaZIljCwYAnlkqdNSmoTxBOQ;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr_nKtkSEEFRrKhTrIrBAYNseYwyoH;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_lyVdtmXfxMthMLPyLHCxprKYioV;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr_qqxivRifIBLfOVuHQUTleLQjOji;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr_uGlOHkjRObFeMCELeIVFjndPZrq;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr_eADEEFJCWOUCaLyBSJdNMqZhUUHS;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr_TYJtttUMRYRjjXRzqHXzAEuRdcA;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr_RxttpxjtekTAUyOYUVaxldAmGktk;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_FklVTrSZNzYhKyjSveDfZMwzRTm;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_tTDWZVTIwSKYKXvLROgABNVYNMp;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_QsWnnSMnkDQQzlFljYojzfgruoE;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr__onAxisValueChanged;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr__onButtonValueChanged;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr__onButtonDown;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr__onButtonUp;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_QUsuNeFpdczRPYGqJmIJuaIEeo;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_add_Void_UnityAction_1_Single_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_rem_Void_UnityAction_1_Single_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_add_ButtonValueChangedEvent_Public_add_Void_UnityAction_1_Boolean_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_remove_ButtonValueChangedEvent_Public_rem_Void_UnityAction_1_Boolean_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_add_ButtonDownEvent_Public_add_Void_UnityAction_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_remove_ButtonDownEvent_Public_rem_Void_UnityAction_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_add_ButtonUpEvent_Public_add_Void_UnityAction_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_remove_ButtonUpEvent_Public_rem_Void_UnityAction_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_get_targetCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonType_Public_get_ButtonType_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonType_Public_set_Void_ButtonType_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_get_activateOnSwipeIn_Public_get_Boolean_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_set_activateOnSwipeIn_Public_set_Void_Boolean_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_get_stayActiveOnSwipeOut_Public_get_Boolean_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_set_stayActiveOnSwipeOut_Public_set_Void_Boolean_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_get_useDigitalAxisSimulation_Public_get_Boolean_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_set_useDigitalAxisSimulation_Public_set_Void_Boolean_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_get_digitalAxisGravity_Public_get_Single_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_set_digitalAxisGravity_Public_set_Void_Single_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_get_digitalAxisSensitivity_Public_get_Single_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_set_digitalAxisSensitivity_Public_set_Void_Single_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_get_touchRegion_Public_get_TouchRegion_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_set_touchRegion_Public_set_Void_TouchRegion_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_get_useTouchRegionOnly_Public_get_Boolean_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_set_useTouchRegionOnly_Public_set_Void_Boolean_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_get_moveToTouchPosition_Public_get_Boolean_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_set_moveToTouchPosition_Public_set_Void_Boolean_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_get_returnOnRelease_Public_get_Boolean_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_set_returnOnRelease_Public_set_Void_Boolean_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_get_followTouchPosition_Public_get_Boolean_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_set_followTouchPosition_Public_set_Void_Boolean_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_get_animateOnMoveToTouch_Public_get_Boolean_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_set_animateOnMoveToTouch_Public_set_Void_Boolean_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_get_moveToTouchSpeed_Public_get_Single_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_set_moveToTouchSpeed_Public_set_Void_Single_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_get_animateOnReturn_Public_get_Boolean_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_set_animateOnReturn_Public_set_Void_Boolean_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_get_returnSpeed_Public_get_Single_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_set_returnSpeed_Public_set_Void_Single_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_get_manageRaycasting_Public_get_Boolean_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_set_manageRaycasting_Public_set_Void_Boolean_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_get_hasPointer_Public_get_Boolean_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_get_axis_Internal_get_StandaloneAxis_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_get_moveStartedDelegate_Private_get_Action_1_OnblsOyajJhlGzXGxhVSRFdUfck_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_get_moveEndedDelegate_Private_get_Action_1_OnblsOyajJhlGzXGxhVSRFdUfck_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_get_axisValue_Private_get_Single_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_get_axisValuePrev_Private_get_Single_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonValue_Private_get_Boolean_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonValuePrev_Private_get_Boolean_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_get_effectivePointerId_Private_get_Int32_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_SetRawValue_Public_Void_Single_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultPosition_Public_Void_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_INvchJBcQkSeGZgUXICnVqDkNBa_Private_Void_Vector2_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_Boolean_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Internal_Virtual_Void_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Internal_Virtual_Boolean_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_OnCustomControllerUpdate_Internal_Virtual_Void_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_OnSubscribeEvents_Internal_Virtual_Void_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_OnUnsubscribeEvents_Internal_Virtual_Void_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_OnSetProperty_Internal_Virtual_Void_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_OnClear_Internal_Virtual_Void_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_IsPressed_Internal_Virtual_Boolean_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_IsThisOrTouchRegionGameObject_Internal_Virtual_Boolean_GameObject_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_coCktQilPOISLyNbctBSEIUxdMQ_Private_Void_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_MxbCcxKTOWdnROXxllKLaVpRTmM_Private_Void_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_wmhPWgtyCACcqshxUEPgYAfQTVg_Private_Void_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_QdPfgKcoUhelODRleGPVOdGAgaKG_Private_Void_Single_Boolean_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_nSceUIGDHgPszSpiYHYtkxHPzZio_Private_Void_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_zbfuTECUoAsSiPyAnhuqUMjwNub_Private_Void_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_oCddbrAzLSgARApvwyLBgfvztGoB_Private_Void_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_ScfGINmFMxfNAJVmpKaJsxmTkXqf_Private_Boolean_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_nRvokDeWGGctkRtLitHwbAHZIso_Private_Void_TouchRegion_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_fOwxbxkERGiUgPApbIWvgPmZPSO_Private_Void_TouchRegion_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_EqPWznbcqXfSbBqHkAxpEdqMLyWN_Private_Void_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_lYFqcNqPVQUWLQzfHypznAkffnR_Private_Void_Vector2_Boolean_Single_OnblsOyajJhlGzXGxhVSRFdUfck_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_bndCRqovhXNzogiaEgObWGJQjPoa_Private_Void_Vector2_PositionType_Boolean_Single_OnblsOyajJhlGzXGxhVSRFdUfck_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_vkcfalFMzcgemqDQsIhfobMLjflg_Private_IEnumerator_Vector2_PositionType_Single_OnblsOyajJhlGzXGxhVSRFdUfck_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_DsphDRCaOcDcijQVdImpyNcwmHe_Private_Void_OnblsOyajJhlGzXGxhVSRFdUfck_Vector2_PositionType_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_XLLNWtCwXRBqlTJzCfKrbpeyhQGq_Private_Void_OnblsOyajJhlGzXGxhVSRFdUfck_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_SIuBcTqDlIpUZIPLQnVORwJXTBJ_Private_Void_OnblsOyajJhlGzXGxhVSRFdUfck_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_UIxnocxzYFfsRxEkPqhqIOluQjN_Private_Void_Int32_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_nUDeYYbgQCDNaKgGyfLeqdHdeMxP_Private_Void_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_baEViyRRodmuwhaehpMDycKSVwN_Private_Void_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_JAmblvHRjTbFRpLqVhkTwYaNJHM_Private_Boolean_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_tvfieGHVIvJAwOWABvkfZuaYRdg_Private_Void_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_EzuEKEcRDHQOUwaaCWnntUCHasKc_Private_Boolean_Int32_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_sPcvSSlGvTmwkQDQWFTYqTVIcix_Private_PointerEventData_Int32_GameObject_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_fygGGlEnKmuTNSTfXSwkyGEfsJS_Private_PointerEventData_Int32_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_BtCjHnVCQQZOUErBybAPpoLjeBj_Private_Void_PointerEventData_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_RTRyejIHkYVUBLhWNMKKFAUfreV_Private_PointerEventData_Int32_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_kigeNwWVsYERXqwjreancGuqqDE_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_NJoaOsRdPOKjssNjRbxAqdXWPan_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_ZAVdRrdxNFckOYQCbBCUgAfIgTyA_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_lfnXGCYWqVSkgcSxlPOzgNuXEtM_Private_Void_PointerEventData_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_DDUCAWJSvpGMNhYKUcwQBJMrScy_Private_Void_Int32_Vector2_IkdCQCEtiIDNGOuEuNKfEZIVOAiF_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_YItZvqPcQhbqZIBTSJcwAqrHqkd_Private_Void_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_dUHXYlsiNyoGytvpHasBSXDaouo_Private_Void_PointerEventData_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_MqVGxwdIhdkYxCeELtBHDUDBqHw_Private_Void_PointerEventData_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_SrFgwGeyWNweDotJFrWgeGBpDYGh_Private_Void_PointerEventData_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_RQQGpvvccMPqUmqcSAznEENoAPi_Private_Void_PointerEventData_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_iKvhyyDmHyilyjqsJZrcpJwxVPj_Private_Void_Single_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_sCFRpqDtzffscZKEOGCXHMrJESW_Private_Void_Boolean_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_nipKcSFQsALEMgjEUAArcMlLaVWD_Private_Void_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_YgQMShjEgpkqDOagAFOXernqyEc_Private_Void_0;

		// Token: 0x02000257 RID: 599
		[OriginalName("Rewired_Core.dll", "", "ButtonType")]
		public enum ButtonType
		{
			// Token: 0x0400302A RID: 12330
			Standard,
			// Token: 0x0400302B RID: 12331
			ToggleSwitch
		}

		// Token: 0x02000258 RID: 600
		[OriginalName("Rewired_Core.dll", "", "OnblsOyajJhlGzXGxhVSRFdUfck")]
		public enum OnblsOyajJhlGzXGxhVSRFdUfck
		{
			// Token: 0x0400302D RID: 12333
			urhBwQidoSAKHIhcxeCWNbALMhkh,
			// Token: 0x0400302E RID: 12334
			PEyGteqOvFiHPmYheQXLlIMfseW,
			// Token: 0x0400302F RID: 12335
			qGdyXsFZTOfhwXwKVygNOQkalAU
		}

		// Token: 0x02000259 RID: 601
		[OriginalName("Rewired_Core.dll", "", "IkdCQCEtiIDNGOuEuNKfEZIVOAiF")]
		public enum IkdCQCEtiIDNGOuEuNKfEZIVOAiF
		{
			// Token: 0x04003031 RID: 12337
			pbEwUmgtedTWksLWRJLxjjXcbkR,
			// Token: 0x04003032 RID: 12338
			FPYWBLDnTCVJfwQHOpuFKFuUbtA
		}

		// Token: 0x0200025A RID: 602
		[Serializable]
		public class AxisValueChangedEventHandler : UnityEvent<float>
		{
			// Token: 0x0600390E RID: 14606 RVA: 0x00013EBC File Offset: 0x000120BC
			// Note: this type is marked as 'beforefieldinit'.
			static AxisValueChangedEventHandler()
			{
				Il2CppClassPointerStore<TouchButton.AxisValueChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "AxisValueChangedEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchButton.AxisValueChangedEventHandler>.NativeClassPtr);
				TouchButton.AxisValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton.AxisValueChangedEventHandler>.NativeClassPtr, 100664766);
			}

			// Token: 0x0600390F RID: 14607 RVA: 0x00116770 File Offset: 0x00114970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249081, XrefRangeEnd = 249083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AxisValueChangedEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchButton.AxisValueChangedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.AxisValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003910 RID: 14608 RVA: 0x00013EF0 File Offset: 0x000120F0
			public AxisValueChangedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003033 RID: 12339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200025B RID: 603
		[Serializable]
		public class ButtonValueChangedEventHandler : UnityEvent<bool>
		{
			// Token: 0x06003911 RID: 14609 RVA: 0x00013EF9 File Offset: 0x000120F9
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonValueChangedEventHandler()
			{
				Il2CppClassPointerStore<TouchButton.ButtonValueChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "ButtonValueChangedEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchButton.ButtonValueChangedEventHandler>.NativeClassPtr);
				TouchButton.ButtonValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton.ButtonValueChangedEventHandler>.NativeClassPtr, 100664767);
			}

			// Token: 0x06003912 RID: 14610 RVA: 0x001167AC File Offset: 0x001149AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249083, XrefRangeEnd = 249085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonValueChangedEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchButton.ButtonValueChangedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.ButtonValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003913 RID: 14611 RVA: 0x00013F2D File Offset: 0x0001212D
			public ButtonValueChangedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003034 RID: 12340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200025C RID: 604
		[Serializable]
		public class ButtonDownEventHandler : UnityEvent
		{
			// Token: 0x06003914 RID: 14612 RVA: 0x00013F36 File Offset: 0x00012136
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonDownEventHandler()
			{
				Il2CppClassPointerStore<TouchButton.ButtonDownEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "ButtonDownEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchButton.ButtonDownEventHandler>.NativeClassPtr);
				TouchButton.ButtonDownEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton.ButtonDownEventHandler>.NativeClassPtr, 100664768);
			}

			// Token: 0x06003915 RID: 14613 RVA: 0x001167E8 File Offset: 0x001149E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonDownEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchButton.ButtonDownEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.ButtonDownEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003916 RID: 14614 RVA: 0x00013F6A File Offset: 0x0001216A
			public ButtonDownEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003035 RID: 12341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200025D RID: 605
		[Serializable]
		public class ButtonUpEventHandler : UnityEvent
		{
			// Token: 0x06003917 RID: 14615 RVA: 0x00013F73 File Offset: 0x00012173
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonUpEventHandler()
			{
				Il2CppClassPointerStore<TouchButton.ButtonUpEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "ButtonUpEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchButton.ButtonUpEventHandler>.NativeClassPtr);
				TouchButton.ButtonUpEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton.ButtonUpEventHandler>.NativeClassPtr, 100664769);
			}

			// Token: 0x06003918 RID: 14616 RVA: 0x00116824 File Offset: 0x00114A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonUpEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchButton.ButtonUpEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.ButtonUpEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003919 RID: 14617 RVA: 0x00013FA7 File Offset: 0x000121A7
			public ButtonUpEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003036 RID: 12342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200025E RID: 606
		public sealed class IFyyImeRFRimEqQaeNbRiiNIdj : global::Il2CppSystem.Object
		{
			// Token: 0x0600391A RID: 14618 RVA: 0x00116860 File Offset: 0x00114A60
			// Note: this type is marked as 'beforefieldinit'.
			static IFyyImeRFRimEqQaeNbRiiNIdj()
			{
				Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchButton>.NativeClassPtr, "IFyyImeRFRimEqQaeNbRiiNIdj");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr);
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_HqNOVSqyZgsPCXRbncuLhQsCKCrG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "HqNOVSqyZgsPCXRbncuLhQsCKCrG");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_BqySXaTZmKleAPNHvEeZQpiiNfv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "BqySXaTZmKleAPNHvEeZQpiiNfv");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_CUfEqFiNWSnIAsqKObGFeXEtaaKb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "CUfEqFiNWSnIAsqKObGFeXEtaaKb");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_eifgwUgHdNifEghyFaAHsBocReC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "eifgwUgHdNifEghyFaAHsBocReC");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_vePCZAITajLVfVHZFqBmFqPAEEW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "vePCZAITajLVfVHZFqBmFqPAEEW");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_YXRXinZklqHHAclErDcWIZHoebQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "YXRXinZklqHHAclErDcWIZHoebQ");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_LHajsyTiAFkVYZYLUhMHuovxdgNj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "LHajsyTiAFkVYZYLUhMHuovxdgNj");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_kwTykwWHXHEKpWvjavEdVpJdyjJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "kwTykwWHXHEKpWvjavEdVpJdyjJ");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_aubXVqlQHvlIjIqVQpsvWjzuwnP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, "aubXVqlQHvlIjIqVQpsvWjzuwnP");
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, 100664770);
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, 100664771);
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, 100664772);
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, 100664773);
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, 100664774);
				TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr, 100664775);
			}

			// Token: 0x0600391B RID: 14619 RVA: 0x001169F4 File Offset: 0x00114BF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249085, XrefRangeEnd = 249086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001112 RID: 4370
			// (get) Token: 0x0600391C RID: 14620 RVA: 0x00116A30 File Offset: 0x00114C30
			public unsafe global::Il2CppSystem.Object lGWADsAPVgBuVCpEAGGxMFmASVGL
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600391D RID: 14621 RVA: 0x00116A70 File Offset: 0x00114C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249086, XrefRangeEnd = 249091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600391E RID: 14622 RVA: 0x00116AA4 File Offset: 0x00114CA4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001113 RID: 4371
			// (get) Token: 0x0600391F RID: 14623 RVA: 0x00116AD8 File Offset: 0x00114CD8
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003920 RID: 14624 RVA: 0x00116B18 File Offset: 0x00114D18
			[CallerCount(0)]
			public unsafe IFyyImeRFRimEqQaeNbRiiNIdj(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003921 RID: 14625 RVA: 0x00013FB0 File Offset: 0x000121B0
			public IFyyImeRFRimEqQaeNbRiiNIdj(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001106 RID: 4358
			// (get) Token: 0x06003922 RID: 14626 RVA: 0x00116B60 File Offset: 0x00114D60
			// (set) Token: 0x06003923 RID: 14627 RVA: 0x00013FB9 File Offset: 0x000121B9
			public unsafe global::Il2CppSystem.Object NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001107 RID: 4359
			// (get) Token: 0x06003924 RID: 14628 RVA: 0x00116B90 File Offset: 0x00114D90
			// (set) Token: 0x06003925 RID: 14629 RVA: 0x00013FD8 File Offset: 0x000121D8
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x17001108 RID: 4360
			// (get) Token: 0x06003926 RID: 14630 RVA: 0x00116BB8 File Offset: 0x00114DB8
			// (set) Token: 0x06003927 RID: 14631 RVA: 0x00013FF3 File Offset: 0x000121F3
			public unsafe TouchButton HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001109 RID: 4361
			// (get) Token: 0x06003928 RID: 14632 RVA: 0x00116BE8 File Offset: 0x00114DE8
			// (set) Token: 0x06003929 RID: 14633 RVA: 0x00014012 File Offset: 0x00012212
			public unsafe Vector2 HqNOVSqyZgsPCXRbncuLhQsCKCrG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_HqNOVSqyZgsPCXRbncuLhQsCKCrG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_HqNOVSqyZgsPCXRbncuLhQsCKCrG)) = value;
				}
			}

			// Token: 0x1700110A RID: 4362
			// (get) Token: 0x0600392A RID: 14634 RVA: 0x00116C10 File Offset: 0x00114E10
			// (set) Token: 0x0600392B RID: 14635 RVA: 0x0001402D File Offset: 0x0001222D
			public unsafe PositionType BqySXaTZmKleAPNHvEeZQpiiNfv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_BqySXaTZmKleAPNHvEeZQpiiNfv);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_BqySXaTZmKleAPNHvEeZQpiiNfv)) = value;
				}
			}

			// Token: 0x1700110B RID: 4363
			// (get) Token: 0x0600392C RID: 14636 RVA: 0x00116C38 File Offset: 0x00114E38
			// (set) Token: 0x0600392D RID: 14637 RVA: 0x00014048 File Offset: 0x00012248
			public unsafe float CUfEqFiNWSnIAsqKObGFeXEtaaKb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_CUfEqFiNWSnIAsqKObGFeXEtaaKb);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_CUfEqFiNWSnIAsqKObGFeXEtaaKb)) = value;
				}
			}

			// Token: 0x1700110C RID: 4364
			// (get) Token: 0x0600392E RID: 14638 RVA: 0x00116C60 File Offset: 0x00114E60
			// (set) Token: 0x0600392F RID: 14639 RVA: 0x00014063 File Offset: 0x00012263
			public unsafe TouchButton.OnblsOyajJhlGzXGxhVSRFdUfck eifgwUgHdNifEghyFaAHsBocReC
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_eifgwUgHdNifEghyFaAHsBocReC);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_eifgwUgHdNifEghyFaAHsBocReC)) = value;
				}
			}

			// Token: 0x1700110D RID: 4365
			// (get) Token: 0x06003930 RID: 14640 RVA: 0x00116C88 File Offset: 0x00114E88
			// (set) Token: 0x06003931 RID: 14641 RVA: 0x0001407E File Offset: 0x0001227E
			public unsafe RectTransform vePCZAITajLVfVHZFqBmFqPAEEW
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_vePCZAITajLVfVHZFqBmFqPAEEW);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_vePCZAITajLVfVHZFqBmFqPAEEW), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110E RID: 4366
			// (get) Token: 0x06003932 RID: 14642 RVA: 0x00116CB8 File Offset: 0x00114EB8
			// (set) Token: 0x06003933 RID: 14643 RVA: 0x0001409D File Offset: 0x0001229D
			public unsafe Vector2 YXRXinZklqHHAclErDcWIZHoebQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_YXRXinZklqHHAclErDcWIZHoebQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_YXRXinZklqHHAclErDcWIZHoebQ)) = value;
				}
			}

			// Token: 0x1700110F RID: 4367
			// (get) Token: 0x06003934 RID: 14644 RVA: 0x00116CE0 File Offset: 0x00114EE0
			// (set) Token: 0x06003935 RID: 14645 RVA: 0x000140B8 File Offset: 0x000122B8
			public unsafe float LHajsyTiAFkVYZYLUhMHuovxdgNj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_LHajsyTiAFkVYZYLUhMHuovxdgNj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_LHajsyTiAFkVYZYLUhMHuovxdgNj)) = value;
				}
			}

			// Token: 0x17001110 RID: 4368
			// (get) Token: 0x06003936 RID: 14646 RVA: 0x00116D08 File Offset: 0x00114F08
			// (set) Token: 0x06003937 RID: 14647 RVA: 0x000140D3 File Offset: 0x000122D3
			public unsafe float kwTykwWHXHEKpWvjavEdVpJdyjJ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_kwTykwWHXHEKpWvjavEdVpJdyjJ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_kwTykwWHXHEKpWvjavEdVpJdyjJ)) = value;
				}
			}

			// Token: 0x17001111 RID: 4369
			// (get) Token: 0x06003938 RID: 14648 RVA: 0x00116D30 File Offset: 0x00114F30
			// (set) Token: 0x06003939 RID: 14649 RVA: 0x000140EE File Offset: 0x000122EE
			public unsafe float aubXVqlQHvlIjIqVQpsvWjzuwnP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_aubXVqlQHvlIjIqVQpsvWjzuwnP);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButton.IFyyImeRFRimEqQaeNbRiiNIdj.NativeFieldInfoPtr_aubXVqlQHvlIjIqVQpsvWjzuwnP)) = value;
				}
			}

			// Token: 0x04003037 RID: 12343
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003038 RID: 12344
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003039 RID: 12345
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x0400303A RID: 12346
			private static readonly IntPtr NativeFieldInfoPtr_HqNOVSqyZgsPCXRbncuLhQsCKCrG;

			// Token: 0x0400303B RID: 12347
			private static readonly IntPtr NativeFieldInfoPtr_BqySXaTZmKleAPNHvEeZQpiiNfv;

			// Token: 0x0400303C RID: 12348
			private static readonly IntPtr NativeFieldInfoPtr_CUfEqFiNWSnIAsqKObGFeXEtaaKb;

			// Token: 0x0400303D RID: 12349
			private static readonly IntPtr NativeFieldInfoPtr_eifgwUgHdNifEghyFaAHsBocReC;

			// Token: 0x0400303E RID: 12350
			private static readonly IntPtr NativeFieldInfoPtr_vePCZAITajLVfVHZFqBmFqPAEEW;

			// Token: 0x0400303F RID: 12351
			private static readonly IntPtr NativeFieldInfoPtr_YXRXinZklqHHAclErDcWIZHoebQ;

			// Token: 0x04003040 RID: 12352
			private static readonly IntPtr NativeFieldInfoPtr_LHajsyTiAFkVYZYLUhMHuovxdgNj;

			// Token: 0x04003041 RID: 12353
			private static readonly IntPtr NativeFieldInfoPtr_kwTykwWHXHEKpWvjavEdVpJdyjJ;

			// Token: 0x04003042 RID: 12354
			private static readonly IntPtr NativeFieldInfoPtr_aubXVqlQHvlIjIqVQpsvWjzuwnP;

			// Token: 0x04003043 RID: 12355
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003044 RID: 12356
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003045 RID: 12357
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003046 RID: 12358
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003047 RID: 12359
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003048 RID: 12360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
