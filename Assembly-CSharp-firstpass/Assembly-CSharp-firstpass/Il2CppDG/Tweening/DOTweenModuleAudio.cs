using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2CppDG.Tweening
{
	// Token: 0x020001ED RID: 493
	public static class DOTweenModuleAudio : global::Il2CppSystem.Object
	{
		// Token: 0x0600192F RID: 6447 RVA: 0x00071438 File Offset: 0x0006F638
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenModuleAudio()
		{
			Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "DG.Tweening", "DOTweenModuleAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Single_Single_FloatOptions_AudioSource_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667034);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOPitch_Public_Static_TweenerCore_3_Single_Single_FloatOptions_AudioSource_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667035);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOSetFloat_Public_Static_TweenerCore_3_Single_Single_FloatOptions_AudioMixer_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667036);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOComplete_Public_Static_Int32_AudioMixer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667037);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOKill_Public_Static_Int32_AudioMixer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667038);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOFlip_Public_Static_Int32_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667039);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOGoto_Public_Static_Int32_AudioMixer_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667040);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOPause_Public_Static_Int32_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667041);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOPlay_Public_Static_Int32_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667042);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667043);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667044);
			DOTweenModuleAudio.NativeMethodInfoPtr_DORestart_Public_Static_Int32_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667045);
			DOTweenModuleAudio.NativeMethodInfoPtr_DORewind_Public_Static_Int32_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667046);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667047);
			DOTweenModuleAudio.NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, 100667048);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00071594 File Offset: 0x0006F794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20685, RefRangeEnd = 20686, XrefRangeStart = 20663, XrefRangeEnd = 20685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Single_Single_FloatOptions_AudioSource_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x000715F4 File Offset: 0x0006F7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20686, XrefRangeEnd = 20707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOPitch_Public_Static_TweenerCore_3_Single_Single_FloatOptions_AudioSource_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00071654 File Offset: 0x0006F854
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 20728, RefRangeEnd = 20744, XrefRangeStart = 20707, XrefRangeEnd = 20728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(floatName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOSetFloat_Public_Static_TweenerCore_3_Single_Single_FloatOptions_AudioMixer_String_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x000716C8 File Offset: 0x0006F8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20744, XrefRangeEnd = 20751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOComplete_Public_Static_Int32_AudioMixer_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00071718 File Offset: 0x0006F918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20751, XrefRangeEnd = 20755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOKill(this AudioMixer target, bool complete = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOKill_Public_Static_Int32_AudioMixer_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00071768 File Offset: 0x0006F968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20755, XrefRangeEnd = 20762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOFlip(this AudioMixer target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOFlip_Public_Static_Int32_AudioMixer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x000717AC File Offset: 0x0006F9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20762, XrefRangeEnd = 20769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOGoto_Public_Static_Int32_AudioMixer_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0007180C File Offset: 0x0006FA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20769, XrefRangeEnd = 20776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPause(this AudioMixer target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOPause_Public_Static_Int32_AudioMixer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00071850 File Offset: 0x0006FA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20776, XrefRangeEnd = 20783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlay(this AudioMixer target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOPlay_Public_Static_Int32_AudioMixer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00071894 File Offset: 0x0006FA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20783, XrefRangeEnd = 20790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlayBackwards(this AudioMixer target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_AudioMixer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x000718D8 File Offset: 0x0006FAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20790, XrefRangeEnd = 20797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlayForward(this AudioMixer target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_AudioMixer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0007191C File Offset: 0x0006FB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20797, XrefRangeEnd = 20804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DORestart(this AudioMixer target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DORestart_Public_Static_Int32_AudioMixer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00071960 File Offset: 0x0006FB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20804, XrefRangeEnd = 20811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DORewind(this AudioMixer target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DORewind_Public_Static_Int32_AudioMixer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000719A4 File Offset: 0x0006FBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20811, XrefRangeEnd = 20818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOSmoothRewind(this AudioMixer target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_AudioMixer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000719E8 File Offset: 0x0006FBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20818, XrefRangeEnd = 20825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOTogglePause(this AudioMixer target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_AudioMixer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00009EEC File Offset: 0x000080EC
		public DOTweenModuleAudio(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Single_Single_FloatOptions_AudioSource_Single_Single_0;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeMethodInfoPtr_DOPitch_Public_Static_TweenerCore_3_Single_Single_FloatOptions_AudioSource_Single_Single_0;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeMethodInfoPtr_DOSetFloat_Public_Static_TweenerCore_3_Single_Single_FloatOptions_AudioMixer_String_Single_Single_0;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeMethodInfoPtr_DOComplete_Public_Static_Int32_AudioMixer_Boolean_0;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeMethodInfoPtr_DOKill_Public_Static_Int32_AudioMixer_Boolean_0;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeMethodInfoPtr_DOFlip_Public_Static_Int32_AudioMixer_0;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeMethodInfoPtr_DOGoto_Public_Static_Int32_AudioMixer_Single_Boolean_0;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr_DOPause_Public_Static_Int32_AudioMixer_0;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_DOPlay_Public_Static_Int32_AudioMixer_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_AudioMixer_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_AudioMixer_0;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeMethodInfoPtr_DORestart_Public_Static_Int32_AudioMixer_0;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeMethodInfoPtr_DORewind_Public_Static_Int32_AudioMixer_0;

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_AudioMixer_0;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_AudioMixer_0;

		// Token: 0x02000271 RID: 625
		[ObfuscatedName("DG.Tweening.DOTweenModuleAudio+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600221D RID: 8733 RVA: 0x00094160 File Offset: 0x00092360
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass0_0>.NativeClassPtr);
				DOTweenModuleAudio.__c__DisplayClass0_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass0_0>.NativeClassPtr, "target");
				DOTweenModuleAudio.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass0_0>.NativeClassPtr, 100667049);
				DOTweenModuleAudio.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass0_0>.NativeClassPtr, 100667050);
				DOTweenModuleAudio.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass0_0>.NativeClassPtr, 100667051);
			}

			// Token: 0x0600221E RID: 8734 RVA: 0x000941DC File Offset: 0x000923DC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600221F RID: 8735 RVA: 0x00094218 File Offset: 0x00092418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20639, XrefRangeEnd = 20644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002220 RID: 8736 RVA: 0x00094254 File Offset: 0x00092454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20644, XrefRangeEnd = 20649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFade_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002221 RID: 8737 RVA: 0x0000CB74 File Offset: 0x0000AD74
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x06002222 RID: 8738 RVA: 0x00094294 File Offset: 0x00092494
			// (set) Token: 0x06002223 RID: 8739 RVA: 0x0000CB7D File Offset: 0x0000AD7D
			public unsafe AudioSource target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleAudio.__c__DisplayClass0_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleAudio.__c__DisplayClass0_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400215A RID: 8538
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400215B RID: 8539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400215C RID: 8540
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Single_0;

			// Token: 0x0400215D RID: 8541
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000272 RID: 626
		[ObfuscatedName("DG.Tweening.DOTweenModuleAudio+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002224 RID: 8740 RVA: 0x000942C4 File Offset: 0x000924C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass1_0>.NativeClassPtr);
				DOTweenModuleAudio.__c__DisplayClass1_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass1_0>.NativeClassPtr, "target");
				DOTweenModuleAudio.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass1_0>.NativeClassPtr, 100667052);
				DOTweenModuleAudio.__c__DisplayClass1_0.NativeMethodInfoPtr__DOPitch_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass1_0>.NativeClassPtr, 100667053);
				DOTweenModuleAudio.__c__DisplayClass1_0.NativeMethodInfoPtr__DOPitch_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass1_0>.NativeClassPtr, 100667054);
			}

			// Token: 0x06002225 RID: 8741 RVA: 0x00094340 File Offset: 0x00092540
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002226 RID: 8742 RVA: 0x0009437C File Offset: 0x0009257C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20649, XrefRangeEnd = 20654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOPitch_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.__c__DisplayClass1_0.NativeMethodInfoPtr__DOPitch_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002227 RID: 8743 RVA: 0x000943B8 File Offset: 0x000925B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20654, XrefRangeEnd = 20659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPitch_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.__c__DisplayClass1_0.NativeMethodInfoPtr__DOPitch_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002228 RID: 8744 RVA: 0x0000CB9C File Offset: 0x0000AD9C
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x06002229 RID: 8745 RVA: 0x000943F8 File Offset: 0x000925F8
			// (set) Token: 0x0600222A RID: 8746 RVA: 0x0000CBA5 File Offset: 0x0000ADA5
			public unsafe AudioSource target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleAudio.__c__DisplayClass1_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleAudio.__c__DisplayClass1_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400215E RID: 8542
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400215F RID: 8543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002160 RID: 8544
			private static readonly IntPtr NativeMethodInfoPtr__DOPitch_b__0_Internal_Single_0;

			// Token: 0x04002161 RID: 8545
			private static readonly IntPtr NativeMethodInfoPtr__DOPitch_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000273 RID: 627
		[ObfuscatedName("DG.Tweening.DOTweenModuleAudio+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600222B RID: 8747 RVA: 0x00094428 File Offset: 0x00092628
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleAudio>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass2_0>.NativeClassPtr);
				DOTweenModuleAudio.__c__DisplayClass2_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass2_0>.NativeClassPtr, "target");
				DOTweenModuleAudio.__c__DisplayClass2_0.NativeFieldInfoPtr_floatName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass2_0>.NativeClassPtr, "floatName");
				DOTweenModuleAudio.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass2_0>.NativeClassPtr, 100667055);
				DOTweenModuleAudio.__c__DisplayClass2_0.NativeMethodInfoPtr__DOSetFloat_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass2_0>.NativeClassPtr, 100667056);
				DOTweenModuleAudio.__c__DisplayClass2_0.NativeMethodInfoPtr__DOSetFloat_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass2_0>.NativeClassPtr, 100667057);
			}

			// Token: 0x0600222C RID: 8748 RVA: 0x000944B8 File Offset: 0x000926B8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleAudio.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600222D RID: 8749 RVA: 0x000944F4 File Offset: 0x000926F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20659, XrefRangeEnd = 20661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOSetFloat_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.__c__DisplayClass2_0.NativeMethodInfoPtr__DOSetFloat_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600222E RID: 8750 RVA: 0x00094530 File Offset: 0x00092730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20661, XrefRangeEnd = 20663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOSetFloat_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleAudio.__c__DisplayClass2_0.NativeMethodInfoPtr__DOSetFloat_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600222F RID: 8751 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x06002230 RID: 8752 RVA: 0x00094570 File Offset: 0x00092770
			// (set) Token: 0x06002231 RID: 8753 RVA: 0x0000CBCD File Offset: 0x0000ADCD
			public unsafe AudioMixer target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleAudio.__c__DisplayClass2_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleAudio.__c__DisplayClass2_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x06002232 RID: 8754 RVA: 0x000945A0 File Offset: 0x000927A0
			// (set) Token: 0x06002233 RID: 8755 RVA: 0x0000CBEC File Offset: 0x0000ADEC
			public unsafe string floatName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleAudio.__c__DisplayClass2_0.NativeFieldInfoPtr_floatName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleAudio.__c__DisplayClass2_0.NativeFieldInfoPtr_floatName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002162 RID: 8546
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002163 RID: 8547
			private static readonly IntPtr NativeFieldInfoPtr_floatName;

			// Token: 0x04002164 RID: 8548
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002165 RID: 8549
			private static readonly IntPtr NativeMethodInfoPtr__DOSetFloat_b__0_Internal_Single_0;

			// Token: 0x04002166 RID: 8550
			private static readonly IntPtr NativeMethodInfoPtr__DOSetFloat_b__1_Internal_Void_Single_0;
		}
	}
}
