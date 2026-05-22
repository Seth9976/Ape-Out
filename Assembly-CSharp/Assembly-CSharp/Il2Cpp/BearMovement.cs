using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000075 RID: 117
	public class BearMovement : MonoBehaviour
	{
		// Token: 0x06000EDA RID: 3802 RVA: 0x0005FDC0 File Offset: 0x0005DFC0
		// Note: this type is marked as 'beforefieldinit'.
		static BearMovement()
		{
			Il2CppClassPointerStore<BearMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BearMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BearMovement>.NativeClassPtr);
			BearMovement.NativeFieldInfoPtr_uncagedSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "uncagedSpd");
			BearMovement.NativeFieldInfoPtr_peaceSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "peaceSpd");
			BearMovement.NativeFieldInfoPtr_madSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "madSpd");
			BearMovement.NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "maxSpeed");
			BearMovement.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "dest");
			BearMovement.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "state");
			BearMovement.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "head");
			BearMovement.NativeFieldInfoPtr_shoulders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "shoulders");
			BearMovement.NativeFieldInfoPtr_turnSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "turnSpd");
			BearMovement.NativeFieldInfoPtr_headSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "headSpd");
			BearMovement.NativeFieldInfoPtr_mover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "mover");
			BearMovement.NativeFieldInfoPtr_hasPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "hasPath");
			BearMovement.NativeFieldInfoPtr_pathPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "pathPending");
			BearMovement.NativeFieldInfoPtr_curPathPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "curPathPt");
			BearMovement.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "path");
			BearMovement.NativeFieldInfoPtr_pathID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "pathID");
			BearMovement.NativeFieldInfoPtr_pathFinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "pathFinder");
			BearMovement.NativeFieldInfoPtr_headRelPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "headRelPos");
			BearMovement.NativeFieldInfoPtr_smallCage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "smallCage");
			BearMovement.NativeFieldInfoPtr_curVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "curVel");
			BearMovement.NativeFieldInfoPtr_rotVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "rotVel");
			BearMovement.NativeFieldInfoPtr_debugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, "debugging");
			BearMovement.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664574);
			BearMovement.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664575);
			BearMovement.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664576);
			BearMovement.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664577);
			BearMovement.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664578);
			BearMovement.NativeMethodInfoPtr_TurnBody_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664579);
			BearMovement.NativeMethodInfoPtr_TurnHead_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664580);
			BearMovement.NativeMethodInfoPtr_FollowPath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664581);
			BearMovement.NativeMethodInfoPtr_PathFailed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664582);
			BearMovement.NativeMethodInfoPtr_OnDestReached_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664583);
			BearMovement.NativeMethodInfoPtr_GetPath_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664584);
			BearMovement.NativeMethodInfoPtr_CancelPath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664585);
			BearMovement.NativeMethodInfoPtr_StartNavigation_Public_Void_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664586);
			BearMovement.NativeMethodInfoPtr_Wander_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664587);
			BearMovement.NativeMethodInfoPtr_OnShot_Public_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664588);
			BearMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearMovement>.NativeClassPtr, 100664589);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000600E8 File Offset: 0x0005E2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45857, XrefRangeEnd = 45903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0006011C File Offset: 0x0005E31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45903, XrefRangeEnd = 45918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00060150 File Offset: 0x0005E350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45918, XrefRangeEnd = 45927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00060184 File Offset: 0x0005E384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45927, XrefRangeEnd = 46017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x000601B8 File Offset: 0x0005E3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46017, XrefRangeEnd = 46019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000601EC File Offset: 0x0005E3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46109, RefRangeEnd = 46110, XrefRangeStart = 46019, XrefRangeEnd = 46109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnBody()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_TurnBody_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00060220 File Offset: 0x0005E420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46174, RefRangeEnd = 46175, XrefRangeStart = 46110, XrefRangeEnd = 46174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnHead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_TurnHead_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00060254 File Offset: 0x0005E454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46208, RefRangeEnd = 46209, XrefRangeStart = 46175, XrefRangeEnd = 46208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FollowPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_FollowPath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00060288 File Offset: 0x0005E488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46209, XrefRangeEnd = 46216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PathFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_PathFailed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x000602BC File Offset: 0x0005E4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46216, XrefRangeEnd = 46223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_OnDestReached_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000602F0 File Offset: 0x0005E4F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 46239, RefRangeEnd = 46243, XrefRangeStart = 46223, XrefRangeEnd = 46239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPath(Vector2 newDest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newDest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_GetPath_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00060330 File Offset: 0x0005E530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46252, RefRangeEnd = 46254, XrefRangeStart = 46243, XrefRangeEnd = 46252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_CancelPath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00060364 File Offset: 0x0005E564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46270, RefRangeEnd = 46271, XrefRangeStart = 46254, XrefRangeEnd = 46270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartNavigation(List<Vector2> ptList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ptList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_StartNavigation_Public_Void_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000603A8 File Offset: 0x0005E5A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 46288, RefRangeEnd = 46293, XrefRangeStart = 46271, XrefRangeEnd = 46288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wander()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_Wander_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000603DC File Offset: 0x0005E5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46293, XrefRangeEnd = 46303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnShot(Il2CppStructArray<Vector2> pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr_OnShot_Public_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00060420 File Offset: 0x0005E620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46303, XrefRangeEnd = 46306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BearMovement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BearMovement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0000B1C3 File Offset: 0x000093C3
		public BearMovement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0006045C File Offset: 0x0005E65C
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x0000B1CC File Offset: 0x000093CC
		public unsafe float uncagedSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_uncagedSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_uncagedSpd)) = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00060484 File Offset: 0x0005E684
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x0000B1E7 File Offset: 0x000093E7
		public unsafe float peaceSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_peaceSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_peaceSpd)) = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x000604AC File Offset: 0x0005E6AC
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x0000B202 File Offset: 0x00009402
		public unsafe float madSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_madSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_madSpd)) = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x000604D4 File Offset: 0x0005E6D4
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x0000B21D File Offset: 0x0000941D
		public unsafe float maxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_maxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_maxSpeed)) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x000604FC File Offset: 0x0005E6FC
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x0000B238 File Offset: 0x00009438
		public unsafe Vector2 dest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_dest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_dest)) = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00060524 File Offset: 0x0005E724
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x0000B253 File Offset: 0x00009453
		public unsafe BearState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BearState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00060554 File Offset: 0x0005E754
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x0000B272 File Offset: 0x00009472
		public unsafe GameObject head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00060584 File Offset: 0x0005E784
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x0000B291 File Offset: 0x00009491
		public unsafe GameObject shoulders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_shoulders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_shoulders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x000605B4 File Offset: 0x0005E7B4
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x0000B2B0 File Offset: 0x000094B0
		public unsafe float turnSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_turnSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_turnSpd)) = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x000605DC File Offset: 0x0005E7DC
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x0000B2CB File Offset: 0x000094CB
		public unsafe float headSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_headSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_headSpd)) = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00060604 File Offset: 0x0005E804
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x0000B2E6 File Offset: 0x000094E6
		public unsafe Mover mover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_mover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mover>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_mover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00060634 File Offset: 0x0005E834
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x0000B305 File Offset: 0x00009505
		public unsafe bool hasPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_hasPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_hasPath)) = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0006065C File Offset: 0x0005E85C
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x0000B320 File Offset: 0x00009520
		public unsafe bool pathPending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_pathPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_pathPending)) = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00060684 File Offset: 0x0005E884
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x0000B33B File Offset: 0x0000953B
		public unsafe int curPathPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_curPathPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_curPathPt)) = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x000606AC File Offset: 0x0005E8AC
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x0000B356 File Offset: 0x00009556
		public unsafe List<Vector2> path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000606DC File Offset: 0x0005E8DC
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x0000B375 File Offset: 0x00009575
		public unsafe int pathID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_pathID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_pathID)) = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x00060704 File Offset: 0x0005E904
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x0000B390 File Offset: 0x00009590
		public unsafe PathFinding pathFinder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_pathFinder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathFinding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_pathFinder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00060734 File Offset: 0x0005E934
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x0000B3AF File Offset: 0x000095AF
		public unsafe Vector2 headRelPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_headRelPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_headRelPos)) = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x0006075C File Offset: 0x0005E95C
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x0000B3CA File Offset: 0x000095CA
		public unsafe bool smallCage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_smallCage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_smallCage)) = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00060784 File Offset: 0x0005E984
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x0000B3E5 File Offset: 0x000095E5
		public unsafe Vector2 curVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_curVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_curVel)) = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x000607AC File Offset: 0x0005E9AC
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x0000B400 File Offset: 0x00009600
		public unsafe float rotVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_rotVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_rotVel)) = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x000607D4 File Offset: 0x0005E9D4
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x0000B41B File Offset: 0x0000961B
		public unsafe bool debugging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_debugging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearMovement.NativeFieldInfoPtr_debugging)) = value;
			}
		}

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_uncagedSpd;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_peaceSpd;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_madSpd;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr_maxSpeed;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeFieldInfoPtr_dest;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr_shoulders;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeFieldInfoPtr_turnSpd;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeFieldInfoPtr_headSpd;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeFieldInfoPtr_mover;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeFieldInfoPtr_hasPath;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeFieldInfoPtr_pathPending;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeFieldInfoPtr_curPathPt;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeFieldInfoPtr_pathID;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeFieldInfoPtr_pathFinder;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr_headRelPos;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeFieldInfoPtr_smallCage;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeFieldInfoPtr_curVel;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeFieldInfoPtr_rotVel;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeFieldInfoPtr_debugging;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_TurnBody_Public_Void_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_TurnHead_Public_Void_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_FollowPath_Public_Void_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_PathFailed_Public_Void_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_OnDestReached_Public_Void_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_Void_Vector2_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_CancelPath_Public_Void_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_StartNavigation_Public_Void_List_1_Vector2_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_Wander_Public_Void_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_OnShot_Public_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
