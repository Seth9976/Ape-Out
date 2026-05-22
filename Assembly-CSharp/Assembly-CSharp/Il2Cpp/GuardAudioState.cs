using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000027 RID: 39
	public class GuardAudioState : MonoBehaviour
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x00042E48 File Offset: 0x00041048
		// Note: this type is marked as 'beforefieldinit'.
		static GuardAudioState()
		{
			Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardAudioState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr);
			GuardAudioState.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "Source");
			GuardAudioState.NativeFieldInfoPtr_NormalBreathing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "NormalBreathing");
			GuardAudioState.NativeFieldInfoPtr_StressedBreathing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "StressedBreathing");
			GuardAudioState.NativeFieldInfoPtr_ScaredBreathing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "ScaredBreathing");
			GuardAudioState.NativeFieldInfoPtr_Struggling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "Struggling");
			GuardAudioState.NativeFieldInfoPtr_timingAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "timingAsset");
			GuardAudioState.NativeFieldInfoPtr_stressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "stressed");
			GuardAudioState.NativeFieldInfoPtr_grabbed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "grabbed");
			GuardAudioState.NativeFieldInfoPtr_startingUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "startingUp");
			GuardAudioState.NativeFieldInfoPtr_defaultVol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "defaultVol");
			GuardAudioState.NativeFieldInfoPtr_struggleVol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "struggleVol");
			GuardAudioState.NativeFieldInfoPtr_dontBreathe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "dontBreathe");
			GuardAudioState.NativeFieldInfoPtr_myWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "myWait");
			GuardAudioState.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, 100663711);
			GuardAudioState.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, 100663712);
			GuardAudioState.NativeMethodInfoPtr_LoadAndStartAfterWait_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, 100663713);
			GuardAudioState.NativeMethodInfoPtr_StartAfterWait_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, 100663714);
			GuardAudioState.NativeMethodInfoPtr_PlayStressedBreathing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, 100663715);
			GuardAudioState.NativeMethodInfoPtr_PlayScaredBreathing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, 100663716);
			GuardAudioState.NativeMethodInfoPtr_PlayStruggling_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, 100663717);
			GuardAudioState.NativeMethodInfoPtr_OnSeen_Public_Void_GuardBodyType_WeaponType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, 100663718);
			GuardAudioState.NativeMethodInfoPtr_GuardGrabbed_Public_Void_GuardBodyType_WeaponType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, 100663719);
			GuardAudioState.NativeMethodInfoPtr_GuardUnGrabbed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, 100663720);
			GuardAudioState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, 100663721);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00043058 File Offset: 0x00041258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35053, XrefRangeEnd = 35085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0004308C File Offset: 0x0004128C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35085, XrefRangeEnd = 35105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000430C0 File Offset: 0x000412C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35105, XrefRangeEnd = 35108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAndStartAfterWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState.NativeMethodInfoPtr_LoadAndStartAfterWait_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00043100 File Offset: 0x00041300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35108, XrefRangeEnd = 35111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartAfterWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState.NativeMethodInfoPtr_StartAfterWait_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00043140 File Offset: 0x00041340
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 35119, RefRangeEnd = 35124, XrefRangeStart = 35111, XrefRangeEnd = 35119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayStressedBreathing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState.NativeMethodInfoPtr_PlayStressedBreathing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00043174 File Offset: 0x00041374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35124, XrefRangeEnd = 35125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayScaredBreathing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState.NativeMethodInfoPtr_PlayScaredBreathing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000431A8 File Offset: 0x000413A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35125, XrefRangeEnd = 35133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayStruggling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState.NativeMethodInfoPtr_PlayStruggling_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000431DC File Offset: 0x000413DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35133, XrefRangeEnd = 35145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSeen(GuardState.GuardBodyType guardType, GuardState.WeaponType weaponType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref guardType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState.NativeMethodInfoPtr_OnSeen_Public_Void_GuardBodyType_WeaponType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00043228 File Offset: 0x00041428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35168, RefRangeEnd = 35169, XrefRangeStart = 35145, XrefRangeEnd = 35168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardGrabbed(GuardState.GuardBodyType guardType, GuardState.WeaponType weaponType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref guardType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState.NativeMethodInfoPtr_GuardGrabbed_Public_Void_GuardBodyType_WeaponType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00043274 File Offset: 0x00041474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35169, XrefRangeEnd = 35170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardUnGrabbed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState.NativeMethodInfoPtr_GuardUnGrabbed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000432A8 File Offset: 0x000414A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35170, XrefRangeEnd = 35176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardAudioState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00004D79 File Offset: 0x00002F79
		public GuardAudioState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x000432E4 File Offset: 0x000414E4
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00004D82 File Offset: 0x00002F82
		public unsafe SECTR_PointSource Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_PointSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00043314 File Offset: 0x00041514
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00004DA1 File Offset: 0x00002FA1
		public unsafe SECTR_AudioCue NormalBreathing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_NormalBreathing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_NormalBreathing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00043344 File Offset: 0x00041544
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00004DC0 File Offset: 0x00002FC0
		public unsafe SECTR_AudioCue StressedBreathing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_StressedBreathing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_StressedBreathing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00043374 File Offset: 0x00041574
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00004DDF File Offset: 0x00002FDF
		public unsafe SECTR_AudioCue ScaredBreathing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_ScaredBreathing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_ScaredBreathing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x000433A4 File Offset: 0x000415A4
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00004DFE File Offset: 0x00002FFE
		public unsafe SECTR_AudioCue Struggling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_Struggling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_Struggling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000433D4 File Offset: 0x000415D4
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00004E1D File Offset: 0x0000301D
		public unsafe GuardAudioStateTiming timingAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_timingAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardAudioStateTiming>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_timingAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00043404 File Offset: 0x00041604
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00004E3C File Offset: 0x0000303C
		public unsafe bool stressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_stressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_stressed)) = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0004342C File Offset: 0x0004162C
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00004E57 File Offset: 0x00003057
		public unsafe bool grabbed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_grabbed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_grabbed)) = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00043454 File Offset: 0x00041654
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00004E72 File Offset: 0x00003072
		public unsafe bool startingUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_startingUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_startingUp)) = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0004347C File Offset: 0x0004167C
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00004E8D File Offset: 0x0000308D
		public unsafe float defaultVol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_defaultVol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_defaultVol)) = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x000434A4 File Offset: 0x000416A4
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00004EA8 File Offset: 0x000030A8
		public unsafe float struggleVol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_struggleVol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_struggleVol)) = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000434CC File Offset: 0x000416CC
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00004EC3 File Offset: 0x000030C3
		public unsafe bool dontBreathe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_dontBreathe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_dontBreathe)) = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000434F4 File Offset: 0x000416F4
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00004EDE File Offset: 0x000030DE
		public unsafe WaitForSeconds myWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_myWait);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState.NativeFieldInfoPtr_myWait), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_NormalBreathing;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_StressedBreathing;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_ScaredBreathing;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_Struggling;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_timingAsset;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_stressed;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_grabbed;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr_startingUp;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr_defaultVol;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_struggleVol;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_dontBreathe;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_myWait;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndStartAfterWait_Private_IEnumerator_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_StartAfterWait_Private_IEnumerator_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_PlayStressedBreathing_Private_Void_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_PlayScaredBreathing_Public_Void_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_PlayStruggling_Private_Void_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_OnSeen_Public_Void_GuardBodyType_WeaponType_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_GuardGrabbed_Public_Void_GuardBodyType_WeaponType_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_GuardUnGrabbed_Public_Void_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002AC RID: 684
		[ObfuscatedName("GuardAudioState+<LoadAndStartAfterWait>d__14")]
		public sealed class _LoadAndStartAfterWait_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x06004ABB RID: 19131 RVA: 0x00114AE0 File Offset: 0x00112CE0
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndStartAfterWait_d__14()
			{
				Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "<LoadAndStartAfterWait>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr);
				GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr, "<>1__state");
				GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr, "<>2__current");
				GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr, "<>4__this");
				GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr__req_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr, "<req>5__2");
				GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr__index_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr, "<index>5__3");
				GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr, 100663722);
				GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr, 100663723);
				GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr, 100663724);
				GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr, 100663725);
				GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr, 100663726);
				GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr, 100663727);
			}

			// Token: 0x06004ABC RID: 19132 RVA: 0x00114BE8 File Offset: 0x00112DE8
			[CallerCount(0)]
			public unsafe _LoadAndStartAfterWait_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardAudioState._LoadAndStartAfterWait_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004ABD RID: 19133 RVA: 0x00114C30 File Offset: 0x00112E30
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004ABE RID: 19134 RVA: 0x00114C64 File Offset: 0x00112E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35033, XrefRangeEnd = 35039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B2C RID: 6956
			// (get) Token: 0x06004ABF RID: 19135 RVA: 0x00114CA0 File Offset: 0x00112EA0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AC0 RID: 19136 RVA: 0x00114CE0 File Offset: 0x00112EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35039, XrefRangeEnd = 35044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B2D RID: 6957
			// (get) Token: 0x06004AC1 RID: 19137 RVA: 0x00114D14 File Offset: 0x00112F14
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._LoadAndStartAfterWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AC2 RID: 19138 RVA: 0x0002BFCB File Offset: 0x0002A1CB
			public _LoadAndStartAfterWait_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B27 RID: 6951
			// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x00114D54 File Offset: 0x00112F54
			// (set) Token: 0x06004AC4 RID: 19140 RVA: 0x0002BFD4 File Offset: 0x0002A1D4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B28 RID: 6952
			// (get) Token: 0x06004AC5 RID: 19141 RVA: 0x00114D7C File Offset: 0x00112F7C
			// (set) Token: 0x06004AC6 RID: 19142 RVA: 0x0002BFEF File Offset: 0x0002A1EF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B29 RID: 6953
			// (get) Token: 0x06004AC7 RID: 19143 RVA: 0x00114DAC File Offset: 0x00112FAC
			// (set) Token: 0x06004AC8 RID: 19144 RVA: 0x0002C00E File Offset: 0x0002A20E
			public unsafe GuardAudioState __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardAudioState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B2A RID: 6954
			// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x00114DDC File Offset: 0x00112FDC
			// (set) Token: 0x06004ACA RID: 19146 RVA: 0x0002C02D File Offset: 0x0002A22D
			public unsafe ResourceRequest _req_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr__req_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr__req_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B2B RID: 6955
			// (get) Token: 0x06004ACB RID: 19147 RVA: 0x00114E0C File Offset: 0x0011300C
			// (set) Token: 0x06004ACC RID: 19148 RVA: 0x0002C04C File Offset: 0x0002A24C
			public unsafe int _index_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr__index_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._LoadAndStartAfterWait_d__14.NativeFieldInfoPtr__index_5__3)) = value;
				}
			}

			// Token: 0x040030E5 RID: 12517
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040030E6 RID: 12518
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040030E7 RID: 12519
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040030E8 RID: 12520
			private static readonly IntPtr NativeFieldInfoPtr__req_5__2;

			// Token: 0x040030E9 RID: 12521
			private static readonly IntPtr NativeFieldInfoPtr__index_5__3;

			// Token: 0x040030EA RID: 12522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040030EB RID: 12523
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040030EC RID: 12524
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040030ED RID: 12525
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040030EE RID: 12526
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040030EF RID: 12527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002AD RID: 685
		[ObfuscatedName("GuardAudioState+<StartAfterWait>d__16")]
		public sealed class _StartAfterWait_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x06004ACD RID: 19149 RVA: 0x00114E34 File Offset: 0x00113034
			// Note: this type is marked as 'beforefieldinit'.
			static _StartAfterWait_d__16()
			{
				Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuardAudioState>.NativeClassPtr, "<StartAfterWait>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr);
				GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr, "<>1__state");
				GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr, "<>2__current");
				GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr, "<>4__this");
				GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr__index_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr, "<index>5__2");
				GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr, 100663728);
				GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr, 100663729);
				GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr, 100663730);
				GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr, 100663731);
				GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr, 100663732);
				GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr, 100663733);
			}

			// Token: 0x06004ACE RID: 19150 RVA: 0x00114F28 File Offset: 0x00113128
			[CallerCount(0)]
			public unsafe _StartAfterWait_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardAudioState._StartAfterWait_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004ACF RID: 19151 RVA: 0x00114F70 File Offset: 0x00113170
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AD0 RID: 19152 RVA: 0x00114FA4 File Offset: 0x001131A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35044, XrefRangeEnd = 35048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B32 RID: 6962
			// (get) Token: 0x06004AD1 RID: 19153 RVA: 0x00114FE0 File Offset: 0x001131E0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AD2 RID: 19154 RVA: 0x00115020 File Offset: 0x00113220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35048, XrefRangeEnd = 35053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B33 RID: 6963
			// (get) Token: 0x06004AD3 RID: 19155 RVA: 0x00115054 File Offset: 0x00113254
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAudioState._StartAfterWait_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AD4 RID: 19156 RVA: 0x0002C067 File Offset: 0x0002A267
			public _StartAfterWait_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B2E RID: 6958
			// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x00115094 File Offset: 0x00113294
			// (set) Token: 0x06004AD6 RID: 19158 RVA: 0x0002C070 File Offset: 0x0002A270
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B2F RID: 6959
			// (get) Token: 0x06004AD7 RID: 19159 RVA: 0x001150BC File Offset: 0x001132BC
			// (set) Token: 0x06004AD8 RID: 19160 RVA: 0x0002C08B File Offset: 0x0002A28B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B30 RID: 6960
			// (get) Token: 0x06004AD9 RID: 19161 RVA: 0x001150EC File Offset: 0x001132EC
			// (set) Token: 0x06004ADA RID: 19162 RVA: 0x0002C0AA File Offset: 0x0002A2AA
			public unsafe GuardAudioState __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardAudioState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B31 RID: 6961
			// (get) Token: 0x06004ADB RID: 19163 RVA: 0x0011511C File Offset: 0x0011331C
			// (set) Token: 0x06004ADC RID: 19164 RVA: 0x0002C0C9 File Offset: 0x0002A2C9
			public unsafe int _index_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr__index_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAudioState._StartAfterWait_d__16.NativeFieldInfoPtr__index_5__2)) = value;
				}
			}

			// Token: 0x040030F0 RID: 12528
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040030F1 RID: 12529
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040030F2 RID: 12530
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040030F3 RID: 12531
			private static readonly IntPtr NativeFieldInfoPtr__index_5__2;

			// Token: 0x040030F4 RID: 12532
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040030F5 RID: 12533
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040030F6 RID: 12534
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040030F7 RID: 12535
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040030F8 RID: 12536
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040030F9 RID: 12537
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
