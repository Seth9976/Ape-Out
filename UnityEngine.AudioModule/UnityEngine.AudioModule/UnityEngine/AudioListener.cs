using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public sealed class AudioListener : AudioBehaviour
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000040EC File Offset: 0x000022EC
		// Note: this type is marked as 'beforefieldinit'.
		static AudioListener()
		{
			Il2CppClassPointerStore<AudioListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioListener>.NativeClassPtr);
			AudioListener.NativeMethodInfoPtr_get_volume_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663336);
			AudioListener.NativeMethodInfoPtr_set_volume_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663337);
			AudioListener.NativeMethodInfoPtr_get_pause_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663338);
			AudioListener.NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663339);
			AudioListener.GetOutputDataHelperDelegateField = IL2CPP.ResolveICall<AudioListener.GetOutputDataHelperDelegate>("UnityEngine.AudioListener::GetOutputDataHelper");
			AudioListener.GetSpectrumDataHelperDelegateField = IL2CPP.ResolveICall<AudioListener.GetSpectrumDataHelperDelegate>("UnityEngine.AudioListener::GetSpectrumDataHelper");
			AudioListener.set_pauseDelegateField = IL2CPP.ResolveICall<AudioListener.set_pauseDelegate>("UnityEngine.AudioListener::set_pause");
			AudioListener.get_velocityUpdateModeDelegateField = IL2CPP.ResolveICall<AudioListener.get_velocityUpdateModeDelegate>("UnityEngine.AudioListener::get_velocityUpdateMode");
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000041A8 File Offset: 0x000023A8
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000041D8 File Offset: 0x000023D8
		public unsafe static float volume
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484853, XrefRangeEnd = 484857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_get_volume_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484857, XrefRangeEnd = 484861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_set_volume_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000420C File Offset: 0x0000240C
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000224B File Offset: 0x0000044B
		public unsafe static bool pause
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484861, XrefRangeEnd = 484865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_get_pause_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				AudioListener.set_pauseDelegateField(value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002258 File Offset: 0x00000458
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0000423C File Offset: 0x0000243C
		public unsafe AudioVelocityUpdateMode velocityUpdateMode
		{
			get
			{
				return AudioListener.get_velocityUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484865, XrefRangeEnd = 484869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000221B File Offset: 0x0000041B
		public AudioListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002224 File Offset: 0x00000424
		public static void GetOutputDataHelper([Out] Il2CppStructArray<float> samples, int channel)
		{
			AudioListener.GetOutputDataHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(samples), channel);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002237 File Offset: 0x00000437
		public static void GetSpectrumDataHelper([Out] Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			AudioListener.GetSpectrumDataHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(samples), channel, window);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000226A File Offset: 0x0000046A
		public static Il2CppStructArray<float> GetOutputData(int numSamples, int channel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002277 File Offset: 0x00000477
		public static void GetOutputData(Il2CppStructArray<float> samples, int channel)
		{
			AudioListener.GetOutputDataHelper(samples, channel);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002282 File Offset: 0x00000482
		public static Il2CppStructArray<float> GetSpectrumData(int numSamples, int channel, FFTWindow window)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000228F File Offset: 0x0000048F
		public static void GetSpectrumData(Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			AudioListener.GetSpectrumDataHelper(samples, channel, window);
		}

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_volume_Public_Static_get_Single_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_set_volume_Public_Static_set_Void_Single_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_pause_Public_Static_get_Boolean_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0;

		// Token: 0x04000064 RID: 100
		private static readonly AudioListener.GetOutputDataHelperDelegate GetOutputDataHelperDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly AudioListener.GetSpectrumDataHelperDelegate GetSpectrumDataHelperDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly AudioListener.set_pauseDelegate set_pauseDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly AudioListener.get_velocityUpdateModeDelegate get_velocityUpdateModeDelegateField;

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000242 RID: 578
		private delegate void GetOutputDataHelperDelegate([Out] IntPtr samples, int channel);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000244 RID: 580
		private delegate void GetSpectrumDataHelperDelegate([Out] IntPtr samples, int channel, FFTWindow window);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000246 RID: 582
		private delegate void set_pauseDelegate(bool value);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x06000248 RID: 584
		private delegate AudioVelocityUpdateMode get_velocityUpdateModeDelegate(IntPtr @this);
	}
}
