using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2Cpp
{
	// Token: 0x020000E3 RID: 227
	public class GFX : MonoBehaviour
	{
		// Token: 0x060019D2 RID: 6610 RVA: 0x0007CAEC File Offset: 0x0007ACEC
		// Note: this type is marked as 'beforefieldinit'.
		static GFX()
		{
			Il2CppClassPointerStore<GFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GFX>.NativeClassPtr);
			GFX.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "verts");
			GFX.NativeFieldInfoPtr_verts4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "verts4");
			GFX.NativeFieldInfoPtr_verts8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "verts8");
			GFX.NativeFieldInfoPtr_uvs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "uvs");
			GFX.NativeFieldInfoPtr_tris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "tris");
			GFX.NativeFieldInfoPtr_v3Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "v3Zero");
			GFX.NativeFieldInfoPtr_mesh4Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "mesh4Pool");
			GFX.NativeFieldInfoPtr_mesh4Free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "mesh4Free");
			GFX.NativeFieldInfoPtr_nativeMesh4VBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "nativeMesh4VBuff");
			GFX.NativeFieldInfoPtr_meshUpdateFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "meshUpdateFlags");
			GFX.NativeFieldInfoPtr_meshUpdateFlagsRecalc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "meshUpdateFlagsRecalc");
			GFX.NativeFieldInfoPtr_poolSize4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "poolSize4");
			GFX.NativeFieldInfoPtr_meshLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "meshLists");
			GFX.NativeFieldInfoPtr_meshFreeLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "meshFreeLists");
			GFX.NativeFieldInfoPtr_nativeMeshVBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "nativeMeshVBuffs");
			GFX.NativeFieldInfoPtr_meshDefaultVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "meshDefaultVerts");
			GFX.NativeFieldInfoPtr_meshDefaultUvs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "meshDefaultUvs");
			GFX.NativeFieldInfoPtr_meshDefaultTris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "meshDefaultTris");
			GFX.NativeFieldInfoPtr_maxVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "maxVerts");
			GFX.NativeFieldInfoPtr_vertexLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "vertexLayout");
			GFX.NativeFieldInfoPtr_shitsDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GFX>.NativeClassPtr, "shitsDisposed");
			GFX.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665397);
			GFX.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665398);
			GFX.NativeMethodInfoPtr_Ind2Vert_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665399);
			GFX.NativeMethodInfoPtr_Vert2Ind_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665400);
			GFX.NativeMethodInfoPtr_ReleaseMeshWithVerts_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665401);
			GFX.NativeMethodInfoPtr_GetMeshWithVerts_Public_Static_Int32_MeshFilter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665402);
			GFX.NativeMethodInfoPtr_InitLimbMesh_Public_Static_Void_MeshFilter_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665403);
			GFX.NativeMethodInfoPtr_FreeMesh4_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665404);
			GFX.NativeMethodInfoPtr_InitWorldMesh_Public_Static_Void_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665405);
			GFX.NativeMethodInfoPtr_InitBoxMesh_Public_Static_Void_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665406);
			GFX.NativeMethodInfoPtr_InitBoxMeshNonAlloc_Public_Static_Int32_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665407);
			GFX.NativeMethodInfoPtr_InitBoxMeshNonAllocDontTrans_Public_Static_Int32_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665408);
			GFX.NativeMethodInfoPtr_ZeroMesh_Public_Static_Void_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665409);
			GFX.NativeMethodInfoPtr_ZeroMesh_Public_Static_Void_NativeArray_1_MeshPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665410);
			GFX.NativeMethodInfoPtr_DrawMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665411);
			GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665412);
			GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_Single_MeshFilter_Boolean_Single_Single_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665413);
			GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665414);
			GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665415);
			GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665416);
			GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665417);
			GFX.NativeMethodInfoPtr_DrawLimb_Public_Static_Vector2_Vector2_Vector2_Single_Single_Transform_Transform_Single_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665418);
			GFX.NativeMethodInfoPtr_PlaceLimbMesh_Public_Static_Void_Transform_Vector2_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665419);
			GFX.NativeMethodInfoPtr_PlaceLimbMesh_Public_Static_Void_Transform_Vector2_Vector2_Single_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665420);
			GFX.NativeMethodInfoPtr_DrawLimb_Public_Static_Vector2_Vector2_Vector2_Single_Single_Transform_Transform_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665421);
			GFX.NativeMethodInfoPtr_DrawLimb_Public_Static_Void_Vector2_Vector2_Vector2_Transform_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665422);
			GFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GFX>.NativeClassPtr, 100665423);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0007CEDC File Offset: 0x0007B0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59295, XrefRangeEnd = 59308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x0007CF10 File Offset: 0x0007B110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59308, XrefRangeEnd = 59435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0007CF44 File Offset: 0x0007B144
		[CallerCount(0)]
		public unsafe static int Ind2Vert(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_Ind2Vert_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0007CF84 File Offset: 0x0007B184
		[CallerCount(0)]
		public unsafe static int Vert2Ind(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_Vert2Ind_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0007CFC4 File Offset: 0x0007B1C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 59449, RefRangeEnd = 59452, XrefRangeStart = 59435, XrefRangeEnd = 59449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseMeshWithVerts(int meshIndex, int vertNum)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref meshIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_ReleaseMeshWithVerts_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0007D004 File Offset: 0x0007B204
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 59474, RefRangeEnd = 59477, XrefRangeStart = 59452, XrefRangeEnd = 59474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMeshWithVerts(MeshFilter filt, int vertNum)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_GetMeshWithVerts_Public_Static_Int32_MeshFilter_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x0007D054 File Offset: 0x0007B254
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 59515, RefRangeEnd = 59520, XrefRangeStart = 59477, XrefRangeEnd = 59515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitLimbMesh(MeshFilter mesher, float leftLocalWidth, float rightLocalWidth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesher);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftLocalWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightLocalWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_InitLimbMesh_Public_Static_Void_MeshFilter_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0007D0A8 File Offset: 0x0007B2A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 59524, RefRangeEnd = 59531, XrefRangeStart = 59520, XrefRangeEnd = 59524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeMesh4(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_FreeMesh4_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x0007D0DC File Offset: 0x0007B2DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 59578, RefRangeEnd = 59581, XrefRangeStart = 59531, XrefRangeEnd = 59578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitWorldMesh(MeshFilter mesher)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_InitWorldMesh_Public_Static_Void_MeshFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0007D114 File Offset: 0x0007B314
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 59621, RefRangeEnd = 59626, XrefRangeStart = 59581, XrefRangeEnd = 59621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitBoxMesh(MeshFilter mesher)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_InitBoxMesh_Public_Static_Void_MeshFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0007D14C File Offset: 0x0007B34C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 59663, RefRangeEnd = 59669, XrefRangeStart = 59626, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InitBoxMeshNonAlloc(MeshFilter mesher)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_InitBoxMeshNonAlloc_Public_Static_Int32_MeshFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0007D190 File Offset: 0x0007B390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59669, XrefRangeEnd = 59680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InitBoxMeshNonAllocDontTrans(MeshFilter mesher)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_InitBoxMeshNonAllocDontTrans_Public_Static_Int32_MeshFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0007D1D4 File Offset: 0x0007B3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59680, XrefRangeEnd = 59728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroMesh(MeshFilter mesh)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_ZeroMesh_Public_Static_Void_MeshFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0007D20C File Offset: 0x0007B40C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 59736, RefRangeEnd = 59741, XrefRangeStart = 59728, XrefRangeEnd = 59736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroMesh(NativeArray<MeshPt> arr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_ZeroMesh_Public_Static_Void_NativeArray_1_MeshPt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0007D248 File Offset: 0x0007B448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59773, RefRangeEnd = 59774, XrefRangeStart = 59741, XrefRangeEnd = 59773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh DrawMesh(Il2CppStructArray<Vector3> ptArr, Vector2 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ptArr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_DrawMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0007D29C File Offset: 0x0007B49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59774, XrefRangeEnd = 59780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineMesh(Vector2 a, Vector2 b, float w, MeshFilter mesher, bool flip, float scalex, float scaley, float minWidth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesher);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flip;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scalex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaley;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0007D334 File Offset: 0x0007B534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59841, RefRangeEnd = 59843, XrefRangeStart = 59780, XrefRangeEnd = 59841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineMesh(Vector2 a, Vector2 b, float w1, float w2, MeshFilter mesher, bool flip, float scalex, float scaley, float minWidth, Vector2 stretchDir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesher);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flip;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scalex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaley;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minWidth;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stretchDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_Single_MeshFilter_Boolean_Single_Single_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0007D3EC File Offset: 0x0007B5EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 59854, RefRangeEnd = 59857, XrefRangeStart = 59843, XrefRangeEnd = 59854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineMesh(Vector2 a, Vector2 b, float w, MeshFilter mesher, bool flip, Vector2 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesher);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flip;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Boolean_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0007D468 File Offset: 0x0007B668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59857, XrefRangeEnd = 59861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineMesh(Vector2 a, Vector2 b, float w, MeshFilter mesher)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesher);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0007D4C8 File Offset: 0x0007B6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59861, XrefRangeEnd = 59865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineMesh(Vector2 a, Vector2 b, float w, MeshFilter mesher, Vector2 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesher);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x0007D538 File Offset: 0x0007B738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59865, XrefRangeEnd = 59869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineMesh(Vector2 a, Vector2 b, float w, MeshFilter mesher, bool flip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesher);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0007D5A8 File Offset: 0x0007B7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59900, RefRangeEnd = 59901, XrefRangeStart = 59869, XrefRangeEnd = 59900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 DrawLimb(Vector2 a, Vector2 b, float ul, float ll, Transform uTrans, Transform lTrans, float scale, bool bendRight, bool offset, float minWidth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ul;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ll;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uTrans);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lTrans);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bendRight;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_DrawLimb_Public_Static_Vector2_Vector2_Vector2_Single_Single_Transform_Transform_Single_Boolean_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0007D670 File Offset: 0x0007B870
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 59921, RefRangeEnd = 59926, XrefRangeStart = 59901, XrefRangeEnd = 59921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlaceLimbMesh(Transform limb, Vector2 a, Vector2 b, float minWidth, float scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(limb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_PlaceLimbMesh_Public_Static_Void_Transform_Vector2_Vector2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0007D6E0 File Offset: 0x0007B8E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59946, RefRangeEnd = 59947, XrefRangeStart = 59926, XrefRangeEnd = 59946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlaceLimbMesh(Transform limb, Vector2 a, Vector2 b, float minWidth, float scale, Vector2 stretchDir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(limb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stretchDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_PlaceLimbMesh_Public_Static_Void_Transform_Vector2_Vector2_Single_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0007D75C File Offset: 0x0007B95C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59951, RefRangeEnd = 59953, XrefRangeStart = 59947, XrefRangeEnd = 59951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 DrawLimb(Vector2 a, Vector2 b, float ul, float ll, Transform uMesher, Transform lMesher, float scale, bool bendRight, bool offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ul;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ll;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uMesher);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lMesher);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bendRight;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_DrawLimb_Public_Static_Vector2_Vector2_Vector2_Single_Single_Transform_Transform_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0007D814 File Offset: 0x0007BA14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60042, RefRangeEnd = 60043, XrefRangeStart = 59953, XrefRangeEnd = 60042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLimb(Vector2 a, Vector2 b, Vector2 ePos, Transform uMesher, Transform lMesher, float scale, float minWidth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ePos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uMesher);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lMesher);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr_DrawLimb_Public_Static_Void_Vector2_Vector2_Vector2_Transform_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0007D8A4 File Offset: 0x0007BAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GFX()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GFX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00012666 File Offset: 0x00010866
		public GFX(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x0007D8E0 File Offset: 0x0007BAE0
		// (set) Token: 0x060019F0 RID: 6640 RVA: 0x0001266F File Offset: 0x0001086F
		public unsafe static List<Vector3> verts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_verts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_verts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x0007D908 File Offset: 0x0007BB08
		// (set) Token: 0x060019F2 RID: 6642 RVA: 0x00012681 File Offset: 0x00010881
		public unsafe static List<Vector3> verts4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_verts4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_verts4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0007D930 File Offset: 0x0007BB30
		// (set) Token: 0x060019F4 RID: 6644 RVA: 0x00012693 File Offset: 0x00010893
		public unsafe static List<Vector3> verts8
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_verts8, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_verts8, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0007D958 File Offset: 0x0007BB58
		// (set) Token: 0x060019F6 RID: 6646 RVA: 0x000126A5 File Offset: 0x000108A5
		public unsafe static Il2CppStructArray<Vector2> uvs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_uvs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_uvs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x0007D980 File Offset: 0x0007BB80
		// (set) Token: 0x060019F8 RID: 6648 RVA: 0x000126B7 File Offset: 0x000108B7
		public unsafe static Il2CppStructArray<int> tris
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_tris, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_tris, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x0007D9A8 File Offset: 0x0007BBA8
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x000126C9 File Offset: 0x000108C9
		public unsafe static Vector3 v3Zero
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_v3Zero, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_v3Zero, (void*)(&value));
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x0007D9C4 File Offset: 0x0007BBC4
		// (set) Token: 0x060019FC RID: 6652 RVA: 0x000126D7 File Offset: 0x000108D7
		public unsafe static Il2CppReferenceArray<Mesh> mesh4Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_mesh4Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Mesh>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_mesh4Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x0007D9EC File Offset: 0x0007BBEC
		// (set) Token: 0x060019FE RID: 6654 RVA: 0x000126E9 File Offset: 0x000108E9
		public unsafe static Il2CppStructArray<byte> mesh4Free
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_mesh4Free, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_mesh4Free, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x0007DA14 File Offset: 0x0007BC14
		// (set) Token: 0x06001A00 RID: 6656 RVA: 0x000126FB File Offset: 0x000108FB
		public unsafe static NativeArray<MeshPt> nativeMesh4VBuff
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<MeshPt>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_nativeMesh4VBuff, intPtr);
				return new NativeArray<MeshPt>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<MeshPt>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_nativeMesh4VBuff, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x0007DA50 File Offset: 0x0007BC50
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x00012712 File Offset: 0x00010912
		public unsafe static MeshUpdateFlags meshUpdateFlags
		{
			get
			{
				MeshUpdateFlags meshUpdateFlags;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_meshUpdateFlags, (void*)(&meshUpdateFlags));
				return meshUpdateFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_meshUpdateFlags, (void*)(&value));
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x0007DA6C File Offset: 0x0007BC6C
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x00012720 File Offset: 0x00010920
		public unsafe static MeshUpdateFlags meshUpdateFlagsRecalc
		{
			get
			{
				MeshUpdateFlags meshUpdateFlags;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_meshUpdateFlagsRecalc, (void*)(&meshUpdateFlags));
				return meshUpdateFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_meshUpdateFlagsRecalc, (void*)(&value));
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x0007DA88 File Offset: 0x0007BC88
		// (set) Token: 0x06001A06 RID: 6662 RVA: 0x0001272E File Offset: 0x0001092E
		public unsafe static int poolSize4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_poolSize4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_poolSize4, (void*)(&value));
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x0007DAA4 File Offset: 0x0007BCA4
		// (set) Token: 0x06001A08 RID: 6664 RVA: 0x0001273C File Offset: 0x0001093C
		public unsafe static Il2CppReferenceArray<List<Mesh>> meshLists
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_meshLists, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<Mesh>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_meshLists, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x0007DACC File Offset: 0x0007BCCC
		// (set) Token: 0x06001A0A RID: 6666 RVA: 0x0001274E File Offset: 0x0001094E
		public unsafe static Il2CppReferenceArray<List<byte>> meshFreeLists
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_meshFreeLists, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<byte>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_meshFreeLists, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x0007DAF4 File Offset: 0x0007BCF4
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x00012760 File Offset: 0x00010960
		public unsafe static Il2CppReferenceArray<NativeArray<MeshPt>> nativeMeshVBuffs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_nativeMeshVBuffs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NativeArray<MeshPt>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_nativeMeshVBuffs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x0007DB1C File Offset: 0x0007BD1C
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x00012772 File Offset: 0x00010972
		public unsafe static Il2CppReferenceArray<List<Vector3>> meshDefaultVerts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_meshDefaultVerts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<Vector3>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_meshDefaultVerts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0007DB44 File Offset: 0x0007BD44
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x00012784 File Offset: 0x00010984
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<Vector2>> meshDefaultUvs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_meshDefaultUvs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<Vector2>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_meshDefaultUvs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x0007DB6C File Offset: 0x0007BD6C
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x00012796 File Offset: 0x00010996
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> meshDefaultTris
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_meshDefaultTris, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_meshDefaultTris, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x0007DB94 File Offset: 0x0007BD94
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x000127A8 File Offset: 0x000109A8
		public unsafe static int maxVerts
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_maxVerts, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_maxVerts, (void*)(&value));
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x0007DBB0 File Offset: 0x0007BDB0
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x000127B6 File Offset: 0x000109B6
		public unsafe static Il2CppStructArray<VertexAttributeDescriptor> vertexLayout
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_vertexLayout, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<VertexAttributeDescriptor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_vertexLayout, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x0007DBD8 File Offset: 0x0007BDD8
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x000127C8 File Offset: 0x000109C8
		public unsafe static bool shitsDisposed
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(GFX.NativeFieldInfoPtr_shitsDisposed, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GFX.NativeFieldInfoPtr_shitsDisposed, (void*)(&value));
			}
		}

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeFieldInfoPtr_verts4;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeFieldInfoPtr_verts8;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeFieldInfoPtr_uvs;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeFieldInfoPtr_tris;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeFieldInfoPtr_v3Zero;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeFieldInfoPtr_mesh4Pool;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeFieldInfoPtr_mesh4Free;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeFieldInfoPtr_nativeMesh4VBuff;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeFieldInfoPtr_meshUpdateFlags;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeFieldInfoPtr_meshUpdateFlagsRecalc;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeFieldInfoPtr_poolSize4;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeFieldInfoPtr_meshLists;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeFieldInfoPtr_meshFreeLists;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeFieldInfoPtr_nativeMeshVBuffs;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeFieldInfoPtr_meshDefaultVerts;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeFieldInfoPtr_meshDefaultUvs;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeFieldInfoPtr_meshDefaultTris;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeFieldInfoPtr_maxVerts;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeFieldInfoPtr_vertexLayout;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeFieldInfoPtr_shitsDisposed;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr_Ind2Vert_Private_Static_Int32_Int32_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr_Vert2Ind_Public_Static_Int32_Int32_0;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseMeshWithVerts_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshWithVerts_Public_Static_Int32_MeshFilter_Int32_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr_InitLimbMesh_Public_Static_Void_MeshFilter_Single_Single_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr_FreeMesh4_Public_Static_Void_Int32_0;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr_InitWorldMesh_Public_Static_Void_MeshFilter_0;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeMethodInfoPtr_InitBoxMesh_Public_Static_Void_MeshFilter_0;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr_InitBoxMeshNonAlloc_Public_Static_Int32_MeshFilter_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_InitBoxMeshNonAllocDontTrans_Public_Static_Int32_MeshFilter_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_ZeroMesh_Public_Static_Void_MeshFilter_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_ZeroMesh_Public_Static_Void_NativeArray_1_MeshPt_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Vector2_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Boolean_Single_Single_Single_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_Single_MeshFilter_Boolean_Single_Single_Single_Vector2_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Boolean_Vector2_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Vector2_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineMesh_Public_Static_Void_Vector2_Vector2_Single_MeshFilter_Boolean_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_DrawLimb_Public_Static_Vector2_Vector2_Vector2_Single_Single_Transform_Transform_Single_Boolean_Boolean_Single_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_PlaceLimbMesh_Public_Static_Void_Transform_Vector2_Vector2_Single_Single_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_PlaceLimbMesh_Public_Static_Void_Transform_Vector2_Vector2_Single_Single_Vector2_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_DrawLimb_Public_Static_Vector2_Vector2_Vector2_Single_Single_Transform_Transform_Single_Boolean_Boolean_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_DrawLimb_Public_Static_Void_Vector2_Vector2_Vector2_Transform_Transform_Single_Single_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
