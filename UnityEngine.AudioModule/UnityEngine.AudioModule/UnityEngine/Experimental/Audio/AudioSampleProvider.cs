using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x02000016 RID: 22
	public class AudioSampleProvider : Object
	{
		// Token: 0x06000145 RID: 325 RVA: 0x000072C0 File Offset: 0x000054C0
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSampleProvider()
		{
			Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Experimental.Audio", "AudioSampleProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr);
			AudioSampleProvider.NativeFieldInfoPtr_sampleFramesAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "sampleFramesAvailable");
			AudioSampleProvider.NativeFieldInfoPtr_sampleFramesOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "sampleFramesOverflow");
			AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, 100663451);
			AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, 100663452);
			AudioSampleProvider.InternalCreateSampleProviderDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalCreateSampleProviderDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalCreateSampleProvider");
			AudioSampleProvider.InternalRemoveDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalRemoveDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalRemove");
			AudioSampleProvider.InternalGetFormatInfoDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetFormatInfoDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFormatInfo");
			AudioSampleProvider.InternalGetScriptingPtrDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetScriptingPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetScriptingPtr");
			AudioSampleProvider.InternalSetScriptingPtrDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetScriptingPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetScriptingPtr");
			AudioSampleProvider.InternalIsValidDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalIsValidDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalIsValid");
			AudioSampleProvider.InternalGetMaxSampleFrameCountDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetMaxSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetMaxSampleFrameCount");
			AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetAvailableSampleFrameCount");
			AudioSampleProvider.InternalGetFreeSampleFrameCountDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetFreeSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFreeSampleFrameCount");
			AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFreeSampleFrameCountLowThreshold");
			AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetFreeSampleFrameCountLowThreshold");
			AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetEnableSampleFramesAvailableEvents");
			AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetEnableSampleFramesAvailableEvents");
			AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetSampleFramesAvailableNativeHandler");
			AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalClearSampleFramesAvailableNativeHandler");
			AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetSampleFramesOverflowNativeHandler");
			AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalClearSampleFramesOverflowNativeHandler");
			AudioSampleProvider.InternalGetEnableSilencePaddingDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetEnableSilencePaddingDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetEnableSilencePadding");
			AudioSampleProvider.InternalSetEnableSilencePaddingDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetEnableSilencePaddingDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetEnableSilencePadding");
			AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetConsumeSampleFramesNativeFunctionPtr");
			AudioSampleProvider.InternalQueueSampleFramesDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalQueueSampleFramesDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalQueueSampleFrames");
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000747C File Offset: 0x0000567C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485684, XrefRangeEnd = 485685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeSampleFramesAvailable(int sampleFrameCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sampleFrameCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000074BC File Offset: 0x000056BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485685, XrefRangeEnd = 485686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeSampleFramesOverflow(int droppedSampleFrameCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref droppedSampleFrameCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000028E0 File Offset: 0x00000AE0
		public AudioSampleProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000074FC File Offset: 0x000056FC
		// (set) Token: 0x0600014A RID: 330 RVA: 0x000028E9 File Offset: 0x00000AE9
		public unsafe AudioSampleProvider.SampleFramesHandler sampleFramesAvailable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesAvailable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSampleProvider.SampleFramesHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesAvailable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000752C File Offset: 0x0000572C
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002908 File Offset: 0x00000B08
		public unsafe AudioSampleProvider.SampleFramesHandler sampleFramesOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesOverflow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSampleProvider.SampleFramesHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesOverflow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000755C File Offset: 0x0000575C
		public static AudioSampleProvider Lookup(uint providerId, Object ownerObj, ushort trackIndex)
		{
			AudioSampleProvider audioSampleProvider = AudioSampleProvider.InternalGetScriptingPtr(providerId);
			bool flag = audioSampleProvider != null || !AudioSampleProvider.InternalIsValid(providerId);
			AudioSampleProvider audioSampleProvider2;
			if (flag)
			{
				audioSampleProvider2 = audioSampleProvider;
			}
			else
			{
				audioSampleProvider2 = new AudioSampleProvider(providerId, ownerObj, trackIndex);
			}
			return audioSampleProvider2;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00007594 File Offset: 0x00005794
		public static AudioSampleProvider Create(ushort channelCount, uint sampleRate)
		{
			uint num = AudioSampleProvider.InternalCreateSampleProvider(channelCount, sampleRate);
			bool flag = !AudioSampleProvider.InternalIsValid(num);
			AudioSampleProvider audioSampleProvider;
			if (flag)
			{
				audioSampleProvider = null;
			}
			else
			{
				audioSampleProvider = new AudioSampleProvider(num, null, 0);
			}
			return audioSampleProvider;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000075C8 File Offset: 0x000057C8
		public ~AudioSampleProvider()
		{
			this.owner = null;
			this.Dispose();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00007600 File Offset: 0x00005800
		public void Dispose()
		{
			bool flag = this.id > 0U;
			if (flag)
			{
				AudioSampleProvider.InternalSetScriptingPtr(this.id, null);
				bool flag2 = this.owner == null;
				if (flag2)
				{
					AudioSampleProvider.InternalRemove(this.id);
				}
				this.id = 0U;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00002927 File Offset: 0x00000B27
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002934 File Offset: 0x00000B34
		public uint id
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00002941 File Offset: 0x00000B41
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0000294E File Offset: 0x00000B4E
		public ushort trackIndex
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000295B File Offset: 0x00000B5B
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002968 File Offset: 0x00000B68
		public Object owner
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00007658 File Offset: 0x00005858
		public bool valid
		{
			get
			{
				return AudioSampleProvider.InternalIsValid(this.id);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002975 File Offset: 0x00000B75
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002982 File Offset: 0x00000B82
		public ushort channelCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000298F File Offset: 0x00000B8F
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0000299C File Offset: 0x00000B9C
		public uint sampleRate
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00007678 File Offset: 0x00005878
		public uint maxSampleFrameCount
		{
			get
			{
				return AudioSampleProvider.InternalGetMaxSampleFrameCount(this.id);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00007698 File Offset: 0x00005898
		public uint availableSampleFrameCount
		{
			get
			{
				return AudioSampleProvider.InternalGetAvailableSampleFrameCount(this.id);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000076B8 File Offset: 0x000058B8
		public uint freeSampleFrameCount
		{
			get
			{
				return AudioSampleProvider.InternalGetFreeSampleFrameCount(this.id);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000076D8 File Offset: 0x000058D8
		// (set) Token: 0x06000160 RID: 352 RVA: 0x000029A9 File Offset: 0x00000BA9
		public uint freeSampleFrameCountLowThreshold
		{
			get
			{
				return AudioSampleProvider.InternalGetFreeSampleFrameCountLowThreshold(this.id);
			}
			set
			{
				AudioSampleProvider.InternalSetFreeSampleFrameCountLowThreshold(this.id, value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000076F8 File Offset: 0x000058F8
		// (set) Token: 0x06000162 RID: 354 RVA: 0x000029B9 File Offset: 0x00000BB9
		public bool enableSampleFramesAvailableEvents
		{
			get
			{
				return AudioSampleProvider.InternalGetEnableSampleFramesAvailableEvents(this.id);
			}
			set
			{
				AudioSampleProvider.InternalSetEnableSampleFramesAvailableEvents(this.id, value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00007718 File Offset: 0x00005918
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000029C9 File Offset: 0x00000BC9
		public bool enableSilencePadding
		{
			get
			{
				return AudioSampleProvider.InternalGetEnableSilencePadding(this.id);
			}
			set
			{
				AudioSampleProvider.InternalSetEnableSilencePadding(this.id, value);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000029D9 File Offset: 0x00000BD9
		public uint ConsumeSampleFrames(NativeArray<float> sampleFrames)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00007738 File Offset: 0x00005938
		public uint QueueSampleFrames(NativeArray<float> sampleFrames)
		{
			bool flag = this.channelCount == 0;
			uint num;
			if (flag)
			{
				num = 0U;
			}
			else
			{
				num = AudioSampleProvider.InternalQueueSampleFrames(this.id, (IntPtr)sampleFrames.GetUnsafeReadOnlyPtr<float>(), (uint)(sampleFrames.Length / (int)this.channelCount));
			}
			return num;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000029E6 File Offset: 0x00000BE6
		public void add_sampleFramesAvailable(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000029F3 File Offset: 0x00000BF3
		public void remove_sampleFramesAvailable(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002A00 File Offset: 0x00000C00
		public void add_sampleFramesOverflow(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002A0D File Offset: 0x00000C0D
		public void remove_sampleFramesOverflow(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002A1A File Offset: 0x00000C1A
		public void ClearSampleFramesAvailableNativeHandler()
		{
			AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandler(this.id);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002A29 File Offset: 0x00000C29
		public void ClearSampleFramesOverflowNativeHandler()
		{
			AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandler(this.id);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002A38 File Offset: 0x00000C38
		public static uint InternalCreateSampleProvider(ushort channelCount, uint sampleRate)
		{
			return AudioSampleProvider.InternalCreateSampleProviderDelegateField(channelCount, sampleRate);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002A46 File Offset: 0x00000C46
		public static void InternalRemove(uint providerId)
		{
			AudioSampleProvider.InternalRemoveDelegateField(providerId);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002A53 File Offset: 0x00000C53
		public static void InternalGetFormatInfo(uint providerId, out ushort chCount, out uint sRate)
		{
			AudioSampleProvider.InternalGetFormatInfoDelegateField(providerId, out chCount, out sRate);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00007780 File Offset: 0x00005980
		public static AudioSampleProvider InternalGetScriptingPtr(uint providerId)
		{
			IntPtr intPtr = AudioSampleProvider.InternalGetScriptingPtrDelegateField(providerId);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSampleProvider>(intPtr2) : null;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002A62 File Offset: 0x00000C62
		public static void InternalSetScriptingPtr(uint providerId, AudioSampleProvider provider)
		{
			AudioSampleProvider.InternalSetScriptingPtrDelegateField(providerId, IL2CPP.Il2CppObjectBaseToPtr(provider));
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002A75 File Offset: 0x00000C75
		public static bool InternalIsValid(uint providerId)
		{
			return AudioSampleProvider.InternalIsValidDelegateField(providerId);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002A82 File Offset: 0x00000C82
		public static uint InternalGetMaxSampleFrameCount(uint providerId)
		{
			return AudioSampleProvider.InternalGetMaxSampleFrameCountDelegateField(providerId);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002A8F File Offset: 0x00000C8F
		public static uint InternalGetAvailableSampleFrameCount(uint providerId)
		{
			return AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegateField(providerId);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002A9C File Offset: 0x00000C9C
		public static uint InternalGetFreeSampleFrameCount(uint providerId)
		{
			return AudioSampleProvider.InternalGetFreeSampleFrameCountDelegateField(providerId);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002AA9 File Offset: 0x00000CA9
		public static uint InternalGetFreeSampleFrameCountLowThreshold(uint providerId)
		{
			return AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegateField(providerId);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002AB6 File Offset: 0x00000CB6
		public static void InternalSetFreeSampleFrameCountLowThreshold(uint providerId, uint sampleFrameCount)
		{
			AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegateField(providerId, sampleFrameCount);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002AC4 File Offset: 0x00000CC4
		public static bool InternalGetEnableSampleFramesAvailableEvents(uint providerId)
		{
			return AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegateField(providerId);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002AD1 File Offset: 0x00000CD1
		public static void InternalSetEnableSampleFramesAvailableEvents(uint providerId, bool enable)
		{
			AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegateField(providerId, enable);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002ADF File Offset: 0x00000CDF
		public static void InternalSetSampleFramesAvailableNativeHandler(uint providerId, IntPtr handler, IntPtr userData)
		{
			AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegateField(providerId, handler, userData);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002AEE File Offset: 0x00000CEE
		public static void InternalClearSampleFramesAvailableNativeHandler(uint providerId)
		{
			AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegateField(providerId);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002AFB File Offset: 0x00000CFB
		public static void InternalSetSampleFramesOverflowNativeHandler(uint providerId, IntPtr handler, IntPtr userData)
		{
			AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegateField(providerId, handler, userData);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002B0A File Offset: 0x00000D0A
		public static void InternalClearSampleFramesOverflowNativeHandler(uint providerId)
		{
			AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegateField(providerId);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002B17 File Offset: 0x00000D17
		public static bool InternalGetEnableSilencePadding(uint id)
		{
			return AudioSampleProvider.InternalGetEnableSilencePaddingDelegateField(id);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002B24 File Offset: 0x00000D24
		public static void InternalSetEnableSilencePadding(uint id, bool enabled)
		{
			AudioSampleProvider.InternalSetEnableSilencePaddingDelegateField(id, enabled);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002B32 File Offset: 0x00000D32
		public static IntPtr InternalGetConsumeSampleFramesNativeFunctionPtr()
		{
			return AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002B3E File Offset: 0x00000D3E
		public static uint InternalQueueSampleFrames(uint id, IntPtr interleavedSampleFrames, uint sampleFrameCount)
		{
			return AudioSampleProvider.InternalQueueSampleFramesDelegateField(id, interleavedSampleFrames, sampleFrameCount);
		}

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_sampleFramesAvailable;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_sampleFramesOverflow;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0;

		// Token: 0x04000126 RID: 294
		private static readonly AudioSampleProvider.InternalCreateSampleProviderDelegate InternalCreateSampleProviderDelegateField;

		// Token: 0x04000127 RID: 295
		private static readonly AudioSampleProvider.InternalRemoveDelegate InternalRemoveDelegateField;

		// Token: 0x04000128 RID: 296
		private static readonly AudioSampleProvider.InternalGetFormatInfoDelegate InternalGetFormatInfoDelegateField;

		// Token: 0x04000129 RID: 297
		private static readonly AudioSampleProvider.InternalGetScriptingPtrDelegate InternalGetScriptingPtrDelegateField;

		// Token: 0x0400012A RID: 298
		private static readonly AudioSampleProvider.InternalSetScriptingPtrDelegate InternalSetScriptingPtrDelegateField;

		// Token: 0x0400012B RID: 299
		private static readonly AudioSampleProvider.InternalIsValidDelegate InternalIsValidDelegateField;

		// Token: 0x0400012C RID: 300
		private static readonly AudioSampleProvider.InternalGetMaxSampleFrameCountDelegate InternalGetMaxSampleFrameCountDelegateField;

		// Token: 0x0400012D RID: 301
		private static readonly AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegate InternalGetAvailableSampleFrameCountDelegateField;

		// Token: 0x0400012E RID: 302
		private static readonly AudioSampleProvider.InternalGetFreeSampleFrameCountDelegate InternalGetFreeSampleFrameCountDelegateField;

		// Token: 0x0400012F RID: 303
		private static readonly AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegate InternalGetFreeSampleFrameCountLowThresholdDelegateField;

		// Token: 0x04000130 RID: 304
		private static readonly AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegate InternalSetFreeSampleFrameCountLowThresholdDelegateField;

		// Token: 0x04000131 RID: 305
		private static readonly AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegate InternalGetEnableSampleFramesAvailableEventsDelegateField;

		// Token: 0x04000132 RID: 306
		private static readonly AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegate InternalSetEnableSampleFramesAvailableEventsDelegateField;

		// Token: 0x04000133 RID: 307
		private static readonly AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegate InternalSetSampleFramesAvailableNativeHandlerDelegateField;

		// Token: 0x04000134 RID: 308
		private static readonly AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegate InternalClearSampleFramesAvailableNativeHandlerDelegateField;

		// Token: 0x04000135 RID: 309
		private static readonly AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegate InternalSetSampleFramesOverflowNativeHandlerDelegateField;

		// Token: 0x04000136 RID: 310
		private static readonly AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegate InternalClearSampleFramesOverflowNativeHandlerDelegateField;

		// Token: 0x04000137 RID: 311
		private static readonly AudioSampleProvider.InternalGetEnableSilencePaddingDelegate InternalGetEnableSilencePaddingDelegateField;

		// Token: 0x04000138 RID: 312
		private static readonly AudioSampleProvider.InternalSetEnableSilencePaddingDelegate InternalSetEnableSilencePaddingDelegateField;

		// Token: 0x04000139 RID: 313
		private static readonly AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegate InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField;

		// Token: 0x0400013A RID: 314
		private static readonly AudioSampleProvider.InternalQueueSampleFramesDelegate InternalQueueSampleFramesDelegateField;

		// Token: 0x02000087 RID: 135
		public sealed class SampleFramesHandler : MulticastDelegate
		{
			// Token: 0x060002D3 RID: 723 RVA: 0x00008660 File Offset: 0x00006860
			// Note: this type is marked as 'beforefieldinit'.
			static SampleFramesHandler()
			{
				Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "SampleFramesHandler");
				AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr, 100663453);
				AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr, 100663454);
				AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AudioSampleProvider_UInt32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr, 100663455);
				AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr, 100663456);
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x000086D4 File Offset: 0x000068D4
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SampleFramesHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x00008730 File Offset: 0x00006930
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 485678, RefRangeEnd = 485680, XrefRangeStart = 485678, XrefRangeEnd = 485678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(AudioSampleProvider provider, uint sampleFrameCount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sampleFrameCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x00008780 File Offset: 0x00006980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485680, XrefRangeEnd = 485684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AudioSampleProvider provider, uint sampleFrameCount, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sampleFrameCount;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AudioSampleProvider_UInt32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x00008804 File Offset: 0x00006A04
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x00003374 File Offset: 0x00001574
			public SampleFramesHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x0000337D File Offset: 0x0000157D
			public static implicit operator AudioSampleProvider.SampleFramesHandler(Action<AudioSampleProvider, uint> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioSampleProvider.SampleFramesHandler>(A_0);
			}

			// Token: 0x060002DA RID: 730 RVA: 0x00003385 File Offset: 0x00001585
			public static AudioSampleProvider.SampleFramesHandler operator +(AudioSampleProvider.SampleFramesHandler A_0, AudioSampleProvider.SampleFramesHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioSampleProvider.SampleFramesHandler>();
			}

			// Token: 0x060002DB RID: 731 RVA: 0x00003393 File Offset: 0x00001593
			public static AudioSampleProvider.SampleFramesHandler operator -(AudioSampleProvider.SampleFramesHandler A_0, AudioSampleProvider.SampleFramesHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioSampleProvider.SampleFramesHandler>();
				}
				return delegate2;
			}

			// Token: 0x040001D2 RID: 466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040001D3 RID: 467
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0;

			// Token: 0x040001D4 RID: 468
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AudioSampleProvider_UInt32_AsyncCallback_Object_0;

			// Token: 0x040001D5 RID: 469
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060002DD RID: 733
		private delegate uint InternalCreateSampleProviderDelegate(ushort channelCount, uint sampleRate);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060002DF RID: 735
		private delegate void InternalRemoveDelegate(uint providerId);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060002E1 RID: 737
		private delegate void InternalGetFormatInfoDelegate(uint providerId, [Out] IntPtr chCount, [Out] IntPtr sRate);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060002E3 RID: 739
		private delegate IntPtr InternalGetScriptingPtrDelegate(uint providerId);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060002E5 RID: 741
		private delegate void InternalSetScriptingPtrDelegate(uint providerId, IntPtr provider);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060002E7 RID: 743
		private delegate bool InternalIsValidDelegate(uint providerId);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060002E9 RID: 745
		private delegate uint InternalGetMaxSampleFrameCountDelegate(uint providerId);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060002EB RID: 747
		private delegate uint InternalGetAvailableSampleFrameCountDelegate(uint providerId);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060002ED RID: 749
		private delegate uint InternalGetFreeSampleFrameCountDelegate(uint providerId);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060002EF RID: 751
		private delegate uint InternalGetFreeSampleFrameCountLowThresholdDelegate(uint providerId);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060002F1 RID: 753
		private delegate void InternalSetFreeSampleFrameCountLowThresholdDelegate(uint providerId, uint sampleFrameCount);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060002F3 RID: 755
		private delegate bool InternalGetEnableSampleFramesAvailableEventsDelegate(uint providerId);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060002F5 RID: 757
		private delegate void InternalSetEnableSampleFramesAvailableEventsDelegate(uint providerId, bool enable);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060002F7 RID: 759
		private delegate void InternalSetSampleFramesAvailableNativeHandlerDelegate(uint providerId, IntPtr handler, IntPtr userData);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060002F9 RID: 761
		private delegate void InternalClearSampleFramesAvailableNativeHandlerDelegate(uint providerId);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060002FB RID: 763
		private delegate void InternalSetSampleFramesOverflowNativeHandlerDelegate(uint providerId, IntPtr handler, IntPtr userData);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060002FD RID: 765
		private delegate void InternalClearSampleFramesOverflowNativeHandlerDelegate(uint providerId);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060002FF RID: 767
		private delegate bool InternalGetEnableSilencePaddingDelegate(uint id);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000301 RID: 769
		private delegate void InternalSetEnableSilencePaddingDelegate(uint id, bool enabled);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000303 RID: 771
		private delegate IntPtr InternalGetConsumeSampleFramesNativeFunctionPtrDelegate();

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000305 RID: 773
		private delegate uint InternalQueueSampleFramesDelegate(uint id, IntPtr interleavedSampleFrames, uint sampleFrameCount);
	}
}
