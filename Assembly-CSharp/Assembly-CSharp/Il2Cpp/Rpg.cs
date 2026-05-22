using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000178 RID: 376
	public class Rpg : GuardGun
	{
		// Token: 0x06002CF9 RID: 11513 RVA: 0x000B03D4 File Offset: 0x000AE5D4
		// Note: this type is marked as 'beforefieldinit'.
		static Rpg()
		{
			Il2CppClassPointerStore<Rpg>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Rpg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rpg>.NativeClassPtr);
			Rpg.NativeFieldInfoPtr_prepPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rpg>.NativeClassPtr, "prepPart");
			Rpg.NativeFieldInfoPtr_shooting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rpg>.NativeClassPtr, "shooting");
			Rpg.NativeFieldInfoPtr_playing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rpg>.NativeClassPtr, "playing");
			Rpg.NativeFieldInfoPtr_nextPlayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rpg>.NativeClassPtr, "nextPlayTime");
			Rpg.NativeFieldInfoPtr_aud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rpg>.NativeClassPtr, "aud");
			Rpg.NativeFieldInfoPtr_shotFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rpg>.NativeClassPtr, "shotFX");
			Rpg.NativeFieldInfoPtr_playedPrepSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rpg>.NativeClassPtr, "playedPrepSound");
			Rpg.NativeFieldInfoPtr_prepDad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rpg>.NativeClassPtr, "prepDad");
			Rpg.NativeFieldInfoPtr_prepLocPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rpg>.NativeClassPtr, "prepLocPos");
			Rpg.NativeFieldInfoPtr_prepLocRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rpg>.NativeClassPtr, "prepLocRot");
			Rpg.NativeFieldInfoPtr_startRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rpg>.NativeClassPtr, "startRan");
			Rpg.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rpg>.NativeClassPtr, 100666791);
			Rpg.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rpg>.NativeClassPtr, 100666792);
			Rpg.NativeMethodInfoPtr_ResetSheller_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rpg>.NativeClassPtr, 100666793);
			Rpg.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rpg>.NativeClassPtr, 100666794);
			Rpg.NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rpg>.NativeClassPtr, 100666795);
			Rpg.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rpg>.NativeClassPtr, 100666796);
			Rpg.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rpg>.NativeClassPtr, 100666797);
			Rpg.NativeMethodInfoPtr_ShotEffects_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rpg>.NativeClassPtr, 100666798);
			Rpg.NativeMethodInfoPtr_PlayCockSnd_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rpg>.NativeClassPtr, 100666799);
			Rpg.NativeMethodInfoPtr_DrawTrail_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rpg>.NativeClassPtr, 100666800);
			Rpg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rpg>.NativeClassPtr, 100666801);
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x000B05BC File Offset: 0x000AE7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80882, XrefRangeEnd = 80895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rpg.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x000B05F8 File Offset: 0x000AE7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80895, XrefRangeEnd = 80919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rpg.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x000B0634 File Offset: 0x000AE834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80919, XrefRangeEnd = 80942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetSheller()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rpg.NativeMethodInfoPtr_ResetSheller_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x000B0670 File Offset: 0x000AE870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80942, XrefRangeEnd = 80948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rpg.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x000B06AC File Offset: 0x000AE8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80948, XrefRangeEnd = 80999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MakeBulletGo(Vector2 shotVect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shotVect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rpg.NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x000B06F8 File Offset: 0x000AE8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80999, XrefRangeEnd = 81016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rpg.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x000B0734 File Offset: 0x000AE934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81016, XrefRangeEnd = 81033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rpg.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x000B0770 File Offset: 0x000AE970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81033, XrefRangeEnd = 81036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ShotEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rpg.NativeMethodInfoPtr_ShotEffects_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x000B07AC File Offset: 0x000AE9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81036, XrefRangeEnd = 81041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayCockSnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rpg.NativeMethodInfoPtr_PlayCockSnd_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000B07E8 File Offset: 0x000AE9E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DrawTrail(Vector2 pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rpg.NativeMethodInfoPtr_DrawTrail_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x000B0834 File Offset: 0x000AEA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rpg()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rpg>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rpg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x0001F2E9 File Offset: 0x0001D4E9
		public Rpg(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000B0870 File Offset: 0x000AEA70
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x0001F2F2 File Offset: 0x0001D4F2
		public unsafe ParticleSystem prepPart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_prepPart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_prepPart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x000B08A0 File Offset: 0x000AEAA0
		// (set) Token: 0x06002D09 RID: 11529 RVA: 0x0001F311 File Offset: 0x0001D511
		public unsafe bool shooting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_shooting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_shooting)) = value;
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x000B08C8 File Offset: 0x000AEAC8
		// (set) Token: 0x06002D0B RID: 11531 RVA: 0x0001F32C File Offset: 0x0001D52C
		public unsafe bool playing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_playing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_playing)) = value;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x000B08F0 File Offset: 0x000AEAF0
		// (set) Token: 0x06002D0D RID: 11533 RVA: 0x0001F347 File Offset: 0x0001D547
		public unsafe float nextPlayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_nextPlayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_nextPlayTime)) = value;
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x000B0918 File Offset: 0x000AEB18
		// (set) Token: 0x06002D0F RID: 11535 RVA: 0x0001F362 File Offset: 0x0001D562
		public unsafe AudioSource aud
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_aud);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_aud), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x000B0948 File Offset: 0x000AEB48
		// (set) Token: 0x06002D11 RID: 11537 RVA: 0x0001F381 File Offset: 0x0001D581
		public unsafe Il2CppReferenceArray<ParticleSystem> shotFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_shotFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_shotFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06002D12 RID: 11538 RVA: 0x000B0978 File Offset: 0x000AEB78
		// (set) Token: 0x06002D13 RID: 11539 RVA: 0x0001F3A0 File Offset: 0x0001D5A0
		public unsafe bool playedPrepSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_playedPrepSound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_playedPrepSound)) = value;
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x000B09A0 File Offset: 0x000AEBA0
		// (set) Token: 0x06002D15 RID: 11541 RVA: 0x0001F3BB File Offset: 0x0001D5BB
		public unsafe Transform prepDad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_prepDad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_prepDad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x000B09D0 File Offset: 0x000AEBD0
		// (set) Token: 0x06002D17 RID: 11543 RVA: 0x0001F3DA File Offset: 0x0001D5DA
		public unsafe Vector3 prepLocPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_prepLocPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_prepLocPos)) = value;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06002D18 RID: 11544 RVA: 0x000B09F8 File Offset: 0x000AEBF8
		// (set) Token: 0x06002D19 RID: 11545 RVA: 0x0001F3F5 File Offset: 0x0001D5F5
		public unsafe Quaternion prepLocRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_prepLocRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_prepLocRot)) = value;
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x000B0A20 File Offset: 0x000AEC20
		// (set) Token: 0x06002D1B RID: 11547 RVA: 0x0001F410 File Offset: 0x0001D610
		public unsafe bool startRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_startRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rpg.NativeFieldInfoPtr_startRan)) = value;
			}
		}

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeFieldInfoPtr_prepPart;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeFieldInfoPtr_shooting;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeFieldInfoPtr_playing;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeFieldInfoPtr_nextPlayTime;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeFieldInfoPtr_aud;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeFieldInfoPtr_shotFX;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeFieldInfoPtr_playedPrepSound;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeFieldInfoPtr_prepDad;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeFieldInfoPtr_prepLocPos;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeFieldInfoPtr_prepLocRot;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeFieldInfoPtr_startRan;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeMethodInfoPtr_ResetSheller_Public_Virtual_Void_0;

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeMethodInfoPtr_ShotEffects_Public_Virtual_Void_0;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeMethodInfoPtr_PlayCockSnd_Public_Virtual_Void_0;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeMethodInfoPtr_DrawTrail_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
