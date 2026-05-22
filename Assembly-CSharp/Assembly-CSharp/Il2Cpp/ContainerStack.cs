using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000AD RID: 173
	public class ContainerStack : MonoBehaviour
	{
		// Token: 0x0600151B RID: 5403 RVA: 0x00070064 File Offset: 0x0006E264
		// Note: this type is marked as 'beforefieldinit'.
		static ContainerStack()
		{
			Il2CppClassPointerStore<ContainerStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ContainerStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr);
			ContainerStack.NativeFieldInfoPtr_mesher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "mesher");
			ContainerStack.NativeFieldInfoPtr_mesherRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "mesherRend");
			ContainerStack.NativeFieldInfoPtr_stackHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "stackHeight");
			ContainerStack.NativeFieldInfoPtr_myMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "myMeshes");
			ContainerStack.NativeFieldInfoPtr_myRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "myRends");
			ContainerStack.NativeFieldInfoPtr_palMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "palMesh");
			ContainerStack.NativeFieldInfoPtr_palRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "palRend");
			ContainerStack.NativeFieldInfoPtr_palMeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "palMeshIndex");
			ContainerStack.NativeFieldInfoPtr_rocky = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "rocky");
			ContainerStack.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "startFlag");
			ContainerStack.NativeFieldInfoPtr_shadowCheckTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "shadowCheckTimer");
			ContainerStack.NativeFieldInfoPtr_topVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "topVerts");
			ContainerStack.NativeFieldInfoPtr_zeroed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "zeroed");
			ContainerStack.NativeFieldInfoPtr_shadowVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "shadowVerts");
			ContainerStack.NativeFieldInfoPtr_botRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "botRends");
			ContainerStack.NativeFieldInfoPtr_setMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "setMats");
			ContainerStack.NativeFieldInfoPtr_startRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "startRan");
			ContainerStack.NativeFieldInfoPtr_meshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "meshIndex");
			ContainerStack.NativeFieldInfoPtr_freshMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, "freshMesh");
			ContainerStack.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, 100665068);
			ContainerStack.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, 100665069);
			ContainerStack.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, 100665070);
			ContainerStack.NativeMethodInfoPtr_Zero_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, 100665071);
			ContainerStack.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, 100665072);
			ContainerStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr, 100665073);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00070288 File Offset: 0x0006E488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53329, XrefRangeEnd = 53433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerStack.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000702BC File Offset: 0x0006E4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53433, XrefRangeEnd = 53449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerStack.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x000702F0 File Offset: 0x0006E4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53449, XrefRangeEnd = 53450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerStack.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00070324 File Offset: 0x0006E524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53478, RefRangeEnd = 53479, XrefRangeStart = 53450, XrefRangeEnd = 53478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Zero()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerStack.NativeMethodInfoPtr_Zero_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00070358 File Offset: 0x0006E558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53479, XrefRangeEnd = 53836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerStack.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0007038C File Offset: 0x0006E58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContainerStack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerStack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0000F55E File Offset: 0x0000D75E
		public ContainerStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x000703C8 File Offset: 0x0006E5C8
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x0000F567 File Offset: 0x0000D767
		public unsafe MeshFilter mesher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_mesher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_mesher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x000703F8 File Offset: 0x0006E5F8
		// (set) Token: 0x06001526 RID: 5414 RVA: 0x0000F586 File Offset: 0x0000D786
		public unsafe MeshRenderer mesherRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_mesherRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_mesherRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x00070428 File Offset: 0x0006E628
		// (set) Token: 0x06001528 RID: 5416 RVA: 0x0000F5A5 File Offset: 0x0000D7A5
		public unsafe int stackHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_stackHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_stackHeight)) = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x00070450 File Offset: 0x0006E650
		// (set) Token: 0x0600152A RID: 5418 RVA: 0x0000F5C0 File Offset: 0x0000D7C0
		public unsafe Il2CppReferenceArray<MeshFilter> myMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_myMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_myMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x00070480 File Offset: 0x0006E680
		// (set) Token: 0x0600152C RID: 5420 RVA: 0x0000F5DF File Offset: 0x0000D7DF
		public unsafe Il2CppReferenceArray<MeshRenderer> myRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_myRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_myRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x000704B0 File Offset: 0x0006E6B0
		// (set) Token: 0x0600152E RID: 5422 RVA: 0x0000F5FE File Offset: 0x0000D7FE
		public unsafe MeshFilter palMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_palMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_palMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x000704E0 File Offset: 0x0006E6E0
		// (set) Token: 0x06001530 RID: 5424 RVA: 0x0000F61D File Offset: 0x0000D81D
		public unsafe MeshRenderer palRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_palRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_palRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x00070510 File Offset: 0x0006E710
		// (set) Token: 0x06001532 RID: 5426 RVA: 0x0000F63C File Offset: 0x0000D83C
		public unsafe int palMeshIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_palMeshIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_palMeshIndex)) = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x00070538 File Offset: 0x0006E738
		// (set) Token: 0x06001534 RID: 5428 RVA: 0x0000F657 File Offset: 0x0000D857
		public unsafe RockTech rocky
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_rocky);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RockTech>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_rocky), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x00070568 File Offset: 0x0006E768
		// (set) Token: 0x06001536 RID: 5430 RVA: 0x0000F676 File Offset: 0x0000D876
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x00070590 File Offset: 0x0006E790
		// (set) Token: 0x06001538 RID: 5432 RVA: 0x0000F691 File Offset: 0x0000D891
		public unsafe int shadowCheckTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_shadowCheckTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_shadowCheckTimer)) = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x000705B8 File Offset: 0x0006E7B8
		// (set) Token: 0x0600153A RID: 5434 RVA: 0x0000F6AC File Offset: 0x0000D8AC
		public unsafe List<Vector3> topVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_topVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_topVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x000705E8 File Offset: 0x0006E7E8
		// (set) Token: 0x0600153C RID: 5436 RVA: 0x0000F6CB File Offset: 0x0000D8CB
		public unsafe bool zeroed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_zeroed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_zeroed)) = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x00070610 File Offset: 0x0006E810
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x0000F6E6 File Offset: 0x0000D8E6
		public unsafe Il2CppStructArray<Vector3> shadowVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_shadowVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_shadowVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x00070640 File Offset: 0x0006E840
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x0000F705 File Offset: 0x0000D905
		public unsafe Il2CppReferenceArray<Renderer> botRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_botRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_botRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00070670 File Offset: 0x0006E870
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x0000F724 File Offset: 0x0000D924
		public unsafe Il2CppStructArray<int> setMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_setMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_setMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x000706A0 File Offset: 0x0006E8A0
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x0000F743 File Offset: 0x0000D943
		public unsafe bool startRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_startRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_startRan)) = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x000706C8 File Offset: 0x0006E8C8
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x0000F75E File Offset: 0x0000D95E
		public unsafe Il2CppStructArray<int> meshIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_meshIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_meshIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x000706F8 File Offset: 0x0006E8F8
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x0000F77D File Offset: 0x0000D97D
		public unsafe bool freshMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_freshMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerStack.NativeFieldInfoPtr_freshMesh)) = value;
			}
		}

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeFieldInfoPtr_mesher;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeFieldInfoPtr_mesherRend;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeFieldInfoPtr_stackHeight;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_myMeshes;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeFieldInfoPtr_myRends;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeFieldInfoPtr_palMesh;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeFieldInfoPtr_palRend;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeFieldInfoPtr_palMeshIndex;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeFieldInfoPtr_rocky;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeFieldInfoPtr_shadowCheckTimer;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeFieldInfoPtr_topVerts;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeFieldInfoPtr_zeroed;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeFieldInfoPtr_shadowVerts;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeFieldInfoPtr_botRends;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeFieldInfoPtr_setMats;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeFieldInfoPtr_startRan;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeFieldInfoPtr_meshIndex;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeFieldInfoPtr_freshMesh;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_Zero_Private_Void_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
