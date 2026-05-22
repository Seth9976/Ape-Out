using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200015C RID: 348
	public class PathFollower : MessageReceiver
	{
		// Token: 0x06002962 RID: 10594 RVA: 0x000A6CC8 File Offset: 0x000A4EC8
		// Note: this type is marked as 'beforefieldinit'.
		static PathFollower()
		{
			Il2CppClassPointerStore<PathFollower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PathFollower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathFollower>.NativeClassPtr);
			PathFollower.NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "maxSpeed");
			PathFollower.NativeFieldInfoPtr_hasPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "hasPath");
			PathFollower.NativeFieldInfoPtr_pathPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "pathPending");
			PathFollower.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "dest");
			PathFollower.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "path");
			PathFollower.NativeFieldInfoPtr_pathFinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "pathFinder");
			PathFollower.NativeFieldInfoPtr_going = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "going");
			PathFollower.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "on");
			PathFollower.NativeFieldInfoPtr_pathID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "pathID");
			PathFollower.NativeFieldInfoPtr_imATrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "imATrain");
			PathFollower.NativeFieldInfoPtr_curPathPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "curPathPoint");
			PathFollower.NativeFieldInfoPtr_myPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "myPos");
			PathFollower.NativeFieldInfoPtr_mover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "mover");
			PathFollower.NativeFieldInfoPtr_curVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, "curVel");
			PathFollower.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666574);
			PathFollower.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666575);
			PathFollower.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666576);
			PathFollower.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666577);
			PathFollower.NativeMethodInfoPtr_FollowPath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666578);
			PathFollower.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666579);
			PathFollower.NativeMethodInfoPtr_Go_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666580);
			PathFollower.NativeMethodInfoPtr_PathFailed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666581);
			PathFollower.NativeMethodInfoPtr_StartNavigation_Public_Virtual_Void_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666582);
			PathFollower.NativeMethodInfoPtr_OnDestReached_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666583);
			PathFollower.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666584);
			PathFollower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFollower>.NativeClassPtr, 100666585);
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000A6F00 File Offset: 0x000A5100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76970, XrefRangeEnd = 76980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFollower.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x000A6F34 File Offset: 0x000A5134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76980, XrefRangeEnd = 76995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFollower.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x000A6F68 File Offset: 0x000A5168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76995, XrefRangeEnd = 77005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFollower.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000A6F9C File Offset: 0x000A519C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77005, XrefRangeEnd = 77019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFollower.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x000A6FD0 File Offset: 0x000A51D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77048, RefRangeEnd = 77049, XrefRangeStart = 77019, XrefRangeEnd = 77048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FollowPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFollower.NativeMethodInfoPtr_FollowPath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x000A7004 File Offset: 0x000A5204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77049, XrefRangeEnd = 77058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFollower.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x000A7038 File Offset: 0x000A5238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77058, XrefRangeEnd = 77064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Go(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFollower.NativeMethodInfoPtr_Go_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x000A7078 File Offset: 0x000A5278
		[CallerCount(0)]
		public unsafe override void PathFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathFollower.NativeMethodInfoPtr_PathFailed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x000A70B4 File Offset: 0x000A52B4
		[CallerCount(0)]
		public unsafe override void StartNavigation(List<Vector2> pointList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathFollower.NativeMethodInfoPtr_StartNavigation_Public_Virtual_Void_List_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x000A7104 File Offset: 0x000A5304
		[CallerCount(0)]
		public unsafe void OnDestReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFollower.NativeMethodInfoPtr_OnDestReached_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x000A7138 File Offset: 0x000A5338
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77067, RefRangeEnd = 77070, XrefRangeStart = 77064, XrefRangeEnd = 77067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFollower.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x000A716C File Offset: 0x000A536C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77070, XrefRangeEnd = 77076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathFollower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathFollower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFollower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x0001CCD2 File Offset: 0x0001AED2
		public PathFollower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x000A71A8 File Offset: 0x000A53A8
		// (set) Token: 0x06002971 RID: 10609 RVA: 0x0001CCDB File Offset: 0x0001AEDB
		public unsafe float maxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_maxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_maxSpeed)) = value;
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x000A71D0 File Offset: 0x000A53D0
		// (set) Token: 0x06002973 RID: 10611 RVA: 0x0001CCF6 File Offset: 0x0001AEF6
		public unsafe bool hasPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_hasPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_hasPath)) = value;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06002974 RID: 10612 RVA: 0x000A71F8 File Offset: 0x000A53F8
		// (set) Token: 0x06002975 RID: 10613 RVA: 0x0001CD11 File Offset: 0x0001AF11
		public unsafe bool pathPending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_pathPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_pathPending)) = value;
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06002976 RID: 10614 RVA: 0x000A7220 File Offset: 0x000A5420
		// (set) Token: 0x06002977 RID: 10615 RVA: 0x0001CD2C File Offset: 0x0001AF2C
		public unsafe Vector2 dest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_dest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_dest)) = value;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06002978 RID: 10616 RVA: 0x000A7248 File Offset: 0x000A5448
		// (set) Token: 0x06002979 RID: 10617 RVA: 0x0001CD47 File Offset: 0x0001AF47
		public unsafe List<Vector2> path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x0600297A RID: 10618 RVA: 0x000A7278 File Offset: 0x000A5478
		// (set) Token: 0x0600297B RID: 10619 RVA: 0x0001CD66 File Offset: 0x0001AF66
		public unsafe PathFinding pathFinder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_pathFinder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathFinding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_pathFinder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x000A72A8 File Offset: 0x000A54A8
		// (set) Token: 0x0600297D RID: 10621 RVA: 0x0001CD85 File Offset: 0x0001AF85
		public unsafe bool going
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_going);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_going)) = value;
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x000A72D0 File Offset: 0x000A54D0
		// (set) Token: 0x0600297F RID: 10623 RVA: 0x0001CDA0 File Offset: 0x0001AFA0
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x000A72F8 File Offset: 0x000A54F8
		// (set) Token: 0x06002981 RID: 10625 RVA: 0x0001CDBB File Offset: 0x0001AFBB
		public unsafe int pathID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_pathID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_pathID)) = value;
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06002982 RID: 10626 RVA: 0x000A7320 File Offset: 0x000A5520
		// (set) Token: 0x06002983 RID: 10627 RVA: 0x0001CDD6 File Offset: 0x0001AFD6
		public unsafe bool imATrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_imATrain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_imATrain)) = value;
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002984 RID: 10628 RVA: 0x000A7348 File Offset: 0x000A5548
		// (set) Token: 0x06002985 RID: 10629 RVA: 0x0001CDF1 File Offset: 0x0001AFF1
		public unsafe int curPathPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_curPathPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_curPathPoint)) = value;
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x000A7370 File Offset: 0x000A5570
		// (set) Token: 0x06002987 RID: 10631 RVA: 0x0001CE0C File Offset: 0x0001B00C
		public unsafe Vector2 myPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_myPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_myPos)) = value;
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x000A7398 File Offset: 0x000A5598
		// (set) Token: 0x06002989 RID: 10633 RVA: 0x0001CE27 File Offset: 0x0001B027
		public unsafe Mover mover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_mover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mover>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_mover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x000A73C8 File Offset: 0x000A55C8
		// (set) Token: 0x0600298B RID: 10635 RVA: 0x0001CE46 File Offset: 0x0001B046
		public unsafe Vector2 curVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_curVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFollower.NativeFieldInfoPtr_curVel)) = value;
			}
		}

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeFieldInfoPtr_maxSpeed;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeFieldInfoPtr_hasPath;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeFieldInfoPtr_pathPending;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeFieldInfoPtr_dest;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeFieldInfoPtr_pathFinder;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeFieldInfoPtr_going;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeFieldInfoPtr_pathID;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeFieldInfoPtr_imATrain;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeFieldInfoPtr_curPathPoint;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeFieldInfoPtr_myPos;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeFieldInfoPtr_mover;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeFieldInfoPtr_curVel;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_FollowPath_Public_Void_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr_Go_Public_Void_Vector2_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr_PathFailed_Public_Virtual_Void_0;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeMethodInfoPtr_StartNavigation_Public_Virtual_Void_List_1_Vector2_0;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeMethodInfoPtr_OnDestReached_Public_Void_0;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
