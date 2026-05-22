using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public sealed class AudioClip : Object
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00003704 File Offset: 0x00001904
		// Note: this type is marked as 'beforefieldinit'.
		static AudioClip()
		{
			Il2CppClassPointerStore<AudioClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioClip>.NativeClassPtr);
			AudioClip.NativeFieldInfoPtr_m_PCMReaderCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "m_PCMReaderCallback");
			AudioClip.NativeFieldInfoPtr_m_PCMSetPositionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "m_PCMSetPositionCallback");
			AudioClip.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663307);
			AudioClip.NativeMethodInfoPtr_SetData_Private_Static_Boolean_AudioClip_Il2CppStructArray_1_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663308);
			AudioClip.NativeMethodInfoPtr_Construct_Internal_Private_Static_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663309);
			AudioClip.NativeMethodInfoPtr_GetName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663310);
			AudioClip.NativeMethodInfoPtr_CreateUserSound_Private_Void_String_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663311);
			AudioClip.NativeMethodInfoPtr_get_length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663312);
			AudioClip.NativeMethodInfoPtr_get_samples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663313);
			AudioClip.NativeMethodInfoPtr_get_channels_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663314);
			AudioClip.NativeMethodInfoPtr_get_frequency_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663315);
			AudioClip.NativeMethodInfoPtr_LoadAudioData_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663316);
			AudioClip.NativeMethodInfoPtr_get_ambisonic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663317);
			AudioClip.NativeMethodInfoPtr_get_loadState_Public_get_AudioDataLoadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663318);
			AudioClip.NativeMethodInfoPtr_SetData_Public_Boolean_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663319);
			AudioClip.NativeMethodInfoPtr_Create_Public_Static_AudioClip_String_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663320);
			AudioClip.NativeMethodInfoPtr_Create_Public_Static_AudioClip_String_Int32_Int32_Int32_Boolean_PCMReaderCallback_PCMSetPositionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663321);
			AudioClip.NativeMethodInfoPtr_add_m_PCMReaderCallback_Private_add_Void_PCMReaderCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663322);
			AudioClip.NativeMethodInfoPtr_remove_m_PCMReaderCallback_Private_rem_Void_PCMReaderCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663323);
			AudioClip.NativeMethodInfoPtr_add_m_PCMSetPositionCallback_Private_add_Void_PCMSetPositionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663324);
			AudioClip.NativeMethodInfoPtr_remove_m_PCMSetPositionCallback_Private_rem_Void_PCMSetPositionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663325);
			AudioClip.NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663326);
			AudioClip.NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663327);
			AudioClip.GetDataDelegateField = IL2CPP.ResolveICall<AudioClip.GetDataDelegate>("UnityEngine.AudioClip::GetData");
			AudioClip.get_isReadyToPlayDelegateField = IL2CPP.ResolveICall<AudioClip.get_isReadyToPlayDelegate>("UnityEngine.AudioClip::get_isReadyToPlay");
			AudioClip.get_loadTypeDelegateField = IL2CPP.ResolveICall<AudioClip.get_loadTypeDelegate>("UnityEngine.AudioClip::get_loadType");
			AudioClip.UnloadAudioDataDelegateField = IL2CPP.ResolveICall<AudioClip.UnloadAudioDataDelegate>("UnityEngine.AudioClip::UnloadAudioData");
			AudioClip.get_preloadAudioDataDelegateField = IL2CPP.ResolveICall<AudioClip.get_preloadAudioDataDelegate>("UnityEngine.AudioClip::get_preloadAudioData");
			AudioClip.get_loadInBackgroundDelegateField = IL2CPP.ResolveICall<AudioClip.get_loadInBackgroundDelegate>("UnityEngine.AudioClip::get_loadInBackground");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000395C File Offset: 0x00001B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484755, XrefRangeEnd = 484758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003998 File Offset: 0x00001B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484758, XrefRangeEnd = 484762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetData(AudioClip clip, Il2CppStructArray<float> data, int numsamples, int samplesOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numsamples;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplesOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_SetData_Private_Static_Boolean_AudioClip_Il2CppStructArray_1_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003A08 File Offset: 0x00001C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484762, XrefRangeEnd = 484766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioClip Construct_Internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_Construct_Internal_Private_Static_AudioClip_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003A3C File Offset: 0x00001C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484766, XrefRangeEnd = 484770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_GetName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003A74 File Offset: 0x00001C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484770, XrefRangeEnd = 484774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lengthSamples;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channels;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frequency;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_CreateUserSound_Private_Void_String_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003AF0 File Offset: 0x00001CF0
		public unsafe float length
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 484778, RefRangeEnd = 484782, XrefRangeStart = 484774, XrefRangeEnd = 484778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_get_length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003B2C File Offset: 0x00001D2C
		public unsafe int samples
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484782, XrefRangeEnd = 484786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_get_samples_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003B68 File Offset: 0x00001D68
		public unsafe int channels
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 484790, RefRangeEnd = 484791, XrefRangeStart = 484786, XrefRangeEnd = 484790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_get_channels_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003BA4 File Offset: 0x00001DA4
		public unsafe int frequency
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484791, XrefRangeEnd = 484795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_get_frequency_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003BE0 File Offset: 0x00001DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484795, XrefRangeEnd = 484799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LoadAudioData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_LoadAudioData_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003C1C File Offset: 0x00001E1C
		public unsafe bool ambisonic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484799, XrefRangeEnd = 484803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_get_ambisonic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003C58 File Offset: 0x00001E58
		public unsafe AudioDataLoadState loadState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484803, XrefRangeEnd = 484807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_get_loadState_Public_get_AudioDataLoadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003C94 File Offset: 0x00001E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484826, RefRangeEnd = 484827, XrefRangeStart = 484807, XrefRangeEnd = 484826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetData(Il2CppStructArray<float> data, int offsetSamples)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetSamples;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_SetData_Public_Boolean_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484827, XrefRangeEnd = 484828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lengthSamples;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channels;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frequency;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_Create_Public_Static_AudioClip_String_Int32_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003D6C File Offset: 0x00001F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484838, RefRangeEnd = 484839, XrefRangeStart = 484828, XrefRangeEnd = 484838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lengthSamples;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channels;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frequency;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pcmreadercallback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pcmsetpositioncallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_Create_Public_Static_AudioClip_String_Int32_Int32_Int32_Boolean_PCMReaderCallback_PCMSetPositionCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003E10 File Offset: 0x00002010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484839, XrefRangeEnd = 484842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_add_m_PCMReaderCallback_Private_add_Void_PCMReaderCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003E54 File Offset: 0x00002054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484842, XrefRangeEnd = 484845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_remove_m_PCMReaderCallback_Private_rem_Void_PCMReaderCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003E98 File Offset: 0x00002098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484845, XrefRangeEnd = 484848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_add_m_PCMSetPositionCallback_Private_add_Void_PCMSetPositionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003EDC File Offset: 0x000020DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484848, XrefRangeEnd = 484851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_remove_m_PCMSetPositionCallback_Private_rem_Void_PCMSetPositionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003F20 File Offset: 0x00002120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484851, XrefRangeEnd = 484852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokePCMReaderCallback_Internal(Il2CppStructArray<float> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003F64 File Offset: 0x00002164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484852, XrefRangeEnd = 484853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokePCMSetPositionCallback_Internal(int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002132 File Offset: 0x00000332
		public AudioClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003FA4 File Offset: 0x000021A4
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000213B File Offset: 0x0000033B
		public unsafe AudioClip.PCMReaderCallback m_PCMReaderCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMReaderCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip.PCMReaderCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMReaderCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003FD4 File Offset: 0x000021D4
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000215A File Offset: 0x0000035A
		public unsafe AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMSetPositionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip.PCMSetPositionCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMSetPositionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002179 File Offset: 0x00000379
		public static bool GetData(AudioClip clip, [Out] Il2CppStructArray<float> data, int numSamples, int samplesOffset)
		{
			return AudioClip.GetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(clip), IL2CPP.Il2CppObjectBaseToPtr(data), numSamples, samplesOffset);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002193 File Offset: 0x00000393
		public bool isReadyToPlay
		{
			get
			{
				return AudioClip.get_isReadyToPlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000021A5 File Offset: 0x000003A5
		public AudioClipLoadType loadType
		{
			get
			{
				return AudioClip.get_loadTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000021B7 File Offset: 0x000003B7
		public bool UnloadAudioData()
		{
			return AudioClip.UnloadAudioDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000021C9 File Offset: 0x000003C9
		public bool preloadAudioData
		{
			get
			{
				return AudioClip.get_preloadAudioDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000021DB File Offset: 0x000003DB
		public bool loadInBackground
		{
			get
			{
				return AudioClip.get_loadInBackgroundDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004004 File Offset: 0x00002204
		public bool GetData(Il2CppStructArray<float> data, int offsetSamples)
		{
			bool flag = this.channels <= 0;
			bool flag2;
			if (flag)
			{
				Debug.Log(String.Concat("AudioClip.GetData failed; AudioClip ", this.GetName(), " contains no data"));
				flag2 = false;
			}
			else
			{
				int num = ((data != null) ? (data.Length / this.channels) : 0);
				flag2 = AudioClip.GetData(this, data, num, offsetSamples);
			}
			return flag2;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004064 File Offset: 0x00002264
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004084 File Offset: 0x00002284
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000040A4 File Offset: 0x000022A4
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, pcmsetpositioncallback);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000040C8 File Offset: 0x000022C8
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
		}

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_m_PCMReaderCallback;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_m_PCMSetPositionCallback;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Private_Static_Boolean_AudioClip_Il2CppStructArray_1_Single_Int32_Int32_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_Construct_Internal_Private_Static_AudioClip_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Private_String_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_CreateUserSound_Private_Void_String_Int32_Int32_Int32_Boolean_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_get_length_Public_get_Single_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_get_samples_Public_get_Int32_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_channels_Public_get_Int32_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_get_frequency_Public_get_Int32_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_LoadAudioData_Public_Boolean_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_ambisonic_Public_get_Boolean_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_loadState_Public_get_AudioDataLoadState_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Boolean_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AudioClip_String_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AudioClip_String_Int32_Int32_Int32_Boolean_PCMReaderCallback_PCMSetPositionCallback_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_add_m_PCMReaderCallback_Private_add_Void_PCMReaderCallback_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_remove_m_PCMReaderCallback_Private_rem_Void_PCMReaderCallback_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_add_m_PCMSetPositionCallback_Private_add_Void_PCMSetPositionCallback_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_remove_m_PCMSetPositionCallback_Private_rem_Void_PCMSetPositionCallback_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0;

		// Token: 0x0400005A RID: 90
		private static readonly AudioClip.GetDataDelegate GetDataDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly AudioClip.get_isReadyToPlayDelegate get_isReadyToPlayDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly AudioClip.get_loadTypeDelegate get_loadTypeDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly AudioClip.UnloadAudioDataDelegate UnloadAudioDataDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly AudioClip.get_preloadAudioDataDelegate get_preloadAudioDataDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly AudioClip.get_loadInBackgroundDelegate get_loadInBackgroundDelegateField;

		// Token: 0x02000036 RID: 54
		public sealed class PCMReaderCallback : MulticastDelegate
		{
			// Token: 0x06000223 RID: 547 RVA: 0x000082D0 File Offset: 0x000064D0
			// Note: this type is marked as 'beforefieldinit'.
			static PCMReaderCallback()
			{
				Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "PCMReaderCallback");
				AudioClip.PCMReaderCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr, 100663328);
				AudioClip.PCMReaderCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr, 100663329);
				AudioClip.PCMReaderCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr, 100663330);
				AudioClip.PCMReaderCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr, 100663331);
			}

			// Token: 0x06000224 RID: 548 RVA: 0x00008344 File Offset: 0x00006544
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PCMReaderCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMReaderCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000225 RID: 549 RVA: 0x000083A0 File Offset: 0x000065A0
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1006, RefRangeEnd = 1022, XrefRangeStart = 1006, XrefRangeEnd = 1022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Il2CppStructArray<float> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMReaderCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000226 RID: 550 RVA: 0x000083E4 File Offset: 0x000065E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Il2CppStructArray<float> data, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMReaderCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000227 RID: 551 RVA: 0x00008458 File Offset: 0x00006658
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMReaderCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000228 RID: 552 RVA: 0x00003314 File Offset: 0x00001514
			public PCMReaderCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000229 RID: 553 RVA: 0x0000331D File Offset: 0x0000151D
			public static implicit operator AudioClip.PCMReaderCallback(Action<Il2CppStructArray<float>> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioClip.PCMReaderCallback>(A_0);
			}

			// Token: 0x0600022A RID: 554 RVA: 0x00003325 File Offset: 0x00001525
			public static AudioClip.PCMReaderCallback operator +(AudioClip.PCMReaderCallback A_0, AudioClip.PCMReaderCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioClip.PCMReaderCallback>();
			}

			// Token: 0x0600022B RID: 555 RVA: 0x00003333 File Offset: 0x00001533
			public static AudioClip.PCMReaderCallback operator -(AudioClip.PCMReaderCallback A_0, AudioClip.PCMReaderCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioClip.PCMReaderCallback>();
				}
				return delegate2;
			}

			// Token: 0x040001CA RID: 458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040001CB RID: 459
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0;

			// Token: 0x040001CC RID: 460
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Single_AsyncCallback_Object_0;

			// Token: 0x040001CD RID: 461
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000037 RID: 55
		public sealed class PCMSetPositionCallback : MulticastDelegate
		{
			// Token: 0x0600022C RID: 556 RVA: 0x0000849C File Offset: 0x0000669C
			// Note: this type is marked as 'beforefieldinit'.
			static PCMSetPositionCallback()
			{
				Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "PCMSetPositionCallback");
				AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr, 100663332);
				AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr, 100663333);
				AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr, 100663334);
				AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr, 100663335);
			}

			// Token: 0x0600022D RID: 557 RVA: 0x00008510 File Offset: 0x00006710
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PCMSetPositionCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600022E RID: 558 RVA: 0x0000856C File Offset: 0x0000676C
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 12882, RefRangeEnd = 12902, XrefRangeStart = 12882, XrefRangeEnd = 12902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(int position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref position;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600022F RID: 559 RVA: 0x000085AC File Offset: 0x000067AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484751, XrefRangeEnd = 484755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int position, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref position;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000230 RID: 560 RVA: 0x0000861C File Offset: 0x0000681C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000231 RID: 561 RVA: 0x00003344 File Offset: 0x00001544
			public PCMSetPositionCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000232 RID: 562 RVA: 0x0000334D File Offset: 0x0000154D
			public static implicit operator AudioClip.PCMSetPositionCallback(Action<int> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioClip.PCMSetPositionCallback>(A_0);
			}

			// Token: 0x06000233 RID: 563 RVA: 0x00003355 File Offset: 0x00001555
			public static AudioClip.PCMSetPositionCallback operator +(AudioClip.PCMSetPositionCallback A_0, AudioClip.PCMSetPositionCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioClip.PCMSetPositionCallback>();
			}

			// Token: 0x06000234 RID: 564 RVA: 0x00003363 File Offset: 0x00001563
			public static AudioClip.PCMSetPositionCallback operator -(AudioClip.PCMSetPositionCallback A_0, AudioClip.PCMSetPositionCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioClip.PCMSetPositionCallback>();
				}
				return delegate2;
			}

			// Token: 0x040001CE RID: 462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040001CF RID: 463
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

			// Token: 0x040001D0 RID: 464
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

			// Token: 0x040001D1 RID: 465
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000236 RID: 566
		private delegate bool GetDataDelegate(IntPtr clip, [Out] IntPtr data, int numSamples, int samplesOffset);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000238 RID: 568
		private delegate bool get_isReadyToPlayDelegate(IntPtr @this);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x0600023A RID: 570
		private delegate AudioClipLoadType get_loadTypeDelegate(IntPtr @this);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600023C RID: 572
		private delegate bool UnloadAudioDataDelegate(IntPtr @this);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x0600023E RID: 574
		private delegate bool get_preloadAudioDataDelegate(IntPtr @this);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000240 RID: 576
		private delegate bool get_loadInBackgroundDelegate(IntPtr @this);
	}
}
