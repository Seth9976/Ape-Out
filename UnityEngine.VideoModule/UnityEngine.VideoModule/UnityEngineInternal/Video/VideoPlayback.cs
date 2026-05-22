using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Experimental.Audio;

namespace UnityEngineInternal.Video
{
	// Token: 0x02000010 RID: 16
	public class VideoPlayback
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00002978 File Offset: 0x00000B78
		public void StartPlayback()
		{
			VideoPlayback.StartPlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000298A File Offset: 0x00000B8A
		public void PausePlayback()
		{
			VideoPlayback.PausePlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000299C File Offset: 0x00000B9C
		public void StopPlayback()
		{
			VideoPlayback.StopPlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000029AE File Offset: 0x00000BAE
		public VideoError GetStatus()
		{
			return VideoPlayback.GetStatusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000029C0 File Offset: 0x00000BC0
		public bool IsReady()
		{
			return VideoPlayback.IsReadyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000029D2 File Offset: 0x00000BD2
		public bool IsPlaying()
		{
			return VideoPlayback.IsPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000029E4 File Offset: 0x00000BE4
		public void Step()
		{
			VideoPlayback.StepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000029F6 File Offset: 0x00000BF6
		public bool CanStep()
		{
			return VideoPlayback.CanStepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002A08 File Offset: 0x00000C08
		public uint GetWidth()
		{
			return VideoPlayback.GetWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002A1A File Offset: 0x00000C1A
		public uint GetHeight()
		{
			return VideoPlayback.GetHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002A2C File Offset: 0x00000C2C
		public float GetFrameRate()
		{
			return VideoPlayback.GetFrameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002A3E File Offset: 0x00000C3E
		public float GetDuration()
		{
			return VideoPlayback.GetDurationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002A50 File Offset: 0x00000C50
		public ulong GetFrameCount()
		{
			return VideoPlayback.GetFrameCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002A62 File Offset: 0x00000C62
		public uint GetPixelAspectRatioNumerator()
		{
			return VideoPlayback.GetPixelAspectRatioNumeratorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002A74 File Offset: 0x00000C74
		public uint GetPixelAspectRatioDenominator()
		{
			return VideoPlayback.GetPixelAspectRatioDenominatorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002A86 File Offset: 0x00000C86
		public VideoPixelFormat GetPixelFormat()
		{
			return VideoPlayback.GetPixelFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002A98 File Offset: 0x00000C98
		public bool CanNotSkipOnDrop()
		{
			return VideoPlayback.CanNotSkipOnDropDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002AAA File Offset: 0x00000CAA
		public void SetSkipOnDrop(bool skipOnDrop)
		{
			VideoPlayback.SetSkipOnDropDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), skipOnDrop);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002ABD File Offset: 0x00000CBD
		public bool GetTexture(Texture texture, out long outputFrameNum)
		{
			return VideoPlayback.GetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(texture), out outputFrameNum);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002AD6 File Offset: 0x00000CD6
		public float GetPlaybackSpeed()
		{
			return VideoPlayback.GetPlaybackSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002AE8 File Offset: 0x00000CE8
		public void SetPlaybackSpeed(float value)
		{
			VideoPlayback.SetPlaybackSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002AFB File Offset: 0x00000CFB
		public bool GetLoop()
		{
			return VideoPlayback.GetLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002B0D File Offset: 0x00000D0D
		public void SetLoop(bool value)
		{
			VideoPlayback.SetLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002B20 File Offset: 0x00000D20
		public void SetAdjustToLinearSpace(bool enable)
		{
			VideoPlayback.SetAdjustToLinearSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), enable);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002B33 File Offset: 0x00000D33
		public ushort GetAudioTrackCount()
		{
			return VideoPlayback.GetAudioTrackCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002B45 File Offset: 0x00000D45
		public ushort GetAudioChannelCount(ushort trackIdx)
		{
			return VideoPlayback.GetAudioChannelCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIdx);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002B58 File Offset: 0x00000D58
		public uint GetAudioSampleRate(ushort trackIdx)
		{
			return VideoPlayback.GetAudioSampleRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIdx);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002B6B File Offset: 0x00000D6B
		public void SetAudioTarget(ushort trackIdx, bool enabled, bool softwareOutput, AudioSource audioSource)
		{
			VideoPlayback.SetAudioTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIdx, enabled, softwareOutput, IL2CPP.Il2CppObjectBaseToPtr(audioSource));
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002B87 File Offset: 0x00000D87
		public uint GetAudioSampleProviderId(ushort trackIndex)
		{
			return VideoPlayback.GetAudioSampleProviderIdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000041C0 File Offset: 0x000023C0
		public AudioSampleProvider GetAudioSampleProvider(ushort trackIndex)
		{
			bool flag = trackIndex >= this.GetAudioTrackCount();
			if (flag)
			{
				throw new ArgumentOutOfRangeException("trackIndex", trackIndex, String.Concat("VideoPlayback has ", this.GetAudioTrackCount().ToString(), " tracks."));
			}
			AudioSampleProvider audioSampleProvider = AudioSampleProvider.Lookup(this.GetAudioSampleProviderId(trackIndex), null, trackIndex);
			bool flag2 = audioSampleProvider == null;
			if (flag2)
			{
				throw new InvalidOperationException("VideoPlayback.GetAudioSampleProvider got null provider.");
			}
			bool flag3 = audioSampleProvider.owner != null;
			if (flag3)
			{
				throw new InvalidOperationException("Internal error: VideoPlayback.GetAudioSampleProvider got unexpected non-null provider owner.");
			}
			bool flag4 = audioSampleProvider.trackIndex != trackIndex;
			if (flag4)
			{
				throw new InvalidOperationException(String.Concat("Internal error: VideoPlayback.GetAudioSampleProvider got provider for track ", audioSampleProvider.trackIndex.ToString(), " instead of ", trackIndex.ToString()));
			}
			return audioSampleProvider;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002B9A File Offset: 0x00000D9A
		public static bool PlatformSupportsH265()
		{
			return VideoPlayback.PlatformSupportsH265DelegateField();
		}

		// Token: 0x040000B6 RID: 182
		private static readonly VideoPlayback.StartPlaybackDelegate StartPlaybackDelegateField = IL2CPP.ResolveICall<VideoPlayback.StartPlaybackDelegate>("UnityEngineInternal.Video.VideoPlayback::StartPlayback");

		// Token: 0x040000B7 RID: 183
		private static readonly VideoPlayback.PausePlaybackDelegate PausePlaybackDelegateField = IL2CPP.ResolveICall<VideoPlayback.PausePlaybackDelegate>("UnityEngineInternal.Video.VideoPlayback::PausePlayback");

		// Token: 0x040000B8 RID: 184
		private static readonly VideoPlayback.StopPlaybackDelegate StopPlaybackDelegateField = IL2CPP.ResolveICall<VideoPlayback.StopPlaybackDelegate>("UnityEngineInternal.Video.VideoPlayback::StopPlayback");

		// Token: 0x040000B9 RID: 185
		private static readonly VideoPlayback.GetStatusDelegate GetStatusDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetStatusDelegate>("UnityEngineInternal.Video.VideoPlayback::GetStatus");

		// Token: 0x040000BA RID: 186
		private static readonly VideoPlayback.IsReadyDelegate IsReadyDelegateField = IL2CPP.ResolveICall<VideoPlayback.IsReadyDelegate>("UnityEngineInternal.Video.VideoPlayback::IsReady");

		// Token: 0x040000BB RID: 187
		private static readonly VideoPlayback.IsPlayingDelegate IsPlayingDelegateField = IL2CPP.ResolveICall<VideoPlayback.IsPlayingDelegate>("UnityEngineInternal.Video.VideoPlayback::IsPlaying");

		// Token: 0x040000BC RID: 188
		private static readonly VideoPlayback.StepDelegate StepDelegateField = IL2CPP.ResolveICall<VideoPlayback.StepDelegate>("UnityEngineInternal.Video.VideoPlayback::Step");

		// Token: 0x040000BD RID: 189
		private static readonly VideoPlayback.CanStepDelegate CanStepDelegateField = IL2CPP.ResolveICall<VideoPlayback.CanStepDelegate>("UnityEngineInternal.Video.VideoPlayback::CanStep");

		// Token: 0x040000BE RID: 190
		private static readonly VideoPlayback.GetWidthDelegate GetWidthDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetWidthDelegate>("UnityEngineInternal.Video.VideoPlayback::GetWidth");

		// Token: 0x040000BF RID: 191
		private static readonly VideoPlayback.GetHeightDelegate GetHeightDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetHeightDelegate>("UnityEngineInternal.Video.VideoPlayback::GetHeight");

		// Token: 0x040000C0 RID: 192
		private static readonly VideoPlayback.GetFrameRateDelegate GetFrameRateDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetFrameRateDelegate>("UnityEngineInternal.Video.VideoPlayback::GetFrameRate");

		// Token: 0x040000C1 RID: 193
		private static readonly VideoPlayback.GetDurationDelegate GetDurationDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetDurationDelegate>("UnityEngineInternal.Video.VideoPlayback::GetDuration");

		// Token: 0x040000C2 RID: 194
		private static readonly VideoPlayback.GetFrameCountDelegate GetFrameCountDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetFrameCountDelegate>("UnityEngineInternal.Video.VideoPlayback::GetFrameCount");

		// Token: 0x040000C3 RID: 195
		private static readonly VideoPlayback.GetPixelAspectRatioNumeratorDelegate GetPixelAspectRatioNumeratorDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetPixelAspectRatioNumeratorDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPixelAspectRatioNumerator");

		// Token: 0x040000C4 RID: 196
		private static readonly VideoPlayback.GetPixelAspectRatioDenominatorDelegate GetPixelAspectRatioDenominatorDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetPixelAspectRatioDenominatorDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPixelAspectRatioDenominator");

		// Token: 0x040000C5 RID: 197
		private static readonly VideoPlayback.GetPixelFormatDelegate GetPixelFormatDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetPixelFormatDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPixelFormat");

		// Token: 0x040000C6 RID: 198
		private static readonly VideoPlayback.CanNotSkipOnDropDelegate CanNotSkipOnDropDelegateField = IL2CPP.ResolveICall<VideoPlayback.CanNotSkipOnDropDelegate>("UnityEngineInternal.Video.VideoPlayback::CanNotSkipOnDrop");

		// Token: 0x040000C7 RID: 199
		private static readonly VideoPlayback.SetSkipOnDropDelegate SetSkipOnDropDelegateField = IL2CPP.ResolveICall<VideoPlayback.SetSkipOnDropDelegate>("UnityEngineInternal.Video.VideoPlayback::SetSkipOnDrop");

		// Token: 0x040000C8 RID: 200
		private static readonly VideoPlayback.GetTextureDelegate GetTextureDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetTextureDelegate>("UnityEngineInternal.Video.VideoPlayback::GetTexture");

		// Token: 0x040000C9 RID: 201
		private static readonly VideoPlayback.GetPlaybackSpeedDelegate GetPlaybackSpeedDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetPlaybackSpeedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPlaybackSpeed");

		// Token: 0x040000CA RID: 202
		private static readonly VideoPlayback.SetPlaybackSpeedDelegate SetPlaybackSpeedDelegateField = IL2CPP.ResolveICall<VideoPlayback.SetPlaybackSpeedDelegate>("UnityEngineInternal.Video.VideoPlayback::SetPlaybackSpeed");

		// Token: 0x040000CB RID: 203
		private static readonly VideoPlayback.GetLoopDelegate GetLoopDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetLoopDelegate>("UnityEngineInternal.Video.VideoPlayback::GetLoop");

		// Token: 0x040000CC RID: 204
		private static readonly VideoPlayback.SetLoopDelegate SetLoopDelegateField = IL2CPP.ResolveICall<VideoPlayback.SetLoopDelegate>("UnityEngineInternal.Video.VideoPlayback::SetLoop");

		// Token: 0x040000CD RID: 205
		private static readonly VideoPlayback.SetAdjustToLinearSpaceDelegate SetAdjustToLinearSpaceDelegateField = IL2CPP.ResolveICall<VideoPlayback.SetAdjustToLinearSpaceDelegate>("UnityEngineInternal.Video.VideoPlayback::SetAdjustToLinearSpace");

		// Token: 0x040000CE RID: 206
		private static readonly VideoPlayback.GetAudioTrackCountDelegate GetAudioTrackCountDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetAudioTrackCountDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioTrackCount");

		// Token: 0x040000CF RID: 207
		private static readonly VideoPlayback.GetAudioChannelCountDelegate GetAudioChannelCountDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetAudioChannelCountDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioChannelCount");

		// Token: 0x040000D0 RID: 208
		private static readonly VideoPlayback.GetAudioSampleRateDelegate GetAudioSampleRateDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetAudioSampleRateDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioSampleRate");

		// Token: 0x040000D1 RID: 209
		private static readonly VideoPlayback.SetAudioTargetDelegate SetAudioTargetDelegateField = IL2CPP.ResolveICall<VideoPlayback.SetAudioTargetDelegate>("UnityEngineInternal.Video.VideoPlayback::SetAudioTarget");

		// Token: 0x040000D2 RID: 210
		private static readonly VideoPlayback.GetAudioSampleProviderIdDelegate GetAudioSampleProviderIdDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetAudioSampleProviderIdDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioSampleProviderId");

		// Token: 0x040000D3 RID: 211
		private static readonly VideoPlayback.PlatformSupportsH265Delegate PlatformSupportsH265DelegateField = IL2CPP.ResolveICall<VideoPlayback.PlatformSupportsH265Delegate>("UnityEngineInternal.Video.VideoPlayback::PlatformSupportsH265");

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060001D6 RID: 470
		private delegate void StartPlaybackDelegate(IntPtr @this);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060001D8 RID: 472
		private delegate void PausePlaybackDelegate(IntPtr @this);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060001DA RID: 474
		private delegate void StopPlaybackDelegate(IntPtr @this);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060001DC RID: 476
		private delegate VideoError GetStatusDelegate(IntPtr @this);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060001DE RID: 478
		private delegate bool IsReadyDelegate(IntPtr @this);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060001E0 RID: 480
		private delegate bool IsPlayingDelegate(IntPtr @this);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060001E2 RID: 482
		private delegate void StepDelegate(IntPtr @this);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060001E4 RID: 484
		private delegate bool CanStepDelegate(IntPtr @this);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060001E6 RID: 486
		private delegate uint GetWidthDelegate(IntPtr @this);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060001E8 RID: 488
		private delegate uint GetHeightDelegate(IntPtr @this);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060001EA RID: 490
		private delegate float GetFrameRateDelegate(IntPtr @this);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060001EC RID: 492
		private delegate float GetDurationDelegate(IntPtr @this);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060001EE RID: 494
		private delegate ulong GetFrameCountDelegate(IntPtr @this);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060001F0 RID: 496
		private delegate uint GetPixelAspectRatioNumeratorDelegate(IntPtr @this);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060001F2 RID: 498
		private delegate uint GetPixelAspectRatioDenominatorDelegate(IntPtr @this);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060001F4 RID: 500
		private delegate VideoPixelFormat GetPixelFormatDelegate(IntPtr @this);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060001F6 RID: 502
		private delegate bool CanNotSkipOnDropDelegate(IntPtr @this);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060001F8 RID: 504
		private delegate void SetSkipOnDropDelegate(IntPtr @this, bool skipOnDrop);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060001FA RID: 506
		private delegate bool GetTextureDelegate(IntPtr @this, IntPtr texture, [Out] IntPtr outputFrameNum);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060001FC RID: 508
		private delegate float GetPlaybackSpeedDelegate(IntPtr @this);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060001FE RID: 510
		private delegate void SetPlaybackSpeedDelegate(IntPtr @this, float value);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000200 RID: 512
		private delegate bool GetLoopDelegate(IntPtr @this);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000202 RID: 514
		private delegate void SetLoopDelegate(IntPtr @this, bool value);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000204 RID: 516
		private delegate void SetAdjustToLinearSpaceDelegate(IntPtr @this, bool enable);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x06000206 RID: 518
		private delegate ushort GetAudioTrackCountDelegate(IntPtr @this);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000208 RID: 520
		private delegate ushort GetAudioChannelCountDelegate(IntPtr @this, ushort trackIdx);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x0600020A RID: 522
		private delegate uint GetAudioSampleRateDelegate(IntPtr @this, ushort trackIdx);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x0600020C RID: 524
		private delegate void SetAudioTargetDelegate(IntPtr @this, ushort trackIdx, bool enabled, bool softwareOutput, IntPtr audioSource);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x0600020E RID: 526
		private delegate uint GetAudioSampleProviderIdDelegate(IntPtr @this, ushort trackIndex);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000210 RID: 528
		private delegate bool PlatformSupportsH265Delegate();
	}
}
