using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public class Animator : Behaviour
	{
		// Token: 0x060000DE RID: 222 RVA: 0x000077DC File Offset: 0x000059DC
		// Note: this type is marked as 'beforefieldinit'.
		static Animator()
		{
			Il2CppClassPointerStore<Animator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "Animator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Animator>.NativeClassPtr);
			Animator.NativeMethodInfoPtr_get_isHuman_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663334);
			Animator.NativeMethodInfoPtr_get_hasRootMotion_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663335);
			Animator.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663336);
			Animator.NativeMethodInfoPtr_SetBool_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663337);
			Animator.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663338);
			Animator.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663339);
			Animator.NativeMethodInfoPtr_GetAnimatorStateInfo_Private_Void_Int32_StateInfoIndex_byref_AnimatorStateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663340);
			Animator.NativeMethodInfoPtr_GetCurrentAnimatorStateInfo_Public_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663341);
			Animator.NativeMethodInfoPtr_Play_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663342);
			Animator.NativeMethodInfoPtr_Play_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663343);
			Animator.NativeMethodInfoPtr_Play_Public_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663344);
			Animator.NativeMethodInfoPtr_get_runtimeAnimatorController_Public_get_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663345);
			Animator.NativeMethodInfoPtr_set_runtimeAnimatorController_Public_set_Void_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663346);
			Animator.NativeMethodInfoPtr_get_hasBoundPlayables_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663347);
			Animator.NativeMethodInfoPtr_StringToHash_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663348);
			Animator.NativeMethodInfoPtr_get_avatar_Public_get_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663349);
			Animator.NativeMethodInfoPtr_SetFloatString_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663350);
			Animator.NativeMethodInfoPtr_SetBoolID_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663351);
			Animator.NativeMethodInfoPtr_SetTriggerString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663352);
			Animator.NativeMethodInfoPtr_ResetTriggerString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663353);
			Animator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100663354);
			Animator.get_isOptimizableDelegateField = IL2CPP.ResolveICall<Animator.get_isOptimizableDelegate>("UnityEngine.Animator::get_isOptimizable");
			Animator.get_isRootPositionOrRotationControlledByCurvesDelegateField = IL2CPP.ResolveICall<Animator.get_isRootPositionOrRotationControlledByCurvesDelegate>("UnityEngine.Animator::get_isRootPositionOrRotationControlledByCurves");
			Animator.get_humanScaleDelegateField = IL2CPP.ResolveICall<Animator.get_humanScaleDelegate>("UnityEngine.Animator::get_humanScale");
			Animator.get_isInitializedDelegateField = IL2CPP.ResolveICall<Animator.get_isInitializedDelegate>("UnityEngine.Animator::get_isInitialized");
			Animator.get_applyRootMotionDelegateField = IL2CPP.ResolveICall<Animator.get_applyRootMotionDelegate>("UnityEngine.Animator::get_applyRootMotion");
			Animator.set_applyRootMotionDelegateField = IL2CPP.ResolveICall<Animator.set_applyRootMotionDelegate>("UnityEngine.Animator::set_applyRootMotion");
			Animator.get_linearVelocityBlendingDelegateField = IL2CPP.ResolveICall<Animator.get_linearVelocityBlendingDelegate>("UnityEngine.Animator::get_linearVelocityBlending");
			Animator.set_linearVelocityBlendingDelegateField = IL2CPP.ResolveICall<Animator.set_linearVelocityBlendingDelegate>("UnityEngine.Animator::set_linearVelocityBlending");
			Animator.get_updateModeDelegateField = IL2CPP.ResolveICall<Animator.get_updateModeDelegate>("UnityEngine.Animator::get_updateMode");
			Animator.set_updateModeDelegateField = IL2CPP.ResolveICall<Animator.set_updateModeDelegate>("UnityEngine.Animator::set_updateMode");
			Animator.get_hasTransformHierarchyDelegateField = IL2CPP.ResolveICall<Animator.get_hasTransformHierarchyDelegate>("UnityEngine.Animator::get_hasTransformHierarchy");
			Animator.get_allowConstantClipSamplingOptimizationDelegateField = IL2CPP.ResolveICall<Animator.get_allowConstantClipSamplingOptimizationDelegate>("UnityEngine.Animator::get_allowConstantClipSamplingOptimization");
			Animator.set_allowConstantClipSamplingOptimizationDelegateField = IL2CPP.ResolveICall<Animator.set_allowConstantClipSamplingOptimizationDelegate>("UnityEngine.Animator::set_allowConstantClipSamplingOptimization");
			Animator.get_gravityWeightDelegateField = IL2CPP.ResolveICall<Animator.get_gravityWeightDelegate>("UnityEngine.Animator::get_gravityWeight");
			Animator.GetGoalWeightPositionDelegateField = IL2CPP.ResolveICall<Animator.GetGoalWeightPositionDelegate>("UnityEngine.Animator::GetGoalWeightPosition");
			Animator.SetGoalWeightPositionDelegateField = IL2CPP.ResolveICall<Animator.SetGoalWeightPositionDelegate>("UnityEngine.Animator::SetGoalWeightPosition");
			Animator.GetGoalWeightRotationDelegateField = IL2CPP.ResolveICall<Animator.GetGoalWeightRotationDelegate>("UnityEngine.Animator::GetGoalWeightRotation");
			Animator.SetGoalWeightRotationDelegateField = IL2CPP.ResolveICall<Animator.SetGoalWeightRotationDelegate>("UnityEngine.Animator::SetGoalWeightRotation");
			Animator.GetHintWeightPositionDelegateField = IL2CPP.ResolveICall<Animator.GetHintWeightPositionDelegate>("UnityEngine.Animator::GetHintWeightPosition");
			Animator.SetHintWeightPositionDelegateField = IL2CPP.ResolveICall<Animator.SetHintWeightPositionDelegate>("UnityEngine.Animator::SetHintWeightPosition");
			Animator.SetLookAtWeightInternalDelegateField = IL2CPP.ResolveICall<Animator.SetLookAtWeightInternalDelegate>("UnityEngine.Animator::SetLookAtWeightInternal");
			Animator.GetBehaviourDelegateField = IL2CPP.ResolveICall<Animator.GetBehaviourDelegate>("UnityEngine.Animator::GetBehaviour");
			Animator.InternalGetBehavioursDelegateField = IL2CPP.ResolveICall<Animator.InternalGetBehavioursDelegate>("UnityEngine.Animator::InternalGetBehaviours");
			Animator.InternalGetBehavioursByKeyDelegateField = IL2CPP.ResolveICall<Animator.InternalGetBehavioursByKeyDelegate>("UnityEngine.Animator::InternalGetBehavioursByKey");
			Animator.get_stabilizeFeetDelegateField = IL2CPP.ResolveICall<Animator.get_stabilizeFeetDelegate>("UnityEngine.Animator::get_stabilizeFeet");
			Animator.set_stabilizeFeetDelegateField = IL2CPP.ResolveICall<Animator.set_stabilizeFeetDelegate>("UnityEngine.Animator::set_stabilizeFeet");
			Animator.get_layerCountDelegateField = IL2CPP.ResolveICall<Animator.get_layerCountDelegate>("UnityEngine.Animator::get_layerCount");
			Animator.GetLayerNameDelegateField = IL2CPP.ResolveICall<Animator.GetLayerNameDelegate>("UnityEngine.Animator::GetLayerName");
			Animator.GetLayerIndexDelegateField = IL2CPP.ResolveICall<Animator.GetLayerIndexDelegate>("UnityEngine.Animator::GetLayerIndex");
			Animator.GetLayerWeightDelegateField = IL2CPP.ResolveICall<Animator.GetLayerWeightDelegate>("UnityEngine.Animator::GetLayerWeight");
			Animator.SetLayerWeightDelegateField = IL2CPP.ResolveICall<Animator.SetLayerWeightDelegate>("UnityEngine.Animator::SetLayerWeight");
			Animator.GetAnimatorTransitionInfoDelegateField = IL2CPP.ResolveICall<Animator.GetAnimatorTransitionInfoDelegate>("UnityEngine.Animator::GetAnimatorTransitionInfo");
			Animator.GetAnimatorClipInfoCountDelegateField = IL2CPP.ResolveICall<Animator.GetAnimatorClipInfoCountDelegate>("UnityEngine.Animator::GetAnimatorClipInfoCount");
			Animator.GetCurrentAnimatorClipInfoDelegateField = IL2CPP.ResolveICall<Animator.GetCurrentAnimatorClipInfoDelegate>("UnityEngine.Animator::GetCurrentAnimatorClipInfo");
			Animator.GetNextAnimatorClipInfoDelegateField = IL2CPP.ResolveICall<Animator.GetNextAnimatorClipInfoDelegate>("UnityEngine.Animator::GetNextAnimatorClipInfo");
			Animator.GetAnimatorClipInfoInternalDelegateField = IL2CPP.ResolveICall<Animator.GetAnimatorClipInfoInternalDelegate>("UnityEngine.Animator::GetAnimatorClipInfoInternal");
			Animator.IsInTransitionDelegateField = IL2CPP.ResolveICall<Animator.IsInTransitionDelegate>("UnityEngine.Animator::IsInTransition");
			Animator.get_parametersDelegateField = IL2CPP.ResolveICall<Animator.get_parametersDelegate>("UnityEngine.Animator::get_parameters");
			Animator.get_parameterCountDelegateField = IL2CPP.ResolveICall<Animator.get_parameterCountDelegate>("UnityEngine.Animator::get_parameterCount");
			Animator.GetParameterInternalDelegateField = IL2CPP.ResolveICall<Animator.GetParameterInternalDelegate>("UnityEngine.Animator::GetParameterInternal");
			Animator.get_feetPivotActiveDelegateField = IL2CPP.ResolveICall<Animator.get_feetPivotActiveDelegate>("UnityEngine.Animator::get_feetPivotActive");
			Animator.set_feetPivotActiveDelegateField = IL2CPP.ResolveICall<Animator.set_feetPivotActiveDelegate>("UnityEngine.Animator::set_feetPivotActive");
			Animator.get_pivotWeightDelegateField = IL2CPP.ResolveICall<Animator.get_pivotWeightDelegate>("UnityEngine.Animator::get_pivotWeight");
			Animator.InterruptMatchTargetDelegateField = IL2CPP.ResolveICall<Animator.InterruptMatchTargetDelegate>("UnityEngine.Animator::InterruptMatchTarget");
			Animator.get_isMatchingTargetDelegateField = IL2CPP.ResolveICall<Animator.get_isMatchingTargetDelegate>("UnityEngine.Animator::get_isMatchingTarget");
			Animator.get_speedDelegateField = IL2CPP.ResolveICall<Animator.get_speedDelegate>("UnityEngine.Animator::get_speed");
			Animator.set_speedDelegateField = IL2CPP.ResolveICall<Animator.set_speedDelegate>("UnityEngine.Animator::set_speed");
			Animator.CrossFadeInFixedTimeDelegateField = IL2CPP.ResolveICall<Animator.CrossFadeInFixedTimeDelegate>("UnityEngine.Animator::CrossFadeInFixedTime");
			Animator.WriteDefaultValuesDelegateField = IL2CPP.ResolveICall<Animator.WriteDefaultValuesDelegate>("UnityEngine.Animator::WriteDefaultValues");
			Animator.CrossFadeDelegateField = IL2CPP.ResolveICall<Animator.CrossFadeDelegate>("UnityEngine.Animator::CrossFade");
			Animator.PlayInFixedTimeDelegateField = IL2CPP.ResolveICall<Animator.PlayInFixedTimeDelegate>("UnityEngine.Animator::PlayInFixedTime");
			Animator.SetTargetDelegateField = IL2CPP.ResolveICall<Animator.SetTargetDelegate>("UnityEngine.Animator::SetTarget");
			Animator.IsBoneTransformDelegateField = IL2CPP.ResolveICall<Animator.IsBoneTransformDelegate>("UnityEngine.Animator::IsBoneTransform");
			Animator.get_avatarRootDelegateField = IL2CPP.ResolveICall<Animator.get_avatarRootDelegate>("UnityEngine.Animator::get_avatarRoot");
			Animator.GetBoneTransformInternalDelegateField = IL2CPP.ResolveICall<Animator.GetBoneTransformInternalDelegate>("UnityEngine.Animator::GetBoneTransformInternal");
			Animator.get_cullingModeDelegateField = IL2CPP.ResolveICall<Animator.get_cullingModeDelegate>("UnityEngine.Animator::get_cullingMode");
			Animator.set_cullingModeDelegateField = IL2CPP.ResolveICall<Animator.set_cullingModeDelegate>("UnityEngine.Animator::set_cullingMode");
			Animator.StartPlaybackDelegateField = IL2CPP.ResolveICall<Animator.StartPlaybackDelegate>("UnityEngine.Animator::StartPlayback");
			Animator.StopPlaybackDelegateField = IL2CPP.ResolveICall<Animator.StopPlaybackDelegate>("UnityEngine.Animator::StopPlayback");
			Animator.get_playbackTimeDelegateField = IL2CPP.ResolveICall<Animator.get_playbackTimeDelegate>("UnityEngine.Animator::get_playbackTime");
			Animator.set_playbackTimeDelegateField = IL2CPP.ResolveICall<Animator.set_playbackTimeDelegate>("UnityEngine.Animator::set_playbackTime");
			Animator.StartRecordingDelegateField = IL2CPP.ResolveICall<Animator.StartRecordingDelegate>("UnityEngine.Animator::StartRecording");
			Animator.StopRecordingDelegateField = IL2CPP.ResolveICall<Animator.StopRecordingDelegate>("UnityEngine.Animator::StopRecording");
			Animator.GetRecorderStartTimeDelegateField = IL2CPP.ResolveICall<Animator.GetRecorderStartTimeDelegate>("UnityEngine.Animator::GetRecorderStartTime");
			Animator.GetRecorderStopTimeDelegateField = IL2CPP.ResolveICall<Animator.GetRecorderStopTimeDelegate>("UnityEngine.Animator::GetRecorderStopTime");
			Animator.get_recorderModeDelegateField = IL2CPP.ResolveICall<Animator.get_recorderModeDelegate>("UnityEngine.Animator::get_recorderMode");
			Animator.ClearInternalControllerPlayableDelegateField = IL2CPP.ResolveICall<Animator.ClearInternalControllerPlayableDelegate>("UnityEngine.Animator::ClearInternalControllerPlayable");
			Animator.HasStateDelegateField = IL2CPP.ResolveICall<Animator.HasStateDelegate>("UnityEngine.Animator::HasState");
			Animator.set_avatarDelegateField = IL2CPP.ResolveICall<Animator.set_avatarDelegate>("UnityEngine.Animator::set_avatar");
			Animator.GetStatsDelegateField = IL2CPP.ResolveICall<Animator.GetStatsDelegate>("UnityEngine.Animator::GetStats");
			Animator.GetCurrentGraphDelegateField = IL2CPP.ResolveICall<Animator.GetCurrentGraphDelegate>("UnityEngine.Animator::GetCurrentGraph");
			Animator.IsInIKPassDelegateField = IL2CPP.ResolveICall<Animator.IsInIKPassDelegate>("UnityEngine.Animator::IsInIKPass");
			Animator.SetFloatIDDelegateField = IL2CPP.ResolveICall<Animator.SetFloatIDDelegate>("UnityEngine.Animator::SetFloatID");
			Animator.GetFloatStringDelegateField = IL2CPP.ResolveICall<Animator.GetFloatStringDelegate>("UnityEngine.Animator::GetFloatString");
			Animator.GetFloatIDDelegateField = IL2CPP.ResolveICall<Animator.GetFloatIDDelegate>("UnityEngine.Animator::GetFloatID");
			Animator.SetBoolStringDelegateField = IL2CPP.ResolveICall<Animator.SetBoolStringDelegate>("UnityEngine.Animator::SetBoolString");
			Animator.GetBoolStringDelegateField = IL2CPP.ResolveICall<Animator.GetBoolStringDelegate>("UnityEngine.Animator::GetBoolString");
			Animator.GetBoolIDDelegateField = IL2CPP.ResolveICall<Animator.GetBoolIDDelegate>("UnityEngine.Animator::GetBoolID");
			Animator.SetIntegerStringDelegateField = IL2CPP.ResolveICall<Animator.SetIntegerStringDelegate>("UnityEngine.Animator::SetIntegerString");
			Animator.SetIntegerIDDelegateField = IL2CPP.ResolveICall<Animator.SetIntegerIDDelegate>("UnityEngine.Animator::SetIntegerID");
			Animator.GetIntegerStringDelegateField = IL2CPP.ResolveICall<Animator.GetIntegerStringDelegate>("UnityEngine.Animator::GetIntegerString");
			Animator.GetIntegerIDDelegateField = IL2CPP.ResolveICall<Animator.GetIntegerIDDelegate>("UnityEngine.Animator::GetIntegerID");
			Animator.SetTriggerIDDelegateField = IL2CPP.ResolveICall<Animator.SetTriggerIDDelegate>("UnityEngine.Animator::SetTriggerID");
			Animator.ResetTriggerIDDelegateField = IL2CPP.ResolveICall<Animator.ResetTriggerIDDelegate>("UnityEngine.Animator::ResetTriggerID");
			Animator.IsParameterControlledByCurveStringDelegateField = IL2CPP.ResolveICall<Animator.IsParameterControlledByCurveStringDelegate>("UnityEngine.Animator::IsParameterControlledByCurveString");
			Animator.IsParameterControlledByCurveIDDelegateField = IL2CPP.ResolveICall<Animator.IsParameterControlledByCurveIDDelegate>("UnityEngine.Animator::IsParameterControlledByCurveID");
			Animator.SetFloatStringDampDelegateField = IL2CPP.ResolveICall<Animator.SetFloatStringDampDelegate>("UnityEngine.Animator::SetFloatStringDamp");
			Animator.SetFloatIDDampDelegateField = IL2CPP.ResolveICall<Animator.SetFloatIDDampDelegate>("UnityEngine.Animator::SetFloatIDDamp");
			Animator.get_layersAffectMassCenterDelegateField = IL2CPP.ResolveICall<Animator.get_layersAffectMassCenterDelegate>("UnityEngine.Animator::get_layersAffectMassCenter");
			Animator.set_layersAffectMassCenterDelegateField = IL2CPP.ResolveICall<Animator.set_layersAffectMassCenterDelegate>("UnityEngine.Animator::set_layersAffectMassCenter");
			Animator.get_leftFeetBottomHeightDelegateField = IL2CPP.ResolveICall<Animator.get_leftFeetBottomHeightDelegate>("UnityEngine.Animator::get_leftFeetBottomHeight");
			Animator.get_rightFeetBottomHeightDelegateField = IL2CPP.ResolveICall<Animator.get_rightFeetBottomHeightDelegate>("UnityEngine.Animator::get_rightFeetBottomHeight");
			Animator.get_supportsOnAnimatorMoveDelegateField = IL2CPP.ResolveICall<Animator.get_supportsOnAnimatorMoveDelegate>("UnityEngine.Animator::get_supportsOnAnimatorMove");
			Animator.OnUpdateModeChangedDelegateField = IL2CPP.ResolveICall<Animator.OnUpdateModeChangedDelegate>("UnityEngine.Animator::OnUpdateModeChanged");
			Animator.OnCullingModeChangedDelegateField = IL2CPP.ResolveICall<Animator.OnCullingModeChangedDelegate>("UnityEngine.Animator::OnCullingModeChanged");
			Animator.WriteDefaultPoseDelegateField = IL2CPP.ResolveICall<Animator.WriteDefaultPoseDelegate>("UnityEngine.Animator::WriteDefaultPose");
			Animator.UpdateDelegateField = IL2CPP.ResolveICall<Animator.UpdateDelegate>("UnityEngine.Animator::Update");
			Animator.RebindDelegateField = IL2CPP.ResolveICall<Animator.RebindDelegate>("UnityEngine.Animator::Rebind");
			Animator.ApplyBuiltinRootMotionDelegateField = IL2CPP.ResolveICall<Animator.ApplyBuiltinRootMotionDelegate>("UnityEngine.Animator::ApplyBuiltinRootMotion");
			Animator.EvaluateControllerDelegateField = IL2CPP.ResolveICall<Animator.EvaluateControllerDelegate>("UnityEngine.Animator::EvaluateController");
			Animator.GetAnimatorStateNameDelegateField = IL2CPP.ResolveICall<Animator.GetAnimatorStateNameDelegate>("UnityEngine.Animator::GetAnimatorStateName");
			Animator.ResolveHashDelegateField = IL2CPP.ResolveICall<Animator.ResolveHashDelegate>("UnityEngine.Animator::ResolveHash");
			Animator.get_logWarningsDelegateField = IL2CPP.ResolveICall<Animator.get_logWarningsDelegate>("UnityEngine.Animator::get_logWarnings");
			Animator.set_logWarningsDelegateField = IL2CPP.ResolveICall<Animator.set_logWarningsDelegate>("UnityEngine.Animator::set_logWarnings");
			Animator.get_fireEventsDelegateField = IL2CPP.ResolveICall<Animator.get_fireEventsDelegate>("UnityEngine.Animator::get_fireEvents");
			Animator.set_fireEventsDelegateField = IL2CPP.ResolveICall<Animator.set_fireEventsDelegate>("UnityEngine.Animator::set_fireEvents");
			Animator.get_keepAnimatorStateOnDisableDelegateField = IL2CPP.ResolveICall<Animator.get_keepAnimatorStateOnDisableDelegate>("UnityEngine.Animator::get_keepAnimatorStateOnDisable");
			Animator.set_keepAnimatorStateOnDisableDelegateField = IL2CPP.ResolveICall<Animator.set_keepAnimatorStateOnDisableDelegate>("UnityEngine.Animator::set_keepAnimatorStateOnDisable");
			Animator.get_writeDefaultValuesOnDisableDelegateField = IL2CPP.ResolveICall<Animator.get_writeDefaultValuesOnDisableDelegate>("UnityEngine.Animator::get_writeDefaultValuesOnDisable");
			Animator.set_writeDefaultValuesOnDisableDelegateField = IL2CPP.ResolveICall<Animator.set_writeDefaultValuesOnDisableDelegate>("UnityEngine.Animator::set_writeDefaultValuesOnDisable");
			Animator.get_deltaPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_deltaPosition_InjectedDelegate>("UnityEngine.Animator::get_deltaPosition_Injected");
			Animator.get_deltaRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_deltaRotation_InjectedDelegate>("UnityEngine.Animator::get_deltaRotation_Injected");
			Animator.get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_velocity_InjectedDelegate>("UnityEngine.Animator::get_velocity_Injected");
			Animator.get_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_angularVelocity_InjectedDelegate>("UnityEngine.Animator::get_angularVelocity_Injected");
			Animator.get_rootPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_rootPosition_InjectedDelegate>("UnityEngine.Animator::get_rootPosition_Injected");
			Animator.set_rootPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.set_rootPosition_InjectedDelegate>("UnityEngine.Animator::set_rootPosition_Injected");
			Animator.get_rootRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_rootRotation_InjectedDelegate>("UnityEngine.Animator::get_rootRotation_Injected");
			Animator.set_rootRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.set_rootRotation_InjectedDelegate>("UnityEngine.Animator::set_rootRotation_Injected");
			Animator.get_bodyPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_bodyPositionInternal_InjectedDelegate>("UnityEngine.Animator::get_bodyPositionInternal_Injected");
			Animator.set_bodyPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.set_bodyPositionInternal_InjectedDelegate>("UnityEngine.Animator::set_bodyPositionInternal_Injected");
			Animator.get_bodyRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_bodyRotationInternal_InjectedDelegate>("UnityEngine.Animator::get_bodyRotationInternal_Injected");
			Animator.set_bodyRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.set_bodyRotationInternal_InjectedDelegate>("UnityEngine.Animator::set_bodyRotationInternal_Injected");
			Animator.GetGoalPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.GetGoalPosition_InjectedDelegate>("UnityEngine.Animator::GetGoalPosition_Injected");
			Animator.SetGoalPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.SetGoalPosition_InjectedDelegate>("UnityEngine.Animator::SetGoalPosition_Injected");
			Animator.GetGoalRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.GetGoalRotation_InjectedDelegate>("UnityEngine.Animator::GetGoalRotation_Injected");
			Animator.SetGoalRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.SetGoalRotation_InjectedDelegate>("UnityEngine.Animator::SetGoalRotation_Injected");
			Animator.GetHintPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.GetHintPosition_InjectedDelegate>("UnityEngine.Animator::GetHintPosition_Injected");
			Animator.SetHintPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.SetHintPosition_InjectedDelegate>("UnityEngine.Animator::SetHintPosition_Injected");
			Animator.SetLookAtPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.SetLookAtPositionInternal_InjectedDelegate>("UnityEngine.Animator::SetLookAtPositionInternal_Injected");
			Animator.SetBoneLocalRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<Animator.SetBoneLocalRotationInternal_InjectedDelegate>("UnityEngine.Animator::SetBoneLocalRotationInternal_Injected");
			Animator.get_pivotPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_pivotPosition_InjectedDelegate>("UnityEngine.Animator::get_pivotPosition_Injected");
			Animator.get_targetPosition_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_targetPosition_InjectedDelegate>("UnityEngine.Animator::get_targetPosition_Injected");
			Animator.get_targetRotation_InjectedDelegateField = IL2CPP.ResolveICall<Animator.get_targetRotation_InjectedDelegate>("UnityEngine.Animator::get_targetRotation_Injected");
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000817C File Offset: 0x0000637C
		public unsafe bool isHuman
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483815, RefRangeEnd = 483816, XrefRangeStart = 483811, XrefRangeEnd = 483815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_get_isHuman_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000081B8 File Offset: 0x000063B8
		public unsafe bool hasRootMotion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483816, XrefRangeEnd = 483820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_get_hasRootMotion_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000081F4 File Offset: 0x000063F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483820, XrefRangeEnd = 483824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00008244 File Offset: 0x00006444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 483828, RefRangeEnd = 483830, XrefRangeStart = 483824, XrefRangeEnd = 483828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(int id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetBool_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00008290 File Offset: 0x00006490
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 483834, RefRangeEnd = 483841, XrefRangeStart = 483830, XrefRangeEnd = 483834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrigger(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000082D4 File Offset: 0x000064D4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 483845, RefRangeEnd = 483861, XrefRangeStart = 483841, XrefRangeEnd = 483845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrigger(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00008318 File Offset: 0x00006518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483861, XrefRangeEnd = 483865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateInfoIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_GetAnimatorStateInfo_Private_Void_Int32_StateInfoIndex_byref_AnimatorStateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00008374 File Offset: 0x00006574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 483867, RefRangeEnd = 483868, XrefRangeStart = 483865, XrefRangeEnd = 483867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_GetCurrentAnimatorStateInfo_Public_AnimatorStateInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000083C0 File Offset: 0x000065C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483868, XrefRangeEnd = 483869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(string stateName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stateName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_Play_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00008404 File Offset: 0x00006604
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 483874, RefRangeEnd = 483877, XrefRangeStart = 483869, XrefRangeEnd = 483874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(string stateName, int layer, float normalizedTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stateName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_Play_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00008464 File Offset: 0x00006664
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 483881, RefRangeEnd = 483884, XrefRangeStart = 483877, XrefRangeEnd = 483881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(int stateNameHash, int layer, float normalizedTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stateNameHash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_Play_Public_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000084C0 File Offset: 0x000066C0
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00008500 File Offset: 0x00006700
		public unsafe RuntimeAnimatorController runtimeAnimatorController
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 483888, RefRangeEnd = 483893, XrefRangeStart = 483884, XrefRangeEnd = 483888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_get_runtimeAnimatorController_Public_get_RuntimeAnimatorController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483893, XrefRangeEnd = 483897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_set_runtimeAnimatorController_Public_set_Void_RuntimeAnimatorController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00008544 File Offset: 0x00006744
		public unsafe bool hasBoundPlayables
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483897, XrefRangeEnd = 483901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_get_hasBoundPlayables_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00008580 File Offset: 0x00006780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483901, XrefRangeEnd = 483905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringToHash(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_StringToHash_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000085C4 File Offset: 0x000067C4
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002F6A File Offset: 0x0000116A
		public unsafe Avatar avatar
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483909, RefRangeEnd = 483910, XrefRangeStart = 483905, XrefRangeEnd = 483909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_get_avatar_Public_get_Avatar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr3) : null;
			}
			set
			{
				Animator.set_avatarDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00008604 File Offset: 0x00006804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatString(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetFloatString_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00008654 File Offset: 0x00006854
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 483828, RefRangeEnd = 483830, XrefRangeStart = 483828, XrefRangeEnd = 483830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoolID(int id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetBoolID_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000086A0 File Offset: 0x000068A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 483834, RefRangeEnd = 483841, XrefRangeStart = 483834, XrefRangeEnd = 483841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriggerString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_SetTriggerString_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000086E4 File Offset: 0x000068E4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 483845, RefRangeEnd = 483861, XrefRangeStart = 483845, XrefRangeEnd = 483861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTriggerString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_ResetTriggerString_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00008728 File Offset: 0x00006928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Animator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Animator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000285F File Offset: 0x00000A5F
		public Animator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002868 File Offset: 0x00000A68
		public bool isOptimizable
		{
			get
			{
				return Animator.get_isOptimizableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000287A File Offset: 0x00000A7A
		public bool isRootPositionOrRotationControlledByCurves
		{
			get
			{
				return Animator.get_isRootPositionOrRotationControlledByCurvesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000288C File Offset: 0x00000A8C
		public float humanScale
		{
			get
			{
				return Animator.get_humanScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000289E File Offset: 0x00000A9E
		public bool isInitialized
		{
			get
			{
				return Animator.get_isInitializedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00008764 File Offset: 0x00006964
		public float GetFloat(string name)
		{
			return this.GetFloatString(name);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00008780 File Offset: 0x00006980
		public float GetFloat(int id)
		{
			return this.GetFloatID(id);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000028B0 File Offset: 0x00000AB0
		public void SetFloat(string name, float value, float dampTime, float deltaTime)
		{
			this.SetFloatStringDamp(name, value, dampTime, deltaTime);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000028BF File Offset: 0x00000ABF
		public void SetFloat(int id, float value)
		{
			this.SetFloatID(id, value);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000028CB File Offset: 0x00000ACB
		public void SetFloat(int id, float value, float dampTime, float deltaTime)
		{
			this.SetFloatIDDamp(id, value, dampTime, deltaTime);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000879C File Offset: 0x0000699C
		public bool GetBool(string name)
		{
			return this.GetBoolString(name);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000087B8 File Offset: 0x000069B8
		public bool GetBool(int id)
		{
			return this.GetBoolID(id);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000028DA File Offset: 0x00000ADA
		public void SetBool(string name, bool value)
		{
			this.SetBoolString(name, value);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000087D4 File Offset: 0x000069D4
		public int GetInteger(string name)
		{
			return this.GetIntegerString(name);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000087F0 File Offset: 0x000069F0
		public int GetInteger(int id)
		{
			return this.GetIntegerID(id);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000028E6 File Offset: 0x00000AE6
		public void SetInteger(string name, int value)
		{
			this.SetIntegerString(name, value);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000028F2 File Offset: 0x00000AF2
		public void SetInteger(int id, int value)
		{
			this.SetIntegerID(id, value);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000028FE File Offset: 0x00000AFE
		public void SetTrigger(int id)
		{
			this.SetTriggerID(id);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002909 File Offset: 0x00000B09
		public void ResetTrigger(int id)
		{
			this.ResetTriggerID(id);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000880C File Offset: 0x00006A0C
		public bool IsParameterControlledByCurve(string name)
		{
			return this.IsParameterControlledByCurveString(name);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00008828 File Offset: 0x00006A28
		public bool IsParameterControlledByCurve(int id)
		{
			return this.IsParameterControlledByCurveID(id);
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00008844 File Offset: 0x00006A44
		public Vector3 deltaPosition
		{
			get
			{
				Vector3 vector;
				this.get_deltaPosition_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000885C File Offset: 0x00006A5C
		public Quaternion deltaRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_deltaRotation_Injected(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00008874 File Offset: 0x00006A74
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000888C File Offset: 0x00006A8C
		public Vector3 angularVelocity
		{
			get
			{
				Vector3 vector;
				this.get_angularVelocity_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000088A4 File Offset: 0x00006AA4
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002914 File Offset: 0x00000B14
		public Vector3 rootPosition
		{
			get
			{
				Vector3 vector;
				this.get_rootPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_rootPosition_Injected(ref value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000088BC File Offset: 0x00006ABC
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000291E File Offset: 0x00000B1E
		public Quaternion rootRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_rootRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_rootRotation_Injected(ref value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002928 File Offset: 0x00000B28
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000293A File Offset: 0x00000B3A
		public bool applyRootMotion
		{
			get
			{
				return Animator.get_applyRootMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_applyRootMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000294D File Offset: 0x00000B4D
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000295F File Offset: 0x00000B5F
		public bool linearVelocityBlending
		{
			get
			{
				return Animator.get_linearVelocityBlendingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_linearVelocityBlendingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000088D4 File Offset: 0x00006AD4
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00002972 File Offset: 0x00000B72
		public bool animatePhysics
		{
			get
			{
				return this.updateMode == AnimatorUpdateMode.AnimatePhysics;
			}
			set
			{
				this.updateMode = (value ? AnimatorUpdateMode.AnimatePhysics : AnimatorUpdateMode.Normal);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00002983 File Offset: 0x00000B83
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002995 File Offset: 0x00000B95
		public AnimatorUpdateMode updateMode
		{
			get
			{
				return Animator.get_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000029A8 File Offset: 0x00000BA8
		public bool hasTransformHierarchy
		{
			get
			{
				return Animator.get_hasTransformHierarchyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000029BA File Offset: 0x00000BBA
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000029CC File Offset: 0x00000BCC
		public bool allowConstantClipSamplingOptimization
		{
			get
			{
				return Animator.get_allowConstantClipSamplingOptimizationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_allowConstantClipSamplingOptimizationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000029DF File Offset: 0x00000BDF
		public float gravityWeight
		{
			get
			{
				return Animator.get_gravityWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000088F0 File Offset: 0x00006AF0
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000029F1 File Offset: 0x00000BF1
		public Vector3 bodyPosition
		{
			get
			{
				this.CheckIfInIKPass();
				return this.bodyPositionInternal;
			}
			set
			{
				this.CheckIfInIKPass();
				this.bodyPositionInternal = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00008910 File Offset: 0x00006B10
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002A03 File Offset: 0x00000C03
		public Vector3 bodyPositionInternal
		{
			get
			{
				Vector3 vector;
				this.get_bodyPositionInternal_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_bodyPositionInternal_Injected(ref value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00008928 File Offset: 0x00006B28
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00002A0D File Offset: 0x00000C0D
		public Quaternion bodyRotation
		{
			get
			{
				this.CheckIfInIKPass();
				return this.bodyRotationInternal;
			}
			set
			{
				this.CheckIfInIKPass();
				this.bodyRotationInternal = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00008948 File Offset: 0x00006B48
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002A1F File Offset: 0x00000C1F
		public Quaternion bodyRotationInternal
		{
			get
			{
				Quaternion quaternion;
				this.get_bodyRotationInternal_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_bodyRotationInternal_Injected(ref value);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00008960 File Offset: 0x00006B60
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetGoalPosition(goal);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00008980 File Offset: 0x00006B80
		public Vector3 GetGoalPosition(AvatarIKGoal goal)
		{
			Vector3 vector;
			this.GetGoalPosition_Injected(goal, out vector);
			return vector;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002A29 File Offset: 0x00000C29
		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition)
		{
			this.CheckIfInIKPass();
			this.SetGoalPosition(goal, goalPosition);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002A3C File Offset: 0x00000C3C
		public void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition)
		{
			this.SetGoalPosition_Injected(goal, ref goalPosition);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00008998 File Offset: 0x00006B98
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetGoalRotation(goal);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000089B8 File Offset: 0x00006BB8
		public Quaternion GetGoalRotation(AvatarIKGoal goal)
		{
			Quaternion quaternion;
			this.GetGoalRotation_Injected(goal, out quaternion);
			return quaternion;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002A47 File Offset: 0x00000C47
		public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation)
		{
			this.CheckIfInIKPass();
			this.SetGoalRotation(goal, goalRotation);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002A5A File Offset: 0x00000C5A
		public void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation)
		{
			this.SetGoalRotation_Injected(goal, ref goalRotation);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000089D0 File Offset: 0x00006BD0
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetGoalWeightPosition(goal);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002A65 File Offset: 0x00000C65
		public float GetGoalWeightPosition(AvatarIKGoal goal)
		{
			return Animator.GetGoalWeightPositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002A78 File Offset: 0x00000C78
		public void SetIKPositionWeight(AvatarIKGoal goal, float value)
		{
			this.CheckIfInIKPass();
			this.SetGoalWeightPosition(goal, value);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002A8B File Offset: 0x00000C8B
		public void SetGoalWeightPosition(AvatarIKGoal goal, float value)
		{
			Animator.SetGoalWeightPositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, value);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000089F0 File Offset: 0x00006BF0
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetGoalWeightRotation(goal);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002A9F File Offset: 0x00000C9F
		public float GetGoalWeightRotation(AvatarIKGoal goal)
		{
			return Animator.GetGoalWeightRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public void SetIKRotationWeight(AvatarIKGoal goal, float value)
		{
			this.CheckIfInIKPass();
			this.SetGoalWeightRotation(goal, value);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public void SetGoalWeightRotation(AvatarIKGoal goal, float value)
		{
			Animator.SetGoalWeightRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, value);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00008A10 File Offset: 0x00006C10
		public Vector3 GetIKHintPosition(AvatarIKHint hint)
		{
			this.CheckIfInIKPass();
			return this.GetHintPosition(hint);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00008A30 File Offset: 0x00006C30
		public Vector3 GetHintPosition(AvatarIKHint hint)
		{
			Vector3 vector;
			this.GetHintPosition_Injected(hint, out vector);
			return vector;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002AD9 File Offset: 0x00000CD9
		public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition)
		{
			this.CheckIfInIKPass();
			this.SetHintPosition(hint, hintPosition);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002AEC File Offset: 0x00000CEC
		public void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition)
		{
			this.SetHintPosition_Injected(hint, ref hintPosition);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00008A48 File Offset: 0x00006C48
		public float GetIKHintPositionWeight(AvatarIKHint hint)
		{
			this.CheckIfInIKPass();
			return this.GetHintWeightPosition(hint);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002AF7 File Offset: 0x00000CF7
		public float GetHintWeightPosition(AvatarIKHint hint)
		{
			return Animator.GetHintWeightPositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), hint);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002B0A File Offset: 0x00000D0A
		public void SetIKHintPositionWeight(AvatarIKHint hint, float value)
		{
			this.CheckIfInIKPass();
			this.SetHintWeightPosition(hint, value);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002B1D File Offset: 0x00000D1D
		public void SetHintWeightPosition(AvatarIKHint hint, float value)
		{
			Animator.SetHintWeightPositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), hint, value);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002B31 File Offset: 0x00000D31
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
			this.CheckIfInIKPass();
			this.SetLookAtPositionInternal(lookAtPosition);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002B43 File Offset: 0x00000D43
		public void SetLookAtPositionInternal(Vector3 lookAtPosition)
		{
			this.SetLookAtPositionInternal_Injected(ref lookAtPosition);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002B4D File Offset: 0x00000D4D
		public void SetLookAtWeight(float weight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, 0f, 1f, 0f, 0.5f);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002B73 File Offset: 0x00000D73
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, bodyWeight, 1f, 0f, 0.5f);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002B95 File Offset: 0x00000D95
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, 0f, 0.5f);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002BB3 File Offset: 0x00000DB3
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, 0.5f);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002BCE File Offset: 0x00000DCE
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002BE6 File Offset: 0x00000DE6
		public void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
			Animator.SetLookAtWeightInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002BFF File Offset: 0x00000DFF
		public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation)
		{
			this.CheckIfInIKPass();
			this.SetBoneLocalRotationInternal(HumanTrait.GetBoneIndexFromMono((int)humanBoneId), rotation);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002C17 File Offset: 0x00000E17
		public void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation)
		{
			this.SetBoneLocalRotationInternal_Injected(humanBoneId, ref rotation);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00008A68 File Offset: 0x00006C68
		public ScriptableObject GetBehaviour(Type type)
		{
			IntPtr intPtr = Animator.GetBehaviourDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00008A9C File Offset: 0x00006C9C
		public T GetBehaviour<T>() where T : StateMachineBehaviour
		{
			return this.GetBehaviour(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())).TryCast<T>().Cast<T>();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002C22 File Offset: 0x00000E22
		public static Il2CppArrayBase<T> ConvertStateMachineBehaviour<T>(Il2CppReferenceArray<ScriptableObject> rawObjects) where T : StateMachineBehaviour
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00008AC8 File Offset: 0x00006CC8
		public Il2CppArrayBase<T> GetBehaviours<T>() where T : StateMachineBehaviour
		{
			return Animator.ConvertStateMachineBehaviour<T>(this.InternalGetBehaviours(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00008AF0 File Offset: 0x00006CF0
		public Il2CppReferenceArray<ScriptableObject> InternalGetBehaviours(Type type)
		{
			IntPtr intPtr = Animator.InternalGetBehavioursDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableObject>>(intPtr2) : null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00008B24 File Offset: 0x00006D24
		public Il2CppReferenceArray<StateMachineBehaviour> GetBehaviours(int fullPathHash, int layerIndex)
		{
			return this.InternalGetBehavioursByKey(fullPathHash, layerIndex, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<StateMachineBehaviour>())).TryCast<Il2CppReferenceArray<StateMachineBehaviour>>();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00008B50 File Offset: 0x00006D50
		public Il2CppReferenceArray<ScriptableObject> InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type)
		{
			IntPtr intPtr = Animator.InternalGetBehavioursByKeyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), fullPathHash, layerIndex, IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableObject>>(intPtr2) : null;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002C2F File Offset: 0x00000E2F
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002C41 File Offset: 0x00000E41
		public bool stabilizeFeet
		{
			get
			{
				return Animator.get_stabilizeFeetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_stabilizeFeetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00002C54 File Offset: 0x00000E54
		public int layerCount
		{
			get
			{
				return Animator.get_layerCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00008B84 File Offset: 0x00006D84
		public string GetLayerName(int layerIndex)
		{
			IntPtr intPtr = Animator.GetLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002C66 File Offset: 0x00000E66
		public int GetLayerIndex(string layerName)
		{
			return Animator.GetLayerIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(layerName));
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002C7E File Offset: 0x00000E7E
		public float GetLayerWeight(int layerIndex)
		{
			return Animator.GetLayerWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002C91 File Offset: 0x00000E91
		public void SetLayerWeight(int layerIndex, float weight)
		{
			Animator.SetLayerWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, weight);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00008BAC File Offset: 0x00006DAC
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
		{
			AnimatorStateInfo animatorStateInfo;
			this.GetAnimatorStateInfo(layerIndex, StateInfoIndex.NextState, out animatorStateInfo);
			return animatorStateInfo;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002CA5 File Offset: 0x00000EA5
		public void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info)
		{
			Animator.GetAnimatorTransitionInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, out info);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00008BCC File Offset: 0x00006DCC
		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			this.GetAnimatorTransitionInfo(layerIndex, out animatorTransitionInfo);
			return animatorTransitionInfo;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002CB9 File Offset: 0x00000EB9
		public int GetAnimatorClipInfoCount(int layerIndex, bool current)
		{
			return Animator.GetAnimatorClipInfoCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, current);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00008BEC File Offset: 0x00006DEC
		public int GetCurrentAnimatorClipInfoCount(int layerIndex)
		{
			return this.GetAnimatorClipInfoCount(layerIndex, true);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00008C08 File Offset: 0x00006E08
		public int GetNextAnimatorClipInfoCount(int layerIndex)
		{
			return this.GetAnimatorClipInfoCount(layerIndex, false);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00008C24 File Offset: 0x00006E24
		public Il2CppStructArray<AnimatorClipInfo> GetCurrentAnimatorClipInfo(int layerIndex)
		{
			IntPtr intPtr = Animator.GetCurrentAnimatorClipInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AnimatorClipInfo>>(intPtr2) : null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00008C54 File Offset: 0x00006E54
		public Il2CppStructArray<AnimatorClipInfo> GetNextAnimatorClipInfo(int layerIndex)
		{
			IntPtr intPtr = Animator.GetNextAnimatorClipInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AnimatorClipInfo>>(intPtr2) : null;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00008C84 File Offset: 0x00006E84
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			bool flag = clips == null;
			if (flag)
			{
				throw new ArgumentNullException("clips");
			}
			this.GetAnimatorClipInfoInternal(layerIndex, true, clips);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002CCD File Offset: 0x00000ECD
		public void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, Object clips)
		{
			Animator.GetAnimatorClipInfoInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, isCurrent, IL2CPP.Il2CppObjectBaseToPtr(clips));
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00008CB0 File Offset: 0x00006EB0
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			bool flag = clips == null;
			if (flag)
			{
				throw new ArgumentNullException("clips");
			}
			this.GetAnimatorClipInfoInternal(layerIndex, false, clips);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002CE7 File Offset: 0x00000EE7
		public bool IsInTransition(int layerIndex)
		{
			return Animator.IsInTransitionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00008CDC File Offset: 0x00006EDC
		public Il2CppReferenceArray<AnimatorControllerParameter> parameters
		{
			get
			{
				IntPtr intPtr = Animator.get_parametersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimatorControllerParameter>>(intPtr2) : null;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002CFA File Offset: 0x00000EFA
		public int parameterCount
		{
			get
			{
				return Animator.get_parameterCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00008D08 File Offset: 0x00006F08
		public AnimatorControllerParameter GetParameterInternal(int index)
		{
			IntPtr intPtr = Animator.GetParameterInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatorControllerParameter>(intPtr2) : null;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002D0C File Offset: 0x00000F0C
		public AnimatorControllerParameter GetParameter(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00002D19 File Offset: 0x00000F19
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00002D2B File Offset: 0x00000F2B
		public float feetPivotActive
		{
			get
			{
				return Animator.get_feetPivotActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_feetPivotActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002D3E File Offset: 0x00000F3E
		public float pivotWeight
		{
			get
			{
				return Animator.get_pivotWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00008D38 File Offset: 0x00006F38
		public Vector3 pivotPosition
		{
			get
			{
				Vector3 vector;
				this.get_pivotPosition_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002D50 File Offset: 0x00000F50
		public void InterruptMatchTarget()
		{
			this.InterruptMatchTarget(true);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002D5B File Offset: 0x00000F5B
		public void InterruptMatchTarget(bool completeMatch)
		{
			Animator.InterruptMatchTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), completeMatch);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002D6E File Offset: 0x00000F6E
		public bool isMatchingTarget
		{
			get
			{
				return Animator.get_isMatchingTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00002D80 File Offset: 0x00000F80
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002D92 File Offset: 0x00000F92
		public float speed
		{
			get
			{
				return Animator.get_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002DA5 File Offset: 0x00000FA5
		public void ForceStateNormalizedTime(float normalizedTime)
		{
			this.Play(0, 0, normalizedTime);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008D50 File Offset: 0x00006F50
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration)
		{
			float num = 0f;
			float num2 = 0f;
			int num3 = -1;
			this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, num3, num2, num);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00008D80 File Offset: 0x00006F80
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer)
		{
			float num = 0f;
			float num2 = 0f;
			this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, layer, num2, num);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00008DAC File Offset: 0x00006FAC
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset)
		{
			float num = 0f;
			this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, layer, fixedTimeOffset, num);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002DB2 File Offset: 0x00000FB2
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime)
		{
			this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00008DD4 File Offset: 0x00006FD4
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset)
		{
			float num = 0f;
			this.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset, num);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00008DF8 File Offset: 0x00006FF8
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer)
		{
			float num = 0f;
			float num2 = 0f;
			this.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, num2, num);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008E20 File Offset: 0x00007020
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration)
		{
			float num = 0f;
			float num2 = 0f;
			int num3 = -1;
			this.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, num3, num2, num);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002DC8 File Offset: 0x00000FC8
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime)
		{
			Animator.CrossFadeInFixedTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stateHashName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002DE1 File Offset: 0x00000FE1
		public void WriteDefaultValues()
		{
			Animator.WriteDefaultValuesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00008E48 File Offset: 0x00007048
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
		{
			float num = 0f;
			this.CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, num);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00008E6C File Offset: 0x0000706C
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer)
		{
			float num = 0f;
			float negativeInfinity = float.NegativeInfinity;
			this.CrossFade(stateName, normalizedTransitionDuration, layer, negativeInfinity, num);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00008E94 File Offset: 0x00007094
		public void CrossFade(string stateName, float normalizedTransitionDuration)
		{
			float num = 0f;
			float negativeInfinity = float.NegativeInfinity;
			int num2 = -1;
			this.CrossFade(stateName, normalizedTransitionDuration, num2, negativeInfinity, num);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002DF3 File Offset: 0x00000FF3
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime)
		{
			this.CrossFade(Animator.StringToHash(stateName), normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002E09 File Offset: 0x00001009
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime)
		{
			Animator.CrossFadeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00008EBC File Offset: 0x000070BC
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
		{
			float num = 0f;
			this.CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, num);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00008EE0 File Offset: 0x000070E0
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer)
		{
			float num = 0f;
			float negativeInfinity = float.NegativeInfinity;
			this.CrossFade(stateHashName, normalizedTransitionDuration, layer, negativeInfinity, num);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00008F08 File Offset: 0x00007108
		public void CrossFade(int stateHashName, float normalizedTransitionDuration)
		{
			float num = 0f;
			float negativeInfinity = float.NegativeInfinity;
			int num2 = -1;
			this.CrossFade(stateHashName, normalizedTransitionDuration, num2, negativeInfinity, num);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00008F30 File Offset: 0x00007130
		public void PlayInFixedTime(string stateName, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.PlayInFixedTime(stateName, layer, negativeInfinity);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00008F50 File Offset: 0x00007150
		public void PlayInFixedTime(string stateName)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.PlayInFixedTime(stateName, num, negativeInfinity);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002E22 File Offset: 0x00001022
		public void PlayInFixedTime(string stateName, int layer, float fixedTime)
		{
			this.PlayInFixedTime(Animator.StringToHash(stateName), layer, fixedTime);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002E34 File Offset: 0x00001034
		public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime)
		{
			Animator.PlayInFixedTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stateNameHash, layer, fixedTime);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00008F70 File Offset: 0x00007170
		public void PlayInFixedTime(int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.PlayInFixedTime(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00008F90 File Offset: 0x00007190
		public void PlayInFixedTime(int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.PlayInFixedTime(stateNameHash, num, negativeInfinity);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00008FB0 File Offset: 0x000071B0
		public void Play(string stateName, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.Play(stateName, layer, negativeInfinity);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00008FD0 File Offset: 0x000071D0
		public void Play(int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.Play(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00008FF0 File Offset: 0x000071F0
		public void Play(int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.Play(stateNameHash, num, negativeInfinity);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002E49 File Offset: 0x00001049
		public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime)
		{
			Animator.SetTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), targetIndex, targetNormalizedTime);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00009010 File Offset: 0x00007210
		public Vector3 targetPosition
		{
			get
			{
				Vector3 vector;
				this.get_targetPosition_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00009028 File Offset: 0x00007228
		public Quaternion targetRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_targetRotation_Injected(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00009040 File Offset: 0x00007240
		public bool IsControlled(Transform transform)
		{
			return false;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002E5D File Offset: 0x0000105D
		public bool IsBoneTransform(Transform transform)
		{
			return Animator.IsBoneTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform));
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00009054 File Offset: 0x00007254
		public Transform avatarRoot
		{
			get
			{
				IntPtr intPtr = Animator.get_avatarRootDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00009080 File Offset: 0x00007280
		public Transform GetBoneTransform(HumanBodyBones humanBoneId)
		{
			bool flag = humanBoneId < HumanBodyBones.Hips || humanBoneId >= HumanBodyBones.LastBone;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Concat("humanBoneId must be between 0 and ", HumanBodyBones.LastBone.ToString()));
			}
			return this.GetBoneTransformInternal(HumanTrait.GetBoneIndexFromMono((int)humanBoneId));
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000090D4 File Offset: 0x000072D4
		public Transform GetBoneTransformInternal(int humanBoneId)
		{
			IntPtr intPtr = Animator.GetBoneTransformInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanBoneId);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00002E75 File Offset: 0x00001075
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002E87 File Offset: 0x00001087
		public AnimatorCullingMode cullingMode
		{
			get
			{
				return Animator.get_cullingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_cullingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002E9A File Offset: 0x0000109A
		public void StartPlayback()
		{
			Animator.StartPlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002EAC File Offset: 0x000010AC
		public void StopPlayback()
		{
			Animator.StopPlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002EBE File Offset: 0x000010BE
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002ED0 File Offset: 0x000010D0
		public float playbackTime
		{
			get
			{
				return Animator.get_playbackTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_playbackTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002EE3 File Offset: 0x000010E3
		public void StartRecording(int frameCount)
		{
			Animator.StartRecordingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), frameCount);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002EF6 File Offset: 0x000010F6
		public void StopRecording()
		{
			Animator.StopRecordingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00009104 File Offset: 0x00007304
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002F08 File Offset: 0x00001108
		public float recorderStartTime
		{
			get
			{
				return this.GetRecorderStartTime();
			}
			set
			{
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002F0B File Offset: 0x0000110B
		public float GetRecorderStartTime()
		{
			return Animator.GetRecorderStartTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000911C File Offset: 0x0000731C
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002F1D File Offset: 0x0000111D
		public float recorderStopTime
		{
			get
			{
				return this.GetRecorderStopTime();
			}
			set
			{
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002F20 File Offset: 0x00001120
		public float GetRecorderStopTime()
		{
			return Animator.GetRecorderStopTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00002F32 File Offset: 0x00001132
		public AnimatorRecorderMode recorderMode
		{
			get
			{
				return Animator.get_recorderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002F44 File Offset: 0x00001144
		public void ClearInternalControllerPlayable()
		{
			Animator.ClearInternalControllerPlayableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002F56 File Offset: 0x00001156
		public bool HasState(int layerIndex, int stateID)
		{
			return Animator.HasStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, stateID);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00009134 File Offset: 0x00007334
		public string GetStats()
		{
			IntPtr intPtr = Animator.GetStatsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00009158 File Offset: 0x00007358
		public PlayableGraph playableGraph
		{
			get
			{
				PlayableGraph playableGraph = default(PlayableGraph);
				this.GetCurrentGraph(ref playableGraph);
				return playableGraph;
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002F82 File Offset: 0x00001182
		public void GetCurrentGraph(ref PlayableGraph graph)
		{
			Animator.GetCurrentGraphDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref graph);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000917C File Offset: 0x0000737C
		public void CheckIfInIKPass()
		{
			bool flag = this.logWarnings && !this.IsInIKPass();
			if (flag)
			{
				Debug.LogWarning("Setting and getting Body Position/Rotation, IK Goals, Lookat and BoneLocalRotation should only be done in OnAnimatorIK or OnStateIK");
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002F95 File Offset: 0x00001195
		public bool IsInIKPass()
		{
			return Animator.IsInIKPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002FA7 File Offset: 0x000011A7
		public void SetFloatID(int id, float value)
		{
			Animator.SetFloatIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id, value);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002FBB File Offset: 0x000011BB
		public float GetFloatString(string name)
		{
			return Animator.GetFloatStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002FD3 File Offset: 0x000011D3
		public float GetFloatID(int id)
		{
			return Animator.GetFloatIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002FE6 File Offset: 0x000011E6
		public void SetBoolString(string name, bool value)
		{
			Animator.SetBoolStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002FFF File Offset: 0x000011FF
		public bool GetBoolString(string name)
		{
			return Animator.GetBoolStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00003017 File Offset: 0x00001217
		public bool GetBoolID(int id)
		{
			return Animator.GetBoolIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000302A File Offset: 0x0000122A
		public void SetIntegerString(string name, int value)
		{
			Animator.SetIntegerStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00003043 File Offset: 0x00001243
		public void SetIntegerID(int id, int value)
		{
			Animator.SetIntegerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id, value);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00003057 File Offset: 0x00001257
		public int GetIntegerString(string name)
		{
			return Animator.GetIntegerStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000306F File Offset: 0x0000126F
		public int GetIntegerID(int id)
		{
			return Animator.GetIntegerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00003082 File Offset: 0x00001282
		public void SetTriggerID(int id)
		{
			Animator.SetTriggerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00003095 File Offset: 0x00001295
		public void ResetTriggerID(int id)
		{
			Animator.ResetTriggerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000030A8 File Offset: 0x000012A8
		public bool IsParameterControlledByCurveString(string name)
		{
			return Animator.IsParameterControlledByCurveStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000030C0 File Offset: 0x000012C0
		public bool IsParameterControlledByCurveID(int id)
		{
			return Animator.IsParameterControlledByCurveIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000030D3 File Offset: 0x000012D3
		public void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime)
		{
			Animator.SetFloatStringDampDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), value, dampTime, deltaTime);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000030EF File Offset: 0x000012EF
		public void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime)
		{
			Animator.SetFloatIDDampDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), id, value, dampTime, deltaTime);
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00003106 File Offset: 0x00001306
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00003118 File Offset: 0x00001318
		public bool layersAffectMassCenter
		{
			get
			{
				return Animator.get_layersAffectMassCenterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_layersAffectMassCenterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000312B File Offset: 0x0000132B
		public float leftFeetBottomHeight
		{
			get
			{
				return Animator.get_leftFeetBottomHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000313D File Offset: 0x0000133D
		public float rightFeetBottomHeight
		{
			get
			{
				return Animator.get_rightFeetBottomHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000314F File Offset: 0x0000134F
		public bool supportsOnAnimatorMove
		{
			get
			{
				return Animator.get_supportsOnAnimatorMoveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00003161 File Offset: 0x00001361
		public void OnUpdateModeChanged()
		{
			Animator.OnUpdateModeChangedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00003173 File Offset: 0x00001373
		public void OnCullingModeChanged()
		{
			Animator.OnCullingModeChangedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00003185 File Offset: 0x00001385
		public void WriteDefaultPose()
		{
			Animator.WriteDefaultPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00003197 File Offset: 0x00001397
		public void Update(float deltaTime)
		{
			Animator.UpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), deltaTime);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000031AA File Offset: 0x000013AA
		public void Rebind()
		{
			this.Rebind(true);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000031B5 File Offset: 0x000013B5
		public void Rebind(bool writeDefaultValues)
		{
			Animator.RebindDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), writeDefaultValues);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000031C8 File Offset: 0x000013C8
		public void ApplyBuiltinRootMotion()
		{
			Animator.ApplyBuiltinRootMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000031DA File Offset: 0x000013DA
		public void EvaluateController()
		{
			this.EvaluateController(0f);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000031E9 File Offset: 0x000013E9
		public void EvaluateController(float deltaTime)
		{
			Animator.EvaluateControllerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), deltaTime);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000091B0 File Offset: 0x000073B0
		public string GetCurrentStateName(int layerIndex)
		{
			return this.GetAnimatorStateName(layerIndex, true);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000091CC File Offset: 0x000073CC
		public string GetNextStateName(int layerIndex)
		{
			return this.GetAnimatorStateName(layerIndex, false);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000091E8 File Offset: 0x000073E8
		public string GetAnimatorStateName(int layerIndex, bool current)
		{
			IntPtr intPtr = Animator.GetAnimatorStateNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerIndex, current);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00009210 File Offset: 0x00007410
		public string ResolveHash(int hash)
		{
			IntPtr intPtr = Animator.ResolveHashDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), hash);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000031FC File Offset: 0x000013FC
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0000320E File Offset: 0x0000140E
		public bool logWarnings
		{
			get
			{
				return Animator.get_logWarningsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_logWarningsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00003221 File Offset: 0x00001421
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00003233 File Offset: 0x00001433
		public bool fireEvents
		{
			get
			{
				return Animator.get_fireEventsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_fireEventsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00009238 File Offset: 0x00007438
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00003246 File Offset: 0x00001446
		public bool keepAnimatorControllerStateOnDisable
		{
			get
			{
				return this.keepAnimatorStateOnDisable;
			}
			set
			{
				this.keepAnimatorStateOnDisable = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00003251 File Offset: 0x00001451
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00003263 File Offset: 0x00001463
		public bool keepAnimatorStateOnDisable
		{
			get
			{
				return Animator.get_keepAnimatorStateOnDisableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_keepAnimatorStateOnDisableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00003276 File Offset: 0x00001476
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00003288 File Offset: 0x00001488
		public bool writeDefaultValuesOnDisable
		{
			get
			{
				return Animator.get_writeDefaultValuesOnDisableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animator.set_writeDefaultValuesOnDisableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00009250 File Offset: 0x00007450
		public Vector3 GetVector(string name)
		{
			return Vector3.zero;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00009268 File Offset: 0x00007468
		public Vector3 GetVector(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000329B File Offset: 0x0000149B
		public void SetVector(string name, Vector3 value)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000329E File Offset: 0x0000149E
		public void SetVector(int id, Vector3 value)
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00009280 File Offset: 0x00007480
		public Quaternion GetQuaternion(string name)
		{
			return Quaternion.identity;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00009298 File Offset: 0x00007498
		public Quaternion GetQuaternion(int id)
		{
			return Quaternion.identity;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000032A1 File Offset: 0x000014A1
		public void SetQuaternion(string name, Quaternion value)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000032A4 File Offset: 0x000014A4
		public void SetQuaternion(int id, Quaternion value)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000032A7 File Offset: 0x000014A7
		public void get_deltaPosition_Injected(out Vector3 ret)
		{
			Animator.get_deltaPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000032BA File Offset: 0x000014BA
		public void get_deltaRotation_Injected(out Quaternion ret)
		{
			Animator.get_deltaRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000032CD File Offset: 0x000014CD
		public void get_velocity_Injected(out Vector3 ret)
		{
			Animator.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000032E0 File Offset: 0x000014E0
		public void get_angularVelocity_Injected(out Vector3 ret)
		{
			Animator.get_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000032F3 File Offset: 0x000014F3
		public void get_rootPosition_Injected(out Vector3 ret)
		{
			Animator.get_rootPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00003306 File Offset: 0x00001506
		public void set_rootPosition_Injected(ref Vector3 value)
		{
			Animator.set_rootPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00003319 File Offset: 0x00001519
		public void get_rootRotation_Injected(out Quaternion ret)
		{
			Animator.get_rootRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000332C File Offset: 0x0000152C
		public void set_rootRotation_Injected(ref Quaternion value)
		{
			Animator.set_rootRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000333F File Offset: 0x0000153F
		public void get_bodyPositionInternal_Injected(out Vector3 ret)
		{
			Animator.get_bodyPositionInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00003352 File Offset: 0x00001552
		public void set_bodyPositionInternal_Injected(ref Vector3 value)
		{
			Animator.set_bodyPositionInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00003365 File Offset: 0x00001565
		public void get_bodyRotationInternal_Injected(out Quaternion ret)
		{
			Animator.get_bodyRotationInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00003378 File Offset: 0x00001578
		public void set_bodyRotationInternal_Injected(ref Quaternion value)
		{
			Animator.set_bodyRotationInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000338B File Offset: 0x0000158B
		public void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret)
		{
			Animator.GetGoalPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, out ret);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000339F File Offset: 0x0000159F
		public void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition)
		{
			Animator.SetGoalPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, ref goalPosition);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000033B3 File Offset: 0x000015B3
		public void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret)
		{
			Animator.GetGoalRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, out ret);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000033C7 File Offset: 0x000015C7
		public void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation)
		{
			Animator.SetGoalRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), goal, ref goalRotation);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000033DB File Offset: 0x000015DB
		public void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret)
		{
			Animator.GetHintPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), hint, out ret);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000033EF File Offset: 0x000015EF
		public void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition)
		{
			Animator.SetHintPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), hint, ref hintPosition);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00003403 File Offset: 0x00001603
		public void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition)
		{
			Animator.SetLookAtPositionInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref lookAtPosition);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00003416 File Offset: 0x00001616
		public void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation)
		{
			Animator.SetBoneLocalRotationInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanBoneId, ref rotation);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000342A File Offset: 0x0000162A
		public void get_pivotPosition_Injected(out Vector3 ret)
		{
			Animator.get_pivotPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000343D File Offset: 0x0000163D
		public void get_targetPosition_Injected(out Vector3 ret)
		{
			Animator.get_targetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00003450 File Offset: 0x00001650
		public void get_targetRotation_Injected(out Quaternion ret)
		{
			Animator.get_targetRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_get_isHuman_Public_get_Boolean_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_hasRootMotion_Public_get_Boolean_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Void_Int32_Boolean_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_SetTrigger_Public_Void_String_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimatorStateInfo_Private_Void_Int32_StateInfoIndex_byref_AnimatorStateInfo_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentAnimatorStateInfo_Public_AnimatorStateInfo_Int32_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_String_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_String_Int32_Single_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_Int32_Int32_Single_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_get_runtimeAnimatorController_Public_get_RuntimeAnimatorController_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_set_runtimeAnimatorController_Public_set_Void_RuntimeAnimatorController_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_get_hasBoundPlayables_Public_get_Boolean_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_StringToHash_Public_Static_Int32_String_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_get_avatar_Public_get_Avatar_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatString_Private_Void_String_Single_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_SetBoolID_Private_Void_Int32_Boolean_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_SetTriggerString_Private_Void_String_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_ResetTriggerString_Private_Void_String_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000BA RID: 186
		private static readonly Animator.get_isOptimizableDelegate get_isOptimizableDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly Animator.get_isRootPositionOrRotationControlledByCurvesDelegate get_isRootPositionOrRotationControlledByCurvesDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly Animator.get_humanScaleDelegate get_humanScaleDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly Animator.get_isInitializedDelegate get_isInitializedDelegateField;

		// Token: 0x040000BE RID: 190
		private static readonly Animator.get_applyRootMotionDelegate get_applyRootMotionDelegateField;

		// Token: 0x040000BF RID: 191
		private static readonly Animator.set_applyRootMotionDelegate set_applyRootMotionDelegateField;

		// Token: 0x040000C0 RID: 192
		private static readonly Animator.get_linearVelocityBlendingDelegate get_linearVelocityBlendingDelegateField;

		// Token: 0x040000C1 RID: 193
		private static readonly Animator.set_linearVelocityBlendingDelegate set_linearVelocityBlendingDelegateField;

		// Token: 0x040000C2 RID: 194
		private static readonly Animator.get_updateModeDelegate get_updateModeDelegateField;

		// Token: 0x040000C3 RID: 195
		private static readonly Animator.set_updateModeDelegate set_updateModeDelegateField;

		// Token: 0x040000C4 RID: 196
		private static readonly Animator.get_hasTransformHierarchyDelegate get_hasTransformHierarchyDelegateField;

		// Token: 0x040000C5 RID: 197
		private static readonly Animator.get_allowConstantClipSamplingOptimizationDelegate get_allowConstantClipSamplingOptimizationDelegateField;

		// Token: 0x040000C6 RID: 198
		private static readonly Animator.set_allowConstantClipSamplingOptimizationDelegate set_allowConstantClipSamplingOptimizationDelegateField;

		// Token: 0x040000C7 RID: 199
		private static readonly Animator.get_gravityWeightDelegate get_gravityWeightDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly Animator.GetGoalWeightPositionDelegate GetGoalWeightPositionDelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly Animator.SetGoalWeightPositionDelegate SetGoalWeightPositionDelegateField;

		// Token: 0x040000CA RID: 202
		private static readonly Animator.GetGoalWeightRotationDelegate GetGoalWeightRotationDelegateField;

		// Token: 0x040000CB RID: 203
		private static readonly Animator.SetGoalWeightRotationDelegate SetGoalWeightRotationDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly Animator.GetHintWeightPositionDelegate GetHintWeightPositionDelegateField;

		// Token: 0x040000CD RID: 205
		private static readonly Animator.SetHintWeightPositionDelegate SetHintWeightPositionDelegateField;

		// Token: 0x040000CE RID: 206
		private static readonly Animator.SetLookAtWeightInternalDelegate SetLookAtWeightInternalDelegateField;

		// Token: 0x040000CF RID: 207
		private static readonly Animator.GetBehaviourDelegate GetBehaviourDelegateField;

		// Token: 0x040000D0 RID: 208
		private static readonly Animator.InternalGetBehavioursDelegate InternalGetBehavioursDelegateField;

		// Token: 0x040000D1 RID: 209
		private static readonly Animator.InternalGetBehavioursByKeyDelegate InternalGetBehavioursByKeyDelegateField;

		// Token: 0x040000D2 RID: 210
		private static readonly Animator.get_stabilizeFeetDelegate get_stabilizeFeetDelegateField;

		// Token: 0x040000D3 RID: 211
		private static readonly Animator.set_stabilizeFeetDelegate set_stabilizeFeetDelegateField;

		// Token: 0x040000D4 RID: 212
		private static readonly Animator.get_layerCountDelegate get_layerCountDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly Animator.GetLayerNameDelegate GetLayerNameDelegateField;

		// Token: 0x040000D6 RID: 214
		private static readonly Animator.GetLayerIndexDelegate GetLayerIndexDelegateField;

		// Token: 0x040000D7 RID: 215
		private static readonly Animator.GetLayerWeightDelegate GetLayerWeightDelegateField;

		// Token: 0x040000D8 RID: 216
		private static readonly Animator.SetLayerWeightDelegate SetLayerWeightDelegateField;

		// Token: 0x040000D9 RID: 217
		private static readonly Animator.GetAnimatorTransitionInfoDelegate GetAnimatorTransitionInfoDelegateField;

		// Token: 0x040000DA RID: 218
		private static readonly Animator.GetAnimatorClipInfoCountDelegate GetAnimatorClipInfoCountDelegateField;

		// Token: 0x040000DB RID: 219
		private static readonly Animator.GetCurrentAnimatorClipInfoDelegate GetCurrentAnimatorClipInfoDelegateField;

		// Token: 0x040000DC RID: 220
		private static readonly Animator.GetNextAnimatorClipInfoDelegate GetNextAnimatorClipInfoDelegateField;

		// Token: 0x040000DD RID: 221
		private static readonly Animator.GetAnimatorClipInfoInternalDelegate GetAnimatorClipInfoInternalDelegateField;

		// Token: 0x040000DE RID: 222
		private static readonly Animator.IsInTransitionDelegate IsInTransitionDelegateField;

		// Token: 0x040000DF RID: 223
		private static readonly Animator.get_parametersDelegate get_parametersDelegateField;

		// Token: 0x040000E0 RID: 224
		private static readonly Animator.get_parameterCountDelegate get_parameterCountDelegateField;

		// Token: 0x040000E1 RID: 225
		private static readonly Animator.GetParameterInternalDelegate GetParameterInternalDelegateField;

		// Token: 0x040000E2 RID: 226
		private static readonly Animator.get_feetPivotActiveDelegate get_feetPivotActiveDelegateField;

		// Token: 0x040000E3 RID: 227
		private static readonly Animator.set_feetPivotActiveDelegate set_feetPivotActiveDelegateField;

		// Token: 0x040000E4 RID: 228
		private static readonly Animator.get_pivotWeightDelegate get_pivotWeightDelegateField;

		// Token: 0x040000E5 RID: 229
		private static readonly Animator.InterruptMatchTargetDelegate InterruptMatchTargetDelegateField;

		// Token: 0x040000E6 RID: 230
		private static readonly Animator.get_isMatchingTargetDelegate get_isMatchingTargetDelegateField;

		// Token: 0x040000E7 RID: 231
		private static readonly Animator.get_speedDelegate get_speedDelegateField;

		// Token: 0x040000E8 RID: 232
		private static readonly Animator.set_speedDelegate set_speedDelegateField;

		// Token: 0x040000E9 RID: 233
		private static readonly Animator.CrossFadeInFixedTimeDelegate CrossFadeInFixedTimeDelegateField;

		// Token: 0x040000EA RID: 234
		private static readonly Animator.WriteDefaultValuesDelegate WriteDefaultValuesDelegateField;

		// Token: 0x040000EB RID: 235
		private static readonly Animator.CrossFadeDelegate CrossFadeDelegateField;

		// Token: 0x040000EC RID: 236
		private static readonly Animator.PlayInFixedTimeDelegate PlayInFixedTimeDelegateField;

		// Token: 0x040000ED RID: 237
		private static readonly Animator.SetTargetDelegate SetTargetDelegateField;

		// Token: 0x040000EE RID: 238
		private static readonly Animator.IsBoneTransformDelegate IsBoneTransformDelegateField;

		// Token: 0x040000EF RID: 239
		private static readonly Animator.get_avatarRootDelegate get_avatarRootDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly Animator.GetBoneTransformInternalDelegate GetBoneTransformInternalDelegateField;

		// Token: 0x040000F1 RID: 241
		private static readonly Animator.get_cullingModeDelegate get_cullingModeDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly Animator.set_cullingModeDelegate set_cullingModeDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly Animator.StartPlaybackDelegate StartPlaybackDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly Animator.StopPlaybackDelegate StopPlaybackDelegateField;

		// Token: 0x040000F5 RID: 245
		private static readonly Animator.get_playbackTimeDelegate get_playbackTimeDelegateField;

		// Token: 0x040000F6 RID: 246
		private static readonly Animator.set_playbackTimeDelegate set_playbackTimeDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly Animator.StartRecordingDelegate StartRecordingDelegateField;

		// Token: 0x040000F8 RID: 248
		private static readonly Animator.StopRecordingDelegate StopRecordingDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly Animator.GetRecorderStartTimeDelegate GetRecorderStartTimeDelegateField;

		// Token: 0x040000FA RID: 250
		private static readonly Animator.GetRecorderStopTimeDelegate GetRecorderStopTimeDelegateField;

		// Token: 0x040000FB RID: 251
		private static readonly Animator.get_recorderModeDelegate get_recorderModeDelegateField;

		// Token: 0x040000FC RID: 252
		private static readonly Animator.ClearInternalControllerPlayableDelegate ClearInternalControllerPlayableDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly Animator.HasStateDelegate HasStateDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly Animator.set_avatarDelegate set_avatarDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly Animator.GetStatsDelegate GetStatsDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly Animator.GetCurrentGraphDelegate GetCurrentGraphDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly Animator.IsInIKPassDelegate IsInIKPassDelegateField;

		// Token: 0x04000102 RID: 258
		private static readonly Animator.SetFloatIDDelegate SetFloatIDDelegateField;

		// Token: 0x04000103 RID: 259
		private static readonly Animator.GetFloatStringDelegate GetFloatStringDelegateField;

		// Token: 0x04000104 RID: 260
		private static readonly Animator.GetFloatIDDelegate GetFloatIDDelegateField;

		// Token: 0x04000105 RID: 261
		private static readonly Animator.SetBoolStringDelegate SetBoolStringDelegateField;

		// Token: 0x04000106 RID: 262
		private static readonly Animator.GetBoolStringDelegate GetBoolStringDelegateField;

		// Token: 0x04000107 RID: 263
		private static readonly Animator.GetBoolIDDelegate GetBoolIDDelegateField;

		// Token: 0x04000108 RID: 264
		private static readonly Animator.SetIntegerStringDelegate SetIntegerStringDelegateField;

		// Token: 0x04000109 RID: 265
		private static readonly Animator.SetIntegerIDDelegate SetIntegerIDDelegateField;

		// Token: 0x0400010A RID: 266
		private static readonly Animator.GetIntegerStringDelegate GetIntegerStringDelegateField;

		// Token: 0x0400010B RID: 267
		private static readonly Animator.GetIntegerIDDelegate GetIntegerIDDelegateField;

		// Token: 0x0400010C RID: 268
		private static readonly Animator.SetTriggerIDDelegate SetTriggerIDDelegateField;

		// Token: 0x0400010D RID: 269
		private static readonly Animator.ResetTriggerIDDelegate ResetTriggerIDDelegateField;

		// Token: 0x0400010E RID: 270
		private static readonly Animator.IsParameterControlledByCurveStringDelegate IsParameterControlledByCurveStringDelegateField;

		// Token: 0x0400010F RID: 271
		private static readonly Animator.IsParameterControlledByCurveIDDelegate IsParameterControlledByCurveIDDelegateField;

		// Token: 0x04000110 RID: 272
		private static readonly Animator.SetFloatStringDampDelegate SetFloatStringDampDelegateField;

		// Token: 0x04000111 RID: 273
		private static readonly Animator.SetFloatIDDampDelegate SetFloatIDDampDelegateField;

		// Token: 0x04000112 RID: 274
		private static readonly Animator.get_layersAffectMassCenterDelegate get_layersAffectMassCenterDelegateField;

		// Token: 0x04000113 RID: 275
		private static readonly Animator.set_layersAffectMassCenterDelegate set_layersAffectMassCenterDelegateField;

		// Token: 0x04000114 RID: 276
		private static readonly Animator.get_leftFeetBottomHeightDelegate get_leftFeetBottomHeightDelegateField;

		// Token: 0x04000115 RID: 277
		private static readonly Animator.get_rightFeetBottomHeightDelegate get_rightFeetBottomHeightDelegateField;

		// Token: 0x04000116 RID: 278
		private static readonly Animator.get_supportsOnAnimatorMoveDelegate get_supportsOnAnimatorMoveDelegateField;

		// Token: 0x04000117 RID: 279
		private static readonly Animator.OnUpdateModeChangedDelegate OnUpdateModeChangedDelegateField;

		// Token: 0x04000118 RID: 280
		private static readonly Animator.OnCullingModeChangedDelegate OnCullingModeChangedDelegateField;

		// Token: 0x04000119 RID: 281
		private static readonly Animator.WriteDefaultPoseDelegate WriteDefaultPoseDelegateField;

		// Token: 0x0400011A RID: 282
		private static readonly Animator.UpdateDelegate UpdateDelegateField;

		// Token: 0x0400011B RID: 283
		private static readonly Animator.RebindDelegate RebindDelegateField;

		// Token: 0x0400011C RID: 284
		private static readonly Animator.ApplyBuiltinRootMotionDelegate ApplyBuiltinRootMotionDelegateField;

		// Token: 0x0400011D RID: 285
		private static readonly Animator.EvaluateControllerDelegate EvaluateControllerDelegateField;

		// Token: 0x0400011E RID: 286
		private static readonly Animator.GetAnimatorStateNameDelegate GetAnimatorStateNameDelegateField;

		// Token: 0x0400011F RID: 287
		private static readonly Animator.ResolveHashDelegate ResolveHashDelegateField;

		// Token: 0x04000120 RID: 288
		private static readonly Animator.get_logWarningsDelegate get_logWarningsDelegateField;

		// Token: 0x04000121 RID: 289
		private static readonly Animator.set_logWarningsDelegate set_logWarningsDelegateField;

		// Token: 0x04000122 RID: 290
		private static readonly Animator.get_fireEventsDelegate get_fireEventsDelegateField;

		// Token: 0x04000123 RID: 291
		private static readonly Animator.set_fireEventsDelegate set_fireEventsDelegateField;

		// Token: 0x04000124 RID: 292
		private static readonly Animator.get_keepAnimatorStateOnDisableDelegate get_keepAnimatorStateOnDisableDelegateField;

		// Token: 0x04000125 RID: 293
		private static readonly Animator.set_keepAnimatorStateOnDisableDelegate set_keepAnimatorStateOnDisableDelegateField;

		// Token: 0x04000126 RID: 294
		private static readonly Animator.get_writeDefaultValuesOnDisableDelegate get_writeDefaultValuesOnDisableDelegateField;

		// Token: 0x04000127 RID: 295
		private static readonly Animator.set_writeDefaultValuesOnDisableDelegate set_writeDefaultValuesOnDisableDelegateField;

		// Token: 0x04000128 RID: 296
		private static readonly Animator.get_deltaPosition_InjectedDelegate get_deltaPosition_InjectedDelegateField;

		// Token: 0x04000129 RID: 297
		private static readonly Animator.get_deltaRotation_InjectedDelegate get_deltaRotation_InjectedDelegateField;

		// Token: 0x0400012A RID: 298
		private static readonly Animator.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

		// Token: 0x0400012B RID: 299
		private static readonly Animator.get_angularVelocity_InjectedDelegate get_angularVelocity_InjectedDelegateField;

		// Token: 0x0400012C RID: 300
		private static readonly Animator.get_rootPosition_InjectedDelegate get_rootPosition_InjectedDelegateField;

		// Token: 0x0400012D RID: 301
		private static readonly Animator.set_rootPosition_InjectedDelegate set_rootPosition_InjectedDelegateField;

		// Token: 0x0400012E RID: 302
		private static readonly Animator.get_rootRotation_InjectedDelegate get_rootRotation_InjectedDelegateField;

		// Token: 0x0400012F RID: 303
		private static readonly Animator.set_rootRotation_InjectedDelegate set_rootRotation_InjectedDelegateField;

		// Token: 0x04000130 RID: 304
		private static readonly Animator.get_bodyPositionInternal_InjectedDelegate get_bodyPositionInternal_InjectedDelegateField;

		// Token: 0x04000131 RID: 305
		private static readonly Animator.set_bodyPositionInternal_InjectedDelegate set_bodyPositionInternal_InjectedDelegateField;

		// Token: 0x04000132 RID: 306
		private static readonly Animator.get_bodyRotationInternal_InjectedDelegate get_bodyRotationInternal_InjectedDelegateField;

		// Token: 0x04000133 RID: 307
		private static readonly Animator.set_bodyRotationInternal_InjectedDelegate set_bodyRotationInternal_InjectedDelegateField;

		// Token: 0x04000134 RID: 308
		private static readonly Animator.GetGoalPosition_InjectedDelegate GetGoalPosition_InjectedDelegateField;

		// Token: 0x04000135 RID: 309
		private static readonly Animator.SetGoalPosition_InjectedDelegate SetGoalPosition_InjectedDelegateField;

		// Token: 0x04000136 RID: 310
		private static readonly Animator.GetGoalRotation_InjectedDelegate GetGoalRotation_InjectedDelegateField;

		// Token: 0x04000137 RID: 311
		private static readonly Animator.SetGoalRotation_InjectedDelegate SetGoalRotation_InjectedDelegateField;

		// Token: 0x04000138 RID: 312
		private static readonly Animator.GetHintPosition_InjectedDelegate GetHintPosition_InjectedDelegateField;

		// Token: 0x04000139 RID: 313
		private static readonly Animator.SetHintPosition_InjectedDelegate SetHintPosition_InjectedDelegateField;

		// Token: 0x0400013A RID: 314
		private static readonly Animator.SetLookAtPositionInternal_InjectedDelegate SetLookAtPositionInternal_InjectedDelegateField;

		// Token: 0x0400013B RID: 315
		private static readonly Animator.SetBoneLocalRotationInternal_InjectedDelegate SetBoneLocalRotationInternal_InjectedDelegateField;

		// Token: 0x0400013C RID: 316
		private static readonly Animator.get_pivotPosition_InjectedDelegate get_pivotPosition_InjectedDelegateField;

		// Token: 0x0400013D RID: 317
		private static readonly Animator.get_targetPosition_InjectedDelegate get_targetPosition_InjectedDelegateField;

		// Token: 0x0400013E RID: 318
		private static readonly Animator.get_targetRotation_InjectedDelegate get_targetRotation_InjectedDelegateField;

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x06000642 RID: 1602
		private delegate bool get_isOptimizableDelegate(IntPtr @this);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x06000644 RID: 1604
		private delegate bool get_isRootPositionOrRotationControlledByCurvesDelegate(IntPtr @this);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x06000646 RID: 1606
		private delegate float get_humanScaleDelegate(IntPtr @this);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x06000648 RID: 1608
		private delegate bool get_isInitializedDelegate(IntPtr @this);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x0600064A RID: 1610
		private delegate bool get_applyRootMotionDelegate(IntPtr @this);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x0600064C RID: 1612
		private delegate void set_applyRootMotionDelegate(IntPtr @this, bool value);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x0600064E RID: 1614
		private delegate bool get_linearVelocityBlendingDelegate(IntPtr @this);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x06000650 RID: 1616
		private delegate void set_linearVelocityBlendingDelegate(IntPtr @this, bool value);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x06000652 RID: 1618
		private delegate AnimatorUpdateMode get_updateModeDelegate(IntPtr @this);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x06000654 RID: 1620
		private delegate void set_updateModeDelegate(IntPtr @this, AnimatorUpdateMode value);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x06000656 RID: 1622
		private delegate bool get_hasTransformHierarchyDelegate(IntPtr @this);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x06000658 RID: 1624
		private delegate bool get_allowConstantClipSamplingOptimizationDelegate(IntPtr @this);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x0600065A RID: 1626
		private delegate void set_allowConstantClipSamplingOptimizationDelegate(IntPtr @this, bool value);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x0600065C RID: 1628
		private delegate float get_gravityWeightDelegate(IntPtr @this);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x0600065E RID: 1630
		private delegate float GetGoalWeightPositionDelegate(IntPtr @this, AvatarIKGoal goal);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x06000660 RID: 1632
		private delegate void SetGoalWeightPositionDelegate(IntPtr @this, AvatarIKGoal goal, float value);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x06000662 RID: 1634
		private delegate float GetGoalWeightRotationDelegate(IntPtr @this, AvatarIKGoal goal);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x06000664 RID: 1636
		private delegate void SetGoalWeightRotationDelegate(IntPtr @this, AvatarIKGoal goal, float value);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x06000666 RID: 1638
		private delegate float GetHintWeightPositionDelegate(IntPtr @this, AvatarIKHint hint);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x06000668 RID: 1640
		private delegate void SetHintWeightPositionDelegate(IntPtr @this, AvatarIKHint hint, float value);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x0600066A RID: 1642
		private delegate void SetLookAtWeightInternalDelegate(IntPtr @this, float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x0600066C RID: 1644
		private delegate IntPtr GetBehaviourDelegate(IntPtr @this, IntPtr type);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x0600066E RID: 1646
		private delegate IntPtr InternalGetBehavioursDelegate(IntPtr @this, IntPtr type);

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x06000670 RID: 1648
		private delegate IntPtr InternalGetBehavioursByKeyDelegate(IntPtr @this, int fullPathHash, int layerIndex, IntPtr type);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x06000672 RID: 1650
		private delegate bool get_stabilizeFeetDelegate(IntPtr @this);

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x06000674 RID: 1652
		private delegate void set_stabilizeFeetDelegate(IntPtr @this, bool value);

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x06000676 RID: 1654
		private delegate int get_layerCountDelegate(IntPtr @this);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x06000678 RID: 1656
		private delegate IntPtr GetLayerNameDelegate(IntPtr @this, int layerIndex);

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x0600067A RID: 1658
		private delegate int GetLayerIndexDelegate(IntPtr @this, IntPtr layerName);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x0600067C RID: 1660
		private delegate float GetLayerWeightDelegate(IntPtr @this, int layerIndex);

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x0600067E RID: 1662
		private delegate void SetLayerWeightDelegate(IntPtr @this, int layerIndex, float weight);

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x06000680 RID: 1664
		private delegate void GetAnimatorTransitionInfoDelegate(IntPtr @this, int layerIndex, [Out] IntPtr info);

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x06000682 RID: 1666
		private delegate int GetAnimatorClipInfoCountDelegate(IntPtr @this, int layerIndex, bool current);

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x06000684 RID: 1668
		private delegate IntPtr GetCurrentAnimatorClipInfoDelegate(IntPtr @this, int layerIndex);

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x06000686 RID: 1670
		private delegate IntPtr GetNextAnimatorClipInfoDelegate(IntPtr @this, int layerIndex);

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x06000688 RID: 1672
		private delegate void GetAnimatorClipInfoInternalDelegate(IntPtr @this, int layerIndex, bool isCurrent, IntPtr clips);

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x0600068A RID: 1674
		private delegate bool IsInTransitionDelegate(IntPtr @this, int layerIndex);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x0600068C RID: 1676
		private delegate IntPtr get_parametersDelegate(IntPtr @this);

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x0600068E RID: 1678
		private delegate int get_parameterCountDelegate(IntPtr @this);

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x06000690 RID: 1680
		private delegate IntPtr GetParameterInternalDelegate(IntPtr @this, int index);

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x06000692 RID: 1682
		private delegate float get_feetPivotActiveDelegate(IntPtr @this);

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x06000694 RID: 1684
		private delegate void set_feetPivotActiveDelegate(IntPtr @this, float value);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x06000696 RID: 1686
		private delegate float get_pivotWeightDelegate(IntPtr @this);

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x06000698 RID: 1688
		private delegate void InterruptMatchTargetDelegate(IntPtr @this, bool completeMatch);

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x0600069A RID: 1690
		private delegate bool get_isMatchingTargetDelegate(IntPtr @this);

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x0600069C RID: 1692
		private delegate float get_speedDelegate(IntPtr @this);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x0600069E RID: 1694
		private delegate void set_speedDelegate(IntPtr @this, float value);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x060006A0 RID: 1696
		private delegate void CrossFadeInFixedTimeDelegate(IntPtr @this, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x060006A2 RID: 1698
		private delegate void WriteDefaultValuesDelegate(IntPtr @this);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x060006A4 RID: 1700
		private delegate void CrossFadeDelegate(IntPtr @this, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x060006A6 RID: 1702
		private delegate void PlayInFixedTimeDelegate(IntPtr @this, int stateNameHash, int layer, float fixedTime);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x060006A8 RID: 1704
		private delegate void SetTargetDelegate(IntPtr @this, AvatarTarget targetIndex, float targetNormalizedTime);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x060006AA RID: 1706
		private delegate bool IsBoneTransformDelegate(IntPtr @this, IntPtr transform);

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x060006AC RID: 1708
		private delegate IntPtr get_avatarRootDelegate(IntPtr @this);

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x060006AE RID: 1710
		private delegate IntPtr GetBoneTransformInternalDelegate(IntPtr @this, int humanBoneId);

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x060006B0 RID: 1712
		private delegate AnimatorCullingMode get_cullingModeDelegate(IntPtr @this);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x060006B2 RID: 1714
		private delegate void set_cullingModeDelegate(IntPtr @this, AnimatorCullingMode value);

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x060006B4 RID: 1716
		private delegate void StartPlaybackDelegate(IntPtr @this);

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x060006B6 RID: 1718
		private delegate void StopPlaybackDelegate(IntPtr @this);

		// Token: 0x020000E4 RID: 228
		// (Invoke) Token: 0x060006B8 RID: 1720
		private delegate float get_playbackTimeDelegate(IntPtr @this);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x060006BA RID: 1722
		private delegate void set_playbackTimeDelegate(IntPtr @this, float value);

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x060006BC RID: 1724
		private delegate void StartRecordingDelegate(IntPtr @this, int frameCount);

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x060006BE RID: 1726
		private delegate void StopRecordingDelegate(IntPtr @this);

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x060006C0 RID: 1728
		private delegate float GetRecorderStartTimeDelegate(IntPtr @this);

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x060006C2 RID: 1730
		private delegate float GetRecorderStopTimeDelegate(IntPtr @this);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x060006C4 RID: 1732
		private delegate AnimatorRecorderMode get_recorderModeDelegate(IntPtr @this);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x060006C6 RID: 1734
		private delegate void ClearInternalControllerPlayableDelegate(IntPtr @this);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x060006C8 RID: 1736
		private delegate bool HasStateDelegate(IntPtr @this, int layerIndex, int stateID);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x060006CA RID: 1738
		private delegate void set_avatarDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000EE RID: 238
		// (Invoke) Token: 0x060006CC RID: 1740
		private delegate IntPtr GetStatsDelegate(IntPtr @this);

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x060006CE RID: 1742
		private delegate void GetCurrentGraphDelegate(IntPtr @this, IntPtr graph);

		// Token: 0x020000F0 RID: 240
		// (Invoke) Token: 0x060006D0 RID: 1744
		private delegate bool IsInIKPassDelegate(IntPtr @this);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x060006D2 RID: 1746
		private delegate void SetFloatIDDelegate(IntPtr @this, int id, float value);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x060006D4 RID: 1748
		private delegate float GetFloatStringDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x060006D6 RID: 1750
		private delegate float GetFloatIDDelegate(IntPtr @this, int id);

		// Token: 0x020000F4 RID: 244
		// (Invoke) Token: 0x060006D8 RID: 1752
		private delegate void SetBoolStringDelegate(IntPtr @this, IntPtr name, bool value);

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x060006DA RID: 1754
		private delegate bool GetBoolStringDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x060006DC RID: 1756
		private delegate bool GetBoolIDDelegate(IntPtr @this, int id);

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x060006DE RID: 1758
		private delegate void SetIntegerStringDelegate(IntPtr @this, IntPtr name, int value);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x060006E0 RID: 1760
		private delegate void SetIntegerIDDelegate(IntPtr @this, int id, int value);

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x060006E2 RID: 1762
		private delegate int GetIntegerStringDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x060006E4 RID: 1764
		private delegate int GetIntegerIDDelegate(IntPtr @this, int id);

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x060006E6 RID: 1766
		private delegate void SetTriggerIDDelegate(IntPtr @this, int id);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x060006E8 RID: 1768
		private delegate void ResetTriggerIDDelegate(IntPtr @this, int id);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x060006EA RID: 1770
		private delegate bool IsParameterControlledByCurveStringDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x060006EC RID: 1772
		private delegate bool IsParameterControlledByCurveIDDelegate(IntPtr @this, int id);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x060006EE RID: 1774
		private delegate void SetFloatStringDampDelegate(IntPtr @this, IntPtr name, float value, float dampTime, float deltaTime);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x060006F0 RID: 1776
		private delegate void SetFloatIDDampDelegate(IntPtr @this, int id, float value, float dampTime, float deltaTime);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x060006F2 RID: 1778
		private delegate bool get_layersAffectMassCenterDelegate(IntPtr @this);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x060006F4 RID: 1780
		private delegate void set_layersAffectMassCenterDelegate(IntPtr @this, bool value);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x060006F6 RID: 1782
		private delegate float get_leftFeetBottomHeightDelegate(IntPtr @this);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x060006F8 RID: 1784
		private delegate float get_rightFeetBottomHeightDelegate(IntPtr @this);

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x060006FA RID: 1786
		private delegate bool get_supportsOnAnimatorMoveDelegate(IntPtr @this);

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x060006FC RID: 1788
		private delegate void OnUpdateModeChangedDelegate(IntPtr @this);

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x060006FE RID: 1790
		private delegate void OnCullingModeChangedDelegate(IntPtr @this);

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x06000700 RID: 1792
		private delegate void WriteDefaultPoseDelegate(IntPtr @this);

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x06000702 RID: 1794
		private delegate void UpdateDelegate(IntPtr @this, float deltaTime);

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x06000704 RID: 1796
		private delegate void RebindDelegate(IntPtr @this, bool writeDefaultValues);

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x06000706 RID: 1798
		private delegate void ApplyBuiltinRootMotionDelegate(IntPtr @this);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x06000708 RID: 1800
		private delegate void EvaluateControllerDelegate(IntPtr @this, float deltaTime);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x0600070A RID: 1802
		private delegate IntPtr GetAnimatorStateNameDelegate(IntPtr @this, int layerIndex, bool current);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x0600070C RID: 1804
		private delegate IntPtr ResolveHashDelegate(IntPtr @this, int hash);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x0600070E RID: 1806
		private delegate bool get_logWarningsDelegate(IntPtr @this);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x06000710 RID: 1808
		private delegate void set_logWarningsDelegate(IntPtr @this, bool value);

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x06000712 RID: 1810
		private delegate bool get_fireEventsDelegate(IntPtr @this);

		// Token: 0x02000112 RID: 274
		// (Invoke) Token: 0x06000714 RID: 1812
		private delegate void set_fireEventsDelegate(IntPtr @this, bool value);

		// Token: 0x02000113 RID: 275
		// (Invoke) Token: 0x06000716 RID: 1814
		private delegate bool get_keepAnimatorStateOnDisableDelegate(IntPtr @this);

		// Token: 0x02000114 RID: 276
		// (Invoke) Token: 0x06000718 RID: 1816
		private delegate void set_keepAnimatorStateOnDisableDelegate(IntPtr @this, bool value);

		// Token: 0x02000115 RID: 277
		// (Invoke) Token: 0x0600071A RID: 1818
		private delegate bool get_writeDefaultValuesOnDisableDelegate(IntPtr @this);

		// Token: 0x02000116 RID: 278
		// (Invoke) Token: 0x0600071C RID: 1820
		private delegate void set_writeDefaultValuesOnDisableDelegate(IntPtr @this, bool value);

		// Token: 0x02000117 RID: 279
		// (Invoke) Token: 0x0600071E RID: 1822
		private delegate void get_deltaPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000118 RID: 280
		// (Invoke) Token: 0x06000720 RID: 1824
		private delegate void get_deltaRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000119 RID: 281
		// (Invoke) Token: 0x06000722 RID: 1826
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200011A RID: 282
		// (Invoke) Token: 0x06000724 RID: 1828
		private delegate void get_angularVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200011B RID: 283
		// (Invoke) Token: 0x06000726 RID: 1830
		private delegate void get_rootPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200011C RID: 284
		// (Invoke) Token: 0x06000728 RID: 1832
		private delegate void set_rootPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200011D RID: 285
		// (Invoke) Token: 0x0600072A RID: 1834
		private delegate void get_rootRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200011E RID: 286
		// (Invoke) Token: 0x0600072C RID: 1836
		private delegate void set_rootRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x0600072E RID: 1838
		private delegate void get_bodyPositionInternal_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x06000730 RID: 1840
		private delegate void set_bodyPositionInternal_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x06000732 RID: 1842
		private delegate void get_bodyRotationInternal_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000122 RID: 290
		// (Invoke) Token: 0x06000734 RID: 1844
		private delegate void set_bodyRotationInternal_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x06000736 RID: 1846
		private delegate void GetGoalPosition_InjectedDelegate(IntPtr @this, AvatarIKGoal goal, [Out] IntPtr ret);

		// Token: 0x02000124 RID: 292
		// (Invoke) Token: 0x06000738 RID: 1848
		private delegate void SetGoalPosition_InjectedDelegate(IntPtr @this, AvatarIKGoal goal, IntPtr goalPosition);

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x0600073A RID: 1850
		private delegate void GetGoalRotation_InjectedDelegate(IntPtr @this, AvatarIKGoal goal, [Out] IntPtr ret);

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x0600073C RID: 1852
		private delegate void SetGoalRotation_InjectedDelegate(IntPtr @this, AvatarIKGoal goal, IntPtr goalRotation);

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x0600073E RID: 1854
		private delegate void GetHintPosition_InjectedDelegate(IntPtr @this, AvatarIKHint hint, [Out] IntPtr ret);

		// Token: 0x02000128 RID: 296
		// (Invoke) Token: 0x06000740 RID: 1856
		private delegate void SetHintPosition_InjectedDelegate(IntPtr @this, AvatarIKHint hint, IntPtr hintPosition);

		// Token: 0x02000129 RID: 297
		// (Invoke) Token: 0x06000742 RID: 1858
		private delegate void SetLookAtPositionInternal_InjectedDelegate(IntPtr @this, IntPtr lookAtPosition);

		// Token: 0x0200012A RID: 298
		// (Invoke) Token: 0x06000744 RID: 1860
		private delegate void SetBoneLocalRotationInternal_InjectedDelegate(IntPtr @this, int humanBoneId, IntPtr rotation);

		// Token: 0x0200012B RID: 299
		// (Invoke) Token: 0x06000746 RID: 1862
		private delegate void get_pivotPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200012C RID: 300
		// (Invoke) Token: 0x06000748 RID: 1864
		private delegate void get_targetPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x0600074A RID: 1866
		private delegate void get_targetRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
