using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2Cpp
{
	// Token: 0x02000031 RID: 49
	public class RecordPlayer : MonoBehaviour
	{
		// Token: 0x06000832 RID: 2098 RVA: 0x0004C128 File Offset: 0x0004A328
		// Note: this type is marked as 'beforefieldinit'.
		static RecordPlayer()
		{
			Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RecordPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr);
			RecordPlayer.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "me");
			RecordPlayer.NativeFieldInfoPtr_SourceA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "SourceA");
			RecordPlayer.NativeFieldInfoPtr_SourceB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "SourceB");
			RecordPlayer.NativeFieldInfoPtr_MixerChannelVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "MixerChannelVolume");
			RecordPlayer.NativeFieldInfoPtr_FadeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "FadeLength");
			RecordPlayer.NativeFieldInfoPtr_MixerFadeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "MixerFadeLength");
			RecordPlayer.NativeFieldInfoPtr_SourceAIsNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "SourceAIsNext");
			RecordPlayer.NativeFieldInfoPtr_MasterMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "MasterMixer");
			RecordPlayer.NativeFieldInfoPtr_needleUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "needleUp");
			RecordPlayer.NativeFieldInfoPtr_mixerFadingOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "mixerFadingOut");
			RecordPlayer.NativeFieldInfoPtr_mixerFadingIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "mixerFadingIn");
			RecordPlayer.NativeFieldInfoPtr_recordPlayerVolumeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "recordPlayerVolumeString");
			RecordPlayer.NativeFieldInfoPtr_NeedleDownSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "NeedleDownSamples");
			RecordPlayer.NativeFieldInfoPtr_NeedleUpSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "NeedleUpSamples");
			RecordPlayer.NativeFieldInfoPtr_VinylCrackleSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "VinylCrackleSamples");
			RecordPlayer.NativeFieldInfoPtr_VinylCrackleLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "VinylCrackleLoop");
			RecordPlayer.NativeFieldInfoPtr_VinylCrackleSoundsPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "VinylCrackleSoundsPlayed");
			RecordPlayer.NativeFieldInfoPtr_sourceAFadingIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "sourceAFadingIn");
			RecordPlayer.NativeFieldInfoPtr_sourceBFadingIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "sourceBFadingIn");
			RecordPlayer.NativeFieldInfoPtr_sourceAStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "sourceAStartTime");
			RecordPlayer.NativeFieldInfoPtr_sourceBStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "sourceBStartTime");
			RecordPlayer.NativeFieldInfoPtr_IsHitchless = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "IsHitchless");
			RecordPlayer.NativeFieldInfoPtr_fadeInStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "fadeInStartTime");
			RecordPlayer.NativeFieldInfoPtr_fadeOutStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "fadeOutStartTime");
			RecordPlayer.NativeFieldInfoPtr_dspTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "dspTime");
			RecordPlayer.NativeFieldInfoPtr_timeUntilNextFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "timeUntilNextFade");
			RecordPlayer.NativeFieldInfoPtr_indexOfNextCrackle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, "indexOfNextCrackle");
			RecordPlayer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663893);
			RecordPlayer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663894);
			RecordPlayer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663895);
			RecordPlayer.NativeMethodInfoPtr_UpdateSources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663896);
			RecordPlayer.NativeMethodInfoPtr_NeedleDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663897);
			RecordPlayer.NativeMethodInfoPtr_NeedleUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663898);
			RecordPlayer.NativeMethodInfoPtr_NeedleDownHitchless_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663899);
			RecordPlayer.NativeMethodInfoPtr_StartHitchless_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663900);
			RecordPlayer.NativeMethodInfoPtr_StopHitchless_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663901);
			RecordPlayer.NativeMethodInfoPtr_CueNextClip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663902);
			RecordPlayer.NativeMethodInfoPtr_FadeCracklingOut_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663903);
			RecordPlayer.NativeMethodInfoPtr_FadeCracklingIn_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663904);
			RecordPlayer.NativeMethodInfoPtr_UpdateFadeIn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663905);
			RecordPlayer.NativeMethodInfoPtr_UpdateFadeOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663906);
			RecordPlayer.NativeMethodInfoPtr_PickClip_Private_Int32_Il2CppReferenceArray_1_AudioClip_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663907);
			RecordPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr, 100663908);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0004C4B4 File Offset: 0x0004A6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36737, XrefRangeEnd = 36769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0004C4E8 File Offset: 0x0004A6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36769, XrefRangeEnd = 36780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0004C51C File Offset: 0x0004A71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36780, XrefRangeEnd = 36812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0004C550 File Offset: 0x0004A750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36819, RefRangeEnd = 36820, XrefRangeStart = 36812, XrefRangeEnd = 36819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_UpdateSources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0004C584 File Offset: 0x0004A784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36844, RefRangeEnd = 36846, XrefRangeStart = 36820, XrefRangeEnd = 36844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NeedleDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_NeedleDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0004C5B8 File Offset: 0x0004A7B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36853, RefRangeEnd = 36855, XrefRangeStart = 36846, XrefRangeEnd = 36853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NeedleUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_NeedleUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0004C5EC File Offset: 0x0004A7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36855, XrefRangeEnd = 36876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NeedleDownHitchless()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_NeedleDownHitchless_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0004C620 File Offset: 0x0004A820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36876, XrefRangeEnd = 36890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartHitchless()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_StartHitchless_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0004C654 File Offset: 0x0004A854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36890, XrefRangeEnd = 36891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopHitchless()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_StopHitchless_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0004C688 File Offset: 0x0004A888
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36912, RefRangeEnd = 36914, XrefRangeStart = 36891, XrefRangeEnd = 36912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CueNextClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_CueNextClip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0004C6BC File Offset: 0x0004A8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36914, XrefRangeEnd = 36916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeCracklingOut(float TransitionTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref TransitionTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_FadeCracklingOut_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0004C6FC File Offset: 0x0004A8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36916, XrefRangeEnd = 36940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeCracklingIn(float TransitionTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref TransitionTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_FadeCracklingIn_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0004C73C File Offset: 0x0004A93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36940, XrefRangeEnd = 36943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFadeIn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_UpdateFadeIn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0004C770 File Offset: 0x0004A970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36943, XrefRangeEnd = 36950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFadeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_UpdateFadeOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0004C7A4 File Offset: 0x0004A9A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 36962, RefRangeEnd = 36967, XrefRangeStart = 36950, XrefRangeEnd = 36962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PickClip(Il2CppReferenceArray<AudioClip> clips, List<int> playedList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clips);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playedList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr_PickClip_Private_Int32_Il2CppReferenceArray_1_AudioClip_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0004C804 File Offset: 0x0004AA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36967, XrefRangeEnd = 36985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecordPlayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecordPlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000076F1 File Offset: 0x000058F1
		public RecordPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x0004C840 File Offset: 0x0004AA40
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x000076FA File Offset: 0x000058FA
		public unsafe static RecordPlayer me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RecordPlayer.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecordPlayer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RecordPlayer.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0004C868 File Offset: 0x0004AA68
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x0000770C File Offset: 0x0000590C
		public unsafe AudioSource SourceA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_SourceA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_SourceA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x0004C898 File Offset: 0x0004AA98
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x0000772B File Offset: 0x0000592B
		public unsafe AudioSource SourceB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_SourceB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_SourceB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x0004C8C8 File Offset: 0x0004AAC8
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x0000774A File Offset: 0x0000594A
		public unsafe float MixerChannelVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_MixerChannelVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_MixerChannelVolume)) = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x0004C8F0 File Offset: 0x0004AAF0
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00007765 File Offset: 0x00005965
		public unsafe float FadeLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_FadeLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_FadeLength)) = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0004C918 File Offset: 0x0004AB18
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00007780 File Offset: 0x00005980
		public unsafe float MixerFadeLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_MixerFadeLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_MixerFadeLength)) = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x0004C940 File Offset: 0x0004AB40
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x0000779B File Offset: 0x0000599B
		public unsafe bool SourceAIsNext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_SourceAIsNext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_SourceAIsNext)) = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0004C968 File Offset: 0x0004AB68
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x000077B6 File Offset: 0x000059B6
		public unsafe AudioMixer MasterMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_MasterMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_MasterMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x0004C998 File Offset: 0x0004AB98
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x000077D5 File Offset: 0x000059D5
		public unsafe bool needleUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_needleUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_needleUp)) = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x0004C9C0 File Offset: 0x0004ABC0
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x000077F0 File Offset: 0x000059F0
		public unsafe bool mixerFadingOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_mixerFadingOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_mixerFadingOut)) = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x0004C9E8 File Offset: 0x0004ABE8
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x0000780B File Offset: 0x00005A0B
		public unsafe bool mixerFadingIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_mixerFadingIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_mixerFadingIn)) = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x0004CA10 File Offset: 0x0004AC10
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00007826 File Offset: 0x00005A26
		public unsafe string recordPlayerVolumeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_recordPlayerVolumeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_recordPlayerVolumeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0004CA38 File Offset: 0x0004AC38
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00007845 File Offset: 0x00005A45
		public unsafe Il2CppReferenceArray<AudioClip> NeedleDownSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_NeedleDownSamples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_NeedleDownSamples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x0004CA68 File Offset: 0x0004AC68
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00007864 File Offset: 0x00005A64
		public unsafe Il2CppReferenceArray<AudioClip> NeedleUpSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_NeedleUpSamples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_NeedleUpSamples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0004CA98 File Offset: 0x0004AC98
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00007883 File Offset: 0x00005A83
		public unsafe Il2CppReferenceArray<AudioClip> VinylCrackleSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_VinylCrackleSamples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_VinylCrackleSamples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x0004CAC8 File Offset: 0x0004ACC8
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x000078A2 File Offset: 0x00005AA2
		public unsafe AudioClip VinylCrackleLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_VinylCrackleLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_VinylCrackleLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x0004CAF8 File Offset: 0x0004ACF8
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x000078C1 File Offset: 0x00005AC1
		public unsafe List<int> VinylCrackleSoundsPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_VinylCrackleSoundsPlayed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_VinylCrackleSoundsPlayed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0004CB28 File Offset: 0x0004AD28
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x000078E0 File Offset: 0x00005AE0
		public unsafe bool sourceAFadingIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_sourceAFadingIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_sourceAFadingIn)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0004CB50 File Offset: 0x0004AD50
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x000078FB File Offset: 0x00005AFB
		public unsafe bool sourceBFadingIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_sourceBFadingIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_sourceBFadingIn)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0004CB78 File Offset: 0x0004AD78
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00007916 File Offset: 0x00005B16
		public unsafe double sourceAStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_sourceAStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_sourceAStartTime)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0004CBA0 File Offset: 0x0004ADA0
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00007931 File Offset: 0x00005B31
		public unsafe double sourceBStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_sourceBStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_sourceBStartTime)) = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0004CBC8 File Offset: 0x0004ADC8
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x0000794C File Offset: 0x00005B4C
		public unsafe bool IsHitchless
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_IsHitchless);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_IsHitchless)) = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0004CBF0 File Offset: 0x0004ADF0
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x00007967 File Offset: 0x00005B67
		public unsafe float fadeInStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_fadeInStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_fadeInStartTime)) = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0004CC18 File Offset: 0x0004AE18
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x00007982 File Offset: 0x00005B82
		public unsafe float fadeOutStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_fadeOutStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_fadeOutStartTime)) = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x0004CC40 File Offset: 0x0004AE40
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x0000799D File Offset: 0x00005B9D
		public unsafe double dspTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_dspTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_dspTime)) = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x0004CC68 File Offset: 0x0004AE68
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x000079B8 File Offset: 0x00005BB8
		public unsafe float timeUntilNextFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_timeUntilNextFade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_timeUntilNextFade)) = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0004CC90 File Offset: 0x0004AE90
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x000079D3 File Offset: 0x00005BD3
		public unsafe int indexOfNextCrackle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_indexOfNextCrackle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordPlayer.NativeFieldInfoPtr_indexOfNextCrackle)) = value;
			}
		}

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeFieldInfoPtr_SourceA;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeFieldInfoPtr_SourceB;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_MixerChannelVolume;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_FadeLength;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_MixerFadeLength;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr_SourceAIsNext;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_MasterMixer;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_needleUp;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr_mixerFadingOut;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr_mixerFadingIn;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr_recordPlayerVolumeString;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr_NeedleDownSamples;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr_NeedleUpSamples;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr_VinylCrackleSamples;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr_VinylCrackleLoop;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr_VinylCrackleSoundsPlayed;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeFieldInfoPtr_sourceAFadingIn;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeFieldInfoPtr_sourceBFadingIn;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeFieldInfoPtr_sourceAStartTime;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeFieldInfoPtr_sourceBStartTime;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr_IsHitchless;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeFieldInfoPtr_fadeInStartTime;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr_fadeOutStartTime;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr_dspTime;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilNextFade;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr_indexOfNextCrackle;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSources_Private_Void_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_NeedleDown_Public_Void_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_NeedleUp_Public_Void_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_NeedleDownHitchless_Public_Void_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_StartHitchless_Public_Void_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_StopHitchless_Public_Void_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_CueNextClip_Private_Void_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_FadeCracklingOut_Public_Void_Single_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_FadeCracklingIn_Public_Void_Single_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFadeIn_Private_Void_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFadeOut_Private_Void_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_PickClip_Private_Int32_Il2CppReferenceArray_1_AudioClip_List_1_Int32_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
