using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000014 RID: 20
	public class ResonanceAudioAcousticMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06000307 RID: 775 RVA: 0x0003C11C File Offset: 0x0003A31C
		// Note: this type is marked as 'beforefieldinit'.
		static ResonanceAudioAcousticMesh()
		{
			Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResonanceAudioAcousticMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr);
			ResonanceAudioAcousticMesh.NativeFieldInfoPtr__mesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, "<mesh>k__BackingField");
			ResonanceAudioAcousticMesh.NativeFieldInfoPtr__sourceObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, "<sourceObject>k__BackingField");
			ResonanceAudioAcousticMesh.NativeFieldInfoPtr_isIncludedByObjectFiltering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, "isIncludedByObjectFiltering");
			ResonanceAudioAcousticMesh.NativeFieldInfoPtr_surfaceMaterialsFromSubMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, "surfaceMaterialsFromSubMesh");
			ResonanceAudioAcousticMesh.NativeFieldInfoPtr_triangleRangesFromSubMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, "triangleRangesFromSubMesh");
			ResonanceAudioAcousticMesh.NativeFieldInfoPtr_unityMaxNumVerticesPerMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, "unityMaxNumVerticesPerMesh");
			ResonanceAudioAcousticMesh.NativeFieldInfoPtr_maxNumSubMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, "maxNumSubMeshes");
			ResonanceAudioAcousticMesh.NativeFieldInfoPtr_visualizationMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, "visualizationMaterial");
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663466);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663467);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_get_sourceObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663468);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_set_sourceObject_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663469);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_GenerateFromMeshFilter_Public_Static_ResonanceAudioAcousticMesh_MeshFilter_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663470);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_GenerateFromTerrain_Public_Static_ResonanceAudioAcousticMesh_Terrain_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663471);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_GetSurfaceMaterialIndicesFromTriangle_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663472);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_SetSurfaceMaterialToAllSubMeshes_Public_Void_SurfaceMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663473);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_SetSurfaceMaterialToSubMesh_Public_Void_SurfaceMaterial_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663474);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_Render_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663475);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_IsIncluded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663476);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_IsSubMeshTriangular_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663477);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_CountTriangleIndices_Private_Static_Int32_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663478);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_SubSampleHeightMap_Private_Static_Void_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663479);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_InitializeMesh_Private_Void_Int32_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663480);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_InitializeSubMeshMaterials_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663481);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_InitializeVisualizationMaterial_Private_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663482);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_FillVerticesAndTrianglesFromMesh_Private_Void_Mesh_Transform_byref_Il2CppStructArray_1_Vector3_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663483);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_FillTrianglesAndVerticesFromHeightMap_Private_Void_Vector3_Vector3_Il2CppObjectBase_Int32_Int32_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663484);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_SetSubMeshEnds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663485);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr_SetSubMeshSurfaceMaterials_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663486);
			ResonanceAudioAcousticMesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr, 100663487);
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0003C3A4 File Offset: 0x0003A5A4
		// (set) Token: 0x06000309 RID: 777 RVA: 0x0003C3E4 File Offset: 0x0003A5E4
		public unsafe Mesh mesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0003C428 File Offset: 0x0003A628
		// (set) Token: 0x0600030B RID: 779 RVA: 0x0003C468 File Offset: 0x0003A668
		public unsafe GameObject sourceObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_get_sourceObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_set_sourceObject_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0003C4AC File Offset: 0x0003A6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33187, RefRangeEnd = 33188, XrefRangeStart = 33146, XrefRangeEnd = 33187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResonanceAudioAcousticMesh GenerateFromMeshFilter(MeshFilter meshFilter, Shader surfaceMaterialShader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshFilter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surfaceMaterialShader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_GenerateFromMeshFilter_Public_Static_ResonanceAudioAcousticMesh_MeshFilter_Shader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResonanceAudioAcousticMesh>(intPtr3) : null;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0003C504 File Offset: 0x0003A704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33231, RefRangeEnd = 33232, XrefRangeStart = 33188, XrefRangeEnd = 33231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResonanceAudioAcousticMesh GenerateFromTerrain(Terrain terrain, Shader surfaceMaterialShader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surfaceMaterialShader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_GenerateFromTerrain_Public_Static_ResonanceAudioAcousticMesh_Terrain_Shader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResonanceAudioAcousticMesh>(intPtr3) : null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0003C55C File Offset: 0x0003A75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33232, XrefRangeEnd = 33238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetSurfaceMaterialIndicesFromTriangle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_GetSurfaceMaterialIndicesFromTriangle_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0003C59C File Offset: 0x0003A79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33238, XrefRangeEnd = 33243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSurfaceMaterialToAllSubMeshes(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref surfaceMaterial;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_SetSurfaceMaterialToAllSubMeshes_Public_Void_SurfaceMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0003C5DC File Offset: 0x0003A7DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33288, RefRangeEnd = 33289, XrefRangeStart = 33243, XrefRangeEnd = 33288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSurfaceMaterialToSubMesh(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial, int subMeshIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref surfaceMaterial;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subMeshIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_SetSurfaceMaterialToSubMesh_Public_Void_SurfaceMaterial_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0003C628 File Offset: 0x0003A828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33321, RefRangeEnd = 33322, XrefRangeStart = 33289, XrefRangeEnd = 33321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Render()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_Render_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0003C664 File Offset: 0x0003A864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33347, RefRangeEnd = 33349, XrefRangeStart = 33322, XrefRangeEnd = 33347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIncluded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_IsIncluded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0003C6A0 File Offset: 0x0003A8A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33349, RefRangeEnd = 33350, XrefRangeStart = 33349, XrefRangeEnd = 33349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSubMeshTriangular(int subMeshIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subMeshIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_IsSubMeshTriangular_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0003C6EC File Offset: 0x0003A8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33350, XrefRangeEnd = 33355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountTriangleIndices(Mesh sourceMesh)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceMesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_CountTriangleIndices_Private_Static_Int32_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0003C730 File Offset: 0x0003A930
		[CallerCount(0)]
		public unsafe static void SubSampleHeightMap(int originalM, int originalN, out int m, out int n, out int subSampleStep, out int subSampledNumTriangleIndices)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalM;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalN;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &m;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &n;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &subSampleStep;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &subSampledNumTriangleIndices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_SubSampleHeightMap_Private_Static_Void_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0003C7AC File Offset: 0x0003A9AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33379, RefRangeEnd = 33381, XrefRangeStart = 33355, XrefRangeEnd = 33379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeMesh(int numTriangleIndices, int numVertices, out Il2CppStructArray<int> triangles, out Il2CppStructArray<Vector3> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numTriangleIndices;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numVertices;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_InitializeMesh_Private_Void_Int32_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			triangles = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			vertices = ((intPtr6 == 0) ? null : new Il2CppStructArray<Vector3>(intPtr6));
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0003C840 File Offset: 0x0003AA40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33384, RefRangeEnd = 33386, XrefRangeStart = 33381, XrefRangeEnd = 33384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeSubMeshMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_InitializeSubMeshMaterials_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0003C874 File Offset: 0x0003AA74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33403, RefRangeEnd = 33405, XrefRangeStart = 33386, XrefRangeEnd = 33403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeVisualizationMaterial(Shader surfaceMaterialShader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(surfaceMaterialShader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_InitializeVisualizationMaterial_Private_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0003C8B8 File Offset: 0x0003AAB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33424, RefRangeEnd = 33425, XrefRangeStart = 33405, XrefRangeEnd = 33424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillVerticesAndTrianglesFromMesh(Mesh sourceMesh, Transform sourceObjectTransform, ref Il2CppStructArray<Vector3> vertices, ref Il2CppStructArray<int> triangles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceMesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceObjectTransform);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_FillVerticesAndTrianglesFromMesh_Private_Void_Mesh_Transform_byref_Il2CppStructArray_1_Vector3_byref_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			vertices = ((intPtr5 == 0) ? null : new Il2CppStructArray<Vector3>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			triangles = ((intPtr6 == 0) ? null : new Il2CppStructArray<int>(intPtr6));
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0003C960 File Offset: 0x0003AB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33425, XrefRangeEnd = 33436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillTrianglesAndVerticesFromHeightMap(Vector3 terrainPosition, Vector3 terrainSize, Il2CppObjectBase heightMap, int m, int n, int subSampleStep, ref Il2CppStructArray<int> triangles, ref Il2CppStructArray<Vector3> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref terrainPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref terrainSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(heightMap);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subSampleStep;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(vertices);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_FillTrianglesAndVerticesFromHeightMap_Private_Void_Vector3_Vector3_Il2CppObjectBase_Int32_Int32_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			triangles = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			vertices = ((intPtr6 == 0) ? null : new Il2CppStructArray<Vector3>(intPtr6));
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0003CA3C File Offset: 0x0003AC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33503, RefRangeEnd = 33504, XrefRangeStart = 33436, XrefRangeEnd = 33503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMeshEnds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_SetSubMeshEnds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0003CA70 File Offset: 0x0003AC70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 33530, RefRangeEnd = 33533, XrefRangeStart = 33504, XrefRangeEnd = 33530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMeshSurfaceMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr_SetSubMeshSurfaceMaterials_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0003CAA4 File Offset: 0x0003ACA4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResonanceAudioAcousticMesh()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioAcousticMesh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioAcousticMesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00004288 File Offset: 0x00002488
		public ResonanceAudioAcousticMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0003CAE0 File Offset: 0x0003ACE0
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00004291 File Offset: 0x00002491
		public unsafe Mesh _mesh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr__mesh_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr__mesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0003CB10 File Offset: 0x0003AD10
		// (set) Token: 0x06000322 RID: 802 RVA: 0x000042B0 File Offset: 0x000024B0
		public unsafe GameObject _sourceObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr__sourceObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr__sourceObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0003CB40 File Offset: 0x0003AD40
		// (set) Token: 0x06000324 RID: 804 RVA: 0x000042CF File Offset: 0x000024CF
		public unsafe bool isIncludedByObjectFiltering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_isIncludedByObjectFiltering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_isIncludedByObjectFiltering)) = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0003CB68 File Offset: 0x0003AD68
		// (set) Token: 0x06000326 RID: 806 RVA: 0x000042EA File Offset: 0x000024EA
		public unsafe Il2CppStructArray<ResonanceAudioRoomManager.SurfaceMaterial> surfaceMaterialsFromSubMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_surfaceMaterialsFromSubMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ResonanceAudioRoomManager.SurfaceMaterial>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_surfaceMaterialsFromSubMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0003CB98 File Offset: 0x0003AD98
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00004309 File Offset: 0x00002509
		public unsafe Il2CppStructArray<RangeInt> triangleRangesFromSubMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_triangleRangesFromSubMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RangeInt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_triangleRangesFromSubMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0003CBC8 File Offset: 0x0003ADC8
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00004328 File Offset: 0x00002528
		public unsafe static int unityMaxNumVerticesPerMesh
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_unityMaxNumVerticesPerMesh, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_unityMaxNumVerticesPerMesh, (void*)(&value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0003CBE4 File Offset: 0x0003ADE4
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00004336 File Offset: 0x00002536
		public unsafe static int maxNumSubMeshes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_maxNumSubMeshes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_maxNumSubMeshes, (void*)(&value));
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0003CC00 File Offset: 0x0003AE00
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00004344 File Offset: 0x00002544
		public unsafe Material visualizationMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_visualizationMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioAcousticMesh.NativeFieldInfoPtr_visualizationMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr__mesh_k__BackingField;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr__sourceObject_k__BackingField;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_isIncludedByObjectFiltering;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_surfaceMaterialsFromSubMesh;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_triangleRangesFromSubMesh;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_unityMaxNumVerticesPerMesh;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr_maxNumSubMeshes;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_visualizationMaterial;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceObject_Public_get_GameObject_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_set_sourceObject_Private_set_Void_GameObject_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_GenerateFromMeshFilter_Public_Static_ResonanceAudioAcousticMesh_MeshFilter_Shader_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_GenerateFromTerrain_Public_Static_ResonanceAudioAcousticMesh_Terrain_Shader_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_GetSurfaceMaterialIndicesFromTriangle_Public_Il2CppStructArray_1_Int32_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_SetSurfaceMaterialToAllSubMeshes_Public_Void_SurfaceMaterial_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_SetSurfaceMaterialToSubMesh_Public_Void_SurfaceMaterial_Int32_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Boolean_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_IsIncluded_Public_Boolean_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_IsSubMeshTriangular_Public_Boolean_Int32_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_CountTriangleIndices_Private_Static_Int32_Mesh_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_SubSampleHeightMap_Private_Static_Void_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_InitializeMesh_Private_Void_Int32_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSubMeshMaterials_Private_Void_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVisualizationMaterial_Private_Void_Shader_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_FillVerticesAndTrianglesFromMesh_Private_Void_Mesh_Transform_byref_Il2CppStructArray_1_Vector3_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_FillTrianglesAndVerticesFromHeightMap_Private_Void_Vector3_Vector3_Il2CppObjectBase_Int32_Int32_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMeshEnds_Private_Void_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMeshSurfaceMaterials_Private_Void_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
