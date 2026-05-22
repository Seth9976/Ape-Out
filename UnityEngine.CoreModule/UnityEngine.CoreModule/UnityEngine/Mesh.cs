using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200008F RID: 143
	public sealed class Mesh : Object
	{
		// Token: 0x06000B10 RID: 2832 RVA: 0x0002F6CC File Offset: 0x0002D8CC
		// Note: this type is marked as 'beforefieldinit'.
		static Mesh()
		{
			Il2CppClassPointerStore<Mesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Mesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh>.NativeClassPtr);
			Mesh.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664025);
			Mesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664026);
			Mesh.NativeMethodInfoPtr_SetVertexBufferParamsFromArray_Private_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664027);
			Mesh.NativeMethodInfoPtr_InternalSetVertexBufferData_Private_Void_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664028);
			Mesh.NativeMethodInfoPtr_GetIndexCountImpl_Private_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664029);
			Mesh.NativeMethodInfoPtr_GetTrianglesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664030);
			Mesh.NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664031);
			Mesh.NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664032);
			Mesh.NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664033);
			Mesh.NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664034);
			Mesh.NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664035);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664036);
			Mesh.NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664037);
			Mesh.NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664038);
			Mesh.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664039);
			Mesh.NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664040);
			Mesh.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664041);
			Mesh.NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664042);
			Mesh.NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664043);
			Mesh.NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664044);
			Mesh.NativeMethodInfoPtr_RecalculateNormalsImpl_Private_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664045);
			Mesh.NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664046);
			Mesh.NativeMethodInfoPtr_UploadMeshDataImpl_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664047);
			Mesh.NativeMethodInfoPtr_GetTopologyImpl_Private_MeshTopology_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664048);
			Mesh.NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664049);
			Mesh.NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664050);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664051);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664052);
			Mesh.NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664053);
			Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664054);
			Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664055);
			Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664056);
			Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664057);
			Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664058);
			Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664059);
			Mesh.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664060);
			Mesh.NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664061);
			Mesh.NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664062);
			Mesh.NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664063);
			Mesh.NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664064);
			Mesh.NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664065);
			Mesh.NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664066);
			Mesh.NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664067);
			Mesh.NativeMethodInfoPtr_set_colors_Public_set_Void_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664068);
			Mesh.NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664069);
			Mesh.NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664070);
			Mesh.NativeMethodInfoPtr_GetVertices_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664071);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664072);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664073);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664074);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664075);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664076);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664077);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664078);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664079);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664080);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664081);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664082);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664083);
			Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664084);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664085);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664086);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664087);
			Mesh.NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664088);
			Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664089);
			Mesh.NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664090);
			Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664091);
			Mesh.NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664092);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664093);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664094);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664095);
			Mesh.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664096);
			Mesh.NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664097);
			Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664098);
			Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664099);
			Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664100);
			Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664101);
			Mesh.NativeMethodInfoPtr_GetIndexCount_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664102);
			Mesh.NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664103);
			Mesh.NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664104);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664105);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664106);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664107);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664108);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664109);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664110);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664111);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664112);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664113);
			Mesh.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664114);
			Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664115);
			Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664116);
			Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664117);
			Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664118);
			Mesh.NativeMethodInfoPtr_MarkDynamic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664119);
			Mesh.NativeMethodInfoPtr_UploadMeshData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664120);
			Mesh.NativeMethodInfoPtr_GetTopology_Public_MeshTopology_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664121);
			Mesh.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664122);
			Mesh.NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664123);
			Mesh.FromInstanceIDDelegateField = IL2CPP.ResolveICall<Mesh.FromInstanceIDDelegate>("UnityEngine.Mesh::FromInstanceID");
			Mesh.get_indexFormatDelegateField = IL2CPP.ResolveICall<Mesh.get_indexFormatDelegate>("UnityEngine.Mesh::get_indexFormat");
			Mesh.set_indexFormatDelegateField = IL2CPP.ResolveICall<Mesh.set_indexFormatDelegate>("UnityEngine.Mesh::set_indexFormat");
			Mesh.GetTotalIndexCountDelegateField = IL2CPP.ResolveICall<Mesh.GetTotalIndexCountDelegate>("UnityEngine.Mesh::GetTotalIndexCount");
			Mesh.SetIndexBufferParamsDelegateField = IL2CPP.ResolveICall<Mesh.SetIndexBufferParamsDelegate>("UnityEngine.Mesh::SetIndexBufferParams");
			Mesh.InternalSetIndexBufferDataDelegateField = IL2CPP.ResolveICall<Mesh.InternalSetIndexBufferDataDelegate>("UnityEngine.Mesh::InternalSetIndexBufferData");
			Mesh.InternalSetIndexBufferDataFromArrayDelegateField = IL2CPP.ResolveICall<Mesh.InternalSetIndexBufferDataFromArrayDelegate>("UnityEngine.Mesh::InternalSetIndexBufferDataFromArray");
			Mesh.SetVertexBufferParamsFromPtrDelegateField = IL2CPP.ResolveICall<Mesh.SetVertexBufferParamsFromPtrDelegate>("UnityEngine.Mesh::SetVertexBufferParamsFromPtr");
			Mesh.InternalSetVertexBufferDataFromArrayDelegateField = IL2CPP.ResolveICall<Mesh.InternalSetVertexBufferDataFromArrayDelegate>("UnityEngine.Mesh::InternalSetVertexBufferDataFromArray");
			Mesh.GetVertexAttributesAllocDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributesAllocDelegate>("UnityEngine.Mesh::GetVertexAttributesAlloc");
			Mesh.GetVertexAttributesArrayDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributesArrayDelegate>("UnityEngine.Mesh::GetVertexAttributesArray");
			Mesh.GetVertexAttributesListDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributesListDelegate>("UnityEngine.Mesh::GetVertexAttributesList");
			Mesh.GetVertexAttributeCountImplDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributeCountImplDelegate>("UnityEngine.Mesh::GetVertexAttributeCountImpl");
			Mesh.GetIndexStartImplDelegateField = IL2CPP.ResolveICall<Mesh.GetIndexStartImplDelegate>("UnityEngine.Mesh::GetIndexStartImpl");
			Mesh.GetTrianglesCountImplDelegateField = IL2CPP.ResolveICall<Mesh.GetTrianglesCountImplDelegate>("UnityEngine.Mesh::GetTrianglesCountImpl");
			Mesh.GetBaseVertexImplDelegateField = IL2CPP.ResolveICall<Mesh.GetBaseVertexImplDelegate>("UnityEngine.Mesh::GetBaseVertexImpl");
			Mesh.SetIndicesNativeArrayImplDelegateField = IL2CPP.ResolveICall<Mesh.SetIndicesNativeArrayImplDelegate>("UnityEngine.Mesh::SetIndicesNativeArrayImpl");
			Mesh.GetTrianglesNonAllocImplDelegateField = IL2CPP.ResolveICall<Mesh.GetTrianglesNonAllocImplDelegate>("UnityEngine.Mesh::GetTrianglesNonAllocImpl");
			Mesh.GetTrianglesNonAllocImpl16DelegateField = IL2CPP.ResolveICall<Mesh.GetTrianglesNonAllocImpl16Delegate>("UnityEngine.Mesh::GetTrianglesNonAllocImpl16");
			Mesh.GetIndicesNonAllocImplDelegateField = IL2CPP.ResolveICall<Mesh.GetIndicesNonAllocImplDelegate>("UnityEngine.Mesh::GetIndicesNonAllocImpl");
			Mesh.GetIndicesNonAllocImpl16DelegateField = IL2CPP.ResolveICall<Mesh.GetIndicesNonAllocImpl16Delegate>("UnityEngine.Mesh::GetIndicesNonAllocImpl16");
			Mesh.GetVertexAttributeDimensionDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributeDimensionDelegate>("UnityEngine.Mesh::GetVertexAttributeDimension");
			Mesh.GetVertexAttributeFormatDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributeFormatDelegate>("UnityEngine.Mesh::GetVertexAttributeFormat");
			Mesh.SetNativeArrayForChannelImplDelegateField = IL2CPP.ResolveICall<Mesh.SetNativeArrayForChannelImplDelegate>("UnityEngine.Mesh::SetNativeArrayForChannelImpl");
			Mesh.get_vertexBufferCountDelegateField = IL2CPP.ResolveICall<Mesh.get_vertexBufferCountDelegate>("UnityEngine.Mesh::get_vertexBufferCount");
			Mesh.GetNativeVertexBufferPtrDelegateField = IL2CPP.ResolveICall<Mesh.GetNativeVertexBufferPtrDelegate>("UnityEngine.Mesh::GetNativeVertexBufferPtr");
			Mesh.GetNativeIndexBufferPtrDelegateField = IL2CPP.ResolveICall<Mesh.GetNativeIndexBufferPtrDelegate>("UnityEngine.Mesh::GetNativeIndexBufferPtr");
			Mesh.get_blendShapeCountDelegateField = IL2CPP.ResolveICall<Mesh.get_blendShapeCountDelegate>("UnityEngine.Mesh::get_blendShapeCount");
			Mesh.ClearBlendShapesDelegateField = IL2CPP.ResolveICall<Mesh.ClearBlendShapesDelegate>("UnityEngine.Mesh::ClearBlendShapes");
			Mesh.GetBlendShapeNameDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeNameDelegate>("UnityEngine.Mesh::GetBlendShapeName");
			Mesh.GetBlendShapeIndexDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeIndexDelegate>("UnityEngine.Mesh::GetBlendShapeIndex");
			Mesh.GetBlendShapeFrameCountDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeFrameCountDelegate>("UnityEngine.Mesh::GetBlendShapeFrameCount");
			Mesh.GetBlendShapeFrameWeightDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeFrameWeightDelegate>("UnityEngine.Mesh::GetBlendShapeFrameWeight");
			Mesh.GetBlendShapeFrameVerticesDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeFrameVerticesDelegate>("UnityEngine.Mesh::GetBlendShapeFrameVertices");
			Mesh.AddBlendShapeFrameDelegateField = IL2CPP.ResolveICall<Mesh.AddBlendShapeFrameDelegate>("UnityEngine.Mesh::AddBlendShapeFrame");
			Mesh.HasBoneWeightsDelegateField = IL2CPP.ResolveICall<Mesh.HasBoneWeightsDelegate>("UnityEngine.Mesh::HasBoneWeights");
			Mesh.InternalSetBoneWeightsDelegateField = IL2CPP.ResolveICall<Mesh.InternalSetBoneWeightsDelegate>("UnityEngine.Mesh::InternalSetBoneWeights");
			Mesh.GetAllBoneWeightsArraySizeDelegateField = IL2CPP.ResolveICall<Mesh.GetAllBoneWeightsArraySizeDelegate>("UnityEngine.Mesh::GetAllBoneWeightsArraySize");
			Mesh.GetAllBoneWeightsArrayDelegateField = IL2CPP.ResolveICall<Mesh.GetAllBoneWeightsArrayDelegate>("UnityEngine.Mesh::GetAllBoneWeightsArray");
			Mesh.GetBonesPerVertexArrayDelegateField = IL2CPP.ResolveICall<Mesh.GetBonesPerVertexArrayDelegate>("UnityEngine.Mesh::GetBonesPerVertexArray");
			Mesh.GetBindposeCountDelegateField = IL2CPP.ResolveICall<Mesh.GetBindposeCountDelegate>("UnityEngine.Mesh::GetBindposeCount");
			Mesh.get_bindposesDelegateField = IL2CPP.ResolveICall<Mesh.get_bindposesDelegate>("UnityEngine.Mesh::get_bindposes");
			Mesh.set_bindposesDelegateField = IL2CPP.ResolveICall<Mesh.set_bindposesDelegate>("UnityEngine.Mesh::set_bindposes");
			Mesh.GetBindposesNonAllocImplDelegateField = IL2CPP.ResolveICall<Mesh.GetBindposesNonAllocImplDelegate>("UnityEngine.Mesh::GetBindposesNonAllocImpl");
			Mesh.get_isReadableDelegateField = IL2CPP.ResolveICall<Mesh.get_isReadableDelegate>("UnityEngine.Mesh::get_isReadable");
			Mesh.set_subMeshCountDelegateField = IL2CPP.ResolveICall<Mesh.set_subMeshCountDelegate>("UnityEngine.Mesh::set_subMeshCount");
			Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegateField = IL2CPP.ResolveICall<Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegate>("UnityEngine.Mesh::SetAllSubMeshesAtOnceFromNativeArray");
			Mesh.RecalculateTangentsImplDelegateField = IL2CPP.ResolveICall<Mesh.RecalculateTangentsImplDelegate>("UnityEngine.Mesh::RecalculateTangentsImpl");
			Mesh.MarkModifiedDelegateField = IL2CPP.ResolveICall<Mesh.MarkModifiedDelegate>("UnityEngine.Mesh::MarkModified");
			Mesh.RecalculateUVDistributionMetricImplDelegateField = IL2CPP.ResolveICall<Mesh.RecalculateUVDistributionMetricImplDelegate>("UnityEngine.Mesh::RecalculateUVDistributionMetricImpl");
			Mesh.RecalculateUVDistributionMetricsImplDelegateField = IL2CPP.ResolveICall<Mesh.RecalculateUVDistributionMetricsImplDelegate>("UnityEngine.Mesh::RecalculateUVDistributionMetricsImpl");
			Mesh.GetUVDistributionMetricDelegateField = IL2CPP.ResolveICall<Mesh.GetUVDistributionMetricDelegate>("UnityEngine.Mesh::GetUVDistributionMetric");
			Mesh.OptimizeImplDelegateField = IL2CPP.ResolveICall<Mesh.OptimizeImplDelegate>("UnityEngine.Mesh::OptimizeImpl");
			Mesh.OptimizeIndexBuffersImplDelegateField = IL2CPP.ResolveICall<Mesh.OptimizeIndexBuffersImplDelegate>("UnityEngine.Mesh::OptimizeIndexBuffersImpl");
			Mesh.OptimizeReorderVertexBufferImplDelegateField = IL2CPP.ResolveICall<Mesh.OptimizeReorderVertexBufferImplDelegate>("UnityEngine.Mesh::OptimizeReorderVertexBufferImpl");
			Mesh.GetVertexAttribute_InjectedDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttribute_InjectedDelegate>("UnityEngine.Mesh::GetVertexAttribute_Injected");
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00030200 File Offset: 0x0002E400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489475, XrefRangeEnd = 489479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Mesh mono)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00030238 File Offset: 0x0002E438
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 489486, RefRangeEnd = 489505, XrefRangeStart = 489479, XrefRangeEnd = 489486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mesh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00030274 File Offset: 0x0002E474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489509, RefRangeEnd = 489510, XrefRangeStart = 489505, XrefRangeEnd = 489509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferParamsFromArray(int vertexCount, [Optional] Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			if (attributes == null)
			{
				attributes = new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertexBufferParamsFromArray_Private_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x000302D4 File Offset: 0x0002E4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489510, XrefRangeEnd = 489514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stream;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_InternalSetVertexBufferData_Private_Void_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00030368 File Offset: 0x0002E568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489514, XrefRangeEnd = 489518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIndexCountImpl(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexCountImpl_Private_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x000303B4 File Offset: 0x0002E5B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489522, RefRangeEnd = 489524, XrefRangeStart = 489518, XrefRangeEnd = 489522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetTrianglesImpl(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTrianglesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00030410 File Offset: 0x0002E610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489524, XrefRangeEnd = 489528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndicesImpl(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0003046C File Offset: 0x0002E66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489528, XrefRangeEnd = 489532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndicesImpl(int submesh, MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayStart;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00030514 File Offset: 0x0002E714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489532, XrefRangeEnd = 489536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00030554 File Offset: 0x0002E754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489536, XrefRangeEnd = 489540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000305A0 File Offset: 0x0002E7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489540, XrefRangeEnd = 489544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00030648 File Offset: 0x0002E848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489548, RefRangeEnd = 489549, XrefRangeStart = 489544, XrefRangeEnd = 489548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x000306B0 File Offset: 0x0002E8B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489553, RefRangeEnd = 489554, XrefRangeStart = 489549, XrefRangeEnd = 489553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00030720 File Offset: 0x0002E920
		public unsafe bool canAccess
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489554, XrefRangeEnd = 489558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0003075C File Offset: 0x0002E95C
		public unsafe int vertexCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489558, XrefRangeEnd = 489562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00030798 File Offset: 0x0002E998
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0000856B File Offset: 0x0000676B
		public unsafe int subMeshCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489562, XrefRangeEnd = 489566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Mesh.set_subMeshCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x000307D4 File Offset: 0x0002E9D4
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00030810 File Offset: 0x0002EA10
		public unsafe Bounds bounds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489566, XrefRangeEnd = 489568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489568, XrefRangeEnd = 489570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00030850 File Offset: 0x0002EA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489570, XrefRangeEnd = 489574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearImpl(bool keepVertexLayout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keepVertexLayout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00030890 File Offset: 0x0002EA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489574, XrefRangeEnd = 489578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000308D0 File Offset: 0x0002EAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489578, XrefRangeEnd = 489582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateNormalsImpl_Private_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00030910 File Offset: 0x0002EB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489582, XrefRangeEnd = 489586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDynamicImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00030944 File Offset: 0x0002EB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489586, XrefRangeEnd = 489590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UploadMeshDataImpl(bool markNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref markNoLongerReadable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_UploadMeshDataImpl_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00030984 File Offset: 0x0002EB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489590, XrefRangeEnd = 489594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshTopology GetTopologyImpl(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTopologyImpl_Private_MeshTopology_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x000309D0 File Offset: 0x0002EBD0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 489594, RefRangeEnd = 489600, XrefRangeStart = 489594, XrefRangeEnd = 489594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.VertexAttribute GetUVChannel(int uvIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00030A10 File Offset: 0x0002EC10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 489600, RefRangeEnd = 489603, XrefRangeStart = 489600, XrefRangeEnd = 489600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00030A50 File Offset: 0x0002EC50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489616, RefRangeEnd = 489618, XrefRangeStart = 489603, XrefRangeEnd = 489616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00030AB0 File Offset: 0x0002ECB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489618, XrefRangeEnd = 489619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00030AF4 File Offset: 0x0002ECF4
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 489625, RefRangeEnd = 489715, XrefRangeStart = 489619, XrefRangeEnd = 489625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesArrayLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00030B9C File Offset: 0x0002ED9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489715, XrefRangeEnd = 489718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Il2CppArrayBase<T> values, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00030C18 File Offset: 0x0002EE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489718, XrefRangeEnd = 489722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, Il2CppArrayBase<T> values, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00030C78 File Offset: 0x0002EE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489722, XrefRangeEnd = 489725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00030D10 File Offset: 0x0002EF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489725, XrefRangeEnd = 489729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00030D8C File Offset: 0x0002EF8C
		[CallerCount(0)]
		public unsafe void GetListForChannel<T>(List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00030DF8 File Offset: 0x0002EFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489729, XrefRangeEnd = 489736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetListForChannel<T>(List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim, UnityEngine.Rendering.VertexAttributeFormat channelType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00030E74 File Offset: 0x0002F074
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x00030EB4 File Offset: 0x0002F0B4
		public unsafe Il2CppStructArray<Vector3> vertices
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489736, XrefRangeEnd = 489738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489738, XrefRangeEnd = 489742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00030EF8 File Offset: 0x0002F0F8
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00030F38 File Offset: 0x0002F138
		public unsafe Il2CppStructArray<Vector3> normals
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489742, XrefRangeEnd = 489744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489744, XrefRangeEnd = 489748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00030F7C File Offset: 0x0002F17C
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00030FBC File Offset: 0x0002F1BC
		public unsafe Il2CppStructArray<Vector4> tangents
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489748, XrefRangeEnd = 489750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489750, XrefRangeEnd = 489754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0003262C File Offset: 0x0003082C
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x00031000 File Offset: 0x0002F200
		public unsafe Il2CppStructArray<Vector2> uv
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord0);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489754, XrefRangeEnd = 489758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00032648 File Offset: 0x00030848
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x00031044 File Offset: 0x0002F244
		public unsafe Il2CppStructArray<Vector2> uv2
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord1);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489758, XrefRangeEnd = 489762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0003270C File Offset: 0x0003090C
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00031088 File Offset: 0x0002F288
		public unsafe Il2CppStructArray<Color> colors
		{
			get
			{
				return this.GetAllocArrayFromChannel<Color>(UnityEngine.Rendering.VertexAttribute.Color);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489762, XrefRangeEnd = 489766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_colors_Public_set_Void_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x000310CC File Offset: 0x0002F2CC
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x0003110C File Offset: 0x0002F30C
		public unsafe Il2CppStructArray<Color32> colors32
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489766, XrefRangeEnd = 489769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489769, XrefRangeEnd = 489773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00031150 File Offset: 0x0002F350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489777, RefRangeEnd = 489778, XrefRangeStart = 489773, XrefRangeEnd = 489777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetVertices(List<Vector3> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertices_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00031194 File Offset: 0x0002F394
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 489783, RefRangeEnd = 489786, XrefRangeStart = 489778, XrefRangeEnd = 489783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000311D8 File Offset: 0x0002F3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489786, XrefRangeEnd = 489788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00031238 File Offset: 0x0002F438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489788, XrefRangeEnd = 489790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000312A4 File Offset: 0x0002F4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489790, XrefRangeEnd = 489795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x000312E8 File Offset: 0x0002F4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489795, XrefRangeEnd = 489797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00031348 File Offset: 0x0002F548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489797, XrefRangeEnd = 489799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000313B4 File Offset: 0x0002F5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489799, XrefRangeEnd = 489807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000313F8 File Offset: 0x0002F5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489807, XrefRangeEnd = 489812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00031458 File Offset: 0x0002F658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489812, XrefRangeEnd = 489817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x000314C4 File Offset: 0x0002F6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489817, XrefRangeEnd = 489825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00031508 File Offset: 0x0002F708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489825, XrefRangeEnd = 489830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00031568 File Offset: 0x0002F768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489830, XrefRangeEnd = 489835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000315D4 File Offset: 0x0002F7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489835, XrefRangeEnd = 489843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0003165C File Offset: 0x0002F85C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 489856, RefRangeEnd = 489860, XrefRangeStart = 489843, XrefRangeEnd = 489856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000316AC File Offset: 0x0002F8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489860, XrefRangeEnd = 489870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00031718 File Offset: 0x0002F918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489870, XrefRangeEnd = 489880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00031794 File Offset: 0x0002F994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489880, XrefRangeEnd = 489883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uvIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x000317F4 File Offset: 0x0002F9F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 489888, RefRangeEnd = 489892, XrefRangeStart = 489883, XrefRangeEnd = 489888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUVs(int channel, List<Vector4> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00031844 File Offset: 0x0002FA44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489509, RefRangeEnd = 489510, XrefRangeStart = 489509, XrefRangeEnd = 489510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferParams(int vertexCount, [Optional] Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			if (attributes == null)
			{
				attributes = new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000318A4 File Offset: 0x0002FAA4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 489924, RefRangeEnd = 489933, XrefRangeStart = 489892, XrefRangeEnd = 489924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00031934 File Offset: 0x0002FB34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489941, RefRangeEnd = 489943, XrefRangeStart = 489933, XrefRangeEnd = 489941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintErrorCantAccessIndices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00031968 File Offset: 0x0002FB68
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 489951, RefRangeEnd = 489973, XrefRangeStart = 489943, XrefRangeEnd = 489951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorAboutTriangles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000319C0 File Offset: 0x0002FBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489973, XrefRangeEnd = 489974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmeshTriangles(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00031A0C File Offset: 0x0002FC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489974, XrefRangeEnd = 489975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmeshIndices(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x00031A58 File Offset: 0x0002FC58
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x00031A98 File Offset: 0x0002FC98
		public unsafe Il2CppStructArray<int> triangles
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 489983, RefRangeEnd = 489985, XrefRangeStart = 489975, XrefRangeEnd = 489983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 489992, RefRangeEnd = 490009, XrefRangeStart = 489985, XrefRangeEnd = 489992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00031ADC File Offset: 0x0002FCDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490012, RefRangeEnd = 490013, XrefRangeStart = 490009, XrefRangeEnd = 490012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetTriangles(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00031B28 File Offset: 0x0002FD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490013, XrefRangeEnd = 490016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetTriangles(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00031B84 File Offset: 0x0002FD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490016, XrefRangeEnd = 490020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndices(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00031BD0 File Offset: 0x0002FDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490020, XrefRangeEnd = 490024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndices(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00031C2C File Offset: 0x0002FE2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490038, RefRangeEnd = 490040, XrefRangeStart = 490024, XrefRangeEnd = 490038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIndexCount(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexCount_Public_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00031C78 File Offset: 0x0002FE78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 490040, RefRangeEnd = 490044, XrefRangeStart = 490040, XrefRangeEnd = 490040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIndicesArrayRange(int valuesLength, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valuesLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00031CD4 File Offset: 0x0002FED4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 490049, RefRangeEnd = 490062, XrefRangeStart = 490044, XrefRangeEnd = 490049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrianglesImpl(int submesh, UnityEngine.Rendering.IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesArrayLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00031D78 File Offset: 0x0002FF78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490068, RefRangeEnd = 490070, XrefRangeStart = 490062, XrefRangeEnd = 490068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<int> triangles, int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00031DC8 File Offset: 0x0002FFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490070, XrefRangeEnd = 490076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<int> triangles, int submesh, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00031E34 File Offset: 0x00030034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490076, XrefRangeEnd = 490080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00031EBC File Offset: 0x000300BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490080, XrefRangeEnd = 490090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00031F0C File Offset: 0x0003010C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490090, XrefRangeEnd = 490100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00031F78 File Offset: 0x00030178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490100, XrefRangeEnd = 490107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00032000 File Offset: 0x00030200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490107, XrefRangeEnd = 490115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh, bool calculateBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0003206C File Offset: 0x0003026C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490115, XrefRangeEnd = 490123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x000320E8 File Offset: 0x000302E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490123, XrefRangeEnd = 490129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00032180 File Offset: 0x00030380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490129, XrefRangeEnd = 490133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x000321B4 File Offset: 0x000303B4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 490145, RefRangeEnd = 490168, XrefRangeStart = 490133, XrefRangeEnd = 490145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000321E8 File Offset: 0x000303E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 490180, RefRangeEnd = 490183, XrefRangeStart = 490168, XrefRangeEnd = 490180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNormals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0003221C File Offset: 0x0003041C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490183, XrefRangeEnd = 490195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0003225C File Offset: 0x0003045C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490195, XrefRangeEnd = 490207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0003229C File Offset: 0x0003049C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490211, RefRangeEnd = 490213, XrefRangeStart = 490207, XrefRangeEnd = 490211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDynamic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_MarkDynamic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000322D0 File Offset: 0x000304D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490213, XrefRangeEnd = 490217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UploadMeshData(bool markNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref markNoLongerReadable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_UploadMeshData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00032310 File Offset: 0x00030510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 490227, RefRangeEnd = 490230, XrefRangeStart = 490217, XrefRangeEnd = 490227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshTopology GetTopology(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTopology_Public_MeshTopology_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0003235C File Offset: 0x0003055C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490230, XrefRangeEnd = 490234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0003239C File Offset: 0x0003059C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490234, XrefRangeEnd = 490242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_bounds_Injected(ref Bounds value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000081FE File Offset: 0x000063FE
		public void SetVertexBufferParamsFromArray(int vertexCount, params UnityEngine.Rendering.VertexAttributeDescriptor[] attributes)
		{
			this.SetVertexBufferParamsFromArray(vertexCount, new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(attributes));
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0000820D File Offset: 0x0000640D
		public void SetVertexBufferParams(int vertexCount, params UnityEngine.Rendering.VertexAttributeDescriptor[] attributes)
		{
			this.SetVertexBufferParams(vertexCount, new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(attributes));
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0000821C File Offset: 0x0000641C
		public Mesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x000323DC File Offset: 0x000305DC
		public static Mesh FromInstanceID(int id)
		{
			IntPtr intPtr = Mesh.FromInstanceIDDelegateField(id);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00008225 File Offset: 0x00006425
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x00008237 File Offset: 0x00006437
		public UnityEngine.Rendering.IndexFormat indexFormat
		{
			get
			{
				return Mesh.get_indexFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Mesh.set_indexFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0000824A File Offset: 0x0000644A
		public uint GetTotalIndexCount()
		{
			return Mesh.GetTotalIndexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0000825C File Offset: 0x0000645C
		public void SetIndexBufferParams(int indexCount, UnityEngine.Rendering.IndexFormat format)
		{
			Mesh.SetIndexBufferParamsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), indexCount, format);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00008270 File Offset: 0x00006470
		public void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.InternalSetIndexBufferDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, dataStart, meshBufferStart, count, elemSize, flags);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0000828B File Offset: 0x0000648B
		public void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.InternalSetIndexBufferDataFromArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), dataStart, meshBufferStart, count, elemSize, flags);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x000082AB File Offset: 0x000064AB
		public void SetVertexBufferParamsFromPtr(int vertexCount, IntPtr attributesPtr, int attributesCount)
		{
			Mesh.SetVertexBufferParamsFromPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), vertexCount, attributesPtr, attributesCount);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00032404 File Offset: 0x00030604
		public void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.InternalSetVertexBufferDataFromArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stream, IL2CPP.Il2CppObjectBaseToPtr(data), dataStart, meshBufferStart, count, elemSize, flags);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00032434 File Offset: 0x00030634
		public Array GetVertexAttributesAlloc()
		{
			IntPtr intPtr = Mesh.GetVertexAttributesAllocDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x000082C0 File Offset: 0x000064C0
		public int GetVertexAttributesArray(Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			return Mesh.GetVertexAttributesArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(attributes));
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000082D8 File Offset: 0x000064D8
		public int GetVertexAttributesList(List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			return Mesh.GetVertexAttributesListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(attributes));
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000082F0 File Offset: 0x000064F0
		public int GetVertexAttributeCountImpl()
		{
			return Mesh.GetVertexAttributeCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00032460 File Offset: 0x00030660
		public UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(int index)
		{
			UnityEngine.Rendering.VertexAttributeDescriptor vertexAttributeDescriptor;
			this.GetVertexAttribute_Injected(index, out vertexAttributeDescriptor);
			return vertexAttributeDescriptor;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00008302 File Offset: 0x00006502
		public uint GetIndexStartImpl(int submesh)
		{
			return Mesh.GetIndexStartImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00008315 File Offset: 0x00006515
		public uint GetTrianglesCountImpl(int submesh)
		{
			return Mesh.GetTrianglesCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00008328 File Offset: 0x00006528
		public uint GetBaseVertexImpl(int submesh)
		{
			return Mesh.GetBaseVertexImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00032478 File Offset: 0x00030678
		public void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
		{
			Mesh.SetIndicesNativeArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh, topology, indicesFormat, indices, arrayStart, arraySize, calculateBounds, baseVertex);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0000833B File Offset: 0x0000653B
		public void GetTrianglesNonAllocImpl([Out] Il2CppStructArray<int> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetTrianglesNonAllocImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00008355 File Offset: 0x00006555
		public void GetTrianglesNonAllocImpl16([Out] Il2CppStructArray<ushort> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetTrianglesNonAllocImpl16DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0000836F File Offset: 0x0000656F
		public void GetIndicesNonAllocImpl([Out] Il2CppStructArray<int> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetIndicesNonAllocImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00008389 File Offset: 0x00006589
		public void GetIndicesNonAllocImpl16([Out] Il2CppStructArray<ushort> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetIndicesNonAllocImpl16DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000083A3 File Offset: 0x000065A3
		public int GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute attr)
		{
			return Mesh.GetVertexAttributeDimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), attr);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000083B6 File Offset: 0x000065B6
		public UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute attr)
		{
			return Mesh.GetVertexAttributeFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), attr);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000324A4 File Offset: 0x000306A4
		public void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.SetNativeArrayForChannelImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), channel, format, dim, values, arraySize, valuesStart, valuesCount, flags);
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x000083C9 File Offset: 0x000065C9
		public int vertexBufferCount
		{
			get
			{
				return Mesh.get_vertexBufferCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000083DB File Offset: 0x000065DB
		public IntPtr GetNativeVertexBufferPtr(int index)
		{
			return Mesh.GetNativeVertexBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000083EE File Offset: 0x000065EE
		public IntPtr GetNativeIndexBufferPtr()
		{
			return Mesh.GetNativeIndexBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00008400 File Offset: 0x00006600
		public int blendShapeCount
		{
			get
			{
				return Mesh.get_blendShapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00008412 File Offset: 0x00006612
		public void ClearBlendShapes()
		{
			Mesh.ClearBlendShapesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x000324D0 File Offset: 0x000306D0
		public string GetBlendShapeName(int shapeIndex)
		{
			IntPtr intPtr = Mesh.GetBlendShapeNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00008424 File Offset: 0x00006624
		public int GetBlendShapeIndex(string blendShapeName)
		{
			return Mesh.GetBlendShapeIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(blendShapeName));
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0000843C File Offset: 0x0000663C
		public int GetBlendShapeFrameCount(int shapeIndex)
		{
			return Mesh.GetBlendShapeFrameCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0000844F File Offset: 0x0000664F
		public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex)
		{
			return Mesh.GetBlendShapeFrameWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex, frameIndex);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00008463 File Offset: 0x00006663
		public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Il2CppStructArray<Vector3> deltaVertices, Il2CppStructArray<Vector3> deltaNormals, Il2CppStructArray<Vector3> deltaTangents)
		{
			Mesh.GetBlendShapeFrameVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex, frameIndex, IL2CPP.Il2CppObjectBaseToPtr(deltaVertices), IL2CPP.Il2CppObjectBaseToPtr(deltaNormals), IL2CPP.Il2CppObjectBaseToPtr(deltaTangents));
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0000848B File Offset: 0x0000668B
		public void AddBlendShapeFrame(string shapeName, float frameWeight, Il2CppStructArray<Vector3> deltaVertices, Il2CppStructArray<Vector3> deltaNormals, Il2CppStructArray<Vector3> deltaTangents)
		{
			Mesh.AddBlendShapeFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(shapeName), frameWeight, IL2CPP.Il2CppObjectBaseToPtr(deltaVertices), IL2CPP.Il2CppObjectBaseToPtr(deltaNormals), IL2CPP.Il2CppObjectBaseToPtr(deltaTangents));
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000084B8 File Offset: 0x000066B8
		public bool HasBoneWeights()
		{
			return Mesh.HasBoneWeightsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000084CA File Offset: 0x000066CA
		public void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize)
		{
			Mesh.InternalSetBoneWeightsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bonesPerVertex, bonesPerVertexSize, weights, weightsSize);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x000324F8 File Offset: 0x000306F8
		public unsafe Unity.Collections.NativeArray<byte> GetBonesPerVertex()
		{
			int num = (this.HasBoneWeights() ? this.vertexCount : 0);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>((void*)this.GetBonesPerVertexArray(), num, Unity.Collections.Allocator.None);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000084E1 File Offset: 0x000066E1
		public int GetAllBoneWeightsArraySize()
		{
			return Mesh.GetAllBoneWeightsArraySizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x000084F3 File Offset: 0x000066F3
		public IntPtr GetAllBoneWeightsArray()
		{
			return Mesh.GetAllBoneWeightsArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00008505 File Offset: 0x00006705
		public IntPtr GetBonesPerVertexArray()
		{
			return Mesh.GetBonesPerVertexArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00008517 File Offset: 0x00006717
		public int GetBindposeCount()
		{
			return Mesh.GetBindposeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x00032530 File Offset: 0x00030730
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x00008529 File Offset: 0x00006729
		public Il2CppStructArray<Matrix4x4> bindposes
		{
			get
			{
				IntPtr intPtr = Mesh.get_bindposesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				Mesh.set_bindposesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00008541 File Offset: 0x00006741
		public void GetBindposesNonAllocImpl([Out] Il2CppStructArray<Matrix4x4> values)
		{
			Mesh.GetBindposesNonAllocImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00008559 File Offset: 0x00006759
		public bool isReadable
		{
			get
			{
				return Mesh.get_isReadableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0000857E File Offset: 0x0000677E
		public void SetAllSubMeshesAtOnceFromNativeArray(IntPtr desc, int start, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), desc, start, count, flags);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00008595 File Offset: 0x00006795
		public void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.RecalculateTangentsImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), flags);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x000085A8 File Offset: 0x000067A8
		public void MarkModified()
		{
			Mesh.MarkModifiedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000085BA File Offset: 0x000067BA
		public void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold)
		{
			Mesh.RecalculateUVDistributionMetricImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), uvSetIndex, uvAreaThreshold);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x000085CE File Offset: 0x000067CE
		public void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold)
		{
			Mesh.RecalculateUVDistributionMetricsImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), uvAreaThreshold);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000085E1 File Offset: 0x000067E1
		public float GetUVDistributionMetric(int uvSetIndex)
		{
			return Mesh.GetUVDistributionMetricDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), uvSetIndex);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x000085F4 File Offset: 0x000067F4
		public void OptimizeImpl()
		{
			Mesh.OptimizeImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00008606 File Offset: 0x00006806
		public void OptimizeIndexBuffersImpl()
		{
			Mesh.OptimizeIndexBuffersImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00008618 File Offset: 0x00006818
		public void OptimizeReorderVertexBufferImpl()
		{
			Mesh.OptimizeReorderVertexBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0003255C File Offset: 0x0003075C
		public void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				bool flag = valuesStart < 0;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("valuesStart", valuesStart, "Mesh data array start index can't be negative.");
				}
				bool flag2 = valuesCount < 0;
				if (flag2)
				{
					throw new ArgumentOutOfRangeException("valuesCount", valuesCount, "Mesh data array length can't be negative.");
				}
				bool flag3 = valuesStart >= valuesArrayLength && valuesCount != 0;
				if (flag3)
				{
					throw new ArgumentOutOfRangeException("valuesStart", valuesStart, "Mesh data array start is outside of array size.");
				}
				bool flag4 = valuesStart + valuesCount > valuesArrayLength;
				if (flag4)
				{
					throw new ArgumentOutOfRangeException("valuesCount", valuesStart + valuesCount, "Mesh data array start+count is outside of array size.");
				}
				this.SetNativeArrayForChannelImpl(channel, format, dim, values, valuesArrayLength, valuesStart, valuesCount, flags);
			}
			else
			{
				this.PrintErrorCantAccessChannel(channel);
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00032664 File Offset: 0x00030864
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x0000862A File Offset: 0x0000682A
		public Il2CppStructArray<Vector2> uv3
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord2);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord2, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00032680 File Offset: 0x00030880
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x00008637 File Offset: 0x00006837
		public Il2CppStructArray<Vector2> uv4
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord3);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord3, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0003269C File Offset: 0x0003089C
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x00008644 File Offset: 0x00006844
		public Il2CppStructArray<Vector2> uv5
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord4);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord4, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x000326B8 File Offset: 0x000308B8
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x00008651 File Offset: 0x00006851
		public Il2CppStructArray<Vector2> uv6
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord5);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord5, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x000326D4 File Offset: 0x000308D4
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x0000865F File Offset: 0x0000685F
		public Il2CppStructArray<Vector2> uv7
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord6);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord6, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x000326F0 File Offset: 0x000308F0
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0000866D File Offset: 0x0000686D
		public Il2CppStructArray<Vector2> uv8
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord7);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord7, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0000867B File Offset: 0x0000687B
		public void SetVertices(Il2CppStructArray<Vector3> inVertices)
		{
			this.SetVertices(inVertices, 0, NoAllocHelpers.SafeLength(inVertices));
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0000868D File Offset: 0x0000688D
		public void SetVertices(Il2CppStructArray<Vector3> inVertices, int start, int length)
		{
			this.SetVertices(inVertices, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00032728 File Offset: 0x00030928
		public void SetVertices(Il2CppStructArray<Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Position, UnityEngine.Rendering.VertexAttributeFormat.Float32, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Position), inVertices, NoAllocHelpers.SafeLength(inVertices), start, length, flags);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0000869B File Offset: 0x0000689B
		public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices) where T : struct
		{
			this.SetVertices<T>(inVertices, 0, inVertices.Length);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000086AE File Offset: 0x000068AE
		public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length) where T : struct
		{
			this.SetVertices<T>(inVertices, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00032750 File Offset: 0x00030950
		public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != 12;
			if (flag)
			{
				throw new ArgumentException("SetVertices with NativeArray should use struct type that is 12 bytes (3x float) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Position, UnityEngine.Rendering.VertexAttributeFormat.Float32, 3, (IntPtr)inVertices.GetUnsafeReadOnlyPtr<T>(), inVertices.Length, start, length, flags);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0003279C File Offset: 0x0003099C
		public void GetNormals(List<Vector3> normals)
		{
			bool flag = normals == null;
			if (flag)
			{
				throw new ArgumentNullException("normals", "The result normals list cannot be null.");
			}
			this.GetListForChannel<Vector3>(normals, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Normal, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Normal));
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000086BC File Offset: 0x000068BC
		public void SetNormals(Il2CppStructArray<Vector3> inNormals)
		{
			this.SetNormals(inNormals, 0, NoAllocHelpers.SafeLength(inNormals));
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x000086CE File Offset: 0x000068CE
		public void SetNormals(Il2CppStructArray<Vector3> inNormals, int start, int length)
		{
			this.SetNormals(inNormals, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x000327D8 File Offset: 0x000309D8
		public void SetNormals(Il2CppStructArray<Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Normal, UnityEngine.Rendering.VertexAttributeFormat.Float32, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Normal), inNormals, NoAllocHelpers.SafeLength(inNormals), start, length, flags);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000086DC File Offset: 0x000068DC
		public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals) where T : struct
		{
			this.SetNormals<T>(inNormals, 0, inNormals.Length);
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x000086EF File Offset: 0x000068EF
		public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length) where T : struct
		{
			this.SetNormals<T>(inNormals, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00032800 File Offset: 0x00030A00
		public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != 12;
			if (flag)
			{
				throw new ArgumentException("SetNormals with NativeArray should use struct type that is 12 bytes (3x float) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Normal, UnityEngine.Rendering.VertexAttributeFormat.Float32, 3, (IntPtr)inNormals.GetUnsafeReadOnlyPtr<T>(), inNormals.Length, start, length, flags);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0003284C File Offset: 0x00030A4C
		public void GetTangents(List<Vector4> tangents)
		{
			bool flag = tangents == null;
			if (flag)
			{
				throw new ArgumentNullException("tangents", "The result tangents list cannot be null.");
			}
			this.GetListForChannel<Vector4>(tangents, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Tangent, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Tangent));
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x000086FD File Offset: 0x000068FD
		public void SetTangents(Il2CppStructArray<Vector4> inTangents)
		{
			this.SetTangents(inTangents, 0, NoAllocHelpers.SafeLength(inTangents));
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0000870F File Offset: 0x0000690F
		public void SetTangents(Il2CppStructArray<Vector4> inTangents, int start, int length)
		{
			this.SetTangents(inTangents, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00032888 File Offset: 0x00030A88
		public void SetTangents(Il2CppStructArray<Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Tangent, UnityEngine.Rendering.VertexAttributeFormat.Float32, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Tangent), inTangents, NoAllocHelpers.SafeLength(inTangents), start, length, flags);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0000871D File Offset: 0x0000691D
		public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents) where T : struct
		{
			this.SetTangents<T>(inTangents, 0, inTangents.Length);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00008730 File Offset: 0x00006930
		public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length) where T : struct
		{
			this.SetTangents<T>(inTangents, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000328B0 File Offset: 0x00030AB0
		public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != 16;
			if (flag)
			{
				throw new ArgumentException("SetTangents with NativeArray should use struct type that is 16 bytes (4x float) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Tangent, UnityEngine.Rendering.VertexAttributeFormat.Float32, 4, (IntPtr)inTangents.GetUnsafeReadOnlyPtr<T>(), inTangents.Length, start, length, flags);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000328FC File Offset: 0x00030AFC
		public void GetColors(List<Color> colors)
		{
			bool flag = colors == null;
			if (flag)
			{
				throw new ArgumentNullException("colors", "The result colors list cannot be null.");
			}
			this.GetListForChannel<Color>(colors, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Color, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Color));
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0000873E File Offset: 0x0000693E
		public void SetColors(List<Color> inColors)
		{
			this.SetColors(inColors, 0, NoAllocHelpers.SafeLength<Color>(inColors));
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00008750 File Offset: 0x00006950
		public void SetColors(List<Color> inColors, int start, int length)
		{
			this.SetColors(inColors, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0000875E File Offset: 0x0000695E
		public void SetColors(List<Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetListForChannel<Color>(UnityEngine.Rendering.VertexAttribute.Color, inColors, start, length, flags);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0000876E File Offset: 0x0000696E
		public void SetColors(Il2CppStructArray<Color> inColors)
		{
			this.SetColors(inColors, 0, NoAllocHelpers.SafeLength(inColors));
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00008780 File Offset: 0x00006980
		public void SetColors(Il2CppStructArray<Color> inColors, int start, int length)
		{
			this.SetColors(inColors, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00032938 File Offset: 0x00030B38
		public void SetColors(Il2CppStructArray<Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Color, UnityEngine.Rendering.VertexAttributeFormat.Float32, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Color), inColors, NoAllocHelpers.SafeLength(inColors), start, length, flags);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00032960 File Offset: 0x00030B60
		public void GetColors(List<Color32> colors)
		{
			bool flag = colors == null;
			if (flag)
			{
				throw new ArgumentNullException("colors", "The result colors list cannot be null.");
			}
			this.GetListForChannel<Color32>(colors, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Color, 4, UnityEngine.Rendering.VertexAttributeFormat.UNorm8);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0000878E File Offset: 0x0000698E
		public void SetColors(Il2CppStructArray<Color32> inColors)
		{
			this.SetColors(inColors, 0, NoAllocHelpers.SafeLength(inColors));
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000087A0 File Offset: 0x000069A0
		public void SetColors(Il2CppStructArray<Color32> inColors, int start, int length)
		{
			this.SetColors(inColors, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00032998 File Offset: 0x00030B98
		public void SetColors(Il2CppStructArray<Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Color, UnityEngine.Rendering.VertexAttributeFormat.UNorm8, 4, inColors, NoAllocHelpers.SafeLength(inColors), start, length, flags);
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x000087AE File Offset: 0x000069AE
		public void SetColors<T>(Unity.Collections.NativeArray<T> inColors) where T : struct
		{
			this.SetColors<T>(inColors, 0, inColors.Length);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000087C1 File Offset: 0x000069C1
		public void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length) where T : struct
		{
			this.SetColors<T>(inColors, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x000329BC File Offset: 0x00030BBC
		public void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			bool flag = num != 16 && num != 4;
			if (flag)
			{
				throw new ArgumentException("SetColors with NativeArray should use struct type that is 16 bytes (4x float) or 4 bytes (4x unorm) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Color, (num == 4) ? UnityEngine.Rendering.VertexAttributeFormat.UNorm8 : UnityEngine.Rendering.VertexAttributeFormat.Float32, 4, (IntPtr)inColors.GetUnsafeReadOnlyPtr<T>(), inColors.Length, start, length, flags);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x000087CF File Offset: 0x000069CF
		public void SetUVs(int channel, List<Vector2> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength<Vector2>(uvs));
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x000087E2 File Offset: 0x000069E2
		public void SetUVs(int channel, List<Vector3> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength<Vector3>(uvs));
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000087F5 File Offset: 0x000069F5
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00008805 File Offset: 0x00006A05
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl<Vector2>(channel, 2, uvs, start, length, flags);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00008817 File Offset: 0x00006A17
		public void SetUVs(int channel, List<Vector3> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00008827 File Offset: 0x00006A27
		public void SetUVs(int channel, List<Vector3> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl<Vector3>(channel, 3, uvs, start, length, flags);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00032A18 File Offset: 0x00030C18
		public void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			bool flag = uvIndex < 0 || uvIndex > 7;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("uvIndex", uvIndex, "The uv index is invalid. Must be in the range 0 to 7.");
			}
			this.SetSizedArrayForChannel(Mesh.GetUVChannel(uvIndex), UnityEngine.Rendering.VertexAttributeFormat.Float32, dim, uvs, NoAllocHelpers.SafeLength(uvs), arrayStart, arraySize, flags);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00008839 File Offset: 0x00006A39
		public void SetUVs(int channel, Il2CppStructArray<Vector2> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength(uvs));
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0000884C File Offset: 0x00006A4C
		public void SetUVs(int channel, Il2CppStructArray<Vector3> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength(uvs));
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0000885F File Offset: 0x00006A5F
		public void SetUVs(int channel, Il2CppStructArray<Vector4> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength(uvs));
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00008872 File Offset: 0x00006A72
		public void SetUVs(int channel, Il2CppStructArray<Vector2> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00008882 File Offset: 0x00006A82
		public void SetUVs(int channel, Il2CppStructArray<Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl(channel, 2, uvs, start, length, flags);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00008894 File Offset: 0x00006A94
		public void SetUVs(int channel, Il2CppStructArray<Vector3> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000088A4 File Offset: 0x00006AA4
		public void SetUVs(int channel, Il2CppStructArray<Vector3> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl(channel, 3, uvs, start, length, flags);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x000088B6 File Offset: 0x00006AB6
		public void SetUVs(int channel, Il2CppStructArray<Vector4> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000088C6 File Offset: 0x00006AC6
		public void SetUVs(int channel, Il2CppStructArray<Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl(channel, 4, uvs, start, length, flags);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x000088D8 File Offset: 0x00006AD8
		public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs) where T : struct
		{
			this.SetUVs<T>(channel, uvs, 0, uvs.Length);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000088EC File Offset: 0x00006AEC
		public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length) where T : struct
		{
			this.SetUVs<T>(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00032A68 File Offset: 0x00030C68
		public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = channel < 0 || channel > 7;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("channel", channel, "The uv index is invalid. Must be in the range 0 to 7.");
			}
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			bool flag2 = (num & 3) != 0;
			if (flag2)
			{
				throw new ArgumentException("SetUVs with NativeArray should use struct type that is multiple of 4 bytes in size");
			}
			int num2 = num / 4;
			bool flag3 = num2 < 1 || num2 > 4;
			if (flag3)
			{
				throw new ArgumentException("SetUVs with NativeArray should use struct type that is 1..4 floats in size");
			}
			this.SetSizedNativeArrayForChannel(Mesh.GetUVChannel(channel), UnityEngine.Rendering.VertexAttributeFormat.Float32, num2, (IntPtr)uvs.GetUnsafeReadOnlyPtr<T>(), uvs.Length, start, length, flags);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000088FC File Offset: 0x00006AFC
		public void GetUVs(int channel, List<Vector2> uvs)
		{
			this.GetUVsImpl<Vector2>(channel, uvs, 2);
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00008909 File Offset: 0x00006B09
		public void GetUVs(int channel, List<Vector3> uvs)
		{
			this.GetUVsImpl<Vector3>(channel, uvs, 3);
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00032AFC File Offset: 0x00030CFC
		public int vertexAttributeCount
		{
			get
			{
				return this.GetVertexAttributeCountImpl();
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00032B14 File Offset: 0x00030D14
		public Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> GetVertexAttributes()
		{
			return this.GetVertexAttributesAlloc().Cast<Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>>();
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00032B34 File Offset: 0x00030D34
		public int GetVertexAttributes(Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			return this.GetVertexAttributesArray(attributes);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00032B50 File Offset: 0x00030D50
		public int GetVertexAttributes(List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			return this.GetVertexAttributesList(attributes);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00008916 File Offset: 0x00006B16
		public void SetVertexBufferParams(int vertexCount, Unity.Collections.NativeArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			this.SetVertexBufferParamsFromPtr(vertexCount, (IntPtr)attributes.GetUnsafeReadOnlyPtr<UnityEngine.Rendering.VertexAttributeDescriptor>(), attributes.Length);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00032B6C File Offset: 0x00030D6C
		public void SetVertexBufferData<T>(Il2CppArrayBase<T> data, int dataStart, int meshBufferStart, int count, [Optional] int stream, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				throw new InvalidOperationException(String.Concat("Not allowed to access vertex data on mesh '", base.name, "' (isReadable is false; Read/Write must be enabled in import settings)"));
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Concat("Array passed to SetVertexBufferData must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
			}
			this.InternalSetVertexBufferDataFromArray(stream, data, dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00032C20 File Offset: 0x00030E20
		public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, [Optional] int stream, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				throw new InvalidOperationException(String.Concat("Not allowed to access vertex data on mesh '", base.name, "' (isReadable is false; Read/Write must be enabled in import settings)"));
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "SetVertexBufferData", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
			}
			this.InternalSetVertexBufferDataFromArray(stream, NoAllocHelpers.ExtractArrayFromList(data), dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00008935 File Offset: 0x00006B35
		public void GetTriangles(List<int> triangles, int submesh)
		{
			this.GetTriangles(triangles, submesh, true);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00032CE4 File Offset: 0x00030EE4
		public void GetTriangles(List<int> triangles, int submesh, bool applyBaseVertex)
		{
			bool flag = triangles == null;
			if (flag)
			{
				throw new ArgumentNullException("triangles", "The result triangles list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<int>(triangles, (int)(3U * this.GetTrianglesCountImpl(submesh)));
			this.GetTrianglesNonAllocImpl(NoAllocHelpers.ExtractArrayFromListT<int>(triangles), submesh, applyBaseVertex);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00032D4C File Offset: 0x00030F4C
		public void GetTriangles(List<ushort> triangles, int submesh, [Optional] bool applyBaseVertex)
		{
			bool flag = triangles == null;
			if (flag)
			{
				throw new ArgumentNullException("triangles", "The result triangles list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<ushort>(triangles, (int)(3U * this.GetTrianglesCountImpl(submesh)));
			this.GetTrianglesNonAllocImpl16(NoAllocHelpers.ExtractArrayFromListT<ushort>(triangles), submesh, applyBaseVertex);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00008942 File Offset: 0x00006B42
		public void GetIndices(List<int> indices, int submesh)
		{
			this.GetIndices(indices, submesh, true);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00032DB4 File Offset: 0x00030FB4
		public void GetIndices(List<int> indices, int submesh, bool applyBaseVertex)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices", "The result indices list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<int>(indices, (int)this.GetIndexCount(submesh));
			this.GetIndicesNonAllocImpl(NoAllocHelpers.ExtractArrayFromListT<int>(indices), submesh, applyBaseVertex);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00032E1C File Offset: 0x0003101C
		public void GetIndices(List<ushort> indices, int submesh, [Optional] bool applyBaseVertex)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices", "The result indices list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<ushort>(indices, (int)this.GetIndexCount(submesh));
			this.GetIndicesNonAllocImpl16(NoAllocHelpers.ExtractArrayFromListT<ushort>(indices), submesh, applyBaseVertex);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00032E84 File Offset: 0x00031084
		public void SetIndexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				this.PrintErrorCantAccessIndices();
			}
			else
			{
				bool flag2 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Length;
				if (flag2)
				{
					throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
				}
				this.InternalSetIndexBufferData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00032F0C File Offset: 0x0003110C
		public void SetIndexBufferData<T>(Il2CppArrayBase<T> data, int dataStart, int meshBufferStart, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				this.PrintErrorCantAccessIndices();
			}
			else
			{
				bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
				if (flag2)
				{
					throw new ArgumentException(String.Concat("Array passed to SetIndexBufferData must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
				}
				bool flag3 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Length;
				if (flag3)
				{
					throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
				}
				this.InternalSetIndexBufferDataFromArray(data, dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
			}
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00032FAC File Offset: 0x000311AC
		public void SetIndexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				this.PrintErrorCantAccessIndices();
			}
			else
			{
				bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
				if (flag2)
				{
					throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "SetIndexBufferData", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
				}
				bool flag3 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Count;
				if (flag3)
				{
					throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
				}
				this.InternalSetIndexBufferDataFromArray(NoAllocHelpers.ExtractArrayFromList(data), dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
			}
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00033060 File Offset: 0x00031260
		public uint GetIndexStart(int submesh)
		{
			bool flag = submesh < 0 || submesh >= this.subMeshCount;
			if (flag)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			return this.GetIndexStartImpl(submesh);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0003309C File Offset: 0x0003129C
		public uint GetBaseVertex(int submesh)
		{
			bool flag = submesh < 0 || submesh >= this.subMeshCount;
			if (flag)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			return this.GetBaseVertexImpl(submesh);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0000894F File Offset: 0x00006B4F
		public void SetTriangles(Il2CppStructArray<int> triangles, int submesh, bool calculateBounds)
		{
			this.SetTriangles(triangles, submesh, calculateBounds, 0);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0000895D File Offset: 0x00006B5D
		public void SetTriangles(Il2CppStructArray<ushort> triangles, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetTriangles(triangles, 0, NoAllocHelpers.SafeLength(triangles), submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000330D8 File Offset: 0x000312D8
		public void SetTriangles(Il2CppStructArray<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshTriangles(submesh);
			if (flag)
			{
				this.SetTrianglesImpl(submesh, UnityEngine.Rendering.IndexFormat.UInt16, triangles, NoAllocHelpers.SafeLength(triangles), trianglesStart, trianglesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00008973 File Offset: 0x00006B73
		public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds)
		{
			this.SetTriangles(triangles, submesh, calculateBounds, 0);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00008981 File Offset: 0x00006B81
		public void SetTriangles(List<ushort> triangles, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetTriangles(triangles, 0, NoAllocHelpers.SafeLength<ushort>(triangles), submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0003310C File Offset: 0x0003130C
		public void SetTriangles(List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshTriangles(submesh);
			if (flag)
			{
				this.SetTrianglesImpl(submesh, UnityEngine.Rendering.IndexFormat.UInt16, NoAllocHelpers.ExtractArrayFromList(triangles), NoAllocHelpers.SafeLength<ushort>(triangles), trianglesStart, trianglesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00008997 File Offset: 0x00006B97
		public void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh)
		{
			this.SetIndices(indices, topology, submesh, true, 0);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000089A6 File Offset: 0x00006BA6
		public void SetIndices(Il2CppStructArray<ushort> indices, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetIndices(indices, 0, NoAllocHelpers.SafeLength(indices), topology, submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00033144 File Offset: 0x00031344
		public void SetIndices(Il2CppStructArray<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshIndices(submesh);
			if (flag)
			{
				this.CheckIndicesArrayRange(NoAllocHelpers.SafeLength(indices), indicesStart, indicesLength);
				this.SetIndicesImpl(submesh, topology, UnityEngine.Rendering.IndexFormat.UInt16, indices, indicesStart, indicesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000089BE File Offset: 0x00006BBE
		public void SetIndices<T>(Unity.Collections.NativeArray<T> indices, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex) where T : struct
		{
			this.SetIndices<T>(indices, 0, indices.Length, topology, submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00033184 File Offset: 0x00031384
		public void SetIndices<T>(Unity.Collections.NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex) where T : struct
		{
			bool flag = this.CheckCanAccessSubmeshIndices(submesh);
			if (flag)
			{
				int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
				bool flag2 = num != 2 && num != 4;
				if (flag2)
				{
					throw new ArgumentException("SetIndices with NativeArray should use type is 2 or 4 bytes in size");
				}
				this.CheckIndicesArrayRange(indices.Length, indicesStart, indicesLength);
				this.SetIndicesNativeArrayImpl(submesh, topology, (num == 2) ? UnityEngine.Rendering.IndexFormat.UInt16 : UnityEngine.Rendering.IndexFormat.UInt32, (IntPtr)indices.GetUnsafeReadOnlyPtr<T>(), indicesStart, indicesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000089D7 File Offset: 0x00006BD7
		public void SetIndices(List<int> indices, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetIndices(indices, 0, NoAllocHelpers.SafeLength<int>(indices), topology, submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000331F8 File Offset: 0x000313F8
		public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshIndices(submesh);
			if (flag)
			{
				Array array = NoAllocHelpers.ExtractArrayFromList(indices);
				this.CheckIndicesArrayRange(NoAllocHelpers.SafeLength<int>(indices), indicesStart, indicesLength);
				this.SetIndicesImpl(submesh, topology, UnityEngine.Rendering.IndexFormat.UInt32, array, indicesStart, indicesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000089EF File Offset: 0x00006BEF
		public void SetIndices(List<ushort> indices, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetIndices(indices, 0, NoAllocHelpers.SafeLength<ushort>(indices), topology, submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00033240 File Offset: 0x00031440
		public void SetIndices(List<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshIndices(submesh);
			if (flag)
			{
				Array array = NoAllocHelpers.ExtractArrayFromList(indices);
				this.CheckIndicesArrayRange(NoAllocHelpers.SafeLength<ushort>(indices), indicesStart, indicesLength);
				this.SetIndicesImpl(submesh, topology, UnityEngine.Rendering.IndexFormat.UInt16, array, indicesStart, indicesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00008A07 File Offset: 0x00006C07
		public void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, int start, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00008A14 File Offset: 0x00006C14
		public void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			this.SetSubMeshes<T>(desc, 0, desc.Length, flags);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00033288 File Offset: 0x00031488
		public void GetBindposes(List<Matrix4x4> bindposes)
		{
			bool flag = bindposes == null;
			if (flag)
			{
				throw new ArgumentNullException("bindposes", "The result bindposes list cannot be null.");
			}
			NoAllocHelpers.EnsureListElemCount<Matrix4x4>(bindposes, this.GetBindposeCount());
			this.GetBindposesNonAllocImpl(NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(bindposes));
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00008A28 File Offset: 0x00006C28
		public void Clear(bool keepVertexLayout)
		{
			this.ClearImpl(keepVertexLayout);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00008A33 File Offset: 0x00006C33
		public void RecalculateTangents()
		{
			this.RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000332C8 File Offset: 0x000314C8
		public void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.RecalculateTangentsImpl(flags);
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call RecalculateTangents() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00033300 File Offset: 0x00031500
		public void RecalculateUVDistributionMetric(int uvSetIndex, [Optional] float uvAreaThreshold)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.RecalculateUVDistributionMetricImpl(uvSetIndex, uvAreaThreshold);
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call RecalculateUVDistributionMetric() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0003333C File Offset: 0x0003153C
		public void RecalculateUVDistributionMetrics([Optional] float uvAreaThreshold)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.RecalculateUVDistributionMetricsImpl(uvAreaThreshold);
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call RecalculateUVDistributionMetrics() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00033374 File Offset: 0x00031574
		public void Optimize()
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.OptimizeImpl();
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call Optimize() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x000333AC File Offset: 0x000315AC
		public void OptimizeIndexBuffers()
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.OptimizeIndexBuffersImpl();
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call OptimizeIndexBuffers() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000333E4 File Offset: 0x000315E4
		public void OptimizeReorderVertexBuffer()
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.OptimizeReorderVertexBufferImpl();
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call OptimizeReorderVertexBuffer() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00008A3E File Offset: 0x00006C3E
		public void GetVertexAttribute_Injected(int index, out UnityEngine.Rendering.VertexAttributeDescriptor ret)
		{
			Mesh.GetVertexAttribute_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferParamsFromArray_Private_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetVertexBufferData_Private_Void_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexCountImpl_Private_UInt32_Int32_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_GetTrianglesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNormalsImpl_Private_Void_MeshUpdateFlags_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_UploadMeshDataImpl_Private_Void_Boolean_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_GetTopologyImpl_Private_MeshTopology_Int32_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_set_colors_Public_set_Void_Il2CppStructArray_1_Color_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_GetVertices_Public_Void_List_1_Vector3_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexCount_Public_UInt32_Int32_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_Int32_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBounds_Public_Void_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNormals_Public_Void_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNormals_Public_Void_MeshUpdateFlags_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_MarkDynamic_Public_Void_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_UploadMeshData_Public_Void_Boolean_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_GetTopology_Public_MeshTopology_Int32_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly Mesh.FromInstanceIDDelegate FromInstanceIDDelegateField;

		// Token: 0x040008BA RID: 2234
		private static readonly Mesh.get_indexFormatDelegate get_indexFormatDelegateField;

		// Token: 0x040008BB RID: 2235
		private static readonly Mesh.set_indexFormatDelegate set_indexFormatDelegateField;

		// Token: 0x040008BC RID: 2236
		private static readonly Mesh.GetTotalIndexCountDelegate GetTotalIndexCountDelegateField;

		// Token: 0x040008BD RID: 2237
		private static readonly Mesh.SetIndexBufferParamsDelegate SetIndexBufferParamsDelegateField;

		// Token: 0x040008BE RID: 2238
		private static readonly Mesh.InternalSetIndexBufferDataDelegate InternalSetIndexBufferDataDelegateField;

		// Token: 0x040008BF RID: 2239
		private static readonly Mesh.InternalSetIndexBufferDataFromArrayDelegate InternalSetIndexBufferDataFromArrayDelegateField;

		// Token: 0x040008C0 RID: 2240
		private static readonly Mesh.SetVertexBufferParamsFromPtrDelegate SetVertexBufferParamsFromPtrDelegateField;

		// Token: 0x040008C1 RID: 2241
		private static readonly Mesh.InternalSetVertexBufferDataFromArrayDelegate InternalSetVertexBufferDataFromArrayDelegateField;

		// Token: 0x040008C2 RID: 2242
		private static readonly Mesh.GetVertexAttributesAllocDelegate GetVertexAttributesAllocDelegateField;

		// Token: 0x040008C3 RID: 2243
		private static readonly Mesh.GetVertexAttributesArrayDelegate GetVertexAttributesArrayDelegateField;

		// Token: 0x040008C4 RID: 2244
		private static readonly Mesh.GetVertexAttributesListDelegate GetVertexAttributesListDelegateField;

		// Token: 0x040008C5 RID: 2245
		private static readonly Mesh.GetVertexAttributeCountImplDelegate GetVertexAttributeCountImplDelegateField;

		// Token: 0x040008C6 RID: 2246
		private static readonly Mesh.GetIndexStartImplDelegate GetIndexStartImplDelegateField;

		// Token: 0x040008C7 RID: 2247
		private static readonly Mesh.GetTrianglesCountImplDelegate GetTrianglesCountImplDelegateField;

		// Token: 0x040008C8 RID: 2248
		private static readonly Mesh.GetBaseVertexImplDelegate GetBaseVertexImplDelegateField;

		// Token: 0x040008C9 RID: 2249
		private static readonly Mesh.SetIndicesNativeArrayImplDelegate SetIndicesNativeArrayImplDelegateField;

		// Token: 0x040008CA RID: 2250
		private static readonly Mesh.GetTrianglesNonAllocImplDelegate GetTrianglesNonAllocImplDelegateField;

		// Token: 0x040008CB RID: 2251
		private static readonly Mesh.GetTrianglesNonAllocImpl16Delegate GetTrianglesNonAllocImpl16DelegateField;

		// Token: 0x040008CC RID: 2252
		private static readonly Mesh.GetIndicesNonAllocImplDelegate GetIndicesNonAllocImplDelegateField;

		// Token: 0x040008CD RID: 2253
		private static readonly Mesh.GetIndicesNonAllocImpl16Delegate GetIndicesNonAllocImpl16DelegateField;

		// Token: 0x040008CE RID: 2254
		private static readonly Mesh.GetVertexAttributeDimensionDelegate GetVertexAttributeDimensionDelegateField;

		// Token: 0x040008CF RID: 2255
		private static readonly Mesh.GetVertexAttributeFormatDelegate GetVertexAttributeFormatDelegateField;

		// Token: 0x040008D0 RID: 2256
		private static readonly Mesh.SetNativeArrayForChannelImplDelegate SetNativeArrayForChannelImplDelegateField;

		// Token: 0x040008D1 RID: 2257
		private static readonly Mesh.get_vertexBufferCountDelegate get_vertexBufferCountDelegateField;

		// Token: 0x040008D2 RID: 2258
		private static readonly Mesh.GetNativeVertexBufferPtrDelegate GetNativeVertexBufferPtrDelegateField;

		// Token: 0x040008D3 RID: 2259
		private static readonly Mesh.GetNativeIndexBufferPtrDelegate GetNativeIndexBufferPtrDelegateField;

		// Token: 0x040008D4 RID: 2260
		private static readonly Mesh.get_blendShapeCountDelegate get_blendShapeCountDelegateField;

		// Token: 0x040008D5 RID: 2261
		private static readonly Mesh.ClearBlendShapesDelegate ClearBlendShapesDelegateField;

		// Token: 0x040008D6 RID: 2262
		private static readonly Mesh.GetBlendShapeNameDelegate GetBlendShapeNameDelegateField;

		// Token: 0x040008D7 RID: 2263
		private static readonly Mesh.GetBlendShapeIndexDelegate GetBlendShapeIndexDelegateField;

		// Token: 0x040008D8 RID: 2264
		private static readonly Mesh.GetBlendShapeFrameCountDelegate GetBlendShapeFrameCountDelegateField;

		// Token: 0x040008D9 RID: 2265
		private static readonly Mesh.GetBlendShapeFrameWeightDelegate GetBlendShapeFrameWeightDelegateField;

		// Token: 0x040008DA RID: 2266
		private static readonly Mesh.GetBlendShapeFrameVerticesDelegate GetBlendShapeFrameVerticesDelegateField;

		// Token: 0x040008DB RID: 2267
		private static readonly Mesh.AddBlendShapeFrameDelegate AddBlendShapeFrameDelegateField;

		// Token: 0x040008DC RID: 2268
		private static readonly Mesh.HasBoneWeightsDelegate HasBoneWeightsDelegateField;

		// Token: 0x040008DD RID: 2269
		private static readonly Mesh.InternalSetBoneWeightsDelegate InternalSetBoneWeightsDelegateField;

		// Token: 0x040008DE RID: 2270
		private static readonly Mesh.GetAllBoneWeightsArraySizeDelegate GetAllBoneWeightsArraySizeDelegateField;

		// Token: 0x040008DF RID: 2271
		private static readonly Mesh.GetAllBoneWeightsArrayDelegate GetAllBoneWeightsArrayDelegateField;

		// Token: 0x040008E0 RID: 2272
		private static readonly Mesh.GetBonesPerVertexArrayDelegate GetBonesPerVertexArrayDelegateField;

		// Token: 0x040008E1 RID: 2273
		private static readonly Mesh.GetBindposeCountDelegate GetBindposeCountDelegateField;

		// Token: 0x040008E2 RID: 2274
		private static readonly Mesh.get_bindposesDelegate get_bindposesDelegateField;

		// Token: 0x040008E3 RID: 2275
		private static readonly Mesh.set_bindposesDelegate set_bindposesDelegateField;

		// Token: 0x040008E4 RID: 2276
		private static readonly Mesh.GetBindposesNonAllocImplDelegate GetBindposesNonAllocImplDelegateField;

		// Token: 0x040008E5 RID: 2277
		private static readonly Mesh.get_isReadableDelegate get_isReadableDelegateField;

		// Token: 0x040008E6 RID: 2278
		private static readonly Mesh.set_subMeshCountDelegate set_subMeshCountDelegateField;

		// Token: 0x040008E7 RID: 2279
		private static readonly Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegate SetAllSubMeshesAtOnceFromNativeArrayDelegateField;

		// Token: 0x040008E8 RID: 2280
		private static readonly Mesh.RecalculateTangentsImplDelegate RecalculateTangentsImplDelegateField;

		// Token: 0x040008E9 RID: 2281
		private static readonly Mesh.MarkModifiedDelegate MarkModifiedDelegateField;

		// Token: 0x040008EA RID: 2282
		private static readonly Mesh.RecalculateUVDistributionMetricImplDelegate RecalculateUVDistributionMetricImplDelegateField;

		// Token: 0x040008EB RID: 2283
		private static readonly Mesh.RecalculateUVDistributionMetricsImplDelegate RecalculateUVDistributionMetricsImplDelegateField;

		// Token: 0x040008EC RID: 2284
		private static readonly Mesh.GetUVDistributionMetricDelegate GetUVDistributionMetricDelegateField;

		// Token: 0x040008ED RID: 2285
		private static readonly Mesh.OptimizeImplDelegate OptimizeImplDelegateField;

		// Token: 0x040008EE RID: 2286
		private static readonly Mesh.OptimizeIndexBuffersImplDelegate OptimizeIndexBuffersImplDelegateField;

		// Token: 0x040008EF RID: 2287
		private static readonly Mesh.OptimizeReorderVertexBufferImplDelegate OptimizeReorderVertexBufferImplDelegateField;

		// Token: 0x040008F0 RID: 2288
		private static readonly Mesh.GetVertexAttribute_InjectedDelegate GetVertexAttribute_InjectedDelegateField;

		// Token: 0x0200065C RID: 1628
		[StructLayout(2)]
		public struct MeshData
		{
			// Token: 0x06002AE1 RID: 10977 RVA: 0x00013725 File Offset: 0x00011925
			// Note: this type is marked as 'beforefieldinit'.
			static MeshData()
			{
				Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Mesh>.NativeClassPtr, "MeshData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr);
				Mesh.MeshData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr, "m_Ptr");
			}

			// Token: 0x06002AE2 RID: 10978 RVA: 0x00013759 File Offset: 0x00011959
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr, ref this));
			}

			// Token: 0x04001EE5 RID: 7909
			private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

			// Token: 0x04001EE6 RID: 7910
			[FieldOffset(0)]
			public IntPtr m_Ptr;
		}

		// Token: 0x0200065D RID: 1629
		private sealed class MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0<T>
		{
			// Token: 0x04001EE7 RID: 7911
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200065E RID: 1630
		private sealed class MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0<T>
		{
			// Token: 0x04001EE8 RID: 7912
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200065F RID: 1631
		private sealed class MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>
		{
			// Token: 0x04001EE9 RID: 7913
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000660 RID: 1632
		private sealed class MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>
		{
			// Token: 0x04001EEA RID: 7914
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000661 RID: 1633
		private sealed class MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04001EEB RID: 7915
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000662 RID: 1634
		private sealed class MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04001EEC RID: 7916
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000663 RID: 1635
		private sealed class MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0<T>
		{
			// Token: 0x04001EED RID: 7917
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000664 RID: 1636
		private sealed class MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0<T>
		{
			// Token: 0x04001EEE RID: 7918
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000665 RID: 1637
		private sealed class MethodInfoStoreGeneric_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04001EEF RID: 7919
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000666 RID: 1638
		private sealed class MethodInfoStoreGeneric_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0<T>
		{
			// Token: 0x04001EF0 RID: 7920
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000667 RID: 1639
		private sealed class MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04001EF1 RID: 7921
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000668 RID: 1640
		// (Invoke) Token: 0x06002AEF RID: 10991
		private delegate IntPtr FromInstanceIDDelegate(int id);

		// Token: 0x02000669 RID: 1641
		// (Invoke) Token: 0x06002AF1 RID: 10993
		private delegate UnityEngine.Rendering.IndexFormat get_indexFormatDelegate(IntPtr @this);

		// Token: 0x0200066A RID: 1642
		// (Invoke) Token: 0x06002AF3 RID: 10995
		private delegate void set_indexFormatDelegate(IntPtr @this, UnityEngine.Rendering.IndexFormat value);

		// Token: 0x0200066B RID: 1643
		// (Invoke) Token: 0x06002AF5 RID: 10997
		private delegate uint GetTotalIndexCountDelegate(IntPtr @this);

		// Token: 0x0200066C RID: 1644
		// (Invoke) Token: 0x06002AF7 RID: 10999
		private delegate void SetIndexBufferParamsDelegate(IntPtr @this, int indexCount, UnityEngine.Rendering.IndexFormat format);

		// Token: 0x0200066D RID: 1645
		// (Invoke) Token: 0x06002AF9 RID: 11001
		private delegate void InternalSetIndexBufferDataDelegate(IntPtr @this, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x0200066E RID: 1646
		// (Invoke) Token: 0x06002AFB RID: 11003
		private delegate void InternalSetIndexBufferDataFromArrayDelegate(IntPtr @this, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x0200066F RID: 1647
		// (Invoke) Token: 0x06002AFD RID: 11005
		private delegate void SetVertexBufferParamsFromPtrDelegate(IntPtr @this, int vertexCount, IntPtr attributesPtr, int attributesCount);

		// Token: 0x02000670 RID: 1648
		// (Invoke) Token: 0x06002AFF RID: 11007
		private delegate void InternalSetVertexBufferDataFromArrayDelegate(IntPtr @this, int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x02000671 RID: 1649
		// (Invoke) Token: 0x06002B01 RID: 11009
		private delegate IntPtr GetVertexAttributesAllocDelegate(IntPtr @this);

		// Token: 0x02000672 RID: 1650
		// (Invoke) Token: 0x06002B03 RID: 11011
		private delegate int GetVertexAttributesArrayDelegate(IntPtr @this, IntPtr attributes);

		// Token: 0x02000673 RID: 1651
		// (Invoke) Token: 0x06002B05 RID: 11013
		private delegate int GetVertexAttributesListDelegate(IntPtr @this, IntPtr attributes);

		// Token: 0x02000674 RID: 1652
		// (Invoke) Token: 0x06002B07 RID: 11015
		private delegate int GetVertexAttributeCountImplDelegate(IntPtr @this);

		// Token: 0x02000675 RID: 1653
		// (Invoke) Token: 0x06002B09 RID: 11017
		private delegate uint GetIndexStartImplDelegate(IntPtr @this, int submesh);

		// Token: 0x02000676 RID: 1654
		// (Invoke) Token: 0x06002B0B RID: 11019
		private delegate uint GetTrianglesCountImplDelegate(IntPtr @this, int submesh);

		// Token: 0x02000677 RID: 1655
		// (Invoke) Token: 0x06002B0D RID: 11021
		private delegate uint GetBaseVertexImplDelegate(IntPtr @this, int submesh);

		// Token: 0x02000678 RID: 1656
		// (Invoke) Token: 0x06002B0F RID: 11023
		private delegate void SetIndicesNativeArrayImplDelegate(IntPtr @this, int submesh, MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);

		// Token: 0x02000679 RID: 1657
		// (Invoke) Token: 0x06002B11 RID: 11025
		private delegate void GetTrianglesNonAllocImplDelegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x0200067A RID: 1658
		// (Invoke) Token: 0x06002B13 RID: 11027
		private delegate void GetTrianglesNonAllocImpl16Delegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x0200067B RID: 1659
		// (Invoke) Token: 0x06002B15 RID: 11029
		private delegate void GetIndicesNonAllocImplDelegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x0200067C RID: 1660
		// (Invoke) Token: 0x06002B17 RID: 11031
		private delegate void GetIndicesNonAllocImpl16Delegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x0200067D RID: 1661
		// (Invoke) Token: 0x06002B19 RID: 11033
		private delegate int GetVertexAttributeDimensionDelegate(IntPtr @this, UnityEngine.Rendering.VertexAttribute attr);

		// Token: 0x0200067E RID: 1662
		// (Invoke) Token: 0x06002B1B RID: 11035
		private delegate UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormatDelegate(IntPtr @this, UnityEngine.Rendering.VertexAttribute attr);

		// Token: 0x0200067F RID: 1663
		// (Invoke) Token: 0x06002B1D RID: 11037
		private delegate void SetNativeArrayForChannelImplDelegate(IntPtr @this, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x02000680 RID: 1664
		// (Invoke) Token: 0x06002B1F RID: 11039
		private delegate int get_vertexBufferCountDelegate(IntPtr @this);

		// Token: 0x02000681 RID: 1665
		// (Invoke) Token: 0x06002B21 RID: 11041
		private delegate IntPtr GetNativeVertexBufferPtrDelegate(IntPtr @this, int index);

		// Token: 0x02000682 RID: 1666
		// (Invoke) Token: 0x06002B23 RID: 11043
		private delegate IntPtr GetNativeIndexBufferPtrDelegate(IntPtr @this);

		// Token: 0x02000683 RID: 1667
		// (Invoke) Token: 0x06002B25 RID: 11045
		private delegate int get_blendShapeCountDelegate(IntPtr @this);

		// Token: 0x02000684 RID: 1668
		// (Invoke) Token: 0x06002B27 RID: 11047
		private delegate void ClearBlendShapesDelegate(IntPtr @this);

		// Token: 0x02000685 RID: 1669
		// (Invoke) Token: 0x06002B29 RID: 11049
		private delegate IntPtr GetBlendShapeNameDelegate(IntPtr @this, int shapeIndex);

		// Token: 0x02000686 RID: 1670
		// (Invoke) Token: 0x06002B2B RID: 11051
		private delegate int GetBlendShapeIndexDelegate(IntPtr @this, IntPtr blendShapeName);

		// Token: 0x02000687 RID: 1671
		// (Invoke) Token: 0x06002B2D RID: 11053
		private delegate int GetBlendShapeFrameCountDelegate(IntPtr @this, int shapeIndex);

		// Token: 0x02000688 RID: 1672
		// (Invoke) Token: 0x06002B2F RID: 11055
		private delegate float GetBlendShapeFrameWeightDelegate(IntPtr @this, int shapeIndex, int frameIndex);

		// Token: 0x02000689 RID: 1673
		// (Invoke) Token: 0x06002B31 RID: 11057
		private delegate void GetBlendShapeFrameVerticesDelegate(IntPtr @this, int shapeIndex, int frameIndex, IntPtr deltaVertices, IntPtr deltaNormals, IntPtr deltaTangents);

		// Token: 0x0200068A RID: 1674
		// (Invoke) Token: 0x06002B33 RID: 11059
		private delegate void AddBlendShapeFrameDelegate(IntPtr @this, IntPtr shapeName, float frameWeight, IntPtr deltaVertices, IntPtr deltaNormals, IntPtr deltaTangents);

		// Token: 0x0200068B RID: 1675
		// (Invoke) Token: 0x06002B35 RID: 11061
		private delegate bool HasBoneWeightsDelegate(IntPtr @this);

		// Token: 0x0200068C RID: 1676
		// (Invoke) Token: 0x06002B37 RID: 11063
		private delegate void InternalSetBoneWeightsDelegate(IntPtr @this, IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize);

		// Token: 0x0200068D RID: 1677
		// (Invoke) Token: 0x06002B39 RID: 11065
		private delegate int GetAllBoneWeightsArraySizeDelegate(IntPtr @this);

		// Token: 0x0200068E RID: 1678
		// (Invoke) Token: 0x06002B3B RID: 11067
		private delegate IntPtr GetAllBoneWeightsArrayDelegate(IntPtr @this);

		// Token: 0x0200068F RID: 1679
		// (Invoke) Token: 0x06002B3D RID: 11069
		private delegate IntPtr GetBonesPerVertexArrayDelegate(IntPtr @this);

		// Token: 0x02000690 RID: 1680
		// (Invoke) Token: 0x06002B3F RID: 11071
		private delegate int GetBindposeCountDelegate(IntPtr @this);

		// Token: 0x02000691 RID: 1681
		// (Invoke) Token: 0x06002B41 RID: 11073
		private delegate IntPtr get_bindposesDelegate(IntPtr @this);

		// Token: 0x02000692 RID: 1682
		// (Invoke) Token: 0x06002B43 RID: 11075
		private delegate void set_bindposesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000693 RID: 1683
		// (Invoke) Token: 0x06002B45 RID: 11077
		private delegate void GetBindposesNonAllocImplDelegate(IntPtr @this, [Out] IntPtr values);

		// Token: 0x02000694 RID: 1684
		// (Invoke) Token: 0x06002B47 RID: 11079
		private delegate bool get_isReadableDelegate(IntPtr @this);

		// Token: 0x02000695 RID: 1685
		// (Invoke) Token: 0x06002B49 RID: 11081
		private delegate void set_subMeshCountDelegate(IntPtr @this, int value);

		// Token: 0x02000696 RID: 1686
		// (Invoke) Token: 0x06002B4B RID: 11083
		private delegate void SetAllSubMeshesAtOnceFromNativeArrayDelegate(IntPtr @this, IntPtr desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x02000697 RID: 1687
		// (Invoke) Token: 0x06002B4D RID: 11085
		private delegate void RecalculateTangentsImplDelegate(IntPtr @this, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x02000698 RID: 1688
		// (Invoke) Token: 0x06002B4F RID: 11087
		private delegate void MarkModifiedDelegate(IntPtr @this);

		// Token: 0x02000699 RID: 1689
		// (Invoke) Token: 0x06002B51 RID: 11089
		private delegate void RecalculateUVDistributionMetricImplDelegate(IntPtr @this, int uvSetIndex, float uvAreaThreshold);

		// Token: 0x0200069A RID: 1690
		// (Invoke) Token: 0x06002B53 RID: 11091
		private delegate void RecalculateUVDistributionMetricsImplDelegate(IntPtr @this, float uvAreaThreshold);

		// Token: 0x0200069B RID: 1691
		// (Invoke) Token: 0x06002B55 RID: 11093
		private delegate float GetUVDistributionMetricDelegate(IntPtr @this, int uvSetIndex);

		// Token: 0x0200069C RID: 1692
		// (Invoke) Token: 0x06002B57 RID: 11095
		private delegate void OptimizeImplDelegate(IntPtr @this);

		// Token: 0x0200069D RID: 1693
		// (Invoke) Token: 0x06002B59 RID: 11097
		private delegate void OptimizeIndexBuffersImplDelegate(IntPtr @this);

		// Token: 0x0200069E RID: 1694
		// (Invoke) Token: 0x06002B5B RID: 11099
		private delegate void OptimizeReorderVertexBufferImplDelegate(IntPtr @this);

		// Token: 0x0200069F RID: 1695
		// (Invoke) Token: 0x06002B5D RID: 11101
		private delegate void GetVertexAttribute_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);
	}
}
