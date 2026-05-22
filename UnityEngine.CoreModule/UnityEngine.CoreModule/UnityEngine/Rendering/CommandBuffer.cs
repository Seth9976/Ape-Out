using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Profiling;

namespace UnityEngine.Rendering
{
	// Token: 0x0200016D RID: 365
	public class CommandBuffer : Object
	{
		// Token: 0x06001A22 RID: 6690 RVA: 0x00063AF0 File Offset: 0x00061CF0
		// Note: this type is marked as 'beforefieldinit'.
		static CommandBuffer()
		{
			Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CommandBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr);
			CommandBuffer.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, "m_Ptr");
			CommandBuffer.NativeMethodInfoPtr_Internal_SetSinglePassStereo_Private_Void_SinglePassStereoMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665726);
			CommandBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665727);
			CommandBuffer.NativeMethodInfoPtr_ReleaseBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665728);
			CommandBuffer.NativeMethodInfoPtr_SetComputeVectorParam_Public_Void_ComputeShader_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665729);
			CommandBuffer.NativeMethodInfoPtr_Internal_SetComputeFloats_Private_Void_ComputeShader_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665730);
			CommandBuffer.NativeMethodInfoPtr_Internal_SetComputeTextureParam_Private_Void_ComputeShader_Int32_Int32_byref_RenderTargetIdentifier_Int32_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665731);
			CommandBuffer.NativeMethodInfoPtr_Internal_SetComputeBufferParam_Private_Void_ComputeShader_Int32_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665732);
			CommandBuffer.NativeMethodInfoPtr_Internal_DispatchCompute_Private_Void_ComputeShader_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665733);
			CommandBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665734);
			CommandBuffer.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665735);
			CommandBuffer.NativeMethodInfoPtr_Internal_DrawMesh_Private_Void_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665736);
			CommandBuffer.NativeMethodInfoPtr_SetViewport_Public_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665737);
			CommandBuffer.NativeMethodInfoPtr_CopyTexture_Internal_Private_Void_byref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_byref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665738);
			CommandBuffer.NativeMethodInfoPtr_Blit_Texture_Private_Void_Texture_byref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665739);
			CommandBuffer.NativeMethodInfoPtr_Blit_Identifier_Private_Void_byref_RenderTargetIdentifier_byref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665740);
			CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665741);
			CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665742);
			CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665743);
			CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665744);
			CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665745);
			CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665746);
			CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665747);
			CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665748);
			CommandBuffer.NativeMethodInfoPtr_GetTemporaryRTWithDescriptor_Private_Void_Int32_RenderTextureDescriptor_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665749);
			CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_RenderTextureDescriptor_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665750);
			CommandBuffer.NativeMethodInfoPtr_ReleaseTemporaryRT_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665751);
			CommandBuffer.NativeMethodInfoPtr_ClearRenderTarget_Public_Void_Boolean_Boolean_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665752);
			CommandBuffer.NativeMethodInfoPtr_ClearRenderTarget_Public_Void_Boolean_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665753);
			CommandBuffer.NativeMethodInfoPtr_SetGlobalFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665754);
			CommandBuffer.NativeMethodInfoPtr_SetGlobalVector_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665755);
			CommandBuffer.NativeMethodInfoPtr_EnableShaderKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665756);
			CommandBuffer.NativeMethodInfoPtr_DisableShaderKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665757);
			CommandBuffer.NativeMethodInfoPtr_ValidateAgainstExecutionFlags_Private_Boolean_CommandBufferExecutionFlags_CommandBufferExecutionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665758);
			CommandBuffer.NativeMethodInfoPtr_SetGlobalTexture_Impl_Private_Void_Int32_byref_RenderTargetIdentifier_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665759);
			CommandBuffer.NativeMethodInfoPtr_BeginSample_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665760);
			CommandBuffer.NativeMethodInfoPtr_EndSample_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665761);
			CommandBuffer.NativeMethodInfoPtr_SetRenderTarget_Public_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665762);
			CommandBuffer.NativeMethodInfoPtr_SetRenderTarget_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665763);
			CommandBuffer.NativeMethodInfoPtr_SetRenderTarget_Public_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665764);
			CommandBuffer.NativeMethodInfoPtr_SetRenderTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665765);
			CommandBuffer.NativeMethodInfoPtr_SetRenderTargetSingle_Internal_Private_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665766);
			CommandBuffer.NativeMethodInfoPtr_SetRenderTargetColorDepth_Internal_Private_Void_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665767);
			CommandBuffer.NativeMethodInfoPtr_SetRenderTargetMulti_Internal_Private_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_Il2CppStructArray_1_RenderBufferLoadAction_Il2CppStructArray_1_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665768);
			CommandBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665769);
			CommandBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665770);
			CommandBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665771);
			CommandBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665772);
			CommandBuffer.NativeMethodInfoPtr_SetComputeVectorParam_Public_Void_ComputeShader_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665773);
			CommandBuffer.NativeMethodInfoPtr_SetComputeFloatParams_Public_Void_ComputeShader_String_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665774);
			CommandBuffer.NativeMethodInfoPtr_SetComputeTextureParam_Public_Void_ComputeShader_Int32_String_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665775);
			CommandBuffer.NativeMethodInfoPtr_SetComputeBufferParam_Public_Void_ComputeShader_Int32_String_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665776);
			CommandBuffer.NativeMethodInfoPtr_DispatchCompute_Public_Void_ComputeShader_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665777);
			CommandBuffer.NativeMethodInfoPtr_DrawMesh_Public_Void_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665778);
			CommandBuffer.NativeMethodInfoPtr_DrawMesh_Public_Void_Mesh_Matrix4x4_Material_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665779);
			CommandBuffer.NativeMethodInfoPtr_CopyTexture_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665780);
			CommandBuffer.NativeMethodInfoPtr_CopyTexture_Public_Void_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665781);
			CommandBuffer.NativeMethodInfoPtr_Blit_Public_Void_Texture_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665782);
			CommandBuffer.NativeMethodInfoPtr_Blit_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665783);
			CommandBuffer.NativeMethodInfoPtr_Blit_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665784);
			CommandBuffer.NativeMethodInfoPtr_SetGlobalTexture_Public_Void_String_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665785);
			CommandBuffer.NativeMethodInfoPtr_SetGlobalTexture_Public_Void_Int32_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665786);
			CommandBuffer.NativeMethodInfoPtr_SetGlobalTexture_Public_Void_Int32_RenderTargetIdentifier_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665787);
			CommandBuffer.NativeMethodInfoPtr_SetSinglePassStereo_Public_Void_SinglePassStereoMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665788);
			CommandBuffer.NativeMethodInfoPtr_SetComputeVectorParam_Injected_Private_Void_ComputeShader_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665789);
			CommandBuffer.NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Void_Mesh_byref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665790);
			CommandBuffer.NativeMethodInfoPtr_SetViewport_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665791);
			CommandBuffer.NativeMethodInfoPtr_Blit_Texture_Injected_Private_Void_Texture_byref_RenderTargetIdentifier_Material_Int32_byref_Vector2_byref_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665792);
			CommandBuffer.NativeMethodInfoPtr_Blit_Identifier_Injected_Private_Void_byref_RenderTargetIdentifier_byref_RenderTargetIdentifier_Material_Int32_byref_Vector2_byref_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665793);
			CommandBuffer.NativeMethodInfoPtr_GetTemporaryRTWithDescriptor_Injected_Private_Void_Int32_byref_RenderTextureDescriptor_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665794);
			CommandBuffer.NativeMethodInfoPtr_ClearRenderTarget_Injected_Private_Void_Boolean_Boolean_byref_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665795);
			CommandBuffer.NativeMethodInfoPtr_SetGlobalVector_Injected_Private_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665796);
			CommandBuffer.NativeMethodInfoPtr_SetRenderTargetSingle_Internal_Injected_Private_Void_byref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665797);
			CommandBuffer.NativeMethodInfoPtr_SetRenderTargetColorDepth_Internal_Injected_Private_Void_byref_RenderTargetIdentifier_byref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665798);
			CommandBuffer.NativeMethodInfoPtr_SetRenderTargetMulti_Internal_Injected_Private_Void_Il2CppStructArray_1_RenderTargetIdentifier_byref_RenderTargetIdentifier_Il2CppStructArray_1_RenderBufferLoadAction_Il2CppStructArray_1_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr, 100665799);
			CommandBuffer.WaitAllAsyncReadbackRequestsDelegateField = IL2CPP.ResolveICall<CommandBuffer.WaitAllAsyncReadbackRequestsDelegate>("UnityEngine.Rendering.CommandBuffer::WaitAllAsyncReadbackRequests");
			CommandBuffer.SetInvertCullingDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetInvertCullingDelegate>("UnityEngine.Rendering.CommandBuffer::SetInvertCulling");
			CommandBuffer.CreateGPUFence_InternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.CreateGPUFence_InternalDelegate>("UnityEngine.Rendering.CommandBuffer::CreateGPUFence_Internal");
			CommandBuffer.WaitOnGPUFence_InternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.WaitOnGPUFence_InternalDelegate>("UnityEngine.Rendering.CommandBuffer::WaitOnGPUFence_Internal");
			CommandBuffer.SetComputeFloatParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeFloatParamDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeFloatParam");
			CommandBuffer.SetComputeIntParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeIntParamDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeIntParam");
			CommandBuffer.SetComputeVectorArrayParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeVectorArrayParamDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeVectorArrayParam");
			CommandBuffer.SetComputeMatrixArrayParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeMatrixArrayParamDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeMatrixArrayParam");
			CommandBuffer.Internal_SetComputeIntsDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetComputeIntsDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeInts");
			CommandBuffer.Internal_SetComputeGraphicsBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetComputeGraphicsBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeGraphicsBufferParam");
			CommandBuffer.Internal_SetComputeConstantComputeBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetComputeConstantComputeBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeConstantComputeBufferParam");
			CommandBuffer.Internal_SetComputeConstantGraphicsBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetComputeConstantGraphicsBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeConstantGraphicsBufferParam");
			CommandBuffer.Internal_DispatchComputeIndirectDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DispatchComputeIndirectDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DispatchComputeIndirect");
			CommandBuffer.Internal_DispatchComputeIndirectGraphicsBufferDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DispatchComputeIndirectGraphicsBufferDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DispatchComputeIndirectGraphicsBuffer");
			CommandBuffer.Internal_SetRayTracingBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingBufferParam");
			CommandBuffer.Internal_SetRayTracingConstantComputeBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingConstantComputeBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingConstantComputeBufferParam");
			CommandBuffer.Internal_SetRayTracingConstantGraphicsBufferParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingConstantGraphicsBufferParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingConstantGraphicsBufferParam");
			CommandBuffer.Internal_SetRayTracingTextureParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingTextureParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingTextureParam");
			CommandBuffer.Internal_SetRayTracingFloatParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingFloatParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingFloatParam");
			CommandBuffer.Internal_SetRayTracingIntParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingIntParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingIntParam");
			CommandBuffer.Internal_SetRayTracingVectorArrayParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingVectorArrayParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingVectorArrayParam");
			CommandBuffer.Internal_SetRayTracingMatrixArrayParamDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingMatrixArrayParamDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingMatrixArrayParam");
			CommandBuffer.Internal_SetRayTracingFloatsDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingFloatsDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingFloats");
			CommandBuffer.Internal_SetRayTracingIntsDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingIntsDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingInts");
			CommandBuffer.Internal_SetRayTracingAccelerationStructureDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingAccelerationStructureDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingAccelerationStructure");
			CommandBuffer.SetRayTracingShaderPassDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRayTracingShaderPassDelegate>("UnityEngine.Rendering.CommandBuffer::SetRayTracingShaderPass");
			CommandBuffer.Internal_DispatchRaysDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DispatchRaysDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DispatchRays");
			CommandBuffer.Internal_ResolveAntiAliasedSurfaceDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_ResolveAntiAliasedSurfaceDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_ResolveAntiAliasedSurface");
			CommandBuffer.CopyCounterValueCCDelegateField = IL2CPP.ResolveICall<CommandBuffer.CopyCounterValueCCDelegate>("UnityEngine.Rendering.CommandBuffer::CopyCounterValueCC");
			CommandBuffer.CopyCounterValueGCDelegateField = IL2CPP.ResolveICall<CommandBuffer.CopyCounterValueGCDelegate>("UnityEngine.Rendering.CommandBuffer::CopyCounterValueGC");
			CommandBuffer.CopyCounterValueCGDelegateField = IL2CPP.ResolveICall<CommandBuffer.CopyCounterValueCGDelegate>("UnityEngine.Rendering.CommandBuffer::CopyCounterValueCG");
			CommandBuffer.CopyCounterValueGGDelegateField = IL2CPP.ResolveICall<CommandBuffer.CopyCounterValueGGDelegate>("UnityEngine.Rendering.CommandBuffer::CopyCounterValueGG");
			CommandBuffer.get_nameDelegateField = IL2CPP.ResolveICall<CommandBuffer.get_nameDelegate>("UnityEngine.Rendering.CommandBuffer::get_name");
			CommandBuffer.get_sizeInBytesDelegateField = IL2CPP.ResolveICall<CommandBuffer.get_sizeInBytesDelegate>("UnityEngine.Rendering.CommandBuffer::get_sizeInBytes");
			CommandBuffer.Internal_DrawRendererDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawRendererDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawRenderer");
			CommandBuffer.Internal_DrawMeshInstancedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawMeshInstancedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawMeshInstanced");
			CommandBuffer.Internal_DrawMeshInstancedProceduralDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawMeshInstancedProceduralDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawMeshInstancedProcedural");
			CommandBuffer.Internal_DrawMeshInstancedIndirectDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawMeshInstancedIndirectDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawMeshInstancedIndirect");
			CommandBuffer.Internal_DrawMeshInstancedIndirectGraphicsBufferDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawMeshInstancedIndirectGraphicsBufferDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawMeshInstancedIndirectGraphicsBuffer");
			CommandBuffer.SetRandomWriteTarget_TextureDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRandomWriteTarget_TextureDelegate>("UnityEngine.Rendering.CommandBuffer::SetRandomWriteTarget_Texture");
			CommandBuffer.SetRandomWriteTarget_BufferDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRandomWriteTarget_BufferDelegate>("UnityEngine.Rendering.CommandBuffer::SetRandomWriteTarget_Buffer");
			CommandBuffer.SetRandomWriteTarget_GraphicsBufferDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRandomWriteTarget_GraphicsBufferDelegate>("UnityEngine.Rendering.CommandBuffer::SetRandomWriteTarget_GraphicsBuffer");
			CommandBuffer.ClearRandomWriteTargetsDelegateField = IL2CPP.ResolveICall<CommandBuffer.ClearRandomWriteTargetsDelegate>("UnityEngine.Rendering.CommandBuffer::ClearRandomWriteTargets");
			CommandBuffer.DisableScissorRectDelegateField = IL2CPP.ResolveICall<CommandBuffer.DisableScissorRectDelegate>("UnityEngine.Rendering.CommandBuffer::DisableScissorRect");
			CommandBuffer.GetTemporaryRTArrayDelegateField = IL2CPP.ResolveICall<CommandBuffer.GetTemporaryRTArrayDelegate>("UnityEngine.Rendering.CommandBuffer::GetTemporaryRTArray");
			CommandBuffer.SetGlobalIntDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalIntDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalInt");
			CommandBuffer.SetGlobalDepthBiasDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalDepthBiasDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalDepthBias");
			CommandBuffer.SetExecutionFlagsDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetExecutionFlagsDelegate>("UnityEngine.Rendering.CommandBuffer::SetExecutionFlags");
			CommandBuffer.SetGlobalFloatArrayListImplDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalFloatArrayListImplDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalFloatArrayListImpl");
			CommandBuffer.SetGlobalVectorArrayListImplDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalVectorArrayListImplDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalVectorArrayListImpl");
			CommandBuffer.SetGlobalMatrixArrayListImplDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalMatrixArrayListImplDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalMatrixArrayListImpl");
			CommandBuffer.SetGlobalFloatArrayDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalFloatArrayDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalFloatArray");
			CommandBuffer.SetGlobalVectorArrayDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalVectorArrayDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalVectorArray");
			CommandBuffer.SetGlobalMatrixArrayDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalMatrixArrayDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalMatrixArray");
			CommandBuffer.SetLateLatchProjectionMatricesDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetLateLatchProjectionMatricesDelegate>("UnityEngine.Rendering.CommandBuffer::SetLateLatchProjectionMatrices");
			CommandBuffer.MarkLateLatchMatrixShaderPropertyIDDelegateField = IL2CPP.ResolveICall<CommandBuffer.MarkLateLatchMatrixShaderPropertyIDDelegate>("UnityEngine.Rendering.CommandBuffer::MarkLateLatchMatrixShaderPropertyID");
			CommandBuffer.UnmarkLateLatchMatrixDelegateField = IL2CPP.ResolveICall<CommandBuffer.UnmarkLateLatchMatrixDelegate>("UnityEngine.Rendering.CommandBuffer::UnmarkLateLatchMatrix");
			CommandBuffer.SetGlobalBufferInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalBufferInternalDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalBufferInternal");
			CommandBuffer.SetGlobalGraphicsBufferInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalGraphicsBufferInternalDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalGraphicsBufferInternal");
			CommandBuffer.SetShadowSamplingMode_ImplDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetShadowSamplingMode_ImplDelegate>("UnityEngine.Rendering.CommandBuffer::SetShadowSamplingMode_Impl");
			CommandBuffer.IssuePluginEventInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.IssuePluginEventInternalDelegate>("UnityEngine.Rendering.CommandBuffer::IssuePluginEventInternal");
			CommandBuffer.BeginSample_CustomSamplerDelegateField = IL2CPP.ResolveICall<CommandBuffer.BeginSample_CustomSamplerDelegate>("UnityEngine.Rendering.CommandBuffer::BeginSample_CustomSampler");
			CommandBuffer.EndSample_CustomSamplerDelegateField = IL2CPP.ResolveICall<CommandBuffer.EndSample_CustomSamplerDelegate>("UnityEngine.Rendering.CommandBuffer::EndSample_CustomSampler");
			CommandBuffer.IssuePluginEventAndDataInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.IssuePluginEventAndDataInternalDelegate>("UnityEngine.Rendering.CommandBuffer::IssuePluginEventAndDataInternal");
			CommandBuffer.IssuePluginCustomBlitInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.IssuePluginCustomBlitInternalDelegate>("UnityEngine.Rendering.CommandBuffer::IssuePluginCustomBlitInternal");
			CommandBuffer.IssuePluginCustomTextureUpdateInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.IssuePluginCustomTextureUpdateInternalDelegate>("UnityEngine.Rendering.CommandBuffer::IssuePluginCustomTextureUpdateInternal");
			CommandBuffer.SetGlobalConstantBufferInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalConstantBufferInternalDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalConstantBufferInternal");
			CommandBuffer.SetGlobalConstantGraphicsBufferInternalDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalConstantGraphicsBufferInternalDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalConstantGraphicsBufferInternal");
			CommandBuffer.SetInstanceMultiplierDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetInstanceMultiplierDelegate>("UnityEngine.Rendering.CommandBuffer::SetInstanceMultiplier");
			CommandBuffer.InternalSetComputeBufferNativeDataDelegateField = IL2CPP.ResolveICall<CommandBuffer.InternalSetComputeBufferNativeDataDelegate>("UnityEngine.Rendering.CommandBuffer::InternalSetComputeBufferNativeData");
			CommandBuffer.InternalSetComputeBufferDataDelegateField = IL2CPP.ResolveICall<CommandBuffer.InternalSetComputeBufferDataDelegate>("UnityEngine.Rendering.CommandBuffer::InternalSetComputeBufferData");
			CommandBuffer.SetComputeBufferCounterValueDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeBufferCounterValueDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeBufferCounterValue");
			CommandBuffer.ConvertTexture_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.ConvertTexture_Internal_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::ConvertTexture_Internal_Injected");
			CommandBuffer.SetComputeMatrixParam_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetComputeMatrixParam_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetComputeMatrixParam_Injected");
			CommandBuffer.Internal_SetRayTracingVectorParam_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingVectorParam_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingVectorParam_Injected");
			CommandBuffer.Internal_SetRayTracingMatrixParam_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_SetRayTracingMatrixParam_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_SetRayTracingMatrixParam_Injected");
			CommandBuffer.Internal_BuildRayTracingAccelerationStructure_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_BuildRayTracingAccelerationStructure_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_BuildRayTracingAccelerationStructure_Injected");
			CommandBuffer.Internal_GenerateMips_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_GenerateMips_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_GenerateMips_Injected");
			CommandBuffer.Internal_DrawProcedural_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProcedural_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProcedural_Injected");
			CommandBuffer.Internal_DrawProceduralIndexed_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProceduralIndexed_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProceduralIndexed_Injected");
			CommandBuffer.Internal_DrawProceduralIndirect_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProceduralIndirect_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProceduralIndirect_Injected");
			CommandBuffer.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProceduralIndexedIndirect_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProceduralIndexedIndirect_Injected");
			CommandBuffer.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProceduralIndirectGraphicsBuffer_Injected");
			CommandBuffer.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected");
			CommandBuffer.Internal_DrawOcclusionMesh_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_DrawOcclusionMesh_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_DrawOcclusionMesh_Injected");
			CommandBuffer.EnableScissorRect_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.EnableScissorRect_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::EnableScissorRect_Injected");
			CommandBuffer.SetGlobalColor_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalColor_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalColor_Injected");
			CommandBuffer.SetGlobalMatrix_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetGlobalMatrix_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetGlobalMatrix_Injected");
			CommandBuffer.SetViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetViewMatrix_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetViewMatrix_Injected");
			CommandBuffer.SetProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetProjectionMatrix_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetProjectionMatrix_Injected");
			CommandBuffer.SetViewProjectionMatrices_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetViewProjectionMatrices_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetViewProjectionMatrices_Injected");
			CommandBuffer.IncrementUpdateCount_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.IncrementUpdateCount_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::IncrementUpdateCount_Injected");
			CommandBuffer.SetRenderTargetColorDepthSubtarget_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRenderTargetColorDepthSubtarget_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetRenderTargetColorDepthSubtarget_Injected");
			CommandBuffer.SetRenderTargetMultiSubtarget_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.SetRenderTargetMultiSubtarget_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::SetRenderTargetMultiSubtarget_Injected");
			CommandBuffer.Internal_ProcessVTFeedback_InjectedDelegateField = IL2CPP.ResolveICall<CommandBuffer.Internal_ProcessVTFeedback_InjectedDelegate>("UnityEngine.Rendering.CommandBuffer::Internal_ProcessVTFeedback_Injected");
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00064690 File Offset: 0x00062890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502557, RefRangeEnd = 502559, XrefRangeStart = 502553, XrefRangeEnd = 502557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_SetSinglePassStereo(SinglePassStereoMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Internal_SetSinglePassStereo_Private_Void_SinglePassStereoMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000646D0 File Offset: 0x000628D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502559, XrefRangeEnd = 502563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InitBuffer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00064700 File Offset: 0x00062900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502563, XrefRangeEnd = 502567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_ReleaseBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00064734 File Offset: 0x00062934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502567, XrefRangeEnd = 502569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetComputeVectorParam_Public_Void_ComputeShader_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00064794 File Offset: 0x00062994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502569, XrefRangeEnd = 502573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, Il2CppStructArray<float> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Internal_SetComputeFloats_Private_Void_ComputeShader_Int32_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x000647F8 File Offset: 0x000629F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502573, XrefRangeEnd = 502577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rt;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Internal_SetComputeTextureParam_Private_Void_ComputeShader_Int32_Int32_byref_RenderTargetIdentifier_Int32_RenderTextureSubElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00064884 File Offset: 0x00062A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502577, XrefRangeEnd = 502581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Internal_SetComputeBufferParam_Private_Void_ComputeShader_Int32_Int32_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000648F8 File Offset: 0x00062AF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 502585, RefRangeEnd = 502589, XrefRangeStart = 502581, XrefRangeEnd = 502585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadGroupsX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadGroupsY;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadGroupsZ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Internal_DispatchCompute_Private_Void_ComputeShader_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x00066658 File Offset: 0x00064858
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x00064974 File Offset: 0x00062B74
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = CommandBuffer.get_nameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502589, XrefRangeEnd = 502593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x000649B8 File Offset: 0x00062BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502593, XrefRangeEnd = 502597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x000649EC File Offset: 0x00062BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502597, XrefRangeEnd = 502599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPass;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Internal_DrawMesh_Private_Void_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00064A80 File Offset: 0x00062C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502599, XrefRangeEnd = 502601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetViewport(Rect pixelRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pixelRect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetViewport_Public_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00064AC0 File Offset: 0x00062CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502601, XrefRangeEnd = 502605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcMip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcX;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcY;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcWidth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcHeight;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dst;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstMip;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstX;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstY;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_CopyTexture_Internal_Private_Void_byref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_byref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00064BAC File Offset: 0x00062DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502605, XrefRangeEnd = 502607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceDepthSlice;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destDepthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Blit_Texture_Private_Void_Texture_byref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00064C54 File Offset: 0x00062E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502609, RefRangeEnd = 502611, XrefRangeStart = 502607, XrefRangeEnd = 502609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceDepthSlice;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destDepthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Blit_Identifier_Private_Void_byref_RenderTargetIdentifier_byref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00064CF8 File Offset: 0x00062EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502611, XrefRangeEnd = 502615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableRandomWrite;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00064DB8 File Offset: 0x00062FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502615, XrefRangeEnd = 502619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableRandomWrite;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00064E68 File Offset: 0x00063068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502619, XrefRangeEnd = 502621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00064EFC File Offset: 0x000630FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502621, XrefRangeEnd = 502623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00064F80 File Offset: 0x00063180
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 502626, RefRangeEnd = 502631, XrefRangeStart = 502623, XrefRangeEnd = 502626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableRandomWrite;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00065050 File Offset: 0x00063250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502631, XrefRangeEnd = 502632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableRandomWrite;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00065110 File Offset: 0x00063310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502632, XrefRangeEnd = 502633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableRandomWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x000651C0 File Offset: 0x000633C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 502636, RefRangeEnd = 502640, XrefRangeStart = 502633, XrefRangeEnd = 502636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00065244 File Offset: 0x00063444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502640, XrefRangeEnd = 502642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_GetTemporaryRTWithDescriptor_Private_Void_Int32_RenderTextureDescriptor_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000652A0 File Offset: 0x000634A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502642, XrefRangeEnd = 502644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_RenderTextureDescriptor_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x000652FC File Offset: 0x000634FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 502648, RefRangeEnd = 502655, XrefRangeStart = 502644, XrefRangeEnd = 502648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseTemporaryRT(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_ReleaseTemporaryRT_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0006533C File Offset: 0x0006353C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502655, XrefRangeEnd = 502657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_ClearRenderTarget_Public_Void_Boolean_Boolean_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x000653A4 File Offset: 0x000635A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 502661, RefRangeEnd = 502667, XrefRangeStart = 502657, XrefRangeEnd = 502661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_ClearRenderTarget_Public_Void_Boolean_Boolean_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00065400 File Offset: 0x00063600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502667, XrefRangeEnd = 502671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalFloat(int nameID, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetGlobalFloat_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0006544C File Offset: 0x0006364C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502671, XrefRangeEnd = 502673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalVector(int nameID, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetGlobalVector_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00065498 File Offset: 0x00063698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502673, XrefRangeEnd = 502677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableShaderKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_EnableShaderKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x000654DC File Offset: 0x000636DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502677, XrefRangeEnd = 502681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableShaderKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_DisableShaderKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00065520 File Offset: 0x00063720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502681, XrefRangeEnd = 502685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref requiredFlags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invalidFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_ValidateAgainstExecutionFlags_Private_Boolean_CommandBufferExecutionFlags_CommandBufferExecutionFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00065578 File Offset: 0x00063778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502689, RefRangeEnd = 502691, XrefRangeStart = 502685, XrefRangeEnd = 502689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetGlobalTexture_Impl_Private_Void_Int32_byref_RenderTargetIdentifier_RenderTextureSubElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x000655D4 File Offset: 0x000637D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502691, XrefRangeEnd = 502695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginSample(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_BeginSample_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00065618 File Offset: 0x00063818
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502699, RefRangeEnd = 502700, XrefRangeStart = 502695, XrefRangeEnd = 502699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSample(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_EndSample_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0006565C File Offset: 0x0006385C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 502704, RefRangeEnd = 502707, XrefRangeStart = 502700, XrefRangeEnd = 502704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetRenderTarget_Public_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x000656B8 File Offset: 0x000638B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502711, RefRangeEnd = 502712, XrefRangeStart = 502707, XrefRangeEnd = 502711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetRenderTarget_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00065720 File Offset: 0x00063920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502712, XrefRangeEnd = 502716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetRenderTarget_Public_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x000657A4 File Offset: 0x000639A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502722, RefRangeEnd = 502723, XrefRangeStart = 502716, XrefRangeEnd = 502722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTarget(Il2CppStructArray<RenderTargetIdentifier> colors, RenderTargetIdentifier depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetRenderTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x000657F4 File Offset: 0x000639F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502723, XrefRangeEnd = 502725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetRenderTargetSingle_Internal_Private_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0006586C File Offset: 0x00063A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502725, XrefRangeEnd = 502727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetRenderTargetColorDepth_Internal_Private_Void_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00065900 File Offset: 0x00063B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502727, XrefRangeEnd = 502729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTargetMulti_Internal(Il2CppStructArray<RenderTargetIdentifier> colors, RenderTargetIdentifier depth, Il2CppStructArray<RenderBufferLoadAction> colorLoadActions, Il2CppStructArray<RenderBufferStoreAction> colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorLoadActions);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorStoreActions);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetRenderTargetMulti_Internal_Private_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_Il2CppStructArray_1_RenderBufferLoadAction_Il2CppStructArray_1_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x000659A0 File Offset: 0x00063BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502729, XrefRangeEnd = 502731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommandBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x000659DC File Offset: 0x00063BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502731, XrefRangeEnd = 502736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00065A10 File Offset: 0x00063C10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502739, RefRangeEnd = 502741, XrefRangeStart = 502736, XrefRangeEnd = 502739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00065A50 File Offset: 0x00063C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502741, XrefRangeEnd = 502743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00065A8C File Offset: 0x00063C8C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 502747, RefRangeEnd = 502780, XrefRangeStart = 502743, XrefRangeEnd = 502747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetComputeVectorParam_Public_Void_ComputeShader_String_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00065AF0 File Offset: 0x00063CF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502788, RefRangeEnd = 502790, XrefRangeStart = 502780, XrefRangeEnd = 502788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetComputeFloatParams(ComputeShader computeShader, string name, [Optional] Il2CppStructArray<float> values)
		{
			if (values == null)
			{
				values = new Il2CppStructArray<float>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetComputeFloatParams_Public_Void_ComputeShader_String_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00065B64 File Offset: 0x00063D64
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 502794, RefRangeEnd = 502826, XrefRangeStart = 502790, XrefRangeEnd = 502794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetComputeTextureParam_Public_Void_ComputeShader_Int32_String_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00065BD4 File Offset: 0x00063DD4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 502834, RefRangeEnd = 502843, XrefRangeStart = 502826, XrefRangeEnd = 502834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetComputeBufferParam_Public_Void_ComputeShader_Int32_String_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00065C4C File Offset: 0x00063E4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 502585, RefRangeEnd = 502589, XrefRangeStart = 502585, XrefRangeEnd = 502589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadGroupsX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadGroupsY;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadGroupsZ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_DispatchCompute_Public_Void_ComputeShader_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00065CC8 File Offset: 0x00063EC8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 502885, RefRangeEnd = 502892, XrefRangeStart = 502843, XrefRangeEnd = 502885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPass;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_DrawMesh_Public_Void_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00065D5C File Offset: 0x00063F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502892, XrefRangeEnd = 502893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_DrawMesh_Public_Void_Mesh_Matrix4x4_Material_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00065DDC File Offset: 0x00063FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502893, XrefRangeEnd = 502895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_CopyTexture_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00065E28 File Offset: 0x00064028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502897, RefRangeEnd = 502899, XrefRangeStart = 502895, XrefRangeEnd = 502897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcMip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dst;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstMip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_CopyTexture_Public_Void_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00065EAC File Offset: 0x000640AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502899, XrefRangeEnd = 502905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit(Texture source, RenderTargetIdentifier dest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Blit_Public_Void_Texture_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00065EFC File Offset: 0x000640FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502910, RefRangeEnd = 502912, XrefRangeStart = 502905, XrefRangeEnd = 502910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Blit_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00065F48 File Offset: 0x00064148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502912, XrefRangeEnd = 502917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Blit_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00065FB4 File Offset: 0x000641B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502917, XrefRangeEnd = 502921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalTexture(string name, RenderTargetIdentifier value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetGlobalTexture_Public_Void_String_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00066004 File Offset: 0x00064204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502921, XrefRangeEnd = 502922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalTexture(int nameID, RenderTargetIdentifier value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetGlobalTexture_Public_Void_Int32_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00066050 File Offset: 0x00064250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502922, XrefRangeEnd = 502923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetGlobalTexture_Public_Void_Int32_RenderTargetIdentifier_RenderTextureSubElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x000660AC File Offset: 0x000642AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502557, RefRangeEnd = 502559, XrefRangeStart = 502557, XrefRangeEnd = 502559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSinglePassStereo(SinglePassStereoMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetSinglePassStereo_Public_Void_SinglePassStereoMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x000660EC File Offset: 0x000642EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502923, XrefRangeEnd = 502927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetComputeVectorParam_Injected_Private_Void_ComputeShader_Int32_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0006614C File Offset: 0x0006434C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502927, XrefRangeEnd = 502931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPass;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Void_Mesh_byref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x000661E0 File Offset: 0x000643E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502931, XrefRangeEnd = 502935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetViewport_Injected(ref Rect pixelRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pixelRect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetViewport_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00066220 File Offset: 0x00064420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502935, XrefRangeEnd = 502939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceDepthSlice;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destDepthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Blit_Texture_Injected_Private_Void_Texture_byref_RenderTargetIdentifier_Material_Int32_byref_Vector2_byref_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x000662CC File Offset: 0x000644CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502939, XrefRangeEnd = 502943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceDepthSlice;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destDepthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_Blit_Identifier_Injected_Private_Void_byref_RenderTargetIdentifier_byref_RenderTargetIdentifier_Material_Int32_byref_Vector2_byref_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00066374 File Offset: 0x00064574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502943, XrefRangeEnd = 502947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &desc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_GetTemporaryRTWithDescriptor_Injected_Private_Void_Int32_byref_RenderTextureDescriptor_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x000663D0 File Offset: 0x000645D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502947, XrefRangeEnd = 502951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRenderTarget_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &backgroundColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_ClearRenderTarget_Injected_Private_Void_Boolean_Boolean_byref_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00066438 File Offset: 0x00064638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502951, XrefRangeEnd = 502955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalVector_Injected(int nameID, ref Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetGlobalVector_Injected_Private_Void_Int32_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00066484 File Offset: 0x00064684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502955, XrefRangeEnd = 502959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetRenderTargetSingle_Internal_Injected_Private_Void_byref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x000664FC File Offset: 0x000646FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502959, XrefRangeEnd = 502963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetRenderTargetColorDepth_Internal_Injected_Private_Void_byref_RenderTargetIdentifier_byref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00066590 File Offset: 0x00064790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502963, XrefRangeEnd = 502967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTargetMulti_Internal_Injected(Il2CppStructArray<RenderTargetIdentifier> colors, ref RenderTargetIdentifier depth, Il2CppStructArray<RenderBufferLoadAction> colorLoadActions, Il2CppStructArray<RenderBufferStoreAction> colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorLoadActions);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorStoreActions);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBuffer.NativeMethodInfoPtr_SetRenderTargetMulti_Internal_Injected_Private_Void_Il2CppStructArray_1_RenderTargetIdentifier_byref_RenderTargetIdentifier_Il2CppStructArray_1_RenderBufferLoadAction_Il2CppStructArray_1_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0000DA8C File Offset: 0x0000BC8C
		public void SetComputeFloatParams(ComputeShader computeShader, string name, params float[] values)
		{
			this.SetComputeFloatParams(computeShader, name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0000DA9C File Offset: 0x0000BC9C
		public CommandBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x00066630 File Offset: 0x00064830
		// (set) Token: 0x06001A70 RID: 6768 RVA: 0x0000DAA5 File Offset: 0x0000BCA5
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandBuffer.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandBuffer.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0000DAC0 File Offset: 0x0000BCC0
		public void ConvertTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.ConvertTexture_Internal(src, 0, dst, 0);
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0000DAD7 File Offset: 0x0000BCD7
		public void ConvertTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.ConvertTexture_Internal(src, srcElement, dst, dstElement);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0000DAEF File Offset: 0x0000BCEF
		public void WaitAllAsyncReadbackRequests()
		{
			CommandBuffer.WaitAllAsyncReadbackRequestsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0000DB01 File Offset: 0x0000BD01
		public void SetInvertCulling(bool invertCulling)
		{
			CommandBuffer.SetInvertCullingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), invertCulling);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0000DB14 File Offset: 0x0000BD14
		public void ConvertTexture_Internal(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement)
		{
			this.ConvertTexture_Internal_Injected(ref src, srcElement, ref dst, dstElement);
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0000DB23 File Offset: 0x0000BD23
		public IntPtr CreateGPUFence_Internal(GraphicsFenceType fenceType, SynchronisationStageFlags stage)
		{
			return CommandBuffer.CreateGPUFence_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), fenceType, stage);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0000DB37 File Offset: 0x0000BD37
		public void WaitOnGPUFence_Internal(IntPtr fencePtr, SynchronisationStageFlags stage)
		{
			CommandBuffer.WaitOnGPUFence_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), fencePtr, stage);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0000DB4B File Offset: 0x0000BD4B
		public void SetComputeFloatParam(ComputeShader computeShader, int nameID, float val)
		{
			CommandBuffer.SetComputeFloatParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, val);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0000DB65 File Offset: 0x0000BD65
		public void SetComputeIntParam(ComputeShader computeShader, int nameID, int val)
		{
			CommandBuffer.SetComputeIntParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, val);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0000DB7F File Offset: 0x0000BD7F
		public void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Il2CppStructArray<Vector4> values)
		{
			CommandBuffer.SetComputeVectorArrayParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x0000DB9E File Offset: 0x0000BD9E
		public void SetComputeMatrixParam(ComputeShader computeShader, int nameID, Matrix4x4 val)
		{
			this.SetComputeMatrixParam_Injected(computeShader, nameID, ref val);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x0000DBAA File Offset: 0x0000BDAA
		public void SetComputeMatrixArrayParam(ComputeShader computeShader, int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			CommandBuffer.SetComputeMatrixArrayParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x0000DBC9 File Offset: 0x0000BDC9
		public void Internal_SetComputeInts(ComputeShader computeShader, int nameID, Il2CppStructArray<int> values)
		{
			CommandBuffer.Internal_SetComputeIntsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
		public void Internal_SetComputeGraphicsBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			CommandBuffer.Internal_SetComputeGraphicsBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0000DC09 File Offset: 0x0000BE09
		public void Internal_SetComputeConstantComputeBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
			CommandBuffer.Internal_SetComputeConstantComputeBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0000DC2C File Offset: 0x0000BE2C
		public void Internal_SetComputeConstantGraphicsBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			CommandBuffer.Internal_SetComputeConstantGraphicsBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0000DC4F File Offset: 0x0000BE4F
		public void Internal_DispatchComputeIndirect(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset)
		{
			CommandBuffer.Internal_DispatchComputeIndirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(indirectBuffer), argsOffset);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0000DC70 File Offset: 0x0000BE70
		public void Internal_DispatchComputeIndirectGraphicsBuffer(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset)
		{
			CommandBuffer.Internal_DispatchComputeIndirectGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(indirectBuffer), argsOffset);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0000DC91 File Offset: 0x0000BE91
		public void Internal_SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer)
		{
			CommandBuffer.Internal_SetRayTracingBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		public void Internal_SetRayTracingConstantComputeBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
			CommandBuffer.Internal_SetRayTracingConstantComputeBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0000DCD3 File Offset: 0x0000BED3
		public void Internal_SetRayTracingConstantGraphicsBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			CommandBuffer.Internal_SetRayTracingConstantGraphicsBufferParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0000DCF6 File Offset: 0x0000BEF6
		public void Internal_SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ref RenderTargetIdentifier rt)
		{
			CommandBuffer.Internal_SetRayTracingTextureParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, ref rt);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0000DD10 File Offset: 0x0000BF10
		public void Internal_SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, float val)
		{
			CommandBuffer.Internal_SetRayTracingFloatParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, val);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0000DD2A File Offset: 0x0000BF2A
		public void Internal_SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, int val)
		{
			CommandBuffer.Internal_SetRayTracingIntParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, val);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0000DD44 File Offset: 0x0000BF44
		public void Internal_SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Vector4 val)
		{
			this.Internal_SetRayTracingVectorParam_Injected(rayTracingShader, nameID, ref val);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0000DD50 File Offset: 0x0000BF50
		public void Internal_SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<Vector4> values)
		{
			CommandBuffer.Internal_SetRayTracingVectorArrayParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0000DD6F File Offset: 0x0000BF6F
		public void Internal_SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Matrix4x4 val)
		{
			this.Internal_SetRayTracingMatrixParam_Injected(rayTracingShader, nameID, ref val);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0000DD7B File Offset: 0x0000BF7B
		public void Internal_SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			CommandBuffer.Internal_SetRayTracingMatrixArrayParamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x0000DD9A File Offset: 0x0000BF9A
		public void Internal_SetRayTracingFloats(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<float> values)
		{
			CommandBuffer.Internal_SetRayTracingFloatsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0000DDB9 File Offset: 0x0000BFB9
		public void Internal_SetRayTracingInts(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<int> values)
		{
			CommandBuffer.Internal_SetRayTracingIntsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		public void Internal_BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure, Vector3 relativeOrigin)
		{
			this.Internal_BuildRayTracingAccelerationStructure_Injected(accelerationStructure, ref relativeOrigin);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0000DDE3 File Offset: 0x0000BFE3
		public void Internal_SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure)
		{
			CommandBuffer.Internal_SetRayTracingAccelerationStructureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, IL2CPP.Il2CppObjectBaseToPtr(accelerationStructure));
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x0000DE02 File Offset: 0x0000C002
		public void SetRayTracingShaderPass(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string passName)
		{
			CommandBuffer.SetRayTracingShaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), IL2CPP.ManagedStringToIl2Cpp(passName));
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0000DE20 File Offset: 0x0000C020
		public void Internal_DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string rayGenShaderName, uint width, uint height, uint depth, [Optional] Camera camera)
		{
			CommandBuffer.Internal_DispatchRaysDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), IL2CPP.ManagedStringToIl2Cpp(rayGenShaderName), width, height, depth, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x0000DE4A File Offset: 0x0000C04A
		public void Internal_GenerateMips(RenderTargetIdentifier rt)
		{
			this.Internal_GenerateMips_Injected(ref rt);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0000DE54 File Offset: 0x0000C054
		public void Internal_ResolveAntiAliasedSurface(RenderTexture rt, RenderTexture target)
		{
			CommandBuffer.Internal_ResolveAntiAliasedSurfaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rt), IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0000DE72 File Offset: 0x0000C072
		public void CopyCounterValueCC(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
			CommandBuffer.CopyCounterValueCCDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0000DE91 File Offset: 0x0000C091
		public void CopyCounterValueGC(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
			CommandBuffer.CopyCounterValueGCDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		public void CopyCounterValueCG(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
			CommandBuffer.CopyCounterValueCGDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0000DECF File Offset: 0x0000C0CF
		public void CopyCounterValueGG(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
			CommandBuffer.CopyCounterValueGGDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x0000DEEE File Offset: 0x0000C0EE
		public int sizeInBytes
		{
			get
			{
				return CommandBuffer.get_sizeInBytesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x0000DF00 File Offset: 0x0000C100
		public void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass)
		{
			CommandBuffer.Internal_DrawRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(renderer), IL2CPP.Il2CppObjectBaseToPtr(material), submeshIndex, shaderPass);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0000DF21 File Offset: 0x0000C121
		public void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_DrawRenderer(renderer, material, submeshIndex, -1);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0000DF38 File Offset: 0x0000C138
		public void Internal_DrawRenderer(Renderer renderer, Material material)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_DrawRenderer(renderer, material, 0);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0000DF4E File Offset: 0x0000C14E
		public void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProcedural_Injected(ref matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0006667C File Offset: 0x0006487C
		public void Internal_DrawProceduralIndexed(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProceduralIndexed_Injected(indexBuffer, ref matrix, material, shaderPass, topology, indexCount, instanceCount, properties);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0000DF62 File Offset: 0x0000C162
		public void Internal_DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProceduralIndirect_Injected(ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x000666A0 File Offset: 0x000648A0
		public void Internal_DrawProceduralIndexedIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProceduralIndexedIndirect_Injected(indexBuffer, ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x0000DF76 File Offset: 0x0000C176
		public void Internal_DrawProceduralIndirectGraphicsBuffer(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProceduralIndirectGraphicsBuffer_Injected(ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x000666C4 File Offset: 0x000648C4
		public void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			this.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(indexBuffer, ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x000666E8 File Offset: 0x000648E8
		public void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawMeshInstancedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, IL2CPP.Il2CppObjectBaseToPtr(matrices), count, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0000DF8A File Offset: 0x0000C18A
		public void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawMeshInstancedProceduralDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, count, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00066724 File Offset: 0x00064924
		public void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawMeshInstancedIndirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00066760 File Offset: 0x00064960
		public void Internal_DrawMeshInstancedIndirectGraphicsBuffer(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawMeshInstancedIndirectGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
		public void Internal_DrawOcclusionMesh(RectInt normalizedCamViewport)
		{
			this.Internal_DrawOcclusionMesh_Injected(ref normalizedCamViewport);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0000DFBE File Offset: 0x0000C1BE
		public void SetRandomWriteTarget_Texture(int index, ref RenderTargetIdentifier rt)
		{
			CommandBuffer.SetRandomWriteTarget_TextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref rt);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x0000DFD2 File Offset: 0x0000C1D2
		public void SetRandomWriteTarget_Buffer(int index, ComputeBuffer uav, bool preserveCounterValue)
		{
			CommandBuffer.SetRandomWriteTarget_BufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0000DFEC File Offset: 0x0000C1EC
		public void SetRandomWriteTarget_GraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
			CommandBuffer.SetRandomWriteTarget_GraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0000E006 File Offset: 0x0000C206
		public void ClearRandomWriteTargets()
		{
			CommandBuffer.ClearRandomWriteTargetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0000E018 File Offset: 0x0000C218
		public void EnableScissorRect(Rect scissor)
		{
			this.EnableScissorRect_Injected(ref scissor);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0000E022 File Offset: 0x0000C222
		public void DisableScissorRect()
		{
			CommandBuffer.DisableScissorRectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0006679C File Offset: 0x0006499C
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite, RenderTextureMemoryless.None);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x000667C0 File Offset: 0x000649C0
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, false);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000667E4 File Offset: 0x000649E4
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, 1);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0000E034 File Offset: 0x0000C234
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, SystemInfo.GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat.LDR));
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0000E04B File Offset: 0x0000C24B
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer)
		{
			this.GetTemporaryRT(nameID, width, height, depthBuffer, FilterMode.Point);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0000E05B File Offset: 0x0000C25B
		public void GetTemporaryRT(int nameID, int width, int height)
		{
			this.GetTemporaryRT(nameID, width, height, 0);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0000E069 File Offset: 0x0000C269
		public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc)
		{
			this.GetTemporaryRT(nameID, desc, FilterMode.Point);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00066808 File Offset: 0x00064A08
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, bool useDynamicScale)
		{
			CommandBuffer.GetTemporaryRTArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, enableRandomWrite, useDynamicScale);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00066838 File Offset: 0x00064A38
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, enableRandomWrite, false);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x00066860 File Offset: 0x00064A60
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, false);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00066884 File Offset: 0x00064A84
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, 1);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000668A8 File Offset: 0x00064AA8
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, readWrite), antiAliasing, enableRandomWrite, false);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000668D4 File Offset: 0x00064AD4
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, readWrite), antiAliasing, false);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00066900 File Offset: 0x00064B00
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, readWrite), 1, false);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0006692C File Offset: 0x00064B2C
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, RenderTextureFormat format)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, RenderTextureReadWrite.Default), 1, false);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00066954 File Offset: 0x00064B54
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, SystemInfo.GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat.LDR), 1, false);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0000E076 File Offset: 0x0000C276
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, FilterMode.Point);
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0000E088 File Offset: 0x0000C288
		public void GetTemporaryRTArray(int nameID, int width, int height, int slices)
		{
			this.GetTemporaryRTArray(nameID, width, height, slices, 0);
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0000E098 File Offset: 0x0000C298
		public void SetGlobalInt(int nameID, int value)
		{
			CommandBuffer.SetGlobalIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, value);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		public void SetGlobalColor(int nameID, Color value)
		{
			this.SetGlobalColor_Injected(nameID, ref value);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0000E0B7 File Offset: 0x0000C2B7
		public void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
			this.SetGlobalMatrix_Injected(nameID, ref value);
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x0000E0C2 File Offset: 0x0000C2C2
		public void SetViewMatrix(Matrix4x4 view)
		{
			this.SetViewMatrix_Injected(ref view);
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0000E0CC File Offset: 0x0000C2CC
		public void SetProjectionMatrix(Matrix4x4 proj)
		{
			this.SetProjectionMatrix_Injected(ref proj);
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0000E0D6 File Offset: 0x0000C2D6
		public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj)
		{
			this.SetViewProjectionMatrices_Injected(ref view, ref proj);
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0000E0E2 File Offset: 0x0000C2E2
		public void SetGlobalDepthBias(float bias, float slopeBias)
		{
			CommandBuffer.SetGlobalDepthBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bias, slopeBias);
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0000E0F6 File Offset: 0x0000C2F6
		public void SetExecutionFlags(CommandBufferExecutionFlags flags)
		{
			CommandBuffer.SetExecutionFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), flags);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0000E109 File Offset: 0x0000C309
		public void SetGlobalFloatArrayListImpl(int nameID, Object values)
		{
			CommandBuffer.SetGlobalFloatArrayListImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0000E122 File Offset: 0x0000C322
		public void SetGlobalVectorArrayListImpl(int nameID, Object values)
		{
			CommandBuffer.SetGlobalVectorArrayListImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0000E13B File Offset: 0x0000C33B
		public void SetGlobalMatrixArrayListImpl(int nameID, Object values)
		{
			CommandBuffer.SetGlobalMatrixArrayListImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0000E154 File Offset: 0x0000C354
		public void SetGlobalFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			CommandBuffer.SetGlobalFloatArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0000E16D File Offset: 0x0000C36D
		public void SetGlobalVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			CommandBuffer.SetGlobalVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0000E186 File Offset: 0x0000C386
		public void SetGlobalMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			CommandBuffer.SetGlobalMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0000E19F File Offset: 0x0000C39F
		public void SetLateLatchProjectionMatrices(Il2CppStructArray<Matrix4x4> projectionMat)
		{
			CommandBuffer.SetLateLatchProjectionMatricesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(projectionMat));
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0000E1B7 File Offset: 0x0000C3B7
		public void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID)
		{
			CommandBuffer.MarkLateLatchMatrixShaderPropertyIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), matrixPropertyType, shaderPropertyID);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0000E1CB File Offset: 0x0000C3CB
		public void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType)
		{
			CommandBuffer.UnmarkLateLatchMatrixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), matrixPropertyType);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x0000E1DE File Offset: 0x0000C3DE
		public void SetGlobalBufferInternal(int nameID, ComputeBuffer value)
		{
			CommandBuffer.SetGlobalBufferInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0000E1F7 File Offset: 0x0000C3F7
		public void SetGlobalGraphicsBufferInternal(int nameID, GraphicsBuffer value)
		{
			CommandBuffer.SetGlobalGraphicsBufferInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0000E210 File Offset: 0x0000C410
		public void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode)
		{
			CommandBuffer.SetShadowSamplingMode_ImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref shadowmap, mode);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0000E224 File Offset: 0x0000C424
		public void IssuePluginEventInternal(IntPtr callback, int eventID)
		{
			CommandBuffer.IssuePluginEventInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), callback, eventID);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0000E238 File Offset: 0x0000C438
		public void BeginSample(UnityEngine.Profiling.CustomSampler sampler)
		{
			this.BeginSample_CustomSampler(sampler);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0000E243 File Offset: 0x0000C443
		public void EndSample(UnityEngine.Profiling.CustomSampler sampler)
		{
			this.EndSample_CustomSampler(sampler);
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x0000E24E File Offset: 0x0000C44E
		public void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler)
		{
			CommandBuffer.BeginSample_CustomSamplerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(sampler));
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0000E266 File Offset: 0x0000C466
		public void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler)
		{
			CommandBuffer.EndSample_CustomSamplerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(sampler));
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x0000E27E File Offset: 0x0000C47E
		public void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data)
		{
			CommandBuffer.IssuePluginEventAndDataInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), callback, eventID, data);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x0000E293 File Offset: 0x0000C493
		public void IssuePluginCustomBlitInternal(IntPtr callback, uint command, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, uint commandParam, uint commandFlags)
		{
			CommandBuffer.IssuePluginCustomBlitInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), callback, command, ref source, ref dest, commandParam, commandFlags);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0000E2AE File Offset: 0x0000C4AE
		public void IssuePluginCustomTextureUpdateInternal(IntPtr callback, Texture targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2)
		{
			CommandBuffer.IssuePluginCustomTextureUpdateInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), callback, IL2CPP.Il2CppObjectBaseToPtr(targetTexture), userData, useNewUnityRenderingExtTextureUpdateParamsV2);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0000E2CA File Offset: 0x0000C4CA
		public void SetGlobalConstantBufferInternal(ComputeBuffer buffer, int nameID, int offset, int size)
		{
			CommandBuffer.SetGlobalConstantBufferInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), nameID, offset, size);
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0000E2E6 File Offset: 0x0000C4E6
		public void SetGlobalConstantGraphicsBufferInternal(GraphicsBuffer buffer, int nameID, int offset, int size)
		{
			CommandBuffer.SetGlobalConstantGraphicsBufferInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), nameID, offset, size);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0000E302 File Offset: 0x0000C502
		public void IncrementUpdateCount(RenderTargetIdentifier dest)
		{
			this.IncrementUpdateCount_Injected(ref dest);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0000E30C File Offset: 0x0000C50C
		public void SetInstanceMultiplier(uint multiplier)
		{
			CommandBuffer.SetInstanceMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), multiplier);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0000E31F File Offset: 0x0000C51F
		public void SetRenderTarget(RenderTargetIdentifier rt)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetRenderTargetSingle_Internal(rt, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0006697C File Offset: 0x00064B7C
		public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = colorLoadAction == RenderBufferLoadAction.Clear || depthLoadAction == RenderBufferLoadAction.Clear;
			if (flag)
			{
				throw new ArgumentException("RenderBufferLoadAction.Clear is not supported");
			}
			this.SetRenderTargetSingle_Internal(rt, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x000669BC File Offset: 0x00064BBC
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = mipLevel < 0;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid value for mipLevel ({0})", mipLevel));
			}
			this.SetRenderTargetSingle_Internal(new RenderTargetIdentifier(rt, mipLevel, CubemapFace.Unknown, 0), RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00066A08 File Offset: 0x00064C08
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = mipLevel < 0;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid value for mipLevel ({0})", mipLevel));
			}
			this.SetRenderTargetSingle_Internal(new RenderTargetIdentifier(rt, mipLevel, cubemapFace, 0), RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0000E337 File Offset: 0x0000C537
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetRenderTargetColorDepth_Internal(color, depth, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderTargetFlags.None);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00066A54 File Offset: 0x00064C54
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = mipLevel < 0;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid value for mipLevel ({0})", mipLevel));
			}
			this.SetRenderTargetColorDepth_Internal(new RenderTargetIdentifier(color, mipLevel, CubemapFace.Unknown, 0), depth, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderTargetFlags.None);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00066AA0 File Offset: 0x00064CA0
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = mipLevel < 0;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid value for mipLevel ({0})", mipLevel));
			}
			this.SetRenderTargetColorDepth_Internal(new RenderTargetIdentifier(color, mipLevel, cubemapFace, 0), depth, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderTargetFlags.None);
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00066AEC File Offset: 0x00064CEC
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = depthSlice < -1;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid value for depthSlice ({0})", depthSlice));
			}
			bool flag2 = mipLevel < 0;
			if (flag2)
			{
				throw new ArgumentException(String.Format("Invalid value for mipLevel ({0})", mipLevel));
			}
			this.SetRenderTargetColorDepth_Internal(new RenderTargetIdentifier(color, mipLevel, cubemapFace, depthSlice), depth, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, RenderTargetFlags.None);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00066B5C File Offset: 0x00064D5C
		public void SetRenderTarget(Il2CppStructArray<RenderTargetIdentifier> colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag = colors.Length < 1;
			if (flag)
			{
				throw new ArgumentException(String.Format("colors.Length must be at least 1, but was {0}", colors.Length));
			}
			bool flag2 = colors.Length > SystemInfo.supportedRenderTargetCount;
			if (flag2)
			{
				throw new ArgumentException(String.Format("colors.Length is {0} and exceeds the maximum number of supported render targets ({1})", colors.Length, SystemInfo.supportedRenderTargetCount));
			}
			this.SetRenderTargetMultiSubtarget(colors, depth, null, null, RenderBufferLoadAction.Load, RenderBufferStoreAction.Store, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00066BE8 File Offset: 0x00064DE8
		public void SetRenderTargetColorDepthSubtarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			this.SetRenderTargetColorDepthSubtarget_Injected(ref color, ref depth, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00066C0C File Offset: 0x00064E0C
		public void SetRenderTargetMultiSubtarget(Il2CppStructArray<RenderTargetIdentifier> colors, RenderTargetIdentifier depth, Il2CppStructArray<RenderBufferLoadAction> colorLoadActions, Il2CppStructArray<RenderBufferStoreAction> colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			this.SetRenderTargetMultiSubtarget_Injected(colors, ref depth, colorLoadActions, colorStoreActions, depthLoadAction, depthStoreAction, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00066C30 File Offset: 0x00064E30
		public void Internal_ProcessVTFeedback(RenderTargetIdentifier rt, IntPtr resolver, int slice, int x, int width, int y, int height, int mip)
		{
			this.Internal_ProcessVTFeedback_Injected(ref rt, resolver, slice, x, width, y, height, mip);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00066C54 File Offset: 0x00064E54
		public void SetComputeBufferData(ComputeBuffer buffer, Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to RenderingCommandBuffer.SetBufferData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalSetComputeBufferData(buffer, data, 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00066CBC File Offset: 0x00064EBC
		public void SetComputeBufferData<T>(ComputeBuffer buffer, List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to RenderingCommandBuffer.SetBufferData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			this.InternalSetComputeBufferData(buffer, NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0000E351 File Offset: 0x0000C551
		public void SetComputeBufferData<T>(ComputeBuffer buffer, Unity.Collections.NativeArray<T> data) where T : struct
		{
			this.InternalSetComputeBufferNativeData(buffer, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00066D30 File Offset: 0x00064F30
		public void SetComputeBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to RenderingCommandBuffer.SetBufferData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetComputeBufferData(buffer, data, managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00066DD8 File Offset: 0x00064FD8
		public void SetComputeBufferData<T>(ComputeBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to RenderingCommandBuffer.SetBufferData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetComputeBufferData(buffer, NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00066E8C File Offset: 0x0006508C
		public void SetComputeBufferData<T>(ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = nativeBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || nativeBufferStartIndex + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (nativeBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", nativeBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetComputeBufferNativeData(buffer, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), nativeBufferStartIndex, graphicsBufferStartIndex, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0000E375 File Offset: 0x0000C575
		public void InternalSetComputeBufferNativeData(ComputeBuffer buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			CommandBuffer.InternalSetComputeBufferNativeDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), data, nativeBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x0000E395 File Offset: 0x0000C595
		public void InternalSetComputeBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			CommandBuffer.InternalSetComputeBufferDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0000E3BA File Offset: 0x0000C5BA
		public void SetComputeBufferCounterValue(ComputeBuffer buffer, uint counterValue)
		{
			CommandBuffer.SetComputeBufferCounterValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(buffer), counterValue);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0000E3D3 File Offset: 0x0000C5D3
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0000E3DD File Offset: 0x0000C5DD
		public void SetComputeFloatParam(ComputeShader computeShader, string name, float val)
		{
			this.SetComputeFloatParam(computeShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0000E3EF File Offset: 0x0000C5EF
		public void SetComputeIntParam(ComputeShader computeShader, string name, int val)
		{
			this.SetComputeIntParam(computeShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0000E401 File Offset: 0x0000C601
		public void SetComputeVectorArrayParam(ComputeShader computeShader, string name, Il2CppStructArray<Vector4> values)
		{
			this.SetComputeVectorArrayParam(computeShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0000E413 File Offset: 0x0000C613
		public void SetComputeMatrixParam(ComputeShader computeShader, string name, Matrix4x4 val)
		{
			this.SetComputeMatrixParam(computeShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0000E425 File Offset: 0x0000C625
		public void SetComputeMatrixArrayParam(ComputeShader computeShader, string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetComputeMatrixArrayParam(computeShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0000E437 File Offset: 0x0000C637
		public void SetComputeFloatParams(ComputeShader computeShader, int nameID, Il2CppStructArray<float> values)
		{
			this.Internal_SetComputeFloats(computeShader, nameID, values);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0000E444 File Offset: 0x0000C644
		public void SetComputeFloatParams(ComputeShader computeShader, int nameID, params float[] values)
		{
			this.SetComputeFloatParams(computeShader, nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0000E454 File Offset: 0x0000C654
		public void SetComputeIntParams(ComputeShader computeShader, string name, Il2CppStructArray<int> values)
		{
			this.Internal_SetComputeInts(computeShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0000E466 File Offset: 0x0000C666
		public void SetComputeIntParams(ComputeShader computeShader, string name, params int[] values)
		{
			this.SetComputeIntParams(computeShader, name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0000E476 File Offset: 0x0000C676
		public void SetComputeIntParams(ComputeShader computeShader, int nameID, Il2CppStructArray<int> values)
		{
			this.Internal_SetComputeInts(computeShader, nameID, values);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0000E483 File Offset: 0x0000C683
		public void SetComputeIntParams(ComputeShader computeShader, int nameID, params int[] values)
		{
			this.SetComputeIntParams(computeShader, nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0000E493 File Offset: 0x0000C693
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, nameID, ref rt, 0, RenderTextureSubElement.Default);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0000E4A4 File Offset: 0x0000C6A4
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, Shader.PropertyToID(name), ref rt, mipLevel, RenderTextureSubElement.Default);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0000E4BB File Offset: 0x0000C6BB
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, nameID, ref rt, mipLevel, RenderTextureSubElement.Default);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0000E4CD File Offset: 0x0000C6CD
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, Shader.PropertyToID(name), ref rt, mipLevel, element);
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0000E4E5 File Offset: 0x0000C6E5
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, nameID, ref rt, mipLevel, element);
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			this.Internal_SetComputeBufferParam(computeShader, kernelIndex, nameID, buffer);
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0000E507 File Offset: 0x0000C707
		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			this.Internal_SetComputeGraphicsBufferParam(computeShader, kernelIndex, nameID, buffer);
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0000E516 File Offset: 0x0000C716
		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBuffer buffer)
		{
			this.Internal_SetComputeGraphicsBufferParam(computeShader, kernelIndex, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0000E52A File Offset: 0x0000C72A
		public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
			this.Internal_SetComputeConstantComputeBufferParam(computeShader, nameID, buffer, offset, size);
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0000E53B File Offset: 0x0000C73B
		public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, ComputeBuffer buffer, int offset, int size)
		{
			this.Internal_SetComputeConstantComputeBufferParam(computeShader, Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0000E551 File Offset: 0x0000C751
		public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.Internal_SetComputeConstantGraphicsBufferParam(computeShader, nameID, buffer, offset, size);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0000E562 File Offset: 0x0000C762
		public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.Internal_SetComputeConstantGraphicsBufferParam(computeShader, Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x0000E578 File Offset: 0x0000C778
		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset)
		{
			this.Internal_DispatchComputeIndirect(computeShader, kernelIndex, indirectBuffer, argsOffset);
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0000E587 File Offset: 0x0000C787
		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset)
		{
			this.Internal_DispatchComputeIndirectGraphicsBuffer(computeShader, kernelIndex, indirectBuffer, argsOffset);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00066F00 File Offset: 0x00065100
		public void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure)
		{
			Vector3 vector = new Vector3(0f, 0f, 0f);
			this.Internal_BuildRayTracingAccelerationStructure(accelerationStructure, vector);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0000E596 File Offset: 0x0000C796
		public void BuildRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure, Vector3 relativeOrigin)
		{
			this.Internal_BuildRayTracingAccelerationStructure(accelerationStructure, relativeOrigin);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0000E5A2 File Offset: 0x0000C7A2
		public void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure)
		{
			this.Internal_SetRayTracingAccelerationStructure(rayTracingShader, Shader.PropertyToID(name), rayTracingAccelerationStructure);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0000E5B4 File Offset: 0x0000C7B4
		public void SetRayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure)
		{
			this.Internal_SetRayTracingAccelerationStructure(rayTracingShader, nameID, rayTracingAccelerationStructure);
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0000E5C1 File Offset: 0x0000C7C1
		public void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, ComputeBuffer buffer)
		{
			this.Internal_SetRayTracingBufferParam(rayTracingShader, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0000E5D3 File Offset: 0x0000C7D3
		public void SetRayTracingBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer)
		{
			this.Internal_SetRayTracingBufferParam(rayTracingShader, nameID, buffer);
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		public void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
			this.Internal_SetRayTracingConstantComputeBufferParam(rayTracingShader, nameID, buffer, offset, size);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0000E5F1 File Offset: 0x0000C7F1
		public void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, ComputeBuffer buffer, int offset, int size)
		{
			this.Internal_SetRayTracingConstantComputeBufferParam(rayTracingShader, Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0000E607 File Offset: 0x0000C807
		public void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.Internal_SetRayTracingConstantGraphicsBufferParam(rayTracingShader, nameID, buffer, offset, size);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0000E618 File Offset: 0x0000C818
		public void SetRayTracingConstantBufferParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.Internal_SetRayTracingConstantGraphicsBufferParam(rayTracingShader, Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0000E62E File Offset: 0x0000C82E
		public void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, RenderTargetIdentifier rt)
		{
			this.Internal_SetRayTracingTextureParam(rayTracingShader, Shader.PropertyToID(name), ref rt);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0000E641 File Offset: 0x0000C841
		public void SetRayTracingTextureParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, RenderTargetIdentifier rt)
		{
			this.Internal_SetRayTracingTextureParam(rayTracingShader, nameID, ref rt);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0000E64F File Offset: 0x0000C84F
		public void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, float val)
		{
			this.Internal_SetRayTracingFloatParam(rayTracingShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0000E661 File Offset: 0x0000C861
		public void SetRayTracingFloatParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, float val)
		{
			this.Internal_SetRayTracingFloatParam(rayTracingShader, nameID, val);
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0000E66E File Offset: 0x0000C86E
		public void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Il2CppStructArray<float> values)
		{
			this.Internal_SetRayTracingFloats(rayTracingShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0000E680 File Offset: 0x0000C880
		public void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params float[] values)
		{
			this.SetRayTracingFloatParams(rayTracingShader, name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0000E690 File Offset: 0x0000C890
		public void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<float> values)
		{
			this.Internal_SetRayTracingFloats(rayTracingShader, nameID, values);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0000E69D File Offset: 0x0000C89D
		public void SetRayTracingFloatParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params float[] values)
		{
			this.SetRayTracingFloatParams(rayTracingShader, nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0000E6AD File Offset: 0x0000C8AD
		public void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, int val)
		{
			this.Internal_SetRayTracingIntParam(rayTracingShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0000E6BF File Offset: 0x0000C8BF
		public void SetRayTracingIntParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, int val)
		{
			this.Internal_SetRayTracingIntParam(rayTracingShader, nameID, val);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0000E6CC File Offset: 0x0000C8CC
		public void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Il2CppStructArray<int> values)
		{
			this.Internal_SetRayTracingInts(rayTracingShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0000E6DE File Offset: 0x0000C8DE
		public void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params int[] values)
		{
			this.SetRayTracingIntParams(rayTracingShader, name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0000E6EE File Offset: 0x0000C8EE
		public void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<int> values)
		{
			this.Internal_SetRayTracingInts(rayTracingShader, nameID, values);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0000E6FB File Offset: 0x0000C8FB
		public void SetRayTracingIntParams(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params int[] values)
		{
			this.SetRayTracingIntParams(rayTracingShader, nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0000E70B File Offset: 0x0000C90B
		public void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Vector4 val)
		{
			this.Internal_SetRayTracingVectorParam(rayTracingShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0000E71D File Offset: 0x0000C91D
		public void SetRayTracingVectorParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Vector4 val)
		{
			this.Internal_SetRayTracingVectorParam(rayTracingShader, nameID, val);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0000E72A File Offset: 0x0000C92A
		public void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Il2CppStructArray<Vector4> values)
		{
			this.Internal_SetRayTracingVectorArrayParam(rayTracingShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0000E73C File Offset: 0x0000C93C
		public void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params Vector4[] values)
		{
			this.SetRayTracingVectorArrayParam(rayTracingShader, name, new Il2CppStructArray<Vector4>(values));
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0000E74C File Offset: 0x0000C94C
		public void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<Vector4> values)
		{
			this.Internal_SetRayTracingVectorArrayParam(rayTracingShader, nameID, values);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0000E759 File Offset: 0x0000C959
		public void SetRayTracingVectorArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params Vector4[] values)
		{
			this.SetRayTracingVectorArrayParam(rayTracingShader, nameID, new Il2CppStructArray<Vector4>(values));
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0000E769 File Offset: 0x0000C969
		public void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Matrix4x4 val)
		{
			this.Internal_SetRayTracingMatrixParam(rayTracingShader, Shader.PropertyToID(name), val);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0000E77B File Offset: 0x0000C97B
		public void SetRayTracingMatrixParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Matrix4x4 val)
		{
			this.Internal_SetRayTracingMatrixParam(rayTracingShader, nameID, val);
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0000E788 File Offset: 0x0000C988
		public void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.Internal_SetRayTracingMatrixArrayParam(rayTracingShader, Shader.PropertyToID(name), values);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0000E79A File Offset: 0x0000C99A
		public void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string name, params Matrix4x4[] values)
		{
			this.SetRayTracingMatrixArrayParam(rayTracingShader, name, new Il2CppStructArray<Matrix4x4>(values));
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0000E7AA File Offset: 0x0000C9AA
		public void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			this.Internal_SetRayTracingMatrixArrayParam(rayTracingShader, nameID, values);
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0000E7B7 File Offset: 0x0000C9B7
		public void SetRayTracingMatrixArrayParam(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, params Matrix4x4[] values)
		{
			this.SetRayTracingMatrixArrayParam(rayTracingShader, nameID, new Il2CppStructArray<Matrix4x4>(values));
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0000E7C7 File Offset: 0x0000C9C7
		public void DispatchRays(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, [Optional] Camera camera)
		{
			this.Internal_DispatchRays(rayTracingShader, rayGenName, width, height, depth, camera);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0000E7DA File Offset: 0x0000C9DA
		public void GenerateMips(RenderTargetIdentifier rt)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_GenerateMips(rt);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00066F30 File Offset: 0x00065130
		public void GenerateMips(RenderTexture rt)
		{
			bool flag = rt == null;
			if (flag)
			{
				throw new ArgumentNullException("rt");
			}
			this.GenerateMips(new RenderTargetIdentifier(rt));
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00066F64 File Offset: 0x00065164
		public void ResolveAntiAliasedSurface(RenderTexture rt, [Optional] RenderTexture target)
		{
			bool flag = rt == null;
			if (flag)
			{
				throw new ArgumentNullException("rt");
			}
			this.Internal_ResolveAntiAliasedSurface(rt, target);
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0000E7EE File Offset: 0x0000C9EE
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex)
		{
			this.DrawMesh(mesh, matrix, material, submeshIndex, -1);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0000E7FE File Offset: 0x0000C9FE
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material)
		{
			this.DrawMesh(mesh, matrix, material, 0);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00066F94 File Offset: 0x00065194
		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass)
		{
			bool flag = renderer == null;
			if (flag)
			{
				throw new ArgumentNullException("renderer");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag2 = submeshIndex < 0;
			if (flag2)
			{
				submeshIndex = Mathf.Max(submeshIndex, 0);
				Debug.LogWarning(String.Format("submeshIndex out of range. Clampped to {0}.", submeshIndex));
			}
			bool flag3 = material == null;
			if (flag3)
			{
				throw new ArgumentNullException("material");
			}
			this.Internal_DrawRenderer(renderer, material, submeshIndex, shaderPass);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x0000E80C File Offset: 0x0000CA0C
		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex)
		{
			this.DrawRenderer(renderer, material, submeshIndex, -1);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0000E81A File Offset: 0x0000CA1A
		public void DrawRenderer(Renderer renderer, Material material)
		{
			this.DrawRenderer(renderer, material, 0);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0006700C File Offset: 0x0006520C
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			bool flag = material == null;
			if (flag)
			{
				throw new ArgumentNullException("material");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0000E827 File Offset: 0x0000CA27
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount)
		{
			this.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount, null);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0000E83B File Offset: 0x0000CA3B
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount)
		{
			this.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, 1);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0006704C File Offset: 0x0006524C
		public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = material == null;
			if (flag2)
			{
				throw new ArgumentNullException("material");
			}
			this.Internal_DrawProceduralIndexed(indexBuffer, matrix, material, shaderPass, topology, indexCount, instanceCount, properties);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00067098 File Offset: 0x00065298
		public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount)
		{
			this.DrawProcedural(indexBuffer, matrix, material, shaderPass, topology, indexCount, instanceCount, null);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0000E84D File Offset: 0x0000CA4D
		public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount)
		{
			this.DrawProcedural(indexBuffer, matrix, material, shaderPass, topology, indexCount, 1);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x000670BC File Offset: 0x000652BC
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = material == null;
			if (flag)
			{
				throw new ArgumentNullException("material");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0000E861 File Offset: 0x0000CA61
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0000E875 File Offset: 0x0000CA75
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs)
		{
			this.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, 0);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00067110 File Offset: 0x00065310
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = material == null;
			if (flag2)
			{
				throw new ArgumentNullException("material");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.Internal_DrawProceduralIndexedIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00067170 File Offset: 0x00065370
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0000E887 File Offset: 0x0000CA87
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs)
		{
			this.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, 0);
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00067194 File Offset: 0x00065394
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = material == null;
			if (flag)
			{
				throw new ArgumentNullException("material");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_DrawProceduralIndirectGraphicsBuffer(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0000E89B File Offset: 0x0000CA9B
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0000E8AF File Offset: 0x0000CAAF
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs)
		{
			this.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, 0);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x000671E8 File Offset: 0x000653E8
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = material == null;
			if (flag2)
			{
				throw new ArgumentNullException("material");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.Internal_DrawProceduralIndexedIndirectGraphicsBuffer(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00067248 File Offset: 0x00065448
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0000E8C1 File Offset: 0x0000CAC1
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs)
		{
			this.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, 0);
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0006726C File Offset: 0x0006546C
		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("DrawMeshInstanced is not supported.");
			}
			bool flag2 = mesh == null;
			if (flag2)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag3 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag4 = material == null;
			if (flag4)
			{
				throw new ArgumentNullException("material");
			}
			bool flag5 = matrices == null;
			if (flag5)
			{
				throw new ArgumentNullException("matrices");
			}
			bool flag6 = count < 0 || count > Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length);
			if (flag6)
			{
				throw new ArgumentOutOfRangeException("count", String.Format("Count must be in the range of 0 to {0}.", Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length)));
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag7 = count > 0;
			if (flag7)
			{
				this.Internal_DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count, properties);
			}
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0000E8D5 File Offset: 0x0000CAD5
		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Il2CppStructArray<Matrix4x4> matrices, int count)
		{
			this.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count, null);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0000E8E9 File Offset: 0x0000CAE9
		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Il2CppStructArray<Matrix4x4> matrices)
		{
			this.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, matrices.Length);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00067370 File Offset: 0x00065570
		public void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, [Optional] MaterialPropertyBlock properties)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("DrawMeshInstancedProcedural is not supported.");
			}
			bool flag2 = mesh == null;
			if (flag2)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag3 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag4 = material == null;
			if (flag4)
			{
				throw new ArgumentNullException("material");
			}
			bool flag5 = count <= 0;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			bool flag6 = count > 0;
			if (flag6)
			{
				this.Internal_DrawMeshInstancedProcedural(mesh, submeshIndex, material, shaderPass, count, properties);
			}
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x00067428 File Offset: 0x00065628
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			bool flag2 = mesh == null;
			if (flag2)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag3 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag4 = material == null;
			if (flag4)
			{
				throw new ArgumentNullException("material");
			}
			bool flag5 = bufferWithArgs == null;
			if (flag5)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.Internal_DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0000E902 File Offset: 0x0000CB02
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0000E916 File Offset: 0x0000CB16
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs)
		{
			this.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, 0, null);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x000674C8 File Offset: 0x000656C8
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			bool flag2 = mesh == null;
			if (flag2)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag3 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag4 = material == null;
			if (flag4)
			{
				throw new ArgumentNullException("material");
			}
			bool flag5 = bufferWithArgs == null;
			if (flag5)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.Internal_DrawMeshInstancedIndirectGraphicsBuffer(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x0000E929 File Offset: 0x0000CB29
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			this.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, null);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0000E93D File Offset: 0x0000CB3D
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs)
		{
			this.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, 0, null);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0000E950 File Offset: 0x0000CB50
		public void DrawOcclusionMesh(RectInt normalizedCamViewport)
		{
			this.Internal_DrawOcclusionMesh(normalizedCamViewport);
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0000E95B File Offset: 0x0000CB5B
		public void SetRandomWriteTarget(int index, RenderTargetIdentifier rt)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetRandomWriteTarget_Texture(index, ref rt);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0000E971 File Offset: 0x0000CB71
		public void SetRandomWriteTarget(int index, ComputeBuffer buffer, bool preserveCounterValue)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetRandomWriteTarget_Buffer(index, buffer, preserveCounterValue);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0000E987 File Offset: 0x0000CB87
		public void SetRandomWriteTarget(int index, ComputeBuffer buffer)
		{
			this.SetRandomWriteTarget(index, buffer, false);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0000E994 File Offset: 0x0000CB94
		public void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetRandomWriteTarget_GraphicsBuffer(index, buffer, preserveCounterValue);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0000E9AA File Offset: 0x0000CBAA
		public void SetRandomWriteTarget(int index, GraphicsBuffer buffer)
		{
			this.SetRandomWriteTarget(index, buffer, false);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0000E9B7 File Offset: 0x0000CBB7
		public void CopyCounterValue(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
			this.CopyCounterValueCC(src, dst, dstOffsetBytes);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0000E9C4 File Offset: 0x0000CBC4
		public void CopyCounterValue(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
			this.CopyCounterValueGC(src, dst, dstOffsetBytes);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0000E9D1 File Offset: 0x0000CBD1
		public void CopyCounterValue(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
			this.CopyCounterValueCG(src, dst, dstOffsetBytes);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0000E9DE File Offset: 0x0000CBDE
		public void CopyCounterValue(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
			this.CopyCounterValueGG(src, dst, dstOffsetBytes);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00067568 File Offset: 0x00065768
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement)
		{
			this.CopyTexture_Internal(ref src, srcElement, -1, -1, -1, -1, -1, ref dst, dstElement, -1, -1, -1, 2);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00067590 File Offset: 0x00065790
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			this.CopyTexture_Internal(ref src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, ref dst, dstElement, dstMip, dstX, dstY, 4);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x000675BC File Offset: 0x000657BC
		public void Blit(Texture source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Texture(source, ref dest, null, -1, scale, offset, Texture2DArray.allSlices, 0);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x000675E8 File Offset: 0x000657E8
		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Texture(source, ref dest, mat, -1, new Vector2(1f, 1f), new Vector2(0f, 0f), Texture2DArray.allSlices, 0);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00067630 File Offset: 0x00065830
		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Texture(source, ref dest, mat, pass, new Vector2(1f, 1f), new Vector2(0f, 0f), Texture2DArray.allSlices, 0);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00067678 File Offset: 0x00065878
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, null, -1, scale, offset, Texture2DArray.allSlices, 0);
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x000676A8 File Offset: 0x000658A8
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, mat, -1, new Vector2(1f, 1f), new Vector2(0f, 0f), Texture2DArray.allSlices, 0);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x000676F0 File Offset: 0x000658F0
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, int sourceDepthSlice, int destDepthSlice)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, null, -1, new Vector2(1f, 1f), new Vector2(0f, 0f), sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00067738 File Offset: 0x00065938
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, null, -1, scale, offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x00067764 File Offset: 0x00065964
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass, int destDepthSlice)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Blit_Identifier(ref source, ref dest, mat, pass, new Vector2(1f, 1f), new Vector2(0f, 0f), Texture2DArray.allSlices, destDepthSlice);
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0000E9EB File Offset: 0x0000CBEB
		public void SetGlobalFloat(string name, float value)
		{
			this.SetGlobalFloat(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		public void SetGlobalInt(string name, int value)
		{
			this.SetGlobalInt(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0000EA0D File Offset: 0x0000CC0D
		public void SetGlobalVector(string name, Vector4 value)
		{
			this.SetGlobalVector(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0000EA1E File Offset: 0x0000CC1E
		public void SetGlobalColor(string name, Color value)
		{
			this.SetGlobalColor(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0000EA2F File Offset: 0x0000CC2F
		public void SetGlobalMatrix(string name, Matrix4x4 value)
		{
			this.SetGlobalMatrix(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0000EA40 File Offset: 0x0000CC40
		public void SetGlobalFloatArray(string propertyName, List<float> values)
		{
			this.SetGlobalFloatArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000677B0 File Offset: 0x000659B0
		public void SetGlobalFloatArray(int nameID, List<float> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Count == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetGlobalFloatArrayListImpl(nameID, values);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0000EA51 File Offset: 0x0000CC51
		public void SetGlobalFloatArray(string propertyName, Il2CppStructArray<float> values)
		{
			this.SetGlobalFloatArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0000EA62 File Offset: 0x0000CC62
		public void SetGlobalVectorArray(string propertyName, List<Vector4> values)
		{
			this.SetGlobalVectorArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x000677F4 File Offset: 0x000659F4
		public void SetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Count == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetGlobalVectorArrayListImpl(nameID, values);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0000EA73 File Offset: 0x0000CC73
		public void SetGlobalVectorArray(string propertyName, Il2CppStructArray<Vector4> values)
		{
			this.SetGlobalVectorArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0000EA84 File Offset: 0x0000CC84
		public void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values)
		{
			this.SetGlobalMatrixArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00067838 File Offset: 0x00065A38
		public void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Count == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetGlobalMatrixArrayListImpl(nameID, values);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0000EA95 File Offset: 0x0000CC95
		public void SetGlobalMatrixArray(string propertyName, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetGlobalMatrixArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0000EAA6 File Offset: 0x0000CCA6
		public void SetGlobalTexture(string name, RenderTargetIdentifier value, RenderTextureSubElement element)
		{
			this.SetGlobalTexture(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
		public void SetGlobalBuffer(string name, ComputeBuffer value)
		{
			this.SetGlobalBufferInternal(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0000EAC9 File Offset: 0x0000CCC9
		public void SetGlobalBuffer(int nameID, ComputeBuffer value)
		{
			this.SetGlobalBufferInternal(nameID, value);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0000EAD5 File Offset: 0x0000CCD5
		public void SetGlobalBuffer(string name, GraphicsBuffer value)
		{
			this.SetGlobalGraphicsBufferInternal(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0000EAE6 File Offset: 0x0000CCE6
		public void SetGlobalBuffer(int nameID, GraphicsBuffer value)
		{
			this.SetGlobalGraphicsBufferInternal(nameID, value);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0000EAF2 File Offset: 0x0000CCF2
		public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size)
		{
			this.SetGlobalConstantBufferInternal(buffer, nameID, offset, size);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0000EB01 File Offset: 0x0000CD01
		public void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size)
		{
			this.SetGlobalConstantBufferInternal(buffer, Shader.PropertyToID(name), offset, size);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0000EB15 File Offset: 0x0000CD15
		public void SetGlobalConstantBuffer(GraphicsBuffer buffer, int nameID, int offset, int size)
		{
			this.SetGlobalConstantGraphicsBufferInternal(buffer, nameID, offset, size);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0000EB24 File Offset: 0x0000CD24
		public void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size)
		{
			this.SetGlobalConstantGraphicsBufferInternal(buffer, Shader.PropertyToID(name), offset, size);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0000EB38 File Offset: 0x0000CD38
		public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.SetShadowSamplingMode_Impl(ref shadowmap, mode);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0006787C File Offset: 0x00065A7C
		public void IssuePluginEvent(IntPtr callback, int eventID)
		{
			bool flag = callback == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("Null callback specified.");
			}
			this.IssuePluginEventInternal(callback, eventID);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x000678B0 File Offset: 0x00065AB0
		public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data)
		{
			bool flag = callback == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("Null callback specified.");
			}
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.IssuePluginEventAndDataInternal(callback, eventID, data);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0000EB4E File Offset: 0x0000CD4E
		public void IssuePluginCustomBlit(IntPtr callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest, uint commandParam, uint commandFlags)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.IssuePluginCustomBlitInternal(callback, command, ref source, ref dest, commandParam, commandFlags);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0000EB6B File Offset: 0x0000CD6B
		public void IssuePluginCustomTextureUpdate(IntPtr callback, Texture targetTexture, uint userData)
		{
			this.IssuePluginCustomTextureUpdateInternal(callback, targetTexture, userData, false);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0000EB79 File Offset: 0x0000CD79
		public void IssuePluginCustomTextureUpdateV1(IntPtr callback, Texture targetTexture, uint userData)
		{
			this.IssuePluginCustomTextureUpdateInternal(callback, targetTexture, userData, false);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0000EB87 File Offset: 0x0000CD87
		public void IssuePluginCustomTextureUpdateV2(IntPtr callback, Texture targetTexture, uint userData)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.IssuePluginCustomTextureUpdateInternal(callback, targetTexture, userData, true);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000678EC File Offset: 0x00065AEC
		public void ProcessVTFeedback(RenderTargetIdentifier rt, IntPtr resolver, int slice, int x, int width, int y, int height, int mip)
		{
			this.ValidateAgainstExecutionFlags(CommandBufferExecutionFlags.None, CommandBufferExecutionFlags.AsyncCompute);
			this.Internal_ProcessVTFeedback(rt, resolver, slice, x, width, y, height, mip);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00067918 File Offset: 0x00065B18
		public GPUFence CreateGPUFence(SynchronisationStage stage)
		{
			return default(GPUFence);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00067934 File Offset: 0x00065B34
		public GPUFence CreateGPUFence()
		{
			return default(GPUFence);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0000EB9E File Offset: 0x0000CD9E
		public void WaitOnGPUFence(GPUFence fence, SynchronisationStage stage)
		{
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0000EBA1 File Offset: 0x0000CDA1
		public void WaitOnGPUFence(GPUFence fence)
		{
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0000EBA4 File Offset: 0x0000CDA4
		public void ConvertTexture_Internal_Injected(ref RenderTargetIdentifier src, int srcElement, ref RenderTargetIdentifier dst, int dstElement)
		{
			CommandBuffer.ConvertTexture_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref src, srcElement, ref dst, dstElement);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0000EBBB File Offset: 0x0000CDBB
		public void SetComputeMatrixParam_Injected(ComputeShader computeShader, int nameID, ref Matrix4x4 val)
		{
			CommandBuffer.SetComputeMatrixParam_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(computeShader), nameID, ref val);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0000EBD5 File Offset: 0x0000CDD5
		public void Internal_SetRayTracingVectorParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ref Vector4 val)
		{
			CommandBuffer.Internal_SetRayTracingVectorParam_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, ref val);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0000EBEF File Offset: 0x0000CDEF
		public void Internal_SetRayTracingMatrixParam_Injected(UnityEngine.Experimental.Rendering.RayTracingShader rayTracingShader, int nameID, ref Matrix4x4 val)
		{
			CommandBuffer.Internal_SetRayTracingMatrixParam_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rayTracingShader), nameID, ref val);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0000EC09 File Offset: 0x0000CE09
		public void Internal_BuildRayTracingAccelerationStructure_Injected(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure, ref Vector3 relativeOrigin)
		{
			CommandBuffer.Internal_BuildRayTracingAccelerationStructure_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(accelerationStructure), ref relativeOrigin);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0000EC22 File Offset: 0x0000CE22
		public void Internal_GenerateMips_Injected(ref RenderTargetIdentifier rt)
		{
			CommandBuffer.Internal_GenerateMips_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rt);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00067950 File Offset: 0x00065B50
		public void Internal_DrawProcedural_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProcedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, vertexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x00067984 File Offset: 0x00065B84
		public void Internal_DrawProceduralIndexed_Injected(GraphicsBuffer indexBuffer, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProceduralIndexed_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, indexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000679C0 File Offset: 0x00065BC0
		public void Internal_DrawProceduralIndirect_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProceduralIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x000679F8 File Offset: 0x00065BF8
		public void Internal_DrawProceduralIndexedIndirect_Injected(GraphicsBuffer indexBuffer, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x00067A38 File Offset: 0x00065C38
		public void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x00067A70 File Offset: 0x00065C70
		public void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(GraphicsBuffer indexBuffer, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), shaderPass, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0000EC35 File Offset: 0x0000CE35
		public void Internal_DrawOcclusionMesh_Injected(ref RectInt normalizedCamViewport)
		{
			CommandBuffer.Internal_DrawOcclusionMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref normalizedCamViewport);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0000EC48 File Offset: 0x0000CE48
		public void EnableScissorRect_Injected(ref Rect scissor)
		{
			CommandBuffer.EnableScissorRect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref scissor);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0000EC5B File Offset: 0x0000CE5B
		public void SetGlobalColor_Injected(int nameID, ref Color value)
		{
			CommandBuffer.SetGlobalColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref value);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0000EC6F File Offset: 0x0000CE6F
		public void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value)
		{
			CommandBuffer.SetGlobalMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref value);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0000EC83 File Offset: 0x0000CE83
		public void SetViewMatrix_Injected(ref Matrix4x4 view)
		{
			CommandBuffer.SetViewMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref view);
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0000EC96 File Offset: 0x0000CE96
		public void SetProjectionMatrix_Injected(ref Matrix4x4 proj)
		{
			CommandBuffer.SetProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref proj);
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0000ECA9 File Offset: 0x0000CEA9
		public void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj)
		{
			CommandBuffer.SetViewProjectionMatrices_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref view, ref proj);
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0000ECBD File Offset: 0x0000CEBD
		public void IncrementUpdateCount_Injected(ref RenderTargetIdentifier dest)
		{
			CommandBuffer.IncrementUpdateCount_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref dest);
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00067AB0 File Offset: 0x00065CB0
		public void SetRenderTargetColorDepthSubtarget_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			CommandBuffer.SetRenderTargetColorDepthSubtarget_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref color, ref depth, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00067ADC File Offset: 0x00065CDC
		public void SetRenderTargetMultiSubtarget_Injected(Il2CppStructArray<RenderTargetIdentifier> colors, ref RenderTargetIdentifier depth, Il2CppStructArray<RenderBufferLoadAction> colorLoadActions, Il2CppStructArray<RenderBufferStoreAction> colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			CommandBuffer.SetRenderTargetMultiSubtarget_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), ref depth, IL2CPP.Il2CppObjectBaseToPtr(colorLoadActions), IL2CPP.Il2CppObjectBaseToPtr(colorStoreActions), depthLoadAction, depthStoreAction, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00067B18 File Offset: 0x00065D18
		public void Internal_ProcessVTFeedback_Injected(ref RenderTargetIdentifier rt, IntPtr resolver, int slice, int x, int width, int y, int height, int mip)
		{
			CommandBuffer.Internal_ProcessVTFeedback_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rt, resolver, slice, x, width, y, height, mip);
		}

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetSinglePassStereo_Private_Void_SinglePassStereoMode_0;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_0;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseBuffer_Private_Void_0;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeMethodInfoPtr_SetComputeVectorParam_Public_Void_ComputeShader_Int32_Vector4_0;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetComputeFloats_Private_Void_ComputeShader_Int32_Il2CppStructArray_1_Single_0;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetComputeTextureParam_Private_Void_ComputeShader_Int32_Int32_byref_RenderTargetIdentifier_Int32_RenderTextureSubElement_0;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetComputeBufferParam_Private_Void_ComputeShader_Int32_Int32_ComputeBuffer_0;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DispatchCompute_Private_Void_ComputeShader_Int32_Int32_Int32_Int32_0;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Private_Void_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock_0;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeMethodInfoPtr_SetViewport_Public_Void_Rect_0;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Internal_Private_Void_byref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_Int32_byref_RenderTargetIdentifier_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Texture_Private_Void_Texture_byref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Identifier_Private_Void_byref_RenderTargetIdentifier_byref_RenderTargetIdentifier_Material_Int32_Vector2_Vector2_Int32_Int32_0;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_Boolean_0;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_Boolean_RenderTextureMemoryless_0;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_Int32_0;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_GraphicsFormat_0;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_Boolean_0;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_RenderTextureMemoryless_0;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_RenderTextureReadWrite_Int32_Boolean_0;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_Int32_Int32_Int32_FilterMode_RenderTextureFormat_0;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryRTWithDescriptor_Private_Void_Int32_RenderTextureDescriptor_FilterMode_0;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryRT_Public_Void_Int32_RenderTextureDescriptor_FilterMode_0;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseTemporaryRT_Public_Void_Int32_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_ClearRenderTarget_Public_Void_Boolean_Boolean_Color_Single_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr_ClearRenderTarget_Public_Void_Boolean_Boolean_Color_0;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloat_Public_Void_Int32_Single_0;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVector_Public_Void_Int32_Vector4_0;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeMethodInfoPtr_EnableShaderKeyword_Public_Void_String_0;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr_DisableShaderKeyword_Public_Void_String_0;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAgainstExecutionFlags_Private_Boolean_CommandBufferExecutionFlags_CommandBufferExecutionFlags_0;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTexture_Impl_Private_Void_Int32_byref_RenderTargetIdentifier_RenderTextureSubElement_0;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr_BeginSample_Public_Void_String_0;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeMethodInfoPtr_EndSample_Public_Void_String_0;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetSingle_Internal_Private_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_0;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetColorDepth_Internal_Private_Void_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetMulti_Internal_Private_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_Il2CppStructArray_1_RenderBufferLoadAction_Il2CppStructArray_1_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeMethodInfoPtr_SetComputeVectorParam_Public_Void_ComputeShader_String_Vector4_0;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr_SetComputeFloatParams_Public_Void_ComputeShader_String_Il2CppStructArray_1_Single_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_SetComputeTextureParam_Public_Void_ComputeShader_Int32_String_RenderTargetIdentifier_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_SetComputeBufferParam_Public_Void_ComputeShader_Int32_String_ComputeBuffer_0;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr_DispatchCompute_Public_Void_ComputeShader_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Void_Mesh_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock_0;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Void_Mesh_Matrix4x4_Material_Int32_Int32_0;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Public_Void_RenderTargetIdentifier_Int32_Int32_RenderTargetIdentifier_Int32_Int32_0;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Void_Texture_RenderTargetIdentifier_0;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTexture_Public_Void_String_RenderTargetIdentifier_0;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTexture_Public_Void_Int32_RenderTargetIdentifier_0;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTexture_Public_Void_Int32_RenderTargetIdentifier_RenderTextureSubElement_0;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeMethodInfoPtr_SetSinglePassStereo_Public_Void_SinglePassStereoMode_0;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeMethodInfoPtr_SetComputeVectorParam_Injected_Private_Void_ComputeShader_Int32_byref_Vector4_0;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Void_Mesh_byref_Matrix4x4_Material_Int32_Int32_MaterialPropertyBlock_0;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeMethodInfoPtr_SetViewport_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Texture_Injected_Private_Void_Texture_byref_RenderTargetIdentifier_Material_Int32_byref_Vector2_byref_Vector2_Int32_Int32_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Identifier_Injected_Private_Void_byref_RenderTargetIdentifier_byref_RenderTargetIdentifier_Material_Int32_byref_Vector2_byref_Vector2_Int32_Int32_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryRTWithDescriptor_Injected_Private_Void_Int32_byref_RenderTextureDescriptor_FilterMode_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_ClearRenderTarget_Injected_Private_Void_Boolean_Boolean_byref_Color_Single_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVector_Injected_Private_Void_Int32_byref_Vector4_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetSingle_Internal_Injected_Private_Void_byref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetColorDepth_Internal_Injected_Private_Void_byref_RenderTargetIdentifier_byref_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetMulti_Internal_Injected_Private_Void_Il2CppStructArray_1_RenderTargetIdentifier_byref_RenderTargetIdentifier_Il2CppStructArray_1_RenderBufferLoadAction_Il2CppStructArray_1_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetFlags_0;

		// Token: 0x0400151F RID: 5407
		private static readonly CommandBuffer.WaitAllAsyncReadbackRequestsDelegate WaitAllAsyncReadbackRequestsDelegateField;

		// Token: 0x04001520 RID: 5408
		private static readonly CommandBuffer.SetInvertCullingDelegate SetInvertCullingDelegateField;

		// Token: 0x04001521 RID: 5409
		private static readonly CommandBuffer.CreateGPUFence_InternalDelegate CreateGPUFence_InternalDelegateField;

		// Token: 0x04001522 RID: 5410
		private static readonly CommandBuffer.WaitOnGPUFence_InternalDelegate WaitOnGPUFence_InternalDelegateField;

		// Token: 0x04001523 RID: 5411
		private static readonly CommandBuffer.SetComputeFloatParamDelegate SetComputeFloatParamDelegateField;

		// Token: 0x04001524 RID: 5412
		private static readonly CommandBuffer.SetComputeIntParamDelegate SetComputeIntParamDelegateField;

		// Token: 0x04001525 RID: 5413
		private static readonly CommandBuffer.SetComputeVectorArrayParamDelegate SetComputeVectorArrayParamDelegateField;

		// Token: 0x04001526 RID: 5414
		private static readonly CommandBuffer.SetComputeMatrixArrayParamDelegate SetComputeMatrixArrayParamDelegateField;

		// Token: 0x04001527 RID: 5415
		private static readonly CommandBuffer.Internal_SetComputeIntsDelegate Internal_SetComputeIntsDelegateField;

		// Token: 0x04001528 RID: 5416
		private static readonly CommandBuffer.Internal_SetComputeGraphicsBufferParamDelegate Internal_SetComputeGraphicsBufferParamDelegateField;

		// Token: 0x04001529 RID: 5417
		private static readonly CommandBuffer.Internal_SetComputeConstantComputeBufferParamDelegate Internal_SetComputeConstantComputeBufferParamDelegateField;

		// Token: 0x0400152A RID: 5418
		private static readonly CommandBuffer.Internal_SetComputeConstantGraphicsBufferParamDelegate Internal_SetComputeConstantGraphicsBufferParamDelegateField;

		// Token: 0x0400152B RID: 5419
		private static readonly CommandBuffer.Internal_DispatchComputeIndirectDelegate Internal_DispatchComputeIndirectDelegateField;

		// Token: 0x0400152C RID: 5420
		private static readonly CommandBuffer.Internal_DispatchComputeIndirectGraphicsBufferDelegate Internal_DispatchComputeIndirectGraphicsBufferDelegateField;

		// Token: 0x0400152D RID: 5421
		private static readonly CommandBuffer.Internal_SetRayTracingBufferParamDelegate Internal_SetRayTracingBufferParamDelegateField;

		// Token: 0x0400152E RID: 5422
		private static readonly CommandBuffer.Internal_SetRayTracingConstantComputeBufferParamDelegate Internal_SetRayTracingConstantComputeBufferParamDelegateField;

		// Token: 0x0400152F RID: 5423
		private static readonly CommandBuffer.Internal_SetRayTracingConstantGraphicsBufferParamDelegate Internal_SetRayTracingConstantGraphicsBufferParamDelegateField;

		// Token: 0x04001530 RID: 5424
		private static readonly CommandBuffer.Internal_SetRayTracingTextureParamDelegate Internal_SetRayTracingTextureParamDelegateField;

		// Token: 0x04001531 RID: 5425
		private static readonly CommandBuffer.Internal_SetRayTracingFloatParamDelegate Internal_SetRayTracingFloatParamDelegateField;

		// Token: 0x04001532 RID: 5426
		private static readonly CommandBuffer.Internal_SetRayTracingIntParamDelegate Internal_SetRayTracingIntParamDelegateField;

		// Token: 0x04001533 RID: 5427
		private static readonly CommandBuffer.Internal_SetRayTracingVectorArrayParamDelegate Internal_SetRayTracingVectorArrayParamDelegateField;

		// Token: 0x04001534 RID: 5428
		private static readonly CommandBuffer.Internal_SetRayTracingMatrixArrayParamDelegate Internal_SetRayTracingMatrixArrayParamDelegateField;

		// Token: 0x04001535 RID: 5429
		private static readonly CommandBuffer.Internal_SetRayTracingFloatsDelegate Internal_SetRayTracingFloatsDelegateField;

		// Token: 0x04001536 RID: 5430
		private static readonly CommandBuffer.Internal_SetRayTracingIntsDelegate Internal_SetRayTracingIntsDelegateField;

		// Token: 0x04001537 RID: 5431
		private static readonly CommandBuffer.Internal_SetRayTracingAccelerationStructureDelegate Internal_SetRayTracingAccelerationStructureDelegateField;

		// Token: 0x04001538 RID: 5432
		private static readonly CommandBuffer.SetRayTracingShaderPassDelegate SetRayTracingShaderPassDelegateField;

		// Token: 0x04001539 RID: 5433
		private static readonly CommandBuffer.Internal_DispatchRaysDelegate Internal_DispatchRaysDelegateField;

		// Token: 0x0400153A RID: 5434
		private static readonly CommandBuffer.Internal_ResolveAntiAliasedSurfaceDelegate Internal_ResolveAntiAliasedSurfaceDelegateField;

		// Token: 0x0400153B RID: 5435
		private static readonly CommandBuffer.CopyCounterValueCCDelegate CopyCounterValueCCDelegateField;

		// Token: 0x0400153C RID: 5436
		private static readonly CommandBuffer.CopyCounterValueGCDelegate CopyCounterValueGCDelegateField;

		// Token: 0x0400153D RID: 5437
		private static readonly CommandBuffer.CopyCounterValueCGDelegate CopyCounterValueCGDelegateField;

		// Token: 0x0400153E RID: 5438
		private static readonly CommandBuffer.CopyCounterValueGGDelegate CopyCounterValueGGDelegateField;

		// Token: 0x0400153F RID: 5439
		private static readonly CommandBuffer.get_nameDelegate get_nameDelegateField;

		// Token: 0x04001540 RID: 5440
		private static readonly CommandBuffer.get_sizeInBytesDelegate get_sizeInBytesDelegateField;

		// Token: 0x04001541 RID: 5441
		private static readonly CommandBuffer.Internal_DrawRendererDelegate Internal_DrawRendererDelegateField;

		// Token: 0x04001542 RID: 5442
		private static readonly CommandBuffer.Internal_DrawMeshInstancedDelegate Internal_DrawMeshInstancedDelegateField;

		// Token: 0x04001543 RID: 5443
		private static readonly CommandBuffer.Internal_DrawMeshInstancedProceduralDelegate Internal_DrawMeshInstancedProceduralDelegateField;

		// Token: 0x04001544 RID: 5444
		private static readonly CommandBuffer.Internal_DrawMeshInstancedIndirectDelegate Internal_DrawMeshInstancedIndirectDelegateField;

		// Token: 0x04001545 RID: 5445
		private static readonly CommandBuffer.Internal_DrawMeshInstancedIndirectGraphicsBufferDelegate Internal_DrawMeshInstancedIndirectGraphicsBufferDelegateField;

		// Token: 0x04001546 RID: 5446
		private static readonly CommandBuffer.SetRandomWriteTarget_TextureDelegate SetRandomWriteTarget_TextureDelegateField;

		// Token: 0x04001547 RID: 5447
		private static readonly CommandBuffer.SetRandomWriteTarget_BufferDelegate SetRandomWriteTarget_BufferDelegateField;

		// Token: 0x04001548 RID: 5448
		private static readonly CommandBuffer.SetRandomWriteTarget_GraphicsBufferDelegate SetRandomWriteTarget_GraphicsBufferDelegateField;

		// Token: 0x04001549 RID: 5449
		private static readonly CommandBuffer.ClearRandomWriteTargetsDelegate ClearRandomWriteTargetsDelegateField;

		// Token: 0x0400154A RID: 5450
		private static readonly CommandBuffer.DisableScissorRectDelegate DisableScissorRectDelegateField;

		// Token: 0x0400154B RID: 5451
		private static readonly CommandBuffer.GetTemporaryRTArrayDelegate GetTemporaryRTArrayDelegateField;

		// Token: 0x0400154C RID: 5452
		private static readonly CommandBuffer.SetGlobalIntDelegate SetGlobalIntDelegateField;

		// Token: 0x0400154D RID: 5453
		private static readonly CommandBuffer.SetGlobalDepthBiasDelegate SetGlobalDepthBiasDelegateField;

		// Token: 0x0400154E RID: 5454
		private static readonly CommandBuffer.SetExecutionFlagsDelegate SetExecutionFlagsDelegateField;

		// Token: 0x0400154F RID: 5455
		private static readonly CommandBuffer.SetGlobalFloatArrayListImplDelegate SetGlobalFloatArrayListImplDelegateField;

		// Token: 0x04001550 RID: 5456
		private static readonly CommandBuffer.SetGlobalVectorArrayListImplDelegate SetGlobalVectorArrayListImplDelegateField;

		// Token: 0x04001551 RID: 5457
		private static readonly CommandBuffer.SetGlobalMatrixArrayListImplDelegate SetGlobalMatrixArrayListImplDelegateField;

		// Token: 0x04001552 RID: 5458
		private static readonly CommandBuffer.SetGlobalFloatArrayDelegate SetGlobalFloatArrayDelegateField;

		// Token: 0x04001553 RID: 5459
		private static readonly CommandBuffer.SetGlobalVectorArrayDelegate SetGlobalVectorArrayDelegateField;

		// Token: 0x04001554 RID: 5460
		private static readonly CommandBuffer.SetGlobalMatrixArrayDelegate SetGlobalMatrixArrayDelegateField;

		// Token: 0x04001555 RID: 5461
		private static readonly CommandBuffer.SetLateLatchProjectionMatricesDelegate SetLateLatchProjectionMatricesDelegateField;

		// Token: 0x04001556 RID: 5462
		private static readonly CommandBuffer.MarkLateLatchMatrixShaderPropertyIDDelegate MarkLateLatchMatrixShaderPropertyIDDelegateField;

		// Token: 0x04001557 RID: 5463
		private static readonly CommandBuffer.UnmarkLateLatchMatrixDelegate UnmarkLateLatchMatrixDelegateField;

		// Token: 0x04001558 RID: 5464
		private static readonly CommandBuffer.SetGlobalBufferInternalDelegate SetGlobalBufferInternalDelegateField;

		// Token: 0x04001559 RID: 5465
		private static readonly CommandBuffer.SetGlobalGraphicsBufferInternalDelegate SetGlobalGraphicsBufferInternalDelegateField;

		// Token: 0x0400155A RID: 5466
		private static readonly CommandBuffer.SetShadowSamplingMode_ImplDelegate SetShadowSamplingMode_ImplDelegateField;

		// Token: 0x0400155B RID: 5467
		private static readonly CommandBuffer.IssuePluginEventInternalDelegate IssuePluginEventInternalDelegateField;

		// Token: 0x0400155C RID: 5468
		private static readonly CommandBuffer.BeginSample_CustomSamplerDelegate BeginSample_CustomSamplerDelegateField;

		// Token: 0x0400155D RID: 5469
		private static readonly CommandBuffer.EndSample_CustomSamplerDelegate EndSample_CustomSamplerDelegateField;

		// Token: 0x0400155E RID: 5470
		private static readonly CommandBuffer.IssuePluginEventAndDataInternalDelegate IssuePluginEventAndDataInternalDelegateField;

		// Token: 0x0400155F RID: 5471
		private static readonly CommandBuffer.IssuePluginCustomBlitInternalDelegate IssuePluginCustomBlitInternalDelegateField;

		// Token: 0x04001560 RID: 5472
		private static readonly CommandBuffer.IssuePluginCustomTextureUpdateInternalDelegate IssuePluginCustomTextureUpdateInternalDelegateField;

		// Token: 0x04001561 RID: 5473
		private static readonly CommandBuffer.SetGlobalConstantBufferInternalDelegate SetGlobalConstantBufferInternalDelegateField;

		// Token: 0x04001562 RID: 5474
		private static readonly CommandBuffer.SetGlobalConstantGraphicsBufferInternalDelegate SetGlobalConstantGraphicsBufferInternalDelegateField;

		// Token: 0x04001563 RID: 5475
		private static readonly CommandBuffer.SetInstanceMultiplierDelegate SetInstanceMultiplierDelegateField;

		// Token: 0x04001564 RID: 5476
		private static readonly CommandBuffer.InternalSetComputeBufferNativeDataDelegate InternalSetComputeBufferNativeDataDelegateField;

		// Token: 0x04001565 RID: 5477
		private static readonly CommandBuffer.InternalSetComputeBufferDataDelegate InternalSetComputeBufferDataDelegateField;

		// Token: 0x04001566 RID: 5478
		private static readonly CommandBuffer.SetComputeBufferCounterValueDelegate SetComputeBufferCounterValueDelegateField;

		// Token: 0x04001567 RID: 5479
		private static readonly CommandBuffer.ConvertTexture_Internal_InjectedDelegate ConvertTexture_Internal_InjectedDelegateField;

		// Token: 0x04001568 RID: 5480
		private static readonly CommandBuffer.SetComputeMatrixParam_InjectedDelegate SetComputeMatrixParam_InjectedDelegateField;

		// Token: 0x04001569 RID: 5481
		private static readonly CommandBuffer.Internal_SetRayTracingVectorParam_InjectedDelegate Internal_SetRayTracingVectorParam_InjectedDelegateField;

		// Token: 0x0400156A RID: 5482
		private static readonly CommandBuffer.Internal_SetRayTracingMatrixParam_InjectedDelegate Internal_SetRayTracingMatrixParam_InjectedDelegateField;

		// Token: 0x0400156B RID: 5483
		private static readonly CommandBuffer.Internal_BuildRayTracingAccelerationStructure_InjectedDelegate Internal_BuildRayTracingAccelerationStructure_InjectedDelegateField;

		// Token: 0x0400156C RID: 5484
		private static readonly CommandBuffer.Internal_GenerateMips_InjectedDelegate Internal_GenerateMips_InjectedDelegateField;

		// Token: 0x0400156D RID: 5485
		private static readonly CommandBuffer.Internal_DrawProcedural_InjectedDelegate Internal_DrawProcedural_InjectedDelegateField;

		// Token: 0x0400156E RID: 5486
		private static readonly CommandBuffer.Internal_DrawProceduralIndexed_InjectedDelegate Internal_DrawProceduralIndexed_InjectedDelegateField;

		// Token: 0x0400156F RID: 5487
		private static readonly CommandBuffer.Internal_DrawProceduralIndirect_InjectedDelegate Internal_DrawProceduralIndirect_InjectedDelegateField;

		// Token: 0x04001570 RID: 5488
		private static readonly CommandBuffer.Internal_DrawProceduralIndexedIndirect_InjectedDelegate Internal_DrawProceduralIndexedIndirect_InjectedDelegateField;

		// Token: 0x04001571 RID: 5489
		private static readonly CommandBuffer.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField;

		// Token: 0x04001572 RID: 5490
		private static readonly CommandBuffer.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField;

		// Token: 0x04001573 RID: 5491
		private static readonly CommandBuffer.Internal_DrawOcclusionMesh_InjectedDelegate Internal_DrawOcclusionMesh_InjectedDelegateField;

		// Token: 0x04001574 RID: 5492
		private static readonly CommandBuffer.EnableScissorRect_InjectedDelegate EnableScissorRect_InjectedDelegateField;

		// Token: 0x04001575 RID: 5493
		private static readonly CommandBuffer.SetGlobalColor_InjectedDelegate SetGlobalColor_InjectedDelegateField;

		// Token: 0x04001576 RID: 5494
		private static readonly CommandBuffer.SetGlobalMatrix_InjectedDelegate SetGlobalMatrix_InjectedDelegateField;

		// Token: 0x04001577 RID: 5495
		private static readonly CommandBuffer.SetViewMatrix_InjectedDelegate SetViewMatrix_InjectedDelegateField;

		// Token: 0x04001578 RID: 5496
		private static readonly CommandBuffer.SetProjectionMatrix_InjectedDelegate SetProjectionMatrix_InjectedDelegateField;

		// Token: 0x04001579 RID: 5497
		private static readonly CommandBuffer.SetViewProjectionMatrices_InjectedDelegate SetViewProjectionMatrices_InjectedDelegateField;

		// Token: 0x0400157A RID: 5498
		private static readonly CommandBuffer.IncrementUpdateCount_InjectedDelegate IncrementUpdateCount_InjectedDelegateField;

		// Token: 0x0400157B RID: 5499
		private static readonly CommandBuffer.SetRenderTargetColorDepthSubtarget_InjectedDelegate SetRenderTargetColorDepthSubtarget_InjectedDelegateField;

		// Token: 0x0400157C RID: 5500
		private static readonly CommandBuffer.SetRenderTargetMultiSubtarget_InjectedDelegate SetRenderTargetMultiSubtarget_InjectedDelegateField;

		// Token: 0x0400157D RID: 5501
		private static readonly CommandBuffer.Internal_ProcessVTFeedback_InjectedDelegate Internal_ProcessVTFeedback_InjectedDelegateField;

		// Token: 0x02000965 RID: 2405
		// (Invoke) Token: 0x0600315F RID: 12639
		private delegate void WaitAllAsyncReadbackRequestsDelegate(IntPtr @this);

		// Token: 0x02000966 RID: 2406
		// (Invoke) Token: 0x06003161 RID: 12641
		private delegate void SetInvertCullingDelegate(IntPtr @this, bool invertCulling);

		// Token: 0x02000967 RID: 2407
		// (Invoke) Token: 0x06003163 RID: 12643
		private delegate IntPtr CreateGPUFence_InternalDelegate(IntPtr @this, GraphicsFenceType fenceType, SynchronisationStageFlags stage);

		// Token: 0x02000968 RID: 2408
		// (Invoke) Token: 0x06003165 RID: 12645
		private delegate void WaitOnGPUFence_InternalDelegate(IntPtr @this, IntPtr fencePtr, SynchronisationStageFlags stage);

		// Token: 0x02000969 RID: 2409
		// (Invoke) Token: 0x06003167 RID: 12647
		private delegate void SetComputeFloatParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, float val);

		// Token: 0x0200096A RID: 2410
		// (Invoke) Token: 0x06003169 RID: 12649
		private delegate void SetComputeIntParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, int val);

		// Token: 0x0200096B RID: 2411
		// (Invoke) Token: 0x0600316B RID: 12651
		private delegate void SetComputeVectorArrayParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr values);

		// Token: 0x0200096C RID: 2412
		// (Invoke) Token: 0x0600316D RID: 12653
		private delegate void SetComputeMatrixArrayParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr values);

		// Token: 0x0200096D RID: 2413
		// (Invoke) Token: 0x0600316F RID: 12655
		private delegate void Internal_SetComputeIntsDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr values);

		// Token: 0x0200096E RID: 2414
		// (Invoke) Token: 0x06003171 RID: 12657
		private delegate void Internal_SetComputeGraphicsBufferParamDelegate(IntPtr @this, IntPtr computeShader, int kernelIndex, int nameID, IntPtr buffer);

		// Token: 0x0200096F RID: 2415
		// (Invoke) Token: 0x06003173 RID: 12659
		private delegate void Internal_SetComputeConstantComputeBufferParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000970 RID: 2416
		// (Invoke) Token: 0x06003175 RID: 12661
		private delegate void Internal_SetComputeConstantGraphicsBufferParamDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000971 RID: 2417
		// (Invoke) Token: 0x06003177 RID: 12663
		private delegate void Internal_DispatchComputeIndirectDelegate(IntPtr @this, IntPtr computeShader, int kernelIndex, IntPtr indirectBuffer, uint argsOffset);

		// Token: 0x02000972 RID: 2418
		// (Invoke) Token: 0x06003179 RID: 12665
		private delegate void Internal_DispatchComputeIndirectGraphicsBufferDelegate(IntPtr @this, IntPtr computeShader, int kernelIndex, IntPtr indirectBuffer, uint argsOffset);

		// Token: 0x02000973 RID: 2419
		// (Invoke) Token: 0x0600317B RID: 12667
		private delegate void Internal_SetRayTracingBufferParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr buffer);

		// Token: 0x02000974 RID: 2420
		// (Invoke) Token: 0x0600317D RID: 12669
		private delegate void Internal_SetRayTracingConstantComputeBufferParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000975 RID: 2421
		// (Invoke) Token: 0x0600317F RID: 12671
		private delegate void Internal_SetRayTracingConstantGraphicsBufferParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000976 RID: 2422
		// (Invoke) Token: 0x06003181 RID: 12673
		private delegate void Internal_SetRayTracingTextureParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr rt);

		// Token: 0x02000977 RID: 2423
		// (Invoke) Token: 0x06003183 RID: 12675
		private delegate void Internal_SetRayTracingFloatParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, float val);

		// Token: 0x02000978 RID: 2424
		// (Invoke) Token: 0x06003185 RID: 12677
		private delegate void Internal_SetRayTracingIntParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, int val);

		// Token: 0x02000979 RID: 2425
		// (Invoke) Token: 0x06003187 RID: 12679
		private delegate void Internal_SetRayTracingVectorArrayParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr values);

		// Token: 0x0200097A RID: 2426
		// (Invoke) Token: 0x06003189 RID: 12681
		private delegate void Internal_SetRayTracingMatrixArrayParamDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr values);

		// Token: 0x0200097B RID: 2427
		// (Invoke) Token: 0x0600318B RID: 12683
		private delegate void Internal_SetRayTracingFloatsDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr values);

		// Token: 0x0200097C RID: 2428
		// (Invoke) Token: 0x0600318D RID: 12685
		private delegate void Internal_SetRayTracingIntsDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr values);

		// Token: 0x0200097D RID: 2429
		// (Invoke) Token: 0x0600318F RID: 12687
		private delegate void Internal_SetRayTracingAccelerationStructureDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr accelerationStructure);

		// Token: 0x0200097E RID: 2430
		// (Invoke) Token: 0x06003191 RID: 12689
		private delegate void SetRayTracingShaderPassDelegate(IntPtr @this, IntPtr rayTracingShader, IntPtr passName);

		// Token: 0x0200097F RID: 2431
		// (Invoke) Token: 0x06003193 RID: 12691
		private delegate void Internal_DispatchRaysDelegate(IntPtr @this, IntPtr rayTracingShader, IntPtr rayGenShaderName, uint width, uint height, uint depth, IntPtr camera);

		// Token: 0x02000980 RID: 2432
		// (Invoke) Token: 0x06003195 RID: 12693
		private delegate void Internal_ResolveAntiAliasedSurfaceDelegate(IntPtr @this, IntPtr rt, IntPtr target);

		// Token: 0x02000981 RID: 2433
		// (Invoke) Token: 0x06003197 RID: 12695
		private delegate void CopyCounterValueCCDelegate(IntPtr @this, IntPtr src, IntPtr dst, uint dstOffsetBytes);

		// Token: 0x02000982 RID: 2434
		// (Invoke) Token: 0x06003199 RID: 12697
		private delegate void CopyCounterValueGCDelegate(IntPtr @this, IntPtr src, IntPtr dst, uint dstOffsetBytes);

		// Token: 0x02000983 RID: 2435
		// (Invoke) Token: 0x0600319B RID: 12699
		private delegate void CopyCounterValueCGDelegate(IntPtr @this, IntPtr src, IntPtr dst, uint dstOffsetBytes);

		// Token: 0x02000984 RID: 2436
		// (Invoke) Token: 0x0600319D RID: 12701
		private delegate void CopyCounterValueGGDelegate(IntPtr @this, IntPtr src, IntPtr dst, uint dstOffsetBytes);

		// Token: 0x02000985 RID: 2437
		// (Invoke) Token: 0x0600319F RID: 12703
		private delegate IntPtr get_nameDelegate(IntPtr @this);

		// Token: 0x02000986 RID: 2438
		// (Invoke) Token: 0x060031A1 RID: 12705
		private delegate int get_sizeInBytesDelegate(IntPtr @this);

		// Token: 0x02000987 RID: 2439
		// (Invoke) Token: 0x060031A3 RID: 12707
		private delegate void Internal_DrawRendererDelegate(IntPtr @this, IntPtr renderer, IntPtr material, int submeshIndex, int shaderPass);

		// Token: 0x02000988 RID: 2440
		// (Invoke) Token: 0x060031A5 RID: 12709
		private delegate void Internal_DrawMeshInstancedDelegate(IntPtr @this, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr matrices, int count, IntPtr properties);

		// Token: 0x02000989 RID: 2441
		// (Invoke) Token: 0x060031A7 RID: 12711
		private delegate void Internal_DrawMeshInstancedProceduralDelegate(IntPtr @this, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, int count, IntPtr properties);

		// Token: 0x0200098A RID: 2442
		// (Invoke) Token: 0x060031A9 RID: 12713
		private delegate void Internal_DrawMeshInstancedIndirectDelegate(IntPtr @this, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x0200098B RID: 2443
		// (Invoke) Token: 0x060031AB RID: 12715
		private delegate void Internal_DrawMeshInstancedIndirectGraphicsBufferDelegate(IntPtr @this, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x0200098C RID: 2444
		// (Invoke) Token: 0x060031AD RID: 12717
		private delegate void SetRandomWriteTarget_TextureDelegate(IntPtr @this, int index, IntPtr rt);

		// Token: 0x0200098D RID: 2445
		// (Invoke) Token: 0x060031AF RID: 12719
		private delegate void SetRandomWriteTarget_BufferDelegate(IntPtr @this, int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x0200098E RID: 2446
		// (Invoke) Token: 0x060031B1 RID: 12721
		private delegate void SetRandomWriteTarget_GraphicsBufferDelegate(IntPtr @this, int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x0200098F RID: 2447
		// (Invoke) Token: 0x060031B3 RID: 12723
		private delegate void ClearRandomWriteTargetsDelegate(IntPtr @this);

		// Token: 0x02000990 RID: 2448
		// (Invoke) Token: 0x060031B5 RID: 12725
		private delegate void DisableScissorRectDelegate(IntPtr @this);

		// Token: 0x02000991 RID: 2449
		// (Invoke) Token: 0x060031B7 RID: 12727
		private delegate void GetTemporaryRTArrayDelegate(IntPtr @this, int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, bool useDynamicScale);

		// Token: 0x02000992 RID: 2450
		// (Invoke) Token: 0x060031B9 RID: 12729
		private delegate void SetGlobalIntDelegate(IntPtr @this, int nameID, int value);

		// Token: 0x02000993 RID: 2451
		// (Invoke) Token: 0x060031BB RID: 12731
		private delegate void SetGlobalDepthBiasDelegate(IntPtr @this, float bias, float slopeBias);

		// Token: 0x02000994 RID: 2452
		// (Invoke) Token: 0x060031BD RID: 12733
		private delegate void SetExecutionFlagsDelegate(IntPtr @this, CommandBufferExecutionFlags flags);

		// Token: 0x02000995 RID: 2453
		// (Invoke) Token: 0x060031BF RID: 12735
		private delegate void SetGlobalFloatArrayListImplDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000996 RID: 2454
		// (Invoke) Token: 0x060031C1 RID: 12737
		private delegate void SetGlobalVectorArrayListImplDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000997 RID: 2455
		// (Invoke) Token: 0x060031C3 RID: 12739
		private delegate void SetGlobalMatrixArrayListImplDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000998 RID: 2456
		// (Invoke) Token: 0x060031C5 RID: 12741
		private delegate void SetGlobalFloatArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000999 RID: 2457
		// (Invoke) Token: 0x060031C7 RID: 12743
		private delegate void SetGlobalVectorArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x0200099A RID: 2458
		// (Invoke) Token: 0x060031C9 RID: 12745
		private delegate void SetGlobalMatrixArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x0200099B RID: 2459
		// (Invoke) Token: 0x060031CB RID: 12747
		private delegate void SetLateLatchProjectionMatricesDelegate(IntPtr @this, IntPtr projectionMat);

		// Token: 0x0200099C RID: 2460
		// (Invoke) Token: 0x060031CD RID: 12749
		private delegate void MarkLateLatchMatrixShaderPropertyIDDelegate(IntPtr @this, CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);

		// Token: 0x0200099D RID: 2461
		// (Invoke) Token: 0x060031CF RID: 12751
		private delegate void UnmarkLateLatchMatrixDelegate(IntPtr @this, CameraLateLatchMatrixType matrixPropertyType);

		// Token: 0x0200099E RID: 2462
		// (Invoke) Token: 0x060031D1 RID: 12753
		private delegate void SetGlobalBufferInternalDelegate(IntPtr @this, int nameID, IntPtr value);

		// Token: 0x0200099F RID: 2463
		// (Invoke) Token: 0x060031D3 RID: 12755
		private delegate void SetGlobalGraphicsBufferInternalDelegate(IntPtr @this, int nameID, IntPtr value);

		// Token: 0x020009A0 RID: 2464
		// (Invoke) Token: 0x060031D5 RID: 12757
		private delegate void SetShadowSamplingMode_ImplDelegate(IntPtr @this, IntPtr shadowmap, ShadowSamplingMode mode);

		// Token: 0x020009A1 RID: 2465
		// (Invoke) Token: 0x060031D7 RID: 12759
		private delegate void IssuePluginEventInternalDelegate(IntPtr @this, IntPtr callback, int eventID);

		// Token: 0x020009A2 RID: 2466
		// (Invoke) Token: 0x060031D9 RID: 12761
		private delegate void BeginSample_CustomSamplerDelegate(IntPtr @this, IntPtr sampler);

		// Token: 0x020009A3 RID: 2467
		// (Invoke) Token: 0x060031DB RID: 12763
		private delegate void EndSample_CustomSamplerDelegate(IntPtr @this, IntPtr sampler);

		// Token: 0x020009A4 RID: 2468
		// (Invoke) Token: 0x060031DD RID: 12765
		private delegate void IssuePluginEventAndDataInternalDelegate(IntPtr @this, IntPtr callback, int eventID, IntPtr data);

		// Token: 0x020009A5 RID: 2469
		// (Invoke) Token: 0x060031DF RID: 12767
		private delegate void IssuePluginCustomBlitInternalDelegate(IntPtr @this, IntPtr callback, uint command, IntPtr source, IntPtr dest, uint commandParam, uint commandFlags);

		// Token: 0x020009A6 RID: 2470
		// (Invoke) Token: 0x060031E1 RID: 12769
		private delegate void IssuePluginCustomTextureUpdateInternalDelegate(IntPtr @this, IntPtr callback, IntPtr targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2);

		// Token: 0x020009A7 RID: 2471
		// (Invoke) Token: 0x060031E3 RID: 12771
		private delegate void SetGlobalConstantBufferInternalDelegate(IntPtr @this, IntPtr buffer, int nameID, int offset, int size);

		// Token: 0x020009A8 RID: 2472
		// (Invoke) Token: 0x060031E5 RID: 12773
		private delegate void SetGlobalConstantGraphicsBufferInternalDelegate(IntPtr @this, IntPtr buffer, int nameID, int offset, int size);

		// Token: 0x020009A9 RID: 2473
		// (Invoke) Token: 0x060031E7 RID: 12775
		private delegate void SetInstanceMultiplierDelegate(IntPtr @this, uint multiplier);

		// Token: 0x020009AA RID: 2474
		// (Invoke) Token: 0x060031E9 RID: 12777
		private delegate void InternalSetComputeBufferNativeDataDelegate(IntPtr @this, IntPtr buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x020009AB RID: 2475
		// (Invoke) Token: 0x060031EB RID: 12779
		private delegate void InternalSetComputeBufferDataDelegate(IntPtr @this, IntPtr buffer, IntPtr data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x020009AC RID: 2476
		// (Invoke) Token: 0x060031ED RID: 12781
		private delegate void SetComputeBufferCounterValueDelegate(IntPtr @this, IntPtr buffer, uint counterValue);

		// Token: 0x020009AD RID: 2477
		// (Invoke) Token: 0x060031EF RID: 12783
		private delegate void ConvertTexture_Internal_InjectedDelegate(IntPtr @this, IntPtr src, int srcElement, IntPtr dst, int dstElement);

		// Token: 0x020009AE RID: 2478
		// (Invoke) Token: 0x060031F1 RID: 12785
		private delegate void SetComputeMatrixParam_InjectedDelegate(IntPtr @this, IntPtr computeShader, int nameID, IntPtr val);

		// Token: 0x020009AF RID: 2479
		// (Invoke) Token: 0x060031F3 RID: 12787
		private delegate void Internal_SetRayTracingVectorParam_InjectedDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr val);

		// Token: 0x020009B0 RID: 2480
		// (Invoke) Token: 0x060031F5 RID: 12789
		private delegate void Internal_SetRayTracingMatrixParam_InjectedDelegate(IntPtr @this, IntPtr rayTracingShader, int nameID, IntPtr val);

		// Token: 0x020009B1 RID: 2481
		// (Invoke) Token: 0x060031F7 RID: 12791
		private delegate void Internal_BuildRayTracingAccelerationStructure_InjectedDelegate(IntPtr @this, IntPtr accelerationStructure, IntPtr relativeOrigin);

		// Token: 0x020009B2 RID: 2482
		// (Invoke) Token: 0x060031F9 RID: 12793
		private delegate void Internal_GenerateMips_InjectedDelegate(IntPtr @this, IntPtr rt);

		// Token: 0x020009B3 RID: 2483
		// (Invoke) Token: 0x060031FB RID: 12795
		private delegate void Internal_DrawProcedural_InjectedDelegate(IntPtr @this, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, IntPtr properties);

		// Token: 0x020009B4 RID: 2484
		// (Invoke) Token: 0x060031FD RID: 12797
		private delegate void Internal_DrawProceduralIndexed_InjectedDelegate(IntPtr @this, IntPtr indexBuffer, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, IntPtr properties);

		// Token: 0x020009B5 RID: 2485
		// (Invoke) Token: 0x060031FF RID: 12799
		private delegate void Internal_DrawProceduralIndirect_InjectedDelegate(IntPtr @this, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x020009B6 RID: 2486
		// (Invoke) Token: 0x06003201 RID: 12801
		private delegate void Internal_DrawProceduralIndexedIndirect_InjectedDelegate(IntPtr @this, IntPtr indexBuffer, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x020009B7 RID: 2487
		// (Invoke) Token: 0x06003203 RID: 12803
		private delegate void Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate(IntPtr @this, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x020009B8 RID: 2488
		// (Invoke) Token: 0x06003205 RID: 12805
		private delegate void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate(IntPtr @this, IntPtr indexBuffer, IntPtr matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties);

		// Token: 0x020009B9 RID: 2489
		// (Invoke) Token: 0x06003207 RID: 12807
		private delegate void Internal_DrawOcclusionMesh_InjectedDelegate(IntPtr @this, IntPtr normalizedCamViewport);

		// Token: 0x020009BA RID: 2490
		// (Invoke) Token: 0x06003209 RID: 12809
		private delegate void EnableScissorRect_InjectedDelegate(IntPtr @this, IntPtr scissor);

		// Token: 0x020009BB RID: 2491
		// (Invoke) Token: 0x0600320B RID: 12811
		private delegate void SetGlobalColor_InjectedDelegate(IntPtr @this, int nameID, IntPtr value);

		// Token: 0x020009BC RID: 2492
		// (Invoke) Token: 0x0600320D RID: 12813
		private delegate void SetGlobalMatrix_InjectedDelegate(IntPtr @this, int nameID, IntPtr value);

		// Token: 0x020009BD RID: 2493
		// (Invoke) Token: 0x0600320F RID: 12815
		private delegate void SetViewMatrix_InjectedDelegate(IntPtr @this, IntPtr view);

		// Token: 0x020009BE RID: 2494
		// (Invoke) Token: 0x06003211 RID: 12817
		private delegate void SetProjectionMatrix_InjectedDelegate(IntPtr @this, IntPtr proj);

		// Token: 0x020009BF RID: 2495
		// (Invoke) Token: 0x06003213 RID: 12819
		private delegate void SetViewProjectionMatrices_InjectedDelegate(IntPtr @this, IntPtr view, IntPtr proj);

		// Token: 0x020009C0 RID: 2496
		// (Invoke) Token: 0x06003215 RID: 12821
		private delegate void IncrementUpdateCount_InjectedDelegate(IntPtr @this, IntPtr dest);

		// Token: 0x020009C1 RID: 2497
		// (Invoke) Token: 0x06003217 RID: 12823
		private delegate void SetRenderTargetColorDepthSubtarget_InjectedDelegate(IntPtr @this, IntPtr color, IntPtr depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice);

		// Token: 0x020009C2 RID: 2498
		// (Invoke) Token: 0x06003219 RID: 12825
		private delegate void SetRenderTargetMultiSubtarget_InjectedDelegate(IntPtr @this, IntPtr colors, IntPtr depth, IntPtr colorLoadActions, IntPtr colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice);

		// Token: 0x020009C3 RID: 2499
		// (Invoke) Token: 0x0600321B RID: 12827
		private delegate void Internal_ProcessVTFeedback_InjectedDelegate(IntPtr @this, IntPtr rt, IntPtr resolver, int slice, int x, int width, int y, int height, int mip);
	}
}
