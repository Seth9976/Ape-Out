using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003B RID: 59
	public class SECTR_AudioSource : MonoBehaviour
	{
		// Token: 0x06000965 RID: 2405 RVA: 0x0004FEC8 File Offset: 0x0004E0C8
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_AudioSource()
		{
			Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_AudioSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr);
			SECTR_AudioSource.NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, "volume");
			SECTR_AudioSource.NativeFieldInfoPtr_pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, "pitch");
			SECTR_AudioSource.NativeFieldInfoPtr_playedFromStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, "playedFromStart");
			SECTR_AudioSource.NativeFieldInfoPtr_Cue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, "Cue");
			SECTR_AudioSource.NativeFieldInfoPtr_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, "Loop");
			SECTR_AudioSource.NativeFieldInfoPtr_PlayOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, "PlayOnStart");
			SECTR_AudioSource.NativeMethodInfoPtr_get_Volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664019);
			SECTR_AudioSource.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664020);
			SECTR_AudioSource.NativeMethodInfoPtr_get_Pitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664021);
			SECTR_AudioSource.NativeMethodInfoPtr_set_Pitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664022);
			SECTR_AudioSource.NativeMethodInfoPtr_get_IsPlaying_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664023);
			SECTR_AudioSource.NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664024);
			SECTR_AudioSource.NativeMethodInfoPtr_PlayAtTime_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664025);
			SECTR_AudioSource.NativeMethodInfoPtr_Stop_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664026);
			SECTR_AudioSource.NativeMethodInfoPtr_PlayEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664027);
			SECTR_AudioSource.NativeMethodInfoPtr_StopEvent_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664028);
			SECTR_AudioSource.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664029);
			SECTR_AudioSource.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664030);
			SECTR_AudioSource.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664031);
			SECTR_AudioSource.NativeMethodInfoPtr_OnVolumePitchChanged_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664032);
			SECTR_AudioSource.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr, 100664033);
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0005009C File Offset: 0x0004E29C
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x000500D8 File Offset: 0x0004E2D8
		public unsafe float Volume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSource.NativeMethodInfoPtr_get_Volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37596, XrefRangeEnd = 37597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSource.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00050118 File Offset: 0x0004E318
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00050154 File Offset: 0x0004E354
		public unsafe float Pitch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSource.NativeMethodInfoPtr_get_Pitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37597, XrefRangeEnd = 37598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSource.NativeMethodInfoPtr_set_Pitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00050194 File Offset: 0x0004E394
		public unsafe virtual bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_AudioSource.NativeMethodInfoPtr_get_IsPlaying_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000501DC File Offset: 0x0004E3DC
		[CallerCount(0)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_AudioSource.NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00050218 File Offset: 0x0004E418
		[CallerCount(0)]
		public unsafe virtual void PlayAtTime(float timeToStart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeToStart;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_AudioSource.NativeMethodInfoPtr_PlayAtTime_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00050264 File Offset: 0x0004E464
		[CallerCount(0)]
		public unsafe virtual void Stop(bool stopImmediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopImmediately;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_AudioSource.NativeMethodInfoPtr_Stop_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000502B0 File Offset: 0x0004E4B0
		[CallerCount(0)]
		public unsafe void PlayEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSource.NativeMethodInfoPtr_PlayEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000502E4 File Offset: 0x0004E4E4
		[CallerCount(0)]
		public unsafe void StopEvent(bool stopImmediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopImmediately;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSource.NativeMethodInfoPtr_StopEvent_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00050324 File Offset: 0x0004E524
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSource.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00050358 File Offset: 0x0004E558
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSource.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0005038C File Offset: 0x0004E58C
		[CallerCount(0)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_AudioSource.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000503C8 File Offset: 0x0004E5C8
		[CallerCount(0)]
		public unsafe virtual void OnVolumePitchChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_AudioSource.NativeMethodInfoPtr_OnVolumePitchChanged_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00050404 File Offset: 0x0004E604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37598, XrefRangeEnd = 37601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioSource.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0000806D File Offset: 0x0000626D
		public SECTR_AudioSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00050440 File Offset: 0x0004E640
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x00008076 File Offset: 0x00006276
		public unsafe float volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_volume)) = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00050468 File Offset: 0x0004E668
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00008091 File Offset: 0x00006291
		public unsafe float pitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_pitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_pitch)) = value;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00050490 File Offset: 0x0004E690
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x000080AC File Offset: 0x000062AC
		public unsafe bool playedFromStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_playedFromStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_playedFromStart)) = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x000504B8 File Offset: 0x0004E6B8
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x000080C7 File Offset: 0x000062C7
		public unsafe SECTR_AudioCue Cue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_Cue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_Cue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x000504E8 File Offset: 0x0004E6E8
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x000080E6 File Offset: 0x000062E6
		public unsafe bool Loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_Loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_Loop)) = value;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00050510 File Offset: 0x0004E710
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00008101 File Offset: 0x00006301
		public unsafe bool PlayOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_PlayOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioSource.NativeFieldInfoPtr_PlayOnStart)) = value;
			}
		}

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeFieldInfoPtr_volume;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr_pitch;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr_playedFromStart;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeFieldInfoPtr_Cue;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeFieldInfoPtr_Loop;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr_PlayOnStart;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_get_Single_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_get_Pitch_Public_get_Single_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_set_Pitch_Public_set_Void_Single_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_PlayAtTime_Public_Abstract_Virtual_New_Void_Single_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_PlayEvent_Public_Void_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_StopEvent_Public_Void_Boolean_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_OnVolumePitchChanged_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
