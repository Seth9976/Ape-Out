using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppAudioHelm
{
	// Token: 0x0200027F RID: 639
	public class AudioHelmClock : MonoBehaviour
	{
		// Token: 0x06004752 RID: 18258 RVA: 0x0010ABC8 File Offset: 0x00108DC8
		// Note: this type is marked as 'beforefieldinit'.
		static AudioHelmClock()
		{
			Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "AudioHelmClock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr);
			AudioHelmClock.NativeFieldInfoPtr_globalBpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "globalBpm");
			AudioHelmClock.NativeFieldInfoPtr_globalPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "globalPause");
			AudioHelmClock.NativeFieldInfoPtr_globalBeatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "globalBeatTime");
			AudioHelmClock.NativeFieldInfoPtr_GlobalBeatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "GlobalBeatTime");
			AudioHelmClock.NativeFieldInfoPtr_lastSampledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "lastSampledTime");
			AudioHelmClock.NativeFieldInfoPtr_singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "singleton");
			AudioHelmClock.NativeFieldInfoPtr_waitToSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "waitToSync");
			AudioHelmClock.NativeFieldInfoPtr_SECONDS_PER_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "SECONDS_PER_MIN");
			AudioHelmClock.NativeFieldInfoPtr_OnReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "OnReset");
			AudioHelmClock.NativeFieldInfoPtr_bpm_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "bpm_");
			AudioHelmClock.NativeFieldInfoPtr_pause_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "pause_");
			AudioHelmClock.NativeFieldInfoPtr_resetOnNextDownBeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "resetOnNextDownBeat");
			AudioHelmClock.NativeMethodInfoPtr_add_OnReset_Public_add_Void_ResetAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670632);
			AudioHelmClock.NativeMethodInfoPtr_remove_OnReset_Public_rem_Void_ResetAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670633);
			AudioHelmClock.NativeMethodInfoPtr_get_bpm_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670634);
			AudioHelmClock.NativeMethodInfoPtr_set_bpm_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670635);
			AudioHelmClock.NativeMethodInfoPtr_get_pause_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670636);
			AudioHelmClock.NativeMethodInfoPtr_set_pause_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670637);
			AudioHelmClock.NativeMethodInfoPtr_GetInstance_Public_Static_AudioHelmClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670638);
			AudioHelmClock.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670639);
			AudioHelmClock.NativeMethodInfoPtr_SetGlobalBpm_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670640);
			AudioHelmClock.NativeMethodInfoPtr_SetGlobalPause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670641);
			AudioHelmClock.NativeMethodInfoPtr_StartScheduled_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670642);
			AudioHelmClock.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670643);
			AudioHelmClock.NativeMethodInfoPtr_GetGlobalBpm_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670644);
			AudioHelmClock.NativeMethodInfoPtr_GetGlobalBeatTime_Public_Static_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670645);
			AudioHelmClock.NativeMethodInfoPtr_GetGlobalPause_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670646);
			AudioHelmClock.NativeMethodInfoPtr_GetLastSampledTime_Public_Static_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670647);
			AudioHelmClock.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670648);
			AudioHelmClock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, 100670649);
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x0010AE50 File Offset: 0x00109050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116625, XrefRangeEnd = 116628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnReset(AudioHelmClock.ResetAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_add_OnReset_Public_add_Void_ResetAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x0010AE94 File Offset: 0x00109094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116628, XrefRangeEnd = 116631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnReset(AudioHelmClock.ResetAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_remove_OnReset_Public_rem_Void_ResetAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06004755 RID: 18261 RVA: 0x0010AED8 File Offset: 0x001090D8
		// (set) Token: 0x06004756 RID: 18262 RVA: 0x0010AF14 File Offset: 0x00109114
		public unsafe float bpm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_get_bpm_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116631, XrefRangeEnd = 116632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_set_bpm_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06004757 RID: 18263 RVA: 0x0010AF54 File Offset: 0x00109154
		// (set) Token: 0x06004758 RID: 18264 RVA: 0x0010AF90 File Offset: 0x00109190
		public unsafe bool pause
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_get_pause_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 116639, RefRangeEnd = 116657, XrefRangeStart = 116632, XrefRangeEnd = 116639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_set_pause_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x0010AFD0 File Offset: 0x001091D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116657, XrefRangeEnd = 116661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioHelmClock GetInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_GetInstance_Public_Static_AudioHelmClock_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioHelmClock>(intPtr3) : null;
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x0010B004 File Offset: 0x00109204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116661, XrefRangeEnd = 116689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x0010B038 File Offset: 0x00109238
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 116693, RefRangeEnd = 116702, XrefRangeStart = 116689, XrefRangeEnd = 116693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalBpm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_SetGlobalBpm_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600475C RID: 18268 RVA: 0x0010B06C File Offset: 0x0010926C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116702, XrefRangeEnd = 116709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_SetGlobalPause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600475D RID: 18269 RVA: 0x0010B0A0 File Offset: 0x001092A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116709, XrefRangeEnd = 116716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartScheduled(double timeToStart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeToStart;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_StartScheduled_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600475E RID: 18270 RVA: 0x0010B0E0 File Offset: 0x001092E0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 116724, RefRangeEnd = 116732, XrefRangeStart = 116716, XrefRangeEnd = 116724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x0010B114 File Offset: 0x00109314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116732, XrefRangeEnd = 116736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetGlobalBpm()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_GetGlobalBpm_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x0010B144 File Offset: 0x00109344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116736, XrefRangeEnd = 116740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetGlobalBeatTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_GetGlobalBeatTime_Public_Static_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x0010B174 File Offset: 0x00109374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116740, XrefRangeEnd = 116744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetGlobalPause()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_GetGlobalPause_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x0010B1A4 File Offset: 0x001093A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116744, XrefRangeEnd = 116748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetLastSampledTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_GetLastSampledTime_Public_Static_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x0010B1D4 File Offset: 0x001093D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116748, XrefRangeEnd = 116756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x0010B208 File Offset: 0x00109408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116756, XrefRangeEnd = 116759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioHelmClock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x0002A12F File Offset: 0x0002832F
		public AudioHelmClock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06004766 RID: 18278 RVA: 0x0010B244 File Offset: 0x00109444
		// (set) Token: 0x06004767 RID: 18279 RVA: 0x0002A138 File Offset: 0x00028338
		public unsafe static float globalBpm
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(AudioHelmClock.NativeFieldInfoPtr_globalBpm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioHelmClock.NativeFieldInfoPtr_globalBpm, (void*)(&value));
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06004768 RID: 18280 RVA: 0x0010B260 File Offset: 0x00109460
		// (set) Token: 0x06004769 RID: 18281 RVA: 0x0002A146 File Offset: 0x00028346
		public unsafe static bool globalPause
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AudioHelmClock.NativeFieldInfoPtr_globalPause, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioHelmClock.NativeFieldInfoPtr_globalPause, (void*)(&value));
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x0010B27C File Offset: 0x0010947C
		// (set) Token: 0x0600476B RID: 18283 RVA: 0x0002A154 File Offset: 0x00028354
		public unsafe static double globalBeatTime
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(AudioHelmClock.NativeFieldInfoPtr_globalBeatTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioHelmClock.NativeFieldInfoPtr_globalBeatTime, (void*)(&value));
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x0010B298 File Offset: 0x00109498
		// (set) Token: 0x0600476D RID: 18285 RVA: 0x0002A162 File Offset: 0x00028362
		public unsafe double GlobalBeatTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioHelmClock.NativeFieldInfoPtr_GlobalBeatTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioHelmClock.NativeFieldInfoPtr_GlobalBeatTime)) = value;
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x0600476E RID: 18286 RVA: 0x0010B2C0 File Offset: 0x001094C0
		// (set) Token: 0x0600476F RID: 18287 RVA: 0x0002A17D File Offset: 0x0002837D
		public unsafe static double lastSampledTime
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(AudioHelmClock.NativeFieldInfoPtr_lastSampledTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioHelmClock.NativeFieldInfoPtr_lastSampledTime, (void*)(&value));
			}
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06004770 RID: 18288 RVA: 0x0010B2DC File Offset: 0x001094DC
		// (set) Token: 0x06004771 RID: 18289 RVA: 0x0002A18B File Offset: 0x0002838B
		public unsafe static AudioHelmClock singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioHelmClock.NativeFieldInfoPtr_singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioHelmClock>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioHelmClock.NativeFieldInfoPtr_singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06004772 RID: 18290 RVA: 0x0010B304 File Offset: 0x00109504
		// (set) Token: 0x06004773 RID: 18291 RVA: 0x0002A19D File Offset: 0x0002839D
		public unsafe static double waitToSync
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(AudioHelmClock.NativeFieldInfoPtr_waitToSync, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioHelmClock.NativeFieldInfoPtr_waitToSync, (void*)(&value));
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06004774 RID: 18292 RVA: 0x0010B320 File Offset: 0x00109520
		// (set) Token: 0x06004775 RID: 18293 RVA: 0x0002A1AB File Offset: 0x000283AB
		public unsafe static double SECONDS_PER_MIN
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(AudioHelmClock.NativeFieldInfoPtr_SECONDS_PER_MIN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioHelmClock.NativeFieldInfoPtr_SECONDS_PER_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x0010B33C File Offset: 0x0010953C
		// (set) Token: 0x06004777 RID: 18295 RVA: 0x0002A1B9 File Offset: 0x000283B9
		public unsafe AudioHelmClock.ResetAction OnReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioHelmClock.NativeFieldInfoPtr_OnReset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioHelmClock.ResetAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioHelmClock.NativeFieldInfoPtr_OnReset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x0010B36C File Offset: 0x0010956C
		// (set) Token: 0x06004779 RID: 18297 RVA: 0x0002A1D8 File Offset: 0x000283D8
		public unsafe float bpm_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioHelmClock.NativeFieldInfoPtr_bpm_);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioHelmClock.NativeFieldInfoPtr_bpm_)) = value;
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x0010B394 File Offset: 0x00109594
		// (set) Token: 0x0600477B RID: 18299 RVA: 0x0002A1F3 File Offset: 0x000283F3
		public unsafe bool pause_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioHelmClock.NativeFieldInfoPtr_pause_);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioHelmClock.NativeFieldInfoPtr_pause_)) = value;
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x0600477C RID: 18300 RVA: 0x0010B3BC File Offset: 0x001095BC
		// (set) Token: 0x0600477D RID: 18301 RVA: 0x0002A20E File Offset: 0x0002840E
		public unsafe bool resetOnNextDownBeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioHelmClock.NativeFieldInfoPtr_resetOnNextDownBeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioHelmClock.NativeFieldInfoPtr_resetOnNextDownBeat)) = value;
			}
		}

		// Token: 0x04002D9D RID: 11677
		private static readonly IntPtr NativeFieldInfoPtr_globalBpm;

		// Token: 0x04002D9E RID: 11678
		private static readonly IntPtr NativeFieldInfoPtr_globalPause;

		// Token: 0x04002D9F RID: 11679
		private static readonly IntPtr NativeFieldInfoPtr_globalBeatTime;

		// Token: 0x04002DA0 RID: 11680
		private static readonly IntPtr NativeFieldInfoPtr_GlobalBeatTime;

		// Token: 0x04002DA1 RID: 11681
		private static readonly IntPtr NativeFieldInfoPtr_lastSampledTime;

		// Token: 0x04002DA2 RID: 11682
		private static readonly IntPtr NativeFieldInfoPtr_singleton;

		// Token: 0x04002DA3 RID: 11683
		private static readonly IntPtr NativeFieldInfoPtr_waitToSync;

		// Token: 0x04002DA4 RID: 11684
		private static readonly IntPtr NativeFieldInfoPtr_SECONDS_PER_MIN;

		// Token: 0x04002DA5 RID: 11685
		private static readonly IntPtr NativeFieldInfoPtr_OnReset;

		// Token: 0x04002DA6 RID: 11686
		private static readonly IntPtr NativeFieldInfoPtr_bpm_;

		// Token: 0x04002DA7 RID: 11687
		private static readonly IntPtr NativeFieldInfoPtr_pause_;

		// Token: 0x04002DA8 RID: 11688
		private static readonly IntPtr NativeFieldInfoPtr_resetOnNextDownBeat;

		// Token: 0x04002DA9 RID: 11689
		private static readonly IntPtr NativeMethodInfoPtr_add_OnReset_Public_add_Void_ResetAction_0;

		// Token: 0x04002DAA RID: 11690
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnReset_Public_rem_Void_ResetAction_0;

		// Token: 0x04002DAB RID: 11691
		private static readonly IntPtr NativeMethodInfoPtr_get_bpm_Public_get_Single_0;

		// Token: 0x04002DAC RID: 11692
		private static readonly IntPtr NativeMethodInfoPtr_set_bpm_Public_set_Void_Single_0;

		// Token: 0x04002DAD RID: 11693
		private static readonly IntPtr NativeMethodInfoPtr_get_pause_Public_get_Boolean_0;

		// Token: 0x04002DAE RID: 11694
		private static readonly IntPtr NativeMethodInfoPtr_set_pause_Public_set_Void_Boolean_0;

		// Token: 0x04002DAF RID: 11695
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_Static_AudioHelmClock_0;

		// Token: 0x04002DB0 RID: 11696
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002DB1 RID: 11697
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalBpm_Private_Void_0;

		// Token: 0x04002DB2 RID: 11698
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalPause_Private_Void_0;

		// Token: 0x04002DB3 RID: 11699
		private static readonly IntPtr NativeMethodInfoPtr_StartScheduled_Public_Void_Double_0;

		// Token: 0x04002DB4 RID: 11700
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04002DB5 RID: 11701
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalBpm_Public_Static_Single_0;

		// Token: 0x04002DB6 RID: 11702
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalBeatTime_Public_Static_Double_0;

		// Token: 0x04002DB7 RID: 11703
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalPause_Public_Static_Boolean_0;

		// Token: 0x04002DB8 RID: 11704
		private static readonly IntPtr NativeMethodInfoPtr_GetLastSampledTime_Public_Static_Double_0;

		// Token: 0x04002DB9 RID: 11705
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002DBA RID: 11706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003E8 RID: 1000
		public sealed class ResetAction : MulticastDelegate
		{
			// Token: 0x06005B21 RID: 23329 RVA: 0x00148E18 File Offset: 0x00147018
			// Note: this type is marked as 'beforefieldinit'.
			static ResetAction()
			{
				Il2CppClassPointerStore<AudioHelmClock.ResetAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioHelmClock>.NativeClassPtr, "ResetAction");
				AudioHelmClock.ResetAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock.ResetAction>.NativeClassPtr, 100670651);
				AudioHelmClock.ResetAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock.ResetAction>.NativeClassPtr, 100670652);
				AudioHelmClock.ResetAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock.ResetAction>.NativeClassPtr, 100670653);
				AudioHelmClock.ResetAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioHelmClock.ResetAction>.NativeClassPtr, 100670654);
			}

			// Token: 0x06005B22 RID: 23330 RVA: 0x00148E8C File Offset: 0x0014708C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResetAction(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioHelmClock.ResetAction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.ResetAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B23 RID: 23331 RVA: 0x00148EE8 File Offset: 0x001470E8
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.ResetAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B24 RID: 23332 RVA: 0x00148F1C File Offset: 0x0014711C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.ResetAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005B25 RID: 23333 RVA: 0x00148F80 File Offset: 0x00147180
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioHelmClock.ResetAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B26 RID: 23334 RVA: 0x00033FE6 File Offset: 0x000321E6
			public ResetAction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005B27 RID: 23335 RVA: 0x00033FEF File Offset: 0x000321EF
			public static implicit operator AudioHelmClock.ResetAction(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioHelmClock.ResetAction>(A_0);
			}

			// Token: 0x06005B28 RID: 23336 RVA: 0x00033FF7 File Offset: 0x000321F7
			public static AudioHelmClock.ResetAction operator +(AudioHelmClock.ResetAction A_0, AudioHelmClock.ResetAction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioHelmClock.ResetAction>();
			}

			// Token: 0x06005B29 RID: 23337 RVA: 0x00034005 File Offset: 0x00032205
			public static AudioHelmClock.ResetAction operator -(AudioHelmClock.ResetAction A_0, AudioHelmClock.ResetAction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioHelmClock.ResetAction>();
				}
				return delegate2;
			}

			// Token: 0x04003C81 RID: 15489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003C82 RID: 15490
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04003C83 RID: 15491
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04003C84 RID: 15492
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
