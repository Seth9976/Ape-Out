using System;
using System.Runtime.InteropServices;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Core.Enums;
using Il2CppDG.Tweening.Plugins.Core;
using Il2CppDG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x02000008 RID: 8
	public class DOTween : global::Il2CppSystem.Object
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00005D80 File Offset: 0x00003F80
		// Note: this type is marked as 'beforefieldinit'.
		static DOTween()
		{
			Il2CppClassPointerStore<DOTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "DOTween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTween>.NativeClassPtr);
			DOTween.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "Version");
			DOTween.NativeFieldInfoPtr_useSafeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "useSafeMode");
			DOTween.NativeFieldInfoPtr_nestedTweenFailureBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "nestedTweenFailureBehaviour");
			DOTween.NativeFieldInfoPtr_showUnityEditorReport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "showUnityEditorReport");
			DOTween.NativeFieldInfoPtr_timeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "timeScale");
			DOTween.NativeFieldInfoPtr_useSmoothDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "useSmoothDeltaTime");
			DOTween.NativeFieldInfoPtr_maxSmoothUnscaledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "maxSmoothUnscaledTime");
			DOTween.NativeFieldInfoPtr_rewindCallbackMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "rewindCallbackMode");
			DOTween.NativeFieldInfoPtr__logBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "_logBehaviour");
			DOTween.NativeFieldInfoPtr_drawGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "drawGizmos");
			DOTween.NativeFieldInfoPtr_defaultUpdateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultUpdateType");
			DOTween.NativeFieldInfoPtr_defaultTimeScaleIndependent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultTimeScaleIndependent");
			DOTween.NativeFieldInfoPtr_defaultAutoPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultAutoPlay");
			DOTween.NativeFieldInfoPtr_defaultAutoKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultAutoKill");
			DOTween.NativeFieldInfoPtr_defaultLoopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultLoopType");
			DOTween.NativeFieldInfoPtr_defaultRecyclable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultRecyclable");
			DOTween.NativeFieldInfoPtr_defaultEaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultEaseType");
			DOTween.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultEaseOvershootOrAmplitude");
			DOTween.NativeFieldInfoPtr_defaultEasePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "defaultEasePeriod");
			DOTween.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "instance");
			DOTween.NativeFieldInfoPtr_maxActiveTweenersReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "maxActiveTweenersReached");
			DOTween.NativeFieldInfoPtr_maxActiveSequencesReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "maxActiveSequencesReached");
			DOTween.NativeFieldInfoPtr_GizmosDelegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "GizmosDelegates");
			DOTween.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "initialized");
			DOTween.NativeFieldInfoPtr_isQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "isQuitting");
			DOTween.NativeMethodInfoPtr_get_logBehaviour_Public_Static_get_LogBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663313);
			DOTween.NativeMethodInfoPtr_set_logBehaviour_Public_Static_set_Void_LogBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663314);
			DOTween.NativeMethodInfoPtr_Init_Public_Static_IDOTweenInit_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663315);
			DOTween.NativeMethodInfoPtr_AutoInit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663316);
			DOTween.NativeMethodInfoPtr_Init_Private_Static_IDOTweenInit_DOTweenSettings_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663317);
			DOTween.NativeMethodInfoPtr_SetTweensCapacity_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663318);
			DOTween.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663319);
			DOTween.NativeMethodInfoPtr_ClearCachedTweens_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663320);
			DOTween.NativeMethodInfoPtr_Validate_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663321);
			DOTween.NativeMethodInfoPtr_ManualUpdate_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663322);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Single_Single_FloatOptions_DOGetter_1_Single_DOSetter_1_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663323);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Double_Double_NoOptions_DOGetter_1_Double_DOSetter_1_Double_Double_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663324);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Int32_Int32_NoOptions_DOGetter_1_Int32_DOSetter_1_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663325);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_UInt32_UInt32_UintOptions_DOGetter_1_UInt32_DOSetter_1_UInt32_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663326);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Int64_Int64_NoOptions_DOGetter_1_Int64_DOSetter_1_Int64_Int64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663327);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_UInt64_UInt64_NoOptions_DOGetter_1_UInt64_DOSetter_1_UInt64_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663328);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_String_String_StringOptions_DOGetter_1_String_DOSetter_1_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663329);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_DOGetter_1_Vector2_DOSetter_1_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663330);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663331);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_DOGetter_1_Vector4_DOSetter_1_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663332);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_DOGetter_1_Quaternion_DOSetter_1_Quaternion_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663333);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Color_Color_ColorOptions_DOGetter_1_Color_DOSetter_1_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663334);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_DOGetter_1_Rect_DOSetter_1_Rect_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663335);
			DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_RectOffset_DOSetter_1_RectOffset_RectOffset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663336);
			DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_ABSTweenPlugin_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663337);
			DOTween.NativeMethodInfoPtr_ToAxis_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_AxisConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663338);
			DOTween.NativeMethodInfoPtr_ToAlpha_Public_Static_TweenerCore_3_Color_Color_ColorOptions_DOGetter_1_Color_DOSetter_1_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663339);
			DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOSetter_1_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663340);
			DOTween.NativeMethodInfoPtr_Punch_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663341);
			DOTween.NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663342);
			DOTween.NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663343);
			DOTween.NativeMethodInfoPtr_Shake_Private_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663344);
			DOTween.NativeMethodInfoPtr_ToArray_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663345);
			DOTween.NativeMethodInfoPtr_To_Internal_Static_TweenerCore_3_Color2_Color2_ColorOptions_DOGetter_1_Color2_DOSetter_1_Color2_Color2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663346);
			DOTween.NativeMethodInfoPtr_Sequence_Public_Static_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663347);
			DOTween.NativeMethodInfoPtr_CompleteAll_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663348);
			DOTween.NativeMethodInfoPtr_Complete_Public_Static_Int32_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663349);
			DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663350);
			DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663351);
			DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTotExceptFor_Internal_Static_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663352);
			DOTween.NativeMethodInfoPtr_FlipAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663353);
			DOTween.NativeMethodInfoPtr_Flip_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663354);
			DOTween.NativeMethodInfoPtr_GotoAll_Public_Static_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663355);
			DOTween.NativeMethodInfoPtr_Goto_Public_Static_Int32_Object_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663356);
			DOTween.NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663357);
			DOTween.NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663358);
			DOTween.NativeMethodInfoPtr_Kill_Public_Static_Int32_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663359);
			DOTween.NativeMethodInfoPtr_PauseAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663360);
			DOTween.NativeMethodInfoPtr_Pause_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663361);
			DOTween.NativeMethodInfoPtr_PlayAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663362);
			DOTween.NativeMethodInfoPtr_Play_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663363);
			DOTween.NativeMethodInfoPtr_Play_Public_Static_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663364);
			DOTween.NativeMethodInfoPtr_PlayBackwardsAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663365);
			DOTween.NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663366);
			DOTween.NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663367);
			DOTween.NativeMethodInfoPtr_PlayForwardAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663368);
			DOTween.NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663369);
			DOTween.NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663370);
			DOTween.NativeMethodInfoPtr_RestartAll_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663371);
			DOTween.NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663372);
			DOTween.NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Object_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663373);
			DOTween.NativeMethodInfoPtr_RewindAll_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663374);
			DOTween.NativeMethodInfoPtr_Rewind_Public_Static_Int32_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663375);
			DOTween.NativeMethodInfoPtr_SmoothRewindAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663376);
			DOTween.NativeMethodInfoPtr_SmoothRewind_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663377);
			DOTween.NativeMethodInfoPtr_TogglePauseAll_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663378);
			DOTween.NativeMethodInfoPtr_TogglePause_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663379);
			DOTween.NativeMethodInfoPtr_IsTweening_Public_Static_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663380);
			DOTween.NativeMethodInfoPtr_TotalPlayingTweens_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663381);
			DOTween.NativeMethodInfoPtr_PlayingTweens_Public_Static_List_1_Tween_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663382);
			DOTween.NativeMethodInfoPtr_PausedTweens_Public_Static_List_1_Tween_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663383);
			DOTween.NativeMethodInfoPtr_TweensById_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663384);
			DOTween.NativeMethodInfoPtr_TweensByTarget_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663385);
			DOTween.NativeMethodInfoPtr_InitCheck_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663386);
			DOTween.NativeMethodInfoPtr_ApplyTo_Private_Static_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663387);
			DOTween.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween>.NativeClassPtr, 100663388);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00006594 File Offset: 0x00004794
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000065C4 File Offset: 0x000047C4
		public unsafe static LogBehaviour logBehaviour
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117871, XrefRangeEnd = 117875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_get_logBehaviour_Public_Static_get_LogBehaviour_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117882, RefRangeEnd = 117885, XrefRangeStart = 117875, XrefRangeEnd = 117882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_set_logBehaviour_Public_Static_set_Void_LogBehaviour_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000065F8 File Offset: 0x000047F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117885, XrefRangeEnd = 117904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDOTweenInit Init(Nullable<bool> recycleAllByDefault = null, Nullable<bool> useSafeMode = null, Nullable<LogBehaviour> logBehaviour = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(recycleAllByDefault));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(useSafeMode));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(logBehaviour));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Init_Public_Static_IDOTweenInit_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDOTweenInit>(intPtr3) : null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00006670 File Offset: 0x00004870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117904, XrefRangeEnd = 117915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoInit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_AutoInit_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00006698 File Offset: 0x00004898
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 118040, RefRangeEnd = 118043, XrefRangeStart = 117915, XrefRangeEnd = 118040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDOTweenInit Init(DOTweenSettings settings, Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(recycleAllByDefault));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(useSafeMode));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(logBehaviour));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Init_Private_Static_IDOTweenInit_DOTweenSettings_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDOTweenInit>(intPtr3) : null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00006724 File Offset: 0x00004924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118043, XrefRangeEnd = 118047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tweenersCapacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequencesCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_SetTweensCapacity_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00006764 File Offset: 0x00004964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118047, XrefRangeEnd = 118075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(bool destroy = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref destroy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00006798 File Offset: 0x00004998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118075, XrefRangeEnd = 118079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCachedTweens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_ClearCachedTweens_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000067C0 File Offset: 0x000049C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118079, XrefRangeEnd = 118083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Validate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Validate_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000067F0 File Offset: 0x000049F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118097, RefRangeEnd = 118098, XrefRangeStart = 118083, XrefRangeEnd = 118097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManualUpdate(float deltaTime, float unscaledDeltaTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unscaledDeltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_ManualUpdate_Public_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00006830 File Offset: 0x00004A30
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 118115, RefRangeEnd = 118142, XrefRangeStart = 118098, XrefRangeEnd = 118115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Single_Single_FloatOptions_DOGetter_1_Single_DOSetter_1_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000068A4 File Offset: 0x00004AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118142, XrefRangeEnd = 118159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Double_Double_NoOptions_DOGetter_1_Double_DOSetter_1_Double_Double_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<double, double, NoOptions>>(intPtr3) : null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00006918 File Offset: 0x00004B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118159, XrefRangeEnd = 118176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Int32_Int32_NoOptions_DOGetter_1_Int32_DOSetter_1_Int32_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<int, int, NoOptions>>(intPtr3) : null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000698C File Offset: 0x00004B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118176, XrefRangeEnd = 118193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_UInt32_UInt32_UintOptions_DOGetter_1_UInt32_DOSetter_1_UInt32_UInt32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<uint, uint, UintOptions>>(intPtr3) : null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00006A00 File Offset: 0x00004C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118193, XrefRangeEnd = 118210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Int64_Int64_NoOptions_DOGetter_1_Int64_DOSetter_1_Int64_Int64_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<long, long, NoOptions>>(intPtr3) : null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006A74 File Offset: 0x00004C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118210, XrefRangeEnd = 118227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_UInt64_UInt64_NoOptions_DOGetter_1_UInt64_DOSetter_1_UInt64_UInt64_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<ulong, ulong, NoOptions>>(intPtr3) : null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00006AE8 File Offset: 0x00004CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118227, XrefRangeEnd = 118244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(endValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_String_String_StringOptions_DOGetter_1_String_DOSetter_1_String_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<string, string, StringOptions>>(intPtr3) : null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00006B60 File Offset: 0x00004D60
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 118261, RefRangeEnd = 118289, XrefRangeStart = 118244, XrefRangeEnd = 118261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_DOGetter_1_Vector2_DOSetter_1_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00006BD4 File Offset: 0x00004DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118289, XrefRangeEnd = 118294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00006C48 File Offset: 0x00004E48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118311, RefRangeEnd = 118313, XrefRangeStart = 118294, XrefRangeEnd = 118311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_DOGetter_1_Vector4_DOSetter_1_Vector4_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector4, Vector4, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006CBC File Offset: 0x00004EBC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 118330, RefRangeEnd = 118337, XrefRangeStart = 118313, XrefRangeEnd = 118330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_DOGetter_1_Quaternion_DOSetter_1_Quaternion_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Quaternion, Vector3, QuaternionOptions>>(intPtr3) : null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006D30 File Offset: 0x00004F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118337, XrefRangeEnd = 118342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Color_Color_ColorOptions_DOGetter_1_Color_DOSetter_1_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006DA4 File Offset: 0x00004FA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118359, RefRangeEnd = 118361, XrefRangeStart = 118342, XrefRangeEnd = 118359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_DOGetter_1_Rect_DOSetter_1_Rect_Rect_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Rect, Rect, RectOptions>>(intPtr3) : null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006E18 File Offset: 0x00005018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118361, XrefRangeEnd = 118378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_RectOffset_DOSetter_1_RectOffset_RectOffset_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006E90 File Offset: 0x00005090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118378, XrefRangeEnd = 118381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(plugin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = endValue;
				if (!(t is string))
				{
					ref T2 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr3) != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref endValue;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.MethodInfoStoreGeneric_To_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_ABSTweenPlugin_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006F64 File Offset: 0x00005164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118381, XrefRangeEnd = 118386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.X)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_ToAxis_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_AxisConstraint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006FE4 File Offset: 0x000051E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 118391, RefRangeEnd = 118399, XrefRangeStart = 118386, XrefRangeEnd = 118391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_ToAlpha_Public_Static_TweenerCore_3_Color_Color_ColorOptions_DOGetter_1_Color_DOSetter_1_Color_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00007058 File Offset: 0x00005258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118399, XrefRangeEnd = 118419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(setter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Public_Static_Tweener_DOSetter_1_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000070C8 File Offset: 0x000052C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 118440, RefRangeEnd = 118445, XrefRangeStart = 118419, XrefRangeEnd = 118440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elasticity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Punch_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions>>(intPtr3) : null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00007158 File Offset: 0x00005358
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 118449, RefRangeEnd = 118455, XrefRangeStart = 118445, XrefRangeEnd = 118449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool ignoreZAxis = true, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreZAxis;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_Int32_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions>>(intPtr3) : null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00007204 File Offset: 0x00005404
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 118459, RefRangeEnd = 118465, XrefRangeStart = 118455, XrefRangeEnd = 118459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions>>(intPtr3) : null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000072A0 File Offset: 0x000054A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118517, RefRangeEnd = 118519, XrefRangeStart = 118465, XrefRangeEnd = 118517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreZAxis;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vectorBased;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Shake_Private_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions>>(intPtr3) : null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000735C File Offset: 0x0000555C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118541, RefRangeEnd = 118543, XrefRangeStart = 118519, XrefRangeEnd = 118541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Il2CppStructArray<Vector3> endValues, Il2CppStructArray<float> durations)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endValues);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(durations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_ToArray_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions>>(intPtr3) : null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000073D8 File Offset: 0x000055D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118543, XrefRangeEnd = 118560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_To_Internal_Static_TweenerCore_3_Color2_Color2_ColorOptions_DOGetter_1_Color2_DOSetter_1_Color2_Color2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color2, Color2, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000744C File Offset: 0x0000564C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 118582, RefRangeEnd = 118592, XrefRangeStart = 118560, XrefRangeEnd = 118582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence Sequence()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Sequence_Public_Static_Sequence_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00007480 File Offset: 0x00005680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118596, RefRangeEnd = 118597, XrefRangeStart = 118592, XrefRangeEnd = 118596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompleteAll(bool withCallbacks = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withCallbacks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_CompleteAll_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000074C0 File Offset: 0x000056C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118597, XrefRangeEnd = 118601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Complete(global::Il2CppSystem.Object targetOrId, bool withCallbacks = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Complete_Public_Static_Int32_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00007510 File Offset: 0x00005710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118605, RefRangeEnd = 118606, XrefRangeStart = 118601, XrefRangeEnd = 118605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompleteAndReturnKilledTot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00007540 File Offset: 0x00005740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118606, XrefRangeEnd = 118610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompleteAndReturnKilledTot(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00007584 File Offset: 0x00005784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118610, XrefRangeEnd = 118614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompleteAndReturnKilledTotExceptFor([Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> excludeTargetsOrIds)
		{
			if (excludeTargetsOrIds == null)
			{
				excludeTargetsOrIds = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(excludeTargetsOrIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_CompleteAndReturnKilledTotExceptFor_Internal_Static_Int32_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000075D4 File Offset: 0x000057D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118614, XrefRangeEnd = 118618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FlipAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_FlipAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00007604 File Offset: 0x00005804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118618, XrefRangeEnd = 118622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Flip(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Flip_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007648 File Offset: 0x00005848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118622, XrefRangeEnd = 118626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GotoAll(float to, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref to;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_GotoAll_Public_Static_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00007694 File Offset: 0x00005894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118626, XrefRangeEnd = 118630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Goto(global::Il2CppSystem.Object targetOrId, float to, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Goto_Public_Static_Int32_Object_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000076F4 File Offset: 0x000058F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118630, XrefRangeEnd = 118639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int KillAll(bool complete = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref complete;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007734 File Offset: 0x00005934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118639, XrefRangeEnd = 118651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int KillAll(bool complete, [Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> idsOrTargetsToExclude)
		{
			if (idsOrTargetsToExclude == null)
			{
				idsOrTargetsToExclude = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref complete;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(idsOrTargetsToExclude);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007790 File Offset: 0x00005990
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 118663, RefRangeEnd = 118666, XrefRangeStart = 118651, XrefRangeEnd = 118663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Kill(global::Il2CppSystem.Object targetOrId, bool complete = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Kill_Public_Static_Int32_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000077E0 File Offset: 0x000059E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118666, XrefRangeEnd = 118670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PauseAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PauseAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007810 File Offset: 0x00005A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118670, XrefRangeEnd = 118674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Pause(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Pause_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007854 File Offset: 0x00005A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118674, XrefRangeEnd = 118678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007884 File Offset: 0x00005A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118678, XrefRangeEnd = 118682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Play(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Play_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000078C8 File Offset: 0x00005AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118682, XrefRangeEnd = 118686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Play(global::Il2CppSystem.Object target, global::Il2CppSystem.Object id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Play_Public_Static_Int32_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000791C File Offset: 0x00005B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118686, XrefRangeEnd = 118690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayBackwardsAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayBackwardsAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000794C File Offset: 0x00005B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118690, XrefRangeEnd = 118694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayBackwards(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007990 File Offset: 0x00005B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118694, XrefRangeEnd = 118698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayBackwards(global::Il2CppSystem.Object target, global::Il2CppSystem.Object id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000079E4 File Offset: 0x00005BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118698, XrefRangeEnd = 118702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayForwardAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayForwardAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007A14 File Offset: 0x00005C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118702, XrefRangeEnd = 118706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayForward(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007A58 File Offset: 0x00005C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118706, XrefRangeEnd = 118710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayForward(global::Il2CppSystem.Object target, global::Il2CppSystem.Object id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00007AAC File Offset: 0x00005CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118710, XrefRangeEnd = 118714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RestartAll(bool includeDelay = true)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_RestartAll_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00007AEC File Offset: 0x00005CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118714, XrefRangeEnd = 118718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Restart(global::Il2CppSystem.Object targetOrId, bool includeDelay = true, float changeDelayTo = -1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeDelayTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007B4C File Offset: 0x00005D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118718, XrefRangeEnd = 118723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Restart(global::Il2CppSystem.Object target, global::Il2CppSystem.Object id, bool includeDelay = true, float changeDelayTo = -1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeDelayTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Object_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007BBC File Offset: 0x00005DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118723, XrefRangeEnd = 118727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RewindAll(bool includeDelay = true)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_RewindAll_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007BFC File Offset: 0x00005DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118727, XrefRangeEnd = 118731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Rewind(global::Il2CppSystem.Object targetOrId, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_Rewind_Public_Static_Int32_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007C4C File Offset: 0x00005E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118731, XrefRangeEnd = 118735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SmoothRewindAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_SmoothRewindAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007C7C File Offset: 0x00005E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118735, XrefRangeEnd = 118739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SmoothRewind(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_SmoothRewind_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00007CC0 File Offset: 0x00005EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118739, XrefRangeEnd = 118743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TogglePauseAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_TogglePauseAll_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007CF0 File Offset: 0x00005EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118747, RefRangeEnd = 118748, XrefRangeStart = 118743, XrefRangeEnd = 118747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TogglePause(global::Il2CppSystem.Object targetOrId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_TogglePause_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007D34 File Offset: 0x00005F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118748, XrefRangeEnd = 118752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTweening(global::Il2CppSystem.Object targetOrId, bool alsoCheckIfIsPlaying = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alsoCheckIfIsPlaying;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_IsTweening_Public_Static_Boolean_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007D84 File Offset: 0x00005F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118752, XrefRangeEnd = 118770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TotalPlayingTweens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_TotalPlayingTweens_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007DB4 File Offset: 0x00005FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118770, XrefRangeEnd = 118776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> PlayingTweens(List<Tween> fillableList = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PlayingTweens_Public_Static_List_1_Tween_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007DF8 File Offset: 0x00005FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118776, XrefRangeEnd = 118782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> PausedTweens(List<Tween> fillableList = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_PausedTweens_Public_Static_List_1_Tween_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007E3C File Offset: 0x0000603C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118782, XrefRangeEnd = 118788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> TweensById(global::Il2CppSystem.Object id, bool playingOnly = false, List<Tween> fillableList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playingOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_TweensById_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007EA0 File Offset: 0x000060A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118788, XrefRangeEnd = 118794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> TweensByTarget(global::Il2CppSystem.Object target, bool playingOnly = false, List<Tween> fillableList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playingOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_TweensByTarget_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007F04 File Offset: 0x00006104
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 118815, RefRangeEnd = 118834, XrefRangeStart = 118794, XrefRangeEnd = 118815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitCheck()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr_InitCheck_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007F2C File Offset: 0x0000612C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118834, XrefRangeEnd = 118845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = endValue;
				if (!(t is string))
				{
					ref T2 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr3) != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref endValue;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(plugin);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.MethodInfoStoreGeneric_ApplyTo_Private_Static_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008000 File Offset: 0x00006200
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DOTween()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTween>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000020F2 File Offset: 0x000002F2
		public static int CompleteAndReturnKilledTotExceptFor(params global::Il2CppSystem.Object[] excludeTargetsOrIds)
		{
			return DOTween.CompleteAndReturnKilledTotExceptFor(new Il2CppReferenceArray<global::Il2CppSystem.Object>(excludeTargetsOrIds));
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000020FF File Offset: 0x000002FF
		public static int KillAll(bool complete, params global::Il2CppSystem.Object[] idsOrTargetsToExclude)
		{
			return DOTween.KillAll(complete, new Il2CppReferenceArray<global::Il2CppSystem.Object>(idsOrTargetsToExclude));
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000210D File Offset: 0x0000030D
		public DOTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000803C File Offset: 0x0000623C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002116 File Offset: 0x00000316
		public unsafe static string Version
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_Version, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_Version, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000805C File Offset: 0x0000625C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002128 File Offset: 0x00000328
		public unsafe static bool useSafeMode
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_useSafeMode, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_useSafeMode, (void*)(&value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00008078 File Offset: 0x00006278
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002136 File Offset: 0x00000336
		public unsafe static NestedTweenFailureBehaviour nestedTweenFailureBehaviour
		{
			get
			{
				NestedTweenFailureBehaviour nestedTweenFailureBehaviour;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_nestedTweenFailureBehaviour, (void*)(&nestedTweenFailureBehaviour));
				return nestedTweenFailureBehaviour;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_nestedTweenFailureBehaviour, (void*)(&value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00008094 File Offset: 0x00006294
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002144 File Offset: 0x00000344
		public unsafe static bool showUnityEditorReport
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_showUnityEditorReport, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_showUnityEditorReport, (void*)(&value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000080B0 File Offset: 0x000062B0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002152 File Offset: 0x00000352
		public unsafe static float timeScale
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_timeScale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_timeScale, (void*)(&value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000080CC File Offset: 0x000062CC
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002160 File Offset: 0x00000360
		public unsafe static bool useSmoothDeltaTime
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_useSmoothDeltaTime, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_useSmoothDeltaTime, (void*)(&value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000080E8 File Offset: 0x000062E8
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000216E File Offset: 0x0000036E
		public unsafe static float maxSmoothUnscaledTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_maxSmoothUnscaledTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_maxSmoothUnscaledTime, (void*)(&value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00008104 File Offset: 0x00006304
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000217C File Offset: 0x0000037C
		public unsafe static RewindCallbackMode rewindCallbackMode
		{
			get
			{
				RewindCallbackMode rewindCallbackMode;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_rewindCallbackMode, (void*)(&rewindCallbackMode));
				return rewindCallbackMode;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_rewindCallbackMode, (void*)(&value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00008120 File Offset: 0x00006320
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000218A File Offset: 0x0000038A
		public unsafe static LogBehaviour _logBehaviour
		{
			get
			{
				LogBehaviour logBehaviour;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr__logBehaviour, (void*)(&logBehaviour));
				return logBehaviour;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr__logBehaviour, (void*)(&value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000813C File Offset: 0x0000633C
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002198 File Offset: 0x00000398
		public unsafe static bool drawGizmos
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_drawGizmos, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_drawGizmos, (void*)(&value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00008158 File Offset: 0x00006358
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000021A6 File Offset: 0x000003A6
		public unsafe static UpdateType defaultUpdateType
		{
			get
			{
				UpdateType updateType;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultUpdateType, (void*)(&updateType));
				return updateType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultUpdateType, (void*)(&value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00008174 File Offset: 0x00006374
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000021B4 File Offset: 0x000003B4
		public unsafe static bool defaultTimeScaleIndependent
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultTimeScaleIndependent, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultTimeScaleIndependent, (void*)(&value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00008190 File Offset: 0x00006390
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000021C2 File Offset: 0x000003C2
		public unsafe static AutoPlay defaultAutoPlay
		{
			get
			{
				AutoPlay autoPlay;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultAutoPlay, (void*)(&autoPlay));
				return autoPlay;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultAutoPlay, (void*)(&value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000081AC File Offset: 0x000063AC
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000021D0 File Offset: 0x000003D0
		public unsafe static bool defaultAutoKill
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultAutoKill, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultAutoKill, (void*)(&value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000081C8 File Offset: 0x000063C8
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000021DE File Offset: 0x000003DE
		public unsafe static LoopType defaultLoopType
		{
			get
			{
				LoopType loopType;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultLoopType, (void*)(&loopType));
				return loopType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultLoopType, (void*)(&value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000081E4 File Offset: 0x000063E4
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000021EC File Offset: 0x000003EC
		public unsafe static bool defaultRecyclable
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultRecyclable, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultRecyclable, (void*)(&value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00008200 File Offset: 0x00006400
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000021FA File Offset: 0x000003FA
		public unsafe static Ease defaultEaseType
		{
			get
			{
				Ease ease;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultEaseType, (void*)(&ease));
				return ease;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultEaseType, (void*)(&value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000821C File Offset: 0x0000641C
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002208 File Offset: 0x00000408
		public unsafe static float defaultEaseOvershootOrAmplitude
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude, (void*)(&value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00008238 File Offset: 0x00006438
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002216 File Offset: 0x00000416
		public unsafe static float defaultEasePeriod
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_defaultEasePeriod, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_defaultEasePeriod, (void*)(&value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00008254 File Offset: 0x00006454
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002224 File Offset: 0x00000424
		public unsafe static DOTweenComponent instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DOTweenComponent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000827C File Offset: 0x0000647C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002236 File Offset: 0x00000436
		public unsafe static int maxActiveTweenersReached
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_maxActiveTweenersReached, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_maxActiveTweenersReached, (void*)(&value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00008298 File Offset: 0x00006498
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002244 File Offset: 0x00000444
		public unsafe static int maxActiveSequencesReached
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_maxActiveSequencesReached, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_maxActiveSequencesReached, (void*)(&value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000082B4 File Offset: 0x000064B4
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002252 File Offset: 0x00000452
		public unsafe static List<TweenCallback> GizmosDelegates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_GizmosDelegates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TweenCallback>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_GizmosDelegates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000082DC File Offset: 0x000064DC
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002264 File Offset: 0x00000464
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000082F8 File Offset: 0x000064F8
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002272 File Offset: 0x00000472
		public unsafe static bool isQuitting
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTween.NativeFieldInfoPtr_isQuitting, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTween.NativeFieldInfoPtr_isQuitting, (void*)(&value));
			}
		}

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_useSafeMode;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_nestedTweenFailureBehaviour;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_showUnityEditorReport;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_timeScale;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_useSmoothDeltaTime;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_maxSmoothUnscaledTime;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_rewindCallbackMode;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr__logBehaviour;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_drawGizmos;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_defaultUpdateType;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_defaultTimeScaleIndependent;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_defaultAutoPlay;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_defaultAutoKill;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_defaultLoopType;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_defaultRecyclable;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_defaultEaseType;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_defaultEasePeriod;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_maxActiveTweenersReached;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_maxActiveSequencesReached;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_GizmosDelegates;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_isQuitting;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_logBehaviour_Public_Static_get_LogBehaviour_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_set_logBehaviour_Public_Static_set_Void_LogBehaviour_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_IDOTweenInit_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_AutoInit_Private_Static_Void_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_IDOTweenInit_DOTweenSettings_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_LogBehaviour_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_SetTweensCapacity_Public_Static_Void_Int32_Int32_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedTweens_Public_Static_Void_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Static_Int32_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_ManualUpdate_Public_Static_Void_Single_Single_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Single_Single_FloatOptions_DOGetter_1_Single_DOSetter_1_Single_Single_Single_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Double_Double_NoOptions_DOGetter_1_Double_DOSetter_1_Double_Double_Single_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Int32_Int32_NoOptions_DOGetter_1_Int32_DOSetter_1_Int32_Int32_Single_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_UInt32_UInt32_UintOptions_DOGetter_1_UInt32_DOSetter_1_UInt32_UInt32_Single_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Int64_Int64_NoOptions_DOGetter_1_Int64_DOSetter_1_Int64_Int64_Single_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_UInt64_UInt64_NoOptions_DOGetter_1_UInt64_DOSetter_1_UInt64_UInt64_Single_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_String_String_StringOptions_DOGetter_1_String_DOSetter_1_String_String_Single_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_DOGetter_1_Vector2_DOSetter_1_Vector2_Vector2_Single_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_DOGetter_1_Vector4_DOSetter_1_Vector4_Vector4_Single_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_DOGetter_1_Quaternion_DOSetter_1_Quaternion_Vector3_Single_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Color_Color_ColorOptions_DOGetter_1_Color_DOSetter_1_Color_Color_Single_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_DOGetter_1_Rect_DOSetter_1_Rect_Rect_Single_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_Tweener_DOGetter_1_RectOffset_DOSetter_1_RectOffset_RectOffset_Single_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_ABSTweenPlugin_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_ToAxis_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_AxisConstraint_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ToAlpha_Public_Static_TweenerCore_3_Color_Color_ColorOptions_DOGetter_1_Color_DOSetter_1_Color_Single_Single_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_To_Public_Static_Tweener_DOSetter_1_Single_Single_Single_Single_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_Punch_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Vector3_Single_Int32_Single_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Single_Int32_Single_Boolean_Boolean_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_Shake_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_Shake_Private_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Vector3_Int32_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Static_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_DOGetter_1_Vector3_DOSetter_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Single_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_To_Internal_Static_TweenerCore_3_Color2_Color2_ColorOptions_DOGetter_1_Color2_DOSetter_1_Color2_Color2_Single_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_Sequence_Public_Static_Sequence_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAll_Public_Static_Int32_Boolean_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Static_Int32_Object_Boolean_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAndReturnKilledTot_Internal_Static_Int32_Object_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAndReturnKilledTotExceptFor_Internal_Static_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_FlipAll_Public_Static_Int32_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_Flip_Public_Static_Int32_Object_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_GotoAll_Public_Static_Int32_Single_Boolean_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Public_Static_Int32_Object_Single_Boolean_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_KillAll_Public_Static_Int32_Boolean_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Static_Int32_Object_Boolean_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_PauseAll_Public_Static_Int32_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Int32_Object_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_PlayAll_Public_Static_Int32_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_Int32_Object_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_Int32_Object_Object_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_PlayBackwardsAll_Public_Static_Int32_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_PlayBackwards_Public_Static_Int32_Object_Object_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_PlayForwardAll_Public_Static_Int32_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_PlayForward_Public_Static_Int32_Object_Object_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_RestartAll_Public_Static_Int32_Boolean_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Boolean_Single_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_Restart_Public_Static_Int32_Object_Object_Boolean_Single_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_RewindAll_Public_Static_Int32_Boolean_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_Rewind_Public_Static_Int32_Object_Boolean_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_SmoothRewindAll_Public_Static_Int32_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_SmoothRewind_Public_Static_Int32_Object_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_TogglePauseAll_Public_Static_Int32_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_TogglePause_Public_Static_Int32_Object_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_IsTweening_Public_Static_Boolean_Object_Boolean_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_TotalPlayingTweens_Public_Static_Int32_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_PlayingTweens_Public_Static_List_1_Tween_List_1_Tween_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_PausedTweens_Public_Static_List_1_Tween_List_1_Tween_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_TweensById_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_TweensByTarget_Public_Static_List_1_Tween_Object_Boolean_List_1_Tween_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_InitCheck_Private_Static_Void_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTo_Private_Static_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000061 RID: 97
		[ObfuscatedName("DG.Tweening.DOTween+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005BE RID: 1470 RVA: 0x0001F908 File Offset: 0x0001DB08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<DOTween.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTween>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTween.__c__DisplayClass53_0>.NativeClassPtr);
				DOTween.__c__DisplayClass53_0.NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween.__c__DisplayClass53_0>.NativeClassPtr, "v");
				DOTween.__c__DisplayClass53_0.NativeFieldInfoPtr_setter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTween.__c__DisplayClass53_0>.NativeClassPtr, "setter");
				DOTween.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween.__c__DisplayClass53_0>.NativeClassPtr, 100663390);
				DOTween.__c__DisplayClass53_0.NativeMethodInfoPtr__To_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween.__c__DisplayClass53_0>.NativeClassPtr, 100663391);
				DOTween.__c__DisplayClass53_0.NativeMethodInfoPtr__To_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTween.__c__DisplayClass53_0>.NativeClassPtr, 100663392);
			}

			// Token: 0x060005BF RID: 1471 RVA: 0x0001F998 File Offset: 0x0001DB98
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTween.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005C0 RID: 1472 RVA: 0x0001F9D4 File Offset: 0x0001DBD4
			[CallerCount(0)]
			public unsafe float _To_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.__c__DisplayClass53_0.NativeMethodInfoPtr__To_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005C1 RID: 1473 RVA: 0x0001FA10 File Offset: 0x0001DC10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117867, XrefRangeEnd = 117871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _To_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTween.__c__DisplayClass53_0.NativeMethodInfoPtr__To_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005C2 RID: 1474 RVA: 0x00003E22 File Offset: 0x00002022
			public __c__DisplayClass53_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0001FA50 File Offset: 0x0001DC50
			// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00003E2B File Offset: 0x0000202B
			public unsafe float v
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTween.__c__DisplayClass53_0.NativeFieldInfoPtr_v);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTween.__c__DisplayClass53_0.NativeFieldInfoPtr_v)) = value;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001FA78 File Offset: 0x0001DC78
			// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00003E46 File Offset: 0x00002046
			public unsafe DOSetter<float> setter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTween.__c__DisplayClass53_0.NativeFieldInfoPtr_setter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DOSetter<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTween.__c__DisplayClass53_0.NativeFieldInfoPtr_setter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004A5 RID: 1189
			private static readonly IntPtr NativeFieldInfoPtr_v;

			// Token: 0x040004A6 RID: 1190
			private static readonly IntPtr NativeFieldInfoPtr_setter;

			// Token: 0x040004A7 RID: 1191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004A8 RID: 1192
			private static readonly IntPtr NativeMethodInfoPtr__To_b__0_Internal_Single_0;

			// Token: 0x040004A9 RID: 1193
			private static readonly IntPtr NativeMethodInfoPtr__To_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000062 RID: 98
		private sealed class MethodInfoStoreGeneric_To_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_ABSTweenPlugin_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_0<T1, T2, TPlugOptions>
		{
			// Token: 0x040004AA RID: 1194
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DOTween.NativeMethodInfoPtr_To_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_ABSTweenPlugin_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_0, Il2CppClassPointerStore<DOTween>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000063 RID: 99
		private sealed class MethodInfoStoreGeneric_ApplyTo_Private_Static_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x040004AB RID: 1195
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DOTween.NativeMethodInfoPtr_ApplyTo_Private_Static_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<DOTween>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}
	}
}
