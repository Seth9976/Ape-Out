using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public sealed class AudioLowPassFilter : Behaviour
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00005D98 File Offset: 0x00003F98
		// Note: this type is marked as 'beforefieldinit'.
		static AudioLowPassFilter()
		{
			Il2CppClassPointerStore<AudioLowPassFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioLowPassFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioLowPassFilter>.NativeClassPtr);
			AudioLowPassFilter.NativeMethodInfoPtr_set_cutoffFrequency_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioLowPassFilter>.NativeClassPtr, 100663409);
			AudioLowPassFilter.NativeMethodInfoPtr_set_lowpassResonanceQ_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioLowPassFilter>.NativeClassPtr, 100663410);
			AudioLowPassFilter.GetCustomLowpassLevelCurveCopyDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.GetCustomLowpassLevelCurveCopyDelegate>("UnityEngine.AudioLowPassFilter::GetCustomLowpassLevelCurveCopy");
			AudioLowPassFilter.SetCustomLowpassLevelCurveHelperDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.SetCustomLowpassLevelCurveHelperDelegate>("UnityEngine.AudioLowPassFilter::SetCustomLowpassLevelCurveHelper");
			AudioLowPassFilter.get_cutoffFrequencyDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.get_cutoffFrequencyDelegate>("UnityEngine.AudioLowPassFilter::get_cutoffFrequency");
			AudioLowPassFilter.get_lowpassResonanceQDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.get_lowpassResonanceQDelegate>("UnityEngine.AudioLowPassFilter::get_lowpassResonanceQ");
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002666 File Offset: 0x00000866
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00005E2C File Offset: 0x0000402C
		public unsafe float cutoffFrequency
		{
			get
			{
				return AudioLowPassFilter.get_cutoffFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485276, XrefRangeEnd = 485280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioLowPassFilter.NativeMethodInfoPtr_set_cutoffFrequency_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002678 File Offset: 0x00000878
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00005E6C File Offset: 0x0000406C
		public unsafe float lowpassResonanceQ
		{
			get
			{
				return AudioLowPassFilter.get_lowpassResonanceQDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485280, XrefRangeEnd = 485284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioLowPassFilter.NativeMethodInfoPtr_set_lowpassResonanceQ_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000263A File Offset: 0x0000083A
		public AudioLowPassFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005EAC File Offset: 0x000040AC
		public AnimationCurve GetCustomLowpassLevelCurveCopy()
		{
			IntPtr intPtr = AudioLowPassFilter.GetCustomLowpassLevelCurveCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002643 File Offset: 0x00000843
		public static void SetCustomLowpassLevelCurveHelper(AudioLowPassFilter source, AnimationCurve curve)
		{
			AudioLowPassFilter.SetCustomLowpassLevelCurveHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00005ED8 File Offset: 0x000040D8
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000265B File Offset: 0x0000085B
		public AnimationCurve customCutoffCurve
		{
			get
			{
				return this.GetCustomLowpassLevelCurveCopy();
			}
			set
			{
				AudioLowPassFilter.SetCustomLowpassLevelCurveHelper(this, value);
			}
		}

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_set_cutoffFrequency_Public_set_Void_Single_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_set_lowpassResonanceQ_Public_set_Void_Single_0;

		// Token: 0x040000D8 RID: 216
		private static readonly AudioLowPassFilter.GetCustomLowpassLevelCurveCopyDelegate GetCustomLowpassLevelCurveCopyDelegateField;

		// Token: 0x040000D9 RID: 217
		private static readonly AudioLowPassFilter.SetCustomLowpassLevelCurveHelperDelegate SetCustomLowpassLevelCurveHelperDelegateField;

		// Token: 0x040000DA RID: 218
		private static readonly AudioLowPassFilter.get_cutoffFrequencyDelegate get_cutoffFrequencyDelegateField;

		// Token: 0x040000DB RID: 219
		private static readonly AudioLowPassFilter.get_lowpassResonanceQDelegate get_lowpassResonanceQDelegateField;

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x0600029C RID: 668
		private delegate IntPtr GetCustomLowpassLevelCurveCopyDelegate(IntPtr @this);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x0600029E RID: 670
		private delegate void SetCustomLowpassLevelCurveHelperDelegate(IntPtr source, IntPtr curve);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060002A0 RID: 672
		private delegate float get_cutoffFrequencyDelegate(IntPtr @this);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060002A2 RID: 674
		private delegate float get_lowpassResonanceQDelegate(IntPtr @this);
	}
}
