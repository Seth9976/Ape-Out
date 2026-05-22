using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000171 RID: 369
	public class RockTech : MonoBehaviour
	{
		// Token: 0x06002C36 RID: 11318 RVA: 0x000AE648 File Offset: 0x000AC848
		// Note: this type is marked as 'beforefieldinit'.
		static RockTech()
		{
			Il2CppClassPointerStore<RockTech>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RockTech");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RockTech>.NativeClassPtr);
			RockTech.NativeFieldInfoPtr_botMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "botMesh");
			RockTech.NativeFieldInfoPtr_topMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "topMesh");
			RockTech.NativeFieldInfoPtr_botTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "botTrans");
			RockTech.NativeFieldInfoPtr_topTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "topTrans");
			RockTech.NativeFieldInfoPtr_shadowMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "shadowMesh");
			RockTech.NativeFieldInfoPtr_shadowMeshMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "shadowMeshMesh");
			RockTech.NativeFieldInfoPtr_botRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "botRend");
			RockTech.NativeFieldInfoPtr_topRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "topRend");
			RockTech.NativeFieldInfoPtr_shadowRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "shadowRend");
			RockTech.NativeFieldInfoPtr_debugPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "debugPt");
			RockTech.NativeFieldInfoPtr_tris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "tris");
			RockTech.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "uv");
			RockTech.NativeFieldInfoPtr_paralaxAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "paralaxAmount");
			RockTech.NativeFieldInfoPtr_botMeshVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "botMeshVerts");
			RockTech.NativeFieldInfoPtr_topMeshVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "topMeshVerts");
			RockTech.NativeFieldInfoPtr_layerThisShit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "layerThisShit");
			RockTech.NativeFieldInfoPtr_dontLayerMeDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "dontLayerMeDown");
			RockTech.NativeFieldInfoPtr_palMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "palMat");
			RockTech.NativeFieldInfoPtr_centerLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "centerLocalPos");
			RockTech.NativeFieldInfoPtr_centerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "centerPos");
			RockTech.NativeFieldInfoPtr_zeroVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "zeroVerts");
			RockTech.NativeFieldInfoPtr_zeroed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "zeroed");
			RockTech.NativeFieldInfoPtr_layerOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "layerOverride");
			RockTech.NativeFieldInfoPtr_dynamic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "dynamic");
			RockTech.NativeFieldInfoPtr_prevLayerOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "prevLayerOverride");
			RockTech.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "pts");
			RockTech.NativeFieldInfoPtr_defPts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "defPts");
			RockTech.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "startFlag");
			RockTech.NativeFieldInfoPtr_paraPalMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "paraPalMesh");
			RockTech.NativeFieldInfoPtr_paraPalMeshMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "paraPalMeshMesh");
			RockTech.NativeFieldInfoPtr_paraPalRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "paraPalRend");
			RockTech.NativeFieldInfoPtr_topPalObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "topPalObj");
			RockTech.NativeFieldInfoPtr_topPalRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "topPalRender");
			RockTech.NativeFieldInfoPtr_layerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "layerName");
			RockTech.NativeFieldInfoPtr_visFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "visFlag");
			RockTech.NativeFieldInfoPtr_shadowVertsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "shadowVertsCount");
			RockTech.NativeFieldInfoPtr_botVertsLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "botVertsLength");
			RockTech.NativeFieldInfoPtr_matName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "matName");
			RockTech.NativeFieldInfoPtr_alwaysParalax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "alwaysParalax");
			RockTech.NativeFieldInfoPtr_added = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "added");
			RockTech.NativeFieldInfoPtr_madeSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "madeSender");
			RockTech.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "inited");
			RockTech.NativeFieldInfoPtr_offSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "offSet");
			RockTech.NativeFieldInfoPtr_amCrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "amCrate");
			RockTech.NativeFieldInfoPtr_paraZeroed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "paraZeroed");
			RockTech.NativeFieldInfoPtr_ang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "ang");
			RockTech.NativeFieldInfoPtr_topScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "topScale");
			RockTech.NativeFieldInfoPtr_botScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "botScale");
			RockTech.NativeFieldInfoPtr_xScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "xScaler");
			RockTech.NativeFieldInfoPtr_yScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "yScaler");
			RockTech.NativeFieldInfoPtr_topOffForever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "topOffForever");
			RockTech.NativeFieldInfoPtr_checkedTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "checkedTop");
			RockTech.NativeFieldInfoPtr_havePalMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "havePalMesh");
			RockTech.NativeFieldInfoPtr_meshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "meshIndex");
			RockTech.NativeFieldInfoPtr_freshMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTech>.NativeClassPtr, "freshMesh");
			RockTech.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666756);
			RockTech.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666757);
			RockTech.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666758);
			RockTech.NativeMethodInfoPtr_MyStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666759);
			RockTech.NativeMethodInfoPtr_InitShit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666760);
			RockTech.NativeMethodInfoPtr_AddToManager_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666761);
			RockTech.NativeMethodInfoPtr_RemoveFromManager_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666762);
			RockTech.NativeMethodInfoPtr_LayerOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666763);
			RockTech.NativeMethodInfoPtr_UnLayerOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666764);
			RockTech.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666765);
			RockTech.NativeMethodInfoPtr_OnLateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666766);
			RockTech.NativeMethodInfoPtr_ZeroStuff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666767);
			RockTech.NativeMethodInfoPtr_VisUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666768);
			RockTech.NativeMethodInfoPtr_Vis_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666769);
			RockTech.NativeMethodInfoPtr_Invis_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666770);
			RockTech.NativeMethodInfoPtr_GetTopVert_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666771);
			RockTech.NativeMethodInfoPtr_GetBotVert_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666772);
			RockTech.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTech>.NativeClassPtr, 100666773);
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x000AEC2C File Offset: 0x000ACE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80121, XrefRangeEnd = 80197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000AEC60 File Offset: 0x000ACE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80197, XrefRangeEnd = 80200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x000AEC94 File Offset: 0x000ACE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80200, XrefRangeEnd = 80201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000AECC8 File Offset: 0x000ACEC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80218, RefRangeEnd = 80219, XrefRangeStart = 80201, XrefRangeEnd = 80218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_MyStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000AECFC File Offset: 0x000ACEFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80422, RefRangeEnd = 80425, XrefRangeStart = 80219, XrefRangeEnd = 80422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_InitShit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x000AED30 File Offset: 0x000ACF30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80458, RefRangeEnd = 80460, XrefRangeStart = 80425, XrefRangeEnd = 80458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_AddToManager_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x000AED64 File Offset: 0x000ACF64
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 80500, RefRangeEnd = 80506, XrefRangeStart = 80460, XrefRangeEnd = 80500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_RemoveFromManager_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x000AED98 File Offset: 0x000ACF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80506, XrefRangeEnd = 80507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LayerOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_LayerOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x000AEDCC File Offset: 0x000ACFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80507, XrefRangeEnd = 80509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnLayerOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_UnLayerOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000AEE00 File Offset: 0x000AD000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80509, XrefRangeEnd = 80513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000AEE34 File Offset: 0x000AD034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80542, RefRangeEnd = 80543, XrefRangeStart = 80513, XrefRangeEnd = 80542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_OnLateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x000AEE68 File Offset: 0x000AD068
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 80603, RefRangeEnd = 80609, XrefRangeStart = 80543, XrefRangeEnd = 80603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZeroStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_ZeroStuff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x000AEE9C File Offset: 0x000AD09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80609, XrefRangeEnd = 80610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_VisUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x000AEED0 File Offset: 0x000AD0D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80631, RefRangeEnd = 80633, XrefRangeStart = 80610, XrefRangeEnd = 80631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Vis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_Vis_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x000AEF04 File Offset: 0x000AD104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80633, XrefRangeEnd = 80635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_Invis_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x000AEF38 File Offset: 0x000AD138
		[CallerCount(0)]
		public unsafe int GetTopVert(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_GetTopVert_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000AEF84 File Offset: 0x000AD184
		[CallerCount(0)]
		public unsafe int GetBotVert(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr_GetBotVert_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000AEFD0 File Offset: 0x000AD1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80635, XrefRangeEnd = 80638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RockTech()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RockTech>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTech.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x0001EA87 File Offset: 0x0001CC87
		public RockTech(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x000AF00C File Offset: 0x000AD20C
		// (set) Token: 0x06002C4B RID: 11339 RVA: 0x0001EA90 File Offset: 0x0001CC90
		public unsafe MeshFilter botMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x000AF03C File Offset: 0x000AD23C
		// (set) Token: 0x06002C4D RID: 11341 RVA: 0x0001EAAF File Offset: 0x0001CCAF
		public unsafe MeshFilter topMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x000AF06C File Offset: 0x000AD26C
		// (set) Token: 0x06002C4F RID: 11343 RVA: 0x0001EACE File Offset: 0x0001CCCE
		public unsafe Transform botTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x000AF09C File Offset: 0x000AD29C
		// (set) Token: 0x06002C51 RID: 11345 RVA: 0x0001EAED File Offset: 0x0001CCED
		public unsafe Transform topTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x000AF0CC File Offset: 0x000AD2CC
		// (set) Token: 0x06002C53 RID: 11347 RVA: 0x0001EB0C File Offset: 0x0001CD0C
		public unsafe MeshFilter shadowMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_shadowMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_shadowMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x000AF0FC File Offset: 0x000AD2FC
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x0001EB2B File Offset: 0x0001CD2B
		public unsafe Mesh shadowMeshMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_shadowMeshMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_shadowMeshMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x000AF12C File Offset: 0x000AD32C
		// (set) Token: 0x06002C57 RID: 11351 RVA: 0x0001EB4A File Offset: 0x0001CD4A
		public unsafe MeshRenderer botRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x000AF15C File Offset: 0x000AD35C
		// (set) Token: 0x06002C59 RID: 11353 RVA: 0x0001EB69 File Offset: 0x0001CD69
		public unsafe MeshRenderer topRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x000AF18C File Offset: 0x000AD38C
		// (set) Token: 0x06002C5B RID: 11355 RVA: 0x0001EB88 File Offset: 0x0001CD88
		public unsafe MeshRenderer shadowRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_shadowRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_shadowRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x000AF1BC File Offset: 0x000AD3BC
		// (set) Token: 0x06002C5D RID: 11357 RVA: 0x0001EBA7 File Offset: 0x0001CDA7
		public unsafe Vector2 debugPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_debugPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_debugPt)) = value;
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x000AF1E4 File Offset: 0x000AD3E4
		// (set) Token: 0x06002C5F RID: 11359 RVA: 0x0001EBC2 File Offset: 0x0001CDC2
		public unsafe Il2CppStructArray<int> tris
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_tris);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_tris), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x000AF214 File Offset: 0x000AD414
		// (set) Token: 0x06002C61 RID: 11361 RVA: 0x0001EBE1 File Offset: 0x0001CDE1
		public unsafe Il2CppStructArray<Vector2> uv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_uv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_uv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x000AF244 File Offset: 0x000AD444
		// (set) Token: 0x06002C63 RID: 11363 RVA: 0x0001EC00 File Offset: 0x0001CE00
		public unsafe float paralaxAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_paralaxAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_paralaxAmount)) = value;
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x000AF26C File Offset: 0x000AD46C
		// (set) Token: 0x06002C65 RID: 11365 RVA: 0x0001EC1B File Offset: 0x0001CE1B
		public unsafe Il2CppStructArray<Vector3> botMeshVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botMeshVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botMeshVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x000AF29C File Offset: 0x000AD49C
		// (set) Token: 0x06002C67 RID: 11367 RVA: 0x0001EC3A File Offset: 0x0001CE3A
		public unsafe Il2CppStructArray<Vector3> topMeshVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topMeshVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topMeshVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x000AF2CC File Offset: 0x000AD4CC
		// (set) Token: 0x06002C69 RID: 11369 RVA: 0x0001EC59 File Offset: 0x0001CE59
		public unsafe bool layerThisShit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_layerThisShit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_layerThisShit)) = value;
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x000AF2F4 File Offset: 0x000AD4F4
		// (set) Token: 0x06002C6B RID: 11371 RVA: 0x0001EC74 File Offset: 0x0001CE74
		public unsafe bool dontLayerMeDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_dontLayerMeDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_dontLayerMeDown)) = value;
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x000AF31C File Offset: 0x000AD51C
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x0001EC8F File Offset: 0x0001CE8F
		public unsafe Material palMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_palMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_palMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x000AF34C File Offset: 0x000AD54C
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x0001ECAE File Offset: 0x0001CEAE
		public unsafe Vector2 centerLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_centerLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_centerLocalPos)) = value;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x000AF374 File Offset: 0x000AD574
		// (set) Token: 0x06002C71 RID: 11377 RVA: 0x0001ECC9 File Offset: 0x0001CEC9
		public unsafe Vector2 centerPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_centerPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_centerPos)) = value;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x000AF39C File Offset: 0x000AD59C
		// (set) Token: 0x06002C73 RID: 11379 RVA: 0x0001ECE4 File Offset: 0x0001CEE4
		public unsafe List<Vector3> zeroVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_zeroVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_zeroVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06002C74 RID: 11380 RVA: 0x000AF3CC File Offset: 0x000AD5CC
		// (set) Token: 0x06002C75 RID: 11381 RVA: 0x0001ED03 File Offset: 0x0001CF03
		public unsafe bool zeroed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_zeroed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_zeroed)) = value;
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x000AF3F4 File Offset: 0x000AD5F4
		// (set) Token: 0x06002C77 RID: 11383 RVA: 0x0001ED1E File Offset: 0x0001CF1E
		public unsafe bool layerOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_layerOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_layerOverride)) = value;
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x000AF41C File Offset: 0x000AD61C
		// (set) Token: 0x06002C79 RID: 11385 RVA: 0x0001ED39 File Offset: 0x0001CF39
		public unsafe bool dynamic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_dynamic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_dynamic)) = value;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x000AF444 File Offset: 0x000AD644
		// (set) Token: 0x06002C7B RID: 11387 RVA: 0x0001ED54 File Offset: 0x0001CF54
		public unsafe bool prevLayerOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_prevLayerOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_prevLayerOverride)) = value;
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06002C7C RID: 11388 RVA: 0x000AF46C File Offset: 0x000AD66C
		// (set) Token: 0x06002C7D RID: 11389 RVA: 0x0001ED6F File Offset: 0x0001CF6F
		public unsafe Il2CppStructArray<Vector2> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x000AF49C File Offset: 0x000AD69C
		// (set) Token: 0x06002C7F RID: 11391 RVA: 0x0001ED8E File Offset: 0x0001CF8E
		public unsafe Il2CppStructArray<Vector2> defPts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_defPts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_defPts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x000AF4CC File Offset: 0x000AD6CC
		// (set) Token: 0x06002C81 RID: 11393 RVA: 0x0001EDAD File Offset: 0x0001CFAD
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x000AF4F4 File Offset: 0x000AD6F4
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x0001EDC8 File Offset: 0x0001CFC8
		public unsafe MeshFilter paraPalMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_paraPalMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_paraPalMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x000AF524 File Offset: 0x000AD724
		// (set) Token: 0x06002C85 RID: 11397 RVA: 0x0001EDE7 File Offset: 0x0001CFE7
		public unsafe Mesh paraPalMeshMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_paraPalMeshMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_paraPalMeshMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x000AF554 File Offset: 0x000AD754
		// (set) Token: 0x06002C87 RID: 11399 RVA: 0x0001EE06 File Offset: 0x0001D006
		public unsafe MeshRenderer paraPalRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_paraPalRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_paraPalRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06002C88 RID: 11400 RVA: 0x000AF584 File Offset: 0x000AD784
		// (set) Token: 0x06002C89 RID: 11401 RVA: 0x0001EE25 File Offset: 0x0001D025
		public unsafe Transform topPalObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topPalObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topPalObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x000AF5B4 File Offset: 0x000AD7B4
		// (set) Token: 0x06002C8B RID: 11403 RVA: 0x0001EE44 File Offset: 0x0001D044
		public unsafe Renderer topPalRender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topPalRender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topPalRender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06002C8C RID: 11404 RVA: 0x000AF5E4 File Offset: 0x000AD7E4
		// (set) Token: 0x06002C8D RID: 11405 RVA: 0x0001EE63 File Offset: 0x0001D063
		public unsafe int layerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_layerName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_layerName)) = value;
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06002C8E RID: 11406 RVA: 0x000AF60C File Offset: 0x000AD80C
		// (set) Token: 0x06002C8F RID: 11407 RVA: 0x0001EE7E File Offset: 0x0001D07E
		public unsafe bool visFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_visFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_visFlag)) = value;
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06002C90 RID: 11408 RVA: 0x000AF634 File Offset: 0x000AD834
		// (set) Token: 0x06002C91 RID: 11409 RVA: 0x0001EE99 File Offset: 0x0001D099
		public unsafe int shadowVertsCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_shadowVertsCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_shadowVertsCount)) = value;
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06002C92 RID: 11410 RVA: 0x000AF65C File Offset: 0x000AD85C
		// (set) Token: 0x06002C93 RID: 11411 RVA: 0x0001EEB4 File Offset: 0x0001D0B4
		public unsafe int botVertsLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botVertsLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botVertsLength)) = value;
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x000AF684 File Offset: 0x000AD884
		// (set) Token: 0x06002C95 RID: 11413 RVA: 0x0001EECF File Offset: 0x0001D0CF
		public unsafe int matName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_matName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_matName)) = value;
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06002C96 RID: 11414 RVA: 0x000AF6AC File Offset: 0x000AD8AC
		// (set) Token: 0x06002C97 RID: 11415 RVA: 0x0001EEEA File Offset: 0x0001D0EA
		public unsafe bool alwaysParalax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_alwaysParalax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_alwaysParalax)) = value;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x000AF6D4 File Offset: 0x000AD8D4
		// (set) Token: 0x06002C99 RID: 11417 RVA: 0x0001EF05 File Offset: 0x0001D105
		public unsafe bool added
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_added);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_added)) = value;
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06002C9A RID: 11418 RVA: 0x000AF6FC File Offset: 0x000AD8FC
		// (set) Token: 0x06002C9B RID: 11419 RVA: 0x0001EF20 File Offset: 0x0001D120
		public unsafe bool madeSender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_madeSender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_madeSender)) = value;
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x000AF724 File Offset: 0x000AD924
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x0001EF3B File Offset: 0x0001D13B
		public unsafe bool inited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_inited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_inited)) = value;
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x000AF74C File Offset: 0x000AD94C
		// (set) Token: 0x06002C9F RID: 11423 RVA: 0x0001EF56 File Offset: 0x0001D156
		public unsafe Vector2 offSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_offSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_offSet)) = value;
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x000AF774 File Offset: 0x000AD974
		// (set) Token: 0x06002CA1 RID: 11425 RVA: 0x0001EF71 File Offset: 0x0001D171
		public unsafe bool amCrate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_amCrate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_amCrate)) = value;
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x000AF79C File Offset: 0x000AD99C
		// (set) Token: 0x06002CA3 RID: 11427 RVA: 0x0001EF8C File Offset: 0x0001D18C
		public unsafe bool paraZeroed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_paraZeroed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_paraZeroed)) = value;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06002CA4 RID: 11428 RVA: 0x000AF7C4 File Offset: 0x000AD9C4
		// (set) Token: 0x06002CA5 RID: 11429 RVA: 0x0001EFA7 File Offset: 0x0001D1A7
		public unsafe float ang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_ang);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_ang)) = value;
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x000AF7EC File Offset: 0x000AD9EC
		// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x0001EFC2 File Offset: 0x0001D1C2
		public unsafe Vector2 topScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topScale)) = value;
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x000AF814 File Offset: 0x000ADA14
		// (set) Token: 0x06002CA9 RID: 11433 RVA: 0x0001EFDD File Offset: 0x0001D1DD
		public unsafe Vector2 botScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_botScale)) = value;
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x000AF83C File Offset: 0x000ADA3C
		// (set) Token: 0x06002CAB RID: 11435 RVA: 0x0001EFF8 File Offset: 0x0001D1F8
		public unsafe float xScaler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_xScaler);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_xScaler)) = value;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x000AF864 File Offset: 0x000ADA64
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x0001F013 File Offset: 0x0001D213
		public unsafe float yScaler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_yScaler);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_yScaler)) = value;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x000AF88C File Offset: 0x000ADA8C
		// (set) Token: 0x06002CAF RID: 11439 RVA: 0x0001F02E File Offset: 0x0001D22E
		public unsafe bool topOffForever
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topOffForever);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_topOffForever)) = value;
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x000AF8B4 File Offset: 0x000ADAB4
		// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x0001F049 File Offset: 0x0001D249
		public unsafe bool checkedTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_checkedTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_checkedTop)) = value;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x000AF8DC File Offset: 0x000ADADC
		// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x0001F064 File Offset: 0x0001D264
		public unsafe bool havePalMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_havePalMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_havePalMesh)) = value;
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x000AF904 File Offset: 0x000ADB04
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x0001F07F File Offset: 0x0001D27F
		public unsafe int meshIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_meshIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_meshIndex)) = value;
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x000AF92C File Offset: 0x000ADB2C
		// (set) Token: 0x06002CB7 RID: 11447 RVA: 0x0001F09A File Offset: 0x0001D29A
		public unsafe bool freshMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_freshMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTech.NativeFieldInfoPtr_freshMesh)) = value;
			}
		}

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeFieldInfoPtr_botMesh;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeFieldInfoPtr_topMesh;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeFieldInfoPtr_botTrans;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeFieldInfoPtr_topTrans;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeFieldInfoPtr_shadowMesh;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeFieldInfoPtr_shadowMeshMesh;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeFieldInfoPtr_botRend;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeFieldInfoPtr_topRend;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeFieldInfoPtr_shadowRend;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeFieldInfoPtr_debugPt;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeFieldInfoPtr_tris;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeFieldInfoPtr_paralaxAmount;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeFieldInfoPtr_botMeshVerts;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeFieldInfoPtr_topMeshVerts;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeFieldInfoPtr_layerThisShit;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeFieldInfoPtr_dontLayerMeDown;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeFieldInfoPtr_palMat;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeFieldInfoPtr_centerLocalPos;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeFieldInfoPtr_centerPos;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeFieldInfoPtr_zeroVerts;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeFieldInfoPtr_zeroed;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeFieldInfoPtr_layerOverride;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeFieldInfoPtr_dynamic;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeFieldInfoPtr_prevLayerOverride;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeFieldInfoPtr_defPts;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeFieldInfoPtr_paraPalMesh;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeFieldInfoPtr_paraPalMeshMesh;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeFieldInfoPtr_paraPalRend;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeFieldInfoPtr_topPalObj;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeFieldInfoPtr_topPalRender;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeFieldInfoPtr_layerName;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeFieldInfoPtr_visFlag;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeFieldInfoPtr_shadowVertsCount;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeFieldInfoPtr_botVertsLength;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeFieldInfoPtr_matName;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeFieldInfoPtr_alwaysParalax;

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeFieldInfoPtr_added;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeFieldInfoPtr_madeSender;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeFieldInfoPtr_offSet;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeFieldInfoPtr_amCrate;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeFieldInfoPtr_paraZeroed;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeFieldInfoPtr_ang;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeFieldInfoPtr_topScale;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeFieldInfoPtr_botScale;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeFieldInfoPtr_xScaler;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeFieldInfoPtr_yScaler;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeFieldInfoPtr_topOffForever;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeFieldInfoPtr_checkedTop;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeFieldInfoPtr_havePalMesh;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeFieldInfoPtr_meshIndex;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeFieldInfoPtr_freshMesh;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeMethodInfoPtr_MyStart_Public_Void_0;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeMethodInfoPtr_InitShit_Public_Void_0;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeMethodInfoPtr_AddToManager_Private_Void_0;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromManager_Private_Void_0;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeMethodInfoPtr_LayerOverride_Public_Void_0;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_UnLayerOverride_Public_Void_0;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Void_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr_ZeroStuff_Private_Void_0;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr_VisUp_Private_Void_0;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeMethodInfoPtr_Vis_Public_Void_0;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr_Invis_Public_Void_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeMethodInfoPtr_GetTopVert_Public_Int32_Int32_0;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr_GetBotVert_Public_Int32_Int32_0;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
