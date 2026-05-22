using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Audio;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public sealed class AudioSource : AudioBehaviour
	{
		// Token: 0x06000055 RID: 85 RVA: 0x0000427C File Offset: 0x0000247C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSource()
		{
			Il2CppClassPointerStore<AudioSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSource>.NativeClassPtr);
			AudioSource.NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663340);
			AudioSource.NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663341);
			AudioSource.NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663342);
			AudioSource.NativeMethodInfoPtr_Play_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663343);
			AudioSource.NativeMethodInfoPtr_PlayOneShotHelper_Private_Static_Void_AudioSource_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663344);
			AudioSource.NativeMethodInfoPtr_Stop_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663345);
			AudioSource.NativeMethodInfoPtr_SetCustomCurveHelper_Private_Static_Void_AudioSource_AudioSourceCurveType_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663346);
			AudioSource.NativeMethodInfoPtr_get_volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663347);
			AudioSource.NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663348);
			AudioSource.NativeMethodInfoPtr_get_pitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663349);
			AudioSource.NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663350);
			AudioSource.NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663351);
			AudioSource.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663352);
			AudioSource.NativeMethodInfoPtr_get_timeSamples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663353);
			AudioSource.NativeMethodInfoPtr_set_timeSamples_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663354);
			AudioSource.NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663355);
			AudioSource.NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663356);
			AudioSource.NativeMethodInfoPtr_get_outputAudioMixerGroup_Public_get_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663357);
			AudioSource.NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663358);
			AudioSource.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663359);
			AudioSource.NativeMethodInfoPtr_PlayScheduled_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663360);
			AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663361);
			AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663362);
			AudioSource.NativeMethodInfoPtr_SetScheduledEndTime_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663363);
			AudioSource.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663364);
			AudioSource.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663365);
			AudioSource.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663366);
			AudioSource.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663367);
			AudioSource.NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663368);
			AudioSource.NativeMethodInfoPtr_set_ignoreListenerVolume_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663369);
			AudioSource.NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663370);
			AudioSource.NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663371);
			AudioSource.NativeMethodInfoPtr_set_ignoreListenerPause_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663372);
			AudioSource.NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663373);
			AudioSource.NativeMethodInfoPtr_get_panStereo_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663374);
			AudioSource.NativeMethodInfoPtr_set_panStereo_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663375);
			AudioSource.NativeMethodInfoPtr_set_spatialBlend_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663376);
			AudioSource.NativeMethodInfoPtr_get_spatialize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663377);
			AudioSource.NativeMethodInfoPtr_set_spatialize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663378);
			AudioSource.NativeMethodInfoPtr_set_spatializePostEffects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663379);
			AudioSource.NativeMethodInfoPtr_SetCustomCurve_Public_Void_AudioSourceCurveType_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663380);
			AudioSource.NativeMethodInfoPtr_set_bypassEffects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663381);
			AudioSource.NativeMethodInfoPtr_set_bypassListenerEffects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663382);
			AudioSource.NativeMethodInfoPtr_set_bypassReverbZones_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663383);
			AudioSource.NativeMethodInfoPtr_set_dopplerLevel_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663384);
			AudioSource.NativeMethodInfoPtr_set_spread_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663385);
			AudioSource.NativeMethodInfoPtr_get_priority_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663386);
			AudioSource.NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663387);
			AudioSource.NativeMethodInfoPtr_set_mute_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663388);
			AudioSource.NativeMethodInfoPtr_set_minDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663389);
			AudioSource.NativeMethodInfoPtr_get_maxDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663390);
			AudioSource.NativeMethodInfoPtr_set_maxDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663391);
			AudioSource.NativeMethodInfoPtr_set_rolloffMode_Public_set_Void_AudioRolloffMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663392);
			AudioSource.NativeMethodInfoPtr_SetSpatializerFloat_Public_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663393);
			AudioSource.NativeMethodInfoPtr_SetAmbisonicDecoderFloat_Public_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663394);
			AudioSource.GetCustomCurveHelperDelegateField = IL2CPP.ResolveICall<AudioSource.GetCustomCurveHelperDelegate>("UnityEngine.AudioSource::GetCustomCurveHelper");
			AudioSource.GetOutputDataHelperDelegateField = IL2CPP.ResolveICall<AudioSource.GetOutputDataHelperDelegate>("UnityEngine.AudioSource::GetOutputDataHelper");
			AudioSource.GetSpectrumDataHelperDelegateField = IL2CPP.ResolveICall<AudioSource.GetSpectrumDataHelperDelegate>("UnityEngine.AudioSource::GetSpectrumDataHelper");
			AudioSource.SetScheduledStartTimeDelegateField = IL2CPP.ResolveICall<AudioSource.SetScheduledStartTimeDelegate>("UnityEngine.AudioSource::SetScheduledStartTime");
			AudioSource.UnPauseDelegateField = IL2CPP.ResolveICall<AudioSource.UnPauseDelegate>("UnityEngine.AudioSource::UnPause");
			AudioSource.get_isVirtualDelegateField = IL2CPP.ResolveICall<AudioSource.get_isVirtualDelegate>("UnityEngine.AudioSource::get_isVirtual");
			AudioSource.get_ignoreListenerVolumeDelegateField = IL2CPP.ResolveICall<AudioSource.get_ignoreListenerVolumeDelegate>("UnityEngine.AudioSource::get_ignoreListenerVolume");
			AudioSource.get_ignoreListenerPauseDelegateField = IL2CPP.ResolveICall<AudioSource.get_ignoreListenerPauseDelegate>("UnityEngine.AudioSource::get_ignoreListenerPause");
			AudioSource.get_velocityUpdateModeDelegateField = IL2CPP.ResolveICall<AudioSource.get_velocityUpdateModeDelegate>("UnityEngine.AudioSource::get_velocityUpdateMode");
			AudioSource.get_spatialBlendDelegateField = IL2CPP.ResolveICall<AudioSource.get_spatialBlendDelegate>("UnityEngine.AudioSource::get_spatialBlend");
			AudioSource.get_spatializePostEffectsDelegateField = IL2CPP.ResolveICall<AudioSource.get_spatializePostEffectsDelegate>("UnityEngine.AudioSource::get_spatializePostEffects");
			AudioSource.get_reverbZoneMixDelegateField = IL2CPP.ResolveICall<AudioSource.get_reverbZoneMixDelegate>("UnityEngine.AudioSource::get_reverbZoneMix");
			AudioSource.set_reverbZoneMixDelegateField = IL2CPP.ResolveICall<AudioSource.set_reverbZoneMixDelegate>("UnityEngine.AudioSource::set_reverbZoneMix");
			AudioSource.get_bypassEffectsDelegateField = IL2CPP.ResolveICall<AudioSource.get_bypassEffectsDelegate>("UnityEngine.AudioSource::get_bypassEffects");
			AudioSource.get_bypassListenerEffectsDelegateField = IL2CPP.ResolveICall<AudioSource.get_bypassListenerEffectsDelegate>("UnityEngine.AudioSource::get_bypassListenerEffects");
			AudioSource.get_bypassReverbZonesDelegateField = IL2CPP.ResolveICall<AudioSource.get_bypassReverbZonesDelegate>("UnityEngine.AudioSource::get_bypassReverbZones");
			AudioSource.get_dopplerLevelDelegateField = IL2CPP.ResolveICall<AudioSource.get_dopplerLevelDelegate>("UnityEngine.AudioSource::get_dopplerLevel");
			AudioSource.get_spreadDelegateField = IL2CPP.ResolveICall<AudioSource.get_spreadDelegate>("UnityEngine.AudioSource::get_spread");
			AudioSource.get_muteDelegateField = IL2CPP.ResolveICall<AudioSource.get_muteDelegate>("UnityEngine.AudioSource::get_mute");
			AudioSource.get_minDistanceDelegateField = IL2CPP.ResolveICall<AudioSource.get_minDistanceDelegate>("UnityEngine.AudioSource::get_minDistance");
			AudioSource.get_rolloffModeDelegateField = IL2CPP.ResolveICall<AudioSource.get_rolloffModeDelegate>("UnityEngine.AudioSource::get_rolloffMode");
			AudioSource.GetSpatializerFloatDelegateField = IL2CPP.ResolveICall<AudioSource.GetSpatializerFloatDelegate>("UnityEngine.AudioSource::GetSpatializerFloat");
			AudioSource.GetAmbisonicDecoderFloatDelegateField = IL2CPP.ResolveICall<AudioSource.GetAmbisonicDecoderFloatDelegate>("UnityEngine.AudioSource::GetAmbisonicDecoderFloat");
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004854 File Offset: 0x00002A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484869, XrefRangeEnd = 484873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPitch(AudioSource source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004898 File Offset: 0x00002A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 484877, RefRangeEnd = 484879, XrefRangeStart = 484873, XrefRangeEnd = 484877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPitch(AudioSource source, float pitch)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000048DC File Offset: 0x00002ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484879, XrefRangeEnd = 484883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayHelper(AudioSource source, ulong delay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004920 File Offset: 0x00002B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484883, XrefRangeEnd = 484887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(double delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Play_Private_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004960 File Offset: 0x00002B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484887, XrefRangeEnd = 484891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayOneShotHelper_Private_Static_Void_AudioSource_AudioClip_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000049B8 File Offset: 0x00002BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484891, XrefRangeEnd = 484895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(bool stopOneShots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopOneShots;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Stop_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000049F8 File Offset: 0x00002BF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 484899, RefRangeEnd = 484901, XrefRangeStart = 484895, XrefRangeEnd = 484899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetCustomCurveHelper_Private_Static_Void_AudioSource_AudioSourceCurveType_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00004A50 File Offset: 0x00002C50
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00004A8C File Offset: 0x00002C8C
		public unsafe float volume
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 484905, RefRangeEnd = 484909, XrefRangeStart = 484901, XrefRangeEnd = 484905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 484913, RefRangeEnd = 484938, XrefRangeStart = 484909, XrefRangeEnd = 484913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00004ACC File Offset: 0x00002CCC
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00004B08 File Offset: 0x00002D08
		public unsafe float pitch
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_pitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 484877, RefRangeEnd = 484879, XrefRangeStart = 484877, XrefRangeEnd = 484879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00004B48 File Offset: 0x00002D48
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00004B84 File Offset: 0x00002D84
		public unsafe float time
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 484942, RefRangeEnd = 484943, XrefRangeStart = 484938, XrefRangeEnd = 484942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 484947, RefRangeEnd = 484949, XrefRangeStart = 484943, XrefRangeEnd = 484947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00004BC4 File Offset: 0x00002DC4
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00004C00 File Offset: 0x00002E00
		public unsafe int timeSamples
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 484953, RefRangeEnd = 484954, XrefRangeStart = 484949, XrefRangeEnd = 484953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_timeSamples_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 484958, RefRangeEnd = 484960, XrefRangeStart = 484954, XrefRangeEnd = 484958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_timeSamples_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00004C40 File Offset: 0x00002E40
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00004C80 File Offset: 0x00002E80
		public unsafe AudioClip clip
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 484964, RefRangeEnd = 484967, XrefRangeStart = 484960, XrefRangeEnd = 484964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 484971, RefRangeEnd = 484980, XrefRangeStart = 484967, XrefRangeEnd = 484971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00004CC4 File Offset: 0x00002EC4
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00004D04 File Offset: 0x00002F04
		public unsafe AudioMixerGroup outputAudioMixerGroup
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484980, XrefRangeEnd = 484984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_outputAudioMixerGroup_Public_get_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 484988, RefRangeEnd = 484992, XrefRangeStart = 484984, XrefRangeEnd = 484988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004D48 File Offset: 0x00002F48
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 484996, RefRangeEnd = 485002, XrefRangeStart = 484992, XrefRangeEnd = 484996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004D7C File Offset: 0x00002F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485002, XrefRangeEnd = 485007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayScheduled(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayScheduled_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004DBC File Offset: 0x00002FBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 485027, RefRangeEnd = 485033, XrefRangeStart = 485007, XrefRangeEnd = 485027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOneShot(AudioClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004E00 File Offset: 0x00003000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485033, XrefRangeEnd = 485053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOneShot(AudioClip clip, float volumeScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004E50 File Offset: 0x00003050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485057, RefRangeEnd = 485058, XrefRangeStart = 485053, XrefRangeEnd = 485057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScheduledEndTime(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetScheduledEndTime_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004E90 File Offset: 0x00003090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485062, RefRangeEnd = 485063, XrefRangeStart = 485058, XrefRangeEnd = 485062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004EC4 File Offset: 0x000030C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485063, XrefRangeEnd = 485067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00004EF8 File Offset: 0x000030F8
		public unsafe bool isPlaying
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 485071, RefRangeEnd = 485075, XrefRangeStart = 485067, XrefRangeEnd = 485071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00004F34 File Offset: 0x00003134
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00004F70 File Offset: 0x00003170
		public unsafe bool loop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485075, XrefRangeEnd = 485079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 485083, RefRangeEnd = 485090, XrefRangeStart = 485079, XrefRangeEnd = 485083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002349 File Offset: 0x00000549
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00004FB0 File Offset: 0x000031B0
		public unsafe bool ignoreListenerVolume
		{
			get
			{
				return AudioSource.get_ignoreListenerVolumeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485090, XrefRangeEnd = 485094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_ignoreListenerVolume_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004FF0 File Offset: 0x000031F0
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000502C File Offset: 0x0000322C
		public unsafe bool playOnAwake
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485094, XrefRangeEnd = 485098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485098, XrefRangeEnd = 485102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000235B File Offset: 0x0000055B
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000506C File Offset: 0x0000326C
		public unsafe bool ignoreListenerPause
		{
			get
			{
				return AudioSource.get_ignoreListenerPauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485102, XrefRangeEnd = 485106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_ignoreListenerPause_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000236D File Offset: 0x0000056D
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000050AC File Offset: 0x000032AC
		public unsafe AudioVelocityUpdateMode velocityUpdateMode
		{
			get
			{
				return AudioSource.get_velocityUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485106, XrefRangeEnd = 485110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000050EC File Offset: 0x000032EC
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00005128 File Offset: 0x00003328
		public unsafe float panStereo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485110, XrefRangeEnd = 485114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_panStereo_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 485118, RefRangeEnd = 485121, XrefRangeStart = 485114, XrefRangeEnd = 485118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_panStereo_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000237F File Offset: 0x0000057F
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00005168 File Offset: 0x00003368
		public unsafe float spatialBlend
		{
			get
			{
				return AudioSource.get_spatialBlendDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 485125, RefRangeEnd = 485128, XrefRangeStart = 485121, XrefRangeEnd = 485125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_spatialBlend_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000051A8 File Offset: 0x000033A8
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000051E4 File Offset: 0x000033E4
		public unsafe bool spatialize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 485132, RefRangeEnd = 485133, XrefRangeStart = 485128, XrefRangeEnd = 485132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_spatialize_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 485137, RefRangeEnd = 485139, XrefRangeStart = 485133, XrefRangeEnd = 485137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_spatialize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002391 File Offset: 0x00000591
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00005224 File Offset: 0x00003424
		public unsafe bool spatializePostEffects
		{
			get
			{
				return AudioSource.get_spatializePostEffectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485139, XrefRangeEnd = 485143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_spatializePostEffects_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005264 File Offset: 0x00003464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 484899, RefRangeEnd = 484901, XrefRangeStart = 484899, XrefRangeEnd = 484901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetCustomCurve_Public_Void_AudioSourceCurveType_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000023C8 File Offset: 0x000005C8
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000052B4 File Offset: 0x000034B4
		public unsafe bool bypassEffects
		{
			get
			{
				return AudioSource.get_bypassEffectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485143, XrefRangeEnd = 485147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_bypassEffects_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000023DA File Offset: 0x000005DA
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000052F4 File Offset: 0x000034F4
		public unsafe bool bypassListenerEffects
		{
			get
			{
				return AudioSource.get_bypassListenerEffectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485147, XrefRangeEnd = 485151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_bypassListenerEffects_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000023EC File Offset: 0x000005EC
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00005334 File Offset: 0x00003534
		public unsafe bool bypassReverbZones
		{
			get
			{
				return AudioSource.get_bypassReverbZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 485155, RefRangeEnd = 485156, XrefRangeStart = 485151, XrefRangeEnd = 485155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_bypassReverbZones_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000023FE File Offset: 0x000005FE
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00005374 File Offset: 0x00003574
		public unsafe float dopplerLevel
		{
			get
			{
				return AudioSource.get_dopplerLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 485160, RefRangeEnd = 485162, XrefRangeStart = 485156, XrefRangeEnd = 485160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_dopplerLevel_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002410 File Offset: 0x00000610
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000053B4 File Offset: 0x000035B4
		public unsafe float spread
		{
			get
			{
				return AudioSource.get_spreadDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485162, XrefRangeEnd = 485166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_spread_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000053F4 File Offset: 0x000035F4
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00005430 File Offset: 0x00003630
		public unsafe int priority
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485166, XrefRangeEnd = 485170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_priority_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 485174, RefRangeEnd = 485176, XrefRangeStart = 485170, XrefRangeEnd = 485174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002422 File Offset: 0x00000622
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00005470 File Offset: 0x00003670
		public unsafe bool mute
		{
			get
			{
				return AudioSource.get_muteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 485180, RefRangeEnd = 485182, XrefRangeStart = 485176, XrefRangeEnd = 485180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_mute_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002434 File Offset: 0x00000634
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000054B0 File Offset: 0x000036B0
		public unsafe float minDistance
		{
			get
			{
				return AudioSource.get_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 485186, RefRangeEnd = 485190, XrefRangeStart = 485182, XrefRangeEnd = 485186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_minDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000054F0 File Offset: 0x000036F0
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000552C File Offset: 0x0000372C
		public unsafe float maxDistance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 485194, RefRangeEnd = 485195, XrefRangeStart = 485190, XrefRangeEnd = 485194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_maxDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 485199, RefRangeEnd = 485202, XrefRangeStart = 485195, XrefRangeEnd = 485199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_maxDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002446 File Offset: 0x00000646
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000556C File Offset: 0x0000376C
		public unsafe AudioRolloffMode rolloffMode
		{
			get
			{
				return AudioSource.get_rolloffModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 485206, RefRangeEnd = 485210, XrefRangeStart = 485202, XrefRangeEnd = 485206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_rolloffMode_Public_set_Void_AudioRolloffMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000055AC File Offset: 0x000037AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485210, XrefRangeEnd = 485214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetSpatializerFloat(int index, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetSpatializerFloat_Public_Boolean_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005604 File Offset: 0x00003804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485218, RefRangeEnd = 485220, XrefRangeStart = 485214, XrefRangeEnd = 485218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetAmbisonicDecoderFloat(int index, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetAmbisonicDecoderFloat_Public_Boolean_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000229B File Offset: 0x0000049B
		public AudioSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000565C File Offset: 0x0000385C
		public static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type)
		{
			IntPtr intPtr = AudioSource.GetCustomCurveHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), type);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000022A4 File Offset: 0x000004A4
		public static void GetOutputDataHelper(AudioSource source, [Out] Il2CppStructArray<float> samples, int channel)
		{
			AudioSource.GetOutputDataHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(samples), channel);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000022BD File Offset: 0x000004BD
		public static void GetSpectrumDataHelper(AudioSource source, [Out] Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			AudioSource.GetSpectrumDataHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(samples), channel, window);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000022D7 File Offset: 0x000004D7
		public void Play(ulong delay)
		{
			AudioSource.PlayHelper(this, delay);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000022E2 File Offset: 0x000004E2
		public void PlayDelayed(float delay)
		{
			this.Play((delay < 0f) ? 0.0 : (-(double)delay));
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002302 File Offset: 0x00000502
		public void SetScheduledStartTime(double time)
		{
			AudioSource.SetScheduledStartTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), time);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002315 File Offset: 0x00000515
		public void UnPause()
		{
			AudioSource.UnPauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002327 File Offset: 0x00000527
		public bool isVirtual
		{
			get
			{
				return AudioSource.get_isVirtualDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002339 File Offset: 0x00000539
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position)
		{
			AudioSource.PlayClipAtPoint(clip, position, 1f);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000568C File Offset: 0x0000388C
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume)
		{
			GameObject gameObject = new GameObject("One shot audio");
			gameObject.transform.position = position;
			AudioSource audioSource = gameObject.AddComponent(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AudioSource>())).Cast<AudioSource>();
			audioSource.clip = clip;
			audioSource.spatialBlend = 1f;
			audioSource.volume = volume;
			audioSource.Play();
			Object.Destroy(gameObject, clip.length * ((Time.timeScale < 0.01f) ? 0.01f : Time.timeScale));
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005714 File Offset: 0x00003914
		public AnimationCurve GetCustomCurve(AudioSourceCurveType type)
		{
			return AudioSource.GetCustomCurveHelper(this, type);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000023A3 File Offset: 0x000005A3
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000023B5 File Offset: 0x000005B5
		public float reverbZoneMix
		{
			get
			{
				return AudioSource.get_reverbZoneMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_reverbZoneMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002458 File Offset: 0x00000658
		public Il2CppStructArray<float> GetOutputData(int numSamples, int channel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002465 File Offset: 0x00000665
		public void GetOutputData(Il2CppStructArray<float> samples, int channel)
		{
			AudioSource.GetOutputDataHelper(this, samples, channel);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002471 File Offset: 0x00000671
		public Il2CppStructArray<float> GetSpectrumData(int numSamples, int channel, FFTWindow window)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000247E File Offset: 0x0000067E
		public void GetSpectrumData(Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			AudioSource.GetSpectrumDataHelper(this, samples, channel, window);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00005730 File Offset: 0x00003930
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000248B File Offset: 0x0000068B
		public float minVolume
		{
			get
			{
				Debug.LogError("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
				return 0f;
			}
			set
			{
				Debug.LogError("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00005754 File Offset: 0x00003954
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002499 File Offset: 0x00000699
		public float maxVolume
		{
			get
			{
				Debug.LogError("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
				return 0f;
			}
			set
			{
				Debug.LogError("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00005778 File Offset: 0x00003978
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000024A7 File Offset: 0x000006A7
		public float rolloffFactor
		{
			get
			{
				Debug.LogError("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
				return 0f;
			}
			set
			{
				Debug.LogError("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000024B5 File Offset: 0x000006B5
		public bool GetSpatializerFloat(int index, out float value)
		{
			return AudioSource.GetSpatializerFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out value);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000024C9 File Offset: 0x000006C9
		public bool GetAmbisonicDecoderFloat(int index, out float value)
		{
			return AudioSource.GetAmbisonicDecoderFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out value);
		}

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_Double_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShotHelper_Private_Static_Void_AudioSource_AudioClip_Single_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_Boolean_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomCurveHelper_Private_Static_Void_AudioSource_AudioSourceCurveType_AnimationCurve_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_volume_Public_get_Single_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_pitch_Public_get_Single_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSamples_Public_get_Int32_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSamples_Public_set_Void_Int32_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_outputAudioMixerGroup_Public_get_AudioMixerGroup_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_PlayScheduled_Public_Void_Double_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_Single_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_SetScheduledEndTime_Public_Void_Double_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_loop_Public_get_Boolean_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreListenerVolume_Public_set_Void_Boolean_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreListenerPause_Public_set_Void_Boolean_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_get_panStereo_Public_get_Single_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_set_panStereo_Public_set_Void_Single_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_set_spatialBlend_Public_set_Void_Single_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_get_spatialize_Public_get_Boolean_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_set_spatialize_Public_set_Void_Boolean_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_set_spatializePostEffects_Public_set_Void_Boolean_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomCurve_Public_Void_AudioSourceCurveType_AnimationCurve_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_set_bypassEffects_Public_set_Void_Boolean_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_set_bypassListenerEffects_Public_set_Void_Boolean_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_set_bypassReverbZones_Public_set_Void_Boolean_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_set_dopplerLevel_Public_set_Void_Single_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_set_spread_Public_set_Void_Single_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_priority_Public_get_Int32_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_set_mute_Public_set_Void_Boolean_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_set_minDistance_Public_set_Void_Single_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_get_maxDistance_Public_get_Single_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_set_maxDistance_Public_set_Void_Single_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_set_rolloffMode_Public_set_Void_AudioRolloffMode_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_SetSpatializerFloat_Public_Boolean_Int32_Single_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_SetAmbisonicDecoderFloat_Public_Boolean_Int32_Single_0;

		// Token: 0x0400009F RID: 159
		private static readonly AudioSource.GetCustomCurveHelperDelegate GetCustomCurveHelperDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly AudioSource.GetOutputDataHelperDelegate GetOutputDataHelperDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly AudioSource.GetSpectrumDataHelperDelegate GetSpectrumDataHelperDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly AudioSource.SetScheduledStartTimeDelegate SetScheduledStartTimeDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly AudioSource.UnPauseDelegate UnPauseDelegateField;

		// Token: 0x040000A4 RID: 164
		private static readonly AudioSource.get_isVirtualDelegate get_isVirtualDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly AudioSource.get_ignoreListenerVolumeDelegate get_ignoreListenerVolumeDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly AudioSource.get_ignoreListenerPauseDelegate get_ignoreListenerPauseDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly AudioSource.get_velocityUpdateModeDelegate get_velocityUpdateModeDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly AudioSource.get_spatialBlendDelegate get_spatialBlendDelegateField;

		// Token: 0x040000A9 RID: 169
		private static readonly AudioSource.get_spatializePostEffectsDelegate get_spatializePostEffectsDelegateField;

		// Token: 0x040000AA RID: 170
		private static readonly AudioSource.get_reverbZoneMixDelegate get_reverbZoneMixDelegateField;

		// Token: 0x040000AB RID: 171
		private static readonly AudioSource.set_reverbZoneMixDelegate set_reverbZoneMixDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly AudioSource.get_bypassEffectsDelegate get_bypassEffectsDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly AudioSource.get_bypassListenerEffectsDelegate get_bypassListenerEffectsDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly AudioSource.get_bypassReverbZonesDelegate get_bypassReverbZonesDelegateField;

		// Token: 0x040000AF RID: 175
		private static readonly AudioSource.get_dopplerLevelDelegate get_dopplerLevelDelegateField;

		// Token: 0x040000B0 RID: 176
		private static readonly AudioSource.get_spreadDelegate get_spreadDelegateField;

		// Token: 0x040000B1 RID: 177
		private static readonly AudioSource.get_muteDelegate get_muteDelegateField;

		// Token: 0x040000B2 RID: 178
		private static readonly AudioSource.get_minDistanceDelegate get_minDistanceDelegateField;

		// Token: 0x040000B3 RID: 179
		private static readonly AudioSource.get_rolloffModeDelegate get_rolloffModeDelegateField;

		// Token: 0x040000B4 RID: 180
		private static readonly AudioSource.GetSpatializerFloatDelegate GetSpatializerFloatDelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly AudioSource.GetAmbisonicDecoderFloatDelegate GetAmbisonicDecoderFloatDelegateField;

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600024A RID: 586
		private delegate IntPtr GetCustomCurveHelperDelegate(IntPtr source, AudioSourceCurveType type);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x0600024C RID: 588
		private delegate void GetOutputDataHelperDelegate(IntPtr source, [Out] IntPtr samples, int channel);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x0600024E RID: 590
		private delegate void GetSpectrumDataHelperDelegate(IntPtr source, [Out] IntPtr samples, int channel, FFTWindow window);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000250 RID: 592
		private delegate void SetScheduledStartTimeDelegate(IntPtr @this, double time);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000252 RID: 594
		private delegate void UnPauseDelegate(IntPtr @this);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000254 RID: 596
		private delegate bool get_isVirtualDelegate(IntPtr @this);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000256 RID: 598
		private delegate bool get_ignoreListenerVolumeDelegate(IntPtr @this);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000258 RID: 600
		private delegate bool get_ignoreListenerPauseDelegate(IntPtr @this);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600025A RID: 602
		private delegate AudioVelocityUpdateMode get_velocityUpdateModeDelegate(IntPtr @this);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600025C RID: 604
		private delegate float get_spatialBlendDelegate(IntPtr @this);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x0600025E RID: 606
		private delegate bool get_spatializePostEffectsDelegate(IntPtr @this);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000260 RID: 608
		private delegate float get_reverbZoneMixDelegate(IntPtr @this);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000262 RID: 610
		private delegate void set_reverbZoneMixDelegate(IntPtr @this, float value);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000264 RID: 612
		private delegate bool get_bypassEffectsDelegate(IntPtr @this);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000266 RID: 614
		private delegate bool get_bypassListenerEffectsDelegate(IntPtr @this);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x06000268 RID: 616
		private delegate bool get_bypassReverbZonesDelegate(IntPtr @this);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x0600026A RID: 618
		private delegate float get_dopplerLevelDelegate(IntPtr @this);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x0600026C RID: 620
		private delegate float get_spreadDelegate(IntPtr @this);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x0600026E RID: 622
		private delegate bool get_muteDelegate(IntPtr @this);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000270 RID: 624
		private delegate float get_minDistanceDelegate(IntPtr @this);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000272 RID: 626
		private delegate AudioRolloffMode get_rolloffModeDelegate(IntPtr @this);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000274 RID: 628
		private delegate bool GetSpatializerFloatDelegate(IntPtr @this, int index, [Out] IntPtr value);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000276 RID: 630
		private delegate bool GetAmbisonicDecoderFloatDelegate(IntPtr @this, int index, [Out] IntPtr value);
	}
}
