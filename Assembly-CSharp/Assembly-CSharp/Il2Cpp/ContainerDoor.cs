using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000AC RID: 172
	public class ContainerDoor : MonoBehaviour
	{
		// Token: 0x060014E3 RID: 5347 RVA: 0x0006F7D4 File Offset: 0x0006D9D4
		// Note: this type is marked as 'beforefieldinit'.
		static ContainerDoor()
		{
			Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ContainerDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr);
			ContainerDoor.NativeFieldInfoPtr_vts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "vts");
			ContainerDoor.NativeFieldInfoPtr_topMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "topMeshes");
			ContainerDoor.NativeFieldInfoPtr_mesher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "mesher");
			ContainerDoor.NativeFieldInfoPtr_mesherMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "mesherMesh");
			ContainerDoor.NativeFieldInfoPtr_meshRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "meshRend");
			ContainerDoor.NativeFieldInfoPtr_doorMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "doorMesh");
			ContainerDoor.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "verts");
			ContainerDoor.NativeFieldInfoPtr_swingDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "swingDoor");
			ContainerDoor.NativeFieldInfoPtr_rockTech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "rockTech");
			ContainerDoor.NativeFieldInfoPtr_topRockTechs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "topRockTechs");
			ContainerDoor.NativeFieldInfoPtr_topRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "topRend");
			ContainerDoor.NativeFieldInfoPtr_myRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "myRend");
			ContainerDoor.NativeFieldInfoPtr_zeroed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "zeroed");
			ContainerDoor.NativeFieldInfoPtr_doorPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "doorPercent");
			ContainerDoor.NativeFieldInfoPtr_paraMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "paraMesh");
			ContainerDoor.NativeFieldInfoPtr_paraMeshMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "paraMeshMesh");
			ContainerDoor.NativeFieldInfoPtr_debugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "debugging");
			ContainerDoor.NativeFieldInfoPtr_dumbVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "dumbVerts");
			ContainerDoor.NativeFieldInfoPtr_startRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "startRan");
			ContainerDoor.NativeFieldInfoPtr_box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "box");
			ContainerDoor.NativeFieldInfoPtr_hasPalMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "hasPalMesh");
			ContainerDoor.NativeFieldInfoPtr_mesherIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "mesherIndex");
			ContainerDoor.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, "pts");
			ContainerDoor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, 100665060);
			ContainerDoor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, 100665061);
			ContainerDoor.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, 100665062);
			ContainerDoor.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, 100665063);
			ContainerDoor.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, 100665064);
			ContainerDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, 100665065);
			ContainerDoor.NativeMethodInfoPtr_SetPalMeshVerts_Private_Void_NativeSlice_1_MeshPt_NativeSlice_1_MeshPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, 100665066);
			ContainerDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr, 100665067);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0006FA70 File Offset: 0x0006DC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53044, XrefRangeEnd = 53056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerDoor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0006FAA4 File Offset: 0x0006DCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53056, XrefRangeEnd = 53162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerDoor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0006FAD8 File Offset: 0x0006DCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53162, XrefRangeEnd = 53192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerDoor.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0006FB0C File Offset: 0x0006DD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53192, XrefRangeEnd = 53226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerDoor.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0006FB40 File Offset: 0x0006DD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53226, XrefRangeEnd = 53230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerDoor.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0006FB74 File Offset: 0x0006DD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53230, XrefRangeEnd = 53311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0006FBA8 File Offset: 0x0006DDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53311, XrefRangeEnd = 53326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerDoor.NativeMethodInfoPtr_SetPalMeshVerts_Private_Void_NativeSlice_1_MeshPt_NativeSlice_1_MeshPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0006FC08 File Offset: 0x0006DE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53326, XrefRangeEnd = 53329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContainerDoor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0000F2A4 File Offset: 0x0000D4A4
		public ContainerDoor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0006FC44 File Offset: 0x0006DE44
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x0000F2AD File Offset: 0x0000D4AD
		public unsafe Il2CppStructArray<int> vts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_vts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_vts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0006FC74 File Offset: 0x0006DE74
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x0000F2CC File Offset: 0x0000D4CC
		public unsafe Il2CppReferenceArray<MeshFilter> topMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_topMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_topMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x0006FCA4 File Offset: 0x0006DEA4
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x0000F2EB File Offset: 0x0000D4EB
		public unsafe MeshFilter mesher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_mesher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_mesher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x0006FCD4 File Offset: 0x0006DED4
		// (set) Token: 0x060014F4 RID: 5364 RVA: 0x0000F30A File Offset: 0x0000D50A
		public unsafe Mesh mesherMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_mesherMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_mesherMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0006FD04 File Offset: 0x0006DF04
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x0000F329 File Offset: 0x0000D529
		public unsafe MeshRenderer meshRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_meshRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_meshRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0006FD34 File Offset: 0x0006DF34
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x0000F348 File Offset: 0x0000D548
		public unsafe MeshFilter doorMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_doorMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_doorMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x0006FD64 File Offset: 0x0006DF64
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x0000F367 File Offset: 0x0000D567
		public unsafe List<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x0006FD94 File Offset: 0x0006DF94
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x0000F386 File Offset: 0x0000D586
		public unsafe SwingyDoor swingDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_swingDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SwingyDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_swingDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x0006FDC4 File Offset: 0x0006DFC4
		// (set) Token: 0x060014FE RID: 5374 RVA: 0x0000F3A5 File Offset: 0x0000D5A5
		public unsafe RockTech rockTech
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_rockTech);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RockTech>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_rockTech), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x0006FDF4 File Offset: 0x0006DFF4
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x0000F3C4 File Offset: 0x0000D5C4
		public unsafe Il2CppReferenceArray<RockTech> topRockTechs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_topRockTechs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RockTech>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_topRockTechs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x0006FE24 File Offset: 0x0006E024
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x0000F3E3 File Offset: 0x0000D5E3
		public unsafe MeshRenderer topRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_topRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_topRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x0006FE54 File Offset: 0x0006E054
		// (set) Token: 0x06001504 RID: 5380 RVA: 0x0000F402 File Offset: 0x0000D602
		public unsafe MeshRenderer myRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_myRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_myRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0006FE84 File Offset: 0x0006E084
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x0000F421 File Offset: 0x0000D621
		public unsafe bool zeroed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_zeroed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_zeroed)) = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x0006FEAC File Offset: 0x0006E0AC
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x0000F43C File Offset: 0x0000D63C
		public unsafe float doorPercent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_doorPercent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_doorPercent)) = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x0006FED4 File Offset: 0x0006E0D4
		// (set) Token: 0x0600150A RID: 5386 RVA: 0x0000F457 File Offset: 0x0000D657
		public unsafe MeshFilter paraMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_paraMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_paraMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x0006FF04 File Offset: 0x0006E104
		// (set) Token: 0x0600150C RID: 5388 RVA: 0x0000F476 File Offset: 0x0000D676
		public unsafe Mesh paraMeshMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_paraMeshMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_paraMeshMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x0006FF34 File Offset: 0x0006E134
		// (set) Token: 0x0600150E RID: 5390 RVA: 0x0000F495 File Offset: 0x0000D695
		public unsafe bool debugging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_debugging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_debugging)) = value;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x0006FF5C File Offset: 0x0006E15C
		// (set) Token: 0x06001510 RID: 5392 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		public unsafe Il2CppStructArray<Vector3> dumbVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_dumbVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_dumbVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x0006FF8C File Offset: 0x0006E18C
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x0000F4CF File Offset: 0x0000D6CF
		public unsafe bool startRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_startRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_startRan)) = value;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x0006FFB4 File Offset: 0x0006E1B4
		// (set) Token: 0x06001514 RID: 5396 RVA: 0x0000F4EA File Offset: 0x0000D6EA
		public unsafe BoxCollider2D box
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_box);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_box), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x0006FFE4 File Offset: 0x0006E1E4
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x0000F509 File Offset: 0x0000D709
		public unsafe bool hasPalMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_hasPalMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_hasPalMesh)) = value;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x0007000C File Offset: 0x0006E20C
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x0000F524 File Offset: 0x0000D724
		public unsafe int mesherIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_mesherIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_mesherIndex)) = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x00070034 File Offset: 0x0006E234
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x0000F53F File Offset: 0x0000D73F
		public unsafe Il2CppStructArray<Vector2> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerDoor.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeFieldInfoPtr_vts;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeFieldInfoPtr_topMeshes;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeFieldInfoPtr_mesher;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeFieldInfoPtr_mesherMesh;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeFieldInfoPtr_meshRend;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeFieldInfoPtr_doorMesh;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeFieldInfoPtr_swingDoor;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeFieldInfoPtr_rockTech;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeFieldInfoPtr_topRockTechs;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeFieldInfoPtr_topRend;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeFieldInfoPtr_myRend;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeFieldInfoPtr_zeroed;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeFieldInfoPtr_doorPercent;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeFieldInfoPtr_paraMesh;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeFieldInfoPtr_paraMeshMesh;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeFieldInfoPtr_debugging;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeFieldInfoPtr_dumbVerts;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeFieldInfoPtr_startRan;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeFieldInfoPtr_box;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeFieldInfoPtr_hasPalMesh;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeFieldInfoPtr_mesherIndex;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_SetPalMeshVerts_Private_Void_NativeSlice_1_MeshPt_NativeSlice_1_MeshPt_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
