using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.UI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x02000049 RID: 73
	[Serializable]
	public class TouchInteractable : TouchControl
	{
		// Token: 0x060005D1 RID: 1489 RVA: 0x00043F34 File Offset: 0x00042134
		// Note: this type is marked as 'beforefieldinit'.
		static TouchInteractable()
		{
			Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "TouchInteractable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr);
			TouchInteractable.NativeFieldInfoPtr_POINTER_ID_NULL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "POINTER_ID_NULL");
			TouchInteractable.NativeFieldInfoPtr_POINTER_ID_MOUSE_LEFT_BUTTON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "POINTER_ID_MOUSE_LEFT_BUTTON");
			TouchInteractable.NativeFieldInfoPtr_POINTER_ID_MOUSE_RIGHT_BUTTON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "POINTER_ID_MOUSE_RIGHT_BUTTON");
			TouchInteractable.NativeFieldInfoPtr_POINTER_ID_MOUSE_MIDDLE_BUTTON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "POINTER_ID_MOUSE_MIDDLE_BUTTON");
			TouchInteractable.NativeFieldInfoPtr_MAX_MOUSE_BUTTONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "MAX_MOUSE_BUTTONS");
			TouchInteractable.NativeFieldInfoPtr__interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_interactable");
			TouchInteractable.NativeFieldInfoPtr__visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_visible");
			TouchInteractable.NativeFieldInfoPtr__hideWhenIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_hideWhenIdle");
			TouchInteractable.NativeFieldInfoPtr__allowedMouseButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_allowedMouseButtons");
			TouchInteractable.NativeFieldInfoPtr__transitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_transitionType");
			TouchInteractable.NativeFieldInfoPtr__transitionColorTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_transitionColorTint");
			TouchInteractable.NativeFieldInfoPtr__transitionSpriteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_transitionSpriteState");
			TouchInteractable.NativeFieldInfoPtr__transitionAnimationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_transitionAnimationTriggers");
			TouchInteractable.NativeFieldInfoPtr__targetGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_targetGraphic");
			TouchInteractable.NativeFieldInfoPtr__onInteractionStateTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_onInteractionStateTransition");
			TouchInteractable.NativeFieldInfoPtr__onVisibilityChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_onVisibilityChanged");
			TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_onInteractionStateChangedToNormal");
			TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToHighlighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_onInteractionStateChangedToHighlighted");
			TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_onInteractionStateChangedToPressed");
			TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_onInteractionStateChangedToDisabled");
			TouchInteractable.NativeFieldInfoPtr__canvasGroupCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_canvasGroupCache");
			TouchInteractable.NativeFieldInfoPtr__groupsAllowInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_groupsAllowInteraction");
			TouchInteractable.NativeFieldInfoPtr__interactionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_interactionState");
			TouchInteractable.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "xISHKSqmxBFBXboSBVekNAulortJ");
			TouchInteractable.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "AJKoOMhkVHACBErfSbaQmDfyxZV");
			TouchInteractable.NativeFieldInfoPtr__varWatch_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_varWatch_visible");
			TouchInteractable.NativeFieldInfoPtr__varWatch_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_varWatch_interactable");
			TouchInteractable.NativeFieldInfoPtr__allowSendingEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_allowSendingEvents");
			TouchInteractable.NativeFieldInfoPtr__transitionArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "_transitionArgs");
			TouchInteractable.NativeFieldInfoPtr___hierarchyVisibilityChangedHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "__hierarchyVisibilityChangedHandlers");
			TouchInteractable.NativeFieldInfoPtr___hierarchyInteractionStateTransitionHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "__hierarchyInteractionStateTransitionHandlers");
			TouchInteractable.NativeFieldInfoPtr___interactionStateTransitionHandlerDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "__interactionStateTransitionHandlerDelegate");
			TouchInteractable.NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "CS$<>9__CachedAnonymousMethodDelegate4");
			TouchInteractable.NativeMethodInfoPtr_add_InteractionStateSetEvent_Public_add_Void_UnityAction_1_InteractionStateTransitionArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664274);
			TouchInteractable.NativeMethodInfoPtr_remove_InteractionStateSetEvent_Public_rem_Void_UnityAction_1_InteractionStateTransitionArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664275);
			TouchInteractable.NativeMethodInfoPtr_add_VisibilityChangedEvent_Public_add_Void_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664276);
			TouchInteractable.NativeMethodInfoPtr_remove_VisibilityChangedEvent_Public_rem_Void_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664277);
			TouchInteractable.NativeMethodInfoPtr_add_InteractionStateChangedToNormal_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664278);
			TouchInteractable.NativeMethodInfoPtr_remove_InteractionStateChangedToNormal_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664279);
			TouchInteractable.NativeMethodInfoPtr_add_InteractionStateChangedToHighlighted_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664280);
			TouchInteractable.NativeMethodInfoPtr_remove_InteractionStateChangedToHighlighted_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664281);
			TouchInteractable.NativeMethodInfoPtr_add_InteractionStateChangedToPressed_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664282);
			TouchInteractable.NativeMethodInfoPtr_remove_InteractionStateChangedToPressed_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664283);
			TouchInteractable.NativeMethodInfoPtr_add_InteractionStateChangedToDisabled_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664284);
			TouchInteractable.NativeMethodInfoPtr_remove_InteractionStateChangedToDisabled_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664285);
			TouchInteractable.NativeMethodInfoPtr_get_hierarchyVisibilityChangedHandlers_Private_get_HierarchyEventHelper_2_IVisibilityChangedHandler_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664286);
			TouchInteractable.NativeMethodInfoPtr_get_hierarchyInteractionStateTransitionHandlers_Private_get_HierarchyEventHelper_2_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664287);
			TouchInteractable.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664288);
			TouchInteractable.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664289);
			TouchInteractable.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664290);
			TouchInteractable.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664291);
			TouchInteractable.NativeMethodInfoPtr_get_hideWhenIdle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664292);
			TouchInteractable.NativeMethodInfoPtr_set_hideWhenIdle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664293);
			TouchInteractable.NativeMethodInfoPtr_get_allowedMouseButtons_Public_get_MouseButtonFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664294);
			TouchInteractable.NativeMethodInfoPtr_set_allowedMouseButtons_Public_set_Void_MouseButtonFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664295);
			TouchInteractable.NativeMethodInfoPtr_get_transitionType_Public_get_TransitionTypeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664296);
			TouchInteractable.NativeMethodInfoPtr_set_transitionType_Public_set_Void_TransitionTypeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664297);
			TouchInteractable.NativeMethodInfoPtr_get_transitionColorTint_Public_get_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664298);
			TouchInteractable.NativeMethodInfoPtr_set_transitionColorTint_Public_set_Void_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664299);
			TouchInteractable.NativeMethodInfoPtr_get_transitionSpriteState_Public_get_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664300);
			TouchInteractable.NativeMethodInfoPtr_set_transitionSpriteState_Public_set_Void_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664301);
			TouchInteractable.NativeMethodInfoPtr_get_transitionAnimationTriggers_Public_get_AnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664302);
			TouchInteractable.NativeMethodInfoPtr_set_transitionAnimationTriggers_Public_set_Void_AnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664303);
			TouchInteractable.NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664304);
			TouchInteractable.NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664305);
			TouchInteractable.NativeMethodInfoPtr_get_image_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664306);
			TouchInteractable.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664307);
			TouchInteractable.NativeMethodInfoPtr_get_animator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664308);
			TouchInteractable.NativeMethodInfoPtr_get_interactionState_Public_get_InteractionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664309);
			TouchInteractable.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664310);
			TouchInteractable.NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664311);
			TouchInteractable.NativeMethodInfoPtr_OnCanvasGroupChanged_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664312);
			TouchInteractable.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664313);
			TouchInteractable.NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664314);
			TouchInteractable.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664315);
			TouchInteractable.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664316);
			TouchInteractable.NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664317);
			TouchInteractable.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664318);
			TouchInteractable.NativeMethodInfoPtr_AMTvavhAJFMZzkgIlyIMREPyico_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664319);
			TouchInteractable.NativeMethodInfoPtr_YPzyEwcWCPOkXhXcDWAUzOXyyVX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664320);
			TouchInteractable.NativeMethodInfoPtr_vIiGbQVpVOwnJzdNuCqvMLBrdUPb_Private_Void_InteractionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664321);
			TouchInteractable.NativeMethodInfoPtr_lqbyOQkiMqtTSHaLwWVyHDlZnTq_Private_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664322);
			TouchInteractable.NativeMethodInfoPtr_ufYoiZWDQoKqVxfNABfXoMNaCvFb_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664323);
			TouchInteractable.NativeMethodInfoPtr_lceHbganfbdhOUKTvhWNbmIhtZXK_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664324);
			TouchInteractable.NativeMethodInfoPtr_SNkEVJdvPsXhwCsTTSNXYRVKKvr_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664325);
			TouchInteractable.NativeMethodInfoPtr_IsInteractable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664326);
			TouchInteractable.NativeMethodInfoPtr_znFnGxyOXnvNJEFcIxRAkZPVPJH_Internal_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664327);
			TouchInteractable.NativeMethodInfoPtr_QbKJxkOCtOiwVZtLpxiyGGOjioU_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664328);
			TouchInteractable.NativeMethodInfoPtr_aalhwRqcbQhzQHPqjxaJDiTxaYyw_Internal_Virtual_New_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664329);
			TouchInteractable.NativeMethodInfoPtr_qIxIYmweKlrjcBMOEXWKOFiTliv_Private_Boolean_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664330);
			TouchInteractable.NativeMethodInfoPtr_qIxIYmweKlrjcBMOEXWKOFiTliv_Private_Boolean_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664331);
			TouchInteractable.NativeMethodInfoPtr_DVBxkWTNkjIHJjytmUnOjRZqDKFA_Private_InteractionState_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664332);
			TouchInteractable.NativeMethodInfoPtr_bWRMcfccqjFiAfZKmzqlPCqdSNmv_Private_Boolean_InteractionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664333);
			TouchInteractable.NativeMethodInfoPtr_sauMxetIPqugTJadbQriBqkRgjZ_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664334);
			TouchInteractable.NativeMethodInfoPtr_mIAFviVeyABVWOcZlDlbcawAXMW_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664335);
			TouchInteractable.NativeMethodInfoPtr_jiCgAYeThQbZBaNDTkJtkimAkEK_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664336);
			TouchInteractable.NativeMethodInfoPtr_LkMBdoeVUAqijzqacIwORTFVyvM_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664337);
			TouchInteractable.NativeMethodInfoPtr_PhJCjikfSaldYwoRmkMqkxasPaV_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664338);
			TouchInteractable.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664339);
			TouchInteractable.NativeMethodInfoPtr_XHLNLwJfRXiTxFRbxqrZgImmHkF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664340);
			TouchInteractable.NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664341);
			TouchInteractable.NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664342);
			TouchInteractable.NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664343);
			TouchInteractable.NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664344);
			TouchInteractable.NativeMethodInfoPtr_OnBeginDrag_Internal_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664345);
			TouchInteractable.NativeMethodInfoPtr_OnDrag_Internal_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664346);
			TouchInteractable.NativeMethodInfoPtr_OnEndDrag_Internal_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664347);
			TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664348);
			TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664349);
			TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerEnterHandler_OnPointerEnter_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664350);
			TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerExitHandler_OnPointerExit_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664351);
			TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IBeginDragHandler_OnBeginDrag_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664352);
			TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664353);
			TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IEndDragHandler_OnEndDrag_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664354);
			TouchInteractable.NativeMethodInfoPtr_wZtizzYGSaEuStvOklprpasJWbU_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664355);
			TouchInteractable.NativeMethodInfoPtr_TkPOLnJECphvFKbbhiMiJUuudVp_Internal_Static_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664356);
			TouchInteractable.NativeMethodInfoPtr_nIfTWSYUCrDkTTkCTkAaKgZSfbf_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664357);
			TouchInteractable.NativeMethodInfoPtr_ibSOmMfLVvKZYTGUccTYNagtdyHh_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664358);
			TouchInteractable.NativeMethodInfoPtr_AVRXVWaCruFLNjttxRJMiJVOmuY_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664359);
			TouchInteractable.NativeMethodInfoPtr_MjtLGtJBnmljRyGvgqqivdfzhvt_Internal_Static_Boolean_MouseButtonFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664360);
			TouchInteractable.NativeMethodInfoPtr_kWaEevAYyiGxynGBdjWGKBogXOq_Private_Static_Boolean_MouseButtonFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664361);
			TouchInteractable.NativeMethodInfoPtr_XcZHTeBxSrFAAWugExveTRLzIuj_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664362);
			TouchInteractable.NativeMethodInfoPtr_LCFWLrmkQQhbrxUhcjvhExmHRhT_Internal_Static_Boolean_MouseButtonFlags_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664363);
			TouchInteractable.NativeMethodInfoPtr_MjtLGtJBnmljRyGvgqqivdfzhvt_Internal_Static_Boolean_Int32_MouseButtonFlags_EventTriggerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664364);
			TouchInteractable.NativeMethodInfoPtr_VrFaVtHBgzcVzkJfTqeSnRYvZiNi_Internal_Static_Boolean_MouseButtonFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664365);
			TouchInteractable.NativeMethodInfoPtr_get_interactionStateTransitionHandlerDelegate_Internal_Static_get_EventFunction_2_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664366);
			TouchInteractable.NativeMethodInfoPtr_ayjSVyPEHeNxeDHyjhUqJhQmXQz_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664367);
			TouchInteractable.NativeMethodInfoPtr_yBMAbxDfzDATJCYjYWGjrfPYQPWE_Private_Static_Void_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, 100664368);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00044964 File Offset: 0x00042B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246305, XrefRangeEnd = 246310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_InteractionStateSetEvent(UnityAction<TouchInteractable.InteractionStateTransitionArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_add_InteractionStateSetEvent_Public_add_Void_UnityAction_1_InteractionStateTransitionArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000449A8 File Offset: 0x00042BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246310, XrefRangeEnd = 246313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_InteractionStateSetEvent(UnityAction<TouchInteractable.InteractionStateTransitionArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_remove_InteractionStateSetEvent_Public_rem_Void_UnityAction_1_InteractionStateTransitionArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000449EC File Offset: 0x00042BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246313, XrefRangeEnd = 246318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_VisibilityChangedEvent(UnityAction<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_add_VisibilityChangedEvent_Public_add_Void_UnityAction_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00044A30 File Offset: 0x00042C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246318, XrefRangeEnd = 246321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_VisibilityChangedEvent(UnityAction<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_remove_VisibilityChangedEvent_Public_rem_Void_UnityAction_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00044A74 File Offset: 0x00042C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246321, XrefRangeEnd = 246323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_InteractionStateChangedToNormal(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_add_InteractionStateChangedToNormal_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00044AB8 File Offset: 0x00042CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246323, XrefRangeEnd = 246325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_InteractionStateChangedToNormal(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_remove_InteractionStateChangedToNormal_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00044AFC File Offset: 0x00042CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246325, XrefRangeEnd = 246327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_InteractionStateChangedToHighlighted(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_add_InteractionStateChangedToHighlighted_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00044B40 File Offset: 0x00042D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246327, XrefRangeEnd = 246329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_InteractionStateChangedToHighlighted(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_remove_InteractionStateChangedToHighlighted_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00044B84 File Offset: 0x00042D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246329, XrefRangeEnd = 246331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_InteractionStateChangedToPressed(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_add_InteractionStateChangedToPressed_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00044BC8 File Offset: 0x00042DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246331, XrefRangeEnd = 246333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_InteractionStateChangedToPressed(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_remove_InteractionStateChangedToPressed_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00044C0C File Offset: 0x00042E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246333, XrefRangeEnd = 246335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_InteractionStateChangedToDisabled(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_add_InteractionStateChangedToDisabled_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00044C50 File Offset: 0x00042E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246335, XrefRangeEnd = 246337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_InteractionStateChangedToDisabled(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_remove_InteractionStateChangedToDisabled_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00044C94 File Offset: 0x00042E94
		public unsafe jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<IVisibilityChangedHandler, bool> hierarchyVisibilityChangedHandlers
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 246348, RefRangeEnd = 246354, XrefRangeStart = 246337, XrefRangeEnd = 246348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_hierarchyVisibilityChangedHandlers_Private_get_HierarchyEventHelper_2_IVisibilityChangedHandler_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<IVisibilityChangedHandler, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00044CD4 File Offset: 0x00042ED4
		public unsafe jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> hierarchyInteractionStateTransitionHandlers
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 246368, RefRangeEnd = 246370, XrefRangeStart = 246354, XrefRangeEnd = 246368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_hierarchyInteractionStateTransitionHandlers_Private_get_HierarchyEventHelper_2_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs>>(intPtr3) : null;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00044D14 File Offset: 0x00042F14
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00044D50 File Offset: 0x00042F50
		public unsafe bool interactable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00044D90 File Offset: 0x00042F90
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00044DCC File Offset: 0x00042FCC
		public unsafe bool visible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246370, XrefRangeEnd = 246371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00044E0C File Offset: 0x0004300C
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00044E48 File Offset: 0x00043048
		public unsafe bool hideWhenIdle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_hideWhenIdle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_set_hideWhenIdle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00044E88 File Offset: 0x00043088
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00044EC4 File Offset: 0x000430C4
		public unsafe TouchInteractable.MouseButtonFlags allowedMouseButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_allowedMouseButtons_Public_get_MouseButtonFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_set_allowedMouseButtons_Public_set_Void_MouseButtonFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00044F04 File Offset: 0x00043104
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00044F40 File Offset: 0x00043140
		public unsafe TouchInteractable.TransitionTypeFlags transitionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_transitionType_Public_get_TransitionTypeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_set_transitionType_Public_set_Void_TransitionTypeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00044F80 File Offset: 0x00043180
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00044FBC File Offset: 0x000431BC
		public unsafe ColorBlock transitionColorTint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_transitionColorTint_Public_get_ColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_set_transitionColorTint_Public_set_Void_ColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00044FFC File Offset: 0x000431FC
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00045034 File Offset: 0x00043234
		public unsafe SpriteState transitionSpriteState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_transitionSpriteState_Public_get_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SpriteState(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246371, XrefRangeEnd = 246372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_set_transitionSpriteState_Public_set_Void_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0004507C File Offset: 0x0004327C
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x000450BC File Offset: 0x000432BC
		public unsafe AnimationTriggers transitionAnimationTriggers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_transitionAnimationTriggers_Public_get_AnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_set_transitionAnimationTriggers_Public_set_Void_AnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00045100 File Offset: 0x00043300
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00045140 File Offset: 0x00043340
		public unsafe Graphic targetGraphic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246372, XrefRangeEnd = 246388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00045184 File Offset: 0x00043384
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x000451C4 File Offset: 0x000433C4
		public unsafe Image image
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 246389, RefRangeEnd = 246391, XrefRangeStart = 246388, XrefRangeEnd = 246389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_image_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246391, XrefRangeEnd = 246407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00045208 File Offset: 0x00043408
		public unsafe Animator animator
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 246415, RefRangeEnd = 246423, XrefRangeStart = 246407, XrefRangeEnd = 246415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_animator_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00045248 File Offset: 0x00043448
		public unsafe TouchInteractable.InteractionState interactionState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_interactionState_Public_get_InteractionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00045284 File Offset: 0x00043484
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246459, RefRangeEnd = 246463, XrefRangeStart = 246423, XrefRangeEnd = 246459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchInteractable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000452C0 File Offset: 0x000434C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246484, RefRangeEnd = 246488, XrefRangeStart = 246463, XrefRangeEnd = 246484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000452FC File Offset: 0x000434FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246488, XrefRangeEnd = 246519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasGroupChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnCanvasGroupChanged_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00045338 File Offset: 0x00043538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246519, XrefRangeEnd = 246520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00045374 File Offset: 0x00043574
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246537, RefRangeEnd = 246539, XrefRangeStart = 246520, XrefRangeEnd = 246537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000453B0 File Offset: 0x000435B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246544, RefRangeEnd = 246546, XrefRangeStart = 246539, XrefRangeEnd = 246544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000453EC File Offset: 0x000435EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 246598, RefRangeEnd = 246601, XrefRangeStart = 246546, XrefRangeEnd = 246598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00045428 File Offset: 0x00043628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246601, XrefRangeEnd = 246606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00045464 File Offset: 0x00043664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246606, XrefRangeEnd = 246609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000454A0 File Offset: 0x000436A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246609, XrefRangeEnd = 246610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AMTvavhAJFMZzkgIlyIMREPyico()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_AMTvavhAJFMZzkgIlyIMREPyico_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x000454DC File Offset: 0x000436DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246610, XrefRangeEnd = 246613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void YPzyEwcWCPOkXhXcDWAUzOXyyVX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_YPzyEwcWCPOkXhXcDWAUzOXyyVX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00045510 File Offset: 0x00043710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246645, RefRangeEnd = 246646, XrefRangeStart = 246613, XrefRangeEnd = 246645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void vIiGbQVpVOwnJzdNuCqvMLBrdUPb(TouchInteractable.InteractionState A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_vIiGbQVpVOwnJzdNuCqvMLBrdUPb_Private_Void_InteractionState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0004555C File Offset: 0x0004375C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246659, RefRangeEnd = 246663, XrefRangeStart = 246646, XrefRangeEnd = 246659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void lqbyOQkiMqtTSHaLwWVyHDlZnTq(Color A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_lqbyOQkiMqtTSHaLwWVyHDlZnTq_Private_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x000455A8 File Offset: 0x000437A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246678, RefRangeEnd = 246682, XrefRangeStart = 246663, XrefRangeEnd = 246678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ufYoiZWDQoKqVxfNABfXoMNaCvFb(Sprite A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_ufYoiZWDQoKqVxfNABfXoMNaCvFb_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000455EC File Offset: 0x000437EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246723, RefRangeEnd = 246727, XrefRangeStart = 246682, XrefRangeEnd = 246723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void lceHbganfbdhOUKTvhWNbmIhtZXK(string A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_lceHbganfbdhOUKTvhWNbmIhtZXK_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00045630 File Offset: 0x00043830
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 246732, RefRangeEnd = 246737, XrefRangeStart = 246727, XrefRangeEnd = 246732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SNkEVJdvPsXhwCsTTSNXYRVKKvr(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_SNkEVJdvPsXhwCsTTSNXYRVKKvr_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00045670 File Offset: 0x00043870
		[CallerCount(0)]
		public unsafe bool IsInteractable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_IsInteractable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000456AC File Offset: 0x000438AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246737, XrefRangeEnd = 246741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool znFnGxyOXnvNJEFcIxRAkZPVPJH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_znFnGxyOXnvNJEFcIxRAkZPVPJH_Internal_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000456F4 File Offset: 0x000438F4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 246753, RefRangeEnd = 246771, XrefRangeStart = 246741, XrefRangeEnd = 246753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QbKJxkOCtOiwVZtLpxiyGGOjioU(BaseEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_QbKJxkOCtOiwVZtLpxiyGGOjioU_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00045738 File Offset: 0x00043938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246783, RefRangeEnd = 246785, XrefRangeStart = 246771, XrefRangeEnd = 246783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool aalhwRqcbQhzQHPqjxaJDiTxaYyw(GameObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_aalhwRqcbQhzQHPqjxaJDiTxaYyw_Internal_Virtual_New_Boolean_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00045790 File Offset: 0x00043990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246785, XrefRangeEnd = 246791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool qIxIYmweKlrjcBMOEXWKOFiTliv(BaseEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_qIxIYmweKlrjcBMOEXWKOFiTliv_Private_Boolean_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000457E0 File Offset: 0x000439E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 246796, RefRangeEnd = 246799, XrefRangeStart = 246791, XrefRangeEnd = 246796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool qIxIYmweKlrjcBMOEXWKOFiTliv(bool A_1, GameObject A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_qIxIYmweKlrjcBMOEXWKOFiTliv_Private_Boolean_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0004583C File Offset: 0x00043A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246799, XrefRangeEnd = 246801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchInteractable.InteractionState DVBxkWTNkjIHJjytmUnOjRZqDKFA(BaseEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_DVBxkWTNkjIHJjytmUnOjRZqDKFA_Private_InteractionState_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0004588C File Offset: 0x00043A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246801, XrefRangeEnd = 246802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool bWRMcfccqjFiAfZKmzqlPCqdSNmv(TouchInteractable.InteractionState A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_bWRMcfccqjFiAfZKmzqlPCqdSNmv_Private_Boolean_InteractionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000458D8 File Offset: 0x00043AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246802, XrefRangeEnd = 246803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sauMxetIPqugTJadbQriBqkRgjZ()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_sauMxetIPqugTJadbQriBqkRgjZ_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0004590C File Offset: 0x00043B0C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 246806, RefRangeEnd = 246812, XrefRangeStart = 246803, XrefRangeEnd = 246806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void mIAFviVeyABVWOcZlDlbcawAXMW()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_mIAFviVeyABVWOcZlDlbcawAXMW_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00045940 File Offset: 0x00043B40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246818, RefRangeEnd = 246822, XrefRangeStart = 246812, XrefRangeEnd = 246818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void jiCgAYeThQbZBaNDTkJtkimAkEK(bool A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_jiCgAYeThQbZBaNDTkJtkimAkEK_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0004598C File Offset: 0x00043B8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246851, RefRangeEnd = 246853, XrefRangeStart = 246822, XrefRangeEnd = 246851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LkMBdoeVUAqijzqacIwORTFVyvM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_LkMBdoeVUAqijzqacIwORTFVyvM_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000459C0 File Offset: 0x00043BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246853, XrefRangeEnd = 246859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhJCjikfSaldYwoRmkMqkxasPaV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_PhJCjikfSaldYwoRmkMqkxasPaV_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000459F4 File Offset: 0x00043BF4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 246873, RefRangeEnd = 246880, XrefRangeStart = 246859, XrefRangeEnd = 246873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void iJzeeVgTFhPQqdRTfUGBACRnMOF()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00045A28 File Offset: 0x00043C28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246897, RefRangeEnd = 246901, XrefRangeStart = 246880, XrefRangeEnd = 246897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void XHLNLwJfRXiTxFRbxqrZgImmHkF()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_XHLNLwJfRXiTxFRbxqrZgImmHkF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00045A5C File Offset: 0x00043C5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246906, RefRangeEnd = 246910, XrefRangeStart = 246901, XrefRangeEnd = 246906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00045AAC File Offset: 0x00043CAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 246915, RefRangeEnd = 246920, XrefRangeStart = 246910, XrefRangeEnd = 246915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00045AFC File Offset: 0x00043CFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246925, RefRangeEnd = 246926, XrefRangeStart = 246920, XrefRangeEnd = 246925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00045B4C File Offset: 0x00043D4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246931, RefRangeEnd = 246935, XrefRangeStart = 246926, XrefRangeEnd = 246931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00045B9C File Offset: 0x00043D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246935, XrefRangeEnd = 246940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnBeginDrag_Internal_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00045BEC File Offset: 0x00043DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246940, XrefRangeEnd = 246945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnDrag_Internal_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00045C3C File Offset: 0x00043E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246945, XrefRangeEnd = 246950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.NativeMethodInfoPtr_OnEndDrag_Internal_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00045C8C File Offset: 0x00043E8C
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00045CD0 File Offset: 0x00043ED0
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00045D14 File Offset: 0x00043F14
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_EventSystems_IPointerEnterHandler_OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerEnterHandler_OnPointerEnter_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00045D58 File Offset: 0x00043F58
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_EventSystems_IPointerExitHandler_OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerExitHandler_OnPointerExit_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00045D9C File Offset: 0x00043F9C
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_EventSystems_IBeginDragHandler_OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IBeginDragHandler_OnBeginDrag_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00045DE0 File Offset: 0x00043FE0
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_EventSystems_IDragHandler_OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00045E24 File Offset: 0x00044024
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_EventSystems_IEndDragHandler_OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_UnityEngine_EventSystems_IEndDragHandler_OnEndDrag_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00045E68 File Offset: 0x00044068
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 246969, RefRangeEnd = 246980, XrefRangeStart = 246950, XrefRangeEnd = 246969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool wZtizzYGSaEuStvOklprpasJWbU(int A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_wZtizzYGSaEuStvOklprpasJWbU_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00045EA8 File Offset: 0x000440A8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 246998, RefRangeEnd = 247009, XrefRangeStart = 246980, XrefRangeEnd = 246998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 TkPOLnJECphvFKbbhiMiJUuudVp(int A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_TkPOLnJECphvFKbbhiMiJUuudVp_Internal_Static_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00045EE8 File Offset: 0x000440E8
		[CallerCount(0)]
		public unsafe static bool nIfTWSYUCrDkTTkCTkAaKgZSfbf(int A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_nIfTWSYUCrDkTTkCTkAaKgZSfbf_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00045F28 File Offset: 0x00044128
		[CallerCount(0)]
		public unsafe static bool ibSOmMfLVvKZYTGUccTYNagtdyHh(int A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_ibSOmMfLVvKZYTGUccTYNagtdyHh_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00045F68 File Offset: 0x00044168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247016, RefRangeEnd = 247018, XrefRangeStart = 247009, XrefRangeEnd = 247016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AVRXVWaCruFLNjttxRJMiJVOmuY(int A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_AVRXVWaCruFLNjttxRJMiJVOmuY_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00045FA8 File Offset: 0x000441A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247018, XrefRangeEnd = 247032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MjtLGtJBnmljRyGvgqqivdfzhvt(TouchInteractable.MouseButtonFlags A_0, int A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_MjtLGtJBnmljRyGvgqqivdfzhvt_Internal_Static_Boolean_MouseButtonFlags_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00045FF4 File Offset: 0x000441F4
		[CallerCount(0)]
		public unsafe static bool kWaEevAYyiGxynGBdjWGKBogXOq(TouchInteractable.MouseButtonFlags A_0, int A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_kWaEevAYyiGxynGBdjWGKBogXOq_Private_Static_Boolean_MouseButtonFlags_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00046040 File Offset: 0x00044240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247032, XrefRangeEnd = 247035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int XcZHTeBxSrFAAWugExveTRLzIuj(int A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_XcZHTeBxSrFAAWugExveTRLzIuj_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00046080 File Offset: 0x00044280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247035, XrefRangeEnd = 247036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LCFWLrmkQQhbrxUhcjvhExmHRhT(TouchInteractable.MouseButtonFlags A_0, out int A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_LCFWLrmkQQhbrxUhcjvhExmHRhT_Internal_Static_Boolean_MouseButtonFlags_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000460CC File Offset: 0x000442CC
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 247056, RefRangeEnd = 247112, XrefRangeStart = 247036, XrefRangeEnd = 247056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MjtLGtJBnmljRyGvgqqivdfzhvt(int A_0, TouchInteractable.MouseButtonFlags A_1, EventTriggerType A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_MjtLGtJBnmljRyGvgqqivdfzhvt_Internal_Static_Boolean_Int32_MouseButtonFlags_EventTriggerType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00046128 File Offset: 0x00044328
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247116, RefRangeEnd = 247119, XrefRangeStart = 247112, XrefRangeEnd = 247116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool VrFaVtHBgzcVzkJfTqeSnRYvZiNi(TouchInteractable.MouseButtonFlags A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_VrFaVtHBgzcVzkJfTqeSnRYvZiNi_Internal_Static_Boolean_MouseButtonFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00046168 File Offset: 0x00044368
		public unsafe static jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> interactionStateTransitionHandlerDelegate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 247140, RefRangeEnd = 247141, XrefRangeStart = 247119, XrefRangeEnd = 247140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_get_interactionStateTransitionHandlerDelegate_Internal_Static_get_EventFunction_2_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs>>(intPtr3) : null;
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0004619C File Offset: 0x0004439C
		[CallerCount(0)]
		public unsafe void ayjSVyPEHeNxeDHyjhUqJhQmXQz(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_ayjSVyPEHeNxeDHyjhUqJhQmXQz_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000461DC File Offset: 0x000443DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247141, XrefRangeEnd = 247151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void yBMAbxDfzDATJCYjYWGjrfPYQPWE(TouchInteractable.IInteractionStateTransitionHandler A_0, TouchInteractable.InteractionStateTransitionArgs A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.NativeMethodInfoPtr_yBMAbxDfzDATJCYjYWGjrfPYQPWE_Private_Static_Void_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00003DB0 File Offset: 0x00001FB0
		public TouchInteractable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00046224 File Offset: 0x00044424
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00003DB9 File Offset: 0x00001FB9
		public unsafe static int POINTER_ID_NULL
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TouchInteractable.NativeFieldInfoPtr_POINTER_ID_NULL, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchInteractable.NativeFieldInfoPtr_POINTER_ID_NULL, (void*)(&value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00046240 File Offset: 0x00044440
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00003DC7 File Offset: 0x00001FC7
		public unsafe static int POINTER_ID_MOUSE_LEFT_BUTTON
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TouchInteractable.NativeFieldInfoPtr_POINTER_ID_MOUSE_LEFT_BUTTON, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchInteractable.NativeFieldInfoPtr_POINTER_ID_MOUSE_LEFT_BUTTON, (void*)(&value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x0004625C File Offset: 0x0004445C
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00003DD5 File Offset: 0x00001FD5
		public unsafe static int POINTER_ID_MOUSE_RIGHT_BUTTON
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TouchInteractable.NativeFieldInfoPtr_POINTER_ID_MOUSE_RIGHT_BUTTON, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchInteractable.NativeFieldInfoPtr_POINTER_ID_MOUSE_RIGHT_BUTTON, (void*)(&value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00046278 File Offset: 0x00044478
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x00003DE3 File Offset: 0x00001FE3
		public unsafe static int POINTER_ID_MOUSE_MIDDLE_BUTTON
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TouchInteractable.NativeFieldInfoPtr_POINTER_ID_MOUSE_MIDDLE_BUTTON, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchInteractable.NativeFieldInfoPtr_POINTER_ID_MOUSE_MIDDLE_BUTTON, (void*)(&value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00046294 File Offset: 0x00044494
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00003DF1 File Offset: 0x00001FF1
		public unsafe static int MAX_MOUSE_BUTTONS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TouchInteractable.NativeFieldInfoPtr_MAX_MOUSE_BUTTONS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchInteractable.NativeFieldInfoPtr_MAX_MOUSE_BUTTONS, (void*)(&value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x000462B0 File Offset: 0x000444B0
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00003DFF File Offset: 0x00001FFF
		public unsafe bool _interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__interactable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__interactable)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x000462D8 File Offset: 0x000444D8
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00003E1A File Offset: 0x0000201A
		public unsafe bool _visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__visible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__visible)) = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00046300 File Offset: 0x00044500
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00003E35 File Offset: 0x00002035
		public unsafe bool _hideWhenIdle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__hideWhenIdle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__hideWhenIdle)) = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00046328 File Offset: 0x00044528
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00003E50 File Offset: 0x00002050
		public unsafe TouchInteractable.MouseButtonFlags _allowedMouseButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__allowedMouseButtons);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__allowedMouseButtons)) = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00046350 File Offset: 0x00044550
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00003E6B File Offset: 0x0000206B
		public unsafe TouchInteractable.TransitionTypeFlags _transitionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__transitionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__transitionType)) = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00046378 File Offset: 0x00044578
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00003E86 File Offset: 0x00002086
		public unsafe ColorBlock _transitionColorTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__transitionColorTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__transitionColorTint)) = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x000463A0 File Offset: 0x000445A0
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00003EA1 File Offset: 0x000020A1
		public SpriteState _transitionSpriteState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__transitionSpriteState);
				return new SpriteState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__transitionSpriteState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x000463D0 File Offset: 0x000445D0
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00003ECF File Offset: 0x000020CF
		public unsafe AnimationTriggers _transitionAnimationTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__transitionAnimationTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__transitionAnimationTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00046400 File Offset: 0x00044600
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00003EEE File Offset: 0x000020EE
		public unsafe Graphic _targetGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__targetGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__targetGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00046430 File Offset: 0x00044630
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00003F0D File Offset: 0x0000210D
		public unsafe TouchInteractable.InteractionStateTransitionEventHandler _onInteractionStateTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onInteractionStateTransition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchInteractable.InteractionStateTransitionEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onInteractionStateTransition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00046460 File Offset: 0x00044660
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00003F2C File Offset: 0x0000212C
		public unsafe TouchInteractable.VisibilityChangedEventHandler _onVisibilityChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onVisibilityChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchInteractable.VisibilityChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onVisibilityChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00046490 File Offset: 0x00044690
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00003F4B File Offset: 0x0000214B
		public unsafe UnityEvent _onInteractionStateChangedToNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x000464C0 File Offset: 0x000446C0
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00003F6A File Offset: 0x0000216A
		public unsafe UnityEvent _onInteractionStateChangedToHighlighted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToHighlighted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToHighlighted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x000464F0 File Offset: 0x000446F0
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00003F89 File Offset: 0x00002189
		public unsafe UnityEvent _onInteractionStateChangedToPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToPressed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00046520 File Offset: 0x00044720
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00003FA8 File Offset: 0x000021A8
		public unsafe UnityEvent _onInteractionStateChangedToDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__onInteractionStateChangedToDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00046550 File Offset: 0x00044750
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00003FC7 File Offset: 0x000021C7
		public unsafe List<CanvasGroup> _canvasGroupCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__canvasGroupCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__canvasGroupCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00046580 File Offset: 0x00044780
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00003FE6 File Offset: 0x000021E6
		public unsafe bool _groupsAllowInteraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__groupsAllowInteraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__groupsAllowInteraction)) = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x000465A8 File Offset: 0x000447A8
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00004001 File Offset: 0x00002201
		public unsafe TouchInteractable.InteractionState _interactionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__interactionState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__interactionState)) = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x000465D0 File Offset: 0x000447D0
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x0000401C File Offset: 0x0000221C
		public unsafe bool xISHKSqmxBFBXboSBVekNAulortJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ)) = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x000465F8 File Offset: 0x000447F8
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00004037 File Offset: 0x00002237
		public unsafe bool AJKoOMhkVHACBErfSbaQmDfyxZV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV)) = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00046620 File Offset: 0x00044820
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00004052 File Offset: 0x00002252
		public unsafe bool _varWatch_visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__varWatch_visible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__varWatch_visible)) = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00046648 File Offset: 0x00044848
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x0000406D File Offset: 0x0000226D
		public unsafe bool _varWatch_interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__varWatch_interactable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__varWatch_interactable)) = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00046670 File Offset: 0x00044870
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00004088 File Offset: 0x00002288
		public unsafe bool _allowSendingEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__allowSendingEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr__allowSendingEvents)) = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00046698 File Offset: 0x00044898
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x000040A3 File Offset: 0x000022A3
		public unsafe static TouchInteractable.InteractionStateTransitionArgs _transitionArgs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TouchInteractable.NativeFieldInfoPtr__transitionArgs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchInteractable.InteractionStateTransitionArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchInteractable.NativeFieldInfoPtr__transitionArgs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000466C0 File Offset: 0x000448C0
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x000040B5 File Offset: 0x000022B5
		public unsafe jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<IVisibilityChangedHandler, bool> __hierarchyVisibilityChangedHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr___hierarchyVisibilityChangedHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<IVisibilityChangedHandler, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr___hierarchyVisibilityChangedHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x000466F0 File Offset: 0x000448F0
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x000040D4 File Offset: 0x000022D4
		public unsafe jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> __hierarchyInteractionStateTransitionHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr___hierarchyInteractionStateTransitionHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.NativeFieldInfoPtr___hierarchyInteractionStateTransitionHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00046720 File Offset: 0x00044920
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x000040F3 File Offset: 0x000022F3
		public unsafe static jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> __interactionStateTransitionHandlerDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TouchInteractable.NativeFieldInfoPtr___interactionStateTransitionHandlerDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchInteractable.NativeFieldInfoPtr___interactionStateTransitionHandlerDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00046748 File Offset: 0x00044948
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00004105 File Offset: 0x00002305
		public unsafe static jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> field_Private_Static_EventFunction_2_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TouchInteractable.NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchInteractable.NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr_POINTER_ID_NULL;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_POINTER_ID_MOUSE_LEFT_BUTTON;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr_POINTER_ID_MOUSE_RIGHT_BUTTON;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_POINTER_ID_MOUSE_MIDDLE_BUTTON;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_MAX_MOUSE_BUTTONS;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeFieldInfoPtr__interactable;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeFieldInfoPtr__visible;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeFieldInfoPtr__hideWhenIdle;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeFieldInfoPtr__allowedMouseButtons;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr__transitionType;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeFieldInfoPtr__transitionColorTint;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeFieldInfoPtr__transitionSpriteState;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeFieldInfoPtr__transitionAnimationTriggers;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr__targetGraphic;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeFieldInfoPtr__onInteractionStateTransition;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr__onVisibilityChanged;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeFieldInfoPtr__onInteractionStateChangedToNormal;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeFieldInfoPtr__onInteractionStateChangedToHighlighted;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr__onInteractionStateChangedToPressed;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr__onInteractionStateChangedToDisabled;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr__canvasGroupCache;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr__groupsAllowInteraction;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr__interactionState;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr__varWatch_visible;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr__varWatch_interactable;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr__allowSendingEvents;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr__transitionArgs;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr___hierarchyVisibilityChangedHandlers;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr___hierarchyInteractionStateTransitionHandlers;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr___interactionStateTransitionHandlerDelegate;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_add_InteractionStateSetEvent_Public_add_Void_UnityAction_1_InteractionStateTransitionArgs_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_remove_InteractionStateSetEvent_Public_rem_Void_UnityAction_1_InteractionStateTransitionArgs_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_add_VisibilityChangedEvent_Public_add_Void_UnityAction_1_Boolean_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_remove_VisibilityChangedEvent_Public_rem_Void_UnityAction_1_Boolean_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_add_InteractionStateChangedToNormal_Public_add_Void_UnityAction_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_remove_InteractionStateChangedToNormal_Public_rem_Void_UnityAction_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_add_InteractionStateChangedToHighlighted_Public_add_Void_UnityAction_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_remove_InteractionStateChangedToHighlighted_Public_rem_Void_UnityAction_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_add_InteractionStateChangedToPressed_Public_add_Void_UnityAction_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_remove_InteractionStateChangedToPressed_Public_rem_Void_UnityAction_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_add_InteractionStateChangedToDisabled_Public_add_Void_UnityAction_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_remove_InteractionStateChangedToDisabled_Public_rem_Void_UnityAction_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_get_hierarchyVisibilityChangedHandlers_Private_get_HierarchyEventHelper_2_IVisibilityChangedHandler_Boolean_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_get_hierarchyInteractionStateTransitionHandlers_Private_get_HierarchyEventHelper_2_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_get_visible_Public_get_Boolean_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_get_hideWhenIdle_Public_get_Boolean_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_set_hideWhenIdle_Public_set_Void_Boolean_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_get_allowedMouseButtons_Public_get_MouseButtonFlags_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_set_allowedMouseButtons_Public_set_Void_MouseButtonFlags_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionType_Public_get_TransitionTypeFlags_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_set_transitionType_Public_set_Void_TransitionTypeFlags_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionColorTint_Public_get_ColorBlock_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_set_transitionColorTint_Public_set_Void_ColorBlock_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionSpriteState_Public_get_SpriteState_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_set_transitionSpriteState_Public_set_Void_SpriteState_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionAnimationTriggers_Public_get_AnimationTriggers_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_set_transitionAnimationTriggers_Public_set_Void_AnimationTriggers_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Image_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Image_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_get_animator_Public_get_Animator_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_get_interactionState_Public_get_InteractionState_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasGroupChanged_Internal_Virtual_Void_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Internal_Virtual_Void_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_AMTvavhAJFMZzkgIlyIMREPyico_Internal_Virtual_Void_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_YPzyEwcWCPOkXhXcDWAUzOXyyVX_Private_Void_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_vIiGbQVpVOwnJzdNuCqvMLBrdUPb_Private_Void_InteractionState_Boolean_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_lqbyOQkiMqtTSHaLwWVyHDlZnTq_Private_Void_Color_Boolean_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_ufYoiZWDQoKqVxfNABfXoMNaCvFb_Private_Void_Sprite_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_lceHbganfbdhOUKTvhWNbmIhtZXK_Private_Void_String_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_SNkEVJdvPsXhwCsTTSNXYRVKKvr_Private_Void_Boolean_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_IsInteractable_Public_Boolean_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_znFnGxyOXnvNJEFcIxRAkZPVPJH_Internal_Virtual_New_Boolean_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_QbKJxkOCtOiwVZtLpxiyGGOjioU_Internal_Void_BaseEventData_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_aalhwRqcbQhzQHPqjxaJDiTxaYyw_Internal_Virtual_New_Boolean_GameObject_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_qIxIYmweKlrjcBMOEXWKOFiTliv_Private_Boolean_BaseEventData_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_qIxIYmweKlrjcBMOEXWKOFiTliv_Private_Boolean_Boolean_GameObject_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_DVBxkWTNkjIHJjytmUnOjRZqDKFA_Private_InteractionState_BaseEventData_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_bWRMcfccqjFiAfZKmzqlPCqdSNmv_Private_Boolean_InteractionState_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_sauMxetIPqugTJadbQriBqkRgjZ_Private_Void_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_mIAFviVeyABVWOcZlDlbcawAXMW_Private_Void_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_jiCgAYeThQbZBaNDTkJtkimAkEK_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_LkMBdoeVUAqijzqacIwORTFVyvM_Private_Void_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_PhJCjikfSaldYwoRmkMqkxasPaV_Private_Void_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_XHLNLwJfRXiTxFRbxqrZgImmHkF_Private_Void_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Internal_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Internal_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Internal_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerEnterHandler_OnPointerEnter_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerExitHandler_OnPointerExit_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IBeginDragHandler_OnBeginDrag_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IEndDragHandler_OnEndDrag_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_wZtizzYGSaEuStvOklprpasJWbU_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_TkPOLnJECphvFKbbhiMiJUuudVp_Internal_Static_Vector3_Int32_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_nIfTWSYUCrDkTTkCTkAaKgZSfbf_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_ibSOmMfLVvKZYTGUccTYNagtdyHh_Internal_Static_Boolean_Int32_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_AVRXVWaCruFLNjttxRJMiJVOmuY_Private_Static_Int32_Int32_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_MjtLGtJBnmljRyGvgqqivdfzhvt_Internal_Static_Boolean_MouseButtonFlags_Int32_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_kWaEevAYyiGxynGBdjWGKBogXOq_Private_Static_Boolean_MouseButtonFlags_Int32_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_XcZHTeBxSrFAAWugExveTRLzIuj_Private_Static_Int32_Int32_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_LCFWLrmkQQhbrxUhcjvhExmHRhT_Internal_Static_Boolean_MouseButtonFlags_byref_Int32_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_MjtLGtJBnmljRyGvgqqivdfzhvt_Internal_Static_Boolean_Int32_MouseButtonFlags_EventTriggerType_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_VrFaVtHBgzcVzkJfTqeSnRYvZiNi_Internal_Static_Boolean_MouseButtonFlags_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_get_interactionStateTransitionHandlerDelegate_Internal_Static_get_EventFunction_2_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_ayjSVyPEHeNxeDHyjhUqJhQmXQz_Private_Void_Boolean_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_yBMAbxDfzDATJCYjYWGjrfPYQPWE_Private_Static_Void_IInteractionStateTransitionHandler_InteractionStateTransitionArgs_0;

		// Token: 0x02000242 RID: 578
		[OriginalName("Rewired_Core.dll", "", "InteractionState")]
		public enum InteractionState
		{
			// Token: 0x04002FDE RID: 12254
			Normal,
			// Token: 0x04002FDF RID: 12255
			Highlighted,
			// Token: 0x04002FE0 RID: 12256
			Pressed,
			// Token: 0x04002FE1 RID: 12257
			Disabled
		}

		// Token: 0x02000243 RID: 579
		[OriginalName("Rewired_Core.dll", "", "TransitionTypeFlags")]
		[Flags]
		public enum TransitionTypeFlags
		{
			// Token: 0x04002FE3 RID: 12259
			None = 0,
			// Token: 0x04002FE4 RID: 12260
			ColorTint = 1,
			// Token: 0x04002FE5 RID: 12261
			SpriteSwap = 2,
			// Token: 0x04002FE6 RID: 12262
			Animation = 4
		}

		// Token: 0x02000244 RID: 580
		[OriginalName("Rewired_Core.dll", "", "MouseButtonFlags")]
		[Flags]
		public enum MouseButtonFlags
		{
			// Token: 0x04002FE8 RID: 12264
			None = 0,
			// Token: 0x04002FE9 RID: 12265
			LeftButton = 1,
			// Token: 0x04002FEA RID: 12266
			RightButton = 2,
			// Token: 0x04002FEB RID: 12267
			MiddleButton = 4,
			// Token: 0x04002FEC RID: 12268
			AnyButton = -1
		}

		// Token: 0x02000245 RID: 581
		[Serializable]
		public class InteractionStateTransitionEventHandler : UnityEvent<TouchInteractable.InteractionStateTransitionArgs>
		{
			// Token: 0x060038C3 RID: 14531 RVA: 0x00013AC1 File Offset: 0x00011CC1
			// Note: this type is marked as 'beforefieldinit'.
			static InteractionStateTransitionEventHandler()
			{
				Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "InteractionStateTransitionEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionEventHandler>.NativeClassPtr);
				TouchInteractable.InteractionStateTransitionEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionEventHandler>.NativeClassPtr, 100664370);
			}

			// Token: 0x060038C4 RID: 14532 RVA: 0x00115D4C File Offset: 0x00113F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246301, XrefRangeEnd = 246303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InteractionStateTransitionEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.InteractionStateTransitionEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038C5 RID: 14533 RVA: 0x00013AF5 File Offset: 0x00011CF5
			public InteractionStateTransitionEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002FED RID: 12269
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000246 RID: 582
		[Serializable]
		public class VisibilityChangedEventHandler : UnityEvent<bool>
		{
			// Token: 0x060038C6 RID: 14534 RVA: 0x00013AFE File Offset: 0x00011CFE
			// Note: this type is marked as 'beforefieldinit'.
			static VisibilityChangedEventHandler()
			{
				Il2CppClassPointerStore<TouchInteractable.VisibilityChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "VisibilityChangedEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInteractable.VisibilityChangedEventHandler>.NativeClassPtr);
				TouchInteractable.VisibilityChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable.VisibilityChangedEventHandler>.NativeClassPtr, 100664371);
			}

			// Token: 0x060038C7 RID: 14535 RVA: 0x00115D88 File Offset: 0x00113F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246303, XrefRangeEnd = 246305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VisibilityChangedEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchInteractable.VisibilityChangedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.VisibilityChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038C8 RID: 14536 RVA: 0x00013B32 File Offset: 0x00011D32
			public VisibilityChangedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002FEE RID: 12270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000247 RID: 583
		public class InteractionStateTransitionArgs : global::Il2CppSystem.Object
		{
			// Token: 0x060038C9 RID: 14537 RVA: 0x00115DC4 File Offset: 0x00113FC4
			// Note: this type is marked as 'beforefieldinit'.
			static InteractionStateTransitionArgs()
			{
				Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "InteractionStateTransitionArgs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionArgs>.NativeClassPtr);
				TouchInteractable.InteractionStateTransitionArgs.NativeFieldInfoPtr_qgWoAlXEAyUncKfKuvjLXZKuoLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionArgs>.NativeClassPtr, "qgWoAlXEAyUncKfKuvjLXZKuoLE");
				TouchInteractable.InteractionStateTransitionArgs.NativeFieldInfoPtr_GQXlrxGKQorSnvhHdJjMcoODcI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionArgs>.NativeClassPtr, "GQXlrxGKQorSnvhHdJjMcoODcI");
				TouchInteractable.InteractionStateTransitionArgs.NativeFieldInfoPtr_fbUmOQdcgJSgESLYWoBLVNGZrSn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionArgs>.NativeClassPtr, "fbUmOQdcgJSgESLYWoBLVNGZrSn");
				TouchInteractable.InteractionStateTransitionArgs.NativeMethodInfoPtr_get_sender_Public_get_TouchInteractable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionArgs>.NativeClassPtr, 100664372);
				TouchInteractable.InteractionStateTransitionArgs.NativeMethodInfoPtr_get_state_Public_get_InteractionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionArgs>.NativeClassPtr, 100664373);
				TouchInteractable.InteractionStateTransitionArgs.NativeMethodInfoPtr_get_duration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionArgs>.NativeClassPtr, 100664374);
				TouchInteractable.InteractionStateTransitionArgs.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionArgs>.NativeClassPtr, 100664375);
				TouchInteractable.InteractionStateTransitionArgs.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Internal_Void_TouchInteractable_InteractionState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionArgs>.NativeClassPtr, 100664376);
			}

			// Token: 0x170010F5 RID: 4341
			// (get) Token: 0x060038CA RID: 14538 RVA: 0x00115E90 File Offset: 0x00114090
			public unsafe TouchInteractable sender
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.InteractionStateTransitionArgs.NativeMethodInfoPtr_get_sender_Public_get_TouchInteractable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchInteractable>(intPtr3) : null;
				}
			}

			// Token: 0x170010F6 RID: 4342
			// (get) Token: 0x060038CB RID: 14539 RVA: 0x00115ED0 File Offset: 0x001140D0
			public unsafe TouchInteractable.InteractionState state
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.InteractionStateTransitionArgs.NativeMethodInfoPtr_get_state_Public_get_InteractionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170010F7 RID: 4343
			// (get) Token: 0x060038CC RID: 14540 RVA: 0x00115F0C File Offset: 0x0011410C
			public unsafe float duration
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.InteractionStateTransitionArgs.NativeMethodInfoPtr_get_duration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060038CD RID: 14541 RVA: 0x00115F48 File Offset: 0x00114148
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InteractionStateTransitionArgs()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchInteractable.InteractionStateTransitionArgs>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.InteractionStateTransitionArgs.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038CE RID: 14542 RVA: 0x00115F84 File Offset: 0x00114184
			[CallerCount(0)]
			public unsafe void MRZTryplKgDXZkLfSZwrsdDSOdq(TouchInteractable A_1, TouchInteractable.InteractionState A_2, float A_3)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractable.InteractionStateTransitionArgs.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Internal_Void_TouchInteractable_InteractionState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038CF RID: 14543 RVA: 0x00013B3B File Offset: 0x00011D3B
			public InteractionStateTransitionArgs(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010F2 RID: 4338
			// (get) Token: 0x060038D0 RID: 14544 RVA: 0x00115FE4 File Offset: 0x001141E4
			// (set) Token: 0x060038D1 RID: 14545 RVA: 0x00013B44 File Offset: 0x00011D44
			public unsafe TouchInteractable qgWoAlXEAyUncKfKuvjLXZKuoLE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.InteractionStateTransitionArgs.NativeFieldInfoPtr_qgWoAlXEAyUncKfKuvjLXZKuoLE);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchInteractable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.InteractionStateTransitionArgs.NativeFieldInfoPtr_qgWoAlXEAyUncKfKuvjLXZKuoLE), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F3 RID: 4339
			// (get) Token: 0x060038D2 RID: 14546 RVA: 0x00116014 File Offset: 0x00114214
			// (set) Token: 0x060038D3 RID: 14547 RVA: 0x00013B63 File Offset: 0x00011D63
			public unsafe TouchInteractable.InteractionState GQXlrxGKQorSnvhHdJjMcoODcI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.InteractionStateTransitionArgs.NativeFieldInfoPtr_GQXlrxGKQorSnvhHdJjMcoODcI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.InteractionStateTransitionArgs.NativeFieldInfoPtr_GQXlrxGKQorSnvhHdJjMcoODcI)) = value;
				}
			}

			// Token: 0x170010F4 RID: 4340
			// (get) Token: 0x060038D4 RID: 14548 RVA: 0x0011603C File Offset: 0x0011423C
			// (set) Token: 0x060038D5 RID: 14549 RVA: 0x00013B7E File Offset: 0x00011D7E
			public unsafe float fbUmOQdcgJSgESLYWoBLVNGZrSn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.InteractionStateTransitionArgs.NativeFieldInfoPtr_fbUmOQdcgJSgESLYWoBLVNGZrSn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractable.InteractionStateTransitionArgs.NativeFieldInfoPtr_fbUmOQdcgJSgESLYWoBLVNGZrSn)) = value;
				}
			}

			// Token: 0x04002FEF RID: 12271
			private static readonly IntPtr NativeFieldInfoPtr_qgWoAlXEAyUncKfKuvjLXZKuoLE;

			// Token: 0x04002FF0 RID: 12272
			private static readonly IntPtr NativeFieldInfoPtr_GQXlrxGKQorSnvhHdJjMcoODcI;

			// Token: 0x04002FF1 RID: 12273
			private static readonly IntPtr NativeFieldInfoPtr_fbUmOQdcgJSgESLYWoBLVNGZrSn;

			// Token: 0x04002FF2 RID: 12274
			private static readonly IntPtr NativeMethodInfoPtr_get_sender_Public_get_TouchInteractable_0;

			// Token: 0x04002FF3 RID: 12275
			private static readonly IntPtr NativeMethodInfoPtr_get_state_Public_get_InteractionState_0;

			// Token: 0x04002FF4 RID: 12276
			private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_get_Single_0;

			// Token: 0x04002FF5 RID: 12277
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04002FF6 RID: 12278
			private static readonly IntPtr NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Internal_Void_TouchInteractable_InteractionState_Single_0;
		}

		// Token: 0x02000248 RID: 584
		public class IInteractionStateTransitionHandler : Il2CppObjectBase
		{
			// Token: 0x060038D6 RID: 14550 RVA: 0x00013B99 File Offset: 0x00011D99
			// Note: this type is marked as 'beforefieldinit'.
			static IInteractionStateTransitionHandler()
			{
				Il2CppClassPointerStore<TouchInteractable.IInteractionStateTransitionHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchInteractable>.NativeClassPtr, "IInteractionStateTransitionHandler");
				TouchInteractable.IInteractionStateTransitionHandler.NativeMethodInfoPtr_OnInteractionStateTransition_Public_Abstract_Virtual_New_Void_InteractionStateTransitionArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractable.IInteractionStateTransitionHandler>.NativeClassPtr, 100664377);
			}

			// Token: 0x060038D7 RID: 14551 RVA: 0x00116064 File Offset: 0x00114264
			[CallerCount(0)]
			public unsafe virtual void OnInteractionStateTransition(TouchInteractable.InteractionStateTransitionArgs data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInteractable.IInteractionStateTransitionHandler.NativeMethodInfoPtr_OnInteractionStateTransition_Public_Abstract_Virtual_New_Void_InteractionStateTransitionArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038D8 RID: 14552 RVA: 0x00013BC3 File Offset: 0x00011DC3
			public IInteractionStateTransitionHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002FF7 RID: 12279
			private static readonly IntPtr NativeMethodInfoPtr_OnInteractionStateTransition_Public_Abstract_Virtual_New_Void_InteractionStateTransitionArgs_0;
		}
	}
}
