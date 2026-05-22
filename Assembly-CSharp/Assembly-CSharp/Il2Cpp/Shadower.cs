using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000186 RID: 390
	public class Shadower : MonoBehaviour
	{
		// Token: 0x06002E3A RID: 11834 RVA: 0x000B3C84 File Offset: 0x000B1E84
		// Note: this type is marked as 'beforefieldinit'.
		static Shadower()
		{
			Il2CppClassPointerStore<Shadower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Shadower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shadower>.NativeClassPtr);
			Shadower.NativeFieldInfoPtr_dynamic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "dynamic");
			Shadower.NativeFieldInfoPtr_mesher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "mesher");
			Shadower.NativeFieldInfoPtr_mesherMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "mesherMesh");
			Shadower.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "pts");
			Shadower.NativeFieldInfoPtr_midPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "midPos");
			Shadower.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "sprite");
			Shadower.NativeFieldInfoPtr_meshRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "meshRend");
			Shadower.NativeFieldInfoPtr_palMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "palMat");
			Shadower.NativeFieldInfoPtr_manualPalMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "manualPalMat");
			Shadower.NativeFieldInfoPtr_palRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "palRend");
			Shadower.NativeFieldInfoPtr_palMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "palMesh");
			Shadower.NativeFieldInfoPtr_palMeshMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "palMeshMesh");
			Shadower.NativeFieldInfoPtr_palSpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "palSpr");
			Shadower.NativeFieldInfoPtr_shadowLayerer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "shadowLayerer");
			Shadower.NativeFieldInfoPtr_camControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "camControl");
			Shadower.NativeFieldInfoPtr_dontLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "dontLayer");
			Shadower.NativeFieldInfoPtr_imaBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "imaBox");
			Shadower.NativeFieldInfoPtr_pPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "pPos");
			Shadower.NativeFieldInfoPtr_tgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "tgs");
			Shadower.NativeFieldInfoPtr_palIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "palIndex");
			Shadower.NativeFieldInfoPtr_visFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "visFlag");
			Shadower.NativeFieldInfoPtr_visUpTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "visUpTimer");
			Shadower.NativeFieldInfoPtr_offSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "offSet");
			Shadower.NativeFieldInfoPtr_mat1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "mat1");
			Shadower.NativeFieldInfoPtr_mat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "mat2");
			Shadower.NativeFieldInfoPtr_quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "quad");
			Shadower.NativeFieldInfoPtr_doorwayCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "doorwayCurve");
			Shadower.NativeFieldInfoPtr_myCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "myCol");
			Shadower.NativeFieldInfoPtr_shadowDad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "shadowDad");
			Shadower.NativeFieldInfoPtr_pleasePal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "pleasePal");
			Shadower.NativeFieldInfoPtr_pleaseDontPal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "pleaseDontPal");
			Shadower.NativeFieldInfoPtr_dontPalBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "dontPalBase");
			Shadower.NativeFieldInfoPtr_myBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "myBounds");
			Shadower.NativeFieldInfoPtr_matNameToInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "matNameToInt");
			Shadower.NativeFieldInfoPtr_enterable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "enterable");
			Shadower.NativeFieldInfoPtr_isMadeInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "isMadeInvisible");
			Shadower.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "startFlag");
			Shadower.NativeFieldInfoPtr_added = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "added");
			Shadower.NativeFieldInfoPtr_hasPalMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "hasPalMesh");
			Shadower.NativeFieldInfoPtr_mesherIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "mesherIndex");
			Shadower.NativeFieldInfoPtr_dontParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadower>.NativeClassPtr, "dontParent");
			Shadower.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666900);
			Shadower.NativeMethodInfoPtr_ResetBounds_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666901);
			Shadower.NativeMethodInfoPtr_UpdatePalMat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666902);
			Shadower.NativeMethodInfoPtr_MyStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666903);
			Shadower.NativeMethodInfoPtr_OnLateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666904);
			Shadower.NativeMethodInfoPtr_SetPalMeshVerts_Private_Void_NativeSlice_1_MeshPt_NativeSlice_1_MeshPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666905);
			Shadower.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666906);
			Shadower.NativeMethodInfoPtr_BecameInvisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666907);
			Shadower.NativeMethodInfoPtr_OnBecameVisible_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666908);
			Shadower.NativeMethodInfoPtr_OnBecameInvisible_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666909);
			Shadower.NativeMethodInfoPtr_VisUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666910);
			Shadower.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666911);
			Shadower.NativeMethodInfoPtr_AddToManager_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666912);
			Shadower.NativeMethodInfoPtr_RemoveFromManager_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666913);
			Shadower.NativeMethodInfoPtr_UpdatePts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666914);
			Shadower.NativeMethodInfoPtr_UpdateVerts_Public_Void_NativeSlice_1_MeshPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666915);
			Shadower.NativeMethodInfoPtr_DoorwayShit_Public_Void_NativeSlice_1_MeshPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666916);
			Shadower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadower>.NativeClassPtr, 100666917);
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x000B4150 File Offset: 0x000B2350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81665, XrefRangeEnd = 81710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x000B4184 File Offset: 0x000B2384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81764, RefRangeEnd = 81765, XrefRangeStart = 81710, XrefRangeEnd = 81764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBounds(Mesh msh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_ResetBounds_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x000B41C8 File Offset: 0x000B23C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81814, RefRangeEnd = 81815, XrefRangeStart = 81765, XrefRangeEnd = 81814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePalMat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_UpdatePalMat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x000B41FC File Offset: 0x000B23FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81815, XrefRangeEnd = 82143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_MyStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000B4230 File Offset: 0x000B2430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82150, RefRangeEnd = 82151, XrefRangeStart = 82143, XrefRangeEnd = 82150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_OnLateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x000B4264 File Offset: 0x000B2464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82151, XrefRangeEnd = 82165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPalMeshVerts(NativeSlice<MeshPt> palMesherVerts, NativeSlice<MeshPt> mesherVerts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(palMesherVerts));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(mesherVerts));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_SetPalMeshVerts_Private_Void_NativeSlice_1_MeshPt_NativeSlice_1_MeshPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x000B42C4 File Offset: 0x000B24C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82165, XrefRangeEnd = 82209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x000B42F8 File Offset: 0x000B24F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82275, RefRangeEnd = 82277, XrefRangeStart = 82209, XrefRangeEnd = 82275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BecameInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_BecameInvisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x000B432C File Offset: 0x000B252C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82277, XrefRangeEnd = 82278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBecameVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_OnBecameVisible_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x000B4360 File Offset: 0x000B2560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82278, XrefRangeEnd = 82280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBecameInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_OnBecameInvisible_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x000B4394 File Offset: 0x000B2594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82280, XrefRangeEnd = 82281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_VisUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x000B43C8 File Offset: 0x000B25C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82281, XrefRangeEnd = 82317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x000B43FC File Offset: 0x000B25FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82357, RefRangeEnd = 82359, XrefRangeStart = 82317, XrefRangeEnd = 82357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_AddToManager_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x000B4430 File Offset: 0x000B2630
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82410, RefRangeEnd = 82414, XrefRangeStart = 82359, XrefRangeEnd = 82410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_RemoveFromManager_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x000B4464 File Offset: 0x000B2664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82446, RefRangeEnd = 82447, XrefRangeStart = 82414, XrefRangeEnd = 82446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_UpdatePts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x000B4498 File Offset: 0x000B2698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82447, XrefRangeEnd = 82491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVerts(NativeSlice<MeshPt> mesherVerts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(mesherVerts));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_UpdateVerts_Public_Void_NativeSlice_1_MeshPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x000B44E0 File Offset: 0x000B26E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82491, XrefRangeEnd = 82561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoorwayShit(NativeSlice<MeshPt> mesherVerts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(mesherVerts));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr_DoorwayShit_Public_Void_NativeSlice_1_MeshPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x000B4528 File Offset: 0x000B2728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82561, XrefRangeEnd = 82564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shadower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shadower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x0001FF23 File Offset: 0x0001E123
		public Shadower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x000B4564 File Offset: 0x000B2764
		// (set) Token: 0x06002E4F RID: 11855 RVA: 0x0001FF2C File Offset: 0x0001E12C
		public unsafe bool dynamic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_dynamic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_dynamic)) = value;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x000B458C File Offset: 0x000B278C
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x0001FF47 File Offset: 0x0001E147
		public unsafe MeshFilter mesher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_mesher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_mesher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x000B45BC File Offset: 0x000B27BC
		// (set) Token: 0x06002E53 RID: 11859 RVA: 0x0001FF66 File Offset: 0x0001E166
		public unsafe Mesh mesherMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_mesherMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_mesherMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x000B45EC File Offset: 0x000B27EC
		// (set) Token: 0x06002E55 RID: 11861 RVA: 0x0001FF85 File Offset: 0x0001E185
		public unsafe Il2CppStructArray<Vector2> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06002E56 RID: 11862 RVA: 0x000B461C File Offset: 0x000B281C
		// (set) Token: 0x06002E57 RID: 11863 RVA: 0x0001FFA4 File Offset: 0x0001E1A4
		public unsafe Vector2 midPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_midPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_midPos)) = value;
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06002E58 RID: 11864 RVA: 0x000B4644 File Offset: 0x000B2844
		// (set) Token: 0x06002E59 RID: 11865 RVA: 0x0001FFBF File Offset: 0x0001E1BF
		public unsafe Renderer sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06002E5A RID: 11866 RVA: 0x000B4674 File Offset: 0x000B2874
		// (set) Token: 0x06002E5B RID: 11867 RVA: 0x0001FFDE File Offset: 0x0001E1DE
		public unsafe MeshRenderer meshRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_meshRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_meshRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06002E5C RID: 11868 RVA: 0x000B46A4 File Offset: 0x000B28A4
		// (set) Token: 0x06002E5D RID: 11869 RVA: 0x0001FFFD File Offset: 0x0001E1FD
		public unsafe Material palMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x000B46D4 File Offset: 0x000B28D4
		// (set) Token: 0x06002E5F RID: 11871 RVA: 0x0002001C File Offset: 0x0001E21C
		public unsafe bool manualPalMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_manualPalMat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_manualPalMat)) = value;
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06002E60 RID: 11872 RVA: 0x000B46FC File Offset: 0x000B28FC
		// (set) Token: 0x06002E61 RID: 11873 RVA: 0x00020037 File Offset: 0x0001E237
		public unsafe MeshRenderer palRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x000B472C File Offset: 0x000B292C
		// (set) Token: 0x06002E63 RID: 11875 RVA: 0x00020056 File Offset: 0x0001E256
		public unsafe MeshFilter palMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x000B475C File Offset: 0x000B295C
		// (set) Token: 0x06002E65 RID: 11877 RVA: 0x00020075 File Offset: 0x0001E275
		public unsafe Mesh palMeshMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palMeshMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palMeshMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x000B478C File Offset: 0x000B298C
		// (set) Token: 0x06002E67 RID: 11879 RVA: 0x00020094 File Offset: 0x0001E294
		public unsafe Renderer palSpr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palSpr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palSpr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06002E68 RID: 11880 RVA: 0x000B47BC File Offset: 0x000B29BC
		// (set) Token: 0x06002E69 RID: 11881 RVA: 0x000200B3 File Offset: 0x0001E2B3
		public unsafe ShadowLayerer shadowLayerer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_shadowLayerer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShadowLayerer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_shadowLayerer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x000B47EC File Offset: 0x000B29EC
		// (set) Token: 0x06002E6B RID: 11883 RVA: 0x000200D2 File Offset: 0x0001E2D2
		public unsafe CamControl camControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_camControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_camControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06002E6C RID: 11884 RVA: 0x000B481C File Offset: 0x000B2A1C
		// (set) Token: 0x06002E6D RID: 11885 RVA: 0x000200F1 File Offset: 0x0001E2F1
		public unsafe bool dontLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_dontLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_dontLayer)) = value;
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06002E6E RID: 11886 RVA: 0x000B4844 File Offset: 0x000B2A44
		// (set) Token: 0x06002E6F RID: 11887 RVA: 0x0002010C File Offset: 0x0001E30C
		public unsafe bool imaBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_imaBox);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_imaBox)) = value;
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06002E70 RID: 11888 RVA: 0x000B486C File Offset: 0x000B2A6C
		// (set) Token: 0x06002E71 RID: 11889 RVA: 0x00020127 File Offset: 0x0001E327
		public unsafe Vector2 pPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_pPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_pPos)) = value;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06002E72 RID: 11890 RVA: 0x000B4894 File Offset: 0x000B2A94
		// (set) Token: 0x06002E73 RID: 11891 RVA: 0x00020142 File Offset: 0x0001E342
		public unsafe Tags tgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_tgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_tgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06002E74 RID: 11892 RVA: 0x000B48C4 File Offset: 0x000B2AC4
		// (set) Token: 0x06002E75 RID: 11893 RVA: 0x00020161 File Offset: 0x0001E361
		public unsafe int palIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_palIndex)) = value;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06002E76 RID: 11894 RVA: 0x000B48EC File Offset: 0x000B2AEC
		// (set) Token: 0x06002E77 RID: 11895 RVA: 0x0002017C File Offset: 0x0001E37C
		public unsafe bool visFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_visFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_visFlag)) = value;
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x000B4914 File Offset: 0x000B2B14
		// (set) Token: 0x06002E79 RID: 11897 RVA: 0x00020197 File Offset: 0x0001E397
		public unsafe int visUpTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_visUpTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_visUpTimer)) = value;
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06002E7A RID: 11898 RVA: 0x000B493C File Offset: 0x000B2B3C
		// (set) Token: 0x06002E7B RID: 11899 RVA: 0x000201B2 File Offset: 0x0001E3B2
		public unsafe float offSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_offSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_offSet)) = value;
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06002E7C RID: 11900 RVA: 0x000B4964 File Offset: 0x000B2B64
		// (set) Token: 0x06002E7D RID: 11901 RVA: 0x000201CD File Offset: 0x0001E3CD
		public unsafe Material mat1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_mat1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_mat1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06002E7E RID: 11902 RVA: 0x000B4994 File Offset: 0x000B2B94
		// (set) Token: 0x06002E7F RID: 11903 RVA: 0x000201EC File Offset: 0x0001E3EC
		public unsafe Material mat2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_mat2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_mat2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x000B49C4 File Offset: 0x000B2BC4
		// (set) Token: 0x06002E81 RID: 11905 RVA: 0x0002020B File Offset: 0x0001E40B
		public unsafe GameObject quad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_quad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_quad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06002E82 RID: 11906 RVA: 0x000B49F4 File Offset: 0x000B2BF4
		// (set) Token: 0x06002E83 RID: 11907 RVA: 0x0002022A File Offset: 0x0001E42A
		public unsafe AnimationCurve doorwayCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_doorwayCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_doorwayCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06002E84 RID: 11908 RVA: 0x000B4A24 File Offset: 0x000B2C24
		// (set) Token: 0x06002E85 RID: 11909 RVA: 0x00020249 File Offset: 0x0001E449
		public unsafe Collider2D myCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_myCol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_myCol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x000B4A54 File Offset: 0x000B2C54
		// (set) Token: 0x06002E87 RID: 11911 RVA: 0x00020268 File Offset: 0x0001E468
		public unsafe Shadower shadowDad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_shadowDad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shadower>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_shadowDad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06002E88 RID: 11912 RVA: 0x000B4A84 File Offset: 0x000B2C84
		// (set) Token: 0x06002E89 RID: 11913 RVA: 0x00020287 File Offset: 0x0001E487
		public unsafe bool pleasePal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_pleasePal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_pleasePal)) = value;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06002E8A RID: 11914 RVA: 0x000B4AAC File Offset: 0x000B2CAC
		// (set) Token: 0x06002E8B RID: 11915 RVA: 0x000202A2 File Offset: 0x0001E4A2
		public unsafe bool pleaseDontPal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_pleaseDontPal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_pleaseDontPal)) = value;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06002E8C RID: 11916 RVA: 0x000B4AD4 File Offset: 0x000B2CD4
		// (set) Token: 0x06002E8D RID: 11917 RVA: 0x000202BD File Offset: 0x0001E4BD
		public unsafe bool dontPalBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_dontPalBase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_dontPalBase)) = value;
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06002E8E RID: 11918 RVA: 0x000B4AFC File Offset: 0x000B2CFC
		// (set) Token: 0x06002E8F RID: 11919 RVA: 0x000202D8 File Offset: 0x0001E4D8
		public unsafe Bounds myBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_myBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_myBounds)) = value;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06002E90 RID: 11920 RVA: 0x000B4B24 File Offset: 0x000B2D24
		// (set) Token: 0x06002E91 RID: 11921 RVA: 0x000202F3 File Offset: 0x0001E4F3
		public unsafe int matNameToInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_matNameToInt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_matNameToInt)) = value;
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06002E92 RID: 11922 RVA: 0x000B4B4C File Offset: 0x000B2D4C
		// (set) Token: 0x06002E93 RID: 11923 RVA: 0x0002030E File Offset: 0x0001E50E
		public unsafe bool enterable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_enterable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_enterable)) = value;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06002E94 RID: 11924 RVA: 0x000B4B74 File Offset: 0x000B2D74
		// (set) Token: 0x06002E95 RID: 11925 RVA: 0x00020329 File Offset: 0x0001E529
		public unsafe bool isMadeInvisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_isMadeInvisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_isMadeInvisible)) = value;
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x000B4B9C File Offset: 0x000B2D9C
		// (set) Token: 0x06002E97 RID: 11927 RVA: 0x00020344 File Offset: 0x0001E544
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x000B4BC4 File Offset: 0x000B2DC4
		// (set) Token: 0x06002E99 RID: 11929 RVA: 0x0002035F File Offset: 0x0001E55F
		public unsafe bool added
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_added);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_added)) = value;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x000B4BEC File Offset: 0x000B2DEC
		// (set) Token: 0x06002E9B RID: 11931 RVA: 0x0002037A File Offset: 0x0001E57A
		public unsafe bool hasPalMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_hasPalMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_hasPalMesh)) = value;
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06002E9C RID: 11932 RVA: 0x000B4C14 File Offset: 0x000B2E14
		// (set) Token: 0x06002E9D RID: 11933 RVA: 0x00020395 File Offset: 0x0001E595
		public unsafe int mesherIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_mesherIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_mesherIndex)) = value;
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06002E9E RID: 11934 RVA: 0x000B4C3C File Offset: 0x000B2E3C
		// (set) Token: 0x06002E9F RID: 11935 RVA: 0x000203B0 File Offset: 0x0001E5B0
		public unsafe bool dontParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_dontParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadower.NativeFieldInfoPtr_dontParent)) = value;
			}
		}

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeFieldInfoPtr_dynamic;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeFieldInfoPtr_mesher;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeFieldInfoPtr_mesherMesh;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeFieldInfoPtr_midPos;

		// Token: 0x04001B37 RID: 6967
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeFieldInfoPtr_meshRend;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeFieldInfoPtr_palMat;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeFieldInfoPtr_manualPalMat;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeFieldInfoPtr_palRend;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeFieldInfoPtr_palMesh;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeFieldInfoPtr_palMeshMesh;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeFieldInfoPtr_palSpr;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeFieldInfoPtr_shadowLayerer;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeFieldInfoPtr_camControl;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeFieldInfoPtr_dontLayer;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeFieldInfoPtr_imaBox;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeFieldInfoPtr_pPos;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeFieldInfoPtr_tgs;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeFieldInfoPtr_palIndex;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeFieldInfoPtr_visFlag;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeFieldInfoPtr_visUpTimer;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeFieldInfoPtr_offSet;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeFieldInfoPtr_mat1;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeFieldInfoPtr_mat2;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeFieldInfoPtr_quad;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeFieldInfoPtr_doorwayCurve;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeFieldInfoPtr_myCol;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeFieldInfoPtr_shadowDad;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeFieldInfoPtr_pleasePal;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeFieldInfoPtr_pleaseDontPal;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeFieldInfoPtr_dontPalBase;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeFieldInfoPtr_myBounds;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeFieldInfoPtr_matNameToInt;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeFieldInfoPtr_enterable;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeFieldInfoPtr_isMadeInvisible;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeFieldInfoPtr_added;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeFieldInfoPtr_hasPalMesh;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeFieldInfoPtr_mesherIndex;

		// Token: 0x04001B5A RID: 7002
		private static readonly IntPtr NativeFieldInfoPtr_dontParent;

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeMethodInfoPtr_ResetBounds_Public_Void_Mesh_0;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePalMat_Private_Void_0;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeMethodInfoPtr_MyStart_Public_Void_0;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Void_0;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeMethodInfoPtr_SetPalMeshVerts_Private_Void_NativeSlice_1_MeshPt_NativeSlice_1_MeshPt_0;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeMethodInfoPtr_BecameInvisible_Public_Void_0;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeMethodInfoPtr_OnBecameVisible_Private_Void_0;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeMethodInfoPtr_OnBecameInvisible_Private_Void_0;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr_VisUp_Public_Void_0;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeMethodInfoPtr_AddToManager_Private_Void_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromManager_Private_Void_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePts_Public_Void_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVerts_Public_Void_NativeSlice_1_MeshPt_0;

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeMethodInfoPtr_DoorwayShit_Public_Void_NativeSlice_1_MeshPt_0;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
