using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2Cpp
{
	// Token: 0x0200002A RID: 42
	public class ListenerController : MonoBehaviour
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x000438BC File Offset: 0x00041ABC
		// Note: this type is marked as 'beforefieldinit'.
		static ListenerController()
		{
			Il2CppClassPointerStore<ListenerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ListenerController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListenerController>.NativeClassPtr);
			ListenerController.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "me");
			ListenerController.NativeFieldInfoPtr_mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "mixer");
			ListenerController.NativeFieldInfoPtr_resonanceListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "resonanceListener");
			ListenerController.NativeFieldInfoPtr_Wait2Sec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "Wait2Sec");
			ListenerController.NativeFieldInfoPtr_worldSoundV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "worldSoundV");
			ListenerController.NativeFieldInfoPtr_musicV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "musicV");
			ListenerController.NativeFieldInfoPtr_masterV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "masterV");
			ListenerController.NativeFieldInfoPtr_WorldSoundBus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "WorldSoundBus");
			ListenerController.NativeFieldInfoPtr_AmbianceBus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "AmbianceBus");
			ListenerController.NativeFieldInfoPtr_NoAmbiance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "NoAmbiance");
			ListenerController.NativeFieldInfoPtr_worldSoundVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "worldSoundVolume");
			ListenerController.NativeFieldInfoPtr_musicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "musicVolume");
			ListenerController.NativeFieldInfoPtr_ambianceVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ambianceVolume");
			ListenerController.NativeFieldInfoPtr_masterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "masterVolume");
			ListenerController.NativeFieldInfoPtr_drumVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "drumVolume");
			ListenerController.NativeFieldInfoPtr_cymbalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "cymbalVolume");
			ListenerController.NativeFieldInfoPtr_MyListeningMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MyListeningMode");
			ListenerController.NativeFieldInfoPtr_MaxMusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MaxMusicVolume");
			ListenerController.NativeFieldInfoPtr_MaxAmbianceVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MaxAmbianceVolume");
			ListenerController.NativeFieldInfoPtr_MaxWorldSoundVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MaxWorldSoundVolume");
			ListenerController.NativeFieldInfoPtr_MaxCymbalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MaxCymbalVolume");
			ListenerController.NativeFieldInfoPtr_ComputeBinaural = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ComputeBinaural");
			ListenerController.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "intensity");
			ListenerController.NativeFieldInfoPtr_prevIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "prevIntensity");
			ListenerController.NativeFieldInfoPtr_ambianceDownBcIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ambianceDownBcIntensity");
			ListenerController.NativeFieldInfoPtr_samingMusicBcIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "samingMusicBcIntensity");
			ListenerController.NativeFieldInfoPtr_ListenerFading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ListenerFading");
			ListenerController.NativeFieldInfoPtr_ListenerFadeFromVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ListenerFadeFromVal");
			ListenerController.NativeFieldInfoPtr_ListenerFadeToVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ListenerFadeToVal");
			ListenerController.NativeFieldInfoPtr_ListenerFadeStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ListenerFadeStartTime");
			ListenerController.NativeFieldInfoPtr_ListenerFadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ListenerFadeTime");
			ListenerController.NativeFieldInfoPtr_WorldSoundFading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "WorldSoundFading");
			ListenerController.NativeFieldInfoPtr_WorldSoundFadeFromVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "WorldSoundFadeFromVal");
			ListenerController.NativeFieldInfoPtr_WorldSoundFadeToVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "WorldSoundFadeToVal");
			ListenerController.NativeFieldInfoPtr_WorldSoundFadeStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "WorldSoundFadeStartTime");
			ListenerController.NativeFieldInfoPtr_WorldSoundFadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "WorldSoundFadeTime");
			ListenerController.NativeFieldInfoPtr_Exploding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "Exploding");
			ListenerController.NativeFieldInfoPtr_ExplosionStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ExplosionStartTime");
			ListenerController.NativeFieldInfoPtr_ExplosionStartedFading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ExplosionStartedFading");
			ListenerController.NativeFieldInfoPtr_ExplosionFadingOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ExplosionFadingOut");
			ListenerController.NativeFieldInfoPtr_ExplosionComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "ExplosionComplete");
			ListenerController.NativeFieldInfoPtr_MusicFading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MusicFading");
			ListenerController.NativeFieldInfoPtr_MusicFadeFromVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MusicFadeFromVal");
			ListenerController.NativeFieldInfoPtr_MusicMixerFadeFromVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MusicMixerFadeFromVal");
			ListenerController.NativeFieldInfoPtr_MusicFadeToVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MusicFadeToVal");
			ListenerController.NativeFieldInfoPtr_MusicVolumeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MusicVolumeOffset");
			ListenerController.NativeFieldInfoPtr_MusicFadeStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MusicFadeStartTime");
			ListenerController.NativeFieldInfoPtr_MusicFadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "MusicFadeTime");
			ListenerController.NativeFieldInfoPtr_AmbianceFading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "AmbianceFading");
			ListenerController.NativeFieldInfoPtr_AmbianceFadeFromVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "AmbianceFadeFromVal");
			ListenerController.NativeFieldInfoPtr_AmbianceFadeToVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "AmbianceFadeToVal");
			ListenerController.NativeFieldInfoPtr_AmbianceFadeStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "AmbianceFadeStartTime");
			ListenerController.NativeFieldInfoPtr_AmbianceFadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "AmbianceFadeTime");
			ListenerController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663738);
			ListenerController.NativeMethodInfoPtr_ToMixerVolume_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663739);
			ListenerController.NativeMethodInfoPtr_FromMixerVolume_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663740);
			ListenerController.NativeMethodInfoPtr_DisableAmbiance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663741);
			ListenerController.NativeMethodInfoPtr_EnableAmbiance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663742);
			ListenerController.NativeMethodInfoPtr_SetMusicVolume_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663743);
			ListenerController.NativeMethodInfoPtr_SetMaxMusicValues_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663744);
			ListenerController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663745);
			ListenerController.NativeMethodInfoPtr_SetListeningMode_Public_Void_ListeningMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663746);
			ListenerController.NativeMethodInfoPtr_SetVolumesFromPatch_Public_Void_ListenerControllerPatch_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663747);
			ListenerController.NativeMethodInfoPtr_SetVolumesFromPatchWithDelay_Private_IEnumerator_ListenerControllerPatch_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663748);
			ListenerController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663749);
			ListenerController.NativeMethodInfoPtr_UpdateListenerFade_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663750);
			ListenerController.NativeMethodInfoPtr_FadeOutListener_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663751);
			ListenerController.NativeMethodInfoPtr_FadeInListener_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663752);
			ListenerController.NativeMethodInfoPtr_FadeListenerTo_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663753);
			ListenerController.NativeMethodInfoPtr_UpdateWorldSoundFade_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663754);
			ListenerController.NativeMethodInfoPtr_FadeWorldSoundForExplosion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663755);
			ListenerController.NativeMethodInfoPtr_UpdateExplosion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663756);
			ListenerController.NativeMethodInfoPtr_FadeOutWorldSound_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663757);
			ListenerController.NativeMethodInfoPtr_FadeInWorldSound_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663758);
			ListenerController.NativeMethodInfoPtr_FadeWorldSoundTo_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663759);
			ListenerController.NativeMethodInfoPtr_FadeOutWorldSoundAndAmbiance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663760);
			ListenerController.NativeMethodInfoPtr_FadeInWorldSoundAndAmbiance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663761);
			ListenerController.NativeMethodInfoPtr_FadeWorldSoundAndAmbianceTo_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663762);
			ListenerController.NativeMethodInfoPtr_UpdateMusicFade_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663763);
			ListenerController.NativeMethodInfoPtr_FadeOutMusic_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663764);
			ListenerController.NativeMethodInfoPtr_FadeInMusic_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663765);
			ListenerController.NativeMethodInfoPtr_FadeMusicTo_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663766);
			ListenerController.NativeMethodInfoPtr_UpdateAmbianceFade_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663767);
			ListenerController.NativeMethodInfoPtr_FadeOutAmbiance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663768);
			ListenerController.NativeMethodInfoPtr_FadeInAmbiance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663769);
			ListenerController.NativeMethodInfoPtr_FadeAmbianceTo_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663770);
			ListenerController.NativeMethodInfoPtr_FadeMasterTo_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663771);
			ListenerController.NativeMethodInfoPtr_FadeOutMaster_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663772);
			ListenerController.NativeMethodInfoPtr_FadeInMaster_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663773);
			ListenerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, 100663774);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00043FF4 File Offset: 0x000421F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35249, XrefRangeEnd = 35260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00044028 File Offset: 0x00042228
		[CallerCount(0)]
		public unsafe static float ToMixerVolume(float a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_ToMixerVolume_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00044068 File Offset: 0x00042268
		[CallerCount(0)]
		public unsafe static float FromMixerVolume(float a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FromMixerVolume_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000440A8 File Offset: 0x000422A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35264, RefRangeEnd = 35266, XrefRangeStart = 35260, XrefRangeEnd = 35264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableAmbiance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_DisableAmbiance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000440DC File Offset: 0x000422DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35270, RefRangeEnd = 35271, XrefRangeStart = 35266, XrefRangeEnd = 35270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableAmbiance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_EnableAmbiance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00044110 File Offset: 0x00042310
		[CallerCount(0)]
		public unsafe void SetMusicVolume(float musicVol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref musicVol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_SetMusicVolume_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00044150 File Offset: 0x00042350
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 35277, RefRangeEnd = 35281, XrefRangeStart = 35271, XrefRangeEnd = 35277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxMusicValues(float maxMusic, float maxCymbal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxMusic;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCymbal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_SetMaxMusicValues_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0004419C File Offset: 0x0004239C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35281, XrefRangeEnd = 35315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000441D0 File Offset: 0x000423D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35315, XrefRangeEnd = 35327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetListeningMode(ListenerController.ListeningMode lm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_SetListeningMode_Public_Void_ListeningMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00044210 File Offset: 0x00042410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35327, XrefRangeEnd = 35331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolumesFromPatch(ListenerControllerPatch patch, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_SetVolumesFromPatch_Public_Void_ListenerControllerPatch_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00044260 File Offset: 0x00042460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35331, XrefRangeEnd = 35334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetVolumesFromPatchWithDelay(ListenerControllerPatch patch, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_SetVolumesFromPatchWithDelay_Private_IEnumerator_ListenerControllerPatch_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000442C0 File Offset: 0x000424C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35334, XrefRangeEnd = 35363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000442F4 File Offset: 0x000424F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35363, XrefRangeEnd = 35367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateListenerFade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_UpdateListenerFade_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00044328 File Offset: 0x00042528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35367, XrefRangeEnd = 35371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOutListener(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeOutListener_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00044368 File Offset: 0x00042568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35371, XrefRangeEnd = 35375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeInListener(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeInListener_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000443A8 File Offset: 0x000425A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35375, XrefRangeEnd = 35379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeListenerTo(float Value, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeListenerTo_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000443F4 File Offset: 0x000425F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35379, XrefRangeEnd = 35381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWorldSoundFade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_UpdateWorldSoundFade_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00044428 File Offset: 0x00042628
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35383, RefRangeEnd = 35385, XrefRangeStart = 35381, XrefRangeEnd = 35383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeWorldSoundForExplosion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeWorldSoundForExplosion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0004445C File Offset: 0x0004265C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35385, XrefRangeEnd = 35395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateExplosion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_UpdateExplosion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00044490 File Offset: 0x00042690
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 35397, RefRangeEnd = 35403, XrefRangeStart = 35395, XrefRangeEnd = 35397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOutWorldSound(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeOutWorldSound_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000444D0 File Offset: 0x000426D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 35405, RefRangeEnd = 35409, XrefRangeStart = 35403, XrefRangeEnd = 35405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeInWorldSound(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeInWorldSound_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00044510 File Offset: 0x00042710
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 35411, RefRangeEnd = 35417, XrefRangeStart = 35409, XrefRangeEnd = 35411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeWorldSoundTo(float Value, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeWorldSoundTo_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0004455C File Offset: 0x0004275C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35417, XrefRangeEnd = 35419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOutWorldSoundAndAmbiance(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeOutWorldSoundAndAmbiance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0004459C File Offset: 0x0004279C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35419, XrefRangeEnd = 35421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeInWorldSoundAndAmbiance(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeInWorldSoundAndAmbiance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000445DC File Offset: 0x000427DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35421, XrefRangeEnd = 35423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeWorldSoundAndAmbianceTo(float Value, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeWorldSoundAndAmbianceTo_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00044628 File Offset: 0x00042828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35423, XrefRangeEnd = 35426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMusicFade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_UpdateMusicFade_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0004465C File Offset: 0x0004285C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35429, RefRangeEnd = 35431, XrefRangeStart = 35426, XrefRangeEnd = 35429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOutMusic(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeOutMusic_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0004469C File Offset: 0x0004289C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35434, RefRangeEnd = 35436, XrefRangeStart = 35431, XrefRangeEnd = 35434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeInMusic(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeInMusic_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000446DC File Offset: 0x000428DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35439, RefRangeEnd = 35441, XrefRangeStart = 35436, XrefRangeEnd = 35439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeMusicTo(float Value, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeMusicTo_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00044728 File Offset: 0x00042928
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35452, RefRangeEnd = 35454, XrefRangeStart = 35441, XrefRangeEnd = 35452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAmbianceFade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_UpdateAmbianceFade_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0004475C File Offset: 0x0004295C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 35465, RefRangeEnd = 35472, XrefRangeStart = 35454, XrefRangeEnd = 35465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOutAmbiance(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeOutAmbiance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0004479C File Offset: 0x0004299C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 35474, RefRangeEnd = 35482, XrefRangeStart = 35472, XrefRangeEnd = 35474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeInAmbiance(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeInAmbiance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000447DC File Offset: 0x000429DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 35489, RefRangeEnd = 35497, XrefRangeStart = 35482, XrefRangeEnd = 35489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeAmbianceTo(float Value, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeAmbianceTo_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00044828 File Offset: 0x00042A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35497, XrefRangeEnd = 35500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeMasterTo(float Value, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeMasterTo_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00044874 File Offset: 0x00042A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35500, XrefRangeEnd = 35503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOutMaster(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeOutMaster_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000448B4 File Offset: 0x00042AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35503, XrefRangeEnd = 35506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeInMaster(float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr_FadeInMaster_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000448F4 File Offset: 0x00042AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35506, XrefRangeEnd = 35522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListenerController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListenerController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00004FFB File Offset: 0x000031FB
		public ListenerController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00044930 File Offset: 0x00042B30
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00005004 File Offset: 0x00003204
		public unsafe static ListenerController me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ListenerController.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListenerController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListenerController.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00044958 File Offset: 0x00042B58
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00005016 File Offset: 0x00003216
		public unsafe AudioMixer mixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_mixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_mixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00044988 File Offset: 0x00042B88
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00005035 File Offset: 0x00003235
		public unsafe ResonanceAudioListener resonanceListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_resonanceListener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceAudioListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_resonanceListener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x000449B8 File Offset: 0x00042BB8
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00005054 File Offset: 0x00003254
		public unsafe WaitForSeconds Wait2Sec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_Wait2Sec);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_Wait2Sec), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x000449E8 File Offset: 0x00042BE8
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00005073 File Offset: 0x00003273
		public unsafe string worldSoundV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_worldSoundV);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_worldSoundV), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00044A10 File Offset: 0x00042C10
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00005092 File Offset: 0x00003292
		public unsafe string musicV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_musicV);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_musicV), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00044A38 File Offset: 0x00042C38
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x000050B1 File Offset: 0x000032B1
		public unsafe string masterV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_masterV);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_masterV), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00044A60 File Offset: 0x00042C60
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x000050D0 File Offset: 0x000032D0
		public unsafe SECTR_AudioBus WorldSoundBus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundBus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioBus>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundBus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00044A90 File Offset: 0x00042C90
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x000050EF File Offset: 0x000032EF
		public unsafe SECTR_AudioBus AmbianceBus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceBus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioBus>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceBus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00044AC0 File Offset: 0x00042CC0
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x0000510E File Offset: 0x0000330E
		public unsafe bool NoAmbiance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_NoAmbiance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_NoAmbiance)) = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00044AE8 File Offset: 0x00042CE8
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00005129 File Offset: 0x00003329
		public unsafe float worldSoundVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_worldSoundVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_worldSoundVolume)) = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00044B10 File Offset: 0x00042D10
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00005144 File Offset: 0x00003344
		public unsafe float musicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_musicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_musicVolume)) = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00044B38 File Offset: 0x00042D38
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x0000515F File Offset: 0x0000335F
		public unsafe float ambianceVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ambianceVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ambianceVolume)) = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00044B60 File Offset: 0x00042D60
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x0000517A File Offset: 0x0000337A
		public unsafe float masterVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_masterVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_masterVolume)) = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00044B88 File Offset: 0x00042D88
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00005195 File Offset: 0x00003395
		public unsafe string drumVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_drumVolume);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_drumVolume), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00044BB0 File Offset: 0x00042DB0
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x000051B4 File Offset: 0x000033B4
		public unsafe string cymbalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_cymbalVolume);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_cymbalVolume), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00044BD8 File Offset: 0x00042DD8
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x000051D3 File Offset: 0x000033D3
		public unsafe ListenerController.ListeningMode MyListeningMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MyListeningMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MyListeningMode)) = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00044C00 File Offset: 0x00042E00
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x000051EE File Offset: 0x000033EE
		public unsafe float MaxMusicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MaxMusicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MaxMusicVolume)) = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00044C28 File Offset: 0x00042E28
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00005209 File Offset: 0x00003409
		public unsafe float MaxAmbianceVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MaxAmbianceVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MaxAmbianceVolume)) = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00044C50 File Offset: 0x00042E50
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x00005224 File Offset: 0x00003424
		public unsafe float MaxWorldSoundVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MaxWorldSoundVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MaxWorldSoundVolume)) = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00044C78 File Offset: 0x00042E78
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x0000523F File Offset: 0x0000343F
		public unsafe float MaxCymbalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MaxCymbalVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MaxCymbalVolume)) = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00044CA0 File Offset: 0x00042EA0
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x0000525A File Offset: 0x0000345A
		public unsafe bool ComputeBinaural
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ComputeBinaural);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ComputeBinaural)) = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00044CC8 File Offset: 0x00042EC8
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00005275 File Offset: 0x00003475
		public unsafe float intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_intensity)) = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00044CF0 File Offset: 0x00042EF0
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00005290 File Offset: 0x00003490
		public unsafe float prevIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_prevIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_prevIntensity)) = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00044D18 File Offset: 0x00042F18
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x000052AB File Offset: 0x000034AB
		public unsafe bool ambianceDownBcIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ambianceDownBcIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ambianceDownBcIntensity)) = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00044D40 File Offset: 0x00042F40
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x000052C6 File Offset: 0x000034C6
		public unsafe bool samingMusicBcIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_samingMusicBcIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_samingMusicBcIntensity)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00044D68 File Offset: 0x00042F68
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x000052E1 File Offset: 0x000034E1
		public unsafe bool ListenerFading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ListenerFading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ListenerFading)) = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00044D90 File Offset: 0x00042F90
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x000052FC File Offset: 0x000034FC
		public unsafe float ListenerFadeFromVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ListenerFadeFromVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ListenerFadeFromVal)) = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00044DB8 File Offset: 0x00042FB8
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00005317 File Offset: 0x00003517
		public unsafe float ListenerFadeToVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ListenerFadeToVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ListenerFadeToVal)) = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00044DE0 File Offset: 0x00042FE0
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00005332 File Offset: 0x00003532
		public unsafe float ListenerFadeStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ListenerFadeStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ListenerFadeStartTime)) = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00044E08 File Offset: 0x00043008
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x0000534D File Offset: 0x0000354D
		public unsafe float ListenerFadeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ListenerFadeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ListenerFadeTime)) = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00044E30 File Offset: 0x00043030
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00005368 File Offset: 0x00003568
		public unsafe bool WorldSoundFading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundFading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundFading)) = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00044E58 File Offset: 0x00043058
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00005383 File Offset: 0x00003583
		public unsafe float WorldSoundFadeFromVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundFadeFromVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundFadeFromVal)) = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00044E80 File Offset: 0x00043080
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x0000539E File Offset: 0x0000359E
		public unsafe float WorldSoundFadeToVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundFadeToVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundFadeToVal)) = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00044EA8 File Offset: 0x000430A8
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x000053B9 File Offset: 0x000035B9
		public unsafe float WorldSoundFadeStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundFadeStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundFadeStartTime)) = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00044ED0 File Offset: 0x000430D0
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x000053D4 File Offset: 0x000035D4
		public unsafe float WorldSoundFadeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundFadeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_WorldSoundFadeTime)) = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00044EF8 File Offset: 0x000430F8
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x000053EF File Offset: 0x000035EF
		public unsafe bool Exploding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_Exploding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_Exploding)) = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00044F20 File Offset: 0x00043120
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0000540A File Offset: 0x0000360A
		public unsafe float ExplosionStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ExplosionStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ExplosionStartTime)) = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00044F48 File Offset: 0x00043148
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00005425 File Offset: 0x00003625
		public unsafe bool ExplosionStartedFading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ExplosionStartedFading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ExplosionStartedFading)) = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00044F70 File Offset: 0x00043170
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00005440 File Offset: 0x00003640
		public unsafe bool ExplosionFadingOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ExplosionFadingOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ExplosionFadingOut)) = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00044F98 File Offset: 0x00043198
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x0000545B File Offset: 0x0000365B
		public unsafe bool ExplosionComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ExplosionComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_ExplosionComplete)) = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00044FC0 File Offset: 0x000431C0
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00005476 File Offset: 0x00003676
		public unsafe bool MusicFading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicFading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicFading)) = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00044FE8 File Offset: 0x000431E8
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00005491 File Offset: 0x00003691
		public unsafe float MusicFadeFromVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicFadeFromVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicFadeFromVal)) = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00045010 File Offset: 0x00043210
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x000054AC File Offset: 0x000036AC
		public unsafe float MusicMixerFadeFromVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicMixerFadeFromVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicMixerFadeFromVal)) = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00045038 File Offset: 0x00043238
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x000054C7 File Offset: 0x000036C7
		public unsafe float MusicFadeToVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicFadeToVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicFadeToVal)) = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00045060 File Offset: 0x00043260
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x000054E2 File Offset: 0x000036E2
		public unsafe float MusicVolumeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicVolumeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicVolumeOffset)) = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00045088 File Offset: 0x00043288
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x000054FD File Offset: 0x000036FD
		public unsafe float MusicFadeStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicFadeStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicFadeStartTime)) = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x000450B0 File Offset: 0x000432B0
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x00005518 File Offset: 0x00003718
		public unsafe float MusicFadeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicFadeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_MusicFadeTime)) = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x000450D8 File Offset: 0x000432D8
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00005533 File Offset: 0x00003733
		public unsafe bool AmbianceFading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceFading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceFading)) = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00045100 File Offset: 0x00043300
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x0000554E File Offset: 0x0000374E
		public unsafe float AmbianceFadeFromVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceFadeFromVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceFadeFromVal)) = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00045128 File Offset: 0x00043328
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x00005569 File Offset: 0x00003769
		public unsafe float AmbianceFadeToVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceFadeToVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceFadeToVal)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00045150 File Offset: 0x00043350
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x00005584 File Offset: 0x00003784
		public unsafe float AmbianceFadeStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceFadeStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceFadeStartTime)) = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00045178 File Offset: 0x00043378
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x0000559F File Offset: 0x0000379F
		public unsafe float AmbianceFadeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceFadeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController.NativeFieldInfoPtr_AmbianceFadeTime)) = value;
			}
		}

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr_mixer;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_resonanceListener;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_Wait2Sec;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_worldSoundV;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_musicV;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr_masterV;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeFieldInfoPtr_WorldSoundBus;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr_AmbianceBus;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr_NoAmbiance;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeFieldInfoPtr_worldSoundVolume;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr_musicVolume;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeFieldInfoPtr_ambianceVolume;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeFieldInfoPtr_masterVolume;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeFieldInfoPtr_drumVolume;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeFieldInfoPtr_cymbalVolume;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr_MyListeningMode;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr_MaxMusicVolume;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr_MaxAmbianceVolume;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr_MaxWorldSoundVolume;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeFieldInfoPtr_MaxCymbalVolume;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr_ComputeBinaural;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeFieldInfoPtr_prevIntensity;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr_ambianceDownBcIntensity;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_samingMusicBcIntensity;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_ListenerFading;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_ListenerFadeFromVal;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_ListenerFadeToVal;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_ListenerFadeStartTime;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_ListenerFadeTime;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_WorldSoundFading;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr_WorldSoundFadeFromVal;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_WorldSoundFadeToVal;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_WorldSoundFadeStartTime;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeFieldInfoPtr_WorldSoundFadeTime;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_Exploding;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionStartTime;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionStartedFading;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionFadingOut;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionComplete;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeFieldInfoPtr_MusicFading;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeFieldInfoPtr_MusicFadeFromVal;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr_MusicMixerFadeFromVal;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_MusicFadeToVal;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_MusicVolumeOffset;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_MusicFadeStartTime;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_MusicFadeTime;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_AmbianceFading;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr_AmbianceFadeFromVal;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_AmbianceFadeToVal;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr_AmbianceFadeStartTime;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeFieldInfoPtr_AmbianceFadeTime;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_ToMixerVolume_Public_Static_Single_Single_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_FromMixerVolume_Public_Static_Single_Single_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_DisableAmbiance_Public_Void_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_EnableAmbiance_Public_Void_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_SetMusicVolume_Public_Void_Single_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxMusicValues_Public_Void_Single_Single_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_SetListeningMode_Public_Void_ListeningMode_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_SetVolumesFromPatch_Public_Void_ListenerControllerPatch_Single_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_SetVolumesFromPatchWithDelay_Private_IEnumerator_ListenerControllerPatch_Single_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_UpdateListenerFade_Private_Void_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_FadeOutListener_Public_Void_Single_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_FadeInListener_Public_Void_Single_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_FadeListenerTo_Public_Void_Single_Single_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWorldSoundFade_Private_Void_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_FadeWorldSoundForExplosion_Public_Void_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_UpdateExplosion_Private_Void_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_FadeOutWorldSound_Public_Void_Single_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_FadeInWorldSound_Public_Void_Single_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_FadeWorldSoundTo_Public_Void_Single_Single_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_FadeOutWorldSoundAndAmbiance_Public_Void_Single_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_FadeInWorldSoundAndAmbiance_Public_Void_Single_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_FadeWorldSoundAndAmbianceTo_Public_Void_Single_Single_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMusicFade_Private_Void_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_FadeOutMusic_Public_Void_Single_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_FadeInMusic_Public_Void_Single_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_FadeMusicTo_Public_Void_Single_Single_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAmbianceFade_Private_Void_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_FadeOutAmbiance_Public_Void_Single_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_FadeInAmbiance_Public_Void_Single_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_FadeAmbianceTo_Public_Void_Single_Single_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_FadeMasterTo_Public_Void_Single_Single_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_FadeOutMaster_Public_Void_Single_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_FadeInMaster_Public_Void_Single_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002AE RID: 686
		[OriginalName("Assembly-CSharp.dll", "", "ListeningMode")]
		public enum ListeningMode
		{
			// Token: 0x040030FB RID: 12539
			Mono,
			// Token: 0x040030FC RID: 12540
			StereoHeadphones,
			// Token: 0x040030FD RID: 12541
			StereoSpeakers,
			// Token: 0x040030FE RID: 12542
			FivePt1,
			// Token: 0x040030FF RID: 12543
			SevenPt1
		}

		// Token: 0x020002AF RID: 687
		[ObfuscatedName("ListenerController+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004ADD RID: 19165 RVA: 0x00115144 File Offset: 0x00113344
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ListenerController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListenerController.__c>.NativeClassPtr);
				ListenerController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController.__c>.NativeClassPtr, "<>9");
				ListenerController.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController.__c>.NativeClassPtr, "<>9__33_0");
				ListenerController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController.__c>.NativeClassPtr, 100663776);
				ListenerController.__c.NativeMethodInfoPtr__SetVolumesFromPatchWithDelay_b__33_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController.__c>.NativeClassPtr, 100663777);
			}

			// Token: 0x06004ADE RID: 19166 RVA: 0x001151C0 File Offset: 0x001133C0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListenerController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004ADF RID: 19167 RVA: 0x001151FC File Offset: 0x001133FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35224, XrefRangeEnd = 35226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetVolumesFromPatchWithDelay_b__33_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController.__c.NativeMethodInfoPtr__SetVolumesFromPatchWithDelay_b__33_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004AE0 RID: 19168 RVA: 0x0002C0E4 File Offset: 0x0002A2E4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B34 RID: 6964
			// (get) Token: 0x06004AE1 RID: 19169 RVA: 0x00115238 File Offset: 0x00113438
			// (set) Token: 0x06004AE2 RID: 19170 RVA: 0x0002C0ED File Offset: 0x0002A2ED
			public unsafe static ListenerController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListenerController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListenerController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListenerController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B35 RID: 6965
			// (get) Token: 0x06004AE3 RID: 19171 RVA: 0x00115260 File Offset: 0x00113460
			// (set) Token: 0x06004AE4 RID: 19172 RVA: 0x0002C0FF File Offset: 0x0002A2FF
			public unsafe static Func<bool> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListenerController.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListenerController.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003100 RID: 12544
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003101 RID: 12545
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x04003102 RID: 12546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003103 RID: 12547
			private static readonly IntPtr NativeMethodInfoPtr__SetVolumesFromPatchWithDelay_b__33_0_Internal_Boolean_0;
		}

		// Token: 0x020002B0 RID: 688
		[ObfuscatedName("ListenerController+<SetVolumesFromPatchWithDelay>d__33")]
		public sealed class _SetVolumesFromPatchWithDelay_d__33 : global::Il2CppSystem.Object
		{
			// Token: 0x06004AE5 RID: 19173 RVA: 0x00115288 File Offset: 0x00113488
			// Note: this type is marked as 'beforefieldinit'.
			static _SetVolumesFromPatchWithDelay_d__33()
			{
				Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListenerController>.NativeClassPtr, "<SetVolumesFromPatchWithDelay>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr);
				ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr, "<>1__state");
				ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr, "<>2__current");
				ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr, "<>4__this");
				ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr_patch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr, "patch");
				ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr, "fadeTime");
				ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr, 100663778);
				ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr, 100663779);
				ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr, 100663780);
				ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr, 100663781);
				ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr, 100663782);
				ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr, 100663783);
			}

			// Token: 0x06004AE6 RID: 19174 RVA: 0x00115390 File Offset: 0x00113590
			[CallerCount(0)]
			public unsafe _SetVolumesFromPatchWithDelay_d__33(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListenerController._SetVolumesFromPatchWithDelay_d__33>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004AE7 RID: 19175 RVA: 0x001153D8 File Offset: 0x001135D8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AE8 RID: 19176 RVA: 0x0011540C File Offset: 0x0011360C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35226, XrefRangeEnd = 35244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B3B RID: 6971
			// (get) Token: 0x06004AE9 RID: 19177 RVA: 0x00115448 File Offset: 0x00113648
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AEA RID: 19178 RVA: 0x00115488 File Offset: 0x00113688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35244, XrefRangeEnd = 35249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B3C RID: 6972
			// (get) Token: 0x06004AEB RID: 19179 RVA: 0x001154BC File Offset: 0x001136BC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AEC RID: 19180 RVA: 0x0002C111 File Offset: 0x0002A311
			public _SetVolumesFromPatchWithDelay_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B36 RID: 6966
			// (get) Token: 0x06004AED RID: 19181 RVA: 0x001154FC File Offset: 0x001136FC
			// (set) Token: 0x06004AEE RID: 19182 RVA: 0x0002C11A File Offset: 0x0002A31A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B37 RID: 6967
			// (get) Token: 0x06004AEF RID: 19183 RVA: 0x00115524 File Offset: 0x00113724
			// (set) Token: 0x06004AF0 RID: 19184 RVA: 0x0002C135 File Offset: 0x0002A335
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B38 RID: 6968
			// (get) Token: 0x06004AF1 RID: 19185 RVA: 0x00115554 File Offset: 0x00113754
			// (set) Token: 0x06004AF2 RID: 19186 RVA: 0x0002C154 File Offset: 0x0002A354
			public unsafe ListenerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListenerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B39 RID: 6969
			// (get) Token: 0x06004AF3 RID: 19187 RVA: 0x00115584 File Offset: 0x00113784
			// (set) Token: 0x06004AF4 RID: 19188 RVA: 0x0002C173 File Offset: 0x0002A373
			public unsafe ListenerControllerPatch patch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr_patch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListenerControllerPatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr_patch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B3A RID: 6970
			// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x001155B4 File Offset: 0x001137B4
			// (set) Token: 0x06004AF6 RID: 19190 RVA: 0x0002C192 File Offset: 0x0002A392
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerController._SetVolumesFromPatchWithDelay_d__33.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x04003104 RID: 12548
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003105 RID: 12549
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003106 RID: 12550
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003107 RID: 12551
			private static readonly IntPtr NativeFieldInfoPtr_patch;

			// Token: 0x04003108 RID: 12552
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x04003109 RID: 12553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400310A RID: 12554
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400310B RID: 12555
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400310C RID: 12556
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400310D RID: 12557
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400310E RID: 12558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
