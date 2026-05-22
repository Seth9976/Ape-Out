using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000079 RID: 121
	public class BigDoor : Throwable
	{
		// Token: 0x06000F6D RID: 3949 RVA: 0x000616BC File Offset: 0x0005F8BC
		// Note: this type is marked as 'beforefieldinit'.
		static BigDoor()
		{
			Il2CppClassPointerStore<BigDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BigDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigDoor>.NativeClassPtr);
			BigDoor.NativeFieldInfoPtr_beingPulledTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "beingPulledTimer");
			BigDoor.NativeFieldInfoPtr_isNoiseDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "isNoiseDoor");
			BigDoor.NativeFieldInfoPtr_noiseSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "noiseSource");
			BigDoor.NativeFieldInfoPtr_sectrSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "sectrSource");
			BigDoor.NativeFieldInfoPtr_bent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "bent");
			BigDoor.NativeFieldInfoPtr_bentTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "bentTimer");
			BigDoor.NativeFieldInfoPtr_playing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "playing");
			BigDoor.NativeFieldInfoPtr_flyOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "flyOpen");
			BigDoor.NativeFieldInfoPtr_brokeOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "brokeOff");
			BigDoor.NativeFieldInfoPtr_shadower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "shadower");
			BigDoor.NativeFieldInfoPtr_sparks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "sparks");
			BigDoor.NativeFieldInfoPtr_lastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "lastPos");
			BigDoor.NativeFieldInfoPtr_lastRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "lastRot");
			BigDoor.NativeFieldInfoPtr_pullinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "pullinTime");
			BigDoor.NativeFieldInfoPtr_hinges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "hinges");
			BigDoor.NativeFieldInfoPtr_obstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "obstacle");
			BigDoor.NativeFieldInfoPtr_realDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "realDoor");
			BigDoor.NativeFieldInfoPtr_wasPushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "wasPushed");
			BigDoor.NativeFieldInfoPtr_superShield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "superShield");
			BigDoor.NativeFieldInfoPtr_preShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "preShot");
			BigDoor.NativeFieldInfoPtr_hitSndInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "hitSndInt");
			BigDoor.NativeFieldInfoPtr_dust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "dust");
			BigDoor.NativeFieldInfoPtr_slamTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "slamTrigger");
			BigDoor.NativeFieldInfoPtr_alreadySwingin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "alreadySwingin");
			BigDoor.NativeFieldInfoPtr_bendHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "bendHealth");
			BigDoor.NativeFieldInfoPtr_closer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "closer");
			BigDoor.NativeFieldInfoPtr_tgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "tgs");
			BigDoor.NativeFieldInfoPtr_audTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "audTime");
			BigDoor.NativeFieldInfoPtr_doorDragEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "doorDragEndTime");
			BigDoor.NativeFieldInfoPtr_starting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "starting");
			BigDoor.NativeFieldInfoPtr_moving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "moving");
			BigDoor.NativeFieldInfoPtr_destroying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "destroying");
			BigDoor.NativeFieldInfoPtr_creak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "creak");
			BigDoor.NativeFieldInfoPtr_dragLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "dragLoop");
			BigDoor.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664619);
			BigDoor.NativeMethodInfoPtr_BreakOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664620);
			BigDoor.NativeMethodInfoPtr_NotBeingDragged_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664621);
			BigDoor.NativeMethodInfoPtr_FallDown_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664622);
			BigDoor.NativeMethodInfoPtr_SetLayer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664623);
			BigDoor.NativeMethodInfoPtr_PushDeal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664624);
			BigDoor.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664625);
			BigDoor.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664626);
			BigDoor.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664627);
			BigDoor.NativeMethodInfoPtr_Pulled_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664628);
			BigDoor.NativeMethodInfoPtr_AudPlaying_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664629);
			BigDoor.NativeMethodInfoPtr_PlayHit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664630);
			BigDoor.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664631);
			BigDoor.NativeMethodInfoPtr_SwingShut_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664632);
			BigDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, 100664633);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00061AC0 File Offset: 0x0005FCC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46839, RefRangeEnd = 46840, XrefRangeStart = 46806, XrefRangeEnd = 46839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigDoor.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00061AFC File Offset: 0x0005FCFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46908, RefRangeEnd = 46910, XrefRangeStart = 46840, XrefRangeEnd = 46908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BreakOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor.NativeMethodInfoPtr_BreakOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00061B30 File Offset: 0x0005FD30
		[CallerCount(0)]
		public unsafe bool NotBeingDragged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor.NativeMethodInfoPtr_NotBeingDragged_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00061B6C File Offset: 0x0005FD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46910, XrefRangeEnd = 47000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FallDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigDoor.NativeMethodInfoPtr_FallDown_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00061BA8 File Offset: 0x0005FDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47000, XrefRangeEnd = 47007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigDoor.NativeMethodInfoPtr_SetLayer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00061BE4 File Offset: 0x0005FDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47007, XrefRangeEnd = 47015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PushDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigDoor.NativeMethodInfoPtr_PushDeal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00061C20 File Offset: 0x0005FE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47015, XrefRangeEnd = 47022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00061C54 File Offset: 0x0005FE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47022, XrefRangeEnd = 47036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigDoor.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00061C90 File Offset: 0x0005FE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47036, XrefRangeEnd = 47055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShot(Il2CppStructArray<Vector2> shotInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shotInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigDoor.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00061CE0 File Offset: 0x0005FEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47055, XrefRangeEnd = 47131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Pulled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigDoor.NativeMethodInfoPtr_Pulled_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00061D1C File Offset: 0x0005FF1C
		[CallerCount(0)]
		public unsafe bool AudPlaying()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor.NativeMethodInfoPtr_AudPlaying_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00061D58 File Offset: 0x0005FF58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 47146, RefRangeEnd = 47150, XrefRangeStart = 47131, XrefRangeEnd = 47146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor.NativeMethodInfoPtr_PlayHit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00061D8C File Offset: 0x0005FF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47150, XrefRangeEnd = 47156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00061DD0 File Offset: 0x0005FFD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47159, RefRangeEnd = 47160, XrefRangeStart = 47156, XrefRangeEnd = 47159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SwingShut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor.NativeMethodInfoPtr_SwingShut_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00061E10 File Offset: 0x00060010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47160, XrefRangeEnd = 47161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigDoor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0000B770 File Offset: 0x00009970
		public BigDoor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x00061E4C File Offset: 0x0006004C
		// (set) Token: 0x06000F7F RID: 3967 RVA: 0x0000B779 File Offset: 0x00009979
		public unsafe float beingPulledTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_beingPulledTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_beingPulledTimer)) = value;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x00061E74 File Offset: 0x00060074
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x0000B794 File Offset: 0x00009994
		public unsafe bool isNoiseDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_isNoiseDoor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_isNoiseDoor)) = value;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00061E9C File Offset: 0x0006009C
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x0000B7AF File Offset: 0x000099AF
		public unsafe SECTR_PointSource noiseSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_noiseSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_PointSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_noiseSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x00061ECC File Offset: 0x000600CC
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x0000B7CE File Offset: 0x000099CE
		public unsafe SECTR_PointSource sectrSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_sectrSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_PointSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_sectrSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x00061EFC File Offset: 0x000600FC
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x0000B7ED File Offset: 0x000099ED
		public unsafe int bent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_bent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_bent)) = value;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00061F24 File Offset: 0x00060124
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x0000B808 File Offset: 0x00009A08
		public unsafe int bentTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_bentTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_bentTimer)) = value;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00061F4C File Offset: 0x0006014C
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x0000B823 File Offset: 0x00009A23
		public unsafe bool playing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_playing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_playing)) = value;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00061F74 File Offset: 0x00060174
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x0000B83E File Offset: 0x00009A3E
		public unsafe bool flyOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_flyOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_flyOpen)) = value;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00061F9C File Offset: 0x0006019C
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x0000B859 File Offset: 0x00009A59
		public unsafe bool brokeOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_brokeOff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_brokeOff)) = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00061FC4 File Offset: 0x000601C4
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x0000B874 File Offset: 0x00009A74
		public unsafe Shadower shadower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_shadower);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shadower>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_shadower), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00061FF4 File Offset: 0x000601F4
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x0000B893 File Offset: 0x00009A93
		public unsafe ParticleSystem sparks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_sparks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_sparks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00062024 File Offset: 0x00060224
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x0000B8B2 File Offset: 0x00009AB2
		public unsafe Vector2 lastPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_lastPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_lastPos)) = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0006204C File Offset: 0x0006024C
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x0000B8CD File Offset: 0x00009ACD
		public unsafe float lastRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_lastRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_lastRot)) = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x00062074 File Offset: 0x00060274
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x0000B8E8 File Offset: 0x00009AE8
		public unsafe int pullinTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_pullinTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_pullinTime)) = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0006209C File Offset: 0x0006029C
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x0000B903 File Offset: 0x00009B03
		public unsafe Il2CppReferenceArray<Transform> hinges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_hinges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_hinges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x000620CC File Offset: 0x000602CC
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x0000B922 File Offset: 0x00009B22
		public unsafe Obstacle obstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_obstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Obstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_obstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x000620FC File Offset: 0x000602FC
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x0000B941 File Offset: 0x00009B41
		public unsafe GameObject realDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_realDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_realDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x0006212C File Offset: 0x0006032C
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x0000B960 File Offset: 0x00009B60
		public unsafe bool wasPushed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_wasPushed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_wasPushed)) = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00062154 File Offset: 0x00060354
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x0000B97B File Offset: 0x00009B7B
		public unsafe SuperShield superShield
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_superShield);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SuperShield>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_superShield), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00062184 File Offset: 0x00060384
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x0000B99A File Offset: 0x00009B9A
		public unsafe bool preShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_preShot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_preShot)) = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x000621AC File Offset: 0x000603AC
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x0000B9B5 File Offset: 0x00009BB5
		public unsafe int hitSndInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_hitSndInt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_hitSndInt)) = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x000621D4 File Offset: 0x000603D4
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		public unsafe ParticleSystem dust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_dust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_dust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00062204 File Offset: 0x00060404
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0000B9EF File Offset: 0x00009BEF
		public unsafe GameObject slamTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_slamTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_slamTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00062234 File Offset: 0x00060434
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x0000BA0E File Offset: 0x00009C0E
		public unsafe bool alreadySwingin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_alreadySwingin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_alreadySwingin)) = value;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0006225C File Offset: 0x0006045C
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x0000BA29 File Offset: 0x00009C29
		public unsafe int bendHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_bendHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_bendHealth)) = value;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x00062284 File Offset: 0x00060484
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x0000BA44 File Offset: 0x00009C44
		public unsafe GuardState closer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_closer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_closer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x000622B4 File Offset: 0x000604B4
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x0000BA63 File Offset: 0x00009C63
		public unsafe Tags tgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_tgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_tgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x000622E4 File Offset: 0x000604E4
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x0000BA82 File Offset: 0x00009C82
		public unsafe float audTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_audTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_audTime)) = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0006230C File Offset: 0x0006050C
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x0000BA9D File Offset: 0x00009C9D
		public unsafe float doorDragEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_doorDragEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_doorDragEndTime)) = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00062334 File Offset: 0x00060534
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x0000BAB8 File Offset: 0x00009CB8
		public unsafe bool starting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_starting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_starting)) = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x0006235C File Offset: 0x0006055C
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x0000BAD3 File Offset: 0x00009CD3
		public unsafe bool moving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_moving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_moving)) = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x00062384 File Offset: 0x00060584
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x0000BAEE File Offset: 0x00009CEE
		public unsafe bool destroying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_destroying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_destroying)) = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x000623AC File Offset: 0x000605AC
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x0000BB09 File Offset: 0x00009D09
		public SECTR_AudioCueInstance creak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_creak);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_creak), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x000623DC File Offset: 0x000605DC
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x0000BB37 File Offset: 0x00009D37
		public unsafe SECTRLoopThrough dragLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_dragLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTRLoopThrough>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor.NativeFieldInfoPtr_dragLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_beingPulledTimer;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_isNoiseDoor;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr_noiseSource;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeFieldInfoPtr_sectrSource;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeFieldInfoPtr_bent;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeFieldInfoPtr_bentTimer;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeFieldInfoPtr_playing;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeFieldInfoPtr_flyOpen;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeFieldInfoPtr_brokeOff;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_shadower;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeFieldInfoPtr_sparks;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_lastPos;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr_lastRot;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr_pullinTime;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeFieldInfoPtr_hinges;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeFieldInfoPtr_obstacle;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeFieldInfoPtr_realDoor;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr_wasPushed;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_superShield;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_preShot;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeFieldInfoPtr_hitSndInt;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeFieldInfoPtr_dust;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeFieldInfoPtr_slamTrigger;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeFieldInfoPtr_alreadySwingin;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeFieldInfoPtr_bendHealth;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeFieldInfoPtr_closer;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeFieldInfoPtr_tgs;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeFieldInfoPtr_audTime;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeFieldInfoPtr_doorDragEndTime;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeFieldInfoPtr_starting;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeFieldInfoPtr_moving;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeFieldInfoPtr_destroying;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeFieldInfoPtr_creak;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeFieldInfoPtr_dragLoop;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_BreakOff_Public_Void_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_NotBeingDragged_Private_Boolean_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_FallDown_Public_Virtual_New_Void_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_SetLayer_Public_Virtual_Void_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_PushDeal_Public_Virtual_Void_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_Pulled_Public_Virtual_New_Void_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_AudPlaying_Private_Boolean_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_PlayHit_Public_Void_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_SwingShut_Private_IEnumerator_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D5 RID: 725
		[ObfuscatedName("BigDoor+<SwingShut>d__47")]
		public sealed class _SwingShut_d__47 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D02 RID: 19714 RVA: 0x0011B144 File Offset: 0x00119344
			// Note: this type is marked as 'beforefieldinit'.
			static _SwingShut_d__47()
			{
				Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BigDoor>.NativeClassPtr, "<SwingShut>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr);
				BigDoor._SwingShut_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr, "<>1__state");
				BigDoor._SwingShut_d__47.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr, "<>2__current");
				BigDoor._SwingShut_d__47.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr, "<>4__this");
				BigDoor._SwingShut_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr, 100664634);
				BigDoor._SwingShut_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr, 100664635);
				BigDoor._SwingShut_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr, 100664636);
				BigDoor._SwingShut_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr, 100664637);
				BigDoor._SwingShut_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr, 100664638);
				BigDoor._SwingShut_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr, 100664639);
			}

			// Token: 0x06004D03 RID: 19715 RVA: 0x0011B224 File Offset: 0x00119424
			[CallerCount(0)]
			public unsafe _SwingShut_d__47(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigDoor._SwingShut_d__47>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor._SwingShut_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D04 RID: 19716 RVA: 0x0011B26C File Offset: 0x0011946C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor._SwingShut_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D05 RID: 19717 RVA: 0x0011B2A0 File Offset: 0x001194A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46769, XrefRangeEnd = 46801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor._SwingShut_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C10 RID: 7184
			// (get) Token: 0x06004D06 RID: 19718 RVA: 0x0011B2DC File Offset: 0x001194DC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor._SwingShut_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D07 RID: 19719 RVA: 0x0011B31C File Offset: 0x0011951C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46801, XrefRangeEnd = 46806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor._SwingShut_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C11 RID: 7185
			// (get) Token: 0x06004D08 RID: 19720 RVA: 0x0011B350 File Offset: 0x00119550
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigDoor._SwingShut_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D09 RID: 19721 RVA: 0x0002D514 File Offset: 0x0002B714
			public _SwingShut_d__47(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C0D RID: 7181
			// (get) Token: 0x06004D0A RID: 19722 RVA: 0x0011B390 File Offset: 0x00119590
			// (set) Token: 0x06004D0B RID: 19723 RVA: 0x0002D51D File Offset: 0x0002B71D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor._SwingShut_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor._SwingShut_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C0E RID: 7182
			// (get) Token: 0x06004D0C RID: 19724 RVA: 0x0011B3B8 File Offset: 0x001195B8
			// (set) Token: 0x06004D0D RID: 19725 RVA: 0x0002D538 File Offset: 0x0002B738
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor._SwingShut_d__47.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor._SwingShut_d__47.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C0F RID: 7183
			// (get) Token: 0x06004D0E RID: 19726 RVA: 0x0011B3E8 File Offset: 0x001195E8
			// (set) Token: 0x06004D0F RID: 19727 RVA: 0x0002D557 File Offset: 0x0002B757
			public unsafe BigDoor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor._SwingShut_d__47.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigDoor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigDoor._SwingShut_d__47.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400326D RID: 12909
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400326E RID: 12910
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400326F RID: 12911
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003270 RID: 12912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003271 RID: 12913
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003272 RID: 12914
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003273 RID: 12915
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003274 RID: 12916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003275 RID: 12917
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
