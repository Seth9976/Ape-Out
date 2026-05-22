using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Video
{
	// Token: 0x0200000B RID: 11
	public sealed class VideoPlayer : Behaviour
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000032F4 File Offset: 0x000014F4
		// Note: this type is marked as 'beforefieldinit'.
		static VideoPlayer()
		{
			Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VideoModule.dll", "UnityEngine.Video", "VideoPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr);
			VideoPlayer.NativeFieldInfoPtr_prepareCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "prepareCompleted");
			VideoPlayer.NativeFieldInfoPtr_loopPointReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "loopPointReached");
			VideoPlayer.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "started");
			VideoPlayer.NativeFieldInfoPtr_frameDropped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "frameDropped");
			VideoPlayer.NativeFieldInfoPtr_errorReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "errorReceived");
			VideoPlayer.NativeFieldInfoPtr_seekCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "seekCompleted");
			VideoPlayer.NativeFieldInfoPtr_clockResyncOccurred = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "clockResyncOccurred");
			VideoPlayer.NativeFieldInfoPtr_frameReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "frameReady");
			VideoPlayer.NativeMethodInfoPtr_get_clip_Public_get_VideoClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663300);
			VideoPlayer.NativeMethodInfoPtr_set_clip_Public_set_Void_VideoClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663301);
			VideoPlayer.NativeMethodInfoPtr_InvokePrepareCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663302);
			VideoPlayer.NativeMethodInfoPtr_InvokeFrameReadyCallback_Internal_Private_Static_Void_VideoPlayer_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663303);
			VideoPlayer.NativeMethodInfoPtr_InvokeLoopPointReachedCallback_Internal_Private_Static_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663304);
			VideoPlayer.NativeMethodInfoPtr_InvokeStartedCallback_Internal_Private_Static_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663305);
			VideoPlayer.NativeMethodInfoPtr_InvokeFrameDroppedCallback_Internal_Private_Static_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663306);
			VideoPlayer.NativeMethodInfoPtr_InvokeErrorReceivedCallback_Internal_Private_Static_Void_VideoPlayer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663307);
			VideoPlayer.NativeMethodInfoPtr_InvokeSeekCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663308);
			VideoPlayer.NativeMethodInfoPtr_InvokeClockResyncOccurredCallback_Internal_Private_Static_Void_VideoPlayer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663309);
			VideoPlayer.get_sourceDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_sourceDelegate>("UnityEngine.Video.VideoPlayer::get_source");
			VideoPlayer.set_sourceDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_sourceDelegate>("UnityEngine.Video.VideoPlayer::set_source");
			VideoPlayer.get_urlDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_urlDelegate>("UnityEngine.Video.VideoPlayer::get_url");
			VideoPlayer.set_urlDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_urlDelegate>("UnityEngine.Video.VideoPlayer::set_url");
			VideoPlayer.get_renderModeDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_renderModeDelegate>("UnityEngine.Video.VideoPlayer::get_renderMode");
			VideoPlayer.set_renderModeDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_renderModeDelegate>("UnityEngine.Video.VideoPlayer::set_renderMode");
			VideoPlayer.get_targetCameraDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_targetCameraDelegate>("UnityEngine.Video.VideoPlayer::get_targetCamera");
			VideoPlayer.set_targetCameraDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_targetCameraDelegate>("UnityEngine.Video.VideoPlayer::set_targetCamera");
			VideoPlayer.get_targetTextureDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_targetTextureDelegate>("UnityEngine.Video.VideoPlayer::get_targetTexture");
			VideoPlayer.set_targetTextureDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_targetTextureDelegate>("UnityEngine.Video.VideoPlayer::set_targetTexture");
			VideoPlayer.get_targetMaterialRendererDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_targetMaterialRendererDelegate>("UnityEngine.Video.VideoPlayer::get_targetMaterialRenderer");
			VideoPlayer.set_targetMaterialRendererDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_targetMaterialRendererDelegate>("UnityEngine.Video.VideoPlayer::set_targetMaterialRenderer");
			VideoPlayer.get_targetMaterialPropertyDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_targetMaterialPropertyDelegate>("UnityEngine.Video.VideoPlayer::get_targetMaterialProperty");
			VideoPlayer.set_targetMaterialPropertyDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_targetMaterialPropertyDelegate>("UnityEngine.Video.VideoPlayer::set_targetMaterialProperty");
			VideoPlayer.get_aspectRatioDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_aspectRatioDelegate>("UnityEngine.Video.VideoPlayer::get_aspectRatio");
			VideoPlayer.set_aspectRatioDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_aspectRatioDelegate>("UnityEngine.Video.VideoPlayer::set_aspectRatio");
			VideoPlayer.get_targetCameraAlphaDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_targetCameraAlphaDelegate>("UnityEngine.Video.VideoPlayer::get_targetCameraAlpha");
			VideoPlayer.set_targetCameraAlphaDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_targetCameraAlphaDelegate>("UnityEngine.Video.VideoPlayer::set_targetCameraAlpha");
			VideoPlayer.get_targetCamera3DLayoutDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_targetCamera3DLayoutDelegate>("UnityEngine.Video.VideoPlayer::get_targetCamera3DLayout");
			VideoPlayer.set_targetCamera3DLayoutDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_targetCamera3DLayoutDelegate>("UnityEngine.Video.VideoPlayer::set_targetCamera3DLayout");
			VideoPlayer.get_textureDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_textureDelegate>("UnityEngine.Video.VideoPlayer::get_texture");
			VideoPlayer.PrepareDelegateField = IL2CPP.ResolveICall<VideoPlayer.PrepareDelegate>("UnityEngine.Video.VideoPlayer::Prepare");
			VideoPlayer.get_isPreparedDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_isPreparedDelegate>("UnityEngine.Video.VideoPlayer::get_isPrepared");
			VideoPlayer.get_waitForFirstFrameDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_waitForFirstFrameDelegate>("UnityEngine.Video.VideoPlayer::get_waitForFirstFrame");
			VideoPlayer.set_waitForFirstFrameDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_waitForFirstFrameDelegate>("UnityEngine.Video.VideoPlayer::set_waitForFirstFrame");
			VideoPlayer.get_playOnAwakeDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_playOnAwakeDelegate>("UnityEngine.Video.VideoPlayer::get_playOnAwake");
			VideoPlayer.set_playOnAwakeDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_playOnAwakeDelegate>("UnityEngine.Video.VideoPlayer::set_playOnAwake");
			VideoPlayer.PlayDelegateField = IL2CPP.ResolveICall<VideoPlayer.PlayDelegate>("UnityEngine.Video.VideoPlayer::Play");
			VideoPlayer.PauseDelegateField = IL2CPP.ResolveICall<VideoPlayer.PauseDelegate>("UnityEngine.Video.VideoPlayer::Pause");
			VideoPlayer.StopDelegateField = IL2CPP.ResolveICall<VideoPlayer.StopDelegate>("UnityEngine.Video.VideoPlayer::Stop");
			VideoPlayer.get_isPlayingDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_isPlayingDelegate>("UnityEngine.Video.VideoPlayer::get_isPlaying");
			VideoPlayer.get_isPausedDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_isPausedDelegate>("UnityEngine.Video.VideoPlayer::get_isPaused");
			VideoPlayer.get_canSetTimeDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_canSetTimeDelegate>("UnityEngine.Video.VideoPlayer::get_canSetTime");
			VideoPlayer.get_timeDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_timeDelegate>("UnityEngine.Video.VideoPlayer::get_time");
			VideoPlayer.set_timeDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_timeDelegate>("UnityEngine.Video.VideoPlayer::set_time");
			VideoPlayer.get_frameDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_frameDelegate>("UnityEngine.Video.VideoPlayer::get_frame");
			VideoPlayer.set_frameDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_frameDelegate>("UnityEngine.Video.VideoPlayer::set_frame");
			VideoPlayer.get_clockTimeDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_clockTimeDelegate>("UnityEngine.Video.VideoPlayer::get_clockTime");
			VideoPlayer.get_canStepDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_canStepDelegate>("UnityEngine.Video.VideoPlayer::get_canStep");
			VideoPlayer.StepForwardDelegateField = IL2CPP.ResolveICall<VideoPlayer.StepForwardDelegate>("UnityEngine.Video.VideoPlayer::StepForward");
			VideoPlayer.get_canSetPlaybackSpeedDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_canSetPlaybackSpeedDelegate>("UnityEngine.Video.VideoPlayer::get_canSetPlaybackSpeed");
			VideoPlayer.get_playbackSpeedDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_playbackSpeedDelegate>("UnityEngine.Video.VideoPlayer::get_playbackSpeed");
			VideoPlayer.set_playbackSpeedDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_playbackSpeedDelegate>("UnityEngine.Video.VideoPlayer::set_playbackSpeed");
			VideoPlayer.get_isLoopingDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_isLoopingDelegate>("UnityEngine.Video.VideoPlayer::get_isLooping");
			VideoPlayer.set_isLoopingDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_isLoopingDelegate>("UnityEngine.Video.VideoPlayer::set_isLooping");
			VideoPlayer.get_canSetTimeSourceDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_canSetTimeSourceDelegate>("UnityEngine.Video.VideoPlayer::get_canSetTimeSource");
			VideoPlayer.get_timeSourceDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_timeSourceDelegate>("UnityEngine.Video.VideoPlayer::get_timeSource");
			VideoPlayer.set_timeSourceDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_timeSourceDelegate>("UnityEngine.Video.VideoPlayer::set_timeSource");
			VideoPlayer.get_timeReferenceDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_timeReferenceDelegate>("UnityEngine.Video.VideoPlayer::get_timeReference");
			VideoPlayer.set_timeReferenceDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_timeReferenceDelegate>("UnityEngine.Video.VideoPlayer::set_timeReference");
			VideoPlayer.get_externalReferenceTimeDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_externalReferenceTimeDelegate>("UnityEngine.Video.VideoPlayer::get_externalReferenceTime");
			VideoPlayer.set_externalReferenceTimeDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_externalReferenceTimeDelegate>("UnityEngine.Video.VideoPlayer::set_externalReferenceTime");
			VideoPlayer.get_canSetSkipOnDropDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_canSetSkipOnDropDelegate>("UnityEngine.Video.VideoPlayer::get_canSetSkipOnDrop");
			VideoPlayer.get_skipOnDropDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_skipOnDropDelegate>("UnityEngine.Video.VideoPlayer::get_skipOnDrop");
			VideoPlayer.set_skipOnDropDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_skipOnDropDelegate>("UnityEngine.Video.VideoPlayer::set_skipOnDrop");
			VideoPlayer.get_frameCountDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_frameCountDelegate>("UnityEngine.Video.VideoPlayer::get_frameCount");
			VideoPlayer.get_frameRateDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_frameRateDelegate>("UnityEngine.Video.VideoPlayer::get_frameRate");
			VideoPlayer.get_lengthDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_lengthDelegate>("UnityEngine.Video.VideoPlayer::get_length");
			VideoPlayer.get_widthDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_widthDelegate>("UnityEngine.Video.VideoPlayer::get_width");
			VideoPlayer.get_heightDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_heightDelegate>("UnityEngine.Video.VideoPlayer::get_height");
			VideoPlayer.get_pixelAspectRatioNumeratorDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_pixelAspectRatioNumeratorDelegate>("UnityEngine.Video.VideoPlayer::get_pixelAspectRatioNumerator");
			VideoPlayer.get_pixelAspectRatioDenominatorDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_pixelAspectRatioDenominatorDelegate>("UnityEngine.Video.VideoPlayer::get_pixelAspectRatioDenominator");
			VideoPlayer.get_audioTrackCountDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_audioTrackCountDelegate>("UnityEngine.Video.VideoPlayer::get_audioTrackCount");
			VideoPlayer.GetAudioLanguageCodeDelegateField = IL2CPP.ResolveICall<VideoPlayer.GetAudioLanguageCodeDelegate>("UnityEngine.Video.VideoPlayer::GetAudioLanguageCode");
			VideoPlayer.GetAudioChannelCountDelegateField = IL2CPP.ResolveICall<VideoPlayer.GetAudioChannelCountDelegate>("UnityEngine.Video.VideoPlayer::GetAudioChannelCount");
			VideoPlayer.GetAudioSampleRateDelegateField = IL2CPP.ResolveICall<VideoPlayer.GetAudioSampleRateDelegate>("UnityEngine.Video.VideoPlayer::GetAudioSampleRate");
			VideoPlayer.get_controlledAudioTrackMaxCountDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_controlledAudioTrackMaxCountDelegate>("UnityEngine.Video.VideoPlayer::get_controlledAudioTrackMaxCount");
			VideoPlayer.GetControlledAudioTrackCountDelegateField = IL2CPP.ResolveICall<VideoPlayer.GetControlledAudioTrackCountDelegate>("UnityEngine.Video.VideoPlayer::GetControlledAudioTrackCount");
			VideoPlayer.SetControlledAudioTrackCountDelegateField = IL2CPP.ResolveICall<VideoPlayer.SetControlledAudioTrackCountDelegate>("UnityEngine.Video.VideoPlayer::SetControlledAudioTrackCount");
			VideoPlayer.EnableAudioTrackDelegateField = IL2CPP.ResolveICall<VideoPlayer.EnableAudioTrackDelegate>("UnityEngine.Video.VideoPlayer::EnableAudioTrack");
			VideoPlayer.IsAudioTrackEnabledDelegateField = IL2CPP.ResolveICall<VideoPlayer.IsAudioTrackEnabledDelegate>("UnityEngine.Video.VideoPlayer::IsAudioTrackEnabled");
			VideoPlayer.get_audioOutputModeDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_audioOutputModeDelegate>("UnityEngine.Video.VideoPlayer::get_audioOutputMode");
			VideoPlayer.set_audioOutputModeDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_audioOutputModeDelegate>("UnityEngine.Video.VideoPlayer::set_audioOutputMode");
			VideoPlayer.get_canSetDirectAudioVolumeDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_canSetDirectAudioVolumeDelegate>("UnityEngine.Video.VideoPlayer::get_canSetDirectAudioVolume");
			VideoPlayer.GetDirectAudioVolumeDelegateField = IL2CPP.ResolveICall<VideoPlayer.GetDirectAudioVolumeDelegate>("UnityEngine.Video.VideoPlayer::GetDirectAudioVolume");
			VideoPlayer.SetDirectAudioVolumeDelegateField = IL2CPP.ResolveICall<VideoPlayer.SetDirectAudioVolumeDelegate>("UnityEngine.Video.VideoPlayer::SetDirectAudioVolume");
			VideoPlayer.GetDirectAudioMuteDelegateField = IL2CPP.ResolveICall<VideoPlayer.GetDirectAudioMuteDelegate>("UnityEngine.Video.VideoPlayer::GetDirectAudioMute");
			VideoPlayer.SetDirectAudioMuteDelegateField = IL2CPP.ResolveICall<VideoPlayer.SetDirectAudioMuteDelegate>("UnityEngine.Video.VideoPlayer::SetDirectAudioMute");
			VideoPlayer.GetTargetAudioSourceDelegateField = IL2CPP.ResolveICall<VideoPlayer.GetTargetAudioSourceDelegate>("UnityEngine.Video.VideoPlayer::GetTargetAudioSource");
			VideoPlayer.SetTargetAudioSourceDelegateField = IL2CPP.ResolveICall<VideoPlayer.SetTargetAudioSourceDelegate>("UnityEngine.Video.VideoPlayer::SetTargetAudioSource");
			VideoPlayer.get_sendFrameReadyEventsDelegateField = IL2CPP.ResolveICall<VideoPlayer.get_sendFrameReadyEventsDelegate>("UnityEngine.Video.VideoPlayer::get_sendFrameReadyEvents");
			VideoPlayer.set_sendFrameReadyEventsDelegateField = IL2CPP.ResolveICall<VideoPlayer.set_sendFrameReadyEventsDelegate>("UnityEngine.Video.VideoPlayer::set_sendFrameReadyEvents");
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000395C File Offset: 0x00001B5C
		// (set) Token: 0x06000032 RID: 50 RVA: 0x0000399C File Offset: 0x00001B9C
		public unsafe VideoClip clip
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535005, XrefRangeEnd = 535009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.NativeMethodInfoPtr_get_clip_Public_get_VideoClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VideoClip>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535009, XrefRangeEnd = 535013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.NativeMethodInfoPtr_set_clip_Public_set_Void_VideoClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000039E0 File Offset: 0x00001BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535013, XrefRangeEnd = 535014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokePrepareCompletedCallback_Internal(VideoPlayer source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.NativeMethodInfoPtr_InvokePrepareCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003A18 File Offset: 0x00001C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535014, XrefRangeEnd = 535015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameIdx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.NativeMethodInfoPtr_InvokeFrameReadyCallback_Internal_Private_Static_Void_VideoPlayer_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003A5C File Offset: 0x00001C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535015, XrefRangeEnd = 535016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.NativeMethodInfoPtr_InvokeLoopPointReachedCallback_Internal_Private_Static_Void_VideoPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003A94 File Offset: 0x00001C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535016, XrefRangeEnd = 535017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeStartedCallback_Internal(VideoPlayer source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.NativeMethodInfoPtr_InvokeStartedCallback_Internal_Private_Static_Void_VideoPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003ACC File Offset: 0x00001CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535017, XrefRangeEnd = 535018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeFrameDroppedCallback_Internal(VideoPlayer source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.NativeMethodInfoPtr_InvokeFrameDroppedCallback_Internal_Private_Static_Void_VideoPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003B04 File Offset: 0x00001D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535018, XrefRangeEnd = 535019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorStr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.NativeMethodInfoPtr_InvokeErrorReceivedCallback_Internal_Private_Static_Void_VideoPlayer_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003B4C File Offset: 0x00001D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535019, XrefRangeEnd = 535020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeSeekCompletedCallback_Internal(VideoPlayer source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.NativeMethodInfoPtr_InvokeSeekCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003B84 File Offset: 0x00001D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535020, XrefRangeEnd = 535021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.NativeMethodInfoPtr_InvokeClockResyncOccurredCallback_Internal_Private_Static_Void_VideoPlayer_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002213 File Offset: 0x00000413
		public VideoPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003BC8 File Offset: 0x00001DC8
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0000221C File Offset: 0x0000041C
		public unsafe VideoPlayer.EventHandler prepareCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_prepareCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VideoPlayer.EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_prepareCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00003BF8 File Offset: 0x00001DF8
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000223B File Offset: 0x0000043B
		public unsafe VideoPlayer.EventHandler loopPointReached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_loopPointReached);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VideoPlayer.EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_loopPointReached), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003C28 File Offset: 0x00001E28
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000225A File Offset: 0x0000045A
		public unsafe VideoPlayer.EventHandler started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_started);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VideoPlayer.EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_started), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003C58 File Offset: 0x00001E58
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002279 File Offset: 0x00000479
		public unsafe VideoPlayer.EventHandler frameDropped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_frameDropped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VideoPlayer.EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_frameDropped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003C88 File Offset: 0x00001E88
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002298 File Offset: 0x00000498
		public unsafe VideoPlayer.ErrorEventHandler errorReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_errorReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VideoPlayer.ErrorEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_errorReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003CB8 File Offset: 0x00001EB8
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000022B7 File Offset: 0x000004B7
		public unsafe VideoPlayer.EventHandler seekCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_seekCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VideoPlayer.EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_seekCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003CE8 File Offset: 0x00001EE8
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000022D6 File Offset: 0x000004D6
		public unsafe VideoPlayer.TimeEventHandler clockResyncOccurred
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_clockResyncOccurred);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VideoPlayer.TimeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_clockResyncOccurred), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003D18 File Offset: 0x00001F18
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000022F5 File Offset: 0x000004F5
		public unsafe VideoPlayer.FrameReadyEventHandler frameReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_frameReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VideoPlayer.FrameReadyEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoPlayer.NativeFieldInfoPtr_frameReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002314 File Offset: 0x00000514
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002326 File Offset: 0x00000526
		public VideoSource source
		{
			get
			{
				return VideoPlayer.get_sourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_sourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003D48 File Offset: 0x00001F48
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002339 File Offset: 0x00000539
		public string url
		{
			get
			{
				IntPtr intPtr = VideoPlayer.get_urlDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				VideoPlayer.set_urlDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002351 File Offset: 0x00000551
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002363 File Offset: 0x00000563
		public VideoRenderMode renderMode
		{
			get
			{
				return VideoPlayer.get_renderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_renderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003D6C File Offset: 0x00001F6C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002376 File Offset: 0x00000576
		public Camera targetCamera
		{
			get
			{
				IntPtr intPtr = VideoPlayer.get_targetCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				VideoPlayer.set_targetCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003D98 File Offset: 0x00001F98
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000238E File Offset: 0x0000058E
		public RenderTexture targetTexture
		{
			get
			{
				IntPtr intPtr = VideoPlayer.get_targetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				VideoPlayer.set_targetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003DC4 File Offset: 0x00001FC4
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000023A6 File Offset: 0x000005A6
		public Renderer targetMaterialRenderer
		{
			get
			{
				IntPtr intPtr = VideoPlayer.get_targetMaterialRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				VideoPlayer.set_targetMaterialRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00003DF0 File Offset: 0x00001FF0
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000023BE File Offset: 0x000005BE
		public string targetMaterialProperty
		{
			get
			{
				IntPtr intPtr = VideoPlayer.get_targetMaterialPropertyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				VideoPlayer.set_targetMaterialPropertyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000023D6 File Offset: 0x000005D6
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000023E8 File Offset: 0x000005E8
		public VideoAspectRatio aspectRatio
		{
			get
			{
				return VideoPlayer.get_aspectRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_aspectRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000023FB File Offset: 0x000005FB
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000240D File Offset: 0x0000060D
		public float targetCameraAlpha
		{
			get
			{
				return VideoPlayer.get_targetCameraAlphaDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_targetCameraAlphaDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002420 File Offset: 0x00000620
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002432 File Offset: 0x00000632
		public Video3DLayout targetCamera3DLayout
		{
			get
			{
				return VideoPlayer.get_targetCamera3DLayoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_targetCamera3DLayoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00003E14 File Offset: 0x00002014
		public Texture texture
		{
			get
			{
				IntPtr intPtr = VideoPlayer.get_textureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002445 File Offset: 0x00000645
		public void Prepare()
		{
			VideoPlayer.PrepareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002457 File Offset: 0x00000657
		public bool isPrepared
		{
			get
			{
				return VideoPlayer.get_isPreparedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002469 File Offset: 0x00000669
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000247B File Offset: 0x0000067B
		public bool waitForFirstFrame
		{
			get
			{
				return VideoPlayer.get_waitForFirstFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_waitForFirstFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000248E File Offset: 0x0000068E
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000024A0 File Offset: 0x000006A0
		public bool playOnAwake
		{
			get
			{
				return VideoPlayer.get_playOnAwakeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_playOnAwakeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000024B3 File Offset: 0x000006B3
		public void Play()
		{
			VideoPlayer.PlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000024C5 File Offset: 0x000006C5
		public void Pause()
		{
			VideoPlayer.PauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000024D7 File Offset: 0x000006D7
		public void Stop()
		{
			VideoPlayer.StopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000024E9 File Offset: 0x000006E9
		public bool isPlaying
		{
			get
			{
				return VideoPlayer.get_isPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000024FB File Offset: 0x000006FB
		public bool isPaused
		{
			get
			{
				return VideoPlayer.get_isPausedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000250D File Offset: 0x0000070D
		public bool canSetTime
		{
			get
			{
				return VideoPlayer.get_canSetTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000251F File Offset: 0x0000071F
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002531 File Offset: 0x00000731
		public double time
		{
			get
			{
				return VideoPlayer.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002544 File Offset: 0x00000744
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002556 File Offset: 0x00000756
		public long frame
		{
			get
			{
				return VideoPlayer.get_frameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_frameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002569 File Offset: 0x00000769
		public double clockTime
		{
			get
			{
				return VideoPlayer.get_clockTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000257B File Offset: 0x0000077B
		public bool canStep
		{
			get
			{
				return VideoPlayer.get_canStepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000258D File Offset: 0x0000078D
		public void StepForward()
		{
			VideoPlayer.StepForwardDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000259F File Offset: 0x0000079F
		public bool canSetPlaybackSpeed
		{
			get
			{
				return VideoPlayer.get_canSetPlaybackSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000025B1 File Offset: 0x000007B1
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000025C3 File Offset: 0x000007C3
		public float playbackSpeed
		{
			get
			{
				return VideoPlayer.get_playbackSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_playbackSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000025D6 File Offset: 0x000007D6
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000025E8 File Offset: 0x000007E8
		public bool isLooping
		{
			get
			{
				return VideoPlayer.get_isLoopingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_isLoopingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000025FB File Offset: 0x000007FB
		public bool canSetTimeSource
		{
			get
			{
				return VideoPlayer.get_canSetTimeSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000260D File Offset: 0x0000080D
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000261F File Offset: 0x0000081F
		public VideoTimeSource timeSource
		{
			get
			{
				return VideoPlayer.get_timeSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_timeSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002632 File Offset: 0x00000832
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002644 File Offset: 0x00000844
		public VideoTimeReference timeReference
		{
			get
			{
				return VideoPlayer.get_timeReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_timeReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002657 File Offset: 0x00000857
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002669 File Offset: 0x00000869
		public double externalReferenceTime
		{
			get
			{
				return VideoPlayer.get_externalReferenceTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_externalReferenceTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000267C File Offset: 0x0000087C
		public bool canSetSkipOnDrop
		{
			get
			{
				return VideoPlayer.get_canSetSkipOnDropDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000268E File Offset: 0x0000088E
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000026A0 File Offset: 0x000008A0
		public bool skipOnDrop
		{
			get
			{
				return VideoPlayer.get_skipOnDropDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_skipOnDropDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000026B3 File Offset: 0x000008B3
		public ulong frameCount
		{
			get
			{
				return VideoPlayer.get_frameCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000026C5 File Offset: 0x000008C5
		public float frameRate
		{
			get
			{
				return VideoPlayer.get_frameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000026D7 File Offset: 0x000008D7
		public double length
		{
			get
			{
				return VideoPlayer.get_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000026E9 File Offset: 0x000008E9
		public uint width
		{
			get
			{
				return VideoPlayer.get_widthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000026FB File Offset: 0x000008FB
		public uint height
		{
			get
			{
				return VideoPlayer.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000270D File Offset: 0x0000090D
		public uint pixelAspectRatioNumerator
		{
			get
			{
				return VideoPlayer.get_pixelAspectRatioNumeratorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000271F File Offset: 0x0000091F
		public uint pixelAspectRatioDenominator
		{
			get
			{
				return VideoPlayer.get_pixelAspectRatioDenominatorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002731 File Offset: 0x00000931
		public ushort audioTrackCount
		{
			get
			{
				return VideoPlayer.get_audioTrackCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003E40 File Offset: 0x00002040
		public string GetAudioLanguageCode(ushort trackIndex)
		{
			IntPtr intPtr = VideoPlayer.GetAudioLanguageCodeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002743 File Offset: 0x00000943
		public ushort GetAudioChannelCount(ushort trackIndex)
		{
			return VideoPlayer.GetAudioChannelCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002756 File Offset: 0x00000956
		public uint GetAudioSampleRate(ushort trackIndex)
		{
			return VideoPlayer.GetAudioSampleRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002769 File Offset: 0x00000969
		public static ushort controlledAudioTrackMaxCount
		{
			get
			{
				return VideoPlayer.get_controlledAudioTrackMaxCountDelegateField();
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003E68 File Offset: 0x00002068
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00003E80 File Offset: 0x00002080
		public ushort controlledAudioTrackCount
		{
			get
			{
				return this.GetControlledAudioTrackCount();
			}
			set
			{
				int controlledAudioTrackMaxCount = (int)VideoPlayer.controlledAudioTrackMaxCount;
				bool flag = (int)value > controlledAudioTrackMaxCount;
				if (flag)
				{
					throw new ArgumentException(String.Format("Cannot control more than {0} tracks.", controlledAudioTrackMaxCount), "value");
				}
				this.SetControlledAudioTrackCount(value);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002775 File Offset: 0x00000975
		public ushort GetControlledAudioTrackCount()
		{
			return VideoPlayer.GetControlledAudioTrackCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002787 File Offset: 0x00000987
		public void SetControlledAudioTrackCount(ushort value)
		{
			VideoPlayer.SetControlledAudioTrackCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000279A File Offset: 0x0000099A
		public void EnableAudioTrack(ushort trackIndex, bool enabled)
		{
			VideoPlayer.EnableAudioTrackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex, enabled);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000027AE File Offset: 0x000009AE
		public bool IsAudioTrackEnabled(ushort trackIndex)
		{
			return VideoPlayer.IsAudioTrackEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000027C1 File Offset: 0x000009C1
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000027D3 File Offset: 0x000009D3
		public VideoAudioOutputMode audioOutputMode
		{
			get
			{
				return VideoPlayer.get_audioOutputModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_audioOutputModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000027E6 File Offset: 0x000009E6
		public bool canSetDirectAudioVolume
		{
			get
			{
				return VideoPlayer.get_canSetDirectAudioVolumeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000027F8 File Offset: 0x000009F8
		public float GetDirectAudioVolume(ushort trackIndex)
		{
			return VideoPlayer.GetDirectAudioVolumeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000280B File Offset: 0x00000A0B
		public void SetDirectAudioVolume(ushort trackIndex, float volume)
		{
			VideoPlayer.SetDirectAudioVolumeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex, volume);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000281F File Offset: 0x00000A1F
		public bool GetDirectAudioMute(ushort trackIndex)
		{
			return VideoPlayer.GetDirectAudioMuteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002832 File Offset: 0x00000A32
		public void SetDirectAudioMute(ushort trackIndex, bool mute)
		{
			VideoPlayer.SetDirectAudioMuteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex, mute);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003EC0 File Offset: 0x000020C0
		public AudioSource GetTargetAudioSource(ushort trackIndex)
		{
			IntPtr intPtr = VideoPlayer.GetTargetAudioSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002846 File Offset: 0x00000A46
		public void SetTargetAudioSource(ushort trackIndex, AudioSource source)
		{
			VideoPlayer.SetTargetAudioSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex, IL2CPP.Il2CppObjectBaseToPtr(source));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000285F File Offset: 0x00000A5F
		public void add_prepareCompleted(VideoPlayer.EventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000286C File Offset: 0x00000A6C
		public void remove_prepareCompleted(VideoPlayer.EventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002879 File Offset: 0x00000A79
		public void add_loopPointReached(VideoPlayer.EventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002886 File Offset: 0x00000A86
		public void remove_loopPointReached(VideoPlayer.EventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002893 File Offset: 0x00000A93
		public void add_started(VideoPlayer.EventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000028A0 File Offset: 0x00000AA0
		public void remove_started(VideoPlayer.EventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000028AD File Offset: 0x00000AAD
		public void add_frameDropped(VideoPlayer.EventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000028BA File Offset: 0x00000ABA
		public void remove_frameDropped(VideoPlayer.EventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000028C7 File Offset: 0x00000AC7
		public void add_errorReceived(VideoPlayer.ErrorEventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000028D4 File Offset: 0x00000AD4
		public void remove_errorReceived(VideoPlayer.ErrorEventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000028E1 File Offset: 0x00000AE1
		public void add_seekCompleted(VideoPlayer.EventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000028EE File Offset: 0x00000AEE
		public void remove_seekCompleted(VideoPlayer.EventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000028FB File Offset: 0x00000AFB
		public void add_clockResyncOccurred(VideoPlayer.TimeEventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002908 File Offset: 0x00000B08
		public void remove_clockResyncOccurred(VideoPlayer.TimeEventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002915 File Offset: 0x00000B15
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002927 File Offset: 0x00000B27
		public bool sendFrameReadyEvents
		{
			get
			{
				return VideoPlayer.get_sendFrameReadyEventsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VideoPlayer.set_sendFrameReadyEventsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000293A File Offset: 0x00000B3A
		public void add_frameReady(VideoPlayer.FrameReadyEventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002947 File Offset: 0x00000B47
		public void remove_frameReady(VideoPlayer.FrameReadyEventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_prepareCompleted;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_loopPointReached;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_frameDropped;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_errorReceived;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_seekCompleted;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_clockResyncOccurred;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_frameReady;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_get_clip_Public_get_VideoClip_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_set_clip_Public_set_Void_VideoClip_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_InvokePrepareCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_InvokeFrameReadyCallback_Internal_Private_Static_Void_VideoPlayer_Int64_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_InvokeLoopPointReachedCallback_Internal_Private_Static_Void_VideoPlayer_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_InvokeStartedCallback_Internal_Private_Static_Void_VideoPlayer_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_InvokeFrameDroppedCallback_Internal_Private_Static_Void_VideoPlayer_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_InvokeErrorReceivedCallback_Internal_Private_Static_Void_VideoPlayer_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSeekCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_InvokeClockResyncOccurredCallback_Internal_Private_Static_Void_VideoPlayer_Double_0;

		// Token: 0x04000050 RID: 80
		private static readonly VideoPlayer.get_sourceDelegate get_sourceDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly VideoPlayer.set_sourceDelegate set_sourceDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly VideoPlayer.get_urlDelegate get_urlDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly VideoPlayer.set_urlDelegate set_urlDelegateField;

		// Token: 0x04000054 RID: 84
		private static readonly VideoPlayer.get_renderModeDelegate get_renderModeDelegateField;

		// Token: 0x04000055 RID: 85
		private static readonly VideoPlayer.set_renderModeDelegate set_renderModeDelegateField;

		// Token: 0x04000056 RID: 86
		private static readonly VideoPlayer.get_targetCameraDelegate get_targetCameraDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly VideoPlayer.set_targetCameraDelegate set_targetCameraDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly VideoPlayer.get_targetTextureDelegate get_targetTextureDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly VideoPlayer.set_targetTextureDelegate set_targetTextureDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly VideoPlayer.get_targetMaterialRendererDelegate get_targetMaterialRendererDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly VideoPlayer.set_targetMaterialRendererDelegate set_targetMaterialRendererDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly VideoPlayer.get_targetMaterialPropertyDelegate get_targetMaterialPropertyDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly VideoPlayer.set_targetMaterialPropertyDelegate set_targetMaterialPropertyDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly VideoPlayer.get_aspectRatioDelegate get_aspectRatioDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly VideoPlayer.set_aspectRatioDelegate set_aspectRatioDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly VideoPlayer.get_targetCameraAlphaDelegate get_targetCameraAlphaDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly VideoPlayer.set_targetCameraAlphaDelegate set_targetCameraAlphaDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly VideoPlayer.get_targetCamera3DLayoutDelegate get_targetCamera3DLayoutDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly VideoPlayer.set_targetCamera3DLayoutDelegate set_targetCamera3DLayoutDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly VideoPlayer.get_textureDelegate get_textureDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly VideoPlayer.PrepareDelegate PrepareDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly VideoPlayer.get_isPreparedDelegate get_isPreparedDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly VideoPlayer.get_waitForFirstFrameDelegate get_waitForFirstFrameDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly VideoPlayer.set_waitForFirstFrameDelegate set_waitForFirstFrameDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly VideoPlayer.get_playOnAwakeDelegate get_playOnAwakeDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly VideoPlayer.set_playOnAwakeDelegate set_playOnAwakeDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly VideoPlayer.PlayDelegate PlayDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly VideoPlayer.PauseDelegate PauseDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly VideoPlayer.StopDelegate StopDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly VideoPlayer.get_isPlayingDelegate get_isPlayingDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly VideoPlayer.get_isPausedDelegate get_isPausedDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly VideoPlayer.get_canSetTimeDelegate get_canSetTimeDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly VideoPlayer.get_timeDelegate get_timeDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly VideoPlayer.set_timeDelegate set_timeDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly VideoPlayer.get_frameDelegate get_frameDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly VideoPlayer.set_frameDelegate set_frameDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly VideoPlayer.get_clockTimeDelegate get_clockTimeDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly VideoPlayer.get_canStepDelegate get_canStepDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly VideoPlayer.StepForwardDelegate StepForwardDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly VideoPlayer.get_canSetPlaybackSpeedDelegate get_canSetPlaybackSpeedDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly VideoPlayer.get_playbackSpeedDelegate get_playbackSpeedDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly VideoPlayer.set_playbackSpeedDelegate set_playbackSpeedDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly VideoPlayer.get_isLoopingDelegate get_isLoopingDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly VideoPlayer.set_isLoopingDelegate set_isLoopingDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly VideoPlayer.get_canSetTimeSourceDelegate get_canSetTimeSourceDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly VideoPlayer.get_timeSourceDelegate get_timeSourceDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly VideoPlayer.set_timeSourceDelegate set_timeSourceDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly VideoPlayer.get_timeReferenceDelegate get_timeReferenceDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly VideoPlayer.set_timeReferenceDelegate set_timeReferenceDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly VideoPlayer.get_externalReferenceTimeDelegate get_externalReferenceTimeDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly VideoPlayer.set_externalReferenceTimeDelegate set_externalReferenceTimeDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly VideoPlayer.get_canSetSkipOnDropDelegate get_canSetSkipOnDropDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly VideoPlayer.get_skipOnDropDelegate get_skipOnDropDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly VideoPlayer.set_skipOnDropDelegate set_skipOnDropDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly VideoPlayer.get_frameCountDelegate get_frameCountDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly VideoPlayer.get_frameRateDelegate get_frameRateDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly VideoPlayer.get_lengthDelegate get_lengthDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly VideoPlayer.get_widthDelegate get_widthDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly VideoPlayer.get_heightDelegate get_heightDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly VideoPlayer.get_pixelAspectRatioNumeratorDelegate get_pixelAspectRatioNumeratorDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly VideoPlayer.get_pixelAspectRatioDenominatorDelegate get_pixelAspectRatioDenominatorDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly VideoPlayer.get_audioTrackCountDelegate get_audioTrackCountDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly VideoPlayer.GetAudioLanguageCodeDelegate GetAudioLanguageCodeDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly VideoPlayer.GetAudioChannelCountDelegate GetAudioChannelCountDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly VideoPlayer.GetAudioSampleRateDelegate GetAudioSampleRateDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly VideoPlayer.get_controlledAudioTrackMaxCountDelegate get_controlledAudioTrackMaxCountDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly VideoPlayer.GetControlledAudioTrackCountDelegate GetControlledAudioTrackCountDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly VideoPlayer.SetControlledAudioTrackCountDelegate SetControlledAudioTrackCountDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly VideoPlayer.EnableAudioTrackDelegate EnableAudioTrackDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly VideoPlayer.IsAudioTrackEnabledDelegate IsAudioTrackEnabledDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly VideoPlayer.get_audioOutputModeDelegate get_audioOutputModeDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly VideoPlayer.set_audioOutputModeDelegate set_audioOutputModeDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly VideoPlayer.get_canSetDirectAudioVolumeDelegate get_canSetDirectAudioVolumeDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly VideoPlayer.GetDirectAudioVolumeDelegate GetDirectAudioVolumeDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly VideoPlayer.SetDirectAudioVolumeDelegate SetDirectAudioVolumeDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly VideoPlayer.GetDirectAudioMuteDelegate GetDirectAudioMuteDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly VideoPlayer.SetDirectAudioMuteDelegate SetDirectAudioMuteDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly VideoPlayer.GetTargetAudioSourceDelegate GetTargetAudioSourceDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly VideoPlayer.SetTargetAudioSourceDelegate SetTargetAudioSourceDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly VideoPlayer.get_sendFrameReadyEventsDelegate get_sendFrameReadyEventsDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly VideoPlayer.set_sendFrameReadyEventsDelegate set_sendFrameReadyEventsDelegateField;

		// Token: 0x0200002A RID: 42
		public sealed class EventHandler : MulticastDelegate
		{
			// Token: 0x0600010B RID: 267 RVA: 0x000042F8 File Offset: 0x000024F8
			// Note: this type is marked as 'beforefieldinit'.
			static EventHandler()
			{
				Il2CppClassPointerStore<VideoPlayer.EventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "EventHandler");
				VideoPlayer.EventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.EventHandler>.NativeClassPtr, 100663310);
				VideoPlayer.EventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.EventHandler>.NativeClassPtr, 100663311);
				VideoPlayer.EventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.EventHandler>.NativeClassPtr, 100663312);
				VideoPlayer.EventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.EventHandler>.NativeClassPtr, 100663313);
			}

			// Token: 0x0600010C RID: 268 RVA: 0x0000436C File Offset: 0x0000256C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoPlayer.EventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.EventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600010D RID: 269 RVA: 0x000043C8 File Offset: 0x000025C8
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1006, RefRangeEnd = 1022, XrefRangeStart = 1006, XrefRangeEnd = 1022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoPlayer source)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.EventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600010E RID: 270 RVA: 0x0000440C File Offset: 0x0000260C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VideoPlayer source, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.EventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600010F RID: 271 RVA: 0x00004480 File Offset: 0x00002680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.EventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000110 RID: 272 RVA: 0x00002C14 File Offset: 0x00000E14
			public EventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000111 RID: 273 RVA: 0x00002C1D File Offset: 0x00000E1D
			public static implicit operator VideoPlayer.EventHandler(Action<VideoPlayer> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoPlayer.EventHandler>(A_0);
			}

			// Token: 0x06000112 RID: 274 RVA: 0x00002C25 File Offset: 0x00000E25
			public static VideoPlayer.EventHandler operator +(VideoPlayer.EventHandler A_0, VideoPlayer.EventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoPlayer.EventHandler>();
			}

			// Token: 0x06000113 RID: 275 RVA: 0x00002C33 File Offset: 0x00000E33
			public static VideoPlayer.EventHandler operator -(VideoPlayer.EventHandler A_0, VideoPlayer.EventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoPlayer.EventHandler>();
				}
				return delegate2;
			}

			// Token: 0x040000DA RID: 218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000DB RID: 219
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_0;

			// Token: 0x040000DC RID: 220
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_AsyncCallback_Object_0;

			// Token: 0x040000DD RID: 221
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200002B RID: 43
		public sealed class ErrorEventHandler : MulticastDelegate
		{
			// Token: 0x06000114 RID: 276 RVA: 0x000044C4 File Offset: 0x000026C4
			// Note: this type is marked as 'beforefieldinit'.
			static ErrorEventHandler()
			{
				Il2CppClassPointerStore<VideoPlayer.ErrorEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "ErrorEventHandler");
				VideoPlayer.ErrorEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.ErrorEventHandler>.NativeClassPtr, 100663314);
				VideoPlayer.ErrorEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.ErrorEventHandler>.NativeClassPtr, 100663315);
				VideoPlayer.ErrorEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.ErrorEventHandler>.NativeClassPtr, 100663316);
				VideoPlayer.ErrorEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.ErrorEventHandler>.NativeClassPtr, 100663317);
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00004538 File Offset: 0x00002738
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoPlayer.ErrorEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.ErrorEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000116 RID: 278 RVA: 0x00004594 File Offset: 0x00002794
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 107679, RefRangeEnd = 107686, XrefRangeStart = 107679, XrefRangeEnd = 107686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoPlayer source, string message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.ErrorEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000117 RID: 279 RVA: 0x000045E8 File Offset: 0x000027E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VideoPlayer source, string message, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.ErrorEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000118 RID: 280 RVA: 0x00004670 File Offset: 0x00002870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.ErrorEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00002C44 File Offset: 0x00000E44
			public ErrorEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600011A RID: 282 RVA: 0x00002C4D File Offset: 0x00000E4D
			public static implicit operator VideoPlayer.ErrorEventHandler(Action<VideoPlayer, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoPlayer.ErrorEventHandler>(A_0);
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00002C55 File Offset: 0x00000E55
			public static VideoPlayer.ErrorEventHandler operator +(VideoPlayer.ErrorEventHandler A_0, VideoPlayer.ErrorEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoPlayer.ErrorEventHandler>();
			}

			// Token: 0x0600011C RID: 284 RVA: 0x00002C63 File Offset: 0x00000E63
			public static VideoPlayer.ErrorEventHandler operator -(VideoPlayer.ErrorEventHandler A_0, VideoPlayer.ErrorEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoPlayer.ErrorEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x040000DE RID: 222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000DF RID: 223
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_String_0;

			// Token: 0x040000E0 RID: 224
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_String_AsyncCallback_Object_0;

			// Token: 0x040000E1 RID: 225
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200002C RID: 44
		public sealed class FrameReadyEventHandler : MulticastDelegate
		{
			// Token: 0x0600011D RID: 285 RVA: 0x000046B4 File Offset: 0x000028B4
			// Note: this type is marked as 'beforefieldinit'.
			static FrameReadyEventHandler()
			{
				Il2CppClassPointerStore<VideoPlayer.FrameReadyEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "FrameReadyEventHandler");
				VideoPlayer.FrameReadyEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.FrameReadyEventHandler>.NativeClassPtr, 100663318);
				VideoPlayer.FrameReadyEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.FrameReadyEventHandler>.NativeClassPtr, 100663319);
				VideoPlayer.FrameReadyEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.FrameReadyEventHandler>.NativeClassPtr, 100663320);
				VideoPlayer.FrameReadyEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.FrameReadyEventHandler>.NativeClassPtr, 100663321);
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00004728 File Offset: 0x00002928
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FrameReadyEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoPlayer.FrameReadyEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.FrameReadyEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00004784 File Offset: 0x00002984
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 107679, RefRangeEnd = 107686, XrefRangeStart = 107679, XrefRangeEnd = 107686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoPlayer source, long frameIdx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameIdx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.FrameReadyEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000120 RID: 288 RVA: 0x000047D4 File Offset: 0x000029D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534996, XrefRangeEnd = 535000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VideoPlayer source, long frameIdx, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameIdx;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.FrameReadyEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00004858 File Offset: 0x00002A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.FrameReadyEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00002C74 File Offset: 0x00000E74
			public FrameReadyEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00002C7D File Offset: 0x00000E7D
			public static implicit operator VideoPlayer.FrameReadyEventHandler(Action<VideoPlayer, long> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoPlayer.FrameReadyEventHandler>(A_0);
			}

			// Token: 0x06000124 RID: 292 RVA: 0x00002C85 File Offset: 0x00000E85
			public static VideoPlayer.FrameReadyEventHandler operator +(VideoPlayer.FrameReadyEventHandler A_0, VideoPlayer.FrameReadyEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoPlayer.FrameReadyEventHandler>();
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00002C93 File Offset: 0x00000E93
			public static VideoPlayer.FrameReadyEventHandler operator -(VideoPlayer.FrameReadyEventHandler A_0, VideoPlayer.FrameReadyEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoPlayer.FrameReadyEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x040000E2 RID: 226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000E3 RID: 227
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Int64_0;

			// Token: 0x040000E4 RID: 228
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_Int64_AsyncCallback_Object_0;

			// Token: 0x040000E5 RID: 229
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200002D RID: 45
		public sealed class TimeEventHandler : MulticastDelegate
		{
			// Token: 0x06000126 RID: 294 RVA: 0x0000489C File Offset: 0x00002A9C
			// Note: this type is marked as 'beforefieldinit'.
			static TimeEventHandler()
			{
				Il2CppClassPointerStore<VideoPlayer.TimeEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "TimeEventHandler");
				VideoPlayer.TimeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.TimeEventHandler>.NativeClassPtr, 100663322);
				VideoPlayer.TimeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.TimeEventHandler>.NativeClassPtr, 100663323);
				VideoPlayer.TimeEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_Double_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.TimeEventHandler>.NativeClassPtr, 100663324);
				VideoPlayer.TimeEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer.TimeEventHandler>.NativeClassPtr, 100663325);
			}

			// Token: 0x06000127 RID: 295 RVA: 0x00004910 File Offset: 0x00002B10
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoPlayer.TimeEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.TimeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000128 RID: 296 RVA: 0x0000496C File Offset: 0x00002B6C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 535000, RefRangeEnd = 535001, XrefRangeStart = 535000, XrefRangeEnd = 535000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(VideoPlayer source, double seconds)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.TimeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000129 RID: 297 RVA: 0x000049BC File Offset: 0x00002BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535001, XrefRangeEnd = 535005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VideoPlayer source, double seconds, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.TimeEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_Double_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600012A RID: 298 RVA: 0x00004A40 File Offset: 0x00002C40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoPlayer.TimeEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600012B RID: 299 RVA: 0x00002CA4 File Offset: 0x00000EA4
			public TimeEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600012C RID: 300 RVA: 0x00002CAD File Offset: 0x00000EAD
			public static implicit operator VideoPlayer.TimeEventHandler(Action<VideoPlayer, double> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoPlayer.TimeEventHandler>(A_0);
			}

			// Token: 0x0600012D RID: 301 RVA: 0x00002CB5 File Offset: 0x00000EB5
			public static VideoPlayer.TimeEventHandler operator +(VideoPlayer.TimeEventHandler A_0, VideoPlayer.TimeEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoPlayer.TimeEventHandler>();
			}

			// Token: 0x0600012E RID: 302 RVA: 0x00002CC3 File Offset: 0x00000EC3
			public static VideoPlayer.TimeEventHandler operator -(VideoPlayer.TimeEventHandler A_0, VideoPlayer.TimeEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoPlayer.TimeEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x040000E6 RID: 230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000E7 RID: 231
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Double_0;

			// Token: 0x040000E8 RID: 232
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VideoPlayer_Double_AsyncCallback_Object_0;

			// Token: 0x040000E9 RID: 233
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000130 RID: 304
		private delegate VideoSource get_sourceDelegate(IntPtr @this);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000132 RID: 306
		private delegate void set_sourceDelegate(IntPtr @this, VideoSource value);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000134 RID: 308
		private delegate IntPtr get_urlDelegate(IntPtr @this);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000136 RID: 310
		private delegate void set_urlDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000138 RID: 312
		private delegate VideoRenderMode get_renderModeDelegate(IntPtr @this);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600013A RID: 314
		private delegate void set_renderModeDelegate(IntPtr @this, VideoRenderMode value);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x0600013C RID: 316
		private delegate IntPtr get_targetCameraDelegate(IntPtr @this);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x0600013E RID: 318
		private delegate void set_targetCameraDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000140 RID: 320
		private delegate IntPtr get_targetTextureDelegate(IntPtr @this);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000142 RID: 322
		private delegate void set_targetTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000144 RID: 324
		private delegate IntPtr get_targetMaterialRendererDelegate(IntPtr @this);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000146 RID: 326
		private delegate void set_targetMaterialRendererDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000148 RID: 328
		private delegate IntPtr get_targetMaterialPropertyDelegate(IntPtr @this);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600014A RID: 330
		private delegate void set_targetMaterialPropertyDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x0600014C RID: 332
		private delegate VideoAspectRatio get_aspectRatioDelegate(IntPtr @this);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x0600014E RID: 334
		private delegate void set_aspectRatioDelegate(IntPtr @this, VideoAspectRatio value);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000150 RID: 336
		private delegate float get_targetCameraAlphaDelegate(IntPtr @this);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000152 RID: 338
		private delegate void set_targetCameraAlphaDelegate(IntPtr @this, float value);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000154 RID: 340
		private delegate Video3DLayout get_targetCamera3DLayoutDelegate(IntPtr @this);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x06000156 RID: 342
		private delegate void set_targetCamera3DLayoutDelegate(IntPtr @this, Video3DLayout value);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000158 RID: 344
		private delegate IntPtr get_textureDelegate(IntPtr @this);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x0600015A RID: 346
		private delegate void PrepareDelegate(IntPtr @this);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x0600015C RID: 348
		private delegate bool get_isPreparedDelegate(IntPtr @this);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x0600015E RID: 350
		private delegate bool get_waitForFirstFrameDelegate(IntPtr @this);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000160 RID: 352
		private delegate void set_waitForFirstFrameDelegate(IntPtr @this, bool value);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000162 RID: 354
		private delegate bool get_playOnAwakeDelegate(IntPtr @this);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000164 RID: 356
		private delegate void set_playOnAwakeDelegate(IntPtr @this, bool value);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000166 RID: 358
		private delegate void PlayDelegate(IntPtr @this);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000168 RID: 360
		private delegate void PauseDelegate(IntPtr @this);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600016A RID: 362
		private delegate void StopDelegate(IntPtr @this);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x0600016C RID: 364
		private delegate bool get_isPlayingDelegate(IntPtr @this);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x0600016E RID: 366
		private delegate bool get_isPausedDelegate(IntPtr @this);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000170 RID: 368
		private delegate bool get_canSetTimeDelegate(IntPtr @this);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000172 RID: 370
		private delegate double get_timeDelegate(IntPtr @this);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000174 RID: 372
		private delegate void set_timeDelegate(IntPtr @this, double value);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x06000176 RID: 374
		private delegate long get_frameDelegate(IntPtr @this);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x06000178 RID: 376
		private delegate void set_frameDelegate(IntPtr @this, long value);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x0600017A RID: 378
		private delegate double get_clockTimeDelegate(IntPtr @this);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x0600017C RID: 380
		private delegate bool get_canStepDelegate(IntPtr @this);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x0600017E RID: 382
		private delegate void StepForwardDelegate(IntPtr @this);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000180 RID: 384
		private delegate bool get_canSetPlaybackSpeedDelegate(IntPtr @this);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000182 RID: 386
		private delegate float get_playbackSpeedDelegate(IntPtr @this);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000184 RID: 388
		private delegate void set_playbackSpeedDelegate(IntPtr @this, float value);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x06000186 RID: 390
		private delegate bool get_isLoopingDelegate(IntPtr @this);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06000188 RID: 392
		private delegate void set_isLoopingDelegate(IntPtr @this, bool value);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x0600018A RID: 394
		private delegate bool get_canSetTimeSourceDelegate(IntPtr @this);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x0600018C RID: 396
		private delegate VideoTimeSource get_timeSourceDelegate(IntPtr @this);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x0600018E RID: 398
		private delegate void set_timeSourceDelegate(IntPtr @this, VideoTimeSource value);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000190 RID: 400
		private delegate VideoTimeReference get_timeReferenceDelegate(IntPtr @this);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000192 RID: 402
		private delegate void set_timeReferenceDelegate(IntPtr @this, VideoTimeReference value);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000194 RID: 404
		private delegate double get_externalReferenceTimeDelegate(IntPtr @this);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x06000196 RID: 406
		private delegate void set_externalReferenceTimeDelegate(IntPtr @this, double value);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x06000198 RID: 408
		private delegate bool get_canSetSkipOnDropDelegate(IntPtr @this);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600019A RID: 410
		private delegate bool get_skipOnDropDelegate(IntPtr @this);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x0600019C RID: 412
		private delegate void set_skipOnDropDelegate(IntPtr @this, bool value);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x0600019E RID: 414
		private delegate ulong get_frameCountDelegate(IntPtr @this);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060001A0 RID: 416
		private delegate float get_frameRateDelegate(IntPtr @this);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060001A2 RID: 418
		private delegate double get_lengthDelegate(IntPtr @this);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060001A4 RID: 420
		private delegate uint get_widthDelegate(IntPtr @this);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060001A6 RID: 422
		private delegate uint get_heightDelegate(IntPtr @this);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060001A8 RID: 424
		private delegate uint get_pixelAspectRatioNumeratorDelegate(IntPtr @this);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060001AA RID: 426
		private delegate uint get_pixelAspectRatioDenominatorDelegate(IntPtr @this);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060001AC RID: 428
		private delegate ushort get_audioTrackCountDelegate(IntPtr @this);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060001AE RID: 430
		private delegate IntPtr GetAudioLanguageCodeDelegate(IntPtr @this, ushort trackIndex);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060001B0 RID: 432
		private delegate ushort GetAudioChannelCountDelegate(IntPtr @this, ushort trackIndex);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060001B2 RID: 434
		private delegate uint GetAudioSampleRateDelegate(IntPtr @this, ushort trackIndex);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060001B4 RID: 436
		private delegate ushort get_controlledAudioTrackMaxCountDelegate();

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060001B6 RID: 438
		private delegate ushort GetControlledAudioTrackCountDelegate(IntPtr @this);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060001B8 RID: 440
		private delegate void SetControlledAudioTrackCountDelegate(IntPtr @this, ushort value);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060001BA RID: 442
		private delegate void EnableAudioTrackDelegate(IntPtr @this, ushort trackIndex, bool enabled);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate bool IsAudioTrackEnabledDelegate(IntPtr @this, ushort trackIndex);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate VideoAudioOutputMode get_audioOutputModeDelegate(IntPtr @this);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate void set_audioOutputModeDelegate(IntPtr @this, VideoAudioOutputMode value);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate bool get_canSetDirectAudioVolumeDelegate(IntPtr @this);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060001C4 RID: 452
		private delegate float GetDirectAudioVolumeDelegate(IntPtr @this, ushort trackIndex);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060001C6 RID: 454
		private delegate void SetDirectAudioVolumeDelegate(IntPtr @this, ushort trackIndex, float volume);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060001C8 RID: 456
		private delegate bool GetDirectAudioMuteDelegate(IntPtr @this, ushort trackIndex);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060001CA RID: 458
		private delegate void SetDirectAudioMuteDelegate(IntPtr @this, ushort trackIndex, bool mute);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060001CC RID: 460
		private delegate IntPtr GetTargetAudioSourceDelegate(IntPtr @this, ushort trackIndex);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060001CE RID: 462
		private delegate void SetTargetAudioSourceDelegate(IntPtr @this, ushort trackIndex, IntPtr source);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060001D0 RID: 464
		private delegate bool get_sendFrameReadyEventsDelegate(IntPtr @this);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060001D2 RID: 466
		private delegate void set_sendFrameReadyEventsDelegate(IntPtr @this, bool value);
	}
}
