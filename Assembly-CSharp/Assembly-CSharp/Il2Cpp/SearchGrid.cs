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
	// Token: 0x0200017F RID: 383
	public class SearchGrid : MonoBehaviour
	{
		// Token: 0x06002D57 RID: 11607 RVA: 0x000B144C File Offset: 0x000AF64C
		// Note: this type is marked as 'beforefieldinit'.
		static SearchGrid()
		{
			Il2CppClassPointerStore<SearchGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SearchGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr);
			SearchGrid.NativeFieldInfoPtr_guards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "guards");
			SearchGrid.NativeFieldInfoPtr_guardsLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "guardsLen");
			SearchGrid.NativeFieldInfoPtr_grid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "grid");
			SearchGrid.NativeFieldInfoPtr_newGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "newGrid");
			SearchGrid.NativeFieldInfoPtr_proxyGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "proxyGrid");
			SearchGrid.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "w");
			SearchGrid.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "h");
			SearchGrid.NativeFieldInfoPtr_activeW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "activeW");
			SearchGrid.NativeFieldInfoPtr_activeH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "activeH");
			SearchGrid.NativeFieldInfoPtr_lastSeenPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "lastSeenPos");
			SearchGrid.NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "room");
			SearchGrid.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "player");
			SearchGrid.NativeFieldInfoPtr_gridRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "gridRes");
			SearchGrid.NativeFieldInfoPtr_leakSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "leakSpeed");
			SearchGrid.NativeFieldInfoPtr_seeDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "seeDist");
			SearchGrid.NativeFieldInfoPtr_seenDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "seenDecay");
			SearchGrid.NativeFieldInfoPtr_searching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "searching");
			SearchGrid.NativeFieldInfoPtr_playerSeen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "playerSeen");
			SearchGrid.NativeFieldInfoPtr_seenFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "seenFlag");
			SearchGrid.NativeFieldInfoPtr_totalRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "totalRed");
			SearchGrid.NativeFieldInfoPtr_debugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "debugging");
			SearchGrid.NativeFieldInfoPtr_hotPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "hotPos");
			SearchGrid.NativeFieldInfoPtr_leakTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "leakTime");
			SearchGrid.NativeFieldInfoPtr_seenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "seenTime");
			SearchGrid.NativeFieldInfoPtr_gridOffsetx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "gridOffsetx");
			SearchGrid.NativeFieldInfoPtr_gridOffsety = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "gridOffsety");
			SearchGrid.NativeFieldInfoPtr_off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "off");
			SearchGrid.NativeFieldInfoPtr_pt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "pt");
			SearchGrid.NativeFieldInfoPtr_ObstacleLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "ObstacleLayerMask");
			SearchGrid.NativeFieldInfoPtr_leakSpeedTimesLeakTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "leakSpeedTimesLeakTime");
			SearchGrid.NativeFieldInfoPtr_guardSightAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "guardSightAng");
			SearchGrid.NativeFieldInfoPtr_RayCastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "RayCastHits");
			SearchGrid.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "initialized");
			SearchGrid.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666819);
			SearchGrid.NativeMethodInfoPtr_MyAwake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666820);
			SearchGrid.NativeMethodInfoPtr_PrepGrid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666821);
			SearchGrid.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666822);
			SearchGrid.NativeMethodInfoPtr_LocalAvoidance_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666823);
			SearchGrid.NativeMethodInfoPtr_GuardVision_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666824);
			SearchGrid.NativeMethodInfoPtr_LowestNumInRegion_Private_Int32_Intv2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666825);
			SearchGrid.NativeMethodInfoPtr_Initialize_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666826);
			SearchGrid.NativeMethodInfoPtr_DistFilled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666827);
			SearchGrid.NativeMethodInfoPtr_UpdateGrid_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666828);
			SearchGrid.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666829);
			SearchGrid.NativeMethodInfoPtr_IsValid_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666830);
			SearchGrid.NativeMethodInfoPtr_ClearSeen_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666831);
			SearchGrid.NativeMethodInfoPtr_ToWorld_Public_Void_Int32_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666832);
			SearchGrid.NativeMethodInfoPtr_ToWorld_Public_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666833);
			SearchGrid.NativeMethodInfoPtr_ToGrid_Public_Intv2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666834);
			SearchGrid.NativeMethodInfoPtr_Valid_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666835);
			SearchGrid.NativeMethodInfoPtr_Valid_Public_Boolean_Intv2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666836);
			SearchGrid.NativeMethodInfoPtr_ClearGrid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666837);
			SearchGrid.NativeMethodInfoPtr_ProportionRed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666838);
			SearchGrid.NativeMethodInfoPtr_LeakAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666839);
			SearchGrid.NativeMethodInfoPtr_UpdateRegion_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666840);
			SearchGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, 100666841);
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x000B18DC File Offset: 0x000AFADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81240, XrefRangeEnd = 81262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x000B1910 File Offset: 0x000AFB10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81291, RefRangeEnd = 81292, XrefRangeStart = 81262, XrefRangeEnd = 81291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_MyAwake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x000B1944 File Offset: 0x000AFB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81292, XrefRangeEnd = 81293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepGrid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_PrepGrid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000B1978 File Offset: 0x000AFB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81293, XrefRangeEnd = 81297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x000B19AC File Offset: 0x000AFBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81297, XrefRangeEnd = 81300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LocalAvoidance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_LocalAvoidance_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x000B19EC File Offset: 0x000AFBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81300, XrefRangeEnd = 81303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GuardVision()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_GuardVision_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x000B1A2C File Offset: 0x000AFC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81303, XrefRangeEnd = 81305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LowestNumInRegion(Intv2 gridPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gridPt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_LowestNumInRegion_Private_Int32_Intv2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x000B1A78 File Offset: 0x000AFC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81305, XrefRangeEnd = 81308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_Initialize_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x000B1AB8 File Offset: 0x000AFCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81308, XrefRangeEnd = 81310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DistFilled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_DistFilled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x000B1AF4 File Offset: 0x000AFCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81310, XrefRangeEnd = 81313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator UpdateGrid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_UpdateGrid_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x000B1B34 File Offset: 0x000AFD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81313, XrefRangeEnd = 81323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x000B1B68 File Offset: 0x000AFD68
		[CallerCount(0)]
		public unsafe bool IsValid(int a, int b)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_IsValid_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x000B1BC0 File Offset: 0x000AFDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81323, XrefRangeEnd = 81326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ClearSeen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_ClearSeen_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x000B1C00 File Offset: 0x000AFE00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81326, RefRangeEnd = 81329, XrefRangeStart = 81326, XrefRangeEnd = 81326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToWorld(int a, int b, ref Vector2 worldPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_ToWorld_Public_Void_Int32_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x000B1C5C File Offset: 0x000AFE5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81329, RefRangeEnd = 81330, XrefRangeStart = 81329, XrefRangeEnd = 81329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_ToWorld_Public_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x000B1CB4 File Offset: 0x000AFEB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81330, RefRangeEnd = 81332, XrefRangeStart = 81330, XrefRangeEnd = 81330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Intv2 ToGrid(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_ToGrid_Public_Intv2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x000B1D00 File Offset: 0x000AFF00
		[CallerCount(0)]
		public unsafe bool Valid(Vector2 blah)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref blah;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_Valid_Public_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x000B1D4C File Offset: 0x000AFF4C
		[CallerCount(0)]
		public unsafe bool Valid(Intv2 blah)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref blah;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_Valid_Public_Boolean_Intv2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x000B1D98 File Offset: 0x000AFF98
		[CallerCount(0)]
		public unsafe void ClearGrid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_ClearGrid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x000B1DCC File Offset: 0x000AFFCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81340, RefRangeEnd = 81341, XrefRangeStart = 81332, XrefRangeEnd = 81340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProportionRed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_ProportionRed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x000B1E00 File Offset: 0x000B0000
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 81341, RefRangeEnd = 81345, XrefRangeStart = 81341, XrefRangeEnd = 81341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeakAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_LeakAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x000B1E34 File Offset: 0x000B0034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81347, RefRangeEnd = 81349, XrefRangeStart = 81345, XrefRangeEnd = 81347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRegion(Vector2 min, Vector2 max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr_UpdateRegion_Public_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x000B1E80 File Offset: 0x000B0080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81349, XrefRangeEnd = 81355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SearchGrid()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x0001F60A File Offset: 0x0001D80A
		public SearchGrid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x000B1EBC File Offset: 0x000B00BC
		// (set) Token: 0x06002D71 RID: 11633 RVA: 0x0001F613 File Offset: 0x0001D813
		public unsafe Il2CppReferenceArray<GuardState> guards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_guards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GuardState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_guards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x000B1EEC File Offset: 0x000B00EC
		// (set) Token: 0x06002D73 RID: 11635 RVA: 0x0001F632 File Offset: 0x0001D832
		public unsafe int guardsLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_guardsLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_guardsLen)) = value;
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x000B1F14 File Offset: 0x000B0114
		// (set) Token: 0x06002D75 RID: 11637 RVA: 0x0001F64D File Offset: 0x0001D84D
		public unsafe Il2CppStructArray<float> grid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_grid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_grid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06002D76 RID: 11638 RVA: 0x000B1F44 File Offset: 0x000B0144
		// (set) Token: 0x06002D77 RID: 11639 RVA: 0x0001F66C File Offset: 0x0001D86C
		public unsafe Il2CppStructArray<float> newGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_newGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_newGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06002D78 RID: 11640 RVA: 0x000B1F74 File Offset: 0x000B0174
		// (set) Token: 0x06002D79 RID: 11641 RVA: 0x0001F68B File Offset: 0x0001D88B
		public unsafe Il2CppStructArray<float> proxyGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_proxyGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_proxyGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06002D7A RID: 11642 RVA: 0x000B1FA4 File Offset: 0x000B01A4
		// (set) Token: 0x06002D7B RID: 11643 RVA: 0x0001F6AA File Offset: 0x0001D8AA
		public unsafe int w
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_w);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_w)) = value;
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x000B1FCC File Offset: 0x000B01CC
		// (set) Token: 0x06002D7D RID: 11645 RVA: 0x0001F6C5 File Offset: 0x0001D8C5
		public unsafe int h
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_h);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_h)) = value;
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x000B1FF4 File Offset: 0x000B01F4
		// (set) Token: 0x06002D7F RID: 11647 RVA: 0x0001F6E0 File Offset: 0x0001D8E0
		public unsafe int activeW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_activeW);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_activeW)) = value;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06002D80 RID: 11648 RVA: 0x000B201C File Offset: 0x000B021C
		// (set) Token: 0x06002D81 RID: 11649 RVA: 0x0001F6FB File Offset: 0x0001D8FB
		public unsafe int activeH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_activeH);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_activeH)) = value;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06002D82 RID: 11650 RVA: 0x000B2044 File Offset: 0x000B0244
		// (set) Token: 0x06002D83 RID: 11651 RVA: 0x0001F716 File Offset: 0x0001D916
		public unsafe Intv2 lastSeenPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_lastSeenPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_lastSeenPos)) = value;
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x000B206C File Offset: 0x000B026C
		// (set) Token: 0x06002D85 RID: 11653 RVA: 0x0001F731 File Offset: 0x0001D931
		public unsafe RoomState room
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_room);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoomState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_room), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x000B209C File Offset: 0x000B029C
		// (set) Token: 0x06002D87 RID: 11655 RVA: 0x0001F750 File Offset: 0x0001D950
		public unsafe GameObject player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06002D88 RID: 11656 RVA: 0x000B20CC File Offset: 0x000B02CC
		// (set) Token: 0x06002D89 RID: 11657 RVA: 0x0001F76F File Offset: 0x0001D96F
		public unsafe int gridRes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_gridRes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_gridRes)) = value;
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x000B20F4 File Offset: 0x000B02F4
		// (set) Token: 0x06002D8B RID: 11659 RVA: 0x0001F78A File Offset: 0x0001D98A
		public unsafe float leakSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_leakSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_leakSpeed)) = value;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x000B211C File Offset: 0x000B031C
		// (set) Token: 0x06002D8D RID: 11661 RVA: 0x0001F7A5 File Offset: 0x0001D9A5
		public unsafe float seeDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_seeDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_seeDist)) = value;
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x000B2144 File Offset: 0x000B0344
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x0001F7C0 File Offset: 0x0001D9C0
		public unsafe float seenDecay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_seenDecay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_seenDecay)) = value;
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x000B216C File Offset: 0x000B036C
		// (set) Token: 0x06002D91 RID: 11665 RVA: 0x0001F7DB File Offset: 0x0001D9DB
		public unsafe bool searching
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_searching);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_searching)) = value;
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x000B2194 File Offset: 0x000B0394
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x0001F7F6 File Offset: 0x0001D9F6
		public unsafe bool playerSeen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_playerSeen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_playerSeen)) = value;
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x000B21BC File Offset: 0x000B03BC
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x0001F811 File Offset: 0x0001DA11
		public unsafe bool seenFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_seenFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_seenFlag)) = value;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x000B21E4 File Offset: 0x000B03E4
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x0001F82C File Offset: 0x0001DA2C
		public unsafe float totalRed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_totalRed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_totalRed)) = value;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x000B220C File Offset: 0x000B040C
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x0001F847 File Offset: 0x0001DA47
		public unsafe bool debugging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_debugging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_debugging)) = value;
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x000B2234 File Offset: 0x000B0434
		// (set) Token: 0x06002D9B RID: 11675 RVA: 0x0001F862 File Offset: 0x0001DA62
		public unsafe Vector2 hotPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_hotPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_hotPos)) = value;
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x000B225C File Offset: 0x000B045C
		// (set) Token: 0x06002D9D RID: 11677 RVA: 0x0001F87D File Offset: 0x0001DA7D
		public unsafe float leakTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_leakTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_leakTime)) = value;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x000B2284 File Offset: 0x000B0484
		// (set) Token: 0x06002D9F RID: 11679 RVA: 0x0001F898 File Offset: 0x0001DA98
		public unsafe float seenTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_seenTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_seenTime)) = value;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x000B22AC File Offset: 0x000B04AC
		// (set) Token: 0x06002DA1 RID: 11681 RVA: 0x0001F8B3 File Offset: 0x0001DAB3
		public unsafe int gridOffsetx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_gridOffsetx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_gridOffsetx)) = value;
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x000B22D4 File Offset: 0x000B04D4
		// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x0001F8CE File Offset: 0x0001DACE
		public unsafe int gridOffsety
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_gridOffsety);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_gridOffsety)) = value;
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x000B22FC File Offset: 0x000B04FC
		// (set) Token: 0x06002DA5 RID: 11685 RVA: 0x0001F8E9 File Offset: 0x0001DAE9
		public unsafe bool off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_off);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_off)) = value;
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x000B2324 File Offset: 0x000B0524
		// (set) Token: 0x06002DA7 RID: 11687 RVA: 0x0001F904 File Offset: 0x0001DB04
		public unsafe Vector2 pt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_pt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_pt)) = value;
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x000B234C File Offset: 0x000B054C
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x0001F91F File Offset: 0x0001DB1F
		public unsafe int ObstacleLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_ObstacleLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_ObstacleLayerMask)) = value;
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x000B2374 File Offset: 0x000B0574
		// (set) Token: 0x06002DAB RID: 11691 RVA: 0x0001F93A File Offset: 0x0001DB3A
		public unsafe float leakSpeedTimesLeakTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_leakSpeedTimesLeakTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_leakSpeedTimesLeakTime)) = value;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06002DAC RID: 11692 RVA: 0x000B239C File Offset: 0x000B059C
		// (set) Token: 0x06002DAD RID: 11693 RVA: 0x0001F955 File Offset: 0x0001DB55
		public unsafe float guardSightAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_guardSightAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_guardSightAng)) = value;
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06002DAE RID: 11694 RVA: 0x000B23C4 File Offset: 0x000B05C4
		// (set) Token: 0x06002DAF RID: 11695 RVA: 0x0001F970 File Offset: 0x0001DB70
		public unsafe Il2CppStructArray<RaycastHit2D> RayCastHits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_RayCastHits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_RayCastHits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06002DB0 RID: 11696 RVA: 0x000B23F4 File Offset: 0x000B05F4
		// (set) Token: 0x06002DB1 RID: 11697 RVA: 0x0001F98F File Offset: 0x0001DB8F
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeFieldInfoPtr_guards;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeFieldInfoPtr_guardsLen;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeFieldInfoPtr_grid;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeFieldInfoPtr_newGrid;

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeFieldInfoPtr_proxyGrid;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeFieldInfoPtr_h;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeFieldInfoPtr_activeW;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeFieldInfoPtr_activeH;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeFieldInfoPtr_lastSeenPos;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeFieldInfoPtr_room;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeFieldInfoPtr_gridRes;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeFieldInfoPtr_leakSpeed;

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeFieldInfoPtr_seeDist;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeFieldInfoPtr_seenDecay;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeFieldInfoPtr_searching;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeFieldInfoPtr_playerSeen;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeFieldInfoPtr_seenFlag;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeFieldInfoPtr_totalRed;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeFieldInfoPtr_debugging;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeFieldInfoPtr_hotPos;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeFieldInfoPtr_leakTime;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeFieldInfoPtr_seenTime;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeFieldInfoPtr_gridOffsetx;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeFieldInfoPtr_gridOffsety;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeFieldInfoPtr_off;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeFieldInfoPtr_pt;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeFieldInfoPtr_ObstacleLayerMask;

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeFieldInfoPtr_leakSpeedTimesLeakTime;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeFieldInfoPtr_guardSightAng;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeFieldInfoPtr_RayCastHits;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeMethodInfoPtr_MyAwake_Public_Void_0;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr_PrepGrid_Public_Void_0;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_LocalAvoidance_Private_IEnumerator_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr_GuardVision_Private_IEnumerator_0;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeMethodInfoPtr_LowestNumInRegion_Private_Int32_Intv2_0;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_IEnumerator_0;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeMethodInfoPtr_DistFilled_Private_Boolean_0;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGrid_Private_IEnumerator_0;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_Int32_Int32_0;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_ClearSeen_Public_IEnumerator_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_ToWorld_Public_Void_Int32_Int32_byref_Vector2_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeMethodInfoPtr_ToWorld_Public_Vector2_Int32_Int32_0;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr_ToGrid_Public_Intv2_Vector2_0;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr_Valid_Public_Boolean_Vector2_0;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeMethodInfoPtr_Valid_Public_Boolean_Intv2_0;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeMethodInfoPtr_ClearGrid_Public_Void_0;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeMethodInfoPtr_ProportionRed_Public_Void_0;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr_LeakAll_Public_Void_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRegion_Public_Void_Vector2_Vector2_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000344 RID: 836
		[ObfuscatedName("SearchGrid+<LocalAvoidance>d__37")]
		public sealed class _LocalAvoidance_d__37 : global::Il2CppSystem.Object
		{
			// Token: 0x060052B4 RID: 21172 RVA: 0x0012C5C8 File Offset: 0x0012A7C8
			// Note: this type is marked as 'beforefieldinit'.
			static _LocalAvoidance_d__37()
			{
				Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "<LocalAvoidance>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr);
				SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, "<>1__state");
				SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, "<>2__current");
				SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, "<>4__this");
				SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__prevGrds_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, "<prevGrds>5__2");
				SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__curGrds_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, "<curGrds>5__3");
				SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__j_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, "<j>5__4");
				SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__grdRatio_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, "<grdRatio>5__5");
				SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, "<i>5__6");
				SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, 100666842);
				SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, 100666843);
				SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, 100666844);
				SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, 100666845);
				SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, 100666846);
				SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr, 100666847);
			}

			// Token: 0x060052B5 RID: 21173 RVA: 0x0012C70C File Offset: 0x0012A90C
			[CallerCount(0)]
			public unsafe _LocalAvoidance_d__37(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchGrid._LocalAvoidance_d__37>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052B6 RID: 21174 RVA: 0x0012C754 File Offset: 0x0012A954
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052B7 RID: 21175 RVA: 0x0012C788 File Offset: 0x0012A988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81112, XrefRangeEnd = 81119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E2D RID: 7725
			// (get) Token: 0x060052B8 RID: 21176 RVA: 0x0012C7C4 File Offset: 0x0012A9C4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052B9 RID: 21177 RVA: 0x0012C804 File Offset: 0x0012AA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81119, XrefRangeEnd = 81124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E2E RID: 7726
			// (get) Token: 0x060052BA RID: 21178 RVA: 0x0012C838 File Offset: 0x0012AA38
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._LocalAvoidance_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052BB RID: 21179 RVA: 0x0003033B File Offset: 0x0002E53B
			public _LocalAvoidance_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E25 RID: 7717
			// (get) Token: 0x060052BC RID: 21180 RVA: 0x0012C878 File Offset: 0x0012AA78
			// (set) Token: 0x060052BD RID: 21181 RVA: 0x00030344 File Offset: 0x0002E544
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E26 RID: 7718
			// (get) Token: 0x060052BE RID: 21182 RVA: 0x0012C8A0 File Offset: 0x0012AAA0
			// (set) Token: 0x060052BF RID: 21183 RVA: 0x0003035F File Offset: 0x0002E55F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E27 RID: 7719
			// (get) Token: 0x060052C0 RID: 21184 RVA: 0x0012C8D0 File Offset: 0x0012AAD0
			// (set) Token: 0x060052C1 RID: 21185 RVA: 0x0003037E File Offset: 0x0002E57E
			public unsafe SearchGrid __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchGrid>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E28 RID: 7720
			// (get) Token: 0x060052C2 RID: 21186 RVA: 0x0012C900 File Offset: 0x0012AB00
			// (set) Token: 0x060052C3 RID: 21187 RVA: 0x0003039D File Offset: 0x0002E59D
			public unsafe float _prevGrds_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__prevGrds_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__prevGrds_5__2)) = value;
				}
			}

			// Token: 0x17001E29 RID: 7721
			// (get) Token: 0x060052C4 RID: 21188 RVA: 0x0012C928 File Offset: 0x0012AB28
			// (set) Token: 0x060052C5 RID: 21189 RVA: 0x000303B8 File Offset: 0x0002E5B8
			public unsafe float _curGrds_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__curGrds_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__curGrds_5__3)) = value;
				}
			}

			// Token: 0x17001E2A RID: 7722
			// (get) Token: 0x060052C6 RID: 21190 RVA: 0x0012C950 File Offset: 0x0012AB50
			// (set) Token: 0x060052C7 RID: 21191 RVA: 0x000303D3 File Offset: 0x0002E5D3
			public unsafe int _j_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__j_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__j_5__4)) = value;
				}
			}

			// Token: 0x17001E2B RID: 7723
			// (get) Token: 0x060052C8 RID: 21192 RVA: 0x0012C978 File Offset: 0x0012AB78
			// (set) Token: 0x060052C9 RID: 21193 RVA: 0x000303EE File Offset: 0x0002E5EE
			public unsafe float _grdRatio_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__grdRatio_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__grdRatio_5__5)) = value;
				}
			}

			// Token: 0x17001E2C RID: 7724
			// (get) Token: 0x060052CA RID: 21194 RVA: 0x0012C9A0 File Offset: 0x0012ABA0
			// (set) Token: 0x060052CB RID: 21195 RVA: 0x00030409 File Offset: 0x0002E609
			public unsafe int _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._LocalAvoidance_d__37.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x040036A0 RID: 13984
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040036A1 RID: 13985
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040036A2 RID: 13986
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040036A3 RID: 13987
			private static readonly IntPtr NativeFieldInfoPtr__prevGrds_5__2;

			// Token: 0x040036A4 RID: 13988
			private static readonly IntPtr NativeFieldInfoPtr__curGrds_5__3;

			// Token: 0x040036A5 RID: 13989
			private static readonly IntPtr NativeFieldInfoPtr__j_5__4;

			// Token: 0x040036A6 RID: 13990
			private static readonly IntPtr NativeFieldInfoPtr__grdRatio_5__5;

			// Token: 0x040036A7 RID: 13991
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x040036A8 RID: 13992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040036A9 RID: 13993
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036AA RID: 13994
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040036AB RID: 13995
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040036AC RID: 13996
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036AD RID: 13997
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000345 RID: 837
		[ObfuscatedName("SearchGrid+<GuardVision>d__38")]
		public sealed class _GuardVision_d__38 : global::Il2CppSystem.Object
		{
			// Token: 0x060052CC RID: 21196 RVA: 0x0012C9C8 File Offset: 0x0012ABC8
			// Note: this type is marked as 'beforefieldinit'.
			static _GuardVision_d__38()
			{
				Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "<GuardVision>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr);
				SearchGrid._GuardVision_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, "<>1__state");
				SearchGrid._GuardVision_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, "<>2__current");
				SearchGrid._GuardVision_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, "<>4__this");
				SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__lastTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, "<lastTime>5__2");
				SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__j_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, "<j>5__3");
				SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__curTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, "<curTime>5__4");
				SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__pPos_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, "<pPos>5__5");
				SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__delt_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, "<delt>5__6");
				SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__i_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, "<i>5__7");
				SearchGrid._GuardVision_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, 100666848);
				SearchGrid._GuardVision_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, 100666849);
				SearchGrid._GuardVision_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, 100666850);
				SearchGrid._GuardVision_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, 100666851);
				SearchGrid._GuardVision_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, 100666852);
				SearchGrid._GuardVision_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr, 100666853);
			}

			// Token: 0x060052CD RID: 21197 RVA: 0x0012CB20 File Offset: 0x0012AD20
			[CallerCount(0)]
			public unsafe _GuardVision_d__38(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchGrid._GuardVision_d__38>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._GuardVision_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052CE RID: 21198 RVA: 0x0012CB68 File Offset: 0x0012AD68
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._GuardVision_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052CF RID: 21199 RVA: 0x0012CB9C File Offset: 0x0012AD9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81124, XrefRangeEnd = 81144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._GuardVision_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E38 RID: 7736
			// (get) Token: 0x060052D0 RID: 21200 RVA: 0x0012CBD8 File Offset: 0x0012ADD8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._GuardVision_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052D1 RID: 21201 RVA: 0x0012CC18 File Offset: 0x0012AE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81144, XrefRangeEnd = 81149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._GuardVision_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E39 RID: 7737
			// (get) Token: 0x060052D2 RID: 21202 RVA: 0x0012CC4C File Offset: 0x0012AE4C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._GuardVision_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052D3 RID: 21203 RVA: 0x00030424 File Offset: 0x0002E624
			public _GuardVision_d__38(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E2F RID: 7727
			// (get) Token: 0x060052D4 RID: 21204 RVA: 0x0012CC8C File Offset: 0x0012AE8C
			// (set) Token: 0x060052D5 RID: 21205 RVA: 0x0003042D File Offset: 0x0002E62D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E30 RID: 7728
			// (get) Token: 0x060052D6 RID: 21206 RVA: 0x0012CCB4 File Offset: 0x0012AEB4
			// (set) Token: 0x060052D7 RID: 21207 RVA: 0x00030448 File Offset: 0x0002E648
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E31 RID: 7729
			// (get) Token: 0x060052D8 RID: 21208 RVA: 0x0012CCE4 File Offset: 0x0012AEE4
			// (set) Token: 0x060052D9 RID: 21209 RVA: 0x00030467 File Offset: 0x0002E667
			public unsafe SearchGrid __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchGrid>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E32 RID: 7730
			// (get) Token: 0x060052DA RID: 21210 RVA: 0x0012CD14 File Offset: 0x0012AF14
			// (set) Token: 0x060052DB RID: 21211 RVA: 0x00030486 File Offset: 0x0002E686
			public unsafe float _lastTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__lastTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__lastTime_5__2)) = value;
				}
			}

			// Token: 0x17001E33 RID: 7731
			// (get) Token: 0x060052DC RID: 21212 RVA: 0x0012CD3C File Offset: 0x0012AF3C
			// (set) Token: 0x060052DD RID: 21213 RVA: 0x000304A1 File Offset: 0x0002E6A1
			public unsafe int _j_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__j_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__j_5__3)) = value;
				}
			}

			// Token: 0x17001E34 RID: 7732
			// (get) Token: 0x060052DE RID: 21214 RVA: 0x0012CD64 File Offset: 0x0012AF64
			// (set) Token: 0x060052DF RID: 21215 RVA: 0x000304BC File Offset: 0x0002E6BC
			public unsafe float _curTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__curTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__curTime_5__4)) = value;
				}
			}

			// Token: 0x17001E35 RID: 7733
			// (get) Token: 0x060052E0 RID: 21216 RVA: 0x0012CD8C File Offset: 0x0012AF8C
			// (set) Token: 0x060052E1 RID: 21217 RVA: 0x000304D7 File Offset: 0x0002E6D7
			public unsafe Vector2 _pPos_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__pPos_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__pPos_5__5)) = value;
				}
			}

			// Token: 0x17001E36 RID: 7734
			// (get) Token: 0x060052E2 RID: 21218 RVA: 0x0012CDB4 File Offset: 0x0012AFB4
			// (set) Token: 0x060052E3 RID: 21219 RVA: 0x000304F2 File Offset: 0x0002E6F2
			public unsafe float _delt_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__delt_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__delt_5__6)) = value;
				}
			}

			// Token: 0x17001E37 RID: 7735
			// (get) Token: 0x060052E4 RID: 21220 RVA: 0x0012CDDC File Offset: 0x0012AFDC
			// (set) Token: 0x060052E5 RID: 21221 RVA: 0x0003050D File Offset: 0x0002E70D
			public unsafe int _i_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__i_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._GuardVision_d__38.NativeFieldInfoPtr__i_5__7)) = value;
				}
			}

			// Token: 0x040036AE RID: 13998
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040036AF RID: 13999
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040036B0 RID: 14000
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040036B1 RID: 14001
			private static readonly IntPtr NativeFieldInfoPtr__lastTime_5__2;

			// Token: 0x040036B2 RID: 14002
			private static readonly IntPtr NativeFieldInfoPtr__j_5__3;

			// Token: 0x040036B3 RID: 14003
			private static readonly IntPtr NativeFieldInfoPtr__curTime_5__4;

			// Token: 0x040036B4 RID: 14004
			private static readonly IntPtr NativeFieldInfoPtr__pPos_5__5;

			// Token: 0x040036B5 RID: 14005
			private static readonly IntPtr NativeFieldInfoPtr__delt_5__6;

			// Token: 0x040036B6 RID: 14006
			private static readonly IntPtr NativeFieldInfoPtr__i_5__7;

			// Token: 0x040036B7 RID: 14007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040036B8 RID: 14008
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036B9 RID: 14009
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040036BA RID: 14010
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040036BB RID: 14011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036BC RID: 14012
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000346 RID: 838
		[ObfuscatedName("SearchGrid+<Initialize>d__40")]
		public sealed class _Initialize_d__40 : global::Il2CppSystem.Object
		{
			// Token: 0x060052E6 RID: 21222 RVA: 0x0012CE04 File Offset: 0x0012B004
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__40()
			{
				Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "<Initialize>d__40");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr);
				SearchGrid._Initialize_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr, "<>1__state");
				SearchGrid._Initialize_d__40.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr, "<>2__current");
				SearchGrid._Initialize_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr, "<>4__this");
				SearchGrid._Initialize_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr, 100666854);
				SearchGrid._Initialize_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr, 100666855);
				SearchGrid._Initialize_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr, 100666856);
				SearchGrid._Initialize_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr, 100666857);
				SearchGrid._Initialize_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr, 100666858);
				SearchGrid._Initialize_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr, 100666859);
			}

			// Token: 0x060052E7 RID: 21223 RVA: 0x0012CEE4 File Offset: 0x0012B0E4
			[CallerCount(0)]
			public unsafe _Initialize_d__40(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchGrid._Initialize_d__40>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._Initialize_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052E8 RID: 21224 RVA: 0x0012CF2C File Offset: 0x0012B12C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._Initialize_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052E9 RID: 21225 RVA: 0x0012CF60 File Offset: 0x0012B160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81149, XrefRangeEnd = 81172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._Initialize_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E3D RID: 7741
			// (get) Token: 0x060052EA RID: 21226 RVA: 0x0012CF9C File Offset: 0x0012B19C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._Initialize_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052EB RID: 21227 RVA: 0x0012CFDC File Offset: 0x0012B1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81172, XrefRangeEnd = 81177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._Initialize_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E3E RID: 7742
			// (get) Token: 0x060052EC RID: 21228 RVA: 0x0012D010 File Offset: 0x0012B210
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._Initialize_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052ED RID: 21229 RVA: 0x00030528 File Offset: 0x0002E728
			public _Initialize_d__40(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E3A RID: 7738
			// (get) Token: 0x060052EE RID: 21230 RVA: 0x0012D050 File Offset: 0x0012B250
			// (set) Token: 0x060052EF RID: 21231 RVA: 0x00030531 File Offset: 0x0002E731
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._Initialize_d__40.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._Initialize_d__40.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E3B RID: 7739
			// (get) Token: 0x060052F0 RID: 21232 RVA: 0x0012D078 File Offset: 0x0012B278
			// (set) Token: 0x060052F1 RID: 21233 RVA: 0x0003054C File Offset: 0x0002E74C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._Initialize_d__40.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._Initialize_d__40.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E3C RID: 7740
			// (get) Token: 0x060052F2 RID: 21234 RVA: 0x0012D0A8 File Offset: 0x0012B2A8
			// (set) Token: 0x060052F3 RID: 21235 RVA: 0x0003056B File Offset: 0x0002E76B
			public unsafe SearchGrid __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._Initialize_d__40.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchGrid>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._Initialize_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036BD RID: 14013
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040036BE RID: 14014
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040036BF RID: 14015
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040036C0 RID: 14016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040036C1 RID: 14017
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036C2 RID: 14018
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040036C3 RID: 14019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040036C4 RID: 14020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036C5 RID: 14021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000347 RID: 839
		[ObfuscatedName("SearchGrid+<UpdateGrid>d__42")]
		public sealed class _UpdateGrid_d__42 : global::Il2CppSystem.Object
		{
			// Token: 0x060052F4 RID: 21236 RVA: 0x0012D0D8 File Offset: 0x0012B2D8
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateGrid_d__42()
			{
				Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "<UpdateGrid>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr);
				SearchGrid._UpdateGrid_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr, "<>1__state");
				SearchGrid._UpdateGrid_d__42.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr, "<>2__current");
				SearchGrid._UpdateGrid_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr, "<>4__this");
				SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr, 100666860);
				SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr, 100666861);
				SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr, 100666862);
				SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr, 100666863);
				SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr, 100666864);
				SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr, 100666865);
			}

			// Token: 0x060052F5 RID: 21237 RVA: 0x0012D1B8 File Offset: 0x0012B3B8
			[CallerCount(0)]
			public unsafe _UpdateGrid_d__42(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchGrid._UpdateGrid_d__42>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052F6 RID: 21238 RVA: 0x0012D200 File Offset: 0x0012B400
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052F7 RID: 21239 RVA: 0x0012D234 File Offset: 0x0012B434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81177, XrefRangeEnd = 81213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E42 RID: 7746
			// (get) Token: 0x060052F8 RID: 21240 RVA: 0x0012D270 File Offset: 0x0012B470
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052F9 RID: 21241 RVA: 0x0012D2B0 File Offset: 0x0012B4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81213, XrefRangeEnd = 81218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E43 RID: 7747
			// (get) Token: 0x060052FA RID: 21242 RVA: 0x0012D2E4 File Offset: 0x0012B4E4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._UpdateGrid_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052FB RID: 21243 RVA: 0x0003058A File Offset: 0x0002E78A
			public _UpdateGrid_d__42(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E3F RID: 7743
			// (get) Token: 0x060052FC RID: 21244 RVA: 0x0012D324 File Offset: 0x0012B524
			// (set) Token: 0x060052FD RID: 21245 RVA: 0x00030593 File Offset: 0x0002E793
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._UpdateGrid_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._UpdateGrid_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E40 RID: 7744
			// (get) Token: 0x060052FE RID: 21246 RVA: 0x0012D34C File Offset: 0x0012B54C
			// (set) Token: 0x060052FF RID: 21247 RVA: 0x000305AE File Offset: 0x0002E7AE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._UpdateGrid_d__42.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._UpdateGrid_d__42.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E41 RID: 7745
			// (get) Token: 0x06005300 RID: 21248 RVA: 0x0012D37C File Offset: 0x0012B57C
			// (set) Token: 0x06005301 RID: 21249 RVA: 0x000305CD File Offset: 0x0002E7CD
			public unsafe SearchGrid __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._UpdateGrid_d__42.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchGrid>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._UpdateGrid_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036C6 RID: 14022
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040036C7 RID: 14023
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040036C8 RID: 14024
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040036C9 RID: 14025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040036CA RID: 14026
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036CB RID: 14027
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040036CC RID: 14028
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040036CD RID: 14029
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036CE RID: 14030
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000348 RID: 840
		[ObfuscatedName("SearchGrid+<ClearSeen>d__45")]
		public sealed class _ClearSeen_d__45 : global::Il2CppSystem.Object
		{
			// Token: 0x06005302 RID: 21250 RVA: 0x0012D3AC File Offset: 0x0012B5AC
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearSeen_d__45()
			{
				Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SearchGrid>.NativeClassPtr, "<ClearSeen>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr);
				SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr, "<>1__state");
				SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr, "<>2__current");
				SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr, "<>4__this");
				SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr__num_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr, "<num>5__2");
				SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr__m_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr, "<m>5__3");
				SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr, 100666866);
				SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr, 100666867);
				SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr, 100666868);
				SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr, 100666869);
				SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr, 100666870);
				SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr, 100666871);
			}

			// Token: 0x06005303 RID: 21251 RVA: 0x0012D4B4 File Offset: 0x0012B6B4
			[CallerCount(0)]
			public unsafe _ClearSeen_d__45(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchGrid._ClearSeen_d__45>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005304 RID: 21252 RVA: 0x0012D4FC File Offset: 0x0012B6FC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005305 RID: 21253 RVA: 0x0012D530 File Offset: 0x0012B730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81218, XrefRangeEnd = 81235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E49 RID: 7753
			// (get) Token: 0x06005306 RID: 21254 RVA: 0x0012D56C File Offset: 0x0012B76C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005307 RID: 21255 RVA: 0x0012D5AC File Offset: 0x0012B7AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81235, XrefRangeEnd = 81240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E4A RID: 7754
			// (get) Token: 0x06005308 RID: 21256 RVA: 0x0012D5E0 File Offset: 0x0012B7E0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchGrid._ClearSeen_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005309 RID: 21257 RVA: 0x000305EC File Offset: 0x0002E7EC
			public _ClearSeen_d__45(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E44 RID: 7748
			// (get) Token: 0x0600530A RID: 21258 RVA: 0x0012D620 File Offset: 0x0012B820
			// (set) Token: 0x0600530B RID: 21259 RVA: 0x000305F5 File Offset: 0x0002E7F5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E45 RID: 7749
			// (get) Token: 0x0600530C RID: 21260 RVA: 0x0012D648 File Offset: 0x0012B848
			// (set) Token: 0x0600530D RID: 21261 RVA: 0x00030610 File Offset: 0x0002E810
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E46 RID: 7750
			// (get) Token: 0x0600530E RID: 21262 RVA: 0x0012D678 File Offset: 0x0012B878
			// (set) Token: 0x0600530F RID: 21263 RVA: 0x0003062F File Offset: 0x0002E82F
			public unsafe SearchGrid __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchGrid>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E47 RID: 7751
			// (get) Token: 0x06005310 RID: 21264 RVA: 0x0012D6A8 File Offset: 0x0012B8A8
			// (set) Token: 0x06005311 RID: 21265 RVA: 0x0003064E File Offset: 0x0002E84E
			public unsafe int _num_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr__num_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr__num_5__2)) = value;
				}
			}

			// Token: 0x17001E48 RID: 7752
			// (get) Token: 0x06005312 RID: 21266 RVA: 0x0012D6D0 File Offset: 0x0012B8D0
			// (set) Token: 0x06005313 RID: 21267 RVA: 0x00030669 File Offset: 0x0002E869
			public unsafe int _m_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr__m_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchGrid._ClearSeen_d__45.NativeFieldInfoPtr__m_5__3)) = value;
				}
			}

			// Token: 0x040036CF RID: 14031
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040036D0 RID: 14032
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040036D1 RID: 14033
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040036D2 RID: 14034
			private static readonly IntPtr NativeFieldInfoPtr__num_5__2;

			// Token: 0x040036D3 RID: 14035
			private static readonly IntPtr NativeFieldInfoPtr__m_5__3;

			// Token: 0x040036D4 RID: 14036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040036D5 RID: 14037
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036D6 RID: 14038
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040036D7 RID: 14039
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040036D8 RID: 14040
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036D9 RID: 14041
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
