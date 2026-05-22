using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
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
	// Token: 0x0200004B RID: 75
	[Serializable]
	public sealed class TouchJoystick : TouchInteractable
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x00047648 File Offset: 0x00045848
		// Note: this type is marked as 'beforefieldinit'.
		static TouchJoystick()
		{
			Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "TouchJoystick");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr);
			TouchJoystick.NativeFieldInfoPtr_MAX_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "MAX_MOVE_SPEED");
			TouchJoystick.NativeFieldInfoPtr__horizontalAxisCustomControllerElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_horizontalAxisCustomControllerElement");
			TouchJoystick.NativeFieldInfoPtr__verticalAxisCustomControllerElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_verticalAxisCustomControllerElement");
			TouchJoystick.NativeFieldInfoPtr__tapCustomControllerElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_tapCustomControllerElement");
			TouchJoystick.NativeFieldInfoPtr__stickTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_stickTransform");
			TouchJoystick.NativeFieldInfoPtr__joystickMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_joystickMode");
			TouchJoystick.NativeFieldInfoPtr__digitalModeDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_digitalModeDeadZone");
			TouchJoystick.NativeFieldInfoPtr__stickRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_stickRange");
			TouchJoystick.NativeFieldInfoPtr__scaleStickRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_scaleStickRange");
			TouchJoystick.NativeFieldInfoPtr__stickBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_stickBounds");
			TouchJoystick.NativeFieldInfoPtr__axesToUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_axesToUse");
			TouchJoystick.NativeFieldInfoPtr__snapDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_snapDirections");
			TouchJoystick.NativeFieldInfoPtr__snapStickToTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_snapStickToTouch");
			TouchJoystick.NativeFieldInfoPtr__centerStickOnRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_centerStickOnRelease");
			TouchJoystick.NativeFieldInfoPtr__axis2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_axis2D");
			TouchJoystick.NativeFieldInfoPtr__activateOnSwipeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_activateOnSwipeIn");
			TouchJoystick.NativeFieldInfoPtr__stayActiveOnSwipeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_stayActiveOnSwipeOut");
			TouchJoystick.NativeFieldInfoPtr__allowTap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_allowTap");
			TouchJoystick.NativeFieldInfoPtr__tapTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_tapTimeout");
			TouchJoystick.NativeFieldInfoPtr__tapDistanceLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_tapDistanceLimit");
			TouchJoystick.NativeFieldInfoPtr__touchRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_touchRegion");
			TouchJoystick.NativeFieldInfoPtr__useTouchRegionOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_useTouchRegionOnly");
			TouchJoystick.NativeFieldInfoPtr__moveToTouchPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_moveToTouchPosition");
			TouchJoystick.NativeFieldInfoPtr__returnOnRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_returnOnRelease");
			TouchJoystick.NativeFieldInfoPtr__followTouchPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_followTouchPosition");
			TouchJoystick.NativeFieldInfoPtr__animateOnMoveToTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_animateOnMoveToTouch");
			TouchJoystick.NativeFieldInfoPtr__moveToTouchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_moveToTouchSpeed");
			TouchJoystick.NativeFieldInfoPtr__animateOnReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_animateOnReturn");
			TouchJoystick.NativeFieldInfoPtr__returnSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_returnSpeed");
			TouchJoystick.NativeFieldInfoPtr__manageRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_manageRaycasting");
			TouchJoystick.NativeFieldInfoPtr__useXAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_useXAxis");
			TouchJoystick.NativeFieldInfoPtr__useYAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_useYAxis");
			TouchJoystick.NativeFieldInfoPtr__hierarchyValueChangedHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_hierarchyValueChangedHandlers");
			TouchJoystick.NativeFieldInfoPtr__hierarchyStickPositionChangedHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_hierarchyStickPositionChangedHandlers");
			TouchJoystick.NativeFieldInfoPtr__workingTouchRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_workingTouchRegion");
			TouchJoystick.NativeFieldInfoPtr__origAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_origAnchoredPosition");
			TouchJoystick.NativeFieldInfoPtr__origStickAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_origStickAnchoredPosition");
			TouchJoystick.NativeFieldInfoPtr__lastPressAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_lastPressAnchoredPosition");
			TouchJoystick.NativeFieldInfoPtr__isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_isMoving");
			TouchJoystick.NativeFieldInfoPtr__isMovedFromDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_isMovedFromDefaultPosition");
			TouchJoystick.NativeFieldInfoPtr__moveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_moveDirection");
			TouchJoystick.NativeFieldInfoPtr__pointerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_pointerId");
			TouchJoystick.NativeFieldInfoPtr__realMousePointerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_realMousePointerId");
			TouchJoystick.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "AJKoOMhkVHACBErfSbaQmDfyxZV");
			TouchJoystick.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "xISHKSqmxBFBXboSBVekNAulortJ");
			TouchJoystick.NativeFieldInfoPtr__pointerDownIsFake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_pointerDownIsFake");
			TouchJoystick.NativeFieldInfoPtr__lastPressStartingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_lastPressStartingValue");
			TouchJoystick.NativeFieldInfoPtr__lastClaimSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_lastClaimSource");
			TouchJoystick.NativeFieldInfoPtr__touchStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_touchStartTime");
			TouchJoystick.NativeFieldInfoPtr__touchStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_touchStartPosition");
			TouchJoystick.NativeFieldInfoPtr__coroutineMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_coroutineMove");
			TouchJoystick.NativeFieldInfoPtr__imageRaycastHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_imageRaycastHelper");
			TouchJoystick.NativeFieldInfoPtr__calculatedStickRange_lastUpdatedFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_calculatedStickRange_lastUpdatedFrame");
			TouchJoystick.NativeFieldInfoPtr__lastTapFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_lastTapFrame");
			TouchJoystick.NativeFieldInfoPtr__isEligibleForTap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_isEligibleForTap");
			TouchJoystick.NativeFieldInfoPtr___calculatedStickRange_cachedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "__calculatedStickRange_cachedValue");
			TouchJoystick.NativeFieldInfoPtr___moveStartedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "__moveStartedDelegate");
			TouchJoystick.NativeFieldInfoPtr___moveEndedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "__moveEndedDelegate");
			TouchJoystick.NativeFieldInfoPtr__onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_onValueChanged");
			TouchJoystick.NativeFieldInfoPtr__onStickPositionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_onStickPositionChanged");
			TouchJoystick.NativeFieldInfoPtr__onTouchStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_onTouchStarted");
			TouchJoystick.NativeFieldInfoPtr__onTouchEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_onTouchEnded");
			TouchJoystick.NativeFieldInfoPtr__onTap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "_onTap");
			TouchJoystick.NativeFieldInfoPtr___fakePointerEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "__fakePointerEventData");
			TouchJoystick.NativeFieldInfoPtr___valueChangedHandlerDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "__valueChangedHandlerDelegate");
			TouchJoystick.NativeFieldInfoPtr___stickPositionChangedHandlerDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "__stickPositionChangedHandlerDelegate");
			TouchJoystick.NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IValueChangedHandler_Vector2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "CS$<>9__CachedAnonymousMethodDelegate8");
			TouchJoystick.NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IStickPositionChangedHandler_Vector2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "CS$<>9__CachedAnonymousMethodDelegatea");
			TouchJoystick.NativeMethodInfoPtr_get_horizontalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664417);
			TouchJoystick.NativeMethodInfoPtr_get_verticalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664418);
			TouchJoystick.NativeMethodInfoPtr_get_tapCustomControllerElement_Public_get_CustomControllerElementTargetSetForBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664419);
			TouchJoystick.NativeMethodInfoPtr_get_stickTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664420);
			TouchJoystick.NativeMethodInfoPtr_set_stickTransform_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664421);
			TouchJoystick.NativeMethodInfoPtr_get_joystickMode_Public_get_JoystickMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664422);
			TouchJoystick.NativeMethodInfoPtr_set_joystickMode_Public_set_Void_JoystickMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664423);
			TouchJoystick.NativeMethodInfoPtr_get_digitalModeDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664424);
			TouchJoystick.NativeMethodInfoPtr_set_digitalModeDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664425);
			TouchJoystick.NativeMethodInfoPtr_get_stickRange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664426);
			TouchJoystick.NativeMethodInfoPtr_set_stickRange_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664427);
			TouchJoystick.NativeMethodInfoPtr_get_scaleStickRange_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664428);
			TouchJoystick.NativeMethodInfoPtr_set_scaleStickRange_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664429);
			TouchJoystick.NativeMethodInfoPtr_get_stickBounds_Private_get_StickBounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664430);
			TouchJoystick.NativeMethodInfoPtr_set_stickBounds_Private_set_Void_StickBounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664431);
			TouchJoystick.NativeMethodInfoPtr_get_axesToUse_Public_get_AxisDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664432);
			TouchJoystick.NativeMethodInfoPtr_set_axesToUse_Public_set_Void_AxisDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664433);
			TouchJoystick.NativeMethodInfoPtr_get_snapDirections_Public_get_SnapDirections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664434);
			TouchJoystick.NativeMethodInfoPtr_set_snapDirections_Public_set_Void_SnapDirections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664435);
			TouchJoystick.NativeMethodInfoPtr_get_snapStickToTouch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664436);
			TouchJoystick.NativeMethodInfoPtr_set_snapStickToTouch_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664437);
			TouchJoystick.NativeMethodInfoPtr_get_centerStickOnRelease_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664438);
			TouchJoystick.NativeMethodInfoPtr_set_centerStickOnRelease_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664439);
			TouchJoystick.NativeMethodInfoPtr_get_activateOnSwipeIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664440);
			TouchJoystick.NativeMethodInfoPtr_set_activateOnSwipeIn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664441);
			TouchJoystick.NativeMethodInfoPtr_get_stayActiveOnSwipeOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664442);
			TouchJoystick.NativeMethodInfoPtr_set_stayActiveOnSwipeOut_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664443);
			TouchJoystick.NativeMethodInfoPtr_get_allowTap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664444);
			TouchJoystick.NativeMethodInfoPtr_set_allowTap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664445);
			TouchJoystick.NativeMethodInfoPtr_get_tapTimeout_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664446);
			TouchJoystick.NativeMethodInfoPtr_set_tapTimeout_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664447);
			TouchJoystick.NativeMethodInfoPtr_get_tapDistanceLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664448);
			TouchJoystick.NativeMethodInfoPtr_set_tapDistanceLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664449);
			TouchJoystick.NativeMethodInfoPtr_get_touchRegion_Public_get_TouchRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664450);
			TouchJoystick.NativeMethodInfoPtr_set_touchRegion_Public_set_Void_TouchRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664451);
			TouchJoystick.NativeMethodInfoPtr_get_useTouchRegionOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664452);
			TouchJoystick.NativeMethodInfoPtr_set_useTouchRegionOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664453);
			TouchJoystick.NativeMethodInfoPtr_get_moveToTouchPosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664454);
			TouchJoystick.NativeMethodInfoPtr_set_moveToTouchPosition_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664455);
			TouchJoystick.NativeMethodInfoPtr_get_returnOnRelease_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664456);
			TouchJoystick.NativeMethodInfoPtr_set_returnOnRelease_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664457);
			TouchJoystick.NativeMethodInfoPtr_get_followTouchPosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664458);
			TouchJoystick.NativeMethodInfoPtr_set_followTouchPosition_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664459);
			TouchJoystick.NativeMethodInfoPtr_get_animateOnMoveToTouch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664460);
			TouchJoystick.NativeMethodInfoPtr_set_animateOnMoveToTouch_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664461);
			TouchJoystick.NativeMethodInfoPtr_get_moveToTouchSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664462);
			TouchJoystick.NativeMethodInfoPtr_set_moveToTouchSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664463);
			TouchJoystick.NativeMethodInfoPtr_get_animateOnReturn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664464);
			TouchJoystick.NativeMethodInfoPtr_set_animateOnReturn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664465);
			TouchJoystick.NativeMethodInfoPtr_get_returnSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664466);
			TouchJoystick.NativeMethodInfoPtr_set_returnSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664467);
			TouchJoystick.NativeMethodInfoPtr_get_manageRaycasting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664468);
			TouchJoystick.NativeMethodInfoPtr_set_manageRaycasting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664469);
			TouchJoystick.NativeMethodInfoPtr_get_horizontalAxisCalibration_Public_get_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664470);
			TouchJoystick.NativeMethodInfoPtr_get_verticalAxisCalibration_Public_get_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664471);
			TouchJoystick.NativeMethodInfoPtr_get_deadZoneType_Public_get_Axis2DCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664472);
			TouchJoystick.NativeMethodInfoPtr_get_axis2DCalibration_Public_get_Axis2DCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664473);
			TouchJoystick.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664474);
			TouchJoystick.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664475);
			TouchJoystick.NativeMethodInfoPtr_get_hasPointer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664476);
			TouchJoystick.NativeMethodInfoPtr_get_tapValue_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664477);
			TouchJoystick.NativeMethodInfoPtr_get_axis2D_Internal_get_StandaloneAxis2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664478);
			TouchJoystick.NativeMethodInfoPtr_get_moveStartedDelegate_Private_get_Action_1_TBzQBkblStsOsblRBDCFXBbSxxj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664479);
			TouchJoystick.NativeMethodInfoPtr_get_moveEndedDelegate_Private_get_Action_1_TBzQBkblStsOsblRBDCFXBbSxxj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664480);
			TouchJoystick.NativeMethodInfoPtr_get_effectivePointerId_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664481);
			TouchJoystick.NativeMethodInfoPtr_get_touchReferenceTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664482);
			TouchJoystick.NativeMethodInfoPtr_get_calculatedStickRange_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664483);
			TouchJoystick.NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_UnityAction_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664484);
			TouchJoystick.NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_UnityAction_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664485);
			TouchJoystick.NativeMethodInfoPtr_add_StickPositionChangedEvent_Public_add_Void_UnityAction_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664486);
			TouchJoystick.NativeMethodInfoPtr_remove_StickPositionChangedEvent_Public_rem_Void_UnityAction_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664487);
			TouchJoystick.NativeMethodInfoPtr_add_TouchDownEvent_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664488);
			TouchJoystick.NativeMethodInfoPtr_remove_TouchDownEvent_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664489);
			TouchJoystick.NativeMethodInfoPtr_add_TouchUpEvent_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664490);
			TouchJoystick.NativeMethodInfoPtr_remove_TouchUpEvent_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664491);
			TouchJoystick.NativeMethodInfoPtr_add_TapEvent_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664492);
			TouchJoystick.NativeMethodInfoPtr_remove_TapEvent_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664493);
			TouchJoystick.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664494);
			TouchJoystick.NativeMethodInfoPtr_GetValue_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664495);
			TouchJoystick.NativeMethodInfoPtr_GetRawValue_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664496);
			TouchJoystick.NativeMethodInfoPtr_SetRawValue_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664497);
			TouchJoystick.NativeMethodInfoPtr_SetDefaultPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664498);
			TouchJoystick.NativeMethodInfoPtr_INvchJBcQkSeGZgUXICnVqDkNBa_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664499);
			TouchJoystick.NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664500);
			TouchJoystick.NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664501);
			TouchJoystick.NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664502);
			TouchJoystick.NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664503);
			TouchJoystick.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664504);
			TouchJoystick.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664505);
			TouchJoystick.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664506);
			TouchJoystick.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664507);
			TouchJoystick.NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664508);
			TouchJoystick.NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664509);
			TouchJoystick.NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664510);
			TouchJoystick.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664511);
			TouchJoystick.NativeMethodInfoPtr_xzNKXjAaJMKaZzoFxoimUjvQRfi_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664512);
			TouchJoystick.NativeMethodInfoPtr_AMTvavhAJFMZzkgIlyIMREPyico_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664513);
			TouchJoystick.NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664514);
			TouchJoystick.NativeMethodInfoPtr_znFnGxyOXnvNJEFcIxRAkZPVPJH_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664515);
			TouchJoystick.NativeMethodInfoPtr_aalhwRqcbQhzQHPqjxaJDiTxaYyw_Internal_Virtual_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664516);
			TouchJoystick.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664517);
			TouchJoystick.NativeMethodInfoPtr_oCddbrAzLSgARApvwyLBgfvztGoB_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664518);
			TouchJoystick.NativeMethodInfoPtr_ScfGINmFMxfNAJVmpKaJsxmTkXqf_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664519);
			TouchJoystick.NativeMethodInfoPtr_nRvokDeWGGctkRtLitHwbAHZIso_Private_Void_TouchRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664520);
			TouchJoystick.NativeMethodInfoPtr_fOwxbxkERGiUgPApbIWvgPmZPSO_Private_Void_TouchRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664521);
			TouchJoystick.NativeMethodInfoPtr_EqPWznbcqXfSbBqHkAxpEdqMLyWN_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664522);
			TouchJoystick.NativeMethodInfoPtr_lYFqcNqPVQUWLQzfHypznAkffnR_Private_Void_Vector2_Boolean_Single_TBzQBkblStsOsblRBDCFXBbSxxj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664523);
			TouchJoystick.NativeMethodInfoPtr_bndCRqovhXNzogiaEgObWGJQjPoa_Private_Void_Vector2_PositionType_Boolean_Single_TBzQBkblStsOsblRBDCFXBbSxxj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664524);
			TouchJoystick.NativeMethodInfoPtr_vkcfalFMzcgemqDQsIhfobMLjflg_Private_IEnumerator_Vector2_PositionType_Single_TBzQBkblStsOsblRBDCFXBbSxxj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664525);
			TouchJoystick.NativeMethodInfoPtr_DsphDRCaOcDcijQVdImpyNcwmHe_Private_Void_TBzQBkblStsOsblRBDCFXBbSxxj_Vector2_PositionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664526);
			TouchJoystick.NativeMethodInfoPtr_XLLNWtCwXRBqlTJzCfKrbpeyhQGq_Private_Void_TBzQBkblStsOsblRBDCFXBbSxxj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664527);
			TouchJoystick.NativeMethodInfoPtr_SIuBcTqDlIpUZIPLQnVORwJXTBJ_Private_Void_TBzQBkblStsOsblRBDCFXBbSxxj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664528);
			TouchJoystick.NativeMethodInfoPtr_nUDeYYbgQCDNaKgGyfLeqdHdeMxP_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664529);
			TouchJoystick.NativeMethodInfoPtr_UIxnocxzYFfsRxEkPqhqIOluQjN_Private_Void_Int32_Vector2_PositionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664530);
			TouchJoystick.NativeMethodInfoPtr_baEViyRRodmuwhaehpMDycKSVwN_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664531);
			TouchJoystick.NativeMethodInfoPtr_sKvlCBBoCdqafdbFOCOXCCiLfAtf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664532);
			TouchJoystick.NativeMethodInfoPtr_CmYuplbDIcChxFOHikcWHATbXszo_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664533);
			TouchJoystick.NativeMethodInfoPtr_JAmblvHRjTbFRpLqVhkTwYaNJHM_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664534);
			TouchJoystick.NativeMethodInfoPtr_tvfieGHVIvJAwOWABvkfZuaYRdg_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664535);
			TouchJoystick.NativeMethodInfoPtr_EzuEKEcRDHQOUwaaCWnntUCHasKc_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664536);
			TouchJoystick.NativeMethodInfoPtr_sPcvSSlGvTmwkQDQWFTYqTVIcix_Private_PointerEventData_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664537);
			TouchJoystick.NativeMethodInfoPtr_ldCMCnBLZMpzPoNHaCLvDGIJuib_Private_PointerEventData_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664538);
			TouchJoystick.NativeMethodInfoPtr_fygGGlEnKmuTNSTfXSwkyGEfsJS_Private_PointerEventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664539);
			TouchJoystick.NativeMethodInfoPtr_BtCjHnVCQQZOUErBybAPpoLjeBj_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664540);
			TouchJoystick.NativeMethodInfoPtr_WzWwrwELvSDuhpDoqcIgfbMVGMdL_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664541);
			TouchJoystick.NativeMethodInfoPtr_RTRyejIHkYVUBLhWNMKKFAUfreV_Private_PointerEventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664542);
			TouchJoystick.NativeMethodInfoPtr_WbqbDgpASywaXyCuvhWbQHZDLXX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664543);
			TouchJoystick.NativeMethodInfoPtr_UnMFjSCmAMGvytjoLOAahnsmUzmO_Private_Void_AxisDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664544);
			TouchJoystick.NativeMethodInfoPtr_kigeNwWVsYERXqwjreancGuqqDE_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664545);
			TouchJoystick.NativeMethodInfoPtr_NJoaOsRdPOKjssNjRbxAqdXWPan_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664546);
			TouchJoystick.NativeMethodInfoPtr_ZAVdRrdxNFckOYQCbBCUgAfIgTyA_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664547);
			TouchJoystick.NativeMethodInfoPtr_lfnXGCYWqVSkgcSxlPOzgNuXEtM_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664548);
			TouchJoystick.NativeMethodInfoPtr_kgVYgXAlMRDWNZvFCINUFIWbVvyd_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664549);
			TouchJoystick.NativeMethodInfoPtr_ZkqEhgxutIjvahTgqpNGorntvFG_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664550);
			TouchJoystick.NativeMethodInfoPtr_DpmJfqxVNUXRYgbJEmVzxYQLfQa_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664551);
			TouchJoystick.NativeMethodInfoPtr_DDUCAWJSvpGMNhYKUcwQBJMrScy_Private_Void_Int32_Vector2_MTRzojhzRVbYXLAiscAviPdkJjKD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664552);
			TouchJoystick.NativeMethodInfoPtr_YItZvqPcQhbqZIBTSJcwAqrHqkd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664553);
			TouchJoystick.NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664554);
			TouchJoystick.NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664555);
			TouchJoystick.NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664556);
			TouchJoystick.NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664557);
			TouchJoystick.NativeMethodInfoPtr_OnBeginDrag_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664558);
			TouchJoystick.NativeMethodInfoPtr_OnDrag_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664559);
			TouchJoystick.NativeMethodInfoPtr_OnEndDrag_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664560);
			TouchJoystick.NativeMethodInfoPtr_dUHXYlsiNyoGytvpHasBSXDaouo_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664561);
			TouchJoystick.NativeMethodInfoPtr_MqVGxwdIhdkYxCeELtBHDUDBqHw_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664562);
			TouchJoystick.NativeMethodInfoPtr_SrFgwGeyWNweDotJFrWgeGBpDYGh_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664563);
			TouchJoystick.NativeMethodInfoPtr_RQQGpvvccMPqUmqcSAznEENoAPi_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664564);
			TouchJoystick.NativeMethodInfoPtr_MhWtGoImpcCOOANfVJznkGymNKl_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664565);
			TouchJoystick.NativeMethodInfoPtr_cieygjKKzrfvyZdDvYvTISikRqu_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664566);
			TouchJoystick.NativeMethodInfoPtr_beilSajMDkrKawlQpvkTHNINiuB_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664567);
			TouchJoystick.NativeMethodInfoPtr_iKvhyyDmHyilyjqsJZrcpJwxVPj_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664568);
			TouchJoystick.NativeMethodInfoPtr_get_valueChangedHandlerDelegate_Internal_Static_get_EventFunction_2_IValueChangedHandler_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664569);
			TouchJoystick.NativeMethodInfoPtr_get_stickPositionChangedHandlerDelegate_Internal_Static_get_EventFunction_2_IStickPositionChangedHandler_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664570);
			TouchJoystick.NativeMethodInfoPtr_IqhBUZQPyWVEOCBqQaLEKqvWeNC_Private_Static_Void_IValueChangedHandler_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664571);
			TouchJoystick.NativeMethodInfoPtr_FRUxNHPgzSXwlKeacyAfWmEAEWb_Private_Static_Void_IStickPositionChangedHandler_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, 100664572);
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x000487F8 File Offset: 0x000469F8
		public unsafe CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_horizontalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr3) : null;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00048838 File Offset: 0x00046A38
		public unsafe CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_verticalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr3) : null;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00048878 File Offset: 0x00046A78
		public unsafe CustomControllerElementTargetSetForBoolean tapCustomControllerElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_tapCustomControllerElement_Public_get_CustomControllerElementTargetSetForBoolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForBoolean>(intPtr3) : null;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x000488B8 File Offset: 0x00046AB8
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x000488F8 File Offset: 0x00046AF8
		public unsafe RectTransform stickTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_stickTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247433, XrefRangeEnd = 247449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_stickTransform_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0004893C File Offset: 0x00046B3C
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00048978 File Offset: 0x00046B78
		public unsafe TouchJoystick.JoystickMode joystickMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_joystickMode_Public_get_JoystickMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_joystickMode_Public_set_Void_JoystickMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000489B8 File Offset: 0x00046BB8
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x000489F4 File Offset: 0x00046BF4
		public unsafe float digitalModeDeadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_digitalModeDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247449, XrefRangeEnd = 247450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_digitalModeDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00048A34 File Offset: 0x00046C34
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00048A70 File Offset: 0x00046C70
		public unsafe float stickRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_stickRange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247450, XrefRangeEnd = 247451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_stickRange_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00048AB0 File Offset: 0x00046CB0
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00048AEC File Offset: 0x00046CEC
		public unsafe bool scaleStickRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_scaleStickRange_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_scaleStickRange_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00048B2C File Offset: 0x00046D2C
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00048B68 File Offset: 0x00046D68
		public unsafe TouchJoystick.StickBounds stickBounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_stickBounds_Private_get_StickBounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_stickBounds_Private_set_Void_StickBounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00048BA8 File Offset: 0x00046DA8
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00048BE4 File Offset: 0x00046DE4
		public unsafe TouchJoystick.AxisDirection axesToUse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_axesToUse_Public_get_AxisDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247451, XrefRangeEnd = 247452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_axesToUse_Public_set_Void_AxisDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00048C24 File Offset: 0x00046E24
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00048C60 File Offset: 0x00046E60
		public unsafe TouchJoystick.SnapDirections snapDirections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_snapDirections_Public_get_SnapDirections_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_snapDirections_Public_set_Void_SnapDirections_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00048CA0 File Offset: 0x00046EA0
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00048CDC File Offset: 0x00046EDC
		public unsafe bool snapStickToTouch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_snapStickToTouch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_snapStickToTouch_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00048D1C File Offset: 0x00046F1C
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00048D58 File Offset: 0x00046F58
		public unsafe bool centerStickOnRelease
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_centerStickOnRelease_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_centerStickOnRelease_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00048D98 File Offset: 0x00046F98
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00048DD4 File Offset: 0x00046FD4
		public unsafe bool activateOnSwipeIn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_activateOnSwipeIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_activateOnSwipeIn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00048E14 File Offset: 0x00047014
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00048E50 File Offset: 0x00047050
		public unsafe bool stayActiveOnSwipeOut
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 247464, RefRangeEnd = 247467, XrefRangeStart = 247452, XrefRangeEnd = 247464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_stayActiveOnSwipeOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_stayActiveOnSwipeOut_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00048E90 File Offset: 0x00047090
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x00048ECC File Offset: 0x000470CC
		public unsafe bool allowTap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_allowTap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_allowTap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00048F0C File Offset: 0x0004710C
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00048F48 File Offset: 0x00047148
		public unsafe float tapTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_tapTimeout_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_tapTimeout_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00048F88 File Offset: 0x00047188
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00048FC4 File Offset: 0x000471C4
		public unsafe int tapDistanceLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_tapDistanceLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_tapDistanceLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00049004 File Offset: 0x00047204
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00049044 File Offset: 0x00047244
		public unsafe TouchRegion touchRegion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_touchRegion_Public_get_TouchRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchRegion>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247467, XrefRangeEnd = 247483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_touchRegion_Public_set_Void_TouchRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00049088 File Offset: 0x00047288
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x000490C4 File Offset: 0x000472C4
		public unsafe bool useTouchRegionOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_useTouchRegionOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_useTouchRegionOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00049104 File Offset: 0x00047304
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00049140 File Offset: 0x00047340
		public unsafe bool moveToTouchPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_moveToTouchPosition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_moveToTouchPosition_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00049180 File Offset: 0x00047380
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x000491BC File Offset: 0x000473BC
		public unsafe bool returnOnRelease
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_returnOnRelease_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_returnOnRelease_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x000491FC File Offset: 0x000473FC
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x00049238 File Offset: 0x00047438
		public unsafe bool followTouchPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_followTouchPosition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_followTouchPosition_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00049278 File Offset: 0x00047478
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x000492B4 File Offset: 0x000474B4
		public unsafe bool animateOnMoveToTouch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_animateOnMoveToTouch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_animateOnMoveToTouch_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x000492F4 File Offset: 0x000474F4
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00049330 File Offset: 0x00047530
		public unsafe float moveToTouchSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_moveToTouchSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247483, XrefRangeEnd = 247484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_moveToTouchSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00049370 File Offset: 0x00047570
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x000493AC File Offset: 0x000475AC
		public unsafe bool animateOnReturn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_animateOnReturn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_animateOnReturn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x000493EC File Offset: 0x000475EC
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00049428 File Offset: 0x00047628
		public unsafe float returnSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_returnSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247484, XrefRangeEnd = 247485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_returnSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00049468 File Offset: 0x00047668
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x000494A4 File Offset: 0x000476A4
		public unsafe bool manageRaycasting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_manageRaycasting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247485, XrefRangeEnd = 247488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_manageRaycasting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x000494E4 File Offset: 0x000476E4
		public unsafe AxisCalibration horizontalAxisCalibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_horizontalAxisCalibration_Public_get_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00049524 File Offset: 0x00047724
		public unsafe AxisCalibration verticalAxisCalibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_verticalAxisCalibration_Public_get_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00049564 File Offset: 0x00047764
		public unsafe Axis2DCalibration deadZoneType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_deadZoneType_Public_get_Axis2DCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Axis2DCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x000495A4 File Offset: 0x000477A4
		public unsafe Axis2DCalibration axis2DCalibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_axis2DCalibration_Public_get_Axis2DCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Axis2DCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x000495E4 File Offset: 0x000477E4
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00049620 File Offset: 0x00047820
		public unsafe int pointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00049660 File Offset: 0x00047860
		public unsafe bool hasPointer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_hasPointer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0004969C File Offset: 0x0004789C
		public unsafe bool tapValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247488, XrefRangeEnd = 247490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_tapValue_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x000496D8 File Offset: 0x000478D8
		public unsafe StandaloneAxis2D axis2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_axis2D_Internal_get_StandaloneAxis2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandaloneAxis2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00049718 File Offset: 0x00047918
		public unsafe Action<TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj> moveStartedDelegate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 247496, RefRangeEnd = 247497, XrefRangeStart = 247490, XrefRangeEnd = 247496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_moveStartedDelegate_Private_get_Action_1_TBzQBkblStsOsblRBDCFXBbSxxj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj>>(intPtr3) : null;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00049758 File Offset: 0x00047958
		public unsafe Action<TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj> moveEndedDelegate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247497, XrefRangeEnd = 247503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_moveEndedDelegate_Private_get_Action_1_TBzQBkblStsOsblRBDCFXBbSxxj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj>>(intPtr3) : null;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00049798 File Offset: 0x00047998
		public unsafe int effectivePointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_effectivePointerId_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x000497D4 File Offset: 0x000479D4
		public unsafe RectTransform touchReferenceTransform
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 247509, RefRangeEnd = 247513, XrefRangeStart = 247503, XrefRangeEnd = 247509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_touchReferenceTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00049814 File Offset: 0x00047A14
		public unsafe float calculatedStickRange
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 247538, RefRangeEnd = 247547, XrefRangeStart = 247513, XrefRangeEnd = 247538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_calculatedStickRange_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00049850 File Offset: 0x00047A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247547, XrefRangeEnd = 247552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValueChangedEvent(UnityAction<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_UnityAction_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00049894 File Offset: 0x00047A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247552, XrefRangeEnd = 247555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValueChangedEvent(UnityAction<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_UnityAction_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000498D8 File Offset: 0x00047AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247555, XrefRangeEnd = 247560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_StickPositionChangedEvent(UnityAction<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_add_StickPositionChangedEvent_Public_add_Void_UnityAction_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0004991C File Offset: 0x00047B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247560, XrefRangeEnd = 247563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_StickPositionChangedEvent(UnityAction<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_remove_StickPositionChangedEvent_Public_rem_Void_UnityAction_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00049960 File Offset: 0x00047B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247563, XrefRangeEnd = 247565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TouchDownEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_add_TouchDownEvent_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000499A4 File Offset: 0x00047BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247565, XrefRangeEnd = 247567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TouchDownEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_remove_TouchDownEvent_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000499E8 File Offset: 0x00047BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247567, XrefRangeEnd = 247569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TouchUpEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_add_TouchUpEvent_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00049A2C File Offset: 0x00047C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247569, XrefRangeEnd = 247571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TouchUpEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_remove_TouchUpEvent_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00049A70 File Offset: 0x00047C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247571, XrefRangeEnd = 247573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TapEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_add_TapEvent_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00049AB4 File Offset: 0x00047CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247573, XrefRangeEnd = 247575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TapEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_remove_TapEvent_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00049AF8 File Offset: 0x00047CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247575, XrefRangeEnd = 247619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchJoystick()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00049B34 File Offset: 0x00047D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247619, XrefRangeEnd = 247621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_GetValue_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00049B70 File Offset: 0x00047D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247621, XrefRangeEnd = 247623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRawValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_GetRawValue_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00049BAC File Offset: 0x00047DAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247635, RefRangeEnd = 247638, XrefRangeStart = 247623, XrefRangeEnd = 247635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRawValue(Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_SetRawValue_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00049BEC File Offset: 0x00047DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247638, XrefRangeEnd = 247641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_SetDefaultPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00049C20 File Offset: 0x00047E20
		[CallerCount(0)]
		public unsafe void INvchJBcQkSeGZgUXICnVqDkNBa(Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_INvchJBcQkSeGZgUXICnVqDkNBa_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00049C60 File Offset: 0x00047E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247641, XrefRangeEnd = 247643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnToDefaultPosition(bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instant;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00049CA0 File Offset: 0x00047EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247643, XrefRangeEnd = 247644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnToDefaultPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00049CD4 File Offset: 0x00047ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247644, XrefRangeEnd = 247664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00049D08 File Offset: 0x00047F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247664, XrefRangeEnd = 247666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00049D3C File Offset: 0x00047F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247666, XrefRangeEnd = 247668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00049D70 File Offset: 0x00047F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247668, XrefRangeEnd = 247671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00049DA4 File Offset: 0x00047FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247671, XrefRangeEnd = 247679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NFTSnGXuZXafcZHIgcYanOLckXY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00049DD8 File Offset: 0x00047FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247679, XrefRangeEnd = 247683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool nSRkgireMOAkpBoLMmrDfIispUMG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00049E14 File Offset: 0x00048014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247683, XrefRangeEnd = 247689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void zKEQtrzzyQhnNzFWJQGLGZUsGJG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00049E48 File Offset: 0x00048048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247689, XrefRangeEnd = 247698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ilLZkNyFIEwkNbOyQNmFFIpMaQo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00049E7C File Offset: 0x0004807C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247698, XrefRangeEnd = 247707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LCmYrwVZzAfLeUiFDvNHaNMWskx()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00049EB0 File Offset: 0x000480B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247707, XrefRangeEnd = 247712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00049EE4 File Offset: 0x000480E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247712, XrefRangeEnd = 247720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void xzNKXjAaJMKaZzoFxoimUjvQRfi()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_xzNKXjAaJMKaZzoFxoimUjvQRfi_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00049F18 File Offset: 0x00048118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247720, XrefRangeEnd = 247748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AMTvavhAJFMZzkgIlyIMREPyico()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_AMTvavhAJFMZzkgIlyIMREPyico_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00049F4C File Offset: 0x0004814C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247748, XrefRangeEnd = 247755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00049F80 File Offset: 0x00048180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247755, XrefRangeEnd = 247759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool znFnGxyOXnvNJEFcIxRAkZPVPJH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_znFnGxyOXnvNJEFcIxRAkZPVPJH_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00049FBC File Offset: 0x000481BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247759, XrefRangeEnd = 247793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool aalhwRqcbQhzQHPqjxaJDiTxaYyw(GameObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_aalhwRqcbQhzQHPqjxaJDiTxaYyw_Internal_Virtual_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0004A00C File Offset: 0x0004820C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 247796, RefRangeEnd = 247800, XrefRangeStart = 247793, XrefRangeEnd = 247796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void iJzeeVgTFhPQqdRTfUGBACRnMOF()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0004A040 File Offset: 0x00048240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247804, RefRangeEnd = 247806, XrefRangeStart = 247800, XrefRangeEnd = 247804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void oCddbrAzLSgARApvwyLBgfvztGoB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_oCddbrAzLSgARApvwyLBgfvztGoB_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0004A074 File Offset: 0x00048274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247818, RefRangeEnd = 247820, XrefRangeStart = 247806, XrefRangeEnd = 247818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ScfGINmFMxfNAJVmpKaJsxmTkXqf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_ScfGINmFMxfNAJVmpKaJsxmTkXqf_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0004A0B0 File Offset: 0x000482B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247882, RefRangeEnd = 247883, XrefRangeStart = 247820, XrefRangeEnd = 247882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void nRvokDeWGGctkRtLitHwbAHZIso(TouchRegion A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_nRvokDeWGGctkRtLitHwbAHZIso_Private_Void_TouchRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0004A0F4 File Offset: 0x000482F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247939, RefRangeEnd = 247941, XrefRangeStart = 247883, XrefRangeEnd = 247939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void fOwxbxkERGiUgPApbIWvgPmZPSO(TouchRegion A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_fOwxbxkERGiUgPApbIWvgPmZPSO_Private_Void_TouchRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0004A138 File Offset: 0x00048338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247959, RefRangeEnd = 247961, XrefRangeStart = 247941, XrefRangeEnd = 247959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EqPWznbcqXfSbBqHkAxpEdqMLyWN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_EqPWznbcqXfSbBqHkAxpEdqMLyWN_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0004A16C File Offset: 0x0004836C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247978, RefRangeEnd = 247979, XrefRangeStart = 247961, XrefRangeEnd = 247978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void lYFqcNqPVQUWLQzfHypznAkffnR(Vector2 A_1, bool A_2, float A_3, TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj A_4)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_lYFqcNqPVQUWLQzfHypznAkffnR_Private_Void_Vector2_Boolean_Single_TBzQBkblStsOsblRBDCFXBbSxxj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0004A1D4 File Offset: 0x000483D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 248049, RefRangeEnd = 248055, XrefRangeStart = 247979, XrefRangeEnd = 248049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void bndCRqovhXNzogiaEgObWGJQjPoa(Vector2 A_1, PositionType A_2, bool A_3, float A_4, TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj A_5)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_bndCRqovhXNzogiaEgObWGJQjPoa_Private_Void_Vector2_PositionType_Boolean_Single_TBzQBkblStsOsblRBDCFXBbSxxj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0004A24C File Offset: 0x0004844C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248055, XrefRangeEnd = 248058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator vkcfalFMzcgemqDQsIhfobMLjflg(Vector2 A_1, PositionType A_2, float A_3, TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj A_4)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_vkcfalFMzcgemqDQsIhfobMLjflg_Private_IEnumerator_Vector2_PositionType_Single_TBzQBkblStsOsblRBDCFXBbSxxj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0004A2C4 File Offset: 0x000484C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248072, RefRangeEnd = 248073, XrefRangeStart = 248058, XrefRangeEnd = 248072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DsphDRCaOcDcijQVdImpyNcwmHe(TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj A_1, Vector2 A_2, PositionType A_3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_DsphDRCaOcDcijQVdImpyNcwmHe_Private_Void_TBzQBkblStsOsblRBDCFXBbSxxj_Vector2_PositionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0004A320 File Offset: 0x00048520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248073, XrefRangeEnd = 248089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void XLLNWtCwXRBqlTJzCfKrbpeyhQGq(TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_XLLNWtCwXRBqlTJzCfKrbpeyhQGq_Private_Void_TBzQBkblStsOsblRBDCFXBbSxxj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0004A360 File Offset: 0x00048560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248089, XrefRangeEnd = 248106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SIuBcTqDlIpUZIPLQnVORwJXTBJ(TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_SIuBcTqDlIpUZIPLQnVORwJXTBJ_Private_Void_TBzQBkblStsOsblRBDCFXBbSxxj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0004A3A0 File Offset: 0x000485A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248108, RefRangeEnd = 248111, XrefRangeStart = 248106, XrefRangeEnd = 248108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void nUDeYYbgQCDNaKgGyfLeqdHdeMxP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_nUDeYYbgQCDNaKgGyfLeqdHdeMxP_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0004A3D4 File Offset: 0x000485D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248118, RefRangeEnd = 248119, XrefRangeStart = 248111, XrefRangeEnd = 248118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UIxnocxzYFfsRxEkPqhqIOluQjN(int A_1, Vector2 A_2, PositionType A_3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_UIxnocxzYFfsRxEkPqhqIOluQjN_Private_Void_Int32_Vector2_PositionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0004A430 File Offset: 0x00048630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248169, RefRangeEnd = 248170, XrefRangeStart = 248119, XrefRangeEnd = 248169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void baEViyRRodmuwhaehpMDycKSVwN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_baEViyRRodmuwhaehpMDycKSVwN_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0004A464 File Offset: 0x00048664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248170, XrefRangeEnd = 248176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sKvlCBBoCdqafdbFOCOXCCiLfAtf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_sKvlCBBoCdqafdbFOCOXCCiLfAtf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0004A498 File Offset: 0x00048698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248176, XrefRangeEnd = 248178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmYuplbDIcChxFOHikcWHATbXszo(ref Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_CmYuplbDIcChxFOHikcWHATbXszo_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0004A4D8 File Offset: 0x000486D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248178, XrefRangeEnd = 248190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool JAmblvHRjTbFRpLqVhkTwYaNJHM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_JAmblvHRjTbFRpLqVhkTwYaNJHM_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0004A514 File Offset: 0x00048714
		[CallerCount(0)]
		public unsafe void tvfieGHVIvJAwOWABvkfZuaYRdg()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_tvfieGHVIvJAwOWABvkfZuaYRdg_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0004A548 File Offset: 0x00048748
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 248193, RefRangeEnd = 248202, XrefRangeStart = 248190, XrefRangeEnd = 248193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EzuEKEcRDHQOUwaaCWnntUCHasKc(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_EzuEKEcRDHQOUwaaCWnntUCHasKc_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0004A594 File Offset: 0x00048794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248219, RefRangeEnd = 248220, XrefRangeStart = 248202, XrefRangeEnd = 248219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_sPcvSSlGvTmwkQDQWFTYqTVIcix_Private_PointerEventData_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0004A5F4 File Offset: 0x000487F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248226, RefRangeEnd = 248228, XrefRangeStart = 248220, XrefRangeEnd = 248226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData ldCMCnBLZMpzPoNHaCLvDGIJuib(int A_1, GameObject A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_ldCMCnBLZMpzPoNHaCLvDGIJuib_Private_PointerEventData_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0004A654 File Offset: 0x00048854
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 248243, RefRangeEnd = 248248, XrefRangeStart = 248228, XrefRangeEnd = 248243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData fygGGlEnKmuTNSTfXSwkyGEfsJS(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_fygGGlEnKmuTNSTfXSwkyGEfsJS_Private_PointerEventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0004A6A0 File Offset: 0x000488A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248248, XrefRangeEnd = 248250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BtCjHnVCQQZOUErBybAPpoLjeBj(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_BtCjHnVCQQZOUErBybAPpoLjeBj_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0004A6E4 File Offset: 0x000488E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248258, RefRangeEnd = 248260, XrefRangeStart = 248250, XrefRangeEnd = 248258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WzWwrwELvSDuhpDoqcIgfbMVGMdL(PointerEventData A_1, TouchJoystick.MTRzojhzRVbYXLAiscAviPdkJjKD A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_WzWwrwELvSDuhpDoqcIgfbMVGMdL_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0004A734 File Offset: 0x00048934
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 248283, RefRangeEnd = 248287, XrefRangeStart = 248260, XrefRangeEnd = 248283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData RTRyejIHkYVUBLhWNMKKFAUfreV(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_RTRyejIHkYVUBLhWNMKKFAUfreV_Private_PointerEventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0004A780 File Offset: 0x00048980
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248296, RefRangeEnd = 248299, XrefRangeStart = 248287, XrefRangeEnd = 248296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WbqbDgpASywaXyCuvhWbQHZDLXX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_WbqbDgpASywaXyCuvhWbQHZDLXX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0004A7B4 File Offset: 0x000489B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248310, RefRangeEnd = 248312, XrefRangeStart = 248299, XrefRangeEnd = 248310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnMFjSCmAMGvytjoLOAahnsmUzmO(TouchJoystick.AxisDirection A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_UnMFjSCmAMGvytjoLOAahnsmUzmO_Private_Void_AxisDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0004A7F4 File Offset: 0x000489F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248319, RefRangeEnd = 248322, XrefRangeStart = 248312, XrefRangeEnd = 248319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void kigeNwWVsYERXqwjreancGuqqDE(PointerEventData A_1, TouchJoystick.MTRzojhzRVbYXLAiscAviPdkJjKD A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_kigeNwWVsYERXqwjreancGuqqDE_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0004A844 File Offset: 0x00048A44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248330, RefRangeEnd = 248332, XrefRangeStart = 248322, XrefRangeEnd = 248330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NJoaOsRdPOKjssNjRbxAqdXWPan(PointerEventData A_1, TouchJoystick.MTRzojhzRVbYXLAiscAviPdkJjKD A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_NJoaOsRdPOKjssNjRbxAqdXWPan_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0004A894 File Offset: 0x00048A94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248361, RefRangeEnd = 248363, XrefRangeStart = 248332, XrefRangeEnd = 248361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZAVdRrdxNFckOYQCbBCUgAfIgTyA(PointerEventData A_1, TouchJoystick.MTRzojhzRVbYXLAiscAviPdkJjKD A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_ZAVdRrdxNFckOYQCbBCUgAfIgTyA_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0004A8E4 File Offset: 0x00048AE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248372, RefRangeEnd = 248374, XrefRangeStart = 248363, XrefRangeEnd = 248372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void lfnXGCYWqVSkgcSxlPOzgNuXEtM(PointerEventData A_1, TouchJoystick.MTRzojhzRVbYXLAiscAviPdkJjKD A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_lfnXGCYWqVSkgcSxlPOzgNuXEtM_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0004A934 File Offset: 0x00048B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248379, RefRangeEnd = 248380, XrefRangeStart = 248374, XrefRangeEnd = 248379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void kgVYgXAlMRDWNZvFCINUFIWbVvyd(PointerEventData A_1, TouchJoystick.MTRzojhzRVbYXLAiscAviPdkJjKD A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_kgVYgXAlMRDWNZvFCINUFIWbVvyd_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0004A984 File Offset: 0x00048B84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248422, RefRangeEnd = 248425, XrefRangeStart = 248380, XrefRangeEnd = 248422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZkqEhgxutIjvahTgqpNGorntvFG(PointerEventData A_1, TouchJoystick.MTRzojhzRVbYXLAiscAviPdkJjKD A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_ZkqEhgxutIjvahTgqpNGorntvFG_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0004A9D4 File Offset: 0x00048BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248430, RefRangeEnd = 248431, XrefRangeStart = 248425, XrefRangeEnd = 248430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DpmJfqxVNUXRYgbJEmVzxYQLfQa(PointerEventData A_1, TouchJoystick.MTRzojhzRVbYXLAiscAviPdkJjKD A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_DpmJfqxVNUXRYgbJEmVzxYQLfQa_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0004AA24 File Offset: 0x00048C24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248466, RefRangeEnd = 248467, XrefRangeStart = 248431, XrefRangeEnd = 248466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DDUCAWJSvpGMNhYKUcwQBJMrScy(int A_1, Vector2 A_2, TouchJoystick.MTRzojhzRVbYXLAiscAviPdkJjKD A_3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_DDUCAWJSvpGMNhYKUcwQBJMrScy_Private_Void_Int32_Vector2_MTRzojhzRVbYXLAiscAviPdkJjKD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0004AA80 File Offset: 0x00048C80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248479, RefRangeEnd = 248482, XrefRangeStart = 248467, XrefRangeEnd = 248479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void YItZvqPcQhbqZIBTSJcwAqrHqkd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_YItZvqPcQhbqZIBTSJcwAqrHqkd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0004AAB4 File Offset: 0x00048CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248482, XrefRangeEnd = 248499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0004AAF8 File Offset: 0x00048CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248499, XrefRangeEnd = 248516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0004AB3C File Offset: 0x00048D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248516, XrefRangeEnd = 248533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0004AB80 File Offset: 0x00048D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248533, XrefRangeEnd = 248550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0004ABC4 File Offset: 0x00048DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248550, XrefRangeEnd = 248567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_OnBeginDrag_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0004AC08 File Offset: 0x00048E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248567, XrefRangeEnd = 248584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_OnDrag_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0004AC4C File Offset: 0x00048E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248584, XrefRangeEnd = 248601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_OnEndDrag_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0004AC90 File Offset: 0x00048E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248601, XrefRangeEnd = 248606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dUHXYlsiNyoGytvpHasBSXDaouo(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_dUHXYlsiNyoGytvpHasBSXDaouo_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0004ACD4 File Offset: 0x00048ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248606, XrefRangeEnd = 248611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MqVGxwdIhdkYxCeELtBHDUDBqHw(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_MqVGxwdIhdkYxCeELtBHDUDBqHw_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0004AD18 File Offset: 0x00048F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248611, XrefRangeEnd = 248616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SrFgwGeyWNweDotJFrWgeGBpDYGh(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_SrFgwGeyWNweDotJFrWgeGBpDYGh_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0004AD5C File Offset: 0x00048F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248616, XrefRangeEnd = 248621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RQQGpvvccMPqUmqcSAznEENoAPi(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_RQQGpvvccMPqUmqcSAznEENoAPi_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0004ADA0 File Offset: 0x00048FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248621, XrefRangeEnd = 248630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MhWtGoImpcCOOANfVJznkGymNKl(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_MhWtGoImpcCOOANfVJznkGymNKl_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0004ADE4 File Offset: 0x00048FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248630, XrefRangeEnd = 248635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void cieygjKKzrfvyZdDvYvTISikRqu(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_cieygjKKzrfvyZdDvYvTISikRqu_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0004AE28 File Offset: 0x00049028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248635, XrefRangeEnd = 248644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void beilSajMDkrKawlQpvkTHNINiuB(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_beilSajMDkrKawlQpvkTHNINiuB_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0004AE6C File Offset: 0x0004906C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248644, XrefRangeEnd = 248707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void iKvhyyDmHyilyjqsJZrcpJwxVPj(Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_iKvhyyDmHyilyjqsJZrcpJwxVPj_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0004AEAC File Offset: 0x000490AC
		public unsafe static jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IValueChangedHandler, Vector2> valueChangedHandlerDelegate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 248718, RefRangeEnd = 248719, XrefRangeStart = 248707, XrefRangeEnd = 248718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_valueChangedHandlerDelegate_Internal_Static_get_EventFunction_2_IValueChangedHandler_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IValueChangedHandler, Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0004AEE0 File Offset: 0x000490E0
		public unsafe static jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2> stickPositionChangedHandlerDelegate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 248730, RefRangeEnd = 248731, XrefRangeStart = 248719, XrefRangeEnd = 248730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_get_stickPositionChangedHandlerDelegate_Internal_Static_get_EventFunction_2_IStickPositionChangedHandler_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0004AF14 File Offset: 0x00049114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248731, XrefRangeEnd = 248735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IqhBUZQPyWVEOCBqQaLEKqvWeNC(TouchJoystick.IValueChangedHandler A_0, Vector2 A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_IqhBUZQPyWVEOCBqQaLEKqvWeNC_Private_Static_Void_IValueChangedHandler_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0004AF58 File Offset: 0x00049158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248735, XrefRangeEnd = 248739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FRUxNHPgzSXwlKeacyAfWmEAEWb(TouchJoystick.IStickPositionChangedHandler A_0, Vector2 A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.NativeMethodInfoPtr_FRUxNHPgzSXwlKeacyAfWmEAEWb_Private_Static_Void_IStickPositionChangedHandler_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0000422E File Offset: 0x0000242E
		public TouchJoystick(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0004AF9C File Offset: 0x0004919C
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00004237 File Offset: 0x00002437
		public unsafe static float MAX_MOVE_SPEED
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TouchJoystick.NativeFieldInfoPtr_MAX_MOVE_SPEED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchJoystick.NativeFieldInfoPtr_MAX_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x0004AFB8 File Offset: 0x000491B8
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00004245 File Offset: 0x00002445
		public unsafe CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__horizontalAxisCustomControllerElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__horizontalAxisCustomControllerElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x0004AFE8 File Offset: 0x000491E8
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00004264 File Offset: 0x00002464
		public unsafe CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__verticalAxisCustomControllerElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__verticalAxisCustomControllerElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0004B018 File Offset: 0x00049218
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00004283 File Offset: 0x00002483
		public unsafe CustomControllerElementTargetSetForBoolean _tapCustomControllerElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__tapCustomControllerElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForBoolean>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__tapCustomControllerElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0004B048 File Offset: 0x00049248
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x000042A2 File Offset: 0x000024A2
		public unsafe RectTransform _stickTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__stickTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__stickTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x0004B078 File Offset: 0x00049278
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x000042C1 File Offset: 0x000024C1
		public unsafe TouchJoystick.JoystickMode _joystickMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__joystickMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__joystickMode)) = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x0004B0A0 File Offset: 0x000492A0
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x000042DC File Offset: 0x000024DC
		public unsafe float _digitalModeDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__digitalModeDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__digitalModeDeadZone)) = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x0004B0C8 File Offset: 0x000492C8
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x000042F7 File Offset: 0x000024F7
		public unsafe float _stickRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__stickRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__stickRange)) = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0004B0F0 File Offset: 0x000492F0
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00004312 File Offset: 0x00002512
		public unsafe bool _scaleStickRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__scaleStickRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__scaleStickRange)) = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0004B118 File Offset: 0x00049318
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x0000432D File Offset: 0x0000252D
		public unsafe TouchJoystick.StickBounds _stickBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__stickBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__stickBounds)) = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0004B140 File Offset: 0x00049340
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00004348 File Offset: 0x00002548
		public unsafe TouchJoystick.AxisDirection _axesToUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__axesToUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__axesToUse)) = value;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0004B168 File Offset: 0x00049368
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00004363 File Offset: 0x00002563
		public unsafe TouchJoystick.SnapDirections _snapDirections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__snapDirections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__snapDirections)) = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0004B190 File Offset: 0x00049390
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x0000437E File Offset: 0x0000257E
		public unsafe bool _snapStickToTouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__snapStickToTouch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__snapStickToTouch)) = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x0004B1B8 File Offset: 0x000493B8
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00004399 File Offset: 0x00002599
		public unsafe bool _centerStickOnRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__centerStickOnRelease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__centerStickOnRelease)) = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0004B1E0 File Offset: 0x000493E0
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x000043B4 File Offset: 0x000025B4
		public unsafe StandaloneAxis2D _axis2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__axis2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__axis2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x0004B210 File Offset: 0x00049410
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x000043D3 File Offset: 0x000025D3
		public unsafe bool _activateOnSwipeIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__activateOnSwipeIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__activateOnSwipeIn)) = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x0004B238 File Offset: 0x00049438
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x000043EE File Offset: 0x000025EE
		public unsafe bool _stayActiveOnSwipeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__stayActiveOnSwipeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__stayActiveOnSwipeOut)) = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x0004B260 File Offset: 0x00049460
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00004409 File Offset: 0x00002609
		public unsafe bool _allowTap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__allowTap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__allowTap)) = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x0004B288 File Offset: 0x00049488
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00004424 File Offset: 0x00002624
		public unsafe float _tapTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__tapTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__tapTimeout)) = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0004B2B0 File Offset: 0x000494B0
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x0000443F File Offset: 0x0000263F
		public unsafe int _tapDistanceLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__tapDistanceLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__tapDistanceLimit)) = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x0004B2D8 File Offset: 0x000494D8
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x0000445A File Offset: 0x0000265A
		public unsafe TouchRegion _touchRegion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__touchRegion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchRegion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__touchRegion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x0004B308 File Offset: 0x00049508
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x00004479 File Offset: 0x00002679
		public unsafe bool _useTouchRegionOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__useTouchRegionOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__useTouchRegionOnly)) = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x0004B330 File Offset: 0x00049530
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00004494 File Offset: 0x00002694
		public unsafe bool _moveToTouchPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__moveToTouchPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__moveToTouchPosition)) = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x0004B358 File Offset: 0x00049558
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x000044AF File Offset: 0x000026AF
		public unsafe bool _returnOnRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__returnOnRelease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__returnOnRelease)) = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x0004B380 File Offset: 0x00049580
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x000044CA File Offset: 0x000026CA
		public unsafe bool _followTouchPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__followTouchPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__followTouchPosition)) = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0004B3A8 File Offset: 0x000495A8
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x000044E5 File Offset: 0x000026E5
		public unsafe bool _animateOnMoveToTouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__animateOnMoveToTouch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__animateOnMoveToTouch)) = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x0004B3D0 File Offset: 0x000495D0
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00004500 File Offset: 0x00002700
		public unsafe float _moveToTouchSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__moveToTouchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__moveToTouchSpeed)) = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x0004B3F8 File Offset: 0x000495F8
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x0000451B File Offset: 0x0000271B
		public unsafe bool _animateOnReturn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__animateOnReturn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__animateOnReturn)) = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x0004B420 File Offset: 0x00049620
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00004536 File Offset: 0x00002736
		public unsafe float _returnSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__returnSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__returnSpeed)) = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x0004B448 File Offset: 0x00049648
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00004551 File Offset: 0x00002751
		public unsafe bool _manageRaycasting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__manageRaycasting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__manageRaycasting)) = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x0004B470 File Offset: 0x00049670
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x0000456C File Offset: 0x0000276C
		public unsafe bool _useXAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__useXAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__useXAxis)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0004B498 File Offset: 0x00049698
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00004587 File Offset: 0x00002787
		public unsafe bool _useYAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__useYAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__useYAxis)) = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0004B4C0 File Offset: 0x000496C0
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x000045A2 File Offset: 0x000027A2
		public unsafe jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<TouchJoystick.IValueChangedHandler, Vector2> _hierarchyValueChangedHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__hierarchyValueChangedHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<TouchJoystick.IValueChangedHandler, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__hierarchyValueChangedHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0004B4F0 File Offset: 0x000496F0
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x000045C1 File Offset: 0x000027C1
		public unsafe jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<TouchJoystick.IStickPositionChangedHandler, Vector2> _hierarchyStickPositionChangedHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__hierarchyStickPositionChangedHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.HierarchyEventHelper<TouchJoystick.IStickPositionChangedHandler, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__hierarchyStickPositionChangedHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0004B520 File Offset: 0x00049720
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x000045E0 File Offset: 0x000027E0
		public unsafe TouchRegion _workingTouchRegion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__workingTouchRegion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchRegion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__workingTouchRegion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x0004B550 File Offset: 0x00049750
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x000045FF File Offset: 0x000027FF
		public unsafe Vector2 _origAnchoredPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__origAnchoredPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__origAnchoredPosition)) = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0004B578 File Offset: 0x00049778
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x0000461A File Offset: 0x0000281A
		public unsafe Vector2 _origStickAnchoredPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__origStickAnchoredPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__origStickAnchoredPosition)) = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0004B5A0 File Offset: 0x000497A0
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x00004635 File Offset: 0x00002835
		public unsafe Vector2 _lastPressAnchoredPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__lastPressAnchoredPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__lastPressAnchoredPosition)) = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0004B5C8 File Offset: 0x000497C8
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00004650 File Offset: 0x00002850
		public unsafe bool _isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__isMoving)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0004B5F0 File Offset: 0x000497F0
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x0000466B File Offset: 0x0000286B
		public unsafe bool _isMovedFromDefaultPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__isMovedFromDefaultPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__isMovedFromDefaultPosition)) = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x0004B618 File Offset: 0x00049818
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x00004686 File Offset: 0x00002886
		public unsafe TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj _moveDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__moveDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__moveDirection)) = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x0004B640 File Offset: 0x00049840
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x000046A1 File Offset: 0x000028A1
		public unsafe int _pointerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__pointerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__pointerId)) = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0004B668 File Offset: 0x00049868
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x000046BC File Offset: 0x000028BC
		public unsafe int _realMousePointerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__realMousePointerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__realMousePointerId)) = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0004B690 File Offset: 0x00049890
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x000046D7 File Offset: 0x000028D7
		public new unsafe bool AJKoOMhkVHACBErfSbaQmDfyxZV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV)) = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0004B6B8 File Offset: 0x000498B8
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x000046F2 File Offset: 0x000028F2
		public new unsafe bool xISHKSqmxBFBXboSBVekNAulortJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ)) = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0004B6E0 File Offset: 0x000498E0
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x0000470D File Offset: 0x0000290D
		public unsafe bool _pointerDownIsFake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__pointerDownIsFake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__pointerDownIsFake)) = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0004B708 File Offset: 0x00049908
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x00004728 File Offset: 0x00002928
		public unsafe Vector2 _lastPressStartingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__lastPressStartingValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__lastPressStartingValue)) = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x0004B730 File Offset: 0x00049930
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x00004743 File Offset: 0x00002943
		public unsafe TouchJoystick.MTRzojhzRVbYXLAiscAviPdkJjKD _lastClaimSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__lastClaimSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__lastClaimSource)) = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x0004B758 File Offset: 0x00049958
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x0000475E File Offset: 0x0000295E
		public unsafe float _touchStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__touchStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__touchStartTime)) = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x0004B780 File Offset: 0x00049980
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00004779 File Offset: 0x00002979
		public unsafe Vector2 _touchStartPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__touchStartPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__touchStartPosition)) = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x0004B7A8 File Offset: 0x000499A8
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x00004794 File Offset: 0x00002994
		public unsafe IEnumerator _coroutineMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__coroutineMove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__coroutineMove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x0004B7D8 File Offset: 0x000499D8
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x000047B3 File Offset: 0x000029B3
		public unsafe kmRUwlUPdxkBYAIjfDmUhHgmIqam _imageRaycastHelper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__imageRaycastHelper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<kmRUwlUPdxkBYAIjfDmUhHgmIqam>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__imageRaycastHelper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0004B808 File Offset: 0x00049A08
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x000047D2 File Offset: 0x000029D2
		public unsafe int _calculatedStickRange_lastUpdatedFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__calculatedStickRange_lastUpdatedFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__calculatedStickRange_lastUpdatedFrame)) = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x0004B830 File Offset: 0x00049A30
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x000047ED File Offset: 0x000029ED
		public unsafe int _lastTapFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__lastTapFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__lastTapFrame)) = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0004B858 File Offset: 0x00049A58
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00004808 File Offset: 0x00002A08
		public unsafe bool _isEligibleForTap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__isEligibleForTap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__isEligibleForTap)) = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0004B880 File Offset: 0x00049A80
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x00004823 File Offset: 0x00002A23
		public unsafe float __calculatedStickRange_cachedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr___calculatedStickRange_cachedValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr___calculatedStickRange_cachedValue)) = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x0004B8A8 File Offset: 0x00049AA8
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x0000483E File Offset: 0x00002A3E
		public unsafe Action<TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj> __moveStartedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr___moveStartedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr___moveStartedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x0004B8D8 File Offset: 0x00049AD8
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x0000485D File Offset: 0x00002A5D
		public unsafe Action<TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj> __moveEndedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr___moveEndedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr___moveEndedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x0004B908 File Offset: 0x00049B08
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x0000487C File Offset: 0x00002A7C
		public unsafe TouchJoystick.ValueChangedEventHandler _onValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__onValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchJoystick.ValueChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__onValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x0004B938 File Offset: 0x00049B38
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x0000489B File Offset: 0x00002A9B
		public unsafe TouchJoystick.ValueChangedEventHandler _onStickPositionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__onStickPositionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchJoystick.ValueChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__onStickPositionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x0004B968 File Offset: 0x00049B68
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x000048BA File Offset: 0x00002ABA
		public unsafe TouchJoystick.TouchStartedEventHandler _onTouchStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__onTouchStarted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchJoystick.TouchStartedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__onTouchStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x0004B998 File Offset: 0x00049B98
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x000048D9 File Offset: 0x00002AD9
		public unsafe TouchJoystick.TouchEndedEventHandler _onTouchEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__onTouchEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchJoystick.TouchEndedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__onTouchEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x0004B9C8 File Offset: 0x00049BC8
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x000048F8 File Offset: 0x00002AF8
		public unsafe TouchJoystick.TapEventHandler _onTap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__onTap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchJoystick.TapEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr__onTap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x0004B9F8 File Offset: 0x00049BF8
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00004917 File Offset: 0x00002B17
		public unsafe Dictionary<int, PointerEventData> __fakePointerEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr___fakePointerEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PointerEventData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.NativeFieldInfoPtr___fakePointerEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x0004BA28 File Offset: 0x00049C28
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x00004936 File Offset: 0x00002B36
		public unsafe static jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IValueChangedHandler, Vector2> __valueChangedHandlerDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TouchJoystick.NativeFieldInfoPtr___valueChangedHandlerDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IValueChangedHandler, Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchJoystick.NativeFieldInfoPtr___valueChangedHandlerDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x0004BA50 File Offset: 0x00049C50
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00004948 File Offset: 0x00002B48
		public unsafe static jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2> __stickPositionChangedHandlerDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TouchJoystick.NativeFieldInfoPtr___stickPositionChangedHandlerDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchJoystick.NativeFieldInfoPtr___stickPositionChangedHandlerDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x0004BA78 File Offset: 0x00049C78
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x0000495A File Offset: 0x00002B5A
		public unsafe static jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IValueChangedHandler, Vector2> field_Private_Static_EventFunction_2_IValueChangedHandler_Vector2_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TouchJoystick.NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IValueChangedHandler_Vector2_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IValueChangedHandler, Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchJoystick.NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IValueChangedHandler_Vector2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x0004BAA0 File Offset: 0x00049CA0
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x0000496C File Offset: 0x00002B6C
		public unsafe static jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2> field_Private_Static_EventFunction_2_IStickPositionChangedHandler_Vector2_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TouchJoystick.NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IStickPositionChangedHandler_Vector2_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<jfFDlPfrqkYtRfskafICJAZSWFM.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchJoystick.NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IStickPositionChangedHandler_Vector2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeFieldInfoPtr_MAX_MOVE_SPEED;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr__horizontalAxisCustomControllerElement;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr__verticalAxisCustomControllerElement;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr__tapCustomControllerElement;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeFieldInfoPtr__stickTransform;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeFieldInfoPtr__joystickMode;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeFieldInfoPtr__digitalModeDeadZone;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr__stickRange;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr__scaleStickRange;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr__stickBounds;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeFieldInfoPtr__axesToUse;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeFieldInfoPtr__snapDirections;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeFieldInfoPtr__snapStickToTouch;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeFieldInfoPtr__centerStickOnRelease;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeFieldInfoPtr__axis2D;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr__activateOnSwipeIn;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr__stayActiveOnSwipeOut;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr__allowTap;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeFieldInfoPtr__tapTimeout;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeFieldInfoPtr__tapDistanceLimit;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeFieldInfoPtr__touchRegion;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeFieldInfoPtr__useTouchRegionOnly;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeFieldInfoPtr__moveToTouchPosition;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeFieldInfoPtr__returnOnRelease;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr__followTouchPosition;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeFieldInfoPtr__animateOnMoveToTouch;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeFieldInfoPtr__moveToTouchSpeed;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeFieldInfoPtr__animateOnReturn;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeFieldInfoPtr__returnSpeed;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeFieldInfoPtr__manageRaycasting;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeFieldInfoPtr__useXAxis;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeFieldInfoPtr__useYAxis;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeFieldInfoPtr__hierarchyValueChangedHandlers;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr__hierarchyStickPositionChangedHandlers;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeFieldInfoPtr__workingTouchRegion;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr__origAnchoredPosition;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr__origStickAnchoredPosition;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr__lastPressAnchoredPosition;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr__isMoving;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeFieldInfoPtr__isMovedFromDefaultPosition;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeFieldInfoPtr__moveDirection;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeFieldInfoPtr__pointerId;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeFieldInfoPtr__realMousePointerId;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeFieldInfoPtr__pointerDownIsFake;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeFieldInfoPtr__lastPressStartingValue;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr__lastClaimSource;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeFieldInfoPtr__touchStartTime;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeFieldInfoPtr__touchStartPosition;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeFieldInfoPtr__coroutineMove;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeFieldInfoPtr__imageRaycastHelper;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeFieldInfoPtr__calculatedStickRange_lastUpdatedFrame;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeFieldInfoPtr__lastTapFrame;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeFieldInfoPtr__isEligibleForTap;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr___calculatedStickRange_cachedValue;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr___moveStartedDelegate;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr___moveEndedDelegate;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr__onValueChanged;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr__onStickPositionChanged;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeFieldInfoPtr__onTouchStarted;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeFieldInfoPtr__onTouchEnded;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeFieldInfoPtr__onTap;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeFieldInfoPtr___fakePointerEventData;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeFieldInfoPtr___valueChangedHandlerDelegate;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeFieldInfoPtr___stickPositionChangedHandlerDelegate;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IValueChangedHandler_Vector2_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Static_EventFunction_2_IStickPositionChangedHandler_Vector2_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_get_tapCustomControllerElement_Public_get_CustomControllerElementTargetSetForBoolean_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_get_stickTransform_Public_get_RectTransform_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_set_stickTransform_Public_set_Void_RectTransform_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_get_joystickMode_Public_get_JoystickMode_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_set_joystickMode_Public_set_Void_JoystickMode_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_get_digitalModeDeadZone_Public_get_Single_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_set_digitalModeDeadZone_Public_set_Void_Single_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_get_stickRange_Public_get_Single_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_set_stickRange_Public_set_Void_Single_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_get_scaleStickRange_Public_get_Boolean_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_set_scaleStickRange_Public_set_Void_Boolean_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_get_stickBounds_Private_get_StickBounds_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_set_stickBounds_Private_set_Void_StickBounds_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_get_axesToUse_Public_get_AxisDirection_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_set_axesToUse_Public_set_Void_AxisDirection_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_get_snapDirections_Public_get_SnapDirections_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_set_snapDirections_Public_set_Void_SnapDirections_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_get_snapStickToTouch_Public_get_Boolean_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_set_snapStickToTouch_Public_set_Void_Boolean_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_get_centerStickOnRelease_Public_get_Boolean_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_set_centerStickOnRelease_Public_set_Void_Boolean_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_get_activateOnSwipeIn_Public_get_Boolean_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_set_activateOnSwipeIn_Public_set_Void_Boolean_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_get_stayActiveOnSwipeOut_Public_get_Boolean_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_set_stayActiveOnSwipeOut_Public_set_Void_Boolean_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_get_allowTap_Public_get_Boolean_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_set_allowTap_Public_set_Void_Boolean_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_get_tapTimeout_Public_get_Single_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_set_tapTimeout_Public_set_Void_Single_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_get_tapDistanceLimit_Public_get_Int32_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_set_tapDistanceLimit_Public_set_Void_Int32_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_get_touchRegion_Public_get_TouchRegion_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_set_touchRegion_Public_set_Void_TouchRegion_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_get_useTouchRegionOnly_Public_get_Boolean_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_set_useTouchRegionOnly_Public_set_Void_Boolean_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_get_moveToTouchPosition_Public_get_Boolean_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_set_moveToTouchPosition_Public_set_Void_Boolean_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_get_returnOnRelease_Public_get_Boolean_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_set_returnOnRelease_Public_set_Void_Boolean_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_get_followTouchPosition_Public_get_Boolean_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_set_followTouchPosition_Public_set_Void_Boolean_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_get_animateOnMoveToTouch_Public_get_Boolean_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_set_animateOnMoveToTouch_Public_set_Void_Boolean_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_get_moveToTouchSpeed_Public_get_Single_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_set_moveToTouchSpeed_Public_set_Void_Single_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_get_animateOnReturn_Public_get_Boolean_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_set_animateOnReturn_Public_set_Void_Boolean_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_get_returnSpeed_Public_get_Single_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_set_returnSpeed_Public_set_Void_Single_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_get_manageRaycasting_Public_get_Boolean_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_set_manageRaycasting_Public_set_Void_Boolean_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAxisCalibration_Public_get_AxisCalibration_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalAxisCalibration_Public_get_AxisCalibration_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_get_deadZoneType_Public_get_Axis2DCalibration_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_get_axis2DCalibration_Public_get_Axis2DCalibration_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_get_hasPointer_Public_get_Boolean_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_get_tapValue_Private_get_Boolean_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_get_axis2D_Internal_get_StandaloneAxis2D_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_get_moveStartedDelegate_Private_get_Action_1_TBzQBkblStsOsblRBDCFXBbSxxj_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_get_moveEndedDelegate_Private_get_Action_1_TBzQBkblStsOsblRBDCFXBbSxxj_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_get_effectivePointerId_Private_get_Int32_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_get_touchReferenceTransform_Private_get_RectTransform_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_get_calculatedStickRange_Private_get_Single_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_UnityAction_1_Vector2_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_UnityAction_1_Vector2_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_add_StickPositionChangedEvent_Public_add_Void_UnityAction_1_Vector2_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_remove_StickPositionChangedEvent_Public_rem_Void_UnityAction_1_Vector2_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_add_TouchDownEvent_Public_add_Void_UnityAction_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_remove_TouchDownEvent_Public_rem_Void_UnityAction_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_add_TouchUpEvent_Public_add_Void_UnityAction_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_remove_TouchUpEvent_Public_rem_Void_UnityAction_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_add_TapEvent_Public_add_Void_UnityAction_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_remove_TapEvent_Public_rem_Void_UnityAction_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Vector2_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_GetRawValue_Public_Vector2_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_SetRawValue_Public_Void_Vector2_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultPosition_Public_Void_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_INvchJBcQkSeGZgUXICnVqDkNBa_Private_Void_Vector2_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_Boolean_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_ReturnToDefaultPosition_Public_Void_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_Void_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_Void_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_Void_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_xzNKXjAaJMKaZzoFxoimUjvQRfi_Internal_Virtual_Void_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_AMTvavhAJFMZzkgIlyIMREPyico_Internal_Virtual_Void_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_znFnGxyOXnvNJEFcIxRAkZPVPJH_Internal_Virtual_Boolean_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_aalhwRqcbQhzQHPqjxaJDiTxaYyw_Internal_Virtual_Boolean_GameObject_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_oCddbrAzLSgARApvwyLBgfvztGoB_Private_Void_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_ScfGINmFMxfNAJVmpKaJsxmTkXqf_Private_Boolean_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_nRvokDeWGGctkRtLitHwbAHZIso_Private_Void_TouchRegion_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_fOwxbxkERGiUgPApbIWvgPmZPSO_Private_Void_TouchRegion_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_EqPWznbcqXfSbBqHkAxpEdqMLyWN_Private_Void_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_lYFqcNqPVQUWLQzfHypznAkffnR_Private_Void_Vector2_Boolean_Single_TBzQBkblStsOsblRBDCFXBbSxxj_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_bndCRqovhXNzogiaEgObWGJQjPoa_Private_Void_Vector2_PositionType_Boolean_Single_TBzQBkblStsOsblRBDCFXBbSxxj_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_vkcfalFMzcgemqDQsIhfobMLjflg_Private_IEnumerator_Vector2_PositionType_Single_TBzQBkblStsOsblRBDCFXBbSxxj_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_DsphDRCaOcDcijQVdImpyNcwmHe_Private_Void_TBzQBkblStsOsblRBDCFXBbSxxj_Vector2_PositionType_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_XLLNWtCwXRBqlTJzCfKrbpeyhQGq_Private_Void_TBzQBkblStsOsblRBDCFXBbSxxj_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_SIuBcTqDlIpUZIPLQnVORwJXTBJ_Private_Void_TBzQBkblStsOsblRBDCFXBbSxxj_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_nUDeYYbgQCDNaKgGyfLeqdHdeMxP_Private_Void_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_UIxnocxzYFfsRxEkPqhqIOluQjN_Private_Void_Int32_Vector2_PositionType_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_baEViyRRodmuwhaehpMDycKSVwN_Private_Void_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_sKvlCBBoCdqafdbFOCOXCCiLfAtf_Private_Void_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_CmYuplbDIcChxFOHikcWHATbXszo_Private_Void_byref_Vector2_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_JAmblvHRjTbFRpLqVhkTwYaNJHM_Private_Boolean_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_tvfieGHVIvJAwOWABvkfZuaYRdg_Private_Void_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_EzuEKEcRDHQOUwaaCWnntUCHasKc_Private_Boolean_Int32_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_sPcvSSlGvTmwkQDQWFTYqTVIcix_Private_PointerEventData_Int32_GameObject_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_ldCMCnBLZMpzPoNHaCLvDGIJuib_Private_PointerEventData_Int32_GameObject_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_fygGGlEnKmuTNSTfXSwkyGEfsJS_Private_PointerEventData_Int32_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_BtCjHnVCQQZOUErBybAPpoLjeBj_Private_Void_PointerEventData_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_WzWwrwELvSDuhpDoqcIgfbMVGMdL_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_RTRyejIHkYVUBLhWNMKKFAUfreV_Private_PointerEventData_Int32_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_WbqbDgpASywaXyCuvhWbQHZDLXX_Private_Void_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_UnMFjSCmAMGvytjoLOAahnsmUzmO_Private_Void_AxisDirection_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_kigeNwWVsYERXqwjreancGuqqDE_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_NJoaOsRdPOKjssNjRbxAqdXWPan_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_ZAVdRrdxNFckOYQCbBCUgAfIgTyA_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_lfnXGCYWqVSkgcSxlPOzgNuXEtM_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_kgVYgXAlMRDWNZvFCINUFIWbVvyd_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_ZkqEhgxutIjvahTgqpNGorntvFG_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_DpmJfqxVNUXRYgbJEmVzxYQLfQa_Private_Void_PointerEventData_MTRzojhzRVbYXLAiscAviPdkJjKD_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_DDUCAWJSvpGMNhYKUcwQBJMrScy_Private_Void_Int32_Vector2_MTRzojhzRVbYXLAiscAviPdkJjKD_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_YItZvqPcQhbqZIBTSJcwAqrHqkd_Private_Void_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_dUHXYlsiNyoGytvpHasBSXDaouo_Private_Void_PointerEventData_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_MqVGxwdIhdkYxCeELtBHDUDBqHw_Private_Void_PointerEventData_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_SrFgwGeyWNweDotJFrWgeGBpDYGh_Private_Void_PointerEventData_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_RQQGpvvccMPqUmqcSAznEENoAPi_Private_Void_PointerEventData_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_MhWtGoImpcCOOANfVJznkGymNKl_Private_Void_PointerEventData_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_cieygjKKzrfvyZdDvYvTISikRqu_Private_Void_PointerEventData_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_beilSajMDkrKawlQpvkTHNINiuB_Private_Void_PointerEventData_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_iKvhyyDmHyilyjqsJZrcpJwxVPj_Private_Void_Vector2_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_get_valueChangedHandlerDelegate_Internal_Static_get_EventFunction_2_IValueChangedHandler_Vector2_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_get_stickPositionChangedHandlerDelegate_Internal_Static_get_EventFunction_2_IStickPositionChangedHandler_Vector2_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_IqhBUZQPyWVEOCBqQaLEKqvWeNC_Private_Static_Void_IValueChangedHandler_Vector2_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_FRUxNHPgzSXwlKeacyAfWmEAEWb_Private_Static_Void_IStickPositionChangedHandler_Vector2_0;

		// Token: 0x02000249 RID: 585
		[OriginalName("Rewired_Core.dll", "", "AxisDirection")]
		public enum AxisDirection
		{
			// Token: 0x04002FF9 RID: 12281
			Both,
			// Token: 0x04002FFA RID: 12282
			Horizontal,
			// Token: 0x04002FFB RID: 12283
			Vertical
		}

		// Token: 0x0200024A RID: 586
		[OriginalName("Rewired_Core.dll", "", "JoystickMode")]
		public enum JoystickMode
		{
			// Token: 0x04002FFD RID: 12285
			Analog,
			// Token: 0x04002FFE RID: 12286
			Digital
		}

		// Token: 0x0200024B RID: 587
		[OriginalName("Rewired_Core.dll", "", "SnapDirections")]
		public enum SnapDirections
		{
			// Token: 0x04003000 RID: 12288
			None,
			// Token: 0x04003001 RID: 12289
			Four = 4,
			// Token: 0x04003002 RID: 12290
			Eight = 8,
			// Token: 0x04003003 RID: 12291
			Sixteen = 16,
			// Token: 0x04003004 RID: 12292
			ThirtyTwo = 32,
			// Token: 0x04003005 RID: 12293
			SixtyFour = 64
		}

		// Token: 0x0200024C RID: 588
		[OriginalName("Rewired_Core.dll", "", "TBzQBkblStsOsblRBDCFXBbSxxj")]
		public enum TBzQBkblStsOsblRBDCFXBbSxxj
		{
			// Token: 0x04003007 RID: 12295
			urhBwQidoSAKHIhcxeCWNbALMhkh,
			// Token: 0x04003008 RID: 12296
			PEyGteqOvFiHPmYheQXLlIMfseW,
			// Token: 0x04003009 RID: 12297
			qGdyXsFZTOfhwXwKVygNOQkalAU
		}

		// Token: 0x0200024D RID: 589
		[OriginalName("Rewired_Core.dll", "", "MTRzojhzRVbYXLAiscAviPdkJjKD")]
		public enum MTRzojhzRVbYXLAiscAviPdkJjKD
		{
			// Token: 0x0400300B RID: 12299
			pbEwUmgtedTWksLWRJLxjjXcbkR,
			// Token: 0x0400300C RID: 12300
			FPYWBLDnTCVJfwQHOpuFKFuUbtA
		}

		// Token: 0x0200024E RID: 590
		[OriginalName("Rewired_Core.dll", "", "StickBounds")]
		public enum StickBounds
		{
			// Token: 0x0400300E RID: 12302
			Circle,
			// Token: 0x0400300F RID: 12303
			Square
		}

		// Token: 0x0200024F RID: 591
		[Serializable]
		public class ValueChangedEventHandler : UnityEvent<Vector2>
		{
			// Token: 0x060038D9 RID: 14553 RVA: 0x00013BCC File Offset: 0x00011DCC
			// Note: this type is marked as 'beforefieldinit'.
			static ValueChangedEventHandler()
			{
				Il2CppClassPointerStore<TouchJoystick.ValueChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "ValueChangedEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystick.ValueChangedEventHandler>.NativeClassPtr);
				TouchJoystick.ValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.ValueChangedEventHandler>.NativeClassPtr, 100664573);
			}

			// Token: 0x060038DA RID: 14554 RVA: 0x001160B4 File Offset: 0x001142B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247422, XrefRangeEnd = 247424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueChangedEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystick.ValueChangedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.ValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038DB RID: 14555 RVA: 0x00013C00 File Offset: 0x00011E00
			public ValueChangedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003010 RID: 12304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000250 RID: 592
		[Serializable]
		public class StickPositionChangedEventHandler : UnityEvent<Vector2>
		{
			// Token: 0x060038DC RID: 14556 RVA: 0x00013C09 File Offset: 0x00011E09
			// Note: this type is marked as 'beforefieldinit'.
			static StickPositionChangedEventHandler()
			{
				Il2CppClassPointerStore<TouchJoystick.StickPositionChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "StickPositionChangedEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystick.StickPositionChangedEventHandler>.NativeClassPtr);
				TouchJoystick.StickPositionChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.StickPositionChangedEventHandler>.NativeClassPtr, 100664574);
			}

			// Token: 0x060038DD RID: 14557 RVA: 0x001160F0 File Offset: 0x001142F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247424, XrefRangeEnd = 247426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StickPositionChangedEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystick.StickPositionChangedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.StickPositionChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038DE RID: 14558 RVA: 0x00013C3D File Offset: 0x00011E3D
			public StickPositionChangedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003011 RID: 12305
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000251 RID: 593
		[Serializable]
		public class TapEventHandler : UnityEvent
		{
			// Token: 0x060038DF RID: 14559 RVA: 0x00013C46 File Offset: 0x00011E46
			// Note: this type is marked as 'beforefieldinit'.
			static TapEventHandler()
			{
				Il2CppClassPointerStore<TouchJoystick.TapEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "TapEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystick.TapEventHandler>.NativeClassPtr);
				TouchJoystick.TapEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.TapEventHandler>.NativeClassPtr, 100664575);
			}

			// Token: 0x060038E0 RID: 14560 RVA: 0x0011612C File Offset: 0x0011432C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247426, XrefRangeEnd = 247427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TapEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystick.TapEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.TapEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038E1 RID: 14561 RVA: 0x00013C7A File Offset: 0x00011E7A
			public TapEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003012 RID: 12306
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000252 RID: 594
		[Serializable]
		public class TouchStartedEventHandler : UnityEvent
		{
			// Token: 0x060038E2 RID: 14562 RVA: 0x00013C83 File Offset: 0x00011E83
			// Note: this type is marked as 'beforefieldinit'.
			static TouchStartedEventHandler()
			{
				Il2CppClassPointerStore<TouchJoystick.TouchStartedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "TouchStartedEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystick.TouchStartedEventHandler>.NativeClassPtr);
				TouchJoystick.TouchStartedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.TouchStartedEventHandler>.NativeClassPtr, 100664576);
			}

			// Token: 0x060038E3 RID: 14563 RVA: 0x00116168 File Offset: 0x00114368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TouchStartedEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystick.TouchStartedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.TouchStartedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038E4 RID: 14564 RVA: 0x00013CB7 File Offset: 0x00011EB7
			public TouchStartedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003013 RID: 12307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000253 RID: 595
		[Serializable]
		public class TouchEndedEventHandler : UnityEvent
		{
			// Token: 0x060038E5 RID: 14565 RVA: 0x00013CC0 File Offset: 0x00011EC0
			// Note: this type is marked as 'beforefieldinit'.
			static TouchEndedEventHandler()
			{
				Il2CppClassPointerStore<TouchJoystick.TouchEndedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "TouchEndedEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystick.TouchEndedEventHandler>.NativeClassPtr);
				TouchJoystick.TouchEndedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.TouchEndedEventHandler>.NativeClassPtr, 100664577);
			}

			// Token: 0x060038E6 RID: 14566 RVA: 0x001161A4 File Offset: 0x001143A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TouchEndedEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystick.TouchEndedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.TouchEndedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038E7 RID: 14567 RVA: 0x00013CF4 File Offset: 0x00011EF4
			public TouchEndedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003014 RID: 12308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000254 RID: 596
		public class IValueChangedHandler : Il2CppObjectBase
		{
			// Token: 0x060038E8 RID: 14568 RVA: 0x00013CFD File Offset: 0x00011EFD
			// Note: this type is marked as 'beforefieldinit'.
			static IValueChangedHandler()
			{
				Il2CppClassPointerStore<TouchJoystick.IValueChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "IValueChangedHandler");
				TouchJoystick.IValueChangedHandler.NativeMethodInfoPtr_OnValueChanged_Public_Abstract_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.IValueChangedHandler>.NativeClassPtr, 100664578);
			}

			// Token: 0x060038E9 RID: 14569 RVA: 0x001161E0 File Offset: 0x001143E0
			[CallerCount(0)]
			public unsafe virtual void OnValueChanged(Vector2 value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchJoystick.IValueChangedHandler.NativeMethodInfoPtr_OnValueChanged_Public_Abstract_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038EA RID: 14570 RVA: 0x00013D27 File Offset: 0x00011F27
			public IValueChangedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003015 RID: 12309
			private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Public_Abstract_Virtual_New_Void_Vector2_0;
		}

		// Token: 0x02000255 RID: 597
		public class IStickPositionChangedHandler : Il2CppObjectBase
		{
			// Token: 0x060038EB RID: 14571 RVA: 0x00013D30 File Offset: 0x00011F30
			// Note: this type is marked as 'beforefieldinit'.
			static IStickPositionChangedHandler()
			{
				Il2CppClassPointerStore<TouchJoystick.IStickPositionChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "IStickPositionChangedHandler");
				TouchJoystick.IStickPositionChangedHandler.NativeMethodInfoPtr_OnStickPositionChanged_Public_Abstract_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.IStickPositionChangedHandler>.NativeClassPtr, 100664579);
			}

			// Token: 0x060038EC RID: 14572 RVA: 0x0011622C File Offset: 0x0011442C
			[CallerCount(0)]
			public unsafe virtual void OnStickPositionChanged(Vector2 value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchJoystick.IStickPositionChangedHandler.NativeMethodInfoPtr_OnStickPositionChanged_Public_Abstract_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038ED RID: 14573 RVA: 0x00013D5A File Offset: 0x00011F5A
			public IStickPositionChangedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003016 RID: 12310
			private static readonly IntPtr NativeMethodInfoPtr_OnStickPositionChanged_Public_Abstract_Virtual_New_Void_Vector2_0;
		}

		// Token: 0x02000256 RID: 598
		public sealed class xADJfeIeZIUeidkVlcvSGubXsIV : global::Il2CppSystem.Object
		{
			// Token: 0x060038EE RID: 14574 RVA: 0x00116278 File Offset: 0x00114478
			// Note: this type is marked as 'beforefieldinit'.
			static xADJfeIeZIUeidkVlcvSGubXsIV()
			{
				Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchJoystick>.NativeClassPtr, "xADJfeIeZIUeidkVlcvSGubXsIV");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr);
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_HqNOVSqyZgsPCXRbncuLhQsCKCrG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "HqNOVSqyZgsPCXRbncuLhQsCKCrG");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_BqySXaTZmKleAPNHvEeZQpiiNfv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "BqySXaTZmKleAPNHvEeZQpiiNfv");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_CUfEqFiNWSnIAsqKObGFeXEtaaKb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "CUfEqFiNWSnIAsqKObGFeXEtaaKb");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_eifgwUgHdNifEghyFaAHsBocReC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "eifgwUgHdNifEghyFaAHsBocReC");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_jQOIogGVggWvWdKdeGgPHmdAhaNc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "jQOIogGVggWvWdKdeGgPHmdAhaNc");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_PMdyLMQbcrxAFCdHXjgMfwKeZjw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "PMdyLMQbcrxAFCdHXjgMfwKeZjw");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_rgnOCsUqMqCszdXcYdVYGHaHnTOI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "rgnOCsUqMqCszdXcYdVYGHaHnTOI");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_SUDgfSDvhvERSRXUqCyMmxtQzxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "SUDgfSDvhvERSRXUqCyMmxtQzxy");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_kBHjstpAHTAXolcOYDBQzgtfyR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, "kBHjstpAHTAXolcOYDBQzgtfyR");
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, 100664580);
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, 100664581);
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, 100664582);
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, 100664583);
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, 100664584);
				TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr, 100664585);
			}

			// Token: 0x060038EF RID: 14575 RVA: 0x0011640C File Offset: 0x0011460C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247427, XrefRangeEnd = 247428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001104 RID: 4356
			// (get) Token: 0x060038F0 RID: 14576 RVA: 0x00116448 File Offset: 0x00114648
			public unsafe global::Il2CppSystem.Object lGWADsAPVgBuVCpEAGGxMFmASVGL
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060038F1 RID: 14577 RVA: 0x00116488 File Offset: 0x00114688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247428, XrefRangeEnd = 247433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038F2 RID: 14578 RVA: 0x001164BC File Offset: 0x001146BC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001105 RID: 4357
			// (get) Token: 0x060038F3 RID: 14579 RVA: 0x001164F0 File Offset: 0x001146F0
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060038F4 RID: 14580 RVA: 0x00116530 File Offset: 0x00114730
			[CallerCount(0)]
			public unsafe xADJfeIeZIUeidkVlcvSGubXsIV(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038F5 RID: 14581 RVA: 0x00013D63 File Offset: 0x00011F63
			public xADJfeIeZIUeidkVlcvSGubXsIV(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010F8 RID: 4344
			// (get) Token: 0x060038F6 RID: 14582 RVA: 0x00116578 File Offset: 0x00114778
			// (set) Token: 0x060038F7 RID: 14583 RVA: 0x00013D6C File Offset: 0x00011F6C
			public unsafe global::Il2CppSystem.Object NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F9 RID: 4345
			// (get) Token: 0x060038F8 RID: 14584 RVA: 0x001165A8 File Offset: 0x001147A8
			// (set) Token: 0x060038F9 RID: 14585 RVA: 0x00013D8B File Offset: 0x00011F8B
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170010FA RID: 4346
			// (get) Token: 0x060038FA RID: 14586 RVA: 0x001165D0 File Offset: 0x001147D0
			// (set) Token: 0x060038FB RID: 14587 RVA: 0x00013DA6 File Offset: 0x00011FA6
			public unsafe TouchJoystick HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchJoystick>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010FB RID: 4347
			// (get) Token: 0x060038FC RID: 14588 RVA: 0x00116600 File Offset: 0x00114800
			// (set) Token: 0x060038FD RID: 14589 RVA: 0x00013DC5 File Offset: 0x00011FC5
			public unsafe Vector2 HqNOVSqyZgsPCXRbncuLhQsCKCrG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_HqNOVSqyZgsPCXRbncuLhQsCKCrG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_HqNOVSqyZgsPCXRbncuLhQsCKCrG)) = value;
				}
			}

			// Token: 0x170010FC RID: 4348
			// (get) Token: 0x060038FE RID: 14590 RVA: 0x00116628 File Offset: 0x00114828
			// (set) Token: 0x060038FF RID: 14591 RVA: 0x00013DE0 File Offset: 0x00011FE0
			public unsafe PositionType BqySXaTZmKleAPNHvEeZQpiiNfv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_BqySXaTZmKleAPNHvEeZQpiiNfv);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_BqySXaTZmKleAPNHvEeZQpiiNfv)) = value;
				}
			}

			// Token: 0x170010FD RID: 4349
			// (get) Token: 0x06003900 RID: 14592 RVA: 0x00116650 File Offset: 0x00114850
			// (set) Token: 0x06003901 RID: 14593 RVA: 0x00013DFB File Offset: 0x00011FFB
			public unsafe float CUfEqFiNWSnIAsqKObGFeXEtaaKb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_CUfEqFiNWSnIAsqKObGFeXEtaaKb);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_CUfEqFiNWSnIAsqKObGFeXEtaaKb)) = value;
				}
			}

			// Token: 0x170010FE RID: 4350
			// (get) Token: 0x06003902 RID: 14594 RVA: 0x00116678 File Offset: 0x00114878
			// (set) Token: 0x06003903 RID: 14595 RVA: 0x00013E16 File Offset: 0x00012016
			public unsafe TouchJoystick.TBzQBkblStsOsblRBDCFXBbSxxj eifgwUgHdNifEghyFaAHsBocReC
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_eifgwUgHdNifEghyFaAHsBocReC);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_eifgwUgHdNifEghyFaAHsBocReC)) = value;
				}
			}

			// Token: 0x170010FF RID: 4351
			// (get) Token: 0x06003904 RID: 14596 RVA: 0x001166A0 File Offset: 0x001148A0
			// (set) Token: 0x06003905 RID: 14597 RVA: 0x00013E31 File Offset: 0x00012031
			public unsafe RectTransform jQOIogGVggWvWdKdeGgPHmdAhaNc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_jQOIogGVggWvWdKdeGgPHmdAhaNc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_jQOIogGVggWvWdKdeGgPHmdAhaNc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001100 RID: 4352
			// (get) Token: 0x06003906 RID: 14598 RVA: 0x001166D0 File Offset: 0x001148D0
			// (set) Token: 0x06003907 RID: 14599 RVA: 0x00013E50 File Offset: 0x00012050
			public unsafe Vector2 PMdyLMQbcrxAFCdHXjgMfwKeZjw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_PMdyLMQbcrxAFCdHXjgMfwKeZjw);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_PMdyLMQbcrxAFCdHXjgMfwKeZjw)) = value;
				}
			}

			// Token: 0x17001101 RID: 4353
			// (get) Token: 0x06003908 RID: 14600 RVA: 0x001166F8 File Offset: 0x001148F8
			// (set) Token: 0x06003909 RID: 14601 RVA: 0x00013E6B File Offset: 0x0001206B
			public unsafe float rgnOCsUqMqCszdXcYdVYGHaHnTOI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_rgnOCsUqMqCszdXcYdVYGHaHnTOI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_rgnOCsUqMqCszdXcYdVYGHaHnTOI)) = value;
				}
			}

			// Token: 0x17001102 RID: 4354
			// (get) Token: 0x0600390A RID: 14602 RVA: 0x00116720 File Offset: 0x00114920
			// (set) Token: 0x0600390B RID: 14603 RVA: 0x00013E86 File Offset: 0x00012086
			public unsafe float SUDgfSDvhvERSRXUqCyMmxtQzxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_SUDgfSDvhvERSRXUqCyMmxtQzxy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_SUDgfSDvhvERSRXUqCyMmxtQzxy)) = value;
				}
			}

			// Token: 0x17001103 RID: 4355
			// (get) Token: 0x0600390C RID: 14604 RVA: 0x00116748 File Offset: 0x00114948
			// (set) Token: 0x0600390D RID: 14605 RVA: 0x00013EA1 File Offset: 0x000120A1
			public unsafe float kBHjstpAHTAXolcOYDBQzgtfyR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_kBHjstpAHTAXolcOYDBQzgtfyR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystick.xADJfeIeZIUeidkVlcvSGubXsIV.NativeFieldInfoPtr_kBHjstpAHTAXolcOYDBQzgtfyR)) = value;
				}
			}

			// Token: 0x04003017 RID: 12311
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003018 RID: 12312
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003019 RID: 12313
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x0400301A RID: 12314
			private static readonly IntPtr NativeFieldInfoPtr_HqNOVSqyZgsPCXRbncuLhQsCKCrG;

			// Token: 0x0400301B RID: 12315
			private static readonly IntPtr NativeFieldInfoPtr_BqySXaTZmKleAPNHvEeZQpiiNfv;

			// Token: 0x0400301C RID: 12316
			private static readonly IntPtr NativeFieldInfoPtr_CUfEqFiNWSnIAsqKObGFeXEtaaKb;

			// Token: 0x0400301D RID: 12317
			private static readonly IntPtr NativeFieldInfoPtr_eifgwUgHdNifEghyFaAHsBocReC;

			// Token: 0x0400301E RID: 12318
			private static readonly IntPtr NativeFieldInfoPtr_jQOIogGVggWvWdKdeGgPHmdAhaNc;

			// Token: 0x0400301F RID: 12319
			private static readonly IntPtr NativeFieldInfoPtr_PMdyLMQbcrxAFCdHXjgMfwKeZjw;

			// Token: 0x04003020 RID: 12320
			private static readonly IntPtr NativeFieldInfoPtr_rgnOCsUqMqCszdXcYdVYGHaHnTOI;

			// Token: 0x04003021 RID: 12321
			private static readonly IntPtr NativeFieldInfoPtr_SUDgfSDvhvERSRXUqCyMmxtQzxy;

			// Token: 0x04003022 RID: 12322
			private static readonly IntPtr NativeFieldInfoPtr_kBHjstpAHTAXolcOYDBQzgtfyR;

			// Token: 0x04003023 RID: 12323
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003024 RID: 12324
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003025 RID: 12325
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003026 RID: 12326
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003027 RID: 12327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003028 RID: 12328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
