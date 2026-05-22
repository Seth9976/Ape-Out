using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2Cpp
{
	// Token: 0x02000006 RID: 6
	public class BandpassFilterController : MonoBehaviour
	{
		// Token: 0x06000036 RID: 54 RVA: 0x0003504C File Offset: 0x0003324C
		// Note: this type is marked as 'beforefieldinit'.
		static BandpassFilterController()
		{
			Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BandpassFilterController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr);
			BandpassFilterController.NativeFieldInfoPtr_MasterMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "MasterMixer");
			BandpassFilterController.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "me");
			BandpassFilterController.NativeFieldInfoPtr_MusicHPFreq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "MusicHPFreq");
			BandpassFilterController.NativeFieldInfoPtr_MusicLPFreq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "MusicLPFreq");
			BandpassFilterController.NativeFieldInfoPtr_hpF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "hpF");
			BandpassFilterController.NativeFieldInfoPtr_lpF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "lpF");
			BandpassFilterController.NativeFieldInfoPtr_TransitionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "TransitionSpeed");
			BandpassFilterController.NativeFieldInfoPtr_IntensityIncrementInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "IntensityIncrementInterval");
			BandpassFilterController.NativeFieldInfoPtr_nextIncrementTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "nextIncrementTime");
			BandpassFilterController.NativeFieldInfoPtr_TargethpF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "TargethpF");
			BandpassFilterController.NativeFieldInfoPtr_TargetlpF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "TargetlpF");
			BandpassFilterController.NativeFieldInfoPtr_filterIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "filterIntensity");
			BandpassFilterController.NativeFieldInfoPtr_reset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, "reset");
			BandpassFilterController.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, 100663315);
			BandpassFilterController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, 100663316);
			BandpassFilterController.NativeMethodInfoPtr_DecreaseFilterIntensity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, 100663317);
			BandpassFilterController.NativeMethodInfoPtr_IncreaseFilterIntensity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, 100663318);
			BandpassFilterController.NativeMethodInfoPtr_CalculateNewTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, 100663319);
			BandpassFilterController.NativeMethodInfoPtr_SetNewTargets_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, 100663320);
			BandpassFilterController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, 100663321);
			BandpassFilterController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr, 100663322);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00035220 File Offset: 0x00033420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30350, XrefRangeEnd = 30370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BandpassFilterController.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00035254 File Offset: 0x00033454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30370, XrefRangeEnd = 30372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BandpassFilterController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00035288 File Offset: 0x00033488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30372, XrefRangeEnd = 30373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecreaseFilterIntensity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BandpassFilterController.NativeMethodInfoPtr_DecreaseFilterIntensity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000352BC File Offset: 0x000334BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30373, XrefRangeEnd = 30374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseFilterIntensity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BandpassFilterController.NativeMethodInfoPtr_IncreaseFilterIntensity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000352F0 File Offset: 0x000334F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30374, RefRangeEnd = 30376, XrefRangeStart = 30374, XrefRangeEnd = 30374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateNewTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BandpassFilterController.NativeMethodInfoPtr_CalculateNewTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00035324 File Offset: 0x00033524
		[CallerCount(0)]
		public unsafe void SetNewTargets(float _hpFreq, float _lpFreq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _hpFreq;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _lpFreq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BandpassFilterController.NativeMethodInfoPtr_SetNewTargets_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00035370 File Offset: 0x00033570
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BandpassFilterController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000353A4 File Offset: 0x000335A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30376, XrefRangeEnd = 30383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BandpassFilterController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BandpassFilterController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BandpassFilterController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000225F File Offset: 0x0000045F
		public BandpassFilterController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000353E0 File Offset: 0x000335E0
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002268 File Offset: 0x00000468
		public unsafe AudioMixer MasterMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_MasterMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_MasterMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00035410 File Offset: 0x00033610
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002287 File Offset: 0x00000487
		public unsafe static BandpassFilterController me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BandpassFilterController.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BandpassFilterController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BandpassFilterController.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00035438 File Offset: 0x00033638
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002299 File Offset: 0x00000499
		public unsafe string MusicHPFreq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_MusicHPFreq);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_MusicHPFreq), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00035460 File Offset: 0x00033660
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000022B8 File Offset: 0x000004B8
		public unsafe string MusicLPFreq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_MusicLPFreq);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_MusicLPFreq), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00035488 File Offset: 0x00033688
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000022D7 File Offset: 0x000004D7
		public unsafe float hpF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_hpF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_hpF)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000354B0 File Offset: 0x000336B0
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000022F2 File Offset: 0x000004F2
		public unsafe float lpF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_lpF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_lpF)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000354D8 File Offset: 0x000336D8
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000230D File Offset: 0x0000050D
		public unsafe float TransitionSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_TransitionSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_TransitionSpeed)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00035500 File Offset: 0x00033700
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002328 File Offset: 0x00000528
		public unsafe float IntensityIncrementInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_IntensityIncrementInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_IntensityIncrementInterval)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00035528 File Offset: 0x00033728
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002343 File Offset: 0x00000543
		public unsafe float nextIncrementTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_nextIncrementTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_nextIncrementTime)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00035550 File Offset: 0x00033750
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000235E File Offset: 0x0000055E
		public unsafe float TargethpF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_TargethpF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_TargethpF)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00035578 File Offset: 0x00033778
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002379 File Offset: 0x00000579
		public unsafe float TargetlpF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_TargetlpF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_TargetlpF)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000355A0 File Offset: 0x000337A0
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002394 File Offset: 0x00000594
		public unsafe int filterIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_filterIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_filterIntensity)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000355C8 File Offset: 0x000337C8
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000023AF File Offset: 0x000005AF
		public unsafe bool reset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_reset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BandpassFilterController.NativeFieldInfoPtr_reset)) = value;
			}
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_MasterMixer;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_MusicHPFreq;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_MusicLPFreq;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_hpF;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_lpF;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_TransitionSpeed;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_IntensityIncrementInterval;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_nextIncrementTime;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_TargethpF;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_TargetlpF;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_filterIntensity;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_reset;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_DecreaseFilterIntensity_Public_Void_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseFilterIntensity_Public_Void_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_CalculateNewTargets_Private_Void_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_SetNewTargets_Public_Void_Single_Single_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
