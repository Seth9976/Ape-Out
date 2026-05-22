using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000017 RID: 23
	public class ResonanceAudioMaterialMapper : ScriptableObject
	{
		// Token: 0x06000359 RID: 857 RVA: 0x0003D3C8 File Offset: 0x0003B5C8
		// Note: this type is marked as 'beforefieldinit'.
		static ResonanceAudioMaterialMapper()
		{
			Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResonanceAudioMaterialMapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr);
			ResonanceAudioMaterialMapper.NativeFieldInfoPtr_materialMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, "materialMap");
			ResonanceAudioMaterialMapper.NativeFieldInfoPtr_unityMaterialAcousticMeshDataFromGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, "unityMaterialAcousticMeshDataFromGuid");
			ResonanceAudioMaterialMapper.NativeFieldInfoPtr_terrainAcousticMeshDataFromGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, "terrainAcousticMeshDataFromGuid");
			ResonanceAudioMaterialMapper.NativeFieldInfoPtr_reverbLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, "reverbLayerMask");
			ResonanceAudioMaterialMapper.NativeFieldInfoPtr_includeNonStaticGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, "includeNonStaticGameObjects");
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663503);
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr_ApplyMaterialMapping_Public_Void_Il2CppReferenceArray_1_MeshRenderer_Il2CppReferenceArray_1_List_1_String_Il2CppReferenceArray_1_Terrain_Il2CppStringArray_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663504);
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr_RenderAcousticMeshes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663505);
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr_GetIncludedAcousticMeshes_Public_List_1_ResonanceAudioAcousticMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663506);
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr_BuildUnityMaterialData_Private_Void_Il2CppReferenceArray_1_MeshRenderer_Il2CppReferenceArray_1_List_1_String_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663507);
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr_BuildTerrainData_Private_Void_Il2CppReferenceArray_1_Terrain_Il2CppStringArray_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663508);
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr_ApplyMaterialMappingToGuids_Private_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663509);
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr_ApplySurfaceMaterialToGameObjects_Private_Void_SurfaceMaterial_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663510);
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr_ApplySurfaceMaterialToTerrains_Private_Void_SurfaceMaterial_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663511);
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr_ApplyObjectFiltering_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663512);
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr_IsIncludedByObjectFiltering_Private_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663513);
			ResonanceAudioMaterialMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, 100663514);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0003D54C File Offset: 0x0003B74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33633, XrefRangeEnd = 33643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0003D580 File Offset: 0x0003B780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33643, XrefRangeEnd = 33660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMaterialMapping(Il2CppReferenceArray<MeshRenderer> meshRenderers, Il2CppReferenceArray<List<string>> guidsForMeshRenderers, Il2CppReferenceArray<Terrain> activeTerrains, Il2CppStringArray guidsForTerrains, Shader surfaceMaterialShader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshRenderers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guidsForMeshRenderers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeTerrains);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guidsForTerrains);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surfaceMaterialShader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr_ApplyMaterialMapping_Public_Void_Il2CppReferenceArray_1_MeshRenderer_Il2CppReferenceArray_1_List_1_String_Il2CppReferenceArray_1_Terrain_Il2CppStringArray_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0003D60C File Offset: 0x0003B80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33660, XrefRangeEnd = 33665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderAcousticMeshes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr_RenderAcousticMeshes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0003D640 File Offset: 0x0003B840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33702, RefRangeEnd = 33703, XrefRangeStart = 33665, XrefRangeEnd = 33702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ResonanceAudioAcousticMesh> GetIncludedAcousticMeshes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr_GetIncludedAcousticMeshes_Public_List_1_ResonanceAudioAcousticMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ResonanceAudioAcousticMesh>>(intPtr3) : null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0003D680 File Offset: 0x0003B880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33737, RefRangeEnd = 33738, XrefRangeStart = 33703, XrefRangeEnd = 33737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildUnityMaterialData(Il2CppReferenceArray<MeshRenderer> meshRenderers, Il2CppReferenceArray<List<string>> guidsForMeshRenderers, Shader surfaceMaterialShader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshRenderers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guidsForMeshRenderers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surfaceMaterialShader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr_BuildUnityMaterialData_Private_Void_Il2CppReferenceArray_1_MeshRenderer_Il2CppReferenceArray_1_List_1_String_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0003D6E8 File Offset: 0x0003B8E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33758, RefRangeEnd = 33759, XrefRangeStart = 33738, XrefRangeEnd = 33758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildTerrainData(Il2CppReferenceArray<Terrain> activeTerrains, Il2CppStringArray guidsForTerrains, Shader surfaceMaterialShader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeTerrains);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guidsForTerrains);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surfaceMaterialShader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr_BuildTerrainData_Private_Void_Il2CppReferenceArray_1_Terrain_Il2CppStringArray_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0003D750 File Offset: 0x0003B950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33771, RefRangeEnd = 33772, XrefRangeStart = 33759, XrefRangeEnd = 33771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMaterialMappingToGuids(List<string> guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guids);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr_ApplyMaterialMappingToGuids_Private_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0003D794 File Offset: 0x0003B994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33812, RefRangeEnd = 33813, XrefRangeStart = 33772, XrefRangeEnd = 33812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySurfaceMaterialToGameObjects(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref surfaceMaterial;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr_ApplySurfaceMaterialToGameObjects_Private_Void_SurfaceMaterial_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0003D7E4 File Offset: 0x0003B9E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33825, RefRangeEnd = 33826, XrefRangeStart = 33813, XrefRangeEnd = 33825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySurfaceMaterialToTerrains(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref surfaceMaterial;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr_ApplySurfaceMaterialToTerrains_Private_Void_SurfaceMaterial_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0003D834 File Offset: 0x0003BA34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33852, RefRangeEnd = 33853, XrefRangeStart = 33826, XrefRangeEnd = 33852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyObjectFiltering()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr_ApplyObjectFiltering_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0003D868 File Offset: 0x0003BA68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33855, RefRangeEnd = 33857, XrefRangeStart = 33853, XrefRangeEnd = 33855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIncludedByObjectFiltering(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr_IsIncludedByObjectFiltering_Private_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0003D8B8 File Offset: 0x0003BAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33857, XrefRangeEnd = 33858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResonanceAudioMaterialMapper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000044AF File Offset: 0x000026AF
		public ResonanceAudioMaterialMapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0003D8F4 File Offset: 0x0003BAF4
		// (set) Token: 0x06000368 RID: 872 RVA: 0x000044B8 File Offset: 0x000026B8
		public unsafe ResonanceAudioMaterialMap materialMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.NativeFieldInfoPtr_materialMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceAudioMaterialMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.NativeFieldInfoPtr_materialMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0003D924 File Offset: 0x0003BB24
		// (set) Token: 0x0600036A RID: 874 RVA: 0x000044D7 File Offset: 0x000026D7
		public unsafe Dictionary<string, ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData> unityMaterialAcousticMeshDataFromGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.NativeFieldInfoPtr_unityMaterialAcousticMeshDataFromGuid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.NativeFieldInfoPtr_unityMaterialAcousticMeshDataFromGuid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0003D954 File Offset: 0x0003BB54
		// (set) Token: 0x0600036C RID: 876 RVA: 0x000044F6 File Offset: 0x000026F6
		public unsafe Dictionary<string, ResonanceAudioMaterialMapper.TerrainAcousticMeshData> terrainAcousticMeshDataFromGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.NativeFieldInfoPtr_terrainAcousticMeshDataFromGuid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResonanceAudioMaterialMapper.TerrainAcousticMeshData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.NativeFieldInfoPtr_terrainAcousticMeshDataFromGuid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0003D984 File Offset: 0x0003BB84
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00004515 File Offset: 0x00002715
		public unsafe LayerMask reverbLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.NativeFieldInfoPtr_reverbLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.NativeFieldInfoPtr_reverbLayerMask)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0003D9AC File Offset: 0x0003BBAC
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00004530 File Offset: 0x00002730
		public unsafe bool includeNonStaticGameObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.NativeFieldInfoPtr_includeNonStaticGameObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.NativeFieldInfoPtr_includeNonStaticGameObjects)) = value;
			}
		}

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_materialMap;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_unityMaterialAcousticMeshDataFromGuid;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_terrainAcousticMeshDataFromGuid;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_reverbLayerMask;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_includeNonStaticGameObjects;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterialMapping_Public_Void_Il2CppReferenceArray_1_MeshRenderer_Il2CppReferenceArray_1_List_1_String_Il2CppReferenceArray_1_Terrain_Il2CppStringArray_Shader_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_RenderAcousticMeshes_Public_Void_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_GetIncludedAcousticMeshes_Public_List_1_ResonanceAudioAcousticMesh_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_BuildUnityMaterialData_Private_Void_Il2CppReferenceArray_1_MeshRenderer_Il2CppReferenceArray_1_List_1_String_Shader_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_BuildTerrainData_Private_Void_Il2CppReferenceArray_1_Terrain_Il2CppStringArray_Shader_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterialMappingToGuids_Private_Void_List_1_String_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_ApplySurfaceMaterialToGameObjects_Private_Void_SurfaceMaterial_String_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_ApplySurfaceMaterialToTerrains_Private_Void_SurfaceMaterial_String_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_ApplyObjectFiltering_Private_Void_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_IsIncludedByObjectFiltering_Private_Boolean_GameObject_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200029D RID: 669
		public class UnityMaterialAcousticMeshData : global::Il2CppSystem.Object
		{
			// Token: 0x06004A5F RID: 19039 RVA: 0x00113938 File Offset: 0x00111B38
			// Note: this type is marked as 'beforefieldinit'.
			static UnityMaterialAcousticMeshData()
			{
				Il2CppClassPointerStore<ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, "UnityMaterialAcousticMeshData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData>.NativeClassPtr);
				ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData.NativeFieldInfoPtr_acousticMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData>.NativeClassPtr, "acousticMeshes");
				ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData.NativeFieldInfoPtr_subMeshIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData>.NativeClassPtr, "subMeshIndices");
				ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData>.NativeClassPtr, 100663515);
			}

			// Token: 0x06004A60 RID: 19040 RVA: 0x001139A0 File Offset: 0x00111BA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33625, RefRangeEnd = 33626, XrefRangeStart = 33613, XrefRangeEnd = 33625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnityMaterialAcousticMeshData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A61 RID: 19041 RVA: 0x0002BD31 File Offset: 0x00029F31
			public UnityMaterialAcousticMeshData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B12 RID: 6930
			// (get) Token: 0x06004A62 RID: 19042 RVA: 0x001139DC File Offset: 0x00111BDC
			// (set) Token: 0x06004A63 RID: 19043 RVA: 0x0002BD3A File Offset: 0x00029F3A
			public unsafe List<ResonanceAudioAcousticMesh> acousticMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData.NativeFieldInfoPtr_acousticMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ResonanceAudioAcousticMesh>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData.NativeFieldInfoPtr_acousticMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B13 RID: 6931
			// (get) Token: 0x06004A64 RID: 19044 RVA: 0x00113A0C File Offset: 0x00111C0C
			// (set) Token: 0x06004A65 RID: 19045 RVA: 0x0002BD59 File Offset: 0x00029F59
			public unsafe List<int> subMeshIndices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData.NativeFieldInfoPtr_subMeshIndices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.UnityMaterialAcousticMeshData.NativeFieldInfoPtr_subMeshIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003068 RID: 12392
			private static readonly IntPtr NativeFieldInfoPtr_acousticMeshes;

			// Token: 0x04003069 RID: 12393
			private static readonly IntPtr NativeFieldInfoPtr_subMeshIndices;

			// Token: 0x0400306A RID: 12394
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200029E RID: 670
		public class TerrainAcousticMeshData : global::Il2CppSystem.Object
		{
			// Token: 0x06004A66 RID: 19046 RVA: 0x00113A3C File Offset: 0x00111C3C
			// Note: this type is marked as 'beforefieldinit'.
			static TerrainAcousticMeshData()
			{
				Il2CppClassPointerStore<ResonanceAudioMaterialMapper.TerrainAcousticMeshData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResonanceAudioMaterialMapper>.NativeClassPtr, "TerrainAcousticMeshData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioMaterialMapper.TerrainAcousticMeshData>.NativeClassPtr);
				ResonanceAudioMaterialMapper.TerrainAcousticMeshData.NativeFieldInfoPtr_acousticMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMapper.TerrainAcousticMeshData>.NativeClassPtr, "acousticMeshes");
				ResonanceAudioMaterialMapper.TerrainAcousticMeshData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapper.TerrainAcousticMeshData>.NativeClassPtr, 100663516);
			}

			// Token: 0x06004A67 RID: 19047 RVA: 0x00113A90 File Offset: 0x00111C90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33632, RefRangeEnd = 33633, XrefRangeStart = 33626, XrefRangeEnd = 33632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TerrainAcousticMeshData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioMaterialMapper.TerrainAcousticMeshData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapper.TerrainAcousticMeshData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A68 RID: 19048 RVA: 0x0002BD78 File Offset: 0x00029F78
			public TerrainAcousticMeshData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B14 RID: 6932
			// (get) Token: 0x06004A69 RID: 19049 RVA: 0x00113ACC File Offset: 0x00111CCC
			// (set) Token: 0x06004A6A RID: 19050 RVA: 0x0002BD81 File Offset: 0x00029F81
			public unsafe List<ResonanceAudioAcousticMesh> acousticMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.TerrainAcousticMeshData.NativeFieldInfoPtr_acousticMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ResonanceAudioAcousticMesh>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapper.TerrainAcousticMeshData.NativeFieldInfoPtr_acousticMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400306B RID: 12395
			private static readonly IntPtr NativeFieldInfoPtr_acousticMeshes;

			// Token: 0x0400306C RID: 12396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
