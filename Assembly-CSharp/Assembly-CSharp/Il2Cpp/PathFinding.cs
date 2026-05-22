using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000153 RID: 339
	public class PathFinding : MonoBehaviour
	{
		// Token: 0x060028B8 RID: 10424 RVA: 0x000A4B98 File Offset: 0x000A2D98
		// Note: this type is marked as 'beforefieldinit'.
		static PathFinding()
		{
			Il2CppClassPointerStore<PathFinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PathFinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathFinding>.NativeClassPtr);
			PathFinding.NativeFieldInfoPtr_nativeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "nativeMap");
			PathFinding.NativeFieldInfoPtr_altMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "altMap");
			PathFinding.NativeFieldInfoPtr_nativeMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "nativeMaps");
			PathFinding.NativeFieldInfoPtr_mapDimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "mapDimensions");
			PathFinding.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "w");
			PathFinding.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "h");
			PathFinding.NativeFieldInfoPtr_gridRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "gridRes");
			PathFinding.NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "room");
			PathFinding.NativeFieldInfoPtr_agentRad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "agentRad");
			PathFinding.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "layerMask");
			PathFinding.NativeFieldInfoPtr_pathsPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "pathsPending");
			PathFinding.NativeFieldInfoPtr_cancelList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "cancelList");
			PathFinding.NativeFieldInfoPtr_failureList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "failureList");
			PathFinding.NativeFieldInfoPtr_debugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "debugging");
			PathFinding.NativeFieldInfoPtr_debugIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "debugIndex");
			PathFinding.NativeFieldInfoPtr_pathID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "pathID");
			PathFinding.NativeFieldInfoPtr_checkedListArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "checkedListArray");
			PathFinding.NativeFieldInfoPtr_checkingNodeListArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "checkingNodeListArray");
			PathFinding.NativeFieldInfoPtr_visitedNodeListArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "visitedNodeListArray");
			PathFinding.NativeFieldInfoPtr_pathListIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "pathListIndex");
			PathFinding.NativeFieldInfoPtr_valArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "valArr");
			PathFinding.NativeFieldInfoPtr_cornVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "cornVect");
			PathFinding.NativeFieldInfoPtr_lastFailedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "lastFailedList");
			PathFinding.NativeFieldInfoPtr_searchGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "searchGrid");
			PathFinding.NativeFieldInfoPtr_col2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "col2D");
			PathFinding.NativeFieldInfoPtr_fullVertList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "fullVertList");
			PathFinding.NativeFieldInfoPtr_neighbx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "neighbx");
			PathFinding.NativeFieldInfoPtr_neighby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "neighby");
			PathFinding.NativeFieldInfoPtr_prevJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "prevJob");
			PathFinding.NativeFieldInfoPtr_mapDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "mapDirty");
			PathFinding.NativeFieldInfoPtr_map_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "map_toggle");
			PathFinding.NativeFieldInfoPtr_ugJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "ugJobHandle");
			PathFinding.NativeFieldInfoPtr_update_job_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "update_job_active");
			PathFinding.NativeFieldInfoPtr_outstanding_path_jobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "outstanding_path_jobs");
			PathFinding.NativeFieldInfoPtr_MAX_PATHFINDINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "MAX_PATHFINDINGS");
			PathFinding.NativeFieldInfoPtr_PreallocationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "PreallocationList");
			PathFinding.NativeFieldInfoPtr_regionBndList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "regionBndList");
			PathFinding.NativeFieldInfoPtr_regionBndListCpy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "regionBndListCpy");
			PathFinding.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666515);
			PathFinding.NativeMethodInfoPtr_MyAwake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666516);
			PathFinding.NativeMethodInfoPtr_CreateGrid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666517);
			PathFinding.NativeMethodInfoPtr_CompleteAndDisposePFJobs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666518);
			PathFinding.NativeMethodInfoPtr_FindPath_Public_Int32_Vector2_Vector2_MessageReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666519);
			PathFinding.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666520);
			PathFinding.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666521);
			PathFinding.NativeMethodInfoPtr_FinishUpdatingRegions_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666522);
			PathFinding.NativeMethodInfoPtr_PathFind_Private_Void_Vector2_Vector2_MessageReceiver_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666523);
			PathFinding.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666524);
			PathFinding.NativeMethodInfoPtr_ClosestValidVert_Public_Intv2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666525);
			PathFinding.NativeMethodInfoPtr_GetRandomPathPt_Public_Vector2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666526);
			PathFinding.NativeMethodInfoPtr_DistSqr_Private_Single_Intv2_Intv2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666527);
			PathFinding.NativeMethodInfoPtr_ClosestValid_Public_Intv2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666528);
			PathFinding.NativeMethodInfoPtr_OptimizePath_Private_List_1_Vector2_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666529);
			PathFinding.NativeMethodInfoPtr_LOS_Private_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666530);
			PathFinding.NativeMethodInfoPtr_GetPath_Private_List_1_Vector2_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666531);
			PathFinding.NativeMethodInfoPtr_Cancel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666532);
			PathFinding.NativeMethodInfoPtr_UpdateRegion_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666533);
			PathFinding.NativeMethodInfoPtr_ToWorld_Public_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666534);
			PathFinding.NativeMethodInfoPtr_ToWorld_Public_Vector2_Intv2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666535);
			PathFinding.NativeMethodInfoPtr_ToWorld_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666536);
			PathFinding.NativeMethodInfoPtr_ToGrid_Public_Intv2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666537);
			PathFinding.NativeMethodInfoPtr_ToGrid_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666538);
			PathFinding.NativeMethodInfoPtr_ToGrid_Public_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666539);
			PathFinding.NativeMethodInfoPtr_ToGridCeil_Private_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666540);
			PathFinding.NativeMethodInfoPtr_ToGridFloor_Private_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666541);
			PathFinding.NativeMethodInfoPtr_InMap_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666542);
			PathFinding.NativeMethodInfoPtr_IsValid_Private_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666543);
			PathFinding.NativeMethodInfoPtr_IsValid_Private_Boolean_Intv2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666544);
			PathFinding.NativeMethodInfoPtr_IsValid_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666545);
			PathFinding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, 100666546);
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x000A5140 File Offset: 0x000A3340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76496, XrefRangeEnd = 76589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x000A5174 File Offset: 0x000A3374
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76593, RefRangeEnd = 76595, XrefRangeStart = 76589, XrefRangeEnd = 76593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_MyAwake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x000A51A8 File Offset: 0x000A33A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76601, RefRangeEnd = 76602, XrefRangeStart = 76595, XrefRangeEnd = 76601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateGrid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_CreateGrid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x000A51DC File Offset: 0x000A33DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 76608, RefRangeEnd = 76611, XrefRangeStart = 76602, XrefRangeEnd = 76608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteAndDisposePFJobs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_CompleteAndDisposePFJobs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000A5210 File Offset: 0x000A3410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76611, XrefRangeEnd = 76612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindPath(Vector2 startPos, Vector2 endPos, MessageReceiver agent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(agent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_FindPath_Public_Int32_Vector2_Vector2_MessageReceiver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000A527C File Offset: 0x000A347C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76612, XrefRangeEnd = 76622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000A52B0 File Offset: 0x000A34B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76622, XrefRangeEnd = 76701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000A52E4 File Offset: 0x000A34E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76702, RefRangeEnd = 76706, XrefRangeStart = 76701, XrefRangeEnd = 76702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FinishUpdatingRegions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_FinishUpdatingRegions_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x000A5320 File Offset: 0x000A3520
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 76734, RefRangeEnd = 76739, XrefRangeStart = 76706, XrefRangeEnd = 76734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PathFind(Vector2 startPos, Vector2 endPos, MessageReceiver agent, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(agent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_PathFind_Private_Void_Vector2_Vector2_MessageReceiver_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x000A538C File Offset: 0x000A358C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76739, XrefRangeEnd = 76758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x000A53C0 File Offset: 0x000A35C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76760, RefRangeEnd = 76761, XrefRangeStart = 76758, XrefRangeEnd = 76760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Intv2 ClosestValidVert(Vector2 poos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref poos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_ClosestValidVert_Public_Intv2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x000A540C File Offset: 0x000A360C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76766, RefRangeEnd = 76767, XrefRangeStart = 76761, XrefRangeEnd = 76766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRandomPathPt(Vector2 poos, int stepNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref poos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_GetRandomPathPt_Public_Vector2_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x000A5464 File Offset: 0x000A3664
		[CallerCount(0)]
		public unsafe float DistSqr(Intv2 a, Intv2 b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_DistSqr_Private_Single_Intv2_Intv2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000A54BC File Offset: 0x000A36BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 76768, RefRangeEnd = 76773, XrefRangeStart = 76767, XrefRangeEnd = 76768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Intv2 ClosestValid(Vector2 pos, int radius = 30)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_ClosestValid_Public_Intv2_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x000A5514 File Offset: 0x000A3714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76784, RefRangeEnd = 76786, XrefRangeStart = 76773, XrefRangeEnd = 76784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector2> OptimizePath(List<Vector2> path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_OptimizePath_Private_List_1_Vector2_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000A5564 File Offset: 0x000A3764
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76790, RefRangeEnd = 76792, XrefRangeStart = 76786, XrefRangeEnd = 76790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LOS(Vector2 a, Vector2 b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_LOS_Private_Boolean_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x000A55BC File Offset: 0x000A37BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76792, XrefRangeEnd = 76804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector2> GetPath(Node node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_GetPath_Private_List_1_Vector2_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x000A560C File Offset: 0x000A380C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76804, XrefRangeEnd = 76808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_Cancel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x000A564C File Offset: 0x000A384C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76808, XrefRangeEnd = 76819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRegion(Vector2 mn, Vector2 mx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_UpdateRegion_Public_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x000A5698 File Offset: 0x000A3898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76819, RefRangeEnd = 76820, XrefRangeStart = 76819, XrefRangeEnd = 76819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ToWorld(int a, int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_ToWorld_Public_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000A56F0 File Offset: 0x000A38F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76820, RefRangeEnd = 76822, XrefRangeStart = 76820, XrefRangeEnd = 76820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ToWorld(Intv2 bop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_ToWorld_Public_Vector2_Intv2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000A573C File Offset: 0x000A393C
		[CallerCount(0)]
		public unsafe Vector2 ToWorld(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_ToWorld_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x000A5788 File Offset: 0x000A3988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76830, RefRangeEnd = 76832, XrefRangeStart = 76822, XrefRangeEnd = 76830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Intv2 ToGrid(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_ToGrid_Public_Intv2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x000A57D4 File Offset: 0x000A39D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76832, XrefRangeEnd = 76833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ToGrid(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_ToGrid_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000A5820 File Offset: 0x000A3A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76833, XrefRangeEnd = 76834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToGrid(ref int a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_ToGrid_Public_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000A5860 File Offset: 0x000A3A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76834, XrefRangeEnd = 76836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ToGridCeil(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_ToGridCeil_Private_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000A58AC File Offset: 0x000A3AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76836, XrefRangeEnd = 76838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ToGridFloor(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_ToGridFloor_Private_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000A58F8 File Offset: 0x000A3AF8
		[CallerCount(0)]
		public unsafe bool InMap(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_InMap_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000A5950 File Offset: 0x000A3B50
		[CallerCount(0)]
		public unsafe bool IsValid(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_IsValid_Private_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000A599C File Offset: 0x000A3B9C
		[CallerCount(0)]
		public unsafe bool IsValid(Intv2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_IsValid_Private_Boolean_Intv2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000A59E8 File Offset: 0x000A3BE8
		[CallerCount(0)]
		public unsafe bool IsValid(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr_IsValid_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000A5A40 File Offset: 0x000A3C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76838, XrefRangeEnd = 76852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathFinding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathFinding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0001C695 File Offset: 0x0001A895
		public PathFinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x060028DA RID: 10458 RVA: 0x000A5A7C File Offset: 0x000A3C7C
		// (set) Token: 0x060028DB RID: 10459 RVA: 0x0001C69E File Offset: 0x0001A89E
		public NativeArray<byte> nativeMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_nativeMap);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_nativeMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x060028DC RID: 10460 RVA: 0x000A5AAC File Offset: 0x000A3CAC
		// (set) Token: 0x060028DD RID: 10461 RVA: 0x0001C6CC File Offset: 0x0001A8CC
		public NativeArray<byte> altMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_altMap);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_altMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x060028DE RID: 10462 RVA: 0x000A5ADC File Offset: 0x000A3CDC
		// (set) Token: 0x060028DF RID: 10463 RVA: 0x0001C6FA File Offset: 0x0001A8FA
		public unsafe Il2CppReferenceArray<NativeArray<byte>> nativeMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_nativeMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NativeArray<byte>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_nativeMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x060028E0 RID: 10464 RVA: 0x000A5B0C File Offset: 0x000A3D0C
		// (set) Token: 0x060028E1 RID: 10465 RVA: 0x0001C719 File Offset: 0x0001A919
		public unsafe Il2CppStructArray<Intv2> mapDimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_mapDimensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Intv2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_mapDimensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x060028E2 RID: 10466 RVA: 0x000A5B3C File Offset: 0x000A3D3C
		// (set) Token: 0x060028E3 RID: 10467 RVA: 0x0001C738 File Offset: 0x0001A938
		public unsafe int w
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_w);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_w)) = value;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x000A5B64 File Offset: 0x000A3D64
		// (set) Token: 0x060028E5 RID: 10469 RVA: 0x0001C753 File Offset: 0x0001A953
		public unsafe int h
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_h);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_h)) = value;
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x000A5B8C File Offset: 0x000A3D8C
		// (set) Token: 0x060028E7 RID: 10471 RVA: 0x0001C76E File Offset: 0x0001A96E
		public unsafe float gridRes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_gridRes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_gridRes)) = value;
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x000A5BB4 File Offset: 0x000A3DB4
		// (set) Token: 0x060028E9 RID: 10473 RVA: 0x0001C789 File Offset: 0x0001A989
		public unsafe RoomState room
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_room);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoomState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_room), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x060028EA RID: 10474 RVA: 0x000A5BE4 File Offset: 0x000A3DE4
		// (set) Token: 0x060028EB RID: 10475 RVA: 0x0001C7A8 File Offset: 0x0001A9A8
		public unsafe static float agentRad
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(PathFinding.NativeFieldInfoPtr_agentRad, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathFinding.NativeFieldInfoPtr_agentRad, (void*)(&value));
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x060028EC RID: 10476 RVA: 0x000A5C00 File Offset: 0x000A3E00
		// (set) Token: 0x060028ED RID: 10477 RVA: 0x0001C7B6 File Offset: 0x0001A9B6
		public unsafe LayerMask layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_layerMask)) = value;
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x000A5C28 File Offset: 0x000A3E28
		// (set) Token: 0x060028EF RID: 10479 RVA: 0x0001C7D1 File Offset: 0x0001A9D1
		public unsafe int pathsPending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_pathsPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_pathsPending)) = value;
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x000A5C50 File Offset: 0x000A3E50
		// (set) Token: 0x060028F1 RID: 10481 RVA: 0x0001C7EC File Offset: 0x0001A9EC
		public unsafe List<int> cancelList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_cancelList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_cancelList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x000A5C80 File Offset: 0x000A3E80
		// (set) Token: 0x060028F3 RID: 10483 RVA: 0x0001C80B File Offset: 0x0001AA0B
		public unsafe List<Vector2> failureList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_failureList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_failureList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x000A5CB0 File Offset: 0x000A3EB0
		// (set) Token: 0x060028F5 RID: 10485 RVA: 0x0001C82A File Offset: 0x0001AA2A
		public unsafe bool debugging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_debugging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_debugging)) = value;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060028F6 RID: 10486 RVA: 0x000A5CD8 File Offset: 0x000A3ED8
		// (set) Token: 0x060028F7 RID: 10487 RVA: 0x0001C845 File Offset: 0x0001AA45
		public unsafe int debugIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_debugIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_debugIndex)) = value;
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x000A5D00 File Offset: 0x000A3F00
		// (set) Token: 0x060028F9 RID: 10489 RVA: 0x0001C860 File Offset: 0x0001AA60
		public unsafe int pathID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_pathID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_pathID)) = value;
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060028FA RID: 10490 RVA: 0x000A5D28 File Offset: 0x000A3F28
		// (set) Token: 0x060028FB RID: 10491 RVA: 0x0001C87B File Offset: 0x0001AA7B
		public unsafe Il2CppReferenceArray<HashSet<int>> checkedListArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_checkedListArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HashSet<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_checkedListArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x000A5D58 File Offset: 0x000A3F58
		// (set) Token: 0x060028FD RID: 10493 RVA: 0x0001C89A File Offset: 0x0001AA9A
		public unsafe Il2CppReferenceArray<NodeList> checkingNodeListArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_checkingNodeListArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NodeList>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_checkingNodeListArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x000A5D88 File Offset: 0x000A3F88
		// (set) Token: 0x060028FF RID: 10495 RVA: 0x0001C8B9 File Offset: 0x0001AAB9
		public unsafe Il2CppReferenceArray<List<Node>> visitedNodeListArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_visitedNodeListArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<Node>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_visitedNodeListArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x000A5DB8 File Offset: 0x000A3FB8
		// (set) Token: 0x06002901 RID: 10497 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		public unsafe int pathListIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_pathListIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_pathListIndex)) = value;
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x000A5DE0 File Offset: 0x000A3FE0
		// (set) Token: 0x06002903 RID: 10499 RVA: 0x0001C8F3 File Offset: 0x0001AAF3
		public unsafe Il2CppStructArray<Vector2> valArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_valArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_valArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x000A5E10 File Offset: 0x000A4010
		// (set) Token: 0x06002905 RID: 10501 RVA: 0x0001C912 File Offset: 0x0001AB12
		public unsafe Vector2 cornVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_cornVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_cornVect)) = value;
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x000A5E38 File Offset: 0x000A4038
		// (set) Token: 0x06002907 RID: 10503 RVA: 0x0001C92D File Offset: 0x0001AB2D
		public unsafe HashSet<Vector2> lastFailedList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_lastFailedList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_lastFailedList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x000A5E68 File Offset: 0x000A4068
		// (set) Token: 0x06002909 RID: 10505 RVA: 0x0001C94C File Offset: 0x0001AB4C
		public unsafe SearchGrid searchGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_searchGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_searchGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x000A5E98 File Offset: 0x000A4098
		// (set) Token: 0x0600290B RID: 10507 RVA: 0x0001C96B File Offset: 0x0001AB6B
		public unsafe Collider2D col2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_col2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_col2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x000A5EC8 File Offset: 0x000A40C8
		// (set) Token: 0x0600290D RID: 10509 RVA: 0x0001C98A File Offset: 0x0001AB8A
		public unsafe List<int> fullVertList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_fullVertList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_fullVertList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x000A5EF8 File Offset: 0x000A40F8
		// (set) Token: 0x0600290F RID: 10511 RVA: 0x0001C9A9 File Offset: 0x0001ABA9
		public unsafe Il2CppStructArray<int> neighbx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_neighbx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_neighbx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x000A5F28 File Offset: 0x000A4128
		// (set) Token: 0x06002911 RID: 10513 RVA: 0x0001C9C8 File Offset: 0x0001ABC8
		public unsafe Il2CppStructArray<int> neighby
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_neighby);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_neighby), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x000A5F58 File Offset: 0x000A4158
		// (set) Token: 0x06002913 RID: 10515 RVA: 0x0001C9E7 File Offset: 0x0001ABE7
		public unsafe JobHandle prevJob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_prevJob);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_prevJob)) = value;
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x000A5F80 File Offset: 0x000A4180
		// (set) Token: 0x06002915 RID: 10517 RVA: 0x0001CA02 File Offset: 0x0001AC02
		public unsafe bool mapDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_mapDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_mapDirty)) = value;
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x000A5FA8 File Offset: 0x000A41A8
		// (set) Token: 0x06002917 RID: 10519 RVA: 0x0001CA1D File Offset: 0x0001AC1D
		public unsafe byte map_toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_map_toggle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_map_toggle)) = value;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06002918 RID: 10520 RVA: 0x000A5FD0 File Offset: 0x000A41D0
		// (set) Token: 0x06002919 RID: 10521 RVA: 0x0001CA38 File Offset: 0x0001AC38
		public unsafe JobHandle ugJobHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_ugJobHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_ugJobHandle)) = value;
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x000A5FF8 File Offset: 0x000A41F8
		// (set) Token: 0x0600291B RID: 10523 RVA: 0x0001CA53 File Offset: 0x0001AC53
		public unsafe byte update_job_active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_update_job_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_update_job_active)) = value;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x000A6020 File Offset: 0x000A4220
		// (set) Token: 0x0600291D RID: 10525 RVA: 0x0001CA6E File Offset: 0x0001AC6E
		public unsafe Il2CppReferenceArray<PathFinding.dict_holder> outstanding_path_jobs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_outstanding_path_jobs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PathFinding.dict_holder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_outstanding_path_jobs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x0600291E RID: 10526 RVA: 0x000A6050 File Offset: 0x000A4250
		// (set) Token: 0x0600291F RID: 10527 RVA: 0x0001CA8D File Offset: 0x0001AC8D
		public unsafe static int MAX_PATHFINDINGS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PathFinding.NativeFieldInfoPtr_MAX_PATHFINDINGS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathFinding.NativeFieldInfoPtr_MAX_PATHFINDINGS, (void*)(&value));
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002920 RID: 10528 RVA: 0x000A606C File Offset: 0x000A426C
		// (set) Token: 0x06002921 RID: 10529 RVA: 0x0001CA9B File Offset: 0x0001AC9B
		public unsafe static List<int> PreallocationList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PathFinding.NativeFieldInfoPtr_PreallocationList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathFinding.NativeFieldInfoPtr_PreallocationList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002922 RID: 10530 RVA: 0x000A6094 File Offset: 0x000A4294
		// (set) Token: 0x06002923 RID: 10531 RVA: 0x0001CAAD File Offset: 0x0001ACAD
		public NativeList<Vector4> regionBndList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_regionBndList);
				return new NativeList<Vector4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<Vector4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_regionBndList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Vector4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x000A60C4 File Offset: 0x000A42C4
		// (set) Token: 0x06002925 RID: 10533 RVA: 0x0001CADB File Offset: 0x0001ACDB
		public NativeList<Vector4> regionBndListCpy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_regionBndListCpy);
				return new NativeList<Vector4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<Vector4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.NativeFieldInfoPtr_regionBndListCpy), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Vector4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeFieldInfoPtr_nativeMap;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeFieldInfoPtr_altMap;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeFieldInfoPtr_nativeMaps;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeFieldInfoPtr_mapDimensions;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeFieldInfoPtr_h;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeFieldInfoPtr_gridRes;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeFieldInfoPtr_room;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeFieldInfoPtr_agentRad;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeFieldInfoPtr_pathsPending;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeFieldInfoPtr_cancelList;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeFieldInfoPtr_failureList;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeFieldInfoPtr_debugging;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeFieldInfoPtr_debugIndex;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeFieldInfoPtr_pathID;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeFieldInfoPtr_checkedListArray;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeFieldInfoPtr_checkingNodeListArray;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeFieldInfoPtr_visitedNodeListArray;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeFieldInfoPtr_pathListIndex;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeFieldInfoPtr_valArr;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeFieldInfoPtr_cornVect;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeFieldInfoPtr_lastFailedList;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeFieldInfoPtr_searchGrid;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeFieldInfoPtr_col2D;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeFieldInfoPtr_fullVertList;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeFieldInfoPtr_neighbx;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeFieldInfoPtr_neighby;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeFieldInfoPtr_prevJob;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeFieldInfoPtr_mapDirty;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeFieldInfoPtr_map_toggle;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeFieldInfoPtr_ugJobHandle;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeFieldInfoPtr_update_job_active;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeFieldInfoPtr_outstanding_path_jobs;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PATHFINDINGS;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeFieldInfoPtr_PreallocationList;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeFieldInfoPtr_regionBndList;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeFieldInfoPtr_regionBndListCpy;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr_MyAwake_Public_Void_0;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeMethodInfoPtr_CreateGrid_Public_Void_0;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAndDisposePFJobs_Public_Void_0;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr_FindPath_Public_Int32_Vector2_Vector2_MessageReceiver_0;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr_FinishUpdatingRegions_Private_Boolean_0;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr_PathFind_Private_Void_Vector2_Vector2_MessageReceiver_Int32_0;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr_ClosestValidVert_Public_Intv2_Vector2_0;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomPathPt_Public_Vector2_Vector2_Int32_0;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeMethodInfoPtr_DistSqr_Private_Single_Intv2_Intv2_0;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_ClosestValid_Public_Intv2_Vector2_Int32_0;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeMethodInfoPtr_OptimizePath_Private_List_1_Vector2_List_1_Vector2_0;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeMethodInfoPtr_LOS_Private_Boolean_Vector2_Vector2_0;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Private_List_1_Vector2_Node_0;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_Int32_0;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRegion_Public_Void_Vector2_Vector2_0;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeMethodInfoPtr_ToWorld_Public_Vector2_Int32_Int32_0;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeMethodInfoPtr_ToWorld_Public_Vector2_Intv2_0;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeMethodInfoPtr_ToWorld_Public_Vector2_Vector2_0;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeMethodInfoPtr_ToGrid_Public_Intv2_Vector2_0;

		// Token: 0x0400182B RID: 6187
		private static readonly IntPtr NativeMethodInfoPtr_ToGrid_Public_Int32_Single_0;

		// Token: 0x0400182C RID: 6188
		private static readonly IntPtr NativeMethodInfoPtr_ToGrid_Public_Void_byref_Int32_0;

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeMethodInfoPtr_ToGridCeil_Private_Vector2_Vector2_0;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeMethodInfoPtr_ToGridFloor_Private_Vector2_Vector2_0;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeMethodInfoPtr_InMap_Public_Boolean_Int32_Int32_0;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Private_Boolean_Vector2_0;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Private_Boolean_Intv2_0;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_Int32_Int32_0;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200033F RID: 831
		public sealed class dict_holder : ValueType
		{
			// Token: 0x06005265 RID: 21093 RVA: 0x0012B810 File Offset: 0x00129A10
			// Note: this type is marked as 'beforefieldinit'.
			static dict_holder()
			{
				Il2CppClassPointerStore<PathFinding.dict_holder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "dict_holder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathFinding.dict_holder>.NativeClassPtr);
				PathFinding.dict_holder.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.dict_holder>.NativeClassPtr, "handle");
				PathFinding.dict_holder.NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.dict_holder>.NativeClassPtr, "job");
				PathFinding.dict_holder.NativeFieldInfoPtr_agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.dict_holder>.NativeClassPtr, "agent");
				PathFinding.dict_holder.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.dict_holder>.NativeClassPtr, "active");
			}

			// Token: 0x06005266 RID: 21094 RVA: 0x0002FFE5 File Offset: 0x0002E1E5
			public dict_holder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005267 RID: 21095 RVA: 0x0002FFEE File Offset: 0x0002E1EE
			public dict_holder()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathFinding.dict_holder>.NativeClassPtr))
			{
			}

			// Token: 0x17001E0A RID: 7690
			// (get) Token: 0x06005268 RID: 21096 RVA: 0x0012B88C File Offset: 0x00129A8C
			// (set) Token: 0x06005269 RID: 21097 RVA: 0x00030000 File Offset: 0x0002E200
			public unsafe JobHandle handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.dict_holder.NativeFieldInfoPtr_handle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.dict_holder.NativeFieldInfoPtr_handle)) = value;
				}
			}

			// Token: 0x17001E0B RID: 7691
			// (get) Token: 0x0600526A RID: 21098 RVA: 0x0012B8B4 File Offset: 0x00129AB4
			// (set) Token: 0x0600526B RID: 21099 RVA: 0x0003001B File Offset: 0x0002E21B
			public PathFinding.PathFindJob job
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.dict_holder.NativeFieldInfoPtr_job);
					return new PathFinding.PathFindJob(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.dict_holder.NativeFieldInfoPtr_job), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001E0C RID: 7692
			// (get) Token: 0x0600526C RID: 21100 RVA: 0x0012B8E4 File Offset: 0x00129AE4
			// (set) Token: 0x0600526D RID: 21101 RVA: 0x00030049 File Offset: 0x0002E249
			public unsafe MessageReceiver agent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.dict_holder.NativeFieldInfoPtr_agent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageReceiver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.dict_holder.NativeFieldInfoPtr_agent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E0D RID: 7693
			// (get) Token: 0x0600526E RID: 21102 RVA: 0x0012B914 File Offset: 0x00129B14
			// (set) Token: 0x0600526F RID: 21103 RVA: 0x00030068 File Offset: 0x0002E268
			public unsafe byte active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.dict_holder.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.dict_holder.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x04003675 RID: 13941
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x04003676 RID: 13942
			private static readonly IntPtr NativeFieldInfoPtr_job;

			// Token: 0x04003677 RID: 13943
			private static readonly IntPtr NativeFieldInfoPtr_agent;

			// Token: 0x04003678 RID: 13944
			private static readonly IntPtr NativeFieldInfoPtr_active;
		}

		// Token: 0x02000340 RID: 832
		public sealed class PathFindJob : ValueType
		{
			// Token: 0x06005270 RID: 21104 RVA: 0x0012B93C File Offset: 0x00129B3C
			// Note: this type is marked as 'beforefieldinit'.
			static PathFindJob()
			{
				Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "PathFindJob");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr);
				PathFinding.PathFindJob.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, "map");
				PathFinding.PathFindJob.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, "startPos");
				PathFinding.PathFindJob.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, "endPos");
				PathFinding.PathFindJob.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, "w");
				PathFinding.PathFindJob.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, "h");
				PathFinding.PathFindJob.NativeFieldInfoPtr_gridRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, "gridRes");
				PathFinding.PathFindJob.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, "path");
				PathFinding.PathFindJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, 100666548);
				PathFinding.PathFindJob.NativeMethodInfoPtr_SetPath_Private_Void_Nod_byref_NativeHashMap_2_Int32_Nod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, 100666549);
				PathFinding.PathFindJob.NativeMethodInfoPtr_Direction_Private_Intv2_Intv2_Intv2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, 100666550);
				PathFinding.PathFindJob.NativeMethodInfoPtr_Dist_Private_Single_Intv2_Intv2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, 100666551);
				PathFinding.PathFindJob.NativeMethodInfoPtr_PopBest_Private_Nod_byref_NativeList_1_Nod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, 100666552);
				PathFinding.PathFindJob.NativeMethodInfoPtr_Valid_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, 100666553);
				PathFinding.PathFindJob.NativeMethodInfoPtr_Expand_Private_Void_Nod_byref_NativeList_1_Nod_byref_NativeHashMap_2_Int32_Nod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr, 100666554);
			}

			// Token: 0x06005271 RID: 21105 RVA: 0x0012BA80 File Offset: 0x00129C80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76441, RefRangeEnd = 76442, XrefRangeStart = 76401, XrefRangeEnd = 76441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.PathFindJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005272 RID: 21106 RVA: 0x0012BAB8 File Offset: 0x00129CB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76454, RefRangeEnd = 76455, XrefRangeStart = 76442, XrefRangeEnd = 76454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetPath(Nod boop, ref NativeHashMap<int, Nod> checkedNods)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref boop;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(checkedNods));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.PathFindJob.NativeMethodInfoPtr_SetPath_Private_Void_Nod_byref_NativeHashMap_2_Int32_Nod_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005273 RID: 21107 RVA: 0x0012BB14 File Offset: 0x00129D14
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76455, RefRangeEnd = 76456, XrefRangeStart = 76455, XrefRangeEnd = 76455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Intv2 Direction(Intv2 a, Intv2 b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.PathFindJob.NativeMethodInfoPtr_Direction_Private_Intv2_Intv2_Intv2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005274 RID: 21108 RVA: 0x0012BB70 File Offset: 0x00129D70
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 76456, RefRangeEnd = 76460, XrefRangeStart = 76456, XrefRangeEnd = 76456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float Dist(Intv2 a, Intv2 b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.PathFindJob.NativeMethodInfoPtr_Dist_Private_Single_Intv2_Intv2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005275 RID: 21109 RVA: 0x0012BBCC File Offset: 0x00129DCC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76476, RefRangeEnd = 76477, XrefRangeStart = 76460, XrefRangeEnd = 76476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nod PopBest(ref NativeList<Nod> boop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(boop));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.PathFindJob.NativeMethodInfoPtr_PopBest_Private_Nod_byref_NativeList_1_Nod_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005276 RID: 21110 RVA: 0x0012BC24 File Offset: 0x00129E24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76477, RefRangeEnd = 76478, XrefRangeStart = 76477, XrefRangeEnd = 76477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Valid(int x, int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.PathFindJob.NativeMethodInfoPtr_Valid_Public_Boolean_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005277 RID: 21111 RVA: 0x0012BC80 File Offset: 0x00129E80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76494, RefRangeEnd = 76495, XrefRangeStart = 76478, XrefRangeEnd = 76494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Expand(Nod boop, ref NativeList<Nod> list, ref NativeHashMap<int, Nod> checkedNods)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref boop;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(list));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(checkedNods));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.PathFindJob.NativeMethodInfoPtr_Expand_Private_Void_Nod_byref_NativeList_1_Nod_byref_NativeHashMap_2_Int32_Nod_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005278 RID: 21112 RVA: 0x00030083 File Offset: 0x0002E283
			public PathFindJob(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005279 RID: 21113 RVA: 0x0003008C File Offset: 0x0002E28C
			public PathFindJob()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathFinding.PathFindJob>.NativeClassPtr))
			{
			}

			// Token: 0x17001E0E RID: 7694
			// (get) Token: 0x0600527A RID: 21114 RVA: 0x0012BCF4 File Offset: 0x00129EF4
			// (set) Token: 0x0600527B RID: 21115 RVA: 0x0003009E File Offset: 0x0002E29E
			public NativeArray<byte> map
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_map);
					return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_map), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001E0F RID: 7695
			// (get) Token: 0x0600527C RID: 21116 RVA: 0x0012BD24 File Offset: 0x00129F24
			// (set) Token: 0x0600527D RID: 21117 RVA: 0x000300CC File Offset: 0x0002E2CC
			public unsafe Intv2 startPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_startPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_startPos)) = value;
				}
			}

			// Token: 0x17001E10 RID: 7696
			// (get) Token: 0x0600527E RID: 21118 RVA: 0x0012BD4C File Offset: 0x00129F4C
			// (set) Token: 0x0600527F RID: 21119 RVA: 0x000300E7 File Offset: 0x0002E2E7
			public unsafe Intv2 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x17001E11 RID: 7697
			// (get) Token: 0x06005280 RID: 21120 RVA: 0x0012BD74 File Offset: 0x00129F74
			// (set) Token: 0x06005281 RID: 21121 RVA: 0x00030102 File Offset: 0x0002E302
			public unsafe int w
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_w);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_w)) = value;
				}
			}

			// Token: 0x17001E12 RID: 7698
			// (get) Token: 0x06005282 RID: 21122 RVA: 0x0012BD9C File Offset: 0x00129F9C
			// (set) Token: 0x06005283 RID: 21123 RVA: 0x0003011D File Offset: 0x0002E31D
			public unsafe int h
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_h);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_h)) = value;
				}
			}

			// Token: 0x17001E13 RID: 7699
			// (get) Token: 0x06005284 RID: 21124 RVA: 0x0012BDC4 File Offset: 0x00129FC4
			// (set) Token: 0x06005285 RID: 21125 RVA: 0x00030138 File Offset: 0x0002E338
			public unsafe float gridRes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_gridRes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_gridRes)) = value;
				}
			}

			// Token: 0x17001E14 RID: 7700
			// (get) Token: 0x06005286 RID: 21126 RVA: 0x0012BDEC File Offset: 0x00129FEC
			// (set) Token: 0x06005287 RID: 21127 RVA: 0x00030153 File Offset: 0x0002E353
			public NativeList<Vector2> path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_path);
					return new NativeList<Vector2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<Vector2>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.PathFindJob.NativeFieldInfoPtr_path), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Vector2>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04003679 RID: 13945
			private static readonly IntPtr NativeFieldInfoPtr_map;

			// Token: 0x0400367A RID: 13946
			private static readonly IntPtr NativeFieldInfoPtr_startPos;

			// Token: 0x0400367B RID: 13947
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x0400367C RID: 13948
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x0400367D RID: 13949
			private static readonly IntPtr NativeFieldInfoPtr_h;

			// Token: 0x0400367E RID: 13950
			private static readonly IntPtr NativeFieldInfoPtr_gridRes;

			// Token: 0x0400367F RID: 13951
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04003680 RID: 13952
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003681 RID: 13953
			private static readonly IntPtr NativeMethodInfoPtr_SetPath_Private_Void_Nod_byref_NativeHashMap_2_Int32_Nod_0;

			// Token: 0x04003682 RID: 13954
			private static readonly IntPtr NativeMethodInfoPtr_Direction_Private_Intv2_Intv2_Intv2_0;

			// Token: 0x04003683 RID: 13955
			private static readonly IntPtr NativeMethodInfoPtr_Dist_Private_Single_Intv2_Intv2_0;

			// Token: 0x04003684 RID: 13956
			private static readonly IntPtr NativeMethodInfoPtr_PopBest_Private_Nod_byref_NativeList_1_Nod_0;

			// Token: 0x04003685 RID: 13957
			private static readonly IntPtr NativeMethodInfoPtr_Valid_Public_Boolean_Int32_Int32_0;

			// Token: 0x04003686 RID: 13958
			private static readonly IntPtr NativeMethodInfoPtr_Expand_Private_Void_Nod_byref_NativeList_1_Nod_byref_NativeHashMap_2_Int32_Nod_0;
		}

		// Token: 0x02000341 RID: 833
		public sealed class UpdateGridJob : ValueType
		{
			// Token: 0x06005288 RID: 21128 RVA: 0x0012BE1C File Offset: 0x0012A01C
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateGridJob()
			{
				Il2CppClassPointerStore<PathFinding.UpdateGridJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathFinding>.NativeClassPtr, "UpdateGridJob");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathFinding.UpdateGridJob>.NativeClassPtr);
				PathFinding.UpdateGridJob.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.UpdateGridJob>.NativeClassPtr, "w");
				PathFinding.UpdateGridJob.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.UpdateGridJob>.NativeClassPtr, "h");
				PathFinding.UpdateGridJob.NativeFieldInfoPtr_bxLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.UpdateGridJob>.NativeClassPtr, "bxLen");
				PathFinding.UpdateGridJob.NativeFieldInfoPtr_update_boxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.UpdateGridJob>.NativeClassPtr, "update_boxes");
				PathFinding.UpdateGridJob.NativeFieldInfoPtr_in_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.UpdateGridJob>.NativeClassPtr, "in_map");
				PathFinding.UpdateGridJob.NativeFieldInfoPtr_out_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFinding.UpdateGridJob>.NativeClassPtr, "out_map");
				PathFinding.UpdateGridJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFinding.UpdateGridJob>.NativeClassPtr, 100666555);
			}

			// Token: 0x06005289 RID: 21129 RVA: 0x0012BED4 File Offset: 0x0012A0D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76495, RefRangeEnd = 76496, XrefRangeStart = 76495, XrefRangeEnd = 76495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Execute(int idx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref idx;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFinding.UpdateGridJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600528A RID: 21130 RVA: 0x00030181 File Offset: 0x0002E381
			public UpdateGridJob(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600528B RID: 21131 RVA: 0x0003018A File Offset: 0x0002E38A
			public UpdateGridJob()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathFinding.UpdateGridJob>.NativeClassPtr))
			{
			}

			// Token: 0x17001E15 RID: 7701
			// (get) Token: 0x0600528C RID: 21132 RVA: 0x0012BF18 File Offset: 0x0012A118
			// (set) Token: 0x0600528D RID: 21133 RVA: 0x0003019C File Offset: 0x0002E39C
			public unsafe int w
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_w);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_w)) = value;
				}
			}

			// Token: 0x17001E16 RID: 7702
			// (get) Token: 0x0600528E RID: 21134 RVA: 0x0012BF40 File Offset: 0x0012A140
			// (set) Token: 0x0600528F RID: 21135 RVA: 0x000301B7 File Offset: 0x0002E3B7
			public unsafe int h
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_h);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_h)) = value;
				}
			}

			// Token: 0x17001E17 RID: 7703
			// (get) Token: 0x06005290 RID: 21136 RVA: 0x0012BF68 File Offset: 0x0012A168
			// (set) Token: 0x06005291 RID: 21137 RVA: 0x000301D2 File Offset: 0x0002E3D2
			public unsafe int bxLen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_bxLen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_bxLen)) = value;
				}
			}

			// Token: 0x17001E18 RID: 7704
			// (get) Token: 0x06005292 RID: 21138 RVA: 0x0012BF90 File Offset: 0x0012A190
			// (set) Token: 0x06005293 RID: 21139 RVA: 0x000301ED File Offset: 0x0002E3ED
			public NativeArray<Vector4> update_boxes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_update_boxes);
					return new NativeArray<Vector4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_update_boxes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001E19 RID: 7705
			// (get) Token: 0x06005294 RID: 21140 RVA: 0x0012BFC0 File Offset: 0x0012A1C0
			// (set) Token: 0x06005295 RID: 21141 RVA: 0x0003021B File Offset: 0x0002E41B
			public NativeArray<byte> in_map
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_in_map);
					return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_in_map), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001E1A RID: 7706
			// (get) Token: 0x06005296 RID: 21142 RVA: 0x0012BFF0 File Offset: 0x0012A1F0
			// (set) Token: 0x06005297 RID: 21143 RVA: 0x00030249 File Offset: 0x0002E449
			public NativeArray<byte> out_map
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_out_map);
					return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathFinding.UpdateGridJob.NativeFieldInfoPtr_out_map), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04003687 RID: 13959
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x04003688 RID: 13960
			private static readonly IntPtr NativeFieldInfoPtr_h;

			// Token: 0x04003689 RID: 13961
			private static readonly IntPtr NativeFieldInfoPtr_bxLen;

			// Token: 0x0400368A RID: 13962
			private static readonly IntPtr NativeFieldInfoPtr_update_boxes;

			// Token: 0x0400368B RID: 13963
			private static readonly IntPtr NativeFieldInfoPtr_in_map;

			// Token: 0x0400368C RID: 13964
			private static readonly IntPtr NativeFieldInfoPtr_out_map;

			// Token: 0x0400368D RID: 13965
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
		}
	}
}
