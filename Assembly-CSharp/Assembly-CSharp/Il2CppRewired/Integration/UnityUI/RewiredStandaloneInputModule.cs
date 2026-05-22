using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Components;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppRewired.Integration.UnityUI
{
	// Token: 0x020001EC RID: 492
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
	{
		// Token: 0x06003972 RID: 14706 RVA: 0x000D66CC File Offset: 0x000D48CC
		// Note: this type is marked as 'beforefieldinit'.
		static RewiredStandaloneInputModule()
		{
			Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", "RewiredStandaloneInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr);
			RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_HORIZONTAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "DEFAULT_ACTION_MOVE_HORIZONTAL");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_VERTICAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "DEFAULT_ACTION_MOVE_VERTICAL");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_SUBMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "DEFAULT_ACTION_SUBMIT");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_CANCEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "DEFAULT_ACTION_CANCEL");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredInputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "rewiredInputManager");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_useAllRewiredGamePlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "useAllRewiredGamePlayers");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_useRewiredSystemPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "useRewiredSystemPlayer");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredPlayerIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "rewiredPlayerIds");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_usePlayingPlayersOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "usePlayingPlayersOnly");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_playerMice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "playerMice");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_moveOneElementPerAxisPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "moveOneElementPerAxisPress");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_setActionsById = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "setActionsById");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_horizontalActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "horizontalActionId");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_verticalActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "verticalActionId");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_submitActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "submitActionId");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_cancelActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "cancelActionId");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_HorizontalAxis");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_VerticalAxis");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_SubmitButton");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_CancelButton");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_InputActionsPerSecond");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_RepeatDelay");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_allowMouseInput");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInputIfTouchSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_allowMouseInputIfTouchSupported");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowTouchInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_allowTouchInput");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectIfBackgroundClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_deselectIfBackgroundClicked");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectBeforeSelecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_deselectBeforeSelecting");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_ForceModuleActive");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_playerIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "playerIds");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_recompiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "recompiling");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_isTouchSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "isTouchSupported");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_PrevActionTime");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_LastMoveVector");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_ConsecutiveMoveCount");
			RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HasFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "m_HasFocus");
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_RewiredInputManager_Public_get_InputManager_Base_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668132);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_RewiredInputManager_Public_set_Void_InputManager_Base_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668133);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UseAllRewiredGamePlayers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668134);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UseAllRewiredGamePlayers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668135);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UseRewiredSystemPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668136);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UseRewiredSystemPlayer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668137);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_RewiredPlayerIds_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668138);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_RewiredPlayerIds_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668139);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UsePlayingPlayersOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668140);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UsePlayingPlayersOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668141);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_PlayerMice_Public_get_List_1_PlayerMouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668142);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_PlayerMice_Public_set_Void_List_1_PlayerMouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668143);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_MoveOneElementPerAxisPress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668144);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_MoveOneElementPerAxisPress_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668145);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowMouseInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668146);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowMouseInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668147);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowMouseInputIfTouchSupported_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668148);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowMouseInputIfTouchSupported_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668149);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowTouchInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668150);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowTouchInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668151);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_deselectIfBackgroundClicked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668152);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_deselectIfBackgroundClicked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668153);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_deselectBeforeSelecting_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668154);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_deselectBeforeSelecting_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668155);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_SetActionsById_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668156);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_SetActionsById_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668157);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_HorizontalActionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668158);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_HorizontalActionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668159);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_VerticalActionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668160);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_VerticalActionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668161);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_SubmitActionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668162);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_SubmitActionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668163);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_CancelActionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668164);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_CancelActionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668165);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668166);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_isTouchAllowed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668167);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668168);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668169);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668170);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668171);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668172);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668173);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668174);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668175);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668176);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668177);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668178);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668179);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668180);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668181);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668182);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668183);
			RewiredStandaloneInputModule.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668184);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668185);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668186);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668187);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668188);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668189);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668190);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668191);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668192);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchPress_Private_Void_PointerEventData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668193);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668194);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668195);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668196);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_CheckButtonOrKeyMovement_Private_Void_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668197);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668198);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668199);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668200);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMousePress_Private_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668201);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_HandleMouseTouchDeselectionOnSelectionChanged_Private_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668202);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668203);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668204);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668205);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_IsDefaultPlayer_Protected_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668206);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_InitializeRewired_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668207);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_SetupRewiredVars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668208);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_SetUpRewiredPlayerMice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668209);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_SetUpRewiredActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668210);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_GetButton_Private_Boolean_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668211);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_GetButtonDown_Private_Boolean_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668212);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_GetNegativeButton_Private_Boolean_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668213);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_GetNegativeButtonDown_Private_Boolean_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668214);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_GetAxis_Private_Single_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668215);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_CheckEditorRecompile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668216);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_OnEditorRecompile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668217);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_ClearRewiredVars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668218);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_DidAnyMouseMove_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668219);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_GetMouseButtonDownOnAnyMouse_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668220);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_OnRewiredInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668221);
			RewiredStandaloneInputModule.NativeMethodInfoPtr_OnRewiredShutDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100668222);
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06003973 RID: 14707 RVA: 0x000D70D4 File Offset: 0x000D52D4
		// (set) Token: 0x06003974 RID: 14708 RVA: 0x000D7114 File Offset: 0x000D5314
		public unsafe InputManager_Base RewiredInputManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_RewiredInputManager_Public_get_InputManager_Base_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputManager_Base>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 89481, RefRangeEnd = 89490, XrefRangeStart = 89481, XrefRangeEnd = 89481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_RewiredInputManager_Public_set_Void_InputManager_Base_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06003975 RID: 14709 RVA: 0x000D7158 File Offset: 0x000D5358
		// (set) Token: 0x06003976 RID: 14710 RVA: 0x000D7194 File Offset: 0x000D5394
		public unsafe bool UseAllRewiredGamePlayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UseAllRewiredGamePlayers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89490, XrefRangeEnd = 89491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UseAllRewiredGamePlayers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06003977 RID: 14711 RVA: 0x000D71D4 File Offset: 0x000D53D4
		// (set) Token: 0x06003978 RID: 14712 RVA: 0x000D7210 File Offset: 0x000D5410
		public unsafe bool UseRewiredSystemPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UseRewiredSystemPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89491, XrefRangeEnd = 89492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UseRewiredSystemPlayer_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06003979 RID: 14713 RVA: 0x000D7250 File Offset: 0x000D5450
		// (set) Token: 0x0600397A RID: 14714 RVA: 0x000D7290 File Offset: 0x000D5490
		public unsafe Il2CppStructArray<int> RewiredPlayerIds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89492, XrefRangeEnd = 89495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_RewiredPlayerIds_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89495, XrefRangeEnd = 89505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_RewiredPlayerIds_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x000D72D4 File Offset: 0x000D54D4
		// (set) Token: 0x0600397C RID: 14716 RVA: 0x000D7310 File Offset: 0x000D5510
		public unsafe bool UsePlayingPlayersOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UsePlayingPlayersOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UsePlayingPlayersOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x000D7350 File Offset: 0x000D5550
		// (set) Token: 0x0600397E RID: 14718 RVA: 0x000D7390 File Offset: 0x000D5590
		public unsafe List<PlayerMouse> PlayerMice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89505, XrefRangeEnd = 89511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_PlayerMice_Public_get_List_1_PlayerMouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayerMouse>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89511, XrefRangeEnd = 89522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_PlayerMice_Public_set_Void_List_1_PlayerMouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x0600397F RID: 14719 RVA: 0x000D73D4 File Offset: 0x000D55D4
		// (set) Token: 0x06003980 RID: 14720 RVA: 0x000D7410 File Offset: 0x000D5610
		public unsafe bool MoveOneElementPerAxisPress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_MoveOneElementPerAxisPress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_MoveOneElementPerAxisPress_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06003981 RID: 14721 RVA: 0x000D7450 File Offset: 0x000D5650
		// (set) Token: 0x06003982 RID: 14722 RVA: 0x000D748C File Offset: 0x000D568C
		public unsafe bool allowMouseInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowMouseInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowMouseInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06003983 RID: 14723 RVA: 0x000D74CC File Offset: 0x000D56CC
		// (set) Token: 0x06003984 RID: 14724 RVA: 0x000D7508 File Offset: 0x000D5708
		public unsafe bool allowMouseInputIfTouchSupported
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowMouseInputIfTouchSupported_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowMouseInputIfTouchSupported_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x000D7548 File Offset: 0x000D5748
		// (set) Token: 0x06003986 RID: 14726 RVA: 0x000D7584 File Offset: 0x000D5784
		public unsafe bool allowTouchInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowTouchInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowTouchInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06003987 RID: 14727 RVA: 0x000D75C4 File Offset: 0x000D57C4
		// (set) Token: 0x06003988 RID: 14728 RVA: 0x000D7600 File Offset: 0x000D5800
		public unsafe bool deselectIfBackgroundClicked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_deselectIfBackgroundClicked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_deselectIfBackgroundClicked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06003989 RID: 14729 RVA: 0x000D7640 File Offset: 0x000D5840
		// (set) Token: 0x0600398A RID: 14730 RVA: 0x000D767C File Offset: 0x000D587C
		public unsafe bool deselectBeforeSelecting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_deselectBeforeSelecting_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_deselectBeforeSelecting_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x0600398B RID: 14731 RVA: 0x000D76BC File Offset: 0x000D58BC
		// (set) Token: 0x0600398C RID: 14732 RVA: 0x000D76F8 File Offset: 0x000D58F8
		public unsafe bool SetActionsById
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_SetActionsById_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89522, XrefRangeEnd = 89523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_SetActionsById_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x000D7738 File Offset: 0x000D5938
		// (set) Token: 0x0600398E RID: 14734 RVA: 0x000D7774 File Offset: 0x000D5974
		public unsafe int HorizontalActionId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89523, RefRangeEnd = 89524, XrefRangeStart = 89523, XrefRangeEnd = 89523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_HorizontalActionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89524, XrefRangeEnd = 89540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_HorizontalActionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x0600398F RID: 14735 RVA: 0x000D77B4 File Offset: 0x000D59B4
		// (set) Token: 0x06003990 RID: 14736 RVA: 0x000D77F0 File Offset: 0x000D59F0
		public unsafe int VerticalActionId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_VerticalActionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89540, XrefRangeEnd = 89556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_VerticalActionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06003991 RID: 14737 RVA: 0x000D7830 File Offset: 0x000D5A30
		// (set) Token: 0x06003992 RID: 14738 RVA: 0x000D786C File Offset: 0x000D5A6C
		public unsafe int SubmitActionId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_SubmitActionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89556, XrefRangeEnd = 89572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_SubmitActionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06003993 RID: 14739 RVA: 0x000D78AC File Offset: 0x000D5AAC
		// (set) Token: 0x06003994 RID: 14740 RVA: 0x000D78E8 File Offset: 0x000D5AE8
		public unsafe int CancelActionId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_CancelActionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89572, XrefRangeEnd = 89588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_CancelActionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06003995 RID: 14741 RVA: 0x000D7928 File Offset: 0x000D5B28
		public unsafe override bool isMouseSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89588, XrefRangeEnd = 89593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06003996 RID: 14742 RVA: 0x000D7964 File Offset: 0x000D5B64
		public unsafe bool isTouchAllowed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_isTouchAllowed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06003997 RID: 14743 RVA: 0x000D79A0 File Offset: 0x000D5BA0
		// (set) Token: 0x06003998 RID: 14744 RVA: 0x000D79DC File Offset: 0x000D5BDC
		public unsafe bool allowActivationOnMobileDevice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x06003999 RID: 14745 RVA: 0x000D7A1C File Offset: 0x000D5C1C
		// (set) Token: 0x0600399A RID: 14746 RVA: 0x000D7A58 File Offset: 0x000D5C58
		public unsafe bool forceModuleActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x0600399B RID: 14747 RVA: 0x000D7A98 File Offset: 0x000D5C98
		// (set) Token: 0x0600399C RID: 14748 RVA: 0x000D7AD4 File Offset: 0x000D5CD4
		public unsafe float inputActionsPerSecond
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x0600399D RID: 14749 RVA: 0x000D7B14 File Offset: 0x000D5D14
		// (set) Token: 0x0600399E RID: 14750 RVA: 0x000D7B50 File Offset: 0x000D5D50
		public unsafe float repeatDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x0600399F RID: 14751 RVA: 0x000D7B90 File Offset: 0x000D5D90
		// (set) Token: 0x060039A0 RID: 14752 RVA: 0x000D7BC8 File Offset: 0x000D5DC8
		public unsafe string horizontalAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89593, XrefRangeEnd = 89601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x060039A1 RID: 14753 RVA: 0x000D7C0C File Offset: 0x000D5E0C
		// (set) Token: 0x060039A2 RID: 14754 RVA: 0x000D7C44 File Offset: 0x000D5E44
		public unsafe string verticalAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89601, XrefRangeEnd = 89609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x060039A3 RID: 14755 RVA: 0x000D7C88 File Offset: 0x000D5E88
		// (set) Token: 0x060039A4 RID: 14756 RVA: 0x000D7CC0 File Offset: 0x000D5EC0
		public unsafe string submitButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89609, XrefRangeEnd = 89617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x060039A5 RID: 14757 RVA: 0x000D7D04 File Offset: 0x000D5F04
		// (set) Token: 0x060039A6 RID: 14758 RVA: 0x000D7D3C File Offset: 0x000D5F3C
		public unsafe string cancelButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89617, XrefRangeEnd = 89625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x000D7D80 File Offset: 0x000D5F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89625, XrefRangeEnd = 89643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RewiredStandaloneInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A8 RID: 14760 RVA: 0x000D7DBC File Offset: 0x000D5FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89643, XrefRangeEnd = 89677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x000D7DF0 File Offset: 0x000D5FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89677, XrefRangeEnd = 89687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x000D7E24 File Offset: 0x000D6024
		[CallerCount(0)]
		public unsafe override bool IsModuleSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x000D7E60 File Offset: 0x000D6060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89687, XrefRangeEnd = 89742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x000D7E9C File Offset: 0x000D609C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89742, XrefRangeEnd = 89756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x000D7ED0 File Offset: 0x000D60D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89756, XrefRangeEnd = 89757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeactivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x000D7F04 File Offset: 0x000D6104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89757, XrefRangeEnd = 89771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x000D7F38 File Offset: 0x000D6138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89789, RefRangeEnd = 89790, XrefRangeStart = 89771, XrefRangeEnd = 89789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessTouchEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x000D7F74 File Offset: 0x000D6174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89909, RefRangeEnd = 89910, XrefRangeStart = 89790, XrefRangeEnd = 89909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref released;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchPress_Private_Void_PointerEventData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x000D7FD4 File Offset: 0x000D61D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89939, RefRangeEnd = 89940, XrefRangeStart = 89910, XrefRangeEnd = 89939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendSubmitEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x000D8010 File Offset: 0x000D6210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89964, RefRangeEnd = 89965, XrefRangeStart = 89940, XrefRangeEnd = 89964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRawMoveVector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x000D804C File Offset: 0x000D624C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89975, RefRangeEnd = 89976, XrefRangeStart = 89965, XrefRangeEnd = 89975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendMoveEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x000D8088 File Offset: 0x000D6288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89976, XrefRangeEnd = 89991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &downHorizontal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &downVertical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_CheckButtonOrKeyMovement_Private_Void_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x000D80D4 File Offset: 0x000D62D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90000, RefRangeEnd = 90001, XrefRangeStart = 89991, XrefRangeEnd = 90000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMouseEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x000D8108 File Offset: 0x000D6308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90030, RefRangeEnd = 90031, XrefRangeStart = 90001, XrefRangeEnd = 90030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMouseEvent(int playerId, int pointerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x000D8154 File Offset: 0x000D6354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90050, RefRangeEnd = 90051, XrefRangeStart = 90031, XrefRangeEnd = 90050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendUpdateEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x000D8190 File Offset: 0x000D6390
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 90214, RefRangeEnd = 90218, XrefRangeStart = 90051, XrefRangeEnd = 90214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMousePress(RewiredPointerInputModule.MouseButtonEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMousePress_Private_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x000D81D4 File Offset: 0x000D63D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90253, RefRangeEnd = 90255, XrefRangeStart = 90218, XrefRangeEnd = 90253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentOverGo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_HandleMouseTouchDeselectionOnSelectionChanged_Private_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x000D8228 File Offset: 0x000D6428
		[CallerCount(0)]
		public unsafe void OnApplicationFocus(bool hasFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasFocus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x000D8268 File Offset: 0x000D6468
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 90270, RefRangeEnd = 90273, XrefRangeStart = 90255, XrefRangeEnd = 90270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldIgnoreEventsOnNoFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x000D82A4 File Offset: 0x000D64A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90273, XrefRangeEnd = 90298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x000D82D8 File Offset: 0x000D64D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90298, XrefRangeEnd = 90309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultPlayer(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_IsDefaultPlayer_Protected_Virtual_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x000D8324 File Offset: 0x000D6524
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 90363, RefRangeEnd = 90367, XrefRangeStart = 90309, XrefRangeEnd = 90363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeRewired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_InitializeRewired_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x000D8358 File Offset: 0x000D6558
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 90405, RefRangeEnd = 90411, XrefRangeStart = 90367, XrefRangeEnd = 90405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupRewiredVars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SetupRewiredVars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x000D838C File Offset: 0x000D658C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90427, RefRangeEnd = 90428, XrefRangeStart = 90411, XrefRangeEnd = 90427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpRewiredPlayerMice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SetUpRewiredPlayerMice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x000D83C0 File Offset: 0x000D65C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90462, RefRangeEnd = 90463, XrefRangeStart = 90428, XrefRangeEnd = 90462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpRewiredActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SetUpRewiredActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x000D83F4 File Offset: 0x000D65F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90463, XrefRangeEnd = 90464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButton(Player player, int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetButton_Private_Boolean_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x000D8450 File Offset: 0x000D6650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90464, XrefRangeEnd = 90465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonDown(Player player, int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetButtonDown_Private_Boolean_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x000D84AC File Offset: 0x000D66AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90465, XrefRangeEnd = 90466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButton(Player player, int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetNegativeButton_Private_Boolean_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x000D8508 File Offset: 0x000D6708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90466, XrefRangeEnd = 90467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonDown(Player player, int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetNegativeButtonDown_Private_Boolean_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x000D8564 File Offset: 0x000D6764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90467, XrefRangeEnd = 90468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxis(Player player, int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetAxis_Private_Single_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x000D85C0 File Offset: 0x000D67C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90468, XrefRangeEnd = 90473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckEditorRecompile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_CheckEditorRecompile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x000D85F4 File Offset: 0x000D67F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90473, XrefRangeEnd = 90474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEditorRecompile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_OnEditorRecompile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x000D8628 File Offset: 0x000D6828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90477, RefRangeEnd = 90479, XrefRangeStart = 90474, XrefRangeEnd = 90477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRewiredVars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ClearRewiredVars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x000D865C File Offset: 0x000D685C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90491, RefRangeEnd = 90492, XrefRangeStart = 90479, XrefRangeEnd = 90491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DidAnyMouseMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_DidAnyMouseMove_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x000D8698 File Offset: 0x000D6898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90492, XrefRangeEnd = 90504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetMouseButtonDownOnAnyMouse_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x000D86E4 File Offset: 0x000D68E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90504, XrefRangeEnd = 90505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRewiredInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_OnRewiredInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x000D8718 File Offset: 0x000D6918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90505, XrefRangeEnd = 90506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRewiredShutDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_OnRewiredShutDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x000247E0 File Offset: 0x000229E0
		public RewiredStandaloneInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x060039CF RID: 14799 RVA: 0x000D874C File Offset: 0x000D694C
		// (set) Token: 0x060039D0 RID: 14800 RVA: 0x000247E9 File Offset: 0x000229E9
		public unsafe static string DEFAULT_ACTION_MOVE_HORIZONTAL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_HORIZONTAL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_HORIZONTAL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x060039D1 RID: 14801 RVA: 0x000D876C File Offset: 0x000D696C
		// (set) Token: 0x060039D2 RID: 14802 RVA: 0x000247FB File Offset: 0x000229FB
		public unsafe static string DEFAULT_ACTION_MOVE_VERTICAL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_VERTICAL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_VERTICAL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x060039D3 RID: 14803 RVA: 0x000D878C File Offset: 0x000D698C
		// (set) Token: 0x060039D4 RID: 14804 RVA: 0x0002480D File Offset: 0x00022A0D
		public unsafe static string DEFAULT_ACTION_SUBMIT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_SUBMIT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_SUBMIT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x060039D5 RID: 14805 RVA: 0x000D87AC File Offset: 0x000D69AC
		// (set) Token: 0x060039D6 RID: 14806 RVA: 0x0002481F File Offset: 0x00022A1F
		public unsafe static string DEFAULT_ACTION_CANCEL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_CANCEL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_CANCEL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x060039D7 RID: 14807 RVA: 0x000D87CC File Offset: 0x000D69CC
		// (set) Token: 0x060039D8 RID: 14808 RVA: 0x00024831 File Offset: 0x00022A31
		public unsafe InputManager_Base rewiredInputManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredInputManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputManager_Base>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredInputManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x060039D9 RID: 14809 RVA: 0x000D87FC File Offset: 0x000D69FC
		// (set) Token: 0x060039DA RID: 14810 RVA: 0x00024850 File Offset: 0x00022A50
		public unsafe bool useAllRewiredGamePlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_useAllRewiredGamePlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_useAllRewiredGamePlayers)) = value;
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x060039DB RID: 14811 RVA: 0x000D8824 File Offset: 0x000D6A24
		// (set) Token: 0x060039DC RID: 14812 RVA: 0x0002486B File Offset: 0x00022A6B
		public unsafe bool useRewiredSystemPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_useRewiredSystemPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_useRewiredSystemPlayer)) = value;
			}
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x060039DD RID: 14813 RVA: 0x000D884C File Offset: 0x000D6A4C
		// (set) Token: 0x060039DE RID: 14814 RVA: 0x00024886 File Offset: 0x00022A86
		public unsafe Il2CppStructArray<int> rewiredPlayerIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredPlayerIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredPlayerIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x060039DF RID: 14815 RVA: 0x000D887C File Offset: 0x000D6A7C
		// (set) Token: 0x060039E0 RID: 14816 RVA: 0x000248A5 File Offset: 0x00022AA5
		public unsafe bool usePlayingPlayersOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_usePlayingPlayersOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_usePlayingPlayersOnly)) = value;
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x060039E1 RID: 14817 RVA: 0x000D88A4 File Offset: 0x000D6AA4
		// (set) Token: 0x060039E2 RID: 14818 RVA: 0x000248C0 File Offset: 0x00022AC0
		public unsafe List<PlayerMouse> playerMice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_playerMice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerMouse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_playerMice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x060039E3 RID: 14819 RVA: 0x000D88D4 File Offset: 0x000D6AD4
		// (set) Token: 0x060039E4 RID: 14820 RVA: 0x000248DF File Offset: 0x00022ADF
		public unsafe bool moveOneElementPerAxisPress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_moveOneElementPerAxisPress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_moveOneElementPerAxisPress)) = value;
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x060039E5 RID: 14821 RVA: 0x000D88FC File Offset: 0x000D6AFC
		// (set) Token: 0x060039E6 RID: 14822 RVA: 0x000248FA File Offset: 0x00022AFA
		public unsafe bool setActionsById
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_setActionsById);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_setActionsById)) = value;
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x060039E7 RID: 14823 RVA: 0x000D8924 File Offset: 0x000D6B24
		// (set) Token: 0x060039E8 RID: 14824 RVA: 0x00024915 File Offset: 0x00022B15
		public unsafe int horizontalActionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_horizontalActionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_horizontalActionId)) = value;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x060039E9 RID: 14825 RVA: 0x000D894C File Offset: 0x000D6B4C
		// (set) Token: 0x060039EA RID: 14826 RVA: 0x00024930 File Offset: 0x00022B30
		public unsafe int verticalActionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_verticalActionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_verticalActionId)) = value;
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x060039EB RID: 14827 RVA: 0x000D8974 File Offset: 0x000D6B74
		// (set) Token: 0x060039EC RID: 14828 RVA: 0x0002494B File Offset: 0x00022B4B
		public unsafe int submitActionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_submitActionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_submitActionId)) = value;
			}
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x060039ED RID: 14829 RVA: 0x000D899C File Offset: 0x000D6B9C
		// (set) Token: 0x060039EE RID: 14830 RVA: 0x00024966 File Offset: 0x00022B66
		public unsafe int cancelActionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_cancelActionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_cancelActionId)) = value;
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x060039EF RID: 14831 RVA: 0x000D89C4 File Offset: 0x000D6BC4
		// (set) Token: 0x060039F0 RID: 14832 RVA: 0x00024981 File Offset: 0x00022B81
		public unsafe string m_HorizontalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x060039F1 RID: 14833 RVA: 0x000D89EC File Offset: 0x000D6BEC
		// (set) Token: 0x060039F2 RID: 14834 RVA: 0x000249A0 File Offset: 0x00022BA0
		public unsafe string m_VerticalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x060039F3 RID: 14835 RVA: 0x000D8A14 File Offset: 0x000D6C14
		// (set) Token: 0x060039F4 RID: 14836 RVA: 0x000249BF File Offset: 0x00022BBF
		public unsafe string m_SubmitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x060039F5 RID: 14837 RVA: 0x000D8A3C File Offset: 0x000D6C3C
		// (set) Token: 0x060039F6 RID: 14838 RVA: 0x000249DE File Offset: 0x00022BDE
		public unsafe string m_CancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_CancelButton);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_CancelButton), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x060039F7 RID: 14839 RVA: 0x000D8A64 File Offset: 0x000D6C64
		// (set) Token: 0x060039F8 RID: 14840 RVA: 0x000249FD File Offset: 0x00022BFD
		public unsafe float m_InputActionsPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond)) = value;
			}
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x060039F9 RID: 14841 RVA: 0x000D8A8C File Offset: 0x000D6C8C
		// (set) Token: 0x060039FA RID: 14842 RVA: 0x00024A18 File Offset: 0x00022C18
		public unsafe float m_RepeatDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay)) = value;
			}
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x000D8AB4 File Offset: 0x000D6CB4
		// (set) Token: 0x060039FC RID: 14844 RVA: 0x00024A33 File Offset: 0x00022C33
		public unsafe bool m_allowMouseInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInput)) = value;
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x000D8ADC File Offset: 0x000D6CDC
		// (set) Token: 0x060039FE RID: 14846 RVA: 0x00024A4E File Offset: 0x00022C4E
		public unsafe bool m_allowMouseInputIfTouchSupported
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInputIfTouchSupported);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInputIfTouchSupported)) = value;
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x000D8B04 File Offset: 0x000D6D04
		// (set) Token: 0x06003A00 RID: 14848 RVA: 0x00024A69 File Offset: 0x00022C69
		public unsafe bool m_allowTouchInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowTouchInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowTouchInput)) = value;
			}
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x000D8B2C File Offset: 0x000D6D2C
		// (set) Token: 0x06003A02 RID: 14850 RVA: 0x00024A84 File Offset: 0x00022C84
		public unsafe bool m_deselectIfBackgroundClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectIfBackgroundClicked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectIfBackgroundClicked)) = value;
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06003A03 RID: 14851 RVA: 0x000D8B54 File Offset: 0x000D6D54
		// (set) Token: 0x06003A04 RID: 14852 RVA: 0x00024A9F File Offset: 0x00022C9F
		public unsafe bool m_deselectBeforeSelecting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectBeforeSelecting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectBeforeSelecting)) = value;
			}
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06003A05 RID: 14853 RVA: 0x000D8B7C File Offset: 0x000D6D7C
		// (set) Token: 0x06003A06 RID: 14854 RVA: 0x00024ABA File Offset: 0x00022CBA
		public unsafe bool m_ForceModuleActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive)) = value;
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06003A07 RID: 14855 RVA: 0x000D8BA4 File Offset: 0x000D6DA4
		// (set) Token: 0x06003A08 RID: 14856 RVA: 0x00024AD5 File Offset: 0x00022CD5
		public unsafe Il2CppStructArray<int> playerIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_playerIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_playerIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x000D8BD4 File Offset: 0x000D6DD4
		// (set) Token: 0x06003A0A RID: 14858 RVA: 0x00024AF4 File Offset: 0x00022CF4
		public unsafe bool recompiling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_recompiling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_recompiling)) = value;
			}
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06003A0B RID: 14859 RVA: 0x000D8BFC File Offset: 0x000D6DFC
		// (set) Token: 0x06003A0C RID: 14860 RVA: 0x00024B0F File Offset: 0x00022D0F
		public unsafe bool isTouchSupported
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_isTouchSupported);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_isTouchSupported)) = value;
			}
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06003A0D RID: 14861 RVA: 0x000D8C24 File Offset: 0x000D6E24
		// (set) Token: 0x06003A0E RID: 14862 RVA: 0x00024B2A File Offset: 0x00022D2A
		public unsafe double m_PrevActionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime)) = value;
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06003A0F RID: 14863 RVA: 0x000D8C4C File Offset: 0x000D6E4C
		// (set) Token: 0x06003A10 RID: 14864 RVA: 0x00024B45 File Offset: 0x00022D45
		public unsafe Vector2 m_LastMoveVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector)) = value;
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06003A11 RID: 14865 RVA: 0x000D8C74 File Offset: 0x000D6E74
		// (set) Token: 0x06003A12 RID: 14866 RVA: 0x00024B60 File Offset: 0x00022D60
		public unsafe int m_ConsecutiveMoveCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount)) = value;
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06003A13 RID: 14867 RVA: 0x000D8C9C File Offset: 0x000D6E9C
		// (set) Token: 0x06003A14 RID: 14868 RVA: 0x00024B7B File Offset: 0x00022D7B
		public unsafe bool m_HasFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HasFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HasFocus)) = value;
			}
		}

		// Token: 0x0400226F RID: 8815
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_HORIZONTAL;

		// Token: 0x04002270 RID: 8816
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_VERTICAL;

		// Token: 0x04002271 RID: 8817
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_ACTION_SUBMIT;

		// Token: 0x04002272 RID: 8818
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_ACTION_CANCEL;

		// Token: 0x04002273 RID: 8819
		private static readonly IntPtr NativeFieldInfoPtr_rewiredInputManager;

		// Token: 0x04002274 RID: 8820
		private static readonly IntPtr NativeFieldInfoPtr_useAllRewiredGamePlayers;

		// Token: 0x04002275 RID: 8821
		private static readonly IntPtr NativeFieldInfoPtr_useRewiredSystemPlayer;

		// Token: 0x04002276 RID: 8822
		private static readonly IntPtr NativeFieldInfoPtr_rewiredPlayerIds;

		// Token: 0x04002277 RID: 8823
		private static readonly IntPtr NativeFieldInfoPtr_usePlayingPlayersOnly;

		// Token: 0x04002278 RID: 8824
		private static readonly IntPtr NativeFieldInfoPtr_playerMice;

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeFieldInfoPtr_moveOneElementPerAxisPress;

		// Token: 0x0400227A RID: 8826
		private static readonly IntPtr NativeFieldInfoPtr_setActionsById;

		// Token: 0x0400227B RID: 8827
		private static readonly IntPtr NativeFieldInfoPtr_horizontalActionId;

		// Token: 0x0400227C RID: 8828
		private static readonly IntPtr NativeFieldInfoPtr_verticalActionId;

		// Token: 0x0400227D RID: 8829
		private static readonly IntPtr NativeFieldInfoPtr_submitActionId;

		// Token: 0x0400227E RID: 8830
		private static readonly IntPtr NativeFieldInfoPtr_cancelActionId;

		// Token: 0x0400227F RID: 8831
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAxis;

		// Token: 0x04002280 RID: 8832
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalAxis;

		// Token: 0x04002281 RID: 8833
		private static readonly IntPtr NativeFieldInfoPtr_m_SubmitButton;

		// Token: 0x04002282 RID: 8834
		private static readonly IntPtr NativeFieldInfoPtr_m_CancelButton;

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeFieldInfoPtr_m_InputActionsPerSecond;

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeFieldInfoPtr_m_RepeatDelay;

		// Token: 0x04002285 RID: 8837
		private static readonly IntPtr NativeFieldInfoPtr_m_allowMouseInput;

		// Token: 0x04002286 RID: 8838
		private static readonly IntPtr NativeFieldInfoPtr_m_allowMouseInputIfTouchSupported;

		// Token: 0x04002287 RID: 8839
		private static readonly IntPtr NativeFieldInfoPtr_m_allowTouchInput;

		// Token: 0x04002288 RID: 8840
		private static readonly IntPtr NativeFieldInfoPtr_m_deselectIfBackgroundClicked;

		// Token: 0x04002289 RID: 8841
		private static readonly IntPtr NativeFieldInfoPtr_m_deselectBeforeSelecting;

		// Token: 0x0400228A RID: 8842
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceModuleActive;

		// Token: 0x0400228B RID: 8843
		private static readonly IntPtr NativeFieldInfoPtr_playerIds;

		// Token: 0x0400228C RID: 8844
		private static readonly IntPtr NativeFieldInfoPtr_recompiling;

		// Token: 0x0400228D RID: 8845
		private static readonly IntPtr NativeFieldInfoPtr_isTouchSupported;

		// Token: 0x0400228E RID: 8846
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevActionTime;

		// Token: 0x0400228F RID: 8847
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMoveVector;

		// Token: 0x04002290 RID: 8848
		private static readonly IntPtr NativeFieldInfoPtr_m_ConsecutiveMoveCount;

		// Token: 0x04002291 RID: 8849
		private static readonly IntPtr NativeFieldInfoPtr_m_HasFocus;

		// Token: 0x04002292 RID: 8850
		private static readonly IntPtr NativeMethodInfoPtr_get_RewiredInputManager_Public_get_InputManager_Base_0;

		// Token: 0x04002293 RID: 8851
		private static readonly IntPtr NativeMethodInfoPtr_set_RewiredInputManager_Public_set_Void_InputManager_Base_0;

		// Token: 0x04002294 RID: 8852
		private static readonly IntPtr NativeMethodInfoPtr_get_UseAllRewiredGamePlayers_Public_get_Boolean_0;

		// Token: 0x04002295 RID: 8853
		private static readonly IntPtr NativeMethodInfoPtr_set_UseAllRewiredGamePlayers_Public_set_Void_Boolean_0;

		// Token: 0x04002296 RID: 8854
		private static readonly IntPtr NativeMethodInfoPtr_get_UseRewiredSystemPlayer_Public_get_Boolean_0;

		// Token: 0x04002297 RID: 8855
		private static readonly IntPtr NativeMethodInfoPtr_set_UseRewiredSystemPlayer_Public_set_Void_Boolean_0;

		// Token: 0x04002298 RID: 8856
		private static readonly IntPtr NativeMethodInfoPtr_get_RewiredPlayerIds_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002299 RID: 8857
		private static readonly IntPtr NativeMethodInfoPtr_set_RewiredPlayerIds_Public_set_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400229A RID: 8858
		private static readonly IntPtr NativeMethodInfoPtr_get_UsePlayingPlayersOnly_Public_get_Boolean_0;

		// Token: 0x0400229B RID: 8859
		private static readonly IntPtr NativeMethodInfoPtr_set_UsePlayingPlayersOnly_Public_set_Void_Boolean_0;

		// Token: 0x0400229C RID: 8860
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerMice_Public_get_List_1_PlayerMouse_0;

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerMice_Public_set_Void_List_1_PlayerMouse_0;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveOneElementPerAxisPress_Public_get_Boolean_0;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeMethodInfoPtr_set_MoveOneElementPerAxisPress_Public_set_Void_Boolean_0;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeMethodInfoPtr_get_allowMouseInput_Public_get_Boolean_0;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeMethodInfoPtr_set_allowMouseInput_Public_set_Void_Boolean_0;

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeMethodInfoPtr_get_allowMouseInputIfTouchSupported_Public_get_Boolean_0;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeMethodInfoPtr_set_allowMouseInputIfTouchSupported_Public_set_Void_Boolean_0;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeMethodInfoPtr_get_allowTouchInput_Public_get_Boolean_0;

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeMethodInfoPtr_set_allowTouchInput_Public_set_Void_Boolean_0;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeMethodInfoPtr_get_deselectIfBackgroundClicked_Public_get_Boolean_0;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeMethodInfoPtr_set_deselectIfBackgroundClicked_Public_set_Void_Boolean_0;

		// Token: 0x040022A8 RID: 8872
		private static readonly IntPtr NativeMethodInfoPtr_get_deselectBeforeSelecting_Private_get_Boolean_0;

		// Token: 0x040022A9 RID: 8873
		private static readonly IntPtr NativeMethodInfoPtr_set_deselectBeforeSelecting_Private_set_Void_Boolean_0;

		// Token: 0x040022AA RID: 8874
		private static readonly IntPtr NativeMethodInfoPtr_get_SetActionsById_Public_get_Boolean_0;

		// Token: 0x040022AB RID: 8875
		private static readonly IntPtr NativeMethodInfoPtr_set_SetActionsById_Public_set_Void_Boolean_0;

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeMethodInfoPtr_get_HorizontalActionId_Public_get_Int32_0;

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeMethodInfoPtr_set_HorizontalActionId_Public_set_Void_Int32_0;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeMethodInfoPtr_get_VerticalActionId_Public_get_Int32_0;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeMethodInfoPtr_set_VerticalActionId_Public_set_Void_Int32_0;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeMethodInfoPtr_get_SubmitActionId_Public_get_Int32_0;

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeMethodInfoPtr_set_SubmitActionId_Public_set_Void_Int32_0;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeMethodInfoPtr_get_CancelActionId_Public_get_Int32_0;

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeMethodInfoPtr_set_CancelActionId_Public_set_Void_Int32_0;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_get_Boolean_0;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeMethodInfoPtr_get_isTouchAllowed_Private_get_Boolean_0;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0;

		// Token: 0x040022B7 RID: 8887
		private static readonly IntPtr NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0;

		// Token: 0x040022B8 RID: 8888
		private static readonly IntPtr NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0;

		// Token: 0x040022B9 RID: 8889
		private static readonly IntPtr NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0;

		// Token: 0x040022BA RID: 8890
		private static readonly IntPtr NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0;

		// Token: 0x040022BB RID: 8891
		private static readonly IntPtr NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0;

		// Token: 0x040022BC RID: 8892
		private static readonly IntPtr NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0;

		// Token: 0x040022BD RID: 8893
		private static readonly IntPtr NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0;

		// Token: 0x040022BE RID: 8894
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0;

		// Token: 0x040022BF RID: 8895
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0;

		// Token: 0x040022C0 RID: 8896
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0;

		// Token: 0x040022C1 RID: 8897
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0;

		// Token: 0x040022C2 RID: 8898
		private static readonly IntPtr NativeMethodInfoPtr_get_submitButton_Public_get_String_0;

		// Token: 0x040022C3 RID: 8899
		private static readonly IntPtr NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0;

		// Token: 0x040022C4 RID: 8900
		private static readonly IntPtr NativeMethodInfoPtr_get_cancelButton_Public_get_String_0;

		// Token: 0x040022C5 RID: 8901
		private static readonly IntPtr NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0;

		// Token: 0x040022C6 RID: 8902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040022C7 RID: 8903
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040022C8 RID: 8904
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0;

		// Token: 0x040022C9 RID: 8905
		private static readonly IntPtr NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0;

		// Token: 0x040022CA RID: 8906
		private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0;

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0;

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0;

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchPress_Private_Void_PointerEventData_Boolean_Boolean_0;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Private_Boolean_0;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeMethodInfoPtr_SendMoveEventToSelectedObject_Private_Boolean_0;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeMethodInfoPtr_CheckButtonOrKeyMovement_Private_Void_byref_Boolean_byref_Boolean_0;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvents_Private_Void_0;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Private_Void_Int32_Int32_0;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Private_Boolean_0;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMousePress_Private_Void_MouseButtonEventData_0;

		// Token: 0x040022D8 RID: 8920
		private static readonly IntPtr NativeMethodInfoPtr_HandleMouseTouchDeselectionOnSelectionChanged_Private_Void_GameObject_BaseEventData_0;

		// Token: 0x040022D9 RID: 8921
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x040022DA RID: 8922
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0;

		// Token: 0x040022DB RID: 8923
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040022DC RID: 8924
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultPlayer_Protected_Virtual_Boolean_Int32_0;

		// Token: 0x040022DD RID: 8925
		private static readonly IntPtr NativeMethodInfoPtr_InitializeRewired_Private_Void_0;

		// Token: 0x040022DE RID: 8926
		private static readonly IntPtr NativeMethodInfoPtr_SetupRewiredVars_Private_Void_0;

		// Token: 0x040022DF RID: 8927
		private static readonly IntPtr NativeMethodInfoPtr_SetUpRewiredPlayerMice_Private_Void_0;

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeMethodInfoPtr_SetUpRewiredActions_Private_Void_0;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Private_Boolean_Player_Int32_0;

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Private_Boolean_Player_Int32_0;

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButton_Private_Boolean_Player_Int32_0;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonDown_Private_Boolean_Player_Int32_0;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Private_Single_Player_Int32_0;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeMethodInfoPtr_CheckEditorRecompile_Private_Void_0;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeMethodInfoPtr_OnEditorRecompile_Private_Void_0;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeMethodInfoPtr_ClearRewiredVars_Private_Void_0;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeMethodInfoPtr_DidAnyMouseMove_Private_Boolean_0;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonDownOnAnyMouse_Private_Boolean_Int32_0;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeMethodInfoPtr_OnRewiredInitialized_Private_Void_0;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeMethodInfoPtr_OnRewiredShutDown_Private_Void_0;

		// Token: 0x02000364 RID: 868
		[Serializable]
		public class PlayerSetting : global::Il2CppSystem.Object
		{
			// Token: 0x060054AB RID: 21675 RVA: 0x00133164 File Offset: 0x00131364
			// Note: this type is marked as 'beforefieldinit'.
			static PlayerSetting()
			{
				Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, "PlayerSetting");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr);
				RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr, "playerId");
				RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerMice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr, "playerMice");
				RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr, 100668223);
				RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr__ctor_Private_Void_PlayerSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr, 100668224);
				RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr_Clone_Public_PlayerSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr, 100668225);
			}

			// Token: 0x060054AC RID: 21676 RVA: 0x001331F4 File Offset: 0x001313F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89449, XrefRangeEnd = 89455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSetting()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054AD RID: 21677 RVA: 0x00133230 File Offset: 0x00131430
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89476, RefRangeEnd = 89477, XrefRangeStart = 89455, XrefRangeEnd = 89476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSetting(RewiredStandaloneInputModule.PlayerSetting other)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr__ctor_Private_Void_PlayerSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060054AE RID: 21678 RVA: 0x0013327C File Offset: 0x0013147C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89477, XrefRangeEnd = 89481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RewiredStandaloneInputModule.PlayerSetting Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr_Clone_Public_PlayerSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RewiredStandaloneInputModule.PlayerSetting>(intPtr3) : null;
			}

			// Token: 0x060054AF RID: 21679 RVA: 0x00031087 File Offset: 0x0002F287
			public PlayerSetting(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EDA RID: 7898
			// (get) Token: 0x060054B0 RID: 21680 RVA: 0x001332BC File Offset: 0x001314BC
			// (set) Token: 0x060054B1 RID: 21681 RVA: 0x00031090 File Offset: 0x0002F290
			public unsafe int playerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerId)) = value;
				}
			}

			// Token: 0x17001EDB RID: 7899
			// (get) Token: 0x060054B2 RID: 21682 RVA: 0x001332E4 File Offset: 0x001314E4
			// (set) Token: 0x060054B3 RID: 21683 RVA: 0x000310AB File Offset: 0x0002F2AB
			public unsafe List<PlayerMouse> playerMice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerMice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerMouse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerMice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037FB RID: 14331
			private static readonly IntPtr NativeFieldInfoPtr_playerId;

			// Token: 0x040037FC RID: 14332
			private static readonly IntPtr NativeFieldInfoPtr_playerMice;

			// Token: 0x040037FD RID: 14333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040037FE RID: 14334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_PlayerSetting_0;

			// Token: 0x040037FF RID: 14335
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_PlayerSetting_0;
		}
	}
}
