using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Timeline
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public class TimelineClip : Object
	{
		// Token: 0x06000109 RID: 265 RVA: 0x000085B0 File Offset: 0x000067B0
		// Note: this type is marked as 'beforefieldinit'.
		static TimelineClip()
		{
			Il2CppClassPointerStore<TimelineClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimelineClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr);
			TimelineClip.NativeFieldInfoPtr_k_LatestVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "k_LatestVersion");
			TimelineClip.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_Version");
			TimelineClip.NativeFieldInfoPtr_kDefaultClipCaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kDefaultClipCaps");
			TimelineClip.NativeFieldInfoPtr_kDefaultClipDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kDefaultClipDurationInSeconds");
			TimelineClip.NativeFieldInfoPtr_kTimeScaleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kTimeScaleMin");
			TimelineClip.NativeFieldInfoPtr_kTimeScaleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kTimeScaleMax");
			TimelineClip.NativeFieldInfoPtr_kDefaultCurvesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kDefaultCurvesName");
			TimelineClip.NativeFieldInfoPtr_kMinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kMinDuration");
			TimelineClip.NativeFieldInfoPtr_kMaxTimeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kMaxTimeValue");
			TimelineClip.NativeFieldInfoPtr_m_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_Start");
			TimelineClip.NativeFieldInfoPtr_m_ClipIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_ClipIn");
			TimelineClip.NativeFieldInfoPtr_m_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_Asset");
			TimelineClip.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_Duration");
			TimelineClip.NativeFieldInfoPtr_m_TimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_TimeScale");
			TimelineClip.NativeFieldInfoPtr_m_ParentTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_ParentTrack");
			TimelineClip.NativeFieldInfoPtr_m_EaseInDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_EaseInDuration");
			TimelineClip.NativeFieldInfoPtr_m_EaseOutDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_EaseOutDuration");
			TimelineClip.NativeFieldInfoPtr_m_BlendInDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_BlendInDuration");
			TimelineClip.NativeFieldInfoPtr_m_BlendOutDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_BlendOutDuration");
			TimelineClip.NativeFieldInfoPtr_m_MixInCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_MixInCurve");
			TimelineClip.NativeFieldInfoPtr_m_MixOutCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_MixOutCurve");
			TimelineClip.NativeFieldInfoPtr_m_BlendInCurveMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_BlendInCurveMode");
			TimelineClip.NativeFieldInfoPtr_m_BlendOutCurveMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_BlendOutCurveMode");
			TimelineClip.NativeFieldInfoPtr_m_ExposedParameterNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_ExposedParameterNames");
			TimelineClip.NativeFieldInfoPtr_m_AnimationCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_AnimationCurves");
			TimelineClip.NativeFieldInfoPtr_m_Recordable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_Recordable");
			TimelineClip.NativeFieldInfoPtr_m_PostExtrapolationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_PostExtrapolationMode");
			TimelineClip.NativeFieldInfoPtr_m_PreExtrapolationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_PreExtrapolationMode");
			TimelineClip.NativeFieldInfoPtr_m_PostExtrapolationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_PostExtrapolationTime");
			TimelineClip.NativeFieldInfoPtr_m_PreExtrapolationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_PreExtrapolationTime");
			TimelineClip.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_DisplayName");
			TimelineClip.NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663470);
			TimelineClip.NativeMethodInfoPtr__ctor_Internal_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663471);
			TimelineClip.NativeMethodInfoPtr_get_hasPreExtrapolation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663472);
			TimelineClip.NativeMethodInfoPtr_get_hasPostExtrapolation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663473);
			TimelineClip.NativeMethodInfoPtr_get_timeScale_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663474);
			TimelineClip.NativeMethodInfoPtr_set_timeScale_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663475);
			TimelineClip.NativeMethodInfoPtr_get_start_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663476);
			TimelineClip.NativeMethodInfoPtr_set_start_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663477);
			TimelineClip.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663478);
			TimelineClip.NativeMethodInfoPtr_set_duration_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663479);
			TimelineClip.NativeMethodInfoPtr_get_end_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663480);
			TimelineClip.NativeMethodInfoPtr_get_clipIn_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663481);
			TimelineClip.NativeMethodInfoPtr_set_clipIn_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663482);
			TimelineClip.NativeMethodInfoPtr_get_displayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663483);
			TimelineClip.NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663484);
			TimelineClip.NativeMethodInfoPtr_get_clipAssetDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663485);
			TimelineClip.NativeMethodInfoPtr_get_curves_Public_Virtual_Final_New_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663486);
			TimelineClip.NativeMethodInfoPtr_set_curves_Internal_set_Void_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663487);
			TimelineClip.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_defaultCurvesName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663488);
			TimelineClip.NativeMethodInfoPtr_get_hasCurves_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663489);
			TimelineClip.NativeMethodInfoPtr_get_asset_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663490);
			TimelineClip.NativeMethodInfoPtr_set_asset_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663491);
			TimelineClip.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_assetOwner_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663492);
			TimelineClip.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_targetTrack_Private_Virtual_Final_New_get_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663493);
			TimelineClip.NativeMethodInfoPtr_get_underlyingAsset_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663494);
			TimelineClip.NativeMethodInfoPtr_set_underlyingAsset_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663495);
			TimelineClip.NativeMethodInfoPtr_get_parentTrack_Public_get_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663496);
			TimelineClip.NativeMethodInfoPtr_set_parentTrack_Public_set_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663497);
			TimelineClip.NativeMethodInfoPtr_get_easeInDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663498);
			TimelineClip.NativeMethodInfoPtr_set_easeInDuration_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663499);
			TimelineClip.NativeMethodInfoPtr_get_easeOutDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663500);
			TimelineClip.NativeMethodInfoPtr_set_easeOutDuration_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663501);
			TimelineClip.NativeMethodInfoPtr_get_eastOutTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663502);
			TimelineClip.NativeMethodInfoPtr_get_easeOutTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663503);
			TimelineClip.NativeMethodInfoPtr_get_blendInDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663504);
			TimelineClip.NativeMethodInfoPtr_set_blendInDuration_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663505);
			TimelineClip.NativeMethodInfoPtr_get_blendOutDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663506);
			TimelineClip.NativeMethodInfoPtr_set_blendOutDuration_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663507);
			TimelineClip.NativeMethodInfoPtr_get_blendInCurveMode_Public_get_BlendCurveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663508);
			TimelineClip.NativeMethodInfoPtr_set_blendInCurveMode_Public_set_Void_BlendCurveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663509);
			TimelineClip.NativeMethodInfoPtr_get_blendOutCurveMode_Public_get_BlendCurveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663510);
			TimelineClip.NativeMethodInfoPtr_set_blendOutCurveMode_Public_set_Void_BlendCurveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663511);
			TimelineClip.NativeMethodInfoPtr_get_hasBlendIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663512);
			TimelineClip.NativeMethodInfoPtr_get_hasBlendOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663513);
			TimelineClip.NativeMethodInfoPtr_get_mixInCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663514);
			TimelineClip.NativeMethodInfoPtr_set_mixInCurve_Public_set_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663515);
			TimelineClip.NativeMethodInfoPtr_get_mixInPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663516);
			TimelineClip.NativeMethodInfoPtr_get_mixInDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663517);
			TimelineClip.NativeMethodInfoPtr_get_mixOutCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663518);
			TimelineClip.NativeMethodInfoPtr_set_mixOutCurve_Public_set_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663519);
			TimelineClip.NativeMethodInfoPtr_get_mixOutTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663520);
			TimelineClip.NativeMethodInfoPtr_get_mixOutDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663521);
			TimelineClip.NativeMethodInfoPtr_get_mixOutPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663522);
			TimelineClip.NativeMethodInfoPtr_get_recordable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663523);
			TimelineClip.NativeMethodInfoPtr_set_recordable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663524);
			TimelineClip.NativeMethodInfoPtr_get_exposedParameters_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663525);
			TimelineClip.NativeMethodInfoPtr_get_clipCaps_Public_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663526);
			TimelineClip.NativeMethodInfoPtr_Hash_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663527);
			TimelineClip.NativeMethodInfoPtr_EvaluateMixOut_Public_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663528);
			TimelineClip.NativeMethodInfoPtr_EvaluateMixIn_Public_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663529);
			TimelineClip.NativeMethodInfoPtr_GetDefaultMixInCurve_Private_Static_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663530);
			TimelineClip.NativeMethodInfoPtr_GetDefaultMixOutCurve_Private_Static_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663531);
			TimelineClip.NativeMethodInfoPtr_ToLocalTime_Public_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663532);
			TimelineClip.NativeMethodInfoPtr_ToLocalTimeUnbound_Public_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663533);
			TimelineClip.NativeMethodInfoPtr_FromLocalTimeUnbound_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663534);
			TimelineClip.NativeMethodInfoPtr_get_animationClip_Public_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663535);
			TimelineClip.NativeMethodInfoPtr_SanitizeTimeValue_Private_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663536);
			TimelineClip.NativeMethodInfoPtr_get_postExtrapolationMode_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663537);
			TimelineClip.NativeMethodInfoPtr_set_postExtrapolationMode_Internal_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663538);
			TimelineClip.NativeMethodInfoPtr_get_preExtrapolationMode_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663539);
			TimelineClip.NativeMethodInfoPtr_set_preExtrapolationMode_Internal_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663540);
			TimelineClip.NativeMethodInfoPtr_SetPostExtrapolationTime_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663541);
			TimelineClip.NativeMethodInfoPtr_SetPreExtrapolationTime_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663542);
			TimelineClip.NativeMethodInfoPtr_IsExtrapolatedTime_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663543);
			TimelineClip.NativeMethodInfoPtr_IsPreExtrapolatedTime_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663544);
			TimelineClip.NativeMethodInfoPtr_IsPostExtrapolatedTime_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663545);
			TimelineClip.NativeMethodInfoPtr_get_extrapolatedStart_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663546);
			TimelineClip.NativeMethodInfoPtr_get_extrapolatedDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663547);
			TimelineClip.NativeMethodInfoPtr_GetExtrapolatedTime_Private_Static_Double_Double_ClipExtrapolation_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663548);
			TimelineClip.NativeMethodInfoPtr_CreateCurves_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663549);
			TimelineClip.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663550);
			TimelineClip.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663551);
			TimelineClip.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663552);
			TimelineClip.NativeMethodInfoPtr_ConformEaseValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663553);
			TimelineClip.NativeMethodInfoPtr_CalculateEasingRatio_Private_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663554);
			TimelineClip.NativeMethodInfoPtr_UpdateDirty_Private_Void_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663555);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00008F04 File Offset: 0x00007104
		[CallerCount(0)]
		public unsafe void UpgradeToLatestVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00008F38 File Offset: 0x00007138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473698, XrefRangeEnd = 473699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimelineClip(TrackAsset parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr__ctor_Internal_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00008F84 File Offset: 0x00007184
		public unsafe bool hasPreExtrapolation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_hasPreExtrapolation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00008FC0 File Offset: 0x000071C0
		public unsafe bool hasPostExtrapolation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_hasPostExtrapolation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00008FFC File Offset: 0x000071FC
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00009038 File Offset: 0x00007238
		public unsafe double timeScale
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 473709, RefRangeEnd = 473716, XrefRangeStart = 473699, XrefRangeEnd = 473709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_timeScale_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473716, XrefRangeEnd = 473727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_timeScale_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00009078 File Offset: 0x00007278
		// (set) Token: 0x06000111 RID: 273 RVA: 0x000090B4 File Offset: 0x000072B4
		public unsafe double start
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_start_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 473747, RefRangeEnd = 473749, XrefRangeStart = 473727, XrefRangeEnd = 473747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_start_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000090F4 File Offset: 0x000072F4
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00009130 File Offset: 0x00007330
		public unsafe virtual double duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 473757, RefRangeEnd = 473762, XrefRangeStart = 473749, XrefRangeEnd = 473757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_duration_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00009170 File Offset: 0x00007370
		public unsafe double end
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_end_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000091AC File Offset: 0x000073AC
		// (set) Token: 0x06000116 RID: 278 RVA: 0x000091E8 File Offset: 0x000073E8
		public unsafe double clipIn
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473762, XrefRangeEnd = 473763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_clipIn_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473763, XrefRangeEnd = 473775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_clipIn_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00009228 File Offset: 0x00007428
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00009260 File Offset: 0x00007460
		public unsafe string displayName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_displayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 426723, RefRangeEnd = 426724, XrefRangeStart = 426723, XrefRangeEnd = 426724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000092A4 File Offset: 0x000074A4
		public unsafe double clipAssetDuration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473775, XrefRangeEnd = 473780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_clipAssetDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000092E0 File Offset: 0x000074E0
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00009320 File Offset: 0x00007520
		public unsafe virtual AnimationClip curves
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_curves_Public_Virtual_Final_New_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 161221, RefRangeEnd = 161228, XrefRangeStart = 161221, XrefRangeEnd = 161228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_curves_Internal_set_Void_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00009364 File Offset: 0x00007564
		public unsafe virtual string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473780, XrefRangeEnd = 473784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_defaultCurvesName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000939C File Offset: 0x0000759C
		public unsafe virtual bool hasCurves
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473784, XrefRangeEnd = 473798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_hasCurves_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000093D8 File Offset: 0x000075D8
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00009418 File Offset: 0x00007618
		public unsafe virtual Object asset
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_asset_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_asset_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000945C File Offset: 0x0000765C
		public unsafe virtual Object UnityEngine.Timeline.ICurvesOwner.assetOwner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_assetOwner_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000949C File Offset: 0x0000769C
		public unsafe virtual TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_targetTrack_Private_Virtual_Final_New_get_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr3) : null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000094DC File Offset: 0x000076DC
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000951C File Offset: 0x0000771C
		public unsafe Object underlyingAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_underlyingAsset_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_underlyingAsset_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00009560 File Offset: 0x00007760
		// (set) Token: 0x06000125 RID: 293 RVA: 0x000095A0 File Offset: 0x000077A0
		public unsafe TrackAsset parentTrack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_parentTrack_Public_get_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 473841, RefRangeEnd = 473843, XrefRangeStart = 473798, XrefRangeEnd = 473841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_parentTrack_Public_set_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000095E4 File Offset: 0x000077E4
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00009620 File Offset: 0x00007820
		public unsafe double easeInDuration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473843, XrefRangeEnd = 473849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_easeInDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473849, XrefRangeEnd = 473860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_easeInDuration_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00009660 File Offset: 0x00007860
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000969C File Offset: 0x0000789C
		public unsafe double easeOutDuration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473860, XrefRangeEnd = 473866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_easeOutDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473866, XrefRangeEnd = 473877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_easeOutDuration_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000096DC File Offset: 0x000078DC
		public unsafe double eastOutTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473877, XrefRangeEnd = 473884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_eastOutTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00009718 File Offset: 0x00007918
		public unsafe double easeOutTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_easeOutTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00009754 File Offset: 0x00007954
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00009790 File Offset: 0x00007990
		public unsafe double blendInDuration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473884, XrefRangeEnd = 473885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_blendInDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473885, XrefRangeEnd = 473891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_blendInDuration_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000097D0 File Offset: 0x000079D0
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0000980C File Offset: 0x00007A0C
		public unsafe double blendOutDuration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473891, XrefRangeEnd = 473892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_blendOutDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473892, XrefRangeEnd = 473898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_blendOutDuration_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000984C File Offset: 0x00007A4C
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00009888 File Offset: 0x00007A88
		public unsafe TimelineClip.BlendCurveMode blendInCurveMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_blendInCurveMode_Public_get_BlendCurveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_blendInCurveMode_Public_set_Void_BlendCurveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000098C8 File Offset: 0x00007AC8
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00009904 File Offset: 0x00007B04
		public unsafe TimelineClip.BlendCurveMode blendOutCurveMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_blendOutCurveMode_Public_get_BlendCurveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_blendOutCurveMode_Public_set_Void_BlendCurveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00009944 File Offset: 0x00007B44
		public unsafe bool hasBlendIn
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473898, XrefRangeEnd = 473899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_hasBlendIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00009980 File Offset: 0x00007B80
		public unsafe bool hasBlendOut
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473899, XrefRangeEnd = 473900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_hasBlendOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000099BC File Offset: 0x00007BBC
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000099FC File Offset: 0x00007BFC
		public unsafe AnimationCurve mixInCurve
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473900, XrefRangeEnd = 473906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_mixInCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14893, RefRangeEnd = 14909, XrefRangeStart = 14893, XrefRangeEnd = 14909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_mixInCurve_Public_set_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00009A40 File Offset: 0x00007C40
		public unsafe float mixInPercentage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473906, XrefRangeEnd = 473907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_mixInPercentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00009A7C File Offset: 0x00007C7C
		public unsafe double mixInDuration
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 473909, RefRangeEnd = 473911, XrefRangeStart = 473907, XrefRangeEnd = 473909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_mixInDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00009AB8 File Offset: 0x00007CB8
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00009AF8 File Offset: 0x00007CF8
		public unsafe AnimationCurve mixOutCurve
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473911, XrefRangeEnd = 473917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_mixOutCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 89481, RefRangeEnd = 89490, XrefRangeStart = 89481, XrefRangeEnd = 89490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_mixOutCurve_Public_set_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00009B3C File Offset: 0x00007D3C
		public unsafe double mixOutTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473917, XrefRangeEnd = 473918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_mixOutTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00009B78 File Offset: 0x00007D78
		public unsafe double mixOutDuration
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 473920, RefRangeEnd = 473923, XrefRangeStart = 473918, XrefRangeEnd = 473920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_mixOutDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00009BB4 File Offset: 0x00007DB4
		public unsafe float mixOutPercentage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473923, XrefRangeEnd = 473924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_mixOutPercentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00009BF0 File Offset: 0x00007DF0
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00009C2C File Offset: 0x00007E2C
		public unsafe bool recordable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_recordable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_recordable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00009C6C File Offset: 0x00007E6C
		public unsafe List<string> exposedParameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473924, XrefRangeEnd = 473930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_exposedParameters_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00009CAC File Offset: 0x00007EAC
		public unsafe ClipCaps clipCaps
		{
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 473939, RefRangeEnd = 473982, XrefRangeStart = 473930, XrefRangeEnd = 473939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_clipCaps_Public_get_ClipCaps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00009CE8 File Offset: 0x00007EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473982, XrefRangeEnd = 473985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Hash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_Hash_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00009D24 File Offset: 0x00007F24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 473989, RefRangeEnd = 473992, XrefRangeStart = 473985, XrefRangeEnd = 473989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float EvaluateMixOut(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_EvaluateMixOut_Public_Single_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00009D70 File Offset: 0x00007F70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 473996, RefRangeEnd = 473999, XrefRangeStart = 473992, XrefRangeEnd = 473996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float EvaluateMixIn(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_EvaluateMixIn_Public_Single_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00009DBC File Offset: 0x00007FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473999, XrefRangeEnd = 474000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationCurve GetDefaultMixInCurve()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_GetDefaultMixInCurve_Private_Static_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00009DF0 File Offset: 0x00007FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474000, XrefRangeEnd = 474001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationCurve GetDefaultMixOutCurve()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_GetDefaultMixOutCurve_Private_Static_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00009E24 File Offset: 0x00008024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474014, RefRangeEnd = 474016, XrefRangeStart = 474001, XrefRangeEnd = 474014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ToLocalTime(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_ToLocalTime_Public_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00009E70 File Offset: 0x00008070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474016, XrefRangeEnd = 474019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ToLocalTimeUnbound(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_ToLocalTimeUnbound_Public_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00009EBC File Offset: 0x000080BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474019, XrefRangeEnd = 474022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double FromLocalTimeUnbound(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_FromLocalTimeUnbound_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00009F08 File Offset: 0x00008108
		public unsafe AnimationClip animationClip
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474022, XrefRangeEnd = 474050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_animationClip_Public_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00009F48 File Offset: 0x00008148
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 474071, RefRangeEnd = 474078, XrefRangeStart = 474050, XrefRangeEnd = 474071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double SanitizeTimeValue(double value, double defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_SanitizeTimeValue_Private_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00009F94 File Offset: 0x00008194
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00009FD0 File Offset: 0x000081D0
		public unsafe TimelineClip.ClipExtrapolation postExtrapolationMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474078, XrefRangeEnd = 474079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_postExtrapolationMode_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474079, XrefRangeEnd = 474080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_postExtrapolationMode_Internal_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000A010 File Offset: 0x00008210
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000A04C File Offset: 0x0000824C
		public unsafe TimelineClip.ClipExtrapolation preExtrapolationMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474080, XrefRangeEnd = 474081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_preExtrapolationMode_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474081, XrefRangeEnd = 474082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_set_preExtrapolationMode_Internal_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000A08C File Offset: 0x0000828C
		[CallerCount(0)]
		public unsafe void SetPostExtrapolationTime(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_SetPostExtrapolationTime_Internal_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000A0CC File Offset: 0x000082CC
		[CallerCount(0)]
		public unsafe void SetPreExtrapolationTime(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_SetPreExtrapolationTime_Internal_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000A10C File Offset: 0x0000830C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474082, XrefRangeEnd = 474083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsExtrapolatedTime(double sequenceTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequenceTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_IsExtrapolatedTime_Public_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000A158 File Offset: 0x00008358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474083, XrefRangeEnd = 474084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPreExtrapolatedTime(double sequenceTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequenceTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_IsPreExtrapolatedTime_Public_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000A1A4 File Offset: 0x000083A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474085, RefRangeEnd = 474086, XrefRangeStart = 474084, XrefRangeEnd = 474085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPostExtrapolatedTime(double sequenceTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequenceTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_IsPostExtrapolatedTime_Public_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000A1F0 File Offset: 0x000083F0
		public unsafe double extrapolatedStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_extrapolatedStart_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000A22C File Offset: 0x0000842C
		public unsafe double extrapolatedDuration
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 474094, RefRangeEnd = 474097, XrefRangeStart = 474086, XrefRangeEnd = 474094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_get_extrapolatedDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000A268 File Offset: 0x00008468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474101, RefRangeEnd = 474103, XrefRangeStart = 474097, XrefRangeEnd = 474101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetExtrapolatedTime(double time, TimelineClip.ClipExtrapolation mode, double duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_GetExtrapolatedTime_Private_Static_Double_Double_ClipExtrapolation_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000A2C4 File Offset: 0x000084C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474103, XrefRangeEnd = 474120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateCurves(string curvesClipName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(curvesClipName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_CreateCurves_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000A308 File Offset: 0x00008508
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000A33C File Offset: 0x0000853C
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000A370 File Offset: 0x00008570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474120, XrefRangeEnd = 474156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimelineClip.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000A3B4 File Offset: 0x000085B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474156, XrefRangeEnd = 474168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConformEaseValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_ConformEaseValues_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000A3E8 File Offset: 0x000085E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474168, XrefRangeEnd = 474177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CalculateEasingRatio(double easeIn, double easeOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref easeIn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_CalculateEasingRatio_Private_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000A434 File Offset: 0x00008634
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDirty(double oldValue, double newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.NativeMethodInfoPtr_UpdateDirty_Private_Void_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002571 File Offset: 0x00000771
		public TimelineClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000A480 File Offset: 0x00008680
		// (set) Token: 0x06000162 RID: 354 RVA: 0x0000257A File Offset: 0x0000077A
		public unsafe static int k_LatestVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimelineClip.NativeFieldInfoPtr_k_LatestVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimelineClip.NativeFieldInfoPtr_k_LatestVersion, (void*)(&value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000A49C File Offset: 0x0000869C
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002588 File Offset: 0x00000788
		public unsafe int m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000A4C4 File Offset: 0x000086C4
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000025A3 File Offset: 0x000007A3
		public unsafe static ClipCaps kDefaultClipCaps
		{
			get
			{
				ClipCaps clipCaps;
				IL2CPP.il2cpp_field_static_get_value(TimelineClip.NativeFieldInfoPtr_kDefaultClipCaps, (void*)(&clipCaps));
				return clipCaps;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimelineClip.NativeFieldInfoPtr_kDefaultClipCaps, (void*)(&value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000A4E0 File Offset: 0x000086E0
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000025B1 File Offset: 0x000007B1
		public unsafe static float kDefaultClipDurationInSeconds
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TimelineClip.NativeFieldInfoPtr_kDefaultClipDurationInSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimelineClip.NativeFieldInfoPtr_kDefaultClipDurationInSeconds, (void*)(&value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000A4FC File Offset: 0x000086FC
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000025BF File Offset: 0x000007BF
		public unsafe static double kTimeScaleMin
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimelineClip.NativeFieldInfoPtr_kTimeScaleMin, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimelineClip.NativeFieldInfoPtr_kTimeScaleMin, (void*)(&value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000A518 File Offset: 0x00008718
		// (set) Token: 0x0600016C RID: 364 RVA: 0x000025CD File Offset: 0x000007CD
		public unsafe static double kTimeScaleMax
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimelineClip.NativeFieldInfoPtr_kTimeScaleMax, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimelineClip.NativeFieldInfoPtr_kTimeScaleMax, (void*)(&value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000A534 File Offset: 0x00008734
		// (set) Token: 0x0600016E RID: 366 RVA: 0x000025DB File Offset: 0x000007DB
		public unsafe static string kDefaultCurvesName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimelineClip.NativeFieldInfoPtr_kDefaultCurvesName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimelineClip.NativeFieldInfoPtr_kDefaultCurvesName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000A554 File Offset: 0x00008754
		// (set) Token: 0x06000170 RID: 368 RVA: 0x000025ED File Offset: 0x000007ED
		public unsafe static double kMinDuration
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimelineClip.NativeFieldInfoPtr_kMinDuration, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimelineClip.NativeFieldInfoPtr_kMinDuration, (void*)(&value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000A570 File Offset: 0x00008770
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000025FB File Offset: 0x000007FB
		public unsafe static double kMaxTimeValue
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimelineClip.NativeFieldInfoPtr_kMaxTimeValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimelineClip.NativeFieldInfoPtr_kMaxTimeValue, (void*)(&value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000A58C File Offset: 0x0000878C
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002609 File Offset: 0x00000809
		public unsafe double m_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_Start)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000A5B4 File Offset: 0x000087B4
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002624 File Offset: 0x00000824
		public unsafe double m_ClipIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_ClipIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_ClipIn)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000A5DC File Offset: 0x000087DC
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0000263F File Offset: 0x0000083F
		public unsafe Object m_Asset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_Asset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_Asset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000A60C File Offset: 0x0000880C
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000265E File Offset: 0x0000085E
		public unsafe double m_Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_Duration)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000A634 File Offset: 0x00008834
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002679 File Offset: 0x00000879
		public unsafe double m_TimeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_TimeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_TimeScale)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000A65C File Offset: 0x0000885C
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002694 File Offset: 0x00000894
		public unsafe TrackAsset m_ParentTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_ParentTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_ParentTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000A68C File Offset: 0x0000888C
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000026B3 File Offset: 0x000008B3
		public unsafe double m_EaseInDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_EaseInDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_EaseInDuration)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000A6B4 File Offset: 0x000088B4
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000026CE File Offset: 0x000008CE
		public unsafe double m_EaseOutDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_EaseOutDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_EaseOutDuration)) = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000A6DC File Offset: 0x000088DC
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000026E9 File Offset: 0x000008E9
		public unsafe double m_BlendInDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_BlendInDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_BlendInDuration)) = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000A704 File Offset: 0x00008904
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002704 File Offset: 0x00000904
		public unsafe double m_BlendOutDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_BlendOutDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_BlendOutDuration)) = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000A72C File Offset: 0x0000892C
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000271F File Offset: 0x0000091F
		public unsafe AnimationCurve m_MixInCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_MixInCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_MixInCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000A75C File Offset: 0x0000895C
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0000273E File Offset: 0x0000093E
		public unsafe AnimationCurve m_MixOutCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_MixOutCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_MixOutCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000A78C File Offset: 0x0000898C
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000275D File Offset: 0x0000095D
		public unsafe TimelineClip.BlendCurveMode m_BlendInCurveMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_BlendInCurveMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_BlendInCurveMode)) = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000A7B4 File Offset: 0x000089B4
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002778 File Offset: 0x00000978
		public unsafe TimelineClip.BlendCurveMode m_BlendOutCurveMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_BlendOutCurveMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_BlendOutCurveMode)) = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000A7DC File Offset: 0x000089DC
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002793 File Offset: 0x00000993
		public unsafe List<string> m_ExposedParameterNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_ExposedParameterNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_ExposedParameterNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000A80C File Offset: 0x00008A0C
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000027B2 File Offset: 0x000009B2
		public unsafe AnimationClip m_AnimationCurves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_AnimationCurves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_AnimationCurves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000A83C File Offset: 0x00008A3C
		// (set) Token: 0x06000194 RID: 404 RVA: 0x000027D1 File Offset: 0x000009D1
		public unsafe bool m_Recordable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_Recordable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_Recordable)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000A864 File Offset: 0x00008A64
		// (set) Token: 0x06000196 RID: 406 RVA: 0x000027EC File Offset: 0x000009EC
		public unsafe TimelineClip.ClipExtrapolation m_PostExtrapolationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_PostExtrapolationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_PostExtrapolationMode)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000A88C File Offset: 0x00008A8C
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002807 File Offset: 0x00000A07
		public unsafe TimelineClip.ClipExtrapolation m_PreExtrapolationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_PreExtrapolationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_PreExtrapolationMode)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002822 File Offset: 0x00000A22
		public unsafe double m_PostExtrapolationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_PostExtrapolationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_PostExtrapolationTime)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000A8DC File Offset: 0x00008ADC
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0000283D File Offset: 0x00000A3D
		public unsafe double m_PreExtrapolationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_PreExtrapolationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_PreExtrapolationTime)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000A904 File Offset: 0x00008B04
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002858 File Offset: 0x00000A58
		public unsafe string m_DisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_DisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineClip.NativeFieldInfoPtr_m_DisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_k_LatestVersion;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultClipCaps;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultClipDurationInSeconds;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_kTimeScaleMin;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_kTimeScaleMax;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultCurvesName;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_kMinDuration;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_kMaxTimeValue;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_m_Start;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipIn;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_m_Asset;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeScale;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentTrack;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_m_EaseInDuration;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_m_EaseOutDuration;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendInDuration;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendOutDuration;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_m_MixInCurve;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_m_MixOutCurve;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendInCurveMode;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendOutCurveMode;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_m_ExposedParameterNames;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimationCurves;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_m_Recordable;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_m_PostExtrapolationMode;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_m_PreExtrapolationMode;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_m_PostExtrapolationTime;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_m_PreExtrapolationTime;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayName;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TrackAsset_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_get_hasPreExtrapolation_Public_get_Boolean_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_get_hasPostExtrapolation_Public_get_Boolean_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_get_timeScale_Public_get_Double_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_set_timeScale_Public_set_Void_Double_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_get_start_Public_get_Double_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_set_start_Public_set_Void_Double_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Double_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_set_duration_Public_set_Void_Double_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_get_end_Public_get_Double_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_get_clipIn_Public_get_Double_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_set_clipIn_Public_set_Void_Double_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_get_displayName_Public_get_String_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_get_clipAssetDuration_Public_get_Double_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_curves_Public_Virtual_Final_New_get_AnimationClip_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_set_curves_Internal_set_Void_AnimationClip_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_defaultCurvesName_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_get_hasCurves_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_get_asset_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_set_asset_Public_set_Void_Object_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_assetOwner_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_targetTrack_Private_Virtual_Final_New_get_TrackAsset_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_get_underlyingAsset_Public_get_Object_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_set_underlyingAsset_Public_set_Void_Object_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_get_parentTrack_Public_get_TrackAsset_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_set_parentTrack_Public_set_Void_TrackAsset_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_get_easeInDuration_Public_get_Double_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_set_easeInDuration_Public_set_Void_Double_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_get_easeOutDuration_Public_get_Double_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_set_easeOutDuration_Public_set_Void_Double_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_get_eastOutTime_Public_get_Double_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_easeOutTime_Public_get_Double_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_get_blendInDuration_Public_get_Double_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_set_blendInDuration_Public_set_Void_Double_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_get_blendOutDuration_Public_get_Double_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_set_blendOutDuration_Public_set_Void_Double_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_get_blendInCurveMode_Public_get_BlendCurveMode_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_set_blendInCurveMode_Public_set_Void_BlendCurveMode_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_get_blendOutCurveMode_Public_get_BlendCurveMode_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_set_blendOutCurveMode_Public_set_Void_BlendCurveMode_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_get_hasBlendIn_Public_get_Boolean_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_get_hasBlendOut_Public_get_Boolean_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_get_mixInCurve_Public_get_AnimationCurve_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_set_mixInCurve_Public_set_Void_AnimationCurve_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_get_mixInPercentage_Public_get_Single_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_mixInDuration_Public_get_Double_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_mixOutCurve_Public_get_AnimationCurve_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_set_mixOutCurve_Public_set_Void_AnimationCurve_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_mixOutTime_Public_get_Double_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_get_mixOutDuration_Public_get_Double_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_get_mixOutPercentage_Public_get_Single_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_get_recordable_Public_get_Boolean_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_set_recordable_Internal_set_Void_Boolean_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_get_exposedParameters_Public_get_List_1_String_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_get_clipCaps_Public_get_ClipCaps_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_Hash_Internal_Int32_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateMixOut_Public_Single_Double_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateMixIn_Public_Single_Double_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultMixInCurve_Private_Static_AnimationCurve_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultMixOutCurve_Private_Static_AnimationCurve_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_ToLocalTime_Public_Double_Double_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_ToLocalTimeUnbound_Public_Double_Double_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_FromLocalTimeUnbound_Internal_Double_Double_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_get_animationClip_Public_get_AnimationClip_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeTimeValue_Private_Static_Double_Double_Double_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_get_postExtrapolationMode_Public_get_ClipExtrapolation_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_set_postExtrapolationMode_Internal_set_Void_ClipExtrapolation_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_get_preExtrapolationMode_Public_get_ClipExtrapolation_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_set_preExtrapolationMode_Internal_set_Void_ClipExtrapolation_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_SetPostExtrapolationTime_Internal_Void_Double_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_SetPreExtrapolationTime_Internal_Void_Double_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_IsExtrapolatedTime_Public_Boolean_Double_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_IsPreExtrapolatedTime_Public_Boolean_Double_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_IsPostExtrapolatedTime_Public_Boolean_Double_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_get_extrapolatedStart_Public_get_Double_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_get_extrapolatedDuration_Public_get_Double_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_GetExtrapolatedTime_Private_Static_Double_Double_ClipExtrapolation_Double_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_CreateCurves_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_ConformEaseValues_Public_Void_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_CalculateEasingRatio_Private_Static_Double_Double_Double_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDirty_Private_Void_Double_Double_0;

		// Token: 0x02000059 RID: 89
		[OriginalName("Unity.Timeline.dll", "", "Versions")]
		public enum Versions
		{
			// Token: 0x04000420 RID: 1056
			Initial,
			// Token: 0x04000421 RID: 1057
			ClipInFromGlobalToLocal
		}

		// Token: 0x0200005A RID: 90
		public static class TimelineClipUpgrade : Object
		{
			// Token: 0x06000557 RID: 1367 RVA: 0x00003C9D File Offset: 0x00001E9D
			// Note: this type is marked as 'beforefieldinit'.
			static TimelineClipUpgrade()
			{
				Il2CppClassPointerStore<TimelineClip.TimelineClipUpgrade>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "TimelineClipUpgrade");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineClip.TimelineClipUpgrade>.NativeClassPtr);
				TimelineClip.TimelineClipUpgrade.NativeMethodInfoPtr_UpgradeClipInFromGlobalToLocal_Public_Static_Void_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip.TimelineClipUpgrade>.NativeClassPtr, 100663557);
			}

			// Token: 0x06000558 RID: 1368 RVA: 0x000196F4 File Offset: 0x000178F4
			[CallerCount(0)]
			public unsafe static void UpgradeClipInFromGlobalToLocal(TimelineClip clip)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClip.TimelineClipUpgrade.NativeMethodInfoPtr_UpgradeClipInFromGlobalToLocal_Public_Static_Void_TimelineClip_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000559 RID: 1369 RVA: 0x00003CD1 File Offset: 0x00001ED1
			public TimelineClipUpgrade(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000422 RID: 1058
			private static readonly IntPtr NativeMethodInfoPtr_UpgradeClipInFromGlobalToLocal_Public_Static_Void_TimelineClip_0;
		}

		// Token: 0x0200005B RID: 91
		[OriginalName("Unity.Timeline.dll", "", "ClipExtrapolation")]
		public enum ClipExtrapolation
		{
			// Token: 0x04000424 RID: 1060
			None,
			// Token: 0x04000425 RID: 1061
			Hold,
			// Token: 0x04000426 RID: 1062
			Loop,
			// Token: 0x04000427 RID: 1063
			PingPong,
			// Token: 0x04000428 RID: 1064
			Continue
		}

		// Token: 0x0200005C RID: 92
		[OriginalName("Unity.Timeline.dll", "", "BlendCurveMode")]
		public enum BlendCurveMode
		{
			// Token: 0x0400042A RID: 1066
			Auto,
			// Token: 0x0400042B RID: 1067
			Manual
		}
	}
}
