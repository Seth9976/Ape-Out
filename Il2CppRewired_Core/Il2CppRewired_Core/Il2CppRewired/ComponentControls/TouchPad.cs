using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.ComponentControls.Data;
using Il2CppRewired.Internal;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x02000050 RID: 80
	[Serializable]
	public sealed class TouchPad : TouchInteractable
	{
		// Token: 0x0600091C RID: 2332 RVA: 0x00050898 File Offset: 0x0004EA98
		// Note: this type is marked as 'beforefieldinit'.
		static TouchPad()
		{
			Il2CppClassPointerStore<TouchPad>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "TouchPad");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchPad>.NativeClassPtr);
			TouchPad.NativeFieldInfoPtr_SMOOTH_DELTA_FRAME_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "SMOOTH_DELTA_FRAME_COUNT");
			TouchPad.NativeFieldInfoPtr__horizontalAxisCustomControllerElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_horizontalAxisCustomControllerElement");
			TouchPad.NativeFieldInfoPtr__verticalAxisCustomControllerElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_verticalAxisCustomControllerElement");
			TouchPad.NativeFieldInfoPtr__tapCustomControllerElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_tapCustomControllerElement");
			TouchPad.NativeFieldInfoPtr__pressCustomControllerElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_pressCustomControllerElement");
			TouchPad.NativeFieldInfoPtr__axesToUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_axesToUse");
			TouchPad.NativeFieldInfoPtr__touchPadMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_touchPadMode");
			TouchPad.NativeFieldInfoPtr__valueFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_valueFormat");
			TouchPad.NativeFieldInfoPtr__useInertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_useInertia");
			TouchPad.NativeFieldInfoPtr__inertiaFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_inertiaFriction");
			TouchPad.NativeFieldInfoPtr__activateOnSwipeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_activateOnSwipeIn");
			TouchPad.NativeFieldInfoPtr__stayActiveOnSwipeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_stayActiveOnSwipeOut");
			TouchPad.NativeFieldInfoPtr__allowTap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_allowTap");
			TouchPad.NativeFieldInfoPtr__tapTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_tapTimeout");
			TouchPad.NativeFieldInfoPtr__tapDistanceLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_tapDistanceLimit");
			TouchPad.NativeFieldInfoPtr__allowPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_allowPress");
			TouchPad.NativeFieldInfoPtr__pressStartDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_pressStartDelay");
			TouchPad.NativeFieldInfoPtr__pressDistanceLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_pressDistanceLimit");
			TouchPad.NativeFieldInfoPtr__hideAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_hideAtRuntime");
			TouchPad.NativeFieldInfoPtr__axis2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_axis2D");
			TouchPad.NativeFieldInfoPtr__onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_onValueChanged");
			TouchPad.NativeFieldInfoPtr__onTap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_onTap");
			TouchPad.NativeFieldInfoPtr__onPressDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_onPressDown");
			TouchPad.NativeFieldInfoPtr__onPressUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_onPressUp");
			TouchPad.NativeFieldInfoPtr__useXAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_useXAxis");
			TouchPad.NativeFieldInfoPtr__useYAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_useYAxis");
			TouchPad.NativeFieldInfoPtr__pointerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_pointerId");
			TouchPad.NativeFieldInfoPtr__realMousePointerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_realMousePointerId");
			TouchPad.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "AJKoOMhkVHACBErfSbaQmDfyxZV");
			TouchPad.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "xISHKSqmxBFBXboSBVekNAulortJ");
			TouchPad.NativeFieldInfoPtr__pointerDownIsFake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_pointerDownIsFake");
			TouchPad.NativeFieldInfoPtr__touchStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_touchStartPosition");
			TouchPad.NativeFieldInfoPtr__touchStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_touchStartTime");
			TouchPad.NativeFieldInfoPtr__currentCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_currentCenter");
			TouchPad.NativeFieldInfoPtr__previousTouchPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_previousTouchPosition");
			TouchPad.NativeFieldInfoPtr__lastTapFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_lastTapFrame");
			TouchPad.NativeFieldInfoPtr__isEligibleForTap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_isEligibleForTap");
			TouchPad.NativeFieldInfoPtr__isEligibleForPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_isEligibleForPress");
			TouchPad.NativeFieldInfoPtr__pressValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_pressValue");
			TouchPad.NativeFieldInfoPtr__smoothDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "_smoothDelta");
			TouchPad.NativeFieldInfoPtr___fakePointerEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "__fakePointerEventData");
			TouchPad.NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_UnityAction_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664788);
			TouchPad.NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_UnityAction_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664789);
			TouchPad.NativeMethodInfoPtr_add_TapEvent_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664790);
			TouchPad.NativeMethodInfoPtr_remove_TapEvent_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664791);
			TouchPad.NativeMethodInfoPtr_add_PressDownEvent_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664792);
			TouchPad.NativeMethodInfoPtr_remove_PressDownEvent_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664793);
			TouchPad.NativeMethodInfoPtr_add_PressUpEvent_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664794);
			TouchPad.NativeMethodInfoPtr_remove_PressUpEvent_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664795);
			TouchPad.NativeMethodInfoPtr_get_horizontalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664796);
			TouchPad.NativeMethodInfoPtr_get_verticalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664797);
			TouchPad.NativeMethodInfoPtr_get_tapCustomControllerElement_Public_get_CustomControllerElementTargetSetForBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664798);
			TouchPad.NativeMethodInfoPtr_get_pressCustomControllerElement_Public_get_CustomControllerElementTargetSetForBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664799);
			TouchPad.NativeMethodInfoPtr_get_axesToUse_Public_get_AxisDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664800);
			TouchPad.NativeMethodInfoPtr_set_axesToUse_Public_set_Void_AxisDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664801);
			TouchPad.NativeMethodInfoPtr_get_touchPadMode_Public_get_TouchPadMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664802);
			TouchPad.NativeMethodInfoPtr_set_touchPadMode_Public_set_Void_TouchPadMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664803);
			TouchPad.NativeMethodInfoPtr_get_valueFormat_Public_get_ValueFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664804);
			TouchPad.NativeMethodInfoPtr_set_valueFormat_Public_set_Void_ValueFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664805);
			TouchPad.NativeMethodInfoPtr_get_useInertia_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664806);
			TouchPad.NativeMethodInfoPtr_set_useInertia_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664807);
			TouchPad.NativeMethodInfoPtr_get_inertiaFriction_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664808);
			TouchPad.NativeMethodInfoPtr_set_inertiaFriction_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664809);
			TouchPad.NativeMethodInfoPtr_get_activateOnSwipeIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664810);
			TouchPad.NativeMethodInfoPtr_set_activateOnSwipeIn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664811);
			TouchPad.NativeMethodInfoPtr_get_stayActiveOnSwipeOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664812);
			TouchPad.NativeMethodInfoPtr_set_stayActiveOnSwipeOut_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664813);
			TouchPad.NativeMethodInfoPtr_get_allowTap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664814);
			TouchPad.NativeMethodInfoPtr_set_allowTap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664815);
			TouchPad.NativeMethodInfoPtr_get_tapTimeout_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664816);
			TouchPad.NativeMethodInfoPtr_set_tapTimeout_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664817);
			TouchPad.NativeMethodInfoPtr_get_tapDistanceLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664818);
			TouchPad.NativeMethodInfoPtr_set_tapDistanceLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664819);
			TouchPad.NativeMethodInfoPtr_get_allowPress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664820);
			TouchPad.NativeMethodInfoPtr_set_allowPress_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664821);
			TouchPad.NativeMethodInfoPtr_get_pressStartDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664822);
			TouchPad.NativeMethodInfoPtr_set_pressStartDelay_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664823);
			TouchPad.NativeMethodInfoPtr_get_pressDistanceLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664824);
			TouchPad.NativeMethodInfoPtr_set_pressDistanceLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664825);
			TouchPad.NativeMethodInfoPtr_get_hideAtRuntime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664826);
			TouchPad.NativeMethodInfoPtr_set_hideAtRuntime_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664827);
			TouchPad.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664828);
			TouchPad.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664829);
			TouchPad.NativeMethodInfoPtr_get_hasPointer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664830);
			TouchPad.NativeMethodInfoPtr_get_touchStartPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664831);
			TouchPad.NativeMethodInfoPtr_get_touchPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664832);
			TouchPad.NativeMethodInfoPtr_get_horizontalAxisCalibration_Public_get_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664833);
			TouchPad.NativeMethodInfoPtr_get_verticalAxisCalibration_Public_get_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664834);
			TouchPad.NativeMethodInfoPtr_get_axis2DCalibration_Public_get_Axis2DCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664835);
			TouchPad.NativeMethodInfoPtr_get_axis2D_Internal_get_StandaloneAxis2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664836);
			TouchPad.NativeMethodInfoPtr_get_effectivePointerId_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664837);
			TouchPad.NativeMethodInfoPtr_get_tapValue_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664838);
			TouchPad.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664839);
			TouchPad.NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664840);
			TouchPad.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664841);
			TouchPad.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664842);
			TouchPad.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664843);
			TouchPad.NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664844);
			TouchPad.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664845);
			TouchPad.NativeMethodInfoPtr_xzNKXjAaJMKaZzoFxoimUjvQRfi_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664846);
			TouchPad.NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664847);
			TouchPad.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664848);
			TouchPad.NativeMethodInfoPtr_WbqbDgpASywaXyCuvhWbQHZDLXX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664849);
			TouchPad.NativeMethodInfoPtr_UnMFjSCmAMGvytjoLOAahnsmUzmO_Private_Void_AxisDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664850);
			TouchPad.NativeMethodInfoPtr_baEViyRRodmuwhaehpMDycKSVwN_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664851);
			TouchPad.NativeMethodInfoPtr_sOtcTwggZdaXnDhjizojZiZSeRrU_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664852);
			TouchPad.NativeMethodInfoPtr_xttgUBeWkaItOScFNdPnWUBHSCFl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664853);
			TouchPad.NativeMethodInfoPtr_sKvlCBBoCdqafdbFOCOXCCiLfAtf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664854);
			TouchPad.NativeMethodInfoPtr_CmYuplbDIcChxFOHikcWHATbXszo_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664855);
			TouchPad.NativeMethodInfoPtr_zVQaLNqAdJCYSaqXuEQcDCOaqtwp_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664856);
			TouchPad.NativeMethodInfoPtr_wtLqCzxxLqLosnJpkOyfcVrEacI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664857);
			TouchPad.NativeMethodInfoPtr_cczrmyMWIikgEqrQRTjbXHdxcGl_Private_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664858);
			TouchPad.NativeMethodInfoPtr_GLQdsqAjfycQMAswIfMMNuKtXzw_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664859);
			TouchPad.NativeMethodInfoPtr_kigeNwWVsYERXqwjreancGuqqDE_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664860);
			TouchPad.NativeMethodInfoPtr_NJoaOsRdPOKjssNjRbxAqdXWPan_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664861);
			TouchPad.NativeMethodInfoPtr_ZAVdRrdxNFckOYQCbBCUgAfIgTyA_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664862);
			TouchPad.NativeMethodInfoPtr_lfnXGCYWqVSkgcSxlPOzgNuXEtM_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664863);
			TouchPad.NativeMethodInfoPtr_DDUCAWJSvpGMNhYKUcwQBJMrScy_Private_Void_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664864);
			TouchPad.NativeMethodInfoPtr_YItZvqPcQhbqZIBTSJcwAqrHqkd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664865);
			TouchPad.NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664866);
			TouchPad.NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664867);
			TouchPad.NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664868);
			TouchPad.NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664869);
			TouchPad.NativeMethodInfoPtr_tvfieGHVIvJAwOWABvkfZuaYRdg_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664870);
			TouchPad.NativeMethodInfoPtr_EzuEKEcRDHQOUwaaCWnntUCHasKc_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664871);
			TouchPad.NativeMethodInfoPtr_sPcvSSlGvTmwkQDQWFTYqTVIcix_Private_PointerEventData_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664872);
			TouchPad.NativeMethodInfoPtr_ldCMCnBLZMpzPoNHaCLvDGIJuib_Private_PointerEventData_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664873);
			TouchPad.NativeMethodInfoPtr_fygGGlEnKmuTNSTfXSwkyGEfsJS_Private_PointerEventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664874);
			TouchPad.NativeMethodInfoPtr_BtCjHnVCQQZOUErBybAPpoLjeBj_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664875);
			TouchPad.NativeMethodInfoPtr_RTRyejIHkYVUBLhWNMKKFAUfreV_Private_PointerEventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, 100664876);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000512F0 File Offset: 0x0004F4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250037, XrefRangeEnd = 250042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValueChangedEvent(UnityAction<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_UnityAction_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00051334 File Offset: 0x0004F534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250042, XrefRangeEnd = 250045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValueChangedEvent(UnityAction<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_UnityAction_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00051378 File Offset: 0x0004F578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250045, XrefRangeEnd = 250047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TapEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_add_TapEvent_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000513BC File Offset: 0x0004F5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250047, XrefRangeEnd = 250049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TapEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_remove_TapEvent_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00051400 File Offset: 0x0004F600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250049, XrefRangeEnd = 250051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PressDownEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_add_PressDownEvent_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00051444 File Offset: 0x0004F644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250051, XrefRangeEnd = 250053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PressDownEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_remove_PressDownEvent_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00051488 File Offset: 0x0004F688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250053, XrefRangeEnd = 250055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PressUpEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_add_PressUpEvent_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000514CC File Offset: 0x0004F6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250055, XrefRangeEnd = 250057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PressUpEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_remove_PressUpEvent_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00051510 File Offset: 0x0004F710
		public unsafe CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_horizontalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr3) : null;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00051550 File Offset: 0x0004F750
		public unsafe CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_verticalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr3) : null;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00051590 File Offset: 0x0004F790
		public unsafe CustomControllerElementTargetSetForBoolean tapCustomControllerElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_tapCustomControllerElement_Public_get_CustomControllerElementTargetSetForBoolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForBoolean>(intPtr3) : null;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x000515D0 File Offset: 0x0004F7D0
		public unsafe CustomControllerElementTargetSetForBoolean pressCustomControllerElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_pressCustomControllerElement_Public_get_CustomControllerElementTargetSetForBoolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForBoolean>(intPtr3) : null;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00051610 File Offset: 0x0004F810
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0005164C File Offset: 0x0004F84C
		public unsafe TouchPad.AxisDirection axesToUse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_axesToUse_Public_get_AxisDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250057, XrefRangeEnd = 250058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_axesToUse_Public_set_Void_AxisDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0005168C File Offset: 0x0004F88C
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x000516C8 File Offset: 0x0004F8C8
		public unsafe TouchPad.TouchPadMode touchPadMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_touchPadMode_Public_get_TouchPadMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_touchPadMode_Public_set_Void_TouchPadMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00051708 File Offset: 0x0004F908
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00051744 File Offset: 0x0004F944
		public unsafe TouchPad.ValueFormat valueFormat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_valueFormat_Public_get_ValueFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_valueFormat_Public_set_Void_ValueFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00051784 File Offset: 0x0004F984
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x000517C0 File Offset: 0x0004F9C0
		public unsafe bool useInertia
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_useInertia_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_useInertia_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00051800 File Offset: 0x0004FA00
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x0005183C File Offset: 0x0004FA3C
		public unsafe float inertiaFriction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_inertiaFriction_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_inertiaFriction_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0005187C File Offset: 0x0004FA7C
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x000518B8 File Offset: 0x0004FAB8
		public unsafe bool activateOnSwipeIn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_activateOnSwipeIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_activateOnSwipeIn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x000518F8 File Offset: 0x0004FAF8
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x00051934 File Offset: 0x0004FB34
		public unsafe bool stayActiveOnSwipeOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_stayActiveOnSwipeOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_stayActiveOnSwipeOut_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00051974 File Offset: 0x0004FB74
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x000519B0 File Offset: 0x0004FBB0
		public unsafe bool allowTap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_allowTap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_allowTap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x000519F0 File Offset: 0x0004FBF0
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x00051A2C File Offset: 0x0004FC2C
		public unsafe float tapTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_tapTimeout_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_tapTimeout_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00051A6C File Offset: 0x0004FC6C
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x00051AA8 File Offset: 0x0004FCA8
		public unsafe int tapDistanceLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_tapDistanceLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_tapDistanceLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00051AE8 File Offset: 0x0004FCE8
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x00051B24 File Offset: 0x0004FD24
		public unsafe bool allowPress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_allowPress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_allowPress_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00051B64 File Offset: 0x0004FD64
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x00051BA0 File Offset: 0x0004FDA0
		public unsafe float pressStartDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_pressStartDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_pressStartDelay_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00051BE0 File Offset: 0x0004FDE0
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x00051C1C File Offset: 0x0004FE1C
		public unsafe int pressDistanceLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_pressDistanceLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_pressDistanceLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00051C5C File Offset: 0x0004FE5C
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x00051C98 File Offset: 0x0004FE98
		public unsafe bool hideAtRuntime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_hideAtRuntime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_hideAtRuntime_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00051CD8 File Offset: 0x0004FED8
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x00051D14 File Offset: 0x0004FF14
		public unsafe int pointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00051D54 File Offset: 0x0004FF54
		public unsafe bool hasPointer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_hasPointer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00051D90 File Offset: 0x0004FF90
		public unsafe Vector2 touchStartPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_touchStartPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00051DCC File Offset: 0x0004FFCC
		public unsafe Vector2 touchPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250058, XrefRangeEnd = 250067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_touchPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00051E08 File Offset: 0x00050008
		public unsafe AxisCalibration horizontalAxisCalibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_horizontalAxisCalibration_Public_get_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00051E48 File Offset: 0x00050048
		public unsafe AxisCalibration verticalAxisCalibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_verticalAxisCalibration_Public_get_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00051E88 File Offset: 0x00050088
		public unsafe Axis2DCalibration axis2DCalibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_axis2DCalibration_Public_get_Axis2DCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Axis2DCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00051EC8 File Offset: 0x000500C8
		public unsafe StandaloneAxis2D axis2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_axis2D_Internal_get_StandaloneAxis2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandaloneAxis2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x00051F08 File Offset: 0x00050108
		public unsafe int effectivePointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_effectivePointerId_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00051F44 File Offset: 0x00050144
		public unsafe bool tapValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250067, XrefRangeEnd = 250069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_get_tapValue_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00051F80 File Offset: 0x00050180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250069, XrefRangeEnd = 250125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchPad()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchPad>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00051FBC File Offset: 0x000501BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250125, XrefRangeEnd = 250129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00051FF0 File Offset: 0x000501F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250129, XrefRangeEnd = 250132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00052024 File Offset: 0x00050224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250132, XrefRangeEnd = 250135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool nSRkgireMOAkpBoLMmrDfIispUMG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00052060 File Offset: 0x00050260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250135, XrefRangeEnd = 250145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NFTSnGXuZXafcZHIgcYanOLckXY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00052094 File Offset: 0x00050294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250145, XrefRangeEnd = 250154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void zKEQtrzzyQhnNzFWJQGLGZUsGJG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000520C8 File Offset: 0x000502C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250154, XrefRangeEnd = 250159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x000520FC File Offset: 0x000502FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250159, XrefRangeEnd = 250164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void xzNKXjAaJMKaZzoFxoimUjvQRfi()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_xzNKXjAaJMKaZzoFxoimUjvQRfi_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00052130 File Offset: 0x00050330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250164, XrefRangeEnd = 250171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00052164 File Offset: 0x00050364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250172, RefRangeEnd = 250174, XrefRangeStart = 250171, XrefRangeEnd = 250172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void iJzeeVgTFhPQqdRTfUGBACRnMOF()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00052198 File Offset: 0x00050398
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250185, RefRangeEnd = 250188, XrefRangeStart = 250174, XrefRangeEnd = 250185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WbqbDgpASywaXyCuvhWbQHZDLXX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_WbqbDgpASywaXyCuvhWbQHZDLXX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x000521CC File Offset: 0x000503CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250193, RefRangeEnd = 250195, XrefRangeStart = 250188, XrefRangeEnd = 250193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnMFjSCmAMGvytjoLOAahnsmUzmO(TouchPad.AxisDirection A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_UnMFjSCmAMGvytjoLOAahnsmUzmO_Private_Void_AxisDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0005220C File Offset: 0x0005040C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250216, RefRangeEnd = 250217, XrefRangeStart = 250195, XrefRangeEnd = 250216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void baEViyRRodmuwhaehpMDycKSVwN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_baEViyRRodmuwhaehpMDycKSVwN_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00052240 File Offset: 0x00050440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250265, RefRangeEnd = 250266, XrefRangeStart = 250217, XrefRangeEnd = 250265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sOtcTwggZdaXnDhjizojZiZSeRrU()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_sOtcTwggZdaXnDhjizojZiZSeRrU_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00052274 File Offset: 0x00050474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250273, RefRangeEnd = 250274, XrefRangeStart = 250266, XrefRangeEnd = 250273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void xttgUBeWkaItOScFNdPnWUBHSCFl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_xttgUBeWkaItOScFNdPnWUBHSCFl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000522A8 File Offset: 0x000504A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250284, RefRangeEnd = 250285, XrefRangeStart = 250274, XrefRangeEnd = 250284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sKvlCBBoCdqafdbFOCOXCCiLfAtf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_sKvlCBBoCdqafdbFOCOXCCiLfAtf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x000522DC File Offset: 0x000504DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250285, XrefRangeEnd = 250287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmYuplbDIcChxFOHikcWHATbXszo(ref Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_CmYuplbDIcChxFOHikcWHATbXszo_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0005231C File Offset: 0x0005051C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250287, XrefRangeEnd = 250291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zVQaLNqAdJCYSaqXuEQcDCOaqtwp(ref Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_zVQaLNqAdJCYSaqXuEQcDCOaqtwp_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0005235C File Offset: 0x0005055C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250291, XrefRangeEnd = 250297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void wtLqCzxxLqLosnJpkOyfcVrEacI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_wtLqCzxxLqLosnJpkOyfcVrEacI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00052390 File Offset: 0x00050590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250297, XrefRangeEnd = 250298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 cczrmyMWIikgEqrQRTjbXHdxcGl(Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_cczrmyMWIikgEqrQRTjbXHdxcGl_Private_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000523DC File Offset: 0x000505DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250298, XrefRangeEnd = 250299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GLQdsqAjfycQMAswIfMMNuKtXzw(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_GLQdsqAjfycQMAswIfMMNuKtXzw_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0005241C File Offset: 0x0005061C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250307, RefRangeEnd = 250309, XrefRangeStart = 250299, XrefRangeEnd = 250307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void kigeNwWVsYERXqwjreancGuqqDE(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_kigeNwWVsYERXqwjreancGuqqDE_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00052460 File Offset: 0x00050660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250309, XrefRangeEnd = 250317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NJoaOsRdPOKjssNjRbxAqdXWPan(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_NJoaOsRdPOKjssNjRbxAqdXWPan_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000524A4 File Offset: 0x000506A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250345, RefRangeEnd = 250346, XrefRangeStart = 250317, XrefRangeEnd = 250345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZAVdRrdxNFckOYQCbBCUgAfIgTyA(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_ZAVdRrdxNFckOYQCbBCUgAfIgTyA_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000524E8 File Offset: 0x000506E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250346, XrefRangeEnd = 250354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void lfnXGCYWqVSkgcSxlPOzgNuXEtM(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_lfnXGCYWqVSkgcSxlPOzgNuXEtM_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0005252C File Offset: 0x0005072C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250354, XrefRangeEnd = 250356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DDUCAWJSvpGMNhYKUcwQBJMrScy(int A_1, Vector2 A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_DDUCAWJSvpGMNhYKUcwQBJMrScy_Private_Void_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00052578 File Offset: 0x00050778
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 250369, RefRangeEnd = 250373, XrefRangeStart = 250356, XrefRangeEnd = 250369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void YItZvqPcQhbqZIBTSJcwAqrHqkd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_YItZvqPcQhbqZIBTSJcwAqrHqkd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000525AC File Offset: 0x000507AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250373, XrefRangeEnd = 250385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000525F0 File Offset: 0x000507F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250385, XrefRangeEnd = 250390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00052634 File Offset: 0x00050834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250390, XrefRangeEnd = 250395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00052678 File Offset: 0x00050878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250395, XrefRangeEnd = 250405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000526BC File Offset: 0x000508BC
		[CallerCount(0)]
		public unsafe void tvfieGHVIvJAwOWABvkfZuaYRdg()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_tvfieGHVIvJAwOWABvkfZuaYRdg_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000526F0 File Offset: 0x000508F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 250408, RefRangeEnd = 250414, XrefRangeStart = 250405, XrefRangeEnd = 250408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EzuEKEcRDHQOUwaaCWnntUCHasKc(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_EzuEKEcRDHQOUwaaCWnntUCHasKc_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0005273C File Offset: 0x0005093C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250431, RefRangeEnd = 250432, XrefRangeStart = 250414, XrefRangeEnd = 250431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_sPcvSSlGvTmwkQDQWFTYqTVIcix_Private_PointerEventData_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0005279C File Offset: 0x0005099C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250432, XrefRangeEnd = 250438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_ldCMCnBLZMpzPoNHaCLvDGIJuib_Private_PointerEventData_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000527FC File Offset: 0x000509FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 250453, RefRangeEnd = 250457, XrefRangeStart = 250438, XrefRangeEnd = 250453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData fygGGlEnKmuTNSTfXSwkyGEfsJS(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_fygGGlEnKmuTNSTfXSwkyGEfsJS_Private_PointerEventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00052848 File Offset: 0x00050A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250457, XrefRangeEnd = 250459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BtCjHnVCQQZOUErBybAPpoLjeBj(PointerEventData A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_BtCjHnVCQQZOUErBybAPpoLjeBj_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0005288C File Offset: 0x00050A8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 250482, RefRangeEnd = 250486, XrefRangeStart = 250459, XrefRangeEnd = 250482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData RTRyejIHkYVUBLhWNMKKFAUfreV(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.NativeMethodInfoPtr_RTRyejIHkYVUBLhWNMKKFAUfreV_Private_PointerEventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00005090 File Offset: 0x00003290
		public TouchPad(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x000528D8 File Offset: 0x00050AD8
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00005099 File Offset: 0x00003299
		public unsafe static int SMOOTH_DELTA_FRAME_COUNT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TouchPad.NativeFieldInfoPtr_SMOOTH_DELTA_FRAME_COUNT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchPad.NativeFieldInfoPtr_SMOOTH_DELTA_FRAME_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x000528F4 File Offset: 0x00050AF4
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x000050A7 File Offset: 0x000032A7
		public unsafe CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__horizontalAxisCustomControllerElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__horizontalAxisCustomControllerElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00052924 File Offset: 0x00050B24
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x000050C6 File Offset: 0x000032C6
		public unsafe CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__verticalAxisCustomControllerElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__verticalAxisCustomControllerElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00052954 File Offset: 0x00050B54
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x000050E5 File Offset: 0x000032E5
		public unsafe CustomControllerElementTargetSetForBoolean _tapCustomControllerElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__tapCustomControllerElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForBoolean>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__tapCustomControllerElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x00052984 File Offset: 0x00050B84
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x00005104 File Offset: 0x00003304
		public unsafe CustomControllerElementTargetSetForBoolean _pressCustomControllerElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pressCustomControllerElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForBoolean>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pressCustomControllerElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x000529B4 File Offset: 0x00050BB4
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x00005123 File Offset: 0x00003323
		public unsafe TouchPad.AxisDirection _axesToUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__axesToUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__axesToUse)) = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x000529DC File Offset: 0x00050BDC
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x0000513E File Offset: 0x0000333E
		public unsafe TouchPad.TouchPadMode _touchPadMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__touchPadMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__touchPadMode)) = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x00052A04 File Offset: 0x00050C04
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x00005159 File Offset: 0x00003359
		public unsafe TouchPad.ValueFormat _valueFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__valueFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__valueFormat)) = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x00052A2C File Offset: 0x00050C2C
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x00005174 File Offset: 0x00003374
		public unsafe bool _useInertia
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__useInertia);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__useInertia)) = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x00052A54 File Offset: 0x00050C54
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x0000518F File Offset: 0x0000338F
		public unsafe float _inertiaFriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__inertiaFriction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__inertiaFriction)) = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x00052A7C File Offset: 0x00050C7C
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x000051AA File Offset: 0x000033AA
		public unsafe bool _activateOnSwipeIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__activateOnSwipeIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__activateOnSwipeIn)) = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x00052AA4 File Offset: 0x00050CA4
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x000051C5 File Offset: 0x000033C5
		public unsafe bool _stayActiveOnSwipeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__stayActiveOnSwipeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__stayActiveOnSwipeOut)) = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00052ACC File Offset: 0x00050CCC
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x000051E0 File Offset: 0x000033E0
		public unsafe bool _allowTap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__allowTap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__allowTap)) = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00052AF4 File Offset: 0x00050CF4
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x000051FB File Offset: 0x000033FB
		public unsafe float _tapTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__tapTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__tapTimeout)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00052B1C File Offset: 0x00050D1C
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x00005216 File Offset: 0x00003416
		public unsafe int _tapDistanceLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__tapDistanceLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__tapDistanceLimit)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x00052B44 File Offset: 0x00050D44
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x00005231 File Offset: 0x00003431
		public unsafe bool _allowPress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__allowPress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__allowPress)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x00052B6C File Offset: 0x00050D6C
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x0000524C File Offset: 0x0000344C
		public unsafe float _pressStartDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pressStartDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pressStartDelay)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00052B94 File Offset: 0x00050D94
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x00005267 File Offset: 0x00003467
		public unsafe int _pressDistanceLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pressDistanceLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pressDistanceLimit)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x00052BBC File Offset: 0x00050DBC
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x00005282 File Offset: 0x00003482
		public unsafe bool _hideAtRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__hideAtRuntime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__hideAtRuntime)) = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00052BE4 File Offset: 0x00050DE4
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x0000529D File Offset: 0x0000349D
		public unsafe StandaloneAxis2D _axis2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__axis2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__axis2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x00052C14 File Offset: 0x00050E14
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x000052BC File Offset: 0x000034BC
		public unsafe TouchPad.ValueChangedEventHandler _onValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__onValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchPad.ValueChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__onValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00052C44 File Offset: 0x00050E44
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x000052DB File Offset: 0x000034DB
		public unsafe TouchPad.TapEventHandler _onTap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__onTap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchPad.TapEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__onTap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00052C74 File Offset: 0x00050E74
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x000052FA File Offset: 0x000034FA
		public unsafe TouchPad.PressDownEventHandler _onPressDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__onPressDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchPad.PressDownEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__onPressDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00052CA4 File Offset: 0x00050EA4
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x00005319 File Offset: 0x00003519
		public unsafe TouchPad.PressUpEventHandler _onPressUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__onPressUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchPad.PressUpEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__onPressUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00052CD4 File Offset: 0x00050ED4
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x00005338 File Offset: 0x00003538
		public unsafe bool _useXAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__useXAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__useXAxis)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00052CFC File Offset: 0x00050EFC
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x00005353 File Offset: 0x00003553
		public unsafe bool _useYAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__useYAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__useYAxis)) = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00052D24 File Offset: 0x00050F24
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x0000536E File Offset: 0x0000356E
		public unsafe int _pointerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pointerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pointerId)) = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00052D4C File Offset: 0x00050F4C
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x00005389 File Offset: 0x00003589
		public unsafe int _realMousePointerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__realMousePointerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__realMousePointerId)) = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00052D74 File Offset: 0x00050F74
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x000053A4 File Offset: 0x000035A4
		public new unsafe bool AJKoOMhkVHACBErfSbaQmDfyxZV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV)) = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00052D9C File Offset: 0x00050F9C
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x000053BF File Offset: 0x000035BF
		public new unsafe bool xISHKSqmxBFBXboSBVekNAulortJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ)) = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00052DC4 File Offset: 0x00050FC4
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x000053DA File Offset: 0x000035DA
		public unsafe bool _pointerDownIsFake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pointerDownIsFake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pointerDownIsFake)) = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00052DEC File Offset: 0x00050FEC
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x000053F5 File Offset: 0x000035F5
		public unsafe Vector2 _touchStartPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__touchStartPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__touchStartPosition)) = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00052E14 File Offset: 0x00051014
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00005410 File Offset: 0x00003610
		public unsafe float _touchStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__touchStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__touchStartTime)) = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00052E3C File Offset: 0x0005103C
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x0000542B File Offset: 0x0000362B
		public unsafe Vector3 _currentCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__currentCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__currentCenter)) = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00052E64 File Offset: 0x00051064
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00005446 File Offset: 0x00003646
		public unsafe Vector2 _previousTouchPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__previousTouchPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__previousTouchPosition)) = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00052E8C File Offset: 0x0005108C
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x00005461 File Offset: 0x00003661
		public unsafe int _lastTapFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__lastTapFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__lastTapFrame)) = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00052EB4 File Offset: 0x000510B4
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x0000547C File Offset: 0x0000367C
		public unsafe bool _isEligibleForTap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__isEligibleForTap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__isEligibleForTap)) = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00052EDC File Offset: 0x000510DC
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x00005497 File Offset: 0x00003697
		public unsafe bool _isEligibleForPress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__isEligibleForPress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__isEligibleForPress)) = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00052F04 File Offset: 0x00051104
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x000054B2 File Offset: 0x000036B2
		public unsafe bool _pressValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pressValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__pressValue)) = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00052F2C File Offset: 0x0005112C
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000054CD File Offset: 0x000036CD
		public unsafe TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj _smoothDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__smoothDelta);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr__smoothDelta), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00052F5C File Offset: 0x0005115C
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x000054EC File Offset: 0x000036EC
		public unsafe Dictionary<int, PointerEventData> __fakePointerEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr___fakePointerEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PointerEventData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.NativeFieldInfoPtr___fakePointerEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeFieldInfoPtr_SMOOTH_DELTA_FRAME_COUNT;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeFieldInfoPtr__horizontalAxisCustomControllerElement;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeFieldInfoPtr__verticalAxisCustomControllerElement;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeFieldInfoPtr__tapCustomControllerElement;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeFieldInfoPtr__pressCustomControllerElement;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeFieldInfoPtr__axesToUse;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeFieldInfoPtr__touchPadMode;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeFieldInfoPtr__valueFormat;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeFieldInfoPtr__useInertia;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeFieldInfoPtr__inertiaFriction;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeFieldInfoPtr__activateOnSwipeIn;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeFieldInfoPtr__stayActiveOnSwipeOut;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr__allowTap;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr__tapTimeout;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeFieldInfoPtr__tapDistanceLimit;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeFieldInfoPtr__allowPress;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeFieldInfoPtr__pressStartDelay;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr__pressDistanceLimit;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr__hideAtRuntime;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeFieldInfoPtr__axis2D;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr__onValueChanged;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr__onTap;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr__onPressDown;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr__onPressUp;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr__useXAxis;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr__useYAxis;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeFieldInfoPtr__pointerId;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeFieldInfoPtr__realMousePointerId;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeFieldInfoPtr_AJKoOMhkVHACBErfSbaQmDfyxZV;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeFieldInfoPtr_xISHKSqmxBFBXboSBVekNAulortJ;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeFieldInfoPtr__pointerDownIsFake;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr__touchStartPosition;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr__touchStartTime;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr__currentCenter;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr__previousTouchPosition;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr__lastTapFrame;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeFieldInfoPtr__isEligibleForTap;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeFieldInfoPtr__isEligibleForPress;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr__pressValue;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeFieldInfoPtr__smoothDelta;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr___fakePointerEventData;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_UnityAction_1_Vector2_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_UnityAction_1_Vector2_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_add_TapEvent_Public_add_Void_UnityAction_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_remove_TapEvent_Public_rem_Void_UnityAction_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_add_PressDownEvent_Public_add_Void_UnityAction_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_remove_PressDownEvent_Public_rem_Void_UnityAction_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_add_PressUpEvent_Public_add_Void_UnityAction_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_remove_PressUpEvent_Public_rem_Void_UnityAction_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalAxisCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_get_tapCustomControllerElement_Public_get_CustomControllerElementTargetSetForBoolean_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_get_pressCustomControllerElement_Public_get_CustomControllerElementTargetSetForBoolean_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_get_axesToUse_Public_get_AxisDirection_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_set_axesToUse_Public_set_Void_AxisDirection_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_get_touchPadMode_Public_get_TouchPadMode_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_set_touchPadMode_Public_set_Void_TouchPadMode_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_get_valueFormat_Public_get_ValueFormat_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_set_valueFormat_Public_set_Void_ValueFormat_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_get_useInertia_Public_get_Boolean_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_set_useInertia_Public_set_Void_Boolean_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_get_inertiaFriction_Public_get_Single_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_set_inertiaFriction_Public_set_Void_Single_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_get_activateOnSwipeIn_Public_get_Boolean_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_set_activateOnSwipeIn_Public_set_Void_Boolean_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_get_stayActiveOnSwipeOut_Public_get_Boolean_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_set_stayActiveOnSwipeOut_Public_set_Void_Boolean_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_get_allowTap_Public_get_Boolean_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_set_allowTap_Public_set_Void_Boolean_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_get_tapTimeout_Public_get_Single_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_set_tapTimeout_Public_set_Void_Single_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_get_tapDistanceLimit_Public_get_Int32_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_set_tapDistanceLimit_Public_set_Void_Int32_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_get_allowPress_Public_get_Boolean_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_set_allowPress_Public_set_Void_Boolean_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_get_pressStartDelay_Public_get_Single_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_set_pressStartDelay_Public_set_Void_Single_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_get_pressDistanceLimit_Public_get_Int32_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_set_pressDistanceLimit_Public_set_Void_Int32_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_get_hideAtRuntime_Public_get_Boolean_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_set_hideAtRuntime_Public_set_Void_Boolean_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_get_hasPointer_Public_get_Boolean_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_get_touchStartPosition_Public_get_Vector2_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_get_touchPosition_Public_get_Vector2_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAxisCalibration_Public_get_AxisCalibration_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalAxisCalibration_Public_get_AxisCalibration_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_get_axis2DCalibration_Public_get_Axis2DCalibration_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_get_axis2D_Internal_get_StandaloneAxis2D_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_get_effectivePointerId_Private_get_Int32_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_get_tapValue_Private_get_Boolean_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Internal_Virtual_Void_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_Void_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Internal_Virtual_Void_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_xzNKXjAaJMKaZzoFxoimUjvQRfi_Internal_Virtual_Void_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_WbqbDgpASywaXyCuvhWbQHZDLXX_Private_Void_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_UnMFjSCmAMGvytjoLOAahnsmUzmO_Private_Void_AxisDirection_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_baEViyRRodmuwhaehpMDycKSVwN_Private_Void_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_sOtcTwggZdaXnDhjizojZiZSeRrU_Private_Void_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_xttgUBeWkaItOScFNdPnWUBHSCFl_Private_Void_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_sKvlCBBoCdqafdbFOCOXCCiLfAtf_Private_Void_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_CmYuplbDIcChxFOHikcWHATbXszo_Private_Void_byref_Vector2_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_zVQaLNqAdJCYSaqXuEQcDCOaqtwp_Private_Void_byref_Vector2_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_wtLqCzxxLqLosnJpkOyfcVrEacI_Private_Void_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_cczrmyMWIikgEqrQRTjbXHdxcGl_Private_Vector2_Vector2_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_GLQdsqAjfycQMAswIfMMNuKtXzw_Private_Void_Boolean_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_kigeNwWVsYERXqwjreancGuqqDE_Private_Void_PointerEventData_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_NJoaOsRdPOKjssNjRbxAqdXWPan_Private_Void_PointerEventData_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_ZAVdRrdxNFckOYQCbBCUgAfIgTyA_Private_Void_PointerEventData_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_lfnXGCYWqVSkgcSxlPOzgNuXEtM_Private_Void_PointerEventData_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_DDUCAWJSvpGMNhYKUcwQBJMrScy_Private_Void_Int32_Vector2_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_YItZvqPcQhbqZIBTSJcwAqrHqkd_Private_Void_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Internal_Virtual_Void_PointerEventData_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_tvfieGHVIvJAwOWABvkfZuaYRdg_Private_Void_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_EzuEKEcRDHQOUwaaCWnntUCHasKc_Private_Boolean_Int32_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_sPcvSSlGvTmwkQDQWFTYqTVIcix_Private_PointerEventData_Int32_GameObject_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_ldCMCnBLZMpzPoNHaCLvDGIJuib_Private_PointerEventData_Int32_GameObject_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_fygGGlEnKmuTNSTfXSwkyGEfsJS_Private_PointerEventData_Int32_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_BtCjHnVCQQZOUErBybAPpoLjeBj_Private_Void_PointerEventData_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_RTRyejIHkYVUBLhWNMKKFAUfreV_Private_PointerEventData_Int32_0;

		// Token: 0x0200025F RID: 607
		[OriginalName("Rewired_Core.dll", "", "AxisDirection")]
		public enum AxisDirection
		{
			// Token: 0x0400304A RID: 12362
			Both,
			// Token: 0x0400304B RID: 12363
			Horizontal,
			// Token: 0x0400304C RID: 12364
			Vertical
		}

		// Token: 0x02000260 RID: 608
		[OriginalName("Rewired_Core.dll", "", "TouchPadMode")]
		public enum TouchPadMode
		{
			// Token: 0x0400304E RID: 12366
			Delta,
			// Token: 0x0400304F RID: 12367
			ScreenPosition,
			// Token: 0x04003050 RID: 12368
			VectorFromCenter,
			// Token: 0x04003051 RID: 12369
			VectorFromInitialTouch
		}

		// Token: 0x02000261 RID: 609
		[OriginalName("Rewired_Core.dll", "", "ValueFormat")]
		public enum ValueFormat
		{
			// Token: 0x04003053 RID: 12371
			Pixels,
			// Token: 0x04003054 RID: 12372
			Screen,
			// Token: 0x04003055 RID: 12373
			Physical,
			// Token: 0x04003056 RID: 12374
			Direction
		}

		// Token: 0x02000262 RID: 610
		public class CzaXWOzXquHQnDnRXsrbaCxCXIj : global::Il2CppSystem.Object
		{
			// Token: 0x0600393A RID: 14650 RVA: 0x00116D58 File Offset: 0x00114F58
			// Note: this type is marked as 'beforefieldinit'.
			static CzaXWOzXquHQnDnRXsrbaCxCXIj()
			{
				Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "CzaXWOzXquHQnDnRXsrbaCxCXIj");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr);
				TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeFieldInfoPtr_TKcdLehDdrRWEGwInLsjYhVvDiO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr, "TKcdLehDdrRWEGwInLsjYhVvDiO");
				TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeFieldInfoPtr_yJYXnEfdkJNRmdgBKhiaglsvHpUg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr, "yJYXnEfdkJNRmdgBKhiaglsvHpUg");
				TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr, "czPgrBYcuMpJrlqXpuRJAvvkFiI");
				TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr, 100664877);
				TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr, 100664878);
				TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_vVVLndjJtzSZopmEpclnoNoiDMj_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr, 100664879);
				TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_tTsdudtTApDqvyFaSEtmgwIQcWti_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr, 100664880);
				TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_RbotheTrECgEiiAmtSNlxDBQGjh_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr, 100664881);
				TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_uKpfnBFlOVlleXLaCEZVNNHXjNTX_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr, 100664882);
				TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_aqRejdIwSvXtKiihFqfrPKCaQvA_Private_Static_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr, 100664883);
			}

			// Token: 0x0600393B RID: 14651 RVA: 0x00116E4C File Offset: 0x0011504C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250012, XrefRangeEnd = 250029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CzaXWOzXquHQnDnRXsrbaCxCXIj(int maxSmoothFrames)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref maxSmoothFrames;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600393C RID: 14652 RVA: 0x00116E94 File Offset: 0x00115094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250029, XrefRangeEnd = 250033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void jDuDLbhduyqRAnokNKSffDLOAphG(float A_1, float A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600393D RID: 14653 RVA: 0x00116EE0 File Offset: 0x001150E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250033, XrefRangeEnd = 250035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 vVVLndjJtzSZopmEpclnoNoiDMj()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_vVVLndjJtzSZopmEpclnoNoiDMj_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600393E RID: 14654 RVA: 0x00116F1C File Offset: 0x0011511C
			[CallerCount(0)]
			public unsafe void tTsdudtTApDqvyFaSEtmgwIQcWti()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_tTsdudtTApDqvyFaSEtmgwIQcWti_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600393F RID: 14655 RVA: 0x00116F50 File Offset: 0x00115150
			[CallerCount(0)]
			public unsafe static int RbotheTrECgEiiAmtSNlxDBQGjh(int A_0, int A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_RbotheTrECgEiiAmtSNlxDBQGjh_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003940 RID: 14656 RVA: 0x00116F9C File Offset: 0x0011519C
			[CallerCount(0)]
			public unsafe int uKpfnBFlOVlleXLaCEZVNNHXjNTX(int A_1, int A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_uKpfnBFlOVlleXLaCEZVNNHXjNTX_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003941 RID: 14657 RVA: 0x00116FF4 File Offset: 0x001151F4
			[CallerCount(0)]
			public unsafe static bool aqRejdIwSvXtKiihFqfrPKCaQvA(uint A_0, uint A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeMethodInfoPtr_aqRejdIwSvXtKiihFqfrPKCaQvA_Private_Static_Boolean_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003942 RID: 14658 RVA: 0x00014109 File Offset: 0x00012309
			public CzaXWOzXquHQnDnRXsrbaCxCXIj(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001114 RID: 4372
			// (get) Token: 0x06003943 RID: 14659 RVA: 0x00117040 File Offset: 0x00115240
			// (set) Token: 0x06003944 RID: 14660 RVA: 0x00014112 File Offset: 0x00012312
			public unsafe int TKcdLehDdrRWEGwInLsjYhVvDiO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeFieldInfoPtr_TKcdLehDdrRWEGwInLsjYhVvDiO);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeFieldInfoPtr_TKcdLehDdrRWEGwInLsjYhVvDiO)) = value;
				}
			}

			// Token: 0x17001115 RID: 4373
			// (get) Token: 0x06003945 RID: 14661 RVA: 0x00117068 File Offset: 0x00115268
			// (set) Token: 0x06003946 RID: 14662 RVA: 0x0001412D File Offset: 0x0001232D
			public unsafe Il2CppReferenceArray<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf> yJYXnEfdkJNRmdgBKhiaglsvHpUg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeFieldInfoPtr_yJYXnEfdkJNRmdgBKhiaglsvHpUg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeFieldInfoPtr_yJYXnEfdkJNRmdgBKhiaglsvHpUg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001116 RID: 4374
			// (get) Token: 0x06003947 RID: 14663 RVA: 0x00117098 File Offset: 0x00115298
			// (set) Token: 0x06003948 RID: 14664 RVA: 0x0001414C File Offset: 0x0001234C
			public unsafe int czPgrBYcuMpJrlqXpuRJAvvkFiI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI)) = value;
				}
			}

			// Token: 0x04003057 RID: 12375
			private static readonly IntPtr NativeFieldInfoPtr_TKcdLehDdrRWEGwInLsjYhVvDiO;

			// Token: 0x04003058 RID: 12376
			private static readonly IntPtr NativeFieldInfoPtr_yJYXnEfdkJNRmdgBKhiaglsvHpUg;

			// Token: 0x04003059 RID: 12377
			private static readonly IntPtr NativeFieldInfoPtr_czPgrBYcuMpJrlqXpuRJAvvkFiI;

			// Token: 0x0400305A RID: 12378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400305B RID: 12379
			private static readonly IntPtr NativeMethodInfoPtr_jDuDLbhduyqRAnokNKSffDLOAphG_Public_Void_Single_Single_0;

			// Token: 0x0400305C RID: 12380
			private static readonly IntPtr NativeMethodInfoPtr_vVVLndjJtzSZopmEpclnoNoiDMj_Public_Vector2_0;

			// Token: 0x0400305D RID: 12381
			private static readonly IntPtr NativeMethodInfoPtr_tTsdudtTApDqvyFaSEtmgwIQcWti_Private_Void_0;

			// Token: 0x0400305E RID: 12382
			private static readonly IntPtr NativeMethodInfoPtr_RbotheTrECgEiiAmtSNlxDBQGjh_Private_Static_Int32_Int32_Int32_0;

			// Token: 0x0400305F RID: 12383
			private static readonly IntPtr NativeMethodInfoPtr_uKpfnBFlOVlleXLaCEZVNNHXjNTX_Private_Int32_Int32_Int32_0;

			// Token: 0x04003060 RID: 12384
			private static readonly IntPtr NativeMethodInfoPtr_aqRejdIwSvXtKiihFqfrPKCaQvA_Private_Static_Boolean_UInt32_UInt32_0;

			// Token: 0x020004C3 RID: 1219
			public class RFdWoJHyUATLPKCooFOTczfRhnf : global::Il2CppSystem.Object
			{
				// Token: 0x06005275 RID: 21109 RVA: 0x00176038 File Offset: 0x00174238
				// Note: this type is marked as 'beforefieldinit'.
				static RFdWoJHyUATLPKCooFOTczfRhnf()
				{
					Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj>.NativeClassPtr, "RFdWoJHyUATLPKCooFOTczfRhnf");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf>.NativeClassPtr);
					TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf.NativeFieldInfoPtr_KAcbydvbDezarMrACqJiTnSTsGF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf>.NativeClassPtr, "KAcbydvbDezarMrACqJiTnSTsGF");
					TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf.NativeFieldInfoPtr_ceTeGyZoqjqmTSnnlUOfPoeqGPY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf>.NativeClassPtr, "ceTeGyZoqjqmTSnnlUOfPoeqGPY");
					TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf.NativeFieldInfoPtr_XfVHGYCFKcQruJNmXcIZiRiNTTg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf>.NativeClassPtr, "XfVHGYCFKcQruJNmXcIZiRiNTTg");
					TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf>.NativeClassPtr, 100664884);
				}

				// Token: 0x06005276 RID: 21110 RVA: 0x001760B4 File Offset: 0x001742B4
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe RFdWoJHyUATLPKCooFOTczfRhnf()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005277 RID: 21111 RVA: 0x0001DC46 File Offset: 0x0001BE46
				public RFdWoJHyUATLPKCooFOTczfRhnf(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001949 RID: 6473
				// (get) Token: 0x06005278 RID: 21112 RVA: 0x001760F0 File Offset: 0x001742F0
				// (set) Token: 0x06005279 RID: 21113 RVA: 0x0001DC4F File Offset: 0x0001BE4F
				public unsafe float KAcbydvbDezarMrACqJiTnSTsGF
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf.NativeFieldInfoPtr_KAcbydvbDezarMrACqJiTnSTsGF);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf.NativeFieldInfoPtr_KAcbydvbDezarMrACqJiTnSTsGF)) = value;
					}
				}

				// Token: 0x1700194A RID: 6474
				// (get) Token: 0x0600527A RID: 21114 RVA: 0x00176118 File Offset: 0x00174318
				// (set) Token: 0x0600527B RID: 21115 RVA: 0x0001DC6A File Offset: 0x0001BE6A
				public unsafe float ceTeGyZoqjqmTSnnlUOfPoeqGPY
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf.NativeFieldInfoPtr_ceTeGyZoqjqmTSnnlUOfPoeqGPY);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf.NativeFieldInfoPtr_ceTeGyZoqjqmTSnnlUOfPoeqGPY)) = value;
					}
				}

				// Token: 0x1700194B RID: 6475
				// (get) Token: 0x0600527C RID: 21116 RVA: 0x00176140 File Offset: 0x00174340
				// (set) Token: 0x0600527D RID: 21117 RVA: 0x0001DC85 File Offset: 0x0001BE85
				public unsafe uint XfVHGYCFKcQruJNmXcIZiRiNTTg
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf.NativeFieldInfoPtr_XfVHGYCFKcQruJNmXcIZiRiNTTg);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPad.CzaXWOzXquHQnDnRXsrbaCxCXIj.RFdWoJHyUATLPKCooFOTczfRhnf.NativeFieldInfoPtr_XfVHGYCFKcQruJNmXcIZiRiNTTg)) = value;
					}
				}

				// Token: 0x04004529 RID: 17705
				private static readonly IntPtr NativeFieldInfoPtr_KAcbydvbDezarMrACqJiTnSTsGF;

				// Token: 0x0400452A RID: 17706
				private static readonly IntPtr NativeFieldInfoPtr_ceTeGyZoqjqmTSnnlUOfPoeqGPY;

				// Token: 0x0400452B RID: 17707
				private static readonly IntPtr NativeFieldInfoPtr_XfVHGYCFKcQruJNmXcIZiRiNTTg;

				// Token: 0x0400452C RID: 17708
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x02000263 RID: 611
		[Serializable]
		public class ValueChangedEventHandler : UnityEvent<Vector2>
		{
			// Token: 0x06003949 RID: 14665 RVA: 0x00014167 File Offset: 0x00012367
			// Note: this type is marked as 'beforefieldinit'.
			static ValueChangedEventHandler()
			{
				Il2CppClassPointerStore<TouchPad.ValueChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "ValueChangedEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchPad.ValueChangedEventHandler>.NativeClassPtr);
				TouchPad.ValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.ValueChangedEventHandler>.NativeClassPtr, 100664885);
			}

			// Token: 0x0600394A RID: 14666 RVA: 0x001170C0 File Offset: 0x001152C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250035, XrefRangeEnd = 250037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueChangedEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchPad.ValueChangedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.ValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600394B RID: 14667 RVA: 0x0001419B File Offset: 0x0001239B
			public ValueChangedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003061 RID: 12385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000264 RID: 612
		[Serializable]
		public class TapEventHandler : UnityEvent
		{
			// Token: 0x0600394C RID: 14668 RVA: 0x000141A4 File Offset: 0x000123A4
			// Note: this type is marked as 'beforefieldinit'.
			static TapEventHandler()
			{
				Il2CppClassPointerStore<TouchPad.TapEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "TapEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchPad.TapEventHandler>.NativeClassPtr);
				TouchPad.TapEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.TapEventHandler>.NativeClassPtr, 100664886);
			}

			// Token: 0x0600394D RID: 14669 RVA: 0x001170FC File Offset: 0x001152FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TapEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchPad.TapEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.TapEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600394E RID: 14670 RVA: 0x000141D8 File Offset: 0x000123D8
			public TapEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003062 RID: 12386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000265 RID: 613
		[Serializable]
		public class PressDownEventHandler : UnityEvent
		{
			// Token: 0x0600394F RID: 14671 RVA: 0x000141E1 File Offset: 0x000123E1
			// Note: this type is marked as 'beforefieldinit'.
			static PressDownEventHandler()
			{
				Il2CppClassPointerStore<TouchPad.PressDownEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "PressDownEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchPad.PressDownEventHandler>.NativeClassPtr);
				TouchPad.PressDownEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.PressDownEventHandler>.NativeClassPtr, 100664887);
			}

			// Token: 0x06003950 RID: 14672 RVA: 0x00117138 File Offset: 0x00115338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PressDownEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchPad.PressDownEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.PressDownEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003951 RID: 14673 RVA: 0x00014215 File Offset: 0x00012415
			public PressDownEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003063 RID: 12387
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000266 RID: 614
		[Serializable]
		public class PressUpEventHandler : UnityEvent
		{
			// Token: 0x06003952 RID: 14674 RVA: 0x0001421E File Offset: 0x0001241E
			// Note: this type is marked as 'beforefieldinit'.
			static PressUpEventHandler()
			{
				Il2CppClassPointerStore<TouchPad.PressUpEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchPad>.NativeClassPtr, "PressUpEventHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchPad.PressUpEventHandler>.NativeClassPtr);
				TouchPad.PressUpEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPad.PressUpEventHandler>.NativeClassPtr, 100664888);
			}

			// Token: 0x06003953 RID: 14675 RVA: 0x00117174 File Offset: 0x00115374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PressUpEventHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchPad.PressUpEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPad.PressUpEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003954 RID: 14676 RVA: 0x00014252 File Offset: 0x00012452
			public PressUpEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003064 RID: 12388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
