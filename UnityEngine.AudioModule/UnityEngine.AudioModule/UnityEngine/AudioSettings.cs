using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public sealed class AudioSettings : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000033A4 File Offset: 0x000015A4
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSettings()
		{
			Il2CppClassPointerStore<AudioSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr);
			AudioSettings.NativeFieldInfoPtr_OnAudioConfigurationChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "OnAudioConfigurationChanged");
			AudioSettings.NativeFieldInfoPtr_OnAudioSystemShuttingDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "OnAudioSystemShuttingDown");
			AudioSettings.NativeFieldInfoPtr_OnAudioSystemStartedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "OnAudioSystemStartedUp");
			AudioSettings.NativeMethodInfoPtr_GetSampleRate_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663297);
			AudioSettings.NativeMethodInfoPtr_get_dspTime_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663298);
			AudioSettings.NativeMethodInfoPtr_get_outputSampleRate_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663299);
			AudioSettings.NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663300);
			AudioSettings.NativeMethodInfoPtr_InvokeOnAudioSystemShuttingDown_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663301);
			AudioSettings.NativeMethodInfoPtr_InvokeOnAudioSystemStartedUp_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663302);
			AudioSettings.GetSpeakerModeDelegateField = IL2CPP.ResolveICall<AudioSettings.GetSpeakerModeDelegate>("UnityEngine.AudioSettings::GetSpeakerMode");
			AudioSettings.get_driverCapabilitiesDelegateField = IL2CPP.ResolveICall<AudioSettings.get_driverCapabilitiesDelegate>("UnityEngine.AudioSettings::get_driverCapabilities");
			AudioSettings.get_profilerCaptureFlagsDelegateField = IL2CPP.ResolveICall<AudioSettings.get_profilerCaptureFlagsDelegate>("UnityEngine.AudioSettings::get_profilerCaptureFlags");
			AudioSettings.GetDSPBufferSizeDelegateField = IL2CPP.ResolveICall<AudioSettings.GetDSPBufferSizeDelegate>("UnityEngine.AudioSettings::GetDSPBufferSize");
			AudioSettings.GetSpatializerPluginNameDelegateField = IL2CPP.ResolveICall<AudioSettings.GetSpatializerPluginNameDelegate>("UnityEngine.AudioSettings::GetSpatializerPluginName");
			AudioSettings.get_unityAudioDisabledDelegateField = IL2CPP.ResolveICall<AudioSettings.get_unityAudioDisabledDelegate>("UnityEngine.AudioSettings::get_unityAudioDisabled");
			AudioSettings.GetAmbisonicDecoderPluginNameDelegateField = IL2CPP.ResolveICall<AudioSettings.GetAmbisonicDecoderPluginNameDelegate>("UnityEngine.AudioSettings::GetAmbisonicDecoderPluginName");
			AudioSettings.StartAudioOutputDelegateField = IL2CPP.ResolveICall<AudioSettings.StartAudioOutputDelegate>("UnityEngine.AudioSettings::StartAudioOutput");
			AudioSettings.StopAudioOutputDelegateField = IL2CPP.ResolveICall<AudioSettings.StopAudioOutputDelegate>("UnityEngine.AudioSettings::StopAudioOutput");
			AudioSettings.get_audioOutputStartedDelegateField = IL2CPP.ResolveICall<AudioSettings.get_audioOutputStartedDelegate>("UnityEngine.AudioSettings::get_audioOutputStarted");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00003520 File Offset: 0x00001720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484737, RefRangeEnd = 484738, XrefRangeStart = 484733, XrefRangeEnd = 484737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSampleRate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr_GetSampleRate_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00003550 File Offset: 0x00001750
		public unsafe static double dspTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484738, XrefRangeEnd = 484742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr_get_dspTime_Public_Static_get_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00003580 File Offset: 0x00001780
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020C0 File Offset: 0x000002C0
		public unsafe static int outputSampleRate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 484737, RefRangeEnd = 484738, XrefRangeStart = 484737, XrefRangeEnd = 484738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr_get_outputSampleRate_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000035B0 File Offset: 0x000017B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484742, XrefRangeEnd = 484745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceWasChanged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000035E4 File Offset: 0x000017E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484745, XrefRangeEnd = 484748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnAudioSystemShuttingDown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr_InvokeOnAudioSystemShuttingDown_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000360C File Offset: 0x0000180C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484748, XrefRangeEnd = 484751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnAudioSystemStartedUp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr_InvokeOnAudioSystemStartedUp_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		public AudioSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00003634 File Offset: 0x00001834
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioSettings.NativeFieldInfoPtr_OnAudioConfigurationChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSettings.AudioConfigurationChangeHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioSettings.NativeFieldInfoPtr_OnAudioConfigurationChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000365C File Offset: 0x0000185C
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe static Action OnAudioSystemShuttingDown
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioSettings.NativeFieldInfoPtr_OnAudioSystemShuttingDown, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioSettings.NativeFieldInfoPtr_OnAudioSystemShuttingDown, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00003684 File Offset: 0x00001884
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000207D File Offset: 0x0000027D
		public unsafe static Action OnAudioSystemStartedUp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioSettings.NativeFieldInfoPtr_OnAudioSystemStartedUp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioSettings.NativeFieldInfoPtr_OnAudioSystemStartedUp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000208F File Offset: 0x0000028F
		public static AudioSpeakerMode GetSpeakerMode()
		{
			return AudioSettings.GetSpeakerModeDelegateField();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000209B File Offset: 0x0000029B
		public static AudioSpeakerMode driverCapabilities
		{
			get
			{
				return AudioSettings.get_driverCapabilitiesDelegateField();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000036AC File Offset: 0x000018AC
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020A7 File Offset: 0x000002A7
		public static AudioSpeakerMode speakerMode
		{
			get
			{
				return AudioSettings.GetSpeakerMode();
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020B4 File Offset: 0x000002B4
		public static int profilerCaptureFlags
		{
			get
			{
				return AudioSettings.get_profilerCaptureFlagsDelegateField();
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020CD File Offset: 0x000002CD
		public static void GetDSPBufferSize(out int bufferLength, out int numBuffers)
		{
			AudioSettings.GetDSPBufferSizeDelegateField(out bufferLength, out numBuffers);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020DB File Offset: 0x000002DB
		public static void SetDSPBufferSize(int bufferLength, int numBuffers)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000036C4 File Offset: 0x000018C4
		public static string GetSpatializerPluginName()
		{
			IntPtr intPtr = AudioSettings.GetSpatializerPluginNameDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020E8 File Offset: 0x000002E8
		public static void add_OnAudioConfigurationChanged(AudioSettings.AudioConfigurationChangeHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020F5 File Offset: 0x000002F5
		public static void remove_OnAudioConfigurationChanged(AudioSettings.AudioConfigurationChangeHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002102 File Offset: 0x00000302
		public static bool unityAudioDisabled
		{
			get
			{
				return AudioSettings.get_unityAudioDisabledDelegateField();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000036E4 File Offset: 0x000018E4
		public static string GetAmbisonicDecoderPluginName()
		{
			IntPtr intPtr = AudioSettings.GetAmbisonicDecoderPluginNameDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000210E File Offset: 0x0000030E
		public static bool StartAudioOutput()
		{
			return AudioSettings.StartAudioOutputDelegateField();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000211A File Offset: 0x0000031A
		public static bool StopAudioOutput()
		{
			return AudioSettings.StopAudioOutputDelegateField();
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002126 File Offset: 0x00000326
		public static bool audioOutputStarted
		{
			get
			{
				return AudioSettings.get_audioOutputStartedDelegateField();
			}
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_OnAudioConfigurationChanged;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_OnAudioSystemShuttingDown;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_OnAudioSystemStartedUp;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleRate_Private_Static_Int32_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_dspTime_Public_Static_get_Double_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_get_outputSampleRate_Public_Static_get_Int32_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnAudioSystemShuttingDown_Internal_Static_Void_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnAudioSystemStartedUp_Internal_Static_Void_0;

		// Token: 0x04000039 RID: 57
		private static readonly AudioSettings.GetSpeakerModeDelegate GetSpeakerModeDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly AudioSettings.get_driverCapabilitiesDelegate get_driverCapabilitiesDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly AudioSettings.get_profilerCaptureFlagsDelegate get_profilerCaptureFlagsDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly AudioSettings.GetDSPBufferSizeDelegate GetDSPBufferSizeDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly AudioSettings.GetSpatializerPluginNameDelegate GetSpatializerPluginNameDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly AudioSettings.get_unityAudioDisabledDelegate get_unityAudioDisabledDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly AudioSettings.GetAmbisonicDecoderPluginNameDelegate GetAmbisonicDecoderPluginNameDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly AudioSettings.StartAudioOutputDelegate StartAudioOutputDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly AudioSettings.StopAudioOutputDelegate StopAudioOutputDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly AudioSettings.get_audioOutputStartedDelegate get_audioOutputStartedDelegateField;

		// Token: 0x0200002A RID: 42
		public sealed class AudioConfigurationChangeHandler : MulticastDelegate
		{
			// Token: 0x06000206 RID: 518 RVA: 0x0000810C File Offset: 0x0000630C
			// Note: this type is marked as 'beforefieldinit'.
			static AudioConfigurationChangeHandler()
			{
				Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "AudioConfigurationChangeHandler");
				AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr, 100663303);
				AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr, 100663304);
				AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr, 100663305);
				AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr, 100663306);
			}

			// Token: 0x06000207 RID: 519 RVA: 0x00008180 File Offset: 0x00006380
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AudioConfigurationChangeHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000208 RID: 520 RVA: 0x000081DC File Offset: 0x000063DC
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 42994, RefRangeEnd = 43010, XrefRangeStart = 42994, XrefRangeEnd = 43010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(bool deviceWasChanged)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref deviceWasChanged;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000209 RID: 521 RVA: 0x0000821C File Offset: 0x0000641C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484729, XrefRangeEnd = 484733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(bool deviceWasChanged, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref deviceWasChanged;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600020A RID: 522 RVA: 0x0000828C File Offset: 0x0000648C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600020B RID: 523 RVA: 0x000032E4 File Offset: 0x000014E4
			public AudioConfigurationChangeHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600020C RID: 524 RVA: 0x000032ED File Offset: 0x000014ED
			public static implicit operator AudioSettings.AudioConfigurationChangeHandler(Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioSettings.AudioConfigurationChangeHandler>(A_0);
			}

			// Token: 0x0600020D RID: 525 RVA: 0x000032F5 File Offset: 0x000014F5
			public static AudioSettings.AudioConfigurationChangeHandler operator +(AudioSettings.AudioConfigurationChangeHandler A_0, AudioSettings.AudioConfigurationChangeHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioSettings.AudioConfigurationChangeHandler>();
			}

			// Token: 0x0600020E RID: 526 RVA: 0x00003303 File Offset: 0x00001503
			public static AudioSettings.AudioConfigurationChangeHandler operator -(AudioSettings.AudioConfigurationChangeHandler A_0, AudioSettings.AudioConfigurationChangeHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioSettings.AudioConfigurationChangeHandler>();
				}
				return delegate2;
			}

			// Token: 0x040001C6 RID: 454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040001C7 RID: 455
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

			// Token: 0x040001C8 RID: 456
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

			// Token: 0x040001C9 RID: 457
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200002B RID: 43
		public static class Mobile
		{
		}

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000210 RID: 528
		private delegate AudioSpeakerMode GetSpeakerModeDelegate();

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000212 RID: 530
		private delegate AudioSpeakerMode get_driverCapabilitiesDelegate();

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000214 RID: 532
		private delegate int get_profilerCaptureFlagsDelegate();

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000216 RID: 534
		private delegate void GetDSPBufferSizeDelegate([Out] IntPtr bufferLength, [Out] IntPtr numBuffers);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000218 RID: 536
		private delegate IntPtr GetSpatializerPluginNameDelegate();

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600021A RID: 538
		private delegate bool get_unityAudioDisabledDelegate();

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x0600021C RID: 540
		private delegate IntPtr GetAmbisonicDecoderPluginNameDelegate();

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600021E RID: 542
		private delegate bool StartAudioOutputDelegate();

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000220 RID: 544
		private delegate bool StopAudioOutputDelegate();

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000222 RID: 546
		private delegate bool get_audioOutputStartedDelegate();
	}
}
